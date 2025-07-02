Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface ILintAlarmBroadcaster(Of T As IDataRetrievalEventArgs)
        Inherits ILintDatabaseInformationBroadcaster(Of T), ILintAlarmBroadcaster
        Event _AlarmStatusUpdateCompleted As EventHandler(Of T)
    End Interface
    Public Interface ILintAlarmBroadcaster
        Inherits ILintDatabaseInformationBroadcaster

    End Interface
End Namespace