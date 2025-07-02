Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Core.WinForms.Helpers
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Global.WinForms.EventArgs
Namespace Wdw_Sust.Textile.[Global].Opc.WinForms
    Public Class CtrlLintAlarmIcon
        Inherits CtrlUserControlBase
        Implements IInformationSubscriber(Of LintAlarmEventArgs)

#Region "Fields"

        Private ReadOnly _activeAlarmList As New List(Of LintAlarm)
        Private _subscribedAlarms As List(Of Integer)
        Private _configureControl As Boolean
        Private ReadOnly RESET_ALARM_SR As String = "Are you sure to reset alarm {0}?"
        Private ReadOnly ALARM_FONT As Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold, GraphicsUnit.Pixel)

#End Region

#Region "Events"
        Public Event _OnShowAlarmHistoryViewerEvent As EventHandler(Of AlarmHistoryFormEventArgs)
#End Region

#Region "Properities"
        ''' <summary>
        ''' To input alarm ids stored in the database during design time.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <Category("Alarm Properties"), Description("Put the alarm ID in the list")>
        Public Property SubscribedAlarms() As List(Of Integer)
            Get
                If _subscribedAlarms Is Nothing Then _subscribedAlarms = New List(Of Integer)
                Return _subscribedAlarms
            End Get
            Set(ByVal value As List(Of Integer))
                _subscribedAlarms = value
            End Set
        End Property

        Public Property SubscriberName As String Implements IInformationSubscriber(Of LintAlarmEventArgs).SubscriberName
            Get
                Return Me.Name
            End Get
            Private Set(value As String)
                'Do nothing
            End Set
        End Property

        Protected ReadOnly Property ActiveAlarmList As IList(Of LintAlarm)
            Get
                Return _activeAlarmList.AsReadOnly
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads Property BorderStyle As BorderStyle
            Get
                Return PictureBox1.BorderStyle
            End Get
            Set(value As BorderStyle)
                PictureBox1.BorderStyle = value
            End Set
        End Property

        Public Property ParentBroadcaster As IInformationBroadcaster Implements IInformationSubscriber.ParentBroadcaster

#End Region

#Region "Methods"
        Public Sub ProcessSubscribedInformation(args As LintAlarmEventArgs) Implements IInformationSubscriber(Of LintAlarmEventArgs).ProcessSubscribedInformation
            If Not BackgroundWorker1.IsBusy Then
                TryAction(AddressOf BackgroundWorker1.RunWorkerAsync, args)
            End If
        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            Dim listOfAlarms As IList(Of LintAlarm) = CType(e.Argument, LintAlarmEventArgs).ActiveAlarmList
            _activeAlarmList.Clear()
            For Each alarm As LintAlarm In listOfAlarms
                If SubscribedAlarms.Contains(alarm.AlarmID) Then _activeAlarmList.Add(alarm.Clone)
            Next
        End Sub

        Private Sub CtrlLINTAlarmIcon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not _configureControl Then
                ConfigureControl()
                _configureControl = True
            End If
        End Sub

        Protected Overridable Sub ConfigureControl()
            If Not DesignMode Then
                Select Case CONFIGURATION.ApplicationMode
                    Case ProgramMode.MAINTENANCE
                        Exit Sub
                    Case ProgramMode.FAIL_OVER_AUTO, ProgramMode.FAIL_OVER_MANUAL
                        Visible = False
                    Case ProgramMode.PRODUCTION
                        Visible = False
                End Select
            End If
        End Sub

        Private Sub CtrlLINTAlarmIcon_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter, PictureBox1.MouseEnter, MyBase.MouseEnter
            If CONFIGURATION.ApplicationMode = ProgramMode.PRODUCTION Then
                ConvertProductionToolTipText()
            ElseIf CONFIGURATION.ApplicationMode = ProgramMode.MAINTENANCE Then
                ConvertMaintenanceToolTipText()
            End If
            If ToolTipText IsNot Nothing Then
                ShowToolTip()
            End If
        End Sub

        Private Sub ConvertMaintenanceToolTipText()
            ToolTipText = String.Empty
            For Each alarm As Integer In _subscribedAlarms
                ToolTipText += alarm.ToString + vbCrLf
            Next
        End Sub

        Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider

            Return LintFactoryProvider.Instance
        End Function

        Protected Overridable Sub ConvertProductionToolTipText()
            ToolTipText = String.Empty
            For Each alarm As LintAlarm In _activeAlarmList
                ToolTipText += String.Format("{0}:{1} -- Started:{2} ago", alarm.AlarmID, alarm.AlarmDescription, alarm.DisplayAlarmDuration) + vbCrLf
            Next
        End Sub

        Private Sub CtrlLINTAlarmIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave, PictureBox1.MouseLeave
            HideToolTip()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            If _activeAlarmList.Count > 1 Then
                Dim rect As New Drawing.Rectangle(Width - 14, 1, 12, 12)
                Using format As New StringFormat()
                    format.Alignment = StringAlignment.Center
                    format.LineAlignment = StringAlignment.Center
                    e.Graphics.DrawArc(Pens.Red, rect, 0, 360)
                    e.Graphics.DrawString(_activeAlarmList.Count.ToString, ALARM_FONT, Brushes.Red, rect, format)
                End Using
            End If
            MyBase.OnPaint(e)
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            PostSyncCallback(AddressOf AlarmsProcessed)
        End Sub

        Protected Overridable Sub AlarmsProcessed()
            Visible = (_activeAlarmList.Count > 0)
            If Visible Then Invalidate()
        End Sub

        Private Sub PictureBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick
            If e.Button = MouseButtons.Right Then
                ContextMenuStrip1.Text = "Get Historical Data On:"
                ContextMenuStrip1.Items.Clear()
                _activeAlarmList.ForEach(Sub(a) ContextMenuStrip1.Items.Add(a.AlarmID))
                ContextMenuStrip1.Show(Me, PointToClient(Control.MousePosition), ToolStripDropDownDirection.BelowRight)
            End If
        End Sub

        Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
            For Each tsi As ToolStripItem In ContextMenuStrip1.Items
                If tsi.Text = e.ClickedItem.Text Then
                    Dim alarmNumber As Integer = CInt(e.ClickedItem.Text)
                    If IsShiftPressed() Then
                        If CONFIGURATION.WorkStation = WorkStations.DEVELOPMENT_PC Then
                            Factory.Alarm.UpdateLINTAlarmStatus(alarmNumber, False, Now, 0)
                        Else
                            If MsgBox(String.Format(RESET_ALARM_SR, alarmNumber), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
                                If card Is Nothing Then Exit Sub
                                If LintSecurityProvider.GetLINTRolesToUpdateAlarmStatus.Contains(card.CastInfo.UserType) Then
                                    Factory.Alarm.UpdateLINTAlarmStatus(alarmNumber, False, Now, 0)
                                Else
                                    MsgBox("You don't have the right to change status of the alarm!")
                                End If
                            End If
                        End If
                    Else
                        RaiseEvent _OnShowAlarmHistoryViewerEvent(Me, New AlarmHistoryFormEventArgs With {.GlobalAlarmId = alarmNumber})
                    End If
                End If
            Next
        End Sub

#End Region

#Region "Constructors"
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()
            DoubleBuffered = True
            ' Add any initialization after the InitializeComponent() call.
        End Sub
#End Region

    End Class

End Namespace