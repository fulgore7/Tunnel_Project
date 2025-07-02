Namespace Interfaces
    ''' <summary>
    ''' Interface IHaveConnectionString. Implement this class to indicate that
    ''' the object support having a connection string to connect to a database
    ''' </summary>
    Public Interface IHaveConnectionString
        Property ConnectionString() As String
    End Interface
End Namespace