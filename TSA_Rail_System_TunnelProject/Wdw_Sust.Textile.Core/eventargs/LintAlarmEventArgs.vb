Namespace EventArgs
    Public Class LintAlarmEventArgs
        Inherits DataRetrievalEventArgs

#Region "Properities"
        Public Property ActiveAlarmList() As New List(Of LintAlarm)
        Public Property LastUpdateTime() As Date
        Public Property UpdateInterval As Integer
#End Region

    End Class
End Namespace
