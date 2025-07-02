Imports Wdw_Sust.Core.Interfaces

Namespace EventArgs
    Public Class DataRetrievalEventArgs
        Inherits System.EventArgs
        Implements IDataRetrievalEventArgs

        Public Property InfoRetrivalUnsuccessfulCounts As Integer Implements IDataRetrievalEventArgs.InfoRetrivalUnsuccessfulCounts
        Public Property IsDataRetrivedSuccessfully As String Implements IDataRetrievalEventArgs.IsDataRetrivedSuccessfully
        Public Property ShouldRetrieveDataFromCache As Boolean Implements IDataRetrievalEventArgs.ShouldRetrieveDataFromCache

    End Class
End Namespace