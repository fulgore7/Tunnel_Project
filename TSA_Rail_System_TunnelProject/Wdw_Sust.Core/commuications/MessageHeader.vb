Imports Wdw_Sust.Core.Interfaces

Namespace Communications
    <Serializable()>
    Public Class MessageHeader
        Implements IMessageHeader

        Public Property MessageType As Integer Implements IMessageHeader.MessageType
        Public Property MessageSize As Integer Implements IMessageHeader.MessageSize

        Public Sub New(ByVal messageType As Integer, ByVal messageSize As Integer)
            Me.MessageSize = messageSize
            Me.MessageType = messageType
        End Sub

        Public ReadOnly Property HeaderSize As Integer Implements IMessageHeader.HeaderSize
            Get
                Return 182
            End Get
        End Property
    End Class
End Namespace