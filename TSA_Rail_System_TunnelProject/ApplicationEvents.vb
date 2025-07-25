﻿Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public Event UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Using frm As New frmMain
                'frm.LogApplicationEvent(New LINTApplicationEventLog(frm.ApplicationID, Now, String.Format("Unhandled Exception - {0}", e.Exception.ToString), My.Computer.Name))
            End Using
        End Sub
    End Class


End Namespace

