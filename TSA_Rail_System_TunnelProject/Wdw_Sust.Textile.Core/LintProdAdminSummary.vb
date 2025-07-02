Imports System.Data

<Serializable()>
Public Class LintProdAdminSummary
    Inherits LintProdBase

#Region "Properties"
    Public Property DeptName As String
    Public Property TotalProdHours As Double
    Public ReadOnly Property RejectRate As Double
        Get
            Dim pace As Double = (RejectCount / (RejectCount + PieceCount))
            Return pace
        End Get
    End Property
#End Region

#Region "Constructors"
    Public Sub New(ByVal lintUserID As Integer, ByVal pieceCount As Integer, ByVal rejectCount As Integer, ByVal expectedCount As Integer,
                   ByVal firstName As String, ByVal lastName As String, ByVal totalProdHours As Double, ByVal deptName As String)
        MyBase.New(lintUserID, pieceCount, rejectCount, expectedCount, firstName, lastName)
        _TotalProdHours = totalProdHours
        _DeptName = deptName
    End Sub

    Public Sub New(ByVal reader As IDataReader)
        MyBase.New(reader)
        _TotalProdHours = reader("total_prod_hours")
        _DeptName = reader("dept_name")
    End Sub
#End Region

End Class
