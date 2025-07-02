Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Tsa.Wcf
Imports Wdw_Sust.Textile.Tsa.Wcf.Core
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

Public Class BllWcfRailInfoProvider
    Inherits BllRailInfoProviderBase(Of BllWcfRailInfoProvider)

    Private _factory As IWcfTsaFactoryProvider

    Protected ReadOnly Property Factory As IWcfTsaFactoryProvider
        Get
            If _factory Is Nothing Then _factory = New WcfTsaFactoryProvider()
            'TODO: remove local debug code once completed
            'If _factory Is Nothing Then _factory = New WcfTsaLocalFactoryProvider
            Return _factory
        End Get
    End Property

    Public Overrides Function GetCartDumpProductivityData(shift As LintShiftData) As List(Of LintCartDumpProductivityData)
        Return Factory.Rail.GetCartDumpProductivityData(shift)
    End Function

    Public Overrides Function GetCastShiftProductivityData(shift As LintShiftData) As List(Of LintCastMemberProductivityElectronicBoardData)
        Return Factory.Rail.GetCastShiftProductivityData(shift)
    End Function

    Public Overrides Function GetLast60MinutesCleanworkProductivity() As LintTotalProductivityEfficiencyData
        Return Factory.Rail.GetLast60MinutesCleanworkProductivity
    End Function

    Public Overrides Function GetLast60MinutesNumberOfBagDrops() As List(Of LintTunnelProductivityData)
        Return Factory.Rail.GetLast60MinutesNumberOfBagDrops
    End Function

    Public Overrides Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer))
        Return Factory.Rail.GetLast60MinutesSortingPounds
    End Function

    Public Overrides Function GetNumberOfBagWashedAndSorted(shift As LintShiftData) As List(Of LintKeyValuePair(Of LintZone, Integer))
        Return Factory.Rail.GetNumberOfBagWashedAndSorted(shift)
    End Function

    Public Overrides Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData)
        Return Factory.Rail.GetOperatorProductivitySummaryData
    End Function

    Public Overrides Function GetSortingProductivityDetails(shift As LintShiftData) As List(Of LintSortingProductivityData)
        Return Factory.Rail.GetSortingProductivityDetails(shift)
    End Function

    Public Overrides Function GetTsaLastestProductDistributionSnapShot() As List(Of LintProductSnapshot)
        Return Factory.Rail.GetTsaLastestProductDistributionSnapShot
    End Function

    Public Overrides Function GetTsaTowelFoldDepartmentTotal(shift As LintShiftData) As LintTotalProductivityEfficiencyData
        Return Factory.Rail.GetTsaTowelFoldDepartmentTotal(shift)
    End Function

    Public Overrides Function GetTSAWashdeckProductivityData(shift As LintShiftData) As System.Collections.Generic.List(Of LintWashdeckProductivityData)
        Return Factory.Rail.GetWashdeckProductivityData(shift)
    End Function

    Public Overrides Function GetTSALast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        Return Factory.Rail.GetLast60MinutesCallOffProductDistribution
    End Function

    Public Overrides Function GetTSALast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        Return Factory.Rail.GetLast60MinutesSortingProductDistribution
    End Function

    Public Overrides Function Ping() As Boolean
        Return Factory.Rail.Ping
    End Function

End Class