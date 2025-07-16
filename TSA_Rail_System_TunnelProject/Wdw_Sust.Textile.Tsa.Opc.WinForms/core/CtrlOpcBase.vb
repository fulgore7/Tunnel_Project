Imports System.ComponentModel

Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.OpcDa.Core.Ab

Namespace Core
    ''' <summary>
    ''' Abstract class for all the opc objects to share. Do not use this class by itself. This 
    ''' class should be treated as "MustInherits" class
    ''' </summary>
    ''' <remarks></remarks>
    Public Class CtrlOpcBase
        Inherits CtrlUserControlBase
        Implements IOpcObject, ICustomObject, IHaveOpcObjects

#Region "Fields"
        Private Shared ReadOnly _tagDefinitionCache As New Dictionary(Of Type, List(Of String))()
        ''' <summary>
        ''' time stamp of the value change
        ''' </summary>
        ''' <remarks></remarks>
        Private _timeStamp As Date

        ''' <summary>
        ''' Dictionary(Of PLCTagName, Index)
        ''' </summary>
        ''' <remarks>String = PLC compliance tag name, Integer = property index</remarks>
        Private _listOfOPCTags As Dictionary(Of String, Integer)

        Private _filterProperties As String()

        Private _isRegisteringInProcess As Boolean = True

        Private _registeredItems As Integer
        ''' <summary>
        ''' To be overridden by the derived class for specific filtering
        ''' </summary>
        ''' <remarks>Override SetPropertyFilter</remarks>
        Private _filterString As String = "Date,DateTime,Chars,"
        Private _parent As IOpcObject
        Protected _opc As OpcComm

#End Region

#Region "Events"
        ''' <summary>
        ''' Properties are updated successfully. This can be used when you want to have action after the object properties are updated.
        ''' </summary>
        Public Event PropertiesUpdateCompleted(ByVal sender As IOpcObject, ByVal e As System.EventArgs) Implements IOpcObject.PropertiesUpdateCompleted
        Public Event ItemsRegisteringCompleted(ByVal sender As IOpcObject, ByVal e As System.EventArgs) Implements IOpcObject.ItemsRegisteringCompleted
        Public Event SyncWriteCompleted(ByVal sender As IOpcObject, ByVal e As System.EventArgs)
#End Region

