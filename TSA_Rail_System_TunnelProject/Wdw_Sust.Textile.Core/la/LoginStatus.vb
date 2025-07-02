Imports System.Data

Public Class LoginStatus

    Public Sub New(ByVal reader As IDataReader)
        LoginTimestamp = Convert.ToDateTime(reader("LoginTimestamp"))
        Person = New Person(reader)
        MachineId = Convert.ToInt32(reader("MachineId"))
        PositionNo = Convert.ToInt32(reader("PositionNo"))
    End Sub

    Public Property LoginTimestamp As DateTime
    Public Property MachineId As Integer
    Public Property Person As Person
    Public Property PositionNo As Integer
End Class