Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Core.Helpers
Imports System.Data

<Serializable()>
Public Class LintSortingProductivityData
    Inherits LintObjectBase(Of LintSortingProductivityData)

#Region "Properities"
    Public Property Belt() As String
    Public Property CategoryCode() As Integer
    Public Property Day() As Integer
    Public Property Hour() As Integer
    Public Property Month() As Integer
    Public Property TotalCount() As Integer
    Public Property TotalWeight() As Double
    Public Property Year() As Integer
#End Region

#Region "Methods"

#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        _Belt = reader("Belt")
        _CategoryCode = FixNull(Of Integer)(reader("category_code"))
        _Day = FixNull(Of Double)(reader("Day"))
        _Hour = reader("HOUR")
        _Month = reader("Month")
        _TotalCount = FixNull(Of Integer)(reader("Total_Count"))
        _TotalWeight = FixNull(Of Double)(reader("Total_Weight"))
        _Year = reader("Year")
    End Sub
    Public Sub New()

    End Sub


#End Region

End Class


