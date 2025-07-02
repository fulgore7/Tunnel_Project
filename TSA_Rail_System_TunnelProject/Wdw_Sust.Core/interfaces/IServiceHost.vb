Imports Wdw_Sust.Core.EventArgs

Namespace Interfaces
    Public Interface IServiceHost
        Inherits IHaveServiceName
        Event ServiceStarted As EventHandler(Of ServiceEventArgs)
        Event ServiceStopped As EventHandler(Of ServiceEventArgs)
        Event ServiceExceptionOccurred As EventHandler(Of ServiceExceptionEventArgs)

        Sub StartService()
        Sub StopService()

        Property Status As ServiceStatus
        ReadOnly Property CanStart As Boolean
        ReadOnly Property CanStop As Boolean
    End Interface
End Namespace