Imports System.ServiceModel
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Wcf.Core
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

<ServiceBehavior(ConcurrencyMode:=ConcurrencyMode.Multiple, InstanceContextMode:=InstanceContextMode.Single, IncludeExceptionDetailInFaults:=True)>
Public Class WcfTsaTeamService
    Inherits WcfLintNetTcpServiceHostBase(Of IWcfTsaTeamService, WcfTsaTeamService)
    Implements IWcfTsaTeamService

#Region "Constructors"

    Public Sub New(ByVal bindingType As WcfBindingType)
        MyBase.New(bindingType, LintServiceType.TSA_TEAM_DATA)
        ServiceInstance = Me
    End Sub

#End Region

#Region "Methods"
    Protected Overrides Function CreateFactoryObject() As ILintFactoryProvider
        Return TsaFactoryProvider.Instance
    End Function

    Public Function GetTeamCleanworkMachineFullStatusByShift(shift As LintShiftData) As TsaTeamDashboardDataList Implements IWcfTsaTeamService.GetTeamCleanworkMachineFullStatusByShift
        Try
            Return CType(GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamCleanworkMachineDashboardData, shift.ShiftStartTime, Now, 60), TsaTeamDashboardDataList)
        Catch ex As Exception
            Return New TsaTeamDashboardDataList
        End Try
    End Function

    Public Function GetTeamCleanworkMachineCurrentStatus() As List(Of TsaTeamMachineCurrentStatus) Implements IWcfTsaTeamService.GetTeamCleanworkMachineCurrentStatus
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamCleanworkMachineCurrentMachineStatus, 15).OfType(Of TsaTeamMachineCurrentStatus)
        Catch ex As Exception
            Return New List(Of TsaTeamMachineCurrentStatus)
        End Try
    End Function

    Public Function GetCurrentCastMachineLogInStatus() As List(Of LintOperatorMachineLoginStatus) Implements IWcfTsaTeamService.GetCurrentCastMachineLogInStatus
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Productivity.GetCurrentMachineLoginStatuses, 15)
        Catch ex As Exception
            Return New List(Of LintOperatorMachineLoginStatus)
        End Try
    End Function

    Public Function GetTeamCleanworkMachineCastMemberPacingInformation(ByVal numberOfMinutesAgo As Integer) As List(Of TsaTeamDashboardCleanworkMachineCastMemberPacingDetail) Implements IWcfTsaTeamService.GetTeamCleanworkMachineCastMemberPacingInformation
        Try
            Dim x = GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamCleanworkMachineCastMemberPacingInformation, Now.AddMinutes(-numberOfMinutesAgo), Now, 60)
            'Return x.ConvertAll(Function(a) CType(a, TsaTeamDashboardCleanworkMachineCastMemberPacingDetail))
            Return x
        Catch ex As Exception
            Return New List(Of TsaTeamDashboardCleanworkMachineCastMemberPacingDetail)
        End Try
    End Function

    Public Function GetTeamCleanworkMachinePacingInformation(ByVal numberOfMinutesAgo As Integer) As List(Of TsaTeamDashboardCleanworkMachinePacingDetail) Implements IWcfTsaTeamService.GetTeamCleanworkMachinePacingInformation
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamCleanworkMachinePacingInformation, Now.AddMinutes(-numberOfMinutesAgo), Now, 60).Cast(Of TsaTeamDashboardCleanworkMachinePacingDetail)
        Catch ex As Exception
            Return New List(Of TsaTeamDashboardCleanworkMachinePacingDetail)
        End Try
    End Function

    Public Function GetTeamWashdeckMachineBagDropsByShift(shift As LintShiftData) As TsaTeamDashboardBagDropData Implements IWcfTsaTeamService.GetTeamWashdeckMachineBagDropsByShift
        Try
            Return CType(GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamWashdeckBagDrops, shift.ShiftStartTime, Now, 60), TsaTeamDashboardBagDropData)
        Catch ex As Exception
            Return New TsaTeamDashboardBagDropData
        End Try
    End Function

    Public Function GetTeamWashdeckMachineFullStatusByShift(shift As LintShiftData) As TsaTeamDashboardDataList Implements IWcfTsaTeamService.GetTeamWashdeckMachineFullStatusByShift
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamWashdeckDashboardData, shift.ShiftStartTime, Now, 60)
        Catch ex As Exception
            Return Activator.CreateInstance(Of TsaTeamDashboardDataList)
        End Try
    End Function

    Public Function GetTeamCurrentMachineStatus() As List(Of TsaTeamMachineCurrentStatus) Implements IWcfTsaTeamService.GetTeamCurrentMachineStatus
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamCurrentMachineStatus, 60)
        Catch ex As Exception
            Return New List(Of TsaTeamMachineCurrentStatus)
        End Try
    End Function

    Public Function GetTeamMachineStatusDistrbutionDetails(shift As LintShiftData) As List(Of TsaTeamMachineStatusDistributionDetail) Implements IWcfTsaTeamService.GetTeamMachineStatusDistrbutionDetails
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamMachineStatusDistrbutionDetails, shift.ShiftStartTime, Now, 60).OfType(Of TsaTeamMachineStatusDistributionDetail)
        Catch ex As Exception
            Return New List(Of TsaTeamMachineStatusDistributionDetail)
        End Try
    End Function

    Public Function GetTeamMachineFullStatusByShift(shift As LintShiftData) As TsaTeamDashboardDataList Implements IWcfTsaTeamService.GetTeamMachineFullStatusByShift
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Team.GetTeamMachineDashboardData, shift.ShiftStartTime, Now, 60)
        Catch ex As Exception
            Return New TsaTeamDashboardDataList
        End Try
    End Function

#End Region

End Class
