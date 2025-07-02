Imports Wdw_Sust.Core.Interfaces

Namespace Cache
    Public NotInheritable Class CacheData
        Implements ICacheData
        Private _data As Object
        Private _lastUpdateTime As Date

        ''' <summary>
        ''' Data to be cached
        ''' </summary>
        Public Property Data As Object Implements ICacheData.Data
            Get
                Return _data
            End Get
            Set(value As Object)
                _data = value
                _lastUpdateTime = Now
            End Set
        End Property
        ''' <summary>
        ''' Last update time for the cache
        ''' </summary>
        Public ReadOnly Property LastUpdateTime As Date Implements ICacheData.LastUpdateTime
            Get
                Return _lastUpdateTime
            End Get
        End Property

        Public Property Name As String Implements ICacheData.Name

        Public Property CacheDurationInSecond As Integer
        ''' <summary>
        ''' CacheDurationInSecond = 0 means the cache will never expire.
        ''' </summary>
        Public ReadOnly Property IsCacheExpired As Boolean Implements ICacheData.IsCacheExpired
            Get
                If CacheDurationInSecond = 0 Then Return False
                Return Now.Subtract(LastUpdateTime).TotalSeconds > CacheDurationInSecond
            End Get
        End Property

        Public ReadOnly Property SecondsFromCacheExpiring As Integer Implements ICacheData.SecondsFromCacheExpiring
            Get
                If CacheDurationInSecond = 0 Then Return -1
                Return CacheDurationInSecond - Now.Subtract(LastUpdateTime).TotalSeconds
            End Get
        End Property
    End Class

End Namespace
