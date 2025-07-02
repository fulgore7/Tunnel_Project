Namespace Interfaces
    Public Interface ISupportCache
        ReadOnly Property Cache As List(Of ICacheData)
        ReadOnly Property IsCacheUsed() As Boolean
        Function IsCached(ByVal itemKey As String) As Boolean
        ''' <summary>
        ''' Invalidate all caches
        ''' </summary>
        Sub InvalidateCache()
        ''' <summary>
        ''' Only Invalidate cache by the item key
        ''' </summary>
        Sub InvalidateCache(ByVal itemKey As String)

        Sub ManageCache(ByVal key As String, ByVal value As Object, ByVal cacheDurationInSeconds As Integer)
    End Interface
End Namespace