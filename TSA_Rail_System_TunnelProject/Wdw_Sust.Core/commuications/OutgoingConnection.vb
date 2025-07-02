Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Net
Imports Wdw_Sust.Core.Interfaces

Namespace Communications
    Public Class IncomingConnection
        Inherits ConnectionBase

        Public Sub New(ByVal socket As TcpClient)
            Me.TCPSocketProtocol = New TcpIpSocketProtocol(socket.Client)
            IsConnected = True
        End Sub

    End Class


    Public Class OutgoingConnection
        Inherits ConnectionBase

        Public Property ConnectionID As Integer

        ''' <summary>
        ''' Connect to remote host
        ''' </summary>
        ''' <param name="hostName">Host name to be connected</param>
        ''' <param name="portNumber">Port number of the remote host</param>
        ''' <returns>Connect status. True = connected</returns>
        ''' <remarks></remarks>
        Public Function Connect(ByVal hostName As String, ByVal portNumber As Integer) As Boolean
            Dim text As String = String.Empty
            IsConnected = TryAction(Sub()
                                        If Not IsConnected Then
                                            TCPSocketProtocol = New TcpIpSocketProtocol()
                                            TCPSocketProtocol.Connect(hostName, portNumber, True)
                                        End If
                                    End Sub, text)
            If IsConnected Then
                CreateAndRunBackgroundThread(AddressOf ProcessIncomingData)
                CreateAndRunBackgroundThread(AddressOf CheckConnectStatus)
                'JOB_MANAGER.AddJob(String.Format("{0}_CheckConnectStatus", Me.GetHashCode), New TimeSpan(0, 0, 5), AddressOf CheckConnectStatus)
            Else
                OnConnectException(System.EventArgs.Empty)
            End If
            Return IsConnected
        End Function

        Public Sub New()

        End Sub

        Private Sub ProcessIncomingData()
            While IsConnected
                Dim msg As INetworkMessage = GetNewMessage()
                If msg IsNot Nothing Then
                    OnMessageReceived(msg)
                Else
                    Thread.Sleep(50)
                End If
            End While
        End Sub

    End Class
End Namespace

