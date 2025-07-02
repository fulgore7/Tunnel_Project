Imports System.Data

Public Class LintMachineWithCipData
    Inherits LintMachine
    Public Property Operator_ID_Tag_Name As String
    Public Property Operator_ID_System_Source_ID As Integer

    Public Sub New(ByVal reader As IDataReader)
        MyBase.New(reader)

        Operator_ID_Tag_Name = CStr(reader("Operator_ID_Tag_Name"))
        Operator_ID_System_Source_ID = Convert.ToInt32(reader("Operator_ID_System_Source_ID"))
    End Sub
End Class
