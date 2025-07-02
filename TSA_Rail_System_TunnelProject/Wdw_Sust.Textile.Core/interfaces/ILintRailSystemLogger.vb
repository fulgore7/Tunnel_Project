
Imports Wdw_Sust.Textile.Core.EventArgs

Namespace Interfaces
    Public Interface ILintRailSystemLogger
        ''' <summary>
        ''' Log bag related events
        ''' </summary>
        ''' <param name="sender">Object which fires the event</param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Sub LogBagEvent(ByVal sender As Object, ByVal e As LintBagEditLogEventArgs)

        ''' <summary>
        ''' Log rail sequence events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Sub LogRailSequenceEvent(ByVal sender As Object, ByVal e As LintRailSequenceEventArgs)

        ''' <summary>
        ''' Log operator events
        ''' </summary>
        ''' <param name="sender">What control caused the action</param>
        ''' <param name="e">The event args which contains the action from an operator</param>
        ''' <remarks></remarks>
        Sub LogOperatorEvent(ByVal sender As Object, ByVal e As LintOperatorEventArgs)

        ''' <summary>
        ''' Log application events
        ''' </summary>
        ''' <param name="log"></param>
        ''' <remarks></remarks>
        Sub LogApplicationEvent(ByVal log As LintApplicationEventLog)
        Property IsLoggingEnabled() As Boolean
    End Interface
End Namespace