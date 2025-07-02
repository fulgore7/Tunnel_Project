Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Job
Imports Wdw_Sust.Textile.Core.Interfaces

Public MustInherit Class DatabaseMonitorJobManagerBase
    Implements IDatabaseMonitorJobManager, IDisposable

#Region "Fields"
    Private _jobProvider As LintJobProvider
    Private WithEvents _job As ExternalSourceMonitorJob
#End Region

#Region "Events"
    Public Event DatabaseStatusChanged As EventHandler Implements IDatabaseMonitorJobManager.DatabaseStatusChanged
#End Region

#Region "Properties"
    Public ReadOnly Property DatabaseIsOnline As Boolean Implements IDatabaseMonitorJobManager.DatabaseIsOnline
        Get
            If _job Is Nothing Then Return False
            Return _job.SourceStatusOk
        End Get
    End Property

    Public ReadOnly Property LastSeenTime As Date Implements IDatabaseMonitorJobManager.LastSeenTime
        Get
            If _job IsNot Nothing Then
                Return _job.LastSeenTime
            Else
                Return Date.MinValue
            End If
        End Get
    End Property
#End Region

#Region "Methods"
    Protected MustOverride Function OnCreateExternalSourceMonitorJob() As IExternalSourceMonitorJob

    Public Sub StartMonitoring() Implements IDatabaseMonitorJobManager.StartMonitoring
        If _job Is Nothing Then
            _job = OnCreateExternalSourceMonitorJob()
            _jobProvider.AddJob(_job)
        End If
        _job.IsEnabled = True
    End Sub

    Public Sub StopMonitoring() Implements IDatabaseMonitorJobManager.StopMonitoring
        If _job IsNot Nothing Then
            _job.IsEnabled = False
        End If
    End Sub

    Public Sub New(jobProvider As LintJobProvider)
        _jobProvider = jobProvider

    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                _jobProvider.RemoveJob(_job.JobName)
                _job.Dispose()
                _jobProvider = Nothing
                _job = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Private Sub _job_SourceStatusChanged(sender As Object, e As System.EventArgs) Handles _job.SourceStatusChanged
        RaiseEvent DatabaseStatusChanged(Me, e)
    End Sub


#End Region

End Class