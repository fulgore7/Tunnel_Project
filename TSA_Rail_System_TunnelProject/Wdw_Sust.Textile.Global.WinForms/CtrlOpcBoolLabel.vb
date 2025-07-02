Imports System.ComponentModel

Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.OpcDa.Core.Interfaces
Namespace Wdw_Sust.Textile.Global.Opc.WinForms
    Public Class CtrlOpcBoolLabel
        Implements IOpcElementControl
        Private _textWhenTrue As String
        Private _textWhenFalse As String

        '<Category("OPC Properties"), Description("Text to display when the control is visible") _
        ', Attributes.NotConnectableOPCItem(), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)> _
        '    Public Overrides Property Text() As String
        '    Get
        '        Return Me.Label1.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.Label1.Text = value
        '    End Set
        'End Property
        Protected Friend Sub UpdateControl(ByVal shown As Boolean)
            If InvokeRequired Then
                BeginInvoke(Sub(s) UpdateControl(s), New Object() {shown})
            Else
                Select Case shown
                    Case False
                        Label1.Text = _textWhenFalse
                    Case True
                        Label1.Text = _textWhenTrue
                End Select
                If Label1.Text = String.Empty Then
                    Visible = False
                Else
                    Visible = True
                End If
            End If
        End Sub
        Protected Overrides Sub ValueFromPlcToObject(ByVal index As Integer, ByVal value As Object)
            Select Case index
                Case 1
                    UpdateControl(CBool(value))
                Case Else
                    Throw New Exception("Index Out of Range!!")
            End Select
        End Sub
        <Category("OPC Properties"), Description("Text to display when the control value is false") _
    , NotConnectableOpcItem(), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)>
        Public Property TextWhenFalse() As String
            Get
                Return _textWhenFalse
            End Get
            Set(ByVal value As String)
                _textWhenFalse = value
            End Set
        End Property
        <Category("OPC Properties"), Description("Text to display when the control value is true") _
    , NotConnectableOpcItem(), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)>
        Public Property TextWhenTrue() As String
            Get
                Return _textWhenTrue
            End Get
            Set(ByVal value As String)
                _textWhenTrue = value
                Me.Label1.Text = _textWhenTrue
            End Set
        End Property
    End Class
End Namespace
