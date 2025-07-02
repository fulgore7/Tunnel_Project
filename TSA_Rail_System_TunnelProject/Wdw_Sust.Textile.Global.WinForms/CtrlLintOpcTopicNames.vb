Imports System.ComponentModel
Imports Wdw_Sust.Textile.Global.WinForms.Core

Public Class CtrlLintOpcTopicNames
    Inherits CtrlFormBase

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        ConfigBindingSource.DataSource = CONFIGURATION.PlcTopics
    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MsgBox("Please apply on the Admin Console form ")
    End Sub
End Class
