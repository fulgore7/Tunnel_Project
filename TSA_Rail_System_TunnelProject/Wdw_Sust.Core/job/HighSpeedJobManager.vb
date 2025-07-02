' ***********************************************************************
' Assembly         : Wdw_Sust.Core
' Author           : yeunc009
' Created          : 01-20-2017
'
' Last Modified By : yeunc009
' Last Modified On : 01-20-2017
' ***********************************************************************
' <copyright file="HighSpeedJobManager.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Imports Wdw_Sust.Core.Interfaces

Namespace Job
    ''' <summary>
    ''' Class HighSpeedJobManager. This class cannot be inherited.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Job.JobManagerBase" />
    Public NotInheritable Class HighSpeedJobManager
        Inherits JobManagerBase

        ''' <summary>
        ''' Gets the tick resolution.
        ''' </summary>
        ''' <value>The tick resolution.</value>
        Public ReadOnly Property TickResolution As Integer
            Get
                Return TimerManager.TimerInterval
            End Get
        End Property

        ''' <summary>
        ''' Initializes a new instance of the <see cref="HighSpeedJobManager" /> class.
        ''' </summary>
        ''' <param name="tickIntervalInMilliseconds">The tick interval in milliseconds.</param>
        Public Sub New(ByVal tickIntervalInMilliseconds As Integer)
            TimerManager.TimerInterval = tickIntervalInMilliseconds
        End Sub

        ''' <summary>
        ''' Gets or sets the tick resolution threshold.
        ''' </summary>
        ''' <value>The tick resolution threshold.</value>
        Public Property TickResolutionThreshold As Long = 1000000 '100 ms

        ''' <summary>
        ''' Each tick will call <code>ProcessJobs()</code>
        ''' </summary>
        Protected Overrides Sub ProcessJobs()
            Dim start As Long = Now.Ticks
            Dim time As DateTime = Now
            For Each job As IJobDetail In _listOfJobDetails
                If Now.Subtract(LastTickTime).Ticks >= TickResolution Then Exit For
                If Not job.MarkForRemoval AndAlso job.IsEnabled AndAlso Not job.IsBusy Then
                    If TypeOf job Is ISpecificRunTimeJobDetail Then
                        Dim j As ISpecificRunTimeJobDetail = CType(job, ISpecificRunTimeJobDetail)
                        For Each run As JobRunTime In j.ListOfRunTime
                            If run.DayOfWeek = time.DayOfWeek AndAlso run.Hour = time.Hour AndAlso run.Minute = time.Minute AndAlso run.Second = time.Second AndAlso Now.Subtract(job.LastUpdate).TotalSeconds > 1 Then
                                ExecuteJob(job)
                                Continue For
                            End If
                        Next
                    ElseIf TypeOf job Is ITimeSpanJobDetail Then
                        Dim detail As ITimeSpanJobDetail = job
                        If time.Subtract(detail.LastUpdate).Ticks >= detail.TimeSpanRunTime.Ticks Then
                            Dim delta As Double = CDbl(time.Subtract(detail.LastUpdate).Ticks / detail.TimeSpanRunTime.Ticks)
                            Console.WriteLine("{0} - {1}", detail.JobName, CDbl(time.Subtract(detail.LastUpdate).Ticks))
                            'Console.WriteLine("{0} - {1}", detail.JobName, delta.ToString("P"))
                            ExecuteJob(job)
                            Continue For
                        End If
                    End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' Adjusts the timer resolution.
        ''' </summary>
        ''' <param name="jobDetail">The job detail.</param>
        Private Sub AdjustTimerResolution(ByVal jobDetail As ITimeSpanJobDetail)
            'If jobDetail.TimeSpanRunTime.TotalMilliseconds < CDbl(TickResolution) Then TimerManager.TimerInterval = jobDetail.TimeSpanRunTime.TotalMilliseconds
            TimerManager.TimerInterval = 100
        End Sub

        ''' <summary>
        ''' Adds the job.
        ''' </summary>
        ''' <param name="jobDetail">The job detail.</param>
        ''' <param name="runImmediately">if set to <c>true</c> [run immediately].</param>
        ''' <returns>IJobDetail.</returns>
        Public Overrides Function AddJob(jobDetail As IJobDetail, Optional runImmediately As Boolean = False) As IJobDetail
            Dim job As IJobDetail = MyBase.AddJob(jobDetail, runImmediately)
            'If job IsNot Nothing AndAlso TypeOf jobDetail Is ITimeSpanJobDetail Then AdjustTimerResolution(job)
            Return job
        End Function
    End Class

End Namespace
