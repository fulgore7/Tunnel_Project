
Imports Wdw_Sust.Textile.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintUserManagement


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
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Dim RFBadgeUserIDLabel As System.Windows.Forms.Label
        Dim AssignedShiftLabel As System.Windows.Forms.Label
        Dim IsActiveLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim LastLoginTimeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintUserManagement))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LINTCastMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbCastInfo = New System.Windows.Forms.GroupBox()
        Me.tbxLintUserId = New System.Windows.Forms.TextBox()
        Me.LastLoginTimeLabel1 = New System.Windows.Forms.Label()
        Me.lblLintUserId = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.gbWorkLocation = New System.Windows.Forms.GroupBox()
        Me.WorkAtTSACheckBox = New System.Windows.Forms.CheckBox()
        Me.WorkAtNSACheckBox = New System.Windows.Forms.CheckBox()
        Me.lblWorkLocation = New System.Windows.Forms.Label()
        Me.WorkAtASACheckBox = New System.Windows.Forms.CheckBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.IsActiveCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AssignedShiftComboBox = New System.Windows.Forms.ComboBox()
        Me.UserTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.gbRailSystemAccess = New System.Windows.Forms.GroupBox()
        Me.CanLogOperatorOffStation = New System.Windows.Forms.CheckBox()
        Me.gbBagEdits = New System.Windows.Forms.GroupBox()
        Me.EditBagsCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeleteBagsCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagZeroDestinationEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagCallIDEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagPLCIDEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagCategoryEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagRFTagEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagAccountEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagDropDestinationEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagWeightEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagStorageDestinationEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.BagSourceBinEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.gbSystemConfiguration = New System.Windows.Forms.GroupBox()
        Me.ResetProductionNumbersCheckBox = New System.Windows.Forms.CheckBox()
        Me.CanBlockUnblockRailCheckBox = New System.Windows.Forms.CheckBox()
        Me.CategorySetupCheckBox = New System.Windows.Forms.CheckBox()
        Me.SystemConfigurationCheckBox = New System.Windows.Forms.CheckBox()
        Me.AccountSetupCheckBox = New System.Windows.Forms.CheckBox()
        Me.CalibrationCheckBox = New System.Windows.Forms.CheckBox()
        Me.CallOffEditCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExpressProductSelectionCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChangeSequencesCheckBox = New System.Windows.Forms.CheckBox()
        Me.CallOffResetCheckBox = New System.Windows.Forms.CheckBox()
        Me.RunDownSystemCheckBox = New System.Windows.Forms.CheckBox()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.gbIDCard = New System.Windows.Forms.GroupBox()
        Me.lblCardReassignment = New System.Windows.Forms.Label()
        Me.btnAssignIDCard = New System.Windows.Forms.Button()
        Me.RFBadgeUserIDTextBox = New System.Windows.Forms.TextBox()
        Me.btnIDCardList = New System.Windows.Forms.Button()
        Me.gbUserManagement = New System.Windows.Forms.GroupBox()
        Me.EditUserCheckBox = New System.Windows.Forms.CheckBox()
        Me.gbEditUser = New System.Windows.Forms.GroupBox()
        Me.EditUserActiveStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditUserNameCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditShiftCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditEmployeeIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.gbCardOperations = New System.Windows.Forms.GroupBox()
        Me.EditCardNumberCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditCardCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeleteCardCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddCardCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReturnCardCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditCardAssignmentCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditUserSystemConfigurationCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditUserProductivityTargetsCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditUserTypeCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditUserWorkLocationCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditUserRailOptionsCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeleteUserCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddUserCheckBox = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbUserList = New System.Windows.Forms.GroupBox()
        Me.cbShowOnlyActiveCasts = New System.Windows.Forms.CheckBox()
        Me.lblPlantFilter = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbCastName = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCastCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RostrImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbProxId = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.proxTextbox = New System.Windows.Forms.TextBox()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        RFBadgeUserIDLabel = New System.Windows.Forms.Label()
        AssignedShiftLabel = New System.Windows.Forms.Label()
        IsActiveLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        LastLoginTimeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.LINTCastMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCastInfo.SuspendLayout()
        Me.gbWorkLocation.SuspendLayout()
        Me.gbRailSystemAccess.SuspendLayout()
        Me.gbBagEdits.SuspendLayout()
        Me.gbSystemConfiguration.SuspendLayout()
        Me.gbIDCard.SuspendLayout()
        Me.gbUserManagement.SuspendLayout()
        Me.gbEditUser.SuspendLayout()
        Me.gbCardOperations.SuspendLayout()
        Me.gbUserList.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.RostrImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbProxId.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(11, 26)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(55, 13)
        EmployeeIDLabel.TabIndex = 1
        EmployeeIDLabel.Text = "Perner ID:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(7, 99)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(59, 13)
        UserTypeLabel.TabIndex = 12
        UserTypeLabel.Text = "User Type:"
        '
        'RFBadgeUserIDLabel
        '
        RFBadgeUserIDLabel.AutoSize = True
        RFBadgeUserIDLabel.Location = New System.Drawing.Point(11, 23)
        RFBadgeUserIDLabel.Name = "RFBadgeUserIDLabel"
        RFBadgeUserIDLabel.Size = New System.Drawing.Size(72, 13)
        RFBadgeUserIDLabel.TabIndex = 0
        RFBadgeUserIDLabel.Text = "Card Number:"
        '
        'AssignedShiftLabel
        '
        AssignedShiftLabel.AutoSize = True
        AssignedShiftLabel.Location = New System.Drawing.Point(35, 125)
        AssignedShiftLabel.Name = "AssignedShiftLabel"
        AssignedShiftLabel.Size = New System.Drawing.Size(31, 13)
        AssignedShiftLabel.TabIndex = 14
        AssignedShiftLabel.Text = "Shift:"
        '
        'IsActiveLabel
        '
        IsActiveLabel.AutoSize = True
        IsActiveLabel.Location = New System.Drawing.Point(188, 125)
        IsActiveLabel.Name = "IsActiveLabel"
        IsActiveLabel.Size = New System.Drawing.Size(51, 13)
        IsActiveLabel.TabIndex = 15
        IsActiveLabel.Text = "Is Active:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(7, 51)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 16
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(6, 76)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 17
        LastNameLabel.Text = "Last Name:"
        '
        'LastLoginTimeLabel
        '
        LastLoginTimeLabel.AutoSize = True
        LastLoginTimeLabel.Location = New System.Drawing.Point(190, 51)
        LastLoginTimeLabel.Name = "LastLoginTimeLabel"
        LastLoginTimeLabel.Size = New System.Drawing.Size(85, 13)
        LastLoginTimeLabel.TabIndex = 30
        LastLoginTimeLabel.Text = "Last Login Time:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 36
        Label1.Text = "Prox Number:"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.LINTCastMemberBindingSource
        Me.ListBox1.DisplayMember = "EmployeeName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(5, 59)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(172, 602)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "EmployeeID"
        '
        'LINTCastMemberBindingSource
        '
        Me.LINTCastMemberBindingSource.DataSource = GetType(Wdw_Sust.Textile.Core.LintCastMember)
        '
        'gbCastInfo
        '
        Me.gbCastInfo.Controls.Add(Me.tbxLintUserId)
        Me.gbCastInfo.Controls.Add(LastLoginTimeLabel)
        Me.gbCastInfo.Controls.Add(Me.LastLoginTimeLabel1)
        Me.gbCastInfo.Controls.Add(Me.lblLintUserId)
        Me.gbCastInfo.Controls.Add(LastNameLabel)
        Me.gbCastInfo.Controls.Add(Me.LastNameTextBox)
        Me.gbCastInfo.Controls.Add(Me.gbWorkLocation)
        Me.gbCastInfo.Controls.Add(FirstNameLabel)
        Me.gbCastInfo.Controls.Add(Me.FirstNameTextBox)
        Me.gbCastInfo.Controls.Add(IsActiveLabel)
        Me.gbCastInfo.Controls.Add(Me.IsActiveCheckBox1)
        Me.gbCastInfo.Controls.Add(AssignedShiftLabel)
        Me.gbCastInfo.Controls.Add(Me.AssignedShiftComboBox)
        Me.gbCastInfo.Controls.Add(EmployeeIDLabel)
        Me.gbCastInfo.Controls.Add(UserTypeLabel)
        Me.gbCastInfo.Controls.Add(Me.UserTypeComboBox)
        Me.gbCastInfo.Controls.Add(Me.EmployeeIDTextBox)
        Me.gbCastInfo.Location = New System.Drawing.Point(377, 12)
        Me.gbCastInfo.Name = "gbCastInfo"
        Me.gbCastInfo.Size = New System.Drawing.Size(376, 210)
        Me.gbCastInfo.TabIndex = 1
        Me.gbCastInfo.TabStop = False
        Me.gbCastInfo.Text = "Cast Infomation"
        '
        'tbxLintUserId
        '
        Me.tbxLintUserId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTCastMemberBindingSource, "LintUserID", True))
        Me.tbxLintUserId.Enabled = False
        Me.tbxLintUserId.Location = New System.Drawing.Point(259, 22)
        Me.tbxLintUserId.Name = "tbxLintUserId"
        Me.tbxLintUserId.ReadOnly = True
        Me.tbxLintUserId.Size = New System.Drawing.Size(100, 20)
        Me.tbxLintUserId.TabIndex = 33
        '
        'LastLoginTimeLabel1
        '
        Me.LastLoginTimeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTCastMemberBindingSource, "LastLoginTime", True))
        Me.LastLoginTimeLabel1.Location = New System.Drawing.Point(240, 64)
        Me.LastLoginTimeLabel1.Name = "LastLoginTimeLabel1"
        Me.LastLoginTimeLabel1.Size = New System.Drawing.Size(131, 23)
        Me.LastLoginTimeLabel1.TabIndex = 31
        Me.LastLoginTimeLabel1.Text = "Last Login In Time"
        '
        'lblLintUserId
        '
        Me.lblLintUserId.AutoSize = True
        Me.lblLintUserId.Location = New System.Drawing.Point(190, 26)
        Me.lblLintUserId.Name = "lblLintUserId"
        Me.lblLintUserId.Size = New System.Drawing.Size(66, 13)
        Me.lblLintUserId.TabIndex = 32
        Me.lblLintUserId.Text = "Lint User ID:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTCastMemberBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(67, 73)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(106, 20)
        Me.LastNameTextBox.TabIndex = 2
        '
        'gbWorkLocation
        '
        Me.gbWorkLocation.Controls.Add(Me.WorkAtTSACheckBox)
        Me.gbWorkLocation.Controls.Add(Me.WorkAtNSACheckBox)
        Me.gbWorkLocation.Controls.Add(Me.lblWorkLocation)
        Me.gbWorkLocation.Controls.Add(Me.WorkAtASACheckBox)
        Me.gbWorkLocation.Location = New System.Drawing.Point(6, 150)
        Me.gbWorkLocation.Name = "gbWorkLocation"
        Me.gbWorkLocation.Size = New System.Drawing.Size(361, 50)
        Me.gbWorkLocation.TabIndex = 2
        Me.gbWorkLocation.TabStop = False
        Me.gbWorkLocation.Text = "Work Location"
        '
        'WorkAtTSACheckBox
        '
        Me.WorkAtTSACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "WorkAtTSA", True))
        Me.WorkAtTSACheckBox.Location = New System.Drawing.Point(198, 19)
        Me.WorkAtTSACheckBox.Name = "WorkAtTSACheckBox"
        Me.WorkAtTSACheckBox.Size = New System.Drawing.Size(48, 24)
        Me.WorkAtTSACheckBox.TabIndex = 2
        Me.WorkAtTSACheckBox.Text = "TSA"
        Me.WorkAtTSACheckBox.UseVisualStyleBackColor = True
        '
        'WorkAtNSACheckBox
        '
        Me.WorkAtNSACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "WorkAtNSA", True))
        Me.WorkAtNSACheckBox.Location = New System.Drawing.Point(142, 19)
        Me.WorkAtNSACheckBox.Name = "WorkAtNSACheckBox"
        Me.WorkAtNSACheckBox.Size = New System.Drawing.Size(50, 24)
        Me.WorkAtNSACheckBox.TabIndex = 1
        Me.WorkAtNSACheckBox.Text = "NSA"
        Me.WorkAtNSACheckBox.UseVisualStyleBackColor = True
        '
        'lblWorkLocation
        '
        Me.lblWorkLocation.AutoSize = True
        Me.lblWorkLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkLocation.Location = New System.Drawing.Point(6, 24)
        Me.lblWorkLocation.Name = "lblWorkLocation"
        Me.lblWorkLocation.Size = New System.Drawing.Size(77, 13)
        Me.lblWorkLocation.TabIndex = 8
        Me.lblWorkLocation.Text = "Work Location"
        '
        'WorkAtASACheckBox
        '
        Me.WorkAtASACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "WorkAtASA", True))
        Me.WorkAtASACheckBox.Location = New System.Drawing.Point(88, 19)
        Me.WorkAtASACheckBox.Name = "WorkAtASACheckBox"
        Me.WorkAtASACheckBox.Size = New System.Drawing.Size(48, 24)
        Me.WorkAtASACheckBox.TabIndex = 0
        Me.WorkAtASACheckBox.Text = "ASA"
        Me.WorkAtASACheckBox.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTCastMemberBindingSource, "FirstName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(67, 48)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(106, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'IsActiveCheckBox1
        '
        Me.IsActiveCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "IsActive", True))
        Me.IsActiveCheckBox1.Location = New System.Drawing.Point(245, 120)
        Me.IsActiveCheckBox1.Name = "IsActiveCheckBox1"
        Me.IsActiveCheckBox1.Size = New System.Drawing.Size(19, 24)
        Me.IsActiveCheckBox1.TabIndex = 5
        Me.IsActiveCheckBox1.UseVisualStyleBackColor = True
        '
        'AssignedShiftComboBox
        '
        Me.AssignedShiftComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTCastMemberBindingSource, "AssignedShift", True))
        Me.AssignedShiftComboBox.FormattingEnabled = True
        Me.AssignedShiftComboBox.Location = New System.Drawing.Point(67, 121)
        Me.AssignedShiftComboBox.Name = "AssignedShiftComboBox"
        Me.AssignedShiftComboBox.Size = New System.Drawing.Size(106, 21)
        Me.AssignedShiftComboBox.TabIndex = 4
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.CausesValidation = False
        Me.UserTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LINTCastMemberBindingSource, "UserType", True))
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.Location = New System.Drawing.Point(67, 96)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(172, 21)
        Me.UserTypeComboBox.TabIndex = 3
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTCastMemberBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(67, 22)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(106, 20)
        Me.EmployeeIDTextBox.TabIndex = 0
        '
        'gbRailSystemAccess
        '
        Me.gbRailSystemAccess.Controls.Add(Me.CanLogOperatorOffStation)
        Me.gbRailSystemAccess.Controls.Add(Me.gbBagEdits)
        Me.gbRailSystemAccess.Controls.Add(Me.gbSystemConfiguration)
        Me.gbRailSystemAccess.Location = New System.Drawing.Point(203, 229)
        Me.gbRailSystemAccess.Name = "gbRailSystemAccess"
        Me.gbRailSystemAccess.Size = New System.Drawing.Size(550, 489)
        Me.gbRailSystemAccess.TabIndex = 11
        Me.gbRailSystemAccess.TabStop = False
        Me.gbRailSystemAccess.Text = "Rail System Access"
        '
        'CanLogOperatorOffStation
        '
        Me.CanLogOperatorOffStation.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTCastMemberBindingSource, "LogOperatorOffOfStation", True))
        Me.CanLogOperatorOffStation.Location = New System.Drawing.Point(19, 182)
        Me.CanLogOperatorOffStation.Name = "CanLogOperatorOffStation"
        Me.CanLogOperatorOffStation.Size = New System.Drawing.Size(173, 24)
        Me.CanLogOperatorOffStation.TabIndex = 12
        Me.CanLogOperatorOffStation.Text = "Can Log Operator Off Station"
        Me.CanLogOperatorOffStation.UseVisualStyleBackColor = True
        '
        'gbBagEdits
        '
        Me.gbBagEdits.Controls.Add(Me.EditBagsCheckBox)
        Me.gbBagEdits.Controls.Add(Me.DeleteBagsCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagZeroDestinationEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagCallIDEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagPLCIDEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagCategoryEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagRFTagEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagAccountEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagDropDestinationEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagWeightEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagStorageDestinationEditCheckBox)
        Me.gbBagEdits.Controls.Add(Me.BagSourceBinEditCheckBox)
        Me.gbBagEdits.Location = New System.Drawing.Point(12, 209)
        Me.gbBagEdits.Name = "gbBagEdits"
        Me.gbBagEdits.Size = New System.Drawing.Size(293, 228)
        Me.gbBagEdits.TabIndex = 1
        Me.gbBagEdits.TabStop = False
        Me.gbBagEdits.Text = "Bag Editing"
        '
        'EditBagsCheckBox
        '
        Me.EditBagsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditBags", True))
        Me.EditBagsCheckBox.Location = New System.Drawing.Point(162, 37)
        Me.EditBagsCheckBox.Name = "EditBagsCheckBox"
        Me.EditBagsCheckBox.Size = New System.Drawing.Size(85, 21)
        Me.EditBagsCheckBox.TabIndex = 3
        Me.EditBagsCheckBox.Text = "Edit Bags"
        Me.EditBagsCheckBox.UseVisualStyleBackColor = True
        '
        'DeleteBagsCheckBox
        '
        Me.DeleteBagsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "DeleteBags", True))
        Me.DeleteBagsCheckBox.Location = New System.Drawing.Point(162, 18)
        Me.DeleteBagsCheckBox.Name = "DeleteBagsCheckBox"
        Me.DeleteBagsCheckBox.Size = New System.Drawing.Size(85, 18)
        Me.DeleteBagsCheckBox.TabIndex = 1
        Me.DeleteBagsCheckBox.Text = "Delete Bags"
        Me.DeleteBagsCheckBox.UseVisualStyleBackColor = True
        '
        'BagZeroDestinationEditCheckBox
        '
        Me.BagZeroDestinationEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagZeroDestinationEdit", True))
        Me.BagZeroDestinationEditCheckBox.Location = New System.Drawing.Point(7, 191)
        Me.BagZeroDestinationEditCheckBox.Name = "BagZeroDestinationEditCheckBox"
        Me.BagZeroDestinationEditCheckBox.Size = New System.Drawing.Size(259, 24)
        Me.BagZeroDestinationEditCheckBox.TabIndex = 11
        Me.BagZeroDestinationEditCheckBox.Text = "Change Bags With Non Zero Drop Destination"
        Me.BagZeroDestinationEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagCallIDEditCheckBox
        '
        Me.BagCallIDEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagCallIDEdit", True))
        Me.BagCallIDEditCheckBox.Location = New System.Drawing.Point(7, 175)
        Me.BagCallIDEditCheckBox.Name = "BagCallIDEditCheckBox"
        Me.BagCallIDEditCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.BagCallIDEditCheckBox.TabIndex = 10
        Me.BagCallIDEditCheckBox.Text = "Bag Call ID Edit"
        Me.BagCallIDEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagPLCIDEditCheckBox
        '
        Me.BagPLCIDEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagPLCIDEdit", True))
        Me.BagPLCIDEditCheckBox.Location = New System.Drawing.Point(7, 155)
        Me.BagPLCIDEditCheckBox.Name = "BagPLCIDEditCheckBox"
        Me.BagPLCIDEditCheckBox.Size = New System.Drawing.Size(115, 17)
        Me.BagPLCIDEditCheckBox.TabIndex = 9
        Me.BagPLCIDEditCheckBox.Text = "Bag PLC ID Edit"
        Me.BagPLCIDEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagCategoryEditCheckBox
        '
        Me.BagCategoryEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagCategoryEdit", True))
        Me.BagCategoryEditCheckBox.Location = New System.Drawing.Point(7, 19)
        Me.BagCategoryEditCheckBox.Name = "BagCategoryEditCheckBox"
        Me.BagCategoryEditCheckBox.Size = New System.Drawing.Size(153, 17)
        Me.BagCategoryEditCheckBox.TabIndex = 0
        Me.BagCategoryEditCheckBox.Text = "Bag Category Edit"
        Me.BagCategoryEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagRFTagEditCheckBox
        '
        Me.BagRFTagEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagRFTagEdit", True))
        Me.BagRFTagEditCheckBox.Location = New System.Drawing.Point(7, 133)
        Me.BagRFTagEditCheckBox.Name = "BagRFTagEditCheckBox"
        Me.BagRFTagEditCheckBox.Size = New System.Drawing.Size(125, 20)
        Me.BagRFTagEditCheckBox.TabIndex = 8
        Me.BagRFTagEditCheckBox.Text = "Bag RF Tag ID Edit"
        Me.BagRFTagEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagAccountEditCheckBox
        '
        Me.BagAccountEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagAccountEdit", True))
        Me.BagAccountEditCheckBox.Location = New System.Drawing.Point(7, 37)
        Me.BagAccountEditCheckBox.Name = "BagAccountEditCheckBox"
        Me.BagAccountEditCheckBox.Size = New System.Drawing.Size(153, 21)
        Me.BagAccountEditCheckBox.TabIndex = 2
        Me.BagAccountEditCheckBox.Text = "Bag Account Edit"
        Me.BagAccountEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagDropDestinationEditCheckBox
        '
        Me.BagDropDestinationEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagDropDestinationEdit", True))
        Me.BagDropDestinationEditCheckBox.Location = New System.Drawing.Point(7, 115)
        Me.BagDropDestinationEditCheckBox.Name = "BagDropDestinationEditCheckBox"
        Me.BagDropDestinationEditCheckBox.Size = New System.Drawing.Size(168, 17)
        Me.BagDropDestinationEditCheckBox.TabIndex = 7
        Me.BagDropDestinationEditCheckBox.Text = "Bag Drop Destination Edit"
        Me.BagDropDestinationEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagWeightEditCheckBox
        '
        Me.BagWeightEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagWeightEdit", True))
        Me.BagWeightEditCheckBox.Location = New System.Drawing.Point(7, 58)
        Me.BagWeightEditCheckBox.Name = "BagWeightEditCheckBox"
        Me.BagWeightEditCheckBox.Size = New System.Drawing.Size(153, 17)
        Me.BagWeightEditCheckBox.TabIndex = 4
        Me.BagWeightEditCheckBox.Text = "Bag Weight Edit"
        Me.BagWeightEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagStorageDestinationEditCheckBox
        '
        Me.BagStorageDestinationEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagStorageDestinationEdit", True))
        Me.BagStorageDestinationEditCheckBox.Location = New System.Drawing.Point(7, 96)
        Me.BagStorageDestinationEditCheckBox.Name = "BagStorageDestinationEditCheckBox"
        Me.BagStorageDestinationEditCheckBox.Size = New System.Drawing.Size(168, 17)
        Me.BagStorageDestinationEditCheckBox.TabIndex = 6
        Me.BagStorageDestinationEditCheckBox.Text = "Bag Storage Destination Edit"
        Me.BagStorageDestinationEditCheckBox.UseVisualStyleBackColor = True
        '
        'BagSourceBinEditCheckBox
        '
        Me.BagSourceBinEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "BagSourceBinEdit", True))
        Me.BagSourceBinEditCheckBox.Location = New System.Drawing.Point(7, 77)
        Me.BagSourceBinEditCheckBox.Name = "BagSourceBinEditCheckBox"
        Me.BagSourceBinEditCheckBox.Size = New System.Drawing.Size(153, 17)
        Me.BagSourceBinEditCheckBox.TabIndex = 5
        Me.BagSourceBinEditCheckBox.Text = "Bag Source Station Edit"
        Me.BagSourceBinEditCheckBox.UseVisualStyleBackColor = True
        '
        'gbSystemConfiguration
        '
        Me.gbSystemConfiguration.Controls.Add(Me.ResetProductionNumbersCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.CanBlockUnblockRailCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.CategorySetupCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.SystemConfigurationCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.AccountSetupCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.CalibrationCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.CallOffEditCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.ExpressProductSelectionCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.ChangeSequencesCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.CallOffResetCheckBox)
        Me.gbSystemConfiguration.Controls.Add(Me.RunDownSystemCheckBox)
        Me.gbSystemConfiguration.Location = New System.Drawing.Point(12, 18)
        Me.gbSystemConfiguration.Name = "gbSystemConfiguration"
        Me.gbSystemConfiguration.Size = New System.Drawing.Size(293, 154)
        Me.gbSystemConfiguration.TabIndex = 0
        Me.gbSystemConfiguration.TabStop = False
        Me.gbSystemConfiguration.Text = "System Configuration"
        '
        'ResetProductionNumbersCheckBox
        '
        Me.ResetProductionNumbersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTCastMemberBindingSource, "ResetProductionNumbers", True))
        Me.ResetProductionNumbersCheckBox.Location = New System.Drawing.Point(162, 90)
        Me.ResetProductionNumbersCheckBox.Name = "ResetProductionNumbersCheckBox"
        Me.ResetProductionNumbersCheckBox.Size = New System.Drawing.Size(129, 24)
        Me.ResetProductionNumbersCheckBox.TabIndex = 11
        Me.ResetProductionNumbersCheckBox.Text = "Reset Production #"
        Me.ResetProductionNumbersCheckBox.UseVisualStyleBackColor = True
        '
        'CanBlockUnblockRailCheckBox
        '
        Me.CanBlockUnblockRailCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTCastMemberBindingSource, "CanBlockUnblockRail", True))
        Me.CanBlockUnblockRailCheckBox.Location = New System.Drawing.Point(162, 71)
        Me.CanBlockUnblockRailCheckBox.Name = "CanBlockUnblockRailCheckBox"
        Me.CanBlockUnblockRailCheckBox.Size = New System.Drawing.Size(129, 24)
        Me.CanBlockUnblockRailCheckBox.TabIndex = 10
        Me.CanBlockUnblockRailCheckBox.Text = "Block / Unblock Rail"
        Me.CanBlockUnblockRailCheckBox.UseVisualStyleBackColor = True
        '
        'CategorySetupCheckBox
        '
        Me.CategorySetupCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "CategorySetup", True))
        Me.CategorySetupCheckBox.Location = New System.Drawing.Point(162, 20)
        Me.CategorySetupCheckBox.Name = "CategorySetupCheckBox"
        Me.CategorySetupCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.CategorySetupCheckBox.TabIndex = 1
        Me.CategorySetupCheckBox.Text = "Category Setup"
        Me.CategorySetupCheckBox.UseVisualStyleBackColor = True
        '
        'SystemConfigurationCheckBox
        '
        Me.SystemConfigurationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "SystemConfiguration", True))
        Me.SystemConfigurationCheckBox.Location = New System.Drawing.Point(162, 56)
        Me.SystemConfigurationCheckBox.Name = "SystemConfigurationCheckBox"
        Me.SystemConfigurationCheckBox.Size = New System.Drawing.Size(129, 19)
        Me.SystemConfigurationCheckBox.TabIndex = 5
        Me.SystemConfigurationCheckBox.Text = "System Configuration"
        Me.SystemConfigurationCheckBox.UseVisualStyleBackColor = True
        '
        'AccountSetupCheckBox
        '
        Me.AccountSetupCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "AccountSetup", True))
        Me.AccountSetupCheckBox.Location = New System.Drawing.Point(162, 38)
        Me.AccountSetupCheckBox.Name = "AccountSetupCheckBox"
        Me.AccountSetupCheckBox.Size = New System.Drawing.Size(104, 19)
        Me.AccountSetupCheckBox.TabIndex = 3
        Me.AccountSetupCheckBox.Text = "Account Setup"
        Me.AccountSetupCheckBox.UseVisualStyleBackColor = True
        '
        'CalibrationCheckBox
        '
        Me.CalibrationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "Calibration", True))
        Me.CalibrationCheckBox.Location = New System.Drawing.Point(7, 18)
        Me.CalibrationCheckBox.Name = "CalibrationCheckBox"
        Me.CalibrationCheckBox.Size = New System.Drawing.Size(177, 20)
        Me.CalibrationCheckBox.TabIndex = 0
        Me.CalibrationCheckBox.Text = "Sorting Station Calibration"
        Me.CalibrationCheckBox.UseVisualStyleBackColor = True
        '
        'CallOffEditCheckBox
        '
        Me.CallOffEditCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "CallOffEdit", True))
        Me.CallOffEditCheckBox.Location = New System.Drawing.Point(7, 38)
        Me.CallOffEditCheckBox.Name = "CallOffEditCheckBox"
        Me.CallOffEditCheckBox.Size = New System.Drawing.Size(104, 18)
        Me.CallOffEditCheckBox.TabIndex = 2
        Me.CallOffEditCheckBox.Text = "Call Off Edit"
        Me.CallOffEditCheckBox.UseVisualStyleBackColor = True
        '
        'ExpressProductSelectionCheckBox
        '
        Me.ExpressProductSelectionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "ExpressProductSelection", True))
        Me.ExpressProductSelectionCheckBox.Location = New System.Drawing.Point(7, 114)
        Me.ExpressProductSelectionCheckBox.Name = "ExpressProductSelectionCheckBox"
        Me.ExpressProductSelectionCheckBox.Size = New System.Drawing.Size(191, 15)
        Me.ExpressProductSelectionCheckBox.TabIndex = 8
        Me.ExpressProductSelectionCheckBox.Text = "Express Product Selection"
        Me.ExpressProductSelectionCheckBox.UseVisualStyleBackColor = True
        '
        'ChangeSequencesCheckBox
        '
        Me.ChangeSequencesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "ChangeSequences", True))
        Me.ChangeSequencesCheckBox.Location = New System.Drawing.Point(7, 93)
        Me.ChangeSequencesCheckBox.Name = "ChangeSequencesCheckBox"
        Me.ChangeSequencesCheckBox.Size = New System.Drawing.Size(166, 18)
        Me.ChangeSequencesCheckBox.TabIndex = 7
        Me.ChangeSequencesCheckBox.Text = "Change Machine Sequence"
        Me.ChangeSequencesCheckBox.UseVisualStyleBackColor = True
        '
        'CallOffResetCheckBox
        '
        Me.CallOffResetCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "CallOffReset", True))
        Me.CallOffResetCheckBox.Location = New System.Drawing.Point(7, 73)
        Me.CallOffResetCheckBox.Name = "CallOffResetCheckBox"
        Me.CallOffResetCheckBox.Size = New System.Drawing.Size(104, 20)
        Me.CallOffResetCheckBox.TabIndex = 6
        Me.CallOffResetCheckBox.Text = "Call Off Reset"
        Me.CallOffResetCheckBox.UseVisualStyleBackColor = True
        '
        'RunDownSystemCheckBox
        '
        Me.RunDownSystemCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "RunDownSystem", True))
        Me.RunDownSystemCheckBox.Location = New System.Drawing.Point(7, 55)
        Me.RunDownSystemCheckBox.Name = "RunDownSystemCheckBox"
        Me.RunDownSystemCheckBox.Size = New System.Drawing.Size(150, 20)
        Me.RunDownSystemCheckBox.TabIndex = 4
        Me.RunDownSystemCheckBox.Text = "Run Down System"
        Me.RunDownSystemCheckBox.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(236, 20)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(99, 30)
        Me.btnDeleteUser.TabIndex = 6
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(124, 20)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(98, 30)
        Me.btnAddUser.TabIndex = 5
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUser.Location = New System.Drawing.Point(15, 20)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(98, 30)
        Me.btnEditUser.TabIndex = 4
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(124, 94)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(98, 30)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'gbIDCard
        '
        Me.gbIDCard.Controls.Add(Me.lblCardReassignment)
        Me.gbIDCard.Controls.Add(Me.btnAssignIDCard)
        Me.gbIDCard.Controls.Add(RFBadgeUserIDLabel)
        Me.gbIDCard.Controls.Add(Me.RFBadgeUserIDTextBox)
        Me.gbIDCard.Location = New System.Drawing.Point(757, 12)
        Me.gbIDCard.Name = "gbIDCard"
        Me.gbIDCard.Size = New System.Drawing.Size(355, 68)
        Me.gbIDCard.TabIndex = 3
        Me.gbIDCard.TabStop = False
        Me.gbIDCard.Text = "Productivity Card"
        '
        'lblCardReassignment
        '
        Me.lblCardReassignment.AutoSize = True
        Me.lblCardReassignment.ForeColor = System.Drawing.Color.Red
        Me.lblCardReassignment.Location = New System.Drawing.Point(11, 47)
        Me.lblCardReassignment.Name = "lblCardReassignment"
        Me.lblCardReassignment.Size = New System.Drawing.Size(84, 13)
        Me.lblCardReassignment.TabIndex = 32
        Me.lblCardReassignment.Text = "lblReassignment"
        '
        'btnAssignIDCard
        '
        Me.btnAssignIDCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssignIDCard.Location = New System.Drawing.Point(259, 19)
        Me.btnAssignIDCard.Name = "btnAssignIDCard"
        Me.btnAssignIDCard.Size = New System.Drawing.Size(90, 22)
        Me.btnAssignIDCard.TabIndex = 1
        Me.btnAssignIDCard.Text = "Assign ID Card"
        Me.btnAssignIDCard.UseVisualStyleBackColor = True
        '
        'RFBadgeUserIDTextBox
        '
        Me.RFBadgeUserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LINTCastMemberBindingSource, "RFBadgeUserID", True))
        Me.RFBadgeUserIDTextBox.Location = New System.Drawing.Point(89, 20)
        Me.RFBadgeUserIDTextBox.Name = "RFBadgeUserIDTextBox"
        Me.RFBadgeUserIDTextBox.Size = New System.Drawing.Size(168, 20)
        Me.RFBadgeUserIDTextBox.TabIndex = 0
        '
        'btnIDCardList
        '
        Me.btnIDCardList.Location = New System.Drawing.Point(124, 56)
        Me.btnIDCardList.Name = "btnIDCardList"
        Me.btnIDCardList.Size = New System.Drawing.Size(98, 31)
        Me.btnIDCardList.TabIndex = 7
        Me.btnIDCardList.Text = "ID Card List"
        Me.btnIDCardList.UseVisualStyleBackColor = True
        '
        'gbUserManagement
        '
        Me.gbUserManagement.Controls.Add(Me.EditUserCheckBox)
        Me.gbUserManagement.Controls.Add(Me.gbEditUser)
        Me.gbUserManagement.Controls.Add(Me.DeleteUserCheckBox)
        Me.gbUserManagement.Controls.Add(Me.AddUserCheckBox)
        Me.gbUserManagement.Location = New System.Drawing.Point(757, 302)
        Me.gbUserManagement.Name = "gbUserManagement"
        Me.gbUserManagement.Size = New System.Drawing.Size(355, 416)
        Me.gbUserManagement.TabIndex = 12
        Me.gbUserManagement.TabStop = False
        Me.gbUserManagement.Text = "User Management"
        '
        'EditUserCheckBox
        '
        Me.EditUserCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUser", True))
        Me.EditUserCheckBox.Location = New System.Drawing.Point(82, 21)
        Me.EditUserCheckBox.Name = "EditUserCheckBox"
        Me.EditUserCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EditUserCheckBox.TabIndex = 2
        Me.EditUserCheckBox.Text = "Edit User"
        Me.EditUserCheckBox.UseVisualStyleBackColor = True
        '
        'gbEditUser
        '
        Me.gbEditUser.Controls.Add(Me.EditUserActiveStatusCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditUserNameCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditShiftCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditEmployeeIDCheckBox)
        Me.gbEditUser.Controls.Add(Me.gbCardOperations)
        Me.gbEditUser.Controls.Add(Me.EditUserSystemConfigurationCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditUserProductivityTargetsCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditUserTypeCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditUserWorkLocationCheckBox)
        Me.gbEditUser.Controls.Add(Me.EditUserRailOptionsCheckBox)
        Me.gbEditUser.Location = New System.Drawing.Point(6, 74)
        Me.gbEditUser.Name = "gbEditUser"
        Me.gbEditUser.Size = New System.Drawing.Size(189, 342)
        Me.gbEditUser.TabIndex = 3
        Me.gbEditUser.TabStop = False
        Me.gbEditUser.Text = "Edit User"
        '
        'EditUserActiveStatusCheckBox
        '
        Me.EditUserActiveStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LINTCastMemberBindingSource, "EditUserActiveStatus", True))
        Me.EditUserActiveStatusCheckBox.Location = New System.Drawing.Point(6, 165)
        Me.EditUserActiveStatusCheckBox.Name = "EditUserActiveStatusCheckBox"
        Me.EditUserActiveStatusCheckBox.Size = New System.Drawing.Size(150, 24)
        Me.EditUserActiveStatusCheckBox.TabIndex = 13
        Me.EditUserActiveStatusCheckBox.Text = "Edit User Active Status"
        Me.EditUserActiveStatusCheckBox.UseVisualStyleBackColor = True
        '
        'EditUserNameCheckBox
        '
        Me.EditUserNameCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUserName", True))
        Me.EditUserNameCheckBox.Location = New System.Drawing.Point(6, 70)
        Me.EditUserNameCheckBox.Name = "EditUserNameCheckBox"
        Me.EditUserNameCheckBox.Size = New System.Drawing.Size(143, 24)
        Me.EditUserNameCheckBox.TabIndex = 12
        Me.EditUserNameCheckBox.Text = "Edit User Name"
        Me.EditUserNameCheckBox.UseVisualStyleBackColor = True
        '
        'EditShiftCheckBox
        '
        Me.EditShiftCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditShift", True))
        Me.EditShiftCheckBox.Location = New System.Drawing.Point(6, 108)
        Me.EditShiftCheckBox.Name = "EditShiftCheckBox"
        Me.EditShiftCheckBox.Size = New System.Drawing.Size(150, 24)
        Me.EditShiftCheckBox.TabIndex = 4
        Me.EditShiftCheckBox.Text = "Edit Shift"
        Me.EditShiftCheckBox.UseVisualStyleBackColor = True
        '
        'EditEmployeeIDCheckBox
        '
        Me.EditEmployeeIDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditEmployeeID", True))
        Me.EditEmployeeIDCheckBox.Location = New System.Drawing.Point(6, 50)
        Me.EditEmployeeIDCheckBox.Name = "EditEmployeeIDCheckBox"
        Me.EditEmployeeIDCheckBox.Size = New System.Drawing.Size(150, 24)
        Me.EditEmployeeIDCheckBox.TabIndex = 2
        Me.EditEmployeeIDCheckBox.Text = "Edit Employee ID"
        Me.EditEmployeeIDCheckBox.UseVisualStyleBackColor = True
        '
        'gbCardOperations
        '
        Me.gbCardOperations.Controls.Add(Me.EditCardNumberCheckBox)
        Me.gbCardOperations.Controls.Add(Me.EditCardCheckBox)
        Me.gbCardOperations.Controls.Add(Me.DeleteCardCheckBox)
        Me.gbCardOperations.Controls.Add(Me.AddCardCheckBox)
        Me.gbCardOperations.Controls.Add(Me.ReturnCardCheckBox)
        Me.gbCardOperations.Controls.Add(Me.EditCardAssignmentCheckBox)
        Me.gbCardOperations.Location = New System.Drawing.Point(9, 187)
        Me.gbCardOperations.Name = "gbCardOperations"
        Me.gbCardOperations.Size = New System.Drawing.Size(147, 140)
        Me.gbCardOperations.TabIndex = 11
        Me.gbCardOperations.TabStop = False
        Me.gbCardOperations.Text = "Card Operations"
        '
        'EditCardNumberCheckBox
        '
        Me.EditCardNumberCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditCardNumber", True))
        Me.EditCardNumberCheckBox.Location = New System.Drawing.Point(6, 114)
        Me.EditCardNumberCheckBox.Name = "EditCardNumberCheckBox"
        Me.EditCardNumberCheckBox.Size = New System.Drawing.Size(123, 19)
        Me.EditCardNumberCheckBox.TabIndex = 5
        Me.EditCardNumberCheckBox.Text = "Edit Card Number"
        Me.EditCardNumberCheckBox.UseVisualStyleBackColor = True
        '
        'EditCardCheckBox
        '
        Me.EditCardCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditCard", True))
        Me.EditCardCheckBox.Location = New System.Drawing.Point(6, 18)
        Me.EditCardCheckBox.Name = "EditCardCheckBox"
        Me.EditCardCheckBox.Size = New System.Drawing.Size(104, 19)
        Me.EditCardCheckBox.TabIndex = 0
        Me.EditCardCheckBox.Text = "Edit Card"
        Me.EditCardCheckBox.UseVisualStyleBackColor = True
        '
        'DeleteCardCheckBox
        '
        Me.DeleteCardCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "DeleteCard", True))
        Me.DeleteCardCheckBox.Location = New System.Drawing.Point(6, 95)
        Me.DeleteCardCheckBox.Name = "DeleteCardCheckBox"
        Me.DeleteCardCheckBox.Size = New System.Drawing.Size(104, 19)
        Me.DeleteCardCheckBox.TabIndex = 4
        Me.DeleteCardCheckBox.Text = "Delete Card"
        Me.DeleteCardCheckBox.UseVisualStyleBackColor = True
        '
        'AddCardCheckBox
        '
        Me.AddCardCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "AddCard", True))
        Me.AddCardCheckBox.Location = New System.Drawing.Point(6, 37)
        Me.AddCardCheckBox.Name = "AddCardCheckBox"
        Me.AddCardCheckBox.Size = New System.Drawing.Size(104, 19)
        Me.AddCardCheckBox.TabIndex = 1
        Me.AddCardCheckBox.Text = "Add Card"
        Me.AddCardCheckBox.UseVisualStyleBackColor = True
        '
        'ReturnCardCheckBox
        '
        Me.ReturnCardCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "ReturnCard", True))
        Me.ReturnCardCheckBox.Location = New System.Drawing.Point(6, 76)
        Me.ReturnCardCheckBox.Name = "ReturnCardCheckBox"
        Me.ReturnCardCheckBox.Size = New System.Drawing.Size(104, 19)
        Me.ReturnCardCheckBox.TabIndex = 3
        Me.ReturnCardCheckBox.Text = "Return Card"
        Me.ReturnCardCheckBox.UseVisualStyleBackColor = True
        '
        'EditCardAssignmentCheckBox
        '
        Me.EditCardAssignmentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditCardAssignment", True))
        Me.EditCardAssignmentCheckBox.Location = New System.Drawing.Point(6, 57)
        Me.EditCardAssignmentCheckBox.Name = "EditCardAssignmentCheckBox"
        Me.EditCardAssignmentCheckBox.Size = New System.Drawing.Size(136, 19)
        Me.EditCardAssignmentCheckBox.TabIndex = 2
        Me.EditCardAssignmentCheckBox.Text = "Edit Card Assignment"
        Me.EditCardAssignmentCheckBox.UseVisualStyleBackColor = True
        '
        'EditUserSystemConfigurationCheckBox
        '
        Me.EditUserSystemConfigurationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUserSystemConfiguration", True))
        Me.EditUserSystemConfigurationCheckBox.Location = New System.Drawing.Point(6, 13)
        Me.EditUserSystemConfigurationCheckBox.Name = "EditUserSystemConfigurationCheckBox"
        Me.EditUserSystemConfigurationCheckBox.Size = New System.Drawing.Size(150, 24)
        Me.EditUserSystemConfigurationCheckBox.TabIndex = 0
        Me.EditUserSystemConfigurationCheckBox.Text = "Edit System Configuration"
        Me.EditUserSystemConfigurationCheckBox.UseVisualStyleBackColor = True
        '
        'EditUserProductivityTargetsCheckBox
        '
        Me.EditUserProductivityTargetsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUserProductivityTargets", True))
        Me.EditUserProductivityTargetsCheckBox.Location = New System.Drawing.Point(6, 146)
        Me.EditUserProductivityTargetsCheckBox.Name = "EditUserProductivityTargetsCheckBox"
        Me.EditUserProductivityTargetsCheckBox.Size = New System.Drawing.Size(143, 24)
        Me.EditUserProductivityTargetsCheckBox.TabIndex = 6
        Me.EditUserProductivityTargetsCheckBox.Text = "Edit Productivity Targets"
        Me.EditUserProductivityTargetsCheckBox.UseVisualStyleBackColor = True
        '
        'EditUserTypeCheckBox
        '
        Me.EditUserTypeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUserType", True))
        Me.EditUserTypeCheckBox.Location = New System.Drawing.Point(6, 90)
        Me.EditUserTypeCheckBox.Name = "EditUserTypeCheckBox"
        Me.EditUserTypeCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EditUserTypeCheckBox.TabIndex = 3
        Me.EditUserTypeCheckBox.Text = "Edit User Type"
        Me.EditUserTypeCheckBox.UseVisualStyleBackColor = True
        '
        'EditUserWorkLocationCheckBox
        '
        Me.EditUserWorkLocationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUserWorkLocation", True))
        Me.EditUserWorkLocationCheckBox.Location = New System.Drawing.Point(6, 128)
        Me.EditUserWorkLocationCheckBox.Name = "EditUserWorkLocationCheckBox"
        Me.EditUserWorkLocationCheckBox.Size = New System.Drawing.Size(143, 24)
        Me.EditUserWorkLocationCheckBox.TabIndex = 5
        Me.EditUserWorkLocationCheckBox.Text = "Edit Work Location"
        Me.EditUserWorkLocationCheckBox.UseVisualStyleBackColor = True
        '
        'EditUserRailOptionsCheckBox
        '
        Me.EditUserRailOptionsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "EditUserRailOptions", True))
        Me.EditUserRailOptionsCheckBox.Location = New System.Drawing.Point(6, 32)
        Me.EditUserRailOptionsCheckBox.Name = "EditUserRailOptionsCheckBox"
        Me.EditUserRailOptionsCheckBox.Size = New System.Drawing.Size(132, 24)
        Me.EditUserRailOptionsCheckBox.TabIndex = 1
        Me.EditUserRailOptionsCheckBox.Text = "Edit Rail Options"
        Me.EditUserRailOptionsCheckBox.UseVisualStyleBackColor = True
        '
        'DeleteUserCheckBox
        '
        Me.DeleteUserCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "DeleteUser", True))
        Me.DeleteUserCheckBox.Location = New System.Drawing.Point(6, 43)
        Me.DeleteUserCheckBox.Name = "DeleteUserCheckBox"
        Me.DeleteUserCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DeleteUserCheckBox.TabIndex = 1
        Me.DeleteUserCheckBox.Text = "Delete User"
        Me.DeleteUserCheckBox.UseVisualStyleBackColor = True
        '
        'AddUserCheckBox
        '
        Me.AddUserCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LINTCastMemberBindingSource, "AddUser", True))
        Me.AddUserCheckBox.Location = New System.Drawing.Point(6, 21)
        Me.AddUserCheckBox.Name = "AddUserCheckBox"
        Me.AddUserCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AddUserCheckBox.TabIndex = 0
        Me.AddUserCheckBox.Text = "Add User"
        Me.AddUserCheckBox.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderSize = 3
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(236, 94)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 30)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbUserList
        '
        Me.gbUserList.Controls.Add(Me.cbShowOnlyActiveCasts)
        Me.gbUserList.Controls.Add(Me.lblPlantFilter)
        Me.gbUserList.Controls.Add(Me.btnSearch)
        Me.gbUserList.Controls.Add(Me.cmbCastName)
        Me.gbUserList.Controls.Add(Me.ListBox1)
        Me.gbUserList.Location = New System.Drawing.Point(13, 12)
        Me.gbUserList.Name = "gbUserList"
        Me.gbUserList.Size = New System.Drawing.Size(183, 706)
        Me.gbUserList.TabIndex = 0
        Me.gbUserList.TabStop = False
        Me.gbUserList.Text = "User List"
        '
        'cbShowOnlyActiveCasts
        '
        Me.cbShowOnlyActiveCasts.AutoSize = True
        Me.cbShowOnlyActiveCasts.Checked = True
        Me.cbShowOnlyActiveCasts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowOnlyActiveCasts.Location = New System.Drawing.Point(5, 39)
        Me.cbShowOnlyActiveCasts.Name = "cbShowOnlyActiveCasts"
        Me.cbShowOnlyActiveCasts.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbShowOnlyActiveCasts.Size = New System.Drawing.Size(158, 17)
        Me.cbShowOnlyActiveCasts.TabIndex = 33
        Me.cbShowOnlyActiveCasts.Text = "Show Only Active Cast Only"
        Me.cbShowOnlyActiveCasts.UseVisualStyleBackColor = True
        '
        'lblPlantFilter
        '
        Me.lblPlantFilter.AutoSize = True
        Me.lblPlantFilter.Location = New System.Drawing.Point(6, 18)
        Me.lblPlantFilter.Name = "lblPlantFilter"
        Me.lblPlantFilter.Size = New System.Drawing.Size(59, 13)
        Me.lblPlantFilter.TabIndex = 32
        Me.lblPlantFilter.Text = "Plant Filter:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(6, 667)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(171, 31)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search Cast Members"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbCastName
        '
        Me.cmbCastName.FormattingEnabled = True
        Me.cmbCastName.Items.AddRange(New Object() {"ALL", "TSA", "NSA", "ASA"})
        Me.cmbCastName.Location = New System.Drawing.Point(71, 14)
        Me.cmbCastName.Name = "cmbCastName"
        Me.cmbCastName.Size = New System.Drawing.Size(106, 21)
        Me.cmbCastName.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(15, 94)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 30)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslLogin, Me.tsslCastCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 721)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1130, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslLogin
        '
        Me.tsslLogin.Name = "tsslLogin"
        Me.tsslLogin.Size = New System.Drawing.Size(119, 17)
        Me.tsslLogin.Text = "ToolStripStatusLabel1"
        '
        'tsslCastCount
        '
        Me.tsslCastCount.Name = "tsslCastCount"
        Me.tsslCastCount.Size = New System.Drawing.Size(996, 17)
        Me.tsslCastCount.Spring = True
        Me.tsslCastCount.Text = "ToolStripStatusLabel1"
        Me.tsslCastCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RostrImage
        '
        Me.RostrImage.BackColor = System.Drawing.Color.White
        Me.RostrImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RostrImage.Location = New System.Drawing.Point(203, 12)
        Me.RostrImage.Name = "RostrImage"
        Me.RostrImage.Size = New System.Drawing.Size(168, 210)
        Me.RostrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RostrImage.TabIndex = 31
        Me.RostrImage.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditUser)
        Me.GroupBox1.Controls.Add(Me.btnAddUser)
        Me.GroupBox1.Controls.Add(Me.btnDeleteUser)
        Me.GroupBox1.Controls.Add(Me.btnIDCardList)
        Me.GroupBox1.Controls.Add(Me.btnApply)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(757, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 138)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'gbProxId
        '
        Me.gbProxId.Controls.Add(Me.PictureBox1)
        Me.gbProxId.Controls.Add(Label1)
        Me.gbProxId.Controls.Add(Me.proxTextbox)
        Me.gbProxId.Location = New System.Drawing.Point(757, 80)
        Me.gbProxId.Name = "gbProxId"
        Me.gbProxId.Size = New System.Drawing.Size(355, 76)
        Me.gbProxId.TabIndex = 33
        Me.gbProxId.TabStop = False
        Me.gbProxId.Text = "Company ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Wdw_Sust.Textile.[Global].WinForms.My.Resources.Resources.Help
        Me.PictureBox1.Location = New System.Drawing.Point(263, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'proxTextbox
        '
        Me.proxTextbox.Location = New System.Drawing.Point(89, 16)
        Me.proxTextbox.Name = "proxTextbox"
        Me.proxTextbox.Size = New System.Drawing.Size(168, 20)
        Me.proxTextbox.TabIndex = 37
        '
        'CtrlLintUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1130, 743)
        Me.Controls.Add(Me.gbProxId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RostrImage)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbUserList)
        Me.Controls.Add(Me.gbUserManagement)
        Me.Controls.Add(Me.gbIDCard)
        Me.Controls.Add(Me.gbRailSystemAccess)
        Me.Controls.Add(Me.gbCastInfo)
        Me.EnableTimeout = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1038, 446)
        Me.Name = "CtrlLintUserManagement"
        Me.Text = "Operator and User Setup"
        Me.TimeoutInSeconds = 120
        CType(Me.LINTCastMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCastInfo.ResumeLayout(False)
        Me.gbCastInfo.PerformLayout()
        Me.gbWorkLocation.ResumeLayout(False)
        Me.gbWorkLocation.PerformLayout()
        Me.gbRailSystemAccess.ResumeLayout(False)
        Me.gbBagEdits.ResumeLayout(False)
        Me.gbSystemConfiguration.ResumeLayout(False)
        Me.gbIDCard.ResumeLayout(False)
        Me.gbIDCard.PerformLayout()
        Me.gbUserManagement.ResumeLayout(False)
        Me.gbEditUser.ResumeLayout(False)
        Me.gbCardOperations.ResumeLayout(False)
        Me.gbUserList.ResumeLayout(False)
        Me.gbUserList.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.RostrImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbProxId.ResumeLayout(False)
        Me.gbProxId.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LINTCastMemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gbCastInfo As System.Windows.Forms.GroupBox
    Friend WithEvents gbRailSystemAccess As System.Windows.Forms.GroupBox
    Friend WithEvents gbBagEdits As System.Windows.Forms.GroupBox
    Friend WithEvents gbSystemConfiguration As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents BagAccountEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagCategoryEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagWeightEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagSourceBinEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagStorageDestinationEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagDropDestinationEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagRFTagEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditBagsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DeleteBagsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagZeroDestinationEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagCallIDEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BagPLCIDEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CategorySetupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AccountSetupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CalibrationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CallOffEditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ExpressProductSelectionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChangeSequencesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CallOffResetCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RunDownSystemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SystemConfigurationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents gbWorkLocation As System.Windows.Forms.GroupBox
    Friend WithEvents WorkAtASACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WorkAtTSACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WorkAtNSACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblWorkLocation As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents gbIDCard As System.Windows.Forms.GroupBox
    Friend WithEvents RFBadgeUserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAssignIDCard As System.Windows.Forms.Button
    Friend WithEvents btnIDCardList As System.Windows.Forms.Button
    Friend WithEvents gbUserManagement As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteUserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AddUserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents gbEditUser As System.Windows.Forms.GroupBox
    Friend WithEvents EditUserTypeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserWorkLocationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserRailOptionsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserSystemConfigurationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserProductivityTargetsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditCardAssignmentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AddCardCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditCardCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReturnCardCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents gbCardOperations As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteCardCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditEmployeeIDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents gbUserList As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbCastName As System.Windows.Forms.ComboBox
    Friend WithEvents IsActiveCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents AssignedShiftComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UserTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblPlantFilter As System.Windows.Forms.Label
    Friend WithEvents EditCardNumberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslLogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditShiftCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserNameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents tsslCastCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LastLoginTimeLabel1 As System.Windows.Forms.Label
    Friend WithEvents cbShowOnlyActiveCasts As System.Windows.Forms.CheckBox
    Friend WithEvents EditUserActiveStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CanBlockUnblockRailCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblCardReassignment As System.Windows.Forms.Label
    Friend WithEvents ResetProductionNumbersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblLintUserId As System.Windows.Forms.Label
    Friend WithEvents tbxLintUserId As System.Windows.Forms.TextBox
    Friend WithEvents RostrImage As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CanLogOperatorOffStation As System.Windows.Forms.CheckBox
    Friend WithEvents gbProxId As System.Windows.Forms.GroupBox
    Friend WithEvents proxTextbox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class


