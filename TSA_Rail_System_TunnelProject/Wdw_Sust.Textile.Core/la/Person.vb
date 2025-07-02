Public Class Person
    Public Property PersonId As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property FullName As String

    Public Sub New(ByVal reader As IDataReader)
        PersonId = Convert.ToInt32(reader("PersonId"))
        FirstName = reader("FirstName").ToString()
        LastName = reader("LastName").ToString()

        If FirstName IsNot Nothing And LastName IsNot Nothing Then
            FullName = $"{FirstName} {LastName.First}."
        End If
    End Sub
End Class
