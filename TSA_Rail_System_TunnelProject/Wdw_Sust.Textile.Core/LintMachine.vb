Imports System.Data

Public Class LintMachine
    Public Property MachineID As Integer
    Public Property MachineName As String
    Public Property ParentMachineID As Integer
    Public Property Plant As Plant
    Public Property DisplayInfo As String

    Public Function GetDisplayInfo() As String
        Return $"{MachineName} - {MachineID.ToString()}"
    End Function

    Public Sub New(reader As IDataReader)
        MachineID = reader("Machine_ID")
        MachineName = reader("Machine_Name")
        ParentMachineID = reader("Parent_Machine_ID")
        Plant = CInt(reader("Plant_ID"))

        DisplayInfo = $"{MachineName} - {MachineID.ToString()}"
    End Sub
End Class
