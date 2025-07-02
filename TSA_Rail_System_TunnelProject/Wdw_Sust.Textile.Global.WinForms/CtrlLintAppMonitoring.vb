Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.WinForms.Core

Public Class CtrlLintAppMonitoring
    Inherits CtrlFormBase

#Region "Fields"

    Private _applicationId As LintApplicationId
    Private _isMonitoringEnabled As Boolean
#End Region

#Region "Events"

#End Region

#Region "Properties"
    Private Property IsMonitoringEnabled As Boolean
        Get
            Return _isMonitoringEnabled
        End Get
        Set(value As Boolean)
            _isMonitoringEnabled = value
            btnChangeStatus.Text = IIf(_isMonitoringEnabled, "Disable Monitoring", "Enable Monitoring")
            btnChangeStatus.BackColor = IIf(_isMonitoringEnabled, Drawing.Color.Lime, Drawing.Color.Cyan)
        End Set
    End Property
#End Region

#Region "Methods"

    Protected Overrides Sub Initialize()
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        Dim provider As New LintBackupProvider
        IsMonitoringEnabled = provider.GetApplicationMonitoringStatus(_applicationId, My.Computer.Name, Db_Configuration.LintProductionConnectionString)
    End Sub

    Private Sub SaveSettings()
        Dim provider As New LintBackupProvider
        If Not IsMonitoringEnabled Then
            Dim workstations As List(Of Integer) = provider.GetAllMonitoredWorkstationsByApplicationId(_applicationId, Db_Configuration.LintProductionConnectionString)
            If workstations.Count > 0 Then
                Dim result As MsgBoxResult = MsgBox("There are more than 1 computer monitoring the application already, do you want to remove them", MsgBoxStyle.YesNoCancel)
                If result = MsgBoxResult.Yes Then
                    workstations.ForEach(Sub(a) provider.UpdateApplicationMonitonringStatus(_applicationId, a, False, Db_Configuration.LintProductionConnectionString))
                End If
            End If
        End If
        provider.UpdateApplicationMonitonringStatus(_applicationId, My.Computer.Name, Not IsMonitoringEnabled, Db_Configuration.LintProductionConnectionString)
        IsMonitoringEnabled = Not IsMonitoringEnabled
        If IsMonitoringEnabled AndAlso Not provider.CheckIfApplicationLinksToAlarms(_applicationId, Db_Configuration.LintProductionConnectionString) Then
            MsgBox("Even though this application is monitored, there is no alarm attached to the application. Please make sure alarm is assigned to the app to be notified by an alarm in the table LINT_software.LINT_Application_Alarm_JT! ", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btnChangeStatus_Click(sender As Object, e As System.EventArgs) Handles btnChangeStatus.Click
        Dim args As New LintRoleAccessRightEventArgs(LintSecurityProvider.GetLINTRolesToEnabledAndDisableApplicationMonitoringStatus)
        Dim rfid As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRoleAccessRights(rfid, args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            SaveSettings()
            'LogOperatorEvent(Me, New LINTOperatorEventArgs(Now, args.EmployeeID, My.Computer.Name, action, "External log in validation has been changed!"))
        Else
            MsgBox(args.Message)
        End If
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(ByVal applicationId As LintApplicationId)
        InitializeComponent()
        _applicationId = applicationId
        lblApplication.Text = String.Format("Application Name: {0} ({1}) ", _applicationId.ToString, CInt(_applicationId))
        lblComputerName.Text = String.Format("Computer Name: {0} ", My.Computer.Name)
    End Sub
#End Region

End Class

