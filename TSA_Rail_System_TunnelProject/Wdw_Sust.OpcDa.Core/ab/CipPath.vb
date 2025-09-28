Namespace Ab

    Public Class CipPath
        Inherits List(Of CipPathNode)

        Public Sub ConvertToCipPath(path As SByte())
            Clear()
        End Sub

        Public Sub ConvertToCipPath(path As String)

        End Sub

        Public Function ToCipPath() As SByte()
            'Dim node As CipPathNode
            For Each n As CipPathNode In Me

            Next
            Return Nothing
        End Function

    End Class

End Namespace