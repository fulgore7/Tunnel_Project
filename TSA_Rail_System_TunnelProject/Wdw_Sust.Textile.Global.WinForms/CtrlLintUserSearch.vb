Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Rostr

Friend Class CtrlLintUserSearch
    Inherits CtrlFormBase

#Region "Fields"
    Private _employeeList As List(Of LintCastMember)
    Private ReadOnly _rostr As RostrClient
#End Region

#Region "Events"
    Public Event _NameFound(ByVal sender As Object, ByVal castName As String)
#End Region

#Region "Properties"
    Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider
        Return LintFactoryProvider.Instance
    End Function
    'Private Shared ReadOnly Property LINT As LintInfoProvider
    '    Get
    '        Return LintInfoProvider.Instance
    '    End Get
    'End Property

#End Region

#Region "Methods"

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub ButtonFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFind.Click
        ListBoxNameReturn.Items.Clear()
        Dim listOfNames As Array
        Dim searchCriteria As String = Trim(TextBoxFind.Text)
        Dim tempCast As LintCastMember = Nothing
        If RadioButtonRFIDCard.Checked AndAlso IsNumeric(searchCriteria) Then
            tempCast = _employeeList.FirstOrDefault(Function(a) a.RFBadgeUserID = CInt(searchCriteria))
            If tempCast IsNot Nothing Then
                RaiseNameFoundEvent(tempCast.EmployeeName)
            Else
                MsgBox("Criteria entered does not return any result. Try again!!")
            End If
        ElseIf RadioButtonPersonelNumber.Checked AndAlso IsNumeric(searchCriteria) Then
            tempCast = _employeeList.FirstOrDefault(Function(a) a.EmployeeID = CInt(searchCriteria))
            If tempCast IsNot Nothing Then
                RaiseNameFoundEvent(tempCast.EmployeeName)
            Else
                MsgBox("Criteria entered does not return any result. Try again!!")
            End If
        ElseIf RadioButtonEmployeeName.Checked Then
            listOfNames = (From cast As LintCastMember In _employeeList Where cast.EmployeeName.ToLower.Contains(searchCriteria.ToLower) Select cast.EmployeeName).ToArray
            If listOfNames.Length = 0 Then
                MsgBox("Criteria entered does not return any result. Try again!!")
                Exit Sub
            ElseIf listOfNames.Length = 1 Then
                RaiseNameFoundEvent(listOfNames(0))
            End If
            ListBoxNameReturn.Items.AddRange(listOfNames)
        End If
    End Sub

    Private Sub LinkOpenRFIDReader_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkOpenRFIDReader.LinkClicked
        RadioButtonEmployeeName.Checked = False
        RadioButtonPersonelNumber.Checked = False
        RadioButtonRFIDCard.Checked = False
        Dim card As RfidCard = ReadFromRfid(CONFIGURATION.SecuraKeyComportSettings)
        If card IsNot Nothing AndAlso card.CastInfo.EmployeeName IsNot Nothing Then
            RaiseNameFoundEvent(card.CastInfo.EmployeeName)
        Else
            MsgBox("Criteria entered does not return any result. Try again!!")
            Exit Sub
        End If
    End Sub

    Private Sub ListBoxNameReturn_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxNameReturn.DoubleClick
        RaiseNameFoundEvent(CStr(ListBoxNameReturn.SelectedItem))
    End Sub

    Private Sub RadioButtonSelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonEmployeeName.CheckedChanged, RadioButtonPersonelNumber.CheckedChanged, RadioButtonRFIDCard.CheckedChanged
        TextBoxFind.Text = String.Empty
        TextBoxFind.Focus()
    End Sub

    Private Sub RaiseNameFoundEvent(ByVal castName As String)
        RaiseEvent _NameFound(Me, castName)
        Close()
    End Sub

#End Region

#Region "Constructors"
    Public Sub New(ByVal employeeList As List(Of LintCastMember), rostrToken As string)
        InitializeComponent()
        _rostr = new RostrClient(rostrToken)
        _employeeList = employeeList
    End Sub
#End Region
End Class

