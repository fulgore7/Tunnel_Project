Public Class OpcItemWriteErrorException
    Inherits System.Exception

    Public Sub New(itemName As String, value As Object)
        Me.ItemName = itemName
        Me.Value = value
    End Sub

    Public Property ItemName As String
    Public Property Value As Object
End Class