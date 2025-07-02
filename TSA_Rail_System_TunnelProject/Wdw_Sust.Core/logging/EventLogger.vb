Namespace Logging

    Public Class EventLogger
        Inherits GenericLogger

        Public Overrides Sub Log(logTime As Date, message As String)
            Try
                Dim log As New EventLog(My.Application.Info.ProductName, My.Computer.Name, My.Application.Info.ProductName)
                If Not EventLog.Exists(log.Source) Then EventLog.CreateEventSource(log.Source, log.Source)
                log.WriteEntry(String.Format("{0} - {1}", logTime, message))
                MyBase.Log(logTime, message)
            Catch ex As Exception
                RaiseMessageLogExceptionEvent(ex)
            End Try
        End Sub
    End Class
End Namespace
