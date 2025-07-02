Imports Wdw_Sust.Core.Interfaces

Namespace Job
    ''' <summary>
    ''' This is used to monitor an external source for change of state and provide feedback later.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Interfaces.IExternalSourceMonitorJob" />
    Public Class ExternalSourceMonitorJob
        Implements IExternalSourceMonitorJob

#Region "Fields"
        Private _status As Boolean
        Private _isInitialized As Boolean
        Private _retryCount As Integer
        Private _lastSeenTime As DateTime = DateTime.MinValue
        Private ReadOnly TRY_LIMIT As Integer = 3
        Private _jobScheduler As IJobManager
#End Region

#Region "Events"
        Public Event SourceStatusChanged(sender As Object, e As System.EventArgs) Implements IExternalSourceMonitorJob.SourceStatusChanged
#End Region

#Region "Properties"
        Public Property SourceToMonitor As System.Func(Of Boolean) Implements IExternalSourceMonitorJob.SourceToMonitor

        Friend Property MarkForRemoval As Boolean Implements IJobDetail.MarkForRemoval

        Public ReadOnly Property LastSeenTime As DateTime
            Get
                Return _lastSeenTime
            End Get
        End Property

        Public Property SourceStatusOk As Boolean Implements IExternalSourceMonitorJob.SourceStatusOk
            Get
                Return _status
            End Get
            Private Set(value As Boolean)
                If _status <> value Then
                    _status = value
                    _retryCount = 0
                End If
                RaiseEvent SourceStatusChanged(Me, System.EventArgs.Empty)
                If value Then _lastSeenTime = Now
            End Set
        End Property

        Public Property TimeSpanRunTime As TimeSpan Implements ITimeSpanJobDetail.TimeSpanRunTime

        Public Property JobName As String Implements IJobDetail.JobName

        Public Property IsEnabled As Boolean Implements IJobDetail.IsEnabled

        Public Property IsBusy As Boolean Implements IJobDetail.IsBusy

        Public Property LastUpdate As Date Implements IJobDetail.LastUpdate

        Public Property JobScheduler As IJobManager Implements IJobDetail.JobScheduler
            Get
                Return _jobScheduler
            End Get
            Private Set(value As IJobManager)
                If Not ReferenceEquals(_jobScheduler, value) Then
                    If _jobScheduler IsNot Nothing
                        _jobScheduler.RemoveJob(me)
                    End If
                    _jobScheduler = value
                End If
            End Set
        End Property

#End Region

#Region "Methods"
        Public Sub ExecuteJob() Implements IExecuteJob.ExecuteJob
            If SourceToMonitor IsNot Nothing Then
                If Not IsBusy Then
                    IsBusy = True
                    Dim result As Boolean = SourceToMonitor.Invoke
                    'If Not _isInitialized Then
                    '    _isInitialized = True
                    '    SourceStatusOk = result
                    '    RaiseEvent SourceStatusChanged(Me, System.EventArgs.Empty)
                    'Else
                    If SourceStatusOk <> result Then
                        If SourceStatusOk AndAlso Not result Then
                            SourceStatusOk = result
                        Else
                            _retryCount += 1
                            If _retryCount >= TRY_LIMIT Then SourceStatusOk = result
                        End If
                    ElseIf Not SourceStatusOk AndAlso Not result AndAlso _retryCount > 0 Then
                        _retryCount = 0
                    End If
                    SourceStatusOk = result
                    LastUpdate = Now
                    'End If
                    IsBusy = False
                End If
            ElseIf Not MarkForRemoval Then
                Throw New ArgumentException("No job is defined")
            End If
        End Sub
        Public Overrides Function ToString() As String
            Return String.Format("{0}: Interval: {1:F0} Seconds: IsEnabled: {2}", JobName, TimeSpanRunTime.TotalSeconds, IsEnabled)
        End Function

        Public Sub Subscribe(jobScheduler As IJobManager, Optional ByVal runImmediately As Boolean = False) Implements IJobDetail.Subscribe
            If jobScheduler Is Nothing Then Throw New NullReferenceException("jobScheduler")
            jobScheduler.AddJob(Me, runImmediately)
        End Sub

        Public Sub Unsubscribe() Implements IJobDetail.Unsubscribe
            If _jobScheduler IsNot Nothing Then
                _jobScheduler.RemoveJob(Me)
                _jobScheduler = Nothing
            End If
        End Sub
#End Region

#Region "Constructors"
        Public Sub New(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal sourceToMonitor As Func(Of Boolean))
            Me.JobName = jobName
            Me.SourceToMonitor = sourceToMonitor
            TimeSpanRunTime = frequency
        End Sub
#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean

        ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    MarkForRemoval = True
                    SourceToMonitor = Nothing
                End If
            End If
            Me.disposedValue = True
        End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Public Sub SetScheduler(scheduler As IJobManager) Implements IJobDetail.SetScheduler
            JobScheduler=scheduler
        End Sub

#End Region

    End Class
End Namespace