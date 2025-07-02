Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums

Namespace Interfaces
    Public Interface ILintSystemsProvider
        Inherits IDatabaseProvider
        Function GetServiceSettings(ByVal serviceID As LintServiceType) As LintServiceSetting
        Function GetServiceSettings() As List(Of LintServiceSetting)
        Function GetSystemParameters(ByVal plant As Plant, ByVal parameterID As LintSystemParameterId) As LintSystemParameter
        Function GetSystemParameters(ByVal plant As Plant) As LintSystemParameters
        Function GetSystemParameterRoles(ByVal plant As Plant) As List(Of LintSystemParameterRole)
        Sub UpdateSystemParameters(ByVal plant As Plant, ByVal parameters As List(Of LintSystemParameter))
        Sub UpdateSystemParameters(ByVal plant As Plant, ByVal parameter As LintSystemParameter)
        Function GetSystemParameters() As LintSystemParameters
        Sub InsertComputerStatusLog(ByVal log As ComputerStatusLogDetail)
        Sub InsertExceptionLog(ByVal Exception As String)
        Function GetPlantPerformance() As List(Of PlantPerformance)
        Function GetSummaryPlantPerformance(plant As Integer) As List(Of PlantPerformanceByTime)
    End Interface
End Namespace
