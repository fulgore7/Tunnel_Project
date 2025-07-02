Imports System.Data
Imports System.Data.SqlClient
Imports Wdw_Sust.Textile.Core.Interfaces

<Serializable()>
Public Class LintCategoryDetail
    Inherits LintObjectBase(Of LintCategoryDetail)
    Implements ILintCategoryDetail

#Region "Properities"

    Public Property CategoryID() As Integer Implements ILintCategoryDescription.CategoryId

    Public Property CategoryDescription() As String Implements ILintCategoryDescription.CategoryDescription

    Public Property CategoryScreenColor() As Integer

    Public Property CategoryTextColor() As Integer

    Public Property ReleaseWeight As Integer Implements ILintCategoryDetail.ReleaseWeight

    Public ReadOnly Property DisplayInfo() As String Implements ILintCategoryDescription.DisplayInfo
        Get
            Return Me.ToString
        End Get
    End Property
#End Region

#Region "Methods"
    Public Function GetBagColor() As LintBagColorProperties Implements ILintCategoryDetail.GetBagColor
        Return New LintBagColorProperties(CategoryScreenColor, CategoryTextColor)
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1}", Me.CategoryID, CategoryDescription)
    End Function
#End Region

#Region "Constructors"
    Public Sub New(ByVal categoryID As Integer, ByVal categoryDescription As String)
        Me._CategoryDescription = categoryDescription
        Me._CategoryID = categoryID
    End Sub

    ''' <summary>
    ''' reader(0) = reader("Category_ID"), reader(1) = reader("Category_Description")
    ''' </summary>
    ''' <param name="reader"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal reader As IDataReader)
        Me._CategoryID = reader(0)
        Me._CategoryDescription = reader(1)
    End Sub

    Public Sub New()

    End Sub
#End Region

End Class
