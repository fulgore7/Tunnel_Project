Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Job.EventArgs
Imports Wdw_Sust.Core.Job
''' <summary>
''' This class has a tick resolution of 1 second
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class LintJobProvider
    Inherits SingletonProviderBase(Of LintJobProvider)
    Implements IDisposable

#Region "Fields"
    Private WithEvents _jobManager As New JobManager
    Private _tickCount As Long
    Private Shared _FLASH As Boolean
#End Region

#Region "Events"
    Public Event JobProcessed As EventHandler(Of JobEventArgs)
#End Region

#Region "Properties"
    Public ReadOnly Property TickCount As Long
        Get
            Return _tickCount
        End Get
    End Property
    Public ReadOnly Property Flash As Boolean
        Get
            Return _FLASH
        End Get
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' Add job to the manager. The job will run immediately by default
    ''' </summary>
    ''' <param name="jobDetail"></param>
    ''' <param name="runImmediately"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddJob(ByVal jobDetail As IJobDetail, Optional ByVal runImmediately As Boolean = True) As Boolean
        Dim job As IJobDetail = Nothing
        If Not _jobManager.ContainsJob(jobDetail.JobName) Then
            TryAction(Sub() job = _jobManager.AddJob(jobDetail, runImmediately))
            If job IsNot Nothing AndAlso Not _jobManager.IsRunning Then
                _jobManager.StartProcessingJobs()
            End If
        End If
        Return job IsNot Nothing
    End Function

    Public Sub AddJobs(ByVal runImmediately As Boolean, ByVal ParamArray jobDetails As IJobDetail())
        For i As Integer = 0 To jobDetails.Count - 1
            AddJob(jobDetails(i), runImmediately)
        Next
    End Sub

    ''' <summary>
    ''' Add job to the manager. The job will run immediately by default
    ''' </summary>
    ''' <param name="jobName">Name of the job. This has to be unique</param>
    ''' <param name="frequency">How frequent the job needs to run</param>
    ''' <param name="act">The action of the job</param>
    ''' <param name="runImmediately"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddJob(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal act As Action, Optional ByVal runImmediately As Boolean = True) As Boolean
        Return AddJob(New TimeSpanJobDetail(jobName, frequency, act), runImmediately)
    End Function

    Public Function RemoveJob(ByVal jobName As String) As Boolean
        If _jobManager.ContainsJob(jobName) Then
            _jobManager.RemoveJob(jobName)
            If _jobManager.JobCounts <= 0 Then _jobManager.StopProcessingJobs()
            Return True
        End If
        Return False
    End Function

    Public Sub RemoveJobs()
        If _jobManager.IsRunning Then
            _jobManager.StopProcessingJobs()
            _jobManager.RemoveJobs()
            _jobManager.StartProcessingJobs()
        End If
    End Sub

    Public Function JobCounts() As Integer
        Return _jobManager.JobCounts
    End Function

    ''' <summary>
    ''' Only do the action once
    ''' </summary>
    ''' <param name="jobName">Name of the job</param>
    ''' <param name="secondsFromNow">Perform the action X number of seconds from now</param>
    ''' <param name="act"></param>
    ''' <remarks></remarks>
    Public Sub DoOnce(jobName As String, secondsFromNow As TimeSpan, act As Action)
        AddJob(jobName, secondsFromNow, Sub()
                                            act()
                                            RemoveJob(jobName)
                                        End Sub, False)
    End Sub

    Public Function GetJob(ByVal jobName As String) As IJobDetail
        Return _jobManager.GetJob(jobName)
    End Function

    Public Function ContainsJob(ByVal jobName As String) As Boolean
        Return _jobManager.ContainsJob(jobName)
    End Function

    Public Function GetJobNames() As List(Of String)
        Return _jobManager.GetJobNames
    End Function

    Private Sub _jobManager__OnProcessedJob(sender As Object, e As JobEventArgs) Handles _jobManager._OnProcessedJob
        RaiseEvent JobProcessed(Me, e)
    End Sub

    Private Sub _jobManager__Tick(sender As Object, e As System.EventArgs) Handles _jobManager._Tick
        System.Threading.Interlocked.Increment(_tickCount)
        _FLASH = Not _FLASH
    End Sub

    Public Function DoOnceAtFirstTrueResult(jobName As String, frequency As TimeSpan, testCondition As Func(Of Boolean), actionWhenTrue As Action, Optional actionWhenFalse As Action = Nothing, Optional runImmediately As Boolean = True) As Boolean
        Return AddJob(jobName, frequency, Sub()
                                              If testCondition() Then
                                                  RemoveJob(jobName)
                                                  actionWhenTrue()
                                              Else
                                                  If actionWhenFalse IsNot Nothing Then actionWhenFalse()
                                              End If
                                          End Sub, runImmediately)
    End Function

    Public Function ContinueUntilFirstFalseResult(jobName As String, frequency As TimeSpan, testCondition As Func(Of Boolean), actionWhenFalse As Action, Optional actionWhenTrue As Action = Nothing, Optional runImmediately As Boolean = True) As Boolean
        Return AddJob(jobName, frequency, Sub()
                                              If Not testCondition() Then
                                                  RemoveJob(jobName)
                                                  actionWhenFalse()
                                              Else
                                                  If actionWhenTrue IsNot Nothing Then actionWhenTrue()
                                              End If
                                          End Sub, runImmediately)
    End Function

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _jobManager.StopProcessingJobs()
                _jobManager.RemoveJobs()
                _jobManager.Dispose()
            End If
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class


