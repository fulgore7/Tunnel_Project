Imports Wdw_Sust.Core.Interfaces

Namespace Cache
    Public Class CacheManager
        Inherits NotifyableBase
        Implements ISupportCache
        Private _cache As List(Of ICacheData)
        ''' <summary>
        ''' Used to cache repeatedly used data to memory.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected ReadOnly Property Cache() As List(Of ICacheData) Implements ISupportCache.Cache
            Get
                If _cache Is Nothing Then _cache = New List(Of ICacheData)
                Return _cache
            End Get
        End Property

        Public Sub InvalidateCache() Implements ISupportCache.InvalidateCache
            If _cache IsNot Nothing Then
                _cache.Clear()
                _cache = Nothing
            End If
        End Sub

        Public Sub InvalidateCache(itemKey As String) Implements ISupportCache.InvalidateCache
            Try
                _cache.RemoveAll(Function(a) a.Name.ToLower = itemKey.ToLower)
            Catch ex As Exception
                Debug.Print("Cannot invalidate cache. Name {0} is undefined!!", itemKey)
            End Try
        End Sub

        Public Function IsCached(itemKey As String) As Boolean Implements ISupportCache.IsCached
            Return IsCacheUsed AndAlso Cache.Exists(Function(a) a.Name.ToLower = itemKey.ToLower)
        End Function

        Protected Overridable ReadOnly Property IsCacheUsed As Boolean Implements ISupportCache.IsCacheUsed
            Get
                Return True
            End Get
        End Property

        ''' <summary>
        ''' Manage the cache dictionary. If the cache dictionary already has the value,
        ''' it will replace its value to the new ones, otherwises it will add the value to the 
        ''' dictionary.
        ''' </summary>
        ''' <param name="key">Key of the cache value</param>
        ''' <param name="value">Data associated with the key</param>
        ''' <remarks></remarks>
        Protected Sub ManageCache(ByVal key As String, ByVal value As Object, ByVal cacheDurationInSeconds As Integer) Implements ISupportCache.ManageCache
            If Cache.Exists(Function(a) a.Name.ToLower = key.ToLower) Then
                Dim cacheData As CacheData = Cache.Find(Function(a) a.Name.ToLower = key.ToLower)
                cacheData.Data = value
                cacheData.CacheDurationInSecond = cacheDurationInSeconds
            Else
                Cache.Add(New CacheData With {.Name = key, .Data = value, .CacheDurationInSecond = cacheDurationInSeconds})
            End If
        End Sub
    End Class

End Namespace
