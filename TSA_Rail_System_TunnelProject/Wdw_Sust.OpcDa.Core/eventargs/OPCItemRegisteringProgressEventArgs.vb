Namespace EventArgs

    Public Class OpcItemRegisteringProgressEventArgs
        Inherits System.EventArgs
        Private _progress As Integer = 0

        Public Sub New(progress As Integer)
            _progress = progress
        End Sub

        Public ReadOnly Property Progress() As Integer
            Get
                Return _progress
            End Get
        End Property

    End Class

End Namespace