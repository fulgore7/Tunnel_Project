Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces

Public MustInherit Class ChatClient
    Inherits InformationSubscriberBase
    Implements IChatClient, IInformationSubscriber(Of LintApplicationManagerEventArgs)

#Region "Fields"
    Private _isIdle As Boolean
    Private _isOnline As Boolean
    Private _isConnected As Boolean
#End Region

#Region "Events"
    Public Event _OfflineEvent(sender As Object, e As System.EventArgs) Implements IChatClient._LoggedOffEvent
    Public Event _OnlineEvent(sender As Object, e As System.EventArgs) Implements IChatClient._LoggedInEvent
    Public Event _MessageSentEvent(sender As Object, e As System.EventArgs) Implements IChatClient._MessageSentEvent
    Public Event _NewMessagesReceivedEvent(sender As Object, e As NewChatMessagesReceivedArgs) Implements IChatClient._NewMessagesReceivedEvent
    Public Event _IdleTimeOutEvent As EventHandler Implements IChatClient._IdleTimeOutEvent
    Public Event _NewMessageAlert As EventHandler(Of NewMessageAlertArgs) Implements IChatClient._NewMessageAlert
    Public Event _IdleStatusChanged As EventHandler Implements IChatClient._IdleStatusChanged
    Public Event _ExceptionOccurred As EventHandler(Of ChatClientExceptionEventArgs) Implements IChatClient._ExceptionOccurred
    Public Event _ConnectStatusChanged As EventHandler Implements IChatClient._ConnectStatusChanged
#End Region

#Region "Properties"
    Public Property LastUpdate As Date
    Public Property IsConnected As Boolean Implements IChatClient.IsConnected
        Get
            Return _isConnected
        End Get
        Protected Set(value As Boolean)
            If _isConnected <> value Then
                _isConnected = value
                RaiseEvent _ConnectStatusChanged(Me, System.EventArgs.Empty)
            End If
        End Set
    End Property
    Public ReadOnly Property IsOnline As Boolean Implements IChatClient.IsOnline
        Get
            Return _isOnline
        End Get
    End Property
#End Region

#Region "Methods"
    Public MustOverride Function GetMessages(ByVal timeSince As Date, ByVal plant As Plant) As System.Collections.Generic.List(Of ChatMessage) Implements IChatClient.GetMessage
    Public MustOverride Sub RefreshMessages(Optional ByVal sinceTime As Date = Nothing) Implements IChatClient.RefreshMessages
    Public MustOverride Sub StartClient() Implements IChatClient.StartClient
    Public MustOverride Sub StopClient() Implements IChatClient.StopClient

    Public Sub ProcessSubscribedInformation(args As LintApplicationManagerEventArgs) Implements IInformationSubscriber(Of LintApplicationManagerEventArgs).ProcessSubscribedInformation
        If args.IsChatEnabled Then
            StartClient()
        Else
            StopClient()
        End If
    End Sub

    Protected Sub MessagesReceived(ByVal e As NewChatMessagesReceivedArgs)
        RaiseEvent _NewMessagesReceivedEvent(Me, e)
    End Sub

    Public Sub Login() Implements IChatClient.Login
        If Not _isOnline Then
            _isOnline = True
            OnLogin()
        End If
    End Sub

    Public Property IsIdle As Boolean Implements IChatClient.IsIdle
        Get
            Return _isIdle
        End Get
        Set(value As Boolean)
            If _isIdle <> value Then
                _isIdle = value
                RaiseIdleStatusChangedEvent()
            End If
        End Set
    End Property

    Protected Sub RaiseIdleStatusChangedEvent()
        RaiseEvent _IdleStatusChanged(Me, System.EventArgs.Empty)
        OnIdleStatusChanged()
    End Sub

    Protected Overridable Sub OnIdleStatusChanged()


    End Sub

    Protected Overridable Sub OnLogin()
        RaiseEvent _OnlineEvent(Me, System.EventArgs.Empty)
    End Sub

    Protected Overridable Sub OnLogoff()
        RaiseEvent _OfflineEvent(Me, System.EventArgs.Empty)
    End Sub

    Public Sub LogOff() Implements IChatClient.LogOff
        If _isOnline Then
            _isOnline = False
            OnLogoff()
        End If
    End Sub
    Protected Sub RaiseNewMessageAlertEvent(ByVal numberOfNewMessage As Integer)
        RaiseEvent _NewMessageAlert(Me, New NewMessageAlertArgs With {.NewMessageCounts = numberOfNewMessage})
    End Sub
    Public Overridable Sub SendMessage(message As ChatMessage) Implements IChatClient.SendMessage
        OnMessageSent()
    End Sub
    Protected Sub OnExceptionOccurred(ByVal e As ChatClientExceptionEventArgs)
        IsConnected = False
        RaiseEvent _ExceptionOccurred(Me, e)
    End Sub
    Protected Overridable Sub OnMessageSent()
        RaiseEvent _MessageSentEvent(Me, System.EventArgs.Empty)
    End Sub

    Protected Sub RaiseOnIdleTimeOutEvent()
        RaiseEvent _IdleTimeOutEvent(Me, System.EventArgs.Empty)
    End Sub



#End Region

End Class