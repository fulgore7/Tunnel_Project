Public Class CtrlErrorReporting
    Inherits CtrlLightFormBase

    Public Sub UpdateTextBox(e As Exception)
        PostSyncCallback(Sub() StackTraceTextBox.Text = e.ToString())
    End Sub

    Public Sub New(exceptionData As Exception)
        InitializeComponent()

        UpdateTextBox(exceptionData)
    End Sub
End Class