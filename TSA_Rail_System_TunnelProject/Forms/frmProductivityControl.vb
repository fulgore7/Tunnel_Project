Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.WinForms.Helpers
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Imports Wdw_Sust.Textile.Core

Public Class frmProductivityControl
    Inherits CtrlOpcTsaRailFormBase

#Region "Methods"

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is CtrlOpcButton Then
                Dim c As CtrlOpcButton = CType(ctrl, CtrlOpcButton)
                c.IsSecurityFeatureUsed = True
                c.RoleNeeded.AddRange(LintSecurityProvider.GetTSARolesToResetProductionNumbers)
            End If
        Next
    End Sub

    Private Sub btnResetAllData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetAllData.Click
        'Dim args As New LINTRoleAccessRightEventArgs(Security.LINTSecurityManager.GetTSARolesToResetProductionNumbers(), Plant.TSA)
        Dim args As New LintRailAccessRightEventArgs(RailAccessOptions.RESET_PRODUCTION_NUMBERS, CONFIGURATION.Plant)
        'FACTORY.Security.CheckRoleAccessRights(Me, args)

        Dim card As RfidCard = GetRfidCarddata(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRailAccessRights(card, args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is IOpcElementControl Then
                    CType(ctrl, CtrlOpcBase).ValueFromObjectToPlc(String.Empty, 1, True)
                End If
            Next
            OpcAsyncWrite("Productivity_Productivity")
            OpcAsyncWrite("Classified_Productivity")
            OpcAsyncWrite("Gateway_Productivity")
            LogOperatorEvent(Me, New LintOperatorEventArgs(Now, args.EmployeeID, My.Computer.Name, LintAction.RESET_PRODUCTION_NUMBER, "All production numbers were reset"))
        Else
            MsgBox(args.Message)
        End If
    End Sub

#End Region

    Private Sub btnResetProductivity__ActionLogged(sender As Object, e As LintOperatorEventArgs) Handles btnResetProductivityTF1._ActionLogged, btnResetProductivityTF2._ActionLogged, btnResetProductivityTF3._ActionLogged, btnResetProductivityTF4._ActionLogged,
                                                                                       btnResetProductivityTF5._ActionLogged, btnResetProductivityTF6._ActionLogged, btnResetProductivityTF7._ActionLogged, btnResetProductivityTF8._ActionLogged,
                                                                                       btnResetProductivityTF9._ActionLogged, btnResetProductivityTF10._ActionLogged, btnResetProductivityTF11._ActionLogged, btnResetProductivityTF12._ActionLogged,
                                                                                       btnResetProductivityTF13._ActionLogged, btnResetProductivityTF14._ActionLogged, btnResetProductivityTF15._ActionLogged, btnResetProductivityTF16._ActionLogged,
                                                                                       btnResetProductivityTF17._ActionLogged, btnResetProductivityTF18._ActionLogged, btnResetProductivityTF19._ActionLogged, btnResetProductivityTF20._ActionLogged,
                                                                                       btnResetProductivityTF21._ActionLogged, btnResetProductivityTF22._ActionLogged, btnResetProductivityFW1._ActionLogged, btnResetProductivityFW2._ActionLogged,
                                                                                       btnResetProductivityFW3._ActionLogged, btnResetProductivityFW4._ActionLogged, btnResetProductivityFW5._ActionLogged, btnResetProductivityFW6._ActionLogged,
                                                                                       btnResetProductivityFW7._ActionLogged, btnResetCartDump._ActionLogged, btnResetClassifiedSorting._ActionLogged, btnResetWashdeck._ActionLogged
        Dim c As CtrlOpcButton = TryCast(sender, CtrlOpcButton)
        If c IsNot Nothing Then
            e.LintActionId = LintAction.RESET_PRODUCTION_NUMBER
            e.LogDescription = String.Format("Machine {0} productivity number was reset", c.HighStateText)
        End If
        LogOperatorEvent(c, e)
    End Sub

    Private Sub CtrlOPCButton_Click(sender As Object, e As IRailAccessRightEventArgs) Handles btnResetProductivityTF1._ButtonClick, btnResetProductivityTF2._ButtonClick, btnResetProductivityTF3._ButtonClick, btnResetProductivityTF4._ButtonClick,
                                                                                       btnResetProductivityTF5._ButtonClick, btnResetProductivityTF6._ButtonClick, btnResetProductivityTF7._ButtonClick, btnResetProductivityTF8._ButtonClick,
                                                                                       btnResetProductivityTF9._ButtonClick, btnResetProductivityTF10._ButtonClick, btnResetProductivityTF11._ButtonClick, btnResetProductivityTF12._ButtonClick,
                                                                                       btnResetProductivityTF13._ButtonClick, btnResetProductivityTF14._ButtonClick, btnResetProductivityTF15._ButtonClick, btnResetProductivityTF16._ButtonClick,
                                                                                       btnResetProductivityTF17._ButtonClick, btnResetProductivityTF18._ButtonClick, btnResetProductivityTF19._ButtonClick, btnResetProductivityTF20._ButtonClick,
                                                                                       btnResetProductivityTF21._ButtonClick, btnResetProductivityTF22._ButtonClick, btnResetProductivityFW1._ButtonClick, btnResetProductivityFW2._ButtonClick,
                                                                                       btnResetProductivityFW3._ButtonClick, btnResetProductivityFW4._ButtonClick, btnResetProductivityFW5._ButtonClick, btnResetProductivityFW6._ButtonClick,
                                                                                       btnResetProductivityFW7._ButtonClick, btnResetCartDump._ButtonClick, btnResetClassifiedSorting._ButtonClick, btnResetWashdeck._ButtonClick
        'FACTORY.Security.CheckRoleAccessRights(sender, e)
        Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRailAccessRights(card, e)
    End Sub


End Class