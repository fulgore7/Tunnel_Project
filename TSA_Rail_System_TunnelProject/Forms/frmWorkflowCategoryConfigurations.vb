Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Tsa
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Tsa.Workflow.Interfaces
Imports Wdw_Sust.Textile.Tsa.Workflow.Dal
Imports Wdw_Sust.Textile.Tsa.Dal

Public Class frmWorkflowCategoryConfigurations
    Inherits CtrlOpcRailFormBase

#Region "Fields"
    Private _castInfo As LintCastMember
    Private _workflow As ILintWorkflowProvider
#End Region

#Region "Properties"
    Public ReadOnly Property WorkflowProvider As ILintWorkflowProvider
        Get
            If _workflow Is Nothing Then
                _workflow = TsaWorkflowInfoProvider.Instance
                _workflow.ConnectionString = Db_Configuration.LintInUseConnectionString
            End If
            Return _workflow
        End Get
    End Property
#End Region

#Region "Methods"
    Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider
        Return TsaFactoryProvider.Instance
    End Function

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If IsNumeric(e.Value) AndAlso e.Value = 0 Then e.CellStyle.BackColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Protected Overrides Sub OnFormClosing(e As System.Windows.Forms.FormClosingEventArgs)
        Dim categories As List(Of TsaWorkflowCategoryConfiguration) = CType(TSAWorkflowCategoryConfigurationBindingSource.DataSource, List(Of TsaWorkflowCategoryConfiguration)).FindAll(Function(a) a.IsDirty)
        Dim categoryString As New System.Text.StringBuilder
        If categories.Count > 0 Then
            WorkflowProvider.UpdateWorkflowCategoryParameters(categories)
            categories.ForEach(Sub(a)
                                   a.IsDirty = False
                                   categoryString.AppendLine(String.Format("{0}", a.CategoryCode))
                               End Sub)
            If Logger.IsLoggingEnabled Then LogOperatorEvent(Me, New LintOperatorEventArgs(Now, _castInfo.EmployeeID, My.Computer.Name, LintAction.TSA_CATEGORY_WORKFLOW_PARAMETER_CHANGED, String.Format("Call Off of Category: {0} modified.", categoryString.ToString)))
        End If
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub TSAWorkflowCategoryConfigurationBindingSource_ListChanged(sender As System.Object, e As System.ComponentModel.ListChangedEventArgs) Handles TSAWorkflowCategoryConfigurationBindingSource.ListChanged
        If e.ListChangedType = System.ComponentModel.ListChangedType.ItemChanged Then
            CType(TSAWorkflowCategoryConfigurationBindingSource.Current, TsaWorkflowCategoryConfiguration).IsDirty = True
        End If
    End Sub

    Protected Overrides Sub Initialize()
        LINTCategoryDetailBindingSource.DataSource = Factory.Rail.GetCategoryDescriptionDetails
        MyBase.Initialize()
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(ByVal categoryParameters As List(Of TsaWorkflowCategoryConfiguration), ByVal castInfo As LintCastMember)
        InitializeComponent()
        _castInfo = castInfo
        TSAWorkflowCategoryConfigurationBindingSource.DataSource = categoryParameters
        If Not LintSecurityProvider.GetTSARolesToSaveWorkflowCategoryConfiguration.Contains(_castInfo.UserType) Then
            DataGridView1.ReadOnly = True
            MsgBox("You don't have the right to change settings! Therefore, this grid is read only")
        End If
    End Sub
#End Region

End Class