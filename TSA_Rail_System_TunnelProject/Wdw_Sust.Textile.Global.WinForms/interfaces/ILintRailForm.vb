Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces

Namespace Interfaces
    Public Interface ILintRailForm
        Property Logger As ILintRailSystemLogger
        Sub LogBagEvent(sender As Object, e As LintBagEditLogEventArgs)
        Sub LogRailSequenceEvent(sender As Object, e As LintRailSequenceEventArgs)
        Sub LogOperatorEvent(sender As Object, e As LintOperatorEventArgs)
        Sub CheckRailAccessRights(ByVal sender As Object, ByVal e As IRailAccessRightEventArgs)
        Sub CheckRoleAccessRights(ByVal sender As RfidCard, ByVal e As LintRoleAccessRightEventArgs)
    End Interface
End Namespace
