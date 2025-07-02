Namespace Interfaces
    Public Interface ITeamDashboardDataList
        Inherits IEnumerable(Of ITeamDashboardData)
        Function GetFwProductivity() As ITeamDashboardData
        Function GetTfProductivity() As ITeamDashboardData
        Function GetPcProductivity() As ITeamDashboardData
        Function GetTotalCleanworkProductivity() As ITeamDashboardData
        Function GetWasherProductivity() As ITeamDashboardData
    End Interface
End Namespace