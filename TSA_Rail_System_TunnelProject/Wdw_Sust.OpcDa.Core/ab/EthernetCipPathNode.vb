Imports System.Text

Namespace Ab

    Public Class EthernetCipPathNode
        Inherits CipPathNode

        Public Overrides ReadOnly Property Media As SByte
            Get
                Return 18
            End Get
        End Property

        Public Overrides Function BuildPath() As String
            Dim s As New StringBuilder
            s.Append(Chr(Node.Length))
            s.Append(Node)
            If Node.Length Mod 2 = 1 Then s.Append(Chr(0))
            Return s.ToString
        End Function

    End Class

End Namespace