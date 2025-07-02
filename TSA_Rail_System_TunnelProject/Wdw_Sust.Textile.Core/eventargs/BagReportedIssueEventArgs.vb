Namespace EventArgs
    Public Class BagReportedIssueEventArgs
        Inherits System.EventArgs
        Public Property TimeStamp As Date
        Public Property CategoryId As Integer
        Public Property Reason As LintReasoning
        Public Property Comments As String
        Public Property PlcBagId As Integer
        Public Property EmployeeId As Integer
    End Class
End Namespace