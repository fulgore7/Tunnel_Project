
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CtrlLINTSerialPortSetup
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLINTSerialPortSetup))
            Me.btnSave = New System.Windows.Forms.Button
            Me.btnCancel = New System.Windows.Forms.Button
            Me.lblPortName = New System.Windows.Forms.Label
            Me.cmbPortNames = New System.Windows.Forms.ComboBox
            Me.lblBaudRate = New System.Windows.Forms.Label
            Me.txtBaudRate = New System.Windows.Forms.TextBox
            Me.lblReadTimeOut = New System.Windows.Forms.Label
            Me.txtReadTimeOut = New System.Windows.Forms.TextBox
            Me.btnDefault = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.Location = New System.Drawing.Point(109, 97)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 23)
            Me.btnSave.TabIndex = 0
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(190, 97)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'lblPortName
            '
            Me.lblPortName.AutoSize = True
            Me.lblPortName.Location = New System.Drawing.Point(61, 13)
            Me.lblPortName.Name = "lblPortName"
            Me.lblPortName.Size = New System.Drawing.Size(56, 13)
            Me.lblPortName.TabIndex = 2
            Me.lblPortName.Text = "COM Port:"
            '
            'cmbPortNames
            '
            Me.cmbPortNames.FormattingEnabled = True
            Me.cmbPortNames.Location = New System.Drawing.Point(124, 10)
            Me.cmbPortNames.Name = "cmbPortNames"
            Me.cmbPortNames.Size = New System.Drawing.Size(142, 21)
            Me.cmbPortNames.TabIndex = 3
            '
            'lblBaudRate
            '
            Me.lblBaudRate.AutoSize = True
            Me.lblBaudRate.Location = New System.Drawing.Point(56, 40)
            Me.lblBaudRate.Name = "lblBaudRate"
            Me.lblBaudRate.Size = New System.Drawing.Size(61, 13)
            Me.lblBaudRate.TabIndex = 4
            Me.lblBaudRate.Text = "Baud Rate:"
            '
            'txtBaudRate
            '
            Me.txtBaudRate.Location = New System.Drawing.Point(123, 37)
            Me.txtBaudRate.Name = "txtBaudRate"
            Me.txtBaudRate.Size = New System.Drawing.Size(142, 20)
            Me.txtBaudRate.TabIndex = 5
            '
            'lblReadTimeOut
            '
            Me.lblReadTimeOut.AutoSize = True
            Me.lblReadTimeOut.Location = New System.Drawing.Point(13, 68)
            Me.lblReadTimeOut.Name = "lblReadTimeOut"
            Me.lblReadTimeOut.Size = New System.Drawing.Size(104, 13)
            Me.lblReadTimeOut.TabIndex = 6
            Me.lblReadTimeOut.Text = "Read Time Out (ms):"
            '
            'txtReadTimeOut
            '
            Me.txtReadTimeOut.Location = New System.Drawing.Point(123, 65)
            Me.txtReadTimeOut.Name = "txtReadTimeOut"
            Me.txtReadTimeOut.Size = New System.Drawing.Size(142, 20)
            Me.txtReadTimeOut.TabIndex = 7
            '
            'btnDefault
            '
            Me.btnDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDefault.Location = New System.Drawing.Point(24, 97)
            Me.btnDefault.Name = "btnDefault"
            Me.btnDefault.Size = New System.Drawing.Size(75, 23)
            Me.btnDefault.TabIndex = 8
            Me.btnDefault.Text = "Default"
            Me.btnDefault.UseVisualStyleBackColor = True
            '
            'CtrlLINTSerialPortSetup
            '
            Me.AcceptButton = Me.btnSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(273, 132)
            Me.Controls.Add(Me.btnDefault)
            Me.Controls.Add(Me.txtReadTimeOut)
            Me.Controls.Add(Me.lblReadTimeOut)
            Me.Controls.Add(Me.txtBaudRate)
            Me.Controls.Add(Me.lblBaudRate)
            Me.Controls.Add(Me.cmbPortNames)
            Me.Controls.Add(Me.lblPortName)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "CtrlLINTSerialPortSetup"
            Me.Text = "RFID Reader Port Properties"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents lblPortName As System.Windows.Forms.Label
        Friend WithEvents cmbPortNames As System.Windows.Forms.ComboBox
        Friend WithEvents lblBaudRate As System.Windows.Forms.Label
        Friend WithEvents txtBaudRate As System.Windows.Forms.TextBox
        Friend WithEvents lblReadTimeOut As System.Windows.Forms.Label
        Friend WithEvents txtReadTimeOut As System.Windows.Forms.TextBox
        Friend WithEvents btnDefault As System.Windows.Forms.Button
    End Class

