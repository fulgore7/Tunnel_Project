Imports System.Data
Imports Wdw_Sust.Core.Helpers
''' <summary>
''' This class is used to create a list of name and value pair, such as Machine ID / Machine Name
''' or Rail Step ID / Rail Step description
''' </summary>
''' <remarks></remarks>
<Serializable()>
Public Class LintNameValuePair
    Inherits LintObjectBase(Of LintNameValuePair)

#Region "Properties"
    Public Property ID() As Integer
    Public Property Name() As String
#End Region

#Region "Constructors"
    Public Sub New(ByVal id As Integer, ByVal name As String)
        Me.ID = id
        Me.Name = name
    End Sub

    Public Sub New(ByVal reader As SqlClient.SqlDataReader)
        ID = FixNull(Of Integer)(reader(0))
        Name = FixNull(Of String)(reader(1))
    End Sub

    Public Sub New()

    End Sub
#End Region

End Class