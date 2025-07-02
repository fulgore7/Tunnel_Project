Imports Wdw_Sust.Core
Imports Wdw_Sust.Textile.Global.WinForms.Core


Public Class CtrlLintConnectionStringBuilderOld
    Inherits CtrlFormBase

    Private _connectionStringBuilder As ConnectionStringBuilder

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        'TODO: need to fix the connection string builder
        'ListBox1.Items.AddRange(LINTFunctions.GetConnectionStringNames.ToArray)
        ListBox1.SelectedIndex = 0
    End Sub

    Private Function LocalCheckSuccessful() As Boolean
        Dim password As String = InputBox("Please input the password")
        If Not IsNumeric(password) Then Return False
        Return CInt(password) = 8665
    End Function

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If LocalCheckSuccessful() Then
            SaveSettings()
            MsgBox("Please close the program and restart!")
            Close()
        Else
            MsgBox("You don't have the right to perform this action!")
        End If
    End Sub

    Private Sub SaveSettings()
        'If cbEncryptionEnabled.Checked Then
        '    My.Settings.Item(ListBox1.SelectedItem) = _connectionStringBuilder.EncryptedConnectionString
        'Else
        '    My.Settings.Item(ListBox1.SelectedItem) = _connectionStringBuilder.ConnectionString
        'End If
        'My.Settings.Connection_String_Encryption_Enabled = cbEncryptionEnabled.Checked
        My.Settings.Item(ListBox1.SelectedItem) = _connectionStringBuilder.ConnectionString
        My.Settings.Save()
    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedValueChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            _connectionStringBuilder = New ConnectionStringBuilder(GetConnectionString(ListBox1.SelectedItem))
            ConnectionStringBuilderBindingSource.DataSource = _connectionStringBuilder
        End If
    End Sub

    Private Function GetConnectionString(ByVal connectionStringName As String) As String
        Return My.Settings.Item(connectionStringName)
    End Function

End Class

