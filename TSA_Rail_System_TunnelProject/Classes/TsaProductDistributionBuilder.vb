Imports System.Linq
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Tsa
Imports Wdw_Sust.Textile.Tsa.Wcf

''' <summary>
''' To build the pie charts in the TSA rail graphics application
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class TsaProductDistributionBuilder
    Inherits LintObjectBase(Of TsaProductDistributionBuilder)
    ''' <summary>
    ''' Building the chart data
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Build() As IEnumerable(Of TsaProductDistributionDetail)
        Dim classifiedProducts As List(Of LintKeyValuePair(Of String, Double)) = Nothing
        Dim cleanProducts As List(Of LintKeyValuePair(Of String, Double)) = Nothing
        Dim washdeckProducts As List(Of LintKeyValuePair(Of String, Double)) = Nothing
        Dim totalProducts As List(Of LintKeyValuePair(Of String, Double)) = Nothing
        Dim totalProductivity As LintTotalProductivityEfficiencyData = Nothing
        Dim productDistribution As List(Of LintProductSnapshot) = Nothing
        Dim currentSortingRate As List(Of LintKeyValuePair(Of String, Double)) = Nothing
        Dim currentCallOffRate As List(Of LintKeyValuePair(Of String, Double)) = Nothing
        Dim factory As TsaRailInfoProvider = TsaRailInfoProvider.Instance
        Dim list As New List(Of TsaProductDistributionDetail)
        Dim fuct As Func(Of String, TsaProductDistributionDetail) = Function(product As String)
                                                                        Dim detail As New TsaProductDistributionDetail With {.ProductDescription = product}
                                                                        Dim filler As LintKeyValuePair(Of String, Double)
                                                                        filler = currentCallOffRate.FirstOrDefault(Function(a) a.Key = product)
                                                                        detail.CallOffPercentage = If(filler Is Nothing, 0, filler.Value)

                                                                        filler = classifiedProducts.FirstOrDefault(Function(a) a.Key = product)
                                                                        detail.ClassifiedStoragePercentage = If(filler Is Nothing, 0, filler.Value)

                                                                        filler = cleanProducts.FirstOrDefault(Function(a) a.Key = product)
                                                                        detail.CleansideStoragePercentage = If(filler Is Nothing, 0, filler.Value)

                                                                        filler = washdeckProducts.FirstOrDefault(Function(a) a.Key = product)
                                                                        detail.WashdeckPercentage = If(filler Is Nothing, 0, filler.Value)

                                                                        filler = totalProducts.FirstOrDefault(Function(a) a.Key = product)
                                                                        detail.TotalProductPercentage = If(filler Is Nothing, 0, filler.Value)

                                                                        filler = currentSortingRate.FirstOrDefault(Function(a) a.Key = product)
                                                                        detail.SortingPercentage = If(filler Is Nothing, 0, filler.Value)
                                                                        Return detail
                                                                    End Function

        If TryAction(Sub()
                         totalProductivity = BllRailInfoProvider.Instance.Service.GetLast60MinutesCleanworkProductivity
                         productDistribution = BllRailInfoProvider.Instance.Service.GetTsaLastestProductDistributionSnapShot
                         currentSortingRate = BllRailInfoProvider.Instance.Service.GetLast60MinutesSortingProductDistribution
                         currentCallOffRate = BllRailInfoProvider.Instance.Service.GetLast60MinutesCallOffProductDistribution
                         classifiedProducts = factory.GetProductLiveSnapShotByDepartment(productDistribution, Function(a) a.ClassifiedStorageTotalBags)
                         cleanProducts = factory.GetProductLiveSnapShotByDepartment(productDistribution, Function(a) a.CleanworkStorageTotalBags)
                         washdeckProducts = factory.GetProductLiveSnapShotByDepartment(productDistribution, Function(a) a.WashdeckTotalBags)
                         totalProducts = factory.GetTotalProductLiveSnapShotByDepartment(productDistribution)
                     End Sub) Then
            list.Add(fuct("Flatwork"))
            list.Add(fuct("Other"))
            list.Add(fuct("Pillow Case"))
            list.Add(fuct("Hand Fold"))
            list.Add(fuct("Towel Fold"))
        End If
        Return list
    End Function
End Class