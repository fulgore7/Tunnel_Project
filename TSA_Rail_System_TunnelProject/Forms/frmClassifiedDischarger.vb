
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms
Imports Wdw_Sust.Core.Extensions
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Enums

Public Class frmClassifiedDischarger
    Inherits CtrlOpcTsaRailFormBase

#Region "Fields"
    Private _listOfDropDestinations As New List(Of Integer)
    Private WithEvents _jlaSequence As OpcElement
#End Region

#Region "Methods"
    Private Sub CtrlOPCBag__DestinationChanged(ByVal sender As System.Object, ByVal e As LintChangeDestinationEventArgs)
        InvokeIfNeeded(Sub()
                           Dim tagName As String = CType(sender, IOpcObject).TagName
                           Dim railNumber As Integer = CInt(tagName.SubStr("[", ",").ToString)
                           If e.DestinationType = BagDestinationType.DROP_DESTINATION Then
                               lbOffgoing.DataSource = Nothing
                               If e.Destination > 0 AndAlso Not _listOfDropDestinations.Contains(railNumber) Then
                                   _listOfDropDestinations.Add(railNumber)
                               ElseIf e.Destination = 0 AndAlso _listOfDropDestinations.Contains(railNumber) Then
                                   _listOfDropDestinations.Remove(railNumber)
                               End If
                               lbOffgoing.DataSource = _listOfDropDestinations
                               lbOffgoing.SelectedIndex = -1
                           End If
                       End Sub)
    End Sub

    Protected Overrides Sub ManageBagControl(ctrl As CtrlOpcBagBase, handlerAction As HandlerAction)
        MyBase.ManageBagControl(ctrl, handlerAction)
        Select Case True
            Case TypeOf ctrl Is CtrlOpcTsaBagWithDropDestination
                If handlerAction = HandlerAction.Add Then
                    AddHandler CType(ctrl, CtrlOpcTsaBagWithDropDestination)._DropDestinationChanged, AddressOf CtrlOPCBag__DestinationChanged
                ElseIf handlerAction = HandlerAction.Remove Then
                    RemoveHandler CType(ctrl, CtrlOpcTsaBagWithDropDestination)._DropDestinationChanged, AddressOf CtrlOPCBag__DestinationChanged
                End If
        End Select
    End Sub

    Protected Overrides Sub Initialize()
        If CONFIGURATION.WorkStation = WorkStations.TSA_COACHES_PC Then DisableEnableEmptyLineButtons()
        If Not CONFIGURATION.IsFailOverMode() Then CType(ParentForm, frmMain).AlarmBroadcaster.Refresh(True)
        MyBase.Initialize()
    End Sub

    Private Sub DisableEnableEmptyLineButtons()
        CtrlEmptyControl4.Enabled = False
        CtrlEmptyControl5.Enabled = False
        CtrlEmptyControl6.Enabled = False
        CtrlEmptyControl3.Enabled = False
        CtrlEmptyControl2.Enabled = False
        CtrlEmptyControl1.Enabled = False
        CtrlEmptyControl7.Enabled = False
        CtrlEmptyControl8.Enabled = False
    End Sub

    Protected Overrides Sub InitializeOpcCommunication()
        OpenOpcComm("Classified_Storage_With_Discharger_Assignment", 1000)
        OpenOpcComm("Classified_Discharger_Bag_Over_Tunnel", 1000)
        OpenOpcComm("Classified_Discharger_Sequences", 2000)
        OpenOpcComm("Classified_Discharger_Bags", 3000)
        OpenOpcComm("Classified_Discharger_Offgoing_Buffer", 3000)
        OpenOpcComm("Classified_Storage_Discharger", 3000)
        OpenOpcComm("Classified_Storage_1_7_Discharger", 3000)
        OpenOpcComm("Classified_Storage_8_16_Discharger", 3000)
        OpenOpcComm("Classified_Storage_17_24_Discharger", 3000)
        OpenOpcComm("Classified_Storage_36_43_Discharger", 3000)
        OpenOpcComm("Classified_Storage_45_51_Discharger", 3000)
        MyBase.InitializeOpcCommunication()
    End Sub

    Protected Overrides Sub InitializeOpcObjects()
        MyBase.InitializeOpcObjects()
        _jlaSequence = AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaClassifiedPlc, "gSeq[17]", "Empty_Bag_Return_Controls")
    End Sub

    Private Sub CtrlOPCCheckBox1_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles CtrlEmptyControl1.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl2.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl3.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl4.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl5.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl6.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl7.PropertiesUpdateCompleted,
                                                                                                                CtrlEmptyControl8.PropertiesUpdateCompleted
        CtrlEmptyControlTimer1.Visible = Not CtrlEmptyControl1.Checked
        CtrlEmptyControlTimer2.Visible = Not CtrlEmptyControl2.Checked
        CtrlEmptyControlTimer3.Visible = Not CtrlEmptyControl3.Checked
        CtrlEmptyControlTimer4.Visible = Not CtrlEmptyControl4.Checked
        CtrlEmptyControlTimer5.Visible = Not CtrlEmptyControl5.Checked
        CtrlEmptyControlTimer6.Visible = Not CtrlEmptyControl6.Checked
        CtrlEmptyControlTimer7.Visible = Not CtrlEmptyControl7.Checked
        CtrlEmptyControlTimer8.Visible = Not CtrlEmptyControl8.Checked
    End Sub

    Private Sub _jlaSequence_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles _jlaSequence.PropertiesUpdateCompleted
        Dim enabled As Boolean = (_jlaSequence.Value <= 10)
        CtrlEmptyControl8.Enabled = enabled
        Label5.Enabled = enabled
    End Sub

    Private Sub CtrlOPCBagWithDropDestination55_Load(sender As Object, e As System.EventArgs) Handles CtrlOPCBagWithDropDestination55.Load

    End Sub
#End Region

End Class