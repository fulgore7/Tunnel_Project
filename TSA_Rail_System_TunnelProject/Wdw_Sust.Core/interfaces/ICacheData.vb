Namespace Interfaces
    Public Interface ICacheData
        Property Name As String
        ReadOnly Property LastUpdateTime As Date
        ReadOnly Property IsCacheExpired As Boolean
        ReadOnly Property SecondsFromCacheExpiring As Integer
        Property Data As Object
    End Interface
End Namespace
