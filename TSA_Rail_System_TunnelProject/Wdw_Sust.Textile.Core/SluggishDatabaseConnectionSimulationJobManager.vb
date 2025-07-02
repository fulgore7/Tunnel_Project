
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Job

''' <summary>
''' This class mimic a sluggish database connection. 
''' The default fail delay is 20 seconds, and will be alternating online and offline every 30 seconds.
''' </summary>
''' <seealso cref="Wdw_Sust.Textile.Core.DatabaseMonitorJobManagerBase" />
Public Class SluggishDatabaseConnectionSimulationJobManager
    Inherits DatabaseMonitorJobManagerBase
    Public Property FailDelayInSeconds As Integer = 20
    Private _count As Integer
    Private Function FakeDatabaseMonitorJob() As Boolean
        If _count <= FailDelayInSeconds Then
            _count += 1
            Return True
        Else
            Return Now.Second > 30
        End If
    End Function
    Protected Overrides Function OnCreateExternalSourceMonitorJob() As IExternalSourceMonitorJob
        Return New ExternalSourceMonitorJob(Me.GetType.ToString, TimeSpan.FromSeconds(1), AddressOf FakeDatabaseMonitorJob)
    End Function

    Public Sub New(jobProvider As LintJobProvider)
        MyBase.New(jobProvider)
    End Sub
End Class