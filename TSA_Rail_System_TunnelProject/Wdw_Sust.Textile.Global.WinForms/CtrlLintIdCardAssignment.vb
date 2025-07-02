Imports System.Drawing
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Dal
Imports System.Windows.Forms

Friend Class CtrlLintIdCardAssignment
    Inherits CtrlFormBase

#Region "Fields"
    Private _castInfo As LintCastMember
#End Region

#Region "Events"
    Public Event _Card_Assignment_Completed As EventHandler
    Public Event _Card_Assignment_Exception As EventHandler
    Public Event _WriteRF(ByVal RFBadgeUserID As Integer)
    Public Event _Refresh()
#End Region

#Region "Methods"
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFirstName.TextChanged
        If tbFirstName.Text <> String.Empty Then
            btnStep2.Enabled = True
            btnStep1.BackColor = Color.GreenYellow
            CheckBox1.Checked = True
        Else
            btnStep2.Enabled = False
            btnStep1.BackColor = Color.Transparent
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbIDNumber.TextChanged
        If tbIDNumber.Text <> "" Or tbScanIDNumber.Text <> "" Then
            btnStep3.Enabled = True
            CheckBox1.Checked = True
            btnStep2.BackColor = Color.GreenYellow
            CheckBox2.Checked = True
        Else
            btnStep3.Enabled = False
            CheckBox1.Checked = False
            CheckBox2.Checked = True
            btnStep2.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbScanIDNumber.TextChanged
        If tbIDNumber.Text <> String.Empty Then
            If GroupBoxReason.Visible = False Then btnAssignCard.Enabled = True
            btnStep3.BackColor = Color.GreenYellow
        Else
            If GroupBoxReason.Visible = False Then btnAssignCard.Enabled = False
            btnStep3.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub ComboBoxReason_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbReason.TextChanged
        btnAssignCard.Enabled = Not (cmbReason.Text = String.Empty)
    End Sub

    Private Sub btnAssignCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignCard.Click
        If Not tbIDNumber.Text = tbScanIDNumber.Text Then
            Dim result As DialogResult = MessageBox.Show("Card does not match the id selected, would you like to program the card now?", "Card does not match", MessageBoxButtons.YesNoCancel)

            If (DialogResult.OK) Then
                WriteRfid(tbIDNumber.Text, CONFIGURATION.SecuraKeyComportSettings)

                Dim number = ReadFromRfid(CONFIGURATION.SecuraKeyComportSettings).RFBadgeUserID
                tbScanIDNumber.Text = number

                HandleCardAssignment()
            ElseIf (DialogResult.No Or DialogResult.Cancel) Then
                Exit Sub
            End If
        Else
            HandleCardAssignment()
        End If
    End Sub

    Private Sub HandleCardAssignment()
        Dim cardAssignmentReason As CardAssignmentReason = ExtractNumbers(cmbReason.Text)
        Dim card As New RfidCard
        With card
            .RFBadgeUserID = CInt(tbScanIDNumber.Text)
            .CastInfo.FirstName = tbFirstName.Text
            .CastInfo.LastName = tbLastName.Text
            .TimeIssued = Now
            .IsCardValid = 1
        End With
        Dim isSuccessful As Boolean = Factory.LintInfo.UpdateCardInfo(card, _castInfo.RFBadgeUserID, cardAssignmentReason)
        If isSuccessful Then
            MsgBox("Card assignment has been completed!!")
            Factory.LintInfo.AddLog(_castInfo.EmployeeID, CInt(tbIDNumber.Text), String.Format("Card Assigned To {0}", tbFirstName.Text))
            RaiseEvent _Card_Assignment_Completed(Me, System.EventArgs.Empty)
            RaiseEvent _WriteRF(CInt(tbIDNumber.Text))
            RaiseEvent _Refresh()
        Else
            MsgBox("Database connection issue!! Try again in a little while!!")
            Factory.LintInfo.AddLog(_castInfo.EmployeeID, CInt(tbIDNumber.Text), String.Format("Card Assigned To {0} Is Not Successful", tbFirstName.Text))
            RaiseEvent _Card_Assignment_Exception(Me, System.EventArgs.Empty)
        End If
        Close()
    End Sub

    Private Sub btnStep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep2.Click
        Using frm As New CtrlLintIdCardList(_castInfo, FormMode.ADD)
            AddHandler frm._CardNumberChosen, Sub(sdr, cardNumber) tbIDNumber.Text = cardNumber
            'AddHandler frm._refresh, AddressOf 
            AddHandler frm._Refresh, Sub() RaiseEvent _Refresh()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnStep3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep3.Click
        Dim card As RfidCard = ReadFromRfid(CONFIGURATION.SecuraKeyComportSettings)
        If card IsNot Nothing Then
            tbScanIDNumber.Text = card.RFBadgeUserID
            GroupBoxReason.Enabled = True
        End If
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
#End Region

#Region "Control Click Events"
#End Region

#Region "Properties"
    Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider
        Return LintFactoryProvider.Instance
    End Function
    'Public Property RFIDCardAssignment() As RFIDCard
    '    Get
    '        Return _rfidCard
    '    End Get
    '    Set(ByVal value As RFIDCard)
    '        _rfidCard = value
    '    End Set
    'End Property

    'Public Shared ReadOnly Property LINT As LintInfoProvider
    '    Get
    '        Return LintInfoProvider.Instance
    '    End Get
    'End Property

#End Region

#Region "Constructors"
    Public Sub New(ByVal castInfo As LintCastMember, ByVal firstNameToShow As String, ByVal lastNameToShow As String)
        InitializeComponent()
        _castInfo = castInfo
        tbFirstName.Text = firstNameToShow
        tbLastName.Text = lastNameToShow
    End Sub

    Public Sub New(ByVal castToAssign As LintCastMember, ByVal castToBeAssigned As LintCastMember)
        InitializeComponent()
        _castInfo = castToAssign
        tbFirstName.Text = castToBeAssigned.FirstName
        tbLastName.Text = castToBeAssigned.LastName
    End Sub
#End Region

End Class

