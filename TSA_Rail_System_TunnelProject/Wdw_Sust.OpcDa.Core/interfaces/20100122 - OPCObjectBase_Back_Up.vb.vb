Imports System.Collections.Generic
Imports System.Reflection
Imports System.ComponentModel
Imports System.Threading

Imports WDW_SUST.Textile.LINT.Core

Namespace Textile.LINT.OPC.Core
    ''' <summary>
    ''' All classes which work with OPC must inherit from this class
    ''' to make use of the OPCComm class
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class OPCObjectBase
        Implements IOPCObject

#Region "Fields"

        ''' <summary>
        ''' Gruop name to distinguish which group the PLC tag belongs to.
        ''' </summary>
        ''' <remarks></remarks>
        Private _groupName As String

        ''' <summary>
        ''' OPC topic name from RSLinx
        ''' </summary>
        ''' <remarks></remarks>
        Private _PLCName As String

        ''' <summary>
        ''' TagName of the item, which does not include the PLC name and does not
        ''' include the sub member names.
        ''' </summary>
        ''' <remarks></remarks>
        Private _tagName As String

        ''' <summary>
        ''' time stamp of the value change
        ''' </summary>
        ''' <remarks></remarks>
        Private _timeStamp As Date

        ''' <summary>
        ''' Dictionary(Of PLCTagName, Index)
        ''' </summary>
        ''' <remarks>String = PLC compliance tag name, Integer = property index</remarks>
        Private _listOfOPCTags As Dictionary(Of String, Integer) = Nothing

        Private _filterProperties As String() = Nothing

        Private _isRegisteringInProcess As Boolean = True

        Private _registeredItems As Integer = 0
        ''' <summary>
        ''' To be overriden by the derived class for specific filtering
        ''' </summary>
        ''' <remarks>Override SetPropertyFilter</remarks>
        Private _filterString As String = "Date,DateTime,Chars,"
        'Protected _filterString As String = "GroupName,PLCName,TagName,UniqueID,MicroSecond,ListOfOPCTags,Date,DateTime,TimeStamp,Chars,IsRegisteringInProgress,RegisterItems,Value,"

        Private _parent As IOPCObject
#End Region

