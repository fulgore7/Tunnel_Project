
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Namespace Core
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CtrlOpcBagBase
        Inherits CtrlOpcBase


        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            _categoryDetail = Nothing
            _bagDetail = Nothing
            '            _dragManager = Nothing
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
            Me.SendBagToMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowBagDetailToolStripMenuItem, Me.DeleteBagToolStripMenuItem, Me.ReportBagIssueToolStripMenuItem, Me.SendBagToMaintenanceToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(213, 92)
            '
            'ShowBagDetailToolStripMenuItem
            '
            Me.ShowBagDetailToolStripMenuItem.Name = "ShowBagDetailToolStripMenuItem"
            Me.ShowBagDetailToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
            Me.ShowBagDetailToolStripMenuItem.Text = "Show Bag Detail"
            '
            'DeleteBagToolStripMenuItem
            '
            Me.DeleteBagToolStripMenuItem.Name = "DeleteBagToolStripMenuItem"
            Me.DeleteBagToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
            Me.DeleteBagToolStripMenuItem.Text = "Delete Bag"
            Me.DeleteBagToolStripMenuItem.Visible = False
            '
            'ReportBagIssueToolStripMenuItem
            '
            Me.ReportBagIssueToolStripMenuItem.Name = "ReportBagIssueToolStripMenuItem"
            Me.ReportBagIssueToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
            Me.ReportBagIssueToolStripMenuItem.Text = "Report Bag Issue"
            '
            'SendBagToMaintenanceToolStripMenuItem
            '
            Me.SendBagToMaintenanceToolStripMenuItem.Name = "SendBagToMaintenanceToolStripMenuItem"
            Me.SendBagToMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
            Me.SendBagToMaintenanceToolStripMenuItem.Text = "Send Bag To Maintenance"
            '
            'CtrlOpcBagBase
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
            Me.BackColor = System.Drawing.Color.White
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(5)
            Me.Name = "CtrlOpcBagBase"
            Me.Size = New System.Drawing.Size(36, 36)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ShowBagDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DeleteBagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ReportBagIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SendBagToMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace



