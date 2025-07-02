<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlRfidUsbConfig
    Inherits System.Windows.Forms.Form

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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lbDevices = New System.Windows.Forms.ListBox()
        Me.btnTestReader = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxOutput = New System.Windows.Forms.TextBox()
        Me.tbxWriteCard = New System.Windows.Forms.TextBox()
        Me.btnWriteCard = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(18, 19)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(156, 37)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh Devices"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lbDevices
        '
        Me.lbDevices.FormattingEnabled = True
        Me.lbDevices.ItemHeight = 21
        Me.lbDevices.Location = New System.Drawing.Point(183, 19)
        Me.lbDevices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbDevices.Name = "lbDevices"
        Me.lbDevices.Size = New System.Drawing.Size(372, 235)
        Me.lbDevices.TabIndex = 1
        '
        'btnTestReader
        '
        Me.btnTestReader.Location = New System.Drawing.Point(50, 52)
        Me.btnTestReader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTestReader.Name = "btnTestReader"
        Me.btnTestReader.Size = New System.Drawing.Size(138, 37)
        Me.btnTestReader.TabIndex = 2
        Me.btnTestReader.Text = "Test Reader"
        Me.btnTestReader.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnWriteCard)
        Me.GroupBox1.Controls.Add(Me.tbxWriteCard)
        Me.GroupBox1.Controls.Add(Me.tbxOutput)
        Me.GroupBox1.Controls.Add(Me.btnTestReader)
        Me.GroupBox1.Location = New System.Drawing.Point(183, 267)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(374, 183)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Reader"
        '
        'tbxOutput
        '
        Me.tbxOutput.Location = New System.Drawing.Point(196, 53)
        Me.tbxOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxOutput.Multiline = True
        Me.tbxOutput.Name = "tbxOutput"
        Me.tbxOutput.Size = New System.Drawing.Size(136, 30)
        Me.tbxOutput.TabIndex = 3
        '
        'tbxWriteCard
        '
        Me.tbxWriteCard.Location = New System.Drawing.Point(196, 100)
        Me.tbxWriteCard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxWriteCard.Name = "tbxWriteCard"
        Me.tbxWriteCard.Size = New System.Drawing.Size(136, 29)
        Me.tbxWriteCard.TabIndex = 5
        '
        'btnWriteCard
        '
        Me.btnWriteCard.Location = New System.Drawing.Point(50, 99)
        Me.btnWriteCard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnWriteCard.Name = "btnWriteCard"
        Me.btnWriteCard.Size = New System.Drawing.Size(138, 37)
        Me.btnWriteCard.TabIndex = 6
        Me.btnWriteCard.Text = "Write Card"
        Me.btnWriteCard.UseVisualStyleBackColor = True
        '
        'CtrlRfidUsbConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbDevices)
        Me.Controls.Add(Me.btnRefresh)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CtrlRfidUsbConfig"
        Me.Text = "CtrlRfidUsbConfig"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lbDevices As System.Windows.Forms.ListBox
    Friend WithEvents btnTestReader As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbxOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnWriteCard As System.Windows.Forms.Button
    Friend WithEvents tbxWriteCard As System.Windows.Forms.TextBox
End Class
