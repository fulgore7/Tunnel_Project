Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.WinForms
Imports Wdw_Sust.Textile.Global.WinForms.DevExp

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSortingProductivity


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSortingProductivity))
        Me.ctrlBeltA = New CtrlLintProductivityGauge()
        Me.ctrlBeltB = New CtrlLintProductivityGauge()
        Me.ctrlBeltC = New CtrlLintProductivityGauge()
        Me.ctrlBeltD = New CtrlLintProductivityGauge()
        Me.ctrlBeltTotal = New CtrlLintProductivityGauge()
        Me.TSAMachineHourlyProductivityDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.TSASortingProductivityDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fieldHour = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalCount = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTotalWeight = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBelt = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCategoryCode = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl2 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.TSACartDumpProductivityDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fieldHour1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNumOperations = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.TSAMachineHourlyProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSASortingProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSACartDumpProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctrlBeltA
        '
        Me.ctrlBeltA.Actual = 0.0!
        Me.ctrlBeltA.EffectRange = 0.004!
        Me.ctrlBeltA.Location = New System.Drawing.Point(518, 5)
        Me.ctrlBeltA.MaximumSize = New System.Drawing.Size(600, 600)
        Me.ctrlBeltA.Name = "ctrlBeltA"
        Me.ctrlBeltA.Size = New System.Drawing.Size(322, 208)
        Me.ctrlBeltA.TabIndex = 0
        Me.ctrlBeltA.Title = "Belt A"
        Me.ctrlBeltA.Total = 0.0!
        Me.ctrlBeltA.UseAnimatedEffect = True
        '
        'ctrlBeltB
        '
        Me.ctrlBeltB.Actual = 0.0!
        Me.ctrlBeltB.EffectRange = 0.004!
        Me.ctrlBeltB.Location = New System.Drawing.Point(852, 5)
        Me.ctrlBeltB.MaximumSize = New System.Drawing.Size(600, 600)
        Me.ctrlBeltB.Name = "ctrlBeltB"
        Me.ctrlBeltB.Size = New System.Drawing.Size(322, 208)
        Me.ctrlBeltB.TabIndex = 1
        Me.ctrlBeltB.Title = "Belt B"
        Me.ctrlBeltB.Total = 0.0!
        Me.ctrlBeltB.UseAnimatedEffect = True
        '
        'ctrlBeltC
        '
        Me.ctrlBeltC.Actual = 0.0!
        Me.ctrlBeltC.EffectRange = 0.004!
        Me.ctrlBeltC.Location = New System.Drawing.Point(518, 219)
        Me.ctrlBeltC.MaximumSize = New System.Drawing.Size(600, 600)
        Me.ctrlBeltC.Name = "ctrlBeltC"
        Me.ctrlBeltC.Size = New System.Drawing.Size(322, 208)
        Me.ctrlBeltC.TabIndex = 2
        Me.ctrlBeltC.Title = "Belt C"
        Me.ctrlBeltC.Total = 0.0!
        Me.ctrlBeltC.UseAnimatedEffect = True
        '
        'ctrlBeltD
        '
        Me.ctrlBeltD.Actual = 0.0!
        Me.ctrlBeltD.EffectRange = 0.004!
        Me.ctrlBeltD.Location = New System.Drawing.Point(852, 219)
        Me.ctrlBeltD.MaximumSize = New System.Drawing.Size(600, 600)
        Me.ctrlBeltD.Name = "ctrlBeltD"
        Me.ctrlBeltD.Size = New System.Drawing.Size(322, 208)
        Me.ctrlBeltD.TabIndex = 3
        Me.ctrlBeltD.Title = "Belt D"
        Me.ctrlBeltD.Total = 0.0!
        Me.ctrlBeltD.UseAnimatedEffect = True
        '
        'ctrlBeltTotal
        '
        Me.ctrlBeltTotal.Actual = 0.0!
        Me.ctrlBeltTotal.EffectRange = 0.004!
        Me.ctrlBeltTotal.Location = New System.Drawing.Point(90, 5)
        Me.ctrlBeltTotal.MaximumSize = New System.Drawing.Size(600, 600)
        Me.ctrlBeltTotal.Name = "ctrlBeltTotal"
        Me.ctrlBeltTotal.Size = New System.Drawing.Size(422, 422)
        Me.ctrlBeltTotal.TabIndex = 4
        Me.ctrlBeltTotal.Title = "Sorting (Last 60 Minutes)"
        Me.ctrlBeltTotal.Total = 0.0!
        Me.ctrlBeltTotal.UseAnimatedEffect = True
        '
        'TSAMachineHourlyProductivityDataBindingSource
        '
        Me.TSAMachineHourlyProductivityDataBindingSource.DataSource = GetType(LintMachineHourlyProductivityData)
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.TSASortingProductivityDataBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldHour, Me.fieldTotalCount, Me.fieldTotalWeight, Me.fieldBelt, Me.fieldCategoryCode})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.ApplyToCell = False
        PivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        PivotGridStyleFormatCondition1.Expression = "[TotalWeight] >= 20000"
        PivotGridStyleFormatCondition1.FieldName = ""
        Me.PivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(90, 433)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1084, 208)
        Me.PivotGridControl1.TabIndex = 6
        '
        'TSASortingProductivityDataBindingSource
        '
        Me.TSASortingProductivityDataBindingSource.DataSource = GetType(LintSortingProductivityData)
        '
        'fieldHour
        '
        Me.fieldHour.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldHour.AreaIndex = 0
        Me.fieldHour.FieldName = "Hour"
        Me.fieldHour.Name = "fieldHour"
        Me.fieldHour.Width = 66
        '
        'fieldTotalCount
        '
        Me.fieldTotalCount.AreaIndex = 1
        Me.fieldTotalCount.Caption = "Bag Count"
        Me.fieldTotalCount.FieldName = "TotalCount"
        Me.fieldTotalCount.Name = "fieldTotalCount"
        '
        'fieldTotalWeight
        '
        Me.fieldTotalWeight.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTotalWeight.AreaIndex = 0
        Me.fieldTotalWeight.Caption = "Weight"
        Me.fieldTotalWeight.CellFormat.FormatString = "{0:F0}"
        Me.fieldTotalWeight.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTotalWeight.FieldName = "TotalWeight"
        Me.fieldTotalWeight.Name = "fieldTotalWeight"
        '
        'fieldBelt
        '
        Me.fieldBelt.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBelt.AreaIndex = 0
        Me.fieldBelt.Caption = "Belt"
        Me.fieldBelt.FieldName = "Belt"
        Me.fieldBelt.Name = "fieldBelt"
        '
        'fieldCategoryCode
        '
        Me.fieldCategoryCode.AreaIndex = 0
        Me.fieldCategoryCode.Caption = "Category"
        Me.fieldCategoryCode.FieldName = "CategoryCode"
        Me.fieldCategoryCode.Name = "fieldCategoryCode"
        '
        'PivotGridControl2
        '
        Me.PivotGridControl2.DataSource = Me.TSACartDumpProductivityDataBindingSource
        Me.PivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldHour1, Me.PivotGridField1, Me.fieldNumOperations})
        Me.PivotGridControl2.Location = New System.Drawing.Point(90, 647)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.Size = New System.Drawing.Size(1084, 262)
        Me.PivotGridControl2.TabIndex = 7
        '
        'TSACartDumpProductivityDataBindingSource
        '
        Me.TSACartDumpProductivityDataBindingSource.DataSource = GetType(LintCartDumpProductivityData)
        '
        'fieldHour1
        '
        Me.fieldHour1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldHour1.AreaIndex = 0
        Me.fieldHour1.FieldName = "Hour"
        Me.fieldHour1.Name = "fieldHour1"
        Me.fieldHour1.Width = 66
        '
        'PivotGridField1tsaProductivitySummaryBroadcaster
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Names"
        Me.PivotGridField1.FieldName = "MachineName"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'fieldNumOperations
        '
        Me.fieldNumOperations.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNumOperations.AreaIndex = 0
        Me.fieldNumOperations.Caption = "# of Operations"
        Me.fieldNumOperations.FieldName = "NumOperations"
        Me.fieldNumOperations.Name = "fieldNumOperations"
        Me.fieldNumOperations.Width = 96
        '
        'frmSortingProductivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1284, 921)
        Me.Controls.Add(Me.PivotGridControl2)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.ctrlBeltTotal)
        Me.Controls.Add(Me.ctrlBeltD)
        Me.Controls.Add(Me.ctrlBeltC)
        Me.Controls.Add(Me.ctrlBeltB)
        Me.Controls.Add(Me.ctrlBeltA)
        Me.EnableTimeout = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1667, 987)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1278, 738)
        Me.Name = "frmSortingProductivity"
        Me.Text = "Sorting / Cart Dump Productivity"
        Me.TimeoutInSeconds = 60
        CType(Me.TSAMachineHourlyProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSASortingProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSACartDumpProductivityDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctrlBeltA As CtrlLintProductivityGauge
    Friend WithEvents ctrlBeltB As CtrlLintProductivityGauge
    Friend WithEvents ctrlBeltC As CtrlLintProductivityGauge
    Friend WithEvents ctrlBeltD As CtrlLintProductivityGauge
    Friend WithEvents ctrlBeltTotal As CtrlLintProductivityGauge
    Friend WithEvents TSAMachineHourlyProductivityDataBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridControl2 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldHour1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNumOperations As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents TSACartDumpProductivityDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TSASortingProductivityDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents fieldHour As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTotalCount As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTotalWeight As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBelt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCategoryCode As DevExpress.XtraPivotGrid.PivotGridField
End Class
