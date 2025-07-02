Namespace EventArgs
    Public Class NewChatMessagesReceivedArgs
        Inherits System.EventArgs
        Public Messages As List(Of ChatMessage)
        Public TimeUpdated As Date
    End Class
End Namespace

