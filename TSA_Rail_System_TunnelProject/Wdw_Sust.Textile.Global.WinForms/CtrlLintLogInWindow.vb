Imports System.Drawing
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.WinForms.Core

Public Class CtrlLintLogInWindow
    Inherits CtrlFormBase

#Region "Fields"

    Private _counter As Integer = 0
    Private _card As RfidCard
    Private _readTimeOut As Integer

#End Region

#Region "Properties"

    Public ReadOnly Property RfidCard() As RfidCard
        Get
            Return _card
        End Get
    End Property

#End Region

#Region "Methods"

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Timer1.Enabled = False
        Close()
    End Sub

    Private Sub ButtonSubmit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubmit.Click
        If MaskedTextBox1.Text <> String.Empty AndAlso (IsNumeric(MaskedTextBox1.Text) AndAlso CLng(MaskedTextBox1.Text) <= Integer.MaxValue) Then
            _card = Factory.LintInfo.GetCardInfoWithUserDetailsByEmployeeNumber(CInt(MaskedTextBox1.Text))
            If _card IsNot Nothing AndAlso _card.RFBadgeUserID = 0 Then
                _card.RFBadgeUserID = -1
            End If
            Close()
        Else
            MsgBox("Password should contain only numbers")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick

        If _counter Mod 2 = 0 Then
            Label1.ForeColor = Color.Black
        Else
            Label1.ForeColor = Color.Red
        End If
        _counter += 1

        'Close the form if the serial port read is time out
        If _counter * Timer1.Interval >= _readTimeOut Then
            _card = Nothing
            Close()
        End If
    End Sub

    Protected Overrides Sub OnShown(e As System.EventArgs)
        MaskedTextBox1.Focus()
    End Sub
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        With Timer1
            .Interval = 1000
            .Enabled = True
        End With
    End Sub

#End Region

#Region "Constructors"

    Public Sub New(Optional readTimeOut As Integer = 15000)
        InitializeComponent()
        _readTimeOut = readTimeOut
    End Sub

#End Region

End Class

