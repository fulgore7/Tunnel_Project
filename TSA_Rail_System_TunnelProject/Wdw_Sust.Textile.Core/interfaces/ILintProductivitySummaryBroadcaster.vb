Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface ILintProductivitySummaryBroadcaster
        Inherits ILintDatabaseInformationBroadcaster
    End Interface

    Public Interface ILintProductivitySummaryBroadcaster(Of T As IDataRetrievalEventArgs)
        Inherits ILintProductivitySummaryBroadcaster, ILintDatabaseInformationBroadcaster(Of T) ', IInformationSubscriber(Of IProgramModeManager)
        Event _ProductivitySummaryUpdateCompleted As EventHandler(Of T)
    End Interface


End Namespace