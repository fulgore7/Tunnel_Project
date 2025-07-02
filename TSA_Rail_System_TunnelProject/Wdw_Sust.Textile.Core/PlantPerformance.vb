Imports System.Data

Public Class PlantPerformance
    Public Property Plant As Plant
    Public Property RecordDate As Date
    Public Property PoundsSorted As String
    Public Property PoundsDroppedIntoWasher As String
    Public Property PoundsWashed As String
    Public Property PoundsDroppedAtFlatWork As String

    Public Sub New(reader As IDataReader)
        Plant = reader("Plant")
        RecordDate = reader("RecordDate")
        PoundsSorted = reader("POUNDS_SORTED")
        PoundsDroppedIntoWasher = reader("POUNDS_DROPPEDINTOWASHER")
        PoundsWashed = reader("POUNDS_WASHED")
        PoundsDroppedAtFlatWork = reader("POUNDS_DROPPEDATFLATWORK")
    End Sub
End Class
