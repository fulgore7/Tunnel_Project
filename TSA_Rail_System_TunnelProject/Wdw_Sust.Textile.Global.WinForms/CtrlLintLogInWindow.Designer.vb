Imports Wdw_Sust.Textile.Global.WinForms.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintLogInWindow
    Inherits CtrlFormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintLogInWindow))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please Login"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.CausesValidation = False
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(12, 250)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(218, 212)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MaskedTextBox1.Size = New System.Drawing.Size(152, 20)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(309, 250)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubmit.TabIndex = 4
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CtrlLintLogInWindow
        '
        Me.AcceptButton = Me.ButtonSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CtrlLintLogInWindow"
        Me.ShowInTaskbar = False
        Me.Text = "Login Window"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
