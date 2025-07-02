


Public Class LintSortingDisplayDetail

#Region "Properties"
    Public Property CurrentWeight As Double
    Public Property CategoryNumber As Integer
    Public Property ReleaseWeight As Double
    Public Property StationTotalWeightSorted As Double
    Public Property WeightStationNumber As Integer
    Public Property CategoryDescription As String
    Public Property BeltTotalSorted As Double
    Public Property BeltHourlySorted As Double
    Public Property BagInPosition As Boolean
    Public Property CategoryBackgroundColorInRgb As Integer
    Public Property CategoryFontColorInRgb As Integer
    Public Property BeltDescription As String
    Public ReadOnly Property CurrentWeightPercentage As Double
        Get
            If ReleaseWeight <= 0 Then Return 0
            Return CDbl(CurrentWeight / ReleaseWeight)
        End Get
    End Property

    Public Property StationHourlyWeightSorted As Double
#End Region

End Class


