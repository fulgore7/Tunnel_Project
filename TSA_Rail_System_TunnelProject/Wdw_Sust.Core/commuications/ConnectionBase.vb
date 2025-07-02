Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization

Namespace Communications
    Public MustInherit Class ConnectionBase

        Public Enum ConnectExceptionReason As Integer
            Unknown
            RemoteHostLost
            RemoteClientLost
            RemoteHostNotReachable
        End Enum

        Public Class ConnectionExceptionEventArgs
            Inherits System.EventArgs
            Public Property ExceptionReason As ConnectExceptionReason
            Public Sub New()

            End Sub
            Public Sub New(ByVal reason As ConnectExceptionReason)
                Me.ExceptionReason = reason
            End Sub
        End Class

        Public TCPSocketProtocol As ICommunicationProtocol

        Public Event MessageReceived(ByVal message As INetworkMessage)
        Public Event ConnectStatusChanged As EventHandler
        Public Event ConnectException As EventHandler
        Private _isConnected As Boolean
        Private ReadOnly _reset As Boolean

        Public Sub SendMessage(ByVal message As INetworkMessage)
            'If IsConnected Then
            '    Dim bytes As Byte() = WDW_SUST.Util.Serialization.SerializationManager.SerializeData(message)
            '    Send(bytes)
            'End If
            If IsConnected Then
                Dim bytes As Byte() = message.ConstructMessageAsBytes
                Send(bytes)
            End If
        End Sub

        Public Function SendSyncMessage(Of T)(ByVal message As INetworkMessage) As T
            'If IsConnected Then
            '    Dim bytes As Byte() = WDW_SUST.Util.Serialization.SerializationManager.SerializeData(message)
            '    Dim numberOfBytesReceived As Integer
            '    Dim bytesReceived(1024) As Byte
            '    Send(bytes)
            '    numberOfBytesReceived = Receive(bytesReceived, 1024)
            '    Return ReadData(bytesReceived)
            'End If
            If IsConnected Then
                Dim bytes As Byte() = message.ConstructMessageAsBytes
                Dim numberOfBytesReceived As Integer
                Dim bytesReceived(1024) As Byte
                Send(bytes)
                numberOfBytesReceived = Receive(bytesReceived, 1024)
                Return ReadData(bytesReceived)
            End If
        End Function

        Protected Sub CheckConnectStatus()
            While IsConnected
                If TCPSocketProtocol.Socket.Poll(5, SelectMode.SelectRead) Then
                    IsConnected = False
                    RaiseEvent ConnectException(Me, New ConnectionExceptionEventArgs(ConnectExceptionReason.RemoteHostLost))
                Else
                    Thread.Sleep(5000)
                End If
            End While
        End Sub

        'Protected Sub CheckConnectStatus()
        '    If TCPSocketProtocol.Socket.Poll(5, SelectMode.SelectRead) Then
        '        IsConnected = False
        '        RaiseEvent ConnectException(Me, New ConnectionExceptionEventArgs(ConnectExceptionReason.RemoteHostLost))
        '    End If
        'End Sub

        Public Function GetNewMessage() As INetworkMessage
            'Dim availableBytes As Integer = TCPSocketProtocol.Available
            'If availableBytes > 0 Then
            '    Dim byteArrayIn(availableBytes - 1) As Byte
            '    Dim msg As INetworkMessage
            '    TCPSocketProtocol.Receive(byteArrayIn, 0, availableBytes, SocketFlags.None, 0)
            '    msg = ReadData(byteArrayIn)
            '    Return msg
            'Else
            '    Return Nothing
            'End If



            Dim availableBytes As Integer = TCPSocketProtocol.Available
            Dim maxIncomingBytesToReadAtOnce As Integer = 8000

            Dim x As New MemoryStream
            Dim msg As Object = Nothing
            Dim remainingBytesToRead = availableBytes
            Dim maxBytesToRead As Integer = 1000
            Dim byteReadSoFar As Integer
            Dim byteReadThisRound As Integer
            Dim errorOut As SocketError


            If availableBytes > 0 Then


                Dim byteHeader(181) As Byte
                TCPSocketProtocol.Receive(byteHeader, 0, 182, SocketFlags.None, errorOut)
                Dim tempHeader As MessageHeader = Serialization.SerializationManager.DeserializeData(byteHeader)
                remainingBytesToRead = tempHeader.MessageSize

                While remainingBytesToRead > 0
                    maxBytesToRead = IIf(remainingBytesToRead > maxIncomingBytesToReadAtOnce, maxBytesToRead, remainingBytesToRead)
                    Dim byteArrayIn(maxBytesToRead - 1) As Byte

                    While remainingBytesToRead > 0

                        byteReadThisRound = TCPSocketProtocol.Receive(byteArrayIn, 0, maxBytesToRead, SocketFlags.None, errorOut)
                        byteReadSoFar += byteReadThisRound
                        remainingBytesToRead -= byteReadThisRound
                        If Not errorOut = SocketError.Success Then
                            Exit While
                        End If
                        x.Write(byteArrayIn, 0, byteReadThisRound)
                    End While

                    ' Thread.Sleep(15)
                    availableBytes = TCPSocketProtocol.Available
                End While
                msg = ReadData(x.ToArray)
                Return New NetworkMessage With {.MessageHeader = tempHeader, .MessageContent = msg}
            Else

                Return Nothing
            End If




        End Function

        Protected Overridable Sub OnMessageReceived(ByVal message As INetworkMessage)
            RaiseEvent MessageReceived(message)
        End Sub

        Protected Sub OnConnectException(e As System.EventArgs)
            RaiseEvent ConnectException(Me, e)
            IsConnected = False
        End Sub

        'Private Shared Function ReadData(ByVal bytesToRead As Byte()) As INetworkMessage
        '    Dim msg As INetworkMessage = CType(WDW_SUST.Util.Serialization.SerializationManager.DeserializeData(bytesToRead), INetworkMessage)
        '    Return msg
        'End Function

        Private Shared Function ReadData(ByVal bytesToRead As Byte()) As Object
            Dim msg As Object = Nothing
            If bytesToRead.Length > 0 Then
                msg = SerializationManager.DeserializeData(bytesToRead)
            End If
            Return msg
        End Function


        Public Sub Disconnect()
            TCPSocketProtocol.Disconnect()
            IsConnected = False
        End Sub

        Private Sub Send(ByVal bytesToSend As Byte())
            Dim errCode As Integer
            TCPSocketProtocol.Send(bytesToSend, 0, bytesToSend.Length, SocketFlags.None, errCode)
        End Sub

        Private Function Receive(ByVal bytesToReceive As Byte(), ByVal length As Integer) As Integer
            Dim errCode As Integer
            Return TCPSocketProtocol.Receive(bytesToReceive, 0, length, SocketFlags.None, errCode)
        End Function

        Public Overridable Property IsConnected() As Boolean
            Get
                Return _isConnected
            End Get
            Protected Set(ByVal value As Boolean)
                If _isConnected <> value Then
                    _isConnected = value
                    RaiseEvent ConnectStatusChanged(Me, System.EventArgs.Empty)
                End If
            End Set
        End Property

        Public Sub New()

        End Sub
    End Class
End Namespace

