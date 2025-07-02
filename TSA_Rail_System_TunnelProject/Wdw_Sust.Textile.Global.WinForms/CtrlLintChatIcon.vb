Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces

Public Class CtrlLintChatIcon
    Private WithEvents CHAT_CLIENT As IChatClient
    Private _iconClickedHandler As Action

    Private Sub CHAT_CLIENT__ConnectStatusChanged(sender As Object, e As System.EventArgs) Handles CHAT_CLIENT._ConnectStatusChanged
        'InvokeIfNeeded(Sub() PictureBox1.Image = IIf(CHAT_CLIENT.IsConnected, My.Resources.chat_32_by_32, My.Resources.chat_not_working_32_by_32))
    End Sub

    Private Sub CHAT_CLIENT__IdleStatusChanged(sender As Object, e As System.EventArgs) Handles CHAT_CLIENT._IdleStatusChanged
        If Not CHAT_CLIENT.IsIdle Then
            InvokeIfNeeded(Sub()
                               'PictureBox1.Image = My.Resources.chat_32_by_32
                               lblNewMessages.Visible = False
                           End Sub)
        End If
    End Sub

    Private Sub CHAT_CLIENT__NewMessagesReceivedEvent(sender As Object, e As NewChatMessagesReceivedArgs) Handles CHAT_CLIENT._NewMessagesReceivedEvent
        InvokeIfNeeded(Sub()
                           'PictureBox1.Image = My.Resources.new_messages_32_by_32
                           lblNewMessages.Text = String.Format("{0} New Messages", e.Messages.Count)
                           lblNewMessages.Visible = True
                       End Sub)
    End Sub

    Public Sub SetClickHandler(ByVal handler As Action)
        _iconClickedHandler = handler
    End Sub

    Public Sub SetClient(ByVal client As IChatClient)
        CHAT_CLIENT = client
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As System.EventArgs) Handles PictureBox1.Click
        If CHAT_CLIENT IsNot Nothing Then
            CHAT_CLIENT.IsIdle = False
            If _iconClickedHandler IsNot Nothing Then _iconClickedHandler()
            'PictureBox1.Image = My.Resources.chat_32_by_32
            lblNewMessages.Visible = False
        End If
    End Sub
End Class
