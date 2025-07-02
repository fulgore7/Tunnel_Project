Imports System.ServiceModel
Imports Wdw_Sust.Core.Communications
Imports Wdw_Sust.Core.Interfaces

Namespace Communications

    Public MustInherit Class WcfNetTcpClientBase(Of ContractType As Class)
        Inherits WcfNetTcpConnectionBase
        Implements IWcfNetTcpClientBase(Of ContractType), IDisposable

        Protected _service As ContractType

        Private _channel As ChannelFactory(Of ContractType)

        Protected Function SafeExecute(Of T)(ByVal action As Func(Of T)) As T Implements IWcfClientBase(Of ContractType).SafeExecuteContract
            Try
                Return action()
            Catch ex As Exception
                Return Nothing
            Finally
                Proxy.Close()
            End Try
        End Function

        Public Overridable ReadOnly Property Service As ContractType Implements IWcfClientBase(Of ContractType).Service
            Get
                _service = Proxy.CreateChannel
                Return _service
            End Get
        End Property

        Public ReadOnly Property Proxy As ChannelFactory(Of ContractType)
            Get
                Dim endPoint As EndpointAddress = CreateEndPoint(String.Format("net.tcp://{0}:{1}/{2}.svc", BaseAddress, PortNumber, ServiceName))
                Dim binding As Channels.Binding = CreateBinding()
                _channel = New ChannelFactory(Of ContractType)(binding, endPoint)
                Return _channel
            End Get
        End Property

        Protected Overridable Function CreateEndPoint(ByVal serviceAddress As String) As EndpointAddress
            Return New EndpointAddress(serviceAddress)
        End Function

        Public Sub New(ByVal bindingType As WcfBindingType, ByVal baseAddress As String, ByVal portNumber As Integer)
            MyBase.New(bindingType)
            Me.BaseAddress = baseAddress
            Me.PortNumber = portNumber
        End Sub

        Protected Sub CleanUp()
            If _service IsNot Nothing Then
                CType(_service, ICommunicationObject).Close()
                _service = Nothing
            End If
        End Sub

        Public ReadOnly Property ServiceStatus As CommunicationState
            Get
                Return CType(Service, ICommunicationObject).State
            End Get
        End Property

        Private disposedValue As Boolean ' To detect redundant calls

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    CleanUp()
                End If
            End If
            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

    End Class

End Namespace