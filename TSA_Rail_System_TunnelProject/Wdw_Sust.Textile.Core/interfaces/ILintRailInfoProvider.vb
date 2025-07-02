Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.EventArgs

Namespace Interfaces
    ''' <summary>
    ''' Basic skeleton for all rail program to stay consistency. All rail program must implement
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface ILintRailInfoProvider
        Inherits IDatabaseProvider
        Function GetCategoryDetail(ByVal categoryID As Integer) As ILintCategoryDetail
        Function GetCategoryDetails() As List(Of ILintCategoryDetail)
        Function GetCategoryDescriptionByID(ByVal categoryID As Integer) As String
        Function GetMachineLastAvailableTime(machineID As Integer) As Date
        Function GetCategoryDescriptionDetails() As List(Of LintCategoryDetail)
        Function GetBagColor(ByVal categoryID As Integer) As LintBagColorProperties
        Function GetCategoryReleaseWeight(ByVal categoryCode As Integer) As Integer
        Function GetCategoryReleaseWeight(ByVal categoryCode As Integer, zone As LintZone) As Integer
        Function GetRailSequenceSteps(ByVal sequenceID As Integer) As LintRailSequence
        Function GetRailSequenceStep(ByVal sequeunceID As Integer, ByVal stepNumber As Integer) As LintRailSequenceStep
        Function GetRailSequenceStepDescription(ByVal sequenceID As Integer, ByVal currentStep As Integer) As String
        Function GetRailSequenceLockedOutInformation(ByVal sequenceID As Integer) As LintRailSequenceLockoutInfo
        Function GetRailSequenceNames() As List(Of LintKeyValuePair(Of Integer, String))
        Function GetClassifiedBagDetail(ByVal plcBagID As Integer) As ILintBagDetail
        Function GetCleanworkBagDetail(ByVal plcBagID As Integer) As ILintBagDetail
        Function GetLastRailSequenceModifiedData(ByVal sequenceID As Integer) As LintRailSequenceEditData
        Function GetOperatorEventLog(ByVal dateFrom As DateTime, ByVal dateTo As Date) As List(Of LintRailEditData)
        Function GetMachineNamesByPlant(ByVal plant As Plant) As List(Of LintNameValuePair)
        Function GetMachineName(ByVal machineID As Integer, ByVal plant As Plant) As String
        Function GetNumberOfBagWashedAndSorted(ByVal startTime As Date, ByVal endTime As Date) As List(Of LintKeyValuePair(Of LintZone, Integer))
        Function GetBagEditDetails(ByVal bagID As Integer) As List(Of LintBagEditDetail)
        Function GetSortingProductivityDetails(ByVal startTime As Date, ByVal endTime As Date) As List(Of LintMachineHourlyProductivityData)
        Function GetTotalCleanworkProductivityData(ByVal startTime As Date, ByVal endTime As Date) As LintTotalProductivityEfficiencyData
        Function GetLastestProductDistributionLiveSnapShot() As List(Of LintProductSnapshot)
        Function GetTunnelProductivityData(ByVal startTime As Date, ByVal endTime As Date) As List(Of LintTunnelProductivityData)
        Function GetLast60MinutesCallOffProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        Function GetLast60MinutesSortingPounds() As List(Of LintKeyValuePair(Of String, Integer))
        Function GetLast60MinutesSortingProductDistribution() As List(Of LintKeyValuePair(Of String, Double))
        Function GetPlcComponentData(ByVal plcComponentID As Integer) As IPlcComponentData
        Function GetWashGroupInfo(ByVal washGroupID As Integer) As LintWashGroupInfo
        Sub AddOperatorBagEventLog(ByVal bagEventLog As LintBagEditLogEventArgs)
        Sub AddOperatorRailSequenceEditEventLog(ByVal railSequenceEdit As LintRailSequenceEventArgs)
        Sub AddOperatorEventLog(ByVal eventLogData As LintOperatorEventArgs)
        Sub AddCleanworkBagReportedProblem(ByVal timeReport As Date, ByVal machineID As Integer, ByVal categoryID As Integer, ByVal reasoningID As Integer, ByVal comments As String, ByVal bagID As Integer, ByVal employeeID As Integer)
        Sub AddApplicationLog(ByVal log As LintApplicationEventLog)
        Sub UpdateRailSequenceLockOutInfo(ByVal sequenceID As Integer, ByVal employeeID As Integer)
        Sub UpdateCategoryData(ByVal category As ILintCategoryDetail)
        Sub UpdateManuallyModifiedBag(ByVal plcBagID As Integer, ByVal plcSystem As PLC_System)
        Sub InsertNewCategoryData(ByVal category As ILintCategoryDetail)
        Function GetMachineNamesAll() As List(Of LintMachine)
    End Interface
End Namespace
