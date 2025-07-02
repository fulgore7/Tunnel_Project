Imports System.ComponentModel
Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Threading

Imports Wdw_Sust.Core.EventArgs
Imports Wdw_Sust.Core.Interfaces

Namespace Communications
    Public MustInherit Class WcfNetTcpServiceHostBase(Of Contract As Class, Service As Class)
        Inherits WcfNetTcpConnectionBase
        Implements IWcfServiceHost, INotifyPropertyChanged

#Region "Fields"
        Private _reset As New ManualResetEvent(False)
        Private _status As ServiceStatus = ServiceStatus.Stopped
        Private _serviceNameOverride As String
#End Region

#Region "Events"
        Public Event ServiceStarted(sender As Object, e As ServiceEventArgs) Implements IWcfServiceHost.ServiceStarted
        Public Event ServiceStopped(sender As Object, e As ServiceEventArgs) Implements IWcfServiceHost.ServiceStopped
        Public Event ServiceExceptionOccurred(sender As Object, e As ServiceExceptionEventArgs) Implements IWcfServiceHost.ServiceExceptionOccurred
#End Region

#Region "Methods"
        Public Sub StartService() Implements IWcfServiceHost.StartService
            If CanStart Then
                Status = ServiceStatus.StartPending
                Reset.Reset()
                CreateAndRunBackgroundThread(AddressOf ServiceListening)
            End If
        End Sub

        Private Sub ServiceListening()
            If String.IsNullOrEmpty(BaseAddress) Then Throw New ArgumentException("BaseAddress Invalid!")
            If PortNumber <= 0 Then Throw New ArgumentException("PortNumber Invalid!")
            Dim baseUri As New Uri(String.Format("net.tcp://{0}:{1}/", BaseAddress, PortNumber))
            Dim serviceUri = New Uri(baseUri, String.Format("{0}.svc", ServiceName))
            Dim binding As Channels.Binding = CreateBinding()
            Dim msg As String = String.Empty
            OnStartService()
            If Not TryAction(Sub()
                                 Using host As ServiceHost = CreateServiceHost(baseUri)
                                     host.AddServiceEndpoint(ContractType, binding, serviceUri)
                                     AddServiceEndPoint(host)
                                     Dim behaviors As New List(Of IServiceBehavior)
                                     CreateServiceBehaviors(behaviors)
                                     If behaviors.Count > 0 Then behaviors.ForEach(Sub(a) host.Description.Behaviors.Add(a))
                                     host.Open()
                                     RaiseEvent ServiceStarted(Me, New ServiceEventArgs With {.ServiceName = ServiceName})
                                     Status = ServiceStatus.Started
                                     _reset.WaitOne()
                                 End Using
                             End Sub, msg) Then
                RaiseEvent ServiceExceptionOccurred(Me, New ServiceExceptionEventArgs With {.ServiceName = ServiceName, .Message = msg})
            End If
        End Sub

        Protected Overridable Sub AddServiceEndPoint(ByVal host As ServiceHost)

        End Sub

        Protected Overridable Sub CreateServiceBehaviors(ByVal behaviors As List(Of IServiceBehavior))

        End Sub

        Private Function IsSingletonService() As Boolean
            If Attribute.IsDefined(Me.GetType, GetType(ServiceBehaviorAttribute)) Then
                Dim a As ServiceBehaviorAttribute = Attribute.GetCustomAttribute(Me.GetType, GetType(ServiceBehaviorAttribute))
                Return a.InstanceContextMode = InstanceContextMode.Single
            End If
            Return False
        End Function

        Private Function CreateServiceHost(ByVal baseUri) As ServiceHost
            Dim isSingletonType As Boolean = IsSingletonService()
            If isSingletonType AndAlso ServiceInstance Is Nothing Then
                Throw New InvalidOperationException(String.Format("Define property ServiceInstance for type {0} if InstanceContextMode = InstanceContextMode.Single", Me.GetType().ToString))
            ElseIf Not isSingletonType AndAlso ServiceInstance IsNot Nothing Then
                Throw New InvalidOperationException(String.Format("Cannot define property ServiceInstance for type {0} if NOT InstanceContextMode = InstanceContextMode.Single", Me.GetType().ToString))
            End If
            If isSingletonType Then
                Return New ServiceHost(ServiceInstance, New Uri() {baseUri})
            Else
                Return New ServiceHost(ServiceType)
            End If
        End Function

        ''' <summary>
        ''' Overrides to initialize any resource that wants the service to do
        ''' </summary>
        Protected Overridable Sub OnStartService()

        End Sub

        ''' <summary>
        ''' Overrides to release any resource when the service is stopped
        ''' </summary>
        Protected Overridable Sub OnStopService()

        End Sub

        ''' <summary>
        ''' Stop the service so that the service will not be hosted anymore.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub StopService() Implements IWcfServiceHost.StopService
            If CanStop Then
                Status = ServiceStatus.StopPending
                OnStopService()
                _reset.Set()
                Status = ServiceStatus.Stopped
                RaiseEvent ServiceStopped(Me, New ServiceEventArgs With {.ServiceName = ServiceName})
            End If
        End Sub

        Protected Sub RaiseServiceExceptionEvent()
            RaiseEvent ServiceExceptionOccurred(Me, New ServiceEventArgs With {.ServiceName = ServiceName})
        End Sub
