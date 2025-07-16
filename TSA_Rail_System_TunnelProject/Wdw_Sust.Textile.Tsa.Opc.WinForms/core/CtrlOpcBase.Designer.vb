Namespace Core
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CtrlOpcBase

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                If _opc IsNot Nothing Then _opc = Nothing
            End If
            _parent = Nothing
            MyBase.Dispose(disposing)
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
            'AbsOPCControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "AbsOPCControl"
            Me.Size = New System.Drawing.Size(72, 27)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
