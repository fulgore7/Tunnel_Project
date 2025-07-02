Namespace Logging
    Public Class ConsoleLogger
        Inherits GenericLogger

        Public Overrides Sub Log(Of MessageType As System.Type)(logTime As DateTime, message As String, messageTypeValue As Integer)
            Console.WriteLine(String.Format("{0} - {1}", Now.ToString, message))
            RaiseMessageLoggedEvent(logTime, message)
        End Sub

    End Class
End Namespace