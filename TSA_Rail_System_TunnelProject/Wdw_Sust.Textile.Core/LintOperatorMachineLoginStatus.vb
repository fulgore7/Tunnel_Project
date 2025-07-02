Imports System.Data

<Serializable>
Public Class LintOperatorMachineLoginStatus
    Public Property MachineID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property LastUpdateTime As DateTime

    Public Sub New(ByVal reader As IDataReader)
        MachineID = reader("Machine_ID")
        FirstName = reader("First_Name")
        LastName = reader("Last_Name")
        LastUpdateTime = reader("Last_Update_Time")
    End Sub
End Class

