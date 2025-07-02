
Imports Wdw_Sust.Textile.Global.WinForms.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintAppMonitoring

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLINTAppMonitoring))
        Me.btnChangeStatus = New System.Windows.Forms.Button()
        Me.lblComputerName = New System.Windows.Forms.Label()
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChangeStatus
        '
        Me.btnChangeStatus.Location = New System.Drawing.Point(12, 66)
        Me.btnChangeStatus.Name = "btnChangeStatus"
        Me.btnChangeStatus.Size = New System.Drawing.Size(261, 39)
        Me.btnChangeStatus.TabIndex = 0
        Me.btnChangeStatus.Text = "Change Status"
        Me.btnChangeStatus.UseVisualStyleBackColor = True
        '
        'lblComputerName
        '
        Me.lblComputerName.AutoSize = True
        Me.lblComputerName.Location = New System.Drawing.Point(12, 9)
        Me.lblComputerName.Name = "lblComputerName"
        Me.lblComputerName.Size = New System.Drawing.Size(83, 13)
        Me.lblComputerName.TabIndex = 1
        Me.lblComputerName.Text = "Computer Name"
        '
        'lblApplication
        '
        Me.lblApplication.AutoSize = True
        Me.lblApplication.Location = New System.Drawing.Point(12, 40)
        Me.lblApplication.Name = "lblApplication"
        Me.lblApplication.Size = New System.Drawing.Size(59, 13)
        Me.lblApplication.TabIndex = 2
        Me.lblApplication.Text = "Application"
        '
        'CtrlLINTAppMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 114)
        Me.Controls.Add(Me.lblApplication)
        Me.Controls.Add(Me.lblComputerName)
        Me.Controls.Add(Me.btnChangeStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(301, 152)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(301, 152)
        Me.Name = "CtrlLINTAppMonitoring"
        Me.Text = "Application Monitoring Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChangeStatus As System.Windows.Forms.Button
    Friend WithEvents lblComputerName As System.Windows.Forms.Label
    Friend WithEvents lblApplication As System.Windows.Forms.Label
End Class


