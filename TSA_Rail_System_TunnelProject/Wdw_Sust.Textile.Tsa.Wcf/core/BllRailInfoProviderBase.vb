Imports Wdw_Sust.Core
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

Namespace Core
    Public MustInherit Class BllRailInfoProviderBase(Of T As Class)
        Inherits SingletonProviderBase(Of T)
        Implements IWcfTsaRailInfoService

        Public MustOverride Function GetCartDumpProductivityData(shift As LintShiftData) As List(Of LintCartDumpProductivityData) Implements IWcfTsaRailInfoService.GetCartDumpProductivityData
        Public MustOverride Function GetCastShiftProductivityData(shift As LintShiftData) As List(Of LintCastMemberProductivityElectronicBoardData) Implements IWcfTsaRailInfoService.GetCastShiftProductivityData
        Public MustOverride Function GetLast60MinutesCleanworkProductivity() As LintTotalProductivityEfficiencyData Implements IWcfTsaRailInfoService.GetLast60MinutesCleanworkProductivity
        Public MustOverride Function GetLast60MinutesNumberOfBagDrops() As List(Of LintTunnelProductivityData) Implements IWcfTsaRailInfoService.GetLast60MinutesNumberOfBagDrops
        Public MustOverride Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer)) Implements IWcfTsaRailInfoService.GetLast60MinutesSortingPounds
        Public MustOverride Function GetNumberOfBagWashedAndSorted(shift As LintShiftData) As List(Of LintKeyValuePair(Of LintZone, Integer)) Implements IWcfTsaRailInfoService.GetNumberOfBagWashedAndSorted
        Public MustOverride Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData) Implements IWcfTsaRailInfoService.GetOperatorProductivitySummaryData
        Public MustOverride Function GetSortingProductivityDetails(shift As LintShiftData) As List(Of LintSortingProductivityData) Implements IWcfTsaRailInfoService.GetSortingProductivityDetails
        Public MustOverride Function GetTsaLastestProductDistributionSnapShot() As List(Of LintProductSnapshot) Implements IWcfTsaRailInfoService.GetTsaLastestProductDistributionSnapShot
        Public MustOverride Function GetTsaTowelFoldDepartmentTotal(shift As LintShiftData) As LintTotalProductivityEfficiencyData Implements IWcfTsaRailInfoService.GetTsaTowelFoldDepartmentTotal
        Public MustOverride Function GetTSAWashdeckProductivityData(shift As LintShiftData) As List(Of LintWashdeckProductivityData) Implements IWcfTsaRailInfoService.GetWashdeckProductivityData
        Public MustOverride Function GetTSALast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double)) Implements IWcfTsaRailInfoService.GetLast60MinutesCallOffProductDistribution
        Public MustOverride Function GetTSALast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double)) Implements IWcfTsaRailInfoService.GetLast60MinutesSortingProductDistribution
        Public MustOverride Function Ping() As Boolean Implements IWcfTsaRailInfoService.Ping

        Protected Function CatchWhenError(Of Z)(asFunction As Func(Of Z)) As Z
            Try
                Return asFunction()
            Catch ex As Exception
                RaiseEvent InformationRetrivalFailed(Me, System.EventArgs.Empty)
                Return Activator.CreateInstance(Of Z)()
            End Try
        End Function

        Protected Function CatchWhenError(Of X, Y, Z)(asFunction As Func(Of X, Y, Z), parameter1 As X, parameter2 As Y) As Z
            Try
                Return asFunction(parameter1, parameter2)
            Catch ex As Exception
                RaiseEvent InformationRetrivalFailed(Me, System.EventArgs.Empty)
                Return Activator.CreateInstance(Of Z)()
            End Try
        End Function

        Protected Function CatchWhenError(Of Y, Z)(asFunction As Func(Of Y, Z), parameter1 As Y) As Z
            Try
                Return asFunction(parameter1)
            Catch ex As Exception
                RaiseEvent InformationRetrivalFailed(Me, System.EventArgs.Empty)
                Return Activator.CreateInstance(Of Z)()
            End Try
        End Function

        Public Event InformationRetrivalFailed(sender As Object, e As System.EventArgs) Implements IWcfTsaRailInfoService.InformationRetrivalFailed

    End Class
End Namespace
