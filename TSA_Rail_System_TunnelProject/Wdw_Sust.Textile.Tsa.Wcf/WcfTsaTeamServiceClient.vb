Imports System.ServiceModel
Imports System.ServiceModel.Channels

Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Wcf.Core
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

Public Class WcfTsaTeamServiceClient
    Inherits WcfLintNetTcpClientBase(Of IWcfTsaTeamService, WcfTsaTeamService)
    Implements IWcfTsaTeamServiceClient

    ''' <summary>
    ''' Override the CreateBinding function due to insufficient of the buffer size to handle the machine status distribution
    ''' </summary>
    ''' <returns></returns>
    Protected Overrides Function CreateBinding() As Binding
        Dim x As NetTcpBinding = MyBase.CreateBinding
        x.MaxReceivedMessageSize = 65535 * 2
        Return x
    End Function

    Public Sub New(ByVal bindingType As WcfBindingType)
        MyBase.New(bindingType, LintServiceType.TSA_TEAM_DATA)
    End Sub

    Public Sub New(ByVal bindingType As WcfBindingType, ByVal settings As LintServiceSetting)
        MyBase.New(bindingType, settings)
    End Sub

    Public Function GetTeamCleanworkMachineFullStatusByShift(shift As LintShiftData) As TsaTeamDashboardDataList Implements IWcfTsaTeamServiceClient.GetTeamCleanworkMachineFullStatusByShift
        Return SafeExecute(Function() Service.GetTeamCleanworkMachineFullStatusByShift(shift))
    End Function

    Public Function GetTeamCleanworkMachineCurrentStatus() As List(Of TsaTeamMachineCurrentStatus) Implements IWcfTsaTeamServiceClient.GetTeamCleanworkMachineCurrentStatus
        Return SafeExecute(AddressOf Service.GetTeamCleanworkMachineCurrentStatus)
    End Function

    Public Function GetCurrentCastMachineLogInStatus() As List(Of LintOperatorMachineLoginStatus) Implements IWcfTsaTeamServiceClient.GetCurrentCastMachineLogInStatus
        Return SafeExecute(AddressOf Service.GetCurrentCastMachineLogInStatus)
    End Function

    Public Function GetTeamCleanworkMachineCastMemberPacingInformation(ByVal numberOfMinutesAgo As Integer) As List(Of TsaTeamDashboardCleanworkMachineCastMemberPacingDetail) Implements IWcfTsaTeamServiceClient.GetTeamCleanworkMachineCastMemberPacingInformation
        Return SafeExecute(Function() Service.GetTeamCleanworkMachineCastMemberPacingInformation(numberOfMinutesAgo))
    End Function

    Public Function GetTeamCleanworkMachinePacingInformation(ByVal numberOfMinutesAgo As Integer) As List(Of TsaTeamDashboardCleanworkMachinePacingDetail) Implements IWcfTsaTeamServiceClient.GetTeamCleanworkMachinePacingInformation
        Return SafeExecute(Function() Service.GetTeamCleanworkMachinePacingInformation(numberOfMinutesAgo))
    End Function

    Public Function GetTeamMachineStatusDistrbutionDetails(shift As LintShiftData) As List(Of TsaTeamMachineStatusDistributionDetail) Implements IWcfTsaTeamServiceClient.GetTeamMachineStatusDistrbutionDetails
        Return SafeExecute(Function() Service.GetTeamMachineStatusDistrbutionDetails(shift))
    End Function

    Public Function GetTeamWashdeckMachineBagDropsByShift(shift As LintShiftData) As TsaTeamDashboardBagDropData Implements IWcfTsaTeamServiceClient.GetTeamWashdeckMachineBagDropsByShift
        Return SafeExecute(Function() Service.GetTeamWashdeckMachineBagDropsByShift(shift))
    End Function

    Public Function GetTeamWashdeckMachineFullStatusByShift(shift As LintShiftData) As TsaTeamDashboardDataList Implements IWcfTsaTeamServiceClient.GetTeamWashdeckMachineFullStatusByShift
        Return SafeExecute(Function() Service.GetTeamWashdeckMachineFullStatusByShift(shift))
    End Function

    Public Function GetTeamCurrentMachineStatus() As List(Of TsaTeamMachineCurrentStatus) Implements IWcfTsaTeamServiceClient.GetTeamCurrentMachineStatus
        Return SafeExecute(AddressOf Service.GetTeamCurrentMachineStatus)
    End Function

    Public Function GetTeamMachineFullStatusByShift(shift As LintShiftData) As TsaTeamDashboardDataList Implements IWcfTsaTeamService.GetTeamMachineFullStatusByShift
        Return SafeExecute(Function() Service.GetTeamMachineFullStatusByShift(shift))
    End Function
End Class