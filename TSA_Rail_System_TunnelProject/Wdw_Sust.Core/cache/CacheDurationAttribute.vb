
Namespace Cache
    Public NotInheritable Class CacheDurationAttribute
        Inherits Attribute
        Public Property CacheDurationInSeconds As Integer
        Public Sub New(ByVal cacheDurationInSeconds As Integer)
            Me.CacheDurationInSeconds = cacheDurationInSeconds
        End Sub
    End Class
End Namespace