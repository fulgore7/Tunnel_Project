Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.WinForms
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits TSA_Rail_System.frmRailMainFormBase

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShiftSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategorySetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryWorkflowParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeightCalibrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetProductivityCountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WashdeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanworkProductivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WashdeckToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CastMemberShiftDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkflowSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunAutoCallOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastWorkflowCalculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataCollectionMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RFIDCommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableExternalLoginValidationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RailSequenceEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslShift = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssActiveAlarms = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLoginStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssNumberOfFWTFLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLastAction = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssDataSource = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssProgramMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Environment = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsClassified = New System.Windows.Forms.ToolStripLabel()
        Me.tsgcClassifiedOngoing = New TSA_Rail_System.CtrlOpcTsaRunDownButton()
        Me.tsgcClassifiedOffgoing = New TSA_Rail_System.CtrlOpcTsaRunDownButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCleanwork = New System.Windows.Forms.ToolStripLabel()
        Me.tsgcCleanworkOngoing = New TSA_Rail_System.CtrlOpcTsaRunDownButton()
        Me.tsgcCleanworkOffgoing = New TSA_Rail_System.CtrlOpcTsaRunDownButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDataCollection = New System.Windows.Forms.ToolStripLabel()
        Me.CtrlLINTAlarmToolStripIndicator1 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmToolStripIndicator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsMilnorComm = New System.Windows.Forms.ToolStripLabel()
        Me.CtrlLINTAlarmToolStripIndicator2 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmToolStripIndicator()
        Me.tsAutoCallOff = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgcAutoCallOffButtonT1 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT5 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT6 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT7 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.tsgcAutoCallOffButtonT8 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaAutoCallOffButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAutoCallOff = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CtrlLINTChatToolStripIndicator1 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintChatToolStripIndicator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssTotalSorted = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssTotalWashed = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssAvailableDryers = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssClassifiedStorageBags = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssCleanStorageBags = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssAvailableWashers = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel()
        Me.msMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1199, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiShiftSettings, Me.DatabaseSettingsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'tsmiShiftSettings
        '
        Me.tsmiShiftSettings.Name = "tsmiShiftSettings"
        Me.tsmiShiftSettings.Size = New System.Drawing.Size(167, 22)
        Me.tsmiShiftSettings.Text = "Shift Settings"
        '
        'DatabaseSettingsToolStripMenuItem
        '
        Me.DatabaseSettingsToolStripMenuItem.Name = "DatabaseSettingsToolStripMenuItem"
        Me.DatabaseSettingsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DatabaseSettingsToolStripMenuItem.Text = "Database Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategorySetupToolStripMenuItem, Me.CategoryWorkflowParametersToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AdminConsoleToolStripMenuItem, Me.WeightCalibrationToolStripMenuItem, Me.ResetProductivityCountsToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.ChatToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CategorySetupToolStripMenuItem
        '
        Me.CategorySetupToolStripMenuItem.Name = "CategorySetupToolStripMenuItem"
        Me.CategorySetupToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CategorySetupToolStripMenuItem.Text = "Category Setup"
        '
        'CategoryWorkflowParametersToolStripMenuItem
        '
        Me.CategoryWorkflowParametersToolStripMenuItem.Name = "CategoryWorkflowParametersToolStripMenuItem"
        Me.CategoryWorkflowParametersToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CategoryWorkflowParametersToolStripMenuItem.Text = "Category Workflow Parameters"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableauToolStripMenuItem, Me.DesktopToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.Visible = False
        '
        'TableauToolStripMenuItem
        '
        Me.TableauToolStripMenuItem.Name = "TableauToolStripMenuItem"
        Me.TableauToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TableauToolStripMenuItem.Text = "Tableau"
        '
        'DesktopToolStripMenuItem
        '
        Me.DesktopToolStripMenuItem.Name = "DesktopToolStripMenuItem"
        Me.DesktopToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DesktopToolStripMenuItem.Text = "Desktop"
        '
        'AdminConsoleToolStripMenuItem
        '
        Me.AdminConsoleToolStripMenuItem.Name = "AdminConsoleToolStripMenuItem"
        Me.AdminConsoleToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.AdminConsoleToolStripMenuItem.Text = "Admin Console"
        '
        'WeightCalibrationToolStripMenuItem
        '
        Me.WeightCalibrationToolStripMenuItem.Enabled = False
        Me.WeightCalibrationToolStripMenuItem.Name = "WeightCalibrationToolStripMenuItem"
        Me.WeightCalibrationToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.WeightCalibrationToolStripMenuItem.Text = "Scale Calibration"
        '
        'ResetProductivityCountsToolStripMenuItem
        '
        Me.ResetProductivityCountsToolStripMenuItem.Enabled = False
        Me.ResetProductivityCountsToolStripMenuItem.Name = "ResetProductivityCountsToolStripMenuItem"
        Me.ResetProductivityCountsToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ResetProductivityCountsToolStripMenuItem.Text = "Reset Productivity"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.Enabled = False
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WashdeckToolStripMenuItem, Me.ProductivityToolStripMenuItem, Me.AlarmViewerToolStripMenuItem, Me.WorkflowSystemToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'WashdeckToolStripMenuItem
        '
        Me.WashdeckToolStripMenuItem.Name = "WashdeckToolStripMenuItem"
        Me.WashdeckToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.WashdeckToolStripMenuItem.Text = "Washdeck Area"
        '
        'ProductivityToolStripMenuItem
        '
        Me.ProductivityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanworkProductivityToolStripMenuItem, Me.SortingToolStripMenuItem, Me.WashdeckToolStripMenuItem1, Me.CastMemberShiftDataToolStripMenuItem, Me.ProductDistributionToolStripMenuItem})
        Me.ProductivityToolStripMenuItem.Name = "ProductivityToolStripMenuItem"
        Me.ProductivityToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ProductivityToolStripMenuItem.Text = "Productivity"
        Me.ProductivityToolStripMenuItem.Visible = False
        '
        'CleanworkProductivityToolStripMenuItem
        '
        Me.CleanworkProductivityToolStripMenuItem.Name = "CleanworkProductivityToolStripMenuItem"
        Me.CleanworkProductivityToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CleanworkProductivityToolStripMenuItem.Text = "Cleanwork"
        '
        'SortingToolStripMenuItem
        '
        Me.SortingToolStripMenuItem.Name = "SortingToolStripMenuItem"
        Me.SortingToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SortingToolStripMenuItem.Text = "Sorting"
        '
        'WashdeckToolStripMenuItem1
        '
        Me.WashdeckToolStripMenuItem1.Name = "WashdeckToolStripMenuItem1"
        Me.WashdeckToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.WashdeckToolStripMenuItem1.Text = "Washdeck"
        '
        'CastMemberShiftDataToolStripMenuItem
        '
        Me.CastMemberShiftDataToolStripMenuItem.Name = "CastMemberShiftDataToolStripMenuItem"
        Me.CastMemberShiftDataToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CastMemberShiftDataToolStripMenuItem.Text = "Cast Member Shift Data"
        '
        'ProductDistributionToolStripMenuItem
        '
        Me.ProductDistributionToolStripMenuItem.Name = "ProductDistributionToolStripMenuItem"
        Me.ProductDistributionToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ProductDistributionToolStripMenuItem.Text = "Product Distribution"
        '
        'AlarmViewerToolStripMenuItem
        '
        Me.AlarmViewerToolStripMenuItem.Name = "AlarmViewerToolStripMenuItem"
        Me.AlarmViewerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AlarmViewerToolStripMenuItem.Text = "Alarm Viewer"
        Me.AlarmViewerToolStripMenuItem.Visible = False
        '
        'WorkflowSystemToolStripMenuItem
        '
        Me.WorkflowSystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CallOffToolStripMenuItem, Me.RunAutoCallOffToolStripMenuItem, Me.LastWorkflowCalculationToolStripMenuItem})
        Me.WorkflowSystemToolStripMenuItem.Enabled = False
        Me.WorkflowSystemToolStripMenuItem.Name = "WorkflowSystemToolStripMenuItem"
        Me.WorkflowSystemToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.WorkflowSystemToolStripMenuItem.Text = "Workflow System"
        Me.WorkflowSystemToolStripMenuItem.Visible = False
        '
        'CallOffToolStripMenuItem
        '
        Me.CallOffToolStripMenuItem.Name = "CallOffToolStripMenuItem"
        Me.CallOffToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CallOffToolStripMenuItem.Text = "Auto Call Off"
        '
        'RunAutoCallOffToolStripMenuItem
        '
        Me.RunAutoCallOffToolStripMenuItem.Name = "RunAutoCallOffToolStripMenuItem"
        Me.RunAutoCallOffToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RunAutoCallOffToolStripMenuItem.Text = "Run Auto Call Off"
        '
        'LastWorkflowCalculationToolStripMenuItem
        '
        Me.LastWorkflowCalculationToolStripMenuItem.Name = "LastWorkflowCalculationToolStripMenuItem"
        Me.LastWorkflowCalculationToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.LastWorkflowCalculationToolStripMenuItem.Text = "Last Workflow Calculation"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdateToolStripMenuItem, Me.ToolStripMenuItem1, Me.DataCollectionMonitoringToolStripMenuItem, Me.DiagnosticsToolStripMenuItem, Me.LogToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CheckForUpdateToolStripMenuItem
        '
        Me.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        Me.CheckForUpdateToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CheckForUpdateToolStripMenuItem.Text = "Check For Update"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 6)
        '
        'DataCollectionMonitoringToolStripMenuItem
        '
        Me.DataCollectionMonitoringToolStripMenuItem.Name = "DataCollectionMonitoringToolStripMenuItem"
        Me.DataCollectionMonitoringToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DataCollectionMonitoringToolStripMenuItem.Text = "Data Collection Monitoring"
        Me.DataCollectionMonitoringToolStripMenuItem.Visible = False
        '
        'DiagnosticsToolStripMenuItem
        '
        Me.DiagnosticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RFIDCommunicationsToolStripMenuItem, Me.EnableExternalLoginValidationToolStripMenuItem, Me.RailSequenceEditorToolStripMenuItem})
        Me.DiagnosticsToolStripMenuItem.Name = "DiagnosticsToolStripMenuItem"
        Me.DiagnosticsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DiagnosticsToolStripMenuItem.Text = "Diagnostics"
        '
        'RFIDCommunicationsToolStripMenuItem
        '
        Me.RFIDCommunicationsToolStripMenuItem.Name = "RFIDCommunicationsToolStripMenuItem"
        Me.RFIDCommunicationsToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.RFIDCommunicationsToolStripMenuItem.Text = "RFID Communications"
        '
        'EnableExternalLoginValidationToolStripMenuItem
        '
        Me.EnableExternalLoginValidationToolStripMenuItem.Name = "EnableExternalLoginValidationToolStripMenuItem"
        Me.EnableExternalLoginValidationToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.EnableExternalLoginValidationToolStripMenuItem.Text = "Enable External Login Validation"
        '
        'RailSequenceEditorToolStripMenuItem
        '
        Me.RailSequenceEditorToolStripMenuItem.Name = "RailSequenceEditorToolStripMenuItem"
        Me.RailSequenceEditorToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.RailSequenceEditorToolStripMenuItem.Text = "Rail Sequence Editor"
        '
        'LogToolStripMenuItem1
        '
        Me.LogToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatorLogToolStripMenuItem, Me.SystemLogToolStripMenuItem})
        Me.LogToolStripMenuItem1.Name = "LogToolStripMenuItem1"
        Me.LogToolStripMenuItem1.Size = New System.Drawing.Size(218, 22)
        Me.LogToolStripMenuItem1.Text = "Log"
        '
        'OperatorLogToolStripMenuItem
        '
        Me.OperatorLogToolStripMenuItem.Name = "OperatorLogToolStripMenuItem"
        Me.OperatorLogToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OperatorLogToolStripMenuItem.Text = "Operator Log"
        '
        'SystemLogToolStripMenuItem
        '
        Me.SystemLogToolStripMenuItem.Name = "SystemLogToolStripMenuItem"
        Me.SystemLogToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SystemLogToolStripMenuItem.Text = "System Log"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslShift, Me.tssActiveAlarms, Me.tssLoginStatus, Me.tssNumberOfFWTFLogin, Me.tssLastAction, Me.tssDataSource, Me.tssProgramMode, Me.tssVersion, Me.Environment})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(1199, 28)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslShift
        '
        Me.tsslShift.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslShift.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tsslShift.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslShift.Name = "tsslShift"
        Me.tsslShift.Size = New System.Drawing.Size(51, 23)
        Me.tsslShift.Text = "Shift"
        '
        'tssActiveAlarms
        '
        Me.tssActiveAlarms.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssActiveAlarms.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssActiveAlarms.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssActiveAlarms.Name = "tssActiveAlarms"
        Me.tssActiveAlarms.Size = New System.Drawing.Size(173, 23)
        Me.tssActiveAlarms.Spring = True
        Me.tssActiveAlarms.Text = "Active Alarms"
        Me.tssActiveAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssLoginStatus
        '
        Me.tssLoginStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssLoginStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssLoginStatus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssLoginStatus.Name = "tssLoginStatus"
        Me.tssLoginStatus.Size = New System.Drawing.Size(173, 23)
        Me.tssLoginStatus.Spring = True
        Me.tssLoginStatus.Text = "Last Login"
        Me.tssLoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssNumberOfFWTFLogin
        '
        Me.tssNumberOfFWTFLogin.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssNumberOfFWTFLogin.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssNumberOfFWTFLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssNumberOfFWTFLogin.Name = "tssNumberOfFWTFLogin"
        Me.tssNumberOfFWTFLogin.Size = New System.Drawing.Size(173, 23)
        Me.tssNumberOfFWTFLogin.Spring = True
        Me.tssNumberOfFWTFLogin.Text = "Ironer Login: Towel Login:"
        Me.tssNumberOfFWTFLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssLastAction
        '
        Me.tssLastAction.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssLastAction.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssLastAction.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssLastAction.Name = "tssLastAction"
        Me.tssLastAction.Size = New System.Drawing.Size(173, 23)
        Me.tssLastAction.Spring = True
        Me.tssLastAction.Text = "Last Action"
        Me.tssLastAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssDataSource
        '
        Me.tssDataSource.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssDataSource.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssDataSource.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssDataSource.Name = "tssDataSource"
        Me.tssDataSource.Size = New System.Drawing.Size(173, 23)
        Me.tssDataSource.Spring = True
        Me.tssDataSource.Text = "Data Source"
        Me.tssDataSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssProgramMode
        '
        Me.tssProgramMode.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssProgramMode.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssProgramMode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssProgramMode.Name = "tssProgramMode"
        Me.tssProgramMode.Size = New System.Drawing.Size(132, 23)
        Me.tssProgramMode.Text = "Program Mode"
        Me.tssProgramMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tssVersion
        '
        Me.tssVersion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssVersion.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.tssVersion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssVersion.Name = "tssVersion"
        Me.tssVersion.Size = New System.Drawing.Size(74, 23)
        Me.tssVersion.Text = "Version"
        '
        'Environment
        '
        Me.Environment.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Environment.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.Environment.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Environment.ForeColor = System.Drawing.Color.Lime
        Me.Environment.Name = "Environment"
        Me.Environment.Size = New System.Drawing.Size(60, 23)
        Me.Environment.Text = "PROD"
        '
        'tsMain
        '
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsClassified, Me.tsgcClassifiedOngoing, Me.tsgcClassifiedOffgoing, Me.ToolStripSeparator1, Me.tsCleanwork, Me.tsgcCleanworkOngoing, Me.tsgcCleanworkOffgoing, Me.ToolStripSeparator4, Me.tsDataCollection, Me.CtrlLINTAlarmToolStripIndicator1, Me.ToolStripSeparator7, Me.tsMilnorComm, Me.CtrlLINTAlarmToolStripIndicator2, Me.tsAutoCallOff, Me.ToolStripSeparator5, Me.tsgcAutoCallOffButtonT1, Me.tsgcAutoCallOffButtonT2, Me.tsgcAutoCallOffButtonT3, Me.tsgcAutoCallOffButtonT4, Me.tsgcAutoCallOffButtonT5, Me.tsgcAutoCallOffButtonT6, Me.tsgcAutoCallOffButtonT7, Me.tsgcAutoCallOffButtonT8, Me.ToolStripSeparator6, Me.tsbtnAutoCallOff, Me.ToolStripSeparator9, Me.ToolStripLabel1, Me.CtrlLINTChatToolStripIndicator1, Me.ToolStripSeparator11, Me.tssTotalSorted, Me.ToolStripSeparator8, Me.tssTotalWashed, Me.ToolStripSeparator14, Me.tssAvailableDryers, Me.ToolStripSeparator15, Me.tssClassifiedStorageBags, Me.ToolStripSeparator12, Me.tssCleanStorageBags, Me.ToolStripSeparator13, Me.tssAvailableWashers})
        Me.tsMain.Location = New System.Drawing.Point(0, 24)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1199, 35)
        Me.tsMain.TabIndex = 6
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsClassified
        '
        Me.tsClassified.Name = "tsClassified"
        Me.tsClassified.Size = New System.Drawing.Size(60, 32)
        Me.tsClassified.Text = "Classified:"
        '
        'tsgcClassifiedOngoing
        '
        Me.tsgcClassifiedOngoing.AutoSize = False
        Me.tsgcClassifiedOngoing.GroupName = "Global_Parameters"
        Me.tsgcClassifiedOngoing.Name = "tsgcClassifiedOngoing"
        Me.tsgcClassifiedOngoing.PLCName = Nothing
        Me.tsgcClassifiedOngoing.Size = New System.Drawing.Size(32, 32)
        Me.tsgcClassifiedOngoing.TagNameCompleted = "Run_Down_Ongoing_Complete"
        Me.tsgcClassifiedOngoing.TagNameRequest = "Run_Down_Ongoing"
        Me.tsgcClassifiedOngoing.ToolTipText = "Classified Ongoing Rundown Control"
        '
        'tsgcClassifiedOffgoing
        '
        Me.tsgcClassifiedOffgoing.AutoSize = False
        Me.tsgcClassifiedOffgoing.GroupName = "Global_Parameters"
        Me.tsgcClassifiedOffgoing.Name = "tsgcClassifiedOffgoing"
        Me.tsgcClassifiedOffgoing.PLCName = Nothing
        Me.tsgcClassifiedOffgoing.Size = New System.Drawing.Size(32, 32)
        Me.tsgcClassifiedOffgoing.TagNameCompleted = "Run_Down_Offgoing_Complete"
        Me.tsgcClassifiedOffgoing.TagNameRequest = "Run_Down_Offgoing"
        Me.tsgcClassifiedOffgoing.ToolTipText = "Classified Offgoing Rundown Control"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'tsCleanwork
        '
        Me.tsCleanwork.Name = "tsCleanwork"
        Me.tsCleanwork.Size = New System.Drawing.Size(66, 32)
        Me.tsCleanwork.Text = "Cleanwork:"
        '
        'tsgcCleanworkOngoing
        '
        Me.tsgcCleanworkOngoing.AutoSize = False
        Me.tsgcCleanworkOngoing.GroupName = "Global_Parameters"
        Me.tsgcCleanworkOngoing.Name = "tsgcCleanworkOngoing"
        Me.tsgcCleanworkOngoing.PLCName = Nothing
        Me.tsgcCleanworkOngoing.Size = New System.Drawing.Size(32, 32)
        Me.tsgcCleanworkOngoing.TagNameCompleted = "Run_Down_Ongoing_Complete"
        Me.tsgcCleanworkOngoing.TagNameRequest = "Run_Down_Ongoing"
        Me.tsgcCleanworkOngoing.ToolTipText = "Cleanwork Ongoing Rundown Control"
        '
        'tsgcCleanworkOffgoing
        '
        Me.tsgcCleanworkOffgoing.AutoSize = False
        Me.tsgcCleanworkOffgoing.GroupName = "Global_Parameters"
        Me.tsgcCleanworkOffgoing.Name = "tsgcCleanworkOffgoing"
        Me.tsgcCleanworkOffgoing.PLCName = Nothing
        Me.tsgcCleanworkOffgoing.Size = New System.Drawing.Size(32, 32)
        Me.tsgcCleanworkOffgoing.TagNameCompleted = "Run_Down_Offgoing_Complete"
        Me.tsgcCleanworkOffgoing.TagNameRequest = "Run_Down_Offgoing"
        Me.tsgcCleanworkOffgoing.ToolTipText = "Cleanwork Offgoing Rundown Control"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'tsDataCollection
        '
        Me.tsDataCollection.Name = "tsDataCollection"
        Me.tsDataCollection.Size = New System.Drawing.Size(91, 32)
        Me.tsDataCollection.Text = "Data Collection:"
        '
        'CtrlLINTAlarmToolStripIndicator1
        '
        Me.CtrlLINTAlarmToolStripIndicator1.AutoSize = False
        Me.CtrlLINTAlarmToolStripIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlLINTAlarmToolStripIndicator1.GraphicShownWhenFalse = Nothing
        Me.CtrlLINTAlarmToolStripIndicator1.GraphicShownWhenTrue = Nothing
        Me.CtrlLINTAlarmToolStripIndicator1.Name = "CtrlLINTAlarmToolStripIndicator1"
        Me.CtrlLINTAlarmToolStripIndicator1.PictureShownInDesigner = Wdw_Sust.Textile.Core.Enums.PictureShown.UNDETERMINED
        Me.CtrlLINTAlarmToolStripIndicator1.Size = New System.Drawing.Size(32, 32)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(108001)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(101400)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(101401)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(101402)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(107003)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(107004)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(107013)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(108001)
        Me.CtrlLINTAlarmToolStripIndicator1.SubscribedAlarms.Add(108003)
        Me.CtrlLINTAlarmToolStripIndicator1.Text = "CtrlLINTAlarmToolStripButton1"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 35)
        '
        'tsMilnorComm
        '
        Me.tsMilnorComm.Name = "tsMilnorComm"
        Me.tsMilnorComm.Size = New System.Drawing.Size(88, 32)
        Me.tsMilnorComm.Text = "Milnor Comm.:"
        '
        'CtrlLINTAlarmToolStripIndicator2
        '
        Me.CtrlLINTAlarmToolStripIndicator2.AutoSize = False
        Me.CtrlLINTAlarmToolStripIndicator2.BackColor = System.Drawing.Color.Transparent
        Me.CtrlLINTAlarmToolStripIndicator2.GraphicShownWhenFalse = Nothing
        Me.CtrlLINTAlarmToolStripIndicator2.GraphicShownWhenTrue = Nothing
        Me.CtrlLINTAlarmToolStripIndicator2.Name = "CtrlLINTAlarmToolStripIndicator2"
        Me.CtrlLINTAlarmToolStripIndicator2.PictureShownInDesigner = Wdw_Sust.Textile.Core.Enums.PictureShown.UNDETERMINED
        Me.CtrlLINTAlarmToolStripIndicator2.Size = New System.Drawing.Size(32, 32)
        Me.CtrlLINTAlarmToolStripIndicator2.SubscribedAlarms.Add(105682)
        Me.CtrlLINTAlarmToolStripIndicator2.SubscribedAlarms.Add(105683)
        Me.CtrlLINTAlarmToolStripIndicator2.SubscribedAlarms.Add(105681)
        Me.CtrlLINTAlarmToolStripIndicator2.SubscribedAlarms.Add(105481)
        Me.CtrlLINTAlarmToolStripIndicator2.SubscribedAlarms.Add(105483)
        Me.CtrlLINTAlarmToolStripIndicator2.SubscribedAlarms.Add(105482)
        Me.CtrlLINTAlarmToolStripIndicator2.Text = "CtrlLINTAlarmToolStripButton1"
        '
        'tsAutoCallOff
        '
        Me.tsAutoCallOff.Name = "tsAutoCallOff"
        Me.tsAutoCallOff.Size = New System.Drawing.Size(81, 36)
        Me.tsAutoCallOff.Text = "Auto Call-Off:"
        Me.tsAutoCallOff.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        Me.ToolStripSeparator5.Visible = False
        '
        'tsgcAutoCallOffButtonT1
        '
        Me.tsgcAutoCallOffButtonT1.AutoSize = False
        Me.tsgcAutoCallOffButtonT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT1.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT1.Name = "tsgcAutoCallOffButtonT1"
        Me.tsgcAutoCallOffButtonT1.PLCName = ""
        Me.tsgcAutoCallOffButtonT1.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT1.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[1]"
        Me.tsgcAutoCallOffButtonT1.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[1]"
        Me.tsgcAutoCallOffButtonT1.Text = "T1"
        Me.tsgcAutoCallOffButtonT1.Visible = False
        Me.tsgcAutoCallOffButtonT1.WasherNumber = 1
        '
        'tsgcAutoCallOffButtonT2
        '
        Me.tsgcAutoCallOffButtonT2.AutoSize = False
        Me.tsgcAutoCallOffButtonT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT2.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT2.Name = "tsgcAutoCallOffButtonT2"
        Me.tsgcAutoCallOffButtonT2.PLCName = ""
        Me.tsgcAutoCallOffButtonT2.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT2.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[2]"
        Me.tsgcAutoCallOffButtonT2.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[2]"
        Me.tsgcAutoCallOffButtonT2.Text = "T2"
        Me.tsgcAutoCallOffButtonT2.Visible = False
        Me.tsgcAutoCallOffButtonT2.WasherNumber = 2
        '
        'tsgcAutoCallOffButtonT3
        '
        Me.tsgcAutoCallOffButtonT3.AutoSize = False
        Me.tsgcAutoCallOffButtonT3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT3.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT3.Name = "tsgcAutoCallOffButtonT3"
        Me.tsgcAutoCallOffButtonT3.PLCName = ""
        Me.tsgcAutoCallOffButtonT3.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT3.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[3]"
        Me.tsgcAutoCallOffButtonT3.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[3]"
        Me.tsgcAutoCallOffButtonT3.Text = "T3"
        Me.tsgcAutoCallOffButtonT3.Visible = False
        Me.tsgcAutoCallOffButtonT3.WasherNumber = 3
        '
        'tsgcAutoCallOffButtonT4
        '
        Me.tsgcAutoCallOffButtonT4.AutoSize = False
        Me.tsgcAutoCallOffButtonT4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT4.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT4.Name = "tsgcAutoCallOffButtonT4"
        Me.tsgcAutoCallOffButtonT4.PLCName = ""
        Me.tsgcAutoCallOffButtonT4.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT4.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[4]"
        Me.tsgcAutoCallOffButtonT4.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[4]"
        Me.tsgcAutoCallOffButtonT4.Text = "T4"
        Me.tsgcAutoCallOffButtonT4.Visible = False
        Me.tsgcAutoCallOffButtonT4.WasherNumber = 4
        '
        'tsgcAutoCallOffButtonT5
        '
        Me.tsgcAutoCallOffButtonT5.AutoSize = False
        Me.tsgcAutoCallOffButtonT5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT5.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT5.Name = "tsgcAutoCallOffButtonT5"
        Me.tsgcAutoCallOffButtonT5.PLCName = ""
        Me.tsgcAutoCallOffButtonT5.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT5.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[5]"
        Me.tsgcAutoCallOffButtonT5.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[5]"
        Me.tsgcAutoCallOffButtonT5.Text = "T5"
        Me.tsgcAutoCallOffButtonT5.Visible = False
        Me.tsgcAutoCallOffButtonT5.WasherNumber = 5
        '
        'tsgcAutoCallOffButtonT6
        '
        Me.tsgcAutoCallOffButtonT6.AutoSize = False
        Me.tsgcAutoCallOffButtonT6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT6.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT6.Name = "tsgcAutoCallOffButtonT6"
        Me.tsgcAutoCallOffButtonT6.PLCName = ""
        Me.tsgcAutoCallOffButtonT6.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT6.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[6]"
        Me.tsgcAutoCallOffButtonT6.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[6]"
        Me.tsgcAutoCallOffButtonT6.Text = "T6"
        Me.tsgcAutoCallOffButtonT6.Visible = False
        Me.tsgcAutoCallOffButtonT6.WasherNumber = 6
        '
        'tsgcAutoCallOffButtonT7
        '
        Me.tsgcAutoCallOffButtonT7.AutoSize = False
        Me.tsgcAutoCallOffButtonT7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT7.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT7.Name = "tsgcAutoCallOffButtonT7"
        Me.tsgcAutoCallOffButtonT7.PLCName = ""
        Me.tsgcAutoCallOffButtonT7.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT7.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[7]"
        Me.tsgcAutoCallOffButtonT7.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[7]"
        Me.tsgcAutoCallOffButtonT7.Text = "T7"
        Me.tsgcAutoCallOffButtonT7.Visible = False
        Me.tsgcAutoCallOffButtonT7.WasherNumber = 7
        '
        'tsgcAutoCallOffButtonT8
        '
        Me.tsgcAutoCallOffButtonT8.AutoSize = False
        Me.tsgcAutoCallOffButtonT8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tsgcAutoCallOffButtonT8.GroupName = "Global_Parameters"
        Me.tsgcAutoCallOffButtonT8.Name = "tsgcAutoCallOffButtonT8"
        Me.tsgcAutoCallOffButtonT8.PLCName = ""
        Me.tsgcAutoCallOffButtonT8.Size = New System.Drawing.Size(32, 32)
        Me.tsgcAutoCallOffButtonT8.TagNameWorkflowControl = "Workflow_Call_Off_Tunnel[8]"
        Me.tsgcAutoCallOffButtonT8.TagNameWorkflowEnable = "bWorkflow_Automatic_Call_Off_Enabled[8]"
        Me.tsgcAutoCallOffButtonT8.Text = "T8"
        Me.tsgcAutoCallOffButtonT8.Visible = False
        Me.tsgcAutoCallOffButtonT8.WasherNumber = 8
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        Me.ToolStripSeparator6.Visible = False
        '
        'tsbtnAutoCallOff
        '
        Me.tsbtnAutoCallOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAutoCallOff.Image = CType(resources.GetObject("tsbtnAutoCallOff.Image"), System.Drawing.Image)
        Me.tsbtnAutoCallOff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnAutoCallOff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAutoCallOff.Name = "tsbtnAutoCallOff"
        Me.tsbtnAutoCallOff.Size = New System.Drawing.Size(36, 36)
        Me.tsbtnAutoCallOff.Text = "ToolStripButton1"
        Me.tsbtnAutoCallOff.ToolTipText = "Workflow is not running, make sure it is running in the war room!"
        Me.tsbtnAutoCallOff.Visible = False
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 35)
        Me.ToolStripSeparator9.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 32)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'CtrlLINTChatToolStripIndicator1
        '
        Me.CtrlLINTChatToolStripIndicator1.AutoSize = False
        Me.CtrlLINTChatToolStripIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlLINTChatToolStripIndicator1.Name = "CtrlLINTChatToolStripIndicator1"
        Me.CtrlLINTChatToolStripIndicator1.Size = New System.Drawing.Size(142, 32)
        Me.CtrlLINTChatToolStripIndicator1.Text = "CtrlLINTChatToolStripIndicator1"
        Me.CtrlLINTChatToolStripIndicator1.Visible = False
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 35)
        '
        'tssTotalSorted
        '
        Me.tssTotalSorted.AllowResizeOnHover = True
        Me.tssTotalSorted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssTotalSorted.Name = "tssTotalSorted"
        Me.tssTotalSorted.Size = New System.Drawing.Size(93, 30)
        Me.tssTotalSorted.Spring = True
        Me.tssTotalSorted.Text = "Total Sorted"
        Me.tssTotalSorted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 35)
        '
        'tssTotalWashed
        '
        Me.tssTotalWashed.AllowResizeOnHover = True
        Me.tssTotalWashed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tssTotalWashed.Name = "tssTotalWashed"
        Me.tssTotalWashed.Size = New System.Drawing.Size(101, 30)
        Me.tssTotalWashed.Spring = True
        Me.tssTotalWashed.Text = "Total Washed"
        Me.tssTotalWashed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 35)
        '
        'tssAvailableDryers
        '
        Me.tssAvailableDryers.AllowResizeOnHover = True
        Me.tssAvailableDryers.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tssAvailableDryers.Name = "tssAvailableDryers"
        Me.tssAvailableDryers.Size = New System.Drawing.Size(120, 30)
        Me.tssAvailableDryers.Spring = True
        Me.tssAvailableDryers.Text = "Available Dryers"
        Me.tssAvailableDryers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 35)
        '
        'tssClassifiedStorageBags
        '
        Me.tssClassifiedStorageBags.AllowResizeOnHover = True
        Me.tssClassifiedStorageBags.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tssClassifiedStorageBags.Name = "tssClassifiedStorageBags"
        Me.tssClassifiedStorageBags.Size = New System.Drawing.Size(164, 30)
        Me.tssClassifiedStorageBags.Text = "Classified Bags In Store"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 35)
        '
        'tssCleanStorageBags
        '
        Me.tssCleanStorageBags.AllowResizeOnHover = True
        Me.tssCleanStorageBags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssCleanStorageBags.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tssCleanStorageBags.Name = "tssCleanStorageBags"
        Me.tssCleanStorageBags.Size = New System.Drawing.Size(174, 60)
        Me.tssCleanStorageBags.Text = "Cleanwork Bags In Store"
        Me.tssCleanStorageBags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 65)
        '
        'tssAvailableWashers
        '
        Me.tssAvailableWashers.AllowResizeOnHover = True
        Me.tssAvailableWashers.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tssAvailableWashers.Name = "tssAvailableWashers"
        Me.tssAvailableWashers.Size = New System.Drawing.Size(133, 60)
        Me.tssAvailableWashers.Text = "Available Washers"
        Me.tssAvailableWashers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.ApplicationId = Wdw_Sust.Textile.Core.Enums.LintApplicationId.TSA_RAIL_SYSTEM
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 658)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.msMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsHealthMonitoringEnabled = True
        Me.MainMenuStrip = Me.msMain
        Me.Margin = New System.Windows.Forms.Padding(68, 68, 68, 68)
        Me.Name = "frmMain"
        Me.Text = "TSA Rail System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.msMain, 0)
        Me.Controls.SetChildIndex(Me.StatusStrip1, 0)
        Me.Controls.SetChildIndex(Me.tsMain, 0)
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategorySetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WashdeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlarmViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssActiveAlarms As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLoginStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLastAction As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsClassified As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsCleanwork As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAutoCallOff As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CleanworkProductivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeightCalibrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SortingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetProductivityCountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsgcClassifiedOngoing As CtrlOpcTsaRunDownButton
    Friend WithEvents tsgcClassifiedOffgoing As CtrlOpcTsaRunDownButton
    Friend WithEvents tsgcCleanworkOngoing As CtrlOpcTsaRunDownButton
    Friend WithEvents tsgcCleanworkOffgoing As CtrlOpcTsaRunDownButton
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WashdeckToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDataCollection As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CtrlLINTAlarmToolStripIndicator1 As CtrlLintAlarmToolStripIndicator
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CheckForUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataCollectionMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtrlLINTChatToolStripIndicator1 As CtrlLintChatToolStripIndicator
    Friend WithEvents tsgcAutoCallOffButtonT3 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT1 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT2 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT4 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT5 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT6 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT7 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsgcAutoCallOffButtonT8 As CtrlOpcTsaAutoCallOffButton
    Friend WithEvents tsbtnAutoCallOff As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsslShift As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents WorkflowSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CallOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunAutoCallOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShiftSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LastWorkflowCalculationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CastMemberShiftDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductDistributionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperatorLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryWorkflowParametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiagnosticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RFIDCommunicationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableExternalLoginValidationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RailSequenceEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssDataSource As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsMilnorComm As ToolStripLabel
    Friend WithEvents CtrlLINTAlarmToolStripIndicator2 As CtrlLintAlarmToolStripIndicator
    Friend WithEvents tssNumberOfFWTFLogin As ToolStripStatusLabel
    Friend WithEvents tssProgramMode As ToolStripStatusLabel
    Friend WithEvents tssVersion As ToolStripStatusLabel
    Friend WithEvents tssTotalSorted As Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel
    Friend WithEvents tssTotalWashed As Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel
    Friend WithEvents tssAvailableDryers As Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel
    Friend WithEvents tssAvailableWashers As Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel
    Friend WithEvents tssClassifiedStorageBags As Wdw_Sust.Textile.Global.WinForms.CtrlLintToolStripStatusLabel
    Friend WithEvents tssCleanStorageBags As Wdw_Sust.Textile.[Global].WinForms.CtrlLintToolStripStatusLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents Environment As ToolStripStatusLabel
    Friend WithEvents TableauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopToolStripMenuItem As ToolStripMenuItem
End Class
