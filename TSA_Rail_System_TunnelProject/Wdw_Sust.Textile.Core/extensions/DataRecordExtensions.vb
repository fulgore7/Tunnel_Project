Imports System.Data

Public Class DataRecordExtensions
    Public Function HasColumn(dataRecord As IDataReader, columnName As String) As Boolean
        For Each dr As DataRow In dataRecord.GetSchemaTable().Rows
            If dr("columnName").ToString() = columnName Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub SetProperty(Of T)(prop As Object, columnName As String, reader As IDataReader)
        If HasColumn(reader, columnName) Then
            prop = reader(columnName)
        End If
    End Sub
End Class
