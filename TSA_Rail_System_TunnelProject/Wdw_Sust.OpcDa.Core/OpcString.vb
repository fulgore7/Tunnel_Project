Imports System.Text
Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.Core.Enums

Public Class OpcString
    Inherits OpcObjectBase

    Private _data(20) As SByte

    Public Property LEN As Integer

    <NotConnectableOpcItem()>
    Public ReadOnly Property Length As Integer
        Get
            Return CInt(Data(2))
        End Get
    End Property

    <IsOpcArray(20, ArrayStartWithIndex.ZERO)>
    Public Property Data(index As Integer) As SByte
        Get
            Return _data(index)
        End Get
        Set(value As SByte)
            _data(index) = value
        End Set
    End Property

    ''' <summary>
    ''' This is used to change the ip address
    ''' </summary>
    ''' <param name="ipAddress">IP address</param>
    ''' <remarks>
    ''' this is the padding needs happen per AB KB - 50237 - Manipulating the message path string in
    ''' MSG control structure for Ethernet messages
    ''' </remarks>
    Public Sub ChangeIPAddress(ipAddress As String, isAsyncWrite As Boolean)
        Dim ipIndex As Integer = 0
        Dim ipAddressIndex As Integer = GetIpAddressIndex()
        Dim currentMessageIndex As Integer = ipAddressIndex
        ValueFromObjectToPlc(String.Format("Data[{0}]", ipAddressIndex - 1), ipAddress.Length, isAsyncWrite) 'length
        For index As Integer = ipAddressIndex To ipAddress.Length + ipAddressIndex - 1
            ValueFromObjectToPlc(String.Format("Data[{0}]", index), Asc(ipAddress(ipIndex)), isAsyncWrite)
            ipIndex += 1
            currentMessageIndex += 1
        Next
        If ipAddress.Length Mod 2 = 1 Then
            ValueFromObjectToPlc(String.Format("Data[{0}]", GetIpAddressIndex() + ipAddress.Length), 0, isAsyncWrite)
            currentMessageIndex += 1
        End If
        For index As Integer = currentMessageIndex To 19
            ValueFromObjectToPlc(String.Format("Data[{0}]", index), 0, isAsyncWrite)
        Next
        ValueFromObjectToPlc("LEN", currentMessageIndex, isAsyncWrite)
    End Sub

    Public Function GetIpAddress() As String
        Dim ipIndex As Integer = GetIpAddressIndex()
        Dim ipLength As Integer = _data(ipIndex - 1)
        Dim s As New StringBuilder
        For i As Integer = ipIndex To ipLength + ipIndex - 1
            s.Append(Chr(_data(i)))
        Next
        Return s.ToString
    End Function

    Public Overrides Function ToString() As String
        Dim str As New StringBuilder
        Dim returnValue As String
        With str
            For index As Integer = 0 To Length - 1
                str.Append(Chr(Data(index)))
            Next
        End With
        returnValue = str.ToString
        Return returnValue
    End Function

    Protected Overrides Sub ValueFromPlcToObject(index As Integer, value As Object)
        Select Case index
            Case 1
                _data(0) = CSByte(value)
            Case 2
                _data(1) = CSByte(value)
            Case 3
                _data(10) = CSByte(value)
            Case 4
                _data(11) = CSByte(value)
            Case 5
                _data(12) = CSByte(value)
            Case 6
                _data(13) = CSByte(value)
            Case 7
                _data(14) = CSByte(value)
            Case 8
                _data(15) = CSByte(value)
            Case 9
                _data(16) = CSByte(value)
            Case 10
                _data(17) = CSByte(value)
            Case 11
                _data(18) = CSByte(value)
            Case 12
                _data(19) = CSByte(value)
            Case 13
                _data(2) = CSByte(value)
            Case 14
                _data(3) = CSByte(value)
            Case 15
                _data(4) = CSByte(value)
            Case 16
                _data(5) = CSByte(value)
            Case 17
                _data(6) = CSByte(value)
            Case 18
                _data(7) = CSByte(value)
            Case 19
                _data(8) = CSByte(value)
            Case 20
                _data(9) = CSByte(value)
        End Select
    End Sub

    Private Function GetIpAddressIndex() As Integer
        Dim index As Integer
        For i As Integer = 0 To _data.Length
            If _data(index) = 18 Then
                Return i + 2
            End If
            index += 1
        Next
        Return 0
    End Function

#Region "Constructors"

    Public Sub New(plcName As String, tagName As String)
        MyBase.New(plcName, tagName)
    End Sub

    Public Sub New(plcName As String, tagName As String, groupName As String)
        MyBase.New(plcName, tagName, groupName)
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class