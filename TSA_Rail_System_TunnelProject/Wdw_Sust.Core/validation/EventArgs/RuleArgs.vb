Namespace Validation.EventArgs
    Public Class RuleArgs
        Inherits System.EventArgs
        Public Delegate Function RuleDeletgate(ByVal e As Object) As Boolean
        Private ReadOnly _msg As String
        Private ReadOnly _rule As RuleDeletgate
        Private ReadOnly _ruleName As String = String.Empty
        Private ReadOnly _isEnabled As Boolean
        Public ReadOnly Property RuleName As String
            Get
                Return _ruleName
            End Get
        End Property

        Public ReadOnly Property Rule As RuleDeletgate
            Get
                Return _rule
            End Get
        End Property
        Public ReadOnly Property Message As String
            Get
                Return _msg
            End Get
        End Property
        Public ReadOnly Property IsEnabled As Boolean
            Get
                Return _isEnabled
            End Get
        End Property

        Public Sub New(ByVal message As String, ByVal ruleName As String, ByVal rule As RuleDeletgate, Optional ByVal isRuleEnable As Boolean = True)
            _msg = message
            _ruleName = ruleName
            _rule = rule
            _isEnabled = isRuleEnable
        End Sub
    End Class
End Namespace

