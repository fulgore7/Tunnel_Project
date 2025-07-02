Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.WinForms.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintAlarmDetails
    Inherits CtrlFormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AlarmCriticalLabel As System.Windows.Forms.Label
        Dim AlarmDelayBeforeResendMessageLabel As System.Windows.Forms.Label
        Dim AlarmDepartmentLabel As System.Windows.Forms.Label
        Dim AlarmDescriptionLabel As System.Windows.Forms.Label
        Dim AlarmEnabledLabel As System.Windows.Forms.Label
        Dim AlarmFaultTypeLabel As System.Windows.Forms.Label
        Dim AlarmGlobalIDLabel As System.Windows.Forms.Label
        Dim AlarmHyperLinkLabel As System.Windows.Forms.Label
        Dim AlarmMachineLabel As System.Windows.Forms.Label
        Dim AlarmMessageTypeLabel As System.Windows.Forms.Label
        Dim AlarmOnStatusDeadbandLabel As System.Windows.Forms.Label
        Dim AlarmPlantLabel As System.Windows.Forms.Label
        Dim AlarmSourceIDLabel As System.Windows.Forms.Label
        Dim AlarmSystemLabel As System.Windows.Forms.Label
        Dim AlarmSystemComponentLabel As System.Windows.Forms.Label
        Dim AlarmWorkflowSystemDiagnosticsGroupLabel As System.Windows.Forms.Label
        Dim AlarmZoneLabel As System.Windows.Forms.Label
        Dim AlarmSeverityLevelLabel As System.Windows.Forms.Label
        Dim AlarmSystemIDLabel1 As System.Windows.Forms.Label
        Me.AlarmCriticalCheckBox = New System.Windows.Forms.CheckBox()
        Me.AlarmDelayBeforeResendMessageTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmDepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmEnabledCheckBox = New System.Windows.Forms.CheckBox()
        Me.AlarmFaultTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmGlobalIDTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmHyperLinkTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmMachineTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmMessageTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmOnStatusDeadbandTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmPlantTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmSourceIDComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmSystemComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmSystemComponentComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmWorkflowSystemDiagnosticsGroupTextBox = New System.Windows.Forms.TextBox()
        Me.AlarmZoneComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmSeverityLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.AlarmSystemIDTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.LINTAlarmParameterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTZoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTComponentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTMessageTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTAlarmSeverityTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTFaultTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LINTSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        AlarmCriticalLabel = New System.Windows.Forms.Label()
        AlarmDelayBeforeResendMessageLabel = New System.Windows.Forms.Label()
        AlarmDepartmentLabel = New System.Windows.Forms.Label()
        AlarmDescriptionLabel = New System.Windows.Forms.Label()
        AlarmEnabledLabel = New System.Windows.Forms.Label()
        AlarmFaultTypeLabel = New System.Windows.Forms.Label()
        AlarmGlobalIDLabel = New System.Windows.Forms.Label()
        AlarmHyperLinkLabel = New System.Windows.Forms.Label()
        AlarmMachineLabel = New System.Windows.Forms.Label()
        AlarmMessageTypeLabel = New System.Windows.Forms.Label()
        AlarmOnStatusDeadbandLabel = New System.Windows.Forms.Label()
        AlarmPlantLabel = New System.Windows.Forms.Label()
        AlarmSourceIDLabel = New System.Windows.Forms.Label()
        AlarmSystemLabel = New System.Windows.Forms.Label()
        AlarmSystemComponentLabel = New System.Windows.Forms.Label()
        AlarmWorkflowSystemDiagnosticsGroupLabel = New System.Windows.Forms.Label()
        AlarmZoneLabel = New System.Windows.Forms.Label()
        AlarmSeverityLevelLabel = New System.Windows.Forms.Label()
        AlarmSystemIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.LINTAlarmParameterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTZoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTComponentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTMessageTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTAlarmSeverityTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTFaultTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlarmCriticalLabel
        '
        AlarmCriticalLabel.AutoSize = True
        AlarmCriticalLabel.Location = New System.Drawing.Point(623, 39)
        AlarmCriticalLabel.Name = "AlarmCriticalLabel"
        AlarmCriticalLabel.Size = New System.Drawing.Size(70, 13)
        AlarmCriticalLabel.TabIndex = 1
        AlarmCriticalLabel.Text = "Alarm Critical:"
        '
        'AlarmDelayBeforeResendMessageLabel
        '
        AlarmDelayBeforeResendMessageLabel.AutoSize = True
        AlarmDelayBeforeResendMessageLabel.Location = New System.Drawing.Point(12, 243)
        AlarmDelayBeforeResendMessageLabel.Name = "AlarmDelayBeforeResendMessageLabel"
        AlarmDelayBeforeResendMessageLabel.Size = New System.Drawing.Size(186, 13)
        AlarmDelayBeforeResendMessageLabel.TabIndex = 3
        AlarmDelayBeforeResendMessageLabel.Text = "Alarm Delay Before Resend Message:"
        '
        'AlarmDepartmentLabel
        '
        AlarmDepartmentLabel.AutoSize = True
        AlarmDepartmentLabel.Location = New System.Drawing.Point(12, 137)
        AlarmDepartmentLabel.Name = "AlarmDepartmentLabel"
        AlarmDepartmentLabel.Size = New System.Drawing.Size(94, 13)
        AlarmDepartmentLabel.TabIndex = 5
        AlarmDepartmentLabel.Text = "Alarm Department:"
        '
        'AlarmDescriptionLabel
        '
        AlarmDescriptionLabel.AutoSize = True
        AlarmDescriptionLabel.Location = New System.Drawing.Point(12, 272)
        AlarmDescriptionLabel.Name = "AlarmDescriptionLabel"
        AlarmDescriptionLabel.Size = New System.Drawing.Size(92, 13)
        AlarmDescriptionLabel.TabIndex = 7
        AlarmDescriptionLabel.Text = "Alarm Description:"
        '
        'AlarmEnabledLabel
        '
        AlarmEnabledLabel.AutoSize = True
        AlarmEnabledLabel.Location = New System.Drawing.Point(623, 11)
        AlarmEnabledLabel.Name = "AlarmEnabledLabel"
        AlarmEnabledLabel.Size = New System.Drawing.Size(78, 13)
        AlarmEnabledLabel.TabIndex = 9
        AlarmEnabledLabel.Text = "Alarm Enabled:"
        '
        'AlarmFaultTypeLabel
        '
        AlarmFaultTypeLabel.AutoSize = True
        AlarmFaultTypeLabel.Location = New System.Drawing.Point(399, 167)
        AlarmFaultTypeLabel.Name = "AlarmFaultTypeLabel"
        AlarmFaultTypeLabel.Size = New System.Drawing.Size(89, 13)
        AlarmFaultTypeLabel.TabIndex = 11
        AlarmFaultTypeLabel.Text = "Alarm Fault Type:"
        '
        'AlarmGlobalIDLabel
        '
        AlarmGlobalIDLabel.AutoSize = True
        AlarmGlobalIDLabel.Location = New System.Drawing.Point(12, 33)
        AlarmGlobalIDLabel.Name = "AlarmGlobalIDLabel"
        AlarmGlobalIDLabel.Size = New System.Drawing.Size(83, 13)
        AlarmGlobalIDLabel.TabIndex = 13
        AlarmGlobalIDLabel.Text = "Alarm Global ID:"
        '
        'AlarmHyperLinkLabel
        '
        AlarmHyperLinkLabel.AutoSize = True
        AlarmHyperLinkLabel.Location = New System.Drawing.Point(12, 224)
        AlarmHyperLinkLabel.Name = "AlarmHyperLinkLabel"
        AlarmHyperLinkLabel.Size = New System.Drawing.Size(90, 13)
        AlarmHyperLinkLabel.TabIndex = 15
        AlarmHyperLinkLabel.Text = "Alarm Hyper Link:"
        '
        'AlarmMachineLabel
        '
        AlarmMachineLabel.AutoSize = True
        AlarmMachineLabel.Location = New System.Drawing.Point(12, 194)
        AlarmMachineLabel.Name = "AlarmMachineLabel"
        AlarmMachineLabel.Size = New System.Drawing.Size(80, 13)
        AlarmMachineLabel.TabIndex = 17
        AlarmMachineLabel.Text = "Alarm Machine:"
        '
        'AlarmMessageTypeLabel
        '
        AlarmMessageTypeLabel.AutoSize = True
        AlarmMessageTypeLabel.Location = New System.Drawing.Point(399, 81)
        AlarmMessageTypeLabel.Name = "AlarmMessageTypeLabel"
        AlarmMessageTypeLabel.Size = New System.Drawing.Size(109, 13)
        AlarmMessageTypeLabel.TabIndex = 19
        AlarmMessageTypeLabel.Text = "Alarm Message Type:"
        '
        'AlarmOnStatusDeadbandLabel
        '
        AlarmOnStatusDeadbandLabel.AutoSize = True
        AlarmOnStatusDeadbandLabel.Location = New System.Drawing.Point(308, 194)
        AlarmOnStatusDeadbandLabel.Name = "AlarmOnStatusDeadbandLabel"
        AlarmOnStatusDeadbandLabel.Size = New System.Drawing.Size(139, 13)
        AlarmOnStatusDeadbandLabel.TabIndex = 21
        AlarmOnStatusDeadbandLabel.Text = "Alarm On Status Deadband:"
        '
        'AlarmPlantLabel
        '
        AlarmPlantLabel.AutoSize = True
        AlarmPlantLabel.Location = New System.Drawing.Point(483, 33)
        AlarmPlantLabel.Name = "AlarmPlantLabel"
        AlarmPlantLabel.Size = New System.Drawing.Size(63, 13)
        AlarmPlantLabel.TabIndex = 23
        AlarmPlantLabel.Text = "Alarm Plant:"
        '
        'AlarmSourceIDLabel
        '
        AlarmSourceIDLabel.AutoSize = True
        AlarmSourceIDLabel.Location = New System.Drawing.Point(399, 137)
        AlarmSourceIDLabel.Name = "AlarmSourceIDLabel"
        AlarmSourceIDLabel.Size = New System.Drawing.Size(73, 13)
        AlarmSourceIDLabel.TabIndex = 27
        AlarmSourceIDLabel.Text = "Alarm Source:"
        '
        'AlarmSystemLabel
        '
        AlarmSystemLabel.AutoSize = True
        AlarmSystemLabel.Location = New System.Drawing.Point(12, 81)
        AlarmSystemLabel.Name = "AlarmSystemLabel"
        AlarmSystemLabel.Size = New System.Drawing.Size(73, 13)
        AlarmSystemLabel.TabIndex = 29
        AlarmSystemLabel.Text = "Alarm System:"
        '
        'AlarmSystemComponentLabel
        '
        AlarmSystemComponentLabel.AutoSize = True
        AlarmSystemComponentLabel.Location = New System.Drawing.Point(12, 109)
        AlarmSystemComponentLabel.Name = "AlarmSystemComponentLabel"
        AlarmSystemComponentLabel.Size = New System.Drawing.Size(130, 13)
        AlarmSystemComponentLabel.TabIndex = 31
        AlarmSystemComponentLabel.Text = "Alarm System Component:"
        '
        'AlarmWorkflowSystemDiagnosticsGroupLabel
        '
        AlarmWorkflowSystemDiagnosticsGroupLabel.AutoSize = True
        AlarmWorkflowSystemDiagnosticsGroupLabel.Location = New System.Drawing.Point(520, 194)
        AlarmWorkflowSystemDiagnosticsGroupLabel.Name = "AlarmWorkflowSystemDiagnosticsGroupLabel"
        AlarmWorkflowSystemDiagnosticsGroupLabel.Size = New System.Drawing.Size(174, 13)
        AlarmWorkflowSystemDiagnosticsGroupLabel.TabIndex = 35
        AlarmWorkflowSystemDiagnosticsGroupLabel.Text = "Alarm Workflow Diagnostics Group:"
        '
        'AlarmZoneLabel
        '
        AlarmZoneLabel.AutoSize = True
        AlarmZoneLabel.Location = New System.Drawing.Point(12, 167)
        AlarmZoneLabel.Name = "AlarmZoneLabel"
        AlarmZoneLabel.Size = New System.Drawing.Size(64, 13)
        AlarmZoneLabel.TabIndex = 37
        AlarmZoneLabel.Text = "Alarm Zone:"
        '
        'AlarmSeverityLevelLabel
        '
        AlarmSeverityLevelLabel.AutoSize = True
        AlarmSeverityLevelLabel.Location = New System.Drawing.Point(399, 109)
        AlarmSeverityLevelLabel.Name = "AlarmSeverityLevelLabel"
        AlarmSeverityLevelLabel.Size = New System.Drawing.Size(106, 13)
        AlarmSeverityLevelLabel.TabIndex = 39
        AlarmSeverityLevelLabel.Text = "Alarm Severity Level:"
        '
        'AlarmSystemIDLabel1
        '
        AlarmSystemIDLabel1.AutoSize = True
        AlarmSystemIDLabel1.Location = New System.Drawing.Point(284, 33)
        AlarmSystemIDLabel1.Name = "AlarmSystemIDLabel1"
        AlarmSystemIDLabel1.Size = New System.Drawing.Size(87, 13)
        AlarmSystemIDLabel1.TabIndex = 40
        AlarmSystemIDLabel1.Text = "Alarm System ID:"
        '
        'AlarmCriticalCheckBox
        '
        Me.AlarmCriticalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTAlarmParameterBindingSource, "AlarmCritical", True))
        Me.AlarmCriticalCheckBox.Location = New System.Drawing.Point(707, 34)
        Me.AlarmCriticalCheckBox.Name = "AlarmCriticalCheckBox"
        Me.AlarmCriticalCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.AlarmCriticalCheckBox.TabIndex = 2
        Me.AlarmCriticalCheckBox.UseVisualStyleBackColor = True
        '
        'AlarmDelayBeforeResendMessageTextBox
        '
        Me.AlarmDelayBeforeResendMessageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmDelayBeforeResendMessage", True))
        Me.AlarmDelayBeforeResendMessageTextBox.Location = New System.Drawing.Point(204, 243)
        Me.AlarmDelayBeforeResendMessageTextBox.Name = "AlarmDelayBeforeResendMessageTextBox"
        Me.AlarmDelayBeforeResendMessageTextBox.Size = New System.Drawing.Size(544, 20)
        Me.AlarmDelayBeforeResendMessageTextBox.TabIndex = 4
        '
        'AlarmDepartmentComboBox
        '
        Me.AlarmDepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmDepartment", True))
        Me.AlarmDepartmentComboBox.DataSource = Me.LINTDepartmentBindingSource
        Me.AlarmDepartmentComboBox.DisplayMember = "Name"
        Me.AlarmDepartmentComboBox.FormattingEnabled = True
        Me.AlarmDepartmentComboBox.Location = New System.Drawing.Point(181, 134)
        Me.AlarmDepartmentComboBox.Name = "AlarmDepartmentComboBox"
        Me.AlarmDepartmentComboBox.Size = New System.Drawing.Size(190, 21)
        Me.AlarmDepartmentComboBox.TabIndex = 6
        Me.AlarmDepartmentComboBox.ValueMember = "ID"
        '
        'AlarmDescriptionTextBox
        '
        Me.AlarmDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmDescription", True))
        Me.AlarmDescriptionTextBox.Location = New System.Drawing.Point(204, 269)
        Me.AlarmDescriptionTextBox.Multiline = True
        Me.AlarmDescriptionTextBox.Name = "AlarmDescriptionTextBox"
        Me.AlarmDescriptionTextBox.Size = New System.Drawing.Size(544, 71)
        Me.AlarmDescriptionTextBox.TabIndex = 8
        '
        'AlarmEnabledCheckBox
        '
        Me.AlarmEnabledCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTAlarmParameterBindingSource, "AlarmEnabled", True))
        Me.AlarmEnabledCheckBox.Location = New System.Drawing.Point(707, 6)
        Me.AlarmEnabledCheckBox.Name = "AlarmEnabledCheckBox"
        Me.AlarmEnabledCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.AlarmEnabledCheckBox.TabIndex = 10
        Me.AlarmEnabledCheckBox.UseVisualStyleBackColor = True
        '
        'AlarmFaultTypeComboBox
        '
        Me.AlarmFaultTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmFaultType", True))
        Me.AlarmFaultTypeComboBox.DataSource = Me.LINTFaultTypeBindingSource
        Me.AlarmFaultTypeComboBox.DisplayMember = "Name"
        Me.AlarmFaultTypeComboBox.FormattingEnabled = True
        Me.AlarmFaultTypeComboBox.Location = New System.Drawing.Point(559, 164)
        Me.AlarmFaultTypeComboBox.Name = "AlarmFaultTypeComboBox"
        Me.AlarmFaultTypeComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AlarmFaultTypeComboBox.TabIndex = 12
        Me.AlarmFaultTypeComboBox.ValueMember = "ID"
        '
        'AlarmGlobalIDTextBox
        '
        Me.AlarmGlobalIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmGlobalID", True))
        Me.AlarmGlobalIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmGlobalIDTextBox.Location = New System.Drawing.Point(111, 21)
        Me.AlarmGlobalIDTextBox.Name = "AlarmGlobalIDTextBox"
        Me.AlarmGlobalIDTextBox.ReadOnly = True
        Me.AlarmGlobalIDTextBox.Size = New System.Drawing.Size(157, 31)
        Me.AlarmGlobalIDTextBox.TabIndex = 14
        '
        'AlarmHyperLinkTextBox
        '
        Me.AlarmHyperLinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmHyperLink", True))
        Me.AlarmHyperLinkTextBox.Location = New System.Drawing.Point(181, 217)
        Me.AlarmHyperLinkTextBox.Name = "AlarmHyperLinkTextBox"
        Me.AlarmHyperLinkTextBox.Size = New System.Drawing.Size(567, 20)
        Me.AlarmHyperLinkTextBox.TabIndex = 16
        '
        'AlarmMachineTextBox
        '
        Me.AlarmMachineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmMachine", True))
        Me.AlarmMachineTextBox.Location = New System.Drawing.Point(181, 191)
        Me.AlarmMachineTextBox.Name = "AlarmMachineTextBox"
        Me.AlarmMachineTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AlarmMachineTextBox.TabIndex = 18
        '
        'AlarmMessageTypeComboBox
        '
        Me.AlarmMessageTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmMessageType", True))
        Me.AlarmMessageTypeComboBox.DataSource = Me.LINTMessageTypeBindingSource
        Me.AlarmMessageTypeComboBox.DisplayMember = "Name"
        Me.AlarmMessageTypeComboBox.FormattingEnabled = True
        Me.AlarmMessageTypeComboBox.Location = New System.Drawing.Point(559, 78)
        Me.AlarmMessageTypeComboBox.Name = "AlarmMessageTypeComboBox"
        Me.AlarmMessageTypeComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AlarmMessageTypeComboBox.TabIndex = 20
        Me.AlarmMessageTypeComboBox.ValueMember = "ID"
        '
        'AlarmOnStatusDeadbandTextBox
        '
        Me.AlarmOnStatusDeadbandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmOnStatusDeadband", True))
        Me.AlarmOnStatusDeadbandTextBox.Location = New System.Drawing.Point(453, 189)
        Me.AlarmOnStatusDeadbandTextBox.Name = "AlarmOnStatusDeadbandTextBox"
        Me.AlarmOnStatusDeadbandTextBox.Size = New System.Drawing.Size(58, 20)
        Me.AlarmOnStatusDeadbandTextBox.TabIndex = 22
        '
        'AlarmPlantTextBox
        '
        Me.AlarmPlantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmPlant", True))
        Me.AlarmPlantTextBox.Location = New System.Drawing.Point(552, 30)
        Me.AlarmPlantTextBox.Name = "AlarmPlantTextBox"
        Me.AlarmPlantTextBox.Size = New System.Drawing.Size(62, 20)
        Me.AlarmPlantTextBox.TabIndex = 24
        '
        'AlarmSourceIDComboBox
        '
        Me.AlarmSourceIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmSourceID", True))
        Me.AlarmSourceIDComboBox.DataSource = Me.LINTSourceBindingSource
        Me.AlarmSourceIDComboBox.DisplayMember = "Name"
        Me.AlarmSourceIDComboBox.FormattingEnabled = True
        Me.AlarmSourceIDComboBox.Location = New System.Drawing.Point(559, 134)
        Me.AlarmSourceIDComboBox.Name = "AlarmSourceIDComboBox"
        Me.AlarmSourceIDComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AlarmSourceIDComboBox.TabIndex = 28
        Me.AlarmSourceIDComboBox.ValueMember = "ID"
        '
        'AlarmSystemComboBox
        '
        Me.AlarmSystemComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmSystem", True))
        Me.AlarmSystemComboBox.DataSource = Me.LINTSystemBindingSource
        Me.AlarmSystemComboBox.DisplayMember = "Name"
        Me.AlarmSystemComboBox.FormattingEnabled = True
        Me.AlarmSystemComboBox.Location = New System.Drawing.Point(181, 78)
        Me.AlarmSystemComboBox.Name = "AlarmSystemComboBox"
        Me.AlarmSystemComboBox.Size = New System.Drawing.Size(190, 21)
        Me.AlarmSystemComboBox.TabIndex = 30
        Me.AlarmSystemComboBox.ValueMember = "ID"
        '
        'AlarmSystemComponentComboBox
        '
        Me.AlarmSystemComponentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmSystemComponent", True))
        Me.AlarmSystemComponentComboBox.DataSource = Me.LINTComponentBindingSource
        Me.AlarmSystemComponentComboBox.DisplayMember = "Name"
        Me.AlarmSystemComponentComboBox.FormattingEnabled = True
        Me.AlarmSystemComponentComboBox.Location = New System.Drawing.Point(181, 106)
        Me.AlarmSystemComponentComboBox.Name = "AlarmSystemComponentComboBox"
        Me.AlarmSystemComponentComboBox.Size = New System.Drawing.Size(190, 21)
        Me.AlarmSystemComponentComboBox.TabIndex = 32
        Me.AlarmSystemComponentComboBox.ValueMember = "ID"
        '
        'AlarmWorkflowSystemDiagnosticsGroupTextBox
        '
        Me.AlarmWorkflowSystemDiagnosticsGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmWorkflowSystemDiagnosticsGroup", True))
        Me.AlarmWorkflowSystemDiagnosticsGroupTextBox.Location = New System.Drawing.Point(700, 191)
        Me.AlarmWorkflowSystemDiagnosticsGroupTextBox.Name = "AlarmWorkflowSystemDiagnosticsGroupTextBox"
        Me.AlarmWorkflowSystemDiagnosticsGroupTextBox.Size = New System.Drawing.Size(48, 20)
        Me.AlarmWorkflowSystemDiagnosticsGroupTextBox.TabIndex = 36
        '
        'AlarmZoneComboBox
        '
        Me.AlarmZoneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmZone", True))
        Me.AlarmZoneComboBox.DataSource = Me.LINTZoneBindingSource
        Me.AlarmZoneComboBox.DisplayMember = "Name"
        Me.AlarmZoneComboBox.FormattingEnabled = True
        Me.AlarmZoneComboBox.Location = New System.Drawing.Point(181, 164)
        Me.AlarmZoneComboBox.Name = "AlarmZoneComboBox"
        Me.AlarmZoneComboBox.Size = New System.Drawing.Size(190, 21)
        Me.AlarmZoneComboBox.TabIndex = 38
        Me.AlarmZoneComboBox.ValueMember = "ID"
        '
        'AlarmSeverityLevelComboBox
        '
        Me.AlarmSeverityLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTAlarmParameterBindingSource, "AlarmSeverityLevel", True))
        Me.AlarmSeverityLevelComboBox.DataSource = Me.LINTAlarmSeverityTypeBindingSource
        Me.AlarmSeverityLevelComboBox.DisplayMember = "Name"
        Me.AlarmSeverityLevelComboBox.FormattingEnabled = True
        Me.AlarmSeverityLevelComboBox.Location = New System.Drawing.Point(559, 106)
        Me.AlarmSeverityLevelComboBox.Name = "AlarmSeverityLevelComboBox"
        Me.AlarmSeverityLevelComboBox.Size = New System.Drawing.Size(189, 21)
        Me.AlarmSeverityLevelComboBox.TabIndex = 40
        Me.AlarmSeverityLevelComboBox.ValueMember = "ID"
        '
        'AlarmSystemIDTextBox
        '
        Me.AlarmSystemIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTAlarmParameterBindingSource, "AlarmSystemID", True))
        Me.AlarmSystemIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmSystemIDTextBox.Location = New System.Drawing.Point(377, 21)
        Me.AlarmSystemIDTextBox.Name = "AlarmSystemIDTextBox"
        Me.AlarmSystemIDTextBox.Size = New System.Drawing.Size(100, 31)
        Me.AlarmSystemIDTextBox.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(27, 317)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LINTAlarmParameterBindingSource
        '
        Me.LINTAlarmParameterBindingSource.DataSource = GetType(LintAlarmParameter)
        '
        'LINTSystemBindingSource
        '
        Me.LINTSystemBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTZoneBindingSource
        '
        Me.LINTZoneBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTDepartmentBindingSource
        '
        Me.LINTDepartmentBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTComponentBindingSource
        '
        Me.LINTComponentBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTMessageTypeBindingSource
        '
        Me.LINTMessageTypeBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTAlarmSeverityTypeBindingSource
        '
        Me.LINTAlarmSeverityTypeBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTFaultTypeBindingSource
        '
        Me.LINTFaultTypeBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'LINTSourceBindingSource
        '
        Me.LINTSourceBindingSource.DataSource = GetType(LintNameValuePair)
        '
        'CtrlLINTAlarmDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 354)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(AlarmSystemIDLabel1)
        Me.Controls.Add(Me.AlarmSystemIDTextBox)
        Me.Controls.Add(AlarmSeverityLevelLabel)
        Me.Controls.Add(Me.AlarmSeverityLevelComboBox)
        Me.Controls.Add(AlarmCriticalLabel)
        Me.Controls.Add(Me.AlarmCriticalCheckBox)
        Me.Controls.Add(AlarmDelayBeforeResendMessageLabel)
        Me.Controls.Add(Me.AlarmDelayBeforeResendMessageTextBox)
        Me.Controls.Add(AlarmDepartmentLabel)
        Me.Controls.Add(Me.AlarmDepartmentComboBox)
        Me.Controls.Add(AlarmDescriptionLabel)
        Me.Controls.Add(Me.AlarmDescriptionTextBox)
        Me.Controls.Add(AlarmEnabledLabel)
        Me.Controls.Add(Me.AlarmEnabledCheckBox)
        Me.Controls.Add(AlarmFaultTypeLabel)
        Me.Controls.Add(Me.AlarmFaultTypeComboBox)
        Me.Controls.Add(AlarmGlobalIDLabel)
        Me.Controls.Add(Me.AlarmGlobalIDTextBox)
        Me.Controls.Add(AlarmHyperLinkLabel)
        Me.Controls.Add(Me.AlarmHyperLinkTextBox)
        Me.Controls.Add(AlarmMachineLabel)
        Me.Controls.Add(Me.AlarmMachineTextBox)
        Me.Controls.Add(AlarmMessageTypeLabel)
        Me.Controls.Add(Me.AlarmMessageTypeComboBox)
        Me.Controls.Add(AlarmOnStatusDeadbandLabel)
        Me.Controls.Add(Me.AlarmOnStatusDeadbandTextBox)
        Me.Controls.Add(AlarmPlantLabel)
        Me.Controls.Add(Me.AlarmPlantTextBox)
        Me.Controls.Add(AlarmSourceIDLabel)
        Me.Controls.Add(Me.AlarmSourceIDComboBox)
        Me.Controls.Add(AlarmSystemLabel)
        Me.Controls.Add(Me.AlarmSystemComboBox)
        Me.Controls.Add(AlarmSystemComponentLabel)
        Me.Controls.Add(Me.AlarmSystemComponentComboBox)
        Me.Controls.Add(AlarmWorkflowSystemDiagnosticsGroupLabel)
        Me.Controls.Add(Me.AlarmWorkflowSystemDiagnosticsGroupTextBox)
        Me.Controls.Add(AlarmZoneLabel)
        Me.Controls.Add(Me.AlarmZoneComboBox)
        Me.Name = "CtrlLINTAlarmDetail"
        Me.Text = "Alarm Details"
        CType(Me.LINTAlarmParameterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTZoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTComponentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTMessageTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTAlarmSeverityTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTFaultTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LINTAlarmParameterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlarmCriticalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AlarmDelayBeforeResendMessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmDepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmEnabledCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AlarmFaultTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmGlobalIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmHyperLinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmMachineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmMessageTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmOnStatusDeadbandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmPlantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmSourceIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmSystemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmSystemComponentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmWorkflowSystemDiagnosticsGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlarmZoneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmSeverityLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlarmSystemIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents LINTSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTZoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTAlarmSeverityTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTFaultTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTMessageTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTComponentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlarmSourceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
End Class

