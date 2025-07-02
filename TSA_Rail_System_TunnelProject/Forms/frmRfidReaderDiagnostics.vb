
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms

Public Class frmRfidReaderDiagnostics
    Inherits CtrlOpcRailFormBase
    'assign ironer RF reader serial numbers
    'Ironer1 Node 1-3 -> Lane1 to Lane 3
    'Ironer2 Node 4-6 -> Lane1 to Lane 3 (Future)
    'Ironer3 Node 7-9 -> Lane1 to Lane 3 (Future)
    'Ironer4 Node 10-12 -> Lane1 to Lane 3
    'Ironer5 Node 15-17 -> Lane1 to Lane 3 (Future)
    'Ironer6 Node 18-20 -> Lane1 to Lane 3 (Future)
    'Ironer7 Node 21-23 -> Lane1 to Lane 2(Future)
    'Ironer8 Node 24-29 -> Lane1 to Lane 6
    Private WithEvents _resetIronerCommCount As OpcElement
    Private WithEvents _resetTFCommCount As OpcElement
    Private _castInfo As LintCastMember
    Private _groupName As String

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        tableFlatWork.Enabled = (_castInfo.UserType = LintUserType.SYSTEM_ADMINISTRATOR)
        tableTowelFold.Enabled = (_castInfo.UserType = LintUserType.SYSTEM_ADMINISTRATOR)

    End Sub

    Protected Overrides Sub InitializeOpcObjects()
        _groupName = CtrlOPCLabel11.GroupName
        _resetIronerCommCount = AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaProductivityPlc, "seqIronerReadersDiagnosticCountReset", _groupName)
        _resetTFCommCount = AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaProductivityPlc, "seqTFReadersDiagnosticCountReset", _groupName)
        MyBase.InitializeOpcObjects() 'needed for the tags to talk to the PLC
    End Sub

    Private Sub _resetIronerCommCount_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles _resetIronerCommCount.PropertiesUpdateCompleted
        btnIronerCommCountReset.Enabled = (_resetIronerCommCount.Value = 0)
    End Sub

    Private Sub btnIronerCommCountReset_Click(sender As Object, e As System.EventArgs) Handles btnIronerCommCountReset.Click
        btnIronerCommCountReset.Enabled = False
        _resetIronerCommCount.ValueFromObjectToPlc(String.Empty, 10)
    End Sub

    Private Sub _resetTFCommCount_PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs) Handles _resetTFCommCount.PropertiesUpdateCompleted
        btnTFCommCountReset.Enabled = (_resetTFCommCount.Value = 0)
    End Sub

    Private Sub btnTFCommCountReset_Click(sender As Object, e As System.EventArgs) Handles btnTFCommCountReset.Click
        'btnTFCommCountReset.Enabled = False
        _resetTFCommCount.ValueFromObjectToPlc(String.Empty, 10)
    End Sub

    Public Sub New(ByVal castInfo As LintCastMember)
        ' This call is required by the designer.
        InitializeComponent()
        _castInfo = castInfo
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub gbFlatWork_Enter(sender As Object, e As System.EventArgs)

    End Sub


End Class
