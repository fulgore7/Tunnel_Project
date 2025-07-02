Imports Wdw_Sust.Textile.Tsa.Workflow

Public Class frmWorkflowEngineViewer
    Public Sub New(ByVal engine As TsaWorkflowEngine)
        InitializeComponent()
        Text = String.Format("Workflow Calculation - {0}", engine.TimeCalculated)
        CtrlWorkflowEngineViewer1.LoadWorkflowData(engine)
    End Sub
End Class