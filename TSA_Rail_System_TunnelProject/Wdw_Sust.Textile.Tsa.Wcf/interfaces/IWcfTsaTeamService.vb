Imports System.ServiceModel
Imports Wdw_Sust.Textile.Core

Namespace Interfaces

    <ServiceContract()>
    Public Interface IWcfTsaTeamService
        <OperationContract()>
        Function GetTeamCleanworkMachineFullStatusByShift(ByVal shift As LintShiftData) As TsaTeamDashboardDataList
        <OperationContract()>
        Function GetTeamWashdeckMachineFullStatusByShift(ByVal shift As LintShiftData) As TsaTeamDashboardDataList
        <OperationContract()>
        Function GetTeamMachineFullStatusByShift(ByVal shift As LintShiftData) As TsaTeamDashboardDataList
        <OperationContract()>
        Function GetTeamCleanworkMachineCurrentStatus() As List(Of TsaTeamMachineCurrentStatus)
        <OperationContract()>
        Function GetTeamCurrentMachineStatus() As List(Of TsaTeamMachineCurrentStatus)
        <OperationContract()>
        Function GetCurrentCastMachineLogInStatus() As List(Of LintOperatorMachineLoginStatus)
        <OperationContract()>
        Function GetTeamCleanworkMachineCastMemberPacingInformation(ByVal numberOfMinutesAgo As Integer) As List(Of TsaTeamDashboardCleanworkMachineCastMemberPacingDetail)
        <OperationContract()>
        Function GetTeamCleanworkMachinePacingInformation(ByVal numberOfMinutesAgo As Integer) As List(Of TsaTeamDashboardCleanworkMachinePacingDetail)
        <OperationContract()>
        Function GetTeamWashdeckMachineBagDropsByShift(ByVal shift As LintShiftData) As TsaTeamDashboardBagDropData
        <OperationContract()>
        Function GetTeamMachineStatusDistrbutionDetails(shift As LintShiftData) As List(Of TsaTeamMachineStatusDistributionDetail)
    End Interface

End Namespace