#Region "Properties"
        Protected ReadOnly Property Opc As OpcComm
            Get
                If _opc Is Nothing Then
                    _opc = OpcComm.Instance
                End If
                Return _opc
            End get
        End property
        ''' <summary>
        ''' Gets the filter properties.
        ''' </summary>
        ''' <value>The filter properties.</value>
        <NotConnectableOpcItem()>
        Private ReadOnly Property FilterProperties() As String() Implements IOpcObject.FilterProperties
            Get
                If _filterProperties Is Nothing Then _filterProperties = SetPropertyFilter(_filterString)
                Return _filterProperties
            End Get
        End Property

        ''' <summary>
        ''' Group name to distinguish which group the PLC tag belongs to.
        ''' </summary>
        ''' <remarks></remarks>
        <NotConnectableOpcItem(), Category("Custom Object Properties"), Bindable(True)>
        Public Property GroupName() As String Implements IOpcObject.GroupName

        ''' <summary>
        ''' Dictionary(Of PLCTagName, Index)
        ''' </summary>
        ''' <remarks>String = PLC compliance tag name, Integer = property index</remarks>
        <NotConnectableOpcItem(), Browsable(False)>
        Private ReadOnly Property ListOfOpcTags() As Dictionary(Of String, Integer) Implements IOpcObject.ListOfOpcTags
            Get
                If _listOfOPCTags Is Nothing Then _listOfOPCTags = New Dictionary(Of String, Integer)
                Return _listOfOPCTags
            End Get
        End Property

        ''' <summary>
        ''' OPC topic name from RSLinx
        ''' </summary>
        ''' <remarks></remarks>
        <NotConnectableOpcItem(), Category("Custom Object Properties"), Bindable(True)>
        Public Property PlcName() As String Implements IOpcObject.PlcName

        ''' <summary>
        ''' TagName of the item, which does not include the PLC name and does not
        ''' include the sub member names.
        ''' </summary>
        ''' <remarks></remarks>
        <NotConnectableOpcItem(), Category("Custom Object Properties")>
        Public Overridable Property TagName() As String Implements IOpcObject.TagName, ICustomObject.ObjectIdentifier

        <NotConnectableOpcItem(), Browsable(False)>
        Friend Property TimeStamp() As Date Implements IOpcObject.TimeStamp
            Get
                Return _timeStamp
            End Get
            Set(ByVal value As Date)
                _timeStamp = value
            End Set
        End Property

        '<NotConnectableOPCItem(), Browsable(False)> _
        'Protected Shared ReadOnly Property OPC() As OPCComm
        '    Get
        '        Return OPCComm.Instance
        '    End Get
        'End Property

        <NotConnectableOpcItem(), Browsable(False)>
        Friend ReadOnly Property IsRegisteringInProgress() As Boolean Implements IOpcObject.IsRegisteringInProgress
            Get
                Return _isRegisteringInProcess
            End Get
        End Property

        <NotConnectableOpcItem(), Browsable(False)>
        Friend Property RegisterItems() As Integer Implements IOpcObject.RegisterItems
            Get
                Return _registeredItems
            End Get
            Set(ByVal value As Integer)
                _registeredItems = value
                If _registeredItems >= ListOfOpcTags.Count Then
                    _isRegisteringInProcess = False
                    _registeredItems = Nothing
                    RaiseEvent ItemsRegisteringCompleted(Me, System.EventArgs.Empty)
                End If
            End Set
        End Property
#End Region

#Region "Methods"

#Region "Private"

        ''' <summary>
        ''' Gets the index of the property on the list.
        ''' </summary>
        ''' <param name="tagName">Name of the tag.</param>
        ''' <returns>System.Int32.</returns>
        Friend Function GetPropertyIndex(ByVal tagName As String) As Integer Implements IOpcObject.GetPropertyIndex
            Return ListOfOpcTags(tagName)
        End Function

        ''' <summary>
        ''' Used to filter out the properties which are not part of the opc item structure
        ''' </summary>
        ''' <param name="propertyName">Name of the property</param>
        ''' <returns>Boolean to indicate whether the property is pre-defined</returns>
        ''' <remarks></remarks>
        Private Function IsPreDefinedProperties(ByVal propertyName As String) As Boolean
            For Each s As String In FilterProperties
                If s = propertyName Then
                    Return True
                End If
            Next
            Return False
        End Function

        'Private Sub TagNameBreakDown(ByRef names As List(Of String), ByVal publicProperty As PropertyInfo, Optional ByVal subTagName As String = "", Optional ByVal index As Integer = -1)
        '    If Not publicProperty.Module.ScopeName.ToLower.StartsWith("wdw_sust") Then
        '        Exit Sub
        '    End If
        '    If Attribute.IsDefined(publicProperty, GetType(NotConnectableOpcItemAttribute)) Then
        '        Exit Sub
        '    End If
        '    If IsPreDefinedProperties(publicProperty.Name) Then
        '        Exit Sub
        '    End If
        '    If publicProperty.PropertyType.IsClass AndAlso
        '       publicProperty.PropertyType.FullName <> "System.String" Then
        '        If subTagName Is "" Then
        '            If index > -1 Then
        '                subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
        '            Else
        '                subTagName = String.Format("{0}", publicProperty.Name)
        '            End If
        '        Else
        '            subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
        '        End If
        '        Dim mySubType As Type = publicProperty.PropertyType
        '        Dim subPublicProperties() As PropertyInfo
        '        subPublicProperties = mySubType.GetProperties
        '        For i As Integer = 0 To subPublicProperties.Length - 1
        '            TagNameBreakDown(names, subPublicProperties(i), subTagName)
        '        Next
        '        Exit Sub
        '    ElseIf subTagName Is "" Then
        '        If index > -1 Then
        '            subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
        '        Else
        '            subTagName = String.Format("{0}", publicProperty.Name)
        '        End If
        '    Else
        '        subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
        '    End If
        '    names.Add(subTagName)
        'End Sub

#End Region

