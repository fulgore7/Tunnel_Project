Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Sort

<Serializable(), DefaultSortByProperty("AlarmStartTime", SortDirection.DESC)>
Public Class LintAlarm
    Inherits LintObjectBase(Of LintAlarm)

#Region "Fields"

    Private _durationInSeconds As Integer

#End Region

#Region "Properties"

    Public Property AlarmDescription() As String
    Public Property AlarmID() As Integer

    Public ReadOnly Property AlarmPlant As Plant
        Get
            If AlarmID >= 100000 AndAlso AlarmID <= 199999 Then
                Return Plant.TSA
            ElseIf AlarmID >= 200000 AndAlso AlarmID < 299999 Then
                Return Plant.NSA
            ElseIf AlarmID >= 300000 AndAlso AlarmID < 399999 Then
                Return Plant.ASA
            Else
                Return Plant.UNKNOWN
            End If
        End Get
    End Property

    Public Property AlarmSeverity() As Integer
    Public Property AlarmStartTime() As Date

    Public ReadOnly Property DisplayAlarmDuration() As String
        Get
            If DurationInSeconds < 3600 Then
                Return String.Format("{0:F2} minutes", DurationInSeconds / 60.0)
            ElseIf DurationInSeconds > 86400 Then  ' =  (3600 * 24) 
                Return String.Format("{0:F2} days", DurationInSeconds / 86400.0)
            Else
                Return String.Format("{0:F2} hours", DurationInSeconds / 3600.0)
            End If
        End Get
    End Property

    Public ReadOnly Property DurationInSeconds() As Integer
        Get
            Return _durationInSeconds
        End Get
    End Property

    Public Property IsAlarmActive() As Boolean
    Public Property SystemDescription() As String
    Public Property SystemID() As LintSystemOrigin
    Public Property ZoneDescription() As String
    Public Property ZoneID() As LintZone

#End Region

#Region "Methods"

    Public Overrides Function ToString() As String
        Return String.Format("{0}-{1}-{2}", AlarmPlant.ToString, AlarmDescription, DisplayAlarmDuration)
    End Function

#End Region

#Region "Constructors"

    Public Sub New(alarmID As Integer, alarmDescription As String, isAlarmActive As Boolean, alarmStartTime As DateTime, zoneDescription As String, systemDescription As String)
        _AlarmID = alarmID
        _AlarmDescription = alarmDescription
        _IsAlarmActive = isAlarmActive
        _AlarmStartTime = alarmStartTime
        _durationInSeconds = Now.Subtract(alarmStartTime).TotalSeconds
        _ZoneDescription = zoneDescription
        _SystemDescription = systemDescription
    End Sub

    Public Sub New(reader As IDataReader)
        _AlarmID = reader("Alarm_Global_ID")
        _AlarmDescription = reader("Alarm_Description")
        _IsAlarmActive = reader("Alarm_Active")
        _AlarmStartTime = reader("Alarm_Start_Time")
        _durationInSeconds = Now.Subtract(_AlarmStartTime).TotalSeconds
        _ZoneDescription = reader("Zone_Description")
        _SystemDescription = reader("System_Description")
        _ZoneID = reader("Zone_ID")
        _SystemDescription = reader("System_ID")
        _AlarmSeverity = reader("Alarm_Severity")
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class