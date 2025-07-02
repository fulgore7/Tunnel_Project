Imports System.Data

Public Class LintAlarmDepartment
    Public Property DepartmentID As Integer
    Public Property DepartmentName As String
    Public Property Plant As Plant

    Public Sub New(reader As IDataReader)
        DepartmentID = reader("Department_ID")
        DepartmentName = reader("Department_Name")
        Plant = CInt(reader("Plant_ID"))
    End Sub
End Class
