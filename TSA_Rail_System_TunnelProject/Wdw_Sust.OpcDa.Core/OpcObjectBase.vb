Imports System.ComponentModel
Imports System.Linq.Expressions
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.Serialization
Imports Wdw_Sust.OpcDa.Core.Ab
Imports Wdw_Sust.OpcDa.Core.Interfaces


''' <summary>
''' All classes which work with OPCComm must inherit from this class to make use of the OPCComm class.
''' </summary>
''' <remarks></remarks>
<Serializable()>
Public MustInherit Class OpcObjectBase
    Inherits NotifyableBase
    Implements IOpcObject

#Region "Fields"

    ''' <summary>
    ''' Used to cache tag definitions so that it is only generated once. This is a shared field
    ''' </summary>
    Private Shared ReadOnly _tagDefinitionCache As New Dictionary(Of Type, List(Of String))()

    <NonSerialized()>
    Private Shared ReadOnly PREDEFINED_FILTER_STRING As String = "Date,DateTime,Chars,IsDirty,IsValid"

    Private Shared _opc As OpcComm = OpcComm.Instance

    Private ReadOnly _parent As IOpcObject

    Private _filterProperties As String()

    ''' <summary>
    ''' To be overridden by the derived class for specific filtering
    ''' </summary>
    ''' <remarks>Override SetPropertyFilter</remarks>
    <NonSerialized()>
    Private _filterString As String = String.Empty

    ''' <summary>
    ''' Group name to distinguish which group the PLC tag belongs to.
    ''' </summary>
    ''' <remarks></remarks>
    Private _groupName As String

    Private _isRegisteringInProcess As Boolean = True

    ''' <summary>
    ''' Dictionary(Of PLCTagName, Index)
    ''' </summary>
    ''' <remarks>String = PLC compliance tag name, Integer = property index</remarks>
    Private _listOfOPCTags As Dictionary(Of String, Integer)

    ''' <summary>
    ''' OPC topic name from RSLinx
    ''' </summary>
    ''' <remarks></remarks>
    Private _PLCName As String

    Private _registeredItems As Integer

    ''' <summary>
    ''' TagName of the item, which does not include the PLC name and does not include the sub member names.
    ''' </summary>
    ''' <remarks></remarks>
    Private _tagName As String

    ''' <summary>
    ''' time stamp of the value change
    ''' </summary>
    ''' <remarks></remarks>
    Private _timeStamp As Date

    'Protected _filterString As String = "GroupName,PLCName,TagName,UniqueID,MicroSecond,ListOfOPCTags,Date,DateTime,TimeStamp,Chars,IsRegisteringInProgress,RegisterItems,Value,"

#End Region

#Region "Events"

    ''' <summary>
    ''' This will only fire once when registration is completed. This can be used to initialize control
    ''' </summary>
    ''' <param name="sender">The object itself</param>
    ''' <param name="e">Dummy argument</param>
    ''' <remarks></remarks>
    <NonSerialized()>
    Public Event ItemsRegisteringCompleted(sender As IOpcObject, e As System.EventArgs) Implements IOpcObject.ItemsRegisteringCompleted

    ''' <summary>
    ''' Properties are updated successfully. This can be used when you want to have action after the
    ''' object properties are updated.
    ''' </summary>
    <NonSerialized()>
    Public Event PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Implements IOpcObject.PropertiesUpdateCompleted

    <NonSerialized()>
    Public Event SyncWriteCompleted(sender As IOpcObject, e As System.EventArgs)

#End Region

#Region "Properties"

    '<NonSerialized>
    'Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    'Protected Sub OnPropertyChanged(Of U)(propertyExpression As Expression(Of Func(Of U)))
    '    Dim propertyName As String = ExtractPropertyName(propertyExpression)
    '    OnPropertyChanged(propertyName)
    'End Sub

    'Private Sub OnPropertyChanged(propertyName As String)
    '    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    'End Sub

    ''' <summary>
    ''' Name of the group
    ''' </summary>
    <NotConnectableOpcItem>
    Public Property GroupName() As String Implements IOpcObject.GroupName
        Get
            Return _groupName
        End Get
        Set(value As String)
            _groupName = value
        End Set
    End Property

    <NotConnectableOpcItem>
    Public ReadOnly Property IsSerializable() As Boolean Implements IOpcObject.IsSerializable
        Get
            Return Me.GetType.IsSerializable
        End Get
    End Property

    ''' <summary>
    ''' Dictionary(Of PLCTagName, Index)
    ''' </summary>
    ''' <remarks>String = PLC compliance tag name, Integer = property index</remarks>
    <NotConnectableOpcItem, EditorBrowsable(EditorBrowsableState.Advanced), Browsable(False)>
    Public ReadOnly Property ListOfPlcTags() As Dictionary(Of String, Integer) Implements IOpcObject.ListOfOpcTags
        Get
            If _listOfOPCTags Is Nothing Then _listOfOPCTags = New Dictionary(Of String, Integer)
            Return _listOfOPCTags
        End Get
    End Property

    ''' <summary>
    ''' Topic Name of the PLC set up in RSLinx
    ''' </summary>
    <NotConnectableOpcItem>
    Public Property PlcName() As String Implements IOpcObject.PlcName
        Get
            Return _PLCName
        End Get
        Set(value As String)
            _PLCName = value
        End Set
    End Property

    ''' <summary>
    ''' Name of the root tag name defined in the PLC
    ''' </summary>
    <NotConnectableOpcItem>
    Public Property TagName() As String Implements IOpcObject.TagName
        Get
            Return _tagName
        End Get
        Set(value As String)
            _tagName = value
        End Set
    End Property

    ''' <summary>
    ''' Time stamp associated with data change event for the object
    ''' </summary>
    <NotConnectableOpcItem, Browsable(False)>
    Public Property TimeStamp() As Date Implements IOpcObject.TimeStamp
        Get
            Return _timeStamp
        End Get
        Set(value As Date)
            _timeStamp = value
        End Set
    End Property

    ''' <summary>
    ''' Keep track to see if the object is being initialize
    ''' </summary>
    <NotConnectableOpcItem>
    Friend ReadOnly Property IsRegisteringInProgress() As Boolean Implements IOpcObject.IsRegisteringInProgress
        Get
            Return _isRegisteringInProcess
        End Get
    End Property

    ''' <summary>
    ''' How many items have been connected to the OPC server and already got first data back from
    ''' the PLC
    ''' </summary>
    ''' <value></value>
    ''' <returns>Number of items have been connected to the OPC server.</returns>
    ''' <remarks>
    ''' If number of items back is greater than the list of PLC tags for the object, the
    ''' ItemsRegisteringCompleted event is fire. This should only be fired once.
    ''' </remarks>
    <NotConnectableOpcItem>
    Friend Property RegisterItems() As Integer Implements IOpcObject.RegisterItems
        Get
            Return _registeredItems
        End Get
        Set(value As Integer)
            _registeredItems = value
            If _registeredItems >= ListOfPlcTags.Count Then
                _isRegisteringInProcess = False
                _registeredItems = Nothing
                RaiseEvent ItemsRegisteringCompleted(Me, System.EventArgs.Empty)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Property to reference to the OPCComm.Instance property. This will ensure that only one
    ''' instance is defined at a time
    ''' </summary>
    <NotConnectableOpcItem>
    Protected Shared ReadOnly Property OPC() As OpcComm
        Get
            Return _opc
        End Get
    End Property

    'Private Shared Function ExtractPropertyName(Of U)(propertyExpression As Expression(Of Func(Of U))) As String
    '    If propertyExpression Is Nothing Then Throw New ArgumentNullException(NameOf(propertyExpression))
    '    Dim memberExpression As MemberExpression = propertyExpression.Body
    '    If memberExpression Is Nothing Then Throw New ArgumentException("memberExpression")
    '    Dim prop As PropertyInfo = memberExpression.Member
    '    If prop Is Nothing Then Throw New ArgumentException("property")
    '    Dim getMethod As MethodInfo = prop.GetGetMethod(True)
    '    If getMethod.IsStatic Then Throw New ArgumentException("static method")
    '    Return memberExpression.Member.Name
    'End Function
    ''' <summary>
    ''' Used to filter the property not needed for the OPC object class. This will optimize the OPC
    ''' communication. When an OPC object inherits from a normal class, some of the properties may
    ''' not be needed for OPC. Those properties can be put here.
    ''' </summary>
    <NotConnectableOpcItem>
    Private ReadOnly Property FilterProperties() As String() Implements IOpcObject.FilterProperties
        Get
            If _filterProperties Is Nothing Then
                'If _filterString(_filterString.Length - 1) <> "," Then _filterString += ","
                _filterProperties = SetPropertyFilter(_filterString)
            End If
            Return _filterProperties
        End Get
    End Property

#End Region

#Region "Methods"

#Region "Private"

    Public Function GetPropertyIndex(PLCTagName As String) As Integer Implements IOpcObject.GetPropertyIndex
        Return ListOfPlcTags(PLCTagName)
    End Function

#End Region

#Region "Public"

    ''' <summary>
    ''' Get the item value from the PLC.
    ''' </summary>
    ''' <param name="itemName">The is the name starting with the name of the property</param>
    Public Overridable Function GetItemValueFromPlc(itemName As String) As Object
        Dim plcTagName As String = GetPlcTagName(itemName)
        For Each s As String In ListOfPlcTags.Keys
            If s.Contains(plcTagName) Then
                Return OPC.GetItemValue(Me, itemName)
            End If
        Next
        Throw New Exception("Item is not defined or item name is incorrect!!")
    End Function

    ''' <summary>
    ''' Get number of opc items in the object
    ''' </summary>
    ''' <returns>Integer value of the count</returns>
    ''' <remarks></remarks>
    Public Function GetPlcTagCount() As Integer
        Return ListOfPlcTags.Count
    End Function

    ''' <summary>
    ''' Get the tag name of a property in a class. The format should be
    ''' [PLCName]TagName.Property.SubProperty etc...
    ''' </summary>
    ''' <param name="itemName">Should not be included the TagName</param>
    ''' <returns>PLC compliance tag name</returns>
    ''' <remarks></remarks>
    Public Function GetPlcTagName(itemName As String) As String Implements IOpcObject.GetPlcTagName
        If PlcName = String.Empty OrElse IsNothing(PlcName) Then
            Throw New Exception("No PLC Name Defined!!")
        End If
        If TypeOf (Me) Is OpcElement Then
            Return String.Format("[{0}]{1}", PlcName, TagName)
        Else
            Return String.Format("[{0}]{1}.{2}", PlcName, TagName, itemName)
        End If
    End Function

    ''' <summary>
    ''' Get the tag names in the opc item format [PLCName]Item_Name.Sub_Item_Name
    ''' </summary>
    ''' <returns>List of opc items</returns>
    ''' <remarks></remarks>
    Public MustOverride Function GetPlcTagNames() As String() Implements IOpcObject.GetPlcTagNames
    ''Return RslinxOpcDaSettings.TagGenerator.GenerateOpcTags(Me)

    ''' <summary>
    ''' The ShallowClone method creates a shallow copy by creating a new object, and then copying
    ''' the non-static fields of the current object to the new object. If a field is a value type, a
    ''' bit-by-bit copy of the field is performed. If a field is a reference type, the reference is
    ''' copied but the referred object is not; therefore, the original object and its clone refer to
    ''' the same object.
    ''' </summary>
    ''' <returns>A clone copy of the object</returns>
    ''' <remarks></remarks>
    Public Function ShallowClone() As IOpcObject Implements IOpcObject.ShallowClone
        Return MemberwiseClone()
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}{1}{2}{3}{4}{5}{6}", Me.GetType, vbCrLf, PlcName, vbCrLf, GroupName, vbCrLf, TagName)
    End Function

    ''' <summary>
    ''' Write the item value back to the PLC
    ''' </summary>
    ''' <param name="itemName">Name of the item to be written</param>
    ''' <param name="value">Value to be written</param>
    ''' <param name="asyncWrite">
    ''' Is asyncWrite supported. Default is FALSE, which means that the value will be updated to PLC
    ''' immediately. If the value is TRUE, the value will NOT be updated to PLC until
    ''' AsyncWrite(ByVal groupName As String) from OPCComm Class is called
    ''' </param>
    ''' <remarks>
    ''' tagName should be the name of the item. If the item is type of OPCElement item name would be
    ''' the tag name itself, or itemName can be an empty string. Otherwise, the item name would be
    ''' the item itself not including the tag name.
    ''' </remarks>
    Public Sub ValueFromObjectToPlc(itemName As String, value As Object, Optional asyncWrite As Boolean = False) Implements IOpcObject.ValueFromObjectToPlc
        ValueFromObjectToPlc(itemName, value, asyncWrite, False)
    End Sub

    'End Sub
    Public Sub ValueFromObjectToPlc(Of Tkey)(propertyName As Expression(Of Func(Of Tkey)), value As Object, Optional asyncWrite As Boolean = False)
        ValueFromObjectToPlc(CType(propertyName.Body, MemberExpression).Member.Name, value, asyncWrite, False)
    End Sub

    'Public Sub ValueFromObjectToPLC(x As Expression(Of T))
    Public Sub ValueFromObjectToPlc(itemName As String, value As Object, asyncWrite As Boolean, shouldThrowIfError As Boolean)
        ''If Not IsRegisteringInProgress Then
        Dim tempPLCTagName As String = GetPlcTagName(itemName)
        If asyncWrite Then
            If TypeOf value Is Boolean Then
                If CType(value, Boolean) = True Then
                    OPC.AddAsyncPendingItemToList(GroupName, tempPLCTagName, 1)
                Else
                    OPC.AddAsyncPendingItemToList(GroupName, tempPLCTagName, 0)
                End If
            Else
                OPC.AddAsyncPendingItemToList(GroupName, tempPLCTagName, value)
            End If
        Else
            'Update directly to PLC and wait for OPC data change event to update property value
            If Not OPC.SetItemValue(GroupName, tempPLCTagName, value, shouldThrowIfError) AndAlso shouldThrowIfError Then
                Throw New OpcItemWriteErrorException(itemName, value)
            Else
                If OpcComm.ThreadMode = OpcThreadMode.MULTI_THREADED Then
                    RaiseMultiThreadedEvent(SyncWriteCompletedEvent, New Object() {Me, System.EventArgs.Empty})
                Else
                    RaiseEvent SyncWriteCompleted(Me, System.EventArgs.Empty)
                End If
            End If
        End If
        ''End If
    End Sub

    ''' <summary>
    ''' Must be overridden in the inherited class to reflect changes of the value from the PLC items
    ''' </summary>
    ''' <param name="index">
    ''' The member functions must be in ascending alphabetical order. The first index should be 1
    ''' </param>
    ''' <param name="value">
    ''' Value of the item. To avoid late binding, you should specify what type of the value will
    ''' return from the PLC
    ''' </param>
    ''' <remarks></remarks>
    Protected MustOverride Sub ValueFromPlcToObject(index As Integer, value As Object) Implements IOpcObject.ValueFromPlcToObject

#End Region

#Region "Friend"

    ''' <summary>
    ''' This is used to raise the property changed event from the OPCComm class
    ''' </summary>
    Friend Sub RaisePropertiesUpdatedEvent(e As System.EventArgs) Implements IOpcObject.RaisePropertiesUpdatedEvent
        If OpcComm.ThreadMode = OpcThreadMode.MULTI_THREADED Then
            RaiseMultiThreadedEvent(PropertiesUpdateCompletedEvent, New Object() {Me, e})
        Else
            RaiseEvent PropertiesUpdateCompleted(Me, e)
        End If
    End Sub

