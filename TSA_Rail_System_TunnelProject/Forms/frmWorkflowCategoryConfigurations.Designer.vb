Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Tsa

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkflowCategoryConfigurations

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkflowCategoryConfigurations))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LINTCategoryDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSAWorkflowCategoryConfigurationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AllowCategoryToBeWashedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher4DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher5DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher6DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher7DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowedOnWasher8DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BaselineWeightClassifiedStorageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaselineWeightCleanworkStorageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaselineWeightCurrentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaselineWeightHistoricalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaselineWeightRecentHistoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryPreferredWasherOption9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINTCategoryDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSAWorkflowCategoryConfigurationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryCode, Me.Description, Me.AllowCategoryToBeWashedDataGridViewCheckBoxColumn, Me.AllowedOnWasher1DataGridViewCheckBoxColumn, Me.AllowedOnWasher2DataGridViewCheckBoxColumn, Me.AllowedOnWasher3DataGridViewCheckBoxColumn, Me.AllowedOnWasher4DataGridViewCheckBoxColumn, Me.AllowedOnWasher5DataGridViewCheckBoxColumn, Me.AllowedOnWasher6DataGridViewCheckBoxColumn, Me.AllowedOnWasher7DataGridViewCheckBoxColumn, Me.AllowedOnWasher8DataGridViewCheckBoxColumn, Me.BaselineWeightClassifiedStorageDataGridViewTextBoxColumn, Me.BaselineWeightCleanworkStorageDataGridViewTextBoxColumn, Me.BaselineWeightCurrentStatusDataGridViewTextBoxColumn, Me.BaselineWeightHistoricalDataGridViewTextBoxColumn, Me.BaselineWeightRecentHistoryDataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption1DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption2DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption3DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption4DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption5DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption6DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption7DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption8DataGridViewTextBoxColumn, Me.CategoryPreferredWasherOption9DataGridViewTextBoxColumn, Me.MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn, Me.MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn, Me.MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn, Me.MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn, Me.MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn, Me.MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TSAWorkflowCategoryConfigurationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1107, 742)
        Me.DataGridView1.TabIndex = 0
        '
        'LINTCategoryDetailBindingSource
        '
        Me.LINTCategoryDetailBindingSource.DataSource = GetType(Wdw_Sust.Textile.Core.LintCategoryDetail)
        '
        'TSAWorkflowCategoryConfigurationBindingSource
        '
        Me.TSAWorkflowCategoryConfigurationBindingSource.DataSource = GetType(Wdw_Sust.Textile.Tsa.TsaWorkflowCategoryConfiguration)
        '
        'CategoryCode
        '
        Me.CategoryCode.DataPropertyName = "CategoryCode"
        Me.CategoryCode.HeaderText = "CategoryCode"
        Me.CategoryCode.Name = "CategoryCode"
        Me.CategoryCode.ReadOnly = True
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Description.DataPropertyName = "CategoryCode"
        Me.Description.DataSource = Me.LINTCategoryDetailBindingSource
        Me.Description.DisplayMember = "CategoryDescription"
        Me.Description.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Description.ValueMember = "CategoryID"
        Me.Description.Width = 66
        '
        'AllowCategoryToBeWashedDataGridViewCheckBoxColumn
        '
        Me.AllowCategoryToBeWashedDataGridViewCheckBoxColumn.DataPropertyName = "AllowCategoryToBeWashed"
        Me.AllowCategoryToBeWashedDataGridViewCheckBoxColumn.HeaderText = "Wash Allowed"
        Me.AllowCategoryToBeWashedDataGridViewCheckBoxColumn.Name = "AllowCategoryToBeWashedDataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher1DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher1DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher1"
        Me.AllowedOnWasher1DataGridViewCheckBoxColumn.HeaderText = "T1 Allowed"
        Me.AllowedOnWasher1DataGridViewCheckBoxColumn.Name = "AllowedOnWasher1DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher2DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher2DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher2"
        Me.AllowedOnWasher2DataGridViewCheckBoxColumn.HeaderText = "T2 Allowed"
        Me.AllowedOnWasher2DataGridViewCheckBoxColumn.Name = "AllowedOnWasher2DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher3DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher3DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher3"
        Me.AllowedOnWasher3DataGridViewCheckBoxColumn.HeaderText = "T3 Allowed"
        Me.AllowedOnWasher3DataGridViewCheckBoxColumn.Name = "AllowedOnWasher3DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher4DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher4DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher4"
        Me.AllowedOnWasher4DataGridViewCheckBoxColumn.HeaderText = "T4 Allowed"
        Me.AllowedOnWasher4DataGridViewCheckBoxColumn.Name = "AllowedOnWasher4DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher5DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher5DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher5"
        Me.AllowedOnWasher5DataGridViewCheckBoxColumn.HeaderText = "T5 Allowed"
        Me.AllowedOnWasher5DataGridViewCheckBoxColumn.Name = "AllowedOnWasher5DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher6DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher6DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher6"
        Me.AllowedOnWasher6DataGridViewCheckBoxColumn.HeaderText = "T6 Allowed"
        Me.AllowedOnWasher6DataGridViewCheckBoxColumn.Name = "AllowedOnWasher6DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher7DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher7DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher7"
        Me.AllowedOnWasher7DataGridViewCheckBoxColumn.HeaderText = "T7 Allowed"
        Me.AllowedOnWasher7DataGridViewCheckBoxColumn.Name = "AllowedOnWasher7DataGridViewCheckBoxColumn"
        '
        'AllowedOnWasher8DataGridViewCheckBoxColumn
        '
        Me.AllowedOnWasher8DataGridViewCheckBoxColumn.DataPropertyName = "AllowedOnWasher8"
        Me.AllowedOnWasher8DataGridViewCheckBoxColumn.HeaderText = "T8 Allowed"
        Me.AllowedOnWasher8DataGridViewCheckBoxColumn.Name = "AllowedOnWasher8DataGridViewCheckBoxColumn"
        '
        'BaselineWeightClassifiedStorageDataGridViewTextBoxColumn
        '
        Me.BaselineWeightClassifiedStorageDataGridViewTextBoxColumn.DataPropertyName = "BaselineWeightClassifiedStorage"
        Me.BaselineWeightClassifiedStorageDataGridViewTextBoxColumn.HeaderText = "Classified BL"
        Me.BaselineWeightClassifiedStorageDataGridViewTextBoxColumn.Name = "BaselineWeightClassifiedStorageDataGridViewTextBoxColumn"
        '
        'BaselineWeightCleanworkStorageDataGridViewTextBoxColumn
        '
        Me.BaselineWeightCleanworkStorageDataGridViewTextBoxColumn.DataPropertyName = "BaselineWeightCleanworkStorage"
        Me.BaselineWeightCleanworkStorageDataGridViewTextBoxColumn.HeaderText = "Cleanwork BL"
        Me.BaselineWeightCleanworkStorageDataGridViewTextBoxColumn.Name = "BaselineWeightCleanworkStorageDataGridViewTextBoxColumn"
        '
        'BaselineWeightCurrentStatusDataGridViewTextBoxColumn
        '
        Me.BaselineWeightCurrentStatusDataGridViewTextBoxColumn.DataPropertyName = "BaselineWeightCurrentStatus"
        Me.BaselineWeightCurrentStatusDataGridViewTextBoxColumn.HeaderText = "Current BL"
        Me.BaselineWeightCurrentStatusDataGridViewTextBoxColumn.Name = "BaselineWeightCurrentStatusDataGridViewTextBoxColumn"
        '
        'BaselineWeightHistoricalDataGridViewTextBoxColumn
        '
        Me.BaselineWeightHistoricalDataGridViewTextBoxColumn.DataPropertyName = "BaselineWeightHistorical"
        Me.BaselineWeightHistoricalDataGridViewTextBoxColumn.HeaderText = "Historical BL"
        Me.BaselineWeightHistoricalDataGridViewTextBoxColumn.Name = "BaselineWeightHistoricalDataGridViewTextBoxColumn"
        '
        'BaselineWeightRecentHistoryDataGridViewTextBoxColumn
        '
        Me.BaselineWeightRecentHistoryDataGridViewTextBoxColumn.DataPropertyName = "BaselineWeightRecentHistory"
        Me.BaselineWeightRecentHistoryDataGridViewTextBoxColumn.HeaderText = "Recent BL"
        Me.BaselineWeightRecentHistoryDataGridViewTextBoxColumn.Name = "BaselineWeightRecentHistoryDataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption1DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption1DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption1"
        Me.CategoryPreferredWasherOption1DataGridViewTextBoxColumn.HeaderText = "Preferred Option 1"
        Me.CategoryPreferredWasherOption1DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption1DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption2DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption2DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption2"
        Me.CategoryPreferredWasherOption2DataGridViewTextBoxColumn.HeaderText = "Preferred Option 2"
        Me.CategoryPreferredWasherOption2DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption2DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption3DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption3DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption3"
        Me.CategoryPreferredWasherOption3DataGridViewTextBoxColumn.HeaderText = "Preferred Option 3"
        Me.CategoryPreferredWasherOption3DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption3DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption4DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption4DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption4"
        Me.CategoryPreferredWasherOption4DataGridViewTextBoxColumn.HeaderText = "Preferred Option 4"
        Me.CategoryPreferredWasherOption4DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption4DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption5DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption5DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption5"
        Me.CategoryPreferredWasherOption5DataGridViewTextBoxColumn.HeaderText = "Preferred Option 5"
        Me.CategoryPreferredWasherOption5DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption5DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption6DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption6DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption6"
        Me.CategoryPreferredWasherOption6DataGridViewTextBoxColumn.HeaderText = "Preferred Option 6"
        Me.CategoryPreferredWasherOption6DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption6DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption7DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption7DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption7"
        Me.CategoryPreferredWasherOption7DataGridViewTextBoxColumn.HeaderText = "Preferred Option 7"
        Me.CategoryPreferredWasherOption7DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption7DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption8DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption8DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption8"
        Me.CategoryPreferredWasherOption8DataGridViewTextBoxColumn.HeaderText = "Preferred Option 8"
        Me.CategoryPreferredWasherOption8DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption8DataGridViewTextBoxColumn"
        '
        'CategoryPreferredWasherOption9DataGridViewTextBoxColumn
        '
        Me.CategoryPreferredWasherOption9DataGridViewTextBoxColumn.DataPropertyName = "CategoryPreferredWasherOption9"
        Me.CategoryPreferredWasherOption9DataGridViewTextBoxColumn.HeaderText = "Preferred Option 9"
        Me.CategoryPreferredWasherOption9DataGridViewTextBoxColumn.Name = "CategoryPreferredWasherOption9DataGridViewTextBoxColumn"
        '
        'MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn
        '
        Me.MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn.DataPropertyName = "MaximumClassifiedStoragePercentage"
        Me.MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn.HeaderText = "Max Classified Storage %"
        Me.MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn.Name = "MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn"
        '
        'MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn
        '
        Me.MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn.DataPropertyName = "MaximumCleanworkStoragePercentage"
        Me.MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn.HeaderText = "Max Cleanwork Storage %"
        Me.MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn.Name = "MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn"
        '
        'MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn
        '
        Me.MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn.DataPropertyName = "MaximumQuantityBeforeCleanworkStorageByPass"
        Me.MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn.HeaderText = "Max Class Qty Before Clean Max By Pass"
        Me.MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn.Name = "MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn"
        '
        'MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn
        '
        Me.MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn.DataPropertyName = "MaximumQuantityInCleanworkToStopCallOff"
        Me.MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn.HeaderText = "Max Qty Clean To Stop Call Off"
        Me.MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn.Name = "MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn"
        '
        'MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn
        '
        Me.MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn.DataPropertyName = "MinimumClassifiedStoragePercentage"
        Me.MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn.HeaderText = "Min Classified Storage %"
        Me.MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn.Name = "MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn"
        '
        'MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn
        '
        Me.MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn.DataPropertyName = "MinimumCleanworkStoragePercentage"
        Me.MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn.HeaderText = "Min Clean Storage %"
        Me.MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn.Name = "MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn"
        '
        'frmWorkflowCategoryConfigurations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 742)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWorkflowCategoryConfigurations"
        Me.Text = "Workflow Category Parameters"
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINTCategoryDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSAWorkflowCategoryConfigurationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TSAWorkflowCategoryConfigurationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINTCategoryDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MinimumStorageQuantityBeforeCallOffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryCode As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewComboBoxColumn
    Friend WithEvents AllowCategoryToBeWashedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher1DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher2DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher3DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher4DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher5DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher6DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher7DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AllowedOnWasher8DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BaselineWeightClassifiedStorageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BaselineWeightCleanworkStorageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BaselineWeightCurrentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BaselineWeightHistoricalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BaselineWeightRecentHistoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryPreferredWasherOption9DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumClassifiedStoragePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumCleanworkStoragePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumQuantityBeforeCleanworkStorageByPassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumQuantityInCleanworkToStopCallOffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimumClassifiedStoragePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimumCleanworkStoragePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
