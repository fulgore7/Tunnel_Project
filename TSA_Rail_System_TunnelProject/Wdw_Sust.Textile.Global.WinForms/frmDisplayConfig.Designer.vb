<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayConfig
    Inherits CtrlLightFormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayConfig))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDefaultForm = New System.Windows.Forms.Label()
        Me.cbxDefaultForm = New System.Windows.Forms.ComboBox()
        Me.chbxCenterForm = New System.Windows.Forms.CheckBox()
        Me.chbxShowChildFormBorder = New System.Windows.Forms.CheckBox()
        Me.chbxLaunchMaximized = New System.Windows.Forms.CheckBox()
        Me.chbxShowToolbar = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDefaultForm, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxDefaultForm, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chbxCenterForm, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chbxShowChildFormBorder, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chbxLaunchMaximized, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chbxShowToolbar, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(245, 231)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblDefaultForm
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblDefaultForm, 2)
        Me.lblDefaultForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDefaultForm.Location = New System.Drawing.Point(3, 0)
        Me.lblDefaultForm.Name = "lblDefaultForm"
        Me.lblDefaultForm.Size = New System.Drawing.Size(239, 30)
        Me.lblDefaultForm.TabIndex = 0
        Me.lblDefaultForm.Text = "Default Form"
        Me.lblDefaultForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxDefaultForm
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbxDefaultForm, 2)
        Me.cbxDefaultForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDefaultForm.FormattingEnabled = True
        Me.cbxDefaultForm.Location = New System.Drawing.Point(3, 33)
        Me.cbxDefaultForm.Name = "cbxDefaultForm"
        Me.cbxDefaultForm.Size = New System.Drawing.Size(239, 21)
        Me.cbxDefaultForm.TabIndex = 1
        '
        'chbxCenterForm
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.chbxCenterForm, 2)
        Me.chbxCenterForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbxCenterForm.Location = New System.Drawing.Point(3, 63)
        Me.chbxCenterForm.Name = "chbxCenterForm"
        Me.chbxCenterForm.Size = New System.Drawing.Size(239, 17)
        Me.chbxCenterForm.TabIndex = 2
        Me.chbxCenterForm.Text = "Center Default Child Form"
        Me.chbxCenterForm.UseVisualStyleBackColor = True
        '
        'chbxShowChildFormBorder
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.chbxShowChildFormBorder, 2)
        Me.chbxShowChildFormBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbxShowChildFormBorder.Location = New System.Drawing.Point(3, 86)
        Me.chbxShowChildFormBorder.Name = "chbxShowChildFormBorder"
        Me.chbxShowChildFormBorder.Size = New System.Drawing.Size(239, 25)
        Me.chbxShowChildFormBorder.TabIndex = 3
        Me.chbxShowChildFormBorder.Text = "Show Child Form Border"
        Me.chbxShowChildFormBorder.UseVisualStyleBackColor = True
        '
        'chbxLaunchMaximized
        '
        Me.chbxLaunchMaximized.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chbxLaunchMaximized, 2)
        Me.chbxLaunchMaximized.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbxLaunchMaximized.Location = New System.Drawing.Point(3, 117)
        Me.chbxLaunchMaximized.Name = "chbxLaunchMaximized"
        Me.chbxLaunchMaximized.Size = New System.Drawing.Size(239, 24)
        Me.chbxLaunchMaximized.TabIndex = 4
        Me.chbxLaunchMaximized.Text = "Launch Main Form Maximized"
        Me.chbxLaunchMaximized.UseVisualStyleBackColor = True
        '
        'chbxShowToolbar
        '
        Me.chbxShowToolbar.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chbxShowToolbar, 2)
        Me.chbxShowToolbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbxShowToolbar.Location = New System.Drawing.Point(3, 147)
        Me.chbxShowToolbar.Name = "chbxShowToolbar"
        Me.chbxShowToolbar.Size = New System.Drawing.Size(239, 24)
        Me.chbxShowToolbar.TabIndex = 5
        Me.chbxShowToolbar.Text = "Show Toolbar on Main Form"
        Me.chbxShowToolbar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancel.Location = New System.Drawing.Point(44, 191)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(125, 191)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmDisplayConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 231)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDisplayConfig"
        Me.Text = "Display Configuration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDefaultForm As System.Windows.Forms.Label
    Friend WithEvents cbxDefaultForm As System.Windows.Forms.ComboBox
    Friend WithEvents chbxCenterForm As System.Windows.Forms.CheckBox
    Friend WithEvents chbxShowChildFormBorder As System.Windows.Forms.CheckBox
    Friend WithEvents chbxLaunchMaximized As System.Windows.Forms.CheckBox
    Friend WithEvents chbxShowToolbar As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
