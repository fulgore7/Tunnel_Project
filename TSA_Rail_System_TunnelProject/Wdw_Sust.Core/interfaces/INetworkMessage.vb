Namespace Interfaces
    Public Interface INetworkMessage
        Property MessageHeader As IMessageHeader
        Property MessageContent As Object
        Function ConstructMessageAsBytes() As Byte()
    End Interface
End Namespace
