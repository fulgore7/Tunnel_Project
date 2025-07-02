Imports System.ServiceModel

Imports Wdw_Sust.Textile.Core

Namespace Interfaces

    <ServiceContract()>
    Public Interface IWcfTsaRailInfoService
        ''' <summary>
        ''' Get number of bags washed and sorted from the beginning of shift up until the minute of that shift.
        ''' This is rolling 60 minutes.
        ''' </summary>
        <OperationContract()>
        Function GetNumberOfBagWashedAndSorted(ByVal shift As LintShiftData) As List(Of LintKeyValuePair(Of LintZone, Integer))
        ''' <summary>
        ''' Get last 60 minutes of bag drops in the washdeck
        ''' </summary>
        <OperationContract()>
        Function GetLast60MinutesNumberOfBagDrops() As List(Of LintTunnelProductivityData)
        ''' <summary>
        ''' 
        ''' </summary>
        <OperationContract()>
        Function GetOperatorProductivitySummaryData() As List(Of LintOperatorProductivitySummaryData)
        ''' <summary>
        ''' Get towel fold department total from the beginning of shift up until the minute of that shift
        ''' </summary>
        <OperationContract()>
        Function GetTsaTowelFoldDepartmentTotal(ByVal shift As LintShiftData) As LintTotalProductivityEfficiencyData
        ''' <summary>
        ''' Get last 60 minutes for the whole cleanwork dempartment productivity. This is rolling 60 minutes
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <OperationContract()>
        Function GetLast60MinutesCleanworkProductivity() As LintTotalProductivityEfficiencyData
        <OperationContract()>
        Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer))
        <OperationContract()>
        Function GetTsaLastestProductDistributionSnapShot() As List(Of LintProductSnapshot)
        <OperationContract()>
        Function GetSortingProductivityDetails(ByVal shift As LintShiftData) As List(Of LintSortingProductivityData)
        <OperationContract()>
        Function GetCartDumpProductivityData(ByVal shift As LintShiftData) As List(Of LintCartDumpProductivityData)
        <OperationContract()>
        Function GetCastShiftProductivityData(ByVal shift As LintShiftData) As List(Of LintCastMemberProductivityElectronicBoardData)
        <OperationContract()>
        Function GetWashdeckProductivityData(ByVal shift As LintShiftData) As List(Of LintWashdeckProductivityData)
        <OperationContract()>
        Function GetLast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        <OperationContract()>
        Function GetLast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        <OperationContract()>
        Function Ping() As Boolean

        Event InformationRetrivalFailed As EventHandler
    End Interface

End Namespace