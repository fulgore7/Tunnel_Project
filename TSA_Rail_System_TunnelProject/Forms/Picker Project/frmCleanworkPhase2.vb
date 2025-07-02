Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms
Imports Wdw_Sust.Core.Extensions
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Enums

Public Class frmCleanworkPhase2
    Inherits CtrlOpcTsaRailFormBase

#Region "Fields"
    Private ReadOnly _listOfDropDestinations As New List(Of Integer)
    Private ReadOnly _listOfStorageDestinations As New List(Of LintNameValuePair)
    Private ReadOnly OPC_GROUP_CLEANWORK_CALL_BLOCK As String = "Cleanwork_Call_Block"
    Private WithEvents _expressProduct As OpcElement
#End Region

#Region "Methods"

    Private Sub btnExpressProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpressProduct.Click
        Try
            Using frm As New frmCleanExpressProduct
                AddHandler frm._OnChangingExpressProduct, AddressOf CheckRailAccessRights
                AddHandler frm._OnChangedExpressProduct, AddressOf LogOperatorEvent
                frm.ShowInTaskbar = False
                frm.ShowDialog()
                RemoveHandler frm._OnChangingExpressProduct, AddressOf CheckRailAccessRights
                RemoveHandler frm._OnChangedExpressProduct, AddressOf LogOperatorEvent
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub WorkStationChanged()
        MyBase.WorkStationChanged()
        CheckReadonlyRailSeqeneces()
    End Sub

    Private Sub CheckReadonlyRailSeqeneces()
        CtrlOpcRailSequenceStep1082.ReadOnlySeqeunce = Not (CONFIGURATION.WorkStation = WorkStations.TSA_CLEANWORK_CONTROL_PC OrElse CONFIGURATION.WorkStation = WorkStations.DEVELOPMENT_PC)
        CtrlOpcRailSequenceStep1083.ReadOnlySeqeunce = Not (CONFIGURATION.WorkStation = WorkStations.TSA_CLEANWORK_CONTROL_PC OrElse CONFIGURATION.WorkStation = WorkStations.DEVELOPMENT_PC)
        CtrlOpcRailSequenceStep1189.ReadOnlySeqeunce = Not (CONFIGURATION.WorkStation = WorkStations.TSA_CLEANWORK_CONTROL_PC OrElse CONFIGURATION.WorkStation = WorkStations.DEVELOPMENT_PC)
    End Sub

    Private Sub CtrlOPCBag__DestinationChanged(ByVal sender As System.Object, ByVal e As LintChangeDestinationEventArgs)
        If TryCast(sender, IOpcObject) Is Nothing Then Throw New ArgumentException("Sender is not an IOPCObject")
        InvokeIfNeeded(Sub()
                           Dim tagName As String = CType(sender, IOpcObject).TagName
                           Dim railNumber As Integer = CInt(tagName.SubStr("[", ",").ToString)
                           If e.DestinationType = BagDestinationType.DROP_DESTINATION Then
                               UpdateOffgoingListBox(railNumber, e.Destination)
                           ElseIf e.DestinationType = BagDestinationType.STORAGE_DESTINATION Then
                               UpdateOngoingListBox(railNumber, e.Destination)
                           End If
                       End Sub)
    End Sub

    Protected Overrides Sub InitializeOpcObjects()
        MyBase.InitializeOpcObjects()

        Try
            _expressProduct = AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaCleanworkPlc, "Fast_Category", OPC_GROUP_CLEANWORK_CALL_BLOCK)
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        If Not CONFIGURATION.IsFailOverMode() Then CType(ParentForm, frmMain).AlarmBroadcaster.Refresh(True)
        CheckReadonlyRailSeqeneces()
    End Sub

    Protected Overrides Sub InitializeOpcSettings()
        SubscribeToOpcGlobalDataChangeEvent = True
    End Sub

    Protected Overrides Sub InitializeOpcCommunication()
        OpenOpcComm("Cleanwork_Sequences", 2000)
        MyBase.OpenOpcComm()
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
            Case TypeOf ctrl Is CtrlOpcTsaBagWithStorageDestination
                If handlerAction = HandlerAction.Add Then
                    AddHandler CType(ctrl, CtrlOpcTsaBagWithStorageDestination)._StorageDestinationChanged, AddressOf CtrlOPCBag__DestinationChanged
                ElseIf handlerAction = HandlerAction.Remove Then
                    RemoveHandler CType(ctrl, CtrlOpcTsaBagWithStorageDestination)._StorageDestinationChanged, AddressOf CtrlOPCBag__DestinationChanged
                End If
        End Select
    End Sub

    Protected Overrides Sub ManageControlsEvent(ctrl As Control, handlerAction As HandlerAction)
        MyBase.ManageControlsEvent(ctrl, handlerAction)
        Select Case True
            Case TypeOf ctrl Is CtrlOpcTsaCleanworkCallOffButton
                ManageCleanworkCallOffButton(ctrl, handlerAction)
        End Select
    End Sub

    Private Sub ManageCleanworkCallOffButton(ctrl As CtrlOpcTsaCleanworkCallOffButton, handlerAction As HandlerAction)
        Select Case handlerAction
            Case HandlerAction.Add
                AddHandler ctrl._OnCommittingCallOff, AddressOf CheckRailAccessRights
                AddHandler ctrl._OnCommittedCallOff, AddressOf LogOperatorEvent
            Case HandlerAction.Remove
                RemoveHandler ctrl._OnCommittingCallOff, AddressOf CheckRailAccessRights
                RemoveHandler ctrl._OnCommittedCallOff, AddressOf LogOperatorEvent
        End Select
    End Sub

    Private Sub UpdateOffgoingListBox(ByVal railNumber As Integer, ByVal destination As Integer)
        lbOffgoing.DataSource = Nothing
        If destination > 0 AndAlso Not _listOfDropDestinations.Contains(railNumber) Then
            _listOfDropDestinations.Add(railNumber)
        ElseIf destination = 0 AndAlso _listOfDropDestinations.Contains(railNumber) Then
            _listOfDropDestinations.Remove(railNumber)
        End If
        lbOffgoing.DataSource = _listOfDropDestinations
        lbOffgoing.SelectedIndex = -1
    End Sub

    Private Sub UpdateOngoingListBox(ByVal railNumber As Integer, ByVal destination As Integer)
        LINTNameValuePairBindingSource.DataSource = Nothing
        If destination > 0 AndAlso IsNothing(_listOfStorageDestinations.Find(Function(a As LintNameValuePair) a.ID = railNumber)) Then
            _listOfStorageDestinations.Add(New LintNameValuePair(railNumber, destination))
        ElseIf destination = 0 AndAlso Not IsNothing(_listOfStorageDestinations.Find(Function(a As LintNameValuePair) a.ID = railNumber)) Then
            _listOfStorageDestinations.Remove(_listOfStorageDestinations.Find(Function(a As LintNameValuePair) a.ID = railNumber))
        End If
        LINTNameValuePairBindingSource.DataSource = _listOfStorageDestinations
        lbOngoing.SelectedIndex = -1
    End Sub

    Private Sub CtrlOpcRailSequenceStep91_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles CtrlOpcRailSequenceStep91.PropertiesUpdateCompleted
        CtrlOPCCycleTimer1.Visible = (CtrlOpcRailSequenceStep91.CurrentStep > 10)
    End Sub

    Private Sub _expressProduct_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles _expressProduct.PropertiesUpdateCompleted
        btnExpressProduct.Text = String.Format("Express Category: {0}", _expressProduct.Value)
    End Sub

    Private Sub CtrlOpcRailSequenceStep27_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles CtrlOpcRailSequenceStep27.PropertiesUpdateCompleted
        CtrlOPCCycleTimer2.Visible = (CtrlOpcRailSequenceStep27.CurrentStep <> 2)
    End Sub

#End Region

#Region "Contructors"
    Public Sub New()
        InitializeComponent()
        DoubleBuffered = True
    End Sub
#End Region

End Class