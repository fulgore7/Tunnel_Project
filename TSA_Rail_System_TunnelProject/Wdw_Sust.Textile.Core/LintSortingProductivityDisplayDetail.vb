Imports System.Data
Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintSortingProductivityDisplayDetail
    Inherits LintObjectBase(Of LintSortingProductivityDisplayDetail)

#Region "Properties"

    Public Property EmployeeName As String
    Public Property MachineName As String
    Public Property LoginTimeInSecond As Integer
    Public Property PoundsSorted As Double
    Public Property TargetPounds As Double
    Public Property IsLoggedIn As Boolean

    Public ReadOnly Property OperatorEfficiency As Double
        Get
            If TargetPounds > 0 Then
                Return PoundsSorted / TargetPounds
            End If
            Return 0
        End Get
    End Property

#End Region

#Region "Contructors"
    Public Sub New(ByVal reader As IDataReader)
        EmployeeName = reader("Employee_Name")
        MachineName = reader("Machine_Name")
        LoginTimeInSecond = FixNull(Of Double)(reader("Login_Time"))
        PoundsSorted = reader("Pounds_Sorted")
        TargetPounds = reader("Target_Pounds")
        IsLoggedIn = reader("Is_Logged_In")
    End Sub
#End Region

End Class


