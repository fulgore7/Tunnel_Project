
Imports System.ServiceModel
Imports System.ServiceModel.Dispatcher
Imports System.ServiceModel.Description

Imports Wdw_Sust.Textile.Global.Wcf.Core
Imports Wdw_Sust.Core.Job
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Core.Enums

<ServiceBehavior(ConcurrencyMode:=ConcurrencyMode.Multiple, InstanceContextMode:=InstanceContextMode.Single, IncludeExceptionDetailInFaults:=True)>
Public Class WcfTsaRailInfoService
    Inherits WcfLintNetTcpServiceHostBase(Of IWcfTsaRailInfoService, WcfTsaRailInfoService)
    Implements IWcfTsaRailInfoService, IErrorHandler

#Region "Properties"
    Private _job As New JobManager
#End Region

#Region "Events"
    Public Event InformationRetrivalFailed(sender As Object, e As System.EventArgs) Implements IWcfTsaRailInfoService.InformationRetrivalFailed
#End Region

#Region "Methods"
    Protected Overrides Function CreateFactoryObject() As ILintFactoryProvider
        Return TsaFactoryProvider.Instance
    End Function

    Protected Overrides Sub CreateServiceBehaviors(behaviors As List(Of IServiceBehavior))
        behaviors.Add(New ServiceThrottlingBehavior With
                                  {
                                      .MaxConcurrentCalls = 100,
                                      .MaxConcurrentInstances = 100,
                                      .MaxConcurrentSessions = 100}
                                  )
    End Sub
    Public Function GetNumberOfBagWashedAndSorted(ByVal shift As LintShiftData) As List(Of LintKeyValuePair(Of LintZone, Integer)) Implements IWcfTsaRailInfoService.GetNumberOfBagWashedAndSorted
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetNumberOfBagWashedAndSorted, shift.ShiftStartTime, Now, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetLast60MinutesNumberOfBagDrops() As List(Of LintTunnelProductivityData) Implements IWcfTsaRailInfoService.GetLast60MinutesNumberOfBagDrops
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetTunnelProductivityData, Now.AddHours(-1), Now, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData) Implements IWcfTsaRailInfoService.GetOperatorProductivitySummaryData
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Productivity.GetOperatorMachineLogInStatus, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetTowelFoldDepartmentTotal(ByVal shift As LintShiftData) As LintTotalProductivityEfficiencyData Implements IWcfTsaRailInfoService.GetTsaTowelFoldDepartmentTotal
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetTotalCleanworkProductivityData, shift.ShiftStartTime, Now, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetLast60MinutesCleanworkProductivity() As LintTotalProductivityEfficiencyData Implements IWcfTsaRailInfoService.GetLast60MinutesCleanworkProductivity
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetTotalCleanworkProductivityData, Now.AddHours(-1), Now, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetLastestProductDistributionSnapShot() As List(Of LintProductSnapshot) Implements IWcfTsaRailInfoService.GetTsaLastestProductDistributionSnapShot
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetLastestProductDistributionLiveSnapShot, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetSortingProductivityDetails(shift As LintShiftData) As List(Of LintSortingProductivityData) Implements IWcfTsaRailInfoService.GetSortingProductivityDetails
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Productivity.GetSortingProductivity, shift.ShiftStartTime, Now, 120)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetCartDumpProductivityData(shift As LintShiftData) As List(Of LintCartDumpProductivityData) Implements IWcfTsaRailInfoService.GetCartDumpProductivityData
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.ProductivityReportInfo.GetCartDumpProductivityData, shift.ShiftStartTime, Now, 120)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetCastShiftProductivityData(shift As LintShiftData) As List(Of LintCastMemberProductivityElectronicBoardData) Implements IWcfTsaRailInfoService.GetCastShiftProductivityData
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Productivity.GetCastElectronicBoardData, shift.ShiftStartTime, Now, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer)) Implements IWcfTsaRailInfoService.GetLast60MinutesSortingPounds
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetLast60MinutesSortingPounds, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetWashdeckProductivityData(shift As LintShiftData) As List(Of LintWashdeckProductivityData) Implements IWcfTsaRailInfoService.GetWashdeckProductivityData
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Productivity.GetWashdeckProductivityData, shift.ShiftStartTime, Now, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetLast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double)) Implements IWcfTsaRailInfoService.GetLast60MinutesCallOffProductDistribution
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetLast60MinutesCallOffProductDistribution, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function GetLast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double)) Implements IWcfTsaRailInfoService.GetLast60MinutesSortingProductDistribution
        Try
            Return GetDataFromDatabaseOrCache(AddressOf Factory.Rail.GetLast60MinutesSortingProductDistribution, 60)
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function Ping() As Boolean Implements IWcfTsaRailInfoService.Ping
        Try
            Return True
        Catch ex As Exception
            WriteLog(ex.Message, My.Application.Info.ProductName)
            Throw New FaultException
        End Try
    End Function
    Public Function HandleError([error] As Exception) As Boolean Implements IErrorHandler.HandleError
        Return True
    End Function

    Public Sub ProvideFault([error] As Exception, version As Channels.MessageVersion, ByRef fault As Channels.Message) Implements IErrorHandler.ProvideFault

    End Sub
#End Region

#Region "Constructors"
    'Public Sub New(ByVal baseAddress As String, ByVal portNumber As Integer)
    '    MyBase.New(WcfBindingType.Tcp, baseAddress, portNumber)
    '    ServiceInstance = Me
    '    ' FACTORY.ConnectionString = Config.Instance.LINTInUseConnectionString
    'End Sub
    Public Sub New(ByVal bindingType As WcfBindingType, Optional ByVal lintServiceType As LintServiceType = LintServiceType.WCF_LINT_RAIL_INFO_7851)
        MyBase.New(bindingType, lintServiceType)
        ServiceInstance = Me
    End Sub
#End Region


End Class


