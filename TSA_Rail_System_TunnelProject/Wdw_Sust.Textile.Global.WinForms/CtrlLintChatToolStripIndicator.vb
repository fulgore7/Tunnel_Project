Imports System.Windows.Forms.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports Wdw_Sust.Textile.Core.Interfaces

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip Or ToolStripItemDesignerAvailability.StatusStrip)>
Public Class CtrlLintChatToolStripIndicator
    Inherits ToolStripControlHost

#Region "Methods"

    Public Sub SetChatClient(ByVal client As IChatClient)
        CType(Control, CtrlLintChatIcon).SetClient(client)
    End Sub

    Public Sub SetClickHandler(ByVal handler As Action)
        CType(Control, CtrlLintChatIcon).SetClickHandler(handler)
    End Sub

#End Region

#Region "Constructors"

    Public Sub New()
        MyBase.New(New CtrlLintChatIcon)
        Control.Dock = DockStyle.Fill
        AutoSize = False
        Size = New Size(142, 32)
    End Sub

#End Region

End Class


