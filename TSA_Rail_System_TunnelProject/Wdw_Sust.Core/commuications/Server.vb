Imports System.Net.Sockets
Imports System.Threading

Imports System.Net
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.EventArgs

'Public Interface IncomingMessageHandler
'    Sub HandleMessage(ByVal connection As IncomingConnection, ByVal message As INetworkMessage)
'End Interface

'Public Class ServerMessageHandler
'    Implements IncomingMessageHandler

'    Public Sub HandleMessage(connection As IncomingConnection, message As INetworkMessage) Implements IncomingMessageHandler.HandleMessage

'    End Sub
'End Class

Namespace Communications


    Public Class Server

        Private _listenerInstance As TcpListener
        Private _clients As New List(Of IncomingConnection)
        Private _isRunning As Boolean
        Public Property ListenOnLocalIP As IPAddress = IPAddress.Any
        Public Property PortNumber As Integer
        Private CLIENT_LOCK_OBJECT As New Object
        Private _messageEventHandler As IMessageEventHandler
        Private _messageReceivedCounts As Integer

        Public Event ClientCountChanged As EventHandler
        Public Event ServerStatusChanged As EventHandler
        Public Event NewClientConnected As EventHandler(Of MessageEventArgs(Of IncomingConnection))


        Public ReadOnly Property IsRunning As Boolean
            Get
                Return _isRunning
            End Get
        End Property

        Public ReadOnly Property MessageReceivedCounts As Integer
            Get
                Return _messageReceivedCounts
            End Get
        End Property

        Public Sub SetMessageEventHandler(ByVal messageEventHandler As IMessageEventHandler)
            _messageEventHandler = messageEventHandler
        End Sub

        Public ReadOnly Property Clients As IList(Of IncomingConnection)
            Get
                Return _clients.AsReadOnly
            End Get
        End Property

        Public ReadOnly Property ClientCounts As Integer
            Get
                Return Clients.Count
            End Get
        End Property

        Public Sub StartServer()
            If Not IsRunning Then
                If _listenerInstance Is Nothing Then _listenerInstance = New TcpListener(ListenOnLocalIP, PortNumber)
                _isRunning = True
                CreateAndRunBackgroundThread(AddressOf Listening)
                CreateAndRunBackgroundThread(AddressOf ProcessIncomingData)
                CreateAndRunBackgroundThread(AddressOf CheckConnectStatus)
                RaiseEvent ServerStatusChanged(Me, System.EventArgs.Empty)
            End If
        End Sub
        Private Sub OnClientCountChanged()
            RaiseEvent ClientCountChanged(Me, System.EventArgs.Empty)
        End Sub
        Protected Sub CheckConnectStatus()
            Dim clientDisconnected As Boolean
            Dim lists As New List(Of IncomingConnection)
            While IsRunning
                lists.Clear()
                clientDisconnected = False
                SyncLock CLIENT_LOCK_OBJECT
                    _clients.ForEach(Sub(a) If a.TCPSocketProtocol.Socket.Poll(5, SelectMode.SelectRead) Then lists.Add(a))
                    clientDisconnected = lists.Count > 0
                    lists.ForEach(Sub(a) _clients.Remove(a))
                End SyncLock
                If clientDisconnected Then Threading.ThreadPool.QueueUserWorkItem(AddressOf OnClientCountChanged)
                Thread.Sleep(3000)
            End While
        End Sub

        Public Sub New(ByVal messageEventHandler As IMessageEventHandler)
            _messageEventHandler = messageEventHandler
        End Sub

        Private Shared Function InitializeClientConnection(ByVal client As TcpClient) As IncomingConnection
            With client.Client
                .NoDelay = False
                .ReceiveBufferSize = 1000 '8192 * 2
                .SendBufferSize = 1000 '8192 * 2
                .Blocking = True
                Dim clientConnection As New IncomingConnection(client)
                Return clientConnection
            End With
        End Function

        Private Sub Listening()
            _listenerInstance.Start()
            While IsRunning
                If _listenerInstance.Pending Then
                    Dim connection As IncomingConnection
                    SyncLock CLIENT_LOCK_OBJECT
                        connection = InitializeClientConnection(_listenerInstance.AcceptTcpClient)
                        _clients.Add(connection)
                    End SyncLock
                    RaiseEvent NewClientConnected(Me, New MessageEventArgs(Of IncomingConnection) With {.Argument = connection})
                    RaiseEvent ClientCountChanged(Me, System.EventArgs.Empty)
                Else
                    Thread.Sleep(50)
                End If
            End While
        End Sub

        Public Sub StopServer()
            If IsRunning Then
                _listenerInstance.Stop()
                _isRunning = False
                RaiseEvent ServerStatusChanged(Me, System.EventArgs.Empty)
            End If
        End Sub

        Public Sub ShutDown()
            StopServer()
        End Sub

        Public Sub CleanUp()

        End Sub

        Public Sub New(ByVal listenIPAddress As IPAddress, ByVal portNumber As Integer, ByVal messageHandler As IMessageEventHandler)
            InitializeServer(listenIPAddress, portNumber)
            _messageEventHandler = messageHandler
        End Sub

        Private Sub InitializeServer(ByVal ipAddress As IPAddress, ByVal portNumber As Integer)
            Me.ListenOnLocalIP = ipAddress
            Me.PortNumber = portNumber
        End Sub

        Public Sub New(ByVal listenIPAddress As IPAddress, ByVal portnumber As Integer)
            Me.PortNumber = portnumber
        End Sub

        Public Sub BroadcastMessage(ByVal message As INetworkMessage)
            _clients.ForEach(Sub(a) a.SendMessage(message))
        End Sub

        Private Sub ProcessIncomingData()
            While IsRunning
                If _clients.Count > 0 Then
                    SyncLock CLIENT_LOCK_OBJECT
                        _clients.ForEach(Sub(a)
                                             If a Is Nothing Then Exit Sub
                                             Dim msg As INetworkMessage = a.GetNewMessage()
                                             If msg IsNot Nothing Then
                                                 _messageReceivedCounts += 1
                                                 _messageEventHandler.MessageHandler(a, msg)
                                                 Console.WriteLine("message received from a client")
                                                 'OnMessageReceived(msg)
                                                 'do nothing
                                             End If
                                         End Sub)
                    End SyncLock
                Else
                    Thread.Sleep(50)
                End If

            End While

        End Sub

        Friend ReadOnly Property Socket As System.Net.Sockets.Socket
            Get
                If _listenerInstance Is Nothing Then Return Nothing
                Return _listenerInstance.Server
            End Get
        End Property
    End Class

End Namespace
