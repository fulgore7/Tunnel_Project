Imports Wdw_Sust.Rfid
Imports Wdw_Sust.Rfid.SecuraKeyDevices.EventArgs
Imports Wdw_Sust.Rfid.SecuraKeyDevices

Public Class CtrlRfidUsbConfig
    Private _usbManager As UsbManager = UsbManager.Instance
    Private WithEvents _rfidReader As ISecuraKeyRfidReader = Nothing

    Private Sub lbDevices_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lbDevices.SelectedIndexChanged
        Dim device As UsbDevice = CType(CType(sender, System.Windows.Forms.ListBox).SelectedItem, UsbDevice)

        If device IsNot Nothing Then
            If _rfidReader IsNot Nothing Then
                _rfidReader.StopReader()
                _rfidReader.DisconnectReader()
                _rfidReader.Dispose()
                _rfidReader = Nothing
            End If

            _rfidReader = New DeviceEtsSk2(COMPortName:=device.PortName, baudRate:=38400)
        End If
    End Sub

    Private Sub btnWriteCard_Click(sender As Object, e As System.EventArgs) Handles btnWriteCard.Click
        If _rfidReader IsNot Nothing Then
            If Not String.IsNullOrEmpty(tbxWriteCard.Text) Then
                Dim cardNumber As Integer = Integer.Parse(tbxWriteCard.Text)

                If cardNumber > 0 Then
                    _rfidReader.WritingData(cardNumber)
                End If
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs) Handles btnRefresh.Click
        _usbManager.ScanDevices()
        lbDevices.DataSource = Nothing
        lbDevices.DataSource = _usbManager._usbDevices
        lbDevices.DisplayMember = "DisplayMembers"
    End Sub

    Private Sub btnTestReader_Click(sender As Object, e As System.EventArgs) Handles btnTestReader.Click
        _rfidReader.StartReadingData()
    End Sub

    Private Sub handleNewCard(sender As Object, e As RfidCardEventArgs) Handles _rfidReader.NewCardArrived
        Dim cardNumber As String = e.CardNumber.ToString()

        setOutputTbx(cardNumber)
    End Sub

    Private Sub setOutputTbx(text As String)
        tbxOutput.Invoke(Sub() tbxOutput.Text = text)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lbDevices.DataSource = _usbManager._usbDevices
        lbDevices.DisplayMember = "DisplayMembers"
        _usbManager.ScanDevices()
    End Sub
End Class