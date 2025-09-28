Namespace Ab

    Public Class BackplaneCipPathNode
        Inherits CipPathNode

        Public Overrides ReadOnly Property Media As SByte
            Get
                Return 1
            End Get
        End Property

        Public Overrides Function BuildPath() As String
            Return String.Format("{0}{1}", Chr(Media), Node)
        End Function

    End Class

End Namespace