Imports Wdw_Sust.Core.Interfaces

Namespace Job

    Public NotInheritable Class JobManager
        Inherits JobManagerBase

        Protected Overrides Sub ProcessJobs()
            Dim time As Date = Now
            For Each job As IJobDetail In _listOfJobDetails
                If Not job.MarkForRemoval AndAlso job.IsEnabled AndAlso Not job.IsBusy Then
                    If TypeOf job Is ISpecificRunTimeJobDetail Then
                        Dim j As ISpecificRunTimeJobDetail = CType(job, ISpecificRunTimeJobDetail)
                        For Each run As JobRunTime In j.ListOfRunTime
                            If run.DayOfWeek = time.DayOfWeek AndAlso run.Hour = time.Hour AndAlso run.Minute = time.Minute AndAlso run.Second = time.Second Then
                                ExecuteJob(job)
                                Continue For
                            End If
                        Next
                    ElseIf TypeOf job Is ITimeSpanJobDetail Then
                        Dim detail As ITimeSpanJobDetail = job
                        If Math.Round(time.Subtract(detail.LastUpdate).TotalMilliseconds) >= detail.TimeSpanRunTime.TotalMilliseconds Then
                            'Console.WriteLine("{0} - {1}", detail.JobName, Math.Round(time.Subtract(detail.LastUpdate).TotalMilliseconds))
                            ExecuteJob(job)
                            Continue For
                        End If
                    End If
                Else
                    If job.IsBusy Then Console.WriteLine("the job {0} currently is busy and cannot be executed again", job.JobName)
                End If
            Next
        End Sub

        Public Overrides Function AddJob(jobDetail As IJobDetail, Optional runImmediately As Boolean = False) As IJobDetail
            If TypeOf jobDetail Is ITimeSpanJobDetail Then
                If CType(jobDetail, ITimeSpanJobDetail).TimeSpanRunTime.TotalSeconds < 1 Then Throw New ArgumentException("Lowest resolution for frequency is 1 second")
            End If
            Return MyBase.AddJob(jobDetail, runImmediately)
        End Function
    End Class

End Namespace


