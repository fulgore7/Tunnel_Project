Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core

Namespace Interfaces
    Public Interface ILintProductivityInfoProvider
        Inherits IDatabaseProvider
        Function GetCastHourlyProductivity(ByVal rfBadgeUserID As Integer) As List(Of LintOperatorHourlyProductivity)
        Function GetOperatorMachineLogInStatus() As List(Of LintOperatorProductivitySummaryData)
        Function GetOperatorMachineLogInStatus(ByVal plant As Plant) As List(Of LintOperatorProductivitySummaryData)
        Sub AddInvalidLoginAttemptDetail(ByVal logDetail As LintSystemEventLogDetail)
        Function GetCurrentMachineLoginStatuses() As List(Of LintOperatorMachineLoginStatus)
        Function GetSortingProductivity(ByVal startTime As Date, ByVal endTime As Date) As List(Of LintSortingProductivityData)
        Function GetWashdeckProductivityData(ByVal startDate As DateTime, ByVal endDate As DateTime) As List(Of LintWashdeckProductivityData)
        Function GetCastElectronicBoardData(ByVal startTime As DateTime, ByVal endTime As DateTime) As List(Of LintCastMemberProductivityElectronicBoardData)
    End Interface
End Namespace
