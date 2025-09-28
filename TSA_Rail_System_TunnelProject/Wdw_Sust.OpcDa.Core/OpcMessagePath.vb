Imports Wdw_Sust.OpcDa.Core.Ab

Public Class OpcMessagePath
    Inherits OpcElement(Of String)
    Private _path As New List(Of CipPath)

    Protected Overrides Sub ValueFromPlcToObject(index As Integer, value As Object)
        MyBase.ValueFromPlcToObject(index, value)
        BuildPath()
    End Sub

    Private Sub BuildPath()

        'Dim enumerator As IEnumerator = Value.GetEnumerator
        'While enumerator.MoveNext
        '    Select Case enumerator.Current
        '        Case 18

        '    End Select
        'End While
    End Sub

#Region "Constructors"

    Public Sub New(plcName As String, tagName As String, groupName As String)
        MyBase.New(plcName, tagName, groupName)
    End Sub

    ''' <summary>
    ''' Create new object for the class. if groupName is not defined, it will be the same as the TagName)
    ''' </summary>
    ''' <param name="plcName">Name of the PLC topic name</param>
    ''' <param name="tagName">Name of the tag name</param>
    ''' <remarks></remarks>
    Public Sub New(plcName As String, tagName As String)
        MyBase.New(plcName, tagName)
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class