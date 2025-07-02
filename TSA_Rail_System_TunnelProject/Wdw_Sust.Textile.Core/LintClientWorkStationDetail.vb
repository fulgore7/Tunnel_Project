<Serializable()>
Public Class LintClientWorkStationDetail
    Public Property WorkStationName As String
    Public Property WorkStation As WorkStations
    Public Sub New(ByVal workStationName As String, ByVal workStation As WorkStations)
        Me.WorkStation = workStation
        Me.WorkStationName = workStationName
    End Sub
    Public Sub New()

    End Sub
End Class