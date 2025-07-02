<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScaleCalibration

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            _calibrationSequence = Nothing
            _spanCalibrate = Nothing
            _stationNumber = Nothing
            _zeroCalibrate = Nothing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScaleCalibration))
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnSpan = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LINTNameValuePairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CtrlOPCButton1 = New Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnStartCalibration = New System.Windows.Forms.Button()
        Me.btnCalibrationCancel = New Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcButton()
        Me.CtrlOPCLabel1 = New Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTNameValuePairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnZero
        '
        Me.btnZero.Enabled = False
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(9, 240)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(228, 57)
        Me.btnZero.TabIndex = 0
        Me.btnZero.Text = "Calibrate Zero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Press when Empty Bag in Position)"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnSpan
        '
        Me.btnSpan.Enabled = False
        Me.btnSpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpan.Location = New System.Drawing.Point(9, 326)
        Me.btnSpan.Name = "btnSpan"
        Me.btnSpan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSpan.Size = New System.Drawing.Size(228, 57)
        Me.btnSpan.TabIndex = 0
        Me.btnSpan.Text = "              Span Weight                       (Press When Span Weight added)"
        Me.btnSpan.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DataSource = Me.LINTNameValuePairBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(65, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 33)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "ID"
        '
        'LINTNameValuePairBindingSource
        '
        Me.LINTNameValuePairBindingSource.DataSource = GetType(Wdw_Sust.Textile.Core.LintNameValuePair)
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(44, 9)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(156, 25)
        Me.lblWeight.TabIndex = 3
        Me.lblWeight.Text = "Current Weight"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(9, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 49)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CtrlOPCButton1
        '
        Me.CtrlOPCButton1.GroupName = "Calibration"
        Me.CtrlOPCButton1.HighStateColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCButton1.HighStateText = "Calibration In Progress"
        Me.CtrlOPCButton1.IsSecurityFeatureUsed = True
        Me.CtrlOPCButton1.Location = New System.Drawing.Point(225, 640)
        Me.CtrlOPCButton1.LowStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton1.LowStateText = "Start Calibration"
        Me.CtrlOPCButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton1.Name = "CtrlOPCButton1"
        Me.CtrlOPCButton1.PLCName = Nothing
        Me.CtrlOPCButton1.RightNeeded = Wdw_Sust.Textile.Core.RailAccessOptions.CALIBRATION
        Me.CtrlOPCButton1.Size = New System.Drawing.Size(10, 10)
        Me.CtrlOPCButton1.TabIndex = 5
        Me.CtrlOPCButton1.TagName = "bStart_Calibration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Step 1: Select a station to calibrate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Step 2: Start calibration process"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Step 3: Verify Empty Bag then press Calibrate Zero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Step 4: Add 50lb  weights then press Span Weight"
        '
        'btnStartCalibration
        '
        Me.btnStartCalibration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartCalibration.Location = New System.Drawing.Point(9, 163)
        Me.btnStartCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartCalibration.Name = "btnStartCalibration"
        Me.btnStartCalibration.Size = New System.Drawing.Size(228, 54)
        Me.btnStartCalibration.TabIndex = 11
        Me.btnStartCalibration.Text = "               Start Calibration                  (Press After Station Selected)"
        Me.btnStartCalibration.UseVisualStyleBackColor = True
        '
        'btnCalibrationCancel
        '
        Me.btnCalibrationCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalibrationCancel.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.btnCalibrationCancel.GroupName = "Calibration"
        Me.btnCalibrationCancel.HighStateColor = System.Drawing.Color.Lime
        Me.btnCalibrationCancel.HighStateText = "Canceling Calibration"
        Me.btnCalibrationCancel.IsSecurityFeatureUsed = False
        Me.btnCalibrationCancel.Location = New System.Drawing.Point(10, 511)
        Me.btnCalibrationCancel.LowStateColor = System.Drawing.Color.Yellow
        Me.btnCalibrationCancel.LowStateText = "Press to Cancel Calibration"
        Me.btnCalibrationCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalibrationCancel.Name = "btnCalibrationCancel"
        Me.btnCalibrationCancel.PLCName = Nothing
        Me.btnCalibrationCancel.RightNeeded = Wdw_Sust.Textile.Core.RailAccessOptions.UNKNOWN
        Me.btnCalibrationCancel.Size = New System.Drawing.Size(228, 47)
        Me.btnCalibrationCancel.TabIndex = 16
        Me.btnCalibrationCancel.TagName = "bCalibrationReset"
        '
        'CtrlOPCLabel1
        '
        Me.CtrlOPCLabel1.BackColor = System.Drawing.Color.White
        Me.CtrlOPCLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCLabel1.ForeColor = System.Drawing.Color.Red
        Me.CtrlOPCLabel1.GroupName = Nothing
        Me.CtrlOPCLabel1.Location = New System.Drawing.Point(14, 689)
        Me.CtrlOPCLabel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CtrlOPCLabel1.Name = "CtrlOPCLabel1"
        Me.CtrlOPCLabel1.PLCName = Nothing
        Me.CtrlOPCLabel1.Size = New System.Drawing.Size(338, 74)
        Me.CtrlOPCLabel1.TabIndex = 17
        Me.CtrlOPCLabel1.TagName = Nothing
        Me.CtrlOPCLabel1.TextToDisplay = Nothing
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(6, 389)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(231, 91)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "Error: Scale Did Not Zero           (Empty Weight greater than +/- 2 pounds or No" &
    "t changing from 0.00)"
        Me.TextBox2.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Red
        Me.TextBox4.Location = New System.Drawing.Point(8, 389)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(231, 91)
        Me.TextBox4.TabIndex = 23
        Me.TextBox4.Text = " Please remove the Weights from Bag"
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Red
        Me.TextBox5.Location = New System.Drawing.Point(7, 389)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(231, 91)
        Me.TextBox5.TabIndex = 24
        Me.TextBox5.Text = "Error: DeviceNet Communication Error. Check PLC module status. Press Cancel to Re" &
    "try"
        Me.TextBox5.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Aqua
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Green
        Me.TextBox7.Location = New System.Drawing.Point(7, 389)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(231, 91)
        Me.TextBox7.TabIndex = 26
        Me.TextBox7.Text = "PLC Processing...Please Wait"
        Me.TextBox7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(12, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "C2 Scale"
        '
        'frmScaleCalibration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 567)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CtrlOPCLabel1)
        Me.Controls.Add(Me.btnCalibrationCancel)
        Me.Controls.Add(Me.btnStartCalibration)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CtrlOPCButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSpan)
        Me.Controls.Add(Me.btnZero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScaleCalibration"
        Me.Text = "Scale Calibration"
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTNameValuePairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnSpan As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LINTNameValuePairBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CtrlOPCButton1 As Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnStartCalibration As System.Windows.Forms.Button
    Friend WithEvents btnCalibrationCancel As Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcButton
    Friend WithEvents CtrlOPCLabel1 As Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcLabel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
