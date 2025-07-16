
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlOpcTsaBag

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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowBagDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBagIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ShowBagDetailToolStripMenuItem
        '
        Me.ShowBagDetailToolStripMenuItem.Name = "ShowBagDetailToolStripMenuItem"
        Me.ShowBagDetailToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'DeleteBagToolStripMenuItem
        '
        Me.DeleteBagToolStripMenuItem.Name = "DeleteBagToolStripMenuItem"
        Me.DeleteBagToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'ReportBagIssueToolStripMenuItem
        '
        Me.ReportBagIssueToolStripMenuItem.Name = "ReportBagIssueToolStripMenuItem"
        Me.ReportBagIssueToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'CtrlOpcTsaBag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Name = "CtrlOpcTsaBag"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowBagDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportBagIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class


