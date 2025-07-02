Imports Wdw_Sust.Core.Validation.EventArgs

Namespace Validation
    ''' <summary>
    ''' Class BusinessRuleManager.
    ''' </summary>
    Public Class BusinessRuleManager

#Region "Fields"
        ''' <summary>
        ''' The list of rules per object type.
        ''' </summary>
        Private Shared ReadOnly _listOfRules As New Dictionary(Of Type, List(Of RuleArgs))()
#End Region

#Region "Events"
        ''' <summary>
        ''' Occurs when the object is detected not being valid.
        ''' </summary>
        Public Shared Event ObjectIsInvalidEvent As EventHandler(Of ObjectInvalidEventArgs)
#End Region

#Region "Methods"
        ''' <summary>
        ''' Adds the rule.
        ''' </summary>
        ''' <param name="t">The type that will be used to validate against.</param>
        ''' <param name="msg">The message when the rule is broken.</param>
        ''' <param name="ruleName">Name of the rule.</param>
        ''' <param name="rule">The rule argument to test.</param>
        ''' <param name="isRuleEnabled">if set to <c>true</c> [is rule enabled].</param>
        Public Shared Sub AddRule(ByVal t As Type, ByVal msg As String, ByVal ruleName As String, ByVal rule As RuleArgs.RuleDeletgate, Optional ByVal isRuleEnabled As Boolean = True)
            If _listOfRules.ContainsKey(t) Then
                If Not _listOfRules.Item(t).Exists(Function(a As RuleArgs) a.RuleName.ToLower = ruleName.ToLower) Then
                    _listOfRules.Item(t).Add(New RuleArgs(msg, ruleName, rule, isRuleEnabled))
                End If
            Else
                _listOfRules.Add(t, New List(Of RuleArgs)({New RuleArgs(msg, ruleName, rule, isRuleEnabled)}))
            End If
        End Sub

        ''' <summary>
        ''' Removes the rules by type.
        ''' </summary>
        ''' <param name="t">The t.</param>
        Public Shared Sub RemoveRulesByType(ByVal t As Type)
            _listOfRules.Remove(t)
        End Sub

        'Public Shared Sub RemoveRuleByName(ByVal ruleName As String)
        '    For Each pair As KeyValuePair(Of Type, List(Of RuleArgs)) In _listOfRules
        '        pair.Value.ForEach(Sub(a) If a.RuleName.Trim.ToLower = ruleName.Trim.ToLower then pair.Value.Remove(
        '    Next
        'End Sub

        ''' <summary>
        ''' Checks if the supplied object is not valid.
        ''' </summary>
        ''' <param name="objectInCheck">The object in check.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Shared Function CheckRules(ByVal objectInCheck As Object) As Boolean
            Dim list As List(Of RuleArgs) = _listOfRules.Item(objectInCheck.GetType)
            Dim errors As New List(Of ObjectValidationErrorDetail)
            Dim msg As String = Nothing
            list.ForEach(Sub(a) If a.IsEnabled AndAlso Not a.Rule.DynamicInvoke(objectInCheck) Then errors.Add(New ObjectValidationErrorDetail With {.RuleName = a.RuleName, .Message = a.Message}))
            If errors.Count > 0 Then RaiseEvent ObjectIsInvalidEvent(objectInCheck, New ObjectInvalidEventArgs With {.InvalidObject = objectInCheck, .Errors = errors})
            Return errors.Count = 0
        End Function

        Public Shared Function HasRules(ByVal t As Type) As Boolean
            Return _listOfRules.ContainsKey(t.UnderlyingSystemType)
        End Function
#End Region

    End Class
End Namespace

