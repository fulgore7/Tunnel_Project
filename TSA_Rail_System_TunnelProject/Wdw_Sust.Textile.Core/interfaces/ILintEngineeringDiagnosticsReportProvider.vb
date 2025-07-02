Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core

Namespace Interfaces
    Public Interface ILintEngineeringDiagnosticsReportProvider
        Inherits IProvider
        Function GetMtbfDiagnosticsData(ByVal workflowSystemDiagnosticsGroup As Integer, ByVal startTime As Date, ByVal endTime As Date) As List(Of LintEngineeringMtbfDiagnosticData)
        Function GetMttrDiagnosticsData(ByVal workflowSystemDiagnosticsGroup As Integer, ByVal startTime As Date, ByVal endTime As Date) As List(Of LintEngineeringMttrDiagnosticData)
    End Interface
End Namespace
