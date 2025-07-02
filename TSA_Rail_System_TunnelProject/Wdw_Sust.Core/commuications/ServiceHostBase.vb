Imports Wdw_Sust.Core.EventArgs
Imports Wdw_Sust.Core.Interfaces

Namespace Communications
    Public MustInherit Class ServiceHostBase
        Implements IServiceHost

        Private _status As ServiceStatus = ServiceStatus.Stopped

        Public Event ServiceExceptionOccurred(sender As Object, e As ServiceExceptionEventArgs) Implements IServiceHost.ServiceExceptionOccurred
        Public Event ServiceStarted(sender As Object, e As ServiceEventArgs) Implements IServiceHost.ServiceStarted
        Public Event ServiceStopped(sender As Object, e As ServiceEventArgs) Implements IServiceHost.ServiceStopped

        Public ReadOnly Property CanStart As Boolean Implements IServiceHost.CanStart
            Get
                Return Status = ServiceStatus.Stopped AndAlso Status <> ServiceStatus.StartPending
            End Get
        End Property

        Public ReadOnly Property CanStop As Boolean Implements IServiceHost.CanStop
            Get
                Return Status = ServiceStatus.Started AndAlso Status <> ServiceStatus.StopPending
            End Get
        End Property

        Public Overridable ReadOnly Property ServiceName As String Implements IServiceHost.ServiceName
            Get
                Return Me.GetType.Name
            End Get
        End Property

        Public ReadOnly Property IsRunning As Boolean
            Get
                Return Status <> ServiceStatus.Stopped
            End Get
        End Property

        Public Property Status As ServiceStatus Implements IServiceHost.Status
            Get
                Return _status
            End Get
            Protected Set(value As ServiceStatus)
                If _status <> value Then
                    _status = value
                End If
            End Set
        End Property

        Protected Sub OnRaiseServiceExceptionOccurredEvent(ByVal msg As String)
            RaiseEvent ServiceExceptionOccurred(Me, New ServiceExceptionEventArgs With {.ServiceName = ServiceName, .Message = msg})
        End Sub

        Protected Sub OnRaiseServiceStartedEvent()
            Status = ServiceStatus.Started
            RaiseEvent ServiceStarted(Me, New ServiceEventArgs With {.ServiceName = ServiceName})
        End Sub

        Protected Sub OnRaiseServiceStoppedEvent()
            Status = ServiceStatus.Stopped
            RaiseEvent ServiceStopped(Me, New ServiceEventArgs With {.ServiceName = ServiceName})
        End Sub

        Public MustOverride Sub StartService() Implements IServiceHost.StartService
        Public MustOverride Sub StopService() Implements IServiceHost.StopService
    End Class

End Namespace