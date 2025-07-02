<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlOpcTsaRailBlockLabel

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblRail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRail
        '
        Me.lblRail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRail.BackColor = System.Drawing.Color.White
        Me.lblRail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRail.ForeColor = System.Drawing.Color.Magenta
        Me.lblRail.Location = New System.Drawing.Point(0, 0)
        Me.lblRail.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRail.Name = "lblRail"
        Me.lblRail.Size = New System.Drawing.Size(21, 15)
        Me.lblRail.TabIndex = 1446
        Me.lblRail.Tag = "DisableCallLine[5]"
        Me.lblRail.Text = "99"
        Me.lblRail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CtrlOpcTsaRailBlockLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblRail)
        Me.Name = "CtrlOpcTsaRailBlockLabel"
        Me.Size = New System.Drawing.Size(21, 15)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblRail As System.Windows.Forms.Label

End Class
