Imports System.IO
Imports System.Net
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.WinForms.Helpers
Imports Wdw_Sust.Rfid.Enums
Imports Wdw_Sust.Rfid.SecuraKeyDevices
Imports Wdw_Sust.Textile.Core

Public Module Helpers

    Const closeWindowAfterThisManySeconds As Integer = 7

    ''' <summary>
    ''' Extract Number from a string and return an integer
    ''' </summary>
    ''' <param name="expr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ExtractNumbers(expr As String) As Integer
        Dim result As String = String.Join(Nothing, System.Text.RegularExpressions.Regex.Split(expr, "[^\d]"))
        If IsNumeric(result) Then
            Return CInt(result)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' This is to get data from the database for the CM who is going to be logged in
    ''' </summary>
    ''' <returns>Information related to the CM</returns>
    ''' <remarks></remarks>
    Function GetRfidCardData(comPortSettings As ComPortSetting) As RfidCard
        If IsShiftPressed() Then
            Return ReadFromUserInput()
        Else
            Try
                Dim card = ReadFromRfid(comPortSettings)
                Return IIf(card?.RFBadgeUserID = 0, Nothing, card)
            Catch ex As Exception
                Return ReadFromUserInput()
            End Try
        End If
        Throw New InvalidOperationException("Unknown Error to Login System!!!")
    End Function

    Sub OpenLintReportViewer(Optional plant As Plant = Plant.ALL_PLANTS, Optional hideTreeView As Boolean = False)
        Try
            Dim downloadLocation As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "ReportViewerDownload")
            Dim downloadedFilename As String = String.Format("{0}\{1}", downloadLocation, "rv.exe")
            Dim userAppData As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LINT_Report_Viewer")
            Dim lintRvAppDataPath As String = String.Format("{0}\{1}", userAppData, "LINT_Desktop_Report_Viewer.exe")
            Dim downloadUri As New Uri("https://textiles.wdw.disney.com/releases/LINT_Desktop_Report_Viewer/Releases/Setup.exe")

            System.IO.Directory.CreateDirectory(downloadLocation)

            Using wc As New WebClient
                wc.DownloadFile(downloadUri, downloadedFilename)
            End Using

            If IsShiftPressed() OrElse Not Directory.Exists(userAppData) Then
                Process.Start(downloadedFilename, String.Format("{0} {1}", plant.ToString, hideTreeView.ToString))
            Else
                Process.Start(lintRvAppDataPath, String.Format("{0} {1}", plant.ToString, hideTreeView.ToString))
            End If
        Catch fex As FileNotFoundException
            MsgBox(String.Format("{0} was not found, please email this error to wdw.textile.sustaining.team@disney.com", fex.FileName))
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Function ReadFromRfid(comPortSettings As ComPortSetting) As RfidCard
        Dim card As RfidCard

        ' This device reads the card reader from USB device, NOT the ComPort.  Communicating
        ' through the ComPort was problematic.
        Using frm As New CtrlLintRfidReader(RfidReaderMode.READ, New DeviceEt4Aum(closeWindowAfterThisManySeconds))
            frm.ShowDialog()
            card = frm.RfidCard
        End Using
        Return card
    End Function

    Function WriteRfid(cardToBeProgrammed As Integer, comPortSettings As ComPortSetting) As RfidCard
        Dim card As RfidCard = Nothing
        TryAction(Sub()
                      'TODO: need to fix for the write card
                      Using frm As New CtrlLintRfidReader(RfidReaderMode.WRITE, New DeviceEt4Aum(closeWindowAfterThisManySeconds), cardToBeProgrammed)
                          frm.ShowDialog()
                          card = frm.RfidCard
                      End Using
                  End Sub)
        Return card
    End Function

    Private Function ReadFromUserInput() As RfidCard
        Dim card As RfidCard
        '' added a longer timeout when the user is attempting to enter in their id number into the login screen.
        Using frm As New CtrlLintLogInWindow(3000000)
            frm.ShowDialog()
            card = frm.RfidCard
        End Using
        Return card
    End Function

End Module