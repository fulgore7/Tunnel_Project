Imports System.ComponentModel

Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core

Public Class CtrlOpcTsaRailBlockLabel
    Inherits CtrlOpcBase
    Implements IOpcElementControl

    Private _blockStatus As Boolean
    Private _textValue As String
    Private _railNumber As Integer

    Public Event _OnBlockingUnblockingRail As EventHandler(Of LintRailAccessRightEventArgs)
    Public Event _OnBlockedUnblockedRail As EventHandler(Of LintOperatorEventArgs)
    Public Event _MouseHover As EventHandler

    <NotConnectableOpcItem(), Category("Custom Object Properties")>
    Public Property TextValue As String
        Get
            Return _textValue
        End Get
        Set(value As String)
            _textValue = value

            If _textValue IsNot Nothing Then
                lblRail.Text = CStr(value)
            End If
        End Set
    End Property

    <NotConnectableOpcItem(), Category("Custom Object Properties")>
    Public Property RailNumber As Integer
        Get
            Return _railNumber
        End Get
        Set(value As Integer)
            _railNumber = value
            If TextValue Is Nothing Then
                lblRail.Text = CStr(_railNumber)
            End If
        End Set
    End Property

    Public Overrides Property TagName As String
        Get
            If MyBase.TagName Is Nothing Then Return String.Empty

            If DesignMode Or TextValue IsNot Nothing Then
                Return MyBase.TagName
            ElseIf Not DesignMode And TextValue Is Nothing Then
                Return String.Format(MyBase.TagName, RailNumber)
            End If
        End Get
        Set(value As String)
            MyBase.TagName = value
        End Set
    End Property

    <NotConnectableOpcItem(), Category("Custom Object Properties"), Description("Set this to true if the tag is positive logic for blocking, such as LineEnable")>
    Public Property LogicReverse As Boolean = False

    <NotConnectableOpcItem(), Category("Custom Object Properties"), Description("Describe the rail area is offgoing or ongoing for proper logging.")>
    Public Property TravelArea As StorageRailDirection = StorageRailDirection.Offgoing

    Protected Overrides Sub ValueFromPlcToObject(index As Integer, value As Object)
        _blockStatus = CBool(value)
        InvokeIfNeeded(AddressOf UpdateLabel)
    End Sub

    Private Sub UpdateLabel()
        If _blockStatus Xor LogicReverse Then
            lblRail.BackColor = Color.Red
            lblRail.ForeColor = Color.White
        Else
            If TextValue Is Nothing Then
                lblRail.BackColor = Color.White
                lblRail.ForeColor = Color.Magenta
            Else
                lblRail.BackColor = Color.Lime
                lblRail.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub lblRail_DoubleClick(sender As Object, e As System.EventArgs) Handles lblRail.DoubleClick
        Dim args As New LintRailAccessRightEventArgs(rightNeeded:=RailAccessOptions.BLOCK_UNBLOCK_RAIL, hasRight:=Not LintSecurityProvider.ENABLE_SECURITY)
        OnBlockingUnblockingRails(args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            ValueFromObjectToPlc(String.Empty, Not (_blockStatus), True)
            Opc.AsyncWrite(GroupName)
            OnBlockedUnblockedRails(args)
        Else
        End If
    End Sub

    Private Sub OnBlockingUnblockingRails(ByVal e As LintRoleAccessRightEventArgs)
        If LintSecurityProvider.ENABLE_SECURITY Then RaiseEvent _OnBlockingUnblockingRail(Me, e)
    End Sub

    Private Sub OnBlockedUnblockedRails(ByVal e As LintRoleAccessRightEventArgs)
        If LintSecurityProvider.ENABLE_SECURITY Then
            Dim actionType As LintAction = IIf(Not _blockStatus Xor LogicReverse, LintAction.BLOCK_STORAGE_RAIL, LintAction.UNBLOCK_STORAGE_RAIL)
            Dim logDesc As String = String.Format("{0} side {1} rail {2} was {3}", PlcName, TravelArea.ToString, RailNumber, actionType.ToString)
            Dim args As New LintOperatorEventArgs(Now, e.EmployeeID, My.Computer.Name, actionType, logDesc)
            RaiseEvent _OnBlockedUnblockedRail(Me, args)
        End If
    End Sub

    Private Sub CtrlOPCTSARailBlockLabel_MouseHover(sender As Object, e As System.EventArgs) Handles lblRail.MouseHover
        RaiseEvent _MouseHover(Me, e)
    End Sub

    Sub New()
        InitializeComponent()
        lblRail.Text = 99
    End Sub

End Class