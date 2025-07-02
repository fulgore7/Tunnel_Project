Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Wdw_Sust.Logging.LoggingManager

Public Class CtrlLintToolStripStatusLabel
    Inherits ToolStripStatusLabel

    Private _originalFontSize As Integer = 0

    <Category("Behavior")>
    Public Property AllowResizeOnHover As Boolean

    Private Sub CtrlLintToolStripStatusLabel_MouseHover(sender As Object, e As System.EventArgs) Handles Me.MouseHover
        If AllowResizeOnHover Then
            TryUserAction(Sub()
                              If _originalFontSize = 0 Or Nothing Then
                                  _originalFontSize = Me.Font.Size
                              End If
                              Dim newFontSize = _originalFontSize + 2
                              Using newFont As System.Drawing.Font = Me.Font
                                  Me.Font = New Font(newFont.FontFamily, newFontSize, newFont.Style)
                              End Using
                          End Sub)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CtrlLintToolStripStatusLabel_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        If AllowResizeOnHover And _originalFontSize > 0 Then
            TryUserAction(Sub()
                              Using newFont As System.Drawing.Font = Me.Font
                                  Me.Font = New Font(newFont.FontFamily, _originalFontSize, newFont.Style)
                              End Using
                          End Sub)
        Else
            Exit Sub
        End If
    End Sub
End Class
