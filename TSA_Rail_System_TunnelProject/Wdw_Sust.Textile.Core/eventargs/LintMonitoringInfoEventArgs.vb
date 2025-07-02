
Namespace EventArgs
    Public Class LintMonitoringInfoEventArgs
        Inherits DataRetrievalEventArgs

        Public Property MonitoredApps As IEnumerable(Of LintApplicationMonitoringDetail)

    End Class
End Namespace
