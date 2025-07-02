Imports System.Drawing
Imports System.Windows.Forms
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Rfid.Enums
Imports Wdw_Sust.Rfid.SecuraKeyDevices
Imports Wdw_Sust.Rfid.SecuraKeyDevices.EventArgs
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.WinForms.Core

Public Class CtrlLintRfidReader
    Inherits CtrlFormBase

#Region "Fields"

    Private ReadOnly _cardToBeProgrammed As Integer
    Private _counter As Integer
    Private WithEvents _reader As ISecuraKeyRfidReader
    Private ReadOnly _mode As RfidReaderMode
    Private _card As RfidCard
    Private _restablishConnectionComPorts As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)

#End Region

#Region "Properties"

    Public ReadOnly Property CardToBeProgrammed() As Integer
        Get
            Return _cardToBeProgrammed
        End Get
    End Property

    Private ReadOnly Property Reader() As DeviceEt4Wxm
        Get
            If _reader Is Nothing Then Throw New InvalidOperationException("Reader not defined!")
            Return _reader
        End Get
    End Property

    Public ReadOnly Property RfidCard() As RfidCard
        Get
            Return _card
        End Get
    End Property

    Public ReadOnly Property Mode() As RfidReaderMode
        Get
            Return _mode
        End Get
    End Property

#End Region

#Region "Support Methods"

    ''' <summary>
    ''' Connect to Card Reader and 'read in card data' on scan
    ''' </summary>
    Private Sub CardReaderInitialize()
        Try
            If _mode = RfidReaderMode.READ Then
                _reader.StartReadingData()
            Else
                _reader.WritingData(_cardToBeProgrammed)
            End If
        Catch ex As Exception
            _reader_ReaderInactiveTimeout(Me, New RfidCardReaderErrorEventArgs(ex))
        End Try
    End Sub

    ''' <summary>
    ''' Initialize the reestablish connection com ports collection.
    ''' </summary>
    Private Sub RestablishConnectionInitialize()
        _restablishConnectionComPorts.Clear()
        _restablishConnectionComPorts = My.Computer.Ports.SerialPortNames.ToDictionary(Function(k) k, Function(v) False)
    End Sub

    ' TODO: Remove This code. Was only required for ComPort communication.
    ''' <summary>
    ''' This method is used whenever there is an issue reading the card reader.
    ''' This method attempts to find the correct Com Port (for the Card Reader)
    ''' </summary>
    Private Sub RestablishConnectionToCardReader(e As RfidCardReaderErrorEventArgs)
        ' do something here
    End Sub

#End Region

#Region "Methods"

    Private Sub _reader_CardWritten(sender As Object, e As RfidCardEventArgs) Handles _reader.CardWritten
        _card = New RfidCard With {.RFBadgeUserID = e.CardNumber, .RFBadgeGuidLoWord = e.LoWord, .RFBadgeGuidHiWord = e.HiWord}
        CloseForm()
    End Sub

    Private Sub _reader_NewCardArrived(sender As Object, e As RfidCardEventArgs) Handles _reader.NewCardArrived
        _card = Factory.LintInfo.GetCardInfoWithUserDetailsByRfidCard(RfidCard.CreateRfidCard(e.CardNumber, e.LoWord, e.HiWord))
        CloseForm()
    End Sub

    ''' <summary>
    ''' Event indicating that Card reader activity was not detected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _reader_ReaderInactiveTimeout(sender As Object, e As RfidCardReaderErrorEventArgs) Handles _reader.ReaderInactiveTimeout
        ' Find the Card Reader (find the ComPort)
        RestablishConnectionToCardReader(e)
    End Sub

    Private Sub CloseForm()
        Timer1.Enabled = False
        If _reader.IsReading Then
            _reader.StopReader()
        End If
        InvokeIfNeeded(AddressOf Close)
        If InvokeRequired Then
            BeginInvoke(Sub() Close())
        Else
            Close()
            Application.DoEvents()
        End If
    End Sub

    Private Sub RFID_Reader_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With Timer1
            .Interval = 1000
            .Enabled = True
        End With

        ' Initialize the Card Reader and prepare to receive data (from Card Reader)
        CardReaderInitialize()
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Timer1.Enabled = False
        CloseForm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        If _counter Mod 2 = 0 Then
            Label1.ForeColor = Color.Black
        Else
            Label1.ForeColor = Color.Red
        End If
        _counter += 1
    End Sub

    ''' <summary>
    ''' Try if the port can be open
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsSerialPortDefinedSuccessfully() As Boolean
        Try
            SerialPort1.Open()
            Return True
        Catch ex As Exception
            Return False
        Finally
            SerialPort1.Close()
        End Try
    End Function

    Private Sub ReaderRuleCheck()
        If Mode = RfidReaderMode.WRITE AndAlso CardToBeProgrammed = 0 Then
            Throw New ArgumentException("If reader is in write mode, parameter cardToBeProgrammed needs to be greater than 0")
            CloseForm()
        End If
    End Sub

#End Region

#Region "Constructors"

    Public Sub New(readerMode As RfidReaderMode, reader As ISecuraKeyRfidReader, Optional cardToBeProgrammed As Integer = 0)
        InitializeComponent()
        _mode = readerMode
        _reader = reader
        _cardToBeProgrammed = cardToBeProgrammed
        ReaderRuleCheck()
    End Sub

#End Region

End Class