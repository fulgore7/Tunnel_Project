Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintAlarmParameter
    Inherits LintObjectBase(Of LintAlarmParameter)

#Region "Properties"

    Public Property AlarmCritical As Boolean
    Public Property AlarmDelayBeforeResendMessage As Integer
    Public Property AlarmDepartment As Integer
    Public Property AlarmDescription As String
    Public Property AlarmEnabled As Boolean
    Public Property AlarmFaultType As Integer
    Public Property AlarmGlobalID As Integer
    Public Property AlarmHyperLink As String
    Public Property AlarmMachine As Integer
    Public Property AlarmMessageType As Integer
    Public Property AlarmOnStatusDeadband As Integer
    Public Property AlarmPlant As Plant
    Public Property AlarmSeverityLevel As Integer
    Public Property AlarmSourceID As Integer
    Public Property AlarmSystem As Integer
    Public Property AlarmSystemComponent As Integer
    Public Property AlarmSystemID As Integer
    Public Property AlarmWorkflowSystemDiagnosticsGroup As Integer
    Public Property AlarmZone As Integer

#End Region

#Region "Constructors"

    Public Sub New(ByVal reader As IDataReader)
        AlarmGlobalID = FixNull(Of Integer)(reader("Alarm_Global_ID"), 0)
        AlarmSystemID = FixNull(Of Integer)(reader("Alarm_System_ID"), 0)
        AlarmPlant = FixNull(Of Integer)(reader("Alarm_Plant"))
        AlarmSystem = FixNull(Of Integer)(reader("Alarm_System"), 0)
        AlarmZone = FixNull(Of Integer)(reader("Alarm_Zone"), 0)
        AlarmDepartment = FixNull(Of Integer)(reader("Alarm_Department"), 0)
        AlarmSystemComponent = FixNull(Of Integer)(reader("Alarm_System_Component"), 0)
        AlarmMachine = FixNull(Of Integer)(reader("Alarm_Machine"), 0)
        AlarmDescription = FixNull(Of String)(reader("Alarm_Description"), String.Empty)
        AlarmCritical = FixNull(Of Boolean)(reader("Alarm_Critical"))
        AlarmMessageType = FixNull(Of Integer)(reader("Alarm_Message_Type"), 0)
        AlarmSeverityLevel = FixNull(Of Integer)(reader("Alarm_Severity_Level"), 0)
        AlarmFaultType = FixNull(Of Integer)(reader("Alarm_Fault_Type"), 0)
        AlarmOnStatusDeadband = FixNull(Of Integer)(reader("Alarm_On_Status_Deadband"), 0)
        AlarmDelayBeforeResendMessage = FixNull(Of Integer)(reader("Alarm_Delay_Before_Resend_Message"), 0)
        AlarmWorkflowSystemDiagnosticsGroup = FixNull(Of Integer)(reader("Alarm_Workflow_System_Diagnostics_Group"), 0)
        AlarmEnabled = FixNull(Of Boolean)(reader("Alarm_Enabled"))
        AlarmHyperLink = FixNull(Of String)(reader("Alarm_Hyperlink"), String.Empty)
        AlarmSourceID = FixNull(Of Integer)(reader("Alarm_Source"))
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class