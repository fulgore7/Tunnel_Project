Imports System.Data
Imports Wdw_Sust.Core

<Serializable()>
Public Class LintProductSnapshot
    Inherits CustomObjectBase

    Public Property CategoryDescription() As String
    Public Property ClassifiedStorageTotalBags() As Double
    Public Property CleanworkStorageTotalBags() As Double
    Public Property WashdeckTotalBags() As Double
    Public Property ProductDepartmentDescription As String


    Public Sub New(ByVal reader As IDataReader)
        _CategoryDescription = reader("category_Description")
        _ClassifiedStorageTotalBags = reader("classified_storage_total_bags")
        _CleanworkStorageTotalBags = reader("cleanwork_storage_total_bags")
        _WashdeckTotalBags = reader("washdeck_total_bags")
        _ProductDepartmentDescription = reader("Product_Department_Description")
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Category: {0}, Classified: {1}, Cleanwork: {2}, Washdeck: {3}", CategoryDescription, ClassifiedStorageTotalBags, CleanworkStorageTotalBags, WashdeckTotalBags)
    End Function
End Class

