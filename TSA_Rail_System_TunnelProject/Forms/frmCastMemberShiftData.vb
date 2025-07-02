Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Tsa.Wcf
Imports DevExpress.XtraPivotGrid

Public Class frmCastMemberShiftData
    Inherits CtrlFormBase

    Private _castData As List(Of LintCastMemberProductivityElectronicBoardData)
    Private ReadOnly _shiftClock As LintShiftClock

    Private Sub chkAutoUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoUpdate.CheckedChanged
        ChangeJobStatusIfDefined("GetAutomaticCastMemberElectronicData", chkAutoUpdate.Checked)
    End Sub

    Private Sub RefreshData()
        Dim shiftData As LintShiftData = _shiftClock.GetCurrentShiftData()
        If shiftData IsNot Nothing Then
            If TryAction(Sub() _castData = BllRailInfoProvider.Instance.Service.GetCastShiftProductivityData(shiftData)) Then InvokeIfNeeded(Of LintShiftData)(AddressOf UpdateScreen, shiftData)
        End If
    End Sub

    Private Sub UpdateScreen(ByVal shiftData As LintShiftData)
        Text = String.Format("Cast Member Productivity - {0} (Start at: {1}, Shift Time: {2:F2} hrs)", shiftData.Shift, shiftData.ShiftStartTime.ToShortTimeString, shiftData.GetCurrentShiftTimeSoFarInHours)
        LINTCastMemberProductivityElectronicBoardDataBindingSource.DataSource = _castData
    End Sub

    Public Sub New(ByVal shiftClock As LintShiftClock)
        InitializeComponent()
        If CONFIGURATION.IsFailOverMode Then
            MsgBox("Program is in fail over mode!! No data is available. Please try again when the program is in production mode!!")
        Else
            _shiftClock = shiftClock
            AddJob("GetAutomaticCastMemberElectronicData", New TimeSpan(0, 2, 0), AddressOf RefreshData, False)
            ChangeJobStatusIfDefined("GetAutomaticCastMemberElectronicData", chkAutoUpdate.Checked)
            RefreshData()
        End If
    End Sub

    Protected Overrides Sub ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode Then InvokeIfNeeded(AddressOf Close)
    End Sub

    Private Sub PivotGridControl2_CustomSummary(sender As Object, e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl2.CustomSummary

        If e.FieldName = "LoginTimeInMinutes" Then
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource

            e.CustomValue = CDbl(CInt(e.SummaryValue.Summary) / 60)
        End If
    End Sub
End Class