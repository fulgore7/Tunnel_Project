Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Wcf.Core
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

Public Class WcfTsaRailInfoServiceClient
    Inherits WcfLintNetTcpClientBase(Of IWcfTsaRailInfoService, WcfTsaRailInfoService)
    Implements IWcfTsaRailInfoServiceClient


#Region "Constructors"
    'Public Sub New(ByVal bindingType As WcfBindingType)
    '    MyBase.New(bindingType, LintServiceType.WCF_LINT_RAIL_INFO)
    'End Sub

    Public Sub New(ByVal bindingType As WcfBindingType, Optional ByVal lintServiceType As LintServiceType = LintServiceType.WCF_LINT_RAIL_INFO)
        MyBase.New(bindingType, lintServiceType)
    End Sub

    'Public Sub New(ByVal bindingType As WcfBindingType, ByVal baseAddress As String, ByVal portNumber As Integer)
    '    MyBase.New(bindingType, baseAddress, portNumber)
    'End Sub

#End Region

    Public Function GetCartDumpProductivityData(shift As LintShiftData) As List(Of LintCartDumpProductivityData) Implements IWcfTsaRailInfoServiceClient.GetCartDumpProductivityData
        Try
            Return SafeExecute(Function() Service.GetCartDumpProductivityData(shift))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetCastShiftProductivityData(shift As LintShiftData) As List(Of LintCastMemberProductivityElectronicBoardData) Implements IWcfTsaRailInfoServiceClient.GetCastShiftProductivityData
        Try
            Return SafeExecute(Function() Service.GetCastShiftProductivityData(shift))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetLast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double)) Implements IWcfTsaRailInfoServiceClient.GetLast60MinutesCallOffProductDistribution
        Try
            Return SafeExecute(AddressOf Service.GetLast60MinutesCallOffProductDistribution)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetLast60MinutesCleanworkProductivity() As LintTotalProductivityEfficiencyData Implements IWcfTsaRailInfoServiceClient.GetLast60MinutesCleanworkProductivity
        Try
            Return SafeExecute(AddressOf Service.GetLast60MinutesCleanworkProductivity)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetLast60MinutesNumberOfBagDrops() As List(Of LintTunnelProductivityData) Implements IWcfTsaRailInfoServiceClient.GetLast60MinutesNumberOfBagDrops
        Try
            Return SafeExecute(AddressOf Service.GetLast60MinutesNumberOfBagDrops)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer)) Implements IWcfTsaRailInfoServiceClient.GetLast60MinutesSortingPounds
        Try
            Return SafeExecute(AddressOf Service.GetLast60MinutesSortingPounds)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetLast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double)) Implements IWcfTsaRailInfoServiceClient.GetLast60MinutesSortingProductDistribution
        Try
            Return SafeExecute(AddressOf Service.GetLast60MinutesSortingProductDistribution)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetLastestProductDistributionSnapShot() As List(Of LintProductSnapshot) Implements IWcfTsaRailInfoServiceClient.GetTsaLastestProductDistributionSnapShot
        Try
            Return SafeExecute(AddressOf Service.GetTsaLastestProductDistributionSnapShot)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetNumberOfBagWashedAndSorted(shift As LintShiftData) As List(Of LintKeyValuePair(Of LintZone, Integer)) Implements IWcfTsaRailInfoServiceClient.GetNumberOfBagWashedAndSorted
        Try
            Return SafeExecute(Function() Service.GetNumberOfBagWashedAndSorted(shift))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData) Implements IWcfTsaRailInfoServiceClient.GetOperatorProductivitySummaryData
        Try
            Return SafeExecute(AddressOf Service.GetOperatorProductivitySummaryData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSortingProductivityDetails(shift As LintShiftData) As List(Of LintSortingProductivityData) Implements IWcfTsaRailInfoServiceClient.GetSortingProductivityDetails
        Try
            Return SafeExecute(Function() Service.GetSortingProductivityDetails(shift))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetTowelFoldDepartmentTotal(shift As LintShiftData) As LintTotalProductivityEfficiencyData Implements IWcfTsaRailInfoServiceClient.GetTsaTowelFoldDepartmentTotal
        Try
            Return SafeExecute(Function() Service.GetTsaTowelFoldDepartmentTotal(shift))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetWashdeckProductivityData(shift As LintShiftData) As List(Of LintWashdeckProductivityData) Implements IWcfTsaRailInfoServiceClient.GetWashdeckProductivityData
        Try
            Return SafeExecute(Function() Service.GetWashdeckProductivityData(shift))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Event InformationRetrivalFailed(sender As Object, e As System.EventArgs) Implements IWcfTsaRailInfoServiceClient.InformationRetrivalFailed

    Public Function Ping() As Boolean Implements IWcfTsaRailInfoServiceClient.Ping
        Try
            Return SafeExecute(AddressOf Service.Ping)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class

