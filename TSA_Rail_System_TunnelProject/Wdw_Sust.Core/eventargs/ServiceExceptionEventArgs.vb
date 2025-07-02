Namespace EventArgs
    ''' <summary>
    ''' Class ServiceExceptionEventArgs. Provide messages for the service exception when implemented.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.EventArgs.ServiceEventArgs" />
    Public Class ServiceExceptionEventArgs
        Inherits ServiceEventArgs
        Public Property Message As String
    End Class
End Namespace