#End Region

#Region "Protected"

    ''' <summary>
    ''' Use to extend the filter to include any unnecessary items for the opc communication in the
    ''' class. Use comma (,) to separate more than 1 property
    ''' </summary>
    ''' <param name="addedFilters">filter to be added</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' There is already a pre-defined filter already. If there are more items needed to be removed,
    ''' this function needs to be call
    ''' </remarks>
    ''' <example>
    ''' <code>
    '''Protected Overrides Function SetPropertyFilter(ByRef addedFilters As String) As String()
    '''addedFilters += "Source_Washer,Recirculation_Destination,Estimated_Pieces,Soiled_Weight"
    '''Return MyBase.SetPropertyFilter(addedFilters)
    '''End Function
    ''' </code>
    ''' </example>
    Protected Overridable Function SetPropertyFilter(ByRef addedFilters As String) As String()
        _filterString = _filterString.Replace(" ", "")
        If _filterString.LastIndexOf(",") <> _filterString.Length - 1 Then
            '_filterString.Remove(_filterString.Length - 1, 1)
            _filterString = String.Format("{0},", _filterString)
        End If
        _filterString += PREDEFINED_FILTER_STRING
        Return _filterString.Split(",")
    End Function

#End Region

#End Region

#Region "Constructors"

    Public Sub New(plcName As String, tagName As String, groupName As String)
        Me.PlcName = plcName
        Me.TagName = tagName
        Me.GroupName = groupName
    End Sub

    Public Sub New(plcName As String, tagName As String)
        Me.PlcName = plcName
        Me.TagName = tagName
        Me.GroupName = tagName
    End Sub

    ''' <summary>
    ''' Used when the class is defined as a property to another opc item class this will make sure
    ''' that GroupName, TagName and PLCName are set properly
    ''' </summary>
    ''' <param name="parent">Parent class of the is class</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef parent As IOpcObject, propertyName As String)
        '_parent = parent
        'GroupName = _parent.GroupName
        'TagName = String.Format("{0}.{1}", _parent.TagName, propertyName)
        'PLCName = _parent.PLCName
        Throw New NotImplementedException("Not Implemented Yet!")
    End Sub

    Protected Sub New()

    End Sub

#End Region

End Class

<Serializable()>
Public MustInherit Class OpcObjectBase(Of T As IOpcObject)
    Inherits OpcObjectBase
    Implements ICloneable

    Public Sub New(plcName As String, tagName As String, groupName As String)
        Me.PlcName = plcName
        Me.TagName = tagName
        Me.GroupName = groupName
    End Sub

    Public Sub New(plcName As String, tagName As String)
        Me.PlcName = plcName
        Me.TagName = tagName
        Me.GroupName = tagName
    End Sub

    Protected Sub New()

    End Sub

    Public Function Clone() As T
        Return SerializationManager.DeserializeData(SerializationManager.SerializeData(Me))
    End Function

    Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
        Return Clone()
    End Function

End Class