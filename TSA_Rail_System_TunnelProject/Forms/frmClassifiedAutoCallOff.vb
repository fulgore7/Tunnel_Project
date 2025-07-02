Public Class frmClassifiedAutoCallOff
    Inherits CtrlOpcTsaRailFormBase

#Region "Methods"

    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.Parent.Text = String.Format("{0} - {1}", TabControl1.Parent.Text, TabControl1.TabPages(TabControl1.SelectedIndex).Tag.ToString)
        End If
    End Sub

#End Region

End Class

