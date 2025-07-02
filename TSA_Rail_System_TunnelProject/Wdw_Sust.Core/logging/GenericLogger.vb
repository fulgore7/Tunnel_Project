Imports Wdw_Sust.Core.Logging.EventArgs

Namespace Logging

    Public Class GenericLogger
        Implements ILogger

        Public Overridable Sub Log(Of MessageType As System.Type)(logTime As DateTime, message As String, messageTypeValue As Integer) Implements ILogger.Log
            RaiseMessageLoggedEvent(logTime, message)
        End Sub



        Public Event MessageLogException(sender As Object, e As MessageLogException)
        Public Event MessageLogged(sender As Object, e As MessageLoggedEventArgs) Implements ILogger.MessageLogged

        Protected Sub RaiseMessageLoggedEvent(ByVal logTime As DateTime, ByVal message As String)
            RaiseEvent MessageLogged(Me, New MessageLoggedEventArgs With {.Message = message, .LogTime = logTime})
        End Sub

        Protected Sub RaiseMessageLogExceptionEvent(e As Exception)
            RaiseEvent MessageLogException(Me, New MessageLogException With {.Exception = e})
        End Sub

        Public Overridable Sub Log(logTime As Date, message As String) Implements ILogger.Log
            RaiseMessageLoggedEvent(logTime, message)
        End Sub
    End Class

End Namespace