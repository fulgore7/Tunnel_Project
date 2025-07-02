Public Class EventLogEntry
    Public Property eventTimeStamp As DateTime
    Public Property plantId As Plant
    Public Property sourceId As Integer
    Public Property SourceSessionId As Integer
    Public Property eventType As Integer
    Public Property subEventType As Integer
    Public Property referenceTypeId As Integer
    Public Property subReferenceTypeId As Integer
    Public Property machineId As Integer
    Public Property eventSubId As Integer
    Public Property batchId As Integer
    Public Property userId As Integer
    Public Property eventText As String
    Public Property eventText2 As String
    Public Property eventState As Boolean
    Public Property eventValue As Decimal
    Public Property valueTypeId As Integer
End Class
