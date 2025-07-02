Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Job


''' <summary>
''' Use this class to mimic database failure.
''' </summary>
''' <seealso cref="Wdw_Sust.Textile.Core.DatabaseMonitorJobManagerBase" />
Public Class UnreachableDatabaseSimulationJobManager
    Inherits DatabaseMonitorJobManagerBase

#Region "Fields"
    Private _count As Integer
#End Region

#Region "Properties"
    ''' <summary>
    ''' Gets or sets the fail delay in seconds. Default is 20 seconds will simulate the failure
    ''' </summary>
    ''' <value>The fail delay in seconds.</value>
    Public Property FailDelayInSeconds As Integer = 20
#End Region

#Region "Methods"
    Public Sub ResetFakeFailStatus()
        FailDelayInSeconds = 0
    End Sub
    Private Function FakeDatabaseMonitorJob() As Boolean
        If _count <= FailDelayInSeconds Then
            _count += 1
        End If
        Console.WriteLine("{0} seconds before simulating database failure", FailDelayInSeconds - _count)
        Return _count <= FailDelayInSeconds
    End Function

    Protected Overrides Function OnCreateExternalSourceMonitorJob() As IExternalSourceMonitorJob
        Return New ExternalSourceMonitorJob(Me.GetType.ToString, TimeSpan.FromSeconds(1), AddressOf FakeDatabaseMonitorJob)
    End Function
#End Region

#Region "Constructors"
    Public Sub New(jobProvider As LintJobProvider)
        MyBase.New(jobProvider)
    End Sub
#End Region

End Class