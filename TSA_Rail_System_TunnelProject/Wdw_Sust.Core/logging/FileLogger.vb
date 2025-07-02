Namespace Logging
    Public Class FileLogger
        Inherits GenericLogger
        Private _fileName As String
        Public Overrides Sub Log(Of MessageType As System.Type)(logTime As Date, message As String, messageTypeValue As Integer)
            WriteLog(String.Format("{0} - {1}", logTime, message), My.Application.Info.ProductName, enabledDetailedInformation:=False, customFileName:=_fileName)
            MyBase.Log(Of MessageType)(logTime, message, messageTypeValue)
        End Sub
        'TODO: fix this
        'Public Overrides Sub Log(logTime As Date, message As String)
        '    WriteLog(logMessage:=String.Format("{0} - {1}", Now.ToString, message), config:=FileLoggerConfigDetail.DefaultLoggingConfigDetail(_fileName))
        '    MyBase.Log(logTime, message)
        'End Sub

        Public Sub New()

        End Sub

        Public Sub New(ByVal fileName As String)
            _fileName = fileName
        End Sub
    End Class
End Namespace



