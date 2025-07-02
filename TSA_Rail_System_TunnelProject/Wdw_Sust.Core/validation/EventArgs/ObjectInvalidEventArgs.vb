Namespace Validation.EventArgs
    Public Class ObjectInvalidEventArgs
        Inherits System.EventArgs

        Public Property InvalidObject As Object
        Public Property Errors As List(Of ObjectValidationErrorDetail)

        Public Function ErrorSummary() As String
            Dim summary As String = String.Empty
            Errors.ForEach(Sub(a) summary += String.Format("{0}{1}", a.Message, vbCrLf))
            Return summary
        End Function
    End Class


End Namespace
