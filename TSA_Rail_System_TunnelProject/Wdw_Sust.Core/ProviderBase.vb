Imports System.Data
Imports System.Data.SqlClient
Imports Wdw_Sust.Core.Cache
Imports Wdw_Sust.Core.Interfaces

Public MustInherit Class ProviderBase(Of SpecifiedProvider As Class)
    Inherits SingletonProviderBase(Of SpecifiedProvider)
    Implements IDatabaseProvider

#Region "Fields"

    Private _cacheManager As ISupportCache = New CacheManager
    Private _connectionString As String

#End Region

#Region "Events"

    Public Event ConnectionStringNotDefinedException(sender As Object, e As System.EventArgs)

#End Region

#Region "Properties"

    ''' <summary>
    ''' Connection String of the reference database
    ''' </summary>
    ''' <value>Connection String</value>
    ''' <returns></returns>
    ''' <remarks>Use the connection settings defined from the class
    ''' WDW_SUST.Textile.LINT.Config</remarks>
    Public Overridable Property ConnectionString() As String Implements IDatabaseProvider.ConnectionString
        Get
            If _connectionString Is Nothing Then
                Throw New Exception(String.Format("Specify a reference connection string for type {0}!!", Me.GetType.Name))
                'If connectionstringnotdefinedexceptioneventhandler.
                'RaiseEvent ConnectionStringNotDefinedException(Me, EventArgs.Empty)
            End If
            Return _connectionString
        End Get
        Set(value As String)
            _connectionString = value
        End Set
    End Property

    Protected ReadOnly Property Cache() As List(Of ICacheData) Implements ISupportCache.Cache
        Get
            Return _cacheManager.Cache
        End Get
    End Property

    Protected Overridable ReadOnly Property IsCacheUsed As Boolean Implements ISupportCache.IsCacheUsed
        Get
            Return True
        End Get
    End Property

#End Region

#Region "Methods"

#Region "Cache Stuff"

    Public Sub ClearInvalidCache()
        For i As Integer = Cache.Count - 1 To 0 Step -1
            If Cache(i).IsCacheExpired Then Cache.RemoveAt(i)
        Next
    End Sub

    ''' <summary>
    ''' Call this function to either get data from cache or from the database
    ''' </summary>
    ''' <typeparam name="T">Data type that will be returned from the function call</typeparam>
    ''' <param name="fuct">The function that will return the data</param>
    ''' <param name="cacheDurationInSeconds">Determine how long the data will be cached in the cache dictionary. Zero means data will be cached forever before
    ''' it's manually removed.</param>
    ''' <param name="cacheKey">Custom cache key value. If it doesn't apply it will use the function name as the key.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function GetDataFromDatabaseOrCache(Of T)(fuct As Func(Of T), Optional cacheDurationInSeconds As Integer = 0, Optional cacheKey As String = Nothing) As T
        Dim dataToReturn As T
        cacheKey = IIf(cacheKey = Nothing, fuct.Method.Name, cacheKey)
        If IsCacheUsed AndAlso Cache.Exists(Function(a) a.Name.ToLower = cacheKey.ToLower) AndAlso
                Not Cache.Find(Function(a) a.Name = cacheKey).IsCacheExpired Then
            dataToReturn = CType(Cache.Find(Function(a) a.Name = cacheKey).Data, T)
        Else
            dataToReturn = fuct()
            ManageCache(cacheKey, dataToReturn, cacheDurationInSeconds)
        End If
        Return dataToReturn
    End Function

    Protected Function GetDataFromDatabaseOrCache(Of P1, P2, T)(fuct As Func(Of P1, P2, T), para1 As P1, para2 As P2, Optional cacheDurationInSeconds As Integer = 0) As T
        Return GetDataFromDatabaseOrCache(Of T)(Function() fuct(para1, para2), cacheDurationInSeconds, fuct.Method.Name)
    End Function

    Protected Function GetDataFromDatabaseOrCache(Of P1, T)(fuct As Func(Of P1, T), para1 As P1, Optional cacheDurationInSeconds As Integer = 0) As T
        Try
            Return GetDataFromDatabaseOrCache(Of T)(Function() fuct(para1), cacheDurationInSeconds, fuct.Method.Name)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

    Public Sub ExecuteNonQuery(storedProcedureName As String, ParamArray parameters As SqlClient.SqlParameter())
        Using cn As New SqlClient.SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(storedProcedureName, cn)
                cmd.CommandType = CommandType.StoredProcedure
                Array.ForEach(parameters, Sub(a) cmd.Parameters.Add(a))
                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ExecuteNonQuery(storedProcedureName As String, Optional connectionString As String = Nothing)
        If connectionString Is Nothing Then
            connectionString = Me.ConnectionString
        End If
        Using cn As New SqlClient.SqlConnection(connectionString)
            Using cmd As New SqlCommand(storedProcedureName, cn)
                cmd.CommandType = CommandType.StoredProcedure
                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Use for text queries only, not for stored procedure
    ''' </summary>
    ''' <param name="commandText">Command text in the format of 'Query Test {...}'</param>
    ''' <param name="parameters">Parameters in the {...} brackets</param>
    ''' <remarks></remarks>
    Public Sub ExecuteNonQuery(commandText As String, ParamArray parameters As Object())
        Using cn As New SqlClient.SqlConnection(ConnectionString)
            Using cmd As SqlCommand = cn.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = String.Format(commandText, parameters)
                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ExecuteReader(Of T)(storedProcedureName As String, parameters As List(Of SqlClient.SqlParameter)) As List(Of T)
        Dim list As List(Of T) = Activator.CreateInstance(Of List(Of T))()
        Using cn As New SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(storedProcedureName, cn)
                Dim reader As SqlDataReader
                If parameters IsNot Nothing Then parameters.ForEach(Sub(a) cmd.Parameters.Add(a))
                cmd.CommandType = CommandType.StoredProcedure
                cn.Open()
                reader = cmd.ExecuteReader
                While reader.Read
                    list.Add(Activator.CreateInstance(GetType(T), reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ''' <summary>
    ''' Use for text queries only. Return a list of the object type 'T'
    ''' </summary>
    ''' <typeparam name="T">Type parameter of the returned object type</typeparam>
    ''' <param name="commandText">Text command in the format of 'Query Text {...}'</param>
    ''' <param name="parameters">Parameters in the {...} brackets. It has to be in the same order in the {...} brackets</param>
    ''' <returns>List of object type 'T'</returns>
    ''' <remarks></remarks>
    Public Function ExecuteReader(Of T)(commandText As String, ParamArray parameters As Object()) As List(Of T)
        Dim list As List(Of T) = Activator.CreateInstance(Of List(Of T))()
        Using cn As New SqlConnection(ConnectionString)
            Using cmd As SqlCommand = cn.CreateCommand
                Dim reader As SqlDataReader
                cmd.CommandText = String.Format(commandText, parameters)
                cmd.CommandType = CommandType.Text
                cn.Open()
                reader = cmd.ExecuteReader
                While reader.Read
                    list.Add(Activator.CreateInstance(GetType(T), reader))
                End While
            End Using
        End Using
        Return list
    End Function

    Public Function ExecuteReader(Of T)(commandText As String) As List(Of T)
        Dim list As List(Of T) = Activator.CreateInstance(Of List(Of T))()
        Using cn As New SqlConnection(ConnectionString)
            Using cmd As SqlCommand = cn.CreateCommand
                Dim reader As SqlDataReader
                cmd.CommandText = commandText
                cmd.CommandType = CommandType.Text
                cn.Open()
                reader = cmd.ExecuteReader
                While reader.Read
                    list.Add(Activator.CreateInstance(GetType(T), reader))
                End While
            End Using
        End Using
        Return list
    End Function

    Public Function ExecuteReaderWithSingleObject(Of T)(commandText As String, ParamArray parameters As Object()) As T
        Using cn As New SqlConnection(ConnectionString)
            Using cmd As SqlCommand = cn.CreateCommand
                Dim reader As SqlDataReader
                cmd.CommandText = String.Format(commandText, parameters)
                cmd.CommandType = CommandType.Text
                cn.Open()
                reader = cmd.ExecuteReader
                If reader.Read Then
                    Return Activator.CreateInstance(GetType(T), reader)
                End If
            End Using
        End Using
        Return Activator.CreateInstance(GetType(T))
    End Function

    Public Function ExecuteScalar(Of T)(storedProcedureName As String, parameters As List(Of SqlClient.SqlParameter)) As T
        Dim obj As T
        Using cn As New SqlConnection(ConnectionString)
            Using cmd As SqlCommand = cn.CreateCommand
                If parameters IsNot Nothing Then parameters.ForEach(Sub(a) cmd.Parameters.Add(a))
                cmd.CommandText = storedProcedureName
                cmd.CommandType = CommandType.StoredProcedure
                cn.Open()
                If GetType(T).IsValueType Then
                    obj = cmd.ExecuteScalar
                Else
                    Dim reader As SqlClient.SqlDataReader
                    reader = cmd.ExecuteReader
                    obj = Activator.CreateInstance(GetType(T), reader)
                End If
            End Using
        End Using
        Return obj
    End Function

    Public Function ExecuteScalar(Of T)(commandText As String, ParamArray parameters As Object()) As T
        Dim obj As T
        Using cn As New SqlConnection(ConnectionString)
            Using cmd As SqlCommand = cn.CreateCommand
                cmd.CommandText = String.Format(commandText, parameters)
                cmd.CommandType = CommandType.Text
                cn.Open()
                If GetType(T).IsValueType Then
                    obj = cmd.ExecuteScalar
                Else
                    Dim reader As SqlDataReader
                    reader = cmd.ExecuteReader
                    obj = Activator.CreateInstance(GetType(T), reader)
                End If
            End Using
        End Using
        Return obj
    End Function

    Public Sub InvalidateCache() Implements IDatabaseProvider.InvalidateCache
        _cacheManager.InvalidateCache()
    End Sub

    Public Sub InvalidateCache(itemKey As String) Implements IDatabaseProvider.InvalidateCache
        _cacheManager.InvalidateCache(itemKey)
    End Sub

    Protected Function IsCached(itemKey As String) As Boolean Implements ISupportCache.IsCached
        Return IsCacheUsed AndAlso _cacheManager.IsCached(itemKey)
    End Function

    ''' <summary>
    ''' Manage the cache dictionary. If the cache dictionary already has the value,
    ''' it will replace its value to the new ones, otherwise it will add the value to the
    ''' dictionary.
    ''' </summary>
    ''' <param name="key">Key of the cache value</param>
    ''' <param name="value">Data associated with the key</param>
    ''' <param name="cacheDurationInSeconds">Cache duration. Zero means indefinite</param>
    ''' <remarks></remarks>
    Protected Sub ManageCache(key As String, value As Object, cacheDurationInSeconds As Integer) Implements ISupportCache.ManageCache
        _cacheManager.ManageCache(key, value, cacheDurationInSeconds)
    End Sub

#End Region

End Class