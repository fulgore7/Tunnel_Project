
Imports System.Drawing

Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.WinForms.Core

Public Class CtrlLintAlarmViewer
    Inherits CtrlFormBase
    Implements IInformationSubscriber(Of LintAlarmEventArgs)

#Region "Fields"
    Private _listOfZoneSubscribed As New List(Of LintZone)
    'Private WithEvents _alarmBroadcaster As LintAlarmBroadcaster
#End Region

#Region "Properties"
    Public ReadOnly Property ListOfZoneSubscribed() As List(Of LintZone)
        Get
            Return _listOfZoneSubscribed
        End Get
    End Property

    Public Property DataGridViewFont() As Font
        Get
            Return DataGridView1.Font
        End Get
        Set(ByVal value As Font)
            DataGridView1.Font = value
        End Set
    End Property

#End Region

#Region "Methods"
    Protected Overrides Sub ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode Then
            InvokeIfNeeded(AddressOf Close)
        End If
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        If DataGridView1.Columns(e.ColumnIndex).Name = "Alarm_Severity" Then
            If e.Value IsNot Nothing Then
                Select Case e.Value.ToString
                    Case "1" : e.CellStyle.BackColor = Color.Red
                    Case "2" : e.CellStyle.BackColor = Color.OrangeRed
                    Case "3" : e.CellStyle.BackColor = Color.Orange
                    Case "4" : e.CellStyle.BackColor = Color.Yellow
                    Case "5" : e.CellStyle.BackColor = Color.White
                End Select
            End If
        End If

        If DataGridView1.Columns(e.ColumnIndex).Name = "AlarmDuration" And e.Value IsNot Nothing Then
            Dim temp As String = e.Value.ToString
            If temp.Contains(" hours") Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            Else
                Dim startIndex As Integer = temp.IndexOf(" ")
                Dim endindex As Integer = temp.IndexOf("s")
                temp = temp.Remove(startIndex, endindex - startIndex + 1)
                If CDbl(temp) > 5.0 AndAlso CDbl(temp) < 10.0 Then
                    e.CellStyle.BackColor = Color.Yellow
                ElseIf CDbl(temp) > 10.0 AndAlso CDbl(temp) < 15.0 Then
                    e.CellStyle.BackColor = Color.Orange
                    e.CellStyle.ForeColor = Color.White
                ElseIf CDbl(temp) > 15.0 Then
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
        End If
    End Sub

    Private Sub AlarmStatusUpdateCompleted(ByVal e As LintAlarmEventArgs)
        If CheckBox1.Checked Then
            Dim listOfAlarms As New List(Of LintAlarm)
            If ListOfZoneSubscribed.Count > 0 Then
                For Each alarm As LintAlarm In e.ActiveAlarmList
                    For Each z As LintZone In ListOfZoneSubscribed
                        If alarm.ZoneID = z Then
                            listOfAlarms.Add(alarm)
                        End If
                    Next
                Next
            Else
                listOfAlarms.AddRange(e.ActiveAlarmList)
            End If
            InvokeIfNeeded(Sub()
                               listOfAlarms.Sort()
                               LINTAlarmBindingSource.DataSource = listOfAlarms
                               DataGridView1.Refresh()
                           End Sub)
        End If
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        If LintAlarm.Sort = SortDirection.ASC Then
            LintAlarm.Sort = SortDirection.DESC
        Else
            LintAlarm.Sort = SortDirection.ASC
        End If
        LintAlarm.SortBy = DataGridView1.Columns(e.ColumnIndex).DataPropertyName
        CType(LINTAlarmBindingSource.DataSource, List(Of LintAlarm)).Sort()
        DataGridView1.Refresh()
    End Sub

    Public Sub ProcessSubscribedInformation(args As LintAlarmEventArgs) Implements IInformationSubscriber(Of LintAlarmEventArgs).ProcessSubscribedInformation
        InvokeIfNeeded(Sub() AlarmStatusUpdateCompleted(args))
    End Sub
#End Region

End Class
