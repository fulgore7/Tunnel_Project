
Imports System.Linq
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Tsa.Wcf
Imports Wdw_Sust.Logging.LoggingManager

Public Class frmTunnelInterface
    Inherits CtrlOpcTsaRailFormBase

#Region "Fields"

    Private _listOfTunnelProductivityData As List(Of LintTunnelProductivityData)
    Private _tunnel1PreviousCount As Integer = -1
    Private _tunnel2PreviousCount As Integer = -1
    Private _tunnel3PreviousCount As Integer = -1
    Private _tunnel4PreviousCount As Integer = -1
    Private _tunnel5PreviousCount As Integer = -1
    Private _tunnel6PreviousCount As Integer = -1
    Private _tunnel7PreviousCount As Integer = -1
    Private _tunnel8PreviousCount As Integer = -1

    Private _groups As New WashdeckOpcGroupName With {.Tunnel1 = "Tunnel_1", .Tunnel2 = "Tunnel_2",
                                                      .Tunnel3 = "Tunnel_3", .Tunnel4 = "Tunnel_4",
                                                      .Tunnel5 = "Tunnel_5", .Tunnel6 = "Tunnel_6", .PhoenixTunnel6 = "PhoenixTunnel6",
                                                      .Tunnel7 = "Tunnel_7", .Tunnel8 = "Tunnel_8",
                                                      .MachineAvailability = "Washdeck_Machinery",
                                                      .CycleTimer = "Washdeck_Cycle_Timer",
                                                      .CleanworkEmptyBag = "Washdeck_Clean_Bag_Buffer"}

#End Region

#Region "Methods"

#Region "Initializations"

#Region "Tag Defintions"

#End Region


    Private Sub MakeBagNotEditable(ByVal sender As Object, ByVal e As LintBagEventArgs)
        e.BagMode = FormMode.READ_ONLY
        e.Message = "*This bag can not be edited"
    End Sub

    Private Shared Sub InitializeProviderConnections()
        LintAlarmBroadcaster.Instance.Plant = Plant.TSA
    End Sub

    Protected Overrides Sub InitializeOpcCommunication()
        OpenOpcComm(_groups.MachineAvailability, 30000)
        OpenOpcComm(_groups.CycleTimer, 3000)
        MyBase.OpenOpcComm()
    End Sub
