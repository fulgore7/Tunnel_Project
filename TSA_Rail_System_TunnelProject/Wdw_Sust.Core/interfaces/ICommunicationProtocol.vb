Imports System.Net.Sockets

Namespace Interfaces
    Public Interface ICommunicationProtocol
        Function Disconnect() As Boolean
        Property Socket() As Socket
        Function Connect(ByVal hostName As String, ByVal portNumber As Integer, ByVal wantThrowException As Boolean) As Boolean
        Function Send(ByVal buffer As Byte(), ByVal offset As Integer, ByVal size As Integer, ByVal flags As SocketFlags, ByRef errorCode As SocketError) As Integer
        Function Receive(ByVal buffer As Byte(), ByVal offset As Integer, ByVal size As Integer, ByVal flags As SocketFlags, ByRef errorCode As SocketError) As Integer
        ReadOnly Property Available() As Integer
        ''' <summary>
        ''' Takes care of cleaning up a TcpClient connection - a bit messy, but functional.
        ''' </summary>
        Sub CloseAndCleanup()
    End Interface

End Namespace
