
Imports Wdw_Sust.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintConnectionStringBuilderOld

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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim ServerNameLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim DatabaseNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintConnectionStringBuilder))
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConnectionStringBuilderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServerNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SqlConnectionStringBuilderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        PasswordLabel = New System.Windows.Forms.Label()
        ServerNameLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        DatabaseNameLabel = New System.Windows.Forms.Label()
        CType(Me.ConnectionStringBuilderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqlConnectionStringBuilderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(500, 93)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Password:"
        '
        'ServerNameLabel
        '
        ServerNameLabel.AutoSize = True
        ServerNameLabel.Location = New System.Drawing.Point(484, 15)
        ServerNameLabel.Name = "ServerNameLabel"
        ServerNameLabel.Size = New System.Drawing.Size(72, 13)
        ServerNameLabel.TabIndex = 5
        ServerNameLabel.Text = "Server Name:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(493, 67)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 7
        UserNameLabel.Text = "User Name:"
        '
        'DatabaseNameLabel
        '
        DatabaseNameLabel.AutoSize = True
        DatabaseNameLabel.Location = New System.Drawing.Point(469, 41)
        DatabaseNameLabel.Name = "DatabaseNameLabel"
        DatabaseNameLabel.Size = New System.Drawing.Size(87, 13)
        DatabaseNameLabel.TabIndex = 11
        DatabaseNameLabel.Text = "Database Name:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringBuilderBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(562, 90)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(217, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'ConnectionStringBuilderBindingSource
        '
        Me.ConnectionStringBuilderBindingSource.DataSource = GetType(ConnectionStringBuilder)
        '
        'ServerNameTextBox
        '
        Me.ServerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringBuilderBindingSource, "ServerName", True))
        Me.ServerNameTextBox.Location = New System.Drawing.Point(562, 12)
        Me.ServerNameTextBox.Name = "ServerNameTextBox"
        Me.ServerNameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.ServerNameTextBox.TabIndex = 6
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringBuilderBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(562, 64)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.UserNameTextBox.TabIndex = 8
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(704, 116)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(450, 134)
        Me.ListBox1.TabIndex = 10
        '
        'SqlConnectionStringBuilderBindingSource
        '
        Me.SqlConnectionStringBuilderBindingSource.DataSource = GetType(System.Data.SqlClient.SqlConnectionStringBuilder)
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringBuilderBindingSource, "DatabaseName", True))
        Me.TextBox1.Location = New System.Drawing.Point(562, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 12
        '
        'CtrlLINTConnectionStringBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 156)
        Me.Controls.Add(DatabaseNameLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(ServerNameLabel)
        Me.Controls.Add(Me.ServerNameTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CtrlLINTConnectionStringBuilder"
        Me.Text = "Connection String Settings"
        CType(Me.ConnectionStringBuilderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqlConnectionStringBuilderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConnectionStringBuilderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SqlConnectionStringBuilderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

