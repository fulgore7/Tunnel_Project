Namespace Core
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CtrlFormBase
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        '<System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            If _timeoutManager IsNot Nothing Then
                _timeoutManager.Dispose()
                _timeoutManager = Nothing
            End If
            If _parentForm IsNot Nothing Then _parentForm = Nothing
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'LintFormBase
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(168, 132)
            Me.DoubleBuffered = True
            Me.Name = "LintFormBase"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "LintFormBase"
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace