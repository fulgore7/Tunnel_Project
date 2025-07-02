Imports Wdw_Sust.Core.Interfaces

Namespace Cache
    Public MustInherit Class UpdatableBase
        Inherits CacheManager
        Implements ICanUpdate

        ''' <summary>
        ''' This will return the value last time any of the data got updated
        ''' </summary>
        Public Property LastUpdateTime As DateTime Implements ICanUpdate.LastUpdateTime
    End Class
End Namespace