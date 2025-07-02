Imports System.Data

<Serializable()>
Public Class LintProdSummary
    Inherits LintProdBase


#Region "Properties"
    Public Property TotalProdHours As Double
    Public Property MachineName As String
#End Region

#Region "Constructors"
    Public Sub New(ByVal lintUserID As Integer, ByVal pieceCount As Integer, ByVal rejectCount As Integer, ByVal expectedCount As Integer,
                   ByVal totalProdHours As Integer, ByVal machineName As String, ByVal firstName As String, ByVal lastName As String)
        MyBase.New(lintUserID, pieceCount, rejectCount, expectedCount, firstName, lastName)
        _TotalProdHours = totalProdHours
        _MachineName = machineName
    End Sub

    Public Sub New(ByVal reader As IDataReader)
        MyBase.New(reader)
        _TotalProdHours = reader("total_prod_hours")
        _MachineName = reader("machine_name")
    End Sub
#End Region

End Class
