
Imports Wdw_Sust.Textile.Core

Namespace Core
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CtrlRailSequenceInfoEditBase

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
            Dim CanEditByAdminLabel As System.Windows.Forms.Label
            Dim CanEditByAreaSupervisorLabel As System.Windows.Forms.Label
            Dim CanEditByEngineeringCraftSupportLabel As System.Windows.Forms.Label
            Dim CanEditByEngineeringFormanLabel As System.Windows.Forms.Label
            Dim CanEditByEngineeringLSMLabel As System.Windows.Forms.Label
            Dim CanEditByEngineeringLSMJrLabel As System.Windows.Forms.Label
            Dim CanEditByEngineeringManagerLabel As System.Windows.Forms.Label
            Dim CanEditByOperationsManagerLabel As System.Windows.Forms.Label
            Dim CanEditByOutsideVendorLabel As System.Windows.Forms.Label
            Dim CanEditByPlantManagerLabel As System.Windows.Forms.Label
            Dim CanEditByProductionManagerLabel As System.Windows.Forms.Label
            Dim CanEditByProductionOperatorLabel As System.Windows.Forms.Label
            Dim CanEditBySystemsOperatorLabel As System.Windows.Forms.Label
            Dim CanEditBySystemsOperatorSrLabel As System.Windows.Forms.Label
            Dim CanEditBySystemSupportLabel As System.Windows.Forms.Label
            Dim DescriptionLabel As System.Windows.Forms.Label
            Dim IsActiveLabel As System.Windows.Forms.Label
            Dim StepNumberLabel As System.Windows.Forms.Label
            Dim RolesToModifySequenceLabel As System.Windows.Forms.Label
            Dim RolesToModifySequenceLabel2 As System.Windows.Forms.Label
            Me.CanEditByAdminCheckBox = New System.Windows.Forms.CheckBox()
            Me.LINTRailSequenceStepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CanEditByAreaSupervisorCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByEngineeringCraftSupportCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByEngineeringFormanCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByEngineeringLSMCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByEngineeringLSMJrCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByEngineeringManagerCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByOperationsManagerCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByOutsideVendorCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByPlantManagerCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByProductionManagerCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditByProductionOperatorCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditBySystemsOperatorCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditBySystemsOperatorSrCheckBox = New System.Windows.Forms.CheckBox()
            Me.CanEditBySystemSupportCheckBox = New System.Windows.Forms.CheckBox()
            Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
            Me.IsActiveCheckBox = New System.Windows.Forms.CheckBox()
            Me.StepNumberTextBox = New System.Windows.Forms.TextBox()
            Me.RolesToModifySequenceLabel1 = New System.Windows.Forms.Label()
            Me.RolesToModifySequenceTextBox = New System.Windows.Forms.TextBox()
            Me.gbRoleEdit = New System.Windows.Forms.GroupBox()
            Me.ListBox1 = New System.Windows.Forms.ListBox()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            CanEditByAdminLabel = New System.Windows.Forms.Label()
            CanEditByAreaSupervisorLabel = New System.Windows.Forms.Label()
            CanEditByEngineeringCraftSupportLabel = New System.Windows.Forms.Label()
            CanEditByEngineeringFormanLabel = New System.Windows.Forms.Label()
            CanEditByEngineeringLSMLabel = New System.Windows.Forms.Label()
            CanEditByEngineeringLSMJrLabel = New System.Windows.Forms.Label()
            CanEditByEngineeringManagerLabel = New System.Windows.Forms.Label()
            CanEditByOperationsManagerLabel = New System.Windows.Forms.Label()
            CanEditByOutsideVendorLabel = New System.Windows.Forms.Label()
            CanEditByPlantManagerLabel = New System.Windows.Forms.Label()
            CanEditByProductionManagerLabel = New System.Windows.Forms.Label()
            CanEditByProductionOperatorLabel = New System.Windows.Forms.Label()
            CanEditBySystemsOperatorLabel = New System.Windows.Forms.Label()
            CanEditBySystemsOperatorSrLabel = New System.Windows.Forms.Label()
            CanEditBySystemSupportLabel = New System.Windows.Forms.Label()
            DescriptionLabel = New System.Windows.Forms.Label()
            IsActiveLabel = New System.Windows.Forms.Label()
            StepNumberLabel = New System.Windows.Forms.Label()
            RolesToModifySequenceLabel = New System.Windows.Forms.Label()
            RolesToModifySequenceLabel2 = New System.Windows.Forms.Label()
            CType(Me.LINTRailSequenceStepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRoleEdit.SuspendLayout()
            Me.SuspendLayout()
            '
            'CanEditByAdminLabel
            '
            CanEditByAdminLabel.AutoSize = True
            CanEditByAdminLabel.Location = New System.Drawing.Point(183, 25)
            CanEditByAdminLabel.Name = "CanEditByAdminLabel"
            CanEditByAdminLabel.Size = New System.Drawing.Size(70, 13)
            CanEditByAdminLabel.TabIndex = 1
            CanEditByAdminLabel.Text = "Administrator:"
            '
            'CanEditByAreaSupervisorLabel
            '
            CanEditByAreaSupervisorLabel.AutoSize = True
            CanEditByAreaSupervisorLabel.Location = New System.Drawing.Point(183, 55)
            CanEditByAreaSupervisorLabel.Name = "CanEditByAreaSupervisorLabel"
            CanEditByAreaSupervisorLabel.Size = New System.Drawing.Size(85, 13)
            CanEditByAreaSupervisorLabel.TabIndex = 3
            CanEditByAreaSupervisorLabel.Text = "Area Supervisor:"
            '
            'CanEditByEngineeringCraftSupportLabel
            '
            CanEditByEngineeringCraftSupportLabel.AutoSize = True
            CanEditByEngineeringCraftSupportLabel.Location = New System.Drawing.Point(183, 85)
            CanEditByEngineeringCraftSupportLabel.Name = "CanEditByEngineeringCraftSupportLabel"
            CanEditByEngineeringCraftSupportLabel.Size = New System.Drawing.Size(131, 13)
            CanEditByEngineeringCraftSupportLabel.TabIndex = 5
            CanEditByEngineeringCraftSupportLabel.Text = "Engineering Craft Support:"
            '
            'CanEditByEngineeringFormanLabel
            '
            CanEditByEngineeringFormanLabel.AutoSize = True
            CanEditByEngineeringFormanLabel.Location = New System.Drawing.Point(183, 115)
            CanEditByEngineeringFormanLabel.Name = "CanEditByEngineeringFormanLabel"
            CanEditByEngineeringFormanLabel.Size = New System.Drawing.Size(104, 13)
            CanEditByEngineeringFormanLabel.TabIndex = 7
            CanEditByEngineeringFormanLabel.Text = "Engineering Forman:"
            '
            'CanEditByEngineeringLSMLabel
            '
            CanEditByEngineeringLSMLabel.AutoSize = True
            CanEditByEngineeringLSMLabel.Location = New System.Drawing.Point(367, 25)
            CanEditByEngineeringLSMLabel.Name = "CanEditByEngineeringLSMLabel"
            CanEditByEngineeringLSMLabel.Size = New System.Drawing.Size(91, 13)
            CanEditByEngineeringLSMLabel.TabIndex = 9
            CanEditByEngineeringLSMLabel.Text = "Engineering LSM:"
            '
            'CanEditByEngineeringLSMJrLabel
            '
            CanEditByEngineeringLSMJrLabel.AutoSize = True
            CanEditByEngineeringLSMJrLabel.Location = New System.Drawing.Point(367, 55)
            CanEditByEngineeringLSMJrLabel.Name = "CanEditByEngineeringLSMJrLabel"
            CanEditByEngineeringLSMJrLabel.Size = New System.Drawing.Size(102, 13)
            CanEditByEngineeringLSMJrLabel.TabIndex = 11
            CanEditByEngineeringLSMJrLabel.Text = "Engineering LSM Jr:"
            '
            'CanEditByEngineeringManagerLabel
            '
            CanEditByEngineeringManagerLabel.AutoSize = True
            CanEditByEngineeringManagerLabel.Location = New System.Drawing.Point(367, 85)
            CanEditByEngineeringManagerLabel.Name = "CanEditByEngineeringManagerLabel"
            CanEditByEngineeringManagerLabel.Size = New System.Drawing.Size(111, 13)
            CanEditByEngineeringManagerLabel.TabIndex = 13
            CanEditByEngineeringManagerLabel.Text = "Engineering Manager:"
            '
            'CanEditByOperationsManagerLabel
            '
            CanEditByOperationsManagerLabel.AutoSize = True
            CanEditByOperationsManagerLabel.Location = New System.Drawing.Point(24, 25)
            CanEditByOperationsManagerLabel.Name = "CanEditByOperationsManagerLabel"
            CanEditByOperationsManagerLabel.Size = New System.Drawing.Size(106, 13)
            CanEditByOperationsManagerLabel.TabIndex = 15
            CanEditByOperationsManagerLabel.Text = "Operations Manager:"
            '
            'CanEditByOutsideVendorLabel
            '
            CanEditByOutsideVendorLabel.AutoSize = True
            CanEditByOutsideVendorLabel.Location = New System.Drawing.Point(24, 55)
            CanEditByOutsideVendorLabel.Name = "CanEditByOutsideVendorLabel"
            CanEditByOutsideVendorLabel.Size = New System.Drawing.Size(83, 13)
            CanEditByOutsideVendorLabel.TabIndex = 17
            CanEditByOutsideVendorLabel.Text = "Outside Vendor:"
            '
            'CanEditByPlantManagerLabel
            '
            CanEditByPlantManagerLabel.AutoSize = True
            CanEditByPlantManagerLabel.Location = New System.Drawing.Point(24, 85)
            CanEditByPlantManagerLabel.Name = "CanEditByPlantManagerLabel"
            CanEditByPlantManagerLabel.Size = New System.Drawing.Size(79, 13)
            CanEditByPlantManagerLabel.TabIndex = 19
            CanEditByPlantManagerLabel.Text = "Plant Manager:"
            '
            'CanEditByProductionManagerLabel
            '
            CanEditByProductionManagerLabel.AutoSize = True
            CanEditByProductionManagerLabel.Location = New System.Drawing.Point(24, 115)
            CanEditByProductionManagerLabel.Name = "CanEditByProductionManagerLabel"
            CanEditByProductionManagerLabel.Size = New System.Drawing.Size(106, 13)
            CanEditByProductionManagerLabel.TabIndex = 21
            CanEditByProductionManagerLabel.Text = "Production Manager:"
            '
            'CanEditByProductionOperatorLabel
            '
            CanEditByProductionOperatorLabel.AutoSize = True
            CanEditByProductionOperatorLabel.Location = New System.Drawing.Point(367, 115)
            CanEditByProductionOperatorLabel.Name = "CanEditByProductionOperatorLabel"
            CanEditByProductionOperatorLabel.Size = New System.Drawing.Size(105, 13)
            CanEditByProductionOperatorLabel.TabIndex = 23
            CanEditByProductionOperatorLabel.Text = "Production Operator:"
            '
            'CanEditBySystemsOperatorLabel
            '
            CanEditBySystemsOperatorLabel.AutoSize = True
            CanEditBySystemsOperatorLabel.Location = New System.Drawing.Point(533, 25)
            CanEditBySystemsOperatorLabel.Name = "CanEditBySystemsOperatorLabel"
            CanEditBySystemsOperatorLabel.Size = New System.Drawing.Size(93, 13)
            CanEditBySystemsOperatorLabel.TabIndex = 25
            CanEditBySystemsOperatorLabel.Text = "Systems Operator:"
            '
            'CanEditBySystemsOperatorSrLabel
            '
            CanEditBySystemsOperatorSrLabel.AutoSize = True
            CanEditBySystemsOperatorSrLabel.Location = New System.Drawing.Point(533, 55)
            CanEditBySystemsOperatorSrLabel.Name = "CanEditBySystemsOperatorSrLabel"
            CanEditBySystemsOperatorSrLabel.Size = New System.Drawing.Size(106, 13)
            CanEditBySystemsOperatorSrLabel.TabIndex = 27
            CanEditBySystemsOperatorSrLabel.Text = "Systems Operator Sr:"
            '
            'CanEditBySystemSupportLabel
            '
            CanEditBySystemSupportLabel.AutoSize = True
            CanEditBySystemSupportLabel.Location = New System.Drawing.Point(533, 85)
            CanEditBySystemSupportLabel.Name = "CanEditBySystemSupportLabel"
            CanEditBySystemSupportLabel.Size = New System.Drawing.Size(84, 13)
            CanEditBySystemSupportLabel.TabIndex = 29
            CanEditBySystemSupportLabel.Text = "System Support:"
            '
            'DescriptionLabel
            '
            DescriptionLabel.AutoSize = True
            DescriptionLabel.Location = New System.Drawing.Point(15, 303)
            DescriptionLabel.Name = "DescriptionLabel"
            DescriptionLabel.Size = New System.Drawing.Size(63, 13)
            DescriptionLabel.TabIndex = 31
            DescriptionLabel.Text = "Description:"
            '
            'IsActiveLabel
            '
            IsActiveLabel.AutoSize = True
            IsActiveLabel.Location = New System.Drawing.Point(616, 305)
            IsActiveLabel.Name = "IsActiveLabel"
            IsActiveLabel.Size = New System.Drawing.Size(51, 13)
            IsActiveLabel.TabIndex = 33
            IsActiveLabel.Text = "Is Active:"
            '
            'StepNumberLabel
            '
            StepNumberLabel.AutoSize = True
            StepNumberLabel.Location = New System.Drawing.Point(493, 303)
            StepNumberLabel.Name = "StepNumberLabel"
            StepNumberLabel.Size = New System.Drawing.Size(72, 13)
            StepNumberLabel.TabIndex = 41
            StepNumberLabel.Text = "Step Number:"
            '
            'RolesToModifySequenceLabel
            '
            RolesToModifySequenceLabel.AutoSize = True
            RolesToModifySequenceLabel.Location = New System.Drawing.Point(9, 485)
            RolesToModifySequenceLabel.Name = "RolesToModifySequenceLabel"
            RolesToModifySequenceLabel.Size = New System.Drawing.Size(139, 13)
            RolesToModifySequenceLabel.TabIndex = 42
            RolesToModifySequenceLabel.Text = "Roles To Modify Sequence:"
            '
            'RolesToModifySequenceLabel2
            '
            RolesToModifySequenceLabel2.AutoSize = True
            RolesToModifySequenceLabel2.Location = New System.Drawing.Point(195, 485)
            RolesToModifySequenceLabel2.Name = "RolesToModifySequenceLabel2"
            RolesToModifySequenceLabel2.Size = New System.Drawing.Size(139, 13)
            RolesToModifySequenceLabel2.TabIndex = 43
            RolesToModifySequenceLabel2.Text = "Roles To Modify Sequence:"
            '
            'CanEditByAdminCheckBox
            '
            Me.CanEditByAdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByAdmin", True))
            Me.CanEditByAdminCheckBox.Location = New System.Drawing.Point(337, 20)
            Me.CanEditByAdminCheckBox.Name = "CanEditByAdminCheckBox"
            Me.CanEditByAdminCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByAdminCheckBox.TabIndex = 2
            Me.CanEditByAdminCheckBox.UseVisualStyleBackColor = True
            '
            'LINTRailSequenceStepBindingSource
            '
            Me.LINTRailSequenceStepBindingSource.DataSource = GetType(Wdw_Sust.Textile.Core.LintRailSequenceStep)
            '
            'CanEditByAreaSupervisorCheckBox
            '
            Me.CanEditByAreaSupervisorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByAreaSupervisor", True))
            Me.CanEditByAreaSupervisorCheckBox.Location = New System.Drawing.Point(337, 50)
            Me.CanEditByAreaSupervisorCheckBox.Name = "CanEditByAreaSupervisorCheckBox"
            Me.CanEditByAreaSupervisorCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByAreaSupervisorCheckBox.TabIndex = 4
            Me.CanEditByAreaSupervisorCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByEngineeringCraftSupportCheckBox
            '
            Me.CanEditByEngineeringCraftSupportCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByEngineeringCraftSupport", True))
            Me.CanEditByEngineeringCraftSupportCheckBox.Location = New System.Drawing.Point(337, 80)
            Me.CanEditByEngineeringCraftSupportCheckBox.Name = "CanEditByEngineeringCraftSupportCheckBox"
            Me.CanEditByEngineeringCraftSupportCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByEngineeringCraftSupportCheckBox.TabIndex = 6
            Me.CanEditByEngineeringCraftSupportCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByEngineeringFormanCheckBox
            '
            Me.CanEditByEngineeringFormanCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByEngineeringForman", True))
            Me.CanEditByEngineeringFormanCheckBox.Location = New System.Drawing.Point(337, 110)
            Me.CanEditByEngineeringFormanCheckBox.Name = "CanEditByEngineeringFormanCheckBox"
            Me.CanEditByEngineeringFormanCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByEngineeringFormanCheckBox.TabIndex = 8
            Me.CanEditByEngineeringFormanCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByEngineeringLSMCheckBox
            '
            Me.CanEditByEngineeringLSMCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByEngineeringLSM", True))
            Me.CanEditByEngineeringLSMCheckBox.Location = New System.Drawing.Point(503, 20)
            Me.CanEditByEngineeringLSMCheckBox.Name = "CanEditByEngineeringLSMCheckBox"
            Me.CanEditByEngineeringLSMCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByEngineeringLSMCheckBox.TabIndex = 10
            Me.CanEditByEngineeringLSMCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByEngineeringLSMJrCheckBox
            '
            Me.CanEditByEngineeringLSMJrCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByEngineeringLSMJr", True))
            Me.CanEditByEngineeringLSMJrCheckBox.Location = New System.Drawing.Point(503, 50)
            Me.CanEditByEngineeringLSMJrCheckBox.Name = "CanEditByEngineeringLSMJrCheckBox"
            Me.CanEditByEngineeringLSMJrCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByEngineeringLSMJrCheckBox.TabIndex = 12
            Me.CanEditByEngineeringLSMJrCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByEngineeringManagerCheckBox
            '
            Me.CanEditByEngineeringManagerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByEngineeringManager", True))
            Me.CanEditByEngineeringManagerCheckBox.Location = New System.Drawing.Point(503, 80)
            Me.CanEditByEngineeringManagerCheckBox.Name = "CanEditByEngineeringManagerCheckBox"
            Me.CanEditByEngineeringManagerCheckBox.Size = New System.Drawing.Size(24, 24)
            Me.CanEditByEngineeringManagerCheckBox.TabIndex = 14
            Me.CanEditByEngineeringManagerCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByOperationsManagerCheckBox
            '
            Me.CanEditByOperationsManagerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByOperationsManager", True))
            Me.CanEditByOperationsManagerCheckBox.Location = New System.Drawing.Point(147, 20)
            Me.CanEditByOperationsManagerCheckBox.Name = "CanEditByOperationsManagerCheckBox"
            Me.CanEditByOperationsManagerCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditByOperationsManagerCheckBox.TabIndex = 16
            Me.CanEditByOperationsManagerCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByOutsideVendorCheckBox
            '
            Me.CanEditByOutsideVendorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByOutsideVendor", True))
            Me.CanEditByOutsideVendorCheckBox.Location = New System.Drawing.Point(147, 50)
            Me.CanEditByOutsideVendorCheckBox.Name = "CanEditByOutsideVendorCheckBox"
            Me.CanEditByOutsideVendorCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditByOutsideVendorCheckBox.TabIndex = 18
            Me.CanEditByOutsideVendorCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByPlantManagerCheckBox
            '
            Me.CanEditByPlantManagerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByPlantManager", True))
            Me.CanEditByPlantManagerCheckBox.Location = New System.Drawing.Point(147, 80)
            Me.CanEditByPlantManagerCheckBox.Name = "CanEditByPlantManagerCheckBox"
            Me.CanEditByPlantManagerCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditByPlantManagerCheckBox.TabIndex = 20
            Me.CanEditByPlantManagerCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByProductionManagerCheckBox
            '
            Me.CanEditByProductionManagerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByProductionManager", True))
            Me.CanEditByProductionManagerCheckBox.Location = New System.Drawing.Point(147, 110)
            Me.CanEditByProductionManagerCheckBox.Name = "CanEditByProductionManagerCheckBox"
            Me.CanEditByProductionManagerCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditByProductionManagerCheckBox.TabIndex = 22
            Me.CanEditByProductionManagerCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditByProductionOperatorCheckBox
            '
            Me.CanEditByProductionOperatorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditByProductionOperator", True))
            Me.CanEditByProductionOperatorCheckBox.Location = New System.Drawing.Point(503, 110)
            Me.CanEditByProductionOperatorCheckBox.Name = "CanEditByProductionOperatorCheckBox"
            Me.CanEditByProductionOperatorCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditByProductionOperatorCheckBox.TabIndex = 24
            Me.CanEditByProductionOperatorCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditBySystemsOperatorCheckBox
            '
            Me.CanEditBySystemsOperatorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditBySystemsOperator", True))
            Me.CanEditBySystemsOperatorCheckBox.Location = New System.Drawing.Point(656, 20)
            Me.CanEditBySystemsOperatorCheckBox.Name = "CanEditBySystemsOperatorCheckBox"
            Me.CanEditBySystemsOperatorCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditBySystemsOperatorCheckBox.TabIndex = 26
            Me.CanEditBySystemsOperatorCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditBySystemsOperatorSrCheckBox
            '
            Me.CanEditBySystemsOperatorSrCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditBySystemsOperatorSr", True))
            Me.CanEditBySystemsOperatorSrCheckBox.Location = New System.Drawing.Point(656, 50)
            Me.CanEditBySystemsOperatorSrCheckBox.Name = "CanEditBySystemsOperatorSrCheckBox"
            Me.CanEditBySystemsOperatorSrCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditBySystemsOperatorSrCheckBox.TabIndex = 28
            Me.CanEditBySystemsOperatorSrCheckBox.UseVisualStyleBackColor = True
            '
            'CanEditBySystemSupportCheckBox
            '
            Me.CanEditBySystemSupportCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "CanEditBySystemSupport", True))
            Me.CanEditBySystemSupportCheckBox.Location = New System.Drawing.Point(656, 80)
            Me.CanEditBySystemSupportCheckBox.Name = "CanEditBySystemSupportCheckBox"
            Me.CanEditBySystemSupportCheckBox.Size = New System.Drawing.Size(25, 24)
            Me.CanEditBySystemSupportCheckBox.TabIndex = 30
            Me.CanEditBySystemSupportCheckBox.UseVisualStyleBackColor = True
            '
            'DescriptionTextBox
            '
            Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTRailSequenceStepBindingSource, "Description", True))
            Me.DescriptionTextBox.Location = New System.Drawing.Point(84, 300)
            Me.DescriptionTextBox.Name = "DescriptionTextBox"
            Me.DescriptionTextBox.Size = New System.Drawing.Size(393, 20)
            Me.DescriptionTextBox.TabIndex = 32
            '
            'IsActiveCheckBox
            '
            Me.IsActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTRailSequenceStepBindingSource, "IsActive", True))
            Me.IsActiveCheckBox.Location = New System.Drawing.Point(673, 300)
            Me.IsActiveCheckBox.Name = "IsActiveCheckBox"
            Me.IsActiveCheckBox.Size = New System.Drawing.Size(40, 24)
            Me.IsActiveCheckBox.TabIndex = 34
            Me.IsActiveCheckBox.UseVisualStyleBackColor = True
            '
            'StepNumberTextBox
            '
            Me.StepNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTRailSequenceStepBindingSource, "StepNumber", True))
            Me.StepNumberTextBox.Location = New System.Drawing.Point(571, 300)
            Me.StepNumberTextBox.Name = "StepNumberTextBox"
            Me.StepNumberTextBox.Size = New System.Drawing.Size(39, 20)
            Me.StepNumberTextBox.TabIndex = 42
            '
            'RolesToModifySequenceLabel1
            '
            Me.RolesToModifySequenceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTRailSequenceStepBindingSource, "RolesToModifySequence", True))
            Me.RolesToModifySequenceLabel1.Location = New System.Drawing.Point(152, 485)
            Me.RolesToModifySequenceLabel1.Name = "RolesToModifySequenceLabel1"
            Me.RolesToModifySequenceLabel1.Size = New System.Drawing.Size(100, 23)
            Me.RolesToModifySequenceLabel1.TabIndex = 43
            Me.RolesToModifySequenceLabel1.Text = "Label1"
            '
            'RolesToModifySequenceTextBox
            '
            Me.RolesToModifySequenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTRailSequenceStepBindingSource, "RolesToModifySequence", True))
            Me.RolesToModifySequenceTextBox.Location = New System.Drawing.Point(340, 482)
            Me.RolesToModifySequenceTextBox.Name = "RolesToModifySequenceTextBox"
            Me.RolesToModifySequenceTextBox.Size = New System.Drawing.Size(100, 20)
            Me.RolesToModifySequenceTextBox.TabIndex = 44
            '
            'gbRoleEdit
            '
            Me.gbRoleEdit.Controls.Add(CanEditByOperationsManagerLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditBySystemSupportCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditBySystemSupportLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditBySystemsOperatorSrCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditBySystemsOperatorSrLabel)
            Me.gbRoleEdit.Controls.Add(CanEditByAdminLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditBySystemsOperatorCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByAdminCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditBySystemsOperatorLabel)
            Me.gbRoleEdit.Controls.Add(CanEditByAreaSupervisorLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByProductionOperatorCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByAreaSupervisorCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditByProductionOperatorLabel)
            Me.gbRoleEdit.Controls.Add(CanEditByEngineeringCraftSupportLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByProductionManagerCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByEngineeringCraftSupportCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditByProductionManagerLabel)
            Me.gbRoleEdit.Controls.Add(CanEditByEngineeringFormanLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByPlantManagerCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByEngineeringFormanCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditByPlantManagerLabel)
            Me.gbRoleEdit.Controls.Add(CanEditByEngineeringLSMLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByOutsideVendorCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByEngineeringLSMCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditByOutsideVendorLabel)
            Me.gbRoleEdit.Controls.Add(CanEditByEngineeringLSMJrLabel)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByOperationsManagerCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByEngineeringLSMJrCheckBox)
            Me.gbRoleEdit.Controls.Add(Me.CanEditByEngineeringManagerCheckBox)
            Me.gbRoleEdit.Controls.Add(CanEditByEngineeringManagerLabel)
            Me.gbRoleEdit.Location = New System.Drawing.Point(8, 326)
            Me.gbRoleEdit.Name = "gbRoleEdit"
            Me.gbRoleEdit.Size = New System.Drawing.Size(705, 146)
            Me.gbRoleEdit.TabIndex = 45
            Me.gbRoleEdit.TabStop = False
            Me.gbRoleEdit.Text = "Roles Can Edit Step"
            '
            'ListBox1
            '
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.Location = New System.Drawing.Point(12, 56)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(718, 238)
            Me.ListBox1.TabIndex = 46
            '
            'ComboBox1
            '
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(540, 21)
            Me.ComboBox1.TabIndex = 47
            '
            'CtrlRailSequenceInfoEditBase
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(744, 515)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.ListBox1)
            Me.Controls.Add(Me.gbRoleEdit)
            Me.Controls.Add(RolesToModifySequenceLabel2)
            Me.Controls.Add(Me.RolesToModifySequenceTextBox)
            Me.Controls.Add(RolesToModifySequenceLabel)
            Me.Controls.Add(Me.RolesToModifySequenceLabel1)
            Me.Controls.Add(DescriptionLabel)
            Me.Controls.Add(Me.DescriptionTextBox)
            Me.Controls.Add(IsActiveLabel)
            Me.Controls.Add(Me.IsActiveCheckBox)
            Me.Controls.Add(StepNumberLabel)
            Me.Controls.Add(Me.StepNumberTextBox)
            Me.Name = "CtrlRailSequenceInfoEditBase"
            Me.Text = "CtrlLINTRailSequenceInfoEdit"
            CType(Me.LINTRailSequenceStepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRoleEdit.ResumeLayout(False)
            Me.gbRoleEdit.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LINTRailSequenceStepBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents CanEditByAdminCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByAreaSupervisorCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByEngineeringCraftSupportCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByEngineeringFormanCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByEngineeringLSMCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByEngineeringLSMJrCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByEngineeringManagerCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByOperationsManagerCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByOutsideVendorCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByPlantManagerCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByProductionManagerCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditByProductionOperatorCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditBySystemsOperatorCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditBySystemsOperatorSrCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CanEditBySystemSupportCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
        Friend WithEvents IsActiveCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents StepNumberTextBox As System.Windows.Forms.TextBox
        Friend WithEvents RolesToModifySequenceLabel1 As System.Windows.Forms.Label
        Friend WithEvents RolesToModifySequenceTextBox As System.Windows.Forms.TextBox
        Friend WithEvents gbRoleEdit As System.Windows.Forms.GroupBox
        Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    End Class
End Namespace


