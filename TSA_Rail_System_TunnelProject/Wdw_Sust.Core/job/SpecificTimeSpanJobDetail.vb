Imports Wdw_Sust.Core.Interfaces

Namespace Job
    Public Class SpecificTimeSpanJobDetail
        Inherits JobDetailBase
        Implements ISpecificTimeSpanJobDetail

        Private _nextUpdate As Date

        Public Property RunFromHour As Integer Implements ISpecificTimeSpanJobDetail.RunFromHour
        Public Property RunFromMinute As Integer Implements ISpecificTimeSpanJobDetail.RunFromMinute
        Public Property RunFromSecond As Integer Implements ISpecificTimeSpanJobDetail.RunFromSecond
        Public ReadOnly Property StartDateTime As Date Implements ISpecificTimeSpanJobDetail.StartDateTime

        Public Property TimeSpanRunTime As TimeSpan Implements ITimeSpanJobDetail.TimeSpanRunTime
        Public ReadOnly Property NextUpdate As Date Implements ISpecificTimeSpanJobDetail.NextUpdate
            Get
                If _nextUpdate < Now() Then
                    _nextUpdate = GetNextUpdate()
                End If
                Return _nextUpdate
            End Get
        End Property

        Private Function GetNextUpdate() As Date
            Dim time As Date = LastUpdate
            Do
                time = time.Add(TimeSpanRunTime)
            Loop While Now.Subtract(time) > TimeSpanRunTime
            Return time.Add(TimeSpanRunTime)
        End Function
        
        Public Sub New(runFromHour As Integer, runFromMinute As Integer, runFromSecond As Integer, runFrequency As TimeSpan, jobName As String, jobToPerform As Action)
            Me.RunFromHour = runFromHour
            Me.RunFromMinute = runFromMinute
            Me.RunFromSecond = runFromSecond
            Me.JobName = jobName
            DefineJob(jobToPerform, Nothing)
            _startDateTime = Today.AddHours(runFromHour).AddMinutes(runFromMinute).AddSeconds(runFromSecond)
            _nextUpdate = IIf(StartDateTime > Now, StartDateTime, StartDateTime.Add(runFrequency))
            LastUpdate = StartDateTime
            Me.TimeSpanRunTime = runFrequency
        End Sub
    End Class
End NameSpace