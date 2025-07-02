Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.WinForms
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTunnelInterface
    Inherits TSA_Rail_System.CtrlOpcTsaRailFormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTunnelInterface))
        Me.lblBagDropT7 = New System.Windows.Forms.Label()
        Me.lblBagDropT6 = New System.Windows.Forms.Label()
        Me.CtrlOPCLabel7 = New Wdw_Sust.Textile.Global.Opc.WinForms.CtrlOpcBoolLabel()
        Me.WashdeckOPCGroupNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlOPCLabel6 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcBoolLabel()
        Me.CtrlLINTAlarmIcon39 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon57 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon56 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon55 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon36 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon37 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon61 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon60 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon59 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon58 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon21 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon54 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon53 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon52 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon20 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon51 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon50 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon49 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon48 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.CtrlLINTAlarmIcon18 = New Wdw_Sust.Textile.[Global].WinForms.CtrlLintAlarmIcon()
        Me.OpcBag182 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCCycleTimer40 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer41 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer42 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer43 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer44 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer45 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer46 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.OpcBag183 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag184 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag185 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag186 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag187 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag188 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag189 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag190 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag191 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag192 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag193 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag194 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag195 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag196 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag197 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag198 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag199 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag200 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag201 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag202 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag203 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag204 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag205 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag206 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag207 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag208 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag209 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag210 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag211 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag212 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag213 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag214 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCCycleTimer47 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.OpcArrow36 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow37 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow38 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow39 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow40 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow41 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow42 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcBag149 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCCycleTimer32 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer33 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer34 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer35 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer36 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer37 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.CtrlOPCCycleTimer38 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.OpcBag150 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag151 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag152 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag153 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag154 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag155 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag156 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag157 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag158 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag159 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag160 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag161 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag162 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag163 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag164 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag165 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag166 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag167 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag168 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag169 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag170 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag171 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag172 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag173 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag174 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag175 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag176 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag177 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag178 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag179 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag180 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.OpcBag181 = New Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag()
        Me.CtrlOPCCycleTimer39 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcCycleTimer()
        Me.OpcArrow29 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow30 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow31 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow32 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow33 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow34 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.OpcArrow35 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcArrow()
        Me.lblAverageBagDropCounts = New System.Windows.Forms.Label()
        Me.OpcMachineAvailabilityStatus27 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus28 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus29 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus30 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus31 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus32 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus33 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus34 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus35 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus36 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus37 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus38 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus39 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.OpcMachineAvailabilityStatus40 = New Wdw_Sust.Textile.[Global].Opc.WinForms.CtrlOpcMachineAvailabilityStatus()
        Me.lblActiveWashers = New System.Windows.Forms.Label()
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashdeckOPCGroupNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBagDropT7
        '
        Me.lblBagDropT7.AutoSize = True
        Me.lblBagDropT7.BackColor = System.Drawing.Color.White
        Me.lblBagDropT7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBagDropT7.Location = New System.Drawing.Point(238, 69)
        Me.lblBagDropT7.Name = "lblBagDropT7"
        Me.lblBagDropT7.Size = New System.Drawing.Size(164, 29)
        Me.lblBagDropT7.TabIndex = 820
        Me.lblBagDropT7.Text = "Calculating..."
        '
        'lblBagDropT6
        '
        Me.lblBagDropT6.AutoSize = True
        Me.lblBagDropT6.BackColor = System.Drawing.Color.White
        Me.lblBagDropT6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBagDropT6.Location = New System.Drawing.Point(-1, 69)
        Me.lblBagDropT6.Name = "lblBagDropT6"
        Me.lblBagDropT6.Size = New System.Drawing.Size(164, 29)
        Me.lblBagDropT6.TabIndex = 819
        Me.lblBagDropT6.Text = "Calculating..."
        '
        'CtrlOPCLabel7
        '
        Me.CtrlOPCLabel7.BackColor = System.Drawing.Color.White
        Me.CtrlOPCLabel7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCLabel7.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.CtrlOPCLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCLabel7.ForeColor = System.Drawing.Color.Red
        Me.CtrlOPCLabel7.GroupName = "Tunnel_Status"
        Me.CtrlOPCLabel7.Location = New System.Drawing.Point(240, 72)
        Me.CtrlOPCLabel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CtrlOPCLabel7.Name = "CtrlOPCLabel7"
        Me.CtrlOPCLabel7.PlcName = "TSA_Aquamizer"
        Me.CtrlOPCLabel7.Size = New System.Drawing.Size(190, 26)
        Me.CtrlOPCLabel7.TabIndex = 833
        Me.CtrlOPCLabel7.TagName = "Tunnel_End_of_Wash_Cycle[7]"
        Me.CtrlOPCLabel7.TextWhenFalse = Nothing
        Me.CtrlOPCLabel7.TextWhenTrue = "End Of Wash Cycle"
        '
        'WashdeckOPCGroupNameBindingSource
        '
        Me.WashdeckOPCGroupNameBindingSource.DataSource = GetType(TSA_Rail_System.WashdeckOpcGroupName)
        '
        'CtrlOPCLabel6
        '
        Me.CtrlOPCLabel6.BackColor = System.Drawing.Color.White
        Me.CtrlOPCLabel6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCLabel6.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.CtrlOPCLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlOPCLabel6.ForeColor = System.Drawing.Color.Red
        Me.CtrlOPCLabel6.GroupName = "Tunnel_Status"
        Me.CtrlOPCLabel6.Location = New System.Drawing.Point(0, 74)
        Me.CtrlOPCLabel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CtrlOPCLabel6.Name = "CtrlOPCLabel6"
        Me.CtrlOPCLabel6.PlcName = "TSA_Aquamizer"
        Me.CtrlOPCLabel6.Size = New System.Drawing.Size(192, 26)
        Me.CtrlOPCLabel6.TabIndex = 832
        Me.CtrlOPCLabel6.TagName = "Tunnel_End_of_Wash_Cycle[6]"
        Me.CtrlOPCLabel6.TextWhenFalse = Nothing
        Me.CtrlOPCLabel6.TextWhenTrue = "End Of Wash Cycle"
        '
        'CtrlLINTAlarmIcon39
        '
        Me.CtrlLINTAlarmIcon39.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon39.Location = New System.Drawing.Point(20, 181)
        Me.CtrlLINTAlarmIcon39.Name = "CtrlLINTAlarmIcon39"
        Me.CtrlLINTAlarmIcon39.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon39.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon39.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon39.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon39.TabIndex = 802
        '
        'CtrlLINTAlarmIcon57
        '
        Me.CtrlLINTAlarmIcon57.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon57.Location = New System.Drawing.Point(434, 339)
        Me.CtrlLINTAlarmIcon57.Name = "CtrlLINTAlarmIcon57"
        Me.CtrlLINTAlarmIcon57.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon57.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon57.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon57.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon57.TabIndex = 800
        '
        'CtrlLINTAlarmIcon56
        '
        Me.CtrlLINTAlarmIcon56.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon56.Location = New System.Drawing.Point(434, 232)
        Me.CtrlLINTAlarmIcon56.Name = "CtrlLINTAlarmIcon56"
        Me.CtrlLINTAlarmIcon56.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon56.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon56.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon56.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon56.TabIndex = 799
        '
        'CtrlLINTAlarmIcon55
        '
        Me.CtrlLINTAlarmIcon55.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon55.Location = New System.Drawing.Point(434, 125)
        Me.CtrlLINTAlarmIcon55.Name = "CtrlLINTAlarmIcon55"
        Me.CtrlLINTAlarmIcon55.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon55.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon55.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon55.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon55.TabIndex = 798
        '
        'CtrlLINTAlarmIcon36
        '
        Me.CtrlLINTAlarmIcon36.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon36.Location = New System.Drawing.Point(256, 181)
        Me.CtrlLINTAlarmIcon36.Name = "CtrlLINTAlarmIcon36"
        Me.CtrlLINTAlarmIcon36.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon36.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon36.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon36.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon36.TabIndex = 797
        '
        'CtrlLINTAlarmIcon37
        '
        Me.CtrlLINTAlarmIcon37.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon37.Location = New System.Drawing.Point(436, 33)
        Me.CtrlLINTAlarmIcon37.Name = "CtrlLINTAlarmIcon37"
        Me.CtrlLINTAlarmIcon37.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon37.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon37.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon37.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon37.TabIndex = 796
        '
        'CtrlLINTAlarmIcon61
        '
        Me.CtrlLINTAlarmIcon61.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon61.Location = New System.Drawing.Point(435, 761)
        Me.CtrlLINTAlarmIcon61.Name = "CtrlLINTAlarmIcon61"
        Me.CtrlLINTAlarmIcon61.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon61.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon61.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon61.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon61.TabIndex = 795
        '
        'CtrlLINTAlarmIcon60
        '
        Me.CtrlLINTAlarmIcon60.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon60.Location = New System.Drawing.Point(435, 656)
        Me.CtrlLINTAlarmIcon60.Name = "CtrlLINTAlarmIcon60"
        Me.CtrlLINTAlarmIcon60.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon60.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon60.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon60.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon60.TabIndex = 794
        '
        'CtrlLINTAlarmIcon59
        '
        Me.CtrlLINTAlarmIcon59.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon59.Location = New System.Drawing.Point(435, 550)
        Me.CtrlLINTAlarmIcon59.Name = "CtrlLINTAlarmIcon59"
        Me.CtrlLINTAlarmIcon59.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon59.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon59.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon59.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon59.TabIndex = 793
        '
        'CtrlLINTAlarmIcon58
        '
        Me.CtrlLINTAlarmIcon58.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon58.Location = New System.Drawing.Point(435, 444)
        Me.CtrlLINTAlarmIcon58.Name = "CtrlLINTAlarmIcon58"
        Me.CtrlLINTAlarmIcon58.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon58.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon58.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon58.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon58.TabIndex = 792
        '
        'CtrlLINTAlarmIcon21
        '
        Me.CtrlLINTAlarmIcon21.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon21.Location = New System.Drawing.Point(297, 748)
        Me.CtrlLINTAlarmIcon21.Name = "CtrlLINTAlarmIcon21"
        Me.CtrlLINTAlarmIcon21.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon21.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon21.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon21.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon21.TabIndex = 791
        '
        'CtrlLINTAlarmIcon54
        '
        Me.CtrlLINTAlarmIcon54.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon54.Location = New System.Drawing.Point(194, 763)
        Me.CtrlLINTAlarmIcon54.Name = "CtrlLINTAlarmIcon54"
        Me.CtrlLINTAlarmIcon54.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon54.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon54.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon54.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon54.TabIndex = 790
        '
        'CtrlLINTAlarmIcon53
        '
        Me.CtrlLINTAlarmIcon53.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon53.Location = New System.Drawing.Point(194, 654)
        Me.CtrlLINTAlarmIcon53.Name = "CtrlLINTAlarmIcon53"
        Me.CtrlLINTAlarmIcon53.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon53.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon53.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon53.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon53.TabIndex = 789
        '
        'CtrlLINTAlarmIcon52
        '
        Me.CtrlLINTAlarmIcon52.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon52.Location = New System.Drawing.Point(194, 547)
        Me.CtrlLINTAlarmIcon52.Name = "CtrlLINTAlarmIcon52"
        Me.CtrlLINTAlarmIcon52.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon52.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon52.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon52.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon52.TabIndex = 788
        '
        'CtrlLINTAlarmIcon20
        '
        Me.CtrlLINTAlarmIcon20.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon20.Location = New System.Drawing.Point(59, 749)
        Me.CtrlLINTAlarmIcon20.Name = "CtrlLINTAlarmIcon20"
        Me.CtrlLINTAlarmIcon20.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon20.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon20.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon20.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon20.TabIndex = 787
        '
        'CtrlLINTAlarmIcon51
        '
        Me.CtrlLINTAlarmIcon51.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon51.Location = New System.Drawing.Point(194, 442)
        Me.CtrlLINTAlarmIcon51.Name = "CtrlLINTAlarmIcon51"
        Me.CtrlLINTAlarmIcon51.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon51.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon51.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon51.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon51.TabIndex = 786
        '
        'CtrlLINTAlarmIcon50
        '
        Me.CtrlLINTAlarmIcon50.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon50.Location = New System.Drawing.Point(194, 336)
        Me.CtrlLINTAlarmIcon50.Name = "CtrlLINTAlarmIcon50"
        Me.CtrlLINTAlarmIcon50.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon50.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon50.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon50.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon50.TabIndex = 785
        '
        'CtrlLINTAlarmIcon49
        '
        Me.CtrlLINTAlarmIcon49.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon49.Location = New System.Drawing.Point(194, 231)
        Me.CtrlLINTAlarmIcon49.Name = "CtrlLINTAlarmIcon49"
        Me.CtrlLINTAlarmIcon49.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon49.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon49.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon49.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon49.TabIndex = 784
        '
        'CtrlLINTAlarmIcon48
        '
        Me.CtrlLINTAlarmIcon48.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon48.Location = New System.Drawing.Point(194, 125)
        Me.CtrlLINTAlarmIcon48.Name = "CtrlLINTAlarmIcon48"
        Me.CtrlLINTAlarmIcon48.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon48.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon48.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon48.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon48.TabIndex = 783
        '
        'CtrlLINTAlarmIcon18
        '
        Me.CtrlLINTAlarmIcon18.BackColor = System.Drawing.Color.White
        Me.CtrlLINTAlarmIcon18.Location = New System.Drawing.Point(199, 33)
        Me.CtrlLINTAlarmIcon18.Name = "CtrlLINTAlarmIcon18"
        Me.CtrlLINTAlarmIcon18.ParentBroadcaster = Nothing
        Me.CtrlLINTAlarmIcon18.Size = New System.Drawing.Size(36, 36)
        Me.CtrlLINTAlarmIcon18.SubscribedAlarms = CType(resources.GetObject("CtrlLINTAlarmIcon18.SubscribedAlarms"), System.Collections.Generic.List(Of Integer))
        Me.CtrlLINTAlarmIcon18.TabIndex = 782
        '
        'OpcBag182
        '
        Me.OpcBag182.BackColor = System.Drawing.Color.White
        Me.OpcBag182.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag182.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag182.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag182.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag182.Category = 88
        Me.OpcBag182.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSACleanworkPLC", True))
        Me.OpcBag182.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel1", True))
        Me.OpcBag182.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag182.GroupName = "Empty_Bags"
        Me.OpcBag182.Location = New System.Drawing.Point(439, 72)
        Me.OpcBag182.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag182.Name = "OpcBag182"
        Me.OpcBag182.PLC_Bag_ID = 0
        Me.OpcBag182.PlcName = ""
        Me.OpcBag182.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag182.TabIndex = 743
        Me.OpcBag182.TagName = "VC_Track[19,1]"
        Me.OpcBag182.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLEANWORK_ONGOING_BUFFER
        '
        'CtrlOPCCycleTimer40
        '
        Me.CtrlOPCCycleTimer40.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer40.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer40.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer40.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer40.Location = New System.Drawing.Point(382, 762)
        Me.CtrlOPCCycleTimer40.Name = "CtrlOPCCycleTimer40"
        Me.CtrlOPCCycleTimer40.PlcName = ""
        Me.CtrlOPCCycleTimer40.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer40.TabIndex = 742
        Me.CtrlOPCCycleTimer40.TagName = "Tunnel[7].Dryers[7].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer40.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer40.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer41
        '
        Me.CtrlOPCCycleTimer41.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer41.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer41.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer41.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer41.Location = New System.Drawing.Point(382, 657)
        Me.CtrlOPCCycleTimer41.Name = "CtrlOPCCycleTimer41"
        Me.CtrlOPCCycleTimer41.PlcName = ""
        Me.CtrlOPCCycleTimer41.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer41.TabIndex = 741
        Me.CtrlOPCCycleTimer41.TagName = "Tunnel[7].Dryers[6].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer41.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer41.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer42
        '
        Me.CtrlOPCCycleTimer42.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer42.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer42.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer42.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer42.Location = New System.Drawing.Point(383, 551)
        Me.CtrlOPCCycleTimer42.Name = "CtrlOPCCycleTimer42"
        Me.CtrlOPCCycleTimer42.PlcName = ""
        Me.CtrlOPCCycleTimer42.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer42.TabIndex = 740
        Me.CtrlOPCCycleTimer42.TagName = "Tunnel[7].Dryers[5].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer42.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer42.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer43
        '
        Me.CtrlOPCCycleTimer43.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer43.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer43.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer43.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer43.Location = New System.Drawing.Point(382, 445)
        Me.CtrlOPCCycleTimer43.Name = "CtrlOPCCycleTimer43"
        Me.CtrlOPCCycleTimer43.PlcName = ""
        Me.CtrlOPCCycleTimer43.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer43.TabIndex = 739
        Me.CtrlOPCCycleTimer43.TagName = "Tunnel[7].Dryers[4].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer43.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer43.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer44
        '
        Me.CtrlOPCCycleTimer44.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer44.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer44.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer44.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer44.Location = New System.Drawing.Point(382, 340)
        Me.CtrlOPCCycleTimer44.Name = "CtrlOPCCycleTimer44"
        Me.CtrlOPCCycleTimer44.PlcName = ""
        Me.CtrlOPCCycleTimer44.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer44.TabIndex = 738
        Me.CtrlOPCCycleTimer44.TagName = "Tunnel[7].Dryers[3].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer44.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer44.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer45
        '
        Me.CtrlOPCCycleTimer45.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer45.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer45.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer45.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer45.Location = New System.Drawing.Point(383, 235)
        Me.CtrlOPCCycleTimer45.Name = "CtrlOPCCycleTimer45"
        Me.CtrlOPCCycleTimer45.PlcName = ""
        Me.CtrlOPCCycleTimer45.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer45.TabIndex = 737
        Me.CtrlOPCCycleTimer45.TagName = "Tunnel[7].Dryers[2].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer45.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer45.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer46
        '
        Me.CtrlOPCCycleTimer46.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer46.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer46.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer46.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer46.Location = New System.Drawing.Point(384, 128)
        Me.CtrlOPCCycleTimer46.Name = "CtrlOPCCycleTimer46"
        Me.CtrlOPCCycleTimer46.PlcName = ""
        Me.CtrlOPCCycleTimer46.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer46.TabIndex = 736
        Me.CtrlOPCCycleTimer46.TagName = "Tunnel[7].Dryers[1].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer46.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer46.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'OpcBag183
        '
        Me.OpcBag183.BackColor = System.Drawing.Color.White
        Me.OpcBag183.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag183.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag183.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag183.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag183.Category = 88
        Me.OpcBag183.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag183.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag183.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag183.GroupName = "Tunnel_7"
        Me.OpcBag183.Location = New System.Drawing.Point(329, 235)
        Me.OpcBag183.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag183.Name = "OpcBag183"
        Me.OpcBag183.PLC_Bag_ID = 0
        Me.OpcBag183.PlcName = ""
        Me.OpcBag183.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag183.TabIndex = 735
        Me.OpcBag183.TagName = "Tunnel[7].Shuttle.Belt_A_Bag_Data"
        Me.OpcBag183.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag184
        '
        Me.OpcBag184.BackColor = System.Drawing.Color.White
        Me.OpcBag184.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag184.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag184.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag184.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag184.Category = 88
        Me.OpcBag184.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag184.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag184.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag184.GroupName = "Tunnel_7"
        Me.OpcBag184.Location = New System.Drawing.Point(297, 235)
        Me.OpcBag184.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag184.Name = "OpcBag184"
        Me.OpcBag184.PLC_Bag_ID = 0
        Me.OpcBag184.PlcName = ""
        Me.OpcBag184.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag184.TabIndex = 734
        Me.OpcBag184.TagName = "Tunnel[7].Shuttle.Belt_B_Bag_Data"
        Me.OpcBag184.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag185
        '
        Me.OpcBag185.BackColor = System.Drawing.Color.White
        Me.OpcBag185.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag185.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag185.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag185.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag185.Category = 88
        Me.OpcBag185.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag185.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag185.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag185.GroupName = "Tunnel_7"
        Me.OpcBag185.Location = New System.Drawing.Point(403, 777)
        Me.OpcBag185.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag185.Name = "OpcBag185"
        Me.OpcBag185.PLC_Bag_ID = 0
        Me.OpcBag185.PlcName = ""
        Me.OpcBag185.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag185.TabIndex = 733
        Me.OpcBag185.TagName = "Tunnel[7].Dryers[7].Bag_Data[1]"
        Me.OpcBag185.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag186
        '
        Me.OpcBag186.BackColor = System.Drawing.Color.White
        Me.OpcBag186.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag186.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag186.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag186.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag186.Category = 88
        Me.OpcBag186.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag186.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag186.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag186.GroupName = "Tunnel_7"
        Me.OpcBag186.Location = New System.Drawing.Point(374, 777)
        Me.OpcBag186.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag186.Name = "OpcBag186"
        Me.OpcBag186.PLC_Bag_ID = 0
        Me.OpcBag186.PlcName = ""
        Me.OpcBag186.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag186.TabIndex = 732
        Me.OpcBag186.TagName = "Tunnel[7].Dryers[7].Bag_Data[2]"
        Me.OpcBag186.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag187
        '
        Me.OpcBag187.BackColor = System.Drawing.Color.White
        Me.OpcBag187.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag187.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag187.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag187.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag187.Category = 88
        Me.OpcBag187.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag187.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag187.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag187.GroupName = "Tunnel_7"
        Me.OpcBag187.Location = New System.Drawing.Point(403, 673)
        Me.OpcBag187.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag187.Name = "OpcBag187"
        Me.OpcBag187.PLC_Bag_ID = 0
        Me.OpcBag187.PlcName = ""
        Me.OpcBag187.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag187.TabIndex = 731
        Me.OpcBag187.TagName = "Tunnel[7].Dryers[6].Bag_Data[1]"
        Me.OpcBag187.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag188
        '
        Me.OpcBag188.BackColor = System.Drawing.Color.White
        Me.OpcBag188.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag188.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag188.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag188.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag188.Category = 88
        Me.OpcBag188.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag188.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag188.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag188.GroupName = "Tunnel_7"
        Me.OpcBag188.Location = New System.Drawing.Point(374, 673)
        Me.OpcBag188.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag188.Name = "OpcBag188"
        Me.OpcBag188.PLC_Bag_ID = 0
        Me.OpcBag188.PlcName = ""
        Me.OpcBag188.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag188.TabIndex = 730
        Me.OpcBag188.TagName = "Tunnel[7].Dryers[6].Bag_Data[2]"
        Me.OpcBag188.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag189
        '
        Me.OpcBag189.BackColor = System.Drawing.Color.White
        Me.OpcBag189.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag189.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag189.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag189.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag189.Category = 88
        Me.OpcBag189.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag189.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag189.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag189.GroupName = "Tunnel_7"
        Me.OpcBag189.Location = New System.Drawing.Point(403, 567)
        Me.OpcBag189.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag189.Name = "OpcBag189"
        Me.OpcBag189.PLC_Bag_ID = 0
        Me.OpcBag189.PlcName = ""
        Me.OpcBag189.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag189.TabIndex = 729
        Me.OpcBag189.TagName = "Tunnel[7].Dryers[5].Bag_Data[1]"
        Me.OpcBag189.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag190
        '
        Me.OpcBag190.BackColor = System.Drawing.Color.White
        Me.OpcBag190.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag190.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag190.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag190.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag190.Category = 88
        Me.OpcBag190.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag190.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag190.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag190.GroupName = "Tunnel_7"
        Me.OpcBag190.Location = New System.Drawing.Point(374, 567)
        Me.OpcBag190.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag190.Name = "OpcBag190"
        Me.OpcBag190.PLC_Bag_ID = 0
        Me.OpcBag190.PlcName = ""
        Me.OpcBag190.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag190.TabIndex = 728
        Me.OpcBag190.TagName = "Tunnel[7].Dryers[5].Bag_Data[2]"
        Me.OpcBag190.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag191
        '
        Me.OpcBag191.BackColor = System.Drawing.Color.White
        Me.OpcBag191.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag191.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag191.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag191.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag191.Category = 88
        Me.OpcBag191.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag191.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag191.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag191.GroupName = "Tunnel_7"
        Me.OpcBag191.Location = New System.Drawing.Point(404, 462)
        Me.OpcBag191.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag191.Name = "OpcBag191"
        Me.OpcBag191.PLC_Bag_ID = 0
        Me.OpcBag191.PlcName = ""
        Me.OpcBag191.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag191.TabIndex = 727
        Me.OpcBag191.TagName = "Tunnel[7].Dryers[4].Bag_Data[1]"
        Me.OpcBag191.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag192
        '
        Me.OpcBag192.BackColor = System.Drawing.Color.White
        Me.OpcBag192.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag192.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag192.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag192.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag192.Category = 88
        Me.OpcBag192.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag192.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag192.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag192.GroupName = "Tunnel_7"
        Me.OpcBag192.Location = New System.Drawing.Point(375, 462)
        Me.OpcBag192.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag192.Name = "OpcBag192"
        Me.OpcBag192.PLC_Bag_ID = 0
        Me.OpcBag192.PlcName = ""
        Me.OpcBag192.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag192.TabIndex = 726
        Me.OpcBag192.TagName = "Tunnel[7].Dryers[4].Bag_Data[2]"
        Me.OpcBag192.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag193
        '
        Me.OpcBag193.BackColor = System.Drawing.Color.White
        Me.OpcBag193.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag193.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag193.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag193.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag193.Category = 88
        Me.OpcBag193.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag193.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag193.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag193.GroupName = "Tunnel_7"
        Me.OpcBag193.Location = New System.Drawing.Point(403, 355)
        Me.OpcBag193.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag193.Name = "OpcBag193"
        Me.OpcBag193.PLC_Bag_ID = 0
        Me.OpcBag193.PlcName = ""
        Me.OpcBag193.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag193.TabIndex = 725
        Me.OpcBag193.TagName = "Tunnel[7].Dryers[3].Bag_Data[1]"
        Me.OpcBag193.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag194
        '
        Me.OpcBag194.BackColor = System.Drawing.Color.White
        Me.OpcBag194.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag194.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag194.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag194.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag194.Category = 88
        Me.OpcBag194.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag194.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag194.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag194.GroupName = "Tunnel_7"
        Me.OpcBag194.Location = New System.Drawing.Point(374, 355)
        Me.OpcBag194.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag194.Name = "OpcBag194"
        Me.OpcBag194.PLC_Bag_ID = 0
        Me.OpcBag194.PlcName = ""
        Me.OpcBag194.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag194.TabIndex = 724
        Me.OpcBag194.TagName = "Tunnel[7].Dryers[3].Bag_Data[2]"
        Me.OpcBag194.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag195
        '
        Me.OpcBag195.BackColor = System.Drawing.Color.White
        Me.OpcBag195.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag195.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag195.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag195.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag195.Category = 88
        Me.OpcBag195.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag195.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag195.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag195.GroupName = "Tunnel_7"
        Me.OpcBag195.Location = New System.Drawing.Point(403, 142)
        Me.OpcBag195.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag195.Name = "OpcBag195"
        Me.OpcBag195.PLC_Bag_ID = 0
        Me.OpcBag195.PlcName = ""
        Me.OpcBag195.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag195.TabIndex = 723
        Me.OpcBag195.TagName = "Tunnel[7].Dryers[1].Bag_Data[1]"
        Me.OpcBag195.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag196
        '
        Me.OpcBag196.BackColor = System.Drawing.Color.White
        Me.OpcBag196.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag196.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag196.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag196.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag196.Category = 88
        Me.OpcBag196.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag196.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag196.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag196.GroupName = "Tunnel_7"
        Me.OpcBag196.Location = New System.Drawing.Point(374, 142)
        Me.OpcBag196.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag196.Name = "OpcBag196"
        Me.OpcBag196.PLC_Bag_ID = 0
        Me.OpcBag196.PlcName = ""
        Me.OpcBag196.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag196.TabIndex = 722
        Me.OpcBag196.TagName = "Tunnel[7].Dryers[1].Bag_Data[2]"
        Me.OpcBag196.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag197
        '
        Me.OpcBag197.BackColor = System.Drawing.Color.White
        Me.OpcBag197.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag197.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag197.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag197.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag197.Category = 88
        Me.OpcBag197.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag197.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag197.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag197.GroupName = "Tunnel_7"
        Me.OpcBag197.Location = New System.Drawing.Point(403, 250)
        Me.OpcBag197.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag197.Name = "OpcBag197"
        Me.OpcBag197.PLC_Bag_ID = 0
        Me.OpcBag197.PlcName = ""
        Me.OpcBag197.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag197.TabIndex = 721
        Me.OpcBag197.TagName = "Tunnel[7].Dryers[2].Bag_Data[1]"
        Me.OpcBag197.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag198
        '
        Me.OpcBag198.BackColor = System.Drawing.Color.White
        Me.OpcBag198.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag198.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag198.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag198.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag198.Category = 88
        Me.OpcBag198.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag198.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag198.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag198.GroupName = "Tunnel_7"
        Me.OpcBag198.Location = New System.Drawing.Point(374, 250)
        Me.OpcBag198.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag198.Name = "OpcBag198"
        Me.OpcBag198.PLC_Bag_ID = 0
        Me.OpcBag198.PlcName = ""
        Me.OpcBag198.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag198.TabIndex = 720
        Me.OpcBag198.TagName = "Tunnel[7].Dryers[2].Bag_Data[2]"
        Me.OpcBag198.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag199
        '
        Me.OpcBag199.BackColor = System.Drawing.Color.White
        Me.OpcBag199.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag199.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag199.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag199.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag199.Category = 88
        Me.OpcBag199.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag199.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag199.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag199.GroupName = "Tunnel_7"
        Me.OpcBag199.Location = New System.Drawing.Point(256, 754)
        Me.OpcBag199.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag199.Name = "OpcBag199"
        Me.OpcBag199.PLC_Bag_ID = 0
        Me.OpcBag199.PlcName = ""
        Me.OpcBag199.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag199.TabIndex = 719
        Me.OpcBag199.TagName = "Tunnel[7].Loading_Position_Bag_Data"
        Me.OpcBag199.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag200
        '
        Me.OpcBag200.BackColor = System.Drawing.Color.White
        Me.OpcBag200.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag200.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag200.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag200.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag200.Category = 88
        Me.OpcBag200.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag200.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag200.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag200.GroupName = "Tunnel_7"
        Me.OpcBag200.Location = New System.Drawing.Point(256, 674)
        Me.OpcBag200.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag200.Name = "OpcBag200"
        Me.OpcBag200.PLC_Bag_ID = 0
        Me.OpcBag200.PlcName = ""
        Me.OpcBag200.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag200.TabIndex = 718
        Me.OpcBag200.TagName = "Tunnel[7].Washer_Compartment_Data[1]"
        Me.OpcBag200.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag201
        '
        Me.OpcBag201.BackColor = System.Drawing.Color.White
        Me.OpcBag201.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag201.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag201.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag201.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag201.Category = 88
        Me.OpcBag201.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag201.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag201.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag201.GroupName = "Tunnel_7"
        Me.OpcBag201.Location = New System.Drawing.Point(256, 644)
        Me.OpcBag201.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag201.Name = "OpcBag201"
        Me.OpcBag201.PLC_Bag_ID = 0
        Me.OpcBag201.PlcName = ""
        Me.OpcBag201.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag201.TabIndex = 717
        Me.OpcBag201.TagName = "Tunnel[7].Washer_Compartment_Data[2]"
        Me.OpcBag201.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag202
        '
        Me.OpcBag202.BackColor = System.Drawing.Color.White
        Me.OpcBag202.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag202.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag202.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag202.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag202.Category = 88
        Me.OpcBag202.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag202.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag202.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag202.GroupName = "Tunnel_7"
        Me.OpcBag202.Location = New System.Drawing.Point(256, 614)
        Me.OpcBag202.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag202.Name = "OpcBag202"
        Me.OpcBag202.PLC_Bag_ID = 0
        Me.OpcBag202.PlcName = ""
        Me.OpcBag202.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag202.TabIndex = 716
        Me.OpcBag202.TagName = "Tunnel[7].Washer_Compartment_Data[3]"
        Me.OpcBag202.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag203
        '
        Me.OpcBag203.BackColor = System.Drawing.Color.White
        Me.OpcBag203.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag203.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag203.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag203.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag203.Category = 88
        Me.OpcBag203.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag203.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag203.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag203.GroupName = "Tunnel_7"
        Me.OpcBag203.Location = New System.Drawing.Point(256, 584)
        Me.OpcBag203.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag203.Name = "OpcBag203"
        Me.OpcBag203.PLC_Bag_ID = 0
        Me.OpcBag203.PlcName = ""
        Me.OpcBag203.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag203.TabIndex = 715
        Me.OpcBag203.TagName = "Tunnel[7].Washer_Compartment_Data[4]"
        Me.OpcBag203.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag204
        '
        Me.OpcBag204.BackColor = System.Drawing.Color.White
        Me.OpcBag204.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag204.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag204.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag204.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag204.Category = 88
        Me.OpcBag204.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag204.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag204.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag204.GroupName = "Tunnel_7"
        Me.OpcBag204.Location = New System.Drawing.Point(256, 554)
        Me.OpcBag204.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag204.Name = "OpcBag204"
        Me.OpcBag204.PLC_Bag_ID = 0
        Me.OpcBag204.PlcName = ""
        Me.OpcBag204.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag204.TabIndex = 714
        Me.OpcBag204.TagName = "Tunnel[7].Washer_Compartment_Data[5]"
        Me.OpcBag204.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag205
        '
        Me.OpcBag205.BackColor = System.Drawing.Color.White
        Me.OpcBag205.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag205.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag205.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag205.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag205.Category = 88
        Me.OpcBag205.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag205.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag205.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag205.GroupName = "Tunnel_7"
        Me.OpcBag205.Location = New System.Drawing.Point(256, 524)
        Me.OpcBag205.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag205.Name = "OpcBag205"
        Me.OpcBag205.PLC_Bag_ID = 0
        Me.OpcBag205.PlcName = ""
        Me.OpcBag205.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag205.TabIndex = 713
        Me.OpcBag205.TagName = "Tunnel[7].Washer_Compartment_Data[6]"
        Me.OpcBag205.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag206
        '
        Me.OpcBag206.BackColor = System.Drawing.Color.White
        Me.OpcBag206.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag206.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag206.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag206.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag206.Category = 88
        Me.OpcBag206.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag206.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag206.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag206.GroupName = "Tunnel_7"
        Me.OpcBag206.Location = New System.Drawing.Point(256, 493)
        Me.OpcBag206.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag206.Name = "OpcBag206"
        Me.OpcBag206.PLC_Bag_ID = 0
        Me.OpcBag206.PlcName = ""
        Me.OpcBag206.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag206.TabIndex = 712
        Me.OpcBag206.TagName = "Tunnel[7].Washer_Compartment_Data[7]"
        Me.OpcBag206.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag207
        '
        Me.OpcBag207.BackColor = System.Drawing.Color.White
        Me.OpcBag207.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag207.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag207.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag207.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag207.Category = 88
        Me.OpcBag207.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag207.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag207.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag207.GroupName = "Tunnel_7"
        Me.OpcBag207.Location = New System.Drawing.Point(256, 463)
        Me.OpcBag207.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag207.Name = "OpcBag207"
        Me.OpcBag207.PLC_Bag_ID = 0
        Me.OpcBag207.PlcName = ""
        Me.OpcBag207.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag207.TabIndex = 711
        Me.OpcBag207.TagName = "Tunnel[7].Washer_Compartment_Data[8]"
        Me.OpcBag207.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag208
        '
        Me.OpcBag208.BackColor = System.Drawing.Color.White
        Me.OpcBag208.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag208.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag208.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag208.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag208.Category = 88
        Me.OpcBag208.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag208.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag208.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag208.GroupName = "Tunnel_7"
        Me.OpcBag208.Location = New System.Drawing.Point(256, 433)
        Me.OpcBag208.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag208.Name = "OpcBag208"
        Me.OpcBag208.PLC_Bag_ID = 0
        Me.OpcBag208.PlcName = ""
        Me.OpcBag208.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag208.TabIndex = 710
        Me.OpcBag208.TagName = "Tunnel[7].Washer_Compartment_Data[9]"
        Me.OpcBag208.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag209
        '
        Me.OpcBag209.BackColor = System.Drawing.Color.White
        Me.OpcBag209.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag209.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag209.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag209.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag209.Category = 88
        Me.OpcBag209.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag209.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag209.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag209.GroupName = "Tunnel_7"
        Me.OpcBag209.Location = New System.Drawing.Point(256, 403)
        Me.OpcBag209.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag209.Name = "OpcBag209"
        Me.OpcBag209.PLC_Bag_ID = 0
        Me.OpcBag209.PlcName = ""
        Me.OpcBag209.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag209.TabIndex = 709
        Me.OpcBag209.TagName = "Tunnel[7].Washer_Compartment_Data[10]"
        Me.OpcBag209.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag210
        '
        Me.OpcBag210.BackColor = System.Drawing.Color.White
        Me.OpcBag210.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag210.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag210.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag210.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag210.Category = 88
        Me.OpcBag210.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag210.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag210.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag210.GroupName = "Tunnel_7"
        Me.OpcBag210.Location = New System.Drawing.Point(256, 373)
        Me.OpcBag210.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag210.Name = "OpcBag210"
        Me.OpcBag210.PLC_Bag_ID = 0
        Me.OpcBag210.PlcName = ""
        Me.OpcBag210.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag210.TabIndex = 708
        Me.OpcBag210.TagName = "Tunnel[7].Washer_Compartment_Data[11]"
        Me.OpcBag210.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag211
        '
        Me.OpcBag211.BackColor = System.Drawing.Color.White
        Me.OpcBag211.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag211.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag211.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag211.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag211.Category = 88
        Me.OpcBag211.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag211.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag211.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag211.GroupName = "Tunnel_7"
        Me.OpcBag211.Location = New System.Drawing.Point(256, 343)
        Me.OpcBag211.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag211.Name = "OpcBag211"
        Me.OpcBag211.PLC_Bag_ID = 0
        Me.OpcBag211.PlcName = ""
        Me.OpcBag211.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag211.TabIndex = 707
        Me.OpcBag211.TagName = "Tunnel[7].Washer_Compartment_Data[12]"
        Me.OpcBag211.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag212
        '
        Me.OpcBag212.BackColor = System.Drawing.Color.White
        Me.OpcBag212.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag212.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag212.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag212.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag212.Category = 88
        Me.OpcBag212.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag212.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag212.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag212.GroupName = "Tunnel_7"
        Me.OpcBag212.Location = New System.Drawing.Point(256, 313)
        Me.OpcBag212.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag212.Name = "OpcBag212"
        Me.OpcBag212.PLC_Bag_ID = 0
        Me.OpcBag212.PlcName = ""
        Me.OpcBag212.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag212.TabIndex = 706
        Me.OpcBag212.TagName = "Tunnel[7].Washer_Compartment_Data[13]"
        Me.OpcBag212.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag213
        '
        Me.OpcBag213.BackColor = System.Drawing.Color.White
        Me.OpcBag213.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag213.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag213.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag213.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag213.Category = 88
        Me.OpcBag213.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag213.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag213.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag213.GroupName = "Tunnel_7"
        Me.OpcBag213.Location = New System.Drawing.Point(256, 283)
        Me.OpcBag213.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag213.Name = "OpcBag213"
        Me.OpcBag213.PLC_Bag_ID = 0
        Me.OpcBag213.PlcName = ""
        Me.OpcBag213.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag213.TabIndex = 705
        Me.OpcBag213.TagName = "Tunnel[7].Washer_Compartment_Data[14]"
        Me.OpcBag213.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag214
        '
        Me.OpcBag214.BackColor = System.Drawing.Color.White
        Me.OpcBag214.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag214.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag214.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag214.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag214.Category = 88
        Me.OpcBag214.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel7", True))
        Me.OpcBag214.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag214.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag214.GroupName = "Tunnel_7"
        Me.OpcBag214.Location = New System.Drawing.Point(256, 230)
        Me.OpcBag214.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag214.Name = "OpcBag214"
        Me.OpcBag214.PLC_Bag_ID = 0
        Me.OpcBag214.PlcName = ""
        Me.OpcBag214.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag214.TabIndex = 704
        Me.OpcBag214.TagName = "Tunnel[7].Press.Press_Bag_Data"
        Me.OpcBag214.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'CtrlOPCCycleTimer47
        '
        Me.CtrlOPCCycleTimer47.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer47.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer47.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer47.GroupName = "Press_Timers"
        Me.CtrlOPCCycleTimer47.Location = New System.Drawing.Point(247, 258)
        Me.CtrlOPCCycleTimer47.Name = "CtrlOPCCycleTimer47"
        Me.CtrlOPCCycleTimer47.PlcName = ""
        Me.CtrlOPCCycleTimer47.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer47.TabIndex = 703
        Me.CtrlOPCCycleTimer47.TagName = "Tunnel[7].Press.Press_Current_Cycle_Time"
        Me.CtrlOPCCycleTimer47.ThresholdBlinkValue = 180
        Me.CtrlOPCCycleTimer47.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'OpcArrow36
        '
        Me.OpcArrow36.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow36.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow36.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow36.GroupName = "Shuttles"
        Me.OpcArrow36.Location = New System.Drawing.Point(358, 757)
        Me.OpcArrow36.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow36.Name = "OpcArrow36"
        Me.OpcArrow36.PlcName = ""
        Me.OpcArrow36.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow36.TabIndex = 695
        Me.OpcArrow36.TagName = "Tunnel[7].Shuttle.Position_Dryer_7"
        '
        'OpcArrow37
        '
        Me.OpcArrow37.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow37.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow37.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow37.GroupName = "Shuttles"
        Me.OpcArrow37.Location = New System.Drawing.Point(358, 651)
        Me.OpcArrow37.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow37.Name = "OpcArrow37"
        Me.OpcArrow37.PlcName = ""
        Me.OpcArrow37.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow37.TabIndex = 694
        Me.OpcArrow37.TagName = "Tunnel[7].Shuttle.Position_Dryer_6"
        '
        'OpcArrow38
        '
        Me.OpcArrow38.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow38.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow38.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow38.GroupName = "Shuttles"
        Me.OpcArrow38.Location = New System.Drawing.Point(358, 546)
        Me.OpcArrow38.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow38.Name = "OpcArrow38"
        Me.OpcArrow38.PlcName = ""
        Me.OpcArrow38.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow38.TabIndex = 693
        Me.OpcArrow38.TagName = "Tunnel[7].Shuttle.Position_Dryer_5"
        '
        'OpcArrow39
        '
        Me.OpcArrow39.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow39.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow39.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow39.GroupName = "Shuttles"
        Me.OpcArrow39.Location = New System.Drawing.Point(358, 439)
        Me.OpcArrow39.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow39.Name = "OpcArrow39"
        Me.OpcArrow39.PlcName = ""
        Me.OpcArrow39.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow39.TabIndex = 692
        Me.OpcArrow39.TagName = "Tunnel[7].Shuttle.Position_Dryer_4"
        '
        'OpcArrow40
        '
        Me.OpcArrow40.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow40.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow40.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow40.GroupName = "Shuttles"
        Me.OpcArrow40.Location = New System.Drawing.Point(358, 334)
        Me.OpcArrow40.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow40.Name = "OpcArrow40"
        Me.OpcArrow40.PlcName = ""
        Me.OpcArrow40.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow40.TabIndex = 691
        Me.OpcArrow40.TagName = "Tunnel[7].Shuttle.Position_Dryer_3"
        '
        'OpcArrow41
        '
        Me.OpcArrow41.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow41.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow41.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow41.GroupName = "Shuttles"
        Me.OpcArrow41.Location = New System.Drawing.Point(358, 228)
        Me.OpcArrow41.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow41.Name = "OpcArrow41"
        Me.OpcArrow41.PlcName = ""
        Me.OpcArrow41.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow41.TabIndex = 690
        Me.OpcArrow41.TagName = "Tunnel[7].Dryers[2].Dryer_Loading"
        '
        'OpcArrow42
        '
        Me.OpcArrow42.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow42.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow42.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow42.GroupName = "Shuttles"
        Me.OpcArrow42.Location = New System.Drawing.Point(358, 122)
        Me.OpcArrow42.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow42.Name = "OpcArrow42"
        Me.OpcArrow42.PlcName = ""
        Me.OpcArrow42.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow42.TabIndex = 689
        Me.OpcArrow42.TagName = "Tunnel[7].Shuttle.Position_Dryer_1"
        '
        'OpcBag149
        '
        Me.OpcBag149.BackColor = System.Drawing.Color.White
        Me.OpcBag149.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag149.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag149.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag149.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag149.Category = 88
        Me.OpcBag149.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSACleanworkPLC", True))
        Me.OpcBag149.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel1", True))
        Me.OpcBag149.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag149.GroupName = "Empty_Bags"
        Me.OpcBag149.Location = New System.Drawing.Point(202, 73)
        Me.OpcBag149.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag149.Name = "OpcBag149"
        Me.OpcBag149.PLC_Bag_ID = 0
        Me.OpcBag149.PlcName = ""
        Me.OpcBag149.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag149.TabIndex = 688
        Me.OpcBag149.TagName = "VC_Track[18,1]"
        Me.OpcBag149.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.CLEANWORK_ONGOING_BUFFER
        '
        'CtrlOPCCycleTimer32
        '
        Me.CtrlOPCCycleTimer32.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer32.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer32.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer32.Location = New System.Drawing.Point(144, 763)
        Me.CtrlOPCCycleTimer32.Name = "CtrlOPCCycleTimer32"
        Me.CtrlOPCCycleTimer32.PlcName = ""
        Me.CtrlOPCCycleTimer32.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer32.TabIndex = 687
        Me.CtrlOPCCycleTimer32.TagName = "Tunnel[6].Dryers[7].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer32.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer32.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer33
        '
        Me.CtrlOPCCycleTimer33.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer33.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer33.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer33.Location = New System.Drawing.Point(144, 657)
        Me.CtrlOPCCycleTimer33.Name = "CtrlOPCCycleTimer33"
        Me.CtrlOPCCycleTimer33.PlcName = ""
        Me.CtrlOPCCycleTimer33.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer33.TabIndex = 686
        Me.CtrlOPCCycleTimer33.TagName = "Tunnel[6].Dryers[6].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer33.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer33.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer34
        '
        Me.CtrlOPCCycleTimer34.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer34.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer34.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer34.Location = New System.Drawing.Point(144, 551)
        Me.CtrlOPCCycleTimer34.Name = "CtrlOPCCycleTimer34"
        Me.CtrlOPCCycleTimer34.PlcName = ""
        Me.CtrlOPCCycleTimer34.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer34.TabIndex = 685
        Me.CtrlOPCCycleTimer34.TagName = "Tunnel[6].Dryers[5].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer34.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer34.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer35
        '
        Me.CtrlOPCCycleTimer35.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer35.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer35.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer35.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer35.Location = New System.Drawing.Point(144, 445)
        Me.CtrlOPCCycleTimer35.Name = "CtrlOPCCycleTimer35"
        Me.CtrlOPCCycleTimer35.PlcName = ""
        Me.CtrlOPCCycleTimer35.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer35.TabIndex = 684
        Me.CtrlOPCCycleTimer35.TagName = "Tunnel[6].Dryers[4].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer35.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer35.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer36
        '
        Me.CtrlOPCCycleTimer36.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer36.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer36.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer36.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer36.Location = New System.Drawing.Point(144, 340)
        Me.CtrlOPCCycleTimer36.Name = "CtrlOPCCycleTimer36"
        Me.CtrlOPCCycleTimer36.PlcName = ""
        Me.CtrlOPCCycleTimer36.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer36.TabIndex = 683
        Me.CtrlOPCCycleTimer36.TagName = "Tunnel[6].Dryers[3].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer36.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer36.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer37
        '
        Me.CtrlOPCCycleTimer37.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer37.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer37.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer37.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer37.Location = New System.Drawing.Point(144, 234)
        Me.CtrlOPCCycleTimer37.Name = "CtrlOPCCycleTimer37"
        Me.CtrlOPCCycleTimer37.PlcName = ""
        Me.CtrlOPCCycleTimer37.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer37.TabIndex = 682
        Me.CtrlOPCCycleTimer37.TagName = "Tunnel[6].Dryers[2].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer37.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer37.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'CtrlOPCCycleTimer38
        '
        Me.CtrlOPCCycleTimer38.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer38.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer38.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer38.GroupName = "Dryer_Timers"
        Me.CtrlOPCCycleTimer38.Location = New System.Drawing.Point(144, 128)
        Me.CtrlOPCCycleTimer38.Name = "CtrlOPCCycleTimer38"
        Me.CtrlOPCCycleTimer38.PlcName = ""
        Me.CtrlOPCCycleTimer38.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer38.TabIndex = 681
        Me.CtrlOPCCycleTimer38.TagName = "Tunnel[6].Dryers[1].Current_Cycle_Time"
        Me.CtrlOPCCycleTimer38.ThresholdBlinkValue = 1800
        Me.CtrlOPCCycleTimer38.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'OpcBag150
        '
        Me.OpcBag150.BackColor = System.Drawing.Color.White
        Me.OpcBag150.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag150.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag150.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag150.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag150.Category = 88
        Me.OpcBag150.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag150.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag150.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag150.GroupName = "Tunnel_6"
        Me.OpcBag150.Location = New System.Drawing.Point(91, 235)
        Me.OpcBag150.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag150.Name = "OpcBag150"
        Me.OpcBag150.PLC_Bag_ID = 0
        Me.OpcBag150.PlcName = ""
        Me.OpcBag150.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag150.TabIndex = 680
        Me.OpcBag150.TagName = ""
        Me.OpcBag150.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag151
        '
        Me.OpcBag151.BackColor = System.Drawing.Color.White
        Me.OpcBag151.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag151.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag151.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag151.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag151.Category = 88
        Me.OpcBag151.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel6", True))
        Me.OpcBag151.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag151.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag151.GroupName = "Tunnel_6"
        Me.OpcBag151.Location = New System.Drawing.Point(59, 235)
        Me.OpcBag151.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag151.Name = "OpcBag151"
        Me.OpcBag151.PLC_Bag_ID = 0
        Me.OpcBag151.PlcName = ""
        Me.OpcBag151.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag151.TabIndex = 679
        Me.OpcBag151.TagName = "Tunnel[6].Shuttle.Belt_B_Bag_Data"
        Me.OpcBag151.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag152
        '
        Me.OpcBag152.BackColor = System.Drawing.Color.White
        Me.OpcBag152.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag152.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag152.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag152.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag152.Category = 88
        Me.OpcBag152.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag152.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag152.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag152.GroupName = "Tunnel_6"
        Me.OpcBag152.Location = New System.Drawing.Point(164, 776)
        Me.OpcBag152.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag152.Name = "OpcBag152"
        Me.OpcBag152.PLC_Bag_ID = 0
        Me.OpcBag152.PlcName = ""
        Me.OpcBag152.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag152.TabIndex = 678
        Me.OpcBag152.TagName = "T6-35-6-ILC390.OPC_WR07_sDry_Program"
        Me.OpcBag152.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag153
        '
        Me.OpcBag153.BackColor = System.Drawing.Color.White
        Me.OpcBag153.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag153.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag153.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag153.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag153.Category = 88
        Me.OpcBag153.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag153.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag153.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag153.GroupName = "Tunnel_6"
        Me.OpcBag153.Location = New System.Drawing.Point(135, 776)
        Me.OpcBag153.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag153.Name = "OpcBag153"
        Me.OpcBag153.PLC_Bag_ID = 0
        Me.OpcBag153.PlcName = ""
        Me.OpcBag153.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag153.TabIndex = 677
        Me.OpcBag153.TagName = "T6-35-6-ILC390.OPC_WR07_sDry_Program"
        Me.OpcBag153.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag154
        '
        Me.OpcBag154.BackColor = System.Drawing.Color.White
        Me.OpcBag154.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag154.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag154.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag154.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag154.Category = 88
        Me.OpcBag154.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag154.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag154.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag154.GroupName = "Tunnel_6"
        Me.OpcBag154.Location = New System.Drawing.Point(164, 672)
        Me.OpcBag154.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag154.Name = "OpcBag154"
        Me.OpcBag154.PLC_Bag_ID = 0
        Me.OpcBag154.PlcName = ""
        Me.OpcBag154.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag154.TabIndex = 676
        Me.OpcBag154.TagName = "T6-35-6-ILC390.OPC_WR06_sDry_Program"
        Me.OpcBag154.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag155
        '
        Me.OpcBag155.BackColor = System.Drawing.Color.White
        Me.OpcBag155.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag155.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag155.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag155.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag155.Category = 88
        Me.OpcBag155.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag155.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag155.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag155.GroupName = "Tunnel_6"
        Me.OpcBag155.Location = New System.Drawing.Point(135, 672)
        Me.OpcBag155.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag155.Name = "OpcBag155"
        Me.OpcBag155.PLC_Bag_ID = 0
        Me.OpcBag155.PlcName = ""
        Me.OpcBag155.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag155.TabIndex = 675
        Me.OpcBag155.TagName = "T6-35-6-ILC390.OPC_WR06_sDry_Program"
        Me.OpcBag155.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag156
        '
        Me.OpcBag156.BackColor = System.Drawing.Color.White
        Me.OpcBag156.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag156.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag156.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag156.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag156.Category = 88
        Me.OpcBag156.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag156.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag156.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag156.GroupName = "Tunnel_6"
        Me.OpcBag156.Location = New System.Drawing.Point(164, 566)
        Me.OpcBag156.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag156.Name = "OpcBag156"
        Me.OpcBag156.PLC_Bag_ID = 0
        Me.OpcBag156.PlcName = ""
        Me.OpcBag156.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag156.TabIndex = 674
        Me.OpcBag156.TagName = "T6-35-6-ILC390.OPC_WR05_sDry_Program"
        Me.OpcBag156.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag157
        '
        Me.OpcBag157.BackColor = System.Drawing.Color.White
        Me.OpcBag157.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag157.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag157.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag157.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag157.Category = 88
        Me.OpcBag157.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag157.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag157.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag157.GroupName = "Tunnel_6"
        Me.OpcBag157.Location = New System.Drawing.Point(135, 566)
        Me.OpcBag157.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag157.Name = "OpcBag157"
        Me.OpcBag157.PLC_Bag_ID = 0
        Me.OpcBag157.PlcName = ""
        Me.OpcBag157.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag157.TabIndex = 673
        Me.OpcBag157.TagName = "T6-35-6-ILC390.OPC_WR05_sDry_Program"
        Me.OpcBag157.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag158
        '
        Me.OpcBag158.BackColor = System.Drawing.Color.White
        Me.OpcBag158.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag158.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag158.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag158.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag158.Category = 88
        Me.OpcBag158.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag158.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag158.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag158.GroupName = "Tunnel_6"
        Me.OpcBag158.Location = New System.Drawing.Point(165, 461)
        Me.OpcBag158.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag158.Name = "OpcBag158"
        Me.OpcBag158.PLC_Bag_ID = 0
        Me.OpcBag158.PlcName = ""
        Me.OpcBag158.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag158.TabIndex = 672
        Me.OpcBag158.TagName = "T6-35-6-ILC390.OPC_WR04_sDry_Program"
        Me.OpcBag158.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag159
        '
        Me.OpcBag159.BackColor = System.Drawing.Color.White
        Me.OpcBag159.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag159.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag159.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag159.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag159.Category = 88
        Me.OpcBag159.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag159.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag159.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag159.GroupName = "Tunnel_6"
        Me.OpcBag159.Location = New System.Drawing.Point(136, 461)
        Me.OpcBag159.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag159.Name = "OpcBag159"
        Me.OpcBag159.PLC_Bag_ID = 0
        Me.OpcBag159.PlcName = ""
        Me.OpcBag159.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag159.TabIndex = 671
        Me.OpcBag159.TagName = "T6-35-6-ILC390.OPC_WR04_sDry_Program"
        Me.OpcBag159.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag160
        '
        Me.OpcBag160.BackColor = System.Drawing.Color.White
        Me.OpcBag160.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag160.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag160.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag160.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag160.Category = 88
        Me.OpcBag160.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag160.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag160.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag160.GroupName = "Tunnel_6"
        Me.OpcBag160.Location = New System.Drawing.Point(164, 354)
        Me.OpcBag160.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag160.Name = "OpcBag160"
        Me.OpcBag160.PLC_Bag_ID = 0
        Me.OpcBag160.PlcName = ""
        Me.OpcBag160.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag160.TabIndex = 670
        Me.OpcBag160.TagName = "T6-35-6-ILC390.OPC_WR03_sDry_Program"
        Me.OpcBag160.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag161
        '
        Me.OpcBag161.BackColor = System.Drawing.Color.White
        Me.OpcBag161.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag161.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag161.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag161.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag161.Category = 88
        Me.OpcBag161.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag161.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag161.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag161.GroupName = "Tunnel_6"
        Me.OpcBag161.Location = New System.Drawing.Point(135, 354)
        Me.OpcBag161.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag161.Name = "OpcBag161"
        Me.OpcBag161.PLC_Bag_ID = 0
        Me.OpcBag161.PlcName = ""
        Me.OpcBag161.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag161.TabIndex = 669
        Me.OpcBag161.TagName = "T6-35-6-ILC390.OPC_WR03_sDry_Program"
        Me.OpcBag161.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag162
        '
        Me.OpcBag162.BackColor = System.Drawing.Color.White
        Me.OpcBag162.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag162.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag162.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag162.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag162.Category = 88
        Me.OpcBag162.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag162.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag162.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag162.GroupName = "Tunnel_6"
        Me.OpcBag162.Location = New System.Drawing.Point(164, 144)
        Me.OpcBag162.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag162.Name = "OpcBag162"
        Me.OpcBag162.PLC_Bag_ID = 0
        Me.OpcBag162.PlcName = ""
        Me.OpcBag162.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag162.TabIndex = 668
        Me.OpcBag162.TagName = "T6-35-6-ILC390.OPC_WR01_sDry_Program"
        Me.OpcBag162.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag163
        '
        Me.OpcBag163.BackColor = System.Drawing.Color.White
        Me.OpcBag163.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag163.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag163.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag163.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag163.Category = 88
        Me.OpcBag163.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag163.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag163.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag163.GroupName = "Tunnel_6"
        Me.OpcBag163.Location = New System.Drawing.Point(135, 144)
        Me.OpcBag163.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag163.Name = "OpcBag163"
        Me.OpcBag163.PLC_Bag_ID = 0
        Me.OpcBag163.PlcName = ""
        Me.OpcBag163.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag163.TabIndex = 667
        Me.OpcBag163.TagName = "T6-35-6-ILC390.OPC_WR01_sDry_Program"
        Me.OpcBag163.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag164
        '
        Me.OpcBag164.BackColor = System.Drawing.Color.White
        Me.OpcBag164.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag164.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag164.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag164.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag164.Category = 88
        Me.OpcBag164.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag164.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag164.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag164.GroupName = "Tunnel_6"
        Me.OpcBag164.Location = New System.Drawing.Point(164, 249)
        Me.OpcBag164.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag164.Name = "OpcBag164"
        Me.OpcBag164.PLC_Bag_ID = 0
        Me.OpcBag164.PlcName = ""
        Me.OpcBag164.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag164.TabIndex = 666
        Me.OpcBag164.TagName = "T6-35-6-ILC390.OPC_WR02_sDry_Program"
        Me.OpcBag164.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag165
        '
        Me.OpcBag165.BackColor = System.Drawing.Color.White
        Me.OpcBag165.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag165.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag165.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag165.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag165.Category = 88
        Me.OpcBag165.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag165.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag165.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag165.GroupName = "Tunnel_6"
        Me.OpcBag165.Location = New System.Drawing.Point(135, 249)
        Me.OpcBag165.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag165.Name = "OpcBag165"
        Me.OpcBag165.PLC_Bag_ID = 0
        Me.OpcBag165.PlcName = ""
        Me.OpcBag165.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag165.TabIndex = 665
        Me.OpcBag165.TagName = "T6-35-6-ILC390.OPC_WR02_sDry_Program"
        Me.OpcBag165.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag166
        '
        Me.OpcBag166.BackColor = System.Drawing.Color.White
        Me.OpcBag166.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag166.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag166.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag166.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag166.Category = 88
        Me.OpcBag166.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel6", True))
        Me.OpcBag166.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag166.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag166.GroupName = "Tunnel_6"
        Me.OpcBag166.Location = New System.Drawing.Point(20, 751)
        Me.OpcBag166.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag166.Name = "OpcBag166"
        Me.OpcBag166.PLC_Bag_ID = 0
        Me.OpcBag166.PlcName = ""
        Me.OpcBag166.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag166.TabIndex = 664
        Me.OpcBag166.TagName = "Tunnel[6].Loading_Position_Bag_Data"
        Me.OpcBag166.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag167
        '
        Me.OpcBag167.BackColor = System.Drawing.Color.White
        Me.OpcBag167.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag167.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag167.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag167.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag167.Category = 88
        Me.OpcBag167.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "Tunnel6", True))
        Me.OpcBag167.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag167.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag167.GroupName = "Tunnel_6"
        Me.OpcBag167.Location = New System.Drawing.Point(20, 674)
        Me.OpcBag167.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag167.Name = "OpcBag167"
        Me.OpcBag167.PLC_Bag_ID = 0
        Me.OpcBag167.PlcName = ""
        Me.OpcBag167.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag167.TabIndex = 663
        Me.OpcBag167.TagName = "Tunnel[6].Washer_Compartment_Data[1]"
        Me.OpcBag167.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag168
        '
        Me.OpcBag168.BackColor = System.Drawing.Color.White
        Me.OpcBag168.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag168.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag168.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag168.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag168.Category = 88
        Me.OpcBag168.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag168.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag168.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag168.GroupName = "Tunnel_6"
        Me.OpcBag168.Location = New System.Drawing.Point(20, 644)
        Me.OpcBag168.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag168.Name = "OpcBag168"
        Me.OpcBag168.PLC_Bag_ID = 0
        Me.OpcBag168.PlcName = ""
        Me.OpcBag168.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag168.TabIndex = 662
        Me.OpcBag168.TagName = "T6-33-6-ILC390.OPC_TW_C02_siProgram"
        Me.OpcBag168.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag169
        '
        Me.OpcBag169.BackColor = System.Drawing.Color.White
        Me.OpcBag169.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag169.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag169.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag169.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag169.Category = 88
        Me.OpcBag169.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag169.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag169.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag169.GroupName = "Tunnel_6"
        Me.OpcBag169.Location = New System.Drawing.Point(20, 614)
        Me.OpcBag169.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag169.Name = "OpcBag169"
        Me.OpcBag169.PLC_Bag_ID = 0
        Me.OpcBag169.PlcName = ""
        Me.OpcBag169.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag169.TabIndex = 661
        Me.OpcBag169.TagName = "T6-33-6-ILC390.OPC_TW_C03_siProgram"
        Me.OpcBag169.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag170
        '
        Me.OpcBag170.BackColor = System.Drawing.Color.White
        Me.OpcBag170.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag170.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag170.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag170.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag170.Category = 88
        Me.OpcBag170.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag170.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag170.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag170.GroupName = "Tunnel_6"
        Me.OpcBag170.Location = New System.Drawing.Point(20, 584)
        Me.OpcBag170.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag170.Name = "OpcBag170"
        Me.OpcBag170.PLC_Bag_ID = 0
        Me.OpcBag170.PlcName = ""
        Me.OpcBag170.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag170.TabIndex = 660
        Me.OpcBag170.TagName = "T6-33-6-ILC390.OPC_TW_C04_siProgram"
        Me.OpcBag170.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag171
        '
        Me.OpcBag171.BackColor = System.Drawing.Color.White
        Me.OpcBag171.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag171.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag171.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag171.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag171.Category = 88
        Me.OpcBag171.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag171.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag171.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag171.GroupName = "Tunnel_6"
        Me.OpcBag171.Location = New System.Drawing.Point(20, 554)
        Me.OpcBag171.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag171.Name = "OpcBag171"
        Me.OpcBag171.PLC_Bag_ID = 0
        Me.OpcBag171.PlcName = ""
        Me.OpcBag171.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag171.TabIndex = 659
        Me.OpcBag171.TagName = "T6-33-6-ILC390.OPC_TW_C05_siProgram"
        Me.OpcBag171.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag172
        '
        Me.OpcBag172.BackColor = System.Drawing.Color.White
        Me.OpcBag172.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag172.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag172.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag172.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag172.Category = 88
        Me.OpcBag172.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag172.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag172.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag172.GroupName = "Tunnel_6"
        Me.OpcBag172.Location = New System.Drawing.Point(20, 524)
        Me.OpcBag172.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag172.Name = "OpcBag172"
        Me.OpcBag172.PLC_Bag_ID = 0
        Me.OpcBag172.PlcName = ""
        Me.OpcBag172.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag172.TabIndex = 658
        Me.OpcBag172.TagName = "T6-33-6-ILC390.OPC_TW_C06_siProgram"
        Me.OpcBag172.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag173
        '
        Me.OpcBag173.BackColor = System.Drawing.Color.White
        Me.OpcBag173.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag173.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag173.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag173.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag173.Category = 88
        Me.OpcBag173.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag173.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag173.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag173.GroupName = "Tunnel_6"
        Me.OpcBag173.Location = New System.Drawing.Point(20, 493)
        Me.OpcBag173.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag173.Name = "OpcBag173"
        Me.OpcBag173.PLC_Bag_ID = 0
        Me.OpcBag173.PlcName = ""
        Me.OpcBag173.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag173.TabIndex = 657
        Me.OpcBag173.TagName = "T6-33-6-ILC390.OPC_TW_C07_siProgram"
        Me.OpcBag173.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag174
        '
        Me.OpcBag174.BackColor = System.Drawing.Color.White
        Me.OpcBag174.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag174.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag174.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag174.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag174.Category = 88
        Me.OpcBag174.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag174.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag174.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag174.GroupName = "Tunnel_6"
        Me.OpcBag174.Location = New System.Drawing.Point(20, 463)
        Me.OpcBag174.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag174.Name = "OpcBag174"
        Me.OpcBag174.PLC_Bag_ID = 0
        Me.OpcBag174.PlcName = ""
        Me.OpcBag174.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag174.TabIndex = 656
        Me.OpcBag174.TagName = "T6-33-6-ILC390.OPC_TW_C08_siProgram"
        Me.OpcBag174.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag175
        '
        Me.OpcBag175.BackColor = System.Drawing.Color.White
        Me.OpcBag175.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag175.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag175.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag175.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag175.Category = 88
        Me.OpcBag175.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag175.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag175.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag175.GroupName = "Tunnel_6"
        Me.OpcBag175.Location = New System.Drawing.Point(20, 433)
        Me.OpcBag175.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag175.Name = "OpcBag175"
        Me.OpcBag175.PLC_Bag_ID = 0
        Me.OpcBag175.PlcName = ""
        Me.OpcBag175.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag175.TabIndex = 655
        Me.OpcBag175.TagName = "T6-33-6-ILC390.OPC_TW_C09_siProgram"
        Me.OpcBag175.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag176
        '
        Me.OpcBag176.BackColor = System.Drawing.Color.White
        Me.OpcBag176.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag176.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag176.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag176.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag176.Category = 88
        Me.OpcBag176.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag176.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag176.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag176.GroupName = "Tunnel_6"
        Me.OpcBag176.Location = New System.Drawing.Point(20, 403)
        Me.OpcBag176.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag176.Name = "OpcBag176"
        Me.OpcBag176.PLC_Bag_ID = 0
        Me.OpcBag176.PlcName = ""
        Me.OpcBag176.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag176.TabIndex = 654
        Me.OpcBag176.TagName = "T6-33-6-ILC390.OPC_TW_C10_siProgram"
        Me.OpcBag176.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag177
        '
        Me.OpcBag177.BackColor = System.Drawing.Color.White
        Me.OpcBag177.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag177.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag177.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag177.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag177.Category = 88
        Me.OpcBag177.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag177.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag177.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag177.GroupName = "Tunnel_6"
        Me.OpcBag177.Location = New System.Drawing.Point(20, 373)
        Me.OpcBag177.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag177.Name = "OpcBag177"
        Me.OpcBag177.PLC_Bag_ID = 0
        Me.OpcBag177.PlcName = ""
        Me.OpcBag177.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag177.TabIndex = 653
        Me.OpcBag177.TagName = "T6-33-6-ILC390.OPC_TW_C11_siProgram"
        Me.OpcBag177.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag178
        '
        Me.OpcBag178.BackColor = System.Drawing.Color.White
        Me.OpcBag178.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag178.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag178.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag178.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag178.Category = 88
        Me.OpcBag178.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag178.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag178.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag178.GroupName = "Tunnel_6"
        Me.OpcBag178.Location = New System.Drawing.Point(20, 343)
        Me.OpcBag178.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag178.Name = "OpcBag178"
        Me.OpcBag178.PLC_Bag_ID = 0
        Me.OpcBag178.PlcName = ""
        Me.OpcBag178.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag178.TabIndex = 652
        Me.OpcBag178.TagName = "T6-33-6-ILC390.OPC_TW_C12_siProgram"
        Me.OpcBag178.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag179
        '
        Me.OpcBag179.BackColor = System.Drawing.Color.White
        Me.OpcBag179.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag179.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag179.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag179.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag179.Category = 88
        Me.OpcBag179.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag179.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag179.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag179.GroupName = "Tunnel_6"
        Me.OpcBag179.Location = New System.Drawing.Point(20, 313)
        Me.OpcBag179.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag179.Name = "OpcBag179"
        Me.OpcBag179.PLC_Bag_ID = 0
        Me.OpcBag179.PlcName = ""
        Me.OpcBag179.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag179.TabIndex = 651
        Me.OpcBag179.TagName = "T6-33-6-ILC390.OPC_TW_C13_siProgram"
        Me.OpcBag179.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag180
        '
        Me.OpcBag180.BackColor = System.Drawing.Color.White
        Me.OpcBag180.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag180.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag180.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag180.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag180.Category = 88
        Me.OpcBag180.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag180.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag180.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag180.GroupName = "Tunnel_6"
        Me.OpcBag180.Location = New System.Drawing.Point(20, 283)
        Me.OpcBag180.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag180.Name = "OpcBag180"
        Me.OpcBag180.PLC_Bag_ID = 0
        Me.OpcBag180.PlcName = ""
        Me.OpcBag180.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag180.TabIndex = 650
        Me.OpcBag180.TagName = "T6-33-6-ILC390.OPC_TW_C14_siProgram"
        Me.OpcBag180.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'OpcBag181
        '
        Me.OpcBag181.BackColor = System.Drawing.Color.White
        Me.OpcBag181.BagBackColor = System.Drawing.SystemColors.Control
        Me.OpcBag181.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL
        Me.OpcBag181.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN
        Me.OpcBag181.BagTextColor = System.Drawing.Color.Black
        Me.OpcBag181.Category = 88
        Me.OpcBag181.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "PhoenixTunnel6", True))
        Me.OpcBag181.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcBag181.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcBag181.GroupName = "Tunnel_6"
        Me.OpcBag181.Location = New System.Drawing.Point(20, 232)
        Me.OpcBag181.Margin = New System.Windows.Forms.Padding(5)
        Me.OpcBag181.Name = "OpcBag181"
        Me.OpcBag181.PLC_Bag_ID = 0
        Me.OpcBag181.PlcName = ""
        Me.OpcBag181.Size = New System.Drawing.Size(28, 28)
        Me.OpcBag181.TabIndex = 649
        Me.OpcBag181.TagName = "T6-34-6-ILC390.OPC_OUT.OPC_PR_siProgram"
        Me.OpcBag181.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.TUNNEL_WASHER
        '
        'CtrlOPCCycleTimer39
        '
        Me.CtrlOPCCycleTimer39.BackColor = System.Drawing.Color.White
        Me.CtrlOPCCycleTimer39.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "CycleTimer", True))
        Me.CtrlOPCCycleTimer39.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.CtrlOPCCycleTimer39.GroupName = "Press_Timers"
        Me.CtrlOPCCycleTimer39.Location = New System.Drawing.Point(10, 261)
        Me.CtrlOPCCycleTimer39.Name = "CtrlOPCCycleTimer39"
        Me.CtrlOPCCycleTimer39.PlcName = ""
        Me.CtrlOPCCycleTimer39.Size = New System.Drawing.Size(49, 13)
        Me.CtrlOPCCycleTimer39.TabIndex = 648
        Me.CtrlOPCCycleTimer39.TagName = "Tunnel[6].Press.Press_Current_Cycle_Time"
        Me.CtrlOPCCycleTimer39.ThresholdBlinkValue = 180
        Me.CtrlOPCCycleTimer39.TimeUnit = Wdw_Sust.Core.Enums.TimeUnit.Second
        '
        'OpcArrow29
        '
        Me.OpcArrow29.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow29.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow29.GroupName = "Shuttles"
        Me.OpcArrow29.Location = New System.Drawing.Point(120, 757)
        Me.OpcArrow29.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow29.Name = "OpcArrow29"
        Me.OpcArrow29.PlcName = ""
        Me.OpcArrow29.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow29.TabIndex = 640
        Me.OpcArrow29.TagName = "Tunnel[6].Shuttle.Position_Dryer_7"
        '
        'OpcArrow30
        '
        Me.OpcArrow30.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow30.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow30.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow30.GroupName = "Shuttles"
        Me.OpcArrow30.Location = New System.Drawing.Point(120, 651)
        Me.OpcArrow30.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow30.Name = "OpcArrow30"
        Me.OpcArrow30.PlcName = ""
        Me.OpcArrow30.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow30.TabIndex = 639
        Me.OpcArrow30.TagName = "Tunnel[6].Shuttle.Position_Dryer_6"
        '
        'OpcArrow31
        '
        Me.OpcArrow31.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow31.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow31.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow31.GroupName = "Shuttles"
        Me.OpcArrow31.Location = New System.Drawing.Point(120, 546)
        Me.OpcArrow31.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow31.Name = "OpcArrow31"
        Me.OpcArrow31.PlcName = ""
        Me.OpcArrow31.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow31.TabIndex = 638
        Me.OpcArrow31.TagName = "Tunnel[6].Shuttle.Position_Dryer_5"
        '
        'OpcArrow32
        '
        Me.OpcArrow32.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow32.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow32.GroupName = "Shuttles"
        Me.OpcArrow32.Location = New System.Drawing.Point(120, 439)
        Me.OpcArrow32.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow32.Name = "OpcArrow32"
        Me.OpcArrow32.PlcName = ""
        Me.OpcArrow32.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow32.TabIndex = 637
        Me.OpcArrow32.TagName = "Tunnel[6].Shuttle.Position_Dryer_4"
        '
        'OpcArrow33
        '
        Me.OpcArrow33.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow33.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow33.GroupName = "Shuttles"
        Me.OpcArrow33.Location = New System.Drawing.Point(120, 334)
        Me.OpcArrow33.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow33.Name = "OpcArrow33"
        Me.OpcArrow33.PlcName = ""
        Me.OpcArrow33.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow33.TabIndex = 636
        Me.OpcArrow33.TagName = "Tunnel[6].Shuttle.Position_Dryer_3"
        '
        'OpcArrow34
        '
        Me.OpcArrow34.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow34.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow34.GroupName = "Shuttles"
        Me.OpcArrow34.Location = New System.Drawing.Point(120, 228)
        Me.OpcArrow34.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow34.Name = "OpcArrow34"
        Me.OpcArrow34.PlcName = ""
        Me.OpcArrow34.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow34.TabIndex = 635
        Me.OpcArrow34.TagName = "Tunnel[6].Dryers[2].Dryer_Loading"
        '
        'OpcArrow35
        '
        Me.OpcArrow35.BackColor = System.Drawing.SystemColors.Control
        Me.OpcArrow35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpcArrow35.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcArrow35.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcArrow35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcArrow35.GroupName = "Shuttles"
        Me.OpcArrow35.Location = New System.Drawing.Point(120, 122)
        Me.OpcArrow35.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpcArrow35.Name = "OpcArrow35"
        Me.OpcArrow35.PlcName = ""
        Me.OpcArrow35.Size = New System.Drawing.Size(24, 24)
        Me.OpcArrow35.TabIndex = 634
        Me.OpcArrow35.TagName = "Tunnel[6].Shuttle.Position_Dryer_1"
        '
        'lblAverageBagDropCounts
        '
        Me.lblAverageBagDropCounts.AutoSize = True
        Me.lblAverageBagDropCounts.BackColor = System.Drawing.Color.White
        Me.lblAverageBagDropCounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageBagDropCounts.Location = New System.Drawing.Point(1689, 0)
        Me.lblAverageBagDropCounts.Name = "lblAverageBagDropCounts"
        Me.lblAverageBagDropCounts.Size = New System.Drawing.Size(88, 29)
        Me.lblAverageBagDropCounts.TabIndex = 835
        Me.lblAverageBagDropCounts.Text = "Counts"
        '
        'OpcMachineAvailabilityStatus27
        '
        Me.OpcMachineAvailabilityStatus27.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus27.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus27.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus27.Location = New System.Drawing.Point(170, 736)
        Me.OpcMachineAvailabilityStatus27.MachineID = 10758
        Me.OpcMachineAvailabilityStatus27.Name = "OpcMachineAvailabilityStatus27"
        Me.OpcMachineAvailabilityStatus27.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus27.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus27.TabIndex = 999
        Me.OpcMachineAvailabilityStatus27.TagName = "Tunnel[6].Dryers[7].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus28
        '
        Me.OpcMachineAvailabilityStatus28.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus28.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus28.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus28.Location = New System.Drawing.Point(170, 630)
        Me.OpcMachineAvailabilityStatus28.MachineID = 10757
        Me.OpcMachineAvailabilityStatus28.Name = "OpcMachineAvailabilityStatus28"
        Me.OpcMachineAvailabilityStatus28.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus28.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus28.TabIndex = 998
        Me.OpcMachineAvailabilityStatus28.TagName = "Tunnel[6].Dryers[6].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus29
        '
        Me.OpcMachineAvailabilityStatus29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus29.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus29.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus29.Location = New System.Drawing.Point(170, 524)
        Me.OpcMachineAvailabilityStatus29.MachineID = 10756
        Me.OpcMachineAvailabilityStatus29.Name = "OpcMachineAvailabilityStatus29"
        Me.OpcMachineAvailabilityStatus29.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus29.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus29.TabIndex = 997
        Me.OpcMachineAvailabilityStatus29.TagName = "Tunnel[6].Dryers[5].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus30
        '
        Me.OpcMachineAvailabilityStatus30.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus30.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus30.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus30.Location = New System.Drawing.Point(170, 420)
        Me.OpcMachineAvailabilityStatus30.MachineID = 10755
        Me.OpcMachineAvailabilityStatus30.Name = "OpcMachineAvailabilityStatus30"
        Me.OpcMachineAvailabilityStatus30.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus30.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus30.TabIndex = 996
        Me.OpcMachineAvailabilityStatus30.TagName = "Tunnel[6].Dryers[4].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus31
        '
        Me.OpcMachineAvailabilityStatus31.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus31.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus31.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus31.Location = New System.Drawing.Point(170, 314)
        Me.OpcMachineAvailabilityStatus31.MachineID = 10754
        Me.OpcMachineAvailabilityStatus31.Name = "OpcMachineAvailabilityStatus31"
        Me.OpcMachineAvailabilityStatus31.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus31.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus31.TabIndex = 995
        Me.OpcMachineAvailabilityStatus31.TagName = "Tunnel[6].Dryers[3].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus32
        '
        Me.OpcMachineAvailabilityStatus32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus32.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus32.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus32.Location = New System.Drawing.Point(170, 208)
        Me.OpcMachineAvailabilityStatus32.MachineID = 10753
        Me.OpcMachineAvailabilityStatus32.Name = "OpcMachineAvailabilityStatus32"
        Me.OpcMachineAvailabilityStatus32.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus32.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus32.TabIndex = 994
        Me.OpcMachineAvailabilityStatus32.TagName = "Tunnel[6].Dryers[2].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus33
        '
        Me.OpcMachineAvailabilityStatus33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus33.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus33.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus33.Location = New System.Drawing.Point(170, 102)
        Me.OpcMachineAvailabilityStatus33.MachineID = 10752
        Me.OpcMachineAvailabilityStatus33.Name = "OpcMachineAvailabilityStatus33"
        Me.OpcMachineAvailabilityStatus33.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus33.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus33.TabIndex = 993
        Me.OpcMachineAvailabilityStatus33.TagName = "Tunnel[6].Dryers[1].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus34
        '
        Me.OpcMachineAvailabilityStatus34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus34.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus34.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus34.Location = New System.Drawing.Point(410, 736)
        Me.OpcMachineAvailabilityStatus34.MachineID = 10768
        Me.OpcMachineAvailabilityStatus34.Name = "OpcMachineAvailabilityStatus34"
        Me.OpcMachineAvailabilityStatus34.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus34.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus34.TabIndex = 1006
        Me.OpcMachineAvailabilityStatus34.TagName = "Tunnel[7].Dryers[7].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus35
        '
        Me.OpcMachineAvailabilityStatus35.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus35.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus35.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus35.Location = New System.Drawing.Point(410, 630)
        Me.OpcMachineAvailabilityStatus35.MachineID = 10767
        Me.OpcMachineAvailabilityStatus35.Name = "OpcMachineAvailabilityStatus35"
        Me.OpcMachineAvailabilityStatus35.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus35.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus35.TabIndex = 1005
        Me.OpcMachineAvailabilityStatus35.TagName = "Tunnel[7].Dryers[6].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus36
        '
        Me.OpcMachineAvailabilityStatus36.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus36.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus36.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus36.Location = New System.Drawing.Point(410, 524)
        Me.OpcMachineAvailabilityStatus36.MachineID = 10766
        Me.OpcMachineAvailabilityStatus36.Name = "OpcMachineAvailabilityStatus36"
        Me.OpcMachineAvailabilityStatus36.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus36.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus36.TabIndex = 1004
        Me.OpcMachineAvailabilityStatus36.TagName = "Tunnel[7].Dryers[5].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus37
        '
        Me.OpcMachineAvailabilityStatus37.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus37.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus37.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus37.Location = New System.Drawing.Point(410, 420)
        Me.OpcMachineAvailabilityStatus37.MachineID = 10765
        Me.OpcMachineAvailabilityStatus37.Name = "OpcMachineAvailabilityStatus37"
        Me.OpcMachineAvailabilityStatus37.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus37.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus37.TabIndex = 1003
        Me.OpcMachineAvailabilityStatus37.TagName = "Tunnel[7].Dryers[4].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus38
        '
        Me.OpcMachineAvailabilityStatus38.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus38.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus38.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus38.Location = New System.Drawing.Point(410, 314)
        Me.OpcMachineAvailabilityStatus38.MachineID = 10764
        Me.OpcMachineAvailabilityStatus38.Name = "OpcMachineAvailabilityStatus38"
        Me.OpcMachineAvailabilityStatus38.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus38.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus38.TabIndex = 1002
        Me.OpcMachineAvailabilityStatus38.TagName = "Tunnel[7].Dryers[3].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus39
        '
        Me.OpcMachineAvailabilityStatus39.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus39.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus39.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus39.Location = New System.Drawing.Point(411, 208)
        Me.OpcMachineAvailabilityStatus39.MachineID = 10763
        Me.OpcMachineAvailabilityStatus39.Name = "OpcMachineAvailabilityStatus39"
        Me.OpcMachineAvailabilityStatus39.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus39.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus39.TabIndex = 1001
        Me.OpcMachineAvailabilityStatus39.TagName = "Tunnel[7].Dryers[2].Dryer_In_Service"
        '
        'OpcMachineAvailabilityStatus40
        '
        Me.OpcMachineAvailabilityStatus40.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAAquamizerPLC", True))
        Me.OpcMachineAvailabilityStatus40.DataBindings.Add(New System.Windows.Forms.Binding("GroupName", Me.WashdeckOPCGroupNameBindingSource, "MachineAvailability", True))
        Me.OpcMachineAvailabilityStatus40.GroupName = Nothing
        Me.OpcMachineAvailabilityStatus40.Location = New System.Drawing.Point(410, 102)
        Me.OpcMachineAvailabilityStatus40.MachineID = 10762
        Me.OpcMachineAvailabilityStatus40.Name = "OpcMachineAvailabilityStatus40"
        Me.OpcMachineAvailabilityStatus40.PlcName = Nothing
        Me.OpcMachineAvailabilityStatus40.Size = New System.Drawing.Size(23, 23)
        Me.OpcMachineAvailabilityStatus40.TabIndex = 1000
        Me.OpcMachineAvailabilityStatus40.TagName = "Tunnel[7].Dryers[1].Dryer_In_Service"
        '
        'lblActiveWashers
        '
        Me.lblActiveWashers.AutoSize = True
        Me.lblActiveWashers.BackColor = System.Drawing.Color.White
        Me.lblActiveWashers.Location = New System.Drawing.Point(12, 822)
        Me.lblActiveWashers.Name = "lblActiveWashers"
        Me.lblActiveWashers.Size = New System.Drawing.Size(85, 13)
        Me.lblActiveWashers.TabIndex = 1017
        Me.lblActiveWashers.Text = "Active Washers:"
        '
        'frmTunnelInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1906, 843)
        Me.Controls.Add(Me.lblActiveWashers)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus34)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus35)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus36)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus37)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus38)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus39)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus40)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus27)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus28)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus29)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus30)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus31)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus32)
        Me.Controls.Add(Me.OpcMachineAvailabilityStatus33)
        Me.Controls.Add(Me.lblAverageBagDropCounts)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon39)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon57)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon56)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon55)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon36)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon37)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon61)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon60)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon59)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon58)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon21)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon54)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon53)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon52)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon20)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon51)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon50)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon49)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon48)
        Me.Controls.Add(Me.CtrlLINTAlarmIcon18)
        Me.Controls.Add(Me.OpcBag182)
        Me.Controls.Add(Me.CtrlOPCCycleTimer40)
        Me.Controls.Add(Me.CtrlOPCCycleTimer41)
        Me.Controls.Add(Me.CtrlOPCCycleTimer42)
        Me.Controls.Add(Me.CtrlOPCCycleTimer43)
        Me.Controls.Add(Me.CtrlOPCCycleTimer44)
        Me.Controls.Add(Me.CtrlOPCCycleTimer45)
        Me.Controls.Add(Me.CtrlOPCCycleTimer46)
        Me.Controls.Add(Me.OpcBag183)
        Me.Controls.Add(Me.OpcBag184)
        Me.Controls.Add(Me.OpcBag185)
        Me.Controls.Add(Me.OpcBag186)
        Me.Controls.Add(Me.OpcBag187)
        Me.Controls.Add(Me.OpcBag188)
        Me.Controls.Add(Me.OpcBag189)
        Me.Controls.Add(Me.OpcBag190)
        Me.Controls.Add(Me.OpcBag191)
        Me.Controls.Add(Me.OpcBag192)
        Me.Controls.Add(Me.OpcBag193)
        Me.Controls.Add(Me.OpcBag194)
        Me.Controls.Add(Me.OpcBag195)
        Me.Controls.Add(Me.OpcBag196)
        Me.Controls.Add(Me.OpcBag197)
        Me.Controls.Add(Me.OpcBag198)
        Me.Controls.Add(Me.OpcBag199)
        Me.Controls.Add(Me.OpcBag200)
        Me.Controls.Add(Me.OpcBag201)
        Me.Controls.Add(Me.OpcBag202)
        Me.Controls.Add(Me.OpcBag203)
        Me.Controls.Add(Me.OpcBag204)
        Me.Controls.Add(Me.OpcBag205)
        Me.Controls.Add(Me.OpcBag206)
        Me.Controls.Add(Me.OpcBag207)
        Me.Controls.Add(Me.OpcBag208)
        Me.Controls.Add(Me.OpcBag209)
        Me.Controls.Add(Me.OpcBag210)
        Me.Controls.Add(Me.OpcBag211)
        Me.Controls.Add(Me.OpcBag212)
        Me.Controls.Add(Me.OpcBag213)
        Me.Controls.Add(Me.OpcBag214)
        Me.Controls.Add(Me.CtrlOPCCycleTimer47)
        Me.Controls.Add(Me.OpcArrow36)
        Me.Controls.Add(Me.OpcArrow37)
        Me.Controls.Add(Me.OpcArrow38)
        Me.Controls.Add(Me.OpcArrow39)
        Me.Controls.Add(Me.OpcArrow40)
        Me.Controls.Add(Me.OpcArrow41)
        Me.Controls.Add(Me.OpcArrow42)
        Me.Controls.Add(Me.OpcBag149)
        Me.Controls.Add(Me.CtrlOPCCycleTimer32)
        Me.Controls.Add(Me.CtrlOPCCycleTimer33)
        Me.Controls.Add(Me.CtrlOPCCycleTimer34)
        Me.Controls.Add(Me.CtrlOPCCycleTimer35)
        Me.Controls.Add(Me.CtrlOPCCycleTimer36)
        Me.Controls.Add(Me.CtrlOPCCycleTimer37)
        Me.Controls.Add(Me.CtrlOPCCycleTimer38)
        Me.Controls.Add(Me.OpcBag150)
        Me.Controls.Add(Me.OpcBag151)
        Me.Controls.Add(Me.OpcBag152)
        Me.Controls.Add(Me.OpcBag153)
        Me.Controls.Add(Me.OpcBag154)
        Me.Controls.Add(Me.OpcBag155)
        Me.Controls.Add(Me.OpcBag156)
        Me.Controls.Add(Me.OpcBag157)
        Me.Controls.Add(Me.OpcBag158)
        Me.Controls.Add(Me.OpcBag159)
        Me.Controls.Add(Me.OpcBag160)
        Me.Controls.Add(Me.OpcBag161)
        Me.Controls.Add(Me.OpcBag162)
        Me.Controls.Add(Me.OpcBag163)
        Me.Controls.Add(Me.OpcBag164)
        Me.Controls.Add(Me.OpcBag165)
        Me.Controls.Add(Me.OpcBag166)
        Me.Controls.Add(Me.OpcBag167)
        Me.Controls.Add(Me.OpcBag168)
        Me.Controls.Add(Me.OpcBag169)
        Me.Controls.Add(Me.OpcBag170)
        Me.Controls.Add(Me.OpcBag171)
        Me.Controls.Add(Me.OpcBag172)
        Me.Controls.Add(Me.OpcBag173)
        Me.Controls.Add(Me.OpcBag174)
        Me.Controls.Add(Me.OpcBag175)
        Me.Controls.Add(Me.OpcBag176)
        Me.Controls.Add(Me.OpcBag177)
        Me.Controls.Add(Me.OpcBag178)
        Me.Controls.Add(Me.OpcBag179)
        Me.Controls.Add(Me.OpcBag180)
        Me.Controls.Add(Me.OpcBag181)
        Me.Controls.Add(Me.CtrlOPCCycleTimer39)
        Me.Controls.Add(Me.OpcArrow29)
        Me.Controls.Add(Me.OpcArrow30)
        Me.Controls.Add(Me.OpcArrow31)
        Me.Controls.Add(Me.OpcArrow32)
        Me.Controls.Add(Me.OpcArrow33)
        Me.Controls.Add(Me.OpcArrow34)
        Me.Controls.Add(Me.OpcArrow35)
        Me.Controls.Add(Me.CtrlOPCLabel7)
        Me.Controls.Add(Me.CtrlOPCLabel6)
        Me.Controls.Add(Me.lblBagDropT7)
        Me.Controls.Add(Me.lblBagDropT6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1922, 882)
        Me.Name = "frmTunnelInterface"
        Me.Text = "Washdeck Area"
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashdeckOPCGroupNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpcBag149 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCCycleTimer32 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer33 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer34 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer35 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer36 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer37 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer38 As CtrlOpcCycleTimer
    Friend WithEvents OpcBag150 As CtrlOpcTsaBag
    Friend WithEvents OpcBag151 As CtrlOpcTsaBag
    Friend WithEvents OpcBag152 As CtrlOpcTsaBag
    Friend WithEvents OpcBag153 As CtrlOpcTsaBag
    Friend WithEvents OpcBag154 As CtrlOpcTsaBag
    Friend WithEvents OpcBag155 As CtrlOpcTsaBag
    Friend WithEvents OpcBag156 As CtrlOpcTsaBag
    Friend WithEvents OpcBag157 As CtrlOpcTsaBag
    Friend WithEvents OpcBag158 As CtrlOpcTsaBag
    Friend WithEvents OpcBag159 As CtrlOpcTsaBag
    Friend WithEvents OpcBag160 As CtrlOpcTsaBag
    Friend WithEvents OpcBag161 As CtrlOpcTsaBag
    Friend WithEvents OpcBag162 As CtrlOpcTsaBag
    Friend WithEvents OpcBag163 As CtrlOpcTsaBag
    Friend WithEvents OpcBag164 As CtrlOpcTsaBag
    Friend WithEvents OpcBag165 As CtrlOpcTsaBag
    Friend WithEvents OpcBag166 As CtrlOpcTsaBag
    Friend WithEvents OpcBag167 As CtrlOpcTsaBag
    Friend WithEvents OpcBag168 As CtrlOpcTsaBag
    Friend WithEvents OpcBag169 As CtrlOpcTsaBag
    Friend WithEvents OpcBag170 As CtrlOpcTsaBag
    Friend WithEvents OpcBag171 As CtrlOpcTsaBag
    Friend WithEvents OpcBag172 As CtrlOpcTsaBag
    Friend WithEvents OpcBag173 As CtrlOpcTsaBag
    Friend WithEvents OpcBag174 As CtrlOpcTsaBag
    Friend WithEvents OpcBag175 As CtrlOpcTsaBag
    Friend WithEvents OpcBag176 As CtrlOpcTsaBag
    Friend WithEvents OpcBag177 As CtrlOpcTsaBag
    Friend WithEvents OpcBag178 As CtrlOpcTsaBag
    Friend WithEvents OpcBag179 As CtrlOpcTsaBag
    Friend WithEvents OpcBag180 As CtrlOpcTsaBag
    Friend WithEvents OpcBag181 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCCycleTimer39 As CtrlOpcCycleTimer
    Friend WithEvents OpcArrow29 As CtrlOPCArrow
    Friend WithEvents OpcArrow30 As CtrlOPCArrow
    Friend WithEvents OpcArrow31 As CtrlOPCArrow
    Friend WithEvents OpcArrow32 As CtrlOPCArrow
    Friend WithEvents OpcArrow33 As CtrlOPCArrow
    Friend WithEvents OpcArrow34 As CtrlOPCArrow
    Friend WithEvents OpcArrow35 As CtrlOPCArrow
    Friend WithEvents OpcBag182 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCCycleTimer40 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer41 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer42 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer43 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer44 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer45 As CtrlOpcCycleTimer
    Friend WithEvents CtrlOPCCycleTimer46 As CtrlOpcCycleTimer
    Friend WithEvents OpcBag183 As CtrlOpcTsaBag
    Friend WithEvents OpcBag184 As CtrlOpcTsaBag
    Friend WithEvents OpcBag185 As CtrlOpcTsaBag
    Friend WithEvents OpcBag186 As CtrlOpcTsaBag
    Friend WithEvents OpcBag187 As CtrlOpcTsaBag
    Friend WithEvents OpcBag188 As CtrlOpcTsaBag
    Friend WithEvents OpcBag189 As CtrlOpcTsaBag
    Friend WithEvents OpcBag190 As CtrlOpcTsaBag
    Friend WithEvents OpcBag191 As CtrlOpcTsaBag
    Friend WithEvents OpcBag192 As CtrlOpcTsaBag
    Friend WithEvents OpcBag193 As CtrlOpcTsaBag
    Friend WithEvents OpcBag194 As CtrlOpcTsaBag
    Friend WithEvents OpcBag195 As CtrlOpcTsaBag
    Friend WithEvents OpcBag196 As CtrlOpcTsaBag
    Friend WithEvents OpcBag197 As CtrlOpcTsaBag
    Friend WithEvents OpcBag198 As CtrlOpcTsaBag
    Friend WithEvents OpcBag199 As CtrlOpcTsaBag
    Friend WithEvents OpcBag200 As CtrlOpcTsaBag
    Friend WithEvents OpcBag201 As CtrlOpcTsaBag
    Friend WithEvents OpcBag202 As CtrlOpcTsaBag
    Friend WithEvents OpcBag203 As CtrlOpcTsaBag
    Friend WithEvents OpcBag204 As CtrlOpcTsaBag
    Friend WithEvents OpcBag205 As CtrlOpcTsaBag
    Friend WithEvents OpcBag206 As CtrlOpcTsaBag
    Friend WithEvents OpcBag207 As CtrlOpcTsaBag
    Friend WithEvents OpcBag208 As CtrlOpcTsaBag
    Friend WithEvents OpcBag209 As CtrlOpcTsaBag
    Friend WithEvents OpcBag210 As CtrlOpcTsaBag
    Friend WithEvents OpcBag211 As CtrlOpcTsaBag
    Friend WithEvents OpcBag212 As CtrlOpcTsaBag
    Friend WithEvents OpcBag213 As CtrlOpcTsaBag
    Friend WithEvents OpcBag214 As CtrlOpcTsaBag
    Friend WithEvents CtrlOPCCycleTimer47 As CtrlOpcCycleTimer
    Friend WithEvents OpcArrow36 As CtrlOPCArrow
    Friend WithEvents OpcArrow37 As CtrlOPCArrow
    Friend WithEvents OpcArrow38 As CtrlOPCArrow
    Friend WithEvents OpcArrow39 As CtrlOPCArrow
    Friend WithEvents OpcArrow40 As CtrlOPCArrow
    Friend WithEvents OpcArrow41 As CtrlOPCArrow
    Friend WithEvents OpcArrow42 As CtrlOPCArrow
    Friend WithEvents CtrlLINTAlarmIcon51 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon50 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon49 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon48 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon18 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon54 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon53 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon52 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon20 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon61 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon60 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon59 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon58 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon21 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon57 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon56 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon55 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon36 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon37 As CtrlLintAlarmIcon
    Friend WithEvents CtrlLINTAlarmIcon39 As CtrlLintAlarmIcon
    Friend WithEvents lblBagDropT7 As System.Windows.Forms.Label
    Friend WithEvents lblBagDropT6 As System.Windows.Forms.Label
    Friend WithEvents CtrlOPCLabel7 As CtrlOpcBoolLabel
    Friend WithEvents CtrlOPCLabel6 As CtrlOpcBoolLabel
    Friend WithEvents lblAverageBagDropCounts As System.Windows.Forms.Label
    Friend WithEvents WashdeckOPCGroupNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpcMachineAvailabilityStatus27 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus28 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus29 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus30 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus31 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus32 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus33 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus34 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus35 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus36 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus37 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus38 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus39 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents OpcMachineAvailabilityStatus40 As CtrlOpcMachineAvailabilityStatus
    Friend WithEvents lblActiveWashers As System.Windows.Forms.Label
End Class
