Namespace Ab

    Public MustInherit Class CipPathNode
        Public MustOverride ReadOnly Property Media As SByte
        Public Property Node As String

        Public MustOverride Function BuildPath() As String

    End Class

End Namespace