Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Opc.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRfidReaderDiagnostics

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRfidReaderDiagnostics))
        Me.btnIronerCommCountReset = New System.Windows.Forms.Button()
        Me.CtrlOPCLabel3 = New CtrlOpcLabel()
        Me.btnTFCommCountReset = New System.Windows.Forms.Button()
        Me.CtrlOPCLabel5 = New CtrlOpcLabel()
        Me.CtrlOPCLabel19 = New CtrlOpcLabel()
        Me.CtrlOPCLabel7 = New CtrlOpcLabel()
        Me.CtrlOPCLabel9 = New CtrlOpcLabel()
        Me.CtrlOPCLabel11 = New CtrlOpcLabel()
        Me.CtrlOPCLabel13 = New CtrlOpcLabel()
        Me.CtrlOPCLabel15 = New CtrlOpcLabel()
        Me.CtrlOPCLabel17 = New CtrlOpcLabel()
        Me.CtrlOPCLabel33 = New CtrlOpcLabel()
        Me.CtrlOPCLabel34 = New CtrlOpcLabel()
        Me.CtrlOPCLabel35 = New CtrlOpcLabel()
        Me.CtrlOPCLabel36 = New CtrlOpcLabel()
        Me.CtrlOPCLabel37 = New CtrlOpcLabel()
        Me.CtrlOPCLabel38 = New CtrlOpcLabel()
        Me.CtrlOPCLabel39 = New CtrlOpcLabel()
        Me.CtrlOPCLabel40 = New CtrlOpcLabel()
        Me.CtrlOPCLabel41 = New CtrlOpcLabel()
        Me.CtrlOPCLabel42 = New CtrlOpcLabel()
        Me.CtrlOPCLabel43 = New CtrlOpcLabel()
        Me.CtrlOPCLabel44 = New CtrlOpcLabel()
        Me.CtrlOPCLabel45 = New CtrlOpcLabel()
        Me.CtrlOPCLabel46 = New CtrlOpcLabel()
        Me.CtrlOPCLabel47 = New CtrlOpcLabel()
        Me.CtrlOPCLabel48 = New CtrlOpcLabel()
        Me.CtrlOPCLabel49 = New CtrlOpcLabel()
        Me.CtrlOPCTextBox2 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox3 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox4 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox5 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox1 = New CtrlOpcTextBox()
        Me.CtrlOPCLabel2 = New CtrlOpcLabel()
        Me.tableFlatWork = New System.Windows.Forms.TableLayoutPanel()
        Me.CtrlOPCButton26 = New CtrlOpcButton()
        Me.CtrlOPCButton24 = New CtrlOpcButton()
        Me.CtrlOPCButton22 = New CtrlOpcButton()
        Me.CtrlOPCButton20 = New CtrlOpcButton()
        Me.CtrlOPCButton18 = New CtrlOpcButton()
        Me.CtrlOPCButton14 = New CtrlOpcButton()
        Me.CtrlOPCTextBox12 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox11 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox10 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox9 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox8 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox7 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox6 = New CtrlOpcTextBox()
        Me.CtrlOPCButton7 = New CtrlOpcButton()
        Me.CtrlOPCButton5 = New CtrlOpcButton()
        Me.CtrlOPCButton4 = New CtrlOpcButton()
        Me.CtrlOPCButton3 = New CtrlOpcButton()
        Me.CtrlOPCButton2 = New CtrlOpcButton()
        Me.CtrlOPCButton1 = New CtrlOpcButton()
        Me.CtrlOPCButton6 = New CtrlOpcButton()
        Me.CtrlOPCButton8 = New CtrlOpcButton()
        Me.CtrlOPCButton9 = New CtrlOpcButton()
        Me.CtrlOPCButton10 = New CtrlOpcButton()
        Me.CtrlOPCButton11 = New CtrlOpcButton()
        Me.CtrlOPCButton12 = New CtrlOpcButton()
        Me.CtrlOPCButton13 = New CtrlOpcButton()
        Me.CtrlOPCButton15 = New CtrlOpcButton()
        Me.CtrlOPCButton16 = New CtrlOpcButton()
        Me.CtrlOPCButton17 = New CtrlOpcButton()
        Me.CtrlOPCButton19 = New CtrlOpcButton()
        Me.CtrlOPCButton21 = New CtrlOpcButton()
        Me.CtrlOPCButton23 = New CtrlOpcButton()
        Me.CtrlOPCButton25 = New CtrlOpcButton()
        Me.CtrlOPCButton27 = New CtrlOpcButton()
        Me.CtrlOPCTextBox15 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox16 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox17 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox18 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox19 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox20 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox21 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox22 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox23 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox29 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox30 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox31 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox32 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox33 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox34 = New CtrlOpcTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tableTowelFold = New System.Windows.Forms.TableLayoutPanel()
        Me.CtrlOPCButton50 = New CtrlOpcButton()
        Me.CtrlOPCTextBox50 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox51 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox52 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox53 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox54 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox55 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox56 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox57 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox58 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox59 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox60 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox61 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox62 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox63 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox64 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox65 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox66 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox67 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox68 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox69 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox70 = New CtrlOpcTextBox()
        Me.CtrlOPCTextBox71 = New CtrlOpcTextBox()
        Me.CtrlOPCButton51 = New CtrlOpcButton()
        Me.CtrlOPCButton52 = New CtrlOpcButton()
        Me.CtrlOPCButton53 = New CtrlOpcButton()
        Me.CtrlOPCButton54 = New CtrlOpcButton()
        Me.CtrlOPCButton55 = New CtrlOpcButton()
        Me.CtrlOPCButton56 = New CtrlOpcButton()
        Me.CtrlOPCButton57 = New CtrlOpcButton()
        Me.CtrlOPCButton58 = New CtrlOpcButton()
        Me.CtrlOPCButton59 = New CtrlOpcButton()
        Me.CtrlOPCButton60 = New CtrlOpcButton()
        Me.CtrlOPCButton61 = New CtrlOpcButton()
        Me.CtrlOPCButton62 = New CtrlOpcButton()
        Me.CtrlOPCLabel50 = New CtrlOpcLabel()
        Me.CtrlOPCLabel51 = New CtrlOpcLabel()
        Me.CtrlOPCLabel52 = New CtrlOpcLabel()
        Me.CtrlOPCLabel53 = New CtrlOpcLabel()
        Me.CtrlOPCLabel54 = New CtrlOpcLabel()
        Me.CtrlOPCLabel55 = New CtrlOpcLabel()
        Me.CtrlOPCLabel56 = New CtrlOpcLabel()
        Me.CtrlOPCLabel57 = New CtrlOpcLabel()
        Me.CtrlOPCLabel58 = New CtrlOpcLabel()
        Me.CtrlOPCLabel59 = New CtrlOpcLabel()
        Me.CtrlOPCLabel60 = New CtrlOpcLabel()
        Me.CtrlOPCLabel61 = New CtrlOpcLabel()
        Me.CtrlOPCLabel62 = New CtrlOpcLabel()
        Me.CtrlOPCLabel63 = New CtrlOpcLabel()
        Me.CtrlOPCLabel64 = New CtrlOpcLabel()
        Me.CtrlOPCLabel65 = New CtrlOpcLabel()
        Me.CtrlOPCLabel66 = New CtrlOpcLabel()
        Me.CtrlOPCLabel67 = New CtrlOpcLabel()
        Me.CtrlOPCLabel68 = New CtrlOpcLabel()
        Me.CtrlOPCLabel69 = New CtrlOpcLabel()
        Me.CtrlOPCLabel70 = New CtrlOpcLabel()
        Me.CtrlOPCLabel71 = New CtrlOpcLabel()
        Me.CtrlOPCButton63 = New CtrlOpcButton()
        Me.CtrlOPCButton64 = New CtrlOpcButton()
        Me.CtrlOPCButton65 = New CtrlOpcButton()
        Me.CtrlOPCButton66 = New CtrlOpcButton()
        Me.CtrlOPCButton67 = New CtrlOpcButton()
        Me.CtrlOPCButton68 = New CtrlOpcButton()
        Me.CtrlOPCButton69 = New CtrlOpcButton()
        Me.CtrlOPCButton70 = New CtrlOpcButton()
        Me.CtrlOPCButton71 = New CtrlOpcButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableFlatWork.SuspendLayout()
        Me.tableTowelFold.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIronerCommCountReset
        '
        Me.btnIronerCommCountReset.Location = New System.Drawing.Point(593, 871)
        Me.btnIronerCommCountReset.Name = "btnIronerCommCountReset"
        Me.btnIronerCommCountReset.Size = New System.Drawing.Size(148, 56)
        Me.btnIronerCommCountReset.TabIndex = 2
        Me.btnIronerCommCountReset.Text = "Reset Ironer Comm Counts"
        Me.btnIronerCommCountReset.UseVisualStyleBackColor = True
        '
        'CtrlOPCLabel3
        '
        Me.CtrlOPCLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel3.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel3.Location = New System.Drawing.Point(8, 36)
        Me.CtrlOPCLabel3.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel3.Name = "CtrlOPCLabel3"
        Me.CtrlOPCLabel3.PlcName = Nothing
        Me.CtrlOPCLabel3.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel3.TabIndex = 4
        Me.CtrlOPCLabel3.TagName = "Ironer_RFID_Readers[2].comms_timeouts"
        Me.CtrlOPCLabel3.TextToDisplay = "Ironer 1 Lane 2 Comm Time Out: {0}"
        '
        'btnTFCommCountReset
        '
        Me.btnTFCommCountReset.Location = New System.Drawing.Point(12, 784)
        Me.btnTFCommCountReset.Name = "btnTFCommCountReset"
        Me.btnTFCommCountReset.Size = New System.Drawing.Size(148, 56)
        Me.btnTFCommCountReset.TabIndex = 5
        Me.btnTFCommCountReset.Text = "Reset TF Comm Counts"
        Me.btnTFCommCountReset.UseVisualStyleBackColor = True
        '
        'CtrlOPCLabel5
        '
        Me.CtrlOPCLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel5.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel5.Location = New System.Drawing.Point(8, 65)
        Me.CtrlOPCLabel5.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel5.Name = "CtrlOPCLabel5"
        Me.CtrlOPCLabel5.PlcName = Nothing
        Me.CtrlOPCLabel5.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel5.TabIndex = 7
        Me.CtrlOPCLabel5.TagName = "Ironer_RFID_Readers[3].comms_timeouts"
        Me.CtrlOPCLabel5.TextToDisplay = "Ironer 1 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel19
        '
        Me.CtrlOPCLabel19.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel19.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel19.Location = New System.Drawing.Point(8, 268)
        Me.CtrlOPCLabel19.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel19.Name = "CtrlOPCLabel19"
        Me.CtrlOPCLabel19.PlcName = Nothing
        Me.CtrlOPCLabel19.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel19.TabIndex = 21
        Me.CtrlOPCLabel19.TagName = "Ironer_RFID_Readers[10].comms_timeouts"
        Me.CtrlOPCLabel19.TextToDisplay = "Ironer 4 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel7
        '
        Me.CtrlOPCLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel7.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel7.Location = New System.Drawing.Point(8, 123)
        Me.CtrlOPCLabel7.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel7.Name = "CtrlOPCLabel7"
        Me.CtrlOPCLabel7.PlcName = Nothing
        Me.CtrlOPCLabel7.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel7.TabIndex = 24
        Me.CtrlOPCLabel7.TagName = "Ironer_RFID_Readers[5].comms_timeouts"
        Me.CtrlOPCLabel7.TextToDisplay = "Ironer 2 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel9
        '
        Me.CtrlOPCLabel9.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel9.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel9.Location = New System.Drawing.Point(8, 181)
        Me.CtrlOPCLabel9.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel9.Name = "CtrlOPCLabel9"
        Me.CtrlOPCLabel9.PlcName = Nothing
        Me.CtrlOPCLabel9.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel9.TabIndex = 23
        Me.CtrlOPCLabel9.TagName = "Ironer_RFID_Readers[7].comms_timeouts"
        Me.CtrlOPCLabel9.TextToDisplay = "Ironer 3 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel11
        '
        Me.CtrlOPCLabel11.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel11.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel11.Location = New System.Drawing.Point(8, 94)
        Me.CtrlOPCLabel11.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel11.Name = "CtrlOPCLabel11"
        Me.CtrlOPCLabel11.PlcName = Nothing
        Me.CtrlOPCLabel11.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel11.TabIndex = 22
        Me.CtrlOPCLabel11.TagName = "Ironer_RFID_Readers[4].comms_timeouts"
        Me.CtrlOPCLabel11.TextToDisplay = "Ironer 2 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel13
        '
        Me.CtrlOPCLabel13.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel13.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel13.Location = New System.Drawing.Point(8, 239)
        Me.CtrlOPCLabel13.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel13.Name = "CtrlOPCLabel13"
        Me.CtrlOPCLabel13.PlcName = Nothing
        Me.CtrlOPCLabel13.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel13.TabIndex = 27
        Me.CtrlOPCLabel13.TagName = "Ironer_RFID_Readers[9].comms_timeouts"
        Me.CtrlOPCLabel13.TextToDisplay = "Ironer 3 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel15
        '
        Me.CtrlOPCLabel15.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel15.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel15.Location = New System.Drawing.Point(8, 210)
        Me.CtrlOPCLabel15.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel15.Name = "CtrlOPCLabel15"
        Me.CtrlOPCLabel15.PlcName = Nothing
        Me.CtrlOPCLabel15.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel15.TabIndex = 26
        Me.CtrlOPCLabel15.TagName = "Ironer_RFID_Readers[8].comms_timeouts"
        Me.CtrlOPCLabel15.TextToDisplay = "Ironer 3 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel17
        '
        Me.CtrlOPCLabel17.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel17.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel17.Location = New System.Drawing.Point(8, 152)
        Me.CtrlOPCLabel17.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel17.Name = "CtrlOPCLabel17"
        Me.CtrlOPCLabel17.PlcName = Nothing
        Me.CtrlOPCLabel17.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel17.TabIndex = 25
        Me.CtrlOPCLabel17.TagName = "Ironer_RFID_Readers[6].comms_timeouts"
        Me.CtrlOPCLabel17.TextToDisplay = "Ironer 2 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel33
        '
        Me.CtrlOPCLabel33.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel33.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel33.Location = New System.Drawing.Point(8, 297)
        Me.CtrlOPCLabel33.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel33.Name = "CtrlOPCLabel33"
        Me.CtrlOPCLabel33.PlcName = Nothing
        Me.CtrlOPCLabel33.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel33.TabIndex = 40
        Me.CtrlOPCLabel33.TagName = "Ironer_RFID_Readers[11].comms_timeouts"
        Me.CtrlOPCLabel33.TextToDisplay = "Ironer 4 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel34
        '
        Me.CtrlOPCLabel34.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel34.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel34.Location = New System.Drawing.Point(8, 326)
        Me.CtrlOPCLabel34.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel34.Name = "CtrlOPCLabel34"
        Me.CtrlOPCLabel34.PlcName = Nothing
        Me.CtrlOPCLabel34.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel34.TabIndex = 41
        Me.CtrlOPCLabel34.TagName = "Ironer_RFID_Readers[12].comms_timeouts"
        Me.CtrlOPCLabel34.TextToDisplay = "Ironer 4 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel35
        '
        Me.CtrlOPCLabel35.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel35.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel35.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel35.Location = New System.Drawing.Point(8, 674)
        Me.CtrlOPCLabel35.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel35.Name = "CtrlOPCLabel35"
        Me.CtrlOPCLabel35.PlcName = Nothing
        Me.CtrlOPCLabel35.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel35.TabIndex = 53
        Me.CtrlOPCLabel35.TagName = "Ironer_RFID_Readers[26].comms_timeouts"
        Me.CtrlOPCLabel35.TextToDisplay = "Ironer 8 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel36
        '
        Me.CtrlOPCLabel36.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel36.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel36.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel36.Location = New System.Drawing.Point(8, 645)
        Me.CtrlOPCLabel36.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel36.Name = "CtrlOPCLabel36"
        Me.CtrlOPCLabel36.PlcName = Nothing
        Me.CtrlOPCLabel36.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel36.TabIndex = 52
        Me.CtrlOPCLabel36.TagName = "Ironer_RFID_Readers[25].comms_timeouts"
        Me.CtrlOPCLabel36.TextToDisplay = "Ironer 8 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel37
        '
        Me.CtrlOPCLabel37.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel37.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel37.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel37.Location = New System.Drawing.Point(8, 587)
        Me.CtrlOPCLabel37.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel37.Name = "CtrlOPCLabel37"
        Me.CtrlOPCLabel37.PlcName = Nothing
        Me.CtrlOPCLabel37.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel37.TabIndex = 51
        Me.CtrlOPCLabel37.TagName = "Ironer_RFID_Readers[23].comms_timeouts"
        Me.CtrlOPCLabel37.TextToDisplay = "Ironer 7 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel38
        '
        Me.CtrlOPCLabel38.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel38.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel38.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel38.Location = New System.Drawing.Point(8, 558)
        Me.CtrlOPCLabel38.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel38.Name = "CtrlOPCLabel38"
        Me.CtrlOPCLabel38.PlcName = Nothing
        Me.CtrlOPCLabel38.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel38.TabIndex = 50
        Me.CtrlOPCLabel38.TagName = "Ironer_RFID_Readers[22].comms_timeouts"
        Me.CtrlOPCLabel38.TextToDisplay = "Ironer 7 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel39
        '
        Me.CtrlOPCLabel39.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel39.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel39.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel39.Location = New System.Drawing.Point(8, 529)
        Me.CtrlOPCLabel39.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel39.Name = "CtrlOPCLabel39"
        Me.CtrlOPCLabel39.PlcName = Nothing
        Me.CtrlOPCLabel39.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel39.TabIndex = 49
        Me.CtrlOPCLabel39.TagName = "Ironer_RFID_Readers[21].comms_timeouts"
        Me.CtrlOPCLabel39.TextToDisplay = "Ironer 7 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel40
        '
        Me.CtrlOPCLabel40.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel40.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel40.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel40.Location = New System.Drawing.Point(8, 500)
        Me.CtrlOPCLabel40.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel40.Name = "CtrlOPCLabel40"
        Me.CtrlOPCLabel40.PlcName = Nothing
        Me.CtrlOPCLabel40.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel40.TabIndex = 48
        Me.CtrlOPCLabel40.TagName = "Ironer_RFID_Readers[20].comms_timeouts"
        Me.CtrlOPCLabel40.TextToDisplay = "Ironer 6 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel41
        '
        Me.CtrlOPCLabel41.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel41.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel41.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel41.Location = New System.Drawing.Point(8, 471)
        Me.CtrlOPCLabel41.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel41.Name = "CtrlOPCLabel41"
        Me.CtrlOPCLabel41.PlcName = Nothing
        Me.CtrlOPCLabel41.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel41.TabIndex = 47
        Me.CtrlOPCLabel41.TagName = "Ironer_RFID_Readers[19].comms_timeouts"
        Me.CtrlOPCLabel41.TextToDisplay = "Ironer 6 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel42
        '
        Me.CtrlOPCLabel42.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel42.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel42.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel42.Location = New System.Drawing.Point(8, 442)
        Me.CtrlOPCLabel42.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel42.Name = "CtrlOPCLabel42"
        Me.CtrlOPCLabel42.PlcName = Nothing
        Me.CtrlOPCLabel42.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel42.TabIndex = 46
        Me.CtrlOPCLabel42.TagName = "Ironer_RFID_Readers[18].comms_timeouts"
        Me.CtrlOPCLabel42.TextToDisplay = "Ironer 6 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel43
        '
        Me.CtrlOPCLabel43.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel43.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel43.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel43.Location = New System.Drawing.Point(8, 616)
        Me.CtrlOPCLabel43.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel43.Name = "CtrlOPCLabel43"
        Me.CtrlOPCLabel43.PlcName = Nothing
        Me.CtrlOPCLabel43.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel43.TabIndex = 45
        Me.CtrlOPCLabel43.TagName = "Ironer_RFID_Readers[24].comms_timeouts"
        Me.CtrlOPCLabel43.TextToDisplay = "Ironer 8 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel44
        '
        Me.CtrlOPCLabel44.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel44.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel44.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel44.Location = New System.Drawing.Point(8, 413)
        Me.CtrlOPCLabel44.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel44.Name = "CtrlOPCLabel44"
        Me.CtrlOPCLabel44.PlcName = Nothing
        Me.CtrlOPCLabel44.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel44.TabIndex = 44
        Me.CtrlOPCLabel44.TagName = "Ironer_RFID_Readers[17].comms_timeouts"
        Me.CtrlOPCLabel44.TextToDisplay = "Ironer 5 Lane 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel45
        '
        Me.CtrlOPCLabel45.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel45.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel45.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel45.Location = New System.Drawing.Point(8, 384)
        Me.CtrlOPCLabel45.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel45.Name = "CtrlOPCLabel45"
        Me.CtrlOPCLabel45.PlcName = Nothing
        Me.CtrlOPCLabel45.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel45.TabIndex = 43
        Me.CtrlOPCLabel45.TagName = "Ironer_RFID_Readers[16].comms_timeouts"
        Me.CtrlOPCLabel45.TextToDisplay = "Ironer 5 Lane 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel46
        '
        Me.CtrlOPCLabel46.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel46.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel46.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel46.Location = New System.Drawing.Point(8, 355)
        Me.CtrlOPCLabel46.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel46.Name = "CtrlOPCLabel46"
        Me.CtrlOPCLabel46.PlcName = Nothing
        Me.CtrlOPCLabel46.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel46.TabIndex = 42
        Me.CtrlOPCLabel46.TagName = "Ironer_RFID_Readers[15].comms_timeouts"
        Me.CtrlOPCLabel46.TextToDisplay = "Ironer 5 Lane 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel47
        '
        Me.CtrlOPCLabel47.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel47.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel47.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel47.Location = New System.Drawing.Point(8, 761)
        Me.CtrlOPCLabel47.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel47.Name = "CtrlOPCLabel47"
        Me.CtrlOPCLabel47.PlcName = Nothing
        Me.CtrlOPCLabel47.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel47.TabIndex = 56
        Me.CtrlOPCLabel47.TagName = "Ironer_RFID_Readers[29].comms_timeouts"
        Me.CtrlOPCLabel47.TextToDisplay = "Ironer 8 Lane 6 Comm Time Out: {0}"
        '
        'CtrlOPCLabel48
        '
        Me.CtrlOPCLabel48.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel48.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel48.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel48.Location = New System.Drawing.Point(8, 732)
        Me.CtrlOPCLabel48.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel48.Name = "CtrlOPCLabel48"
        Me.CtrlOPCLabel48.PlcName = Nothing
        Me.CtrlOPCLabel48.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel48.TabIndex = 55
        Me.CtrlOPCLabel48.TagName = "Ironer_RFID_Readers[28].comms_timeouts"
        Me.CtrlOPCLabel48.TextToDisplay = "Ironer 8 Lane 5 Comm Time Out: {0}"
        '
        'CtrlOPCLabel49
        '
        Me.CtrlOPCLabel49.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel49.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel49.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel49.Location = New System.Drawing.Point(8, 703)
        Me.CtrlOPCLabel49.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel49.Name = "CtrlOPCLabel49"
        Me.CtrlOPCLabel49.PlcName = Nothing
        Me.CtrlOPCLabel49.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel49.TabIndex = 54
        Me.CtrlOPCLabel49.TagName = "Ironer_RFID_Readers[27].comms_timeouts"
        Me.CtrlOPCLabel49.TextToDisplay = "Ironer 8 Lane 4 Comm Time Out: {0}"
        '
        'CtrlOPCTextBox2
        '
        Me.CtrlOPCTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox2.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox2.DataType = DataType.Numeric
        Me.CtrlOPCTextBox2.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox2.Location = New System.Drawing.Point(427, 36)
        Me.CtrlOPCTextBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox2.Name = "CtrlOPCTextBox2"
        Me.CtrlOPCTextBox2.PlcName = Nothing
        Me.CtrlOPCTextBox2.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox2.TabIndex = 63
        Me.CtrlOPCTextBox2.TagName = "FW_Reader_Serial_Number[2]"
        Me.CtrlOPCTextBox2.Text = "CtrlOPCTextBox2"
        '
        'CtrlOPCTextBox3
        '
        Me.CtrlOPCTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox3.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox3.DataType = DataType.Numeric
        Me.CtrlOPCTextBox3.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox3.Location = New System.Drawing.Point(427, 65)
        Me.CtrlOPCTextBox3.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox3.Name = "CtrlOPCTextBox3"
        Me.CtrlOPCTextBox3.PlcName = Nothing
        Me.CtrlOPCTextBox3.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox3.TabIndex = 64
        Me.CtrlOPCTextBox3.TagName = "FW_Reader_Serial_Number[3]"
        Me.CtrlOPCTextBox3.Text = "CtrlOPCTextBox3"
        '
        'CtrlOPCTextBox4
        '
        Me.CtrlOPCTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox4.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox4.DataType = DataType.Numeric
        Me.CtrlOPCTextBox4.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox4.Location = New System.Drawing.Point(427, 94)
        Me.CtrlOPCTextBox4.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox4.Name = "CtrlOPCTextBox4"
        Me.CtrlOPCTextBox4.PlcName = Nothing
        Me.CtrlOPCTextBox4.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox4.TabIndex = 65
        Me.CtrlOPCTextBox4.TagName = "FW_Reader_Serial_Number[4]"
        Me.CtrlOPCTextBox4.Text = "CtrlOPCTextBox4"
        '
        'CtrlOPCTextBox5
        '
        Me.CtrlOPCTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox5.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox5.DataType = DataType.Numeric
        Me.CtrlOPCTextBox5.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox5.Location = New System.Drawing.Point(427, 123)
        Me.CtrlOPCTextBox5.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox5.Name = "CtrlOPCTextBox5"
        Me.CtrlOPCTextBox5.PlcName = Nothing
        Me.CtrlOPCTextBox5.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox5.TabIndex = 66
        Me.CtrlOPCTextBox5.TagName = "FW_Reader_Serial_Number[5]"
        Me.CtrlOPCTextBox5.Text = "CtrlOPCTextBox5"
        '
        'CtrlOPCTextBox1
        '
        Me.CtrlOPCTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox1.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox1.DataType = DataType.Numeric
        Me.CtrlOPCTextBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CtrlOPCTextBox1.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox1.Location = New System.Drawing.Point(427, 7)
        Me.CtrlOPCTextBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox1.Name = "CtrlOPCTextBox1"
        Me.CtrlOPCTextBox1.PlcName = Nothing
        Me.CtrlOPCTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox1.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox1.TabIndex = 62
        Me.CtrlOPCTextBox1.TagName = "FW_Reader_Serial_Number[1]"
        Me.CtrlOPCTextBox1.Text = "CtrlOPCTextBox1"
        '
        'CtrlOPCLabel2
        '
        Me.CtrlOPCLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel2.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel2.Location = New System.Drawing.Point(8, 7)
        Me.CtrlOPCLabel2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel2.Name = "CtrlOPCLabel2"
        Me.CtrlOPCLabel2.PlcName = Nothing
        Me.CtrlOPCLabel2.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel2.TabIndex = 1
        Me.CtrlOPCLabel2.TagName = "Ironer_RFID_Readers[1].comms_timeouts"
        Me.CtrlOPCLabel2.TextToDisplay = "Ironer 1 Lane 1 Comm Time Out: {0}"
        '
        'tableFlatWork
        '
        Me.tableFlatWork.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tableFlatWork.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tableFlatWork.ColumnCount = 3
        Me.tableFlatWork.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tableFlatWork.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.tableFlatWork.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton26, 1, 19)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton24, 1, 18)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton22, 1, 17)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton20, 1, 16)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton18, 1, 15)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton14, 1, 13)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox12, 2, 11)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox11, 2, 10)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox10, 2, 9)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox9, 2, 8)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox8, 2, 7)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox7, 2, 6)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox6, 2, 5)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel39, 0, 18)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox1, 2, 0)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel36, 0, 22)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton7, 1, 5)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel42, 0, 15)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton5, 1, 4)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton4, 1, 3)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton3, 1, 2)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel38, 0, 19)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton2, 1, 1)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel2, 0, 0)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox5, 2, 4)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel47, 0, 26)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel3, 0, 1)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox3, 2, 2)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel48, 0, 25)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel5, 0, 2)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel11, 0, 3)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox4, 2, 3)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel49, 0, 24)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton1, 1, 0)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel35, 0, 23)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel37, 0, 20)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel44, 0, 14)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel7, 0, 4)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel17, 0, 5)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel9, 0, 6)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel15, 0, 7)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel40, 0, 17)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel43, 0, 21)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel13, 0, 8)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel19, 0, 9)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel41, 0, 16)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel34, 0, 11)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel33, 0, 10)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel46, 0, 12)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCLabel45, 0, 13)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton6, 1, 6)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton8, 1, 7)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton9, 1, 8)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton10, 1, 9)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton11, 1, 10)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton12, 1, 11)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton13, 1, 12)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton15, 1, 14)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton16, 1, 20)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton17, 1, 21)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton19, 1, 22)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton21, 1, 23)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton23, 1, 24)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton25, 1, 25)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCButton27, 1, 26)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox15, 2, 12)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox16, 2, 13)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox17, 2, 14)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox18, 2, 15)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox19, 2, 16)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox20, 2, 17)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox21, 2, 18)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox22, 2, 19)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox23, 2, 20)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox29, 2, 21)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox30, 2, 22)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox31, 2, 23)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox32, 2, 24)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox33, 2, 25)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox34, 2, 26)
        Me.tableFlatWork.Controls.Add(Me.CtrlOPCTextBox2, 2, 1)
        Me.tableFlatWork.ForeColor = System.Drawing.Color.Black
        Me.tableFlatWork.Location = New System.Drawing.Point(593, 71)
        Me.tableFlatWork.Name = "tableFlatWork"
        Me.tableFlatWork.RowCount = 30
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableFlatWork.Size = New System.Drawing.Size(503, 788)
        Me.tableFlatWork.TabIndex = 25
        '
        'CtrlOPCButton26
        '
        Me.CtrlOPCButton26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton26.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton26.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton26.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton26.HighStateText = "Enabled"
        Me.CtrlOPCButton26.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton26.Location = New System.Drawing.Point(260, 555)
        Me.CtrlOPCButton26.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton26.LowStateText = "Disabled"
        Me.CtrlOPCButton26.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton26.Name = "CtrlOPCButton26"
        Me.CtrlOPCButton26.PlcName = Nothing
        Me.CtrlOPCButton26.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton26.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton26.TabIndex = 102
        Me.CtrlOPCButton26.TagName = "FW_Reader_Enable[22]"
        '
        'CtrlOPCButton24
        '
        Me.CtrlOPCButton24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton24.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton24.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton24.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton24.HighStateText = "Enabled"
        Me.CtrlOPCButton24.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton24.Location = New System.Drawing.Point(260, 526)
        Me.CtrlOPCButton24.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton24.LowStateText = "Disabled"
        Me.CtrlOPCButton24.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton24.Name = "CtrlOPCButton24"
        Me.CtrlOPCButton24.PlcName = Nothing
        Me.CtrlOPCButton24.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton24.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton24.TabIndex = 100
        Me.CtrlOPCButton24.TagName = "FW_Reader_Enable[21]"
        '
        'CtrlOPCButton22
        '
        Me.CtrlOPCButton22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton22.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton22.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton22.HighStateText = "Enabled"
        Me.CtrlOPCButton22.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton22.Location = New System.Drawing.Point(260, 497)
        Me.CtrlOPCButton22.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton22.LowStateText = "Disabled"
        Me.CtrlOPCButton22.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton22.Name = "CtrlOPCButton22"
        Me.CtrlOPCButton22.PlcName = Nothing
        Me.CtrlOPCButton22.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton22.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton22.TabIndex = 98
        Me.CtrlOPCButton22.TagName = "FW_Reader_Enable[20]"
        '
        'CtrlOPCButton20
        '
        Me.CtrlOPCButton20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton20.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton20.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton20.HighStateText = "Enabled"
        Me.CtrlOPCButton20.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton20.Location = New System.Drawing.Point(260, 468)
        Me.CtrlOPCButton20.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton20.LowStateText = "Disabled"
        Me.CtrlOPCButton20.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton20.Name = "CtrlOPCButton20"
        Me.CtrlOPCButton20.PlcName = Nothing
        Me.CtrlOPCButton20.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton20.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton20.TabIndex = 96
        Me.CtrlOPCButton20.TagName = "FW_Reader_Enable[19]"
        '
        'CtrlOPCButton18
        '
        Me.CtrlOPCButton18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton18.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton18.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton18.HighStateText = "Enabled"
        Me.CtrlOPCButton18.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton18.Location = New System.Drawing.Point(260, 439)
        Me.CtrlOPCButton18.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton18.LowStateText = "Disabled"
        Me.CtrlOPCButton18.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton18.Name = "CtrlOPCButton18"
        Me.CtrlOPCButton18.PlcName = Nothing
        Me.CtrlOPCButton18.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton18.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton18.TabIndex = 94
        Me.CtrlOPCButton18.TagName = "FW_Reader_Enable[18]"
        '
        'CtrlOPCButton14
        '
        Me.CtrlOPCButton14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton14.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton14.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton14.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton14.HighStateText = "Enabled"
        Me.CtrlOPCButton14.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton14.Location = New System.Drawing.Point(260, 381)
        Me.CtrlOPCButton14.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton14.LowStateText = "Disabled"
        Me.CtrlOPCButton14.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton14.Name = "CtrlOPCButton14"
        Me.CtrlOPCButton14.PlcName = Nothing
        Me.CtrlOPCButton14.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton14.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton14.TabIndex = 90
        Me.CtrlOPCButton14.TagName = "FW_Reader_Enable[16]"
        '
        'CtrlOPCTextBox12
        '
        Me.CtrlOPCTextBox12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox12.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox12.DataType = DataType.Numeric
        Me.CtrlOPCTextBox12.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox12.Location = New System.Drawing.Point(427, 326)
        Me.CtrlOPCTextBox12.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox12.Name = "CtrlOPCTextBox12"
        Me.CtrlOPCTextBox12.PlcName = Nothing
        Me.CtrlOPCTextBox12.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox12.TabIndex = 88
        Me.CtrlOPCTextBox12.TagName = "FW_Reader_Serial_Number[12]"
        Me.CtrlOPCTextBox12.Text = "CtrlOPCTextBox12"
        '
        'CtrlOPCTextBox11
        '
        Me.CtrlOPCTextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox11.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox11.DataType = DataType.Numeric
        Me.CtrlOPCTextBox11.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox11.Location = New System.Drawing.Point(427, 297)
        Me.CtrlOPCTextBox11.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox11.Name = "CtrlOPCTextBox11"
        Me.CtrlOPCTextBox11.PlcName = Nothing
        Me.CtrlOPCTextBox11.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox11.TabIndex = 87
        Me.CtrlOPCTextBox11.TagName = "FW_Reader_Serial_Number[11]"
        Me.CtrlOPCTextBox11.Text = "CtrlOPCTextBox11"
        '
        'CtrlOPCTextBox10
        '
        Me.CtrlOPCTextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox10.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox10.DataType = DataType.Numeric
        Me.CtrlOPCTextBox10.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox10.Location = New System.Drawing.Point(427, 268)
        Me.CtrlOPCTextBox10.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox10.Name = "CtrlOPCTextBox10"
        Me.CtrlOPCTextBox10.PlcName = Nothing
        Me.CtrlOPCTextBox10.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox10.TabIndex = 86
        Me.CtrlOPCTextBox10.TagName = "FW_Reader_Serial_Number[10]"
        Me.CtrlOPCTextBox10.Text = "CtrlOPCTextBox10"
        '
        'CtrlOPCTextBox9
        '
        Me.CtrlOPCTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox9.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox9.DataType = DataType.Numeric
        Me.CtrlOPCTextBox9.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox9.Location = New System.Drawing.Point(427, 239)
        Me.CtrlOPCTextBox9.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox9.Name = "CtrlOPCTextBox9"
        Me.CtrlOPCTextBox9.PlcName = Nothing
        Me.CtrlOPCTextBox9.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox9.TabIndex = 85
        Me.CtrlOPCTextBox9.TagName = "FW_Reader_Serial_Number[9]"
        Me.CtrlOPCTextBox9.Text = "CtrlOPCTextBox9"
        '
        'CtrlOPCTextBox8
        '
        Me.CtrlOPCTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox8.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox8.DataType = DataType.Numeric
        Me.CtrlOPCTextBox8.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox8.Location = New System.Drawing.Point(427, 210)
        Me.CtrlOPCTextBox8.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox8.Name = "CtrlOPCTextBox8"
        Me.CtrlOPCTextBox8.PlcName = Nothing
        Me.CtrlOPCTextBox8.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox8.TabIndex = 84
        Me.CtrlOPCTextBox8.TagName = "FW_Reader_Serial_Number[8]"
        Me.CtrlOPCTextBox8.Text = "CtrlOPCTextBox8"
        '
        'CtrlOPCTextBox7
        '
        Me.CtrlOPCTextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox7.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox7.DataType = DataType.Numeric
        Me.CtrlOPCTextBox7.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox7.Location = New System.Drawing.Point(427, 181)
        Me.CtrlOPCTextBox7.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox7.Name = "CtrlOPCTextBox7"
        Me.CtrlOPCTextBox7.PlcName = Nothing
        Me.CtrlOPCTextBox7.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox7.TabIndex = 83
        Me.CtrlOPCTextBox7.TagName = "FW_Reader_Serial_Number[7]"
        Me.CtrlOPCTextBox7.Text = "CtrlOPCTextBox7"
        '
        'CtrlOPCTextBox6
        '
        Me.CtrlOPCTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox6.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox6.DataType = DataType.Numeric
        Me.CtrlOPCTextBox6.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox6.Location = New System.Drawing.Point(427, 152)
        Me.CtrlOPCTextBox6.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox6.Name = "CtrlOPCTextBox6"
        Me.CtrlOPCTextBox6.PlcName = Nothing
        Me.CtrlOPCTextBox6.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox6.TabIndex = 82
        Me.CtrlOPCTextBox6.TagName = "FW_Reader_Serial_Number[6]"
        Me.CtrlOPCTextBox6.Text = "CtrlOPCTextBox6"
        '
        'CtrlOPCButton7
        '
        Me.CtrlOPCButton7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton7.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton7.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton7.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton7.HighStateText = "Enabled"
        Me.CtrlOPCButton7.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton7.Location = New System.Drawing.Point(260, 149)
        Me.CtrlOPCButton7.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton7.LowStateText = "Disabled"
        Me.CtrlOPCButton7.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton7.Name = "CtrlOPCButton7"
        Me.CtrlOPCButton7.PlcName = Nothing
        Me.CtrlOPCButton7.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton7.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton7.TabIndex = 75
        Me.CtrlOPCButton7.TagName = "FW_Reader_Enable[6]"
        '
        'CtrlOPCButton5
        '
        Me.CtrlOPCButton5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton5.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton5.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton5.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton5.HighStateText = "Enabled"
        Me.CtrlOPCButton5.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton5.Location = New System.Drawing.Point(260, 120)
        Me.CtrlOPCButton5.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton5.LowStateText = "Disabled"
        Me.CtrlOPCButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton5.Name = "CtrlOPCButton5"
        Me.CtrlOPCButton5.PlcName = Nothing
        Me.CtrlOPCButton5.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton5.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton5.TabIndex = 73
        Me.CtrlOPCButton5.TagName = "FW_Reader_Enable[5]"
        '
        'CtrlOPCButton4
        '
        Me.CtrlOPCButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton4.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton4.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton4.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton4.HighStateText = "Enabled"
        Me.CtrlOPCButton4.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton4.Location = New System.Drawing.Point(260, 91)
        Me.CtrlOPCButton4.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton4.LowStateText = "Disabled"
        Me.CtrlOPCButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton4.Name = "CtrlOPCButton4"
        Me.CtrlOPCButton4.PlcName = Nothing
        Me.CtrlOPCButton4.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton4.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton4.TabIndex = 72
        Me.CtrlOPCButton4.TagName = "FW_Reader_Enable[4]"
        '
        'CtrlOPCButton3
        '
        Me.CtrlOPCButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton3.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton3.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton3.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton3.HighStateText = "Enabled"
        Me.CtrlOPCButton3.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton3.Location = New System.Drawing.Point(260, 62)
        Me.CtrlOPCButton3.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton3.LowStateText = "Disabled"
        Me.CtrlOPCButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton3.Name = "CtrlOPCButton3"
        Me.CtrlOPCButton3.PlcName = Nothing
        Me.CtrlOPCButton3.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton3.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton3.TabIndex = 71
        Me.CtrlOPCButton3.TagName = "FW_Reader_Enable[3]"
        '
        'CtrlOPCButton2
        '
        Me.CtrlOPCButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton2.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton2.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton2.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton2.HighStateText = "Enabled"
        Me.CtrlOPCButton2.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton2.Location = New System.Drawing.Point(260, 33)
        Me.CtrlOPCButton2.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton2.LowStateText = "Disabled"
        Me.CtrlOPCButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton2.Name = "CtrlOPCButton2"
        Me.CtrlOPCButton2.PlcName = Nothing
        Me.CtrlOPCButton2.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton2.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton2.TabIndex = 70
        Me.CtrlOPCButton2.TagName = "FW_Reader_Enable[2]"
        '
        'CtrlOPCButton1
        '
        Me.CtrlOPCButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton1.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton1.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton1.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton1.HighStateText = "Enabled"
        Me.CtrlOPCButton1.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton1.Location = New System.Drawing.Point(260, 4)
        Me.CtrlOPCButton1.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton1.LowStateText = "Disabled"
        Me.CtrlOPCButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton1.Name = "CtrlOPCButton1"
        Me.CtrlOPCButton1.PlcName = Nothing
        Me.CtrlOPCButton1.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton1.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton1.TabIndex = 69
        Me.CtrlOPCButton1.TagName = "FW_Reader_Enable[1]"
        '
        'CtrlOPCButton6
        '
        Me.CtrlOPCButton6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton6.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton6.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton6.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton6.HighStateText = "Enabled"
        Me.CtrlOPCButton6.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton6.Location = New System.Drawing.Point(260, 178)
        Me.CtrlOPCButton6.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton6.LowStateText = "Disabled"
        Me.CtrlOPCButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton6.Name = "CtrlOPCButton6"
        Me.CtrlOPCButton6.PlcName = Nothing
        Me.CtrlOPCButton6.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton6.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton6.TabIndex = 74
        Me.CtrlOPCButton6.TagName = "FW_Reader_Enable[7]"
        '
        'CtrlOPCButton8
        '
        Me.CtrlOPCButton8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton8.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton8.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton8.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton8.HighStateText = "Enabled"
        Me.CtrlOPCButton8.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton8.Location = New System.Drawing.Point(260, 207)
        Me.CtrlOPCButton8.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton8.LowStateText = "Disabled"
        Me.CtrlOPCButton8.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton8.Name = "CtrlOPCButton8"
        Me.CtrlOPCButton8.PlcName = Nothing
        Me.CtrlOPCButton8.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton8.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton8.TabIndex = 76
        Me.CtrlOPCButton8.TagName = "FW_Reader_Enable[8]"
        '
        'CtrlOPCButton9
        '
        Me.CtrlOPCButton9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton9.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton9.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton9.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton9.HighStateText = "Enabled"
        Me.CtrlOPCButton9.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton9.Location = New System.Drawing.Point(260, 236)
        Me.CtrlOPCButton9.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton9.LowStateText = "Disabled"
        Me.CtrlOPCButton9.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton9.Name = "CtrlOPCButton9"
        Me.CtrlOPCButton9.PlcName = Nothing
        Me.CtrlOPCButton9.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton9.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton9.TabIndex = 77
        Me.CtrlOPCButton9.TagName = "FW_Reader_Enable[9]"
        '
        'CtrlOPCButton10
        '
        Me.CtrlOPCButton10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton10.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton10.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton10.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton10.HighStateText = "Enabled"
        Me.CtrlOPCButton10.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton10.Location = New System.Drawing.Point(260, 265)
        Me.CtrlOPCButton10.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton10.LowStateText = "Disabled"
        Me.CtrlOPCButton10.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton10.Name = "CtrlOPCButton10"
        Me.CtrlOPCButton10.PlcName = Nothing
        Me.CtrlOPCButton10.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton10.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton10.TabIndex = 78
        Me.CtrlOPCButton10.TagName = "FW_Reader_Enable[10]"
        '
        'CtrlOPCButton11
        '
        Me.CtrlOPCButton11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton11.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton11.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton11.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton11.HighStateText = "Enabled"
        Me.CtrlOPCButton11.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton11.Location = New System.Drawing.Point(260, 294)
        Me.CtrlOPCButton11.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton11.LowStateText = "Disabled"
        Me.CtrlOPCButton11.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton11.Name = "CtrlOPCButton11"
        Me.CtrlOPCButton11.PlcName = Nothing
        Me.CtrlOPCButton11.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton11.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton11.TabIndex = 79
        Me.CtrlOPCButton11.TagName = "FW_Reader_Enable[11]"
        '
        'CtrlOPCButton12
        '
        Me.CtrlOPCButton12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton12.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton12.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton12.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton12.HighStateText = "Enabled"
        Me.CtrlOPCButton12.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton12.Location = New System.Drawing.Point(260, 323)
        Me.CtrlOPCButton12.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton12.LowStateText = "Disabled"
        Me.CtrlOPCButton12.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton12.Name = "CtrlOPCButton12"
        Me.CtrlOPCButton12.PlcName = Nothing
        Me.CtrlOPCButton12.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton12.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton12.TabIndex = 80
        Me.CtrlOPCButton12.TagName = "FW_Reader_Enable[12]"
        '
        'CtrlOPCButton13
        '
        Me.CtrlOPCButton13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton13.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton13.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton13.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton13.HighStateText = "Enabled"
        Me.CtrlOPCButton13.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton13.Location = New System.Drawing.Point(260, 352)
        Me.CtrlOPCButton13.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton13.LowStateText = "Disabled"
        Me.CtrlOPCButton13.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton13.Name = "CtrlOPCButton13"
        Me.CtrlOPCButton13.PlcName = Nothing
        Me.CtrlOPCButton13.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton13.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton13.TabIndex = 81
        Me.CtrlOPCButton13.TagName = "FW_Reader_Enable[15]"
        '
        'CtrlOPCButton15
        '
        Me.CtrlOPCButton15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton15.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton15.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton15.HighStateText = "Enabled"
        Me.CtrlOPCButton15.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton15.Location = New System.Drawing.Point(260, 410)
        Me.CtrlOPCButton15.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton15.LowStateText = "Disabled"
        Me.CtrlOPCButton15.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton15.Name = "CtrlOPCButton15"
        Me.CtrlOPCButton15.PlcName = Nothing
        Me.CtrlOPCButton15.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton15.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton15.TabIndex = 91
        Me.CtrlOPCButton15.TagName = "FW_Reader_Enable[17]"
        '
        'CtrlOPCButton16
        '
        Me.CtrlOPCButton16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton16.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton16.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton16.HighStateText = "Enabled"
        Me.CtrlOPCButton16.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton16.Location = New System.Drawing.Point(260, 584)
        Me.CtrlOPCButton16.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton16.LowStateText = "Disabled"
        Me.CtrlOPCButton16.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton16.Name = "CtrlOPCButton16"
        Me.CtrlOPCButton16.PlcName = Nothing
        Me.CtrlOPCButton16.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton16.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton16.TabIndex = 92
        Me.CtrlOPCButton16.TagName = "FW_Reader_Enable[23]"
        '
        'CtrlOPCButton17
        '
        Me.CtrlOPCButton17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton17.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton17.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton17.HighStateText = "Enabled"
        Me.CtrlOPCButton17.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton17.Location = New System.Drawing.Point(260, 613)
        Me.CtrlOPCButton17.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton17.LowStateText = "Disabled"
        Me.CtrlOPCButton17.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton17.Name = "CtrlOPCButton17"
        Me.CtrlOPCButton17.PlcName = Nothing
        Me.CtrlOPCButton17.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton17.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton17.TabIndex = 93
        Me.CtrlOPCButton17.TagName = "FW_Reader_Enable[24]"
        '
        'CtrlOPCButton19
        '
        Me.CtrlOPCButton19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton19.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton19.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton19.HighStateText = "Enabled"
        Me.CtrlOPCButton19.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton19.Location = New System.Drawing.Point(260, 642)
        Me.CtrlOPCButton19.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton19.LowStateText = "Disabled"
        Me.CtrlOPCButton19.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton19.Name = "CtrlOPCButton19"
        Me.CtrlOPCButton19.PlcName = Nothing
        Me.CtrlOPCButton19.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton19.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton19.TabIndex = 95
        Me.CtrlOPCButton19.TagName = "FW_Reader_Enable[25]"
        '
        'CtrlOPCButton21
        '
        Me.CtrlOPCButton21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton21.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton21.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton21.HighStateText = "Enabled"
        Me.CtrlOPCButton21.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton21.Location = New System.Drawing.Point(260, 671)
        Me.CtrlOPCButton21.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton21.LowStateText = "Disabled"
        Me.CtrlOPCButton21.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton21.Name = "CtrlOPCButton21"
        Me.CtrlOPCButton21.PlcName = Nothing
        Me.CtrlOPCButton21.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton21.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton21.TabIndex = 97
        Me.CtrlOPCButton21.TagName = "FW_Reader_Enable[26]"
        '
        'CtrlOPCButton23
        '
        Me.CtrlOPCButton23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton23.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton23.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton23.HighStateText = "Enabled"
        Me.CtrlOPCButton23.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton23.Location = New System.Drawing.Point(260, 700)
        Me.CtrlOPCButton23.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton23.LowStateText = "Disabled"
        Me.CtrlOPCButton23.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton23.Name = "CtrlOPCButton23"
        Me.CtrlOPCButton23.PlcName = Nothing
        Me.CtrlOPCButton23.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton23.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton23.TabIndex = 99
        Me.CtrlOPCButton23.TagName = "FW_Reader_Enable[27]"
        '
        'CtrlOPCButton25
        '
        Me.CtrlOPCButton25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton25.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton25.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton25.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton25.HighStateText = "Enabled"
        Me.CtrlOPCButton25.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton25.Location = New System.Drawing.Point(260, 729)
        Me.CtrlOPCButton25.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton25.LowStateText = "Disabled"
        Me.CtrlOPCButton25.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton25.Name = "CtrlOPCButton25"
        Me.CtrlOPCButton25.PlcName = Nothing
        Me.CtrlOPCButton25.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton25.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton25.TabIndex = 103
        Me.CtrlOPCButton25.TagName = "FW_Reader_Enable[28]"
        '
        'CtrlOPCButton27
        '
        Me.CtrlOPCButton27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton27.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton27.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton27.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton27.HighStateText = "Enabled"
        Me.CtrlOPCButton27.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton27.Location = New System.Drawing.Point(260, 758)
        Me.CtrlOPCButton27.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton27.LowStateText = "Disabled"
        Me.CtrlOPCButton27.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton27.Name = "CtrlOPCButton27"
        Me.CtrlOPCButton27.PlcName = Nothing
        Me.CtrlOPCButton27.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton27.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton27.TabIndex = 104
        Me.CtrlOPCButton27.TagName = "FW_Reader_Enable[29]"
        '
        'CtrlOPCTextBox15
        '
        Me.CtrlOPCTextBox15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox15.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox15.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox15.DataType = DataType.Numeric
        Me.CtrlOPCTextBox15.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox15.Location = New System.Drawing.Point(427, 355)
        Me.CtrlOPCTextBox15.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox15.Name = "CtrlOPCTextBox15"
        Me.CtrlOPCTextBox15.PlcName = Nothing
        Me.CtrlOPCTextBox15.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox15.TabIndex = 110
        Me.CtrlOPCTextBox15.TagName = "FW_Reader_Serial_Number[15]"
        Me.CtrlOPCTextBox15.Text = "CtrlOPCTextBox15"
        '
        'CtrlOPCTextBox16
        '
        Me.CtrlOPCTextBox16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox16.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox16.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox16.DataType = DataType.Numeric
        Me.CtrlOPCTextBox16.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox16.Location = New System.Drawing.Point(427, 384)
        Me.CtrlOPCTextBox16.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox16.Name = "CtrlOPCTextBox16"
        Me.CtrlOPCTextBox16.PlcName = Nothing
        Me.CtrlOPCTextBox16.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox16.TabIndex = 111
        Me.CtrlOPCTextBox16.TagName = "FW_Reader_Serial_Number[16]"
        Me.CtrlOPCTextBox16.Text = "CtrlOPCTextBox16"
        '
        'CtrlOPCTextBox17
        '
        Me.CtrlOPCTextBox17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox17.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox17.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox17.DataType = DataType.Numeric
        Me.CtrlOPCTextBox17.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox17.Location = New System.Drawing.Point(427, 413)
        Me.CtrlOPCTextBox17.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox17.Name = "CtrlOPCTextBox17"
        Me.CtrlOPCTextBox17.PlcName = Nothing
        Me.CtrlOPCTextBox17.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox17.TabIndex = 112
        Me.CtrlOPCTextBox17.TagName = "FW_Reader_Serial_Number[17]"
        Me.CtrlOPCTextBox17.Text = "CtrlOPCTextBox17"
        '
        'CtrlOPCTextBox18
        '
        Me.CtrlOPCTextBox18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox18.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox18.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox18.DataType = DataType.Numeric
        Me.CtrlOPCTextBox18.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox18.Location = New System.Drawing.Point(427, 442)
        Me.CtrlOPCTextBox18.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox18.Name = "CtrlOPCTextBox18"
        Me.CtrlOPCTextBox18.PlcName = Nothing
        Me.CtrlOPCTextBox18.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox18.TabIndex = 113
        Me.CtrlOPCTextBox18.TagName = "FW_Reader_Serial_Number[18]"
        Me.CtrlOPCTextBox18.Text = "CtrlOPCTextBox18"
        '
        'CtrlOPCTextBox19
        '
        Me.CtrlOPCTextBox19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox19.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox19.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox19.DataType = DataType.Numeric
        Me.CtrlOPCTextBox19.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox19.Location = New System.Drawing.Point(427, 471)
        Me.CtrlOPCTextBox19.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox19.Name = "CtrlOPCTextBox19"
        Me.CtrlOPCTextBox19.PlcName = Nothing
        Me.CtrlOPCTextBox19.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox19.TabIndex = 114
        Me.CtrlOPCTextBox19.TagName = "FW_Reader_Serial_Number[19]"
        Me.CtrlOPCTextBox19.Text = "CtrlOPCTextBox19"
        '
        'CtrlOPCTextBox20
        '
        Me.CtrlOPCTextBox20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox20.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox20.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox20.DataType = DataType.Numeric
        Me.CtrlOPCTextBox20.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox20.Location = New System.Drawing.Point(427, 500)
        Me.CtrlOPCTextBox20.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox20.Name = "CtrlOPCTextBox20"
        Me.CtrlOPCTextBox20.PlcName = Nothing
        Me.CtrlOPCTextBox20.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox20.TabIndex = 115
        Me.CtrlOPCTextBox20.TagName = "FW_Reader_Serial_Number[20]"
        Me.CtrlOPCTextBox20.Text = "CtrlOPCTextBox20"
        '
        'CtrlOPCTextBox21
        '
        Me.CtrlOPCTextBox21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox21.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox21.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox21.DataType = DataType.Numeric
        Me.CtrlOPCTextBox21.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox21.Location = New System.Drawing.Point(427, 529)
        Me.CtrlOPCTextBox21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox21.Name = "CtrlOPCTextBox21"
        Me.CtrlOPCTextBox21.PlcName = Nothing
        Me.CtrlOPCTextBox21.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox21.TabIndex = 116
        Me.CtrlOPCTextBox21.TagName = "FW_Reader_Serial_Number[21]"
        Me.CtrlOPCTextBox21.Text = "CtrlOPCTextBox21"
        '
        'CtrlOPCTextBox22
        '
        Me.CtrlOPCTextBox22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox22.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox22.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox22.DataType = DataType.Numeric
        Me.CtrlOPCTextBox22.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox22.Location = New System.Drawing.Point(427, 558)
        Me.CtrlOPCTextBox22.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox22.Name = "CtrlOPCTextBox22"
        Me.CtrlOPCTextBox22.PlcName = Nothing
        Me.CtrlOPCTextBox22.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox22.TabIndex = 117
        Me.CtrlOPCTextBox22.TagName = "FW_Reader_Serial_Number[22]"
        Me.CtrlOPCTextBox22.Text = "CtrlOPCTextBox22"
        '
        'CtrlOPCTextBox23
        '
        Me.CtrlOPCTextBox23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox23.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox23.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox23.DataType = DataType.Numeric
        Me.CtrlOPCTextBox23.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox23.Location = New System.Drawing.Point(427, 587)
        Me.CtrlOPCTextBox23.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox23.Name = "CtrlOPCTextBox23"
        Me.CtrlOPCTextBox23.PlcName = Nothing
        Me.CtrlOPCTextBox23.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox23.TabIndex = 118
        Me.CtrlOPCTextBox23.TagName = "FW_Reader_Serial_Number[23]"
        Me.CtrlOPCTextBox23.Text = "CtrlOPCTextBox23"
        '
        'CtrlOPCTextBox29
        '
        Me.CtrlOPCTextBox29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox29.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox29.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox29.DataType = DataType.Numeric
        Me.CtrlOPCTextBox29.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox29.Location = New System.Drawing.Point(427, 616)
        Me.CtrlOPCTextBox29.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox29.Name = "CtrlOPCTextBox29"
        Me.CtrlOPCTextBox29.PlcName = Nothing
        Me.CtrlOPCTextBox29.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox29.TabIndex = 119
        Me.CtrlOPCTextBox29.TagName = "FW_Reader_Serial_Number[24]"
        Me.CtrlOPCTextBox29.Text = "CtrlOPCTextBox29"
        '
        'CtrlOPCTextBox30
        '
        Me.CtrlOPCTextBox30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox30.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox30.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox30.DataType = DataType.Numeric
        Me.CtrlOPCTextBox30.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox30.Location = New System.Drawing.Point(427, 645)
        Me.CtrlOPCTextBox30.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox30.Name = "CtrlOPCTextBox30"
        Me.CtrlOPCTextBox30.PlcName = Nothing
        Me.CtrlOPCTextBox30.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox30.TabIndex = 124
        Me.CtrlOPCTextBox30.TagName = "FW_Reader_Serial_Number[25]"
        Me.CtrlOPCTextBox30.Text = "CtrlOPCTextBox30"
        '
        'CtrlOPCTextBox31
        '
        Me.CtrlOPCTextBox31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox31.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox31.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox31.DataType = DataType.Numeric
        Me.CtrlOPCTextBox31.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox31.Location = New System.Drawing.Point(427, 674)
        Me.CtrlOPCTextBox31.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox31.Name = "CtrlOPCTextBox31"
        Me.CtrlOPCTextBox31.PlcName = Nothing
        Me.CtrlOPCTextBox31.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox31.TabIndex = 125
        Me.CtrlOPCTextBox31.TagName = "FW_Reader_Serial_Number[26]"
        Me.CtrlOPCTextBox31.Text = "CtrlOPCTextBox31"
        '
        'CtrlOPCTextBox32
        '
        Me.CtrlOPCTextBox32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox32.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox32.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox32.DataType = DataType.Numeric
        Me.CtrlOPCTextBox32.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox32.Location = New System.Drawing.Point(427, 703)
        Me.CtrlOPCTextBox32.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox32.Name = "CtrlOPCTextBox32"
        Me.CtrlOPCTextBox32.PlcName = Nothing
        Me.CtrlOPCTextBox32.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox32.TabIndex = 126
        Me.CtrlOPCTextBox32.TagName = "FW_Reader_Serial_Number[27]"
        Me.CtrlOPCTextBox32.Text = "CtrlOPCTextBox32"
        '
        'CtrlOPCTextBox33
        '
        Me.CtrlOPCTextBox33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox33.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox33.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox33.DataType = DataType.Numeric
        Me.CtrlOPCTextBox33.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox33.Location = New System.Drawing.Point(427, 732)
        Me.CtrlOPCTextBox33.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox33.Name = "CtrlOPCTextBox33"
        Me.CtrlOPCTextBox33.PlcName = Nothing
        Me.CtrlOPCTextBox33.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox33.TabIndex = 127
        Me.CtrlOPCTextBox33.TagName = "FW_Reader_Serial_Number[28]"
        Me.CtrlOPCTextBox33.Text = "CtrlOPCTextBox33"
        '
        'CtrlOPCTextBox34
        '
        Me.CtrlOPCTextBox34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox34.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox34.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox34.DataType = DataType.Numeric
        Me.CtrlOPCTextBox34.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox34.Location = New System.Drawing.Point(427, 761)
        Me.CtrlOPCTextBox34.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox34.Name = "CtrlOPCTextBox34"
        Me.CtrlOPCTextBox34.PlcName = Nothing
        Me.CtrlOPCTextBox34.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox34.TabIndex = 128
        Me.CtrlOPCTextBox34.TagName = "FW_Reader_Serial_Number[29]"
        Me.CtrlOPCTextBox34.Text = "CtrlOPCTextBox34"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(602, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 25)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Flat Work/Ironers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1005, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Reader"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(979, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Serial Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(852, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Enable/Disable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(881, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Reader"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Towel Folders"
        '
        'tableTowelFold
        '
        Me.tableTowelFold.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tableTowelFold.ColumnCount = 3
        Me.tableTowelFold.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tableTowelFold.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.tableTowelFold.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox50, 2, 0)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox52, 2, 20)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox53, 2, 19)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox54, 2, 18)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox55, 2, 17)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox56, 2, 16)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox57, 2, 15)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox58, 2, 14)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox59, 2, 13)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox60, 2, 12)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox61, 2, 11)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox62, 2, 10)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox63, 2, 9)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox64, 2, 8)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox65, 2, 7)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox66, 2, 6)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox67, 2, 5)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox68, 2, 4)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox69, 2, 3)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox70, 2, 2)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox71, 2, 1)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton51, 1, 11)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton52, 1, 10)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton53, 1, 9)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton54, 1, 8)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton55, 1, 7)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton56, 1, 6)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton57, 1, 5)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton58, 1, 4)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton59, 1, 3)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton60, 1, 2)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton61, 1, 1)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton62, 1, 0)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel50, 0, 0)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel51, 0, 1)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel52, 0, 2)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel53, 0, 3)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel54, 0, 4)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel55, 0, 5)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel56, 0, 6)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel57, 0, 7)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel58, 0, 8)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel59, 0, 9)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel60, 0, 10)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel61, 0, 11)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel62, 0, 21)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel63, 0, 20)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel64, 0, 18)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel65, 0, 15)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel66, 0, 19)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel67, 0, 12)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel68, 0, 17)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel69, 0, 16)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel70, 0, 13)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCLabel71, 0, 14)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton63, 1, 12)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton64, 1, 13)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton65, 1, 14)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton66, 1, 15)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton67, 1, 16)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton68, 1, 17)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton69, 1, 18)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton70, 1, 19)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton71, 1, 20)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCTextBox51, 2, 21)
        Me.tableTowelFold.Controls.Add(Me.CtrlOPCButton50, 1, 21)
        Me.tableTowelFold.Location = New System.Drawing.Point(12, 71)
        Me.tableTowelFold.Name = "tableTowelFold"
        Me.tableTowelFold.RowCount = 22
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableTowelFold.Size = New System.Drawing.Size(493, 641)
        Me.tableTowelFold.TabIndex = 82
        '
        'CtrlOPCButton50
        '
        Me.CtrlOPCButton50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton50.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton50.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton50.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton50.HighStateText = "Enabled"
        Me.CtrlOPCButton50.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton50.Location = New System.Drawing.Point(260, 614)
        Me.CtrlOPCButton50.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton50.LowStateText = "Disabled"
        Me.CtrlOPCButton50.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton50.Name = "CtrlOPCButton50"
        Me.CtrlOPCButton50.PlcName = Nothing
        Me.CtrlOPCButton50.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton50.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton50.TabIndex = 173
        Me.CtrlOPCButton50.TagName = "TF_Reader_Enable[22]"
        '
        'CtrlOPCTextBox50
        '
        Me.CtrlOPCTextBox50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox50.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox50.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox50.DataType = DataType.Numeric
        Me.CtrlOPCTextBox50.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox50.Location = New System.Drawing.Point(425, 8)
        Me.CtrlOPCTextBox50.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox50.Name = "CtrlOPCTextBox50"
        Me.CtrlOPCTextBox50.PlcName = Nothing
        Me.CtrlOPCTextBox50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox50.Size = New System.Drawing.Size(65, 14)
        Me.CtrlOPCTextBox50.TabIndex = 172
        Me.CtrlOPCTextBox50.TagName = "TF_Reader_Serial_Number[1]"
        Me.CtrlOPCTextBox50.Text = "CtrlOPCTextBox50"
        '
        'CtrlOPCTextBox51
        '
        Me.CtrlOPCTextBox51.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox51.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox51.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox51.DataType = DataType.Numeric
        Me.CtrlOPCTextBox51.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox51.Location = New System.Drawing.Point(425, 617)
        Me.CtrlOPCTextBox51.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox51.Name = "CtrlOPCTextBox51"
        Me.CtrlOPCTextBox51.PlcName = Nothing
        Me.CtrlOPCTextBox51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox51.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox51.TabIndex = 171
        Me.CtrlOPCTextBox51.TagName = "TF_Reader_Serial_Number[22]"
        Me.CtrlOPCTextBox51.Text = "CtrlOPCTextBox51"
        '
        'CtrlOPCTextBox52
        '
        Me.CtrlOPCTextBox52.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox52.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox52.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox52.DataType = DataType.Numeric
        Me.CtrlOPCTextBox52.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox52.Location = New System.Drawing.Point(425, 587)
        Me.CtrlOPCTextBox52.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox52.Name = "CtrlOPCTextBox52"
        Me.CtrlOPCTextBox52.PlcName = Nothing
        Me.CtrlOPCTextBox52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox52.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox52.TabIndex = 170
        Me.CtrlOPCTextBox52.TagName = "TF_Reader_Serial_Number[21]"
        Me.CtrlOPCTextBox52.Text = "CtrlOPCTextBox52"
        '
        'CtrlOPCTextBox53
        '
        Me.CtrlOPCTextBox53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox53.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox53.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox53.DataType = DataType.Numeric
        Me.CtrlOPCTextBox53.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox53.Location = New System.Drawing.Point(425, 558)
        Me.CtrlOPCTextBox53.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox53.Name = "CtrlOPCTextBox53"
        Me.CtrlOPCTextBox53.PlcName = Nothing
        Me.CtrlOPCTextBox53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox53.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox53.TabIndex = 169
        Me.CtrlOPCTextBox53.TagName = "TF_Reader_Serial_Number[20]"
        Me.CtrlOPCTextBox53.Text = "CtrlOPCTextBox53"
        '
        'CtrlOPCTextBox54
        '
        Me.CtrlOPCTextBox54.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox54.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox54.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox54.DataType = DataType.Numeric
        Me.CtrlOPCTextBox54.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox54.Location = New System.Drawing.Point(425, 529)
        Me.CtrlOPCTextBox54.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox54.Name = "CtrlOPCTextBox54"
        Me.CtrlOPCTextBox54.PlcName = Nothing
        Me.CtrlOPCTextBox54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox54.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox54.TabIndex = 168
        Me.CtrlOPCTextBox54.TagName = "TF_Reader_Serial_Number[19]"
        Me.CtrlOPCTextBox54.Text = "CtrlOPCTextBox54"
        '
        'CtrlOPCTextBox55
        '
        Me.CtrlOPCTextBox55.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox55.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox55.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox55.DataType = DataType.Numeric
        Me.CtrlOPCTextBox55.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox55.Location = New System.Drawing.Point(425, 500)
        Me.CtrlOPCTextBox55.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox55.Name = "CtrlOPCTextBox55"
        Me.CtrlOPCTextBox55.PlcName = Nothing
        Me.CtrlOPCTextBox55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox55.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox55.TabIndex = 167
        Me.CtrlOPCTextBox55.TagName = "TF_Reader_Serial_Number[18]"
        Me.CtrlOPCTextBox55.Text = "CtrlOPCTextBox55"
        '
        'CtrlOPCTextBox56
        '
        Me.CtrlOPCTextBox56.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox56.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox56.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox56.DataType = DataType.Numeric
        Me.CtrlOPCTextBox56.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox56.Location = New System.Drawing.Point(425, 471)
        Me.CtrlOPCTextBox56.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox56.Name = "CtrlOPCTextBox56"
        Me.CtrlOPCTextBox56.PlcName = Nothing
        Me.CtrlOPCTextBox56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox56.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox56.TabIndex = 166
        Me.CtrlOPCTextBox56.TagName = "TF_Reader_Serial_Number[17]"
        Me.CtrlOPCTextBox56.Text = "CtrlOPCTextBox56"
        '
        'CtrlOPCTextBox57
        '
        Me.CtrlOPCTextBox57.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox57.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox57.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox57.DataType = DataType.Numeric
        Me.CtrlOPCTextBox57.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox57.Location = New System.Drawing.Point(425, 442)
        Me.CtrlOPCTextBox57.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox57.Name = "CtrlOPCTextBox57"
        Me.CtrlOPCTextBox57.PlcName = Nothing
        Me.CtrlOPCTextBox57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox57.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox57.TabIndex = 165
        Me.CtrlOPCTextBox57.TagName = "TF_Reader_Serial_Number[16]"
        Me.CtrlOPCTextBox57.Text = "CtrlOPCTextBox57"
        '
        'CtrlOPCTextBox58
        '
        Me.CtrlOPCTextBox58.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox58.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox58.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox58.DataType = DataType.Numeric
        Me.CtrlOPCTextBox58.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox58.Location = New System.Drawing.Point(425, 413)
        Me.CtrlOPCTextBox58.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox58.Name = "CtrlOPCTextBox58"
        Me.CtrlOPCTextBox58.PlcName = Nothing
        Me.CtrlOPCTextBox58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox58.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox58.TabIndex = 164
        Me.CtrlOPCTextBox58.TagName = "TF_Reader_Serial_Number[15]"
        Me.CtrlOPCTextBox58.Text = "CtrlOPCTextBox58"
        '
        'CtrlOPCTextBox59
        '
        Me.CtrlOPCTextBox59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox59.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox59.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox59.DataType = DataType.Numeric
        Me.CtrlOPCTextBox59.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox59.Location = New System.Drawing.Point(425, 384)
        Me.CtrlOPCTextBox59.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox59.Name = "CtrlOPCTextBox59"
        Me.CtrlOPCTextBox59.PlcName = Nothing
        Me.CtrlOPCTextBox59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox59.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox59.TabIndex = 163
        Me.CtrlOPCTextBox59.TagName = "TF_Reader_Serial_Number[14]"
        Me.CtrlOPCTextBox59.Text = "CtrlOPCTextBox59"
        '
        'CtrlOPCTextBox60
        '
        Me.CtrlOPCTextBox60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox60.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox60.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox60.DataType = DataType.Numeric
        Me.CtrlOPCTextBox60.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox60.Location = New System.Drawing.Point(425, 355)
        Me.CtrlOPCTextBox60.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox60.Name = "CtrlOPCTextBox60"
        Me.CtrlOPCTextBox60.PlcName = Nothing
        Me.CtrlOPCTextBox60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox60.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox60.TabIndex = 162
        Me.CtrlOPCTextBox60.TagName = "TF_Reader_Serial_Number[13]"
        Me.CtrlOPCTextBox60.Text = "CtrlOPCTextBox60"
        '
        'CtrlOPCTextBox61
        '
        Me.CtrlOPCTextBox61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox61.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox61.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox61.DataType = DataType.Numeric
        Me.CtrlOPCTextBox61.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox61.Location = New System.Drawing.Point(425, 326)
        Me.CtrlOPCTextBox61.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox61.Name = "CtrlOPCTextBox61"
        Me.CtrlOPCTextBox61.PlcName = Nothing
        Me.CtrlOPCTextBox61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox61.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox61.TabIndex = 161
        Me.CtrlOPCTextBox61.TagName = "TF_Reader_Serial_Number[12]"
        Me.CtrlOPCTextBox61.Text = "CtrlOPCTextBox61"
        '
        'CtrlOPCTextBox62
        '
        Me.CtrlOPCTextBox62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox62.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox62.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox62.DataType = DataType.Numeric
        Me.CtrlOPCTextBox62.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox62.Location = New System.Drawing.Point(425, 297)
        Me.CtrlOPCTextBox62.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox62.Name = "CtrlOPCTextBox62"
        Me.CtrlOPCTextBox62.PlcName = Nothing
        Me.CtrlOPCTextBox62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox62.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox62.TabIndex = 160
        Me.CtrlOPCTextBox62.TagName = "TF_Reader_Serial_Number[11]"
        Me.CtrlOPCTextBox62.Text = "CtrlOPCTextBox62"
        '
        'CtrlOPCTextBox63
        '
        Me.CtrlOPCTextBox63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox63.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox63.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox63.DataType = DataType.Numeric
        Me.CtrlOPCTextBox63.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox63.Location = New System.Drawing.Point(425, 268)
        Me.CtrlOPCTextBox63.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox63.Name = "CtrlOPCTextBox63"
        Me.CtrlOPCTextBox63.PlcName = Nothing
        Me.CtrlOPCTextBox63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox63.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox63.TabIndex = 159
        Me.CtrlOPCTextBox63.TagName = "TF_Reader_Serial_Number[10]"
        Me.CtrlOPCTextBox63.Text = "CtrlOPCTextBox63"
        '
        'CtrlOPCTextBox64
        '
        Me.CtrlOPCTextBox64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox64.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox64.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox64.DataType = DataType.Numeric
        Me.CtrlOPCTextBox64.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox64.Location = New System.Drawing.Point(425, 239)
        Me.CtrlOPCTextBox64.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox64.Name = "CtrlOPCTextBox64"
        Me.CtrlOPCTextBox64.PlcName = Nothing
        Me.CtrlOPCTextBox64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox64.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox64.TabIndex = 158
        Me.CtrlOPCTextBox64.TagName = "TF_Reader_Serial_Number[9]"
        Me.CtrlOPCTextBox64.Text = "CtrlOPCTextBox64"
        '
        'CtrlOPCTextBox65
        '
        Me.CtrlOPCTextBox65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox65.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox65.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox65.DataType = DataType.Numeric
        Me.CtrlOPCTextBox65.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox65.Location = New System.Drawing.Point(425, 210)
        Me.CtrlOPCTextBox65.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox65.Name = "CtrlOPCTextBox65"
        Me.CtrlOPCTextBox65.PlcName = Nothing
        Me.CtrlOPCTextBox65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox65.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox65.TabIndex = 157
        Me.CtrlOPCTextBox65.TagName = "TF_Reader_Serial_Number[8]"
        Me.CtrlOPCTextBox65.Text = "CtrlOPCTextBox65"
        '
        'CtrlOPCTextBox66
        '
        Me.CtrlOPCTextBox66.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox66.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox66.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox66.DataType = DataType.Numeric
        Me.CtrlOPCTextBox66.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox66.Location = New System.Drawing.Point(425, 181)
        Me.CtrlOPCTextBox66.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox66.Name = "CtrlOPCTextBox66"
        Me.CtrlOPCTextBox66.PlcName = Nothing
        Me.CtrlOPCTextBox66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox66.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox66.TabIndex = 156
        Me.CtrlOPCTextBox66.TagName = "TF_Reader_Serial_Number[7]"
        Me.CtrlOPCTextBox66.Text = "CtrlOPCTextBox66"
        '
        'CtrlOPCTextBox67
        '
        Me.CtrlOPCTextBox67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox67.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox67.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox67.DataType = DataType.Numeric
        Me.CtrlOPCTextBox67.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox67.Location = New System.Drawing.Point(425, 152)
        Me.CtrlOPCTextBox67.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox67.Name = "CtrlOPCTextBox67"
        Me.CtrlOPCTextBox67.PlcName = Nothing
        Me.CtrlOPCTextBox67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox67.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox67.TabIndex = 155
        Me.CtrlOPCTextBox67.TagName = "TF_Reader_Serial_Number[6]"
        Me.CtrlOPCTextBox67.Text = "CtrlOPCTextBox67"
        '
        'CtrlOPCTextBox68
        '
        Me.CtrlOPCTextBox68.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox68.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox68.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox68.DataType = DataType.Numeric
        Me.CtrlOPCTextBox68.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox68.Location = New System.Drawing.Point(425, 123)
        Me.CtrlOPCTextBox68.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox68.Name = "CtrlOPCTextBox68"
        Me.CtrlOPCTextBox68.PlcName = Nothing
        Me.CtrlOPCTextBox68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox68.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox68.TabIndex = 154
        Me.CtrlOPCTextBox68.TagName = "TF_Reader_Serial_Number[5]"
        Me.CtrlOPCTextBox68.Text = "CtrlOPCTextBox68"
        '
        'CtrlOPCTextBox69
        '
        Me.CtrlOPCTextBox69.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox69.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox69.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox69.DataType = DataType.Numeric
        Me.CtrlOPCTextBox69.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox69.Location = New System.Drawing.Point(425, 94)
        Me.CtrlOPCTextBox69.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox69.Name = "CtrlOPCTextBox69"
        Me.CtrlOPCTextBox69.PlcName = Nothing
        Me.CtrlOPCTextBox69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox69.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox69.TabIndex = 153
        Me.CtrlOPCTextBox69.TagName = "TF_Reader_Serial_Number[4]"
        Me.CtrlOPCTextBox69.Text = "CtrlOPCTextBox69"
        '
        'CtrlOPCTextBox70
        '
        Me.CtrlOPCTextBox70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox70.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox70.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox70.DataType = DataType.Numeric
        Me.CtrlOPCTextBox70.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox70.Location = New System.Drawing.Point(425, 66)
        Me.CtrlOPCTextBox70.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox70.Name = "CtrlOPCTextBox70"
        Me.CtrlOPCTextBox70.PlcName = Nothing
        Me.CtrlOPCTextBox70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox70.Size = New System.Drawing.Size(65, 14)
        Me.CtrlOPCTextBox70.TabIndex = 152
        Me.CtrlOPCTextBox70.TagName = "TF_Reader_Serial_Number[3]"
        Me.CtrlOPCTextBox70.Text = "CtrlOPCTextBox70"
        '
        'CtrlOPCTextBox71
        '
        Me.CtrlOPCTextBox71.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCTextBox71.BackColor = System.Drawing.Color.White
        Me.CtrlOPCTextBox71.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCTextBox71.DataType = DataType.Numeric
        Me.CtrlOPCTextBox71.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCTextBox71.Location = New System.Drawing.Point(425, 36)
        Me.CtrlOPCTextBox71.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCTextBox71.Name = "CtrlOPCTextBox71"
        Me.CtrlOPCTextBox71.PlcName = Nothing
        Me.CtrlOPCTextBox71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CtrlOPCTextBox71.Size = New System.Drawing.Size(65, 16)
        Me.CtrlOPCTextBox71.TabIndex = 151
        Me.CtrlOPCTextBox71.TagName = "TF_Reader_Serial_Number[2]"
        Me.CtrlOPCTextBox71.Text = "CtrlOPCTextBox71"
        '
        'CtrlOPCButton51
        '
        Me.CtrlOPCButton51.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton51.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton51.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton51.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton51.HighStateText = "Enabled"
        Me.CtrlOPCButton51.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton51.Location = New System.Drawing.Point(260, 323)
        Me.CtrlOPCButton51.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton51.LowStateText = "Disabled"
        Me.CtrlOPCButton51.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton51.Name = "CtrlOPCButton51"
        Me.CtrlOPCButton51.PlcName = Nothing
        Me.CtrlOPCButton51.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton51.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton51.TabIndex = 150
        Me.CtrlOPCButton51.TagName = "TF_Reader_Enable[12]"
        '
        'CtrlOPCButton52
        '
        Me.CtrlOPCButton52.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton52.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton52.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton52.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton52.HighStateText = "Enabled"
        Me.CtrlOPCButton52.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton52.Location = New System.Drawing.Point(260, 294)
        Me.CtrlOPCButton52.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton52.LowStateText = "Disabled"
        Me.CtrlOPCButton52.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton52.Name = "CtrlOPCButton52"
        Me.CtrlOPCButton52.PlcName = Nothing
        Me.CtrlOPCButton52.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton52.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton52.TabIndex = 148
        Me.CtrlOPCButton52.TagName = "TF_Reader_Enable[11]"
        '
        'CtrlOPCButton53
        '
        Me.CtrlOPCButton53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton53.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton53.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton53.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton53.HighStateText = "Enabled"
        Me.CtrlOPCButton53.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton53.Location = New System.Drawing.Point(260, 265)
        Me.CtrlOPCButton53.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton53.LowStateText = "Disabled"
        Me.CtrlOPCButton53.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton53.Name = "CtrlOPCButton53"
        Me.CtrlOPCButton53.PlcName = Nothing
        Me.CtrlOPCButton53.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton53.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton53.TabIndex = 146
        Me.CtrlOPCButton53.TagName = "TF_Reader_Enable[10]"
        '
        'CtrlOPCButton54
        '
        Me.CtrlOPCButton54.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton54.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton54.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton54.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton54.HighStateText = "Enabled"
        Me.CtrlOPCButton54.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton54.Location = New System.Drawing.Point(260, 236)
        Me.CtrlOPCButton54.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton54.LowStateText = "Disabled"
        Me.CtrlOPCButton54.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton54.Name = "CtrlOPCButton54"
        Me.CtrlOPCButton54.PlcName = Nothing
        Me.CtrlOPCButton54.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton54.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton54.TabIndex = 144
        Me.CtrlOPCButton54.TagName = "TF_Reader_Enable[9]"
        '
        'CtrlOPCButton55
        '
        Me.CtrlOPCButton55.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton55.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton55.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton55.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton55.HighStateText = "Enabled"
        Me.CtrlOPCButton55.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton55.Location = New System.Drawing.Point(260, 207)
        Me.CtrlOPCButton55.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton55.LowStateText = "Disabled"
        Me.CtrlOPCButton55.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton55.Name = "CtrlOPCButton55"
        Me.CtrlOPCButton55.PlcName = Nothing
        Me.CtrlOPCButton55.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton55.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton55.TabIndex = 142
        Me.CtrlOPCButton55.TagName = "TF_Reader_Enable[8]"
        '
        'CtrlOPCButton56
        '
        Me.CtrlOPCButton56.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton56.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton56.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton56.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton56.HighStateText = "Enabled"
        Me.CtrlOPCButton56.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton56.Location = New System.Drawing.Point(260, 178)
        Me.CtrlOPCButton56.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton56.LowStateText = "Disabled"
        Me.CtrlOPCButton56.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton56.Name = "CtrlOPCButton56"
        Me.CtrlOPCButton56.PlcName = Nothing
        Me.CtrlOPCButton56.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton56.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton56.TabIndex = 140
        Me.CtrlOPCButton56.TagName = "TF_Reader_Enable[7]"
        '
        'CtrlOPCButton57
        '
        Me.CtrlOPCButton57.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton57.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton57.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton57.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton57.HighStateText = "Enabled"
        Me.CtrlOPCButton57.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton57.Location = New System.Drawing.Point(260, 149)
        Me.CtrlOPCButton57.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton57.LowStateText = "Disabled"
        Me.CtrlOPCButton57.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton57.Name = "CtrlOPCButton57"
        Me.CtrlOPCButton57.PlcName = Nothing
        Me.CtrlOPCButton57.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton57.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton57.TabIndex = 138
        Me.CtrlOPCButton57.TagName = "TF_Reader_Enable[6]"
        '
        'CtrlOPCButton58
        '
        Me.CtrlOPCButton58.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton58.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton58.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton58.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton58.HighStateText = "Enabled"
        Me.CtrlOPCButton58.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton58.Location = New System.Drawing.Point(260, 120)
        Me.CtrlOPCButton58.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton58.LowStateText = "Disabled"
        Me.CtrlOPCButton58.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton58.Name = "CtrlOPCButton58"
        Me.CtrlOPCButton58.PlcName = Nothing
        Me.CtrlOPCButton58.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton58.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton58.TabIndex = 136
        Me.CtrlOPCButton58.TagName = "TF_Reader_Enable[5]"
        '
        'CtrlOPCButton59
        '
        Me.CtrlOPCButton59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton59.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton59.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton59.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton59.HighStateText = "Enabled"
        Me.CtrlOPCButton59.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton59.Location = New System.Drawing.Point(260, 91)
        Me.CtrlOPCButton59.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton59.LowStateText = "Disabled"
        Me.CtrlOPCButton59.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton59.Name = "CtrlOPCButton59"
        Me.CtrlOPCButton59.PlcName = Nothing
        Me.CtrlOPCButton59.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton59.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton59.TabIndex = 134
        Me.CtrlOPCButton59.TagName = "TF_Reader_Enable[4]"
        '
        'CtrlOPCButton60
        '
        Me.CtrlOPCButton60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton60.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton60.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton60.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton60.HighStateText = "Enabled"
        Me.CtrlOPCButton60.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton60.Location = New System.Drawing.Point(260, 62)
        Me.CtrlOPCButton60.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton60.LowStateText = "Disabled"
        Me.CtrlOPCButton60.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton60.Name = "CtrlOPCButton60"
        Me.CtrlOPCButton60.PlcName = Nothing
        Me.CtrlOPCButton60.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton60.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton60.TabIndex = 132
        Me.CtrlOPCButton60.TagName = "TF_Reader_Enable[3]"
        '
        'CtrlOPCButton61
        '
        Me.CtrlOPCButton61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton61.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton61.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton61.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton61.HighStateText = "Enabled"
        Me.CtrlOPCButton61.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton61.Location = New System.Drawing.Point(260, 33)
        Me.CtrlOPCButton61.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton61.LowStateText = "Disabled"
        Me.CtrlOPCButton61.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton61.Name = "CtrlOPCButton61"
        Me.CtrlOPCButton61.PlcName = Nothing
        Me.CtrlOPCButton61.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton61.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton61.TabIndex = 130
        Me.CtrlOPCButton61.TagName = "TF_Reader_Enable[2]"
        '
        'CtrlOPCButton62
        '
        Me.CtrlOPCButton62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton62.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton62.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton62.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton62.HighStateText = "Enabled"
        Me.CtrlOPCButton62.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton62.Location = New System.Drawing.Point(260, 4)
        Me.CtrlOPCButton62.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton62.LowStateText = "Disabled"
        Me.CtrlOPCButton62.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton62.Name = "CtrlOPCButton62"
        Me.CtrlOPCButton62.PlcName = Nothing
        Me.CtrlOPCButton62.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton62.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton62.TabIndex = 129
        Me.CtrlOPCButton62.TagName = "TF_Reader_Enable[1]"
        '
        'CtrlOPCLabel50
        '
        Me.CtrlOPCLabel50.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel50.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel50.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel50.Location = New System.Drawing.Point(8, 7)
        Me.CtrlOPCLabel50.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel50.Name = "CtrlOPCLabel50"
        Me.CtrlOPCLabel50.PlcName = "TSAProductivityPLC"
        Me.CtrlOPCLabel50.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel50.TabIndex = 0
        Me.CtrlOPCLabel50.TagName = "TF_RFID_Readers[1].comms_timeouts"
        Me.CtrlOPCLabel50.TextToDisplay = "Towefold 1 Comm Time Out: {0}"
        '
        'CtrlOPCLabel51
        '
        Me.CtrlOPCLabel51.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel51.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel51.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel51.Location = New System.Drawing.Point(8, 36)
        Me.CtrlOPCLabel51.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel51.Name = "CtrlOPCLabel51"
        Me.CtrlOPCLabel51.PlcName = Nothing
        Me.CtrlOPCLabel51.Size = New System.Drawing.Size(236, 12)
        Me.CtrlOPCLabel51.TabIndex = 3
        Me.CtrlOPCLabel51.TagName = "TF_RFID_Readers[2].comms_timeouts"
        Me.CtrlOPCLabel51.TextToDisplay = "Towefold 2 Comm Time Out: {0}"
        '
        'CtrlOPCLabel52
        '
        Me.CtrlOPCLabel52.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel52.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel52.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel52.Location = New System.Drawing.Point(8, 65)
        Me.CtrlOPCLabel52.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel52.Name = "CtrlOPCLabel52"
        Me.CtrlOPCLabel52.PlcName = Nothing
        Me.CtrlOPCLabel52.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel52.TabIndex = 6
        Me.CtrlOPCLabel52.TagName = "TF_RFID_Readers[3].comms_timeouts"
        Me.CtrlOPCLabel52.TextToDisplay = "Towefold 3 Comm Time Out: {0}"
        '
        'CtrlOPCLabel53
        '
        Me.CtrlOPCLabel53.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel53.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel53.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel53.Location = New System.Drawing.Point(8, 94)
        Me.CtrlOPCLabel53.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel53.Name = "CtrlOPCLabel53"
        Me.CtrlOPCLabel53.PlcName = Nothing
        Me.CtrlOPCLabel53.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel53.TabIndex = 8
        Me.CtrlOPCLabel53.TagName = "TF_RFID_Readers[4].comms_timeouts"
        Me.CtrlOPCLabel53.TextToDisplay = "Towefold 4 Comm Time Out: {0}"
        '
        'CtrlOPCLabel54
        '
        Me.CtrlOPCLabel54.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel54.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel54.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel54.Location = New System.Drawing.Point(8, 123)
        Me.CtrlOPCLabel54.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel54.Name = "CtrlOPCLabel54"
        Me.CtrlOPCLabel54.PlcName = Nothing
        Me.CtrlOPCLabel54.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel54.TabIndex = 10
        Me.CtrlOPCLabel54.TagName = "TF_RFID_Readers[5].comms_timeouts"
        Me.CtrlOPCLabel54.TextToDisplay = "Towefold 5 Comm Time Out: {0}"
        '
        'CtrlOPCLabel55
        '
        Me.CtrlOPCLabel55.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel55.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel55.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel55.Location = New System.Drawing.Point(8, 152)
        Me.CtrlOPCLabel55.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel55.Name = "CtrlOPCLabel55"
        Me.CtrlOPCLabel55.PlcName = Nothing
        Me.CtrlOPCLabel55.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel55.TabIndex = 12
        Me.CtrlOPCLabel55.TagName = "TF_RFID_Readers[6].comms_timeouts"
        Me.CtrlOPCLabel55.TextToDisplay = "Towefold 6 Comm Time Out: {0}"
        '
        'CtrlOPCLabel56
        '
        Me.CtrlOPCLabel56.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel56.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel56.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel56.Location = New System.Drawing.Point(8, 181)
        Me.CtrlOPCLabel56.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel56.Name = "CtrlOPCLabel56"
        Me.CtrlOPCLabel56.PlcName = Nothing
        Me.CtrlOPCLabel56.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel56.TabIndex = 14
        Me.CtrlOPCLabel56.TagName = "TF_RFID_Readers[7].comms_timeouts"
        Me.CtrlOPCLabel56.TextToDisplay = "Towefold 7 Comm Time Out: {0}"
        '
        'CtrlOPCLabel57
        '
        Me.CtrlOPCLabel57.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel57.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel57.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel57.Location = New System.Drawing.Point(8, 210)
        Me.CtrlOPCLabel57.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel57.Name = "CtrlOPCLabel57"
        Me.CtrlOPCLabel57.PlcName = Nothing
        Me.CtrlOPCLabel57.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel57.TabIndex = 16
        Me.CtrlOPCLabel57.TagName = "TF_RFID_Readers[8].comms_timeouts"
        Me.CtrlOPCLabel57.TextToDisplay = "Towefold 8 Comm Time Out: {0}"
        '
        'CtrlOPCLabel58
        '
        Me.CtrlOPCLabel58.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel58.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel58.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel58.Location = New System.Drawing.Point(8, 239)
        Me.CtrlOPCLabel58.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel58.Name = "CtrlOPCLabel58"
        Me.CtrlOPCLabel58.PlcName = Nothing
        Me.CtrlOPCLabel58.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel58.TabIndex = 18
        Me.CtrlOPCLabel58.TagName = "TF_RFID_Readers[9].comms_timeouts"
        Me.CtrlOPCLabel58.TextToDisplay = "Towefold 9 Comm Time Out: {0}"
        '
        'CtrlOPCLabel59
        '
        Me.CtrlOPCLabel59.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel59.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel59.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel59.Location = New System.Drawing.Point(8, 268)
        Me.CtrlOPCLabel59.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel59.Name = "CtrlOPCLabel59"
        Me.CtrlOPCLabel59.PlcName = Nothing
        Me.CtrlOPCLabel59.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel59.TabIndex = 20
        Me.CtrlOPCLabel59.TagName = "TF_RFID_Readers[10].comms_timeouts"
        Me.CtrlOPCLabel59.TextToDisplay = "Towefold 10 Comm Time Out: {0}"
        '
        'CtrlOPCLabel60
        '
        Me.CtrlOPCLabel60.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel60.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel60.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel60.Location = New System.Drawing.Point(8, 297)
        Me.CtrlOPCLabel60.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel60.Name = "CtrlOPCLabel60"
        Me.CtrlOPCLabel60.PlcName = Nothing
        Me.CtrlOPCLabel60.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel60.TabIndex = 28
        Me.CtrlOPCLabel60.TagName = "TF_RFID_Readers[11].comms_timeouts"
        Me.CtrlOPCLabel60.TextToDisplay = "Towefold 11 Comm Time Out: {0}"
        '
        'CtrlOPCLabel61
        '
        Me.CtrlOPCLabel61.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel61.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel61.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel61.Location = New System.Drawing.Point(8, 326)
        Me.CtrlOPCLabel61.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel61.Name = "CtrlOPCLabel61"
        Me.CtrlOPCLabel61.PlcName = Nothing
        Me.CtrlOPCLabel61.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel61.TabIndex = 29
        Me.CtrlOPCLabel61.TagName = "TF_RFID_Readers[12].comms_timeouts"
        Me.CtrlOPCLabel61.TextToDisplay = "Towefold 12 Comm Time Out: {0}"
        '
        'CtrlOPCLabel62
        '
        Me.CtrlOPCLabel62.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel62.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel62.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel62.Location = New System.Drawing.Point(8, 616)
        Me.CtrlOPCLabel62.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel62.Name = "CtrlOPCLabel62"
        Me.CtrlOPCLabel62.PlcName = Nothing
        Me.CtrlOPCLabel62.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel62.TabIndex = 39
        Me.CtrlOPCLabel62.TagName = "TF_RFID_Readers[22].comms_timeouts"
        Me.CtrlOPCLabel62.TextToDisplay = "Towefold 22 Comm Time Out: {0}"
        '
        'CtrlOPCLabel63
        '
        Me.CtrlOPCLabel63.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel63.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel63.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel63.Location = New System.Drawing.Point(8, 587)
        Me.CtrlOPCLabel63.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel63.Name = "CtrlOPCLabel63"
        Me.CtrlOPCLabel63.PlcName = Nothing
        Me.CtrlOPCLabel63.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel63.TabIndex = 38
        Me.CtrlOPCLabel63.TagName = "TF_RFID_Readers[21].comms_timeouts"
        Me.CtrlOPCLabel63.TextToDisplay = "Towefold 21 Comm Time Out: {0}"
        '
        'CtrlOPCLabel64
        '
        Me.CtrlOPCLabel64.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel64.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel64.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel64.Location = New System.Drawing.Point(8, 529)
        Me.CtrlOPCLabel64.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel64.Name = "CtrlOPCLabel64"
        Me.CtrlOPCLabel64.PlcName = Nothing
        Me.CtrlOPCLabel64.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel64.TabIndex = 36
        Me.CtrlOPCLabel64.TagName = "TF_RFID_Readers[19].comms_timeouts"
        Me.CtrlOPCLabel64.TextToDisplay = "Towefold 19 Comm Time Out: {0}"
        '
        'CtrlOPCLabel65
        '
        Me.CtrlOPCLabel65.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel65.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel65.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel65.Location = New System.Drawing.Point(8, 442)
        Me.CtrlOPCLabel65.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel65.Name = "CtrlOPCLabel65"
        Me.CtrlOPCLabel65.PlcName = Nothing
        Me.CtrlOPCLabel65.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel65.TabIndex = 33
        Me.CtrlOPCLabel65.TagName = "TF_RFID_Readers[16].comms_timeouts"
        Me.CtrlOPCLabel65.TextToDisplay = "Towefold 16 Comm Time Out: {0}"
        '
        'CtrlOPCLabel66
        '
        Me.CtrlOPCLabel66.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel66.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel66.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel66.Location = New System.Drawing.Point(8, 558)
        Me.CtrlOPCLabel66.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel66.Name = "CtrlOPCLabel66"
        Me.CtrlOPCLabel66.PlcName = Nothing
        Me.CtrlOPCLabel66.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel66.TabIndex = 37
        Me.CtrlOPCLabel66.TagName = "TF_RFID_Readers[20].comms_timeouts"
        Me.CtrlOPCLabel66.TextToDisplay = "Towefold 20 Comm Time Out: {0}"
        '
        'CtrlOPCLabel67
        '
        Me.CtrlOPCLabel67.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel67.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel67.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel67.Location = New System.Drawing.Point(8, 355)
        Me.CtrlOPCLabel67.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel67.Name = "CtrlOPCLabel67"
        Me.CtrlOPCLabel67.PlcName = Nothing
        Me.CtrlOPCLabel67.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel67.TabIndex = 30
        Me.CtrlOPCLabel67.TagName = "TF_RFID_Readers[13].comms_timeouts"
        Me.CtrlOPCLabel67.TextToDisplay = "Towefold 13 Comm Time Out: {0}"
        '
        'CtrlOPCLabel68
        '
        Me.CtrlOPCLabel68.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel68.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel68.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel68.Location = New System.Drawing.Point(8, 500)
        Me.CtrlOPCLabel68.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel68.Name = "CtrlOPCLabel68"
        Me.CtrlOPCLabel68.PlcName = Nothing
        Me.CtrlOPCLabel68.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel68.TabIndex = 35
        Me.CtrlOPCLabel68.TagName = "TF_RFID_Readers[18].comms_timeouts"
        Me.CtrlOPCLabel68.TextToDisplay = "Towefold 18 Comm Time Out: {0}"
        '
        'CtrlOPCLabel69
        '
        Me.CtrlOPCLabel69.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel69.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel69.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel69.Location = New System.Drawing.Point(8, 471)
        Me.CtrlOPCLabel69.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel69.Name = "CtrlOPCLabel69"
        Me.CtrlOPCLabel69.PlcName = Nothing
        Me.CtrlOPCLabel69.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel69.TabIndex = 34
        Me.CtrlOPCLabel69.TagName = "TF_RFID_Readers[17].comms_timeouts"
        Me.CtrlOPCLabel69.TextToDisplay = "Towefold 17 Comm Time Out: {0}"
        '
        'CtrlOPCLabel70
        '
        Me.CtrlOPCLabel70.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel70.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel70.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel70.Location = New System.Drawing.Point(8, 384)
        Me.CtrlOPCLabel70.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel70.Name = "CtrlOPCLabel70"
        Me.CtrlOPCLabel70.PlcName = Nothing
        Me.CtrlOPCLabel70.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel70.TabIndex = 31
        Me.CtrlOPCLabel70.TagName = "TF_RFID_Readers[14].comms_timeouts"
        Me.CtrlOPCLabel70.TextToDisplay = "Towefold 14 Comm Time Out: {0}"
        '
        'CtrlOPCLabel71
        '
        Me.CtrlOPCLabel71.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlOPCLabel71.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCLabel71.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCLabel71.Location = New System.Drawing.Point(8, 413)
        Me.CtrlOPCLabel71.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CtrlOPCLabel71.Name = "CtrlOPCLabel71"
        Me.CtrlOPCLabel71.PlcName = Nothing
        Me.CtrlOPCLabel71.Size = New System.Drawing.Size(236, 13)
        Me.CtrlOPCLabel71.TabIndex = 32
        Me.CtrlOPCLabel71.TagName = "TF_RFID_Readers[15].comms_timeouts"
        Me.CtrlOPCLabel71.TextToDisplay = "Towefold 15 Comm Time Out: {0}"
        '
        'CtrlOPCButton63
        '
        Me.CtrlOPCButton63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton63.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton63.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton63.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton63.HighStateText = "Enabled"
        Me.CtrlOPCButton63.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton63.Location = New System.Drawing.Point(260, 352)
        Me.CtrlOPCButton63.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton63.LowStateText = "Disabled"
        Me.CtrlOPCButton63.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton63.Name = "CtrlOPCButton63"
        Me.CtrlOPCButton63.PlcName = Nothing
        Me.CtrlOPCButton63.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton63.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton63.TabIndex = 149
        Me.CtrlOPCButton63.TagName = "TF_Reader_Enable[13]"
        '
        'CtrlOPCButton64
        '
        Me.CtrlOPCButton64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton64.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton64.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton64.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton64.HighStateText = "Enabled"
        Me.CtrlOPCButton64.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton64.Location = New System.Drawing.Point(260, 381)
        Me.CtrlOPCButton64.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton64.LowStateText = "Disabled"
        Me.CtrlOPCButton64.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton64.Name = "CtrlOPCButton64"
        Me.CtrlOPCButton64.PlcName = Nothing
        Me.CtrlOPCButton64.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton64.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton64.TabIndex = 147
        Me.CtrlOPCButton64.TagName = "TF_Reader_Enable[14]"
        '
        'CtrlOPCButton65
        '
        Me.CtrlOPCButton65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton65.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton65.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton65.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton65.HighStateText = "Enabled"
        Me.CtrlOPCButton65.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton65.Location = New System.Drawing.Point(260, 410)
        Me.CtrlOPCButton65.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton65.LowStateText = "Disabled"
        Me.CtrlOPCButton65.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton65.Name = "CtrlOPCButton65"
        Me.CtrlOPCButton65.PlcName = Nothing
        Me.CtrlOPCButton65.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton65.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton65.TabIndex = 145
        Me.CtrlOPCButton65.TagName = "TF_Reader_Enable[15]"
        '
        'CtrlOPCButton66
        '
        Me.CtrlOPCButton66.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton66.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton66.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton66.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton66.HighStateText = "Enabled"
        Me.CtrlOPCButton66.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton66.Location = New System.Drawing.Point(260, 439)
        Me.CtrlOPCButton66.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton66.LowStateText = "Disabled"
        Me.CtrlOPCButton66.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton66.Name = "CtrlOPCButton66"
        Me.CtrlOPCButton66.PlcName = Nothing
        Me.CtrlOPCButton66.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton66.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton66.TabIndex = 143
        Me.CtrlOPCButton66.TagName = "TF_Reader_Enable[16]"
        '
        'CtrlOPCButton67
        '
        Me.CtrlOPCButton67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton67.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton67.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton67.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton67.HighStateText = "Enabled"
        Me.CtrlOPCButton67.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton67.Location = New System.Drawing.Point(260, 468)
        Me.CtrlOPCButton67.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton67.LowStateText = "Disabled"
        Me.CtrlOPCButton67.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton67.Name = "CtrlOPCButton67"
        Me.CtrlOPCButton67.PlcName = Nothing
        Me.CtrlOPCButton67.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton67.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton67.TabIndex = 141
        Me.CtrlOPCButton67.TagName = "TF_Reader_Enable[17]"
        '
        'CtrlOPCButton68
        '
        Me.CtrlOPCButton68.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton68.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton68.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton68.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton68.HighStateText = "Enabled"
        Me.CtrlOPCButton68.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton68.Location = New System.Drawing.Point(260, 497)
        Me.CtrlOPCButton68.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton68.LowStateText = "Disabled"
        Me.CtrlOPCButton68.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton68.Name = "CtrlOPCButton68"
        Me.CtrlOPCButton68.PlcName = Nothing
        Me.CtrlOPCButton68.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton68.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton68.TabIndex = 139
        Me.CtrlOPCButton68.TagName = "TF_Reader_Enable[18]"
        '
        'CtrlOPCButton69
        '
        Me.CtrlOPCButton69.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton69.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton69.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton69.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton69.HighStateText = "Enabled"
        Me.CtrlOPCButton69.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton69.Location = New System.Drawing.Point(260, 526)
        Me.CtrlOPCButton69.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton69.LowStateText = "Disabled"
        Me.CtrlOPCButton69.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton69.Name = "CtrlOPCButton69"
        Me.CtrlOPCButton69.PlcName = Nothing
        Me.CtrlOPCButton69.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton69.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton69.TabIndex = 137
        Me.CtrlOPCButton69.TagName = "TF_Reader_Enable[19]"
        '
        'CtrlOPCButton70
        '
        Me.CtrlOPCButton70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton70.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton70.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton70.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton70.HighStateText = "Enabled"
        Me.CtrlOPCButton70.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton70.Location = New System.Drawing.Point(260, 555)
        Me.CtrlOPCButton70.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton70.LowStateText = "Disabled"
        Me.CtrlOPCButton70.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton70.Name = "CtrlOPCButton70"
        Me.CtrlOPCButton70.PlcName = Nothing
        Me.CtrlOPCButton70.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton70.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton70.TabIndex = 135
        Me.CtrlOPCButton70.TagName = "TF_Reader_Enable[20]"
        '
        'CtrlOPCButton71
        '
        Me.CtrlOPCButton71.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlOPCButton71.DataBindings.Add(New System.Windows.Forms.Binding("PLCName", Me.PlcNameConfigBindingSource, "TSAProductivityPLC", True))
        Me.CtrlOPCButton71.GroupName = "RFID_Reader_Diagnostics"
        Me.CtrlOPCButton71.HighStateColor = System.Drawing.Color.Lime
        Me.CtrlOPCButton71.HighStateText = "Enabled"
        Me.CtrlOPCButton71.IsSecurityFeatureUsed = False
        Me.CtrlOPCButton71.Location = New System.Drawing.Point(260, 584)
        Me.CtrlOPCButton71.LowStateColor = System.Drawing.Color.Red
        Me.CtrlOPCButton71.LowStateText = "Disabled"
        Me.CtrlOPCButton71.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlOPCButton71.Name = "CtrlOPCButton71"
        Me.CtrlOPCButton71.PlcName = Nothing
        Me.CtrlOPCButton71.RightNeeded = RailAccessOptions.UNKNOWN
        Me.CtrlOPCButton71.Size = New System.Drawing.Size(111, 22)
        Me.CtrlOPCButton71.TabIndex = 133
        Me.CtrlOPCButton71.TagName = "TF_Reader_Enable[21]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 25)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Towel Folders"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Reader"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(399, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Serial Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(272, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 16)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Enable/Disable"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(301, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Reader"
        '
        'frmRFIDReaderDiagnostics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 939)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tableTowelFold)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tableFlatWork)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTFCommCountReset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnIronerCommCountReset)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.Name = "frmRFIDReaderDiagnostics"
        Me.Text = "RFID Reader Diagnostics"
        CType(Me.PlcNameConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableFlatWork.ResumeLayout(False)
        Me.tableTowelFold.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIronerCommCountReset As System.Windows.Forms.Button
    Friend WithEvents CtrlOPCLabel3 As CtrlOpcLabel
    Friend WithEvents btnTFCommCountReset As System.Windows.Forms.Button
    Friend WithEvents CtrlOPCLabel5 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel19 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel7 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel9 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel11 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel13 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel15 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel17 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel33 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel34 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel35 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel36 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel37 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel38 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel39 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel40 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel41 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel42 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel43 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel44 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel45 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel46 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel47 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel48 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel49 As CtrlOpcLabel
    Friend WithEvents CtrlOPCTextBox2 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox3 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox4 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox5 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox1 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCLabel2 As CtrlOpcLabel
    Friend WithEvents tableFlatWork As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CtrlOPCButton1 As CtrlOpcButton
    Friend WithEvents CtrlOPCTextBox12 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox11 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox10 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox9 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox8 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox7 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox6 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCButton7 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton5 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton4 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton3 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton2 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton6 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton8 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton9 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton10 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton11 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton12 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton13 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton26 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton24 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton22 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton20 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton18 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton14 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton15 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton16 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton17 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton19 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton21 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton23 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton25 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton27 As CtrlOpcButton
    Friend WithEvents CtrlOPCTextBox23 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox22 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox21 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox20 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox19 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox18 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox17 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox16 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox15 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox29 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox30 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox31 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox32 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox33 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox34 As CtrlOpcTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tableTowelFold As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CtrlOPCButton50 As CtrlOpcButton
    Friend WithEvents CtrlOPCTextBox50 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox51 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox52 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox53 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox54 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox55 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox56 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox57 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox58 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox59 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox60 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox61 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox62 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox63 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox64 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox65 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox66 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox67 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox68 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox69 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox70 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCTextBox71 As CtrlOpcTextBox
    Friend WithEvents CtrlOPCButton51 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton52 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton53 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton54 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton55 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton56 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton57 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton58 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton59 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton60 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton61 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton62 As CtrlOpcButton
    Friend WithEvents CtrlOPCLabel50 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel51 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel52 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel53 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel54 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel55 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel56 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel57 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel58 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel59 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel60 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel61 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel62 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel63 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel64 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel65 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel66 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel67 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel68 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel69 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel70 As CtrlOpcLabel
    Friend WithEvents CtrlOPCLabel71 As CtrlOpcLabel
    Friend WithEvents CtrlOPCButton63 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton64 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton65 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton66 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton67 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton68 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton69 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton70 As CtrlOpcButton
    Friend WithEvents CtrlOPCButton71 As CtrlOpcButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
