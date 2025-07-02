
Namespace Configurations.EventArgs
    Public Class ConfigFileExceptionEventArgs(Of T)
        Inherits System.EventArgs
        Public Property ConfigObject As T
    End Class

End Namespace