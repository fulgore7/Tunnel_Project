
Imports Wdw_Sust.Textile.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintAlarmViewer
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        LINTAlarmBindingSource.DataSource = Nothing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintAlarmViewer))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.LINTAlarmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SystemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ZoneDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlarmIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlarmDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlarmDuration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlarmStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTAlarmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SystemDescription, Me.ZoneDescription, Me.AlarmIDDataGridViewTextBoxColumn, Me.AlarmDescriptionDataGridViewTextBoxColumn, Me.AlarmDuration, Me.AlarmStartTime})
        Me.DataGridView1.DataSource = Me.LINTAlarmBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1431, 667)
        Me.DataGridView1.TabIndex = 0
        '
        'LINTAlarmBindingSource
        '
        Me.LINTAlarmBindingSource.DataSource = GetType(LintAlarm)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 673.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1437, 713)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 34)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Get Current Alarms"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SystemDescription
        '
        Me.SystemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SystemDescription.DataPropertyName = "SystemDescription"
        Me.SystemDescription.HeaderText = "System"
        Me.SystemDescription.Name = "SystemDescription"
        Me.SystemDescription.ReadOnly = True
        Me.SystemDescription.Width = 66
        '
        'ZoneDescription
        '
        Me.ZoneDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZoneDescription.DataPropertyName = "ZoneDescription"
        Me.ZoneDescription.HeaderText = "Zone"
        Me.ZoneDescription.Name = "ZoneDescription"
        Me.ZoneDescription.ReadOnly = True
        Me.ZoneDescription.Width = 57
        '
        'AlarmIDDataGridViewTextBoxColumn
        '
        Me.AlarmIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AlarmIDDataGridViewTextBoxColumn.DataPropertyName = "AlarmID"
        Me.AlarmIDDataGridViewTextBoxColumn.HeaderText = "Alarm ID"
        Me.AlarmIDDataGridViewTextBoxColumn.Name = "AlarmIDDataGridViewTextBoxColumn"
        Me.AlarmIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlarmIDDataGridViewTextBoxColumn.Width = 72
        '
        'AlarmDescriptionDataGridViewTextBoxColumn
        '
        Me.AlarmDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AlarmDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AlarmDescription"
        Me.AlarmDescriptionDataGridViewTextBoxColumn.HeaderText = "Alarm Description"
        Me.AlarmDescriptionDataGridViewTextBoxColumn.Name = "AlarmDescriptionDataGridViewTextBoxColumn"
        Me.AlarmDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlarmDescriptionDataGridViewTextBoxColumn.Width = 105
        '
        'AlarmDuration
        '
        Me.AlarmDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AlarmDuration.DataPropertyName = "DisplayAlarmDuration"
        Me.AlarmDuration.HeaderText = "Duration"
        Me.AlarmDuration.Name = "AlarmDuration"
        Me.AlarmDuration.ReadOnly = True
        Me.AlarmDuration.Width = 72
        '
        'AlarmStartTime
        '
        Me.AlarmStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AlarmStartTime.DataPropertyName = "AlarmStartTime"
        Me.AlarmStartTime.HeaderText = "Alarm Start Time"
        Me.AlarmStartTime.Name = "AlarmStartTime"
        Me.AlarmStartTime.ReadOnly = True
        '
        'CtrlLINTAlarmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 267)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CtrlLINTAlarmViewer"
        Me.Text = "Alarm Viewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTAlarmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LINTAlarmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SystemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZoneDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmDuration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlarmStartTime As System.Windows.Forms.DataGridViewTextBoxColumn
End Class


