Imports Wdw_Sust.Core.Interfaces

Namespace Job
    Public Class TimeSpanJobDetail
        Inherits JobDetailBase
        Implements ITimeSpanJobDetail

#Region "Fields"
        Private _lastUpdate As DateTime
#End Region

#Region "Properties"

        Public Overridable Property TimeSpanRunTime As System.TimeSpan Implements ITimeSpanJobDetail.TimeSpanRunTime

        Public ReadOnly Property NextUpdate As Date
            Get
                Return LastUpdate.Add(TimeSpanRunTime)
            End Get
        End Property
        Public ReadOnly Property TimeUntilNextUpdate As TimeSpan
            Get
                Return TimeSpanRunTime.Subtract(Now.Subtract(LastUpdate))
            End Get
        End Property

#End Region

#Region "Methods"
        ''' <summary>
        ''' Subscribes the specified job scheduler.
        ''' </summary>
        ''' <param name="jobScheduler">The job scheduler.</param>
        ''' <param name="runImmediately">if set to <c>true</c> [run immediately].</param>
        ''' <exception cref="System.InvalidOperationException">TimeSpanRunTime is not defined</exception>
        Public Overrides Sub Subscribe(jobScheduler As IJobManager, Optional runImmediately As Boolean = False)
            If TimeSpanRunTime = TimeSpan.MinValue Then Throw New InvalidOperationException("TimeSpanRunTime is not defined")
            MyBase.Subscribe(jobScheduler, runImmediately)
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0}: Interval: {1:F0} Seconds: IsEnabled: {2}", JobName, TimeSpanRunTime.TotalSeconds, IsEnabled)
        End Function
#End Region

#Region "Constructors"
        Public Sub New(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal jobPerform As Action, Optional ByVal isEnabled As Boolean = True, Optional ByVal args As Object() = Nothing)
            MyBase.New(isEnabled)
            Me.JobName = jobName
            Me.TimeSpanRunTime = frequency
            DefineJob(jobToPerform:=jobPerform, args:=args)
            LastUpdate = Now
        End Sub

        Public Sub New()
            MyBase.New(False)
            LastUpdate = Now
        End Sub
#End Region

    End Class
End Namespace
