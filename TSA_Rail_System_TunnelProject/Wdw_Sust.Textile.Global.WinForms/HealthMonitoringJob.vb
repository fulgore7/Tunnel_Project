Imports Wdw_Sust.Core.Job
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Dal

Public Class HealthMonitoringJob
    Inherits TimeSpanJobDetail
    Public Sub New(ByVal jobName As String, ByVal appID As LintApplicationId)
        MyBase.New(jobName, TimeSpan.FromMinutes(3), Sub() Backup_UpdateApplicationLastSeenTime(New LintKeyValuePair(Of LintApplicationId, String)(appID, My.Computer.Name), TextileDbConfigManager.Instance.LintProductionConnectionString))
    End Sub
End Class
