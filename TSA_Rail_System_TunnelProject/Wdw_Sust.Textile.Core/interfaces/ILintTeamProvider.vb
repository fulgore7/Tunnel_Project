Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces

    Public Interface ILintTeamProvider
        Inherits IDatabaseProvider

        Function GetTeamCleanworkMachineCastMemberPacingByMachine(machineId As Integer, Optional timeInterval As Integer = -15) As IEnumerable(Of ITeamDashboardCleanworkMachineCastMemberPacingDetail)

        Function GetTeamCleanworkMachineCastMemberPacingInformation(startTime As Date, endTime As Date) As IEnumerable(Of ITeamDashboardCleanworkMachineCastMemberPacingDetail)

        Function GetTeamCleanworkMachineCurrentMachineStatus() As IEnumerable(Of ITeamMachineCurrentStatus)

        Function GetTeamCleanworkMachineDashboardData(startTime As Date, endTime As Date) As ITeamDashboardDataList

        Function GetTeamCleanworkMachinePacingInformation(startTime As Date, endTime As Date) As IEnumerable(Of ITeamDashboardCleanworkMachinePacingDetail)

        Function GetTeamCleanworkMachinePacingInformationByMachine(machineId As Integer, startTime As Date, endTime As Date) As ITeamDashboardCleanworkMachinePacingDetail

        Function GetTeamCurrentMachineStatus() As IEnumerable(Of ITeamMachineCurrentStatus)

        Function GetTeamMachineDashboardData(startTime As Date, endTime As Date) As ITeamDashboardDataList

        Function GetTeamMachineDashboardDataByMachine(startTime As Date, endTime As Date, machineId As Integer) As ITeamDashboardDataList

        Function GetTeamMachineStatusDistrbutionDetails(startTime As Date, endTime As Date) As IEnumerable(Of ITeamMachineStatusDistributionDetail)

        Function GetTeamMachineStatusDistrbutionDetailsByMachineID(machineID As Integer, startTime As Date, endTime As Date) As IEnumerable(Of ITeamMachineStatusDistributionDetail)

        Function GetTeamWashdeckBagDrops(startTime As Date, endTime As Date) As ITeamDashboardBagDropData

        Function GetTeamWashdeckDashboardData(startTime As Date, endTime As Date) As ITeamDashboardDataList

        Sub TruncateCleanworkMacineCastMemberPacingInformationTable()

        Sub TruncateCleanworkMacinePacingInformationTable()

        Sub UpdateCleanworkMachineCastMemberPacingInformation(timestamp As Date, startTime As Date, endTime As Date)

        Sub UpdateCleanworkMachinePacingInformation(timestamp As Date, startTime As Date, endTime As Date)

    End Interface

End Namespace