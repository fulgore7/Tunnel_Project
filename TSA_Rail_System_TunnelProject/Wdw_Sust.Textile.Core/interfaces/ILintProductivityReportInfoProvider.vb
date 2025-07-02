Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface ILintProductivityReportInfoProvider
        Inherits IDatabaseProvider
        Function GetCastHourlyProductivity(rfBadgeUserID) As List(Of LintOperatorHourlyProductivity)
        Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData)
        Function GetCartDumpProductivityData(startTime As Date, endTime As Date) As List(Of LintCartDumpProductivityData)
    End Interface
End Namespace
