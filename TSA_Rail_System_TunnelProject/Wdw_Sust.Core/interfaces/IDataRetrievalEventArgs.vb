Namespace Interfaces
    Public Interface IDataRetrievalEventArgs
        Property IsDataRetrivedSuccessfully() As String
        Property ShouldRetrieveDataFromCache As Boolean
        Property InfoRetrivalUnsuccessfulCounts As Integer
    End Interface
End Namespace
