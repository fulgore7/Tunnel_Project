Public Class Machine
    Public Property MachineId As Integer
    Public Property MachineDesc As String
    Public Property ParentMachineId As Integer
    Public Property PlantId As Plant
    Public Property NumStations As Integer

    Public Sub New(ByVal reader As IDataReader)
        MachineId = Convert.ToInt32(reader("MachineId"))
        MachineDesc = reader("MachineDesc").ToString()
        ParentMachineId = Convert.ToInt32(reader("ParentMachineId"))
        PlantId = Convert.ToInt32(reader("PlantId"))
        NumStations = Convert.ToInt32(reader("NumStations"))
    End Sub

    Public Sub New()

    End Sub

End Class
