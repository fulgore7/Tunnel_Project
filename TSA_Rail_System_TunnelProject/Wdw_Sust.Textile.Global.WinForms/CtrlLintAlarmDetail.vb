Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Interfaces

Public Class CtrlLintAlarmDetails
    Inherits CtrlFormBase

#Region "Fields"
    Private _alarmID As Integer
    Private _alarm As LintAlarmParameter
    Private _alarmProvider As ILintAlarmProvider
#End Region

#Region "Methods"
    Protected Overrides Sub Initialize()
        If _alarmID > 0 Then _alarm = _alarmProvider.GetAlarmParameters.Find(Function(a) a.AlarmGlobalID = _alarmID)
        LINTSystemBindingSource.DataSource = _alarmProvider.GetAlarmSystemComponents
        LINTZoneBindingSource.DataSource = _alarmProvider.GetAlarmZones
        LINTDepartmentBindingSource.DataSource = _alarmProvider.GetAlarmDepartments
        LINTSourceBindingSource.DataSource = _alarmProvider.GetAlarmSources
        LINTAlarmParameterBindingSource.DataSource = _alarmProvider.GetAlarmParameters
        LINTComponentBindingSource.DataSource = _alarmProvider.GetAlarmSystemComponents
        LINTMessageTypeBindingSource.DataSource = _alarmProvider.GetAlarmMessageTypes
        LINTFaultTypeBindingSource.DataSource = _alarmProvider.GetAlarmFaultTypes
        LINTAlarmSeverityTypeBindingSource.DataSource = _alarmProvider.GetAlarmFaultSeverities
        LINTAlarmParameterBindingSource.DataSource = _alarm
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub ApplicationModeChanged()
        MyBase.ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode Then Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click
        _alarmProvider.UpdateAlarmParameter(_alarm)
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(ByVal alarmProvider As ILintAlarmProvider, ByVal alarmGlobalID As Integer)
        InitializeComponent()
        If alarmProvider Is Nothing Then Throw New ArgumentNullException(NameOf(alarmProvider))
        _alarmID = alarmGlobalID
        _alarmProvider = alarmProvider
    End Sub

    Public Sub New(ByVal alarm As LintAlarmParameter)
        InitializeComponent()
        _alarm = New LintAlarmParameter
    End Sub
#End Region

End Class



