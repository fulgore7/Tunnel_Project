Namespace Textile.LINT.OPC.Core

    Friend Class OPCItemPropertyItem
        Private _clientHandle As Integer
        Private _serverHandle As Integer = -1
        Private _value As Object
        Private _propertyIndex As Integer
        Private _PLCTagName As String
        Public Property PLCTagName As String
            Get
                Return _PLCTagName
            End Get
            Set(ByVal value As String)
                _PLCTagName = value
            End Set
        End Property
        Public Property ClientHandle As Integer
            Get
                Return _clientHandle
            End Get
            Set(ByVal value As Integer)
                _clientHandle = value
            End Set
        End Property
        Public Property ServerHandle As Integer
            Get
                Return _serverHandle
            End Get
            Set(ByVal value As Integer)
                _serverHandle = value
            End Set
        End Property
        Public Property Value As Object
            Get
                Return _value
            End Get
            Set(ByVal value As Object)
                _value = value
            End Set
        End Property
        Public Property PropertyIndex As Integer
            Get
                Return _propertyIndex
            End Get
            Set(ByVal value As Integer)
                _propertyIndex = value
            End Set
        End Property

    End Class

End Namespace