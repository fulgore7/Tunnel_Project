
Imports Wdw_Sust.Textile.Core.EventArgs

Public Class CtrlLINTSerialPortSetup
    Public Event _OnSettingsSaving(ByVal sender As Object, ByVal e As LintRailAccessRightEventArgs)
    Public Event _OnSettingsSaved(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub LINTSerialPortSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each portName As String In My.Computer.Ports.SerialPortNames
            Me.cmbPortNames.Items.Add(portName)
        Next
        Me.LoadSettings()
    End Sub

    'With SerialPort1
    '         .BaudRate = baudRate
    '         .PortName = comPortName
    '         .StopBits = stopBits
    '         .Parity = parity
    '         .DataBits = dataBits
    '         .ReadTimeout = readTimeOut
    '     End With

    Private Sub LoadSettings()
        'cmbPortNames.SelectedText = My.Settings.Secura_Key_COM_Port
        'txtBaudRate.Text = CStr(My.Settings.Secura_Key_Port_Baud_Rate)
        'txtReadTimeOut.Text = CStr(My.Settings.Secura_Key_Port_Read_Time_Out)
    End Sub

    Private Sub SaveSettings()
        'My.Settings.Secura_Key_COM_Port = cmbPortNames.Text
        'My.Settings.Secura_Key_Port_Baud_Rate = CInt(txtBaudRate.Text)
        'My.Settings.Secura_Key_Port_Read_Time_Out = CInt(txtReadTimeOut.Text)
        My.Settings.Save()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim args As New LINTRailAccessRightEventArgs(LintSecurityProvider. , Not LintSecurityProvider.ENABLE_SECURITY)
        'RaiseEvent _OnSettingsSaving(Me, args)
        'If args.HasRight Then
        SaveSettings()
        RaiseEvent _OnSettingsSaved(Me, System.EventArgs.Empty)
        'MsgBox("Please restart the application to refresh the changes!!")
        'Else
        'MsgBox(args.Message)
        'End If
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        Dim result As MsgBoxResult = MsgBox("All changes will be lost. Do you want to reset to the default settings?")
        Select Case result
            Case MsgBoxResult.Ok
                My.Settings.Reset()
            Case Else
                Exit Sub
        End Select
        My.Settings.Save()
    End Sub

End Class

