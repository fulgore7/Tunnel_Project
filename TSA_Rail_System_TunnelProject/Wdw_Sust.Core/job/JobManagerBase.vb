Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Job.EventArgs
Imports Wdw_Sust.Core.Timer

Namespace Job

    Public MustInherit Class JobManagerBase
        Implements IJobManager, IDisposable

#Region "Fields"
        Protected ReadOnly _listOfJobDetails As New List(Of IJobDetail)
        Private WithEvents _timerManager As TimerManager
        Private ReadOnly _syncLockObject As New Object
        Private _lastTickTime As Date = Date.MinValue
        Private _minTick As Long = Long.MaxValue
        Private _maxTick As Long = 0
#End Region

#Region "Events"
        Public Event _JobManagerStarted As EventHandler
        Public Event _JobManagerStopped As EventHandler
        Public Event _OnProcessingJob As EventHandler(Of JobEventArgs)
        Public Event _OnProcessedJob As EventHandler(Of JobEventArgs)
        ''' <summary>
        ''' Tick event will only raise every second, even though the process time is less than a second
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Event _Tick(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region "Properties"
        Public ReadOnly Property JobDetails As IList(Of IJobDetail)
            Get
                Return _listOfJobDetails.AsReadOnly
            End Get
        End Property

        Protected ReadOnly Property TimerManager As TimerManager
            Get
                If _timerManager Is Nothing Then _timerManager = New TimerManager(False)
                Return _timerManager
            End Get
        End Property

        Public ReadOnly Property IsRunning As Boolean
            Get
                Return TimerManager.IsActive
            End Get
        End Property

        Public ReadOnly Property JobCounts As Integer
            Get
                Return _listOfJobDetails.Count
            End Get
        End Property

        Public ReadOnly Property LastTickTime As Date
            Get
                Return _lastTickTime
            End Get
        End Property

        Public ReadOnly Property MinTick As Long
            Get
                Return _minTick
            End Get
        End Property

        Public ReadOnly Property MaxTick As Long
            Get
                Return _maxTick
            End Get
        End Property

#End Region

#Region "Methods"
        ''' <summary>
        ''' Test
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub _timerManager_TimerTick(sender As Object, e As System.EventArgs) Handles _timerManager.TimerTick
            'Console.WriteLine(Now.Subtract(_timerManager.LastTickTime).TotalMilliseconds)
            _lastTickTime = Now
            RaiseEvent _Tick(Me, System.EventArgs.Empty)
            SyncLock _syncLockObject
                ProcessJobs()
                CheckForDeletedJobs()
            End SyncLock
            CheckTicks()
        End Sub

        Private Sub CheckTicks()
            Dim tempTicks As Long = Now.Subtract(_lastTickTime).Ticks
            If tempTicks < _minTick Then _minTick = tempTicks
            If tempTicks > _maxTick Then _maxTick = tempTicks
            'Console.WriteLine(String.Format("Max Ticks: {0}, Min Ticks {1}, This ticks: {2}", _maxTick, _minTick, tempTicks))
        End Sub

        ''' <summary>
        ''' Each tick will call <code>ProcessJobs()</code> 
        ''' </summary>
        ''' <remarks></remarks>
        Protected MustOverride Sub ProcessJobs()

        Private Sub CheckForDeletedJobs()
            SyncLock _syncLockObject
                _listOfJobDetails.RemoveAll(Function(a)
                                                If a.MarkForRemoval
                                                    a.MarkForRemoval = false
                                                    return true
                                                End If
                                                return false
                                             End Function)
            End SyncLock
        End Sub

        ''' <summary>
        ''' To force the job to be processed immediately
        ''' </summary>
        ''' <param name="jobName"></param>
        ''' <remarks></remarks>
        Public Sub ProcessJob(ByVal jobName As String, Optional ByVal throwIfJobDoesNotExist As Boolean = False)
            Dim job As IJobDetail
            SyncLock _syncLockObject
                job = _listOfJobDetails.Find(Function(a) a.JobName.ToLower = jobName.ToLower)
            End SyncLock
            If job IsNot Nothing AndAlso Not job.MarkForRemoval Then
                ExecuteJob(job)
            ElseIf throwIfJobDoesNotExist Then
                Throw New ArgumentException("Job Does Not Exist!")
            End If
        End Sub

        Public Function ContainsJob(ByVal jobName As String) As Boolean
            If jobName IsNot Nothing OrElse jobName <> String.Empty Then
                Dim returnValue As Boolean
                SyncLock _syncLockObject
                    returnValue = _listOfJobDetails.Find(Function(a) a.JobName.Trim.ToLower = jobName.Trim.ToLower) IsNot Nothing
                End SyncLock
                Return returnValue
            End If
            Return False
        End Function

        Public Function GetJob(ByVal jobName As String) As IJobDetail
            Dim jobToReturn As IJobDetail
            SyncLock _syncLockObject
                jobToReturn = _listOfJobDetails.FirstOrDefault(Function(a) a.JobName.Trim.ToLower = jobName.Trim.ToLower)
            End SyncLock
            Return jobToReturn
        End Function

        Protected Sub ExecuteJob(ByVal job As IJobDetail)
            Dim args As New JobEventArgs(job.JobName)
            RaiseEvent _OnProcessingJob(Me, args)
            If Not args.Cancel Then
                Threading.ThreadPool.QueueUserWorkItem(AddressOf job.ExecuteJob)
                'job.ExecuteJob()
                'Console.WriteLine("Executing Job: {0}", job.JobName)
                job.LastUpdate = Now
            End If
            RaiseEvent _OnProcessedJob(Me, args)
        End Sub

        ''' <summary>
        ''' Return a list of job names
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetJobNames() As List(Of String)
            Dim names As New List(Of String)
            SyncLock _syncLockObject
                _listOfJobDetails.ForEach(Sub(a) names.Add(a.ToString))
                names.Sort()
            End SyncLock
            Return names
        End Function

        Public Overridable Function AddJob(ByVal jobDetail As IJobDetail, Optional runImmediately As Boolean = False) As IJobDetail Implements IJobManager.AddJob
            If jobDetail Is Nothing Then Throw New ArgumentException("jobDetail argument is nothing")
            If jobDetail.JobName = String.Empty OrElse jobDetail.JobName Is Nothing Then Throw New ArgumentException("Please provide a name for the job!!")
            SyncLock _syncLockObject
                If _listOfJobDetails.Exists(Function(a) a.JobName.Trim.ToLower = jobDetail.JobName.Trim.ToLower) Then Throw New ArgumentException("Job has already been in the job manager!!")
                _listOfJobDetails.Add(jobDetail)
                If jobDetail.JobScheduler Is Nothing Then
                    jobDetail.SetScheduler(Me)
                ElseIf Not ReferenceEquals(jobDetail.JobScheduler, Me)
                    jobDetail.JobScheduler.RemoveJob(jobDetail)
                    jobDetail.SetScheduler(Me)
                End If
            End SyncLock
            If runImmediately Then
                Threading.ThreadPool.QueueUserWorkItem(AddressOf jobDetail.ExecuteJob)
            End If
            Return jobDetail
        End Function

        Public Function AddJob(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal action As Action, Optional ByVal isEnabled As Boolean = True, Optional ByVal args As Object() = Nothing, Optional ByVal runImmediately As Boolean = False) As IJobDetail
            Dim jobDetail As New TimeSpanJobDetail(jobName, frequency, action, isEnabled, args)
            Return AddJob(jobDetail, runImmediately)
        End Function

        Public Sub RemoveJob(ByVal jobName As String)
            SyncLock _syncLockObject
                Dim job As IJobDetail = _listOfJobDetails.Find(Function(a) a.JobName.ToLower = jobName.ToLower)
                If job IsNot Nothing Then
                    job.IsEnabled = False
                    job.MarkForRemoval = True
                    if ReferenceEquals(job.JobScheduler, Me)
                        job.SetScheduler(Nothing)
                    End If
                End If
            End SyncLock
        End Sub

        Public Sub RemoveJob(ByVal job As IJobDetail) Implements IJobManager.RemoveJob
            RemoveJob(job.JobName)
        End Sub

        Public Sub RemoveJobs()
            SyncLock _syncLockObject
                _listOfJobDetails.ForEach(Sub(a) a.MarkForRemoval = True)
            End SyncLock
        End Sub

        Public Sub StartProcessingJobs()
            RaiseEvent _JobManagerStarted(Me, System.EventArgs.Empty)
            TimerManager.StartTimer()
        End Sub

        Public Sub StopProcessingJobs()
            RaiseEvent _JobManagerStopped(Me, System.EventArgs.Empty)
            TimerManager.StopTimer()
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Private Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    _listOfJobDetails.Clear()
                    If _timerManager IsNot Nothing Then _timerManager.Dispose()
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
#End Region

#End Region

    End Class

End Namespace
