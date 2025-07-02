
Imports Wdw_Sust.Textile.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintIdCardList


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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintIdCardList))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFixCardOnly = New System.Windows.Forms.Button()
        Me.btnSearchIdNumber = New System.Windows.Forms.Button()
        Me.txtSearchIdNumber = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCreateLogoutCard = New System.Windows.Forms.Button()
        Me.btnDeleteCard = New System.Windows.Forms.Button()
        Me.btnReturnCard = New System.Windows.Forms.Button()
        Me.btnVerifyCard = New System.Windows.Forms.Button()
        Me.btnAddNewCard = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RFBadgeUserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeIssuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeUnassignedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsCardValidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RFIDCardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RFIDCardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(600, 689)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchIdNumber)
        Me.GroupBox2.Controls.Add(Me.txtSearchIdNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 41)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'btnFixCardOnly
        '
        Me.btnFixCardOnly.Location = New System.Drawing.Point(479, 14)
        Me.btnFixCardOnly.Name = "btnFixCardOnly"
        Me.btnFixCardOnly.Size = New System.Drawing.Size(97, 37)
        Me.btnFixCardOnly.TabIndex = 7
        Me.btnFixCardOnly.Text = "Update ID on Card"
        Me.btnFixCardOnly.UseVisualStyleBackColor = True
        '
        'btnSearchIdNumber
        '
        Me.btnSearchIdNumber.Location = New System.Drawing.Point(165, 7)
        Me.btnSearchIdNumber.Name = "btnSearchIdNumber"
        Me.btnSearchIdNumber.Size = New System.Drawing.Size(126, 30)
        Me.btnSearchIdNumber.TabIndex = 6
        Me.btnSearchIdNumber.Text = "Search Id Number"
        Me.btnSearchIdNumber.UseVisualStyleBackColor = True
        '
        'txtSearchIdNumber
        '
        Me.txtSearchIdNumber.Location = New System.Drawing.Point(37, 13)
        Me.txtSearchIdNumber.Name = "txtSearchIdNumber"
        Me.txtSearchIdNumber.Size = New System.Drawing.Size(107, 20)
        Me.txtSearchIdNumber.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(77, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 30)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFixCardOnly)
        Me.GroupBox1.Controls.Add(Me.btnCreateLogoutCard)
        Me.GroupBox1.Controls.Add(Me.btnDeleteCard)
        Me.GroupBox1.Controls.Add(Me.btnReturnCard)
        Me.GroupBox1.Controls.Add(Me.btnVerifyCard)
        Me.GroupBox1.Controls.Add(Me.btnAddNewCard)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 58)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ID Card Options"
        '
        'btnCreateLogoutCard
        '
        Me.btnCreateLogoutCard.Enabled = False
        Me.btnCreateLogoutCard.Location = New System.Drawing.Point(385, 13)
        Me.btnCreateLogoutCard.Name = "btnCreateLogoutCard"
        Me.btnCreateLogoutCard.Size = New System.Drawing.Size(88, 39)
        Me.btnCreateLogoutCard.TabIndex = 4
        Me.btnCreateLogoutCard.Text = "Create Logout Card"
        Me.btnCreateLogoutCard.UseVisualStyleBackColor = True
        '
        'btnDeleteCard
        '
        Me.btnDeleteCard.Enabled = False
        Me.btnDeleteCard.Location = New System.Drawing.Point(291, 13)
        Me.btnDeleteCard.Name = "btnDeleteCard"
        Me.btnDeleteCard.Size = New System.Drawing.Size(88, 39)
        Me.btnDeleteCard.TabIndex = 3
        Me.btnDeleteCard.Text = "Delete Card"
        Me.btnDeleteCard.UseVisualStyleBackColor = True
        '
        'btnReturnCard
        '
        Me.btnReturnCard.Enabled = False
        Me.btnReturnCard.Location = New System.Drawing.Point(197, 13)
        Me.btnReturnCard.Name = "btnReturnCard"
        Me.btnReturnCard.Size = New System.Drawing.Size(88, 39)
        Me.btnReturnCard.TabIndex = 2
        Me.btnReturnCard.Text = "Return Card"
        Me.btnReturnCard.UseVisualStyleBackColor = True
        '
        'btnVerifyCard
        '
        Me.btnVerifyCard.Location = New System.Drawing.Point(103, 13)
        Me.btnVerifyCard.Name = "btnVerifyCard"
        Me.btnVerifyCard.Size = New System.Drawing.Size(88, 39)
        Me.btnVerifyCard.TabIndex = 1
        Me.btnVerifyCard.Text = "Verify ID Card"
        Me.btnVerifyCard.UseVisualStyleBackColor = True
        '
        'btnAddNewCard
        '
        Me.btnAddNewCard.Enabled = False
        Me.btnAddNewCard.Location = New System.Drawing.Point(9, 13)
        Me.btnAddNewCard.Name = "btnAddNewCard"
        Me.btnAddNewCard.Size = New System.Drawing.Size(88, 39)
        Me.btnAddNewCard.TabIndex = 0
        Me.btnAddNewCard.Text = "Add New ID Card"
        Me.btnAddNewCard.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(8, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RFBadgeUserIDDataGridViewTextBoxColumn, Me.AssignedTo, Me.TimeIssuedDataGridViewTextBoxColumn, Me.TimeUnassignedDataGridViewTextBoxColumn, Me.IsCardValidDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.RFIDCardBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(600, 576)
        Me.DataGridView1.TabIndex = 0
        '
        'RFBadgeUserIDDataGridViewTextBoxColumn
        '
        Me.RFBadgeUserIDDataGridViewTextBoxColumn.DataPropertyName = "RFBadgeUserID"
        Me.RFBadgeUserIDDataGridViewTextBoxColumn.HeaderText = "ID Number"
        Me.RFBadgeUserIDDataGridViewTextBoxColumn.Name = "RFBadgeUserIDDataGridViewTextBoxColumn"
        Me.RFBadgeUserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssignedTo
        '
        Me.AssignedTo.DataPropertyName = "AssignedTo"
        Me.AssignedTo.HeaderText = "Assigned To"
        Me.AssignedTo.Name = "AssignedTo"
        Me.AssignedTo.ReadOnly = True
        '
        'TimeIssuedDataGridViewTextBoxColumn
        '
        Me.TimeIssuedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TimeIssuedDataGridViewTextBoxColumn.DataPropertyName = "TimeIssued"
        Me.TimeIssuedDataGridViewTextBoxColumn.HeaderText = "Time Issued"
        Me.TimeIssuedDataGridViewTextBoxColumn.Name = "TimeIssuedDataGridViewTextBoxColumn"
        Me.TimeIssuedDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeIssuedDataGridViewTextBoxColumn.Width = 82
        '
        'TimeUnassignedDataGridViewTextBoxColumn
        '
        Me.TimeUnassignedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TimeUnassignedDataGridViewTextBoxColumn.DataPropertyName = "TimeUnassigned"
        Me.TimeUnassignedDataGridViewTextBoxColumn.HeaderText = "Time Unassigned"
        Me.TimeUnassignedDataGridViewTextBoxColumn.Name = "TimeUnassignedDataGridViewTextBoxColumn"
        Me.TimeUnassignedDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeUnassignedDataGridViewTextBoxColumn.Width = 105
        '
        'IsCardValidDataGridViewCheckBoxColumn
        '
        Me.IsCardValidDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IsCardValidDataGridViewCheckBoxColumn.DataPropertyName = "IsCardValid"
        Me.IsCardValidDataGridViewCheckBoxColumn.HeaderText = "Is Card Valid"
        Me.IsCardValidDataGridViewCheckBoxColumn.Name = "IsCardValidDataGridViewCheckBoxColumn"
        Me.IsCardValidDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'RFIDCardBindingSource
        '
        Me.RFIDCardBindingSource.DataSource = GetType(Wdw_Sust.Textile.Core.RfidCard)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnOK)
        Me.GroupBox3.Location = New System.Drawing.Point(439, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(145, 37)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'CtrlLintIdCardList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 689)
        Me.Controls.Add(Me.SplitContainer1)
        Me.EnableTimeout = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrlLintIdCardList"
        Me.Text = "ID Card List"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RFIDCardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerifyCard As System.Windows.Forms.Button
    Friend WithEvents btnAddNewCard As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnReturnCard As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCard As System.Windows.Forms.Button
    Friend WithEvents RFIDCardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RFBadgeUserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignedTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeIssuedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeUnassignedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsCardValidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnCreateLogoutCard As System.Windows.Forms.Button
    Friend WithEvents btnSearchIdNumber As Windows.Forms.Button
    Friend WithEvents txtSearchIdNumber As Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents btnFixCardOnly As Windows.Forms.Button
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
End Class


