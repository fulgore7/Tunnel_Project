
Namespace Core
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CtrlUserControlBase
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                'JobManager = Nothing
                'CONFIGURATION = Nothing
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
            Me.components = New System.ComponentModel.Container
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.SuspendLayout()
            '
            'LintUserControlBase
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "LintUserControlBase"
            Me.Size = New System.Drawing.Size(71, 57)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    End Class
End Namespace