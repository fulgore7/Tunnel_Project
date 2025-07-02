Imports System.Net.Sockets
Imports Wdw_Sust.Core.Interfaces

Namespace Communications

    Public Class TcpIpSocketProtocol
        Implements ICommunicationProtocol

#Region "Properties"

        Public Property Socket() As Socket Implements ICommunicationProtocol.Socket

        Public ReadOnly Property Available() As Integer Implements ICommunicationProtocol.Available
            Get
                If Socket Is Nothing Then Return -1
                Return Socket.Available
            End Get
        End Property

#End Region

#Region "Methods"

        Public Function Connect(ByVal hostName As String, ByVal portNumber As Integer, ByVal wantThrowException As Boolean) As Boolean Implements ICommunicationProtocol.Connect
            Dim s As Socket = Nothing
            Dim tempSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            tempSocket.Connect(hostName, portNumber)
            If tempSocket.Connected Then s = tempSocket
            Socket = s
            Return s IsNot Nothing
        End Function

        Public Function Disconnect() As Boolean Implements ICommunicationProtocol.Disconnect
            Return TryAction(Sub() CloseAndCleanup())
        End Function

        Public Function Send(buffer As Byte(), offset As Integer, size As Integer, flags As SocketFlags, ByRef errorCode As SocketError) As Integer Implements ICommunicationProtocol.Send
            Return Socket.Send(buffer, offset, size, flags, errorCode)
        End Function

        Public Function Receive(buffer As Byte(), offset As Integer, size As Integer, flags As SocketFlags, ByRef errorCode As SocketError) As Integer Implements ICommunicationProtocol.Receive
            Dim bytes As Integer = Socket.Receive(buffer, offset, size, flags, errorCode)
            Return bytes
        End Function

        ''' <summary>
        ''' Takes care of cleaning up a TcpClient connection - a bit messy, but functional.
        ''' </summary>
        Private Sub CloseAndCleanup() Implements ICommunicationProtocol.CloseAndCleanup
            If Me.Socket IsNot Nothing Then
                TryAction(Sub()
                              Socket.Disconnect(False)
                              Socket.Shutdown(SocketShutdown.Both)
                              Socket.Close()
                              Socket = Nothing
                          End Sub)

            End If
        End Sub
#End Region

#Region "Constructors"

        Public Sub New(ByVal socket As Socket)
            Me.Socket = socket
        End Sub

        Public Sub New()

        End Sub

#End Region

    End Class

End Namespace
