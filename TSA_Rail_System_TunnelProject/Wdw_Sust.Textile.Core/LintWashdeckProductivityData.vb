Imports System.Data
Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintWashdeckProductivityData
    Inherits LintObjectBase(Of LintWashdeckProductivityData)

#Region "Properities"
    Public Property CategoryCode() As Integer
    Public Property Day() As Integer
    Public Property Hour() As Integer
    Public Property MahcineName() As String
    Public Property Month() As Integer
    Public Property TotalCount() As Integer
    Public Property TotalWeight() As Double
    Public Property Year() As Integer
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        CategoryCode = reader("category_code")
        Day = FixNull(Of Integer)(reader("Day"))
        Hour = FixNull(Of Integer)(reader("Hours"))
        MahcineName = FixNull(Of String)(reader("Machine_Name"))
        Month = FixNull(Of Integer)(reader("Month"))
        TotalCount = FixNull(Of Integer)(reader("Total_Count"))
        TotalWeight = FixNull(Of Double)(reader("Total_Weight"))
        Year = FixNull(Of Integer)(reader("Year"))
    End Sub

    Public Sub New()

    End Sub
#End Region

End Class



