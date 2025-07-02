Imports Wdw_Sust.Textile.Tsa.Workflow.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkflowEngineViewer
    Inherits System.Windows.Forms.Form

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
        Me.CtrlWorkflowEngineViewer1 = New CtrlTsaWorkflowEngineViewer()
        Me.SuspendLayout()
        '
        'CtrlWorkflowEngineViewer1
        '
        Me.CtrlWorkflowEngineViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlWorkflowEngineViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlWorkflowEngineViewer1.Name = "CtrlWorkflowEngineViewer1"
        Me.CtrlWorkflowEngineViewer1.Size = New System.Drawing.Size(798, 599)
        Me.CtrlWorkflowEngineViewer1.TabIndex = 0
        '
        'frmWorkflowEngineViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 599)
        Me.Controls.Add(Me.CtrlWorkflowEngineViewer1)
        Me.Name = "frmWorkflowEngineViewer"
        Me.Text = "frmWorkflowEngineViewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlWorkflowEngineViewer1 As CtrlTsaWorkflowEngineViewer
End Class
