Imports System.Threading

Public Class CtrlCheckForUpdates
    Inherits CtrlLightFormBase

    Public Sub UpdateProgress(progress As Integer)
        PostSyncCallback(Sub() updateProgressBar.Value = progress)
    End Sub

    Public Sub UpdateText(text As String)
        PostSyncCallback(Sub() lblStatus.Text = text)
    End Sub

    Public Sub New(ByVal appName As String)
        InitializeComponent()

        SyncContext = SynchronizationContext.Current

        Me.Text = appName
        Me.CenterToParent()
    End Sub
End Class