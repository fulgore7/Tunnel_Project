Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class LoadingManager

    Private Shared _frmLoading As CtrlLoading
    Private Shared _isLoading As Boolean

    Protected Shared ReadOnly Property LoadingScreen As CtrlLoading
        Get
            If IsNothing(_frmLoading) OrElse _frmLoading.IsDisposed OrElse _frmLoading.Disposing Then
                _frmLoading = New CtrlLoading
            End If
            Return _frmLoading
        End Get
    End Property

    Public Shared ReadOnly Property IsLoading As Boolean
        Get
            Return _isLoading
        End Get
    End Property

    Public Shared Sub StartLoading(ByVal ctrl As Control)
        SuspendDrawing(ctrl)
        LoadingScreen.Show()
        _isLoading = True
    End Sub

    Public Shared Sub StopLoading(ByVal ctrl As Control)
        If _isLoading Then
            _frmLoading.Close()
            ResumeDrawing(ctrl)
            _frmLoading.Dispose()
            _frmLoading = Nothing
            _isLoading = False
        End If
    End Sub

    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Boolean, ByVal lParam As Int32) As Integer

    End Function

    Private Const WM_SETREDRAW As Integer = 11

    Private Shared Sub SuspendDrawing(ByVal parent As Control)
        If Not IsNothing(parent) AndAlso Not parent.IsDisposed Then
            SendMessage(parent.Handle, WM_SETREDRAW, False, 0)
        End If
    End Sub
    Private Shared Sub ResumeDrawing(ByVal parent As Control)
        If Not IsNothing(parent) AndAlso Not parent.IsDisposed Then
            SendMessage(parent.Handle, WM_SETREDRAW, True, 0)
            parent.Refresh()
        End If
    End Sub

End Class
