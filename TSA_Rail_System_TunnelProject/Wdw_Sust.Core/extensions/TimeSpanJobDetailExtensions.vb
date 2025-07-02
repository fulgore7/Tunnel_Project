Imports System.Runtime.CompilerServices
Imports Wdw_Sust.Core.Interfaces

Namespace Extensions
    Public Module TimeSpanJobDetailExtensions
        <Extension>
        Public Function ToEnableJob(ByVal job As ITimeSpanJobDetail) As ITimeSpanJobDetail
            job.IsEnabled = True
            Return job
        End Function
        <Extension>
        Public Function NameEquals(ByVal job As ITimeSpanJobDetail, jobName As String) As ITimeSpanJobDetail
            job.JobName = jobName
            Return job
        End Function
        <Extension>
        Public Function RunEvery(ByVal job As ITimeSpanJobDetail, ByVal timeSpan As TimeSpan) As ITimeSpanJobDetail
            job.TimeSpanRunTime = timeSpan
            Return job
        End Function
    End Module
End Namespace
