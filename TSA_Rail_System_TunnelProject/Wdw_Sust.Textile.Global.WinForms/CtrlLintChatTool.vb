Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.WinForms.Core

Public Class CtrlLintChatTool
    Inherits CtrlFormBase

#Region "Fields"
    Private WithEvents _client As IChatClient
    Private Const NAME_LABEL = "{0} is currently logged in"
    Private _currentLoggedIn As LintCastMember
    Private ReadOnly _isWindowsActive As Boolean
    Private ReadOnly _accummulatedNewMessageCounts As Integer
    Private _dateToShow As Date = Date.MinValue
    Private Const DIVIDER As String = "===================== {0} ====================="
#End Region

#Region "Events"

#End Region

#Region "Properties"
    Public Property Plant As Plant = Plant.UNKNOWN
#End Region

#Region "Methods"
    Private Sub btnChat_Click(sender As System.Object, e As System.EventArgs) Handles btnChat.Click
        If txtMessage.Text.Trim <> String.Empty Then
            Dim msg As IChatMessage = New ChatMessage With {.Message = txtMessage.Text, .MessageSubmittedBy = _currentLoggedIn.FirstName, .Plant = Plant, .TimeCreated = Now, .EmployeeID = _currentLoggedIn.EmployeeID}
            UpdateChatHistory(msg)
            txtMessage.Clear()
            txtMessage.Focus()
        End If
    End Sub

    Protected Overrides Sub OnActivated(e As System.EventArgs)
        If _client IsNot Nothing Then _client.IsIdle = False
    End Sub

    Protected Overrides Sub OnDeactivate(e As System.EventArgs)
        If _client IsNot Nothing Then _client.IsIdle = True
    End Sub

    Private Sub _client__ExceptionOccurred(sender As Object, e As ChatClientExceptionEventArgs) Handles _client._ExceptionOccurred
        InvokeIfNeeded(AddressOf Close)
    End Sub

    Private Sub _client__IdleTimeOutEvent(sender As Object, e As System.EventArgs) Handles _client._IdleTimeOutEvent
        If _client IsNot Nothing Then _client.LogOff()
    End Sub

    Private Sub _client__NewMessagesReceivedEvent(sender As Object, e As NewChatMessagesReceivedArgs) Handles _client._NewMessagesReceivedEvent
        Me.InvokeIfNeeded(Sub()
                              ListBox1.BeginUpdate()
                              Dim list As New List(Of String)
                              e.Messages.ForEach(Sub(msg)
                                                     If _dateToShow <> msg.TimeCreated.Date Then
                                                         _dateToShow = msg.TimeCreated.Date
                                                         list.Add(String.Format(DIVIDER, _dateToShow.ToString("MM/dd/yyyy")))
                                                     End If
                                                     list.Add(msg.ToString)
                                                 End Sub)
                              ListBox1.Items.AddRange(list.ToArray)
                              ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                              ListBox1.EndUpdate()
                          End Sub)
    End Sub

    Protected Overrides Sub ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode OrElse Not CONFIGURATION.IsChatServiceEnabled Then InvokeIfNeeded(AddressOf Me.Close)
    End Sub

    Protected Overrides Sub ChatServiceEnableChanged()
        If Not CONFIGURATION.IsChatServiceEnabled Then InvokeIfNeeded(AddressOf Me.Close)
    End Sub

    Private Sub UpdateChatHistory(ByVal msg As ChatMessage)
        _client.SendMessage(msg)
        If _dateToShow <> msg.TimeCreated.Date Then
            _dateToShow = msg.TimeCreated.Date
            ListBox1.Items.Add(String.Format(DIVIDER, _dateToShow.ToString("MM/dd/yyyy")))
        End If
        ListBox1.Items.Add(msg.ToString)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub btnLogIn_Click(sender As System.Object, e As System.EventArgs) Handles btnLogIn.Click
        If _client.IsOnline Then
            _client.LogOff()
        Else
            Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
            If card IsNot Nothing Then
                _currentLoggedIn = card.CastInfo.Clone
                _client.Login()
                txtMessage.Focus()
            End If
        End If
    End Sub

    Private Sub CtrlLINTChatTool_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _client.RefreshMessages(Today.AddDays(-7))
        Me.AcceptButton = Me.btnLogIn
        txtMessage.Focus()
    End Sub

    Private Sub _client__OnOfflineEvent(sender As Object, e As System.EventArgs) Handles _client._LoggedInEvent, _client._LoggedOffEvent
        If _client.IsOnline Then
            InvokeIfNeeded(Sub()
                               btnLogIn.Text = "Log Off"
                               btnChat.Enabled = True
                               lblName.Text = String.Format(NAME_LABEL, _currentLoggedIn.FirstName)
                               Me.AcceptButton = Me.btnChat
                           End Sub)
        Else
            InvokeIfNeeded(Sub()
                               btnLogIn.Text = "Log On"
                               btnChat.Enabled = False
                               _currentLoggedIn = Nothing
                               lblName.Text = "No Current Log In"
                               Me.AcceptButton = Me.btnLogIn
                           End Sub)
        End If
        txtMessage.Focus()
    End Sub

#End Region

#Region "Constructors"

    Public Sub New(ByVal client As IChatClient, ByVal plant As Plant)
        InitializeComponent()
        Me.Plant = plant
        _client = client
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

End Class

