Imports System.Threading.Tasks

Namespace Cache

    Public Class DataBaseCacheManager
        Inherits CacheManager

        ''' <summary>
        ''' Call this function to either get data from cache or from the database
        ''' </summary>
        ''' <typeparam name="T">Data type that will be returned from the function call</typeparam>
        ''' <param name="fuct">The function that will return the data</param>
        ''' <param name="cacheDurationInSeconds">Determine how long the data will be cached in the cache dictionary. Zero means data will be cached forever before
        ''' it's manually removed.</param>
        ''' <param name="cacheKey">Custom cache key value. If it doesn't apply it will use the function name as the key.</param>
        Protected Function GetDataFromDatabaseOrCache(Of T)(fuct As Func(Of T), Optional cacheDurationInSeconds As Integer = 0, Optional ByVal cacheKey As String = Nothing) As T
            Dim dataToReturn As T
            cacheKey = IIf(cacheKey = Nothing, fuct.Method.Name, cacheKey)
            If Cache.Exists(Function(a) a.Name = cacheKey) AndAlso
                Not Cache.Find(Function(a) a.Name = cacheKey).IsCacheExpired Then
                dataToReturn = CType(Cache.Find(Function(a) a.Name = cacheKey).Data, T)
            Else
                dataToReturn = fuct()
                ManageCache(cacheKey, dataToReturn, cacheDurationInSeconds)
                OnDataRetrievedFromDatabase(Of T)(cacheKey, dataToReturn)
            End If
            Return dataToReturn
        End Function

        Protected Function GetDataFromDatabaseOrCache(Of P1, P2, T)(fuct As Func(Of P1, P2, T), para1 As P1, para2 As P2, Optional cacheDurationInSeconds As Integer = 0) As T
            Return GetDataFromDatabaseOrCache(Of T)(Function() fuct(para1, para2), cacheDurationInSeconds, fuct.Method.Name)
        End Function

        Protected Function GetDataFromDatabaseOrCache(Of P1, T)(fuct As Func(Of P1, T), para1 As P1, Optional cacheDurationInSeconds As Integer = 0) As T
            Return GetDataFromDatabaseOrCache(Of T)(Function() fuct(para1), cacheDurationInSeconds, fuct.Method.Name)
        End Function

        Protected Async Function GetDataFromDatabaseOrCacheAsync(Of P1, P2, T)(fuct As Func(Of P1, P2, T), para1 As P1, para2 As P2, Optional cacheDurationInSeconds As Integer = 0) As Task(Of T)
            Return Await Task.Factory.StartNew(Function() GetDataFromDatabaseOrCache(Of T)(Function() fuct(para1, para2), cacheDurationInSeconds, fuct.Method.Name))
        End Function

        Protected Sub InvalidateExpiredCaches()
            For i As Integer = Cache.Count - 1 To 0 Step -1
                If Cache(i).IsCacheExpired Then Cache.RemoveAt(i)
            Next
        End Sub

        Protected Overridable Sub OnDataRetrievedFromDatabase(Of T)(nameOfFunction As String, dataToReturn As T)

        End Sub

    End Class

End Namespace