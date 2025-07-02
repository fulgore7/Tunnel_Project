
Imports Wdw_Sust.Textile.Core.Configurations

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintAdminConsole
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintAdminConsole))
        Me.gbProgramMode = New System.Windows.Forms.GroupBox()
        Me.radTest = New System.Windows.Forms.RadioButton()
        Me.radFailOver = New System.Windows.Forms.RadioButton()
        Me.radMaintenance = New System.Windows.Forms.RadioButton()
        Me.radProduction = New System.Windows.Forms.RadioButton()
        Me.ViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.LintAppConfigFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbWorkStationNames = New System.Windows.Forms.ComboBox()
        Me.lblWorkStationName = New System.Windows.Forms.Label()
        Me.chkHIdReaderEnabled = New System.Windows.Forms.CheckBox()
        Me.gbUsbRfidReader = New System.Windows.Forms.GroupBox()
        Me.lblBaudRate = New System.Windows.Forms.Label()
        Me.lblComPortName = New System.Windows.Forms.Label()
        Me.cmbComPortNames = New System.Windows.Forms.ComboBox()
        Me.ComPortSettingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.lblMessage1 = New System.Windows.Forms.Label()
        Me.chkLogging = New System.Windows.Forms.CheckBox()
        Me.btnCheckMonitor = New System.Windows.Forms.Button()
        Me.chkChatServiceEnabled = New System.Windows.Forms.CheckBox()
        Me.lblBagDrawingMode = New System.Windows.Forms.Label()
        Me.cmbBagDrawingMode = New System.Windows.Forms.ComboBox()
        Me.chkUseRemoteLINX = New System.Windows.Forms.CheckBox()
        Me.txtRemoteGatewayNameOrIP = New System.Windows.Forms.TextBox()
        Me.gbOPC = New System.Windows.Forms.GroupBox()
        Me.btnPlcTopics = New System.Windows.Forms.Button()
        Me.cmbPlant = New System.Windows.Forms.ComboBox()
        Me.lblApplicationName = New System.Windows.Forms.Label()
        Me.cmbAppName = New System.Windows.Forms.ComboBox()
        Me.lblPlant = New System.Windows.Forms.Label()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.cbxStartWithWindows = New System.Windows.Forms.CheckBox()
        Me.lblUpdatePath = New System.Windows.Forms.Label()
        Me.tbxUpdatePath = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDisplayOptions = New System.Windows.Forms.Button()
        Me.cbxSendHeartbeat = New System.Windows.Forms.CheckBox()
        Me.gbProgramMode.SuspendLayout()
        CType(Me.ViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LintAppConfigFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUsbRfidReader.SuspendLayout()
        CType(Me.ComPortSettingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOPC.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProgramMode
        '
        Me.gbProgramMode.Controls.Add(Me.radTest)
        Me.gbProgramMode.Controls.Add(Me.radFailOver)
        Me.gbProgramMode.Controls.Add(Me.radMaintenance)
        Me.gbProgramMode.Controls.Add(Me.radProduction)
        Me.gbProgramMode.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseProgramMode", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.gbProgramMode.Location = New System.Drawing.Point(13, 13)
        Me.gbProgramMode.Name = "gbProgramMode"
        Me.gbProgramMode.Size = New System.Drawing.Size(142, 109)
        Me.gbProgramMode.TabIndex = 0
        Me.gbProgramMode.TabStop = False
        Me.gbProgramMode.Text = "Program Mode"
        '
        'radTest
        '
        Me.radTest.AutoSize = True
        Me.radTest.Location = New System.Drawing.Point(7, 84)
        Me.radTest.Name = "radTest"
        Me.radTest.Size = New System.Drawing.Size(76, 17)
        Me.radTest.TabIndex = 3
        Me.radTest.TabStop = True
        Me.radTest.Text = "Test Mode"
        Me.radTest.UseVisualStyleBackColor = True
        '
        'radFailOver
        '
        Me.radFailOver.AutoSize = True
        Me.radFailOver.Location = New System.Drawing.Point(7, 62)
        Me.radFailOver.Name = "radFailOver"
        Me.radFailOver.Size = New System.Drawing.Size(97, 17)
        Me.radFailOver.TabIndex = 2
        Me.radFailOver.TabStop = True
        Me.radFailOver.Text = "Fail Over Mode"
        Me.radFailOver.UseVisualStyleBackColor = True
        '
        'radMaintenance
        '
        Me.radMaintenance.AutoSize = True
        Me.radMaintenance.Location = New System.Drawing.Point(7, 39)
        Me.radMaintenance.Name = "radMaintenance"
        Me.radMaintenance.Size = New System.Drawing.Size(117, 17)
        Me.radMaintenance.TabIndex = 1
        Me.radMaintenance.TabStop = True
        Me.radMaintenance.Text = "Maintenance Mode"
        Me.radMaintenance.UseVisualStyleBackColor = True
        '
        'radProduction
        '
        Me.radProduction.AutoSize = True
        Me.radProduction.Location = New System.Drawing.Point(7, 16)
        Me.radProduction.Name = "radProduction"
        Me.radProduction.Size = New System.Drawing.Size(106, 17)
        Me.radProduction.TabIndex = 0
        Me.radProduction.TabStop = True
        Me.radProduction.Text = "Production Mode"
        Me.radProduction.UseVisualStyleBackColor = True
        '
        'ViewModelBindingSource
        '
        Me.ViewModelBindingSource.DataSource = GetType(Wdw_Sust.Textile.[Global].WinForms.Interfaces.ICtrlLintAdminConsoleViewModel)
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(174, 505)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 37)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnApply.Location = New System.Drawing.Point(255, 505)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 37)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'LintAppConfigFileBindingSource
        '
        Me.LintAppConfigFileBindingSource.DataSource = GetType(Wdw_Sust.Textile.Core.Configurations.LintApplicationConfigFile)
        '
        'cmbWorkStationNames
        '
        Me.cmbWorkStationNames.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LintAppConfigFileBindingSource, "WorkStation", True))
        Me.cmbWorkStationNames.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseWorkStationName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.cmbWorkStationNames.FormattingEnabled = True
        Me.cmbWorkStationNames.Location = New System.Drawing.Point(15, 183)
        Me.cmbWorkStationNames.Name = "cmbWorkStationNames"
        Me.cmbWorkStationNames.Size = New System.Drawing.Size(316, 21)
        Me.cmbWorkStationNames.TabIndex = 4
        '
        'lblWorkStationName
        '
        Me.lblWorkStationName.AutoSize = True
        Me.lblWorkStationName.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseWorkStationName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblWorkStationName.Location = New System.Drawing.Point(10, 167)
        Me.lblWorkStationName.Name = "lblWorkStationName"
        Me.lblWorkStationName.Size = New System.Drawing.Size(100, 13)
        Me.lblWorkStationName.TabIndex = 5
        Me.lblWorkStationName.Text = "Work Station Name"
        '
        'chkHIdReaderEnabled
        '
        Me.chkHIdReaderEnabled.AutoSize = True
        Me.chkHIdReaderEnabled.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LintAppConfigFileBindingSource, "IsHidInterfaceUsed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkHIdReaderEnabled.Location = New System.Drawing.Point(7, 79)
        Me.chkHIdReaderEnabled.Name = "chkHIdReaderEnabled"
        Me.chkHIdReaderEnabled.Size = New System.Drawing.Size(128, 17)
        Me.chkHIdReaderEnabled.TabIndex = 9
        Me.chkHIdReaderEnabled.Text = "HID Reader Interface"
        Me.chkHIdReaderEnabled.UseVisualStyleBackColor = True
        '
        'gbUsbRfidReader
        '
        Me.gbUsbRfidReader.Controls.Add(Me.lblBaudRate)
        Me.gbUsbRfidReader.Controls.Add(Me.lblComPortName)
        Me.gbUsbRfidReader.Controls.Add(Me.cmbComPortNames)
        Me.gbUsbRfidReader.Controls.Add(Me.cmbBaudRate)
        Me.gbUsbRfidReader.Controls.Add(Me.lblMessage1)
        Me.gbUsbRfidReader.Controls.Add(Me.chkHIdReaderEnabled)
        Me.gbUsbRfidReader.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseRfidReader", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.gbUsbRfidReader.Location = New System.Drawing.Point(11, 377)
        Me.gbUsbRfidReader.Name = "gbUsbRfidReader"
        Me.gbUsbRfidReader.Size = New System.Drawing.Size(319, 122)
        Me.gbUsbRfidReader.TabIndex = 10
        Me.gbUsbRfidReader.TabStop = False
        Me.gbUsbRfidReader.Text = "RFID Reader"
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.Location = New System.Drawing.Point(29, 49)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(58, 13)
        Me.lblBaudRate.TabIndex = 14
        Me.lblBaudRate.Text = "Baud Rate"
        '
        'lblComPortName
        '
        Me.lblComPortName.AutoSize = True
        Me.lblComPortName.Location = New System.Drawing.Point(6, 22)
        Me.lblComPortName.Name = "lblComPortName"
        Me.lblComPortName.Size = New System.Drawing.Size(81, 13)
        Me.lblComPortName.TabIndex = 13
        Me.lblComPortName.Text = "Com Port Name"
        '
        'cmbComPortNames
        '
        Me.cmbComPortNames.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComPortSettingBindingSource, "ComPortName", True))
        Me.cmbComPortNames.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.LintAppConfigFileBindingSource, "IsNotHidInterfaceUsed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbComPortNames.FormattingEnabled = True
        Me.cmbComPortNames.Location = New System.Drawing.Point(93, 19)
        Me.cmbComPortNames.Name = "cmbComPortNames"
        Me.cmbComPortNames.Size = New System.Drawing.Size(90, 21)
        Me.cmbComPortNames.TabIndex = 12
        '
        'ComPortSettingBindingSource
        '
        Me.ComPortSettingBindingSource.DataSource = GetType(Wdw_Sust.Core.ComPortSetting)
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComPortSettingBindingSource, "BaudRate", True))
        Me.cmbBaudRate.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.LintAppConfigFileBindingSource, "IsNotHidInterfaceUsed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Location = New System.Drawing.Point(95, 46)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(88, 21)
        Me.cmbBaudRate.TabIndex = 11
        '
        'lblMessage1
        '
        Me.lblMessage1.Location = New System.Drawing.Point(136, 80)
        Me.lblMessage1.Name = "lblMessage1"
        Me.lblMessage1.Size = New System.Drawing.Size(174, 29)
        Me.lblMessage1.TabIndex = 10
        Me.lblMessage1.Text = "Only check this box for Windows Embedded Machine"
        '
        'chkLogging
        '
        Me.chkLogging.AutoSize = True
        Me.chkLogging.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LintAppConfigFileBindingSource, "IsLoggingEnabled", True))
        Me.chkLogging.Location = New System.Drawing.Point(233, 131)
        Me.chkLogging.Name = "chkLogging"
        Me.chkLogging.Size = New System.Drawing.Size(100, 17)
        Me.chkLogging.TabIndex = 11
        Me.chkLogging.Text = "Enable Logging"
        Me.chkLogging.UseVisualStyleBackColor = True
        '
        'btnCheckMonitor
        '
        Me.btnCheckMonitor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheckMonitor.Location = New System.Drawing.Point(11, 254)
        Me.btnCheckMonitor.Name = "btnCheckMonitor"
        Me.btnCheckMonitor.Size = New System.Drawing.Size(319, 29)
        Me.btnCheckMonitor.TabIndex = 12
        Me.btnCheckMonitor.Text = "Monitor App Status"
        Me.btnCheckMonitor.UseVisualStyleBackColor = True
        '
        'chkChatServiceEnabled
        '
        Me.chkChatServiceEnabled.AutoSize = True
        Me.chkChatServiceEnabled.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LintAppConfigFileBindingSource, "IsChatServiceEnabled", True))
        Me.chkChatServiceEnabled.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseChatService", True))
        Me.chkChatServiceEnabled.Location = New System.Drawing.Point(167, 79)
        Me.chkChatServiceEnabled.Name = "chkChatServiceEnabled"
        Me.chkChatServiceEnabled.Size = New System.Drawing.Size(129, 17)
        Me.chkChatServiceEnabled.TabIndex = 7
        Me.chkChatServiceEnabled.Text = "Chat Service Enabled"
        Me.chkChatServiceEnabled.UseVisualStyleBackColor = True
        '
        'lblBagDrawingMode
        '
        Me.lblBagDrawingMode.AutoSize = True
        Me.lblBagDrawingMode.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseBagGraphics", True))
        Me.lblBagDrawingMode.Location = New System.Drawing.Point(10, 127)
        Me.lblBagDrawingMode.Name = "lblBagDrawingMode"
        Me.lblBagDrawingMode.Size = New System.Drawing.Size(98, 13)
        Me.lblBagDrawingMode.TabIndex = 5
        Me.lblBagDrawingMode.Text = "Bag Drawing Mode"
        '
        'cmbBagDrawingMode
        '
        Me.cmbBagDrawingMode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LintAppConfigFileBindingSource, "BagDrawingMode", True))
        Me.cmbBagDrawingMode.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseBagGraphics", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.cmbBagDrawingMode.FormattingEnabled = True
        Me.cmbBagDrawingMode.Location = New System.Drawing.Point(13, 143)
        Me.cmbBagDrawingMode.Name = "cmbBagDrawingMode"
        Me.cmbBagDrawingMode.Size = New System.Drawing.Size(131, 21)
        Me.cmbBagDrawingMode.TabIndex = 4
        '
        'chkUseRemoteLINX
        '
        Me.chkUseRemoteLINX.AutoSize = True
        Me.chkUseRemoteLINX.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LintAppConfigFileBindingSource, "IsRemoteLinxUsed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUseRemoteLINX.Location = New System.Drawing.Point(6, 16)
        Me.chkUseRemoteLINX.Name = "chkUseRemoteLINX"
        Me.chkUseRemoteLINX.Size = New System.Drawing.Size(107, 17)
        Me.chkUseRemoteLINX.TabIndex = 5
        Me.chkUseRemoteLINX.Text = "Use Remote Linx"
        Me.chkUseRemoteLINX.UseVisualStyleBackColor = True
        '
        'txtRemoteGatewayNameOrIP
        '
        Me.txtRemoteGatewayNameOrIP.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.LintAppConfigFileBindingSource, "IsRemoteLinxUsed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtRemoteGatewayNameOrIP.Location = New System.Drawing.Point(6, 39)
        Me.txtRemoteGatewayNameOrIP.Name = "txtRemoteGatewayNameOrIP"
        Me.txtRemoteGatewayNameOrIP.Size = New System.Drawing.Size(157, 20)
        Me.txtRemoteGatewayNameOrIP.TabIndex = 6
        '
        'gbOPC
        '
        Me.gbOPC.Controls.Add(Me.btnPlcTopics)
        Me.gbOPC.Controls.Add(Me.txtRemoteGatewayNameOrIP)
        Me.gbOPC.Controls.Add(Me.chkUseRemoteLINX)
        Me.gbOPC.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseOpc", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.gbOPC.Location = New System.Drawing.Point(161, 13)
        Me.gbOPC.Name = "gbOPC"
        Me.gbOPC.Size = New System.Drawing.Size(169, 64)
        Me.gbOPC.TabIndex = 6
        Me.gbOPC.TabStop = False
        Me.gbOPC.Text = "OPC"
        '
        'btnPlcTopics
        '
        Me.btnPlcTopics.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPlcTopics.Location = New System.Drawing.Point(111, 13)
        Me.btnPlcTopics.Name = "btnPlcTopics"
        Me.btnPlcTopics.Size = New System.Drawing.Size(53, 21)
        Me.btnPlcTopics.TabIndex = 16
        Me.btnPlcTopics.Text = "Topics"
        Me.btnPlcTopics.UseVisualStyleBackColor = True
        '
        'cmbPlant
        '
        Me.cmbPlant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LintAppConfigFileBindingSource, "Plant", True))
        Me.cmbPlant.FormattingEnabled = True
        Me.cmbPlant.Location = New System.Drawing.Point(150, 143)
        Me.cmbPlant.Name = "cmbPlant"
        Me.cmbPlant.Size = New System.Drawing.Size(77, 21)
        Me.cmbPlant.TabIndex = 13
        '
        'lblApplicationName
        '
        Me.lblApplicationName.AutoSize = True
        Me.lblApplicationName.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseLintAppId", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblApplicationName.Location = New System.Drawing.Point(10, 207)
        Me.lblApplicationName.Name = "lblApplicationName"
        Me.lblApplicationName.Size = New System.Drawing.Size(90, 13)
        Me.lblApplicationName.TabIndex = 15
        Me.lblApplicationName.Text = "Application Name"
        '
        'cmbAppName
        '
        Me.cmbAppName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LintAppConfigFileBindingSource, "ApplicationId", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbAppName.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseLintAppId", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.cmbAppName.FormattingEnabled = True
        Me.cmbAppName.Location = New System.Drawing.Point(15, 227)
        Me.cmbAppName.Name = "cmbAppName"
        Me.cmbAppName.Size = New System.Drawing.Size(316, 21)
        Me.cmbAppName.TabIndex = 14
        '
        'lblPlant
        '
        Me.lblPlant.AutoSize = True
        Me.lblPlant.Location = New System.Drawing.Point(147, 127)
        Me.lblPlant.Name = "lblPlant"
        Me.lblPlant.Size = New System.Drawing.Size(31, 13)
        Me.lblPlant.TabIndex = 15
        Me.lblPlant.Text = "Plant"
        '
        'btnDatabase
        '
        Me.btnDatabase.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseDatabase", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.btnDatabase.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDatabase.Location = New System.Drawing.Point(11, 505)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(75, 37)
        Me.btnDatabase.TabIndex = 16
        Me.btnDatabase.Text = "Database"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'cbxStartWithWindows
        '
        Me.cbxStartWithWindows.AutoSize = True
        Me.cbxStartWithWindows.Location = New System.Drawing.Point(93, 63)
        Me.cbxStartWithWindows.Name = "cbxStartWithWindows"
        Me.cbxStartWithWindows.Size = New System.Drawing.Size(120, 17)
        Me.cbxStartWithWindows.TabIndex = 17
        Me.cbxStartWithWindows.Text = "Start With Windows"
        Me.cbxStartWithWindows.UseVisualStyleBackColor = True
        '
        'lblUpdatePath
        '
        Me.lblUpdatePath.AutoSize = True
        Me.lblUpdatePath.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseWorkStationName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblUpdatePath.Location = New System.Drawing.Point(3, 19)
        Me.lblUpdatePath.Name = "lblUpdatePath"
        Me.lblUpdatePath.Size = New System.Drawing.Size(67, 13)
        Me.lblUpdatePath.TabIndex = 19
        Me.lblUpdatePath.Text = "Update Path"
        '
        'tbxUpdatePath
        '
        Me.tbxUpdatePath.Location = New System.Drawing.Point(7, 37)
        Me.tbxUpdatePath.Name = "tbxUpdatePath"
        Me.tbxUpdatePath.Size = New System.Drawing.Size(305, 20)
        Me.tbxUpdatePath.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUpdatePath)
        Me.GroupBox1.Controls.Add(Me.cbxStartWithWindows)
        Me.GroupBox1.Controls.Add(Me.tbxUpdatePath)
        Me.GroupBox1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.ViewModelBindingSource, "UseRfidReader", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 86)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Windows Settings"
        '
        'btnDisplayOptions
        '
        Me.btnDisplayOptions.Location = New System.Drawing.Point(165, 99)
        Me.btnDisplayOptions.Name = "btnDisplayOptions"
        Me.btnDisplayOptions.Size = New System.Drawing.Size(107, 23)
        Me.btnDisplayOptions.TabIndex = 17
        Me.btnDisplayOptions.Text = "Display Options"
        Me.btnDisplayOptions.UseVisualStyleBackColor = True
        '
        'cbxSendHeartbeat
        '
        Me.cbxSendHeartbeat.AutoSize = True
        Me.cbxSendHeartbeat.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LintAppConfigFileBindingSource, "IsLoggingEnabled", True))
        Me.cbxSendHeartbeat.Location = New System.Drawing.Point(233, 154)
        Me.cbxSendHeartbeat.Name = "cbxSendHeartbeat"
        Me.cbxSendHeartbeat.Size = New System.Drawing.Size(101, 17)
        Me.cbxSendHeartbeat.TabIndex = 18
        Me.cbxSendHeartbeat.Text = "Send Heartbeat"
        Me.cbxSendHeartbeat.UseVisualStyleBackColor = True
        '
        'CtrlLintAdminConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 548)
        Me.Controls.Add(Me.cbxSendHeartbeat)
        Me.Controls.Add(Me.btnDisplayOptions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDatabase)
        Me.Controls.Add(Me.lblPlant)
        Me.Controls.Add(Me.lblApplicationName)
        Me.Controls.Add(Me.cmbAppName)
        Me.Controls.Add(Me.cmbPlant)
        Me.Controls.Add(Me.btnCheckMonitor)
        Me.Controls.Add(Me.chkLogging)
        Me.Controls.Add(Me.gbUsbRfidReader)
        Me.Controls.Add(Me.chkChatServiceEnabled)
        Me.Controls.Add(Me.gbOPC)
        Me.Controls.Add(Me.lblWorkStationName)
        Me.Controls.Add(Me.cmbWorkStationNames)
        Me.Controls.Add(Me.lblBagDrawingMode)
        Me.Controls.Add(Me.cmbBagDrawingMode)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbProgramMode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtrlLintAdminConsole"
        Me.Text = "Admin Console"
        Me.gbProgramMode.ResumeLayout(False)
        Me.gbProgramMode.PerformLayout()
        CType(Me.ViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LintAppConfigFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUsbRfidReader.ResumeLayout(False)
        Me.gbUsbRfidReader.PerformLayout()
        CType(Me.ComPortSettingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOPC.ResumeLayout(False)
        Me.gbOPC.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbProgramMode As System.Windows.Forms.GroupBox
    Friend WithEvents radMaintenance As System.Windows.Forms.RadioButton
    Friend WithEvents radProduction As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents cmbWorkStationNames As System.Windows.Forms.ComboBox
    Friend WithEvents lblWorkStationName As System.Windows.Forms.Label
    Friend WithEvents radFailOver As System.Windows.Forms.RadioButton
    Friend WithEvents chkHIdReaderEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents gbUsbRfidReader As System.Windows.Forms.GroupBox
    Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    Friend WithEvents chkLogging As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckMonitor As System.Windows.Forms.Button
    Friend WithEvents chkChatServiceEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents lblBagDrawingMode As System.Windows.Forms.Label
    Friend WithEvents cmbBagDrawingMode As System.Windows.Forms.ComboBox
    Friend WithEvents chkUseRemoteLINX As System.Windows.Forms.CheckBox
    Friend WithEvents txtRemoteGatewayNameOrIP As System.Windows.Forms.TextBox
    Friend WithEvents gbOPC As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPlant As System.Windows.Forms.ComboBox
    Friend WithEvents lblApplicationName As System.Windows.Forms.Label
    Friend WithEvents cmbAppName As System.Windows.Forms.ComboBox
    Friend WithEvents LintAppConfigFileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents ComPortSettingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbComPortNames As System.Windows.Forms.ComboBox
    Friend WithEvents lblBaudRate As System.Windows.Forms.Label
    Friend WithEvents lblComPortName As System.Windows.Forms.Label
    Friend WithEvents lblPlant As System.Windows.Forms.Label
    Friend WithEvents btnPlcTopics As System.Windows.Forms.Button
    Friend WithEvents btnDatabase As System.Windows.Forms.Button
    Friend WithEvents ViewModelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents radTest As System.Windows.Forms.RadioButton
    Friend WithEvents cbxStartWithWindows As System.Windows.Forms.CheckBox
    Friend WithEvents lblUpdatePath As System.Windows.Forms.Label
    Friend WithEvents tbxUpdatePath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisplayOptions As System.Windows.Forms.Button
    Friend WithEvents cbxSendHeartbeat As System.Windows.Forms.CheckBox
End Class