#Region "Public"
        Public Overridable Function GetItemValueFromPlc(ByVal itemName As String) As Object
            For Each s As String In ListOfOpcTags.Keys
                If s.Contains(itemName) Then
                    Return Opc.GetItemValue(Me, itemName)
                End If
            Next
            Throw New Exception("Item is not defined or item name is defined incorrectly!!")
        End Function

        ''' <summary>
        ''' Get number of opc items in the object
        ''' </summary>
        ''' <returns>Integer value of the count</returns>
        ''' <remarks></remarks>
        Public Function GetPlcTagCount() As Integer
            Return ListOfOpcTags.Count
        End Function

        ''' <summary>
        ''' This is used to get the tag name of a property in a class.
        ''' The format should be [PLCName]TagName.Property.SubProperty etc...
        ''' </summary>
        ''' <param name="itemName">Should not be included the TagName</param>
        ''' <returns>PLC compliance tag name</returns>
        ''' <remarks></remarks>
        Public Function GetPlcTagName(ByVal itemName As String) As String Implements IOpcObject.GetPlcTagName
            If PlcName = "" OrElse IsNothing(PlcName) Then
                Throw New Exception("No PLC Name Defined!!")
            End If
            If TypeOf (Me) Is IOpcElementControl Then
                Return String.Format("[{0}]{1}", PlcName, TagName)
            Else
                Return String.Format("[{0}]{1}.{2}", PlcName, TagName, itemName)
            End If
        End Function

        ''' <summary>
        ''' Get the tag names in the opc item format
        ''' [PLCName]Item_Name.Sub_Item_Name
        ''' </summary>
        ''' <returns>List of opc items</returns>
        ''' <remarks></remarks> 
        Public Function GetPlcTagNames() As String() Implements IOpcObject.GetPlcTagNames
            Return RslinxOpcDaSettings.TagGenerator.GenerateOpcTags(Me)
        End Function

        'Protected Overridable Sub AddTagDefinitionCache(ByVal tags As List(Of String))
        '    CtrlOpcBase._tagDefinitionCache.Add(Me.GetType, tags)
        'End Sub

        ''' <summary>
        ''' Write the item value back to the PLC
        ''' </summary>
        ''' <param name="itemName">Name of the item to be written</param>
        ''' <param name="value">Value to be written</param>
        ''' <param name="asyncWrite">Is asyncWrite supported</param>
        ''' <remarks>tagName should be the name of the item. If the item is type of GlobalOPCElement
        ''' item name would be the tag name itself. Otherwise, the item name would be the item itself not 
        ''' including the tag name.</remarks>
        Public Sub ValueFromObjectToPlc(ByVal itemName As String, ByVal value As Object, Optional ByVal asyncWrite As Boolean = False) Implements IOpcObject.ValueFromObjectToPlc
            Dim tempPLCTagName As String = GetPlcTagName(itemName)
            If TypeOf Me Is IOpcBoolean Then
                If value Then value = 1
            End If
            If asyncWrite Then
                Opc.AddAsyncPendingItemToList(GroupName, tempPLCTagName, value)
            Else
                Opc.SetItemValue(GroupName, tempPLCTagName, value)
            End If
        End Sub

        ''' <summary>
        ''' Create a copy of all values in the object
        ''' </summary>
        ''' <returns>A clone copy of the object</returns>
        ''' <remarks></remarks>
        Public Function ShallowClone() As IOpcObject Implements IOpcObject.ShallowClone
            Return MemberwiseClone()
        End Function

        ''' <summary>
        ''' Test if the class is serializable.
        ''' </summary>
        ''' <value>Boolean to indicate true or false.</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <NotConnectableOpcItem()>
        Public ReadOnly Property IsSerializable() As Boolean Implements IOpcObject.IsSerializable
            Get
                Return Me.GetType.IsSerializable
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return String.Format("PLC Name: {0}; TagName:{1}; GroupName:{2}", PlcName, TagName, GroupName)
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
            _filterString = _filterString.Replace(" ", "")
            If _filterString.LastIndexOf(",") = _filterString.Length - 1 Then
                _filterString.Remove(_filterString.Length - 1, 1)
            End If
            Return _filterString.Split(",")
        End Function

        ''' <summary>
        ''' This is where the handshaking takes place
        ''' </summary>
        ''' <param name="index">Property index</param>
        ''' <param name="value">Value of the item that has this property index</param>
        ''' <remarks></remarks>
        Protected Overridable Sub ValueFromPlcToObject(ByVal index As Integer, ByVal value As Object) Implements IOpcObject.ValueFromPlcToObject
            'Must be inherited in the derived class to make use of the OPC.Instance, see other opc classes for details
            Throw New Exception("You must override this method to receive data from PLC!! " &
                                "please remove MyBase.ValueFromPLCToObject(ByVal index As Integer, " &
                                "ByVal value As Object) when it's overridden")
        End Sub
#End Region

#Region "Friend"
        ''' <summary>
        ''' This is used to raise the property changed event from the OPCComm class
        ''' </summary>
        Friend Sub RaisePropertiesUpdatedEvent(ByVal e As System.EventArgs) Implements IOpcObject.RaisePropertiesUpdatedEvent
            If InvokeRequired Then
                RaiseMultiThreadedEvent(PropertiesUpdateCompletedEvent, New Object() {Me, e})
            Else
                RaiseEvent PropertiesUpdateCompleted(Me, e)
            End If
        End Sub
#End Region

#End Region

#Region "Contructors"
        Public Sub New()
            InitializeComponent()
            DoubleBuffered = True
        End Sub
#End Region

    End Class

End Namespace


