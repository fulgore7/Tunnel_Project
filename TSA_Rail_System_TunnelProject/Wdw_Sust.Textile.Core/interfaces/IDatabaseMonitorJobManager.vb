Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.EventArgs

Namespace Interfaces
    Public Interface IDatabaseMonitorJobManager
        ReadOnly Property DatabaseIsOnline As Boolean
        ReadOnly Property LastSeenTime As Date
        Event DatabaseStatusChanged As EventHandler
        Sub StartMonitoring()
        Sub StopMonitoring()
    End Interface
End Namespace

