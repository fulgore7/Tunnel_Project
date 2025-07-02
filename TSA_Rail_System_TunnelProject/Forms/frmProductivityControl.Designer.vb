Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Opc.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductivityControl
    Inherits TSA_Rail_System.CtrlOpcTsaRailFormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductivityControl))
        Me.btnResetWashdeck = New CtrlOpcButton()
        Me.btnResetClassifiedSorting = New CtrlOpcButton()
        Me.btnResetCartDump = New CtrlOpcButton()
        Me.btnResetProductivityTF1 = New CtrlOpcButton()
        Me.CtrlOPCLabel1 = New CtrlOpcLabel()
        Me.btnResetProductivityTF2 = New CtrlOpcButton()
        Me.CtrlOPCLabel2 = New CtrlOpcLabel()
        Me.CtrlOPCLabel3 = New CtrlOpcLabel()
        Me.btnResetProductivityTF3 = New CtrlOpcButton()
        Me.CtrlOPCLabel4 = New CtrlOpcLabel()
        Me.btnResetProductivityTF4 = New CtrlOpcButton()
        Me.CtrlOPCLabel5 = New CtrlOpcLabel()
        Me.btnResetProductivityTF5 = New CtrlOpcButton()
        Me.CtrlOPCLabel6 = New CtrlOpcLabel()
        Me.btnResetProductivityTF6 = New CtrlOpcButton()
        Me.CtrlOPCLabel7 = New CtrlOpcLabel()
        Me.btnResetProductivityTF7 = New CtrlOpcButton()
        Me.CtrlOPCLabel8 = New CtrlOpcLabel()
        Me.btnResetProductivityTF8 = New CtrlOpcButton()
        Me.CtrlOPCLabel9 = New CtrlOpcLabel()
        Me.btnResetProductivityTF9 = New CtrlOpcButton()
        Me.CtrlOPCLabel10 = New CtrlOpcLabel()
        Me.btnResetProductivityTF10 = New CtrlOpcButton()
        Me.CtrlOPCLabel11 = New CtrlOpcLabel()
        Me.btnResetProductivityTF11 = New CtrlOpcButton()
        Me.CtrlOPCLabel12 = New CtrlOpcLabel()
        Me.btnResetProductivityTF22 = New CtrlOpcButton()
        Me.CtrlOPCLabel13 = New CtrlOpcLabel()
        Me.btnResetProductivityTF21 = New CtrlOpcButton()
        Me.CtrlOPCLabel14 = New CtrlOpcLabel()
        Me.btnResetProductivityTF20 = New CtrlOpcButton()
        Me.CtrlOPCLabel15 = New CtrlOpcLabel()
        Me.btnResetProductivityTF19 = New CtrlOpcButton()
        Me.CtrlOPCLabel16 = New CtrlOpcLabel()
        Me.btnResetProductivityTF18 = New CtrlOpcButton()
        Me.CtrlOPCLabel17 = New CtrlOpcLabel()
        Me.btnResetProductivityTF17 = New CtrlOpcButton()
        Me.CtrlOPCLabel18 = New CtrlOpcLabel()
        Me.btnResetProductivityTF16 = New CtrlOpcButton()
        Me.CtrlOPCLabel19 = New CtrlOpcLabel()
        Me.btnResetProductivityTF15 = New CtrlOpcButton()
        Me.CtrlOPCLabel20 = New CtrlOpcLabel()
        Me.btnResetProductivityTF14 = New CtrlOpcButton()
        Me.CtrlOPCLabel21 = New CtrlOpcLabel()
        Me.btnResetProductivityTF13 = New CtrlOpcButton()
        Me.CtrlOPCLabel22 = New CtrlOpcLabel()
        Me.btnResetProductivityTF12 = New CtrlOpcButton()
        Me.btnResetProductivityFW7 = New CtrlOpcButton()
        Me.btnResetProductivityFW6 = New CtrlOpcButton()
        Me.btnResetProductivityFW5 = New CtrlOpcButton()
        Me.btnResetProductivityFW4 = New CtrlOpcButton()
        Me.btnResetProductivityFW3 = New CtrlOpcButton()
        Me.btnResetProductivityFW2 = New CtrlOpcButton()
        Me.btnResetProductivityFW1 = New CtrlOpcButton()
        Me.btnResetAllData = New System.Windows.Forms.Button()
        Me.CtrlOPCLabel23 = New CtrlOpcLabel()
        Me.CtrlOPCLabel24 = New CtrlOpcLabel()
        Me.CtrlOPCLabel25 = New CtrlOpcLabel()
        Me.CtrlOPCLabel26 = New CtrlOpcLabel()
        Me.CtrlOPCLabel27 = New CtrlOpcLabel()
        Me.CtrlOPCLabel28 = New CtrlOpcLabel()
        Me.CtrlOPCLabel29 = New CtrlOpcLabel()
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnResetWashdeck
        '
        Me.btnResetWashdeck.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.btnResetWashdeck.GroupName = "Classified_Productivity"
        Me.btnResetWashdeck.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetWashdeck.HighStateText = "Wash Pound Reset"
        Me.btnResetWashdeck.IsSecurityFeatureUsed = False
        Me.btnResetWashdeck.Location = New System.Drawing.Point(351, 297)
        Me.btnResetWashdeck.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetWashdeck.LowStateText = "Wash Pound Reset"
        Me.btnResetWashdeck.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetWashdeck.Name = "btnResetWashdeck"
        Me.btnResetWashdeck.PlcName = ""
        Me.btnResetWashdeck.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetWashdeck.Size = New System.Drawing.Size(105, 32)
        Me.btnResetWashdeck.TabIndex = 0
        Me.btnResetWashdeck.TagName = "bReset_Washdeck_Productivity"
        '
        'btnResetClassifiedSorting
        '
        Me.btnResetClassifiedSorting.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAClassifiedPLC", True))
        Me.btnResetClassifiedSorting.GroupName = "Classified_Productivity"
        Me.btnResetClassifiedSorting.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetClassifiedSorting.HighStateText = "Sort Pound Reset"
        Me.btnResetClassifiedSorting.IsSecurityFeatureUsed = False
        Me.btnResetClassifiedSorting.Location = New System.Drawing.Point(351, 329)
        Me.btnResetClassifiedSorting.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetClassifiedSorting.LowStateText = "Sort Pound Reset"
        Me.btnResetClassifiedSorting.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetClassifiedSorting.Name = "btnResetClassifiedSorting"
        Me.btnResetClassifiedSorting.PlcName = ""
        Me.btnResetClassifiedSorting.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetClassifiedSorting.Size = New System.Drawing.Size(105, 32)
        Me.btnResetClassifiedSorting.TabIndex = 1
        Me.btnResetClassifiedSorting.TagName = "bReset_Sorting_Productivity"
        '
        'btnResetCartDump
        '
        Me.btnResetCartDump.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAGatewayPLC", True))
        Me.btnResetCartDump.GroupName = "Gateway_Productivity"
        Me.btnResetCartDump.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetCartDump.HighStateText = "Cart Dump Reset"
        Me.btnResetCartDump.IsSecurityFeatureUsed = False
        Me.btnResetCartDump.Location = New System.Drawing.Point(351, 265)
        Me.btnResetCartDump.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetCartDump.LowStateText = "Cart Dump Reset"
        Me.btnResetCartDump.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetCartDump.Name = "btnResetCartDump"
        Me.btnResetCartDump.PlcName = ""
        Me.btnResetCartDump.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetCartDump.Size = New System.Drawing.Size(105, 32)
        Me.btnResetCartDump.TabIndex = 0
        Me.btnResetCartDump.TagName = "bReset_Cart_Dump_Data"
        '
        'btnResetProductivityTF1
        '
        Me.btnResetProductivityTF1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF1.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF1.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF1.HighStateText = "TF 1"
        Me.btnResetProductivityTF1.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF1.Location = New System.Drawing.Point(9, 9)
        Me.btnResetProductivityTF1.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF1.LowStateText = "TF 1"
        Me.btnResetProductivityTF1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF1.Name = "btnResetProductivityTF1"
        Me.btnResetProductivityTF1.PlcName = ""
        Me.btnResetProductivityTF1.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF1.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF1.TabIndex = 2
        Me.btnResetProductivityTF1.TagName = "bReset_Towel_Folder_Counts[1]"
        '
        'CtrlOPCLabel1
        '
        Me.CtrlOPCLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel1.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel1.Location = New System.Drawing.Point(117, 20)
        Me.CtrlOPCLabel1.Name = "CtrlOPCLabel1"
        Me.CtrlOPCLabel1.PlcName = Nothing
        Me.CtrlOPCLabel1.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel1.TabIndex = 3
        Me.CtrlOPCLabel1.TagName = "TowelFolders[1].total_feeder_operations"
        Me.CtrlOPCLabel1.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF2
        '
        Me.btnResetProductivityTF2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF2.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF2.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF2.HighStateText = "TF 2"
        Me.btnResetProductivityTF2.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF2.Location = New System.Drawing.Point(9, 41)
        Me.btnResetProductivityTF2.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF2.LowStateText = "TF 2"
        Me.btnResetProductivityTF2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF2.Name = "btnResetProductivityTF2"
        Me.btnResetProductivityTF2.PlcName = ""
        Me.btnResetProductivityTF2.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF2.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF2.TabIndex = 4
        Me.btnResetProductivityTF2.TagName = "bReset_Towel_Folder_Counts[2]"
        '
        'CtrlOPCLabel2
        '
        Me.CtrlOPCLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel2.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel2.Location = New System.Drawing.Point(117, 52)
        Me.CtrlOPCLabel2.Name = "CtrlOPCLabel2"
        Me.CtrlOPCLabel2.PlcName = Nothing
        Me.CtrlOPCLabel2.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel2.TabIndex = 5
        Me.CtrlOPCLabel2.TagName = "TowelFolders[2].total_feeder_operations"
        Me.CtrlOPCLabel2.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel3
        '
        Me.CtrlOPCLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel3.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel3.Location = New System.Drawing.Point(117, 84)
        Me.CtrlOPCLabel3.Name = "CtrlOPCLabel3"
        Me.CtrlOPCLabel3.PlcName = Nothing
        Me.CtrlOPCLabel3.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel3.TabIndex = 7
        Me.CtrlOPCLabel3.TagName = "TowelFolders[3].total_feeder_operations"
        Me.CtrlOPCLabel3.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF3
        '
        Me.btnResetProductivityTF3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF3.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF3.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF3.HighStateText = "TF 3"
        Me.btnResetProductivityTF3.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF3.Location = New System.Drawing.Point(9, 73)
        Me.btnResetProductivityTF3.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF3.LowStateText = "TF 3"
        Me.btnResetProductivityTF3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF3.Name = "btnResetProductivityTF3"
        Me.btnResetProductivityTF3.PlcName = ""
        Me.btnResetProductivityTF3.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF3.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF3.TabIndex = 6
        Me.btnResetProductivityTF3.TagName = "bReset_Towel_Folder_Counts[3]"
        '
        'CtrlOPCLabel4
        '
        Me.CtrlOPCLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel4.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel4.Location = New System.Drawing.Point(117, 116)
        Me.CtrlOPCLabel4.Name = "CtrlOPCLabel4"
        Me.CtrlOPCLabel4.PlcName = Nothing
        Me.CtrlOPCLabel4.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel4.TabIndex = 9
        Me.CtrlOPCLabel4.TagName = "TowelFolders[4].total_feeder_operations"
        Me.CtrlOPCLabel4.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF4
        '
        Me.btnResetProductivityTF4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF4.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF4.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF4.HighStateText = "TF 4"
        Me.btnResetProductivityTF4.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF4.Location = New System.Drawing.Point(9, 105)
        Me.btnResetProductivityTF4.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF4.LowStateText = "TF 4"
        Me.btnResetProductivityTF4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF4.Name = "btnResetProductivityTF4"
        Me.btnResetProductivityTF4.PlcName = ""
        Me.btnResetProductivityTF4.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF4.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF4.TabIndex = 8
        Me.btnResetProductivityTF4.TagName = "bReset_Towel_Folder_Counts[4]"
        '
        'CtrlOPCLabel5
        '
        Me.CtrlOPCLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel5.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel5.Location = New System.Drawing.Point(117, 148)
        Me.CtrlOPCLabel5.Name = "CtrlOPCLabel5"
        Me.CtrlOPCLabel5.PlcName = Nothing
        Me.CtrlOPCLabel5.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel5.TabIndex = 11
        Me.CtrlOPCLabel5.TagName = "TowelFolders[5].total_feeder_operations"
        Me.CtrlOPCLabel5.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF5
        '
        Me.btnResetProductivityTF5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF5.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF5.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF5.HighStateText = "TF 5"
        Me.btnResetProductivityTF5.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF5.Location = New System.Drawing.Point(9, 137)
        Me.btnResetProductivityTF5.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF5.LowStateText = "TF 5"
        Me.btnResetProductivityTF5.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF5.Name = "btnResetProductivityTF5"
        Me.btnResetProductivityTF5.PlcName = ""
        Me.btnResetProductivityTF5.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF5.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF5.TabIndex = 10
        Me.btnResetProductivityTF5.TagName = "bReset_Towel_Folder_Counts[5]"
        '
        'CtrlOPCLabel6
        '
        Me.CtrlOPCLabel6.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel6.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel6.Location = New System.Drawing.Point(117, 180)
        Me.CtrlOPCLabel6.Name = "CtrlOPCLabel6"
        Me.CtrlOPCLabel6.PlcName = Nothing
        Me.CtrlOPCLabel6.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel6.TabIndex = 13
        Me.CtrlOPCLabel6.TagName = "TowelFolders[6].total_feeder_operations"
        Me.CtrlOPCLabel6.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF6
        '
        Me.btnResetProductivityTF6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF6.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF6.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF6.HighStateText = "TF 6"
        Me.btnResetProductivityTF6.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF6.Location = New System.Drawing.Point(9, 169)
        Me.btnResetProductivityTF6.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF6.LowStateText = "TF 6"
        Me.btnResetProductivityTF6.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF6.Name = "btnResetProductivityTF6"
        Me.btnResetProductivityTF6.PlcName = ""
        Me.btnResetProductivityTF6.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF6.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF6.TabIndex = 12
        Me.btnResetProductivityTF6.TagName = "bReset_Towel_Folder_Counts[6]"
        '
        'CtrlOPCLabel7
        '
        Me.CtrlOPCLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel7.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel7.Location = New System.Drawing.Point(117, 211)
        Me.CtrlOPCLabel7.Name = "CtrlOPCLabel7"
        Me.CtrlOPCLabel7.PlcName = Nothing
        Me.CtrlOPCLabel7.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel7.TabIndex = 15
        Me.CtrlOPCLabel7.TagName = "TowelFolders[7].total_feeder_operations"
        Me.CtrlOPCLabel7.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF7
        '
        Me.btnResetProductivityTF7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF7.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF7.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF7.HighStateText = "TF 7"
        Me.btnResetProductivityTF7.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF7.Location = New System.Drawing.Point(9, 201)
        Me.btnResetProductivityTF7.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF7.LowStateText = "TF 7"
        Me.btnResetProductivityTF7.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF7.Name = "btnResetProductivityTF7"
        Me.btnResetProductivityTF7.PlcName = ""
        Me.btnResetProductivityTF7.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF7.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF7.TabIndex = 14
        Me.btnResetProductivityTF7.TagName = "bReset_Towel_Folder_Counts[7]"
        '
        'CtrlOPCLabel8
        '
        Me.CtrlOPCLabel8.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel8.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel8.Location = New System.Drawing.Point(117, 244)
        Me.CtrlOPCLabel8.Name = "CtrlOPCLabel8"
        Me.CtrlOPCLabel8.PlcName = Nothing
        Me.CtrlOPCLabel8.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel8.TabIndex = 17
        Me.CtrlOPCLabel8.TagName = "TowelFolders[8].total_feeder_operations"
        Me.CtrlOPCLabel8.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF8
        '
        Me.btnResetProductivityTF8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF8.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF8.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF8.HighStateText = "TF 8"
        Me.btnResetProductivityTF8.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF8.Location = New System.Drawing.Point(9, 233)
        Me.btnResetProductivityTF8.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF8.LowStateText = "TF 8"
        Me.btnResetProductivityTF8.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF8.Name = "btnResetProductivityTF8"
        Me.btnResetProductivityTF8.PlcName = ""
        Me.btnResetProductivityTF8.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF8.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF8.TabIndex = 16
        Me.btnResetProductivityTF8.TagName = "bReset_Towel_Folder_Counts[8]"
        '
        'CtrlOPCLabel9
        '
        Me.CtrlOPCLabel9.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel9.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel9.Location = New System.Drawing.Point(117, 276)
        Me.CtrlOPCLabel9.Name = "CtrlOPCLabel9"
        Me.CtrlOPCLabel9.PlcName = Nothing
        Me.CtrlOPCLabel9.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel9.TabIndex = 19
        Me.CtrlOPCLabel9.TagName = "TowelFolders[9].total_feeder_operations"
        Me.CtrlOPCLabel9.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF9
        '
        Me.btnResetProductivityTF9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF9.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF9.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF9.HighStateText = "TF 9"
        Me.btnResetProductivityTF9.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF9.Location = New System.Drawing.Point(9, 265)
        Me.btnResetProductivityTF9.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF9.LowStateText = "TF 9"
        Me.btnResetProductivityTF9.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF9.Name = "btnResetProductivityTF9"
        Me.btnResetProductivityTF9.PlcName = ""
        Me.btnResetProductivityTF9.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF9.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF9.TabIndex = 18
        Me.btnResetProductivityTF9.TagName = "bReset_Towel_Folder_Counts[9]"
        '
        'CtrlOPCLabel10
        '
        Me.CtrlOPCLabel10.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel10.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel10.Location = New System.Drawing.Point(117, 308)
        Me.CtrlOPCLabel10.Name = "CtrlOPCLabel10"
        Me.CtrlOPCLabel10.PlcName = Nothing
        Me.CtrlOPCLabel10.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel10.TabIndex = 21
        Me.CtrlOPCLabel10.TagName = "TowelFolders[10].total_feeder_operations"
        Me.CtrlOPCLabel10.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF10
        '
        Me.btnResetProductivityTF10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF10.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF10.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF10.HighStateText = "TF 10"
        Me.btnResetProductivityTF10.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF10.Location = New System.Drawing.Point(9, 297)
        Me.btnResetProductivityTF10.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF10.LowStateText = "TF 10"
        Me.btnResetProductivityTF10.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF10.Name = "btnResetProductivityTF10"
        Me.btnResetProductivityTF10.PlcName = ""
        Me.btnResetProductivityTF10.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF10.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF10.TabIndex = 20
        Me.btnResetProductivityTF10.TagName = "bReset_Towel_Folder_Counts[10]"
        '
        'CtrlOPCLabel11
        '
        Me.CtrlOPCLabel11.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel11.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel11.Location = New System.Drawing.Point(117, 340)
        Me.CtrlOPCLabel11.Name = "CtrlOPCLabel11"
        Me.CtrlOPCLabel11.PlcName = Nothing
        Me.CtrlOPCLabel11.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel11.TabIndex = 23
        Me.CtrlOPCLabel11.TagName = "TowelFolders[11].total_feeder_operations"
        Me.CtrlOPCLabel11.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF11
        '
        Me.btnResetProductivityTF11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF11.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF11.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF11.HighStateText = "TF 11"
        Me.btnResetProductivityTF11.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF11.Location = New System.Drawing.Point(9, 329)
        Me.btnResetProductivityTF11.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF11.LowStateText = "TF 11"
        Me.btnResetProductivityTF11.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF11.Name = "btnResetProductivityTF11"
        Me.btnResetProductivityTF11.PlcName = ""
        Me.btnResetProductivityTF11.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF11.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF11.TabIndex = 22
        Me.btnResetProductivityTF11.TagName = "bReset_Towel_Folder_Counts[11]"
        '
        'CtrlOPCLabel12
        '
        Me.CtrlOPCLabel12.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel12.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel12.Location = New System.Drawing.Point(288, 340)
        Me.CtrlOPCLabel12.Name = "CtrlOPCLabel12"
        Me.CtrlOPCLabel12.PlcName = Nothing
        Me.CtrlOPCLabel12.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel12.TabIndex = 45
        Me.CtrlOPCLabel12.TagName = "TowelFolders[22].total_feeder_operations"
        Me.CtrlOPCLabel12.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF22
        '
        Me.btnResetProductivityTF22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF22.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF22.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF22.HighStateText = "TF 22"
        Me.btnResetProductivityTF22.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF22.Location = New System.Drawing.Point(180, 329)
        Me.btnResetProductivityTF22.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF22.LowStateText = "TF 22"
        Me.btnResetProductivityTF22.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF22.Name = "btnResetProductivityTF22"
        Me.btnResetProductivityTF22.PlcName = ""
        Me.btnResetProductivityTF22.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF22.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF22.TabIndex = 44
        Me.btnResetProductivityTF22.TagName = "bReset_Towel_Folder_Counts[22]"
        '
        'CtrlOPCLabel13
        '
        Me.CtrlOPCLabel13.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel13.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel13.Location = New System.Drawing.Point(288, 308)
        Me.CtrlOPCLabel13.Name = "CtrlOPCLabel13"
        Me.CtrlOPCLabel13.PlcName = Nothing
        Me.CtrlOPCLabel13.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel13.TabIndex = 43
        Me.CtrlOPCLabel13.TagName = "TowelFolders[21].total_feeder_operations"
        Me.CtrlOPCLabel13.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF21
        '
        Me.btnResetProductivityTF21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF21.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF21.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF21.HighStateText = "TF 21"
        Me.btnResetProductivityTF21.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF21.Location = New System.Drawing.Point(180, 297)
        Me.btnResetProductivityTF21.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF21.LowStateText = "TF 21"
        Me.btnResetProductivityTF21.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF21.Name = "btnResetProductivityTF21"
        Me.btnResetProductivityTF21.PlcName = ""
        Me.btnResetProductivityTF21.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF21.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF21.TabIndex = 42
        Me.btnResetProductivityTF21.TagName = "bReset_Towel_Folder_Counts[21]"
        '
        'CtrlOPCLabel14
        '
        Me.CtrlOPCLabel14.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel14.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel14.Location = New System.Drawing.Point(288, 276)
        Me.CtrlOPCLabel14.Name = "CtrlOPCLabel14"
        Me.CtrlOPCLabel14.PlcName = Nothing
        Me.CtrlOPCLabel14.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel14.TabIndex = 41
        Me.CtrlOPCLabel14.TagName = "TowelFolders[20].total_feeder_operations"
        Me.CtrlOPCLabel14.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF20
        '
        Me.btnResetProductivityTF20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF20.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF20.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF20.HighStateText = "TF 20"
        Me.btnResetProductivityTF20.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF20.Location = New System.Drawing.Point(180, 265)
        Me.btnResetProductivityTF20.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF20.LowStateText = "TF 20"
        Me.btnResetProductivityTF20.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF20.Name = "btnResetProductivityTF20"
        Me.btnResetProductivityTF20.PlcName = ""
        Me.btnResetProductivityTF20.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF20.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF20.TabIndex = 40
        Me.btnResetProductivityTF20.TagName = "bReset_Towel_Folder_Counts[20]"
        '
        'CtrlOPCLabel15
        '
        Me.CtrlOPCLabel15.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel15.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel15.Location = New System.Drawing.Point(288, 244)
        Me.CtrlOPCLabel15.Name = "CtrlOPCLabel15"
        Me.CtrlOPCLabel15.PlcName = Nothing
        Me.CtrlOPCLabel15.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel15.TabIndex = 39
        Me.CtrlOPCLabel15.TagName = "TowelFolders[19].total_feeder_operations"
        Me.CtrlOPCLabel15.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF19
        '
        Me.btnResetProductivityTF19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF19.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF19.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF19.HighStateText = "TF 19"
        Me.btnResetProductivityTF19.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF19.Location = New System.Drawing.Point(180, 233)
        Me.btnResetProductivityTF19.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF19.LowStateText = "TF 19"
        Me.btnResetProductivityTF19.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF19.Name = "btnResetProductivityTF19"
        Me.btnResetProductivityTF19.PlcName = ""
        Me.btnResetProductivityTF19.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF19.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF19.TabIndex = 38
        Me.btnResetProductivityTF19.TagName = "bReset_Towel_Folder_Counts[19]"
        '
        'CtrlOPCLabel16
        '
        Me.CtrlOPCLabel16.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel16.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel16.Location = New System.Drawing.Point(288, 211)
        Me.CtrlOPCLabel16.Name = "CtrlOPCLabel16"
        Me.CtrlOPCLabel16.PlcName = Nothing
        Me.CtrlOPCLabel16.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel16.TabIndex = 37
        Me.CtrlOPCLabel16.TagName = "TowelFolders[18].total_feeder_operations"
        Me.CtrlOPCLabel16.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF18
        '
        Me.btnResetProductivityTF18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF18.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF18.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF18.HighStateText = "TF 18"
        Me.btnResetProductivityTF18.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF18.Location = New System.Drawing.Point(180, 201)
        Me.btnResetProductivityTF18.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF18.LowStateText = "TF 18"
        Me.btnResetProductivityTF18.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF18.Name = "btnResetProductivityTF18"
        Me.btnResetProductivityTF18.PlcName = ""
        Me.btnResetProductivityTF18.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF18.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF18.TabIndex = 36
        Me.btnResetProductivityTF18.TagName = "bReset_Towel_Folder_Counts[18]"
        '
        'CtrlOPCLabel17
        '
        Me.CtrlOPCLabel17.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel17.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel17.Location = New System.Drawing.Point(288, 180)
        Me.CtrlOPCLabel17.Name = "CtrlOPCLabel17"
        Me.CtrlOPCLabel17.PlcName = Nothing
        Me.CtrlOPCLabel17.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel17.TabIndex = 35
        Me.CtrlOPCLabel17.TagName = "TowelFolders[17].total_feeder_operations"
        Me.CtrlOPCLabel17.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF17
        '
        Me.btnResetProductivityTF17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF17.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF17.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF17.HighStateText = "TF 17"
        Me.btnResetProductivityTF17.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF17.Location = New System.Drawing.Point(180, 169)
        Me.btnResetProductivityTF17.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF17.LowStateText = "TF 17"
        Me.btnResetProductivityTF17.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF17.Name = "btnResetProductivityTF17"
        Me.btnResetProductivityTF17.PlcName = ""
        Me.btnResetProductivityTF17.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF17.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF17.TabIndex = 34
        Me.btnResetProductivityTF17.TagName = "bReset_Towel_Folder_Counts[17]"
        '
        'CtrlOPCLabel18
        '
        Me.CtrlOPCLabel18.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel18.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel18.Location = New System.Drawing.Point(288, 148)
        Me.CtrlOPCLabel18.Name = "CtrlOPCLabel18"
        Me.CtrlOPCLabel18.PlcName = Nothing
        Me.CtrlOPCLabel18.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel18.TabIndex = 33
        Me.CtrlOPCLabel18.TagName = "TowelFolders[16].total_feeder_operations"
        Me.CtrlOPCLabel18.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF16
        '
        Me.btnResetProductivityTF16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF16.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF16.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF16.HighStateText = "TF 16"
        Me.btnResetProductivityTF16.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF16.Location = New System.Drawing.Point(180, 137)
        Me.btnResetProductivityTF16.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF16.LowStateText = "TF 16"
        Me.btnResetProductivityTF16.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF16.Name = "btnResetProductivityTF16"
        Me.btnResetProductivityTF16.PlcName = ""
        Me.btnResetProductivityTF16.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF16.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF16.TabIndex = 32
        Me.btnResetProductivityTF16.TagName = "bReset_Towel_Folder_Counts[16]"
        '
        'CtrlOPCLabel19
        '
        Me.CtrlOPCLabel19.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel19.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel19.Location = New System.Drawing.Point(288, 116)
        Me.CtrlOPCLabel19.Name = "CtrlOPCLabel19"
        Me.CtrlOPCLabel19.PlcName = Nothing
        Me.CtrlOPCLabel19.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel19.TabIndex = 31
        Me.CtrlOPCLabel19.TagName = "TowelFolders[15].total_feeder_operations"
        Me.CtrlOPCLabel19.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF15
        '
        Me.btnResetProductivityTF15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF15.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF15.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF15.HighStateText = "TF 15"
        Me.btnResetProductivityTF15.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF15.Location = New System.Drawing.Point(180, 105)
        Me.btnResetProductivityTF15.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF15.LowStateText = "TF 15"
        Me.btnResetProductivityTF15.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF15.Name = "btnResetProductivityTF15"
        Me.btnResetProductivityTF15.PlcName = ""
        Me.btnResetProductivityTF15.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF15.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF15.TabIndex = 30
        Me.btnResetProductivityTF15.TagName = "bReset_Towel_Folder_Counts[15]"
        '
        'CtrlOPCLabel20
        '
        Me.CtrlOPCLabel20.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel20.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel20.Location = New System.Drawing.Point(288, 84)
        Me.CtrlOPCLabel20.Name = "CtrlOPCLabel20"
        Me.CtrlOPCLabel20.PlcName = Nothing
        Me.CtrlOPCLabel20.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel20.TabIndex = 29
        Me.CtrlOPCLabel20.TagName = "TowelFolders[14].total_feeder_operations"
        Me.CtrlOPCLabel20.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF14
        '
        Me.btnResetProductivityTF14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF14.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF14.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF14.HighStateText = "TF 14"
        Me.btnResetProductivityTF14.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF14.Location = New System.Drawing.Point(180, 73)
        Me.btnResetProductivityTF14.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF14.LowStateText = "TF 14"
        Me.btnResetProductivityTF14.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF14.Name = "btnResetProductivityTF14"
        Me.btnResetProductivityTF14.PlcName = ""
        Me.btnResetProductivityTF14.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF14.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF14.TabIndex = 28
        Me.btnResetProductivityTF14.TagName = "bReset_Towel_Folder_Counts[14]"
        '
        'CtrlOPCLabel21
        '
        Me.CtrlOPCLabel21.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel21.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel21.Location = New System.Drawing.Point(288, 52)
        Me.CtrlOPCLabel21.Name = "CtrlOPCLabel21"
        Me.CtrlOPCLabel21.PlcName = Nothing
        Me.CtrlOPCLabel21.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel21.TabIndex = 27
        Me.CtrlOPCLabel21.TagName = "TowelFolders[13].total_feeder_operations"
        Me.CtrlOPCLabel21.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF13
        '
        Me.btnResetProductivityTF13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF13.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF13.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF13.HighStateText = "TF 13"
        Me.btnResetProductivityTF13.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF13.Location = New System.Drawing.Point(180, 41)
        Me.btnResetProductivityTF13.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF13.LowStateText = "TF 13"
        Me.btnResetProductivityTF13.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF13.Name = "btnResetProductivityTF13"
        Me.btnResetProductivityTF13.PlcName = ""
        Me.btnResetProductivityTF13.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF13.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF13.TabIndex = 26
        Me.btnResetProductivityTF13.TagName = "bReset_Towel_Folder_Counts[13]"
        '
        'CtrlOPCLabel22
        '
        Me.CtrlOPCLabel22.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel22.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel22.Location = New System.Drawing.Point(288, 20)
        Me.CtrlOPCLabel22.Name = "CtrlOPCLabel22"
        Me.CtrlOPCLabel22.PlcName = Nothing
        Me.CtrlOPCLabel22.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel22.TabIndex = 25
        Me.CtrlOPCLabel22.TagName = "TowelFolders[12].total_feeder_operations"
        Me.CtrlOPCLabel22.TextToDisplay = "{0}"
        '
        'btnResetProductivityTF12
        '
        Me.btnResetProductivityTF12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityTF12.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityTF12.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF12.HighStateText = "TF 12"
        Me.btnResetProductivityTF12.IsSecurityFeatureUsed = False
        Me.btnResetProductivityTF12.Location = New System.Drawing.Point(180, 9)
        Me.btnResetProductivityTF12.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityTF12.LowStateText = "TF 12"
        Me.btnResetProductivityTF12.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityTF12.Name = "btnResetProductivityTF12"
        Me.btnResetProductivityTF12.PlcName = ""
        Me.btnResetProductivityTF12.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityTF12.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityTF12.TabIndex = 24
        Me.btnResetProductivityTF12.TagName = "bReset_Towel_Folder_Counts[12]"
        '
        'btnResetProductivityFW7
        '
        Me.btnResetProductivityFW7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW7.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW7.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW7.HighStateText = "Ironer 7"
        Me.btnResetProductivityFW7.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW7.Location = New System.Drawing.Point(351, 201)
        Me.btnResetProductivityFW7.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW7.LowStateText = "Ironer 7"
        Me.btnResetProductivityFW7.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW7.Name = "btnResetProductivityFW7"
        Me.btnResetProductivityFW7.PlcName = ""
        Me.btnResetProductivityFW7.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW7.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW7.TabIndex = 58
        Me.btnResetProductivityFW7.TagName = "bReset_Ironer_Counts[7]"
        '
        'btnResetProductivityFW6
        '
        Me.btnResetProductivityFW6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW6.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW6.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW6.HighStateText = "Ironer 6"
        Me.btnResetProductivityFW6.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW6.Location = New System.Drawing.Point(351, 169)
        Me.btnResetProductivityFW6.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW6.LowStateText = "Ironer 6"
        Me.btnResetProductivityFW6.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW6.Name = "btnResetProductivityFW6"
        Me.btnResetProductivityFW6.PlcName = ""
        Me.btnResetProductivityFW6.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW6.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW6.TabIndex = 56
        Me.btnResetProductivityFW6.TagName = "bReset_Ironer_Counts[6]"
        '
        'btnResetProductivityFW5
        '
        Me.btnResetProductivityFW5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW5.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW5.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW5.HighStateText = "Ironer 5"
        Me.btnResetProductivityFW5.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW5.Location = New System.Drawing.Point(351, 137)
        Me.btnResetProductivityFW5.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW5.LowStateText = "Ironer 5"
        Me.btnResetProductivityFW5.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW5.Name = "btnResetProductivityFW5"
        Me.btnResetProductivityFW5.PlcName = ""
        Me.btnResetProductivityFW5.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW5.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW5.TabIndex = 54
        Me.btnResetProductivityFW5.TagName = "bReset_Ironer_Counts[5]"
        '
        'btnResetProductivityFW4
        '
        Me.btnResetProductivityFW4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW4.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW4.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW4.HighStateText = "Ironer 4"
        Me.btnResetProductivityFW4.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW4.Location = New System.Drawing.Point(351, 105)
        Me.btnResetProductivityFW4.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW4.LowStateText = "Ironer 4"
        Me.btnResetProductivityFW4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW4.Name = "btnResetProductivityFW4"
        Me.btnResetProductivityFW4.PlcName = ""
        Me.btnResetProductivityFW4.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW4.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW4.TabIndex = 52
        Me.btnResetProductivityFW4.TagName = "bReset_Ironer_Counts[4]"
        '
        'btnResetProductivityFW3
        '
        Me.btnResetProductivityFW3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW3.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW3.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW3.HighStateText = "Ironer 3"
        Me.btnResetProductivityFW3.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW3.Location = New System.Drawing.Point(351, 73)
        Me.btnResetProductivityFW3.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW3.LowStateText = "Ironer 3"
        Me.btnResetProductivityFW3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW3.Name = "btnResetProductivityFW3"
        Me.btnResetProductivityFW3.PlcName = ""
        Me.btnResetProductivityFW3.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW3.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW3.TabIndex = 50
        Me.btnResetProductivityFW3.TagName = "bReset_Ironer_Counts[3]"
        '
        'btnResetProductivityFW2
        '
        Me.btnResetProductivityFW2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW2.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW2.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW2.HighStateText = "Ironer 2"
        Me.btnResetProductivityFW2.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW2.Location = New System.Drawing.Point(351, 41)
        Me.btnResetProductivityFW2.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW2.LowStateText = "Ironer 2"
        Me.btnResetProductivityFW2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW2.Name = "btnResetProductivityFW2"
        Me.btnResetProductivityFW2.PlcName = ""
        Me.btnResetProductivityFW2.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW2.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW2.TabIndex = 48
        Me.btnResetProductivityFW2.TagName = "bReset_Ironer_Counts[2]"
        '
        'btnResetProductivityFW1
        '
        Me.btnResetProductivityFW1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.btnResetProductivityFW1.GroupName = "Productivity_Productivity"
        Me.btnResetProductivityFW1.HighStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW1.HighStateText = "Ironer 1"
        Me.btnResetProductivityFW1.IsSecurityFeatureUsed = False
        Me.btnResetProductivityFW1.Location = New System.Drawing.Point(351, 9)
        Me.btnResetProductivityFW1.LowStateColor = System.Drawing.SystemColors.Control
        Me.btnResetProductivityFW1.LowStateText = "Ironer 1"
        Me.btnResetProductivityFW1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetProductivityFW1.Name = "btnResetProductivityFW1"
        Me.btnResetProductivityFW1.PlcName = ""
        Me.btnResetProductivityFW1.RightNeeded = RailAccessOptions.UNKNOWN
        Me.btnResetProductivityFW1.Size = New System.Drawing.Size(105, 32)
        Me.btnResetProductivityFW1.TabIndex = 46
        Me.btnResetProductivityFW1.TagName = "bReset_Ironer_Counts[1]"
        '
        'btnResetAllData
        '
        Me.btnResetAllData.Location = New System.Drawing.Point(178, 385)
        Me.btnResetAllData.Name = "btnResetAllData"
        Me.btnResetAllData.Size = New System.Drawing.Size(182, 42)
        Me.btnResetAllData.TabIndex = 59
        Me.btnResetAllData.Text = "RESET ALL DATA"
        Me.btnResetAllData.UseVisualStyleBackColor = True
        '
        'CtrlOPCLabel23
        '
        Me.CtrlOPCLabel23.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel23.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel23.Location = New System.Drawing.Point(459, 20)
        Me.CtrlOPCLabel23.Name = "CtrlOPCLabel23"
        Me.CtrlOPCLabel23.PlcName = Nothing
        Me.CtrlOPCLabel23.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel23.TabIndex = 25
        Me.CtrlOPCLabel23.TagName = "dintIroner_1_Total_Counts"
        Me.CtrlOPCLabel23.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel24
        '
        Me.CtrlOPCLabel24.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel24.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel24.Location = New System.Drawing.Point(459, 52)
        Me.CtrlOPCLabel24.Name = "CtrlOPCLabel24"
        Me.CtrlOPCLabel24.PlcName = Nothing
        Me.CtrlOPCLabel24.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel24.TabIndex = 25
        Me.CtrlOPCLabel24.TagName = "dintIroner_2_Total_Counts"
        Me.CtrlOPCLabel24.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel25
        '
        Me.CtrlOPCLabel25.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel25.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel25.Location = New System.Drawing.Point(459, 84)
        Me.CtrlOPCLabel25.Name = "CtrlOPCLabel25"
        Me.CtrlOPCLabel25.PlcName = Nothing
        Me.CtrlOPCLabel25.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel25.TabIndex = 25
        Me.CtrlOPCLabel25.TagName = "dintIroner_3_Total_Counts"
        Me.CtrlOPCLabel25.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel26
        '
        Me.CtrlOPCLabel26.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel26.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel26.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel26.Location = New System.Drawing.Point(459, 116)
        Me.CtrlOPCLabel26.Name = "CtrlOPCLabel26"
        Me.CtrlOPCLabel26.PlcName = Nothing
        Me.CtrlOPCLabel26.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel26.TabIndex = 25
        Me.CtrlOPCLabel26.TagName = "dintIroner_4_Total_Counts"
        Me.CtrlOPCLabel26.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel27
        '
        Me.CtrlOPCLabel27.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel27.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel27.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel27.Location = New System.Drawing.Point(459, 148)
        Me.CtrlOPCLabel27.Name = "CtrlOPCLabel27"
        Me.CtrlOPCLabel27.PlcName = Nothing
        Me.CtrlOPCLabel27.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel27.TabIndex = 25
        Me.CtrlOPCLabel27.TagName = "dintIroner_5_Total_Counts"
        Me.CtrlOPCLabel27.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel28
        '
        Me.CtrlOPCLabel28.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel28.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel28.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel28.Location = New System.Drawing.Point(459, 180)
        Me.CtrlOPCLabel28.Name = "CtrlOPCLabel28"
        Me.CtrlOPCLabel28.PlcName = Nothing
        Me.CtrlOPCLabel28.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel28.TabIndex = 25
        Me.CtrlOPCLabel28.TagName = "dintIroner_6_Total_Counts"
        Me.CtrlOPCLabel28.TextToDisplay = "{0}"
        '
        'CtrlOPCLabel29
        '
        Me.CtrlOPCLabel29.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel29.GroupName = "Productivity_Productivity"
        Me.CtrlOPCLabel29.Location = New System.Drawing.Point(459, 211)
        Me.CtrlOPCLabel29.Name = "CtrlOPCLabel29"
        Me.CtrlOPCLabel29.PlcName = Nothing
        Me.CtrlOPCLabel29.Size = New System.Drawing.Size(60, 21)
        Me.CtrlOPCLabel29.TabIndex = 25
        Me.CtrlOPCLabel29.TagName = "dintIroner_7_Total_Counts"
        Me.CtrlOPCLabel29.TextToDisplay = "{0}"
        '
        'frmProductivityControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 439)
        Me.Controls.Add(Me.btnResetAllData)
        Me.Controls.Add(Me.btnResetProductivityFW7)
        Me.Controls.Add(Me.btnResetProductivityFW6)
        Me.Controls.Add(Me.btnResetProductivityFW5)
        Me.Controls.Add(Me.btnResetProductivityFW4)
        Me.Controls.Add(Me.btnResetProductivityFW3)
        Me.Controls.Add(Me.btnResetProductivityFW2)
        Me.Controls.Add(Me.btnResetProductivityFW1)
        Me.Controls.Add(Me.CtrlOPCLabel12)
        Me.Controls.Add(Me.btnResetProductivityTF22)
        Me.Controls.Add(Me.CtrlOPCLabel13)
        Me.Controls.Add(Me.btnResetProductivityTF21)
        Me.Controls.Add(Me.CtrlOPCLabel14)
        Me.Controls.Add(Me.btnResetProductivityTF20)
        Me.Controls.Add(Me.CtrlOPCLabel15)
        Me.Controls.Add(Me.btnResetProductivityTF19)
        Me.Controls.Add(Me.CtrlOPCLabel16)
        Me.Controls.Add(Me.btnResetProductivityTF18)
        Me.Controls.Add(Me.CtrlOPCLabel17)
        Me.Controls.Add(Me.btnResetProductivityTF17)
        Me.Controls.Add(Me.CtrlOPCLabel18)
        Me.Controls.Add(Me.btnResetProductivityTF16)
        Me.Controls.Add(Me.CtrlOPCLabel19)
        Me.Controls.Add(Me.btnResetProductivityTF15)
        Me.Controls.Add(Me.CtrlOPCLabel20)
        Me.Controls.Add(Me.btnResetProductivityTF14)
        Me.Controls.Add(Me.CtrlOPCLabel21)
        Me.Controls.Add(Me.btnResetProductivityTF13)
        Me.Controls.Add(Me.CtrlOPCLabel29)
        Me.Controls.Add(Me.CtrlOPCLabel28)
        Me.Controls.Add(Me.CtrlOPCLabel27)
        Me.Controls.Add(Me.CtrlOPCLabel26)
        Me.Controls.Add(Me.CtrlOPCLabel25)
        Me.Controls.Add(Me.CtrlOPCLabel24)
        Me.Controls.Add(Me.CtrlOPCLabel23)
        Me.Controls.Add(Me.CtrlOPCLabel22)
        Me.Controls.Add(Me.btnResetProductivityTF12)
        Me.Controls.Add(Me.CtrlOPCLabel11)
        Me.Controls.Add(Me.btnResetProductivityTF11)
        Me.Controls.Add(Me.CtrlOPCLabel10)
        Me.Controls.Add(Me.btnResetProductivityTF10)
        Me.Controls.Add(Me.CtrlOPCLabel9)
        Me.Controls.Add(Me.btnResetProductivityTF9)
        Me.Controls.Add(Me.CtrlOPCLabel8)
        Me.Controls.Add(Me.btnResetProductivityTF8)
        Me.Controls.Add(Me.CtrlOPCLabel7)
        Me.Controls.Add(Me.btnResetProductivityTF7)
        Me.Controls.Add(Me.CtrlOPCLabel6)
        Me.Controls.Add(Me.btnResetProductivityTF6)
        Me.Controls.Add(Me.CtrlOPCLabel5)
        Me.Controls.Add(Me.btnResetProductivityTF5)
        Me.Controls.Add(Me.CtrlOPCLabel4)
        Me.Controls.Add(Me.btnResetProductivityTF4)
        Me.Controls.Add(Me.CtrlOPCLabel3)
        Me.Controls.Add(Me.btnResetProductivityTF3)
        Me.Controls.Add(Me.CtrlOPCLabel2)
        Me.Controls.Add(Me.btnResetProductivityTF2)
        Me.Controls.Add(Me.CtrlOPCLabel1)
        Me.Controls.Add(Me.btnResetProductivityTF1)
        Me.Controls.Add(Me.btnResetClassifiedSorting)
        Me.Controls.Add(Me.btnResetCartDump)
        Me.Controls.Add(Me.btnResetWashdeck)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductivityControl"
        Me.Text = "Productivity Control"
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnResetWashdeck As CtrlOpcButton
    Friend WithEvents btnResetClassifiedSorting As CtrlOpcButton
    Friend WithEvents btnResetCartDump As CtrlOpcButton
    Friend WithEvents btnResetProductivityTF1 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel1 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF2 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel2 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel3 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF3 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel4 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF4 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel5 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF5 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel6 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF6 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel7 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF7 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel8 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF8 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel9 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF9 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel10 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF10 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel11 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF11 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel12 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF22 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel13 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF21 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel14 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF20 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel15 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF19 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel16 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF18 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel17 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF17 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel18 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF16 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel19 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF15 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel20 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF14 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel21 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF13 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel22 As CtrlOpcLabel
    Friend WithEvents btnResetProductivityTF12 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW7 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW6 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW5 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW4 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW3 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW2 As CtrlOpcButton
    Friend WithEvents btnResetProductivityFW1 As CtrlOpcButton
    Friend WithEvents btnResetAllData As System.Windows.Forms.Button
    Friend WithEvents CtrlOPCLabel23 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel24 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel25 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel26 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel27 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel28 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel29 As CtrlOpcLabel
End Class
