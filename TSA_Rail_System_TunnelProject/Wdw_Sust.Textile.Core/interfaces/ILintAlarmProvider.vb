Imports System.Data
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core

Namespace Interfaces
    Public Interface ILintAlarmProvider
        Inherits IHaveConnectionString
        Sub UpdateLINTAlarmStatus(ByVal alarmID As Integer, ByVal alarmActive As Boolean, ByVal startTime As DateTime, ByVal statusCode As Integer, Optional ByVal connectionString As String = "")
        Sub UpdateAlarmParameter(ByVal parameter As LintAlarmParameter)
        Function GetAlarmParameters() As List(Of LintAlarmParameter)
        Function GetLintActiveAlarms(ByVal plant As Plant) As List(Of LintAlarm)
        Function GetAlarmHistory(ByVal alarmGlobalID As Integer, ByVal startTime As Date, ByVal endTime As Date) As List(Of LintAlarmDetail)
        Function GetAlarmZones() As List(Of LintNameValuePair)
        Function GetAlarmDepartments() As List(Of LintNameValuePair)
        Function GetAlarmSources() As List(Of LintNameValuePair)
        Function GetAlarmFaultSeverities() As List(Of LintNameValuePair)
        Function GetAlarmFaultTypes() As List(Of LintNameValuePair)
        Function GetAlarmSystemOrigins() As List(Of LintNameValuePair)
        Function GetAlarmMessageTypes() As List(Of LintNameValuePair)
        Function GetAlarmSystemComponents() As List(Of LintNameValuePair)
        Function GetCriticalAlarms() As List(Of LintAlarmParameter)
        Function GetTsaAlarmsFromReader(ByVal reader As IDataReader) As List(Of LintAlarmLogDetail)
        Function GetTsaAlarmFromReader(ByVal reader As IDataReader) As LintAlarmLogDetail
        Function GetLintActiveInternalAlarms() As List(Of LintAlarm)
    End Interface
End Namespace
