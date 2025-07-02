Imports Wdw_Sust.Textile.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCleanExpressProduct

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCleanExpressProduct))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LINTCategoryDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.LINTCategoryDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.LINTCategoryDetailBindingSource
        Me.ComboBox1.DisplayMember = "DisplayInfo"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(376, 33)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CategoryID"
        '
        'LINTCategoryDetailBindingSource
        '
        Me.LINTCategoryDetailBindingSource.DataSource = GetType(LintCategoryDetail)
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(313, 51)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(232, 51)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmCleanExpressProduct
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(400, 82)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCleanExpressProduct"
        Me.Text = "Express Product"
        CType(Me.LINTCategoryDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LINTCategoryDetailBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents btnApply As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
End Class
