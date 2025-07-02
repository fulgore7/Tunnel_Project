Namespace Job.EventArgs

    Public Class JobEventArgs
        Inherits System.EventArgs

        Public Property JobName As String
        Public Property Cancel As Boolean

        Public Sub New(ByVal jobName As String)
            JobName = jobName
        End Sub

    End Class
End Namespace