#Region "Events"
        ''' <summary>
        ''' Properities are updated sucessfully. This can be used when you want to have action after the object properties are updated.
        ''' </summary>
        Public Event PropertiesUpdateCompleted(ByVal sender As IOPCObject, ByVal e As System.EventArgs) Implements IOPCObject.PropertiesUpdateCompleted
        ''' <summary>
        ''' This will only fire only when registration is completed. This can be used to initialize control
        ''' </summary>
        ''' <param name="sender">The object itself</param>
        ''' <param name="e">Dummy argument</param>
        ''' <remarks></remarks>
        Public Event ItemsRegisteringCompleted(ByVal sender As IOPCObject, ByVal e As System.EventArgs) Implements IOPCObject.ItemsRegisteringCompleted
        Public Event SyncWriteCompleted(ByVal sender As IOPCObject, ByVal e As System.EventArgs)
#End Region

#Region "Properties"
        ''' <summary>
        ''' Used to filter the property not needed for the OPC object class. This will optimize the OPC communication
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Private ReadOnly Property FilterProperties() As String()
            Get
                If Me._filterProperties Is Nothing Then Me._filterProperties = SetPropertyFilter(Me._filterString)
                Return _filterProperties
            End Get
        End Property
        ''' <summary>
        ''' Name of the group
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Public Property GroupName() As String Implements IOPCObject.GroupName
            Get
                Return _groupName
            End Get
            Set(ByVal value As String)
                _groupName = value
            End Set
        End Property
        ''' <summary>
        ''' Dictionary(Of PLCTagName, Index)
        ''' </summary>
        ''' <remarks>String = PLC compliance tag name, Integer = property index</remarks>
        <Attributes.NotConnectableOPCItem(), EditorBrowsable(EditorBrowsableState.Advanced), Browsable(False)> _
        Protected Friend ReadOnly Property ListOfPLCTags() As Dictionary(Of String, Integer)
            Get
                If Me._listOfOPCTags Is Nothing Then Me._listOfOPCTags = New Dictionary(Of String, Integer)
                Return _listOfOPCTags
            End Get
        End Property
        ''' <summary>
        ''' Topic Name of the PLC set up in RSLinx
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Public Property PLCName() As String Implements IOPCObject.PLCName
            Get
                'If Me._PLCName = String.Empty Then
                'Throw New ArgumentException("Please specify a PLC topic name!")
                'End If
                Return _PLCName
            End Get
            Set(ByVal value As String)
                _PLCName = value
            End Set
        End Property
        ''' <summary>
        ''' Name of the root tag name defined in the PLC
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Public Property TagName() As String Implements IOPCObject.TagName
            Get
                'If Me._tagName = String.Empty Then
                'Throw New ArgumentException("Please specify a tag name for the object!")
                'End If
                Return _tagName
            End Get
            Set(ByVal value As String)
                _tagName = value
            End Set
        End Property
        ''' <summary>
        ''' Time stamp raised the data change event for the item
        ''' </summary>
        <Attributes.NotConnectableOPCItem(), Browsable(False)> _
        Public Property TimeStamp() As Date Implements IOPCObject.TimeStamp
            Get
                Return _timeStamp
            End Get
            Set(ByVal value As Date)
                _timeStamp = value
            End Set
        End Property
        ''' <summary>
        ''' Property to reference to the OPCComm.Instance property. This will ensure that only one instance is defined at a time
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Protected ReadOnly Property OPC() As OPCComm
            Get
                Return OPCComm.Instance
            End Get
        End Property
        ''' <summary>
        ''' Keep track to see if the object is being initialize
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Friend ReadOnly Property IsRegisteringInProgress() As Boolean Implements IOPCObject.IsRegisteringInProgress
            Get
                Return _isRegisteringInProcess
            End Get
        End Property

        ''' <summary>
        ''' How many items have been connected to the OPC server and already got first data back from the PLC
        ''' </summary>
        ''' <value></value>
        ''' <returns>Number of items have been connected to the OPC server.</returns>
        ''' <remarks>If number of items back is greater than the list of PLC tags for the object, the ItemsRegisteringCompleted event is fire. 
        ''' This should only be fired once.</remarks>
        <Attributes.NotConnectableOPCItem()> _
        Friend Property RegisterItems() As Integer Implements IOPCObject.RegisterItems
            Get
                Return _registeredItems
            End Get
            Set(ByVal value As Integer)
                _registeredItems = value
                If _registeredItems >= Me.ListOfPLCTags.Count Then
                    Me._isRegisteringInProcess = False
                    Me._registeredItems = Nothing
                    RaiseEvent ItemsRegisteringCompleted(Me, New System.EventArgs)
                End If
            End Set
        End Property
        ''' <summary>
        ''' Used to cache tag definitions so that it is only generated once. This is a shared field
        ''' </summary>
        Private Shared _tagDefinitionCache As New Dictionary(Of Type, List(Of String))
#End Region

#Region "Methods"

