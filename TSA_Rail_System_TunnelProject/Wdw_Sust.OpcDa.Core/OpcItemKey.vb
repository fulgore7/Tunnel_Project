Friend NotInheritable Class OpcItemKey

    Private _serverHandle As Integer

    Public Sub New(clientHandle As Integer, groupName As String, tagName As String)
        Me.ClientHandle = clientHandle
        PlcTagName = tagName
        Me.GroupName = groupName
        ServerHandle = -1
    End Sub

    Public Property ClientHandle() As Integer

    Public Property GroupName() As String
    Public Property PlcTagName() As String

    Public Property ServerHandle() As Integer
        Get
            If _serverHandle < 0 Then _serverHandle = OpcComm.Instance.GetItemServerHandle(GroupName, PlcTagName)
            Return _serverHandle
        End Get
        Set(value As Integer)
            _serverHandle = value
        End Set
    End Property

    Public Property Value() As Object
End Class