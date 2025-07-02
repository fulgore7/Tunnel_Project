
Imports Wdw_Sust.Textile.Global.WinForms.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintChatTool
    Inherits CtrlFormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            If _client IsNot Nothing Then _client = Nothing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintChatTool))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(684, 324)
        Me.ListBox1.TabIndex = 0
        '
        'btnChat
        '
        Me.btnChat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChat.Enabled = False
        Me.btnChat.Location = New System.Drawing.Point(621, 372)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(75, 23)
        Me.btnChat.TabIndex = 1
        Me.btnChat.Text = "Chat"
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(12, 340)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(684, 26)
        Me.txtMessage.TabIndex = 4
        '
        'btnLogIn
        '
        Me.btnLogIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogIn.Location = New System.Drawing.Point(540, 372)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 377)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "No Current Log In"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TSA", "NSA", "ASA"})
        Me.ComboBox1.Location = New System.Drawing.Point(467, 374)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "TSA"
        Me.ComboBox1.Visible = False
        '
        'CtrlLINTChatTool
        '
        Me.AcceptButton = Me.btnChat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(708, 403)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(716, 437)
        Me.Name = "CtrlLINTChatTool"
        Me.Text = "Chat Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnChat As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class


