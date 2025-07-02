Imports System.IO
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization

Namespace Communications
    <Serializable()>
    Public Class NetworkMessage
        Implements INetworkMessage
        Public Shared ReadOnly EmptyContent As Object
        Public Property MessageContent As Object Implements INetworkMessage.MessageContent
        Public Property MessageHeader As IMessageHeader Implements INetworkMessage.MessageHeader

        Public Sub New(ByVal messageType As Integer, ByVal messageContent As Object)
            MessageHeader = New MessageHeader(messageType, GetObjectBytes(messageContent))
            Me.MessageContent = messageContent
        End Sub

        Private Shared Function GetObjectBytes(messageContent As Object) As Integer
            If messageContent Is Nothing Then Return 0
            If Not SerializationManager.IsSerializable(messageContent) Then Throw New ArgumentException(String.Format("Object type {0} is not serializable!!", messageContent.GetType))
            Return SerializationManager.SerializeData(messageContent).Length
        End Function

        Public Function ConstructMessageAsBytes() As Byte() Implements INetworkMessage.ConstructMessageAsBytes
            Using ms As New MemoryStream
                'ms.Write(BitConverter.GetBytes(MessageHeader.MessageType), 0, 4)
                'ms.Write(BitConverter.GetBytes(MessageHeader.MessageSize), 0, 4)
                'ms.Seek(MessageHeader.HeaderSize, SeekOrigin.Begin)
                ms.Write(SerializationManager.SerializeData(MessageHeader), 0, SerializationManager.SerializeData(MessageHeader).Length)
                If MessageHeader.MessageSize > 0 Then
                    ms.Write(SerializationManager.SerializeData(MessageContent), 0, SerializationManager.SerializeData(MessageContent).Length)
                End If
                Return ms.ToArray
            End Using
        End Function

        Public Sub New()

        End Sub
    End Class
End Namespace