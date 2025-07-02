Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Textile.Global.Dal.Helpers
Imports Wdw_Sust.Textile.Tsa.Wcf.Core

Public Class BllDatabaseRailInfoProvider
    Inherits BllRailInfoProviderBase(Of BllDatabaseRailInfoProvider)

    Private _factory As TsaFactoryProvider
    Protected ReadOnly Property Factory As TsaFactoryProvider
        Get
            If _factory Is Nothing Then _factory = TsaFactoryProvider.Instance
            Return _factory
        End Get
    End Property

    Public Overrides Function GetCartDumpProductivityData(shift As LintShiftData) As List(Of LintCartDumpProductivityData)
        Return CatchWhenError(AddressOf Factory.ProductivityReportInfo.GetCartDumpProductivityData, shift.ShiftStartTime, Now())
    End Function

    Public Overrides Function GetCastShiftProductivityData(shift As LintShiftData) As List(Of LintCastMemberProductivityElectronicBoardData)
        Return CatchWhenError(AddressOf Factory.Productivity.GetCastElectronicBoardData, shift.ShiftStartTime, Now())
    End Function

    Public Overrides Function GetLast60MinutesCleanworkProductivity() As LintTotalProductivityEfficiencyData
        Return CatchWhenError(AddressOf Factory.Rail.GetTotalCleanworkProductivityData, Now.AddHours(-1), Now)
    End Function

    Public Overrides Function GetLast60MinutesNumberOfBagDrops() As List(Of LintTunnelProductivityData)
        Return CatchWhenError(AddressOf Factory.Rail.GetTunnelProductivityData, Now.AddHours(-1), Now)
    End Function

    Public Overrides Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer))
        Return CatchWhenError(AddressOf Factory.Rail.GetLast60MinutesSortingPounds)
    End Function

    Public Overrides Function GetNumberOfBagWashedAndSorted(shift As LintShiftData) As List(Of LintKeyValuePair(Of LintZone, Integer))
        Return CatchWhenError(AddressOf Factory.Rail.GetNumberOfBagWashedAndSorted, shift.ShiftStartTime, Now)
    End Function

    Public Overrides Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData)
        Return CatchWhenError(AddressOf Factory.Productivity.GetOperatorMachineLogInStatus)
    End Function

    Public Overrides Function GetSortingProductivityDetails(shift As LintShiftData) As List(Of LintSortingProductivityData)
        Return CatchWhenError(AddressOf Factory.Productivity.GetSortingProductivity, shift.ShiftStartTime, Now())
    End Function

    Public Overrides Function GetTsaLastestProductDistributionSnapShot() As List(Of LintProductSnapshot)
        Return CatchWhenError(AddressOf Factory.Rail.GetLastestProductDistributionLiveSnapShot)
    End Function

    Public Overrides Function GetTsaTowelFoldDepartmentTotal(shift As LintShiftData) As LintTotalProductivityEfficiencyData
        Return CatchWhenError(AddressOf Factory.Rail.GetTotalCleanworkProductivityData, Now.AddHours(-1), Now)
    End Function

    Public Overrides Function GetTSAWashdeckProductivityData(shift As LintShiftData) As System.Collections.Generic.List(Of LintWashdeckProductivityData)
        Return CatchWhenError(AddressOf Factory.Productivity.GetWashdeckProductivityData, shift.ShiftStartTime, Now)
    End Function

    Public Overrides Function Ping() As Boolean
        Return CheckIfDatabaseIsReachable(TextileDbConfigManager.Instance.ConfigFile.ConnectionString(ConnectionStringName.LintProductionConnection))
    End Function

    Public Overrides Function GetTSALast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        Return CatchWhenError(AddressOf Factory.Rail.GetLast60MinutesCallOffProductDistribution)
    End Function

    Public Overrides Function GetTSALast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        Return CatchWhenError(AddressOf Factory.Rail.GetLast60MinutesSortingProductDistribution)
    End Function
End Class