#End Region

#Region "Constructors"
        Public Sub New(ByVal bindingType As WcfBindingType)
            MyBase.New(bindingType)
        End Sub

        Public Sub New(ByVal bindingType As WcfBindingType, ByVal baseAddress As String, ByVal portNumber As Integer)
            MyBase.New(bindingType)
            InitializeService(baseAddress, portNumber)
        End Sub

        Public Sub New(ByVal bindingType As WcfBindingType, ByVal baseAddress As String, ByVal portNumber As Integer, serviceNameOverride As String)
            MyBase.New(bindingType)
            Me._serviceNameOverride = serviceNameOverride
            InitializeService(baseAddress, portNumber)
        End Sub

        Private Sub InitializeService(ByVal baseAddress As String, ByVal portnumber As Integer)
            Me.BaseAddress = baseAddress
            Me.PortNumber = portnumber
        End Sub

        Public Sub New(ByVal bindingType As WcfBindingType, ByVal baseAddress As String, ByVal portnumber As Integer, ByVal serviceInstance As Service)
            MyBase.New(bindingType)
            InitializeService(baseAddress, portnumber)
            Me.ServiceInstance = serviceInstance
        End Sub
#End Region

#Region "Properties"
        Public Overrides ReadOnly Property ServiceName As String
            Get
                If (_serviceNameOverride Is Nothing) Then
                    Return GetType(Service).Name
                Else
                    Return _serviceNameOverride
                End If
            End Get
        End Property

        Protected ReadOnly Property Reset As ManualResetEvent
            Get
                Return _reset
            End Get
        End Property

        Public ReadOnly Property ContractType As Type Implements IWcfServiceHost.ContractType
            Get
                Return GetType(Contract)
            End Get
        End Property

        Public ReadOnly Property ServiceType As Type Implements IWcfServiceHost.ServiceType
            Get
                Return GetType(Service)
            End Get
        End Property

        Protected Property ServiceInstance As Service

        Public ReadOnly Property CanStart As Boolean Implements IServiceHost.CanStart
            Get
                Return Status = ServiceStatus.Stopped AndAlso Status <> ServiceStatus.StartPending
            End Get
        End Property

        Public ReadOnly Property IsRunning As Boolean
            Get
                Return Status <> ServiceStatus.Stopped
            End Get
        End Property
        Public ReadOnly Property CanStop As Boolean Implements IServiceHost.CanStop
            Get
                Return Status = ServiceStatus.Started AndAlso Status <> ServiceStatus.StopPending
            End Get
        End Property

        Public Property Status As ServiceStatus Implements IServiceHost.Status
            Get
                Return _status
            End Get
            Protected Set(value As ServiceStatus)
                If _status <> value Then
                    SetField(_status, value)
                    ''_status = value
                End If
            End Set
        End Property
    End Class
#End Region

End Namespace