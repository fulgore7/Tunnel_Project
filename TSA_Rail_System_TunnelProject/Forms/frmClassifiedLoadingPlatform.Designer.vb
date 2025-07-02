Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.WinForms
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClassifiedLoadingPlatform

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassifiedLoadingPlatform))
        Me.OPCGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlOpcTsaRailSequenceStep1 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaBag4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag1 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCShortTrip25 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBag154 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag136 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag214 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag215 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcRailSequenceStep25 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep24 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep23 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep22 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep21 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOPCBagAddButton127 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag213 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBagAddButton126 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip24 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBagAddButton125 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip23 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBag207 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag208 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag209 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag210 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag211 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag212 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBagAddButton124 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip22 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBagAddButton123 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip21 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBagAddButton122 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag206 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag203 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag204 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag205 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag193 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag194 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag195 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag196 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag197 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag198 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag199 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag200 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag201 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag202 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag179 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag180 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag181 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag182 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag183 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag184 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag185 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag186 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag187 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag188 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag189 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag190 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag191 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag192 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag163 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag164 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag165 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag166 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag167 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag168 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag169 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag170 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag171 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag172 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag173 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag174 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag175 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag176 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag177 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag178 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCShortTrip19 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip20 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBag137 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag155 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag156 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag157 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag158 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag159 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag160 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag161 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag162 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBagAddButton121 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip18 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBagAddButton120 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip17 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBag133 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag134 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag135 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag115 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag131 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag132 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag102 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag111 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag112 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag101 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag100 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag99 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBagAddButton119 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip16 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlLINTAlarmIcon15 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon14 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon12 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon11 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon9 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon4 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon2 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon1 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlOpcRailSequenceStep19 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep18 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep16 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep15 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOPCShortTrip14 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip13 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip12 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip10 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip11 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip8 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBagAddButton114 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton106 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton105 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCBagAddButton97 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton98 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton100 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton95 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton96 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton93 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcRailSequenceStep14 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep13 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep11 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep10 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep9 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep8 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep7 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOPCBag146 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag148 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag149 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBagAddButton83 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton84 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton85 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton86 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton87 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton88 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton89 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton90 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton91 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton92 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton73 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton74 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton75 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton76 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton77 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton78 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton79 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton80 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton81 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton82 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton63 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton64 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton65 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton66 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton67 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton68 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton69 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton70 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton71 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton72 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton56 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton57 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton58 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton59 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton60 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton61 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton62 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton49 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton50 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton51 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton52 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton53 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton54 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton55 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton42 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton43 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton44 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton45 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton46 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton47 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton48 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton31 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton32 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton33 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton34 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton28 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton29 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton30 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton11 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton12 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton13 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton14 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton15 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton16 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton17 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton18 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton19 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton20 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton1 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton2 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton3 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton4 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton5 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton6 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton7 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton8 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton9 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton10 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag116 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag117 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag118 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag119 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag120 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag121 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag122 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag123 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag124 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag125 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag104 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag145 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag141 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag143 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag142 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag138 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag113 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag108 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag109 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag110 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag105 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag106 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag107 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag90 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag91 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag92 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag93 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag94 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag95 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag96 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag73 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag74 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag75 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag76 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag77 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag78 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag57 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag58 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag65 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag66 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag67 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag68 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag69 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag70 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag46 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag47 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag48 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag49 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag50 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag51 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag52 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag53 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag54 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag28 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag29 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag30 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag31 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag32 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag33 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag34 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag35 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag36 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag37 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag38 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag39 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag40 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag41 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag42 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag43 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag44 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag45 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag19 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag20 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag21 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag22 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag23 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag24 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag25 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag26 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag27 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag10 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag11 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag12 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag13 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag14 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag15 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag16 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag17 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag18 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag7 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag8 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag9 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag5 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag6 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag1 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag72 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag71 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag64 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag63 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag62 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag61 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag60 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag59 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag80 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag79 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag56 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag55 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag82 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag81 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag89 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag88 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag87 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag86 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag85 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag84 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag83 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBagAddButton27 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton26 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton25 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton24 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton23 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton22 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton21 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton41 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton40 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton39 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton38 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton37 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton36 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton35 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBag153 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCBag150 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcRailSequenceStep12 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOPCBagAddButton94 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton99 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCShortTrip9 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOPCShortTrip15 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOpcRailSequenceStep17 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcRailSequenceStep20 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlLINTAlarmIcon3 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon10 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlOpcTsaBag2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaRailSequenceStep2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaRailSequenceStep3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaRailSequenceStep4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOPCSwitchGateButton1 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOPCSwitchGateButton()
        Me.CtrlOPCSwitchGateButton2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOPCSwitchGateButton()
        Me.CtrlOPCSwitchGateButton4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOPCSwitchGateButton()
        Me.CtrlOPCSwitchGateButton3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOPCSwitchGateButton()
        Me.CtrlOpcBagAddButton118 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcBagAddButton128 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaBag5 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag6 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton101 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaRailSequenceStep5 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaBag14 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag15 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag16 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag17 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag18 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcShortTrip3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOpcBagAddButton107 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaRailSequenceStep8 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaRailSequenceStep9 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaBag20 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag21 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag22 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag23 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton108 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcShortTrip4 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOpcBagAddButton109 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaRailSequenceStep10 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaRailSequenceStep11 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaRailSequenceStep12 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaBagWithStorageDestination3 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBagWithStorageDestination()
        Me.CtrlOpcTsaBag11 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag12 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag13 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton110 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcShortTrip5 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOpcTsaBag24 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag25 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag26 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag27 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag28 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton104 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaBag29 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag30 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton113 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcShortTrip6 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlOpcTsaBag32 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton115 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaRailSequenceStep13 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcShortTrip7 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcShortTrip()
        Me.CtrlLintAlarmIcon18 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLintAlarmIcon17 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLintAlarmIcon16 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLintAlarmIcon8 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlOPCBagAddButton112 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagAddButton111 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOPCBagWithStorageDestination17 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBagWithStorageDestination()
        Me.CtrlOPCBag103 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlLintAlarmIcon6 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLintAlarmIcon7 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlOpcBagAddButton116 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcBagAddButton117 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaBag9 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag10 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag7 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcTsaBag8 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton130 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcBagAddButton131 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcBagAddButton102 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcBagAddButton129 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlLintAlarmIcon13 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLintAlarmIcon5 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlOpcTsaBagWithStorageDestination2 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBagWithStorageDestination()
        Me.CtrlOpcTsaBagWithStorageDestination1 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBagWithStorageDestination()
        Me.CtrlOpcTsaRailSequenceStep7 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcTsaRailSequenceStep6 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaRailSequenceStep()
        Me.CtrlOpcBagAddButton103 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcBagAddButton132 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaBag19 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton133 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        Me.CtrlOpcTsaBag31 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOpcBagAddButton134 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBagAddButton()
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPCGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OPCGroupBindingSource
        '
        Me.OPCGroupBindingSource.DataSource = GetType(TSA_Rail_System.ClassifiedLoadingPlatformOpcGroupName)
        '
        'CtrlOpcTsaRailSequenceStep1
        '
        Me.CtrlOpcTsaRailSequenceStep1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep1.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep1.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep1.Location = New System.Drawing.Point(896, 153)
        Me.CtrlOpcTsaRailSequenceStep1.Name = "CtrlOpcTsaRailSequenceStep1"
        Me.CtrlOpcTsaRailSequenceStep1.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep1.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep1.SequenceID = 1205
        Me.CtrlOpcTsaRailSequenceStep1.Size = New System.Drawing.Size(65, 23)
        Me.CtrlOpcTsaRailSequenceStep1.TabIndex = 417
        Me.CtrlOpcTsaRailSequenceStep1.TagName = "VC5_Release_SEQ"
        Me.CtrlOpcTsaRailSequenceStep1.Text = "Buffer 5"
        '
        'CtrlOpcTsaBag4
        '
        Me.CtrlOpcTsaBag4.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag4.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag4.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag4.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag4.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag4.Category = 88
        Me.CtrlOpcTsaBag4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag4.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOpcTsaBag4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag4.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOpcTsaBag4.Location = New System.Drawing.Point(967, 170)
        Me.CtrlOpcTsaBag4.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag4.Name = "CtrlOpcTsaBag4"
        Me.CtrlOpcTsaBag4.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag4.PlcName = Nothing
        Me.CtrlOpcTsaBag4.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag4.TabIndex = 416
        Me.CtrlOpcTsaBag4.TagName = "VC_Track[5,2]"
        Me.CtrlOpcTsaBag4.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag1
        '
        Me.CtrlOpcTsaBag1.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag1.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag1.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag1.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag1.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag1.Category = 88
        Me.CtrlOpcTsaBag1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag1.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOpcTsaBag1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag1.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOpcTsaBag1.Location = New System.Drawing.Point(851, 171)
        Me.CtrlOpcTsaBag1.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag1.Name = "CtrlOpcTsaBag1"
        Me.CtrlOpcTsaBag1.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag1.PlcName = Nothing
        Me.CtrlOpcTsaBag1.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag1.TabIndex = 413
        Me.CtrlOpcTsaBag1.TagName = "VC_Track[5,3]"
        Me.CtrlOpcTsaBag1.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCShortTrip25
        '
        Me.CtrlOPCShortTrip25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip25.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip25.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip25.Location = New System.Drawing.Point(284, 600)
        Me.CtrlOPCShortTrip25.Name = "CtrlOPCShortTrip25"
        Me.CtrlOPCShortTrip25.PlcName = Nothing
        Me.CtrlOPCShortTrip25.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip25.TabIndex = 412
        Me.CtrlOPCShortTrip25.TagName = "Seq_Trip[156]"
        '
        'CtrlOPCBag154
        '
        Me.CtrlOPCBag154.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag154.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag154.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag154.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag154.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag154.Category = 88
        Me.CtrlOPCBag154.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag154.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag154.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag154.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag154.Location = New System.Drawing.Point(1304, 628)
        Me.CtrlOPCBag154.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag154.Name = "CtrlOPCBag154"
        Me.CtrlOPCBag154.PLC_Bag_ID = 0
        Me.CtrlOPCBag154.PlcName = Nothing
        Me.CtrlOPCBag154.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag154.TabIndex = 411
        Me.CtrlOPCBag154.TagName = "EBB[8,19]"
        Me.CtrlOPCBag154.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag136
        '
        Me.CtrlOPCBag136.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag136.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag136.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag136.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag136.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag136.Category = 88
        Me.CtrlOPCBag136.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag136.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag136.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag136.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag136.Location = New System.Drawing.Point(1339, 376)
        Me.CtrlOPCBag136.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag136.Name = "CtrlOPCBag136"
        Me.CtrlOPCBag136.PLC_Bag_ID = 0
        Me.CtrlOPCBag136.PlcName = Nothing
        Me.CtrlOPCBag136.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag136.TabIndex = 410
        Me.CtrlOPCBag136.TagName = "EBB[7,10]"
        Me.CtrlOPCBag136.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag214
        '
        Me.CtrlOPCBag214.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag214.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag214.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag214.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag214.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag214.Category = 88
        Me.CtrlOPCBag214.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag214.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag214.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag214.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag214.Location = New System.Drawing.Point(1304, 289)
        Me.CtrlOPCBag214.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag214.Name = "CtrlOPCBag214"
        Me.CtrlOPCBag214.PLC_Bag_ID = 0
        Me.CtrlOPCBag214.PlcName = Nothing
        Me.CtrlOPCBag214.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag214.TabIndex = 409
        Me.CtrlOPCBag214.TagName = "EBB[8,9]"
        Me.CtrlOPCBag214.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag215
        '
        Me.CtrlOPCBag215.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag215.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag215.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag215.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag215.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag215.Category = 88
        Me.CtrlOPCBag215.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag215.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag215.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag215.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag215.Location = New System.Drawing.Point(1339, 289)
        Me.CtrlOPCBag215.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag215.Name = "CtrlOPCBag215"
        Me.CtrlOPCBag215.PLC_Bag_ID = 0
        Me.CtrlOPCBag215.PlcName = Nothing
        Me.CtrlOPCBag215.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag215.TabIndex = 408
        Me.CtrlOPCBag215.TagName = "EBB[7,9]"
        Me.CtrlOPCBag215.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOpcRailSequenceStep25
        '
        Me.CtrlOpcRailSequenceStep25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep25.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep25.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep25.Location = New System.Drawing.Point(1286, 13)
        Me.CtrlOpcRailSequenceStep25.Name = "CtrlOpcRailSequenceStep25"
        Me.CtrlOpcRailSequenceStep25.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep25.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep25.SequenceID = 1011
        Me.CtrlOpcRailSequenceStep25.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcRailSequenceStep25.TabIndex = 407
        Me.CtrlOpcRailSequenceStep25.TagName = "gSeq[12]"
        Me.CtrlOpcRailSequenceStep25.Text = "<<<"
        '
        'CtrlOpcRailSequenceStep24
        '
        Me.CtrlOpcRailSequenceStep24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep24.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep24.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep24.Location = New System.Drawing.Point(1227, 725)
        Me.CtrlOpcRailSequenceStep24.Name = "CtrlOpcRailSequenceStep24"
        Me.CtrlOpcRailSequenceStep24.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep24.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep24.SequenceID = 1013
        Me.CtrlOpcRailSequenceStep24.Size = New System.Drawing.Size(33, 23)
        Me.CtrlOpcRailSequenceStep24.TabIndex = 406
        Me.CtrlOpcRailSequenceStep24.TagName = "gSeq[14]"
        Me.CtrlOpcRailSequenceStep24.Text = ">>>"
        '
        'CtrlOpcRailSequenceStep23
        '
        Me.CtrlOpcRailSequenceStep23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep23.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep23.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep23.Location = New System.Drawing.Point(1339, 349)
        Me.CtrlOpcRailSequenceStep23.Name = "CtrlOpcRailSequenceStep23"
        Me.CtrlOpcRailSequenceStep23.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep23.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep23.SequenceID = 1009
        Me.CtrlOpcRailSequenceStep23.Size = New System.Drawing.Size(33, 23)
        Me.CtrlOpcRailSequenceStep23.TabIndex = 405
        Me.CtrlOpcRailSequenceStep23.TagName = "gSeq[10]"
        Me.CtrlOpcRailSequenceStep23.Text = "<<<"
        '
        'CtrlOpcRailSequenceStep22
        '
        Me.CtrlOpcRailSequenceStep22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep22.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep22.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep22.Location = New System.Drawing.Point(1302, 349)
        Me.CtrlOpcRailSequenceStep22.Name = "CtrlOpcRailSequenceStep22"
        Me.CtrlOpcRailSequenceStep22.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep22.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep22.SequenceID = 1010
        Me.CtrlOpcRailSequenceStep22.Size = New System.Drawing.Size(33, 23)
        Me.CtrlOpcRailSequenceStep22.TabIndex = 404
        Me.CtrlOpcRailSequenceStep22.TagName = "gSeq[11]"
        Me.CtrlOpcRailSequenceStep22.Text = ">>>"
        '
        'CtrlOpcRailSequenceStep21
        '
        Me.CtrlOpcRailSequenceStep21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep21.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep21.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep21.Location = New System.Drawing.Point(1103, 760)
        Me.CtrlOpcRailSequenceStep21.Name = "CtrlOpcRailSequenceStep21"
        Me.CtrlOpcRailSequenceStep21.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep21.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep21.SequenceID = 1014
        Me.CtrlOpcRailSequenceStep21.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep21.TabIndex = 403
        Me.CtrlOpcRailSequenceStep21.TagName = "gSeq[15]"
        Me.CtrlOpcRailSequenceStep21.Text = ">>>"
        '
        'CtrlOPCBagAddButton127
        '
        Me.CtrlOPCBagAddButton127.AllowDrop = True
        Me.CtrlOPCBagAddButton127.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton127.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton127.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton127.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton127.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton127.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton127.Location = New System.Drawing.Point(1131, 731)
        Me.CtrlOPCBagAddButton127.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton127.Name = "CtrlOPCBagAddButton127"
        Me.CtrlOPCBagAddButton127.PlcName = Nothing
        Me.CtrlOPCBagAddButton127.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton127.TabIndex = 402
        Me.CtrlOPCBagAddButton127.TagName = "Empty_Track[1,2]"
        Me.CtrlOPCBagAddButton127.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag213
        '
        Me.CtrlOPCBag213.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag213.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag213.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag213.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag213.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag213.Category = 88
        Me.CtrlOPCBag213.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag213.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag213.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag213.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag213.Location = New System.Drawing.Point(1125, 700)
        Me.CtrlOPCBag213.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag213.Name = "CtrlOPCBag213"
        Me.CtrlOPCBag213.PLC_Bag_ID = 0
        Me.CtrlOPCBag213.PlcName = Nothing
        Me.CtrlOPCBag213.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag213.TabIndex = 401
        Me.CtrlOPCBag213.TagName = "Empty_Track[1,2]"
        Me.CtrlOPCBag213.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBagAddButton126
        '
        Me.CtrlOPCBagAddButton126.AllowDrop = True
        Me.CtrlOPCBagAddButton126.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton126.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton126.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton126.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton126.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton126.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton126.Location = New System.Drawing.Point(1274, 523)
        Me.CtrlOPCBagAddButton126.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton126.Name = "CtrlOPCBagAddButton126"
        Me.CtrlOPCBagAddButton126.PlcName = Nothing
        Me.CtrlOPCBagAddButton126.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton126.TabIndex = 400
        Me.CtrlOPCBagAddButton126.TagName = "EBB[11,6]"
        Me.CtrlOPCBagAddButton126.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip24
        '
        Me.CtrlOPCShortTrip24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip24.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip24.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip24.Location = New System.Drawing.Point(1274, 508)
        Me.CtrlOPCShortTrip24.Name = "CtrlOPCShortTrip24"
        Me.CtrlOPCShortTrip24.PlcName = Nothing
        Me.CtrlOPCShortTrip24.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip24.TabIndex = 399
        Me.CtrlOPCShortTrip24.TagName = "Seq_Trip[124]"
        '
        'CtrlOPCBagAddButton125
        '
        Me.CtrlOPCBagAddButton125.AllowDrop = True
        Me.CtrlOPCBagAddButton125.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton125.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton125.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton125.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton125.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton125.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton125.Location = New System.Drawing.Point(1191, 632)
        Me.CtrlOPCBagAddButton125.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton125.Name = "CtrlOPCBagAddButton125"
        Me.CtrlOPCBagAddButton125.PlcName = Nothing
        Me.CtrlOPCBagAddButton125.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton125.TabIndex = 398
        Me.CtrlOPCBagAddButton125.TagName = "EBB[12,13]"
        Me.CtrlOPCBagAddButton125.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip23
        '
        Me.CtrlOPCShortTrip23.BackColor = System.Drawing.Color.White
        Me.CtrlOPCShortTrip23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip23.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip23.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip23.Location = New System.Drawing.Point(1191, 647)
        Me.CtrlOPCShortTrip23.Name = "CtrlOPCShortTrip23"
        Me.CtrlOPCShortTrip23.PlcName = Nothing
        Me.CtrlOPCShortTrip23.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip23.TabIndex = 397
        Me.CtrlOPCShortTrip23.TagName = "Seq_Trip[84]"
        '
        'CtrlOPCBag207
        '
        Me.CtrlOPCBag207.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag207.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag207.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag207.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag207.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag207.Category = 88
        Me.CtrlOPCBag207.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag207.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag207.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag207.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag207.Location = New System.Drawing.Point(1268, 679)
        Me.CtrlOPCBag207.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag207.Name = "CtrlOPCBag207"
        Me.CtrlOPCBag207.PLC_Bag_ID = 0
        Me.CtrlOPCBag207.PlcName = Nothing
        Me.CtrlOPCBag207.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag207.TabIndex = 396
        Me.CtrlOPCBag207.TagName = "EBB[11,1]"
        Me.CtrlOPCBag207.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag208
        '
        Me.CtrlOPCBag208.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag208.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag208.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag208.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag208.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag208.Category = 88
        Me.CtrlOPCBag208.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag208.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag208.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag208.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag208.Location = New System.Drawing.Point(1268, 651)
        Me.CtrlOPCBag208.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag208.Name = "CtrlOPCBag208"
        Me.CtrlOPCBag208.PLC_Bag_ID = 0
        Me.CtrlOPCBag208.PlcName = Nothing
        Me.CtrlOPCBag208.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag208.TabIndex = 395
        Me.CtrlOPCBag208.TagName = "EBB[11,2]"
        Me.CtrlOPCBag208.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag209
        '
        Me.CtrlOPCBag209.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag209.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag209.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag209.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag209.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag209.Category = 88
        Me.CtrlOPCBag209.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag209.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag209.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag209.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag209.Location = New System.Drawing.Point(1268, 623)
        Me.CtrlOPCBag209.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag209.Name = "CtrlOPCBag209"
        Me.CtrlOPCBag209.PLC_Bag_ID = 0
        Me.CtrlOPCBag209.PlcName = Nothing
        Me.CtrlOPCBag209.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag209.TabIndex = 394
        Me.CtrlOPCBag209.TagName = "EBB[11,3]"
        Me.CtrlOPCBag209.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag210
        '
        Me.CtrlOPCBag210.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag210.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag210.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag210.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag210.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag210.Category = 88
        Me.CtrlOPCBag210.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag210.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag210.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag210.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag210.Location = New System.Drawing.Point(1268, 595)
        Me.CtrlOPCBag210.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag210.Name = "CtrlOPCBag210"
        Me.CtrlOPCBag210.PLC_Bag_ID = 0
        Me.CtrlOPCBag210.PlcName = Nothing
        Me.CtrlOPCBag210.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag210.TabIndex = 393
        Me.CtrlOPCBag210.TagName = "EBB[11,4]"
        Me.CtrlOPCBag210.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag211
        '
        Me.CtrlOPCBag211.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag211.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag211.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag211.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag211.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag211.Category = 88
        Me.CtrlOPCBag211.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag211.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag211.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag211.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag211.Location = New System.Drawing.Point(1268, 567)
        Me.CtrlOPCBag211.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag211.Name = "CtrlOPCBag211"
        Me.CtrlOPCBag211.PLC_Bag_ID = 0
        Me.CtrlOPCBag211.PlcName = Nothing
        Me.CtrlOPCBag211.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag211.TabIndex = 392
        Me.CtrlOPCBag211.TagName = "EBB[11,5]"
        Me.CtrlOPCBag211.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag212
        '
        Me.CtrlOPCBag212.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag212.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag212.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag212.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag212.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag212.Category = 88
        Me.CtrlOPCBag212.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag212.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag212.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag212.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag212.Location = New System.Drawing.Point(1268, 539)
        Me.CtrlOPCBag212.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag212.Name = "CtrlOPCBag212"
        Me.CtrlOPCBag212.PLC_Bag_ID = 0
        Me.CtrlOPCBag212.PlcName = Nothing
        Me.CtrlOPCBag212.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag212.TabIndex = 391
        Me.CtrlOPCBag212.TagName = "EBB[11,6]"
        Me.CtrlOPCBag212.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBagAddButton124
        '
        Me.CtrlOPCBagAddButton124.AllowDrop = True
        Me.CtrlOPCBagAddButton124.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton124.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton124.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton124.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton124.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton124.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton124.Location = New System.Drawing.Point(1275, 131)
        Me.CtrlOPCBagAddButton124.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton124.Name = "CtrlOPCBagAddButton124"
        Me.CtrlOPCBagAddButton124.PlcName = Nothing
        Me.CtrlOPCBagAddButton124.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton124.TabIndex = 390
        Me.CtrlOPCBagAddButton124.TagName = "EBB[9,7]"
        Me.CtrlOPCBagAddButton124.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip22
        '
        Me.CtrlOPCShortTrip22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip22.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip22.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip22.Location = New System.Drawing.Point(1275, 116)
        Me.CtrlOPCShortTrip22.Name = "CtrlOPCShortTrip22"
        Me.CtrlOPCShortTrip22.PlcName = Nothing
        Me.CtrlOPCShortTrip22.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip22.TabIndex = 389
        Me.CtrlOPCShortTrip22.TagName = "Seq_Trip[123]"
        '
        'CtrlOPCBagAddButton123
        '
        Me.CtrlOPCBagAddButton123.AllowDrop = True
        Me.CtrlOPCBagAddButton123.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton123.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton123.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton123.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton123.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton123.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton123.Location = New System.Drawing.Point(1241, 131)
        Me.CtrlOPCBagAddButton123.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton123.Name = "CtrlOPCBagAddButton123"
        Me.CtrlOPCBagAddButton123.PlcName = Nothing
        Me.CtrlOPCBagAddButton123.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton123.TabIndex = 388
        Me.CtrlOPCBagAddButton123.TagName = "EBB[6,3]"
        Me.CtrlOPCBagAddButton123.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip21
        '
        Me.CtrlOPCShortTrip21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip21.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip21.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip21.Location = New System.Drawing.Point(1241, 116)
        Me.CtrlOPCShortTrip21.Name = "CtrlOPCShortTrip21"
        Me.CtrlOPCShortTrip21.PlcName = Nothing
        Me.CtrlOPCShortTrip21.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip21.TabIndex = 387
        Me.CtrlOPCShortTrip21.TagName = "Seq_Trip[122]"
        '
        'CtrlOPCBagAddButton122
        '
        Me.CtrlOPCBagAddButton122.AllowDrop = True
        Me.CtrlOPCBagAddButton122.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton122.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton122.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton122.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton122.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton122.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton122.Location = New System.Drawing.Point(1274, 455)
        Me.CtrlOPCBagAddButton122.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton122.Name = "CtrlOPCBagAddButton122"
        Me.CtrlOPCBagAddButton122.PlcName = Nothing
        Me.CtrlOPCBagAddButton122.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton122.TabIndex = 386
        Me.CtrlOPCBagAddButton122.TagName = "EBB[11,7]"
        Me.CtrlOPCBagAddButton122.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag206
        '
        Me.CtrlOPCBag206.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag206.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag206.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag206.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag206.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag206.Category = 88
        Me.CtrlOPCBag206.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag206.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag206.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag206.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag206.Location = New System.Drawing.Point(1268, 471)
        Me.CtrlOPCBag206.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag206.Name = "CtrlOPCBag206"
        Me.CtrlOPCBag206.PLC_Bag_ID = 0
        Me.CtrlOPCBag206.PlcName = Nothing
        Me.CtrlOPCBag206.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag206.TabIndex = 385
        Me.CtrlOPCBag206.TagName = "EBB[11,7]"
        Me.CtrlOPCBag206.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag203
        '
        Me.CtrlOPCBag203.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag203.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag203.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag203.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag203.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag203.Category = 88
        Me.CtrlOPCBag203.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag203.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag203.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag203.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag203.Location = New System.Drawing.Point(1184, 604)
        Me.CtrlOPCBag203.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag203.Name = "CtrlOPCBag203"
        Me.CtrlOPCBag203.PLC_Bag_ID = 0
        Me.CtrlOPCBag203.PlcName = Nothing
        Me.CtrlOPCBag203.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag203.TabIndex = 384
        Me.CtrlOPCBag203.TagName = "EBB[12,13]"
        Me.CtrlOPCBag203.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag204
        '
        Me.CtrlOPCBag204.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag204.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag204.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag204.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag204.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag204.Category = 88
        Me.CtrlOPCBag204.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag204.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag204.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag204.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag204.Location = New System.Drawing.Point(1184, 576)
        Me.CtrlOPCBag204.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag204.Name = "CtrlOPCBag204"
        Me.CtrlOPCBag204.PLC_Bag_ID = 0
        Me.CtrlOPCBag204.PlcName = Nothing
        Me.CtrlOPCBag204.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag204.TabIndex = 383
        Me.CtrlOPCBag204.TagName = "EBB[12,12]"
        Me.CtrlOPCBag204.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag205
        '
        Me.CtrlOPCBag205.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag205.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag205.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag205.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag205.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag205.Category = 88
        Me.CtrlOPCBag205.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag205.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag205.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag205.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag205.Location = New System.Drawing.Point(1184, 548)
        Me.CtrlOPCBag205.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag205.Name = "CtrlOPCBag205"
        Me.CtrlOPCBag205.PLC_Bag_ID = 0
        Me.CtrlOPCBag205.PlcName = Nothing
        Me.CtrlOPCBag205.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag205.TabIndex = 382
        Me.CtrlOPCBag205.TagName = "EBB[12,11]"
        Me.CtrlOPCBag205.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag193
        '
        Me.CtrlOPCBag193.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag193.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag193.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag193.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag193.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag193.Category = 88
        Me.CtrlOPCBag193.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag193.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag193.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag193.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag193.Location = New System.Drawing.Point(1184, 520)
        Me.CtrlOPCBag193.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag193.Name = "CtrlOPCBag193"
        Me.CtrlOPCBag193.PLC_Bag_ID = 0
        Me.CtrlOPCBag193.PlcName = Nothing
        Me.CtrlOPCBag193.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag193.TabIndex = 381
        Me.CtrlOPCBag193.TagName = "EBB[12,10]"
        Me.CtrlOPCBag193.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag194
        '
        Me.CtrlOPCBag194.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag194.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag194.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag194.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag194.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag194.Category = 88
        Me.CtrlOPCBag194.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag194.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag194.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag194.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag194.Location = New System.Drawing.Point(1184, 492)
        Me.CtrlOPCBag194.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag194.Name = "CtrlOPCBag194"
        Me.CtrlOPCBag194.PLC_Bag_ID = 0
        Me.CtrlOPCBag194.PlcName = Nothing
        Me.CtrlOPCBag194.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag194.TabIndex = 380
        Me.CtrlOPCBag194.TagName = "EBB[12,9]"
        Me.CtrlOPCBag194.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag195
        '
        Me.CtrlOPCBag195.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag195.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag195.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag195.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag195.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag195.Category = 88
        Me.CtrlOPCBag195.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag195.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag195.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag195.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag195.Location = New System.Drawing.Point(1184, 464)
        Me.CtrlOPCBag195.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag195.Name = "CtrlOPCBag195"
        Me.CtrlOPCBag195.PLC_Bag_ID = 0
        Me.CtrlOPCBag195.PlcName = Nothing
        Me.CtrlOPCBag195.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag195.TabIndex = 379
        Me.CtrlOPCBag195.TagName = "EBB[12,8]"
        Me.CtrlOPCBag195.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag196
        '
        Me.CtrlOPCBag196.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag196.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag196.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag196.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag196.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag196.Category = 88
        Me.CtrlOPCBag196.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag196.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag196.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag196.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag196.Location = New System.Drawing.Point(1184, 436)
        Me.CtrlOPCBag196.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag196.Name = "CtrlOPCBag196"
        Me.CtrlOPCBag196.PLC_Bag_ID = 0
        Me.CtrlOPCBag196.PlcName = Nothing
        Me.CtrlOPCBag196.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag196.TabIndex = 378
        Me.CtrlOPCBag196.TagName = "EBB[12,7]"
        Me.CtrlOPCBag196.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag197
        '
        Me.CtrlOPCBag197.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag197.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag197.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag197.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag197.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag197.Category = 88
        Me.CtrlOPCBag197.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag197.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag197.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag197.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag197.Location = New System.Drawing.Point(1184, 408)
        Me.CtrlOPCBag197.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag197.Name = "CtrlOPCBag197"
        Me.CtrlOPCBag197.PLC_Bag_ID = 0
        Me.CtrlOPCBag197.PlcName = Nothing
        Me.CtrlOPCBag197.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag197.TabIndex = 377
        Me.CtrlOPCBag197.TagName = "EBB[12,6]"
        Me.CtrlOPCBag197.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag198
        '
        Me.CtrlOPCBag198.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag198.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag198.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag198.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag198.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag198.Category = 88
        Me.CtrlOPCBag198.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag198.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag198.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag198.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag198.Location = New System.Drawing.Point(1184, 380)
        Me.CtrlOPCBag198.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag198.Name = "CtrlOPCBag198"
        Me.CtrlOPCBag198.PLC_Bag_ID = 0
        Me.CtrlOPCBag198.PlcName = Nothing
        Me.CtrlOPCBag198.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag198.TabIndex = 376
        Me.CtrlOPCBag198.TagName = "EBB[12,5]"
        Me.CtrlOPCBag198.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag199
        '
        Me.CtrlOPCBag199.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag199.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag199.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag199.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag199.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag199.Category = 88
        Me.CtrlOPCBag199.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag199.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag199.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag199.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag199.Location = New System.Drawing.Point(1184, 352)
        Me.CtrlOPCBag199.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag199.Name = "CtrlOPCBag199"
        Me.CtrlOPCBag199.PLC_Bag_ID = 0
        Me.CtrlOPCBag199.PlcName = Nothing
        Me.CtrlOPCBag199.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag199.TabIndex = 375
        Me.CtrlOPCBag199.TagName = "EBB[12,4]"
        Me.CtrlOPCBag199.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag200
        '
        Me.CtrlOPCBag200.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag200.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag200.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag200.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag200.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag200.Category = 88
        Me.CtrlOPCBag200.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag200.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag200.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag200.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag200.Location = New System.Drawing.Point(1184, 324)
        Me.CtrlOPCBag200.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag200.Name = "CtrlOPCBag200"
        Me.CtrlOPCBag200.PLC_Bag_ID = 0
        Me.CtrlOPCBag200.PlcName = Nothing
        Me.CtrlOPCBag200.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag200.TabIndex = 374
        Me.CtrlOPCBag200.TagName = "EBB[12,3]"
        Me.CtrlOPCBag200.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag201
        '
        Me.CtrlOPCBag201.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag201.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag201.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag201.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag201.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag201.Category = 88
        Me.CtrlOPCBag201.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag201.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag201.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag201.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag201.Location = New System.Drawing.Point(1184, 296)
        Me.CtrlOPCBag201.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag201.Name = "CtrlOPCBag201"
        Me.CtrlOPCBag201.PLC_Bag_ID = 0
        Me.CtrlOPCBag201.PlcName = Nothing
        Me.CtrlOPCBag201.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag201.TabIndex = 373
        Me.CtrlOPCBag201.TagName = "EBB[12,2]"
        Me.CtrlOPCBag201.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag202
        '
        Me.CtrlOPCBag202.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag202.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag202.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag202.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag202.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag202.Category = 88
        Me.CtrlOPCBag202.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag202.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag202.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag202.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag202.Location = New System.Drawing.Point(1184, 268)
        Me.CtrlOPCBag202.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag202.Name = "CtrlOPCBag202"
        Me.CtrlOPCBag202.PLC_Bag_ID = 0
        Me.CtrlOPCBag202.PlcName = Nothing
        Me.CtrlOPCBag202.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag202.TabIndex = 372
        Me.CtrlOPCBag202.TagName = "EBB[12,1]"
        Me.CtrlOPCBag202.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag179
        '
        Me.CtrlOPCBag179.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag179.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag179.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag179.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag179.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag179.Category = 88
        Me.CtrlOPCBag179.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag179.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag179.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag179.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag179.Location = New System.Drawing.Point(1234, 315)
        Me.CtrlOPCBag179.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag179.Name = "CtrlOPCBag179"
        Me.CtrlOPCBag179.PLC_Bag_ID = 0
        Me.CtrlOPCBag179.PlcName = Nothing
        Me.CtrlOPCBag179.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag179.TabIndex = 371
        Me.CtrlOPCBag179.TagName = "EBB[10,1]"
        Me.CtrlOPCBag179.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag180
        '
        Me.CtrlOPCBag180.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag180.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag180.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag180.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag180.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag180.Category = 88
        Me.CtrlOPCBag180.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag180.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag180.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag180.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag180.Location = New System.Drawing.Point(1234, 287)
        Me.CtrlOPCBag180.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag180.Name = "CtrlOPCBag180"
        Me.CtrlOPCBag180.PLC_Bag_ID = 0
        Me.CtrlOPCBag180.PlcName = Nothing
        Me.CtrlOPCBag180.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag180.TabIndex = 370
        Me.CtrlOPCBag180.TagName = "EBB[10,2]"
        Me.CtrlOPCBag180.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag181
        '
        Me.CtrlOPCBag181.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag181.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag181.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag181.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag181.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag181.Category = 88
        Me.CtrlOPCBag181.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag181.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag181.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag181.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag181.Location = New System.Drawing.Point(1234, 259)
        Me.CtrlOPCBag181.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag181.Name = "CtrlOPCBag181"
        Me.CtrlOPCBag181.PLC_Bag_ID = 0
        Me.CtrlOPCBag181.PlcName = Nothing
        Me.CtrlOPCBag181.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag181.TabIndex = 369
        Me.CtrlOPCBag181.TagName = "EBB[10,3]"
        Me.CtrlOPCBag181.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag182
        '
        Me.CtrlOPCBag182.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag182.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag182.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag182.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag182.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag182.Category = 88
        Me.CtrlOPCBag182.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag182.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag182.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag182.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag182.Location = New System.Drawing.Point(1234, 231)
        Me.CtrlOPCBag182.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag182.Name = "CtrlOPCBag182"
        Me.CtrlOPCBag182.PLC_Bag_ID = 0
        Me.CtrlOPCBag182.PlcName = Nothing
        Me.CtrlOPCBag182.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag182.TabIndex = 368
        Me.CtrlOPCBag182.TagName = "EBB[10,4]"
        Me.CtrlOPCBag182.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag183
        '
        Me.CtrlOPCBag183.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag183.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag183.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag183.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag183.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag183.Category = 88
        Me.CtrlOPCBag183.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag183.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag183.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag183.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag183.Location = New System.Drawing.Point(1234, 203)
        Me.CtrlOPCBag183.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag183.Name = "CtrlOPCBag183"
        Me.CtrlOPCBag183.PLC_Bag_ID = 0
        Me.CtrlOPCBag183.PlcName = Nothing
        Me.CtrlOPCBag183.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag183.TabIndex = 367
        Me.CtrlOPCBag183.TagName = "EBB[10,5]"
        Me.CtrlOPCBag183.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag184
        '
        Me.CtrlOPCBag184.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag184.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag184.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag184.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag184.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag184.Category = 88
        Me.CtrlOPCBag184.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag184.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag184.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag184.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag184.Location = New System.Drawing.Point(1234, 175)
        Me.CtrlOPCBag184.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag184.Name = "CtrlOPCBag184"
        Me.CtrlOPCBag184.PLC_Bag_ID = 0
        Me.CtrlOPCBag184.PlcName = Nothing
        Me.CtrlOPCBag184.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag184.TabIndex = 366
        Me.CtrlOPCBag184.TagName = "EBB[10,6]"
        Me.CtrlOPCBag184.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag185
        '
        Me.CtrlOPCBag185.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag185.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag185.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag185.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag185.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag185.Category = 88
        Me.CtrlOPCBag185.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag185.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag185.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag185.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag185.Location = New System.Drawing.Point(1234, 147)
        Me.CtrlOPCBag185.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag185.Name = "CtrlOPCBag185"
        Me.CtrlOPCBag185.PLC_Bag_ID = 0
        Me.CtrlOPCBag185.PlcName = Nothing
        Me.CtrlOPCBag185.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag185.TabIndex = 365
        Me.CtrlOPCBag185.TagName = "EBB[10,7]"
        Me.CtrlOPCBag185.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag186
        '
        Me.CtrlOPCBag186.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag186.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag186.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag186.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag186.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag186.Category = 88
        Me.CtrlOPCBag186.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag186.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag186.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag186.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag186.Location = New System.Drawing.Point(1269, 315)
        Me.CtrlOPCBag186.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag186.Name = "CtrlOPCBag186"
        Me.CtrlOPCBag186.PLC_Bag_ID = 0
        Me.CtrlOPCBag186.PlcName = Nothing
        Me.CtrlOPCBag186.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag186.TabIndex = 364
        Me.CtrlOPCBag186.TagName = "EBB[9,1]"
        Me.CtrlOPCBag186.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag187
        '
        Me.CtrlOPCBag187.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag187.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag187.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag187.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag187.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag187.Category = 88
        Me.CtrlOPCBag187.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag187.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag187.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag187.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag187.Location = New System.Drawing.Point(1269, 287)
        Me.CtrlOPCBag187.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag187.Name = "CtrlOPCBag187"
        Me.CtrlOPCBag187.PLC_Bag_ID = 0
        Me.CtrlOPCBag187.PlcName = Nothing
        Me.CtrlOPCBag187.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag187.TabIndex = 363
        Me.CtrlOPCBag187.TagName = "EBB[9,2]"
        Me.CtrlOPCBag187.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag188
        '
        Me.CtrlOPCBag188.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag188.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag188.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag188.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag188.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag188.Category = 88
        Me.CtrlOPCBag188.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag188.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag188.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag188.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag188.Location = New System.Drawing.Point(1269, 259)
        Me.CtrlOPCBag188.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag188.Name = "CtrlOPCBag188"
        Me.CtrlOPCBag188.PLC_Bag_ID = 0
        Me.CtrlOPCBag188.PlcName = Nothing
        Me.CtrlOPCBag188.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag188.TabIndex = 362
        Me.CtrlOPCBag188.TagName = "EBB[9,3]"
        Me.CtrlOPCBag188.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag189
        '
        Me.CtrlOPCBag189.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag189.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag189.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag189.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag189.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag189.Category = 88
        Me.CtrlOPCBag189.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag189.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag189.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag189.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag189.Location = New System.Drawing.Point(1269, 231)
        Me.CtrlOPCBag189.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag189.Name = "CtrlOPCBag189"
        Me.CtrlOPCBag189.PLC_Bag_ID = 0
        Me.CtrlOPCBag189.PlcName = Nothing
        Me.CtrlOPCBag189.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag189.TabIndex = 361
        Me.CtrlOPCBag189.TagName = "EBB[9,4]"
        Me.CtrlOPCBag189.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag190
        '
        Me.CtrlOPCBag190.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag190.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag190.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag190.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag190.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag190.Category = 88
        Me.CtrlOPCBag190.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag190.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag190.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag190.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag190.Location = New System.Drawing.Point(1269, 203)
        Me.CtrlOPCBag190.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag190.Name = "CtrlOPCBag190"
        Me.CtrlOPCBag190.PLC_Bag_ID = 0
        Me.CtrlOPCBag190.PlcName = Nothing
        Me.CtrlOPCBag190.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag190.TabIndex = 360
        Me.CtrlOPCBag190.TagName = "EBB[9,5]"
        Me.CtrlOPCBag190.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag191
        '
        Me.CtrlOPCBag191.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag191.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag191.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag191.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag191.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag191.Category = 88
        Me.CtrlOPCBag191.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag191.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag191.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag191.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag191.Location = New System.Drawing.Point(1269, 175)
        Me.CtrlOPCBag191.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag191.Name = "CtrlOPCBag191"
        Me.CtrlOPCBag191.PLC_Bag_ID = 0
        Me.CtrlOPCBag191.PlcName = Nothing
        Me.CtrlOPCBag191.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag191.TabIndex = 359
        Me.CtrlOPCBag191.TagName = "EBB[9,6]"
        Me.CtrlOPCBag191.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag192
        '
        Me.CtrlOPCBag192.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag192.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag192.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag192.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag192.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag192.Category = 88
        Me.CtrlOPCBag192.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag192.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag192.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag192.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag192.Location = New System.Drawing.Point(1269, 147)
        Me.CtrlOPCBag192.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag192.Name = "CtrlOPCBag192"
        Me.CtrlOPCBag192.PLC_Bag_ID = 0
        Me.CtrlOPCBag192.PlcName = Nothing
        Me.CtrlOPCBag192.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag192.TabIndex = 358
        Me.CtrlOPCBag192.TagName = "EBB[9,7]"
        Me.CtrlOPCBag192.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag163
        '
        Me.CtrlOPCBag163.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag163.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag163.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag163.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag163.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag163.Category = 88
        Me.CtrlOPCBag163.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag163.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag163.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag163.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag163.Location = New System.Drawing.Point(1304, 261)
        Me.CtrlOPCBag163.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag163.Name = "CtrlOPCBag163"
        Me.CtrlOPCBag163.PLC_Bag_ID = 0
        Me.CtrlOPCBag163.PlcName = Nothing
        Me.CtrlOPCBag163.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag163.TabIndex = 357
        Me.CtrlOPCBag163.TagName = "EBB[8,8]"
        Me.CtrlOPCBag163.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag164
        '
        Me.CtrlOPCBag164.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag164.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag164.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag164.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag164.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag164.Category = 88
        Me.CtrlOPCBag164.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag164.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag164.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag164.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag164.Location = New System.Drawing.Point(1304, 233)
        Me.CtrlOPCBag164.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag164.Name = "CtrlOPCBag164"
        Me.CtrlOPCBag164.PLC_Bag_ID = 0
        Me.CtrlOPCBag164.PlcName = Nothing
        Me.CtrlOPCBag164.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag164.TabIndex = 356
        Me.CtrlOPCBag164.TagName = "EBB[8,7]"
        Me.CtrlOPCBag164.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag165
        '
        Me.CtrlOPCBag165.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag165.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag165.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag165.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag165.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag165.Category = 88
        Me.CtrlOPCBag165.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag165.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag165.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag165.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag165.Location = New System.Drawing.Point(1304, 205)
        Me.CtrlOPCBag165.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag165.Name = "CtrlOPCBag165"
        Me.CtrlOPCBag165.PLC_Bag_ID = 0
        Me.CtrlOPCBag165.PlcName = Nothing
        Me.CtrlOPCBag165.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag165.TabIndex = 355
        Me.CtrlOPCBag165.TagName = "EBB[8,6]"
        Me.CtrlOPCBag165.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag166
        '
        Me.CtrlOPCBag166.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag166.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag166.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag166.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag166.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag166.Category = 88
        Me.CtrlOPCBag166.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag166.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag166.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag166.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag166.Location = New System.Drawing.Point(1304, 177)
        Me.CtrlOPCBag166.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag166.Name = "CtrlOPCBag166"
        Me.CtrlOPCBag166.PLC_Bag_ID = 0
        Me.CtrlOPCBag166.PlcName = Nothing
        Me.CtrlOPCBag166.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag166.TabIndex = 354
        Me.CtrlOPCBag166.TagName = "EBB[8,5]"
        Me.CtrlOPCBag166.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag167
        '
        Me.CtrlOPCBag167.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag167.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag167.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag167.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag167.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag167.Category = 88
        Me.CtrlOPCBag167.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag167.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag167.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag167.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag167.Location = New System.Drawing.Point(1304, 149)
        Me.CtrlOPCBag167.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag167.Name = "CtrlOPCBag167"
        Me.CtrlOPCBag167.PLC_Bag_ID = 0
        Me.CtrlOPCBag167.PlcName = Nothing
        Me.CtrlOPCBag167.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag167.TabIndex = 353
        Me.CtrlOPCBag167.TagName = "EBB[8,4]"
        Me.CtrlOPCBag167.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag168
        '
        Me.CtrlOPCBag168.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag168.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag168.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag168.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag168.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag168.Category = 88
        Me.CtrlOPCBag168.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag168.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag168.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag168.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag168.Location = New System.Drawing.Point(1304, 121)
        Me.CtrlOPCBag168.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag168.Name = "CtrlOPCBag168"
        Me.CtrlOPCBag168.PLC_Bag_ID = 0
        Me.CtrlOPCBag168.PlcName = Nothing
        Me.CtrlOPCBag168.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag168.TabIndex = 352
        Me.CtrlOPCBag168.TagName = "EBB[8,3]"
        Me.CtrlOPCBag168.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag169
        '
        Me.CtrlOPCBag169.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag169.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag169.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag169.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag169.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag169.Category = 88
        Me.CtrlOPCBag169.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag169.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag169.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag169.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag169.Location = New System.Drawing.Point(1304, 93)
        Me.CtrlOPCBag169.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag169.Name = "CtrlOPCBag169"
        Me.CtrlOPCBag169.PLC_Bag_ID = 0
        Me.CtrlOPCBag169.PlcName = Nothing
        Me.CtrlOPCBag169.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag169.TabIndex = 351
        Me.CtrlOPCBag169.TagName = "EBB[8,2]"
        Me.CtrlOPCBag169.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag170
        '
        Me.CtrlOPCBag170.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag170.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag170.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag170.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag170.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag170.Category = 88
        Me.CtrlOPCBag170.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag170.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag170.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag170.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag170.Location = New System.Drawing.Point(1304, 65)
        Me.CtrlOPCBag170.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag170.Name = "CtrlOPCBag170"
        Me.CtrlOPCBag170.PLC_Bag_ID = 0
        Me.CtrlOPCBag170.PlcName = Nothing
        Me.CtrlOPCBag170.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag170.TabIndex = 350
        Me.CtrlOPCBag170.TagName = "EBB[8,1]"
        Me.CtrlOPCBag170.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag171
        '
        Me.CtrlOPCBag171.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag171.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag171.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag171.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag171.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag171.Category = 88
        Me.CtrlOPCBag171.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag171.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag171.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag171.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag171.Location = New System.Drawing.Point(1339, 261)
        Me.CtrlOPCBag171.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag171.Name = "CtrlOPCBag171"
        Me.CtrlOPCBag171.PLC_Bag_ID = 0
        Me.CtrlOPCBag171.PlcName = Nothing
        Me.CtrlOPCBag171.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag171.TabIndex = 349
        Me.CtrlOPCBag171.TagName = "EBB[7,8]"
        Me.CtrlOPCBag171.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag172
        '
        Me.CtrlOPCBag172.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag172.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag172.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag172.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag172.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag172.Category = 88
        Me.CtrlOPCBag172.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag172.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag172.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag172.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag172.Location = New System.Drawing.Point(1339, 233)
        Me.CtrlOPCBag172.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag172.Name = "CtrlOPCBag172"
        Me.CtrlOPCBag172.PLC_Bag_ID = 0
        Me.CtrlOPCBag172.PlcName = Nothing
        Me.CtrlOPCBag172.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag172.TabIndex = 348
        Me.CtrlOPCBag172.TagName = "EBB[7,7]"
        Me.CtrlOPCBag172.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag173
        '
        Me.CtrlOPCBag173.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag173.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag173.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag173.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag173.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag173.Category = 88
        Me.CtrlOPCBag173.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag173.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag173.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag173.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag173.Location = New System.Drawing.Point(1339, 205)
        Me.CtrlOPCBag173.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag173.Name = "CtrlOPCBag173"
        Me.CtrlOPCBag173.PLC_Bag_ID = 0
        Me.CtrlOPCBag173.PlcName = Nothing
        Me.CtrlOPCBag173.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag173.TabIndex = 347
        Me.CtrlOPCBag173.TagName = "EBB[7,6]"
        Me.CtrlOPCBag173.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag174
        '
        Me.CtrlOPCBag174.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag174.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag174.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag174.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag174.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag174.Category = 88
        Me.CtrlOPCBag174.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag174.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag174.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag174.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag174.Location = New System.Drawing.Point(1339, 177)
        Me.CtrlOPCBag174.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag174.Name = "CtrlOPCBag174"
        Me.CtrlOPCBag174.PLC_Bag_ID = 0
        Me.CtrlOPCBag174.PlcName = Nothing
        Me.CtrlOPCBag174.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag174.TabIndex = 346
        Me.CtrlOPCBag174.TagName = "EBB[7,5]"
        Me.CtrlOPCBag174.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag175
        '
        Me.CtrlOPCBag175.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag175.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag175.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag175.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag175.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag175.Category = 88
        Me.CtrlOPCBag175.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag175.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag175.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag175.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag175.Location = New System.Drawing.Point(1339, 149)
        Me.CtrlOPCBag175.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag175.Name = "CtrlOPCBag175"
        Me.CtrlOPCBag175.PLC_Bag_ID = 0
        Me.CtrlOPCBag175.PlcName = Nothing
        Me.CtrlOPCBag175.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag175.TabIndex = 345
        Me.CtrlOPCBag175.TagName = "EBB[7,4]"
        Me.CtrlOPCBag175.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag176
        '
        Me.CtrlOPCBag176.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag176.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag176.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag176.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag176.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag176.Category = 88
        Me.CtrlOPCBag176.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag176.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag176.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag176.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag176.Location = New System.Drawing.Point(1339, 121)
        Me.CtrlOPCBag176.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag176.Name = "CtrlOPCBag176"
        Me.CtrlOPCBag176.PLC_Bag_ID = 0
        Me.CtrlOPCBag176.PlcName = Nothing
        Me.CtrlOPCBag176.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag176.TabIndex = 344
        Me.CtrlOPCBag176.TagName = "EBB[7,3]"
        Me.CtrlOPCBag176.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag177
        '
        Me.CtrlOPCBag177.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag177.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag177.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag177.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag177.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag177.Category = 88
        Me.CtrlOPCBag177.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag177.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag177.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag177.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag177.Location = New System.Drawing.Point(1339, 93)
        Me.CtrlOPCBag177.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag177.Name = "CtrlOPCBag177"
        Me.CtrlOPCBag177.PLC_Bag_ID = 0
        Me.CtrlOPCBag177.PlcName = Nothing
        Me.CtrlOPCBag177.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag177.TabIndex = 343
        Me.CtrlOPCBag177.TagName = "EBB[7,2]"
        Me.CtrlOPCBag177.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag178
        '
        Me.CtrlOPCBag178.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag178.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag178.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag178.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag178.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag178.Category = 88
        Me.CtrlOPCBag178.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag178.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag178.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag178.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag178.Location = New System.Drawing.Point(1339, 65)
        Me.CtrlOPCBag178.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag178.Name = "CtrlOPCBag178"
        Me.CtrlOPCBag178.PLC_Bag_ID = 0
        Me.CtrlOPCBag178.PlcName = Nothing
        Me.CtrlOPCBag178.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag178.TabIndex = 342
        Me.CtrlOPCBag178.TagName = "EBB[7,1]"
        Me.CtrlOPCBag178.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip19
        '
        Me.CtrlOPCShortTrip19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip19.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip19.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip19.Location = New System.Drawing.Point(1311, 317)
        Me.CtrlOPCShortTrip19.Name = "CtrlOPCShortTrip19"
        Me.CtrlOPCShortTrip19.PlcName = Nothing
        Me.CtrlOPCShortTrip19.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip19.TabIndex = 341
        Me.CtrlOPCShortTrip19.TagName = "Seq_Trip[121]"
        '
        'CtrlOPCShortTrip20
        '
        Me.CtrlOPCShortTrip20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip20.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip20.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip20.Location = New System.Drawing.Point(1346, 317)
        Me.CtrlOPCShortTrip20.Name = "CtrlOPCShortTrip20"
        Me.CtrlOPCShortTrip20.PlcName = Nothing
        Me.CtrlOPCShortTrip20.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip20.TabIndex = 340
        Me.CtrlOPCShortTrip20.TagName = "Seq_Trip[120]"
        '
        'CtrlOPCBag137
        '
        Me.CtrlOPCBag137.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag137.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag137.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag137.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag137.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag137.Category = 88
        Me.CtrlOPCBag137.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag137.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag137.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag137.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag137.Location = New System.Drawing.Point(1304, 600)
        Me.CtrlOPCBag137.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag137.Name = "CtrlOPCBag137"
        Me.CtrlOPCBag137.PLC_Bag_ID = 0
        Me.CtrlOPCBag137.PlcName = Nothing
        Me.CtrlOPCBag137.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag137.TabIndex = 338
        Me.CtrlOPCBag137.TagName = "EBB[8,18]"
        Me.CtrlOPCBag137.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag155
        '
        Me.CtrlOPCBag155.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag155.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag155.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag155.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag155.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag155.Category = 88
        Me.CtrlOPCBag155.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag155.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag155.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag155.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag155.Location = New System.Drawing.Point(1304, 572)
        Me.CtrlOPCBag155.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag155.Name = "CtrlOPCBag155"
        Me.CtrlOPCBag155.PLC_Bag_ID = 0
        Me.CtrlOPCBag155.PlcName = Nothing
        Me.CtrlOPCBag155.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag155.TabIndex = 337
        Me.CtrlOPCBag155.TagName = "EBB[8,17]"
        Me.CtrlOPCBag155.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag156
        '
        Me.CtrlOPCBag156.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag156.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag156.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag156.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag156.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag156.Category = 88
        Me.CtrlOPCBag156.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag156.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag156.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag156.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag156.Location = New System.Drawing.Point(1304, 544)
        Me.CtrlOPCBag156.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag156.Name = "CtrlOPCBag156"
        Me.CtrlOPCBag156.PLC_Bag_ID = 0
        Me.CtrlOPCBag156.PlcName = Nothing
        Me.CtrlOPCBag156.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag156.TabIndex = 336
        Me.CtrlOPCBag156.TagName = "EBB[8,16]"
        Me.CtrlOPCBag156.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag157
        '
        Me.CtrlOPCBag157.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag157.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag157.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag157.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag157.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag157.Category = 88
        Me.CtrlOPCBag157.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag157.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag157.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag157.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag157.Location = New System.Drawing.Point(1304, 516)
        Me.CtrlOPCBag157.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag157.Name = "CtrlOPCBag157"
        Me.CtrlOPCBag157.PLC_Bag_ID = 0
        Me.CtrlOPCBag157.PlcName = Nothing
        Me.CtrlOPCBag157.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag157.TabIndex = 335
        Me.CtrlOPCBag157.TagName = "EBB[8,15]"
        Me.CtrlOPCBag157.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag158
        '
        Me.CtrlOPCBag158.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag158.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag158.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag158.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag158.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag158.Category = 88
        Me.CtrlOPCBag158.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag158.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag158.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag158.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag158.Location = New System.Drawing.Point(1304, 488)
        Me.CtrlOPCBag158.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag158.Name = "CtrlOPCBag158"
        Me.CtrlOPCBag158.PLC_Bag_ID = 0
        Me.CtrlOPCBag158.PlcName = Nothing
        Me.CtrlOPCBag158.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag158.TabIndex = 334
        Me.CtrlOPCBag158.TagName = "EBB[8,14]"
        Me.CtrlOPCBag158.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag159
        '
        Me.CtrlOPCBag159.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag159.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag159.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag159.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag159.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag159.Category = 88
        Me.CtrlOPCBag159.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag159.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag159.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag159.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag159.Location = New System.Drawing.Point(1304, 460)
        Me.CtrlOPCBag159.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag159.Name = "CtrlOPCBag159"
        Me.CtrlOPCBag159.PLC_Bag_ID = 0
        Me.CtrlOPCBag159.PlcName = Nothing
        Me.CtrlOPCBag159.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag159.TabIndex = 333
        Me.CtrlOPCBag159.TagName = "EBB[8,13]"
        Me.CtrlOPCBag159.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag160
        '
        Me.CtrlOPCBag160.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag160.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag160.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag160.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag160.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag160.Category = 88
        Me.CtrlOPCBag160.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag160.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag160.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag160.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag160.Location = New System.Drawing.Point(1304, 432)
        Me.CtrlOPCBag160.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag160.Name = "CtrlOPCBag160"
        Me.CtrlOPCBag160.PLC_Bag_ID = 0
        Me.CtrlOPCBag160.PlcName = Nothing
        Me.CtrlOPCBag160.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag160.TabIndex = 332
        Me.CtrlOPCBag160.TagName = "EBB[8,12]"
        Me.CtrlOPCBag160.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag161
        '
        Me.CtrlOPCBag161.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag161.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag161.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag161.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag161.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag161.Category = 88
        Me.CtrlOPCBag161.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag161.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag161.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag161.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag161.Location = New System.Drawing.Point(1304, 404)
        Me.CtrlOPCBag161.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag161.Name = "CtrlOPCBag161"
        Me.CtrlOPCBag161.PLC_Bag_ID = 0
        Me.CtrlOPCBag161.PlcName = Nothing
        Me.CtrlOPCBag161.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag161.TabIndex = 331
        Me.CtrlOPCBag161.TagName = "EBB[8,11]"
        Me.CtrlOPCBag161.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag162
        '
        Me.CtrlOPCBag162.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag162.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag162.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag162.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag162.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag162.Category = 88
        Me.CtrlOPCBag162.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag162.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag162.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag162.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag162.Location = New System.Drawing.Point(1304, 376)
        Me.CtrlOPCBag162.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag162.Name = "CtrlOPCBag162"
        Me.CtrlOPCBag162.PLC_Bag_ID = 0
        Me.CtrlOPCBag162.PlcName = Nothing
        Me.CtrlOPCBag162.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag162.TabIndex = 330
        Me.CtrlOPCBag162.TagName = "EBB[8,10]"
        Me.CtrlOPCBag162.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBagAddButton121
        '
        Me.CtrlOPCBagAddButton121.AllowDrop = True
        Me.CtrlOPCBagAddButton121.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton121.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton121.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton121.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton121.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton121.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton121.Location = New System.Drawing.Point(1311, 656)
        Me.CtrlOPCBagAddButton121.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton121.Name = "CtrlOPCBagAddButton121"
        Me.CtrlOPCBagAddButton121.PlcName = Nothing
        Me.CtrlOPCBagAddButton121.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton121.TabIndex = 329
        Me.CtrlOPCBagAddButton121.TagName = "EBB[6,3]"
        Me.CtrlOPCBagAddButton121.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip18
        '
        Me.CtrlOPCShortTrip18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip18.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip18.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip18.Location = New System.Drawing.Point(1311, 671)
        Me.CtrlOPCShortTrip18.Name = "CtrlOPCShortTrip18"
        Me.CtrlOPCShortTrip18.PlcName = Nothing
        Me.CtrlOPCShortTrip18.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip18.TabIndex = 328
        Me.CtrlOPCShortTrip18.TagName = "Seq_Trip[119]"
        '
        'CtrlOPCBagAddButton120
        '
        Me.CtrlOPCBagAddButton120.AllowDrop = True
        Me.CtrlOPCBagAddButton120.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton120.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton120.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton120.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton120.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton120.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton120.Location = New System.Drawing.Point(1346, 657)
        Me.CtrlOPCBagAddButton120.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton120.Name = "CtrlOPCBagAddButton120"
        Me.CtrlOPCBagAddButton120.PlcName = Nothing
        Me.CtrlOPCBagAddButton120.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton120.TabIndex = 327
        Me.CtrlOPCBagAddButton120.TagName = "EBB[6,3]"
        Me.CtrlOPCBagAddButton120.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip17
        '
        Me.CtrlOPCShortTrip17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip17.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip17.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip17.Location = New System.Drawing.Point(1346, 672)
        Me.CtrlOPCShortTrip17.Name = "CtrlOPCShortTrip17"
        Me.CtrlOPCShortTrip17.PlcName = Nothing
        Me.CtrlOPCShortTrip17.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip17.TabIndex = 326
        Me.CtrlOPCShortTrip17.TagName = "Seq_Trip[118]"
        '
        'CtrlOPCBag133
        '
        Me.CtrlOPCBag133.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag133.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag133.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag133.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag133.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag133.Category = 88
        Me.CtrlOPCBag133.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag133.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag133.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag133.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag133.Location = New System.Drawing.Point(1339, 629)
        Me.CtrlOPCBag133.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag133.Name = "CtrlOPCBag133"
        Me.CtrlOPCBag133.PLC_Bag_ID = 0
        Me.CtrlOPCBag133.PlcName = Nothing
        Me.CtrlOPCBag133.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag133.TabIndex = 322
        Me.CtrlOPCBag133.TagName = "EBB[7,19]"
        Me.CtrlOPCBag133.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag134
        '
        Me.CtrlOPCBag134.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag134.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag134.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag134.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag134.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag134.Category = 88
        Me.CtrlOPCBag134.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag134.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag134.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag134.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag134.Location = New System.Drawing.Point(1339, 601)
        Me.CtrlOPCBag134.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag134.Name = "CtrlOPCBag134"
        Me.CtrlOPCBag134.PLC_Bag_ID = 0
        Me.CtrlOPCBag134.PlcName = Nothing
        Me.CtrlOPCBag134.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag134.TabIndex = 321
        Me.CtrlOPCBag134.TagName = "EBB[7,18]"
        Me.CtrlOPCBag134.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag135
        '
        Me.CtrlOPCBag135.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag135.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag135.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag135.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag135.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag135.Category = 88
        Me.CtrlOPCBag135.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag135.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag135.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag135.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag135.Location = New System.Drawing.Point(1339, 573)
        Me.CtrlOPCBag135.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag135.Name = "CtrlOPCBag135"
        Me.CtrlOPCBag135.PLC_Bag_ID = 0
        Me.CtrlOPCBag135.PlcName = Nothing
        Me.CtrlOPCBag135.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag135.TabIndex = 320
        Me.CtrlOPCBag135.TagName = "EBB[7,17]"
        Me.CtrlOPCBag135.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag115
        '
        Me.CtrlOPCBag115.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag115.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag115.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag115.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag115.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag115.Category = 88
        Me.CtrlOPCBag115.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag115.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag115.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag115.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag115.Location = New System.Drawing.Point(1339, 545)
        Me.CtrlOPCBag115.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag115.Name = "CtrlOPCBag115"
        Me.CtrlOPCBag115.PLC_Bag_ID = 0
        Me.CtrlOPCBag115.PlcName = Nothing
        Me.CtrlOPCBag115.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag115.TabIndex = 319
        Me.CtrlOPCBag115.TagName = "EBB[7,16]"
        Me.CtrlOPCBag115.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag131
        '
        Me.CtrlOPCBag131.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag131.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag131.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag131.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag131.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag131.Category = 88
        Me.CtrlOPCBag131.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag131.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag131.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag131.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag131.Location = New System.Drawing.Point(1339, 517)
        Me.CtrlOPCBag131.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag131.Name = "CtrlOPCBag131"
        Me.CtrlOPCBag131.PLC_Bag_ID = 0
        Me.CtrlOPCBag131.PlcName = Nothing
        Me.CtrlOPCBag131.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag131.TabIndex = 318
        Me.CtrlOPCBag131.TagName = "EBB[7,15]"
        Me.CtrlOPCBag131.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag132
        '
        Me.CtrlOPCBag132.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag132.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag132.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag132.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag132.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag132.Category = 88
        Me.CtrlOPCBag132.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag132.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag132.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag132.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag132.Location = New System.Drawing.Point(1339, 489)
        Me.CtrlOPCBag132.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag132.Name = "CtrlOPCBag132"
        Me.CtrlOPCBag132.PLC_Bag_ID = 0
        Me.CtrlOPCBag132.PlcName = Nothing
        Me.CtrlOPCBag132.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag132.TabIndex = 317
        Me.CtrlOPCBag132.TagName = "EBB[7,14]"
        Me.CtrlOPCBag132.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag102
        '
        Me.CtrlOPCBag102.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag102.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag102.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag102.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag102.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag102.Category = 88
        Me.CtrlOPCBag102.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag102.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag102.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag102.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag102.Location = New System.Drawing.Point(1339, 461)
        Me.CtrlOPCBag102.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag102.Name = "CtrlOPCBag102"
        Me.CtrlOPCBag102.PLC_Bag_ID = 0
        Me.CtrlOPCBag102.PlcName = Nothing
        Me.CtrlOPCBag102.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag102.TabIndex = 316
        Me.CtrlOPCBag102.TagName = "EBB[7,13]"
        Me.CtrlOPCBag102.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag111
        '
        Me.CtrlOPCBag111.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag111.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag111.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag111.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag111.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag111.Category = 88
        Me.CtrlOPCBag111.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag111.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag111.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag111.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag111.Location = New System.Drawing.Point(1339, 433)
        Me.CtrlOPCBag111.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag111.Name = "CtrlOPCBag111"
        Me.CtrlOPCBag111.PLC_Bag_ID = 0
        Me.CtrlOPCBag111.PlcName = Nothing
        Me.CtrlOPCBag111.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag111.TabIndex = 315
        Me.CtrlOPCBag111.TagName = "EBB[7,12]"
        Me.CtrlOPCBag111.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag112
        '
        Me.CtrlOPCBag112.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag112.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag112.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag112.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag112.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag112.Category = 88
        Me.CtrlOPCBag112.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag112.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag112.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag112.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag112.Location = New System.Drawing.Point(1339, 405)
        Me.CtrlOPCBag112.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag112.Name = "CtrlOPCBag112"
        Me.CtrlOPCBag112.PLC_Bag_ID = 0
        Me.CtrlOPCBag112.PlcName = Nothing
        Me.CtrlOPCBag112.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag112.TabIndex = 314
        Me.CtrlOPCBag112.TagName = "EBB[7,11]"
        Me.CtrlOPCBag112.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag101
        '
        Me.CtrlOPCBag101.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag101.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag101.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag101.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag101.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag101.Category = 88
        Me.CtrlOPCBag101.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag101.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag101.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag101.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag101.Location = New System.Drawing.Point(1339, 854)
        Me.CtrlOPCBag101.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag101.Name = "CtrlOPCBag101"
        Me.CtrlOPCBag101.PLC_Bag_ID = 0
        Me.CtrlOPCBag101.PlcName = Nothing
        Me.CtrlOPCBag101.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag101.TabIndex = 313
        Me.CtrlOPCBag101.TagName = "EBB[6,3]"
        Me.CtrlOPCBag101.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag100
        '
        Me.CtrlOPCBag100.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag100.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag100.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag100.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag100.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag100.Category = 88
        Me.CtrlOPCBag100.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag100.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag100.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag100.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag100.Location = New System.Drawing.Point(1339, 826)
        Me.CtrlOPCBag100.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag100.Name = "CtrlOPCBag100"
        Me.CtrlOPCBag100.PLC_Bag_ID = 0
        Me.CtrlOPCBag100.PlcName = Nothing
        Me.CtrlOPCBag100.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag100.TabIndex = 312
        Me.CtrlOPCBag100.TagName = "EBB[6,2]"
        Me.CtrlOPCBag100.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBag99
        '
        Me.CtrlOPCBag99.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag99.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag99.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag99.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBag99.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag99.Category = 88
        Me.CtrlOPCBag99.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag99.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag99.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag99.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag99.Location = New System.Drawing.Point(1339, 798)
        Me.CtrlOPCBag99.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag99.Name = "CtrlOPCBag99"
        Me.CtrlOPCBag99.PLC_Bag_ID = 0
        Me.CtrlOPCBag99.PlcName = Nothing
        Me.CtrlOPCBag99.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag99.TabIndex = 311
        Me.CtrlOPCBag99.TagName = "EBB[6,1]"
        Me.CtrlOPCBag99.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCBagAddButton119
        '
        Me.CtrlOPCBagAddButton119.AllowDrop = True
        Me.CtrlOPCBagAddButton119.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton119.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton119.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_WHOLE
        Me.CtrlOPCBagAddButton119.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton119.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton119.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton119.Location = New System.Drawing.Point(1345, 882)
        Me.CtrlOPCBagAddButton119.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton119.Name = "CtrlOPCBagAddButton119"
        Me.CtrlOPCBagAddButton119.PlcName = Nothing
        Me.CtrlOPCBagAddButton119.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton119.TabIndex = 310
        Me.CtrlOPCBagAddButton119.TagName = "EBB[6,3]"
        Me.CtrlOPCBagAddButton119.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_EMPTY_BAG_RETURN
        '
        'CtrlOPCShortTrip16
        '
        Me.CtrlOPCShortTrip16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip16.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip16.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip16.Location = New System.Drawing.Point(1345, 897)
        Me.CtrlOPCShortTrip16.Name = "CtrlOPCShortTrip16"
        Me.CtrlOPCShortTrip16.PlcName = Nothing
        Me.CtrlOPCShortTrip16.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip16.TabIndex = 309
        Me.CtrlOPCShortTrip16.TagName = "Seq_Trip[83]"
        '
        'CtrlLINTAlarmIcon15
        '
        Me.CtrlLINTAlarmIcon15.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon15.Location = New System.Drawing.Point(1065, 5)
        Me.CtrlLINTAlarmIcon15.Name = "CtrlLINTAlarmIcon15"
        Me.CtrlLINTAlarmIcon15.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon15.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon15.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon15.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon15.TabIndex = 308
        '
        'CtrlLINTAlarmIcon14
        '
        Me.CtrlLINTAlarmIcon14.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon14.Location = New System.Drawing.Point(1230, 518)
        Me.CtrlLINTAlarmIcon14.Name = "CtrlLINTAlarmIcon14"
        Me.CtrlLINTAlarmIcon14.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon14.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon14.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon14.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon14.TabIndex = 307
        '
        'CtrlLINTAlarmIcon12
        '
        Me.CtrlLINTAlarmIcon12.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon12.Location = New System.Drawing.Point(998, 737)
        Me.CtrlLINTAlarmIcon12.Name = "CtrlLINTAlarmIcon12"
        Me.CtrlLINTAlarmIcon12.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon12.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon12.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon12.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon12.TabIndex = 305
        '
        'CtrlLINTAlarmIcon11
        '
        Me.CtrlLINTAlarmIcon11.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon11.Location = New System.Drawing.Point(998, 537)
        Me.CtrlLINTAlarmIcon11.Name = "CtrlLINTAlarmIcon11"
        Me.CtrlLINTAlarmIcon11.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon11.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon11.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon11.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon11.TabIndex = 304
        '
        'CtrlLINTAlarmIcon9
        '
        Me.CtrlLINTAlarmIcon9.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon9.Location = New System.Drawing.Point(1036, 82)
        Me.CtrlLINTAlarmIcon9.Name = "CtrlLINTAlarmIcon9"
        Me.CtrlLINTAlarmIcon9.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon9.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon9.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon9.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon9.TabIndex = 302
        '
        'CtrlLINTAlarmIcon4
        '
        Me.CtrlLINTAlarmIcon4.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon4.Location = New System.Drawing.Point(779, 679)
        Me.CtrlLINTAlarmIcon4.Name = "CtrlLINTAlarmIcon4"
        Me.CtrlLINTAlarmIcon4.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon4.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon4.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon4.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon4.TabIndex = 297
        '
        'CtrlLINTAlarmIcon2
        '
        Me.CtrlLINTAlarmIcon2.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon2.Location = New System.Drawing.Point(779, 572)
        Me.CtrlLINTAlarmIcon2.Name = "CtrlLINTAlarmIcon2"
        Me.CtrlLINTAlarmIcon2.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon2.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon2.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon2.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon2.TabIndex = 296
        '
        'CtrlLINTAlarmIcon1
        '
        Me.CtrlLINTAlarmIcon1.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon1.Location = New System.Drawing.Point(779, 137)
        Me.CtrlLINTAlarmIcon1.Name = "CtrlLINTAlarmIcon1"
        Me.CtrlLINTAlarmIcon1.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon1.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon1.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon1.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon1.TabIndex = 293
        '
        'CtrlOpcRailSequenceStep19
        '
        Me.CtrlOpcRailSequenceStep19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep19.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep19.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep19.Location = New System.Drawing.Point(1228, 431)
        Me.CtrlOpcRailSequenceStep19.Name = "CtrlOpcRailSequenceStep19"
        Me.CtrlOpcRailSequenceStep19.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep19.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep19.SequenceID = 1012
        Me.CtrlOpcRailSequenceStep19.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep19.TabIndex = 291
        Me.CtrlOpcRailSequenceStep19.TagName = "gSeq[13]"
        Me.CtrlOpcRailSequenceStep19.Text = "PLA5"
        '
        'CtrlOpcRailSequenceStep18
        '
        Me.CtrlOpcRailSequenceStep18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep18.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep18.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep18.Location = New System.Drawing.Point(1032, 120)
        Me.CtrlOpcRailSequenceStep18.Name = "CtrlOpcRailSequenceStep18"
        Me.CtrlOpcRailSequenceStep18.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep18.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep18.SequenceID = 1073
        Me.CtrlOpcRailSequenceStep18.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep18.TabIndex = 290
        Me.CtrlOpcRailSequenceStep18.TagName = "SeqVC[5]"
        Me.CtrlOpcRailSequenceStep18.Text = "VC5"
        '
        'CtrlOpcRailSequenceStep16
        '
        Me.CtrlOpcRailSequenceStep16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep16.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep16.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep16.Location = New System.Drawing.Point(994, 712)
        Me.CtrlOpcRailSequenceStep16.Name = "CtrlOpcRailSequenceStep16"
        Me.CtrlOpcRailSequenceStep16.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep16.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep16.SequenceID = 1076
        Me.CtrlOpcRailSequenceStep16.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep16.TabIndex = 289
        Me.CtrlOpcRailSequenceStep16.TagName = "SeqVC[8]"
        Me.CtrlOpcRailSequenceStep16.Text = "VC8"
        '
        'CtrlOpcRailSequenceStep15
        '
        Me.CtrlOpcRailSequenceStep15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep15.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep15.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep15.Location = New System.Drawing.Point(994, 575)
        Me.CtrlOpcRailSequenceStep15.Name = "CtrlOpcRailSequenceStep15"
        Me.CtrlOpcRailSequenceStep15.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep15.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep15.SequenceID = 1075
        Me.CtrlOpcRailSequenceStep15.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep15.TabIndex = 288
        Me.CtrlOpcRailSequenceStep15.TagName = "SeqVC[7]"
        Me.CtrlOpcRailSequenceStep15.Text = "VC7"
        '
        'CtrlOPCShortTrip14
        '
        Me.CtrlOPCShortTrip14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip14.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip14.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip14.Location = New System.Drawing.Point(1163, 174)
        Me.CtrlOPCShortTrip14.Name = "CtrlOPCShortTrip14"
        Me.CtrlOPCShortTrip14.PlcName = Nothing
        Me.CtrlOPCShortTrip14.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip14.TabIndex = 287
        Me.CtrlOPCShortTrip14.TagName = "Seq_Trip[88]"
        '
        'CtrlOPCShortTrip13
        '
        Me.CtrlOPCShortTrip13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip13.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip13.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip13.Location = New System.Drawing.Point(1051, 612)
        Me.CtrlOPCShortTrip13.Name = "CtrlOPCShortTrip13"
        Me.CtrlOPCShortTrip13.PlcName = Nothing
        Me.CtrlOPCShortTrip13.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip13.TabIndex = 285
        Me.CtrlOPCShortTrip13.TagName = "Seq_Trip[86]"
        '
        'CtrlOPCShortTrip12
        '
        Me.CtrlOPCShortTrip12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip12.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip12.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip12.Location = New System.Drawing.Point(1051, 666)
        Me.CtrlOPCShortTrip12.Name = "CtrlOPCShortTrip12"
        Me.CtrlOPCShortTrip12.PlcName = Nothing
        Me.CtrlOPCShortTrip12.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip12.TabIndex = 284
        Me.CtrlOPCShortTrip12.TagName = "Seq_Trip[85]"
        '
        'CtrlOPCShortTrip10
        '
        Me.CtrlOPCShortTrip10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip10.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip10.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip10.Location = New System.Drawing.Point(979, 668)
        Me.CtrlOPCShortTrip10.Name = "CtrlOPCShortTrip10"
        Me.CtrlOPCShortTrip10.PlcName = Nothing
        Me.CtrlOPCShortTrip10.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip10.TabIndex = 282
        Me.CtrlOPCShortTrip10.TagName = "Seq_Trip[92]"
        '
        'CtrlOPCShortTrip11
        '
        Me.CtrlOPCShortTrip11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip11.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip11.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip11.Location = New System.Drawing.Point(978, 615)
        Me.CtrlOPCShortTrip11.Name = "CtrlOPCShortTrip11"
        Me.CtrlOPCShortTrip11.PlcName = Nothing
        Me.CtrlOPCShortTrip11.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip11.TabIndex = 281
        Me.CtrlOPCShortTrip11.TagName = "Seq_Trip[93]"
        '
        'CtrlOPCShortTrip8
        '
        Me.CtrlOPCShortTrip8.BackColor = System.Drawing.Color.White
        Me.CtrlOPCShortTrip8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip8.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip8.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip8.Location = New System.Drawing.Point(1010, 175)
        Me.CtrlOPCShortTrip8.Name = "CtrlOPCShortTrip8"
        Me.CtrlOPCShortTrip8.PlcName = Nothing
        Me.CtrlOPCShortTrip8.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip8.TabIndex = 279
        Me.CtrlOPCShortTrip8.TagName = "Seq_Trip[95]"
        '
        'CtrlOPCBagAddButton114
        '
        Me.CtrlOPCBagAddButton114.AllowDrop = True
        Me.CtrlOPCBagAddButton114.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton114.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton114.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton114.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton114.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton114.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton114.Location = New System.Drawing.Point(350, 807)
        Me.CtrlOPCBagAddButton114.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton114.Name = "CtrlOPCBagAddButton114"
        Me.CtrlOPCBagAddButton114.PlcName = Nothing
        Me.CtrlOPCBagAddButton114.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton114.TabIndex = 274
        Me.CtrlOPCBagAddButton114.TagName = "PLA_Track[9,0]"
        Me.CtrlOPCBagAddButton114.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBagAddButton106
        '
        Me.CtrlOPCBagAddButton106.AllowDrop = True
        Me.CtrlOPCBagAddButton106.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton106.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton106.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton106.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton106.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton106.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton106.Location = New System.Drawing.Point(284, 481)
        Me.CtrlOPCBagAddButton106.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton106.Name = "CtrlOPCBagAddButton106"
        Me.CtrlOPCBagAddButton106.PlcName = Nothing
        Me.CtrlOPCBagAddButton106.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton106.TabIndex = 266
        Me.CtrlOPCBagAddButton106.TagName = "PLA_Track[8,0]"
        Me.CtrlOPCBagAddButton106.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBagAddButton105
        '
        Me.CtrlOPCBagAddButton105.AllowDrop = True
        Me.CtrlOPCBagAddButton105.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton105.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton105.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton105.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton105.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton105.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton105.Location = New System.Drawing.Point(284, 526)
        Me.CtrlOPCBagAddButton105.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton105.Name = "CtrlOPCBagAddButton105"
        Me.CtrlOPCBagAddButton105.PlcName = Nothing
        Me.CtrlOPCBagAddButton105.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton105.TabIndex = 265
        Me.CtrlOPCBagAddButton105.TagName = "PLA_Track[8,1]"
        Me.CtrlOPCBagAddButton105.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCShortTrip2
        '
        Me.CtrlOPCShortTrip2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip2.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip2.Location = New System.Drawing.Point(67, 9)
        Me.CtrlOPCShortTrip2.Name = "CtrlOPCShortTrip2"
        Me.CtrlOPCShortTrip2.PlcName = Nothing
        Me.CtrlOPCShortTrip2.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip2.TabIndex = 256
        Me.CtrlOPCShortTrip2.TagName = "Seq_Trip[41]"
        '
        'CtrlOPCBagAddButton97
        '
        Me.CtrlOPCBagAddButton97.AllowDrop = True
        Me.CtrlOPCBagAddButton97.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton97.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton97.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton97.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton97.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton97.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton97.Location = New System.Drawing.Point(1035, 666)
        Me.CtrlOPCBagAddButton97.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton97.Name = "CtrlOPCBagAddButton97"
        Me.CtrlOPCBagAddButton97.PlcName = Nothing
        Me.CtrlOPCBagAddButton97.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton97.TabIndex = 252
        Me.CtrlOPCBagAddButton97.TagName = "VC_Track[8,1]"
        Me.CtrlOPCBagAddButton97.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton98
        '
        Me.CtrlOPCBagAddButton98.AllowDrop = True
        Me.CtrlOPCBagAddButton98.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton98.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton98.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton98.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton98.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton98.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton98.Location = New System.Drawing.Point(1035, 612)
        Me.CtrlOPCBagAddButton98.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton98.Name = "CtrlOPCBagAddButton98"
        Me.CtrlOPCBagAddButton98.PlcName = Nothing
        Me.CtrlOPCBagAddButton98.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton98.TabIndex = 251
        Me.CtrlOPCBagAddButton98.TagName = "VC_Track[7,1]"
        Me.CtrlOPCBagAddButton98.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton100
        '
        Me.CtrlOPCBagAddButton100.AllowDrop = True
        Me.CtrlOPCBagAddButton100.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton100.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton100.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton100.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton100.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton100.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton100.Location = New System.Drawing.Point(1071, 174)
        Me.CtrlOPCBagAddButton100.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton100.Name = "CtrlOPCBagAddButton100"
        Me.CtrlOPCBagAddButton100.PlcName = Nothing
        Me.CtrlOPCBagAddButton100.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton100.TabIndex = 249
        Me.CtrlOPCBagAddButton100.TagName = "VC_Track[5,1]"
        Me.CtrlOPCBagAddButton100.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton95
        '
        Me.CtrlOPCBagAddButton95.AllowDrop = True
        Me.CtrlOPCBagAddButton95.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton95.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton95.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton95.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton95.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton95.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton95.Location = New System.Drawing.Point(962, 668)
        Me.CtrlOPCBagAddButton95.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton95.Name = "CtrlOPCBagAddButton95"
        Me.CtrlOPCBagAddButton95.PlcName = Nothing
        Me.CtrlOPCBagAddButton95.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton95.TabIndex = 248
        Me.CtrlOPCBagAddButton95.TagName = "VC_Track[8,2]"
        Me.CtrlOPCBagAddButton95.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton96
        '
        Me.CtrlOPCBagAddButton96.AllowDrop = True
        Me.CtrlOPCBagAddButton96.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton96.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton96.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton96.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton96.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton96.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton96.Location = New System.Drawing.Point(961, 615)
        Me.CtrlOPCBagAddButton96.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton96.Name = "CtrlOPCBagAddButton96"
        Me.CtrlOPCBagAddButton96.PlcName = Nothing
        Me.CtrlOPCBagAddButton96.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton96.TabIndex = 247
        Me.CtrlOPCBagAddButton96.TagName = "VC_Track[7,2]"
        Me.CtrlOPCBagAddButton96.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton93
        '
        Me.CtrlOPCBagAddButton93.AllowDrop = True
        Me.CtrlOPCBagAddButton93.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton93.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton93.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton93.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton93.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton93.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton93.Location = New System.Drawing.Point(995, 175)
        Me.CtrlOPCBagAddButton93.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton93.Name = "CtrlOPCBagAddButton93"
        Me.CtrlOPCBagAddButton93.PlcName = Nothing
        Me.CtrlOPCBagAddButton93.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton93.TabIndex = 245
        Me.CtrlOPCBagAddButton93.TagName = "VC_Track[5,2]"
        Me.CtrlOPCBagAddButton93.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcRailSequenceStep14
        '
        Me.CtrlOpcRailSequenceStep14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep14.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep14.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep14.Location = New System.Drawing.Point(775, 650)
        Me.CtrlOpcRailSequenceStep14.Name = "CtrlOpcRailSequenceStep14"
        Me.CtrlOpcRailSequenceStep14.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep14.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep14.SequenceID = 1034
        Me.CtrlOpcRailSequenceStep14.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep14.TabIndex = 244
        Me.CtrlOpcRailSequenceStep14.TagName = "SeqEmptyBags[3]"
        Me.CtrlOpcRailSequenceStep14.Text = "Empty"
        '
        'CtrlOpcRailSequenceStep13
        '
        Me.CtrlOpcRailSequenceStep13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep13.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep13.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep13.Location = New System.Drawing.Point(775, 614)
        Me.CtrlOpcRailSequenceStep13.Name = "CtrlOpcRailSequenceStep13"
        Me.CtrlOpcRailSequenceStep13.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep13.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep13.SequenceID = 1033
        Me.CtrlOpcRailSequenceStep13.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep13.TabIndex = 243
        Me.CtrlOpcRailSequenceStep13.TagName = "SeqEmptyBags[2]"
        Me.CtrlOpcRailSequenceStep13.Text = "Empty"
        '
        'CtrlOpcRailSequenceStep11
        '
        Me.CtrlOpcRailSequenceStep11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep11.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep11.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep11.Location = New System.Drawing.Point(775, 175)
        Me.CtrlOpcRailSequenceStep11.Name = "CtrlOpcRailSequenceStep11"
        Me.CtrlOpcRailSequenceStep11.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep11.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep11.SequenceID = 1031
        Me.CtrlOpcRailSequenceStep11.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep11.TabIndex = 241
        Me.CtrlOpcRailSequenceStep11.TagName = "SeqEmptyBags[0]"
        Me.CtrlOpcRailSequenceStep11.Text = "Empty"
        '
        'CtrlOpcRailSequenceStep10
        '
        Me.CtrlOpcRailSequenceStep10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep10.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep10.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep10.Location = New System.Drawing.Point(715, 825)
        Me.CtrlOpcRailSequenceStep10.Name = "CtrlOpcRailSequenceStep10"
        Me.CtrlOpcRailSequenceStep10.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep10.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep10.SequenceID = 1038
        Me.CtrlOpcRailSequenceStep10.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep10.TabIndex = 240
        Me.CtrlOpcRailSequenceStep10.TagName = "SeqFullBags[3]"
        Me.CtrlOpcRailSequenceStep10.Text = "Full"
        '
        'CtrlOpcRailSequenceStep9
        '
        Me.CtrlOpcRailSequenceStep9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep9.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep9.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep9.Location = New System.Drawing.Point(715, 441)
        Me.CtrlOpcRailSequenceStep9.Name = "CtrlOpcRailSequenceStep9"
        Me.CtrlOpcRailSequenceStep9.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep9.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep9.SequenceID = 1037
        Me.CtrlOpcRailSequenceStep9.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep9.TabIndex = 239
        Me.CtrlOpcRailSequenceStep9.TagName = "SeqFullBags[2]"
        Me.CtrlOpcRailSequenceStep9.Text = "Full"
        '
        'CtrlOpcRailSequenceStep8
        '
        Me.CtrlOpcRailSequenceStep8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep8.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep8.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep8.Location = New System.Drawing.Point(715, 383)
        Me.CtrlOpcRailSequenceStep8.Name = "CtrlOpcRailSequenceStep8"
        Me.CtrlOpcRailSequenceStep8.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep8.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep8.SequenceID = 1036
        Me.CtrlOpcRailSequenceStep8.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep8.TabIndex = 238
        Me.CtrlOpcRailSequenceStep8.TagName = "SeqFullBags[1]"
        Me.CtrlOpcRailSequenceStep8.Text = "Full"
        '
        'CtrlOpcRailSequenceStep7
        '
        Me.CtrlOpcRailSequenceStep7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep7.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep7.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep7.Location = New System.Drawing.Point(715, 5)
        Me.CtrlOpcRailSequenceStep7.Name = "CtrlOpcRailSequenceStep7"
        Me.CtrlOpcRailSequenceStep7.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep7.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep7.SequenceID = 1035
        Me.CtrlOpcRailSequenceStep7.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep7.TabIndex = 237
        Me.CtrlOpcRailSequenceStep7.TagName = "SeqFullBags[0]"
        Me.CtrlOpcRailSequenceStep7.Text = "Full"
        '
        'CtrlOpcRailSequenceStep4
        '
        Me.CtrlOpcRailSequenceStep4.BackColor = System.Drawing.Color.White
        Me.CtrlOpcRailSequenceStep4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep4.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep4.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep4.Location = New System.Drawing.Point(270, 847)
        Me.CtrlOpcRailSequenceStep4.Name = "CtrlOpcRailSequenceStep4"
        Me.CtrlOpcRailSequenceStep4.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep4.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep4.SequenceID = 1220
        Me.CtrlOpcRailSequenceStep4.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcRailSequenceStep4.TabIndex = 234
        Me.CtrlOpcRailSequenceStep4.TagName = "SeqPLA[9]"
        Me.CtrlOpcRailSequenceStep4.Text = "PLA 9"
        '
        'CtrlOpcRailSequenceStep3
        '
        Me.CtrlOpcRailSequenceStep3.BackColor = System.Drawing.Color.White
        Me.CtrlOpcRailSequenceStep3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep3.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep3.Location = New System.Drawing.Point(277, 576)
        Me.CtrlOpcRailSequenceStep3.Name = "CtrlOpcRailSequenceStep3"
        Me.CtrlOpcRailSequenceStep3.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep3.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep3.SequenceID = 1219
        Me.CtrlOpcRailSequenceStep3.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcRailSequenceStep3.TabIndex = 233
        Me.CtrlOpcRailSequenceStep3.TagName = "SeqPLA[8]"
        Me.CtrlOpcRailSequenceStep3.Text = "PLA 8"
        '
        'CtrlOpcRailSequenceStep2
        '
        Me.CtrlOpcRailSequenceStep2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep2.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep2.Location = New System.Drawing.Point(277, 167)
        Me.CtrlOpcRailSequenceStep2.Name = "CtrlOpcRailSequenceStep2"
        Me.CtrlOpcRailSequenceStep2.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep2.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep2.SequenceID = 1217
        Me.CtrlOpcRailSequenceStep2.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcRailSequenceStep2.TabIndex = 232
        Me.CtrlOpcRailSequenceStep2.TagName = "SeqPLA[6]"
        Me.CtrlOpcRailSequenceStep2.Text = "PLA6"
        '
        'CtrlOPCBag146
        '
        Me.CtrlOPCBag146.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag146.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag146.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag146.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag146.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag146.Category = 88
        Me.CtrlOPCBag146.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag146.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag146.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag146.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag146.Location = New System.Drawing.Point(823, 650)
        Me.CtrlOPCBag146.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag146.Name = "CtrlOPCBag146"
        Me.CtrlOPCBag146.PLC_Bag_ID = 0
        Me.CtrlOPCBag146.PlcName = Nothing
        Me.CtrlOPCBag146.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag146.TabIndex = 223
        Me.CtrlOPCBag146.TagName = "VC_Track[8,4]"
        Me.CtrlOPCBag146.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag148
        '
        Me.CtrlOPCBag148.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag148.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag148.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag148.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag148.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag148.Category = 88
        Me.CtrlOPCBag148.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag148.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag148.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag148.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag148.Location = New System.Drawing.Point(932, 660)
        Me.CtrlOPCBag148.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag148.Name = "CtrlOPCBag148"
        Me.CtrlOPCBag148.PLC_Bag_ID = 0
        Me.CtrlOPCBag148.PlcName = Nothing
        Me.CtrlOPCBag148.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag148.TabIndex = 221
        Me.CtrlOPCBag148.TagName = "VC_Track[8,2]"
        Me.CtrlOPCBag148.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag149
        '
        Me.CtrlOPCBag149.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag149.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag149.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag149.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag149.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag149.Category = 88
        Me.CtrlOPCBag149.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag149.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag149.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag149.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag149.Location = New System.Drawing.Point(1002, 660)
        Me.CtrlOPCBag149.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag149.Name = "CtrlOPCBag149"
        Me.CtrlOPCBag149.PLC_Bag_ID = 0
        Me.CtrlOPCBag149.PlcName = Nothing
        Me.CtrlOPCBag149.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag149.TabIndex = 222
        Me.CtrlOPCBag149.TagName = "VC_Track[8,1]"
        Me.CtrlOPCBag149.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton83
        '
        Me.CtrlOPCBagAddButton83.AllowDrop = True
        Me.CtrlOPCBagAddButton83.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton83.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton83.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton83.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton83.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton83.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton83.Location = New System.Drawing.Point(407, 674)
        Me.CtrlOPCBagAddButton83.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton83.Name = "CtrlOPCBagAddButton83"
        Me.CtrlOPCBagAddButton83.PlcName = Nothing
        Me.CtrlOPCBagAddButton83.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton83.TabIndex = 218
        Me.CtrlOPCBagAddButton83.TagName = "LU_Track[25,0]"
        Me.CtrlOPCBagAddButton83.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton84
        '
        Me.CtrlOPCBagAddButton84.AllowDrop = True
        Me.CtrlOPCBagAddButton84.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton84.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton84.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton84.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton84.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton84.Location = New System.Drawing.Point(443, 674)
        Me.CtrlOPCBagAddButton84.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton84.Name = "CtrlOPCBagAddButton84"
        Me.CtrlOPCBagAddButton84.PlcName = Nothing
        Me.CtrlOPCBagAddButton84.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton84.TabIndex = 217
        Me.CtrlOPCBagAddButton84.TagName = "LU_Track[26,0]"
        Me.CtrlOPCBagAddButton84.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton85
        '
        Me.CtrlOPCBagAddButton85.AllowDrop = True
        Me.CtrlOPCBagAddButton85.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton85.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton85.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton85.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton85.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton85.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton85.Location = New System.Drawing.Point(519, 674)
        Me.CtrlOPCBagAddButton85.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton85.Name = "CtrlOPCBagAddButton85"
        Me.CtrlOPCBagAddButton85.PlcName = Nothing
        Me.CtrlOPCBagAddButton85.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton85.TabIndex = 216
        Me.CtrlOPCBagAddButton85.TagName = "LU_Track[28,0]"
        Me.CtrlOPCBagAddButton85.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton86
        '
        Me.CtrlOPCBagAddButton86.AllowDrop = True
        Me.CtrlOPCBagAddButton86.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton86.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton86.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton86.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton86.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton86.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton86.Location = New System.Drawing.Point(480, 674)
        Me.CtrlOPCBagAddButton86.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton86.Name = "CtrlOPCBagAddButton86"
        Me.CtrlOPCBagAddButton86.PlcName = Nothing
        Me.CtrlOPCBagAddButton86.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton86.TabIndex = 215
        Me.CtrlOPCBagAddButton86.TagName = "LU_Track[27,0]"
        Me.CtrlOPCBagAddButton86.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton87
        '
        Me.CtrlOPCBagAddButton87.AllowDrop = True
        Me.CtrlOPCBagAddButton87.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton87.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton87.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton87.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton87.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton87.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton87.Location = New System.Drawing.Point(556, 674)
        Me.CtrlOPCBagAddButton87.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton87.Name = "CtrlOPCBagAddButton87"
        Me.CtrlOPCBagAddButton87.PlcName = Nothing
        Me.CtrlOPCBagAddButton87.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton87.TabIndex = 214
        Me.CtrlOPCBagAddButton87.TagName = "LU_Track[29,0]"
        Me.CtrlOPCBagAddButton87.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton88
        '
        Me.CtrlOPCBagAddButton88.AllowDrop = True
        Me.CtrlOPCBagAddButton88.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton88.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton88.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton88.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton88.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton88.Location = New System.Drawing.Point(628, 674)
        Me.CtrlOPCBagAddButton88.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton88.Name = "CtrlOPCBagAddButton88"
        Me.CtrlOPCBagAddButton88.PlcName = Nothing
        Me.CtrlOPCBagAddButton88.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton88.TabIndex = 213
        Me.CtrlOPCBagAddButton88.TagName = "LU_Track[31,0]"
        Me.CtrlOPCBagAddButton88.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton89
        '
        Me.CtrlOPCBagAddButton89.AllowDrop = True
        Me.CtrlOPCBagAddButton89.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton89.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton89.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton89.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton89.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton89.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton89.Location = New System.Drawing.Point(592, 674)
        Me.CtrlOPCBagAddButton89.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton89.Name = "CtrlOPCBagAddButton89"
        Me.CtrlOPCBagAddButton89.PlcName = Nothing
        Me.CtrlOPCBagAddButton89.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton89.TabIndex = 212
        Me.CtrlOPCBagAddButton89.TagName = "LU_Track[30,0]"
        Me.CtrlOPCBagAddButton89.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton90
        '
        Me.CtrlOPCBagAddButton90.AllowDrop = True
        Me.CtrlOPCBagAddButton90.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton90.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton90.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton90.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton90.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton90.Location = New System.Drawing.Point(667, 674)
        Me.CtrlOPCBagAddButton90.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton90.Name = "CtrlOPCBagAddButton90"
        Me.CtrlOPCBagAddButton90.PlcName = Nothing
        Me.CtrlOPCBagAddButton90.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton90.TabIndex = 211
        Me.CtrlOPCBagAddButton90.TagName = "LU_Track[32,0]"
        Me.CtrlOPCBagAddButton90.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton91
        '
        Me.CtrlOPCBagAddButton91.AllowDrop = True
        Me.CtrlOPCBagAddButton91.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton91.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton91.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton91.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton91.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton91.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton91.Location = New System.Drawing.Point(738, 674)
        Me.CtrlOPCBagAddButton91.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton91.Name = "CtrlOPCBagAddButton91"
        Me.CtrlOPCBagAddButton91.PlcName = Nothing
        Me.CtrlOPCBagAddButton91.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton91.TabIndex = 210
        Me.CtrlOPCBagAddButton91.TagName = "LU_Track[34,0]"
        Me.CtrlOPCBagAddButton91.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton92
        '
        Me.CtrlOPCBagAddButton92.AllowDrop = True
        Me.CtrlOPCBagAddButton92.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton92.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton92.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton92.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton92.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton92.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton92.Location = New System.Drawing.Point(702, 674)
        Me.CtrlOPCBagAddButton92.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton92.Name = "CtrlOPCBagAddButton92"
        Me.CtrlOPCBagAddButton92.PlcName = Nothing
        Me.CtrlOPCBagAddButton92.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton92.TabIndex = 209
        Me.CtrlOPCBagAddButton92.TagName = "LU_Track[33,0]"
        Me.CtrlOPCBagAddButton92.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton73
        '
        Me.CtrlOPCBagAddButton73.AllowDrop = True
        Me.CtrlOPCBagAddButton73.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton73.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton73.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton73.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton73.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton73.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton73.Location = New System.Drawing.Point(408, 718)
        Me.CtrlOPCBagAddButton73.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton73.Name = "CtrlOPCBagAddButton73"
        Me.CtrlOPCBagAddButton73.PlcName = Nothing
        Me.CtrlOPCBagAddButton73.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton73.TabIndex = 208
        Me.CtrlOPCBagAddButton73.TagName = "Bins[25]"
        Me.CtrlOPCBagAddButton73.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton74
        '
        Me.CtrlOPCBagAddButton74.AllowDrop = True
        Me.CtrlOPCBagAddButton74.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton74.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton74.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton74.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton74.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton74.Location = New System.Drawing.Point(444, 718)
        Me.CtrlOPCBagAddButton74.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton74.Name = "CtrlOPCBagAddButton74"
        Me.CtrlOPCBagAddButton74.PlcName = Nothing
        Me.CtrlOPCBagAddButton74.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton74.TabIndex = 207
        Me.CtrlOPCBagAddButton74.TagName = "Bins[26]"
        Me.CtrlOPCBagAddButton74.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton75
        '
        Me.CtrlOPCBagAddButton75.AllowDrop = True
        Me.CtrlOPCBagAddButton75.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton75.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton75.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton75.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton75.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton75.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton75.Location = New System.Drawing.Point(520, 718)
        Me.CtrlOPCBagAddButton75.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton75.Name = "CtrlOPCBagAddButton75"
        Me.CtrlOPCBagAddButton75.PlcName = Nothing
        Me.CtrlOPCBagAddButton75.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton75.TabIndex = 206
        Me.CtrlOPCBagAddButton75.TagName = "Bins[28]"
        Me.CtrlOPCBagAddButton75.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton76
        '
        Me.CtrlOPCBagAddButton76.AllowDrop = True
        Me.CtrlOPCBagAddButton76.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton76.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton76.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton76.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton76.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton76.Location = New System.Drawing.Point(481, 718)
        Me.CtrlOPCBagAddButton76.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton76.Name = "CtrlOPCBagAddButton76"
        Me.CtrlOPCBagAddButton76.PlcName = Nothing
        Me.CtrlOPCBagAddButton76.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton76.TabIndex = 205
        Me.CtrlOPCBagAddButton76.TagName = "Bins[27]"
        Me.CtrlOPCBagAddButton76.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton77
        '
        Me.CtrlOPCBagAddButton77.AllowDrop = True
        Me.CtrlOPCBagAddButton77.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton77.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton77.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton77.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton77.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton77.Location = New System.Drawing.Point(557, 718)
        Me.CtrlOPCBagAddButton77.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton77.Name = "CtrlOPCBagAddButton77"
        Me.CtrlOPCBagAddButton77.PlcName = Nothing
        Me.CtrlOPCBagAddButton77.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton77.TabIndex = 204
        Me.CtrlOPCBagAddButton77.TagName = "Bins[29]"
        Me.CtrlOPCBagAddButton77.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton78
        '
        Me.CtrlOPCBagAddButton78.AllowDrop = True
        Me.CtrlOPCBagAddButton78.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton78.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton78.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton78.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton78.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton78.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton78.Location = New System.Drawing.Point(629, 718)
        Me.CtrlOPCBagAddButton78.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton78.Name = "CtrlOPCBagAddButton78"
        Me.CtrlOPCBagAddButton78.PlcName = Nothing
        Me.CtrlOPCBagAddButton78.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton78.TabIndex = 203
        Me.CtrlOPCBagAddButton78.TagName = "Bins[31]"
        Me.CtrlOPCBagAddButton78.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton79
        '
        Me.CtrlOPCBagAddButton79.AllowDrop = True
        Me.CtrlOPCBagAddButton79.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton79.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton79.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton79.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton79.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton79.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton79.Location = New System.Drawing.Point(593, 718)
        Me.CtrlOPCBagAddButton79.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton79.Name = "CtrlOPCBagAddButton79"
        Me.CtrlOPCBagAddButton79.PlcName = Nothing
        Me.CtrlOPCBagAddButton79.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton79.TabIndex = 202
        Me.CtrlOPCBagAddButton79.TagName = "Bins[30]"
        Me.CtrlOPCBagAddButton79.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton80
        '
        Me.CtrlOPCBagAddButton80.AllowDrop = True
        Me.CtrlOPCBagAddButton80.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton80.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton80.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton80.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton80.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton80.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton80.Location = New System.Drawing.Point(668, 718)
        Me.CtrlOPCBagAddButton80.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton80.Name = "CtrlOPCBagAddButton80"
        Me.CtrlOPCBagAddButton80.PlcName = Nothing
        Me.CtrlOPCBagAddButton80.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton80.TabIndex = 201
        Me.CtrlOPCBagAddButton80.TagName = "Bins[32]"
        Me.CtrlOPCBagAddButton80.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton81
        '
        Me.CtrlOPCBagAddButton81.AllowDrop = True
        Me.CtrlOPCBagAddButton81.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton81.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton81.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton81.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton81.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton81.Location = New System.Drawing.Point(739, 718)
        Me.CtrlOPCBagAddButton81.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton81.Name = "CtrlOPCBagAddButton81"
        Me.CtrlOPCBagAddButton81.PlcName = Nothing
        Me.CtrlOPCBagAddButton81.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton81.TabIndex = 200
        Me.CtrlOPCBagAddButton81.TagName = "Bins[34]"
        Me.CtrlOPCBagAddButton81.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton82
        '
        Me.CtrlOPCBagAddButton82.AllowDrop = True
        Me.CtrlOPCBagAddButton82.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton82.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton82.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton82.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton82.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton82.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton82.Location = New System.Drawing.Point(703, 718)
        Me.CtrlOPCBagAddButton82.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton82.Name = "CtrlOPCBagAddButton82"
        Me.CtrlOPCBagAddButton82.PlcName = Nothing
        Me.CtrlOPCBagAddButton82.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton82.TabIndex = 199
        Me.CtrlOPCBagAddButton82.TagName = "Bins[33]"
        Me.CtrlOPCBagAddButton82.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton63
        '
        Me.CtrlOPCBagAddButton63.AllowDrop = True
        Me.CtrlOPCBagAddButton63.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton63.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton63.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton63.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton63.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton63.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton63.Location = New System.Drawing.Point(408, 789)
        Me.CtrlOPCBagAddButton63.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton63.Name = "CtrlOPCBagAddButton63"
        Me.CtrlOPCBagAddButton63.PlcName = Nothing
        Me.CtrlOPCBagAddButton63.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton63.TabIndex = 198
        Me.CtrlOPCBagAddButton63.TagName = "LU_Track[25,2]"
        Me.CtrlOPCBagAddButton63.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton64
        '
        Me.CtrlOPCBagAddButton64.AllowDrop = True
        Me.CtrlOPCBagAddButton64.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton64.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton64.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton64.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton64.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton64.Location = New System.Drawing.Point(444, 789)
        Me.CtrlOPCBagAddButton64.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton64.Name = "CtrlOPCBagAddButton64"
        Me.CtrlOPCBagAddButton64.PlcName = Nothing
        Me.CtrlOPCBagAddButton64.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton64.TabIndex = 197
        Me.CtrlOPCBagAddButton64.TagName = "LU_Track[26,2]"
        Me.CtrlOPCBagAddButton64.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton65
        '
        Me.CtrlOPCBagAddButton65.AllowDrop = True
        Me.CtrlOPCBagAddButton65.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton65.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton65.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton65.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton65.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton65.Location = New System.Drawing.Point(520, 789)
        Me.CtrlOPCBagAddButton65.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton65.Name = "CtrlOPCBagAddButton65"
        Me.CtrlOPCBagAddButton65.PlcName = Nothing
        Me.CtrlOPCBagAddButton65.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton65.TabIndex = 196
        Me.CtrlOPCBagAddButton65.TagName = "LU_Track[28,2]"
        Me.CtrlOPCBagAddButton65.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton66
        '
        Me.CtrlOPCBagAddButton66.AllowDrop = True
        Me.CtrlOPCBagAddButton66.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton66.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton66.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton66.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton66.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton66.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton66.Location = New System.Drawing.Point(481, 789)
        Me.CtrlOPCBagAddButton66.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton66.Name = "CtrlOPCBagAddButton66"
        Me.CtrlOPCBagAddButton66.PlcName = Nothing
        Me.CtrlOPCBagAddButton66.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton66.TabIndex = 195
        Me.CtrlOPCBagAddButton66.TagName = "LU_Track[27,2]"
        Me.CtrlOPCBagAddButton66.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton67
        '
        Me.CtrlOPCBagAddButton67.AllowDrop = True
        Me.CtrlOPCBagAddButton67.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton67.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton67.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton67.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton67.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton67.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton67.Location = New System.Drawing.Point(557, 789)
        Me.CtrlOPCBagAddButton67.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton67.Name = "CtrlOPCBagAddButton67"
        Me.CtrlOPCBagAddButton67.PlcName = Nothing
        Me.CtrlOPCBagAddButton67.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton67.TabIndex = 194
        Me.CtrlOPCBagAddButton67.TagName = "LU_Track[29,2]"
        Me.CtrlOPCBagAddButton67.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton68
        '
        Me.CtrlOPCBagAddButton68.AllowDrop = True
        Me.CtrlOPCBagAddButton68.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton68.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton68.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton68.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton68.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton68.Location = New System.Drawing.Point(629, 789)
        Me.CtrlOPCBagAddButton68.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton68.Name = "CtrlOPCBagAddButton68"
        Me.CtrlOPCBagAddButton68.PlcName = Nothing
        Me.CtrlOPCBagAddButton68.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton68.TabIndex = 193
        Me.CtrlOPCBagAddButton68.TagName = "LU_Track[31,2]"
        Me.CtrlOPCBagAddButton68.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton69
        '
        Me.CtrlOPCBagAddButton69.AllowDrop = True
        Me.CtrlOPCBagAddButton69.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton69.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton69.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton69.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton69.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton69.Location = New System.Drawing.Point(593, 789)
        Me.CtrlOPCBagAddButton69.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton69.Name = "CtrlOPCBagAddButton69"
        Me.CtrlOPCBagAddButton69.PlcName = Nothing
        Me.CtrlOPCBagAddButton69.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton69.TabIndex = 192
        Me.CtrlOPCBagAddButton69.TagName = "LU_Track[30,2]"
        Me.CtrlOPCBagAddButton69.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton70
        '
        Me.CtrlOPCBagAddButton70.AllowDrop = True
        Me.CtrlOPCBagAddButton70.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton70.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton70.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton70.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton70.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton70.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton70.Location = New System.Drawing.Point(668, 789)
        Me.CtrlOPCBagAddButton70.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton70.Name = "CtrlOPCBagAddButton70"
        Me.CtrlOPCBagAddButton70.PlcName = Nothing
        Me.CtrlOPCBagAddButton70.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton70.TabIndex = 191
        Me.CtrlOPCBagAddButton70.TagName = "LU_Track[32,2]"
        Me.CtrlOPCBagAddButton70.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton71
        '
        Me.CtrlOPCBagAddButton71.AllowDrop = True
        Me.CtrlOPCBagAddButton71.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton71.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton71.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton71.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton71.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton71.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton71.Location = New System.Drawing.Point(739, 789)
        Me.CtrlOPCBagAddButton71.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton71.Name = "CtrlOPCBagAddButton71"
        Me.CtrlOPCBagAddButton71.PlcName = Nothing
        Me.CtrlOPCBagAddButton71.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton71.TabIndex = 190
        Me.CtrlOPCBagAddButton71.TagName = "LU_Track[34,2]"
        Me.CtrlOPCBagAddButton71.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton72
        '
        Me.CtrlOPCBagAddButton72.AllowDrop = True
        Me.CtrlOPCBagAddButton72.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton72.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton72.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton72.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton72.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton72.Location = New System.Drawing.Point(703, 789)
        Me.CtrlOPCBagAddButton72.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton72.Name = "CtrlOPCBagAddButton72"
        Me.CtrlOPCBagAddButton72.PlcName = Nothing
        Me.CtrlOPCBagAddButton72.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton72.TabIndex = 189
        Me.CtrlOPCBagAddButton72.TagName = "LU_Track[33,2]"
        Me.CtrlOPCBagAddButton72.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton56
        '
        Me.CtrlOPCBagAddButton56.AllowDrop = True
        Me.CtrlOPCBagAddButton56.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton56.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton56.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton56.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton56.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton56.Location = New System.Drawing.Point(574, 597)
        Me.CtrlOPCBagAddButton56.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton56.Name = "CtrlOPCBagAddButton56"
        Me.CtrlOPCBagAddButton56.PlcName = Nothing
        Me.CtrlOPCBagAddButton56.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton56.TabIndex = 188
        Me.CtrlOPCBagAddButton56.TagName = "LU_Track[21,0]"
        Me.CtrlOPCBagAddButton56.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton57
        '
        Me.CtrlOPCBagAddButton57.AllowDrop = True
        Me.CtrlOPCBagAddButton57.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton57.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton57.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton57.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton57.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton57.Location = New System.Drawing.Point(627, 597)
        Me.CtrlOPCBagAddButton57.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton57.Name = "CtrlOPCBagAddButton57"
        Me.CtrlOPCBagAddButton57.PlcName = Nothing
        Me.CtrlOPCBagAddButton57.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton57.TabIndex = 187
        Me.CtrlOPCBagAddButton57.TagName = "LU_Track[20,0]"
        Me.CtrlOPCBagAddButton57.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton58
        '
        Me.CtrlOPCBagAddButton58.AllowDrop = True
        Me.CtrlOPCBagAddButton58.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton58.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton58.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton58.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton58.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton58.Location = New System.Drawing.Point(739, 597)
        Me.CtrlOPCBagAddButton58.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton58.Name = "CtrlOPCBagAddButton58"
        Me.CtrlOPCBagAddButton58.PlcName = Nothing
        Me.CtrlOPCBagAddButton58.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton58.TabIndex = 186
        Me.CtrlOPCBagAddButton58.TagName = "LU_Track[18,0]"
        Me.CtrlOPCBagAddButton58.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton59
        '
        Me.CtrlOPCBagAddButton59.AllowDrop = True
        Me.CtrlOPCBagAddButton59.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton59.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton59.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton59.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton59.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton59.Location = New System.Drawing.Point(684, 597)
        Me.CtrlOPCBagAddButton59.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton59.Name = "CtrlOPCBagAddButton59"
        Me.CtrlOPCBagAddButton59.PlcName = Nothing
        Me.CtrlOPCBagAddButton59.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton59.TabIndex = 185
        Me.CtrlOPCBagAddButton59.TagName = "LU_Track[19,0]"
        Me.CtrlOPCBagAddButton59.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton60
        '
        Me.CtrlOPCBagAddButton60.AllowDrop = True
        Me.CtrlOPCBagAddButton60.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton60.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton60.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton60.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton60.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton60.Location = New System.Drawing.Point(408, 597)
        Me.CtrlOPCBagAddButton60.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton60.Name = "CtrlOPCBagAddButton60"
        Me.CtrlOPCBagAddButton60.PlcName = Nothing
        Me.CtrlOPCBagAddButton60.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton60.TabIndex = 184
        Me.CtrlOPCBagAddButton60.TagName = "LU_Track[24,0]"
        Me.CtrlOPCBagAddButton60.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton61
        '
        Me.CtrlOPCBagAddButton61.AllowDrop = True
        Me.CtrlOPCBagAddButton61.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton61.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton61.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton61.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton61.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton61.Location = New System.Drawing.Point(520, 597)
        Me.CtrlOPCBagAddButton61.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton61.Name = "CtrlOPCBagAddButton61"
        Me.CtrlOPCBagAddButton61.PlcName = Nothing
        Me.CtrlOPCBagAddButton61.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton61.TabIndex = 183
        Me.CtrlOPCBagAddButton61.TagName = "LU_Track[22,0]"
        Me.CtrlOPCBagAddButton61.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton62
        '
        Me.CtrlOPCBagAddButton62.AllowDrop = True
        Me.CtrlOPCBagAddButton62.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton62.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton62.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton62.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton62.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton62.Location = New System.Drawing.Point(464, 597)
        Me.CtrlOPCBagAddButton62.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton62.Name = "CtrlOPCBagAddButton62"
        Me.CtrlOPCBagAddButton62.PlcName = Nothing
        Me.CtrlOPCBagAddButton62.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton62.TabIndex = 182
        Me.CtrlOPCBagAddButton62.TagName = "LU_Track[23,0]"
        Me.CtrlOPCBagAddButton62.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton49
        '
        Me.CtrlOPCBagAddButton49.AllowDrop = True
        Me.CtrlOPCBagAddButton49.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton49.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton49.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton49.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton49.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton49.Location = New System.Drawing.Point(574, 554)
        Me.CtrlOPCBagAddButton49.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton49.Name = "CtrlOPCBagAddButton49"
        Me.CtrlOPCBagAddButton49.PlcName = Nothing
        Me.CtrlOPCBagAddButton49.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton49.TabIndex = 181
        Me.CtrlOPCBagAddButton49.TagName = "Bins[21]"
        Me.CtrlOPCBagAddButton49.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton50
        '
        Me.CtrlOPCBagAddButton50.AllowDrop = True
        Me.CtrlOPCBagAddButton50.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton50.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton50.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton50.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton50.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton50.Location = New System.Drawing.Point(627, 554)
        Me.CtrlOPCBagAddButton50.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton50.Name = "CtrlOPCBagAddButton50"
        Me.CtrlOPCBagAddButton50.PlcName = Nothing
        Me.CtrlOPCBagAddButton50.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton50.TabIndex = 180
        Me.CtrlOPCBagAddButton50.TagName = "Bins[20]"
        Me.CtrlOPCBagAddButton50.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton51
        '
        Me.CtrlOPCBagAddButton51.AllowDrop = True
        Me.CtrlOPCBagAddButton51.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton51.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton51.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton51.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton51.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton51.Location = New System.Drawing.Point(738, 554)
        Me.CtrlOPCBagAddButton51.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton51.Name = "CtrlOPCBagAddButton51"
        Me.CtrlOPCBagAddButton51.PlcName = Nothing
        Me.CtrlOPCBagAddButton51.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton51.TabIndex = 179
        Me.CtrlOPCBagAddButton51.TagName = "Bins[18]"
        Me.CtrlOPCBagAddButton51.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton52
        '
        Me.CtrlOPCBagAddButton52.AllowDrop = True
        Me.CtrlOPCBagAddButton52.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton52.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton52.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton52.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton52.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton52.Location = New System.Drawing.Point(684, 554)
        Me.CtrlOPCBagAddButton52.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton52.Name = "CtrlOPCBagAddButton52"
        Me.CtrlOPCBagAddButton52.PlcName = Nothing
        Me.CtrlOPCBagAddButton52.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton52.TabIndex = 178
        Me.CtrlOPCBagAddButton52.TagName = "Bins[19]"
        Me.CtrlOPCBagAddButton52.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton53
        '
        Me.CtrlOPCBagAddButton53.AllowDrop = True
        Me.CtrlOPCBagAddButton53.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton53.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton53.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton53.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton53.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton53.Location = New System.Drawing.Point(408, 554)
        Me.CtrlOPCBagAddButton53.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton53.Name = "CtrlOPCBagAddButton53"
        Me.CtrlOPCBagAddButton53.PlcName = Nothing
        Me.CtrlOPCBagAddButton53.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton53.TabIndex = 177
        Me.CtrlOPCBagAddButton53.TagName = "Bins[24]"
        Me.CtrlOPCBagAddButton53.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton54
        '
        Me.CtrlOPCBagAddButton54.AllowDrop = True
        Me.CtrlOPCBagAddButton54.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton54.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton54.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton54.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton54.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton54.Location = New System.Drawing.Point(520, 554)
        Me.CtrlOPCBagAddButton54.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton54.Name = "CtrlOPCBagAddButton54"
        Me.CtrlOPCBagAddButton54.PlcName = Nothing
        Me.CtrlOPCBagAddButton54.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton54.TabIndex = 176
        Me.CtrlOPCBagAddButton54.TagName = "Bins[22]"
        Me.CtrlOPCBagAddButton54.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton55
        '
        Me.CtrlOPCBagAddButton55.AllowDrop = True
        Me.CtrlOPCBagAddButton55.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton55.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton55.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton55.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton55.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton55.Location = New System.Drawing.Point(464, 554)
        Me.CtrlOPCBagAddButton55.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton55.Name = "CtrlOPCBagAddButton55"
        Me.CtrlOPCBagAddButton55.PlcName = Nothing
        Me.CtrlOPCBagAddButton55.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton55.TabIndex = 175
        Me.CtrlOPCBagAddButton55.TagName = "Bins[23]"
        Me.CtrlOPCBagAddButton55.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton42
        '
        Me.CtrlOPCBagAddButton42.AllowDrop = True
        Me.CtrlOPCBagAddButton42.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton42.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton42.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton42.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton42.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton42.Location = New System.Drawing.Point(571, 483)
        Me.CtrlOPCBagAddButton42.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton42.Name = "CtrlOPCBagAddButton42"
        Me.CtrlOPCBagAddButton42.PlcName = Nothing
        Me.CtrlOPCBagAddButton42.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton42.TabIndex = 174
        Me.CtrlOPCBagAddButton42.TagName = "LU_Track[21,2]"
        Me.CtrlOPCBagAddButton42.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton43
        '
        Me.CtrlOPCBagAddButton43.AllowDrop = True
        Me.CtrlOPCBagAddButton43.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton43.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton43.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton43.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton43.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton43.Location = New System.Drawing.Point(627, 483)
        Me.CtrlOPCBagAddButton43.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton43.Name = "CtrlOPCBagAddButton43"
        Me.CtrlOPCBagAddButton43.PlcName = Nothing
        Me.CtrlOPCBagAddButton43.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton43.TabIndex = 173
        Me.CtrlOPCBagAddButton43.TagName = "LU_Track[20,2]"
        Me.CtrlOPCBagAddButton43.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton44
        '
        Me.CtrlOPCBagAddButton44.AllowDrop = True
        Me.CtrlOPCBagAddButton44.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton44.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton44.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton44.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton44.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton44.Location = New System.Drawing.Point(738, 483)
        Me.CtrlOPCBagAddButton44.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton44.Name = "CtrlOPCBagAddButton44"
        Me.CtrlOPCBagAddButton44.PlcName = Nothing
        Me.CtrlOPCBagAddButton44.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton44.TabIndex = 172
        Me.CtrlOPCBagAddButton44.TagName = "LU_Track[18,2]"
        Me.CtrlOPCBagAddButton44.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton45
        '
        Me.CtrlOPCBagAddButton45.AllowDrop = True
        Me.CtrlOPCBagAddButton45.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton45.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton45.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton45.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton45.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton45.Location = New System.Drawing.Point(684, 483)
        Me.CtrlOPCBagAddButton45.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton45.Name = "CtrlOPCBagAddButton45"
        Me.CtrlOPCBagAddButton45.PlcName = Nothing
        Me.CtrlOPCBagAddButton45.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton45.TabIndex = 171
        Me.CtrlOPCBagAddButton45.TagName = "LU_Track[19,2]"
        Me.CtrlOPCBagAddButton45.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton46
        '
        Me.CtrlOPCBagAddButton46.AllowDrop = True
        Me.CtrlOPCBagAddButton46.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton46.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton46.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton46.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton46.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton46.Location = New System.Drawing.Point(408, 483)
        Me.CtrlOPCBagAddButton46.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton46.Name = "CtrlOPCBagAddButton46"
        Me.CtrlOPCBagAddButton46.PlcName = Nothing
        Me.CtrlOPCBagAddButton46.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton46.TabIndex = 170
        Me.CtrlOPCBagAddButton46.TagName = "LU_Track[24,2]"
        Me.CtrlOPCBagAddButton46.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton47
        '
        Me.CtrlOPCBagAddButton47.AllowDrop = True
        Me.CtrlOPCBagAddButton47.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton47.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton47.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton47.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton47.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton47.Location = New System.Drawing.Point(520, 483)
        Me.CtrlOPCBagAddButton47.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton47.Name = "CtrlOPCBagAddButton47"
        Me.CtrlOPCBagAddButton47.PlcName = Nothing
        Me.CtrlOPCBagAddButton47.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton47.TabIndex = 169
        Me.CtrlOPCBagAddButton47.TagName = "LU_Track[22,2]"
        Me.CtrlOPCBagAddButton47.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton48
        '
        Me.CtrlOPCBagAddButton48.AllowDrop = True
        Me.CtrlOPCBagAddButton48.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton48.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton48.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton48.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton48.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton48.Location = New System.Drawing.Point(464, 483)
        Me.CtrlOPCBagAddButton48.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton48.Name = "CtrlOPCBagAddButton48"
        Me.CtrlOPCBagAddButton48.PlcName = Nothing
        Me.CtrlOPCBagAddButton48.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton48.TabIndex = 168
        Me.CtrlOPCBagAddButton48.TagName = "LU_Track[23,2]"
        Me.CtrlOPCBagAddButton48.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton31
        '
        Me.CtrlOPCBagAddButton31.AllowDrop = True
        Me.CtrlOPCBagAddButton31.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton31.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton31.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton31.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton31.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton31.Location = New System.Drawing.Point(573, 351)
        Me.CtrlOPCBagAddButton31.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton31.Name = "CtrlOPCBagAddButton31"
        Me.CtrlOPCBagAddButton31.PlcName = Nothing
        Me.CtrlOPCBagAddButton31.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton31.TabIndex = 160
        Me.CtrlOPCBagAddButton31.TagName = "LU_Track[4,2]"
        Me.CtrlOPCBagAddButton31.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton32
        '
        Me.CtrlOPCBagAddButton32.AllowDrop = True
        Me.CtrlOPCBagAddButton32.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton32.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton32.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton32.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton32.Location = New System.Drawing.Point(627, 351)
        Me.CtrlOPCBagAddButton32.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton32.Name = "CtrlOPCBagAddButton32"
        Me.CtrlOPCBagAddButton32.PlcName = Nothing
        Me.CtrlOPCBagAddButton32.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton32.TabIndex = 159
        Me.CtrlOPCBagAddButton32.TagName = "LU_Track[3,2]"
        Me.CtrlOPCBagAddButton32.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton33
        '
        Me.CtrlOPCBagAddButton33.AllowDrop = True
        Me.CtrlOPCBagAddButton33.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton33.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton33.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton33.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton33.Location = New System.Drawing.Point(738, 351)
        Me.CtrlOPCBagAddButton33.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton33.Name = "CtrlOPCBagAddButton33"
        Me.CtrlOPCBagAddButton33.PlcName = Nothing
        Me.CtrlOPCBagAddButton33.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton33.TabIndex = 158
        Me.CtrlOPCBagAddButton33.TagName = "LU_Track[1,2]"
        Me.CtrlOPCBagAddButton33.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton34
        '
        Me.CtrlOPCBagAddButton34.AllowDrop = True
        Me.CtrlOPCBagAddButton34.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton34.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton34.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton34.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton34.Location = New System.Drawing.Point(685, 351)
        Me.CtrlOPCBagAddButton34.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton34.Name = "CtrlOPCBagAddButton34"
        Me.CtrlOPCBagAddButton34.PlcName = Nothing
        Me.CtrlOPCBagAddButton34.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton34.TabIndex = 157
        Me.CtrlOPCBagAddButton34.TagName = "LU_Track[2,2]"
        Me.CtrlOPCBagAddButton34.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton28
        '
        Me.CtrlOPCBagAddButton28.AllowDrop = True
        Me.CtrlOPCBagAddButton28.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton28.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton28.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton28.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton28.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton28.Location = New System.Drawing.Point(408, 352)
        Me.CtrlOPCBagAddButton28.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton28.Name = "CtrlOPCBagAddButton28"
        Me.CtrlOPCBagAddButton28.PlcName = Nothing
        Me.CtrlOPCBagAddButton28.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton28.TabIndex = 149
        Me.CtrlOPCBagAddButton28.TagName = "LU_Track[7,2]"
        Me.CtrlOPCBagAddButton28.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton29
        '
        Me.CtrlOPCBagAddButton29.AllowDrop = True
        Me.CtrlOPCBagAddButton29.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton29.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton29.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton29.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton29.Location = New System.Drawing.Point(520, 351)
        Me.CtrlOPCBagAddButton29.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton29.Name = "CtrlOPCBagAddButton29"
        Me.CtrlOPCBagAddButton29.PlcName = Nothing
        Me.CtrlOPCBagAddButton29.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton29.TabIndex = 148
        Me.CtrlOPCBagAddButton29.TagName = "LU_Track[5,2]"
        Me.CtrlOPCBagAddButton29.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton30
        '
        Me.CtrlOPCBagAddButton30.AllowDrop = True
        Me.CtrlOPCBagAddButton30.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton30.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton30.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton30.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton30.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton30.Location = New System.Drawing.Point(464, 351)
        Me.CtrlOPCBagAddButton30.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton30.Name = "CtrlOPCBagAddButton30"
        Me.CtrlOPCBagAddButton30.PlcName = Nothing
        Me.CtrlOPCBagAddButton30.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton30.TabIndex = 147
        Me.CtrlOPCBagAddButton30.TagName = "LU_Track[6,2]"
        Me.CtrlOPCBagAddButton30.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton11
        '
        Me.CtrlOPCBagAddButton11.AllowDrop = True
        Me.CtrlOPCBagAddButton11.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton11.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton11.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton11.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton11.Location = New System.Drawing.Point(408, 159)
        Me.CtrlOPCBagAddButton11.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton11.Name = "CtrlOPCBagAddButton11"
        Me.CtrlOPCBagAddButton11.PlcName = Nothing
        Me.CtrlOPCBagAddButton11.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton11.TabIndex = 146
        Me.CtrlOPCBagAddButton11.TagName = "LU_Track[8,0]"
        Me.CtrlOPCBagAddButton11.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton12
        '
        Me.CtrlOPCBagAddButton12.AllowDrop = True
        Me.CtrlOPCBagAddButton12.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton12.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton12.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton12.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton12.Location = New System.Drawing.Point(444, 159)
        Me.CtrlOPCBagAddButton12.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton12.Name = "CtrlOPCBagAddButton12"
        Me.CtrlOPCBagAddButton12.PlcName = Nothing
        Me.CtrlOPCBagAddButton12.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton12.TabIndex = 145
        Me.CtrlOPCBagAddButton12.TagName = "LU_Track[9,0]"
        Me.CtrlOPCBagAddButton12.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton13
        '
        Me.CtrlOPCBagAddButton13.AllowDrop = True
        Me.CtrlOPCBagAddButton13.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton13.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton13.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton13.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton13.Location = New System.Drawing.Point(519, 159)
        Me.CtrlOPCBagAddButton13.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton13.Name = "CtrlOPCBagAddButton13"
        Me.CtrlOPCBagAddButton13.PlcName = Nothing
        Me.CtrlOPCBagAddButton13.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton13.TabIndex = 144
        Me.CtrlOPCBagAddButton13.TagName = "LU_Track[11,0]"
        Me.CtrlOPCBagAddButton13.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton14
        '
        Me.CtrlOPCBagAddButton14.AllowDrop = True
        Me.CtrlOPCBagAddButton14.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton14.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton14.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton14.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton14.Location = New System.Drawing.Point(480, 159)
        Me.CtrlOPCBagAddButton14.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton14.Name = "CtrlOPCBagAddButton14"
        Me.CtrlOPCBagAddButton14.PlcName = Nothing
        Me.CtrlOPCBagAddButton14.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton14.TabIndex = 143
        Me.CtrlOPCBagAddButton14.TagName = "LU_Track[10,0]"
        Me.CtrlOPCBagAddButton14.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton15
        '
        Me.CtrlOPCBagAddButton15.AllowDrop = True
        Me.CtrlOPCBagAddButton15.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton15.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton15.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton15.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton15.Location = New System.Drawing.Point(556, 159)
        Me.CtrlOPCBagAddButton15.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton15.Name = "CtrlOPCBagAddButton15"
        Me.CtrlOPCBagAddButton15.PlcName = Nothing
        Me.CtrlOPCBagAddButton15.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton15.TabIndex = 142
        Me.CtrlOPCBagAddButton15.TagName = "LU_Track[12,0]"
        Me.CtrlOPCBagAddButton15.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton16
        '
        Me.CtrlOPCBagAddButton16.AllowDrop = True
        Me.CtrlOPCBagAddButton16.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton16.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton16.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton16.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton16.Location = New System.Drawing.Point(627, 159)
        Me.CtrlOPCBagAddButton16.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton16.Name = "CtrlOPCBagAddButton16"
        Me.CtrlOPCBagAddButton16.PlcName = Nothing
        Me.CtrlOPCBagAddButton16.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton16.TabIndex = 141
        Me.CtrlOPCBagAddButton16.TagName = "LU_Track[14,0]"
        Me.CtrlOPCBagAddButton16.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton17
        '
        Me.CtrlOPCBagAddButton17.AllowDrop = True
        Me.CtrlOPCBagAddButton17.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton17.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton17.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton17.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton17.Location = New System.Drawing.Point(592, 159)
        Me.CtrlOPCBagAddButton17.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton17.Name = "CtrlOPCBagAddButton17"
        Me.CtrlOPCBagAddButton17.PlcName = Nothing
        Me.CtrlOPCBagAddButton17.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton17.TabIndex = 140
        Me.CtrlOPCBagAddButton17.TagName = "LU_Track[13,0]"
        Me.CtrlOPCBagAddButton17.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton18
        '
        Me.CtrlOPCBagAddButton18.AllowDrop = True
        Me.CtrlOPCBagAddButton18.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton18.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton18.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton18.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton18.Location = New System.Drawing.Point(667, 159)
        Me.CtrlOPCBagAddButton18.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton18.Name = "CtrlOPCBagAddButton18"
        Me.CtrlOPCBagAddButton18.PlcName = Nothing
        Me.CtrlOPCBagAddButton18.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton18.TabIndex = 139
        Me.CtrlOPCBagAddButton18.TagName = "LU_Track[15,0]"
        Me.CtrlOPCBagAddButton18.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton19
        '
        Me.CtrlOPCBagAddButton19.AllowDrop = True
        Me.CtrlOPCBagAddButton19.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton19.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton19.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton19.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton19.Location = New System.Drawing.Point(739, 159)
        Me.CtrlOPCBagAddButton19.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton19.Name = "CtrlOPCBagAddButton19"
        Me.CtrlOPCBagAddButton19.PlcName = Nothing
        Me.CtrlOPCBagAddButton19.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton19.TabIndex = 138
        Me.CtrlOPCBagAddButton19.TagName = "LU_Track[17,0]"
        Me.CtrlOPCBagAddButton19.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton20
        '
        Me.CtrlOPCBagAddButton20.AllowDrop = True
        Me.CtrlOPCBagAddButton20.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton20.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton20.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton20.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton20.Location = New System.Drawing.Point(703, 159)
        Me.CtrlOPCBagAddButton20.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton20.Name = "CtrlOPCBagAddButton20"
        Me.CtrlOPCBagAddButton20.PlcName = Nothing
        Me.CtrlOPCBagAddButton20.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton20.TabIndex = 137
        Me.CtrlOPCBagAddButton20.TagName = "LU_Track[16,0]"
        Me.CtrlOPCBagAddButton20.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton1
        '
        Me.CtrlOPCBagAddButton1.AllowDrop = True
        Me.CtrlOPCBagAddButton1.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton1.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton1.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton1.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton1.Location = New System.Drawing.Point(408, 44)
        Me.CtrlOPCBagAddButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton1.Name = "CtrlOPCBagAddButton1"
        Me.CtrlOPCBagAddButton1.PlcName = Nothing
        Me.CtrlOPCBagAddButton1.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton1.TabIndex = 136
        Me.CtrlOPCBagAddButton1.TagName = "LU_Track[8,2]"
        Me.CtrlOPCBagAddButton1.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton2
        '
        Me.CtrlOPCBagAddButton2.AllowDrop = True
        Me.CtrlOPCBagAddButton2.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton2.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton2.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton2.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton2.Location = New System.Drawing.Point(444, 44)
        Me.CtrlOPCBagAddButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton2.Name = "CtrlOPCBagAddButton2"
        Me.CtrlOPCBagAddButton2.PlcName = Nothing
        Me.CtrlOPCBagAddButton2.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton2.TabIndex = 135
        Me.CtrlOPCBagAddButton2.TagName = "LU_Track[9,2]"
        Me.CtrlOPCBagAddButton2.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton3
        '
        Me.CtrlOPCBagAddButton3.AllowDrop = True
        Me.CtrlOPCBagAddButton3.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton3.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton3.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton3.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton3.Location = New System.Drawing.Point(519, 44)
        Me.CtrlOPCBagAddButton3.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton3.Name = "CtrlOPCBagAddButton3"
        Me.CtrlOPCBagAddButton3.PlcName = Nothing
        Me.CtrlOPCBagAddButton3.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton3.TabIndex = 134
        Me.CtrlOPCBagAddButton3.TagName = "LU_Track[11,2]"
        Me.CtrlOPCBagAddButton3.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton4
        '
        Me.CtrlOPCBagAddButton4.AllowDrop = True
        Me.CtrlOPCBagAddButton4.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton4.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton4.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton4.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton4.Location = New System.Drawing.Point(480, 44)
        Me.CtrlOPCBagAddButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton4.Name = "CtrlOPCBagAddButton4"
        Me.CtrlOPCBagAddButton4.PlcName = Nothing
        Me.CtrlOPCBagAddButton4.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton4.TabIndex = 133
        Me.CtrlOPCBagAddButton4.TagName = "LU_Track[10,2]"
        Me.CtrlOPCBagAddButton4.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton5
        '
        Me.CtrlOPCBagAddButton5.AllowDrop = True
        Me.CtrlOPCBagAddButton5.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton5.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton5.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton5.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton5.Location = New System.Drawing.Point(556, 44)
        Me.CtrlOPCBagAddButton5.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton5.Name = "CtrlOPCBagAddButton5"
        Me.CtrlOPCBagAddButton5.PlcName = Nothing
        Me.CtrlOPCBagAddButton5.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton5.TabIndex = 132
        Me.CtrlOPCBagAddButton5.TagName = "LU_Track[12,2]"
        Me.CtrlOPCBagAddButton5.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton6
        '
        Me.CtrlOPCBagAddButton6.AllowDrop = True
        Me.CtrlOPCBagAddButton6.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton6.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton6.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton6.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton6.Location = New System.Drawing.Point(627, 44)
        Me.CtrlOPCBagAddButton6.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton6.Name = "CtrlOPCBagAddButton6"
        Me.CtrlOPCBagAddButton6.PlcName = Nothing
        Me.CtrlOPCBagAddButton6.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton6.TabIndex = 131
        Me.CtrlOPCBagAddButton6.TagName = "LU_Track[14,2]"
        Me.CtrlOPCBagAddButton6.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton7
        '
        Me.CtrlOPCBagAddButton7.AllowDrop = True
        Me.CtrlOPCBagAddButton7.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton7.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton7.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton7.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton7.Location = New System.Drawing.Point(592, 44)
        Me.CtrlOPCBagAddButton7.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton7.Name = "CtrlOPCBagAddButton7"
        Me.CtrlOPCBagAddButton7.PlcName = Nothing
        Me.CtrlOPCBagAddButton7.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton7.TabIndex = 130
        Me.CtrlOPCBagAddButton7.TagName = "LU_Track[13,2]"
        Me.CtrlOPCBagAddButton7.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton8
        '
        Me.CtrlOPCBagAddButton8.AllowDrop = True
        Me.CtrlOPCBagAddButton8.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton8.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton8.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton8.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton8.Location = New System.Drawing.Point(667, 44)
        Me.CtrlOPCBagAddButton8.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton8.Name = "CtrlOPCBagAddButton8"
        Me.CtrlOPCBagAddButton8.PlcName = Nothing
        Me.CtrlOPCBagAddButton8.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton8.TabIndex = 129
        Me.CtrlOPCBagAddButton8.TagName = "LU_Track[15,2]"
        Me.CtrlOPCBagAddButton8.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton9
        '
        Me.CtrlOPCBagAddButton9.AllowDrop = True
        Me.CtrlOPCBagAddButton9.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton9.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton9.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton9.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton9.Location = New System.Drawing.Point(739, 44)
        Me.CtrlOPCBagAddButton9.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton9.Name = "CtrlOPCBagAddButton9"
        Me.CtrlOPCBagAddButton9.PlcName = Nothing
        Me.CtrlOPCBagAddButton9.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton9.TabIndex = 128
        Me.CtrlOPCBagAddButton9.TagName = "LU_Track[17,2]"
        Me.CtrlOPCBagAddButton9.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton10
        '
        Me.CtrlOPCBagAddButton10.AllowDrop = True
        Me.CtrlOPCBagAddButton10.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton10.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton10.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton10.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton10.Location = New System.Drawing.Point(703, 44)
        Me.CtrlOPCBagAddButton10.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton10.Name = "CtrlOPCBagAddButton10"
        Me.CtrlOPCBagAddButton10.PlcName = Nothing
        Me.CtrlOPCBagAddButton10.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton10.TabIndex = 127
        Me.CtrlOPCBagAddButton10.TagName = "LU_Track[16,2]"
        Me.CtrlOPCBagAddButton10.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag116
        '
        Me.CtrlOPCBag116.AllowDrop = True
        Me.CtrlOPCBag116.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag116.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag116.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag116.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag116.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag116.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag116.Location = New System.Drawing.Point(408, 116)
        Me.CtrlOPCBag116.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag116.Name = "CtrlOPCBag116"
        Me.CtrlOPCBag116.PlcName = Nothing
        Me.CtrlOPCBag116.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag116.TabIndex = 126
        Me.CtrlOPCBag116.TagName = "Bins[8]"
        Me.CtrlOPCBag116.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag117
        '
        Me.CtrlOPCBag117.AllowDrop = True
        Me.CtrlOPCBag117.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag117.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag117.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag117.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag117.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag117.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag117.Location = New System.Drawing.Point(444, 116)
        Me.CtrlOPCBag117.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag117.Name = "CtrlOPCBag117"
        Me.CtrlOPCBag117.PlcName = Nothing
        Me.CtrlOPCBag117.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag117.TabIndex = 125
        Me.CtrlOPCBag117.TagName = "Bins[9]"
        Me.CtrlOPCBag117.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag118
        '
        Me.CtrlOPCBag118.AllowDrop = True
        Me.CtrlOPCBag118.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag118.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag118.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag118.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag118.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag118.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag118.Location = New System.Drawing.Point(519, 116)
        Me.CtrlOPCBag118.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag118.Name = "CtrlOPCBag118"
        Me.CtrlOPCBag118.PlcName = Nothing
        Me.CtrlOPCBag118.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag118.TabIndex = 124
        Me.CtrlOPCBag118.TagName = "Bins[11]"
        Me.CtrlOPCBag118.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag119
        '
        Me.CtrlOPCBag119.AllowDrop = True
        Me.CtrlOPCBag119.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag119.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag119.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag119.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag119.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag119.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag119.Location = New System.Drawing.Point(480, 116)
        Me.CtrlOPCBag119.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag119.Name = "CtrlOPCBag119"
        Me.CtrlOPCBag119.PlcName = Nothing
        Me.CtrlOPCBag119.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag119.TabIndex = 123
        Me.CtrlOPCBag119.TagName = "Bins[10]"
        Me.CtrlOPCBag119.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag120
        '
        Me.CtrlOPCBag120.AllowDrop = True
        Me.CtrlOPCBag120.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag120.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag120.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag120.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag120.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag120.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag120.Location = New System.Drawing.Point(556, 116)
        Me.CtrlOPCBag120.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag120.Name = "CtrlOPCBag120"
        Me.CtrlOPCBag120.PlcName = Nothing
        Me.CtrlOPCBag120.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag120.TabIndex = 122
        Me.CtrlOPCBag120.TagName = "Bins[12]"
        Me.CtrlOPCBag120.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag121
        '
        Me.CtrlOPCBag121.AllowDrop = True
        Me.CtrlOPCBag121.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag121.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag121.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag121.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag121.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag121.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag121.Location = New System.Drawing.Point(627, 116)
        Me.CtrlOPCBag121.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag121.Name = "CtrlOPCBag121"
        Me.CtrlOPCBag121.PlcName = Nothing
        Me.CtrlOPCBag121.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag121.TabIndex = 121
        Me.CtrlOPCBag121.TagName = "Bins[14]"
        Me.CtrlOPCBag121.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag122
        '
        Me.CtrlOPCBag122.AllowDrop = True
        Me.CtrlOPCBag122.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag122.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag122.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag122.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag122.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag122.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag122.Location = New System.Drawing.Point(592, 116)
        Me.CtrlOPCBag122.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag122.Name = "CtrlOPCBag122"
        Me.CtrlOPCBag122.PlcName = Nothing
        Me.CtrlOPCBag122.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag122.TabIndex = 120
        Me.CtrlOPCBag122.TagName = "Bins[13]"
        Me.CtrlOPCBag122.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag123
        '
        Me.CtrlOPCBag123.AllowDrop = True
        Me.CtrlOPCBag123.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag123.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag123.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag123.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag123.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag123.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag123.Location = New System.Drawing.Point(667, 116)
        Me.CtrlOPCBag123.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag123.Name = "CtrlOPCBag123"
        Me.CtrlOPCBag123.PlcName = Nothing
        Me.CtrlOPCBag123.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag123.TabIndex = 119
        Me.CtrlOPCBag123.TagName = "Bins[15]"
        Me.CtrlOPCBag123.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag124
        '
        Me.CtrlOPCBag124.AllowDrop = True
        Me.CtrlOPCBag124.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag124.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag124.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag124.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag124.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag124.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag124.Location = New System.Drawing.Point(739, 116)
        Me.CtrlOPCBag124.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag124.Name = "CtrlOPCBag124"
        Me.CtrlOPCBag124.PlcName = Nothing
        Me.CtrlOPCBag124.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag124.TabIndex = 118
        Me.CtrlOPCBag124.TagName = "Bins[17]"
        Me.CtrlOPCBag124.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag125
        '
        Me.CtrlOPCBag125.AllowDrop = True
        Me.CtrlOPCBag125.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag125.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBag125.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag125.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBag125.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag125.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag125.Location = New System.Drawing.Point(703, 116)
        Me.CtrlOPCBag125.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag125.Name = "CtrlOPCBag125"
        Me.CtrlOPCBag125.PlcName = Nothing
        Me.CtrlOPCBag125.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBag125.TabIndex = 117
        Me.CtrlOPCBag125.TagName = "Bins[16]"
        Me.CtrlOPCBag125.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag104
        '
        Me.CtrlOPCBag104.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag104.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag104.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag104.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag104.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag104.Category = 88
        Me.CtrlOPCBag104.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag104.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOPCBag104.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag104.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOPCBag104.Location = New System.Drawing.Point(277, 497)
        Me.CtrlOPCBag104.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag104.Name = "CtrlOPCBag104"
        Me.CtrlOPCBag104.PLC_Bag_ID = 0
        Me.CtrlOPCBag104.PlcName = Nothing
        Me.CtrlOPCBag104.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag104.TabIndex = 116
        Me.CtrlOPCBag104.TagName = "PLA_Track[8,0]"
        Me.CtrlOPCBag104.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBag145
        '
        Me.CtrlOPCBag145.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag145.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag145.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag145.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag145.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag145.Category = 88
        Me.CtrlOPCBag145.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag145.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag145.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag145.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag145.Location = New System.Drawing.Point(823, 610)
        Me.CtrlOPCBag145.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag145.Name = "CtrlOPCBag145"
        Me.CtrlOPCBag145.PLC_Bag_ID = 0
        Me.CtrlOPCBag145.PlcName = Nothing
        Me.CtrlOPCBag145.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag145.TabIndex = 113
        Me.CtrlOPCBag145.TagName = "VC_Track[7,4]"
        Me.CtrlOPCBag145.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag141
        '
        Me.CtrlOPCBag141.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag141.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag141.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag141.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag141.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag141.Category = 88
        Me.CtrlOPCBag141.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag141.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag141.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag141.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag141.Location = New System.Drawing.Point(823, 171)
        Me.CtrlOPCBag141.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag141.Name = "CtrlOPCBag141"
        Me.CtrlOPCBag141.PLC_Bag_ID = 0
        Me.CtrlOPCBag141.PlcName = Nothing
        Me.CtrlOPCBag141.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag141.TabIndex = 113
        Me.CtrlOPCBag141.TagName = "VC_Track[5,4]"
        Me.CtrlOPCBag141.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag143
        '
        Me.CtrlOPCBag143.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag143.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag143.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag143.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag143.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag143.Category = 88
        Me.CtrlOPCBag143.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag143.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag143.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag143.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag143.Location = New System.Drawing.Point(931, 610)
        Me.CtrlOPCBag143.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag143.Name = "CtrlOPCBag143"
        Me.CtrlOPCBag143.PLC_Bag_ID = 0
        Me.CtrlOPCBag143.PlcName = Nothing
        Me.CtrlOPCBag143.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag143.TabIndex = 113
        Me.CtrlOPCBag143.TagName = "VC_Track[7,2]"
        Me.CtrlOPCBag143.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag142
        '
        Me.CtrlOPCBag142.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag142.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag142.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag142.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag142.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag142.Category = 88
        Me.CtrlOPCBag142.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag142.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag142.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag142.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag142.Location = New System.Drawing.Point(1002, 605)
        Me.CtrlOPCBag142.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag142.Name = "CtrlOPCBag142"
        Me.CtrlOPCBag142.PLC_Bag_ID = 0
        Me.CtrlOPCBag142.PlcName = Nothing
        Me.CtrlOPCBag142.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag142.TabIndex = 113
        Me.CtrlOPCBag142.TagName = "VC_Track[7,1]"
        Me.CtrlOPCBag142.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag138
        '
        Me.CtrlOPCBag138.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag138.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag138.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag138.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag138.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag138.Category = 88
        Me.CtrlOPCBag138.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag138.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag138.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag138.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag138.Location = New System.Drawing.Point(1040, 167)
        Me.CtrlOPCBag138.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag138.Name = "CtrlOPCBag138"
        Me.CtrlOPCBag138.PLC_Bag_ID = 0
        Me.CtrlOPCBag138.PlcName = Nothing
        Me.CtrlOPCBag138.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag138.TabIndex = 113
        Me.CtrlOPCBag138.TagName = "VC_Track[5,1]"
        Me.CtrlOPCBag138.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag113
        '
        Me.CtrlOPCBag113.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag113.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag113.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag113.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag113.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag113.Category = 88
        Me.CtrlOPCBag113.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag113.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOPCBag113.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag113.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOPCBag113.Location = New System.Drawing.Point(321, 802)
        Me.CtrlOPCBag113.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag113.Name = "CtrlOPCBag113"
        Me.CtrlOPCBag113.PLC_Bag_ID = 0
        Me.CtrlOPCBag113.PlcName = Nothing
        Me.CtrlOPCBag113.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag113.TabIndex = 112
        Me.CtrlOPCBag113.TagName = "PLA_Track[9,0]"
        Me.CtrlOPCBag113.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBag108
        '
        Me.CtrlOPCBag108.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag108.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag108.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag108.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag108.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag108.Category = 88
        Me.CtrlOPCBag108.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag108.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag108.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag108.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag108.Location = New System.Drawing.Point(401, 689)
        Me.CtrlOPCBag108.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag108.Name = "CtrlOPCBag108"
        Me.CtrlOPCBag108.PLC_Bag_ID = 0
        Me.CtrlOPCBag108.PlcName = Nothing
        Me.CtrlOPCBag108.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag108.TabIndex = 109
        Me.CtrlOPCBag108.TagName = "LU_Track[25,0]"
        Me.CtrlOPCBag108.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag109
        '
        Me.CtrlOPCBag109.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag109.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag109.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag109.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag109.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag109.Category = 88
        Me.CtrlOPCBag109.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag109.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag109.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag109.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag109.Location = New System.Drawing.Point(401, 761)
        Me.CtrlOPCBag109.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag109.Name = "CtrlOPCBag109"
        Me.CtrlOPCBag109.PLC_Bag_ID = 0
        Me.CtrlOPCBag109.PlcName = Nothing
        Me.CtrlOPCBag109.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag109.TabIndex = 108
        Me.CtrlOPCBag109.TagName = "LU_Track[25,2]"
        Me.CtrlOPCBag109.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag110
        '
        Me.CtrlOPCBag110.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag110.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag110.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag110.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag110.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag110.Category = 88
        Me.CtrlOPCBag110.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag110.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag110.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag110.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag110.Location = New System.Drawing.Point(401, 733)
        Me.CtrlOPCBag110.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag110.Name = "CtrlOPCBag110"
        Me.CtrlOPCBag110.PLC_Bag_ID = 0
        Me.CtrlOPCBag110.PlcName = Nothing
        Me.CtrlOPCBag110.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag110.TabIndex = 107
        Me.CtrlOPCBag110.TagName = "Bins[25]"
        Me.CtrlOPCBag110.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag105
        '
        Me.CtrlOPCBag105.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag105.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag105.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag105.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag105.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag105.Category = 88
        Me.CtrlOPCBag105.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag105.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag105.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag105.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag105.Location = New System.Drawing.Point(401, 131)
        Me.CtrlOPCBag105.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag105.Name = "CtrlOPCBag105"
        Me.CtrlOPCBag105.PLC_Bag_ID = 0
        Me.CtrlOPCBag105.PlcName = Nothing
        Me.CtrlOPCBag105.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag105.TabIndex = 106
        Me.CtrlOPCBag105.TagName = "LU_Track[8,0]"
        Me.CtrlOPCBag105.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag106
        '
        Me.CtrlOPCBag106.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag106.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag106.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag106.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag106.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag106.Category = 88
        Me.CtrlOPCBag106.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag106.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag106.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag106.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag106.Location = New System.Drawing.Point(401, 87)
        Me.CtrlOPCBag106.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag106.Name = "CtrlOPCBag106"
        Me.CtrlOPCBag106.PLC_Bag_ID = 0
        Me.CtrlOPCBag106.PlcName = Nothing
        Me.CtrlOPCBag106.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag106.TabIndex = 105
        Me.CtrlOPCBag106.TagName = "Bins[8]"
        Me.CtrlOPCBag106.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag107
        '
        Me.CtrlOPCBag107.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag107.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag107.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag107.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag107.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag107.Category = 88
        Me.CtrlOPCBag107.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag107.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag107.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag107.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag107.Location = New System.Drawing.Point(401, 59)
        Me.CtrlOPCBag107.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag107.Name = "CtrlOPCBag107"
        Me.CtrlOPCBag107.PLC_Bag_ID = 0
        Me.CtrlOPCBag107.PlcName = Nothing
        Me.CtrlOPCBag107.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag107.TabIndex = 104
        Me.CtrlOPCBag107.TagName = "LU_Track[8,2]"
        Me.CtrlOPCBag107.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag90
        '
        Me.CtrlOPCBag90.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag90.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag90.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag90.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag90.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag90.Category = 88
        Me.CtrlOPCBag90.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag90.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag90.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag90.Location = New System.Drawing.Point(401, 569)
        Me.CtrlOPCBag90.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag90.Name = "CtrlOPCBag90"
        Me.CtrlOPCBag90.PLC_Bag_ID = 0
        Me.CtrlOPCBag90.PlcName = Nothing
        Me.CtrlOPCBag90.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag90.TabIndex = 95
        Me.CtrlOPCBag90.TagName = "LU_Track[24,0]"
        Me.CtrlOPCBag90.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag91
        '
        Me.CtrlOPCBag91.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag91.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag91.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag91.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag91.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag91.Category = 88
        Me.CtrlOPCBag91.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag91.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag91.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag91.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag91.Location = New System.Drawing.Point(457, 569)
        Me.CtrlOPCBag91.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag91.Name = "CtrlOPCBag91"
        Me.CtrlOPCBag91.PLC_Bag_ID = 0
        Me.CtrlOPCBag91.PlcName = Nothing
        Me.CtrlOPCBag91.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag91.TabIndex = 94
        Me.CtrlOPCBag91.TagName = "LU_Track[23,0]"
        Me.CtrlOPCBag91.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag92
        '
        Me.CtrlOPCBag92.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag92.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag92.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag92.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag92.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag92.Category = 88
        Me.CtrlOPCBag92.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag92.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag92.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag92.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag92.Location = New System.Drawing.Point(513, 569)
        Me.CtrlOPCBag92.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag92.Name = "CtrlOPCBag92"
        Me.CtrlOPCBag92.PLC_Bag_ID = 0
        Me.CtrlOPCBag92.PlcName = Nothing
        Me.CtrlOPCBag92.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag92.TabIndex = 93
        Me.CtrlOPCBag92.TagName = "LU_Track[22,0]"
        Me.CtrlOPCBag92.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag93
        '
        Me.CtrlOPCBag93.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag93.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag93.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag93.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag93.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag93.Category = 88
        Me.CtrlOPCBag93.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag93.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag93.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag93.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag93.Location = New System.Drawing.Point(566, 569)
        Me.CtrlOPCBag93.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag93.Name = "CtrlOPCBag93"
        Me.CtrlOPCBag93.PLC_Bag_ID = 0
        Me.CtrlOPCBag93.PlcName = Nothing
        Me.CtrlOPCBag93.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag93.TabIndex = 92
        Me.CtrlOPCBag93.TagName = "LU_Track[21,0]"
        Me.CtrlOPCBag93.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag94
        '
        Me.CtrlOPCBag94.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag94.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag94.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag94.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag94.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag94.Category = 88
        Me.CtrlOPCBag94.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag94.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag94.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag94.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag94.Location = New System.Drawing.Point(620, 569)
        Me.CtrlOPCBag94.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag94.Name = "CtrlOPCBag94"
        Me.CtrlOPCBag94.PLC_Bag_ID = 0
        Me.CtrlOPCBag94.PlcName = Nothing
        Me.CtrlOPCBag94.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag94.TabIndex = 91
        Me.CtrlOPCBag94.TagName = "LU_Track[20,0]"
        Me.CtrlOPCBag94.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag95
        '
        Me.CtrlOPCBag95.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag95.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag95.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag95.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag95.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag95.Category = 88
        Me.CtrlOPCBag95.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag95.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag95.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag95.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag95.Location = New System.Drawing.Point(677, 569)
        Me.CtrlOPCBag95.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag95.Name = "CtrlOPCBag95"
        Me.CtrlOPCBag95.PLC_Bag_ID = 0
        Me.CtrlOPCBag95.PlcName = Nothing
        Me.CtrlOPCBag95.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag95.TabIndex = 90
        Me.CtrlOPCBag95.TagName = "LU_Track[19,0]"
        Me.CtrlOPCBag95.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag96
        '
        Me.CtrlOPCBag96.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag96.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag96.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag96.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag96.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag96.Category = 88
        Me.CtrlOPCBag96.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag96.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag96.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag96.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag96.Location = New System.Drawing.Point(732, 569)
        Me.CtrlOPCBag96.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag96.Name = "CtrlOPCBag96"
        Me.CtrlOPCBag96.PLC_Bag_ID = 0
        Me.CtrlOPCBag96.PlcName = Nothing
        Me.CtrlOPCBag96.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag96.TabIndex = 89
        Me.CtrlOPCBag96.TagName = "LU_Track[18,0]"
        Me.CtrlOPCBag96.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag73
        '
        Me.CtrlOPCBag73.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag73.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag73.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag73.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag73.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag73.Category = 88
        Me.CtrlOPCBag73.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag73.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag73.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag73.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag73.Location = New System.Drawing.Point(401, 526)
        Me.CtrlOPCBag73.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag73.Name = "CtrlOPCBag73"
        Me.CtrlOPCBag73.PLC_Bag_ID = 0
        Me.CtrlOPCBag73.PlcName = Nothing
        Me.CtrlOPCBag73.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag73.TabIndex = 77
        Me.CtrlOPCBag73.TagName = "Bins[24]"
        Me.CtrlOPCBag73.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag74
        '
        Me.CtrlOPCBag74.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag74.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag74.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag74.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag74.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag74.Category = 88
        Me.CtrlOPCBag74.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag74.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag74.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag74.Location = New System.Drawing.Point(401, 498)
        Me.CtrlOPCBag74.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag74.Name = "CtrlOPCBag74"
        Me.CtrlOPCBag74.PLC_Bag_ID = 0
        Me.CtrlOPCBag74.PlcName = Nothing
        Me.CtrlOPCBag74.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag74.TabIndex = 76
        Me.CtrlOPCBag74.TagName = "LU_Track[24,2]"
        Me.CtrlOPCBag74.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag75
        '
        Me.CtrlOPCBag75.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag75.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag75.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag75.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag75.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag75.Category = 88
        Me.CtrlOPCBag75.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag75.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag75.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag75.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag75.Location = New System.Drawing.Point(457, 526)
        Me.CtrlOPCBag75.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag75.Name = "CtrlOPCBag75"
        Me.CtrlOPCBag75.PLC_Bag_ID = 0
        Me.CtrlOPCBag75.PlcName = Nothing
        Me.CtrlOPCBag75.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag75.TabIndex = 75
        Me.CtrlOPCBag75.TagName = "Bins[23]"
        Me.CtrlOPCBag75.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag76
        '
        Me.CtrlOPCBag76.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag76.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag76.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag76.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag76.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag76.Category = 88
        Me.CtrlOPCBag76.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag76.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag76.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag76.Location = New System.Drawing.Point(457, 498)
        Me.CtrlOPCBag76.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag76.Name = "CtrlOPCBag76"
        Me.CtrlOPCBag76.PLC_Bag_ID = 0
        Me.CtrlOPCBag76.PlcName = Nothing
        Me.CtrlOPCBag76.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag76.TabIndex = 74
        Me.CtrlOPCBag76.TagName = "LU_Track[23,2]"
        Me.CtrlOPCBag76.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag77
        '
        Me.CtrlOPCBag77.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag77.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag77.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag77.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag77.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag77.Category = 88
        Me.CtrlOPCBag77.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag77.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag77.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag77.Location = New System.Drawing.Point(513, 526)
        Me.CtrlOPCBag77.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag77.Name = "CtrlOPCBag77"
        Me.CtrlOPCBag77.PLC_Bag_ID = 0
        Me.CtrlOPCBag77.PlcName = Nothing
        Me.CtrlOPCBag77.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag77.TabIndex = 73
        Me.CtrlOPCBag77.TagName = "Bins[22]"
        Me.CtrlOPCBag77.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag78
        '
        Me.CtrlOPCBag78.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag78.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag78.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag78.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag78.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag78.Category = 88
        Me.CtrlOPCBag78.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag78.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag78.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag78.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag78.Location = New System.Drawing.Point(513, 498)
        Me.CtrlOPCBag78.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag78.Name = "CtrlOPCBag78"
        Me.CtrlOPCBag78.PLC_Bag_ID = 0
        Me.CtrlOPCBag78.PlcName = Nothing
        Me.CtrlOPCBag78.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag78.TabIndex = 72
        Me.CtrlOPCBag78.TagName = "LU_Track[22,2]"
        Me.CtrlOPCBag78.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag57
        '
        Me.CtrlOPCBag57.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag57.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag57.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag57.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag57.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag57.Category = 88
        Me.CtrlOPCBag57.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag57.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag57.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag57.Location = New System.Drawing.Point(566, 526)
        Me.CtrlOPCBag57.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag57.Name = "CtrlOPCBag57"
        Me.CtrlOPCBag57.PLC_Bag_ID = 0
        Me.CtrlOPCBag57.PlcName = Nothing
        Me.CtrlOPCBag57.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag57.TabIndex = 69
        Me.CtrlOPCBag57.TagName = "Bins[21]"
        Me.CtrlOPCBag57.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag58
        '
        Me.CtrlOPCBag58.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag58.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag58.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag58.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag58.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag58.Category = 88
        Me.CtrlOPCBag58.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag58.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag58.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag58.Location = New System.Drawing.Point(566, 498)
        Me.CtrlOPCBag58.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag58.Name = "CtrlOPCBag58"
        Me.CtrlOPCBag58.PLC_Bag_ID = 0
        Me.CtrlOPCBag58.PlcName = Nothing
        Me.CtrlOPCBag58.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag58.TabIndex = 68
        Me.CtrlOPCBag58.TagName = "LU_Track[21,2]"
        Me.CtrlOPCBag58.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag65
        '
        Me.CtrlOPCBag65.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag65.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag65.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag65.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag65.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag65.Category = 88
        Me.CtrlOPCBag65.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag65.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag65.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag65.Location = New System.Drawing.Point(620, 526)
        Me.CtrlOPCBag65.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag65.Name = "CtrlOPCBag65"
        Me.CtrlOPCBag65.PLC_Bag_ID = 0
        Me.CtrlOPCBag65.PlcName = Nothing
        Me.CtrlOPCBag65.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag65.TabIndex = 61
        Me.CtrlOPCBag65.TagName = "Bins[20]"
        Me.CtrlOPCBag65.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag66
        '
        Me.CtrlOPCBag66.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag66.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag66.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag66.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag66.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag66.Category = 88
        Me.CtrlOPCBag66.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag66.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag66.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag66.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag66.Location = New System.Drawing.Point(620, 498)
        Me.CtrlOPCBag66.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag66.Name = "CtrlOPCBag66"
        Me.CtrlOPCBag66.PLC_Bag_ID = 0
        Me.CtrlOPCBag66.PlcName = Nothing
        Me.CtrlOPCBag66.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag66.TabIndex = 60
        Me.CtrlOPCBag66.TagName = "LU_Track[20,2]"
        Me.CtrlOPCBag66.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag67
        '
        Me.CtrlOPCBag67.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag67.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag67.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag67.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag67.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag67.Category = 88
        Me.CtrlOPCBag67.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag67.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag67.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag67.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag67.Location = New System.Drawing.Point(676, 526)
        Me.CtrlOPCBag67.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag67.Name = "CtrlOPCBag67"
        Me.CtrlOPCBag67.PLC_Bag_ID = 0
        Me.CtrlOPCBag67.PlcName = Nothing
        Me.CtrlOPCBag67.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag67.TabIndex = 59
        Me.CtrlOPCBag67.TagName = "Bins[19]"
        Me.CtrlOPCBag67.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag68
        '
        Me.CtrlOPCBag68.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag68.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag68.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag68.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag68.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag68.Category = 88
        Me.CtrlOPCBag68.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag68.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag68.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag68.Location = New System.Drawing.Point(676, 498)
        Me.CtrlOPCBag68.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag68.Name = "CtrlOPCBag68"
        Me.CtrlOPCBag68.PLC_Bag_ID = 0
        Me.CtrlOPCBag68.PlcName = Nothing
        Me.CtrlOPCBag68.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag68.TabIndex = 58
        Me.CtrlOPCBag68.TagName = "LU_Track[19,2]"
        Me.CtrlOPCBag68.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag69
        '
        Me.CtrlOPCBag69.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag69.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag69.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag69.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBag69.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag69.Category = 88
        Me.CtrlOPCBag69.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag69.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag69.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag69.Location = New System.Drawing.Point(732, 526)
        Me.CtrlOPCBag69.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag69.Name = "CtrlOPCBag69"
        Me.CtrlOPCBag69.PLC_Bag_ID = 0
        Me.CtrlOPCBag69.PlcName = Nothing
        Me.CtrlOPCBag69.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag69.TabIndex = 57
        Me.CtrlOPCBag69.TagName = "Bins[18]"
        Me.CtrlOPCBag69.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag70
        '
        Me.CtrlOPCBag70.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag70.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag70.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag70.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag70.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag70.Category = 88
        Me.CtrlOPCBag70.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag70.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag70.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag70.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag70.Location = New System.Drawing.Point(732, 498)
        Me.CtrlOPCBag70.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag70.Name = "CtrlOPCBag70"
        Me.CtrlOPCBag70.PLC_Bag_ID = 0
        Me.CtrlOPCBag70.PlcName = Nothing
        Me.CtrlOPCBag70.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag70.TabIndex = 56
        Me.CtrlOPCBag70.TagName = "LU_Track[18,2]"
        Me.CtrlOPCBag70.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag46
        '
        Me.CtrlOPCBag46.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag46.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag46.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag46.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag46.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag46.Category = 88
        Me.CtrlOPCBag46.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag46.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag46.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag46.Location = New System.Drawing.Point(437, 689)
        Me.CtrlOPCBag46.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag46.Name = "CtrlOPCBag46"
        Me.CtrlOPCBag46.PLC_Bag_ID = 0
        Me.CtrlOPCBag46.PlcName = Nothing
        Me.CtrlOPCBag46.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag46.TabIndex = 53
        Me.CtrlOPCBag46.TagName = "LU_Track[26,0]"
        Me.CtrlOPCBag46.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag47
        '
        Me.CtrlOPCBag47.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag47.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag47.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag47.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag47.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag47.Category = 88
        Me.CtrlOPCBag47.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag47.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag47.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag47.Location = New System.Drawing.Point(513, 689)
        Me.CtrlOPCBag47.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag47.Name = "CtrlOPCBag47"
        Me.CtrlOPCBag47.PLC_Bag_ID = 0
        Me.CtrlOPCBag47.PlcName = Nothing
        Me.CtrlOPCBag47.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag47.TabIndex = 52
        Me.CtrlOPCBag47.TagName = "LU_Track[28,0]"
        Me.CtrlOPCBag47.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag48
        '
        Me.CtrlOPCBag48.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag48.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag48.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag48.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag48.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag48.Category = 88
        Me.CtrlOPCBag48.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag48.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag48.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag48.Location = New System.Drawing.Point(473, 689)
        Me.CtrlOPCBag48.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag48.Name = "CtrlOPCBag48"
        Me.CtrlOPCBag48.PLC_Bag_ID = 0
        Me.CtrlOPCBag48.PlcName = Nothing
        Me.CtrlOPCBag48.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag48.TabIndex = 51
        Me.CtrlOPCBag48.TagName = "LU_Track[27,0]"
        Me.CtrlOPCBag48.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag49
        '
        Me.CtrlOPCBag49.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag49.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag49.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag49.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag49.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag49.Category = 88
        Me.CtrlOPCBag49.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag49.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag49.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag49.Location = New System.Drawing.Point(549, 689)
        Me.CtrlOPCBag49.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag49.Name = "CtrlOPCBag49"
        Me.CtrlOPCBag49.PLC_Bag_ID = 0
        Me.CtrlOPCBag49.PlcName = Nothing
        Me.CtrlOPCBag49.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag49.TabIndex = 50
        Me.CtrlOPCBag49.TagName = "LU_Track[29,0]"
        Me.CtrlOPCBag49.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag50
        '
        Me.CtrlOPCBag50.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag50.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag50.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag50.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag50.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag50.Category = 88
        Me.CtrlOPCBag50.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag50.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag50.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag50.Location = New System.Drawing.Point(621, 689)
        Me.CtrlOPCBag50.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag50.Name = "CtrlOPCBag50"
        Me.CtrlOPCBag50.PLC_Bag_ID = 0
        Me.CtrlOPCBag50.PlcName = Nothing
        Me.CtrlOPCBag50.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag50.TabIndex = 49
        Me.CtrlOPCBag50.TagName = "LU_Track[31,0]"
        Me.CtrlOPCBag50.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag51
        '
        Me.CtrlOPCBag51.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag51.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag51.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag51.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag51.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag51.Category = 88
        Me.CtrlOPCBag51.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag51.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag51.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag51.Location = New System.Drawing.Point(585, 689)
        Me.CtrlOPCBag51.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag51.Name = "CtrlOPCBag51"
        Me.CtrlOPCBag51.PLC_Bag_ID = 0
        Me.CtrlOPCBag51.PlcName = Nothing
        Me.CtrlOPCBag51.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag51.TabIndex = 48
        Me.CtrlOPCBag51.TagName = "LU_Track[30,0]"
        Me.CtrlOPCBag51.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag52
        '
        Me.CtrlOPCBag52.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag52.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag52.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag52.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag52.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag52.Category = 88
        Me.CtrlOPCBag52.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag52.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag52.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag52.Location = New System.Drawing.Point(660, 689)
        Me.CtrlOPCBag52.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag52.Name = "CtrlOPCBag52"
        Me.CtrlOPCBag52.PLC_Bag_ID = 0
        Me.CtrlOPCBag52.PlcName = Nothing
        Me.CtrlOPCBag52.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag52.TabIndex = 47
        Me.CtrlOPCBag52.TagName = "LU_Track[32,0]"
        Me.CtrlOPCBag52.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag53
        '
        Me.CtrlOPCBag53.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag53.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag53.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag53.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag53.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag53.Category = 88
        Me.CtrlOPCBag53.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag53.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag53.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag53.Location = New System.Drawing.Point(732, 689)
        Me.CtrlOPCBag53.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag53.Name = "CtrlOPCBag53"
        Me.CtrlOPCBag53.PLC_Bag_ID = 0
        Me.CtrlOPCBag53.PlcName = Nothing
        Me.CtrlOPCBag53.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag53.TabIndex = 46
        Me.CtrlOPCBag53.TagName = "LU_Track[34,0]"
        Me.CtrlOPCBag53.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag54
        '
        Me.CtrlOPCBag54.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag54.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag54.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag54.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag54.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag54.Category = 88
        Me.CtrlOPCBag54.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag54.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag54.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag54.Location = New System.Drawing.Point(696, 689)
        Me.CtrlOPCBag54.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag54.Name = "CtrlOPCBag54"
        Me.CtrlOPCBag54.PLC_Bag_ID = 0
        Me.CtrlOPCBag54.PlcName = Nothing
        Me.CtrlOPCBag54.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag54.TabIndex = 45
        Me.CtrlOPCBag54.TagName = "LU_Track[33,0]"
        Me.CtrlOPCBag54.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag28
        '
        Me.CtrlOPCBag28.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag28.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag28.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag28.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag28.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag28.Category = 88
        Me.CtrlOPCBag28.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag28.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag28.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag28.Location = New System.Drawing.Point(437, 761)
        Me.CtrlOPCBag28.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag28.Name = "CtrlOPCBag28"
        Me.CtrlOPCBag28.PLC_Bag_ID = 0
        Me.CtrlOPCBag28.PlcName = Nothing
        Me.CtrlOPCBag28.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag28.TabIndex = 44
        Me.CtrlOPCBag28.TagName = "LU_Track[26,2]"
        Me.CtrlOPCBag28.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag29
        '
        Me.CtrlOPCBag29.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag29.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag29.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag29.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag29.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag29.Category = 88
        Me.CtrlOPCBag29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag29.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag29.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag29.Location = New System.Drawing.Point(437, 733)
        Me.CtrlOPCBag29.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag29.Name = "CtrlOPCBag29"
        Me.CtrlOPCBag29.PLC_Bag_ID = 0
        Me.CtrlOPCBag29.PlcName = Nothing
        Me.CtrlOPCBag29.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag29.TabIndex = 43
        Me.CtrlOPCBag29.TagName = "Bins[26]"
        Me.CtrlOPCBag29.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag30
        '
        Me.CtrlOPCBag30.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag30.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag30.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag30.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag30.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag30.Category = 88
        Me.CtrlOPCBag30.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag30.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag30.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag30.Location = New System.Drawing.Point(513, 761)
        Me.CtrlOPCBag30.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag30.Name = "CtrlOPCBag30"
        Me.CtrlOPCBag30.PLC_Bag_ID = 0
        Me.CtrlOPCBag30.PlcName = Nothing
        Me.CtrlOPCBag30.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag30.TabIndex = 42
        Me.CtrlOPCBag30.TagName = "LU_Track[28,2]"
        Me.CtrlOPCBag30.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag31
        '
        Me.CtrlOPCBag31.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag31.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag31.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag31.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag31.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag31.Category = 88
        Me.CtrlOPCBag31.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag31.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag31.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag31.Location = New System.Drawing.Point(513, 733)
        Me.CtrlOPCBag31.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag31.Name = "CtrlOPCBag31"
        Me.CtrlOPCBag31.PLC_Bag_ID = 0
        Me.CtrlOPCBag31.PlcName = Nothing
        Me.CtrlOPCBag31.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag31.TabIndex = 41
        Me.CtrlOPCBag31.TagName = "Bins[28]"
        Me.CtrlOPCBag31.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag32
        '
        Me.CtrlOPCBag32.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag32.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag32.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag32.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag32.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag32.Category = 88
        Me.CtrlOPCBag32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag32.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag32.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag32.Location = New System.Drawing.Point(473, 761)
        Me.CtrlOPCBag32.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag32.Name = "CtrlOPCBag32"
        Me.CtrlOPCBag32.PLC_Bag_ID = 0
        Me.CtrlOPCBag32.PlcName = Nothing
        Me.CtrlOPCBag32.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag32.TabIndex = 40
        Me.CtrlOPCBag32.TagName = "LU_Track[27,2]"
        Me.CtrlOPCBag32.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag33
        '
        Me.CtrlOPCBag33.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag33.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag33.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag33.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag33.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag33.Category = 88
        Me.CtrlOPCBag33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag33.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag33.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag33.Location = New System.Drawing.Point(473, 733)
        Me.CtrlOPCBag33.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag33.Name = "CtrlOPCBag33"
        Me.CtrlOPCBag33.PLC_Bag_ID = 0
        Me.CtrlOPCBag33.PlcName = Nothing
        Me.CtrlOPCBag33.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag33.TabIndex = 39
        Me.CtrlOPCBag33.TagName = "Bins[27]"
        Me.CtrlOPCBag33.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag34
        '
        Me.CtrlOPCBag34.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag34.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag34.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag34.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag34.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag34.Category = 88
        Me.CtrlOPCBag34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag34.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag34.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag34.Location = New System.Drawing.Point(549, 761)
        Me.CtrlOPCBag34.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag34.Name = "CtrlOPCBag34"
        Me.CtrlOPCBag34.PLC_Bag_ID = 0
        Me.CtrlOPCBag34.PlcName = Nothing
        Me.CtrlOPCBag34.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag34.TabIndex = 38
        Me.CtrlOPCBag34.TagName = "LU_Track[29,2]"
        Me.CtrlOPCBag34.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag35
        '
        Me.CtrlOPCBag35.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag35.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag35.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag35.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag35.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag35.Category = 88
        Me.CtrlOPCBag35.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag35.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag35.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag35.Location = New System.Drawing.Point(549, 733)
        Me.CtrlOPCBag35.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag35.Name = "CtrlOPCBag35"
        Me.CtrlOPCBag35.PLC_Bag_ID = 0
        Me.CtrlOPCBag35.PlcName = Nothing
        Me.CtrlOPCBag35.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag35.TabIndex = 37
        Me.CtrlOPCBag35.TagName = "Bins[29]"
        Me.CtrlOPCBag35.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag36
        '
        Me.CtrlOPCBag36.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag36.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag36.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag36.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag36.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag36.Category = 88
        Me.CtrlOPCBag36.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag36.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag36.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag36.Location = New System.Drawing.Point(621, 761)
        Me.CtrlOPCBag36.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag36.Name = "CtrlOPCBag36"
        Me.CtrlOPCBag36.PLC_Bag_ID = 0
        Me.CtrlOPCBag36.PlcName = Nothing
        Me.CtrlOPCBag36.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag36.TabIndex = 36
        Me.CtrlOPCBag36.TagName = "LU_Track[31,2]"
        Me.CtrlOPCBag36.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag37
        '
        Me.CtrlOPCBag37.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag37.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag37.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag37.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag37.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag37.Category = 88
        Me.CtrlOPCBag37.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag37.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag37.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag37.Location = New System.Drawing.Point(621, 733)
        Me.CtrlOPCBag37.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag37.Name = "CtrlOPCBag37"
        Me.CtrlOPCBag37.PLC_Bag_ID = 0
        Me.CtrlOPCBag37.PlcName = Nothing
        Me.CtrlOPCBag37.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag37.TabIndex = 35
        Me.CtrlOPCBag37.TagName = "Bins[31]"
        Me.CtrlOPCBag37.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag38
        '
        Me.CtrlOPCBag38.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag38.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag38.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag38.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag38.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag38.Category = 88
        Me.CtrlOPCBag38.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag38.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag38.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag38.Location = New System.Drawing.Point(585, 761)
        Me.CtrlOPCBag38.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag38.Name = "CtrlOPCBag38"
        Me.CtrlOPCBag38.PLC_Bag_ID = 0
        Me.CtrlOPCBag38.PlcName = Nothing
        Me.CtrlOPCBag38.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag38.TabIndex = 34
        Me.CtrlOPCBag38.TagName = "LU_Track[30,2]"
        Me.CtrlOPCBag38.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag39
        '
        Me.CtrlOPCBag39.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag39.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag39.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag39.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag39.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag39.Category = 88
        Me.CtrlOPCBag39.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag39.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag39.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag39.Location = New System.Drawing.Point(585, 733)
        Me.CtrlOPCBag39.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag39.Name = "CtrlOPCBag39"
        Me.CtrlOPCBag39.PLC_Bag_ID = 0
        Me.CtrlOPCBag39.PlcName = Nothing
        Me.CtrlOPCBag39.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag39.TabIndex = 33
        Me.CtrlOPCBag39.TagName = "Bins[30]"
        Me.CtrlOPCBag39.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag40
        '
        Me.CtrlOPCBag40.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag40.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag40.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag40.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag40.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag40.Category = 88
        Me.CtrlOPCBag40.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag40.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag40.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag40.Location = New System.Drawing.Point(660, 761)
        Me.CtrlOPCBag40.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag40.Name = "CtrlOPCBag40"
        Me.CtrlOPCBag40.PLC_Bag_ID = 0
        Me.CtrlOPCBag40.PlcName = Nothing
        Me.CtrlOPCBag40.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag40.TabIndex = 32
        Me.CtrlOPCBag40.TagName = "LU_Track[32,2]"
        Me.CtrlOPCBag40.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag41
        '
        Me.CtrlOPCBag41.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag41.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag41.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag41.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag41.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag41.Category = 88
        Me.CtrlOPCBag41.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag41.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag41.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag41.Location = New System.Drawing.Point(660, 733)
        Me.CtrlOPCBag41.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag41.Name = "CtrlOPCBag41"
        Me.CtrlOPCBag41.PLC_Bag_ID = 0
        Me.CtrlOPCBag41.PlcName = Nothing
        Me.CtrlOPCBag41.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag41.TabIndex = 31
        Me.CtrlOPCBag41.TagName = "Bins[32]"
        Me.CtrlOPCBag41.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag42
        '
        Me.CtrlOPCBag42.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag42.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag42.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag42.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag42.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag42.Category = 88
        Me.CtrlOPCBag42.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag42.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag42.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag42.Location = New System.Drawing.Point(732, 761)
        Me.CtrlOPCBag42.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag42.Name = "CtrlOPCBag42"
        Me.CtrlOPCBag42.PLC_Bag_ID = 0
        Me.CtrlOPCBag42.PlcName = Nothing
        Me.CtrlOPCBag42.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag42.TabIndex = 30
        Me.CtrlOPCBag42.TagName = "LU_Track[34,2]"
        Me.CtrlOPCBag42.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag43
        '
        Me.CtrlOPCBag43.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag43.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag43.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag43.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag43.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag43.Category = 88
        Me.CtrlOPCBag43.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag43.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag43.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag43.Location = New System.Drawing.Point(732, 733)
        Me.CtrlOPCBag43.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag43.Name = "CtrlOPCBag43"
        Me.CtrlOPCBag43.PLC_Bag_ID = 0
        Me.CtrlOPCBag43.PlcName = Nothing
        Me.CtrlOPCBag43.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag43.TabIndex = 29
        Me.CtrlOPCBag43.TagName = "Bins[34]"
        Me.CtrlOPCBag43.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag44
        '
        Me.CtrlOPCBag44.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag44.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag44.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag44.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag44.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag44.Category = 88
        Me.CtrlOPCBag44.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag44.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag44.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag44.Location = New System.Drawing.Point(696, 761)
        Me.CtrlOPCBag44.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag44.Name = "CtrlOPCBag44"
        Me.CtrlOPCBag44.PLC_Bag_ID = 0
        Me.CtrlOPCBag44.PlcName = Nothing
        Me.CtrlOPCBag44.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag44.TabIndex = 28
        Me.CtrlOPCBag44.TagName = "LU_Track[33,2]"
        Me.CtrlOPCBag44.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag45
        '
        Me.CtrlOPCBag45.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag45.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag45.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag45.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag45.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag45.Category = 88
        Me.CtrlOPCBag45.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag45.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag45.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag45.Location = New System.Drawing.Point(696, 733)
        Me.CtrlOPCBag45.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag45.Name = "CtrlOPCBag45"
        Me.CtrlOPCBag45.PLC_Bag_ID = 0
        Me.CtrlOPCBag45.PlcName = Nothing
        Me.CtrlOPCBag45.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag45.TabIndex = 27
        Me.CtrlOPCBag45.TagName = "Bins[33]"
        Me.CtrlOPCBag45.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag19
        '
        Me.CtrlOPCBag19.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag19.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag19.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag19.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag19.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag19.Category = 88
        Me.CtrlOPCBag19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag19.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag19.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag19.Location = New System.Drawing.Point(437, 131)
        Me.CtrlOPCBag19.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag19.Name = "CtrlOPCBag19"
        Me.CtrlOPCBag19.PLC_Bag_ID = 0
        Me.CtrlOPCBag19.PlcName = Nothing
        Me.CtrlOPCBag19.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag19.TabIndex = 26
        Me.CtrlOPCBag19.TagName = "LU_Track[9,0]"
        Me.CtrlOPCBag19.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag20
        '
        Me.CtrlOPCBag20.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag20.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag20.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag20.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag20.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag20.Category = 88
        Me.CtrlOPCBag20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag20.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag20.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag20.Location = New System.Drawing.Point(437, 87)
        Me.CtrlOPCBag20.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag20.Name = "CtrlOPCBag20"
        Me.CtrlOPCBag20.PLC_Bag_ID = 0
        Me.CtrlOPCBag20.PlcName = Nothing
        Me.CtrlOPCBag20.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag20.TabIndex = 25
        Me.CtrlOPCBag20.TagName = "Bins[9]"
        Me.CtrlOPCBag20.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag21
        '
        Me.CtrlOPCBag21.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag21.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag21.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag21.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag21.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag21.Category = 88
        Me.CtrlOPCBag21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag21.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag21.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag21.Location = New System.Drawing.Point(437, 59)
        Me.CtrlOPCBag21.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag21.Name = "CtrlOPCBag21"
        Me.CtrlOPCBag21.PLC_Bag_ID = 0
        Me.CtrlOPCBag21.PlcName = Nothing
        Me.CtrlOPCBag21.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag21.TabIndex = 24
        Me.CtrlOPCBag21.TagName = "LU_Track[9,2]"
        Me.CtrlOPCBag21.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag22
        '
        Me.CtrlOPCBag22.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag22.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag22.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag22.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag22.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag22.Category = 88
        Me.CtrlOPCBag22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag22.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag22.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag22.Location = New System.Drawing.Point(513, 131)
        Me.CtrlOPCBag22.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag22.Name = "CtrlOPCBag22"
        Me.CtrlOPCBag22.PLC_Bag_ID = 0
        Me.CtrlOPCBag22.PlcName = Nothing
        Me.CtrlOPCBag22.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag22.TabIndex = 23
        Me.CtrlOPCBag22.TagName = "LU_Track[11,0]"
        Me.CtrlOPCBag22.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag23
        '
        Me.CtrlOPCBag23.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag23.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag23.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag23.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag23.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag23.Category = 88
        Me.CtrlOPCBag23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag23.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag23.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag23.Location = New System.Drawing.Point(513, 87)
        Me.CtrlOPCBag23.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag23.Name = "CtrlOPCBag23"
        Me.CtrlOPCBag23.PLC_Bag_ID = 0
        Me.CtrlOPCBag23.PlcName = Nothing
        Me.CtrlOPCBag23.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag23.TabIndex = 22
        Me.CtrlOPCBag23.TagName = "Bins[11]"
        Me.CtrlOPCBag23.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag24
        '
        Me.CtrlOPCBag24.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag24.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag24.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag24.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag24.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag24.Category = 88
        Me.CtrlOPCBag24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag24.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag24.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag24.Location = New System.Drawing.Point(513, 59)
        Me.CtrlOPCBag24.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag24.Name = "CtrlOPCBag24"
        Me.CtrlOPCBag24.PLC_Bag_ID = 0
        Me.CtrlOPCBag24.PlcName = Nothing
        Me.CtrlOPCBag24.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag24.TabIndex = 21
        Me.CtrlOPCBag24.TagName = "LU_Track[11,2]"
        Me.CtrlOPCBag24.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag25
        '
        Me.CtrlOPCBag25.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag25.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag25.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag25.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag25.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag25.Category = 88
        Me.CtrlOPCBag25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag25.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag25.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag25.Location = New System.Drawing.Point(473, 131)
        Me.CtrlOPCBag25.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag25.Name = "CtrlOPCBag25"
        Me.CtrlOPCBag25.PLC_Bag_ID = 0
        Me.CtrlOPCBag25.PlcName = Nothing
        Me.CtrlOPCBag25.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag25.TabIndex = 20
        Me.CtrlOPCBag25.TagName = "LU_Track[10,0]"
        Me.CtrlOPCBag25.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag26
        '
        Me.CtrlOPCBag26.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag26.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag26.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag26.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag26.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag26.Category = 88
        Me.CtrlOPCBag26.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag26.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag26.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag26.Location = New System.Drawing.Point(473, 87)
        Me.CtrlOPCBag26.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag26.Name = "CtrlOPCBag26"
        Me.CtrlOPCBag26.PLC_Bag_ID = 0
        Me.CtrlOPCBag26.PlcName = Nothing
        Me.CtrlOPCBag26.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag26.TabIndex = 19
        Me.CtrlOPCBag26.TagName = "Bins[10]"
        Me.CtrlOPCBag26.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag27
        '
        Me.CtrlOPCBag27.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag27.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag27.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag27.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag27.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag27.Category = 88
        Me.CtrlOPCBag27.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag27.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag27.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag27.Location = New System.Drawing.Point(473, 59)
        Me.CtrlOPCBag27.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag27.Name = "CtrlOPCBag27"
        Me.CtrlOPCBag27.PLC_Bag_ID = 0
        Me.CtrlOPCBag27.PlcName = Nothing
        Me.CtrlOPCBag27.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag27.TabIndex = 18
        Me.CtrlOPCBag27.TagName = "LU_Track[10,2]"
        Me.CtrlOPCBag27.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag10
        '
        Me.CtrlOPCBag10.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag10.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag10.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag10.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag10.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag10.Category = 88
        Me.CtrlOPCBag10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag10.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag10.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag10.Location = New System.Drawing.Point(549, 131)
        Me.CtrlOPCBag10.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag10.Name = "CtrlOPCBag10"
        Me.CtrlOPCBag10.PLC_Bag_ID = 0
        Me.CtrlOPCBag10.PlcName = Nothing
        Me.CtrlOPCBag10.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag10.TabIndex = 17
        Me.CtrlOPCBag10.TagName = "LU_Track[12,0]"
        Me.CtrlOPCBag10.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag11
        '
        Me.CtrlOPCBag11.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag11.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag11.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag11.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag11.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag11.Category = 88
        Me.CtrlOPCBag11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag11.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag11.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag11.Location = New System.Drawing.Point(549, 87)
        Me.CtrlOPCBag11.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag11.Name = "CtrlOPCBag11"
        Me.CtrlOPCBag11.PLC_Bag_ID = 0
        Me.CtrlOPCBag11.PlcName = Nothing
        Me.CtrlOPCBag11.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag11.TabIndex = 16
        Me.CtrlOPCBag11.TagName = "Bins[12]"
        Me.CtrlOPCBag11.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag12
        '
        Me.CtrlOPCBag12.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag12.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag12.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag12.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag12.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag12.Category = 88
        Me.CtrlOPCBag12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag12.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag12.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag12.Location = New System.Drawing.Point(549, 59)
        Me.CtrlOPCBag12.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag12.Name = "CtrlOPCBag12"
        Me.CtrlOPCBag12.PLC_Bag_ID = 0
        Me.CtrlOPCBag12.PlcName = Nothing
        Me.CtrlOPCBag12.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag12.TabIndex = 15
        Me.CtrlOPCBag12.TagName = "LU_Track[12,2]"
        Me.CtrlOPCBag12.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag13
        '
        Me.CtrlOPCBag13.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag13.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag13.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag13.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag13.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag13.Category = 88
        Me.CtrlOPCBag13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag13.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag13.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag13.Location = New System.Drawing.Point(620, 131)
        Me.CtrlOPCBag13.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag13.Name = "CtrlOPCBag13"
        Me.CtrlOPCBag13.PLC_Bag_ID = 0
        Me.CtrlOPCBag13.PlcName = Nothing
        Me.CtrlOPCBag13.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag13.TabIndex = 14
        Me.CtrlOPCBag13.TagName = "LU_Track[14,0]"
        Me.CtrlOPCBag13.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag14
        '
        Me.CtrlOPCBag14.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag14.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag14.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag14.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag14.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag14.Category = 88
        Me.CtrlOPCBag14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag14.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag14.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag14.Location = New System.Drawing.Point(620, 87)
        Me.CtrlOPCBag14.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag14.Name = "CtrlOPCBag14"
        Me.CtrlOPCBag14.PLC_Bag_ID = 0
        Me.CtrlOPCBag14.PlcName = Nothing
        Me.CtrlOPCBag14.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag14.TabIndex = 13
        Me.CtrlOPCBag14.TagName = "Bins[14]"
        Me.CtrlOPCBag14.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag15
        '
        Me.CtrlOPCBag15.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag15.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag15.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag15.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag15.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag15.Category = 88
        Me.CtrlOPCBag15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag15.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag15.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag15.Location = New System.Drawing.Point(620, 59)
        Me.CtrlOPCBag15.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag15.Name = "CtrlOPCBag15"
        Me.CtrlOPCBag15.PLC_Bag_ID = 0
        Me.CtrlOPCBag15.PlcName = Nothing
        Me.CtrlOPCBag15.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag15.TabIndex = 12
        Me.CtrlOPCBag15.TagName = "LU_Track[14,2]"
        Me.CtrlOPCBag15.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag16
        '
        Me.CtrlOPCBag16.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag16.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag16.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag16.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag16.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag16.Category = 88
        Me.CtrlOPCBag16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag16.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag16.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag16.Location = New System.Drawing.Point(585, 131)
        Me.CtrlOPCBag16.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag16.Name = "CtrlOPCBag16"
        Me.CtrlOPCBag16.PLC_Bag_ID = 0
        Me.CtrlOPCBag16.PlcName = Nothing
        Me.CtrlOPCBag16.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag16.TabIndex = 11
        Me.CtrlOPCBag16.TagName = "LU_Track[13,0]"
        Me.CtrlOPCBag16.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag17
        '
        Me.CtrlOPCBag17.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag17.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag17.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag17.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag17.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag17.Category = 88
        Me.CtrlOPCBag17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag17.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag17.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag17.Location = New System.Drawing.Point(585, 87)
        Me.CtrlOPCBag17.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag17.Name = "CtrlOPCBag17"
        Me.CtrlOPCBag17.PLC_Bag_ID = 0
        Me.CtrlOPCBag17.PlcName = Nothing
        Me.CtrlOPCBag17.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag17.TabIndex = 10
        Me.CtrlOPCBag17.TagName = "Bins[13]"
        Me.CtrlOPCBag17.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag18
        '
        Me.CtrlOPCBag18.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag18.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag18.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag18.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag18.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag18.Category = 88
        Me.CtrlOPCBag18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag18.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag18.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag18.Location = New System.Drawing.Point(585, 59)
        Me.CtrlOPCBag18.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag18.Name = "CtrlOPCBag18"
        Me.CtrlOPCBag18.PLC_Bag_ID = 0
        Me.CtrlOPCBag18.PlcName = Nothing
        Me.CtrlOPCBag18.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag18.TabIndex = 9
        Me.CtrlOPCBag18.TagName = "LU_Track[13,2]"
        Me.CtrlOPCBag18.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag7
        '
        Me.CtrlOPCBag7.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag7.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag7.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag7.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag7.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag7.Category = 88
        Me.CtrlOPCBag7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag7.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag7.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag7.Location = New System.Drawing.Point(660, 131)
        Me.CtrlOPCBag7.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag7.Name = "CtrlOPCBag7"
        Me.CtrlOPCBag7.PLC_Bag_ID = 0
        Me.CtrlOPCBag7.PlcName = Nothing
        Me.CtrlOPCBag7.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag7.TabIndex = 8
        Me.CtrlOPCBag7.TagName = "LU_Track[15,0]"
        Me.CtrlOPCBag7.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag8
        '
        Me.CtrlOPCBag8.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag8.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag8.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag8.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag8.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag8.Category = 88
        Me.CtrlOPCBag8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag8.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag8.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag8.Location = New System.Drawing.Point(660, 87)
        Me.CtrlOPCBag8.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag8.Name = "CtrlOPCBag8"
        Me.CtrlOPCBag8.PLC_Bag_ID = 0
        Me.CtrlOPCBag8.PlcName = Nothing
        Me.CtrlOPCBag8.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag8.TabIndex = 7
        Me.CtrlOPCBag8.TagName = "Bins[15]"
        Me.CtrlOPCBag8.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag9
        '
        Me.CtrlOPCBag9.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag9.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag9.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag9.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag9.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag9.Category = 88
        Me.CtrlOPCBag9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag9.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag9.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag9.Location = New System.Drawing.Point(660, 59)
        Me.CtrlOPCBag9.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag9.Name = "CtrlOPCBag9"
        Me.CtrlOPCBag9.PLC_Bag_ID = 0
        Me.CtrlOPCBag9.PlcName = Nothing
        Me.CtrlOPCBag9.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag9.TabIndex = 6
        Me.CtrlOPCBag9.TagName = "LU_Track[15,2]"
        Me.CtrlOPCBag9.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag4
        '
        Me.CtrlOPCBag4.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag4.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag4.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag4.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag4.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag4.Category = 88
        Me.CtrlOPCBag4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag4.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag4.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag4.Location = New System.Drawing.Point(732, 131)
        Me.CtrlOPCBag4.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag4.Name = "CtrlOPCBag4"
        Me.CtrlOPCBag4.PLC_Bag_ID = 0
        Me.CtrlOPCBag4.PlcName = Nothing
        Me.CtrlOPCBag4.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag4.TabIndex = 5
        Me.CtrlOPCBag4.TagName = "LU_Track[17,0]"
        Me.CtrlOPCBag4.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag5
        '
        Me.CtrlOPCBag5.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag5.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag5.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag5.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag5.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag5.Category = 88
        Me.CtrlOPCBag5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag5.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag5.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag5.Location = New System.Drawing.Point(732, 87)
        Me.CtrlOPCBag5.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag5.Name = "CtrlOPCBag5"
        Me.CtrlOPCBag5.PLC_Bag_ID = 0
        Me.CtrlOPCBag5.PlcName = Nothing
        Me.CtrlOPCBag5.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag5.TabIndex = 4
        Me.CtrlOPCBag5.TagName = "Bins[17]"
        Me.CtrlOPCBag5.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag6
        '
        Me.CtrlOPCBag6.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag6.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag6.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag6.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag6.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag6.Category = 88
        Me.CtrlOPCBag6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag6.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag6.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag6.Location = New System.Drawing.Point(732, 59)
        Me.CtrlOPCBag6.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag6.Name = "CtrlOPCBag6"
        Me.CtrlOPCBag6.PLC_Bag_ID = 0
        Me.CtrlOPCBag6.PlcName = Nothing
        Me.CtrlOPCBag6.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag6.TabIndex = 3
        Me.CtrlOPCBag6.TagName = "LU_Track[17,2]"
        Me.CtrlOPCBag6.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag3
        '
        Me.CtrlOPCBag3.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag3.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag3.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag3.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag3.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag3.Category = 88
        Me.CtrlOPCBag3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag3.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag3.Location = New System.Drawing.Point(696, 131)
        Me.CtrlOPCBag3.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag3.Name = "CtrlOPCBag3"
        Me.CtrlOPCBag3.PLC_Bag_ID = 0
        Me.CtrlOPCBag3.PlcName = Nothing
        Me.CtrlOPCBag3.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag3.TabIndex = 2
        Me.CtrlOPCBag3.TagName = "LU_Track[16,0]"
        Me.CtrlOPCBag3.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag2
        '
        Me.CtrlOPCBag2.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag2.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag2.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag2.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag2.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag2.Category = 88
        Me.CtrlOPCBag2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag2.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag2.Location = New System.Drawing.Point(696, 87)
        Me.CtrlOPCBag2.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag2.Name = "CtrlOPCBag2"
        Me.CtrlOPCBag2.PLC_Bag_ID = 0
        Me.CtrlOPCBag2.PlcName = Nothing
        Me.CtrlOPCBag2.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag2.TabIndex = 1
        Me.CtrlOPCBag2.TagName = "Bins[16]"
        Me.CtrlOPCBag2.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag1
        '
        Me.CtrlOPCBag1.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag1.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag1.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag1.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag1.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag1.Category = 88
        Me.CtrlOPCBag1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag1.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag1.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag1.Location = New System.Drawing.Point(696, 59)
        Me.CtrlOPCBag1.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag1.Name = "CtrlOPCBag1"
        Me.CtrlOPCBag1.PLC_Bag_ID = 0
        Me.CtrlOPCBag1.PlcName = Nothing
        Me.CtrlOPCBag1.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag1.TabIndex = 0
        Me.CtrlOPCBag1.TagName = "LU_Track[16,2]"
        Me.CtrlOPCBag1.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag72
        '
        Me.CtrlOPCBag72.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag72.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag72.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag72.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag72.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag72.Category = 88
        Me.CtrlOPCBag72.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag72.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag72.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag72.Location = New System.Drawing.Point(732, 293)
        Me.CtrlOPCBag72.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag72.Name = "CtrlOPCBag72"
        Me.CtrlOPCBag72.PLC_Bag_ID = 0
        Me.CtrlOPCBag72.PlcName = Nothing
        Me.CtrlOPCBag72.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag72.TabIndex = 54
        Me.CtrlOPCBag72.TagName = "Bins[1]"
        Me.CtrlOPCBag72.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag71
        '
        Me.CtrlOPCBag71.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag71.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag71.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag71.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag71.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag71.Category = 88
        Me.CtrlOPCBag71.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag71.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag71.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag71.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag71.Location = New System.Drawing.Point(732, 321)
        Me.CtrlOPCBag71.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag71.Name = "CtrlOPCBag71"
        Me.CtrlOPCBag71.PLC_Bag_ID = 0
        Me.CtrlOPCBag71.PlcName = Nothing
        Me.CtrlOPCBag71.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag71.TabIndex = 55
        Me.CtrlOPCBag71.TagName = "LU_Track[1,2]"
        Me.CtrlOPCBag71.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag64
        '
        Me.CtrlOPCBag64.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag64.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag64.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag64.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag64.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag64.Category = 88
        Me.CtrlOPCBag64.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag64.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag64.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag64.Location = New System.Drawing.Point(677, 293)
        Me.CtrlOPCBag64.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag64.Name = "CtrlOPCBag64"
        Me.CtrlOPCBag64.PLC_Bag_ID = 0
        Me.CtrlOPCBag64.PlcName = Nothing
        Me.CtrlOPCBag64.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag64.TabIndex = 62
        Me.CtrlOPCBag64.TagName = "Bins[2]"
        Me.CtrlOPCBag64.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag63
        '
        Me.CtrlOPCBag63.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag63.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag63.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag63.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag63.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag63.Category = 88
        Me.CtrlOPCBag63.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag63.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag63.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag63.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag63.Location = New System.Drawing.Point(677, 321)
        Me.CtrlOPCBag63.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag63.Name = "CtrlOPCBag63"
        Me.CtrlOPCBag63.PLC_Bag_ID = 0
        Me.CtrlOPCBag63.PlcName = Nothing
        Me.CtrlOPCBag63.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag63.TabIndex = 63
        Me.CtrlOPCBag63.TagName = "LU_Track[2,2]"
        Me.CtrlOPCBag63.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag62
        '
        Me.CtrlOPCBag62.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag62.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag62.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag62.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag62.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag62.Category = 88
        Me.CtrlOPCBag62.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag62.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag62.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag62.Location = New System.Drawing.Point(621, 293)
        Me.CtrlOPCBag62.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag62.Name = "CtrlOPCBag62"
        Me.CtrlOPCBag62.PLC_Bag_ID = 0
        Me.CtrlOPCBag62.PlcName = Nothing
        Me.CtrlOPCBag62.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag62.TabIndex = 64
        Me.CtrlOPCBag62.TagName = "Bins[3]"
        Me.CtrlOPCBag62.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag61
        '
        Me.CtrlOPCBag61.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag61.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag61.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag61.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag61.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag61.Category = 88
        Me.CtrlOPCBag61.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag61.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag61.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag61.Location = New System.Drawing.Point(621, 321)
        Me.CtrlOPCBag61.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag61.Name = "CtrlOPCBag61"
        Me.CtrlOPCBag61.PLC_Bag_ID = 0
        Me.CtrlOPCBag61.PlcName = Nothing
        Me.CtrlOPCBag61.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag61.TabIndex = 65
        Me.CtrlOPCBag61.TagName = "LU_Track[3,2]"
        Me.CtrlOPCBag61.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag60
        '
        Me.CtrlOPCBag60.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag60.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag60.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag60.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag60.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag60.Category = 88
        Me.CtrlOPCBag60.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag60.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag60.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag60.Location = New System.Drawing.Point(567, 293)
        Me.CtrlOPCBag60.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag60.Name = "CtrlOPCBag60"
        Me.CtrlOPCBag60.PLC_Bag_ID = 0
        Me.CtrlOPCBag60.PlcName = Nothing
        Me.CtrlOPCBag60.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag60.TabIndex = 66
        Me.CtrlOPCBag60.TagName = "Bins[4]"
        Me.CtrlOPCBag60.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag59
        '
        Me.CtrlOPCBag59.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag59.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag59.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag59.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag59.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag59.Category = 88
        Me.CtrlOPCBag59.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag59.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag59.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag59.Location = New System.Drawing.Point(567, 321)
        Me.CtrlOPCBag59.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag59.Name = "CtrlOPCBag59"
        Me.CtrlOPCBag59.PLC_Bag_ID = 0
        Me.CtrlOPCBag59.PlcName = Nothing
        Me.CtrlOPCBag59.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag59.TabIndex = 67
        Me.CtrlOPCBag59.TagName = "LU_Track[4,2]"
        Me.CtrlOPCBag59.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag80
        '
        Me.CtrlOPCBag80.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag80.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag80.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag80.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag80.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag80.Category = 88
        Me.CtrlOPCBag80.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag80.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag80.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag80.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag80.Location = New System.Drawing.Point(512, 293)
        Me.CtrlOPCBag80.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag80.Name = "CtrlOPCBag80"
        Me.CtrlOPCBag80.PLC_Bag_ID = 0
        Me.CtrlOPCBag80.PlcName = Nothing
        Me.CtrlOPCBag80.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag80.TabIndex = 70
        Me.CtrlOPCBag80.TagName = "Bins[5]"
        Me.CtrlOPCBag80.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag79
        '
        Me.CtrlOPCBag79.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag79.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag79.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag79.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag79.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag79.Category = 88
        Me.CtrlOPCBag79.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag79.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag79.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag79.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag79.Location = New System.Drawing.Point(512, 321)
        Me.CtrlOPCBag79.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag79.Name = "CtrlOPCBag79"
        Me.CtrlOPCBag79.PLC_Bag_ID = 0
        Me.CtrlOPCBag79.PlcName = Nothing
        Me.CtrlOPCBag79.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag79.TabIndex = 71
        Me.CtrlOPCBag79.TagName = "LU_Track[5,2]"
        Me.CtrlOPCBag79.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag56
        '
        Me.CtrlOPCBag56.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag56.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag56.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag56.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag56.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag56.Category = 88
        Me.CtrlOPCBag56.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag56.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag56.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag56.Location = New System.Drawing.Point(456, 293)
        Me.CtrlOPCBag56.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag56.Name = "CtrlOPCBag56"
        Me.CtrlOPCBag56.PLC_Bag_ID = 0
        Me.CtrlOPCBag56.PlcName = Nothing
        Me.CtrlOPCBag56.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag56.TabIndex = 78
        Me.CtrlOPCBag56.TagName = "Bins[6]"
        Me.CtrlOPCBag56.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag55
        '
        Me.CtrlOPCBag55.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag55.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag55.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag55.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag55.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag55.Category = 88
        Me.CtrlOPCBag55.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag55.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag55.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag55.Location = New System.Drawing.Point(456, 321)
        Me.CtrlOPCBag55.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag55.Name = "CtrlOPCBag55"
        Me.CtrlOPCBag55.PLC_Bag_ID = 0
        Me.CtrlOPCBag55.PlcName = Nothing
        Me.CtrlOPCBag55.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag55.TabIndex = 79
        Me.CtrlOPCBag55.TagName = "LU_Track[6,2]"
        Me.CtrlOPCBag55.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag82
        '
        Me.CtrlOPCBag82.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag82.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag82.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag82.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag82.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag82.Category = 88
        Me.CtrlOPCBag82.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag82.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag82.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag82.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag82.Location = New System.Drawing.Point(401, 293)
        Me.CtrlOPCBag82.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag82.Name = "CtrlOPCBag82"
        Me.CtrlOPCBag82.PLC_Bag_ID = 0
        Me.CtrlOPCBag82.PlcName = Nothing
        Me.CtrlOPCBag82.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag82.TabIndex = 80
        Me.CtrlOPCBag82.TagName = "Bins[7]"
        Me.CtrlOPCBag82.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag81
        '
        Me.CtrlOPCBag81.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag81.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag81.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag81.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag81.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag81.Category = 88
        Me.CtrlOPCBag81.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag81.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag81.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag81.Location = New System.Drawing.Point(401, 321)
        Me.CtrlOPCBag81.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag81.Name = "CtrlOPCBag81"
        Me.CtrlOPCBag81.PLC_Bag_ID = 0
        Me.CtrlOPCBag81.PlcName = Nothing
        Me.CtrlOPCBag81.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag81.TabIndex = 81
        Me.CtrlOPCBag81.TagName = "LU_Track[7,2]"
        Me.CtrlOPCBag81.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag89
        '
        Me.CtrlOPCBag89.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag89.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag89.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag89.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag89.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag89.Category = 88
        Me.CtrlOPCBag89.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag89.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag89.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag89.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag89.Location = New System.Drawing.Point(732, 250)
        Me.CtrlOPCBag89.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag89.Name = "CtrlOPCBag89"
        Me.CtrlOPCBag89.PLC_Bag_ID = 0
        Me.CtrlOPCBag89.PlcName = Nothing
        Me.CtrlOPCBag89.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag89.TabIndex = 82
        Me.CtrlOPCBag89.TagName = "LU_Track[1,0]"
        Me.CtrlOPCBag89.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag88
        '
        Me.CtrlOPCBag88.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag88.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag88.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag88.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag88.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag88.Category = 88
        Me.CtrlOPCBag88.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag88.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag88.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag88.Location = New System.Drawing.Point(677, 250)
        Me.CtrlOPCBag88.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag88.Name = "CtrlOPCBag88"
        Me.CtrlOPCBag88.PLC_Bag_ID = 0
        Me.CtrlOPCBag88.PlcName = Nothing
        Me.CtrlOPCBag88.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag88.TabIndex = 83
        Me.CtrlOPCBag88.TagName = "LU_Track[2,0]"
        Me.CtrlOPCBag88.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag87
        '
        Me.CtrlOPCBag87.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag87.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag87.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag87.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag87.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag87.Category = 88
        Me.CtrlOPCBag87.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag87.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag87.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag87.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag87.Location = New System.Drawing.Point(621, 250)
        Me.CtrlOPCBag87.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag87.Name = "CtrlOPCBag87"
        Me.CtrlOPCBag87.PLC_Bag_ID = 0
        Me.CtrlOPCBag87.PlcName = Nothing
        Me.CtrlOPCBag87.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag87.TabIndex = 84
        Me.CtrlOPCBag87.TagName = "LU_Track[3,0]"
        Me.CtrlOPCBag87.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag86
        '
        Me.CtrlOPCBag86.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag86.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag86.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag86.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag86.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag86.Category = 88
        Me.CtrlOPCBag86.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag86.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag86.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag86.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag86.Location = New System.Drawing.Point(567, 250)
        Me.CtrlOPCBag86.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag86.Name = "CtrlOPCBag86"
        Me.CtrlOPCBag86.PLC_Bag_ID = 0
        Me.CtrlOPCBag86.PlcName = Nothing
        Me.CtrlOPCBag86.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag86.TabIndex = 85
        Me.CtrlOPCBag86.TagName = "LU_Track[4,0]"
        Me.CtrlOPCBag86.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag85
        '
        Me.CtrlOPCBag85.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag85.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag85.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag85.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag85.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag85.Category = 88
        Me.CtrlOPCBag85.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag85.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag85.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag85.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag85.Location = New System.Drawing.Point(512, 250)
        Me.CtrlOPCBag85.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag85.Name = "CtrlOPCBag85"
        Me.CtrlOPCBag85.PLC_Bag_ID = 0
        Me.CtrlOPCBag85.PlcName = Nothing
        Me.CtrlOPCBag85.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag85.TabIndex = 86
        Me.CtrlOPCBag85.TagName = "LU_Track[5,0]"
        Me.CtrlOPCBag85.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag84
        '
        Me.CtrlOPCBag84.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag84.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag84.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag84.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag84.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag84.Category = 88
        Me.CtrlOPCBag84.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag84.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag84.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag84.Location = New System.Drawing.Point(456, 250)
        Me.CtrlOPCBag84.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag84.Name = "CtrlOPCBag84"
        Me.CtrlOPCBag84.PLC_Bag_ID = 0
        Me.CtrlOPCBag84.PlcName = Nothing
        Me.CtrlOPCBag84.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag84.TabIndex = 87
        Me.CtrlOPCBag84.TagName = "LU_Track[6,0]"
        Me.CtrlOPCBag84.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag83
        '
        Me.CtrlOPCBag83.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag83.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag83.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag83.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag83.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag83.Category = 88
        Me.CtrlOPCBag83.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag83.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOPCBag83.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag83.GroupName = "Classified_Sorting"
        Me.CtrlOPCBag83.Location = New System.Drawing.Point(401, 250)
        Me.CtrlOPCBag83.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag83.Name = "CtrlOPCBag83"
        Me.CtrlOPCBag83.PLC_Bag_ID = 0
        Me.CtrlOPCBag83.PlcName = Nothing
        Me.CtrlOPCBag83.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag83.TabIndex = 88
        Me.CtrlOPCBag83.TagName = "LU_Track[7,0]"
        Me.CtrlOPCBag83.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton27
        '
        Me.CtrlOPCBagAddButton27.AllowDrop = True
        Me.CtrlOPCBagAddButton27.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton27.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton27.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton27.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton27.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton27.Location = New System.Drawing.Point(684, 235)
        Me.CtrlOPCBagAddButton27.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton27.Name = "CtrlOPCBagAddButton27"
        Me.CtrlOPCBagAddButton27.PlcName = Nothing
        Me.CtrlOPCBagAddButton27.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton27.TabIndex = 150
        Me.CtrlOPCBagAddButton27.TagName = "LU_Track[2,0]"
        Me.CtrlOPCBagAddButton27.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton26
        '
        Me.CtrlOPCBagAddButton26.AllowDrop = True
        Me.CtrlOPCBagAddButton26.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton26.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton26.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton26.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton26.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton26.Location = New System.Drawing.Point(738, 235)
        Me.CtrlOPCBagAddButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton26.Name = "CtrlOPCBagAddButton26"
        Me.CtrlOPCBagAddButton26.PlcName = Nothing
        Me.CtrlOPCBagAddButton26.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton26.TabIndex = 151
        Me.CtrlOPCBagAddButton26.TagName = "LU_Track[1,0]"
        Me.CtrlOPCBagAddButton26.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton25
        '
        Me.CtrlOPCBagAddButton25.AllowDrop = True
        Me.CtrlOPCBagAddButton25.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton25.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton25.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton25.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton25.Location = New System.Drawing.Point(627, 235)
        Me.CtrlOPCBagAddButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton25.Name = "CtrlOPCBagAddButton25"
        Me.CtrlOPCBagAddButton25.PlcName = Nothing
        Me.CtrlOPCBagAddButton25.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton25.TabIndex = 152
        Me.CtrlOPCBagAddButton25.TagName = "LU_Track[3,0]"
        Me.CtrlOPCBagAddButton25.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton24
        '
        Me.CtrlOPCBagAddButton24.AllowDrop = True
        Me.CtrlOPCBagAddButton24.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton24.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton24.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton24.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton24.Location = New System.Drawing.Point(519, 235)
        Me.CtrlOPCBagAddButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton24.Name = "CtrlOPCBagAddButton24"
        Me.CtrlOPCBagAddButton24.PlcName = Nothing
        Me.CtrlOPCBagAddButton24.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton24.TabIndex = 153
        Me.CtrlOPCBagAddButton24.TagName = "LU_Track[5,0]"
        Me.CtrlOPCBagAddButton24.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton23
        '
        Me.CtrlOPCBagAddButton23.AllowDrop = True
        Me.CtrlOPCBagAddButton23.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton23.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton23.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton23.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton23.Location = New System.Drawing.Point(574, 235)
        Me.CtrlOPCBagAddButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton23.Name = "CtrlOPCBagAddButton23"
        Me.CtrlOPCBagAddButton23.PlcName = Nothing
        Me.CtrlOPCBagAddButton23.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton23.TabIndex = 154
        Me.CtrlOPCBagAddButton23.TagName = "LU_Track[4,0]"
        Me.CtrlOPCBagAddButton23.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton22
        '
        Me.CtrlOPCBagAddButton22.AllowDrop = True
        Me.CtrlOPCBagAddButton22.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton22.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton22.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton22.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton22.Location = New System.Drawing.Point(463, 235)
        Me.CtrlOPCBagAddButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton22.Name = "CtrlOPCBagAddButton22"
        Me.CtrlOPCBagAddButton22.PlcName = Nothing
        Me.CtrlOPCBagAddButton22.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton22.TabIndex = 155
        Me.CtrlOPCBagAddButton22.TagName = "LU_Track[6,0]"
        Me.CtrlOPCBagAddButton22.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton21
        '
        Me.CtrlOPCBagAddButton21.AllowDrop = True
        Me.CtrlOPCBagAddButton21.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton21.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton21.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton21.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton21.Location = New System.Drawing.Point(409, 235)
        Me.CtrlOPCBagAddButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton21.Name = "CtrlOPCBagAddButton21"
        Me.CtrlOPCBagAddButton21.PlcName = Nothing
        Me.CtrlOPCBagAddButton21.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton21.TabIndex = 156
        Me.CtrlOPCBagAddButton21.TagName = "LU_Track[7,0]"
        Me.CtrlOPCBagAddButton21.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton41
        '
        Me.CtrlOPCBagAddButton41.AllowDrop = True
        Me.CtrlOPCBagAddButton41.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton41.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton41.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton41.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton41.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton41.Location = New System.Drawing.Point(463, 277)
        Me.CtrlOPCBagAddButton41.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton41.Name = "CtrlOPCBagAddButton41"
        Me.CtrlOPCBagAddButton41.PlcName = Nothing
        Me.CtrlOPCBagAddButton41.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton41.TabIndex = 161
        Me.CtrlOPCBagAddButton41.TagName = "Bins[6]"
        Me.CtrlOPCBagAddButton41.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton40
        '
        Me.CtrlOPCBagAddButton40.AllowDrop = True
        Me.CtrlOPCBagAddButton40.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton40.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton40.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton40.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton40.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton40.Location = New System.Drawing.Point(519, 277)
        Me.CtrlOPCBagAddButton40.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton40.Name = "CtrlOPCBagAddButton40"
        Me.CtrlOPCBagAddButton40.PlcName = Nothing
        Me.CtrlOPCBagAddButton40.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton40.TabIndex = 162
        Me.CtrlOPCBagAddButton40.TagName = "Bins[5]"
        Me.CtrlOPCBagAddButton40.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton39
        '
        Me.CtrlOPCBagAddButton39.AllowDrop = True
        Me.CtrlOPCBagAddButton39.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton39.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton39.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton39.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton39.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton39.Location = New System.Drawing.Point(408, 277)
        Me.CtrlOPCBagAddButton39.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton39.Name = "CtrlOPCBagAddButton39"
        Me.CtrlOPCBagAddButton39.PlcName = Nothing
        Me.CtrlOPCBagAddButton39.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton39.TabIndex = 163
        Me.CtrlOPCBagAddButton39.TagName = "Bins[7]"
        Me.CtrlOPCBagAddButton39.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton38
        '
        Me.CtrlOPCBagAddButton38.AllowDrop = True
        Me.CtrlOPCBagAddButton38.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton38.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton38.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton38.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton38.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton38.Location = New System.Drawing.Point(684, 277)
        Me.CtrlOPCBagAddButton38.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton38.Name = "CtrlOPCBagAddButton38"
        Me.CtrlOPCBagAddButton38.PlcName = Nothing
        Me.CtrlOPCBagAddButton38.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton38.TabIndex = 164
        Me.CtrlOPCBagAddButton38.TagName = "Bins[2]"
        Me.CtrlOPCBagAddButton38.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton37
        '
        Me.CtrlOPCBagAddButton37.AllowDrop = True
        Me.CtrlOPCBagAddButton37.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton37.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton37.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton37.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton37.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton37.Location = New System.Drawing.Point(738, 277)
        Me.CtrlOPCBagAddButton37.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton37.Name = "CtrlOPCBagAddButton37"
        Me.CtrlOPCBagAddButton37.PlcName = Nothing
        Me.CtrlOPCBagAddButton37.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton37.TabIndex = 165
        Me.CtrlOPCBagAddButton37.TagName = "Bins[1]"
        Me.CtrlOPCBagAddButton37.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton36
        '
        Me.CtrlOPCBagAddButton36.AllowDrop = True
        Me.CtrlOPCBagAddButton36.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton36.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton36.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton36.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton36.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton36.Location = New System.Drawing.Point(627, 277)
        Me.CtrlOPCBagAddButton36.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton36.Name = "CtrlOPCBagAddButton36"
        Me.CtrlOPCBagAddButton36.PlcName = Nothing
        Me.CtrlOPCBagAddButton36.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton36.TabIndex = 166
        Me.CtrlOPCBagAddButton36.TagName = "Bins[3]"
        Me.CtrlOPCBagAddButton36.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton35
        '
        Me.CtrlOPCBagAddButton35.AllowDrop = True
        Me.CtrlOPCBagAddButton35.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton35.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton35.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton35.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton35.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton35.Location = New System.Drawing.Point(574, 277)
        Me.CtrlOPCBagAddButton35.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton35.Name = "CtrlOPCBagAddButton35"
        Me.CtrlOPCBagAddButton35.PlcName = Nothing
        Me.CtrlOPCBagAddButton35.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton35.TabIndex = 167
        Me.CtrlOPCBagAddButton35.TagName = "Bins[4]"
        Me.CtrlOPCBagAddButton35.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag153
        '
        Me.CtrlOPCBag153.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag153.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag153.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag153.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag153.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag153.Category = 88
        Me.CtrlOPCBag153.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag153.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag153.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag153.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag153.Location = New System.Drawing.Point(1040, 213)
        Me.CtrlOPCBag153.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag153.Name = "CtrlOPCBag153"
        Me.CtrlOPCBag153.PLC_Bag_ID = 0
        Me.CtrlOPCBag153.PlcName = Nothing
        Me.CtrlOPCBag153.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag153.TabIndex = 226
        Me.CtrlOPCBag153.TagName = "VC_Track[6,1]"
        Me.CtrlOPCBag153.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBag150
        '
        Me.CtrlOPCBag150.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag150.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag150.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag150.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag150.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag150.Category = 88
        Me.CtrlOPCBag150.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag150.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOPCBag150.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag150.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOPCBag150.Location = New System.Drawing.Point(823, 209)
        Me.CtrlOPCBag150.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag150.Name = "CtrlOPCBag150"
        Me.CtrlOPCBag150.PLC_Bag_ID = 0
        Me.CtrlOPCBag150.PlcName = Nothing
        Me.CtrlOPCBag150.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag150.TabIndex = 227
        Me.CtrlOPCBag150.TagName = "VC_Track[6,4]"
        Me.CtrlOPCBag150.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcRailSequenceStep12
        '
        Me.CtrlOpcRailSequenceStep12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep12.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep12.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep12.Location = New System.Drawing.Point(775, 213)
        Me.CtrlOpcRailSequenceStep12.Name = "CtrlOpcRailSequenceStep12"
        Me.CtrlOpcRailSequenceStep12.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep12.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep12.SequenceID = 1032
        Me.CtrlOpcRailSequenceStep12.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep12.TabIndex = 242
        Me.CtrlOpcRailSequenceStep12.TagName = "SeqEmptyBags[1]"
        Me.CtrlOpcRailSequenceStep12.Text = "Empty"
        '
        'CtrlOPCBagAddButton94
        '
        Me.CtrlOPCBagAddButton94.AllowDrop = True
        Me.CtrlOPCBagAddButton94.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton94.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton94.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton94.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton94.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton94.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton94.Location = New System.Drawing.Point(996, 221)
        Me.CtrlOPCBagAddButton94.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton94.Name = "CtrlOPCBagAddButton94"
        Me.CtrlOPCBagAddButton94.PlcName = Nothing
        Me.CtrlOPCBagAddButton94.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton94.TabIndex = 246
        Me.CtrlOPCBagAddButton94.TagName = "VC_Track[6,2]"
        Me.CtrlOPCBagAddButton94.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCBagAddButton99
        '
        Me.CtrlOPCBagAddButton99.AllowDrop = True
        Me.CtrlOPCBagAddButton99.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton99.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton99.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton99.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton99.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton99.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton99.Location = New System.Drawing.Point(1071, 219)
        Me.CtrlOPCBagAddButton99.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton99.Name = "CtrlOPCBagAddButton99"
        Me.CtrlOPCBagAddButton99.PlcName = Nothing
        Me.CtrlOPCBagAddButton99.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton99.TabIndex = 250
        Me.CtrlOPCBagAddButton99.TagName = "VC_Track[6,1]"
        Me.CtrlOPCBagAddButton99.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOPCShortTrip9
        '
        Me.CtrlOPCShortTrip9.BackColor = System.Drawing.Color.White
        Me.CtrlOPCShortTrip9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip9.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip9.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip9.Location = New System.Drawing.Point(1011, 221)
        Me.CtrlOPCShortTrip9.Name = "CtrlOPCShortTrip9"
        Me.CtrlOPCShortTrip9.PlcName = Nothing
        Me.CtrlOPCShortTrip9.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip9.TabIndex = 280
        Me.CtrlOPCShortTrip9.TagName = "Seq_Trip[94]"
        '
        'CtrlOPCShortTrip15
        '
        Me.CtrlOPCShortTrip15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCShortTrip15.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCShortTrip15.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOPCShortTrip15.Location = New System.Drawing.Point(1163, 221)
        Me.CtrlOPCShortTrip15.Name = "CtrlOPCShortTrip15"
        Me.CtrlOPCShortTrip15.PlcName = Nothing
        Me.CtrlOPCShortTrip15.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCShortTrip15.TabIndex = 286
        Me.CtrlOPCShortTrip15.TagName = "Seq_Trip[87]"
        '
        'CtrlOpcRailSequenceStep17
        '
        Me.CtrlOpcRailSequenceStep17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep17.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep17.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep17.Location = New System.Drawing.Point(1032, 268)
        Me.CtrlOpcRailSequenceStep17.Name = "CtrlOpcRailSequenceStep17"
        Me.CtrlOpcRailSequenceStep17.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep17.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep17.SequenceID = 1074
        Me.CtrlOpcRailSequenceStep17.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep17.TabIndex = 291
        Me.CtrlOpcRailSequenceStep17.TagName = "SeqVC[6]"
        Me.CtrlOpcRailSequenceStep17.Text = "VC6"
        '
        'CtrlOpcRailSequenceStep20
        '
        Me.CtrlOpcRailSequenceStep20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcRailSequenceStep20.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcRailSequenceStep20.GroupName = Nothing
        Me.CtrlOpcRailSequenceStep20.Location = New System.Drawing.Point(1146, 247)
        Me.CtrlOpcRailSequenceStep20.Name = "CtrlOpcRailSequenceStep20"
        Me.CtrlOpcRailSequenceStep20.PlcName = Nothing
        Me.CtrlOpcRailSequenceStep20.ReadOnlySeqeunce = False
        Me.CtrlOpcRailSequenceStep20.SequenceID = 1015
        Me.CtrlOpcRailSequenceStep20.Size = New System.Drawing.Size(44, 23)
        Me.CtrlOpcRailSequenceStep20.TabIndex = 292
        Me.CtrlOpcRailSequenceStep20.TagName = "gSeq[16]"
        Me.CtrlOpcRailSequenceStep20.Text = ">>>"
        '
        'CtrlLINTAlarmIcon3
        '
        Me.CtrlLINTAlarmIcon3.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon3.Location = New System.Drawing.Point(779, 237)
        Me.CtrlLINTAlarmIcon3.Name = "CtrlLINTAlarmIcon3"
        Me.CtrlLINTAlarmIcon3.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon3.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon3.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon3.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon3.TabIndex = 295
        '
        'CtrlLINTAlarmIcon10
        '
        Me.CtrlLINTAlarmIcon10.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon10.Location = New System.Drawing.Point(1035, 292)
        Me.CtrlLINTAlarmIcon10.Name = "CtrlLINTAlarmIcon10"
        Me.CtrlLINTAlarmIcon10.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon10.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon10.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon10.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon10.TabIndex = 303
        '
        'CtrlOpcTsaBag2
        '
        Me.CtrlOpcTsaBag2.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag2.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag2.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag2.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag2.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag2.Category = 88
        Me.CtrlOpcTsaBag2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOpcTsaBag2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag2.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOpcTsaBag2.Location = New System.Drawing.Point(851, 209)
        Me.CtrlOpcTsaBag2.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag2.Name = "CtrlOpcTsaBag2"
        Me.CtrlOpcTsaBag2.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag2.PlcName = Nothing
        Me.CtrlOpcTsaBag2.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag2.TabIndex = 414
        Me.CtrlOpcTsaBag2.TagName = "VC_Track[6,3]"
        Me.CtrlOpcTsaBag2.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag3
        '
        Me.CtrlOpcTsaBag3.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag3.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag3.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag3.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag3.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag3.Category = 88
        Me.CtrlOpcTsaBag3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "EmptyBagReturn", True))
        Me.CtrlOpcTsaBag3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag3.GroupName = "Classified_Sorting_Empty_Bag_Return"
        Me.CtrlOpcTsaBag3.Location = New System.Drawing.Point(967, 210)
        Me.CtrlOpcTsaBag3.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag3.Name = "CtrlOpcTsaBag3"
        Me.CtrlOpcTsaBag3.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag3.PlcName = Nothing
        Me.CtrlOpcTsaBag3.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag3.TabIndex = 415
        Me.CtrlOpcTsaBag3.TagName = "VC_Track[6,2]"
        Me.CtrlOpcTsaBag3.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaRailSequenceStep2
        '
        Me.CtrlOpcTsaRailSequenceStep2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep2.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep2.Location = New System.Drawing.Point(896, 234)
        Me.CtrlOpcTsaRailSequenceStep2.Name = "CtrlOpcTsaRailSequenceStep2"
        Me.CtrlOpcTsaRailSequenceStep2.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep2.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep2.SequenceID = 1206
        Me.CtrlOpcTsaRailSequenceStep2.Size = New System.Drawing.Size(65, 23)
        Me.CtrlOpcTsaRailSequenceStep2.TabIndex = 418
        Me.CtrlOpcTsaRailSequenceStep2.TagName = "VC6_Release_SEQ"
        Me.CtrlOpcTsaRailSequenceStep2.Text = "Buffer 6"
        '
        'CtrlOpcTsaRailSequenceStep3
        '
        Me.CtrlOpcTsaRailSequenceStep3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep3.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep3.Location = New System.Drawing.Point(865, 587)
        Me.CtrlOpcTsaRailSequenceStep3.Name = "CtrlOpcTsaRailSequenceStep3"
        Me.CtrlOpcTsaRailSequenceStep3.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep3.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep3.SequenceID = 1207
        Me.CtrlOpcTsaRailSequenceStep3.Size = New System.Drawing.Size(65, 23)
        Me.CtrlOpcTsaRailSequenceStep3.TabIndex = 419
        Me.CtrlOpcTsaRailSequenceStep3.TagName = "VC7_Release_SEQ"
        Me.CtrlOpcTsaRailSequenceStep3.Text = "Buffer 7"
        '
        'CtrlOpcTsaRailSequenceStep4
        '
        Me.CtrlOpcTsaRailSequenceStep4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep4.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep4.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep4.Location = New System.Drawing.Point(865, 686)
        Me.CtrlOpcTsaRailSequenceStep4.Name = "CtrlOpcTsaRailSequenceStep4"
        Me.CtrlOpcTsaRailSequenceStep4.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep4.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep4.SequenceID = 1208
        Me.CtrlOpcTsaRailSequenceStep4.Size = New System.Drawing.Size(65, 23)
        Me.CtrlOpcTsaRailSequenceStep4.TabIndex = 420
        Me.CtrlOpcTsaRailSequenceStep4.TagName = "VC8_Release_SEQ"
        Me.CtrlOpcTsaRailSequenceStep4.Text = "Buffer 8"
        '
        'CtrlOPCSwitchGateButton1
        '
        Me.CtrlOPCSwitchGateButton1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCSwitchGateButton1.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCSwitchGateButton1.GroupName = Nothing
        Me.CtrlOPCSwitchGateButton1.Location = New System.Drawing.Point(860, 126)
        Me.CtrlOPCSwitchGateButton1.Name = "CtrlOPCSwitchGateButton1"
        Me.CtrlOPCSwitchGateButton1.PlcName = Nothing
        Me.CtrlOPCSwitchGateButton1.Size = New System.Drawing.Size(139, 22)
        Me.CtrlOPCSwitchGateButton1.TabIndex = 421
        Me.CtrlOPCSwitchGateButton1.TagName = "iHMI_VC5_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton1.TagToCompareTo = "iHMI_VC6_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton1.TextAfterActive = "VC5 Dual Feed Active"
        Me.CtrlOPCSwitchGateButton1.TextBeforeActive = "VC5 Dual Feed Inactive"
        '
        'CtrlOPCSwitchGateButton2
        '
        Me.CtrlOPCSwitchGateButton2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCSwitchGateButton2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCSwitchGateButton2.GroupName = Nothing
        Me.CtrlOPCSwitchGateButton2.Location = New System.Drawing.Point(860, 263)
        Me.CtrlOPCSwitchGateButton2.Name = "CtrlOPCSwitchGateButton2"
        Me.CtrlOPCSwitchGateButton2.PlcName = Nothing
        Me.CtrlOPCSwitchGateButton2.Size = New System.Drawing.Size(139, 22)
        Me.CtrlOPCSwitchGateButton2.TabIndex = 422
        Me.CtrlOPCSwitchGateButton2.TagName = "iHMI_VC6_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton2.TagToCompareTo = "iHMI_VC5_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton2.TextAfterActive = "VC6 Dual Feed Active"
        Me.CtrlOPCSwitchGateButton2.TextBeforeActive = "VC6 Dual Feed Inactive"
        '
        'CtrlOPCSwitchGateButton4
        '
        Me.CtrlOPCSwitchGateButton4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCSwitchGateButton4.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCSwitchGateButton4.GroupName = Nothing
        Me.CtrlOPCSwitchGateButton4.Location = New System.Drawing.Point(828, 715)
        Me.CtrlOPCSwitchGateButton4.Name = "CtrlOPCSwitchGateButton4"
        Me.CtrlOPCSwitchGateButton4.PlcName = Nothing
        Me.CtrlOPCSwitchGateButton4.Size = New System.Drawing.Size(139, 22)
        Me.CtrlOPCSwitchGateButton4.TabIndex = 424
        Me.CtrlOPCSwitchGateButton4.TagName = "iHMI_VC8_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton4.TagToCompareTo = "iHMI_VC7_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton4.TextAfterActive = "VC8 Dual Feed Active"
        Me.CtrlOPCSwitchGateButton4.TextBeforeActive = "VC8 Dual Feed Inactive"
        '
        'CtrlOPCSwitchGateButton3
        '
        Me.CtrlOPCSwitchGateButton3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCSwitchGateButton3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOPCSwitchGateButton3.GroupName = Nothing
        Me.CtrlOPCSwitchGateButton3.Location = New System.Drawing.Point(828, 559)
        Me.CtrlOPCSwitchGateButton3.Name = "CtrlOPCSwitchGateButton3"
        Me.CtrlOPCSwitchGateButton3.PlcName = Nothing
        Me.CtrlOPCSwitchGateButton3.Size = New System.Drawing.Size(139, 22)
        Me.CtrlOPCSwitchGateButton3.TabIndex = 425
        Me.CtrlOPCSwitchGateButton3.TagName = "iHMI_VC7_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton3.TagToCompareTo = "iHMI_VC8_Dual_Active_PB"
        Me.CtrlOPCSwitchGateButton3.TextAfterActive = "VC7 Dual Feed Active"
        Me.CtrlOPCSwitchGateButton3.TextBeforeActive = "VC7 Dual Feed Inactive"
        '
        'CtrlOpcBagAddButton118
        '
        Me.CtrlOpcBagAddButton118.AllowDrop = True
        Me.CtrlOpcBagAddButton118.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton118.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton118.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton118.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton118.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton118.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton118.Location = New System.Drawing.Point(852, 616)
        Me.CtrlOpcBagAddButton118.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton118.Name = "CtrlOpcBagAddButton118"
        Me.CtrlOpcBagAddButton118.PlcName = Nothing
        Me.CtrlOpcBagAddButton118.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton118.TabIndex = 426
        Me.CtrlOpcBagAddButton118.TagName = "VC_Track[7,4]"
        Me.CtrlOpcBagAddButton118.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton128
        '
        Me.CtrlOpcBagAddButton128.AllowDrop = True
        Me.CtrlOpcBagAddButton128.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton128.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton128.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton128.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton128.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton128.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton128.Location = New System.Drawing.Point(852, 656)
        Me.CtrlOpcBagAddButton128.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton128.Name = "CtrlOpcBagAddButton128"
        Me.CtrlOpcBagAddButton128.PlcName = Nothing
        Me.CtrlOpcBagAddButton128.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton128.TabIndex = 427
        Me.CtrlOpcBagAddButton128.TagName = "VC_Track[8,4]"
        Me.CtrlOpcBagAddButton128.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag5
        '
        Me.CtrlOpcTsaBag5.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag5.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag5.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag5.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag5.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag5.Category = 88
        Me.CtrlOpcTsaBag5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag5.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag5.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag5.Location = New System.Drawing.Point(253, 384)
        Me.CtrlOpcTsaBag5.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag5.Name = "CtrlOpcTsaBag5"
        Me.CtrlOpcTsaBag5.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag5.PlcName = Nothing
        Me.CtrlOpcTsaBag5.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag5.TabIndex = 428
        Me.CtrlOpcTsaBag5.TagName = "PLA_Track[7,1]"
        Me.CtrlOpcTsaBag5.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag6
        '
        Me.CtrlOpcTsaBag6.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag6.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag6.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag6.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag6.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag6.Category = 88
        Me.CtrlOpcTsaBag6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag6.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag6.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag6.Location = New System.Drawing.Point(305, 374)
        Me.CtrlOpcTsaBag6.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag6.Name = "CtrlOpcTsaBag6"
        Me.CtrlOpcTsaBag6.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag6.PlcName = Nothing
        Me.CtrlOpcTsaBag6.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag6.TabIndex = 429
        Me.CtrlOpcTsaBag6.TagName = "PLA_Track[7,0]"
        Me.CtrlOpcTsaBag6.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton101
        '
        Me.CtrlOpcBagAddButton101.AllowDrop = True
        Me.CtrlOpcBagAddButton101.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton101.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton101.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton101.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton101.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton101.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton101.Location = New System.Drawing.Point(333, 372)
        Me.CtrlOpcBagAddButton101.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton101.Name = "CtrlOpcBagAddButton101"
        Me.CtrlOpcBagAddButton101.PlcName = Nothing
        Me.CtrlOpcBagAddButton101.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton101.TabIndex = 430
        Me.CtrlOpcBagAddButton101.TagName = "PLA_Track[7,0]"
        Me.CtrlOpcBagAddButton101.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaRailSequenceStep5
        '
        Me.CtrlOpcTsaRailSequenceStep5.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep5.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep5.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep5.Location = New System.Drawing.Point(250, 431)
        Me.CtrlOpcTsaRailSequenceStep5.Name = "CtrlOpcTsaRailSequenceStep5"
        Me.CtrlOpcTsaRailSequenceStep5.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep5.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep5.SequenceID = 1218
        Me.CtrlOpcTsaRailSequenceStep5.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep5.TabIndex = 431
        Me.CtrlOpcTsaRailSequenceStep5.TagName = "SeqPLA[7]"
        Me.CtrlOpcTsaRailSequenceStep5.Text = "PLA 7"
        '
        'CtrlOpcTsaBag14
        '
        Me.CtrlOpcTsaBag14.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag14.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag14.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag14.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag14.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag14.Category = 88
        Me.CtrlOpcTsaBag14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag14.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag14.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag14.Location = New System.Drawing.Point(64, 260)
        Me.CtrlOpcTsaBag14.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag14.Name = "CtrlOpcTsaBag14"
        Me.CtrlOpcTsaBag14.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag14.PlcName = Nothing
        Me.CtrlOpcTsaBag14.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag14.TabIndex = 443
        Me.CtrlOpcTsaBag14.TagName = "StoreBuffer[19,2]"
        Me.CtrlOpcTsaBag14.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag15
        '
        Me.CtrlOpcTsaBag15.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag15.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag15.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag15.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag15.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag15.Category = 88
        Me.CtrlOpcTsaBag15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag15.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag15.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag15.Location = New System.Drawing.Point(64, 318)
        Me.CtrlOpcTsaBag15.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag15.Name = "CtrlOpcTsaBag15"
        Me.CtrlOpcTsaBag15.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag15.PlcName = Nothing
        Me.CtrlOpcTsaBag15.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag15.TabIndex = 445
        Me.CtrlOpcTsaBag15.TagName = "StoreBuffer[19,4]"
        Me.CtrlOpcTsaBag15.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag16
        '
        Me.CtrlOpcTsaBag16.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag16.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag16.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag16.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag16.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag16.Category = 88
        Me.CtrlOpcTsaBag16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag16.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag16.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag16.Location = New System.Drawing.Point(64, 289)
        Me.CtrlOpcTsaBag16.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag16.Name = "CtrlOpcTsaBag16"
        Me.CtrlOpcTsaBag16.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag16.PlcName = Nothing
        Me.CtrlOpcTsaBag16.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag16.TabIndex = 444
        Me.CtrlOpcTsaBag16.TagName = "StoreBuffer[19,3]"
        Me.CtrlOpcTsaBag16.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag17
        '
        Me.CtrlOpcTsaBag17.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag17.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag17.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag17.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag17.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag17.Category = 88
        Me.CtrlOpcTsaBag17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag17.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag17.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag17.Location = New System.Drawing.Point(64, 376)
        Me.CtrlOpcTsaBag17.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag17.Name = "CtrlOpcTsaBag17"
        Me.CtrlOpcTsaBag17.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag17.PlcName = Nothing
        Me.CtrlOpcTsaBag17.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag17.TabIndex = 447
        Me.CtrlOpcTsaBag17.TagName = "StoreBuffer[19,6]"
        Me.CtrlOpcTsaBag17.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag18
        '
        Me.CtrlOpcTsaBag18.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag18.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag18.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag18.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag18.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag18.Category = 88
        Me.CtrlOpcTsaBag18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag18.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag18.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag18.Location = New System.Drawing.Point(64, 347)
        Me.CtrlOpcTsaBag18.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag18.Name = "CtrlOpcTsaBag18"
        Me.CtrlOpcTsaBag18.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag18.PlcName = Nothing
        Me.CtrlOpcTsaBag18.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag18.TabIndex = 446
        Me.CtrlOpcTsaBag18.TagName = "StoreBuffer[19,5]"
        Me.CtrlOpcTsaBag18.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcShortTrip3
        '
        Me.CtrlOpcShortTrip3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcShortTrip3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOpcShortTrip3.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOpcShortTrip3.Location = New System.Drawing.Point(71, 407)
        Me.CtrlOpcShortTrip3.Name = "CtrlOpcShortTrip3"
        Me.CtrlOpcShortTrip3.PlcName = Nothing
        Me.CtrlOpcShortTrip3.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcShortTrip3.TabIndex = 448
        Me.CtrlOpcShortTrip3.TagName = "Seq_Trip[159]"
        '
        'CtrlOpcBagAddButton107
        '
        Me.CtrlOpcBagAddButton107.AllowDrop = True
        Me.CtrlOpcBagAddButton107.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton107.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton107.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton107.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton107.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton107.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton107.Location = New System.Drawing.Point(71, 424)
        Me.CtrlOpcBagAddButton107.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton107.Name = "CtrlOpcBagAddButton107"
        Me.CtrlOpcBagAddButton107.PlcName = Nothing
        Me.CtrlOpcBagAddButton107.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton107.TabIndex = 449
        Me.CtrlOpcBagAddButton107.TagName = "StoreBuffer[19,6]"
        Me.CtrlOpcBagAddButton107.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaRailSequenceStep8
        '
        Me.CtrlOpcTsaRailSequenceStep8.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep8.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep8.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep8.Location = New System.Drawing.Point(178, 406)
        Me.CtrlOpcTsaRailSequenceStep8.Name = "CtrlOpcTsaRailSequenceStep8"
        Me.CtrlOpcTsaRailSequenceStep8.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep8.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep8.SequenceID = 1221
        Me.CtrlOpcTsaRailSequenceStep8.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep8.TabIndex = 450
        Me.CtrlOpcTsaRailSequenceStep8.TagName = "SeqBD[1]"
        Me.CtrlOpcTsaRailSequenceStep8.Text = "BD1"
        '
        'CtrlOpcTsaRailSequenceStep9
        '
        Me.CtrlOpcTsaRailSequenceStep9.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep9.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep9.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep9.Location = New System.Drawing.Point(28, 488)
        Me.CtrlOpcTsaRailSequenceStep9.Name = "CtrlOpcTsaRailSequenceStep9"
        Me.CtrlOpcTsaRailSequenceStep9.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep9.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep9.SequenceID = 1223
        Me.CtrlOpcTsaRailSequenceStep9.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep9.TabIndex = 451
        Me.CtrlOpcTsaRailSequenceStep9.TagName = "SeqBD[3]"
        Me.CtrlOpcTsaRailSequenceStep9.Text = "BD3"
        '
        'CtrlOpcTsaBag20
        '
        Me.CtrlOpcTsaBag20.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag20.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag20.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag20.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag20.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag20.Category = 88
        Me.CtrlOpcTsaBag20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag20.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag20.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag20.Location = New System.Drawing.Point(84, 752)
        Me.CtrlOpcTsaBag20.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag20.Name = "CtrlOpcTsaBag20"
        Me.CtrlOpcTsaBag20.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag20.PlcName = Nothing
        Me.CtrlOpcTsaBag20.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag20.TabIndex = 452
        Me.CtrlOpcTsaBag20.TagName = "EL_Track[4,0]"
        Me.CtrlOpcTsaBag20.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag21
        '
        Me.CtrlOpcTsaBag21.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag21.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag21.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag21.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag21.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag21.Category = 88
        Me.CtrlOpcTsaBag21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag21.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag21.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag21.Location = New System.Drawing.Point(83, 613)
        Me.CtrlOpcTsaBag21.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag21.Name = "CtrlOpcTsaBag21"
        Me.CtrlOpcTsaBag21.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag21.PlcName = Nothing
        Me.CtrlOpcTsaBag21.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag21.TabIndex = 456
        Me.CtrlOpcTsaBag21.TagName = "StoreBuffer[18,3]"
        Me.CtrlOpcTsaBag21.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag22
        '
        Me.CtrlOpcTsaBag22.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag22.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag22.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag22.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag22.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag22.Category = 88
        Me.CtrlOpcTsaBag22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag22.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag22.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag22.Location = New System.Drawing.Point(83, 584)
        Me.CtrlOpcTsaBag22.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag22.Name = "CtrlOpcTsaBag22"
        Me.CtrlOpcTsaBag22.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag22.PlcName = Nothing
        Me.CtrlOpcTsaBag22.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag22.TabIndex = 455
        Me.CtrlOpcTsaBag22.TagName = "StoreBuffer[18,2]"
        Me.CtrlOpcTsaBag22.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag23
        '
        Me.CtrlOpcTsaBag23.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag23.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag23.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag23.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag23.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag23.Category = 88
        Me.CtrlOpcTsaBag23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag23.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag23.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag23.Location = New System.Drawing.Point(83, 555)
        Me.CtrlOpcTsaBag23.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag23.Name = "CtrlOpcTsaBag23"
        Me.CtrlOpcTsaBag23.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag23.PlcName = Nothing
        Me.CtrlOpcTsaBag23.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag23.TabIndex = 454
        Me.CtrlOpcTsaBag23.TagName = "StoreBuffer[18,1]"
        Me.CtrlOpcTsaBag23.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton108
        '
        Me.CtrlOpcBagAddButton108.AllowDrop = True
        Me.CtrlOpcBagAddButton108.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton108.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton108.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton108.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton108.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton108.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton108.Location = New System.Drawing.Point(90, 661)
        Me.CtrlOpcBagAddButton108.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton108.Name = "CtrlOpcBagAddButton108"
        Me.CtrlOpcBagAddButton108.PlcName = Nothing
        Me.CtrlOpcBagAddButton108.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton108.TabIndex = 458
        Me.CtrlOpcBagAddButton108.TagName = "StoreBuffer[18,3]"
        Me.CtrlOpcBagAddButton108.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcShortTrip4
        '
        Me.CtrlOpcShortTrip4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcShortTrip4.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOpcShortTrip4.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOpcShortTrip4.Location = New System.Drawing.Point(90, 644)
        Me.CtrlOpcShortTrip4.Name = "CtrlOpcShortTrip4"
        Me.CtrlOpcShortTrip4.PlcName = Nothing
        Me.CtrlOpcShortTrip4.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcShortTrip4.TabIndex = 457
        Me.CtrlOpcShortTrip4.TagName = "Seq_Trip[158]"
        '
        'CtrlOpcBagAddButton109
        '
        Me.CtrlOpcBagAddButton109.AllowDrop = True
        Me.CtrlOpcBagAddButton109.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton109.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton109.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton109.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton109.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton109.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton109.Location = New System.Drawing.Point(90, 782)
        Me.CtrlOpcBagAddButton109.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton109.Name = "CtrlOpcBagAddButton109"
        Me.CtrlOpcBagAddButton109.PlcName = Nothing
        Me.CtrlOpcBagAddButton109.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton109.TabIndex = 459
        Me.CtrlOpcBagAddButton109.TagName = "EL_Track[4,0]"
        Me.CtrlOpcBagAddButton109.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaRailSequenceStep10
        '
        Me.CtrlOpcTsaRailSequenceStep10.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep10.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep10.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep10.Location = New System.Drawing.Point(65, 728)
        Me.CtrlOpcTsaRailSequenceStep10.Name = "CtrlOpcTsaRailSequenceStep10"
        Me.CtrlOpcTsaRailSequenceStep10.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep10.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep10.SequenceID = 1216
        Me.CtrlOpcTsaRailSequenceStep10.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep10.TabIndex = 460
        Me.CtrlOpcTsaRailSequenceStep10.TagName = "SeqEL[4]"
        Me.CtrlOpcTsaRailSequenceStep10.Text = "EL4"
        '
        'CtrlOpcTsaRailSequenceStep11
        '
        Me.CtrlOpcTsaRailSequenceStep11.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep11.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep11.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep11.Location = New System.Drawing.Point(28, 809)
        Me.CtrlOpcTsaRailSequenceStep11.Name = "CtrlOpcTsaRailSequenceStep11"
        Me.CtrlOpcTsaRailSequenceStep11.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep11.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep11.SequenceID = 1222
        Me.CtrlOpcTsaRailSequenceStep11.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep11.TabIndex = 461
        Me.CtrlOpcTsaRailSequenceStep11.TagName = "SeqBD[2]"
        Me.CtrlOpcTsaRailSequenceStep11.Text = "BD2"
        '
        'CtrlOpcTsaRailSequenceStep12
        '
        Me.CtrlOpcTsaRailSequenceStep12.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep12.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep12.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep12.Location = New System.Drawing.Point(152, 46)
        Me.CtrlOpcTsaRailSequenceStep12.Name = "CtrlOpcTsaRailSequenceStep12"
        Me.CtrlOpcTsaRailSequenceStep12.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep12.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep12.SequenceID = 1224
        Me.CtrlOpcTsaRailSequenceStep12.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep12.TabIndex = 462
        Me.CtrlOpcTsaRailSequenceStep12.TagName = "SeqBD[4]"
        Me.CtrlOpcTsaRailSequenceStep12.Text = "BD4"
        '
        'CtrlOpcTsaBagWithStorageDestination3
        '
        Me.CtrlOpcTsaBagWithStorageDestination3.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBagWithStorageDestination3.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBagWithStorageDestination3.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBagWithStorageDestination3.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBagWithStorageDestination3.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBagWithStorageDestination3.CanRaiseStorageDestinationEvent = True
        Me.CtrlOpcTsaBagWithStorageDestination3.Category = 88
        Me.CtrlOpcTsaBagWithStorageDestination3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBagWithStorageDestination3.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBagWithStorageDestination3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBagWithStorageDestination3.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBagWithStorageDestination3.Location = New System.Drawing.Point(64, 231)
        Me.CtrlOpcTsaBagWithStorageDestination3.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBagWithStorageDestination3.Name = "CtrlOpcTsaBagWithStorageDestination3"
        Me.CtrlOpcTsaBagWithStorageDestination3.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBagWithStorageDestination3.PlcName = Nothing
        Me.CtrlOpcTsaBagWithStorageDestination3.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBagWithStorageDestination3.TabIndex = 465
        Me.CtrlOpcTsaBagWithStorageDestination3.TagName = "StoreBuffer[19,1]"
        Me.CtrlOpcTsaBagWithStorageDestination3.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag11
        '
        Me.CtrlOpcTsaBag11.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag11.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag11.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag11.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag11.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag11.Category = 88
        Me.CtrlOpcTsaBag11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag11.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag11.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag11.Location = New System.Drawing.Point(222, 352)
        Me.CtrlOpcTsaBag11.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag11.Name = "CtrlOpcTsaBag11"
        Me.CtrlOpcTsaBag11.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag11.PlcName = Nothing
        Me.CtrlOpcTsaBag11.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag11.TabIndex = 466
        Me.CtrlOpcTsaBag11.TagName = "StoreBuffer[15,1]"
        Me.CtrlOpcTsaBag11.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag12
        '
        Me.CtrlOpcTsaBag12.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag12.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag12.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag12.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag12.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag12.Category = 88
        Me.CtrlOpcTsaBag12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag12.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag12.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag12.Location = New System.Drawing.Point(222, 324)
        Me.CtrlOpcTsaBag12.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag12.Name = "CtrlOpcTsaBag12"
        Me.CtrlOpcTsaBag12.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag12.PlcName = Nothing
        Me.CtrlOpcTsaBag12.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag12.TabIndex = 467
        Me.CtrlOpcTsaBag12.TagName = "StoreBuffer[15,2]"
        Me.CtrlOpcTsaBag12.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag13
        '
        Me.CtrlOpcTsaBag13.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag13.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag13.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag13.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag13.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag13.Category = 88
        Me.CtrlOpcTsaBag13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag13.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag13.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag13.Location = New System.Drawing.Point(222, 296)
        Me.CtrlOpcTsaBag13.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag13.Name = "CtrlOpcTsaBag13"
        Me.CtrlOpcTsaBag13.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag13.PlcName = Nothing
        Me.CtrlOpcTsaBag13.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag13.TabIndex = 468
        Me.CtrlOpcTsaBag13.TagName = "StoreBuffer[15,3]"
        Me.CtrlOpcTsaBag13.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton110
        '
        Me.CtrlOpcBagAddButton110.AllowDrop = True
        Me.CtrlOpcBagAddButton110.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton110.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton110.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton110.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton110.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton110.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton110.Location = New System.Drawing.Point(228, 280)
        Me.CtrlOpcBagAddButton110.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton110.Name = "CtrlOpcBagAddButton110"
        Me.CtrlOpcBagAddButton110.PlcName = Nothing
        Me.CtrlOpcBagAddButton110.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton110.TabIndex = 470
        Me.CtrlOpcBagAddButton110.TagName = "StoreBuffer[15,3]"
        Me.CtrlOpcBagAddButton110.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcShortTrip5
        '
        Me.CtrlOpcShortTrip5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcShortTrip5.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOpcShortTrip5.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOpcShortTrip5.Location = New System.Drawing.Point(228, 263)
        Me.CtrlOpcShortTrip5.Name = "CtrlOpcShortTrip5"
        Me.CtrlOpcShortTrip5.PlcName = Nothing
        Me.CtrlOpcShortTrip5.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcShortTrip5.TabIndex = 469
        Me.CtrlOpcShortTrip5.TagName = "Seq_Trip[155]"
        '
        'CtrlOpcTsaBag24
        '
        Me.CtrlOpcTsaBag24.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag24.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag24.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag24.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag24.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag24.Category = 88
        Me.CtrlOpcTsaBag24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag24.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag24.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag24.Location = New System.Drawing.Point(272, 802)
        Me.CtrlOpcTsaBag24.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag24.Name = "CtrlOpcTsaBag24"
        Me.CtrlOpcTsaBag24.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag24.PlcName = Nothing
        Me.CtrlOpcTsaBag24.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag24.TabIndex = 471
        Me.CtrlOpcTsaBag24.TagName = "PLA_Track[9,1]"
        Me.CtrlOpcTsaBag24.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag25
        '
        Me.CtrlOpcTsaBag25.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag25.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag25.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag25.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag25.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag25.Category = 88
        Me.CtrlOpcTsaBag25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag25.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag25.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag25.Location = New System.Drawing.Point(277, 546)
        Me.CtrlOpcTsaBag25.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag25.Name = "CtrlOpcTsaBag25"
        Me.CtrlOpcTsaBag25.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag25.PlcName = Nothing
        Me.CtrlOpcTsaBag25.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag25.TabIndex = 473
        Me.CtrlOpcTsaBag25.TagName = "PLA_Track[8,1]"
        Me.CtrlOpcTsaBag25.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag26
        '
        Me.CtrlOpcTsaBag26.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag26.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag26.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag26.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag26.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag26.Category = 88
        Me.CtrlOpcTsaBag26.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag26.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag26.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag26.Location = New System.Drawing.Point(277, 632)
        Me.CtrlOpcTsaBag26.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag26.Name = "CtrlOpcTsaBag26"
        Me.CtrlOpcTsaBag26.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag26.PlcName = Nothing
        Me.CtrlOpcTsaBag26.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag26.TabIndex = 474
        Me.CtrlOpcTsaBag26.TagName = "StoreBuffer[16,3]"
        Me.CtrlOpcTsaBag26.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag27
        '
        Me.CtrlOpcTsaBag27.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag27.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag27.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag27.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag27.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag27.Category = 88
        Me.CtrlOpcTsaBag27.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag27.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag27.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag27.Location = New System.Drawing.Point(277, 660)
        Me.CtrlOpcTsaBag27.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag27.Name = "CtrlOpcTsaBag27"
        Me.CtrlOpcTsaBag27.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag27.PlcName = Nothing
        Me.CtrlOpcTsaBag27.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag27.TabIndex = 475
        Me.CtrlOpcTsaBag27.TagName = "StoreBuffer[16,2]"
        Me.CtrlOpcTsaBag27.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag28
        '
        Me.CtrlOpcTsaBag28.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag28.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag28.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag28.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag28.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag28.Category = 88
        Me.CtrlOpcTsaBag28.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag28.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag28.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag28.Location = New System.Drawing.Point(277, 688)
        Me.CtrlOpcTsaBag28.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag28.Name = "CtrlOpcTsaBag28"
        Me.CtrlOpcTsaBag28.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag28.PlcName = Nothing
        Me.CtrlOpcTsaBag28.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag28.TabIndex = 476
        Me.CtrlOpcTsaBag28.TagName = "StoreBuffer[16,1]"
        Me.CtrlOpcTsaBag28.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton104
        '
        Me.CtrlOpcBagAddButton104.AllowDrop = True
        Me.CtrlOpcBagAddButton104.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton104.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton104.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton104.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton104.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton104.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton104.Location = New System.Drawing.Point(284, 615)
        Me.CtrlOpcBagAddButton104.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton104.Name = "CtrlOpcBagAddButton104"
        Me.CtrlOpcBagAddButton104.PlcName = Nothing
        Me.CtrlOpcBagAddButton104.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton104.TabIndex = 477
        Me.CtrlOpcBagAddButton104.TagName = "StoreBuffer[16,3]"
        Me.CtrlOpcBagAddButton104.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag29
        '
        Me.CtrlOpcTsaBag29.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag29.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag29.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag29.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag29.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag29.Category = 88
        Me.CtrlOpcTsaBag29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag29.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag29.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag29.Location = New System.Drawing.Point(145, 613)
        Me.CtrlOpcTsaBag29.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag29.Name = "CtrlOpcTsaBag29"
        Me.CtrlOpcTsaBag29.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag29.PlcName = Nothing
        Me.CtrlOpcTsaBag29.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag29.TabIndex = 479
        Me.CtrlOpcTsaBag29.TagName = "StoreBuffer[17,2]"
        Me.CtrlOpcTsaBag29.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag30
        '
        Me.CtrlOpcTsaBag30.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag30.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag30.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag30.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag30.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag30.Category = 88
        Me.CtrlOpcTsaBag30.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag30.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag30.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag30.Location = New System.Drawing.Point(145, 585)
        Me.CtrlOpcTsaBag30.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag30.Name = "CtrlOpcTsaBag30"
        Me.CtrlOpcTsaBag30.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag30.PlcName = Nothing
        Me.CtrlOpcTsaBag30.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag30.TabIndex = 478
        Me.CtrlOpcTsaBag30.TagName = "StoreBuffer[17,1]"
        Me.CtrlOpcTsaBag30.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton113
        '
        Me.CtrlOpcBagAddButton113.AllowDrop = True
        Me.CtrlOpcBagAddButton113.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton113.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton113.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton113.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton113.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton113.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton113.Location = New System.Drawing.Point(152, 661)
        Me.CtrlOpcBagAddButton113.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton113.Name = "CtrlOpcBagAddButton113"
        Me.CtrlOpcBagAddButton113.PlcName = Nothing
        Me.CtrlOpcBagAddButton113.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton113.TabIndex = 481
        Me.CtrlOpcBagAddButton113.TagName = "StoreBuffer[17,2]"
        Me.CtrlOpcBagAddButton113.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcShortTrip6
        '
        Me.CtrlOpcShortTrip6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcShortTrip6.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOpcShortTrip6.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOpcShortTrip6.Location = New System.Drawing.Point(152, 644)
        Me.CtrlOpcShortTrip6.Name = "CtrlOpcShortTrip6"
        Me.CtrlOpcShortTrip6.PlcName = Nothing
        Me.CtrlOpcShortTrip6.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcShortTrip6.TabIndex = 480
        Me.CtrlOpcShortTrip6.TagName = "Seq_Trip[157]"
        '
        'CtrlOpcTsaBag32
        '
        Me.CtrlOpcTsaBag32.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag32.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag32.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag32.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag32.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag32.Category = 88
        Me.CtrlOpcTsaBag32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag32.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBag32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag32.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBag32.Location = New System.Drawing.Point(145, 752)
        Me.CtrlOpcTsaBag32.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag32.Name = "CtrlOpcTsaBag32"
        Me.CtrlOpcTsaBag32.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag32.PlcName = Nothing
        Me.CtrlOpcTsaBag32.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag32.TabIndex = 483
        Me.CtrlOpcTsaBag32.TagName = "EL_Track[3,0]"
        Me.CtrlOpcTsaBag32.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton115
        '
        Me.CtrlOpcBagAddButton115.AllowDrop = True
        Me.CtrlOpcBagAddButton115.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton115.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton115.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton115.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton115.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton115.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton115.Location = New System.Drawing.Point(152, 782)
        Me.CtrlOpcBagAddButton115.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton115.Name = "CtrlOpcBagAddButton115"
        Me.CtrlOpcBagAddButton115.PlcName = Nothing
        Me.CtrlOpcBagAddButton115.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton115.TabIndex = 484
        Me.CtrlOpcBagAddButton115.TagName = "EL_Track[3,0]"
        Me.CtrlOpcBagAddButton115.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaRailSequenceStep13
        '
        Me.CtrlOpcTsaRailSequenceStep13.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep13.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep13.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep13.Location = New System.Drawing.Point(143, 728)
        Me.CtrlOpcTsaRailSequenceStep13.Name = "CtrlOpcTsaRailSequenceStep13"
        Me.CtrlOpcTsaRailSequenceStep13.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep13.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep13.SequenceID = 1215
        Me.CtrlOpcTsaRailSequenceStep13.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep13.TabIndex = 485
        Me.CtrlOpcTsaRailSequenceStep13.TagName = "SeqEL[3]"
        Me.CtrlOpcTsaRailSequenceStep13.Text = "EL3"
        '
        'CtrlOpcShortTrip7
        '
        Me.CtrlOpcShortTrip7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcShortTrip7.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "ShortTrip", True))
        Me.CtrlOpcShortTrip7.GroupName = "Classified_Loading_Short_Trips"
        Me.CtrlOpcShortTrip7.Location = New System.Drawing.Point(67, 48)
        Me.CtrlOpcShortTrip7.Name = "CtrlOpcShortTrip7"
        Me.CtrlOpcShortTrip7.PlcName = Nothing
        Me.CtrlOpcShortTrip7.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcShortTrip7.TabIndex = 486
        Me.CtrlOpcShortTrip7.TagName = "Seq_Trip[42]"
        '
        'CtrlLintAlarmIcon18
        '
        Me.CtrlLintAlarmIcon18.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon18.Location = New System.Drawing.Point(277, 868)
        Me.CtrlLintAlarmIcon18.Name = "CtrlLintAlarmIcon18"
        Me.CtrlLintAlarmIcon18.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon18.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon18.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon18.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon18.TabIndex = 496
        '
        'CtrlLintAlarmIcon17
        '
        Me.CtrlLintAlarmIcon17.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon17.Location = New System.Drawing.Point(305, 405)
        Me.CtrlLintAlarmIcon17.Name = "CtrlLintAlarmIcon17"
        Me.CtrlLintAlarmIcon17.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon17.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon17.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon17.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon17.TabIndex = 495
        '
        'CtrlLintAlarmIcon16
        '
        Me.CtrlLintAlarmIcon16.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon16.Location = New System.Drawing.Point(30, 693)
        Me.CtrlLintAlarmIcon16.Name = "CtrlLintAlarmIcon16"
        Me.CtrlLintAlarmIcon16.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon16.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon16.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon16.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon16.TabIndex = 494
        '
        'CtrlLintAlarmIcon8
        '
        Me.CtrlLintAlarmIcon8.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon8.Location = New System.Drawing.Point(328, 130)
        Me.CtrlLintAlarmIcon8.Name = "CtrlLintAlarmIcon8"
        Me.CtrlLintAlarmIcon8.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon8.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon8.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon8.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon8.TabIndex = 491
        '
        'CtrlOPCBagAddButton112
        '
        Me.CtrlOPCBagAddButton112.AllowDrop = True
        Me.CtrlOPCBagAddButton112.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton112.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton112.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton112.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton112.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton112.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton112.Location = New System.Drawing.Point(284, 59)
        Me.CtrlOPCBagAddButton112.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton112.Name = "CtrlOPCBagAddButton112"
        Me.CtrlOPCBagAddButton112.PlcName = Nothing
        Me.CtrlOPCBagAddButton112.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton112.TabIndex = 490
        Me.CtrlOPCBagAddButton112.TagName = "PLA_Track[6,0]"
        Me.CtrlOPCBagAddButton112.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBagAddButton111
        '
        Me.CtrlOPCBagAddButton111.AllowDrop = True
        Me.CtrlOPCBagAddButton111.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagAddButton111.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOPCBagAddButton111.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOPCBagAddButton111.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOPCBagAddButton111.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagAddButton111.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagAddButton111.Location = New System.Drawing.Point(284, 116)
        Me.CtrlOPCBagAddButton111.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagAddButton111.Name = "CtrlOPCBagAddButton111"
        Me.CtrlOPCBagAddButton111.PlcName = Nothing
        Me.CtrlOPCBagAddButton111.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOPCBagAddButton111.TabIndex = 489
        Me.CtrlOPCBagAddButton111.TagName = "PLA_Track[6,1]"
        Me.CtrlOPCBagAddButton111.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBagWithStorageDestination17
        '
        Me.CtrlOPCBagWithStorageDestination17.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBagWithStorageDestination17.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBagWithStorageDestination17.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBagWithStorageDestination17.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBagWithStorageDestination17.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBagWithStorageDestination17.CanRaiseStorageDestinationEvent = True
        Me.CtrlOPCBagWithStorageDestination17.Category = 88
        Me.CtrlOPCBagWithStorageDestination17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBagWithStorageDestination17.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOPCBagWithStorageDestination17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBagWithStorageDestination17.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOPCBagWithStorageDestination17.Location = New System.Drawing.Point(277, 132)
        Me.CtrlOPCBagWithStorageDestination17.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBagWithStorageDestination17.Name = "CtrlOPCBagWithStorageDestination17"
        Me.CtrlOPCBagWithStorageDestination17.PLC_Bag_ID = 0
        Me.CtrlOPCBagWithStorageDestination17.PlcName = Nothing
        Me.CtrlOPCBagWithStorageDestination17.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBagWithStorageDestination17.TabIndex = 488
        Me.CtrlOPCBagWithStorageDestination17.TagName = "PLA_Track[6,1]"
        Me.CtrlOPCBagWithStorageDestination17.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOPCBag103
        '
        Me.CtrlOPCBag103.BackColor = System.Drawing.Color.White
        Me.CtrlOPCBag103.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCBag103.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOPCBag103.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOPCBag103.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOPCBag103.Category = 88
        Me.CtrlOPCBag103.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOPCBag103.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOPCBag103.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCBag103.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOPCBag103.Location = New System.Drawing.Point(277, 78)
        Me.CtrlOPCBag103.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOPCBag103.Name = "CtrlOPCBag103"
        Me.CtrlOPCBag103.PLC_Bag_ID = 0
        Me.CtrlOPCBag103.PlcName = Nothing
        Me.CtrlOPCBag103.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOPCBag103.TabIndex = 487
        Me.CtrlOPCBag103.TagName = "PLA_Track[6,0]"
        Me.CtrlOPCBag103.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlLintAlarmIcon6
        '
        Me.CtrlLintAlarmIcon6.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon6.Location = New System.Drawing.Point(327, 543)
        Me.CtrlLintAlarmIcon6.Name = "CtrlLintAlarmIcon6"
        Me.CtrlLintAlarmIcon6.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon6.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon6.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon6.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon6.TabIndex = 497
        '
        'CtrlLintAlarmIcon7
        '
        Me.CtrlLintAlarmIcon7.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon7.Location = New System.Drawing.Point(192, 693)
        Me.CtrlLintAlarmIcon7.Name = "CtrlLintAlarmIcon7"
        Me.CtrlLintAlarmIcon7.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon7.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon7.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon7.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon7.TabIndex = 498
        '
        'CtrlOpcBagAddButton116
        '
        Me.CtrlOpcBagAddButton116.AllowDrop = True
        Me.CtrlOpcBagAddButton116.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton116.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton116.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_OFFGOING
        Me.CtrlOpcBagAddButton116.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton116.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton116.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton116.Location = New System.Drawing.Point(303, 807)
        Me.CtrlOpcBagAddButton116.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton116.Name = "CtrlOpcBagAddButton116"
        Me.CtrlOpcBagAddButton116.PlcName = Nothing
        Me.CtrlOpcBagAddButton116.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton116.TabIndex = 499
        Me.CtrlOpcBagAddButton116.TagName = "PLA_Track[9,1]"
        Me.CtrlOpcBagAddButton116.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton117
        '
        Me.CtrlOpcBagAddButton117.AllowDrop = True
        Me.CtrlOpcBagAddButton117.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton117.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton117.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_OFFGOING
        Me.CtrlOpcBagAddButton117.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton117.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton117.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton117.Location = New System.Drawing.Point(284, 388)
        Me.CtrlOpcBagAddButton117.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton117.Name = "CtrlOpcBagAddButton117"
        Me.CtrlOpcBagAddButton117.PlcName = Nothing
        Me.CtrlOpcBagAddButton117.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton117.TabIndex = 500
        Me.CtrlOpcBagAddButton117.TagName = "PLA_Track[7,1]"
        Me.CtrlOpcBagAddButton117.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag9
        '
        Me.CtrlOpcTsaBag9.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag9.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag9.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag9.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag9.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag9.Category = 88
        Me.CtrlOpcTsaBag9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag9.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag9.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag9.Location = New System.Drawing.Point(118, 289)
        Me.CtrlOpcTsaBag9.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag9.Name = "CtrlOpcTsaBag9"
        Me.CtrlOpcTsaBag9.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag9.PlcName = Nothing
        Me.CtrlOpcTsaBag9.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag9.TabIndex = 509
        Me.CtrlOpcTsaBag9.TagName = "EL_Track[1,1]"
        Me.CtrlOpcTsaBag9.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag10
        '
        Me.CtrlOpcTsaBag10.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag10.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag10.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag10.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag10.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag10.Category = 88
        Me.CtrlOpcTsaBag10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag10.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag10.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag10.Location = New System.Drawing.Point(154, 289)
        Me.CtrlOpcTsaBag10.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag10.Name = "CtrlOpcTsaBag10"
        Me.CtrlOpcTsaBag10.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag10.PlcName = Nothing
        Me.CtrlOpcTsaBag10.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag10.TabIndex = 508
        Me.CtrlOpcTsaBag10.TagName = "EL_Track[2,1]"
        Me.CtrlOpcTsaBag10.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag7
        '
        Me.CtrlOpcTsaBag7.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag7.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag7.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag7.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag7.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag7.Category = 88
        Me.CtrlOpcTsaBag7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag7.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag7.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag7.Location = New System.Drawing.Point(155, 345)
        Me.CtrlOpcTsaBag7.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag7.Name = "CtrlOpcTsaBag7"
        Me.CtrlOpcTsaBag7.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag7.PlcName = Nothing
        Me.CtrlOpcTsaBag7.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag7.TabIndex = 506
        Me.CtrlOpcTsaBag7.TagName = "EL_Track[2,0]"
        Me.CtrlOpcTsaBag7.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcTsaBag8
        '
        Me.CtrlOpcTsaBag8.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag8.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag8.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag8.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag8.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag8.Category = 88
        Me.CtrlOpcTsaBag8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag8.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag8.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag8.Location = New System.Drawing.Point(118, 345)
        Me.CtrlOpcTsaBag8.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag8.Name = "CtrlOpcTsaBag8"
        Me.CtrlOpcTsaBag8.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag8.PlcName = Nothing
        Me.CtrlOpcTsaBag8.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag8.TabIndex = 507
        Me.CtrlOpcTsaBag8.TagName = "EL_Track[1,0]"
        Me.CtrlOpcTsaBag8.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton130
        '
        Me.CtrlOpcBagAddButton130.AllowDrop = True
        Me.CtrlOpcBagAddButton130.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton130.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton130.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton130.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton130.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton130.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton130.Location = New System.Drawing.Point(124, 297)
        Me.CtrlOpcBagAddButton130.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton130.Name = "CtrlOpcBagAddButton130"
        Me.CtrlOpcBagAddButton130.PlcName = Nothing
        Me.CtrlOpcBagAddButton130.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton130.TabIndex = 521
        Me.CtrlOpcBagAddButton130.TagName = "EL_Track[1,1]"
        Me.CtrlOpcBagAddButton130.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton131
        '
        Me.CtrlOpcBagAddButton131.AllowDrop = True
        Me.CtrlOpcBagAddButton131.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton131.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton131.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton131.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton131.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton131.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton131.Location = New System.Drawing.Point(160, 296)
        Me.CtrlOpcBagAddButton131.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton131.Name = "CtrlOpcBagAddButton131"
        Me.CtrlOpcBagAddButton131.PlcName = Nothing
        Me.CtrlOpcBagAddButton131.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton131.TabIndex = 520
        Me.CtrlOpcBagAddButton131.TagName = "EL_Track[2,1]"
        Me.CtrlOpcBagAddButton131.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton102
        '
        Me.CtrlOpcBagAddButton102.AllowDrop = True
        Me.CtrlOpcBagAddButton102.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton102.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton102.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton102.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton102.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton102.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton102.Location = New System.Drawing.Point(124, 352)
        Me.CtrlOpcBagAddButton102.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton102.Name = "CtrlOpcBagAddButton102"
        Me.CtrlOpcBagAddButton102.PlcName = Nothing
        Me.CtrlOpcBagAddButton102.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton102.TabIndex = 519
        Me.CtrlOpcBagAddButton102.TagName = "EL_Track[1,0]"
        Me.CtrlOpcBagAddButton102.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton129
        '
        Me.CtrlOpcBagAddButton129.AllowDrop = True
        Me.CtrlOpcBagAddButton129.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton129.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton129.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton129.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton129.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton129.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton129.Location = New System.Drawing.Point(160, 352)
        Me.CtrlOpcBagAddButton129.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton129.Name = "CtrlOpcBagAddButton129"
        Me.CtrlOpcBagAddButton129.PlcName = Nothing
        Me.CtrlOpcBagAddButton129.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton129.TabIndex = 518
        Me.CtrlOpcBagAddButton129.TagName = "EL_Track[2,0]"
        Me.CtrlOpcBagAddButton129.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlLintAlarmIcon13
        '
        Me.CtrlLintAlarmIcon13.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon13.Location = New System.Drawing.Point(82, 343)
        Me.CtrlLintAlarmIcon13.Name = "CtrlLintAlarmIcon13"
        Me.CtrlLintAlarmIcon13.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon13.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon13.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon13.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon13.TabIndex = 517
        '
        'CtrlLintAlarmIcon5
        '
        Me.CtrlLintAlarmIcon5.BackColor = System.Drawing.Color.White
        Me.CtrlLintAlarmIcon5.Location = New System.Drawing.Point(184, 343)
        Me.CtrlLintAlarmIcon5.Name = "CtrlLintAlarmIcon5"
        Me.CtrlLintAlarmIcon5.ParentBroadcaster = Nothing
        Me.CtrlLintAlarmIcon5.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLintAlarmIcon5.SubscribedAlarms = CType(resources.GetObject("CtrlLintAlarmIcon5.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLintAlarmIcon5.TabIndex = 516
        '
        'CtrlOpcTsaBagWithStorageDestination2
        '
        Me.CtrlOpcTsaBagWithStorageDestination2.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBagWithStorageDestination2.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBagWithStorageDestination2.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBagWithStorageDestination2.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBagWithStorageDestination2.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBagWithStorageDestination2.CanRaiseStorageDestinationEvent = True
        Me.CtrlOpcTsaBagWithStorageDestination2.Category = 88
        Me.CtrlOpcTsaBagWithStorageDestination2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBagWithStorageDestination2.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBagWithStorageDestination2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBagWithStorageDestination2.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBagWithStorageDestination2.Location = New System.Drawing.Point(154, 236)
        Me.CtrlOpcTsaBagWithStorageDestination2.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBagWithStorageDestination2.Name = "CtrlOpcTsaBagWithStorageDestination2"
        Me.CtrlOpcTsaBagWithStorageDestination2.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBagWithStorageDestination2.PlcName = Nothing
        Me.CtrlOpcTsaBagWithStorageDestination2.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBagWithStorageDestination2.TabIndex = 515
        Me.CtrlOpcTsaBagWithStorageDestination2.TagName = "EL_Track[2,2]"
        Me.CtrlOpcTsaBagWithStorageDestination2.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBagWithStorageDestination1
        '
        Me.CtrlOpcTsaBagWithStorageDestination1.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBagWithStorageDestination1.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBagWithStorageDestination1.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBagWithStorageDestination1.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBagWithStorageDestination1.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBagWithStorageDestination1.CanRaiseStorageDestinationEvent = True
        Me.CtrlOpcTsaBagWithStorageDestination1.Category = 88
        Me.CtrlOpcTsaBagWithStorageDestination1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBagWithStorageDestination1.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "OnGoingBuffer", True))
        Me.CtrlOpcTsaBagWithStorageDestination1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBagWithStorageDestination1.GroupName = "Classified_Sorting_Ongoing_Buffer"
        Me.CtrlOpcTsaBagWithStorageDestination1.Location = New System.Drawing.Point(118, 236)
        Me.CtrlOpcTsaBagWithStorageDestination1.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBagWithStorageDestination1.Name = "CtrlOpcTsaBagWithStorageDestination1"
        Me.CtrlOpcTsaBagWithStorageDestination1.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBagWithStorageDestination1.PlcName = Nothing
        Me.CtrlOpcTsaBagWithStorageDestination1.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBagWithStorageDestination1.TabIndex = 514
        Me.CtrlOpcTsaBagWithStorageDestination1.TagName = "EL_Track[1,2]"
        Me.CtrlOpcTsaBagWithStorageDestination1.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaRailSequenceStep7
        '
        Me.CtrlOpcTsaRailSequenceStep7.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep7.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep7.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep7.Location = New System.Drawing.Point(100, 321)
        Me.CtrlOpcTsaRailSequenceStep7.Name = "CtrlOpcTsaRailSequenceStep7"
        Me.CtrlOpcTsaRailSequenceStep7.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep7.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep7.SequenceID = 1213
        Me.CtrlOpcTsaRailSequenceStep7.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep7.TabIndex = 513
        Me.CtrlOpcTsaRailSequenceStep7.TagName = "SeqEL[1]"
        Me.CtrlOpcTsaRailSequenceStep7.Text = "EL1"
        '
        'CtrlOpcTsaRailSequenceStep6
        '
        Me.CtrlOpcTsaRailSequenceStep6.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaRailSequenceStep6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaRailSequenceStep6.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "RailSequence", True))
        Me.CtrlOpcTsaRailSequenceStep6.GroupName = Nothing
        Me.CtrlOpcTsaRailSequenceStep6.Location = New System.Drawing.Point(152, 321)
        Me.CtrlOpcTsaRailSequenceStep6.Name = "CtrlOpcTsaRailSequenceStep6"
        Me.CtrlOpcTsaRailSequenceStep6.PlcName = Nothing
        Me.CtrlOpcTsaRailSequenceStep6.ReadOnlySeqeunce = False
        Me.CtrlOpcTsaRailSequenceStep6.SequenceID = 1214
        Me.CtrlOpcTsaRailSequenceStep6.Size = New System.Drawing.Size(49, 23)
        Me.CtrlOpcTsaRailSequenceStep6.TabIndex = 512
        Me.CtrlOpcTsaRailSequenceStep6.TagName = "SeqEL[2]"
        Me.CtrlOpcTsaRailSequenceStep6.Text = "EL2"
        '
        'CtrlOpcBagAddButton103
        '
        Me.CtrlOpcBagAddButton103.AllowDrop = True
        Me.CtrlOpcBagAddButton103.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton103.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton103.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton103.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton103.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton103.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton103.Location = New System.Drawing.Point(124, 267)
        Me.CtrlOpcBagAddButton103.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton103.Name = "CtrlOpcBagAddButton103"
        Me.CtrlOpcBagAddButton103.PlcName = Nothing
        Me.CtrlOpcBagAddButton103.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton103.TabIndex = 511
        Me.CtrlOpcBagAddButton103.TagName = "EL_Track[1,2]"
        Me.CtrlOpcBagAddButton103.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcBagAddButton132
        '
        Me.CtrlOpcBagAddButton132.AllowDrop = True
        Me.CtrlOpcBagAddButton132.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton132.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton132.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton132.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton132.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton132.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton132.Location = New System.Drawing.Point(160, 267)
        Me.CtrlOpcBagAddButton132.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton132.Name = "CtrlOpcBagAddButton132"
        Me.CtrlOpcBagAddButton132.PlcName = Nothing
        Me.CtrlOpcBagAddButton132.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton132.TabIndex = 510
        Me.CtrlOpcBagAddButton132.TagName = "EL_Track[2,2]"
        Me.CtrlOpcBagAddButton132.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag19
        '
        Me.CtrlOpcTsaBag19.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag19.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag19.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag19.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag19.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag19.Category = 88
        Me.CtrlOpcTsaBag19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag19.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag19.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag19.Location = New System.Drawing.Point(83, 698)
        Me.CtrlOpcTsaBag19.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag19.Name = "CtrlOpcTsaBag19"
        Me.CtrlOpcTsaBag19.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag19.PlcName = Nothing
        Me.CtrlOpcTsaBag19.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag19.TabIndex = 522
        Me.CtrlOpcTsaBag19.TagName = "EL_Track[4,1]"
        Me.CtrlOpcTsaBag19.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton133
        '
        Me.CtrlOpcBagAddButton133.AllowDrop = True
        Me.CtrlOpcBagAddButton133.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton133.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton133.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton133.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton133.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton133.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton133.Location = New System.Drawing.Point(89, 705)
        Me.CtrlOpcBagAddButton133.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton133.Name = "CtrlOpcBagAddButton133"
        Me.CtrlOpcBagAddButton133.PlcName = Nothing
        Me.CtrlOpcBagAddButton133.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton133.TabIndex = 523
        Me.CtrlOpcBagAddButton133.TagName = "EL_Track[4,1]"
        Me.CtrlOpcBagAddButton133.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'CtrlOpcTsaBag31
        '
        Me.CtrlOpcTsaBag31.BackColor = System.Drawing.Color.White
        Me.CtrlOpcTsaBag31.BagBackColor = System.Drawing.SystemColors.Control
        Me.CtrlOpcTsaBag31.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.CtrlOpcTsaBag31.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.CLASSIFIED_ONGOING
        Me.CtrlOpcTsaBag31.BagTextColor = System.Drawing.Color.Black
        Me.CtrlOpcTsaBag31.Category = 88
        Me.CtrlOpcTsaBag31.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcTsaBag31.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.OPCGroupBindingSource, "Sorting", True))
        Me.CtrlOpcTsaBag31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcTsaBag31.GroupName = "Classified_Sorting"
        Me.CtrlOpcTsaBag31.Location = New System.Drawing.Point(145, 698)
        Me.CtrlOpcTsaBag31.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcTsaBag31.Name = "CtrlOpcTsaBag31"
        Me.CtrlOpcTsaBag31.PLC_Bag_ID = 0
        Me.CtrlOpcTsaBag31.PlcName = Nothing
        Me.CtrlOpcTsaBag31.Size = New System.Drawing.Size(28, 28)
        Me.CtrlOpcTsaBag31.TabIndex = 524
        Me.CtrlOpcTsaBag31.TagName = "EL_Track[3,1]"
        Me.CtrlOpcTsaBag31.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.SORTING
        '
        'CtrlOpcBagAddButton134
        '
        Me.CtrlOpcBagAddButton134.AllowDrop = True
        Me.CtrlOpcBagAddButton134.BackColor = System.Drawing.Color.White
        Me.CtrlOpcBagAddButton134.BagMode = Wdw_Sust.Core.Enums.FormMode.ADD
        Me.CtrlOpcBagAddButton134.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.CtrlOpcBagAddButton134.ButtonColor = System.Drawing.Color.Blue
        Me.CtrlOpcBagAddButton134.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.CtrlOpcBagAddButton134.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOpcBagAddButton134.Location = New System.Drawing.Point(151, 705)
        Me.CtrlOpcBagAddButton134.Margin = New System.Windows.Forms.Padding(5)
        Me.CtrlOpcBagAddButton134.Name = "CtrlOpcBagAddButton134"
        Me.CtrlOpcBagAddButton134.PlcName = Nothing
        Me.CtrlOpcBagAddButton134.Size = New System.Drawing.Size(16, 16)
        Me.CtrlOpcBagAddButton134.TabIndex = 525
        Me.CtrlOpcBagAddButton134.TagName = "EL_Track[3,1]"
        Me.CtrlOpcBagAddButton134.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLASSIFIED_ONGOING_BUFFER
        '
        'frmClassifiedLoadingPlatform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TSA_Rail_System.My.Resources.Resources.Classified_Loading_Platform_Area_phase5
        Me.ClientSize = New System.Drawing.Size(1371, 922)
        Me.Controls.Add(Me.CtrlOpcTsaBag31)
        Me.Controls.Add(Me.CtrlOpcBagAddButton134)
        Me.Controls.Add(Me.CtrlOpcTsaBag19)
        Me.Controls.Add(Me.CtrlOpcBagAddButton133)
        Me.Controls.Add(Me.CtrlOpcTsaBag9)
        Me.Controls.Add(Me.CtrlOpcTsaBag10)
        Me.Controls.Add(Me.CtrlOpcTsaBag7)
        Me.Controls.Add(Me.CtrlOpcTsaBag8)
        Me.Controls.Add(Me.CtrlOpcBagAddButton130)
        Me.Controls.Add(Me.CtrlOpcBagAddButton131)
        Me.Controls.Add(Me.CtrlOpcBagAddButton102)
        Me.Controls.Add(Me.CtrlOpcBagAddButton129)
        Me.Controls.Add(Me.CtrlLintAlarmIcon13)
        Me.Controls.Add(Me.CtrlLintAlarmIcon5)
        Me.Controls.Add(Me.CtrlOpcTsaBagWithStorageDestination2)
        Me.Controls.Add(Me.CtrlOpcTsaBagWithStorageDestination1)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep7)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep6)
        Me.Controls.Add(Me.CtrlOpcBagAddButton103)
        Me.Controls.Add(Me.CtrlOpcBagAddButton132)
        Me.Controls.Add(Me.CtrlOpcBagAddButton117)
        Me.Controls.Add(Me.CtrlOpcBagAddButton116)
        Me.Controls.Add(Me.CtrlLintAlarmIcon7)
        Me.Controls.Add(Me.CtrlLintAlarmIcon6)
        Me.Controls.Add(Me.CtrlLintAlarmIcon18)
        Me.Controls.Add(Me.CtrlLintAlarmIcon17)
        Me.Controls.Add(Me.CtrlLintAlarmIcon16)
        Me.Controls.Add(Me.CtrlLintAlarmIcon8)
        Me.Controls.Add(Me.CtrlOPCBagAddButton112)
        Me.Controls.Add(Me.CtrlOPCBagAddButton111)
        Me.Controls.Add(Me.CtrlOPCBagWithStorageDestination17)
        Me.Controls.Add(Me.CtrlOPCBag103)
        Me.Controls.Add(Me.CtrlOpcShortTrip7)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep13)
        Me.Controls.Add(Me.CtrlOpcBagAddButton115)
        Me.Controls.Add(Me.CtrlOpcTsaBag32)
        Me.Controls.Add(Me.CtrlOpcBagAddButton113)
        Me.Controls.Add(Me.CtrlOpcShortTrip6)
        Me.Controls.Add(Me.CtrlOpcTsaBag29)
        Me.Controls.Add(Me.CtrlOpcTsaBag30)
        Me.Controls.Add(Me.CtrlOpcBagAddButton104)
        Me.Controls.Add(Me.CtrlOpcTsaBag28)
        Me.Controls.Add(Me.CtrlOpcTsaBag27)
        Me.Controls.Add(Me.CtrlOpcTsaBag26)
        Me.Controls.Add(Me.CtrlOpcTsaBag25)
        Me.Controls.Add(Me.CtrlOpcTsaBag24)
        Me.Controls.Add(Me.CtrlOpcBagAddButton110)
        Me.Controls.Add(Me.CtrlOpcShortTrip5)
        Me.Controls.Add(Me.CtrlOpcTsaBag13)
        Me.Controls.Add(Me.CtrlOpcTsaBag12)
        Me.Controls.Add(Me.CtrlOpcTsaBag11)
        Me.Controls.Add(Me.CtrlOpcTsaBagWithStorageDestination3)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep12)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep11)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep10)
        Me.Controls.Add(Me.CtrlOpcBagAddButton109)
        Me.Controls.Add(Me.CtrlOpcBagAddButton108)
        Me.Controls.Add(Me.CtrlOpcShortTrip4)
        Me.Controls.Add(Me.CtrlOpcTsaBag21)
        Me.Controls.Add(Me.CtrlOpcTsaBag22)
        Me.Controls.Add(Me.CtrlOpcTsaBag23)
        Me.Controls.Add(Me.CtrlOpcTsaBag20)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep9)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep8)
        Me.Controls.Add(Me.CtrlOpcBagAddButton107)
        Me.Controls.Add(Me.CtrlOpcShortTrip3)
        Me.Controls.Add(Me.CtrlOpcTsaBag17)
        Me.Controls.Add(Me.CtrlOpcTsaBag18)
        Me.Controls.Add(Me.CtrlOpcTsaBag15)
        Me.Controls.Add(Me.CtrlOpcTsaBag16)
        Me.Controls.Add(Me.CtrlOpcTsaBag14)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep5)
        Me.Controls.Add(Me.CtrlOpcBagAddButton101)
        Me.Controls.Add(Me.CtrlOpcTsaBag6)
        Me.Controls.Add(Me.CtrlOpcTsaBag5)
        Me.Controls.Add(Me.CtrlOpcBagAddButton128)
        Me.Controls.Add(Me.CtrlOpcBagAddButton118)
        Me.Controls.Add(Me.CtrlOPCSwitchGateButton3)
        Me.Controls.Add(Me.CtrlOPCSwitchGateButton4)
        Me.Controls.Add(Me.CtrlOPCSwitchGateButton2)
        Me.Controls.Add(Me.CtrlOPCSwitchGateButton1)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep4)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep3)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep2)
        Me.Controls.Add(Me.CtrlOpcTsaRailSequenceStep1)
        Me.Controls.Add(Me.CtrlOpcTsaBag4)
        Me.Controls.Add(Me.CtrlOpcTsaBag3)
        Me.Controls.Add(Me.CtrlOpcTsaBag2)
        Me.Controls.Add(Me.CtrlOpcTsaBag1)
        Me.Controls.Add(Me.CtrlOPCShortTrip25)
        Me.Controls.Add(Me.CtrlOPCBag154)
        Me.Controls.Add(Me.CtrlOPCBag136)
        Me.Controls.Add(Me.CtrlOPCBag214)
        Me.Controls.Add(Me.CtrlOPCBag215)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep25)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep24)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep23)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep22)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep21)
        Me.Controls.Add(Me.CtrlOPCBagAddButton127)
        Me.Controls.Add(Me.CtrlOPCBag213)
        Me.Controls.Add(Me.CtrlOPCBagAddButton126)
        Me.Controls.Add(Me.CtrlOPCShortTrip24)
        Me.Controls.Add(Me.CtrlOPCBagAddButton125)
        Me.Controls.Add(Me.CtrlOPCShortTrip23)
        Me.Controls.Add(Me.CtrlOPCBag207)
        Me.Controls.Add(Me.CtrlOPCBag208)
        Me.Controls.Add(Me.CtrlOPCBag209)
        Me.Controls.Add(Me.CtrlOPCBag210)
        Me.Controls.Add(Me.CtrlOPCBag211)
        Me.Controls.Add(Me.CtrlOPCBag212)
        Me.Controls.Add(Me.CtrlOPCBagAddButton124)
        Me.Controls.Add(Me.CtrlOPCShortTrip22)
        Me.Controls.Add(Me.CtrlOPCBagAddButton123)
        Me.Controls.Add(Me.CtrlOPCShortTrip21)
        Me.Controls.Add(Me.CtrlOPCBagAddButton122)
        Me.Controls.Add(Me.CtrlOPCBag206)
        Me.Controls.Add(Me.CtrlOPCBag203)
        Me.Controls.Add(Me.CtrlOPCBag204)
        Me.Controls.Add(Me.CtrlOPCBag205)
        Me.Controls.Add(Me.CtrlOPCBag193)
        Me.Controls.Add(Me.CtrlOPCBag194)
        Me.Controls.Add(Me.CtrlOPCBag195)
        Me.Controls.Add(Me.CtrlOPCBag196)
        Me.Controls.Add(Me.CtrlOPCBag197)
        Me.Controls.Add(Me.CtrlOPCBag198)
        Me.Controls.Add(Me.CtrlOPCBag199)
        Me.Controls.Add(Me.CtrlOPCBag200)
        Me.Controls.Add(Me.CtrlOPCBag201)
        Me.Controls.Add(Me.CtrlOPCBag202)
        Me.Controls.Add(Me.CtrlOPCBag179)
        Me.Controls.Add(Me.CtrlOPCBag180)
        Me.Controls.Add(Me.CtrlOPCBag181)
        Me.Controls.Add(Me.CtrlOPCBag182)
        Me.Controls.Add(Me.CtrlOPCBag183)
        Me.Controls.Add(Me.CtrlOPCBag184)
        Me.Controls.Add(Me.CtrlOPCBag185)
        Me.Controls.Add(Me.CtrlOPCBag186)
        Me.Controls.Add(Me.CtrlOPCBag187)
        Me.Controls.Add(Me.CtrlOPCBag188)
        Me.Controls.Add(Me.CtrlOPCBag189)
        Me.Controls.Add(Me.CtrlOPCBag190)
        Me.Controls.Add(Me.CtrlOPCBag191)
        Me.Controls.Add(Me.CtrlOPCBag192)
        Me.Controls.Add(Me.CtrlOPCBag163)
        Me.Controls.Add(Me.CtrlOPCBag164)
        Me.Controls.Add(Me.CtrlOPCBag165)
        Me.Controls.Add(Me.CtrlOPCBag166)
        Me.Controls.Add(Me.CtrlOPCBag167)
        Me.Controls.Add(Me.CtrlOPCBag168)
        Me.Controls.Add(Me.CtrlOPCBag169)
        Me.Controls.Add(Me.CtrlOPCBag170)
        Me.Controls.Add(Me.CtrlOPCBag171)
        Me.Controls.Add(Me.CtrlOPCBag172)
        Me.Controls.Add(Me.CtrlOPCBag173)
        Me.Controls.Add(Me.CtrlOPCBag174)
        Me.Controls.Add(Me.CtrlOPCBag175)
        Me.Controls.Add(Me.CtrlOPCBag176)
        Me.Controls.Add(Me.CtrlOPCBag177)
        Me.Controls.Add(Me.CtrlOPCBag178)
        Me.Controls.Add(Me.CtrlOPCShortTrip19)
        Me.Controls.Add(Me.CtrlOPCShortTrip20)
        Me.Controls.Add(Me.CtrlOPCBag137)
        Me.Controls.Add(Me.CtrlOPCBag155)
        Me.Controls.Add(Me.CtrlOPCBag156)
        Me.Controls.Add(Me.CtrlOPCBag157)
        Me.Controls.Add(Me.CtrlOPCBag158)
        Me.Controls.Add(Me.CtrlOPCBag159)
        Me.Controls.Add(Me.CtrlOPCBag160)
        Me.Controls.Add(Me.CtrlOPCBag161)
        Me.Controls.Add(Me.CtrlOPCBag162)
        Me.Controls.Add(Me.CtrlOPCBagAddButton121)
        Me.Controls.Add(Me.CtrlOPCShortTrip18)
        Me.Controls.Add(Me.CtrlOPCBagAddButton120)
        Me.Controls.Add(Me.CtrlOPCShortTrip17)
        Me.Controls.Add(Me.CtrlOPCBag133)
        Me.Controls.Add(Me.CtrlOPCBag134)
        Me.Controls.Add(Me.CtrlOPCBag135)
        Me.Controls.Add(Me.CtrlOPCBag115)
        Me.Controls.Add(Me.CtrlOPCBag131)
        Me.Controls.Add(Me.CtrlOPCBag132)
        Me.Controls.Add(Me.CtrlOPCBag102)
        Me.Controls.Add(Me.CtrlOPCBag111)
        Me.Controls.Add(Me.CtrlOPCBag112)
        Me.Controls.Add(Me.CtrlOPCBag101)
        Me.Controls.Add(Me.CtrlOPCBag100)
        Me.Controls.Add(Me.CtrlOPCBag99)
        Me.Controls.Add(Me.CtrlOPCBagAddButton119)
        Me.Controls.Add(Me.CtrlOPCShortTrip16)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon15)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon14)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon12)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon11)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon10)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon9)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon4)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon2)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon3)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon1)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep20)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep19)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep17)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep18)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep16)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep15)
        Me.Controls.Add(Me.CtrlOPCShortTrip14)
        Me.Controls.Add(Me.CtrlOPCShortTrip15)
        Me.Controls.Add(Me.CtrlOPCShortTrip13)
        Me.Controls.Add(Me.CtrlOPCShortTrip12)
        Me.Controls.Add(Me.CtrlOPCShortTrip10)
        Me.Controls.Add(Me.CtrlOPCShortTrip11)
        Me.Controls.Add(Me.CtrlOPCShortTrip9)
        Me.Controls.Add(Me.CtrlOPCShortTrip8)
        Me.Controls.Add(Me.CtrlOPCBagAddButton114)
        Me.Controls.Add(Me.CtrlOPCBagAddButton106)
        Me.Controls.Add(Me.CtrlOPCBagAddButton105)
        Me.Controls.Add(Me.CtrlOPCShortTrip2)
        Me.Controls.Add(Me.CtrlOPCBagAddButton97)
        Me.Controls.Add(Me.CtrlOPCBagAddButton98)
        Me.Controls.Add(Me.CtrlOPCBagAddButton99)
        Me.Controls.Add(Me.CtrlOPCBagAddButton100)
        Me.Controls.Add(Me.CtrlOPCBagAddButton95)
        Me.Controls.Add(Me.CtrlOPCBagAddButton96)
        Me.Controls.Add(Me.CtrlOPCBagAddButton94)
        Me.Controls.Add(Me.CtrlOPCBagAddButton93)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep14)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep13)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep12)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep11)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep10)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep9)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep8)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep7)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep4)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep3)
        Me.Controls.Add(Me.CtrlOpcRailSequenceStep2)
        Me.Controls.Add(Me.CtrlOPCBag150)
        Me.Controls.Add(Me.CtrlOPCBag153)
        Me.Controls.Add(Me.CtrlOPCBag146)
        Me.Controls.Add(Me.CtrlOPCBag148)
        Me.Controls.Add(Me.CtrlOPCBag149)
        Me.Controls.Add(Me.CtrlOPCBagAddButton83)
        Me.Controls.Add(Me.CtrlOPCBagAddButton84)
        Me.Controls.Add(Me.CtrlOPCBagAddButton85)
        Me.Controls.Add(Me.CtrlOPCBagAddButton86)
        Me.Controls.Add(Me.CtrlOPCBagAddButton87)
        Me.Controls.Add(Me.CtrlOPCBagAddButton88)
        Me.Controls.Add(Me.CtrlOPCBagAddButton89)
        Me.Controls.Add(Me.CtrlOPCBagAddButton90)
        Me.Controls.Add(Me.CtrlOPCBagAddButton91)
        Me.Controls.Add(Me.CtrlOPCBagAddButton92)
        Me.Controls.Add(Me.CtrlOPCBagAddButton73)
        Me.Controls.Add(Me.CtrlOPCBagAddButton74)
        Me.Controls.Add(Me.CtrlOPCBagAddButton75)
        Me.Controls.Add(Me.CtrlOPCBagAddButton76)
        Me.Controls.Add(Me.CtrlOPCBagAddButton77)
        Me.Controls.Add(Me.CtrlOPCBagAddButton78)
        Me.Controls.Add(Me.CtrlOPCBagAddButton79)
        Me.Controls.Add(Me.CtrlOPCBagAddButton80)
        Me.Controls.Add(Me.CtrlOPCBagAddButton81)
        Me.Controls.Add(Me.CtrlOPCBagAddButton82)
        Me.Controls.Add(Me.CtrlOPCBagAddButton63)
        Me.Controls.Add(Me.CtrlOPCBagAddButton64)
        Me.Controls.Add(Me.CtrlOPCBagAddButton65)
        Me.Controls.Add(Me.CtrlOPCBagAddButton66)
        Me.Controls.Add(Me.CtrlOPCBagAddButton67)
        Me.Controls.Add(Me.CtrlOPCBagAddButton68)
        Me.Controls.Add(Me.CtrlOPCBagAddButton69)
        Me.Controls.Add(Me.CtrlOPCBagAddButton70)
        Me.Controls.Add(Me.CtrlOPCBagAddButton71)
        Me.Controls.Add(Me.CtrlOPCBagAddButton72)
        Me.Controls.Add(Me.CtrlOPCBagAddButton56)
        Me.Controls.Add(Me.CtrlOPCBagAddButton57)
        Me.Controls.Add(Me.CtrlOPCBagAddButton58)
        Me.Controls.Add(Me.CtrlOPCBagAddButton59)
        Me.Controls.Add(Me.CtrlOPCBagAddButton60)
        Me.Controls.Add(Me.CtrlOPCBagAddButton61)
        Me.Controls.Add(Me.CtrlOPCBagAddButton62)
        Me.Controls.Add(Me.CtrlOPCBagAddButton49)
        Me.Controls.Add(Me.CtrlOPCBagAddButton50)
        Me.Controls.Add(Me.CtrlOPCBagAddButton51)
        Me.Controls.Add(Me.CtrlOPCBagAddButton52)
        Me.Controls.Add(Me.CtrlOPCBagAddButton53)
        Me.Controls.Add(Me.CtrlOPCBagAddButton54)
        Me.Controls.Add(Me.CtrlOPCBagAddButton55)
        Me.Controls.Add(Me.CtrlOPCBagAddButton42)
        Me.Controls.Add(Me.CtrlOPCBagAddButton43)
        Me.Controls.Add(Me.CtrlOPCBagAddButton44)
        Me.Controls.Add(Me.CtrlOPCBagAddButton45)
        Me.Controls.Add(Me.CtrlOPCBagAddButton46)
        Me.Controls.Add(Me.CtrlOPCBagAddButton47)
        Me.Controls.Add(Me.CtrlOPCBagAddButton48)
        Me.Controls.Add(Me.CtrlOPCBagAddButton35)
        Me.Controls.Add(Me.CtrlOPCBagAddButton36)
        Me.Controls.Add(Me.CtrlOPCBagAddButton37)
        Me.Controls.Add(Me.CtrlOPCBagAddButton38)
        Me.Controls.Add(Me.CtrlOPCBagAddButton39)
        Me.Controls.Add(Me.CtrlOPCBagAddButton40)
        Me.Controls.Add(Me.CtrlOPCBagAddButton41)
        Me.Controls.Add(Me.CtrlOPCBagAddButton31)
        Me.Controls.Add(Me.CtrlOPCBagAddButton32)
        Me.Controls.Add(Me.CtrlOPCBagAddButton33)
        Me.Controls.Add(Me.CtrlOPCBagAddButton34)
        Me.Controls.Add(Me.CtrlOPCBagAddButton21)
        Me.Controls.Add(Me.CtrlOPCBagAddButton22)
        Me.Controls.Add(Me.CtrlOPCBagAddButton23)
        Me.Controls.Add(Me.CtrlOPCBagAddButton24)
        Me.Controls.Add(Me.CtrlOPCBagAddButton25)
        Me.Controls.Add(Me.CtrlOPCBagAddButton26)
        Me.Controls.Add(Me.CtrlOPCBagAddButton27)
        Me.Controls.Add(Me.CtrlOPCBagAddButton28)
        Me.Controls.Add(Me.CtrlOPCBagAddButton29)
        Me.Controls.Add(Me.CtrlOPCBagAddButton30)
        Me.Controls.Add(Me.CtrlOPCBagAddButton11)
        Me.Controls.Add(Me.CtrlOPCBagAddButton12)
        Me.Controls.Add(Me.CtrlOPCBagAddButton13)
        Me.Controls.Add(Me.CtrlOPCBagAddButton14)
        Me.Controls.Add(Me.CtrlOPCBagAddButton15)
        Me.Controls.Add(Me.CtrlOPCBagAddButton16)
        Me.Controls.Add(Me.CtrlOPCBagAddButton17)
        Me.Controls.Add(Me.CtrlOPCBagAddButton18)
        Me.Controls.Add(Me.CtrlOPCBagAddButton19)
        Me.Controls.Add(Me.CtrlOPCBagAddButton20)
        Me.Controls.Add(Me.CtrlOPCBagAddButton1)
        Me.Controls.Add(Me.CtrlOPCBagAddButton2)
        Me.Controls.Add(Me.CtrlOPCBagAddButton3)
        Me.Controls.Add(Me.CtrlOPCBagAddButton4)
        Me.Controls.Add(Me.CtrlOPCBagAddButton5)
        Me.Controls.Add(Me.CtrlOPCBagAddButton6)
        Me.Controls.Add(Me.CtrlOPCBagAddButton7)
        Me.Controls.Add(Me.CtrlOPCBagAddButton8)
        Me.Controls.Add(Me.CtrlOPCBagAddButton9)
        Me.Controls.Add(Me.CtrlOPCBagAddButton10)
        Me.Controls.Add(Me.CtrlOPCBag116)
        Me.Controls.Add(Me.CtrlOPCBag117)
        Me.Controls.Add(Me.CtrlOPCBag118)
        Me.Controls.Add(Me.CtrlOPCBag119)
        Me.Controls.Add(Me.CtrlOPCBag120)
        Me.Controls.Add(Me.CtrlOPCBag121)
        Me.Controls.Add(Me.CtrlOPCBag122)
        Me.Controls.Add(Me.CtrlOPCBag123)
        Me.Controls.Add(Me.CtrlOPCBag124)
        Me.Controls.Add(Me.CtrlOPCBag125)
        Me.Controls.Add(Me.CtrlOPCBag104)
        Me.Controls.Add(Me.CtrlOPCBag145)
        Me.Controls.Add(Me.CtrlOPCBag141)
        Me.Controls.Add(Me.CtrlOPCBag143)
        Me.Controls.Add(Me.CtrlOPCBag142)
        Me.Controls.Add(Me.CtrlOPCBag138)
        Me.Controls.Add(Me.CtrlOPCBag113)
        Me.Controls.Add(Me.CtrlOPCBag108)
        Me.Controls.Add(Me.CtrlOPCBag109)
        Me.Controls.Add(Me.CtrlOPCBag110)
        Me.Controls.Add(Me.CtrlOPCBag105)
        Me.Controls.Add(Me.CtrlOPCBag106)
        Me.Controls.Add(Me.CtrlOPCBag107)
        Me.Controls.Add(Me.CtrlOPCBag90)
        Me.Controls.Add(Me.CtrlOPCBag91)
        Me.Controls.Add(Me.CtrlOPCBag92)
        Me.Controls.Add(Me.CtrlOPCBag93)
        Me.Controls.Add(Me.CtrlOPCBag94)
        Me.Controls.Add(Me.CtrlOPCBag95)
        Me.Controls.Add(Me.CtrlOPCBag96)
        Me.Controls.Add(Me.CtrlOPCBag83)
        Me.Controls.Add(Me.CtrlOPCBag84)
        Me.Controls.Add(Me.CtrlOPCBag85)
        Me.Controls.Add(Me.CtrlOPCBag86)
        Me.Controls.Add(Me.CtrlOPCBag87)
        Me.Controls.Add(Me.CtrlOPCBag88)
        Me.Controls.Add(Me.CtrlOPCBag89)
        Me.Controls.Add(Me.CtrlOPCBag81)
        Me.Controls.Add(Me.CtrlOPCBag82)
        Me.Controls.Add(Me.CtrlOPCBag55)
        Me.Controls.Add(Me.CtrlOPCBag56)
        Me.Controls.Add(Me.CtrlOPCBag73)
        Me.Controls.Add(Me.CtrlOPCBag74)
        Me.Controls.Add(Me.CtrlOPCBag75)
        Me.Controls.Add(Me.CtrlOPCBag76)
        Me.Controls.Add(Me.CtrlOPCBag77)
        Me.Controls.Add(Me.CtrlOPCBag78)
        Me.Controls.Add(Me.CtrlOPCBag79)
        Me.Controls.Add(Me.CtrlOPCBag80)
        Me.Controls.Add(Me.CtrlOPCBag57)
        Me.Controls.Add(Me.CtrlOPCBag58)
        Me.Controls.Add(Me.CtrlOPCBag59)
        Me.Controls.Add(Me.CtrlOPCBag60)
        Me.Controls.Add(Me.CtrlOPCBag61)
        Me.Controls.Add(Me.CtrlOPCBag62)
        Me.Controls.Add(Me.CtrlOPCBag63)
        Me.Controls.Add(Me.CtrlOPCBag64)
        Me.Controls.Add(Me.CtrlOPCBag65)
        Me.Controls.Add(Me.CtrlOPCBag66)
        Me.Controls.Add(Me.CtrlOPCBag67)
        Me.Controls.Add(Me.CtrlOPCBag68)
        Me.Controls.Add(Me.CtrlOPCBag69)
        Me.Controls.Add(Me.CtrlOPCBag70)
        Me.Controls.Add(Me.CtrlOPCBag71)
        Me.Controls.Add(Me.CtrlOPCBag72)
        Me.Controls.Add(Me.CtrlOPCBag46)
        Me.Controls.Add(Me.CtrlOPCBag47)
        Me.Controls.Add(Me.CtrlOPCBag48)
        Me.Controls.Add(Me.CtrlOPCBag49)
        Me.Controls.Add(Me.CtrlOPCBag50)
        Me.Controls.Add(Me.CtrlOPCBag51)
        Me.Controls.Add(Me.CtrlOPCBag52)
        Me.Controls.Add(Me.CtrlOPCBag53)
        Me.Controls.Add(Me.CtrlOPCBag54)
        Me.Controls.Add(Me.CtrlOPCBag28)
        Me.Controls.Add(Me.CtrlOPCBag29)
        Me.Controls.Add(Me.CtrlOPCBag30)
        Me.Controls.Add(Me.CtrlOPCBag31)
        Me.Controls.Add(Me.CtrlOPCBag32)
        Me.Controls.Add(Me.CtrlOPCBag33)
        Me.Controls.Add(Me.CtrlOPCBag34)
        Me.Controls.Add(Me.CtrlOPCBag35)
        Me.Controls.Add(Me.CtrlOPCBag36)
        Me.Controls.Add(Me.CtrlOPCBag37)
        Me.Controls.Add(Me.CtrlOPCBag38)
        Me.Controls.Add(Me.CtrlOPCBag39)
        Me.Controls.Add(Me.CtrlOPCBag40)
        Me.Controls.Add(Me.CtrlOPCBag41)
        Me.Controls.Add(Me.CtrlOPCBag42)
        Me.Controls.Add(Me.CtrlOPCBag43)
        Me.Controls.Add(Me.CtrlOPCBag44)
        Me.Controls.Add(Me.CtrlOPCBag45)
        Me.Controls.Add(Me.CtrlOPCBag19)
        Me.Controls.Add(Me.CtrlOPCBag20)
        Me.Controls.Add(Me.CtrlOPCBag21)
        Me.Controls.Add(Me.CtrlOPCBag22)
        Me.Controls.Add(Me.CtrlOPCBag23)
        Me.Controls.Add(Me.CtrlOPCBag24)
        Me.Controls.Add(Me.CtrlOPCBag25)
        Me.Controls.Add(Me.CtrlOPCBag26)
        Me.Controls.Add(Me.CtrlOPCBag27)
        Me.Controls.Add(Me.CtrlOPCBag10)
        Me.Controls.Add(Me.CtrlOPCBag11)
        Me.Controls.Add(Me.CtrlOPCBag12)
        Me.Controls.Add(Me.CtrlOPCBag13)
        Me.Controls.Add(Me.CtrlOPCBag14)
        Me.Controls.Add(Me.CtrlOPCBag15)
        Me.Controls.Add(Me.CtrlOPCBag16)
        Me.Controls.Add(Me.CtrlOPCBag17)
        Me.Controls.Add(Me.CtrlOPCBag18)
        Me.Controls.Add(Me.CtrlOPCBag7)
        Me.Controls.Add(Me.CtrlOPCBag8)
        Me.Controls.Add(Me.CtrlOPCBag9)
        Me.Controls.Add(Me.CtrlOPCBag4)
        Me.Controls.Add(Me.CtrlOPCBag5)
        Me.Controls.Add(Me.CtrlOPCBag6)
        Me.Controls.Add(Me.CtrlOPCBag3)
        Me.Controls.Add(Me.CtrlOPCBag2)
        Me.Controls.Add(Me.CtrlOPCBag1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1387, 960)
        Me.MinimumSize = New System.Drawing.Size(1377, 838)
        Me.Name = "frmClassifiedLoadingPlatform"
        Me.Text = "Classified Loading Platform"
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPCGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlOPCBag1 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag2 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag3 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag4 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag5 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag6 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag7 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag8 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag9 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag10 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag11 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag12 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag13 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag14 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag15 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag16 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag17 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag18 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag19 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag20 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag21 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag22 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag23 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag24 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag25 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag26 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag27 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag28 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag29 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag30 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag31 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag32 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag33 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag34 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag35 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag36 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag37 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag38 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag39 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag40 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag41 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag42 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag43 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag44 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag45 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag46 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag47 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag48 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag49 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag50 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag51 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag52 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag53 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag54 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag57 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag58 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag65 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag66 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag67 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag68 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag69 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag70 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag73 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag74 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag75 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag76 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag77 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag78 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag90 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag91 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag92 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag93 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag94 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag95 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag96 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag105 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag106 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag107 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag108 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag109 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag110 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag104 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag113 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag116 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag117 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag118 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag119 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag120 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag121 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag122 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag123 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag124 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag125 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton1 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton2 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton3 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton4 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton5 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton6 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton7 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton8 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton9 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton10 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton11 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton12 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton13 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton14 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton15 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton16 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton17 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton18 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton19 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton20 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton28 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton29 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton30 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton31 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton32 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton33 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton34 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton42 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton43 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton44 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton45 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton46 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton47 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton48 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton49 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton50 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton51 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton52 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton53 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton54 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton55 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton56 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton57 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton58 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton59 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton60 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton61 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton62 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton63 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton64 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton65 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton66 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton67 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton68 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton69 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton70 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton71 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton72 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton73 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton74 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton75 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton76 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton77 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton78 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton79 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton80 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton81 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton82 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton83 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton84 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton85 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton86 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton87 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton88 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton89 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton90 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton91 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton92 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag138 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag141 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag142 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag143 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag145 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag146 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag148 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag149 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcRailSequenceStep2 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep3 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep4 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep7 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep8 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep9 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep10 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep11 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep13 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep14 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOPCBagAddButton93 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton95 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton96 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton97 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton98 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton100 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip2 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBagAddButton105 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton106 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton114 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip8 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip10 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip11 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip12 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip13 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip14 As CtrlOpcShortTrip
    Friend WithEvents CtrlOpcRailSequenceStep15 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep16 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep18 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep19 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlLINTAlarmIcon1 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon2 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon4 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon9 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon11 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon12 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon14 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon15 As CtrlLintAlarmIcon
    Friend WithEvents CtrlOPCShortTrip16 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBagAddButton119 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag99 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag100 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag101 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag102 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag111 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag112 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag115 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag131 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag132 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag133 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag134 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag135 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBagAddButton120 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip17 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBagAddButton121 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip18 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBag137 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag155 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag156 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag157 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag158 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag159 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag160 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag161 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag162 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCShortTrip19 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip20 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBag163 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag164 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag165 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag166 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag167 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag168 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag169 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag170 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag171 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag172 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag173 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag174 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag175 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag176 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag177 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag178 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag179 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag180 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag181 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag182 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag183 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag184 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag185 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag186 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag187 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag188 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag189 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag190 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag191 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag192 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag193 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag194 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag195 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag196 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag197 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag198 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag199 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag200 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag201 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag202 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag203 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag204 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag205 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag206 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBagAddButton122 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton123 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip21 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBagAddButton124 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip22 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBag207 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag208 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag209 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag210 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag211 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag212 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBagAddButton125 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip23 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBagAddButton126 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip24 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCBag213 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBagAddButton127 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcRailSequenceStep21 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep22 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep23 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep24 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep25 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOPCBag214 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag215 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag136 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag154 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCShortTrip25 As CtrlOpcShortTrip
    Friend WithEvents OPCGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtrlOpcTsaBag1 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag4 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaRailSequenceStep1 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOPCBag72 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag71 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag64 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag63 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag62 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag61 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag60 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag59 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag80 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag79 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag56 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag55 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag82 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag81 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag89 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag88 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag87 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag86 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag85 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag84 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag83 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBagAddButton27 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton26 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton25 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton24 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton23 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton22 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton21 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton41 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton40 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton39 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton38 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton37 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton36 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton35 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBag153 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCBag150 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcRailSequenceStep12 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOPCBagAddButton94 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton99 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCShortTrip9 As CtrlOpcShortTrip
    Friend WithEvents CtrlOPCShortTrip15 As CtrlOpcShortTrip
    Friend WithEvents CtrlOpcRailSequenceStep17 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcRailSequenceStep20 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlLINTAlarmIcon3 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon10 As CtrlLintAlarmIcon
    Friend WithEvents CtrlOpcTsaBag2 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag3 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaRailSequenceStep2 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaRailSequenceStep3 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaRailSequenceStep4 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOPCSwitchGateButton1 As CtrlOPCSwitchGateButton
    Friend WithEvents CtrlOPCSwitchGateButton2 As CtrlOPCSwitchGateButton
    Friend WithEvents CtrlOPCSwitchGateButton4 As CtrlOPCSwitchGateButton
    Friend WithEvents CtrlOPCSwitchGateButton3 As CtrlOPCSwitchGateButton
    Friend WithEvents CtrlOpcBagAddButton118 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcBagAddButton128 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaBag5 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag6 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton101 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaRailSequenceStep5 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaBag14 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag15 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag16 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag17 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag18 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcShortTrip3 As CtrlOpcShortTrip
    Friend WithEvents CtrlOpcBagAddButton107 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaRailSequenceStep8 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaRailSequenceStep9 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaBag20 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag21 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag22 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag23 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton108 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcShortTrip4 As CtrlOpcShortTrip
    Friend WithEvents CtrlOpcBagAddButton109 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaRailSequenceStep10 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaRailSequenceStep11 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaRailSequenceStep12 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaBagWithStorageDestination3 As CtrlOpcTsaBagWithStorageDestination
    Friend WithEvents CtrlOpcTsaBag11 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag12 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag13 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton110 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcShortTrip5 As CtrlOpcShortTrip
    Friend WithEvents CtrlOpcTsaBag24 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag25 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag26 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag27 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag28 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton104 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaBag29 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag30 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton113 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcShortTrip6 As CtrlOpcShortTrip
    Friend WithEvents CtrlOpcTsaBag32 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton115 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaRailSequenceStep13 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcShortTrip7 As CtrlOpcShortTrip
    Friend WithEvents CtrlLintAlarmIcon18 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLintAlarmIcon17 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLintAlarmIcon16 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLintAlarmIcon8 As CtrlLintAlarmIcon
    Friend WithEvents CtrlOPCBagAddButton112 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagAddButton111 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOPCBagWithStorageDestination17 As CtrlOpcTsaBagWithStorageDestination
    Friend WithEvents CtrlOPCBag103 As CtrlOpcTsaBag
    Friend WithEvents CtrlLintAlarmIcon6 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLintAlarmIcon7 As CtrlLintAlarmIcon
    Friend WithEvents CtrlOpcBagAddButton116 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcBagAddButton117 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaBag9 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag10 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag7 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcTsaBag8 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton130 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcBagAddButton131 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcBagAddButton102 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcBagAddButton129 As CtrlOpcBagAddButton
    Friend WithEvents CtrlLintAlarmIcon13 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLintAlarmIcon5 As CtrlLintAlarmIcon
    Friend WithEvents CtrlOpcTsaBagWithStorageDestination2 As CtrlOpcTsaBagWithStorageDestination
    Friend WithEvents CtrlOpcTsaBagWithStorageDestination1 As CtrlOpcTsaBagWithStorageDestination
    Friend WithEvents CtrlOpcTsaRailSequenceStep7 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcTsaRailSequenceStep6 As CtrlOpcTsaRailSequenceStep
    Friend WithEvents CtrlOpcBagAddButton103 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcBagAddButton132 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaBag19 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton133 As CtrlOpcBagAddButton
    Friend WithEvents CtrlOpcTsaBag31 As CtrlOpcTsaBag
    Friend WithEvents CtrlOpcBagAddButton134 As CtrlOpcBagAddButton
End Class
