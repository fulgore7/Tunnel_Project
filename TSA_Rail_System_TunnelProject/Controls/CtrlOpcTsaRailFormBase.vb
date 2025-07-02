Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.Opc.WinForms.EventArgs
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms
Imports Wdw_Sust.Textile.Global.WinForms.Helpers
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Extensions
Imports Wdw_Sust.Textile.Global.WinForms.DevExp
Imports Wdw_Sust.Textile.Global.WinForms.EventArgs

''' <summary>
''' Define anything here that is specifically related to TSA facility
''' </summary>
''' <seealso cref="Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcRailFormBase" />
Public Class CtrlOpcTsaRailFormBase
    Inherits CtrlOpcRailFormBase

    Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider
        Return TsaFactoryProvider.Instance
    End Function

    'Make sure the coaches' PC is not allowed to perform changes
    Protected Overrides Sub CheckPlantSpecificRequirements(sender As Object, e As IRailAccessRightEventArgs)
        If Not CONFIGURATION.WorkStation.IsTsaControlWorkStation Then
            e.HasRight = False
            e.Message = String.Format(SR.WARNING_NO_RIGHT_PERFORM_ACTION_AT_WORKSTATION, System.Enum.GetName(GetType(WorkStations), CONFIGURATION.WorkStation))
        End If
    End Sub
    ''' <summary>
    ''' This meant to be overriden so the derived form can wire events to the control
    ''' </summary>
    ''' <param name="ctrl">Control to be wired</param>
    ''' <param name="handlerAction">The handler action.</param>
    Protected Overrides Sub ManageControlsEvent(ctrl As Control, handlerAction As HandlerAction)
        Select Case True
            Case TypeOf ctrl Is CtrlOpcShortTrip
                ManageShortTrip(ctrl, handlerAction)
            Case TypeOf ctrl Is CtrlOpcTsaRailBlockLabel
                ManageBlockUnblockRailLabel(ctrl, handlerAction)
            Case TypeOf ctrl Is CtrlOPCSwitchGateButton
                ManageSwitchGate(ctrl, handlerAction)
        End Select
    End Sub

    Private Sub ManageSwitchGate(ctrl As CtrlOPCSwitchGateButton, handlerAction As HandlerAction)
        Select Case handlerAction
            Case HandlerAction.Add
                AddHandler ctrl._OnSwitchGateStatusChanging, AddressOf CheckRoleAccessRights
                AddHandler ctrl._OnSwitchGateStatusChanged, AddressOf LogOperatorEvent
            Case HandlerAction.Remove
                RemoveHandler ctrl._OnSwitchGateStatusChanging, AddressOf CheckRoleAccessRights
                RemoveHandler ctrl._OnSwitchGateStatusChanged, AddressOf LogOperatorEvent
        End Select
    End Sub

    Private Sub ManageShortTrip(ByVal ctrl As CtrlOpcShortTrip, ByVal handlerAction As HandlerAction)
        Select Case handlerAction
            Case HandlerAction.Add
                AddHandler ctrl._OnShortTripStatusChanging, AddressOf CheckRailAccessRights
                AddHandler ctrl._OnShortTripStatusChanged, AddressOf LogOperatorEvent
            Case HandlerAction.Remove
                RemoveHandler ctrl._OnShortTripStatusChanging, AddressOf CheckRailAccessRights
                RemoveHandler ctrl._OnShortTripStatusChanged, AddressOf LogOperatorEvent
        End Select
    End Sub

    Private Sub ManageBlockUnblockRailLabel(ctrl As CtrlOpcTsaRailBlockLabel, handlerAction As HandlerAction)
        Select Case handlerAction
            Case HandlerAction.Add
                AddHandler ctrl._OnBlockingUnblockingRail, AddressOf CheckRailAccessRights
                AddHandler ctrl._OnBlockedUnblockedRail, AddressOf LogOperatorEvent
            Case HandlerAction.Remove
                RemoveHandler ctrl._OnBlockingUnblockingRail, AddressOf CheckRailAccessRights
                RemoveHandler ctrl._OnBlockedUnblockedRail, AddressOf LogOperatorEvent
        End Select
    End Sub

    ''' <summary>
    ''' This is to determine if a bag can be edited. It can only be edited if the run down of that bag area
    ''' is completed.
    ''' </summary>
    ''' <param name="sender">The bag which called the sub</param>
    ''' <param name="e">The parameters associated to the bag</param>
    Protected Overrides Sub CheckIfBagCanBeEdited(sender As Object, e As LintBagEventArgs)
        Dim isEmptyBag As Boolean
        Dim BagDetail = sender

        Select Case BagDetail.GetType()
            Case GetType(CtrlOpcTsaBagWithDropDestination)
                'If CType(sender, CtrlOpcTsaBag).Category = 99 Then isEmptyBag = True
                If CType(sender, CtrlOpcTsaBagWithDropDestination).Category = 99 Then isEmptyBag = True
            Case GetType(CtrlOpcTsaBag)
                If CType(sender, CtrlOpcTsaBag).Category = 99 Then isEmptyBag = True
        End Select

        If CType(sender, ILintEditableBag).BagMode = FormMode.READ_ONLY Then Exit Sub

        Select Case CONFIGURATION.WorkStation
            'Case WorkStations.TSA_COACHES_PC
            '    e.BagMode = FormMode.READ_ONLY
            '    e.Message = SR.WARNING_BAG_CANNOT_BE_EDITED_IN_PC
            Case WorkStations.DEVELOPMENT_PC
                e.BagMode = FormMode.NORMAL
                e.Message = "*Editing is done in development mode!!"
            Case Else
                Select Case True
                    Case (e.RundownZone = LintRundownZone.CLASSIFIED_ONGOING) AndAlso (isEmptyBag = True) AndAlso (BagDetail.TagName.Contains("VC_Track"))
                        e.BagMode = FormMode.NORMAL
                    Case (e.RundownZone = LintRundownZone.CLASSIFIED_ONGOING) AndAlso IsClassifiedOngoingRunDown
                        e.BagMode = FormMode.NORMAL_WITH_DELETE
                    Case (e.RundownZone = LintRundownZone.CLASSIFIED_OFFGOING) AndAlso IsClassifiedOffgoingRunDown
                        e.BagMode = FormMode.NORMAL_WITH_DELETE
                    Case (e.RundownZone = LintRundownZone.CLASSIFIED_WHOLE) AndAlso IsClassifiedOngoingRunDown AndAlso IsClassifiedOffgoingRunDown
                        e.BagMode = FormMode.NORMAL_WITH_DELETE
                    Case (e.RundownZone = LintRundownZone.CLEANWORK_ONGOING) AndAlso IsCleanworkOngoingRunDown
                        e.BagMode = FormMode.NORMAL_WITH_DELETE
                    Case (e.RundownZone = LintRundownZone.CLEANWORK_OFFGOING) AndAlso IsCleanworkOffgoingRunDown
                        e.BagMode = FormMode.NORMAL_WITH_DELETE
                    Case (e.RundownZone = LintRundownZone.CLEANWORK_WHOLE) AndAlso IsCleanworkOngoingRunDown AndAlso IsCleanworkOffgoingRunDown
                        e.BagMode = FormMode.NORMAL_WITH_DELETE
                    Case Else
                        e.BagMode = FormMode.NORMAL_WITH_EDIT_ONLY
                        e.Message = String.Format("*Run down system {0} to edit bag", e.RundownZone.ToString)
                End Select
        End Select
    End Sub

    Protected Overrides Sub ShowBagEditForm(sender As Object, e As BagEditFormEventArgs)
        Using frm As New CtrlOpcTsaBagEdit(e, New OpcTsaBagEditManager(OpcComm.Instance, e.PlcName, e.TagName))
            AddHandler frm._OnUpdatingBag, AddressOf CheckRailAccessRights
            AddHandler frm._OnUpdatedBag, AddressOf LogBagEvent
            frm.ShowDialog()
            RemoveHandler frm._OnUpdatingBag, AddressOf CheckRailAccessRights
            RemoveHandler frm._OnUpdatedBag, AddressOf LogBagEvent
        End Using
    End Sub

    Protected Overrides Sub ShowBagReportIssueForm(sender As Object, e As BagIssueReportFormEventArgs)
        Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        If card IsNot Nothing Then
            If card.IsValid Then
                Using frm As New CtrlOpcBagReportIssue(e.PlcName, e.TagName, card.CastInfo.EmployeeID)
                    AddHandler frm._OnReportedBagIssue, AddressOf LogOperatorEvent
                    frm.ShowDialog()
                    RemoveHandler frm._OnReportedBagIssue, AddressOf LogOperatorEvent
                End Using
            End If
        End If
    End Sub

    Protected Overrides Sub ShowAlarmHistoryForm(sender As Object, e As AlarmHistoryFormEventArgs)
        Using frm As New CtrlLintAlarmHistoryViewer(e.GlobalAlarmId)
            frm.ShowDialog()
        End Using
    End Sub

    Protected Overrides Sub ShowCastProductivityViewer(sender As Object, e As ProductivityViewerEventArgs)
        Using frm As New CtrlLintCastHourlyProductivityViewer(e.CastData)
            frm.ShowDialog()
        End Using
    End Sub
End Class