Public Class LintReceiveAlarmEventArgs

#Region "Fields"

    Private _message As String = String.Empty

#End Region

#Region "Properties"

    Public ReadOnly Property Message() As String
        Get
            Return _message
        End Get
    End Property

#End Region



#Region "Constructors"

    Public Sub New(message As String)
        _message = message
    End Sub

#End Region

End Class