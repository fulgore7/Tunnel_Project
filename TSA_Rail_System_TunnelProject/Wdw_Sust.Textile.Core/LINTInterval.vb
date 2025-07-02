
<Serializable()>
Public Class LintInterval

#Region "Properties"
    Public Property StartHour As Integer
    Public Property StartMinute As Integer
    Public Property DurationInHours As Double
#End Region

#Region "Methods"
    Public Sub SetInterval(ByVal startHour As Integer, ByVal startMinute As Integer, ByVal durationInHours As Double)
        Me.StartHour = startHour
        Me.StartMinute = startMinute
        Me.DurationInHours = durationInHours
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(ByVal startHour As Integer, ByVal startMinute As Integer, ByVal durationInHours As Double)
        SetInterval(startHour, startMinute, durationInHours)
    End Sub
#End Region

End Class

