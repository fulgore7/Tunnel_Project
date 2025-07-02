Imports System.Windows.Forms.Design
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.Opc.WinForms

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip Or ToolStripItemDesignerAvailability.StatusStrip)>
Public Class CtrlOpcTsaRunDownButton
    Inherits CtrlOpcRunDownButtonBase

    Protected Overrides Sub CtrlOpcTsaRunDownButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim args As New LintRailAccessRightEventArgs(RailAccessOptions.RUN_DOWN_SYSTEM, hasRight:=Not LintSecurityProvider.ENABLE_SECURITY)
        OnChangeAction(args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            Dim systemName As String
            Dim operatorEvent As LintOperatorEventArgs
            If PLCName = LintApplicationConfigurationManager.Instance.ConfigFile.PlcTopics.TsaClassifiedPlc Then
                systemName = "Classified"
            ElseIf PLCName = LintApplicationConfigurationManager.Instance.ConfigFile.PlcTopics.TsaCleanworkPlc Then
                systemName = "Cleanwork"
            Else
                systemName = "Unknown"
            End If
            If Request.TagName.Contains("Run_Down_Ongoing") Then
                systemName = String.Format("{0} run down ongoing", systemName)
            Else
                systemName = String.Format("{0} run down ongoing", systemName)
            End If
            If CBool(Request.Value) Then
                operatorEvent = New LintOperatorEventArgs(Now, args.EmployeeId, My.Computer.Name, LintAction.RUN_UP_SYSTEM, String.Format("The {0} system was started", systemName))
            Else
                operatorEvent = New LintOperatorEventArgs(Now, args.EmployeeId, My.Computer.Name, LintAction.RUN_DOWN_SYSTEM, String.Format("The {0} system was run down", systemName))
            End If
            Request.ValueFromObjectToPlc("", Not CBool(Request.Value))
            OnChangedAction(operatorEvent)
        Else
            MsgBox("you don't have right to perform this action!!")
        End If
    End Sub

End Class

