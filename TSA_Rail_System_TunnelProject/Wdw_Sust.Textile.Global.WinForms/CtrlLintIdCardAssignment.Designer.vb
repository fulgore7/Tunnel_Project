
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintIdCardAssignment


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintIdCardAssignment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnAssignCard = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbScanIDNumber = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.btnStep3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbIDNumber = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnStep2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnStep1 = New System.Windows.Forms.Button()
        Me.GroupBoxReason = New System.Windows.Forms.GroupBox()
        Me.cmbReason = New System.Windows.Forms.ComboBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxReason.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBoxReason)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assign ID Card Checklist"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(199, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 32)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnAssignCard)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(520, 71)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Assign and Issue ID Card"
        '
        'btnAssignCard
        '
        Me.btnAssignCard.Enabled = False
        Me.btnAssignCard.Location = New System.Drawing.Point(167, 19)
        Me.btnAssignCard.Name = "btnAssignCard"
        Me.btnAssignCard.Size = New System.Drawing.Size(155, 32)
        Me.btnAssignCard.TabIndex = 0
        Me.btnAssignCard.Text = "Assign ID Card"
        Me.btnAssignCard.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.tbScanIDNumber)
        Me.GroupBox4.Controls.Add(Me.CheckBox3)
        Me.GroupBox4.Controls.Add(Me.btnStep3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 71)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Verify ID Card"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Scan ID Card"
        '
        'tbScanIDNumber
        '
        Me.tbScanIDNumber.Enabled = False
        Me.tbScanIDNumber.Location = New System.Drawing.Point(181, 26)
        Me.tbScanIDNumber.Multiline = True
        Me.tbScanIDNumber.Name = "tbScanIDNumber"
        Me.tbScanIDNumber.Size = New System.Drawing.Size(320, 32)
        Me.tbScanIDNumber.TabIndex = 2
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(137, 30)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "OK"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'btnStep3
        '
        Me.btnStep3.Enabled = False
        Me.btnStep3.Location = New System.Drawing.Point(15, 26)
        Me.btnStep3.Name = "btnStep3"
        Me.btnStep3.Size = New System.Drawing.Size(116, 32)
        Me.btnStep3.TabIndex = 0
        Me.btnStep3.Text = "Step 3"
        Me.btnStep3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbIDNumber)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.btnStep2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 71)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Assign ID Card Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select ID Card From List"
        '
        'tbIDNumber
        '
        Me.tbIDNumber.Enabled = False
        Me.tbIDNumber.Location = New System.Drawing.Point(181, 26)
        Me.tbIDNumber.Multiline = True
        Me.tbIDNumber.Name = "tbIDNumber"
        Me.tbIDNumber.Size = New System.Drawing.Size(320, 32)
        Me.tbIDNumber.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(137, 30)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "OK"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnStep2
        '
        Me.btnStep2.Enabled = False
        Me.btnStep2.Location = New System.Drawing.Point(15, 26)
        Me.btnStep2.Name = "btnStep2"
        Me.btnStep2.Size = New System.Drawing.Size(116, 32)
        Me.btnStep2.TabIndex = 0
        Me.btnStep2.Text = "Step 2"
        Me.btnStep2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbLastName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbFirstName)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.btnStep1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 71)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'tbFirstName
        '
        Me.tbFirstName.Enabled = False
        Me.tbFirstName.Location = New System.Drawing.Point(181, 26)
        Me.tbFirstName.Multiline = True
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(142, 32)
        Me.tbFirstName.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(137, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "OK"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnStep1
        '
        Me.btnStep1.Location = New System.Drawing.Point(15, 26)
        Me.btnStep1.Name = "btnStep1"
        Me.btnStep1.Size = New System.Drawing.Size(116, 32)
        Me.btnStep1.TabIndex = 0
        Me.btnStep1.Text = "Step 1"
        Me.btnStep1.UseVisualStyleBackColor = True
        '
        'GroupBoxReason
        '
        Me.GroupBoxReason.Controls.Add(Me.cmbReason)
        Me.GroupBoxReason.Enabled = False
        Me.GroupBoxReason.Location = New System.Drawing.Point(12, 251)
        Me.GroupBoxReason.Name = "GroupBoxReason"
        Me.GroupBoxReason.Size = New System.Drawing.Size(520, 39)
        Me.GroupBoxReason.TabIndex = 6
        Me.GroupBoxReason.TabStop = False
        Me.GroupBoxReason.Text = "Reason of Card Assignment"
        '
        'cmbReason
        '
        Me.cmbReason.FormattingEnabled = True
        Me.cmbReason.Items.AddRange(New Object() {"1 - Card Assigned to New Cast Member Or United Temp", "2 - Card Assigned to Existing Cast Member or United Temp for the First Time", "3 - Card Lost", "4 - Card Malfunction (Card Returned to Us)", "5 - Change Cast Member Status From United Temp to Regular"})
        Me.cmbReason.Location = New System.Drawing.Point(6, 14)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(508, 21)
        Me.cmbReason.TabIndex = 5
        '
        'tbLastName
        '
        Me.tbLastName.Enabled = False
        Me.tbLastName.Location = New System.Drawing.Point(360, 26)
        Me.tbLastName.Multiline = True
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(142, 32)
        Me.tbLastName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(357, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Last Name"
        '
        'CtrlIDCardAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 422)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CtrlIDCardAssignment"
        Me.Text = "User ID Card Assignment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxReason.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnStep1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnStep2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAssignCard As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbScanIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents btnStep3 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbReason As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxReason As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
End Class


