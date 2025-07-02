
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Tsa.Wcf

Public Class frmWashdeckProductivity
    Inherits CtrlOpcRailFormBase

    Private _washdeckData As List(Of LintWashdeckProductivityData)
    Private _shiftClock As LintShiftClock
    Private ReadOnly _header As String = "Washdeck Productivity - {0} (Start at: {1}, Shift Time: {2:F2} hrs)"

    Private Sub chkAutoUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoUpdate.CheckedChanged
        ChangeJobStatusIfDefined(SR.JOB_GET_WASHDECK_AUTOMATIC_PRODUCTIVITY_UPDATE, chkAutoUpdate.Checked)
    End Sub

    Private Sub RefreshData()
        Dim shiftData As LintShiftData = _shiftClock.GetCurrentShiftData
        If shiftData IsNot Nothing Then
            _washdeckData = BllRailInfoProvider.Instance.Service.GetWashdeckProductivityData(shiftData)
            InvokeIfNeeded(AddressOf UpdateScreen, shiftData)
        End If
    End Sub

    'Protected Overrides Sub OnCheckedAccessRight(sender As Object, e As Security.EventArgs.IRailAccessRightEventArgs)
    '    e.HasRight = False
    '    e.Message = "The bag cannot be edited"
    'End Sub

    Private Sub UpdateScreen(ByVal shiftData As LintShiftData)
        Text = String.Format(_header, shiftData.Shift, shiftData.ShiftStartTime.ToShortTimeString, shiftData.GetCurrentShiftTimeSoFarInHours)
        TSAWashdeckProductivityDataBindingSource.DataSource = _washdeckData
    End Sub

    Protected Overrides Sub Initialize()
        AddJob(SR.JOB_GET_WASHDECK_AUTOMATIC_PRODUCTIVITY_UPDATE, New TimeSpan(0, 0, 30), AddressOf RefreshData, False)
        ChangeJobStatusIfDefined(SR.JOB_GET_WASHDECK_AUTOMATIC_PRODUCTIVITY_UPDATE, chkAutoUpdate.Checked)
        RefreshData()
    End Sub

    Public Sub New(ByVal shiftClock As LintShiftClock)
        InitializeComponent()
        If CONFIGURATION.IsFailOverMode Then
            MsgBox(SR.WARNING_FEATURE_NOT_AVAILABLE_IN_FAIL_OVER_MODE)
        Else
            _shiftClock = shiftClock
        End If
    End Sub

    Protected Overrides Sub ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode Then InvokeIfNeeded(AddressOf Close)
    End Sub
End Class