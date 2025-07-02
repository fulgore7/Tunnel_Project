Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms

Public Class frmClassifiedCallOff
    Inherits CtrlOpcTsaRailFormBase

#Region "Methods"

    Private Sub frmClassifiedCallOff_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each c As Control In TabControl1.Controls
            If c.HasChildren Then
                For Each subControl As Control In c.Controls
                    If TypeOf subControl Is CtrlOpcTsaClassifiedCallOff Then
                        RemoveHandler CType(subControl, CtrlOpcTsaClassifiedCallOff)._OnEditingCallOff, AddressOf frmMain.CheckRailAccessRights
                        'RemoveHandler CType(subControl, CtrlTSAClassifiedCallOff)._OnEditedCallOff, AddressOf frmMain.LogOperatorEvent
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub frmClassifiedCallOff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each c As Control In TabControl1.Controls
            If c.HasChildren Then
                For Each subControl As Control In c.Controls
                    If TypeOf subControl Is CtrlOpcTsaClassifiedCallOff Then
                        AddHandler CType(subControl, CtrlOpcTsaClassifiedCallOff)._OnEditingCallOff, AddressOf frmMain.CheckRailAccessRights
                        'AddHandler CType(subControl, CtrlTSAClassifiedCallOff)._OnEditedCallOff, AddressOf frmMain.LogOperatorEvent
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.Parent.Text = String.Format("{0} - {1}", TabControl1.Parent.Text, TabControl1.TabPages(TabControl1.SelectedIndex).Tag.ToString)
        End If
    End Sub

    Protected Overrides Sub WorkStationChanged()
        For Each c As Control In TabControl1.Controls
            If c.HasChildren Then
                For Each subControl As Control In c.Controls
                    If TypeOf subControl Is CtrlOpcTsaClassifiedCallOff Then
                        CType(subControl, CtrlOpcTsaClassifiedCallOff).IsAutoSkipEnabled = (CONFIGURATION.WorkStation = WorkStations.DEVELOPMENT_PC)
                    End If
                Next
            End If
        Next
    End Sub
#End Region

End Class

