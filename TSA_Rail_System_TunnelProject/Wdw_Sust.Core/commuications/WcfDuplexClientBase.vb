Imports System.ServiceModel

Imports Wdw_Sust.Core.Communications
Imports Wdw_Sust.Core.Interfaces

<ServiceBehavior(ConcurrencyMode:=ServiceModel.ConcurrencyMode.Reentrant), CallbackBehavior(UseSynchronizationContext:=False)>
Public MustInherit Class WcfDuplexClientBase(Of ContractType As Class, CallBackType As Class)
    Inherits WcfNetTcpClientBase(Of ContractType)
    Implements IJoinableCallBack

    Private _callbackInstance As InstanceContext
    Private _name As String

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property


    Public Overrides ReadOnly Property Service As ContractType
        Get
            If _service Is Nothing OrElse CType(_service, ICommunicationObject).State = CommunicationState.Faulted Then
                If Not TryAction(Sub()
                                     Dim endPoint As EndpointAddress = CreateEndPoint(String.Format("net.tcp://{0}:{1}/{2}.svc", BaseAddress, PortNumber, ServiceName))
                                     Dim binding As Channels.Binding = CreateBinding()
                                     Dim channel As New DuplexChannelFactory(Of ContractType)(_callbackInstance, binding, endPoint)
                                     _service = channel.CreateChannel
                                 End Sub) Then
                End If
            End If
            Return _service
        End Get
    End Property

    Public Sub New(ByVal clientName As String, ByVal bindingType As WcfBindingType, ByVal baseAddress As String, ByVal portNumber As Integer)
        MyBase.New(bindingType, baseAddress, portNumber)
        If Not TypeOf (Me) Is CallBackType Then Throw New ArgumentException("Callback instance can not be nothing")
        _callbackInstance = New InstanceContext(Me)
        _name = clientName
    End Sub

    Sub SomeoneHasJoined(name As String) Implements IJoinableCallBack.SomeoneHasJoined
        MsgBox(String.Format("{0} has joined", name))
    End Sub

    Public Sub ReceiveMessageFromHost(message As String) Implements IJoinableCallBack.MessageFromHost
        MsgBox(message)
    End Sub

    Public Sub SomeoneHasLeft(name As String) Implements IJoinableCallBack.SomeoneHasLeft
        MsgBox(String.Format("{0} has left", name))
    End Sub

    Public Function GetName() As String Implements IJoinableCallBack.GetName
        Return _name
    End Function
End Class