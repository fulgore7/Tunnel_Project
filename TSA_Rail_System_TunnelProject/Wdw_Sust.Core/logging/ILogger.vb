Imports System.Reflection
Imports System.IO

Imports Wdw_Sust.Core.Logging.EventArgs

Namespace Logging

    Public Class MessageLogException
        Inherits System.EventArgs
        Public Property Exception As Exception
    End Class

    Public Interface ILogger
        Sub Log(ByVal logTime As DateTime, ByVal message As String)
        Sub Log(Of MessageType As Type)(ByVal logTime As DateTime, ByVal message As String, ByVal messageTypeValue As Integer)
        Event MessageLogged(ByVal sender As Object, ByVal e As MessageLoggedEventArgs)
    End Interface

    Public Class FileLoggerConfigDetail
        Public Property ApplicationName As String
        Public Property FileLocation As String
        Public Property ShouldAutoFlush As Boolean
        Public Property ShouldAppend As Boolean
        Public Property EnableDetailedInformation As Boolean
        Public Property MaxFileSize As Integer
        Public Property ColumnDelimiter As Char
        Public Property LogFileCreationSchedule As Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption
        Public Property TraceEventType As System.Diagnostics.TraceEventType
        Public Property FileName As String

        Public Shared Function DefaultLoggingConfigDetail(ByVal fileName As String) As FileLoggerConfigDetail
            Dim detail As New FileLoggerConfigDetail
            With detail
                .FileLocation = String.Format("{0}\Logs\{1}", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Format(Now, "yyy_MM"))
                .ShouldAutoFlush = True
                .ShouldAppend = True
                .EnableDetailedInformation = True
                .MaxFileSize = 10000000
                .ColumnDelimiter = ","
                .LogFileCreationSchedule = Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption.Daily
                .ApplicationName = My.Application.Info.ProductName
                .TraceEventType = Diagnostics.TraceEventType.Information
                .FileName = fileName
            End With
            Return detail
        End Function

        Public Shared Function DefaultLoggingConfigDetail() As FileLoggerConfigDetail
            Return DefaultLoggingConfigDetail(Nothing)
        End Function
    End Class





End Namespace

