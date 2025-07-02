Public Class LintAlarmLogDetail

#Region "Properties"
    Public Property AlarmAcknowledgedBy() As Integer
    Public Property AlarmAcknowledgeTime() As DateTime
    Public Property AlarmActive() As Boolean
    Public Property AlarmDescription() As String
    Public Property AlarmDuration() As Integer
    Public Property AlarmEndTime() As DateTime
    Public Property AlarmGlobalID() As Integer
    Public Property AlarmID() As Integer
    Public Property AlarmPlant() As Integer
    Public Property AlarmStartTime() As DateTime
    Public Property AlarmStatus() As Integer
#End Region

#Region "Constructors"
    Sub New(ByVal alarmAcknowledgedBy As Integer, ByVal alarmAcknowledgeTime As Date, ByVal alarmActive As Boolean, ByVal alarmDescription As String, ByVal alarmDuration As Integer,
            ByVal alarmEndTime As Date, ByVal alarmGlobalID As Integer, ByVal alarmID As Integer, ByVal alarmPlant As Integer, ByVal alarmStartTime As Date, ByVal alarmstatus As Integer)
        Me.AlarmAcknowledgedBy = alarmAcknowledgedBy
        Me.AlarmAcknowledgeTime = alarmAcknowledgeTime
        Me.AlarmActive = alarmActive
        Me.AlarmDescription = alarmDescription
        Me.AlarmEndTime = alarmEndTime
        Me.AlarmGlobalID = alarmGlobalID
        Me.AlarmID = alarmID
        Me.AlarmPlant = alarmPlant
        Me.AlarmStartTime = alarmStartTime
        Me.AlarmStatus = alarmstatus
    End Sub
#End Region

End Class
