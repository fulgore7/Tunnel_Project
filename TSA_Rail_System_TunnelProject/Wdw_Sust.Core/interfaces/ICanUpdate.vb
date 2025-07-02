Imports Wdw_Sust.Core.Interfaces
Namespace Interfaces
    Public Interface ICanUpdate
        Inherits ISupportCache
        Property LastUpdateTime As DateTime
    End Interface

    Public Interface ICanCancel
        sub Cancal

    End Interface
End Namespace
