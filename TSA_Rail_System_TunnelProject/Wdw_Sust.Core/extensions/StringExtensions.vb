Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Namespace Extensions
    Public Module StringExtensions
        <Extension()>
        Public Function SubStr(ByVal str As String, ByVal startChar As Char, ByVal endChar As Char) As String
            Dim startIndex As Integer = str.IndexOf(startChar) + 1
            Dim endIndex As Integer = str.IndexOf(endChar)
            If startIndex > endIndex Then
                Return String.Empty
            Else
                Return str.Substring(startIndex, endIndex - startIndex)
            End If
        End Function

        <Extension(), DebuggerNonUserCode()>
        Public Function IsValidIpV4Address(ByVal ipAddress As String) As Boolean
            Dim ip As Regex = New Regex("^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$")
            Return ip.IsMatch(ipAddress)
        End Function


        <Extension(), DebuggerNonUserCode()>
        Public Function IsNumeric(ByVal text As String) As Boolean
            Return Information.IsNumeric(text)
        End Function
    End Module
End Namespace