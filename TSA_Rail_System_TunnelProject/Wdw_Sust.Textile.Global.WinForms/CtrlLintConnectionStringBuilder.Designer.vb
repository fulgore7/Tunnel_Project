
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintConnectionStringBuilder

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
        Me.ConnectionStringsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbConfigFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServerNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblConnectionNames = New System.Windows.Forms.Label()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        PasswordLabel = New System.Windows.Forms.Label()
        ServerNameLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        DatabaseNameLabel = New System.Windows.Forms.Label()
        CType(Me.ConnectionStringsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbConfigFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(298, 88)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Password:"
        '
        'ServerNameLabel
        '
        ServerNameLabel.AutoSize = True
        ServerNameLabel.Location = New System.Drawing.Point(282, 10)
        ServerNameLabel.Name = "ServerNameLabel"
        ServerNameLabel.Size = New System.Drawing.Size(72, 13)
        ServerNameLabel.TabIndex = 5
        ServerNameLabel.Text = "Server Name:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(291, 62)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 7
        UserNameLabel.Text = "User Name:"
        '
        'DatabaseNameLabel
        '
        DatabaseNameLabel.AutoSize = True
        DatabaseNameLabel.Location = New System.Drawing.Point(267, 36)
        DatabaseNameLabel.Name = "DatabaseNameLabel"
        DatabaseNameLabel.Size = New System.Drawing.Size(87, 13)
        DatabaseNameLabel.TabIndex = 11
        DatabaseNameLabel.Text = "Database Name:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringsBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(360, 85)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(217, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'ConnectionStringsBindingSource
        '
        Me.ConnectionStringsBindingSource.DataMember = "ConnectionStrings"
        Me.ConnectionStringsBindingSource.DataSource = Me.DbConfigFileBindingSource
        '
        'DbConfigFileBindingSource
        '
        Me.DbConfigFileBindingSource.DataSource = GetType(Wdw_Sust.Core.Configurations.DbConfigFile)
        '
        'ServerNameTextBox
        '
        Me.ServerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringsBindingSource, "ServerName", True))
        Me.ServerNameTextBox.Location = New System.Drawing.Point(360, 7)
        Me.ServerNameTextBox.Name = "ServerNameTextBox"
        Me.ServerNameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.ServerNameTextBox.TabIndex = 6
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringsBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(360, 59)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.UserNameTextBox.TabIndex = 8
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(502, 111)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ConnectionStringsBindingSource
        Me.ListBox1.DisplayMember = "ConnectionName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 121)
        Me.ListBox1.TabIndex = 10
        Me.ListBox1.ValueMember = "ConnectionName"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnectionStringsBindingSource, "DatabaseName", True))
        Me.TextBox1.Location = New System.Drawing.Point(360, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 12
        '
        'lblConnectionNames
        '
        Me.lblConnectionNames.AutoSize = True
        Me.lblConnectionNames.Location = New System.Drawing.Point(9, 5)
        Me.lblConnectionNames.Name = "lblConnectionNames"
        Me.lblConnectionNames.Size = New System.Drawing.Size(127, 13)
        Me.lblConnectionNames.TabIndex = 13
        Me.lblConnectionNames.Text = "Connection String Names"
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Location = New System.Drawing.Point(285, 111)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(75, 23)
        Me.btnTestConnection.TabIndex = 14
        Me.btnTestConnection.Text = "Test"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'CtrlLintConnectionStringBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 149)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.lblConnectionNames)
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
        Me.Name = "CtrlLintConnectionStringBuilder"
        Me.Text = "Connection String Settings"
        CType(Me.ConnectionStringsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbConfigFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ConnectionStringsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbConfigFileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblConnectionNames As System.Windows.Forms.Label
    Friend WithEvents btnTestConnection As System.Windows.Forms.Button
End Class

