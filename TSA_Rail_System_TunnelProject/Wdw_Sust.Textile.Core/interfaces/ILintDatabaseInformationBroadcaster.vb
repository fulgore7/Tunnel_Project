Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces

    Public Interface ILintDatabaseInformationBroadcaster
        Inherits IInformationBroadcaster
        ReadOnly Property NextUpdateTime() As Date

        Property Plant() As Plant

        Property UpdateInterval() As Integer

        Sub Refresh(Optional fromCache As Boolean = False)

        Sub StartSubscribingInformation(refreshImmediately As Boolean)

        Sub StopSubscribingInformation()

    End Interface

    Public Interface ILintDatabaseInformationBroadcaster(Of T As IDataRetrievalEventArgs)
        Inherits ILintDatabaseInformationBroadcaster, IInformationBroadcaster(Of T)
    End Interface

End Namespace