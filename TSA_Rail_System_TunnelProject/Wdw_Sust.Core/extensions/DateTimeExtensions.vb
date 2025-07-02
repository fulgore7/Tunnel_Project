Imports System.Runtime.CompilerServices

Namespace Extensions

    <Extension()>
    Public Module DateTimeExtensions
        <Extension()>
        Function TimeAgo(ByVal obj As Date) As TimeSpan
            Return Now.Subtract(obj)
        End Function
    End Module

    'Public Module CachableDatabaseCommandExtenstions

    '    <Extension()>
    '    Function GetDataFromDatabaseOrCache(Of T)(obj As ISupportCache, fuct As Func(Of T), Optional cacheDurationInSeconds As Integer = 0, Optional ByVal cacheKey As String = Nothing) As T
    '        Dim dataToReturn As T
    '        cacheKey = IIf(cacheKey = Nothing, fuct.Method.Name, cacheKey)
    '        If obj.Cache.ContainsKey(cacheKey) AndAlso
    '            Not obj.Cache(cacheKey).IsCacheExpired Then
    '            dataToReturn = CType(obj.Cache(cacheKey).Data, T)
    '            Console.WriteLine("{0} from cache!", cacheKey)
    '        Else
    '            dataToReturn = fuct()
    '            obj.ManageCache(cacheKey, dataToReturn, cacheDurationInSeconds)
    '            Console.WriteLine("{0} from database!", cacheKey)
    '        End If
    '        Return dataToReturn
    '    End Function

    '    Function GetDataFromDatabaseOrCache(Of P1, P2, T)(obj As ISupportCache, fuct As Func(Of P1, P2, T), para1 As P1, para2 As P2, Optional cacheDurationInSeconds As Integer = 0, Optional ByVal cacheKey As String = Nothing) As T
    '        Return GetDataFromDatabaseOrCache(Of T)(obj, Function() fuct(para1, para2), cacheDurationInSeconds, fuct.Method.Name)
    '        'Dim dataToReturn As T
    '        'cacheKey = IIf(cacheKey = Nothing, fuct.Method.Name, cacheKey)
    '        'If obj.Cache.ContainsKey(cacheKey) AndAlso
    '        '    Not obj.Cache(cacheKey).IsCacheExpired Then
    '        '    dataToReturn = CType(obj.Cache(cacheKey).Data, T)
    '        '    Console.WriteLine("{0} from cache!", cacheKey)
    '        'Else
    '        '    dataToReturn = fuct(para1, para2)
    '        '    obj.ManageCache(cacheKey, dataToReturn, cacheDurationInSeconds)
    '        '    Console.WriteLine("{0} from database!", cacheKey)
    '        'End If
    '        'Return dataToReturn
    '    End Function

    '    Function GetDataFromDatabaseOrCache(Of P1, T)(obj As ISupportCache, fuct As Func(Of P1, T), para1 As P1, Optional cacheDurationInSeconds As Integer = 0, Optional ByVal cacheKey As String = Nothing) As T
    '        Return GetDataFromDatabaseOrCache(Of T)(obj, Function() fuct(para1), cacheDurationInSeconds, fuct.Method.Name)
    '        'Dim dataToReturn As T
    '        'cacheKey = IIf(cacheKey = Nothing, fuct.Method.Name, cacheKey)
    '        'If obj.Cache.ContainsKey(cacheKey) AndAlso
    '        '    Not obj.Cache(cacheKey).IsCacheExpired Then
    '        '    dataToReturn = CType(obj.Cache(cacheKey).Data, T)
    '        '    Console.WriteLine("{0} from cache!", cacheKey)
    '        'Else
    '        '    dataToReturn = fuct(para1)
    '        '    obj.ManageCache(cacheKey, dataToReturn, cacheDurationInSeconds)
    '        '    Console.WriteLine("{0} from database!", cacheKey)
    '        'End If
    '        'Return dataToReturn
    '    End Function
    'End Module
End Namespace
