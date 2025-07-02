
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Logging

Public Class LoggingManager
    Inherits SingletonProviderBase(Of LoggingManager)

    Private _loggers As New List(Of ILogger)

    Public Sub Log(Of MessageType As Type)(logTime As DateTime, message As String, ByVal messageTypeValue As Integer)
        Dim msgType As String = System.Enum.GetName(GetType(MessageType), messageTypeValue)
        Threading.ThreadPool.QueueUserWorkItem(Sub() _loggers.ForEach(Sub(a) a.Log(Of MessageType)(logTime, message, messageTypeValue)))
    End Sub
End Class
