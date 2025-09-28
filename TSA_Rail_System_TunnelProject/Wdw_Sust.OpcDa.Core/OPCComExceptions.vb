Imports System.Runtime.InteropServices

Public Class OpcComExceptions
    Inherits COMException

    Public Sub New(message As String, errCode As Integer)
        MyBase.New(message, errCode)
    End Sub

    ''' <summary>
    ''' Translation of the PLC error code to readable messages
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ExceptionCode As Integer
        WrongTag = -1073479673                  '0xC0040007
        ClassNotRegistered = -2147221164        '0x80040154
        DuplicatedNameNotAllowed = -1073479668  '0xC004000C
        UnexpectedError = -2147467259           '0x80004005
        NoConnection = -2147220992              '0x80040200
        FileCannotBeFound = -2147024894         '0x80070002
        '-2147467259
    End Enum

    Public Shared Function GetOPCErrorMessage(errCode As Integer) As String
        Dim code As ExceptionCode = errCode
        Dim msg As String = String.Empty
        Select Case code
            Case ExceptionCode.WrongTag
                msg = "Tag is not defined in the PLC!!"
            Case ExceptionCode.ClassNotRegistered
                msg = "Class Not Registered. Maybe the OPC core components are not installed."
            Case ExceptionCode.DuplicatedNameNotAllowed
                msg = "Duplicate name in the same group is not allowed."
            Case ExceptionCode.UnexpectedError
                msg = "Error can not be determined."
            Case ExceptionCode.NoConnection
                msg = "Advise cannot find Connection point or Unable to impersonate DCOM client"
            Case ExceptionCode.FileCannotBeFound
                msg = "The system cannot find the file specified."
        End Select
        Return msg
    End Function

End Class