#Region "Private"
        Friend Function GetPropertyIndex(ByVal PLCTagName As String) As Integer Implements IOPCObject.GetPropertyIndex
            Return Me.ListOfPLCTags(PLCTagName)
        End Function

        ''' <summary>
        ''' Used to filter out the properties which are not part of the opc item structure
        ''' </summary>
        ''' <param name="propertyName">Name of the property</param>
        ''' <returns>Boolean to indicate whether the property is pre-defined</returns>
        ''' <remarks></remarks>
        Private Function IsPreDefinedProperties(ByVal propertyName As String) As Boolean
            For Each s As String In Me.FilterProperties
                If s = propertyName Then
                    Return True
                End If
            Next
            Return False
        End Function

        ''' <summary>
        ''' Subrountine to break down the tag name to the element level
        ''' </summary>
        Private Sub TagNameBreakDown(ByRef names As List(Of String), ByVal publicProperty As PropertyInfo, Optional ByVal subTagName As String = "", Optional ByVal index As Integer = -1)
            'Check if the property of the object falls in the scope of WDW_SUST.dll
            If Not publicProperty.Module.ScopeName = "WDW_SUST.dll" Then
                Exit Sub
            End If
            'Check if the property is non-connectable opc item
            If Attribute.IsDefined(publicProperty, GetType(Attributes.NotConnectableOPCItemAttribute)) Then
                Exit Sub
            End If
            'Check if the property is predefined to be not connected
            If IsPreDefinedProperties(publicProperty.Name) Then
                Exit Sub
            End If

            If publicProperty.PropertyType.IsClass AndAlso publicProperty.PropertyType.FullName <> "System.String" Then
                If subTagName Is "" Then
                    If index > -1 Then
                        subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
                    Else
                        subTagName = String.Format("{0}", publicProperty.Name)
                    End If
                Else
                    subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
                End If
                Dim mySubType As Type = publicProperty.PropertyType
                Dim subPublicProperties() As PropertyInfo
                subPublicProperties = mySubType.GetProperties
                For i As Integer = 0 To subPublicProperties.Length - 1
                    TagNameBreakDown(names, subPublicProperties(i), subTagName)
                Next
                Exit Sub
            ElseIf subTagName Is "" Then
                If index > -1 Then
                    subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
                Else
                    subTagName = String.Format("{0}", publicProperty.Name)
                End If
            Else
                subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
            End If
            names.Add(subTagName)
        End Sub

#End Region

#Region "Public"
        ''' <summary>
        ''' Get the item value from the PLC.
        ''' </summary>
        ''' <param name="itemName">The is the name starting with the name of the property</param>
        Public Overridable Function GetItemValueFromPLC(ByVal itemName As String) As Object
            Dim plcTagName As String = Me.GetPLCTagName(itemName)
            For Each s As String In Me.ListOfPLCTags.Keys
                If s.Contains(plcTagName) Then
                    Return Me.OPC.GetItemValue(Me, itemName)
                End If
            Next
            Throw New Exception("Item is not defined or item name is incorrect!!")
        End Function

        ''' <summary>
        ''' Get number of opc items in the object
        ''' </summary>
        ''' <returns>Integer value of the count</returns>
        ''' <remarks></remarks>
        Public Function GetPLCTagCount() As Integer
            Return Me.ListOfPLCTags.Count
        End Function

        ''' <summary>
        ''' Get the tag name of a property in a class.
        ''' The format should be [PLCName]TagName.Property.SubProperty etc...
        ''' </summary>
        ''' <param name="itemName">Should not be included the TagName</param>
        ''' <returns>PLC compliance tag name</returns>
        ''' <remarks></remarks>
        Public Function GetPLCTagName(ByVal itemName As String) As String Implements IOPCObject.GetPLCTagName
            If Me.PLCName = "" OrElse IsNothing(Me.PLCName) Then
                Throw New Exception("No PLC Name Defined!!")
            End If
            If TypeOf (Me) Is OPCElement Then
                Return String.Format("[{0}]{1}", Me.PLCName, Me.TagName)
            Else
                Return String.Format("[{0}]{1}.{2}", Me.PLCName, Me.TagName, itemName)
            End If
        End Function

        ''' <summary>
        ''' Get the tag names in the opc item format
        ''' [PLCName]Item_Name.Sub_Item_Name
        ''' </summary>
        ''' <returns>List of opc items</returns>
        ''' <remarks></remarks> 
        Public Function GetPLCTagNames() As String() Implements IOPCObject.GetPLCTagNames
            If Me.PLCName = String.Empty Then
                Throw New Exception("PLC name is not defined!!")
            End If
            Dim names As New List(Of String)
            Dim s As String = ""
            'If this is OPCElemnt class, no need to use cache
            If Me.ListOfPLCTags.Count > 0 Then
                For Each k As String In Me.ListOfPLCTags.Keys
                    names.Add(k)
                Next
                Return names.ToArray
                'If this is an OPCElement
            ElseIf TypeOf Me Is OPCElement Then
                s = String.Format("[{0}]{1}", Me.PLCName, Me.TagName)
                'TODO: this needs to be seperated from GetPLCTagNames as it intends to return a list of plc tags
                Me.ListOfPLCTags.Add(s, 1)  ' OPCElement always has 1 index only
                names.Add(s)
#If DEBUG Then
                Console.WriteLine(String.Format("{0} ======== index {1}", s, 1))
#End If
                Return names.ToArray
                'If list of tags has already in the cache
            ElseIf OPCObjectBase._tagDefinitionCache.ContainsKey(Me.GetType) Then
                names = _tagDefinitionCache(Me.GetType)
                'If the list of the tags for the class has not been defined yet
            Else
                Dim publicProperties() As PropertyInfo
                Dim myType As Type = Me.GetType()
                publicProperties = myType.GetProperties()
                Dim para As ParameterInfo()
                Dim i As Integer
                For i = 0 To publicProperties.Length - 1
                    para = Nothing
                    para = publicProperties(i).GetIndexParameters()
                    If para.Length > 0 Then
                        Dim tempPropertyName As String = String.Format("{0}_ARRAY_SIZE", publicProperties(i).Name).ToUpper
                        Dim size As Integer = Me.GetType.GetField(tempPropertyName, BindingFlags.NonPublic AndAlso BindingFlags.IgnoreCase).GetValue(Me)
                        Dim base As Integer = 1
                        If Attribute.IsDefined(publicProperties(i), GetType(Attributes.ArrayBaseEqualsZeroAttribute)) Then
                            base = 0
                        End If
                        For j As Integer = base To (size - 1 + base)
                            TagNameBreakDown(names, publicProperties(i), , j)
                        Next
                    Else
                        TagNameBreakDown(names, publicProperties(i))
                    End If
                Next
                names.Sort()
                'Add this to the cache
                OPCObjectBase._tagDefinitionCache.Add(Me.GetType, names)
            End If
            Dim index As Integer = 1
            Dim tempList As New List(Of String)
            For Each s In names
                s = String.Format("[{0}]{1}.{2}", Me.PLCName, Me.TagName, s)
                tempList.Add(s)
                Me.ListOfPLCTags.Add(s, index)
#If DEBUG Then
                Console.WriteLine(String.Format("{0} ======== index {1}", s, index))
#End If
                index += 1
            Next
            Return tempList.ToArray
            tempList = Nothing
        End Function

        ''' <summary>
        ''' Must be overriden in the inherited class to reflect changes of the value from the PLC items
        ''' </summary>
        ''' <param name="index">The member functions must be in ascending alphabetical
        ''' order. The first index should be 1</param>
        ''' <param name="value">Value of the item. To avoid late binding, you should specify
        ''' what type of the value will return from the PLC</param>
        ''' <remarks></remarks>
        Protected MustOverride Sub ValueFromPLCToObject(ByVal index As Integer, ByVal value As Object) Implements IOPCObject.ValueFromPLCToObject

        ''' <summary>
        ''' Write the item value back to the PLC
        ''' </summary>
        ''' <param name="itemName">Name of the item to be written</param>
        ''' <param name="value">Value to be written</param>
        ''' <param name="asyncWrite">Is asyncWrite supported. Default is FALSE, which means that the value will be updated to
        ''' PLC immediately. If the value is TRUE, the value will NOT be 
        ''' updated to PLC until AsyncWrite(ByVal groupName As String) from OPCComm Class is called</param>
        ''' <remarks>tagName should be the name of the item. If the item is type of GlobalOPCElement
        ''' item name would be the tag name itself. Otherwise, the item name would be the item itself not 
        ''' including the tag name.</remarks>
        Public Sub ValueFromObjectToPLC(ByVal itemName As String, ByVal value As Object, Optional ByVal asyncWrite As Boolean = False) Implements IOPCObject.ValueFromObjectToPLC
            SyncLock Me
                If Not Me.IsRegisteringInProgress Then
                    Dim tempPLCTagName As String = Me.GetPLCTagName(itemName)
                    If asyncWrite Then
                        'Me.OPC.UpdateTagValue(tempPLCTagName, value)
                        If TypeOf value Is Boolean Then
                            If CType(value, Boolean) = True Then
                                Me.OPC.AddAsyncPendingItemToList(Me.GroupName, tempPLCTagName, 1)
                            Else
                                Me.OPC.AddAsyncPendingItemToList(Me.GroupName, tempPLCTagName, 0)
                            End If
                        Else
                            Me.OPC.AddAsyncPendingItemToList(Me.GroupName, tempPLCTagName, value)
                        End If
                        'Update the property value locally
                        'Me.ValueFromPLCToObject(Me.GetPropertyIndex(tempPLCTagName), value)
                    Else
                        'Update directly to PLC and wait for OPC data change event to update property value
                        Me.OPC.SetItemValue(Me.GroupName, tempPLCTagName, value)
                        RaiseEvent SyncWriteCompleted(Me, New System.EventArgs)
                    End If
                End If
            End SyncLock
        End Sub

        ''' <summary>
        ''' Create a copy of all values in the object
        ''' </summary>
        ''' <returns>A clone copy of the object</returns>
        ''' <remarks></remarks>
        Public Function ShallowClone() As IOPCObject Implements IOPCObject.ShallowClone
            Return Me.MemberwiseClone
        End Function
#End Region

#Region "Protected"
        ''' <summary>
        ''' Use to extend the filter to include any unnecessary items for the opc communication
        ''' in the class
        ''' </summary>
        ''' <param name="addedFilters">filter to be added</param>
        ''' <returns></returns>
        ''' <remarks>There is already a pre-defined filter already. If there are more items
        ''' needed to be removed, this function needs to be call</remarks>
        ''' <example>
        ''' <code>
        ''' Protected Overrides Function SetPropertyFilter(ByRef addedFilters As String) As String()
        '''     addedFilters += "Source_Washer,Recirculation_Destination,Estimated_Pieces,Soiled_Weight"
        '''     Return MyBase.SetPropertyFilter(addedFilters)
        ''' End Function
        ''' </code>
        ''' </example>
        Protected Overridable Function SetPropertyFilter(ByRef addedFilters As String) As String()
            Me._filterString = Me._filterString.Replace(" ", "")
            If Me._filterString.LastIndexOf(",") = Me._filterString.Length - 1 Then
                Me._filterString.Remove(Me._filterString.Length - 1, 1)
            End If
            Return Me._filterString.Split(",")
        End Function
        ''' <summary>
        ''' This is used to raise the property changed event from the OPCComm class
        ''' </summary>
        Friend Sub RaisePropertiesUpdatedEvent(ByVal e As System.EventArgs) Implements IOPCObject.RaisePropertiesUpdatedEvent
            RaiseEvent PropertiesUpdateCompleted(Me, e)
        End Sub

#End Region

#End Region

#Region "Constructors"

        Public Sub New(ByVal plcName As String, ByVal tagName As String, ByVal groupName As String)
            Me.PLCName = plcName
            Me.TagName = tagName
            Me.GroupName = groupName
            Me._parent = Me
        End Sub

        Public Sub New(ByVal plcName As String, ByVal tagName As String)
            Me.PLCName = plcName
            Me.TagName = tagName
            Me.GroupName = tagName
            Me._parent = Me
        End Sub

        ''' <summary>
        ''' This constructor is not for OPC communication but for object initialization
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            Me._parent = Me
        End Sub

        ''' <summary>
        ''' Used when the class is defined as a property to another opc item class
        ''' this will make sure that GroupName, TagName and PLCName are set properly
        ''' </summary>
        ''' <param name="parent">Parent class of the is class</param>
        ''' <remarks></remarks>
        Public Sub New(ByRef parent As IOPCObject, ByVal propertyName As String)
            Me._parent = parent
            Me.GroupName = Me._parent.GroupName
            Me.TagName = String.Format("{0}.{1}", Me._parent.TagName, propertyName)
            Me.PLCName = Me._parent.PLCName
        End Sub

#End Region

    End Class
End Namespace
