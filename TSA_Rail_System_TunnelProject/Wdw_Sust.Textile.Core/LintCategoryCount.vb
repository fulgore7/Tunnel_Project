
Imports Wdw_Sust.Core.Sort

<Serializable(), DefaultSortByProperty("Counts")>
Public Class LintCategoryCount
    Inherits LintObjectBase(Of LintCategoryCount)

#Region "Properties"

    Public Property CategoryCode() As Integer
    Public Property Counts() As Integer
    Public Property Percentage As Double

#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("Category {0} - {1}", CategoryCode, Counts)
    End Function
#End Region

#Region "Constructors"

    Public Sub New(ByVal categoryCode As Integer, ByVal counts As Integer)
        Me.CategoryCode = categoryCode
        Me.Counts = counts
    End Sub

    Public Sub New(ByVal categoryCode As Integer, ByVal counts As Integer, ByVal percentage As Double)
        Me.CategoryCode = categoryCode
        Me.Counts = counts
        Me.Percentage = percentage
    End Sub

    Public Sub New()

    End Sub

#End Region
End Class



