Imports System.Data

Public Class LintMachineLoginStatus
    Inherits DataRecordExtensions
    Public Property Machine_ID As Integer
    Public Property RF_Badge_User_ID As Integer

    Public Sub New(ByVal reader As IDataReader)
        Machine_ID = CType(reader("Machine_ID"), Integer)
        RF_Badge_User_ID = CType(reader("RF_Badge_User_ID"), Integer)
    End Sub

    Public Sub New()

    End Sub
End Class