#End Region

    Private Sub RefreshData()
        _listOfTunnelProductivityData = BllRailInfoProvider.Instance.Service.GetLast60MinutesNumberOfBagDrops
        InvokeIfNeeded(AddressOf UpdateScreen)
    End Sub

    'Protected Overrides Sub WndProc(ByRef message As Message)
    '    If CONFIGURATION.WorkStation = WorkStations.NSA_SORTING_CONTROL_PC Then

    '    End If
    '    Const WM_SYSCOMMAND As Integer = &H112
    '    Const SC_MOVE As Integer = &HF010

    '    Select Case message.Msg
    '        Case WM_SYSCOMMAND
    '            Dim command As Integer = message.WParam.ToInt32() And &HFFF0
    '            If command = SC_MOVE Then
    '                Return
    '            End If
    '            Exit Select
    '    End Select

    '    MyBase.WndProc(message)
    'End Sub

    Private Sub UpdateBagDropLabels(ByVal tunnelLabel As Label, ByRef previousTunnelCount As Integer, ByVal tunnelData As LintTunnelProductivityData)
        tunnelLabel.Text = String.Format("{0} Bag Drops", tunnelData.NumberOfBagDrops)
        If previousTunnelCount = -1 Then
            previousTunnelCount = tunnelData.NumberOfBagDrops
        Else
            If previousTunnelCount > tunnelData.NumberOfBagDrops Then
                tunnelLabel.ForeColor = Color.Red
            ElseIf _tunnel1PreviousCount < tunnelData.NumberOfBagDrops Then
                tunnelLabel.ForeColor = Color.Lime
            Else
                tunnelLabel.ForeColor = Color.Black
            End If
            previousTunnelCount = tunnelData.NumberOfBagDrops
        End If
    End Sub

    Protected Overrides Sub CheckIfBagCanBeEdited(sender As Object, e As LintBagEventArgs)
        e.BagMode = FormMode.EDIT
    End Sub

    Private Sub UpdateScreen()
        Try
            Dim totalBagDrops As Integer = _listOfTunnelProductivityData.Where(Function(b) b.RunDuration > 0).Sum(Function(a As LintTunnelProductivityData) a.NumberOfBagDrops)
            Dim totalRuntimes As Decimal = _listOfTunnelProductivityData.Sum(Function(a As LintTunnelProductivityData) a.RunDuration)
            'Dim totalRuntimes As Decimal = CDec(_numberOfActiveWashers)
            'Dim totalRuntimes As Decimal = _totalWashers.Value
            Dim tempAverageDrop As Decimal

            If totalRuntimes > 0 Then
                tempAverageDrop = totalBagDrops / totalRuntimes
            Else
                tempAverageDrop = 0
            End If

            lblAverageBagDropCounts.Text = String.Format("Avg Drops: {0:F2}", tempAverageDrop)
            For Each data As LintTunnelProductivityData In _listOfTunnelProductivityData
                Select Case data.MachineID
                    Case 10701
                        'UpdateBagDropLabels(lblBagDropT1, _tunnel1PreviousCount, data)
                    Case 10711
                        'UpdateBagDropLabels(lblBagDropT2, _tunnel2PreviousCount, data)
                    Case 10721
                        'UpdateBagDropLabels(lblBagDropT3, _tunnel3PreviousCount, data)
                    Case 10731
                        'UpdateBagDropLabels(lblBagDropT4, _tunnel4PreviousCount, data)
                    Case 10741
                        'UpdateBagDropLabels(lblBagDropT5, _tunnel5PreviousCount, data)
                    Case 10751
                        UpdateBagDropLabels(lblBagDropT6, _tunnel6PreviousCount, data)
                    Case 10761
                        UpdateBagDropLabels(lblBagDropT7, _tunnel7PreviousCount, data)
                    Case 10791
                        'UpdateBagDropLabels(lblBagDropT8, _tunnel8PreviousCount, data)
                End Select
            Next
            If tempAverageDrop > 25.0 Then
                lblAverageBagDropCounts.ForeColor = Color.Lime
            ElseIf tempAverageDrop > 20.0 And tempAverageDrop < 25.0 Then
                lblAverageBagDropCounts.ForeColor = Color.Black
            Else
                lblAverageBagDropCounts.ForeColor = Color.Red
            End If
            lblActiveWashers.Text = String.Format("Active Washers: {0}", Available_Washers.Value)
        Catch ex As Exception
            WriteException(ex, "UpdateScreen()")
        End Try
    End Sub

    Protected Overrides Sub Initialize()
        WashdeckOPCGroupNameBindingSource.DataSource = _groups
        MyBase.Initialize()
        AddJob("frmTunnel_Interface_New_RefreshData", TimeSpan.FromMinutes(1), AddressOf RefreshData, Not CONFIGURATION.IsFailOverMode)
        ChangeJobStatusIfDefined(Not CONFIGURATION.IsFailOverMode, "frmTunnel_Interface_New_RefreshData")
    End Sub

    Protected Overrides Sub ApplicationModeChanged()
        ChangeJobStatusIfDefined(Not CONFIGURATION.IsFailOverMode, "frmTunnel_Interface_New_RefreshData")
    End Sub

    Private Sub CtrlOPCMachineStatus1_MouseEnter(sender As Object, e As System.EventArgs)
        'BaseToolTip.Show(String.Format("Redry Control: {0}", IIf(CtrlOPCMachineStatus1.Value, "Enable", "Disable")), Me, CtrlOPCMachineStatus1.Location)
    End Sub

    Private Sub CtrlOPCMachineStatus1_MouseLeave(sender As Object, e As System.EventArgs)
        BaseToolTip.Hide(Me)
    End Sub

    Private Sub frmTunnelInterface_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
#End Region

#Region "Contructors"
    Public Sub New()
        InitializeComponent()
        DoubleBuffered = True
    End Sub

#End Region

End Class