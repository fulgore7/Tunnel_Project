Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core

Namespace Interfaces
    Public Interface ILintProdStatusProvider
        Inherits IHaveConnectionString
        Sub AddToProductivityLogWithRejects(ByVal sessionID As Integer, ByVal machineID As Integer,
                                            ByVal operatorID As Integer, ByVal timeOccured As DateTime,
                                            ByVal actualCount As Integer, ByVal rejectCount As Integer,
                                            ByVal productCode As Integer, ByVal sessionChangeReason As Integer,
                                            Optional ByVal connectionString As String = "")

        Sub AddToProductionStatus(Optional ByVal connectionString As String = "")
        Function GetLintActiveProdStatuses(machineIDs As List(Of Integer)) As List(Of LintProdStatus)
        Sub RefreshProdData()
        Sub RefreshSummaryData()
        Sub RefreshAdminData()
        Function GetLintAdminProdSummaries(startDate As DateTime, endDate As DateTime, plantID As Integer) As List(Of LintProdAdminSummary)
        Function GetLintProdSummaries(plantID As Integer) As List(Of LintProdSummary)
        Function GetMachineLoginStatus(machineIDs As List(Of Integer)) As List(Of LintMachineLoginStatus)
    End Interface
End Namespace
