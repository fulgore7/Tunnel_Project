Imports System.Data

Public Class PlantPerformanceByTime
    Inherits PlantPerformance

    Public Property RecordTime As TimeSpan


    Public Sub New(reader As IDataReader)
        MyBase.New(reader)
        RecordTime = reader("RecordTime")
    End Sub
End Class
