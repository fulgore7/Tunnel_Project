Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Core
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Core.Validation
Imports Wdw_Sust.Core.Validation.EventArgs
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Global.WinForms.Interfaces

Imports System.Windows.Forms
Imports System.Configuration

Public Class CtrlLintAdminConsole
    Inherits CtrlFormBase
    Implements IConfigurator

#Region "Fields"
    Private _useLocalCheck As Boolean
    Private WithEvents _configManager As LintApplicationConfigurationManager
    Private _isConfigChanged As Boolean
#End Region

#Region "Events"
    Public Event _OnSavingData As EventHandler(Of IRoleAccessRightEventArgs)
#End Region

#Region "Methods"

    Private Sub AddBusinessRules()
        BusinessRuleManager.AddRule(GetType(LintApplicationConfigFile),
                                    "App Id is not defined",
                                    "app-id-not-defined",
                                    Function(a As LintApplicationConfigFile) a.ApplicationId <> LintApplicationId.UNKNOWN)
        BusinessRuleManager.AddRule(GetType(LintApplicationConfigFile),
                                    "Plant is not defined",
                                    "plant-not-defined",
                                    Function(a As LintApplicationConfigFile) a.Plant <> Plant.UNKNOWN)
        BusinessRuleManager.AddRule(GetType(LintApplicationConfigFile),
                                    "Workstation is not defined",
                                    "workstation-not-defined",
                                    Function(a As LintApplicationConfigFile) a.WorkStation <> WorkStations.UNKNOWN)
        AddHandler BusinessRuleManager.ObjectIsInvalidEvent, AddressOf ObjectIsInvalidEvent
    End Sub

    Private Sub ObjectIsInvalidEvent(sender As Object, e As ObjectInvalidEventArgs)
        MsgBox(e.ErrorSummary)
    End Sub

    Private Sub btnPlcTopics_Click(sender As Object, e As System.EventArgs) Handles btnPlcTopics.Click
        Using frm As New CtrlLintOpcTopicNames
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnDatabase_Click(sender As Object, e As System.EventArgs) Handles btnDatabase.Click
        Dim saveHandler As EventHandler(Of IRoleAccessRightEventArgs) = Sub(a, b) OnSavingData(b)
        Using frm As New CtrlLintConnectionStringBuilder(true)
            AddHandler frm._OnSavingData, saveHandler
            frm.ShowDialog()
            RemoveHandler frm._OnSavingData, saveHandler
        End Using
    End Sub

    Private Sub LocalValidation()
        If Not CONFIGURATION.IsValid Then Exit Sub
        If LocalCheckSuccessful() Then
            SaveSettings()
        Else
            MsgBox("You don't have right or the password is incorrect to save changes!!")
        End If
    End Sub

    Private Sub DatabaseValidation()
        Dim errorMessage As String = String.Empty
        If Not CONFIGURATION.IsValid Then Exit Sub
        If DatabaseCheckSuccessful() Then
            If ValidateSettings(errorMessage) Then
                SaveSettings()
                Close()
            Else
                MsgBox(errorMessage)
            End If
        Else
            msgbox("Per database configuration, you don't have right to save changes!!")
        End If
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If _useLocalCheck Then
            LocalValidation()
        Else
            DatabaseValidation()
        End If
    End Sub

    Private Function LocalCheckSuccessful() As Boolean
        If Not _configManager.ConfigFile.IsValid Then Return False
        Dim password As String = InputBox("Please input the password")
        If Not IsNumeric(password) Then Return False
        Return CInt(password) = 8665
    End Function

    Private Function DatabaseCheckSuccessful() As Boolean
        Dim args As New LintRoleAccessRightEventArgs(LintUserType.SYSTEM_ADMINISTRATOR, hasRight:=Not LintSecurityProvider.ENABLE_SECURITY)
        OnSavingData(args)
        Return args.HasRight
    End Function

    Private Sub OnSavingData(ByVal e As LintRoleAccessRightEventArgs)
        If LintSecurityProvider.ENABLE_SECURITY Then
            If _configManager.ConfigFile.IsValid Then
                RaiseEvent _OnSavingData(Me, e)
            End If
        End If
    End Sub

    Private Function ValidateSettings(ByVal messageOfError As String) As Boolean
        If chkUseRemoteLINX.Checked Then
            If String.IsNullOrEmpty(txtRemoteGatewayNameOrIP.Text) Then
                messageOfError = "Remote gateway name is not in the correct format"
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Protected Overrides Sub OnInitialize(config As LintFormConfiguration)
        config.SelfSubscribe = False
        MyBase.OnInitialize(config)
    End Sub

    Protected Overrides Sub Initialize()
        AddBusinessRules()
        InvokeIfNeeded(AddressOf LoadSettings)
    End Sub

    Private Sub LoadSettings()
        _configManager.BeginEdit()
        _configManager.ConfigFile.IsPropertyChangedEventBuffered = True
        'Load data sources
        LintAppConfigFileBindingSource.DataSource = _configManager.ConfigFile
        ComPortSettingBindingSource.DataSource = _configManager.ConfigFile.SecuraKeyComportSettings
        'Load COM port names
        cmbComPortNames.LoadStringDataSource(My.Computer.Ports.SerialPortNames.Cast(Of String), CType(ComPortSettingBindingSource.DataSource, ComPortSetting).ComPortName)
        'Load COM port baud rates
        cmbBaudRate.LoadEnumDataSource(Nothing, CType(ComPortSettingBindingSource.DataSource, ComPortSetting).BaudRate)
        'Load plant names
        cmbPlant.LoadEnumDataSource(New Plant() {Plant.ALL_PLANTS, Plant.MULTIPLE_PLANTS, Plant.UNKNOWN}, CType(LintAppConfigFileBindingSource.DataSource, LintApplicationConfigFile).Plant)
        'Load workstation names
        cmbWorkStationNames.LoadEnumDataSource(Nothing, CType(LintAppConfigFileBindingSource.DataSource, LintApplicationConfigFile).WorkStation)
        'Load bag drawing mode
        cmbBagDrawingMode.LoadEnumDataSource(Nothing, CType(LintAppConfigFileBindingSource.DataSource, LintApplicationConfigFile).BagDrawingMode)
        'Load application name
        cmbAppName.LoadEnumDataSource(Nothing, CType(LintAppConfigFileBindingSource.DataSource, LintApplicationConfigFile).ApplicationId)
        'Load application mode
        Select Case _configManager.ConfigFile.ApplicationMode
            Case ProgramMode.PRODUCTION
                Db_Configuration.ChangeInUseLintConnection(ConnectionStringName.LintProductionConnection)
                radProduction.Checked = True
            Case ProgramMode.MAINTENANCE
                radMaintenance.Checked = True
            Case ProgramMode.FAIL_OVER_MANUAL
                radFailOver.Checked = True
            Case ProgramMode.TEST
                Db_Configuration.ChangeInUseLintConnection(ConnectionStringName.LintDevelopmentConnection)
                radTest.Checked = True
        End Select

        cbxSendHeartbeat.Checked = CType(LintAppConfigFileBindingSource.DataSource, LintApplicationConfigFile).SendHeartbeat

        tbxUpdatePath.Text = System.Configuration.ConfigurationManager.AppSettings("UpdatePath")
        cbxStartWithWindows.Checked = System.Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings("StartWithWindows"))
    End Sub

    Private Sub SaveSettings()
        If radProduction.Checked Then
            _configManager.ConfigFile.ApplicationMode = ProgramMode.PRODUCTION
            Db_Configuration.ChangeInUseLintConnection(ConnectionStringName.LintProductionConnection)
        ElseIf radMaintenance.Checked Then
            _configManager.ConfigFile.ApplicationMode = ProgramMode.MAINTENANCE
        ElseIf radFailOver.Checked Then
            _configManager.ConfigFile.ApplicationMode = ProgramMode.FAIL_OVER_MANUAL
        ElseIf radTest.Checked Then
            _configManager.ConfigFile.ApplicationMode = ProgramMode.TEST
            Db_Configuration.ChangeInUseLintConnection(ConnectionStringName.LintDevelopmentConnection)
        End If

        CType(LintAppConfigFileBindingSource.DataSource, LintApplicationConfigFile).SendHeartbeat = cbxSendHeartbeat.Checked

        SaveAppSetting("StartWithWindows", cbxStartWithWindows.Checked.ToString())
        SaveAppSetting("UpdatePath", tbxUpdatePath.Text)

        _configManager.ConfigFile.RemoteLinxAddress = txtRemoteGatewayNameOrIP.Text
        _configManager.Save()
        _isConfigChanged = True
    End Sub

    Private Sub btnCheckMonitor_Click(sender As Object, e As System.EventArgs) Handles btnCheckMonitor.Click
        Using frm As New CtrlLintAppMonitoring(_configManager.ConfigFile.ApplicationId)
            frm.ShowDialog()
        End Using
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If Not _isConfigChanged Then
            _configManager.ConfigFile.ClearPropertyChangedBuffer()
            _configManager.CancelEdit()
        End If
        _configManager.ConfigFile.IsPropertyChangedEventBuffered = False
        BusinessRuleManager.RemoveRulesByType(GetType(LintApplicationConfigFile))
    End Sub

    Private Sub btnDisplayOptions_Click(sender As Object, e As System.EventArgs) Handles btnDisplayOptions.Click
        Using frm As New frmDisplayConfig
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub chkUseRemoteLINX_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkUseRemoteLINX.CheckedChanged
        Dim checkbox As CheckBox = CType(sender, CheckBox)

        If checkbox.Checked Then
            txtRemoteGatewayNameOrIP.Enabled = True
        Else
            txtRemoteGatewayNameOrIP.Enabled = False
        End If
    End Sub

    Private Sub CtrlLintAdminConsole_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(_configManager.ConfigFile.RemoteLinxAddress) Then
            txtRemoteGatewayNameOrIP.Text = _configManager.ConfigFile.RemoteLinxAddress
        End If

        If _configManager.ConfigFile.IsRemoteLinxUsed Then
            txtRemoteGatewayNameOrIP.Enabled = True
        Else
            txtRemoteGatewayNameOrIP.Enabled = False
        End If
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(ByVal useLocalCheck As Boolean, ByVal viewModel As ICtrlLintAdminConsoleViewModel)
        InitializeComponent()
        If viewModel Is Nothing Then Throw New ArgumentNullException("CtrlLintAdminConsole - viewModel")
        _configManager = LintApplicationConfigurationManager.Instance
        ViewModelBindingSource.DataSource = viewModel
        _useLocalCheck = useLocalCheck
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the <see cref="CtrlLintAdminConsole"/> class. By default, remote user validation
    ''' is used.
    ''' </summary>
    ''' <param name="viewModel">The view model.</param>
    Public Sub New(ByVal viewModel As ICtrlLintAdminConsoleViewModel)
        Me.New(False, viewModel)
    End Sub

#End Region

End Class



