Imports Wdw_Sust.Textile.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCastMemberShiftData

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
        Dim PivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
        Dim PivotGridStyleFormatCondition2 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
        Dim PivotGridStyleFormatCondition3 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
        Dim PivotGridStyleFormatCondition4 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCastMemberShiftData))
        Me.PivotGridControl2 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.LINTCastMemberProductivityElectronicBoardDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fieldDepartment = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEfficiency = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHour = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEmployeeName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.chkAutoUpdate = New DevExpress.XtraEditors.CheckEdit()
        Me.fieldLoginTimeInMinutes = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldActualCounts = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTargetCounts = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTCastMemberProductivityElectronicBoardDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl2
        '
        Me.PivotGridControl2.DataSource = Me.LINTCastMemberProductivityElectronicBoardDataBindingSource
        Me.PivotGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldDepartment, Me.fieldEfficiency, Me.fieldHour, Me.fieldEmployeeName, Me.fieldLoginTimeInMinutes, Me.fieldActualCounts, Me.fieldTargetCounts})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition1.Expression = "[Efficiency]<=.7  And  NOT IsNullOrEmpty([Efficiency])"
        PivotGridStyleFormatCondition1.FieldName = ""
        PivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
        PivotGridStyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Honeydew
        PivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition2.Expression = "[Efficiency]>.95"
        PivotGridStyleFormatCondition2.FieldName = ""
        PivotGridStyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition3.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition3.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition3.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition3.ApplyToTotalCell = False
        PivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition3.Expression = "[LoginTimeInMinutes] < 30"
        PivotGridStyleFormatCondition3.FieldName = ""
        PivotGridStyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Lime
        PivotGridStyleFormatCondition4.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition4.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition4.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition4.ApplyToTotalCell = False
        PivotGridStyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition4.Expression = "[LoginTimeInMinutes] >= 45"
        PivotGridStyleFormatCondition4.FieldName = ""
        Me.PivotGridControl2.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1, PivotGridStyleFormatCondition2, PivotGridStyleFormatCondition3, PivotGridStyleFormatCondition4})
        PivotGridGroup1.Caption = "DepartmentGroup"
        PivotGridGroup1.Hierarchy = Nothing
        Me.PivotGridControl2.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl2.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl2.Size = New System.Drawing.Size(1284, 895)
        Me.PivotGridControl2.TabIndex = 1
        '
        'LINTCastMemberProductivityElectronicBoardDataBindingSource
        '
        Me.LINTCastMemberProductivityElectronicBoardDataBindingSource.DataSource = GetType(LintCastMemberProductivityElectronicBoardData)
        '
        'fieldDepartment
        '
        Me.fieldDepartment.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
        Me.fieldDepartment.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDepartment.AreaIndex = 0
        Me.fieldDepartment.FieldName = "Department"
        Me.fieldDepartment.Name = "fieldDepartment"
        Me.fieldDepartment.Width = 75
        '
        'fieldEfficiency
        '
        Me.fieldEfficiency.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldEfficiency.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEfficiency.AreaIndex = 0
        Me.fieldEfficiency.CellFormat.FormatString = "p"
        Me.fieldEfficiency.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldEfficiency.FieldName = "Efficiency"
        Me.fieldEfficiency.GrandTotalText = "Ave. Efficiency"
        Me.fieldEfficiency.Name = "fieldEfficiency"
        Me.fieldEfficiency.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        Me.fieldEfficiency.Width = 65
        '
        'fieldHour
        '
        Me.fieldHour.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
        Me.fieldHour.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldHour.AreaIndex = 0
        Me.fieldHour.FieldName = "Hour"
        Me.fieldHour.Name = "fieldHour"
        Me.fieldHour.Width = 65
        '
        'fieldEmployeeName
        '
        Me.fieldEmployeeName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
        Me.fieldEmployeeName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEmployeeName.AreaIndex = 1
        Me.fieldEmployeeName.Caption = "Name"
        Me.fieldEmployeeName.FieldName = "EmployeeName"
        Me.fieldEmployeeName.Name = "fieldEmployeeName"
        Me.fieldEmployeeName.Width = 175
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoUpdate.Location = New System.Drawing.Point(1162, 5)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAutoUpdate.Properties.Appearance.Options.UseBackColor = True
        Me.chkAutoUpdate.Properties.Caption = "Auto Update"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(89, 19)
        Me.chkAutoUpdate.TabIndex = 2
        '
        'fieldLoginTimeInMinutes
        '
        Me.fieldLoginTimeInMinutes.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldLoginTimeInMinutes.AreaIndex = 0
        Me.fieldLoginTimeInMinutes.Caption = "Log In"
        Me.fieldLoginTimeInMinutes.CellFormat.FormatString = "F1"
        Me.fieldLoginTimeInMinutes.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldLoginTimeInMinutes.FieldName = "LoginTimeInMinutes"
        Me.fieldLoginTimeInMinutes.Name = "fieldLoginTimeInMinutes"
        Me.fieldLoginTimeInMinutes.Width = 65
        '
        'fieldActualCounts
        '
        Me.fieldActualCounts.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldActualCounts.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldActualCounts.AreaIndex = 1
        Me.fieldActualCounts.Caption = "Actual"
        Me.fieldActualCounts.FieldName = "ActualCounts"
        Me.fieldActualCounts.Name = "fieldActualCounts"
        Me.fieldActualCounts.Visible = False
        Me.fieldActualCounts.Width = 42
        '
        'fieldTargetCounts
        '
        Me.fieldTargetCounts.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldTargetCounts.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldTargetCounts.AreaIndex = 1
        Me.fieldTargetCounts.Caption = "Target"
        Me.fieldTargetCounts.FieldName = "TargetCounts"
        Me.fieldTargetCounts.Name = "fieldTargetCounts"
        Me.fieldTargetCounts.Visible = False
        Me.fieldTargetCounts.Width = 42
        '
        'frmCastElectronicBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 895)
        Me.Controls.Add(Me.chkAutoUpdate)
        Me.Controls.Add(Me.PivotGridControl2)
        Me.EnableTimeout = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCastElectronicBoard"
        Me.Text = "Washdeck Productivity"
        Me.TimeoutInSeconds = 60
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTCastMemberProductivityElectronicBoardDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl2 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents chkAutoUpdate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LINTCastMemberProductivityElectronicBoardDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents fieldDepartment As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEfficiency As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHour As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEmployeeName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLoginTimeInMinutes As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldActualCounts As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTargetCounts As DevExpress.XtraPivotGrid.PivotGridField
End Class
