Imports Wdw_Sust.Textile.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWashdeckProductivity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWashdeckProductivity))
        Me.PivotGridControl2 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.TSAWashdeckProductivityDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fieldTotalCount = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCategoryCode = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHour = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMahcineName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalWeight = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.chkAutoUpdate = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSAWashdeckProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl2
        '
        Me.PivotGridControl2.DataSource = Me.TSAWashdeckProductivityDataBindingSource
        Me.PivotGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldTotalCount, Me.fieldCategoryCode, Me.fieldHour, Me.fieldMahcineName, Me.fieldTotalWeight})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.GreenYellow
        PivotGridStyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition1.ApplyToTotalCell = False
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition1.Expression = "[TotalCount] >= 25  And [TotalCount] != 0"
        PivotGridStyleFormatCondition1.FieldName = ""
        PivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition2.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition2.ApplyToTotalCell = False
        PivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition2.Expression = "[TotalCount] <= 15 And [TotalCount] > 0"
        PivotGridStyleFormatCondition2.FieldName = ""
        Me.PivotGridControl2.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1, PivotGridStyleFormatCondition2})
        Me.PivotGridControl2.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl2.Size = New System.Drawing.Size(1284, 324)
        Me.PivotGridControl2.TabIndex = 1
        '
        'TSAWashdeckProductivityDataBindingSource
        '
        Me.TSAWashdeckProductivityDataBindingSource.DataSource = GetType(LintWashdeckProductivityData)
        '
        'fieldTotalCount
        '
        Me.fieldTotalCount.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldTotalCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTotalCount.AreaIndex = 0
        Me.fieldTotalCount.Caption = "Bag Drops"
        Me.fieldTotalCount.FieldName = "TotalCount"
        Me.fieldTotalCount.Name = "fieldTotalCount"
        Me.fieldTotalCount.SortBySummaryInfo.CustomTotalSummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldTotalCount.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'fieldCategoryCode
        '
        Me.fieldCategoryCode.AreaIndex = 0
        Me.fieldCategoryCode.Caption = "Categories"
        Me.fieldCategoryCode.FieldName = "CategoryCode"
        Me.fieldCategoryCode.Name = "fieldCategoryCode"
        Me.fieldCategoryCode.Options.ShowTotals = False
        '
        'fieldHour
        '
        Me.fieldHour.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldHour.AreaIndex = 0
        Me.fieldHour.Caption = "Hour"
        Me.fieldHour.FieldName = "Hour"
        Me.fieldHour.Name = "fieldHour"
        Me.fieldHour.Width = 66
        '
        'fieldMahcineName
        '
        Me.fieldMahcineName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMahcineName.AreaIndex = 0
        Me.fieldMahcineName.Caption = "Tunnels"
        Me.fieldMahcineName.FieldName = "MahcineName"
        Me.fieldMahcineName.Name = "fieldMahcineName"
        Me.fieldMahcineName.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldMahcineName.Width = 79
        '
        'fieldTotalWeight
        '
        Me.fieldTotalWeight.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldTotalWeight.AreaIndex = 1
        Me.fieldTotalWeight.Caption = "Weight"
        Me.fieldTotalWeight.FieldName = "TotalWeight"
        Me.fieldTotalWeight.Name = "fieldTotalWeight"
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoUpdate.Location = New System.Drawing.Point(1183, 5)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAutoUpdate.Properties.Appearance.Options.UseBackColor = True
        Me.chkAutoUpdate.Properties.Caption = "Auto Update"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(89, 19)
        Me.chkAutoUpdate.TabIndex = 2
        '
        'frmWashdeckProductivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 324)
        Me.Controls.Add(Me.chkAutoUpdate)
        Me.Controls.Add(Me.PivotGridControl2)
        Me.EnableTimeout = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWashdeckProductivity"
        Me.Text = "Washdeck Productivity"
        Me.TimeoutInSeconds = 60
        Me.Controls.SetChildIndex(Me.PivotGridControl2, 0)
        Me.Controls.SetChildIndex(Me.chkAutoUpdate, 0)
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSAWashdeckProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSAWashdeckProductivityDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PivotGridControl2 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldTotalCount As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCategoryCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHour As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMahcineName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents chkAutoUpdate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents fieldTotalWeight As DevExpress.XtraPivotGrid.PivotGridField
End Class
