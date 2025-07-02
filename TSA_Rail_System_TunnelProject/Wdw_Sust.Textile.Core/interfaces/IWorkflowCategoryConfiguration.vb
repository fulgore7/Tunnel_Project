
Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface IWorkflowCategoryConfiguration
        Inherits ICanBeDirty
        Property AllowCategoryToBeWashed As Boolean
        Property AllowedOnWasher1 As Boolean
        Property AllowedOnWasher2 As Boolean
        Property AllowedOnWasher3 As Boolean
        Property AllowedOnWasher4 As Boolean
        Property AllowedOnWasher5 As Boolean
        Property AllowedOnWasher6 As Boolean
        Property AllowedOnWasher7 As Boolean
        Property AllowedOnWasher8 As Boolean
        Property AllowedOnWasherExtractors As Boolean
        Property AllowIncompleteBatch As Boolean
        Property BaselineWeightClassifiedStorage As Decimal
        Property BaselineWeightCleanworkStorage As Decimal
        Property BaselineWeightCurrentStatus As Decimal
        Property BaselineWeightHistorical As Decimal
        Property BaselineWeightRecentHistory As Decimal
        Property BatchSizeTunnelWasher As Integer
        Property BatchSizeWasherExtractor As Integer
        Property CategoryCode As Integer
        Property CategoryPreferredWasherOption1 As Integer
        Property CategoryPreferredWasherOption2 As Integer
        Property CategoryPreferredWasherOption3 As Integer
        Property CategoryPreferredWasherOption4 As Integer
        Property CategoryPreferredWasherOption5 As Integer
        Property CategoryPreferredWasherOption6 As Integer
        Property CategoryPreferredWasherOption7 As Integer
        Property CategoryPreferredWasherOption8 As Integer
        Property CategoryPreferredWasherOption9 As Integer
        ReadOnly Property HasValidWasherPreference As Boolean
        Property MaximumClassifiedStoragePercentage As Double
        Property MaximumCleanworkStoragePercentage As Double
        Property MaximumQuantityBeforeCleanworkStorageByPass As Integer
        Property MaximumQuantityInCleanworkToStopCallOff As Integer
        Property MinimumClassifiedStoragePercentage As Double
        Property MinimumCleanworkStoragePercentage As Double
        Property MinimumStorageQuantityBeforeCallOff As Integer
        ReadOnly Property NumberOfWasherPreferences As Integer
        Property ResumeWashingPercentage As Double
        Property StopWashingPercentage As Double
        Property ToleranceMaximum As Double
        Property ToleranceMinimum As Double
        Property ToleranceStartWash As Double
        Property ToleranceStdDev As Double
        Property UseAgingClassified As Boolean
        Property UseAgingCleanwork As Boolean
        ReadOnly Property WasherPreferenceQuantity As Integer
        Function AllowedToWasher(washerNumber As Integer) As Boolean
        Function CanGoToWasher(washerNumber As Integer) As Boolean
        Function GetAllWasherOptions() As List(Of Integer)
        Function IsInPreferredWasherOption(washerNumber As Integer) As Boolean
        Function ToString() As String
        Function WasherPreferencesString() As String
    End Interface
End Namespace