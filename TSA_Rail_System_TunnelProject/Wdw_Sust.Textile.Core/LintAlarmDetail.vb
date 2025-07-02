<Serializable()>
Public Class LintAlarmDetail
    Inherits LintObjectBase(Of LintAlarmDetail)

#Region "Fields"

    Private _alarmDescription As String
    Private _alarmEndTime As DateTime
    Private _alarmGlobalID As Integer
    Private _alarmStartTime As DateTime

#End Region

#Region "Properties"

    Public Property AlarmDescription() As String
        Get
            Return _alarmDescription
        End Get
        Set
            _alarmDescription = Value
        End Set
    End Property

    Public Property AlarmEndTime() As DateTime
        Get
            Return _alarmEndTime
        End Get
        Set
            _alarmEndTime = Value
        End Set
    End Property

    Public Property AlarmGlobalID() As Integer
        Get
            Return _alarmGlobalID
        End Get
        Set
            _alarmGlobalID = Value
        End Set
    End Property

    Public Property AlarmStartTime() As DateTime
        Get
            Return _alarmStartTime
        End Get
        Set
            _alarmStartTime = Value
        End Set
    End Property

    Public ReadOnly Property DurationInMinutes() As Double
        Get
            Return _alarmEndTime.Subtract(_alarmStartTime).TotalMinutes
        End Get
    End Property

#End Region



#Region "Constructors"

    Public Sub New(reader As IDataReader)

        _alarmGlobalID = reader("Alarm_Global_ID")
        _alarmDescription = reader("Alarm_Description")
        _alarmStartTime = reader("Alarm_Start_Time")
        _alarmEndTime = reader("Alarm_End_Time")

    End Sub

    Public Sub New()

    End Sub

#End Region

End Class