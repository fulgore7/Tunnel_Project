Imports Wdw_Sust.Textile.Core.EventArgs

Namespace Interfaces
    Public Interface IChatClient
        ReadOnly Property IsOnline As Boolean
        Property IsIdle As Boolean
        Property IsConnected As Boolean
        Sub SendMessage(ByVal message As ChatMessage)
        Sub RefreshMessages(Optional ByVal sinceTime As Date = Nothing)
        Sub Login()
        Sub LogOff()
        Sub StartClient()
        Sub StopClient()
        Function GetMessage(ByVal timeSince As Date, ByVal plant As Plant) As List(Of ChatMessage)
        Event _LoggedInEvent As EventHandler
        Event _LoggedOffEvent As EventHandler
        Event _MessageSentEvent As EventHandler
        Event _NewMessagesReceivedEvent As EventHandler(Of NewChatMessagesReceivedArgs)
        Event _IdleTimeOutEvent As EventHandler
        Event _NewMessageAlert As EventHandler(Of NewMessageAlertArgs)
        Event _IdleStatusChanged As EventHandler
        Event _ExceptionOccurred As EventHandler(Of ChatClientExceptionEventArgs)
        Event _ConnectStatusChanged As EventHandler
    End Interface
End Namespace