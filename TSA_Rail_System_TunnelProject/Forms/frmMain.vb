Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Logging.LoggingManager
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.OpcDa.Core.Interfaces

Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Extensions
Imports Wdw_Sust.Textile.Core.Interfaces

Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.Wcf
Imports Wdw_Sust.Textile.Global.WinForms
Imports Wdw_Sust.Textile.Global.WinForms.Interfaces
Imports Wdw_Sust.Textile.Global.WinForms.ViewModels
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Textile.Tsa.Opc.WinForms
Imports Wdw_Sust.Textile.Tsa.Wcf
Imports Wdw_Sust.Textile.Tsa.Workflow
Imports Wdw_Sust.Textile.Tsa.Workflow.Dal
Imports Wdw_Sust.Textile.Tsa.Workflow.EventArgs
Imports Wdw_Sust.Textile.Tsa.Workflow.Interfaces
Imports Wdw_Sust.Textile.Tsa.Workflow.Wcf
Imports Wdw_Sust.Textile.Tsa.Workflow.WinForms
Imports System.Threading.Tasks
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Deploy
Imports DevExpress.Office.Utils
Imports System.Linq


Public Class frmMain
    Inherits frmRailMainFormBase

#Region "Fields"

    Private _bagsWashedAndSorted As New List(Of LintKeyValuePair(Of LintZone, Integer)) From
        {New LintKeyValuePair(Of LintZone, Integer)(LintZone.CLASSIFIED_STORAGE, 0),
         New LintKeyValuePair(Of LintZone, Integer)(LintZone.CLEANWORK_STORAGE, 0)}

    Private _workflowEnable As Boolean
    Private WithEvents _workflowWcfClient As WcfTsaWorkflowClient
    Private _workflow As ILintWorkflowProvider
    Private _update As UpdateHelper = New UpdateHelper()
    Private _fontSize As Integer = 12
    Private _displayConfigFile As DisplayConfigFile
    Private _opcConnectAttempted As Boolean = False
    Private _serverStateFailed As Boolean

#End Region

#Region "Properties"
    Protected ReadOnly Property WorkflowProvider As ILintWorkflowProvider
        Get
            If _workflow Is Nothing Then
                _workflow = TsaWorkflowInfoProvider.Instance
                _workflow.ConnectionString = Db_Configuration.LintInUseConnectionString
            End If
            Return _workflow
        End Get
    End Property
#End Region

#Region "Methods"

#Region "Initialization"
    Private Sub InitializeSystemParameters()
        'If Not Not CONFIGURATION.IsFailOverMode Then
        Dim action As Boolean = TryAction(Sub() _workflowEnable = CBool(Factory.Services.GetSystemParameters(Plant.TSA, LintSystemParameterId.EnableWorkflowSystem).Value))
        If Not action Then MsgBox("Cannot retrieve System Parameters")
        'End If
    End Sub

    Protected Overrides Sub Initialize()
        If GetGlobalSettings() Then
            MyBase.Initialize()
            InitializeSystemParameters()
            If InitializeOpcParameters() Then
                AddJob(SR.JOB_GET_BAG_WASHED_AND_SORTED, TimeSpan.FromSeconds(60), AddressOf UpdateBagWashedAndSorted, Not CONFIGURATION.IsFailOverMode)
                AddJob(SR.JOB_PING_APPLICATION_SERVER, TimeSpan.FromSeconds(10), AddressOf PingApplicationService, Not CONFIGURATION.IsFailOverMode)
            End If
            InitializeBroadcasters()
            If CONFIGURATION.WorkStation = WorkStations.TSA_WASHDECK_CONTROL_PC_1 Then OpenWashdeckDisplay()
            tssLoginStatus.Text = SR.INFORMATION_NO_LOG_IN
            tssLastAction.Text = SR.INFORMATION_NO_RECORDED_LAST_ACTION
            AddHandler SHIFT_CLOCK.CurrentShiftChanged, Sub(a, b) _bagsWashedAndSorted.ForEach(Sub(c) c.Value = 0)
        End If
    End Sub

    Private Function InitializeOpcParameters() As Boolean
        If OpcComm.EnableOpcCommunication Then
            InitializeOpcSettings()
            InitializeOpcObjects()
            InitializeOpcCommunication()
        Else
            Return False
        End If
        Return OPC.IsServerRunning
    End Function

    Private Sub OPC_ServerState(serverState As Boolean)
        If Not serverState Then
            _serverStateFailed = True
        Else
            If _serverStateFailed = True Then
                _serverStateFailed = False
                InitializeOpcParameters()
            End If
        End If
    End Sub

    Private Sub PingApplicationService()
        If Not BllWcfRailInfoProvider.Instance.Ping() Then
            BllRailInfoProvider.Instance.InformationSource = InformationSource.Database
        ElseIf BllRailInfoProvider.Instance.InformationSource = InformationSource.Database Then
            BllRailInfoProvider.Instance.InformationSource = InformationSource.Wcf
        End If
    End Sub

    Private Sub UpdateBagWashedAndSorted()
        If SHIFT_CLOCK IsNot Nothing Then
            Dim shiftData As LintShiftData = SHIFT_CLOCK.GetCurrentShiftData
            If shiftData IsNot Nothing Then _bagsWashedAndSorted = BllRailInfoProvider.Instance.Service.GetNumberOfBagWashedAndSorted(shiftData)
            'If shiftData IsNot Nothing Then _bagsWashedAndSorted = BllDatabaseRailInfoProvider.Instance.GetNumberOfBagWashedAndSorted(shiftData)
            If _bagsWashedAndSorted IsNot Nothing Then
                If _bagsWashedAndSorted.Count > 1 Then
                    InvokeIfNeeded(Sub()
                                       tssTotalSorted.Text = String.Format(SR.INFORMATION_TOTAL_SORTED, Pound_Sorted.Value, _bagsWashedAndSorted(0).Value)
                                       tssTotalWashed.Text = String.Format(SR.INFORMATION_TOTAL_WASHED, Pound_Washed.Value, _bagsWashedAndSorted(1).Value)
                                   End Sub)
                Else
                    _bagsWashedAndSorted = New List(Of LintKeyValuePair(Of LintZone, Integer)) From
                     {New LintKeyValuePair(Of LintZone, Integer)(LintZone.CLASSIFIED_STORAGE, 0),
                      New LintKeyValuePair(Of LintZone, Integer)(LintZone.CLEANWORK_STORAGE, 0)}
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' This will fire when an application mode changed is detected. This will also fire at the beginning of the program start.
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overrides Sub ApplicationModeChanged()
        MyBase.ApplicationModeChanged()
        Dim isFailOver As Boolean = CONFIGURATION.IsFailOverMode
        InvokeIfNeeded(Sub()
                           ProductivityToolStripMenuItem.Enabled = Not isFailOver
                           CategoryWorkflowParametersToolStripMenuItem.Enabled = Not isFailOver
                           tssNumberOfFWTFLogin.Visible = Not isFailOver
                           tsmiShiftSettings.Enabled = Not isFailOver
                           If isFailOver Then
                               RunAutoCallOffToolStripMenuItem.Enabled = Not isFailOver
                               tsbtnAutoCallOff.Enabled = Not isFailOver
                           End If
                       End Sub)
        ChangeJobStatusIfDefined(Not isFailOver, SR.JOB_CHECK_WORKFLOW_HOST, SR.JOB_GET_BAG_WASHED_AND_SORTED, SR.JOB_PING_APPLICATION_SERVER)
    End Sub

    Protected Overrides Sub StartRemoteServices()
        StartWorkflowService()
        MyBase.StartRemoteServices()
    End Sub

    Protected Overrides Sub StopRemoteServices()
        If _workflowEnable Then _workflowWcfClient.Dispose()
        MyBase.StopRemoteServices()
    End Sub

    Protected Overrides Sub WorkStationChanged()
        Dim isUnknownPC As Boolean = (CONFIGURATION.WorkStation = WorkStations.UNKNOWN)
        Dim isCoachesPC As Boolean = (CONFIGURATION.WorkStation = WorkStations.TSA_COACHES_PC)
        Dim isSortingPC As Boolean = (CONFIGURATION.WorkStation = WorkStations.TSA_SORTING_CONTROL_PC)
        Dim isDevelopmentPC As Boolean = (CONFIGURATION.WorkStation = WorkStations.DEVELOPMENT_PC)
        msMain.Enabled = Not isUnknownPC
        tsMain.Enabled = Not isUnknownPC
        StatusStrip1.Enabled = Not isUnknownPC
        ''StatusStrip2.Enabled = Not isUnknownPC
        EnableRundownButtons(Not isCoachesPC)
        ResetProductivityCountsToolStripMenuItem.Enabled = isCoachesPC Or isDevelopmentPC
        WeightCalibrationToolStripMenuItem.Enabled = isSortingPC Or isDevelopmentPC
        DataCollectionMonitoringToolStripMenuItem.Visible = isDevelopmentPC
        RailSequenceEditorToolStripMenuItem.Visible = isDevelopmentPC
        WashdeckToolStripMenuItem.Enabled = Not isCoachesPC
        LastWorkflowCalculationToolStripMenuItem.Enabled = isDevelopmentPC
        If isDevelopmentPC Then
            SubscribeToolbarAlarms(CtrlLINTAlarmToolStripIndicator1)
        End If
        MyBase.WorkStationChanged()
    End Sub

    Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider
        Return TsaFactoryProvider.Instance
    End Function

    Protected Overrides Function GetGlobalSettings() As Boolean
        If Not MyBase.GetGlobalSettings Then Return False
        If Not IsTsaControlWorkStation(CONFIGURATION.WorkStation) Then
            Dim frm As CtrlLintAdminConsole = ShowChildForm(Of CtrlLintAdminConsole)(New Object() {New CtrlLintAdminConsoleViewModelForRailGraphics})
            If frm IsNot Nothing Then AddHandler frm._OnSavingData, AddressOf CheckRoleAccessRights
            Return False
        End If
        tssVersion.Text = GetClassLibraryAssemblyVersion()
        Return True
    End Function

    Private Sub EnableRundownButtons(ByVal isEnabled As Boolean)
        tsgcClassifiedOngoing.Enabled = isEnabled
        tsgcClassifiedOffgoing.Enabled = isEnabled
        tsgcCleanworkOngoing.Enabled = isEnabled
        tsgcCleanworkOffgoing.Enabled = isEnabled
    End Sub

    Private Sub InitializeRundownControls()
        tsgcClassifiedOngoing.PLCName = CONFIGURATION.PlcTopics.TsaClassifiedPlc
        tsgcClassifiedOffgoing.PLCName = CONFIGURATION.PlcTopics.TsaClassifiedPlc
        tsgcCleanworkOngoing.PLCName = CONFIGURATION.PlcTopics.TsaCleanworkPlc
        tsgcCleanworkOffgoing.PLCName = CONFIGURATION.PlcTopics.TsaCleanworkPlc

        OPC.AddOpcObjects(tsgcClassifiedOngoing.Request, tsgcClassifiedOngoing.Completed,
                          tsgcClassifiedOffgoing.Request, tsgcClassifiedOffgoing.Completed,
                          tsgcCleanworkOngoing.Request, tsgcCleanworkOngoing.Completed,
                          tsgcCleanworkOffgoing.Request, tsgcCleanworkOffgoing.Completed)
    End Sub

    Private Sub InitializeAutoCallOffControls()

        Dim act As Action(Of CtrlOpcTsaAutoCallOffButton, Boolean) = Sub(a, b)
                                                                         a.PLCName = CONFIGURATION.PlcTopics.TsaClassifiedPlc
                                                                         a.Enabled = b
                                                                         OPC.AddOpcObjects(a.WorkflowControl, a.WorkflowEnable)
                                                                         AddHandler a._OnChangeAction, AddressOf ChangeAutoCallOff
                                                                     End Sub
        tsbtnAutoCallOff.Enabled = _workflowEnable
    End Sub

    Private Sub ChangeAutoCallOff(ByVal sender As Object, ByVal e As LintRoleAccessRightEventArgs)
        Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRoleAccessRights(card, e)
        If e.CancelAction Then Exit Sub
        Dim btn As CtrlOpcTsaAutoCallOffButton = CType(sender, CtrlOpcTsaAutoCallOffButton)
        If btn.WorkflowEnable.Value Then
            Using frm As New CtrlTsaWorkflowCallOffReasons(e.EmployeeId, btn.WasherNumber, Number_Of_Auto_Call_Off_Tunnels.Value)
                Select Case frm.ShowDialog()
                    Case DialogResult.Cancel
                        e.CancelAction = True
                End Select
            End Using
        End If
    End Sub

    Protected Overrides Sub InitializeOpcObjects()
        'Global Parameters
        Available_Dryers = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaAquamizerPlc, "dintNumber_Of_Available_Dryers", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Available_Washers = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaAquamizerPlc, "dintNumber_Of_Available_Washers", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Total_Washers = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaAquamizerPlc, "dintTotal_Number_Of_Washers", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Total_Dryers = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaAquamizerPlc, "dintTotal_Number_Of_Dryers", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        External_Login_Validation_Service = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaProductivityPlc, "External_Log_in_Validation_Enable", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Pound_Sorted = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaClassifiedPlc, "Total_Weight_Sorted", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Pound_Washed = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaClassifiedPlc, "Total_Weight_Washed", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Number_Of_Auto_Call_Off_Tunnels = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaClassifiedPlc, "dintAutomatic_Call_Off_Count", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Classified_Total_Number_Of_Bags = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaClassifiedPlc, "Bags_In_Store", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        Cleanwork_Total_Number_Of_Bags = OPC.AddOpcObject(Of OpcElement)(CONFIGURATION.PlcTopics.TsaCleanworkPlc, "Bags_In_Store", SR.OPC_GROUP_GLOBAL_PARAMETER, Me)
        AddHandler External_Login_Validation_Service.PropertiesUpdateCompleted, Sub(a, b)
                                                                                    If CBool(External_Login_Validation_Service.Value) Then
                                                                                        EnableExternalLoginValidationToolStripMenuItem.Text = "Disable External Login Validation"
                                                                                    Else
                                                                                        EnableExternalLoginValidationToolStripMenuItem.Text = "Enable External Login Validation"
                                                                                    End If
                                                                                End Sub
        InitializeRundownControls()
        InitializeAutoCallOffControls()
    End Sub

    ''' <summary>
    ''' Initialize all broadcasters here. These broadcasters are used to get alarm and login 
    ''' information from the database. The 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeBroadcasters()
        ProductivityBroadcaster.UpdateInterval = 60000 '1 Minutes
        AlarmBroadcaster.UpdateInterval = 30000 '30 Seconds
    End Sub

    Protected Overrides Sub InitializeOpcCommunication()
        If Not TryAction(Sub() OPC.OpenOpcComm(SR.OPC_GROUP_GLOBAL_PARAMETER, 3000)) Then
            ''OPC = Nothing
            'MsgBox("No OPC Server Found, please ensure that RsLinx is running.  (Note: RsLinx Classic Lite is not compatible with this application.)")
        End If

        AddHandler OPC.OpcServerStateError, AddressOf OPC_ServerState
    End Sub

#End Region

#Region "Menu Items"

    Private Sub RfidCommunicationsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles RFIDCommunicationsToolStripMenuItem.Click
        Dim cardData As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        If cardData IsNot Nothing Then
            ShowChildForm(Of frmRfidReaderDiagnostics)(parameters:={cardData.CastInfo})
        Else
            MsgBox(SR.WARNING_SCAN_ID_AGAIN)
        End If
    End Sub

    Private Sub SystemLogToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles SystemLogToolStripMenuItem.Click
        Process.Start("explorer.exe", "Logs\")
    End Sub

    Private Sub DatabaseSettingsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles DatabaseSettingsToolStripMenuItem.Click
        ShowChildForm(Of CtrlLintConnectionStringBuilder)()
    End Sub

    Private Sub CastMemberShiftDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CastMemberShiftDataToolStripMenuItem.Click
        ShowChildForm(Of frmCastMemberShiftData)(New Object() {SHIFT_CLOCK})
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ShowChildForm(Of CtrlAbout)()
        'ShowChildForm(Of CtrlAlarmCreator)()
        'ShowChildForm(Of CtrlLintAlarmEditTool)()
        'TryUserAction(Sub() Throw New Exception, "Test", sendEmail:=True)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing And TypeOf ActiveMdiChild Is ILintRailForm Then
            'PrintChild(ActiveMdiChild, String.Format("{0} - {1}, {2}", Now.ToString, tssTotalSorted.Text, tssTotalWashed.Text))
        ElseIf ActiveMdiChild IsNot Nothing Then
            PrintChild(ActiveMdiChild)
        Else
            MsgBox(SR.WARNING_SELECT_ACTIVE_FORM_TO_PRINT)
        End If
    End Sub

    Private Sub ResetProductivityCountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetProductivityCountsToolStripMenuItem.Click
        ShowChildForm(Of frmProductivityControl)()
    End Sub

    Private Sub SortingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortingToolStripMenuItem.Click
        ShowChildForm(Of frmSortingProductivity)(New Object() {SHIFT_CLOCK})
    End Sub

    'Private Sub ClassifiedSortingBinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassifiedSortingBinToolStripMenuItem.Click
    '    ShowChildForm(Of frmLoadingBins)()
    'End Sub

    Private Sub UserManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManagementToolStripMenuItem.Click
        Dim key As LintSystemParameter = Factory.Services.GetSystemParameters(Plant.ALL_PLANTS, LintSystemParameterId.RostrApiKey)
        Dim cardData As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)

        If cardData IsNot Nothing Then
            ShowChildForm(Of CtrlLintUserManagement)(parameters:={cardData.CastInfo, key.Value})
        Else
            MsgBox(SR.WARNING_SCAN_ID_AGAIN)
        End If
    End Sub

    Private Sub RailSequenceEditorToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles RailSequenceEditorToolStripMenuItem.Click
        ShowChildForm(Of CtrlTsaRailSequenceInfoEdit)()
    End Sub

    Private Sub WashdeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashdeckToolStripMenuItem.Click
        ShowChildForm(Of frmTunnelInterface)()
    End Sub

    Private Sub DataCollectionMonitoringToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataCollectionMonitoringToolStripMenuItem.Click
        ShowChildForm(Of CtrlOpcDataCollectionMonitoring)()
    End Sub

    Private Sub ActiveAlarms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssActiveAlarms.DoubleClick, AlarmViewerToolStripMenuItem.Click
        ShowChildForm(Of CtrlLintAlarmViewer)()
    End Sub

    'Private Sub ClassifiedStorageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassifiedStorageToolStripMenuItem.Click
    '    ShowChildForm(Of frmClassifiedStorage)()
    'End Sub

    Private Sub AdminConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminConsoleToolStripMenuItem.Click
        Dim isNewInstance As Boolean = Not DoesChildExist(GetType(CtrlLintAdminConsole))
        Dim frm As CtrlLintAdminConsole = ShowChildForm(Of CtrlLintAdminConsole)(New Object() {New CtrlLintAdminConsoleViewModelForRailGraphics})
        If isNewInstance Then AddHandler frm._OnSavingData, AddressOf CheckRoleAccessRights
    End Sub
    Dim param As Integer
    'Private Sub CleanworkoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanworkToolStripMenuItem.Click

    '    Dim pickerPhase As LintSystemParameter = Factory.Services.GetSystemParameters(Plant.TSA, LintSystemParameterId.PickerProjectCurrentPhase)

    '    Select Case pickerPhase.Value
    '        Case 1
    '            ShowChildForm(Of frmCleanworkPhase1)()
    '        Case 2
    '            ShowChildForm(Of frmCleanworkPhase2)()
    '        Case 3
    '            ShowChildForm(Of frmCleanworkPhase3)()
    '        Case 4
    '            ShowChildForm(Of frmCleanworkPhase4)()
    '        Case 5
    '            ShowChildForm(Of frmCleanworkPhase5)()
    '        Case 6
    '            ShowChildForm(Of frmCleanworkPhase6)()
    '        Case Else
    '            ShowChildForm(Of frmCleanwork)()
    '    End Select

    'End Sub

    'Private Sub ClassifiedLoadingPlatformToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassifiedLoadingPlatformToolStripMenuItem.Click
    '    ShowChildForm(Of frmClassifiedLoadingPlatform)()
    'End Sub

    'Private Sub LoadingPlatformPhase1ToolStripMenuItem_Click(sender As Object, e As System.EventArgs)
    '    ShowChildForm(Of frmClassifiedLoadingPlatform)()
    'End Sub

    Private Sub DesktopToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles DesktopToolStripMenuItem.Click
        OpenLintReportViewer(CONFIGURATION.Plant, False)
    End Sub

    Private Sub TableauToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles TableauToolStripMenuItem.Click
        OpenInBrowser("https://tableau10.wdw.disney.com/#/site/TextileServices/projects/2044/views")
    End Sub

    Private Sub ChatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChatToolStripMenuItem.Click
        ShowChildForm(Of CtrlLintChatTool)({ChatService, CONFIGURATION.Plant})
    End Sub

    Private Sub LastAction_Click(sender As System.Object, e As System.EventArgs) Handles tssLastAction.Click
        ShowChildForm(Of CtrlTsaOperatorEventLog)()
    End Sub

    Private Async Sub CheckForUpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        Await GetUpdates()
    End Sub

    Private Async Function GetUpdates() As Task
        If My.Computer.FileSystem.FileExists(".is_a_squirrel") Then
            Await _update.GetUpdate()
        End If
    End Function

    'Private Sub DischargerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargerToolStripMenuItem.Click
    '    ShowChildForm(Of frmClassifiedDischarger)()
    'End Sub

    Private Sub CleanworkProductivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanworkProductivityToolStripMenuItem.Click
        'Dim isNewInstance As Boolean = Not DoesChildExist(GetType(frmCleanworkProductivity))
        'Dim frm As frmCleanworkProductivity = CType(ShowChildForm(Of frmCleanworkProductivity)(), frmCleanworkProductivity)
        'If isNewInstance Then AddHandler frm._loginEnableChanging, AddressOf CheckRailAccessRights
    End Sub

    'Private Sub CallOffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CallOffToolStripMenuItem.Click
    '    ShowChildForm(Of frmClassifiedCallOff)()
    'End Sub

    'Private Sub tsAutoCallOff_Click(sender As System.Object, e As System.EventArgs) Handles tsAutoCallOff.Click
    '    ShowChildForm(Of frmClassifiedAutoCallOff)()
    'End Sub

    Private Sub WashdeckToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashdeckToolStripMenuItem1.Click
        ShowChildForm(Of frmWashdeckProductivity)({SHIFT_CLOCK})
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategorySetupToolStripMenuItem.Click
        Dim isNewInstance As Boolean = Not DoesChildExist(GetType(CtrlOpcTsaCategoryDetails))
        Dim frm As CtrlOpcTsaCategoryDetails = ShowChildForm(Of CtrlOpcTsaCategoryDetails)()
        If isNewInstance Then
            AddHandler frm._OnUpdatingChanges, AddressOf CheckRailAccessRights
            AddHandler frm._OnAddingCategory, AddressOf CheckRailAccessRights
            AddHandler frm._OnUpdatedChanges, AddressOf Logger.LogOperatorEvent
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        InvokeIfNeeded(Sub() Close())
    End Sub

    Private Sub RunAutoCallOff_Click(sender As System.Object, e As System.EventArgs) Handles RunAutoCallOffToolStripMenuItem.Click, tsbtnAutoCallOff.Click
        RunAutoCallOff()
    End Sub

    Private Sub tssActiveAlarms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssActiveAlarms.Click, tssActiveAlarms.DoubleClick
        ShowChildForm(Of CtrlLintAlarmViewer)()
    End Sub

    Private Sub ProductDistributionToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ProductDistributionToolStripMenuItem.Click
        ShowChildForm(Of frmProductDistribution)()
    End Sub

    'Private Sub ClassifiedCallOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassifiedCallOffToolStripMenuItem.Click
    '    ShowChildForm(Of frmClassifiedCallOff)()
    'End Sub

    Private Sub OperatorLogToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles OperatorLogToolStripMenuItem.Click
        ShowChildForm(Of CtrlTsaOperatorEventLog)()
    End Sub

    Private Sub WeightCalibrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeightCalibrationToolStripMenuItem.Click
        ShowChildForm(Of frmScaleCalibration)()
    End Sub

    Private Sub ShiftSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tsmiShiftSettings.Click
        Dim isNewInstance As Boolean = Not DoesChildExist(GetType(CtrlOpcShiftAssignment))
        Dim frm As CtrlOpcShiftAssignment = ShowChildForm(Of CtrlOpcShiftAssignment)(New Object() {CONFIGURATION.Plant})
        If isNewInstance Then AddHandler frm._OnSavingData, AddressOf CheckRoleAccessRights
    End Sub

    Private Async Sub CategoryWorkflowParametersToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles CategoryWorkflowParametersToolStripMenuItem.Click
        Dim cardData As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        If cardData IsNot Nothing AndAlso cardData.CastInfo IsNot Nothing Then
            Dim categories = Await WorkflowProvider.GetWorkflowCategoryParametersAsync
            ShowChildForm(Of frmWorkflowCategoryConfigurations)(New Object() {categories, cardData.CastInfo})
        Else
            MsgBox("Please scan your ID again!!")
        End If
    End Sub

    Private Sub EnableExternalLoginValidationToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles EnableExternalLoginValidationToolStripMenuItem.Click
        Dim args As New LintRoleAccessRightEventArgs(LintSecurityProvider.GetTsaRolesToEnableAndDisableExternalLoginValidation, CONFIGURATION.Plant)
        Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRoleAccessRights(card, args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            External_Login_Validation_Service.ValueFromObjectToPlc(String.Empty, Not CBool(External_Login_Validation_Service.Value))
            Dim action As LintAction = IIf(CBool(External_Login_Validation_Service.Value), LintAction.DISABLE_LOGIN_VALIDATION, LintAction.ENABLE_LOGIN_VALIDATION)
            Logger.LogOperatorEvent(Me, New LintOperatorEventArgs(Now, args.EmployeeId, My.Computer.Name, action, "External log in validation has been changed!"))
        Else
            MsgBox(args.Message)
        End If
    End Sub
#End Region

    Private Sub frmMain__LogCreated(ByVal logDescription As String) Handles Me._LogCreated
        tssLastAction.Text = String.Format("{0} - {1}", logDescription, Now.ToString)
    End Sub

    Private Sub frmMain__OnLoginChanged() Handles Me._OnLoginChanged
        If LastLoginCard IsNot Nothing Then
            If LastLoginCard.CastInfo IsNot Nothing Then
                tssLoginStatus.Text = String.Format("Last Log In: {0}", LastLoginCard.CastInfo.EmployeeName)
                tssLastAction.Text = Now.ToString
            End If
        End If
    End Sub

    Protected Overrides Sub ChatServiceEnableChanged()
        CtrlLINTChatToolStripIndicator1.Visible = CONFIGURATION.IsChatServiceEnabled
    End Sub

    Protected Overrides Function CreateChatClientObject() As IChatClient
        Return New WcfChatClient(Factory.Services.GetServiceSettings(LintServiceType.WCF_LINT_CHAT), CONFIGURATION.Plant)
    End Function

    ''' <summary>
    ''' Open washdeck display on the 2nd monitor 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenWashdeckDisplay()
        SuspendLayout()
        Dim frm As Form = ShowChildForm(Of frmTunnelInterface)(setAsChild:=False)
        For Each screen As Screen In Screen.AllScreens
            If Not screen.Primary Then
                frm.DesktopLocation = screen.Bounds.Location
                Exit For
            End If
        Next
        WindowState = FormWindowState.Maximized
        ResumeLayout(True)
    End Sub

    Private Sub SetStaticScreen(Of T As Form)()
        Dim frm As T = Activator.CreateInstance(Of T)
        Dim showBorder As Boolean = _displayConfigFile.ShowChildFormBorder
        Dim centerForm As Boolean = _displayConfigFile.ChildFormIsCentered

        With frm
            If Not showBorder Then
                .FormBorderStyle = FormBorderStyle.None
            End If
            If centerForm Then
                .StartPosition = FormStartPosition.CenterScreen
            End If
            .MdiParent = Me
            .Show()
            .Top = 0
        End With
    End Sub

    Private Sub tsgcRundown__OnChangeAction(ByVal sender As Object, ByVal e As IRailAccessRightEventArgs) Handles tsgcClassifiedOngoing._OnChangeAction,
                                                                                                                tsgcClassifiedOffgoing._OnChangeAction,
                                                                                                                tsgcCleanworkOngoing._OnChangeAction,
                                                                                                                tsgcCleanworkOffgoing._OnChangeAction
        Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRailAccessRights(card, e)
    End Sub

    Private Sub tsgcRundown__OnChangedAction(ByVal sender As Object, ByVal e As LintOperatorEventArgs) Handles tsgcClassifiedOngoing._OnChangedAction,
                                                                                                            tsgcClassifiedOffgoing._OnChangedAction,
                                                                                                            tsgcCleanworkOngoing._OnChangedAction,
                                                                                                            tsgcCleanworkOffgoing._OnChangedAction
        Logger.LogOperatorEvent(sender, e)
    End Sub

    Private Sub tsgc_RunDownStatusChanged(sender As Object, e As System.EventArgs) Handles tsgcClassifiedOffgoing._RunDownStatusChanged,
                                                                                           tsgcClassifiedOngoing._RunDownStatusChanged,
                                                                                           tsgcCleanworkOngoing._RunDownStatusChanged,
                                                                                           tsgcCleanworkOffgoing._RunDownStatusChanged
        IsClassifiedOngoingRunDown = tsgcClassifiedOngoing.IsRunDownCompleted
        IsClassifiedOffgoingRunDown = tsgcClassifiedOffgoing.IsRunDownCompleted
        IsCleanworkOngoingRunDown = tsgcCleanworkOngoing.IsRunDownCompleted
        IsCleanworkOffgoingRunDown = tsgcCleanworkOffgoing.IsRunDownCompleted
    End Sub

    Public Overrides Function CreateAlarmBroadcaster() As ILintAlarmBroadcaster(Of LintAlarmEventArgs)
        Return LintAlarmBroadcaster.Instance
    End Function

    Protected Overrides Function CreateProductivitySummaryBroadcaster() As ILintProductivitySummaryBroadcaster
        Return TsaProductivitySummaryBroadcaster.Instance
    End Function

    Protected Overrides Sub AlarmStatusUpdateCompleted(sender As Object, e As LintAlarmEventArgs)
        InvokeIfNeeded(Sub() tssActiveAlarms.Text = String.Format(SR.INFORMATION_ACTIVE_ALARM_COUNTS, e.ActiveAlarmList.Count))
    End Sub

    Protected Overrides Sub ProductivitySummaryUpdateCompleted(sender As Object, e As LintProductivitySummaryEventArgs)
        InvokeIfNeeded(Sub() tssNumberOfFWTFLogin.Text = String.Format(SR.INFORMATION_LOGIN, e.NumberOfIronerLogin, e.NumberOfTowelFoldLogin))
    End Sub

    Private Sub OPC_GlobalDataChangeEvent(ByVal groupName As String, ByVal listOfOpcObjects As System.Collections.Generic.List(Of IOpcObject)) Handles OPC.GlobalDataChangeEvent
        If groupName = SR.OPC_GROUP_GLOBAL_PARAMETER Then
            tssTotalSorted.Text = String.Format(SR.INFORMATION_TOTAL_SORTED, Pound_Sorted.Value, _bagsWashedAndSorted(0).Value)
            tssTotalWashed.Text = String.Format(SR.INFORMATION_TOTAL_WASHED, Pound_Washed.Value, _bagsWashedAndSorted(1).Value)
            tssAvailableDryers.Text = String.Format(SR.INFORMATION_DRYER, Available_Dryers.Value, CInt(Total_Dryers.Value), CDbl(Available_Dryers.Value / CInt(Total_Dryers.Value)))
            tssAvailableWashers.Text = String.Format(SR.INFORMATION_WASHER, Available_Washers.Value, CInt(Total_Washers.Value))
            tssCleanStorageBags.Text = String.Format(SR.INFORMATION_NUMBER_OF_CLEAN_BAG, Cleanwork_Total_Number_Of_Bags.Value, Cleanwork_Total_Number_Of_Bags.Value / CLEANWORK_STORAGE_CAPACITY)
            tssClassifiedStorageBags.Text = String.Format(SR.INFORMATION_NUMBER_OF_CLASSIFIED_BAG, Classified_Total_Number_Of_Bags.Value, Classified_Total_Number_Of_Bags.Value / CLASSIFID_STORAGE_CAPACITY)
            tssDataSource.Text = BllRailInfoProvider.Instance.InformationSource.ToString
        End If
    End Sub

    ''' <summary>
    ''' Each workstation has its own requirements. This is to make sure that those requirements are met before giving
    ''' rights to the end user to perform action.
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnCheckedAccessRight(sender As Object, e As IRailAccessRightEventArgs)
        'Make sure the coaches' PC is not allowed to perform changes
        If Not CONFIGURATION.WorkStation.IsTsaControlWorkStation Then
            e.HasRight = False
            e.Message = String.Format(SR.WARNING_NO_RIGHT_PERFORM_ACTION_AT_WORKSTATION, System.Enum.GetName(GetType(WorkStations), CONFIGURATION.WorkStation))
        End If
    End Sub

    Private Sub tssActiveAlarms_MouseHover(sender As System.Object, e As System.EventArgs) Handles tssActiveAlarms.MouseHover
        If Not CONFIGURATION.IsFailOverMode Then Me.ShowToolTip(Cursor.Position, String.Format(SR.ALARM_UPDATE_IN_SECOND, AlarmBroadcaster.NextUpdateTime.Subtract(Now).TotalSeconds))
    End Sub

    Private Sub tssNumberOfFWTFLogin_MouseEnter(sender As Object, e As System.EventArgs)
        If Not CONFIGURATION.IsFailOverMode Then ShowToolTip(Cursor.Position, String.Format("Update productivity in {0:F2} seconds", ProductivityBroadcaster.NextUpdateTime.Subtract(Now).TotalSeconds))
    End Sub

    Private Sub frmMain_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
        If e.PropertyName = "ShiftTimeString" Then InvokeIfNeeded(Sub() tsslShift.Text = ShiftTimeString)
    End Sub


#Region "Workflow System"

    Private Sub RunAutoCallOff()
        Dim args As New LintRoleAccessRightEventArgs(LintSecurityProvider.GetTsaRolesToRunWorkflowCalculation, Not LintSecurityProvider.ENABLE_SECURITY)
        Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Factory.Security.CheckRoleAccessRights(card, args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            TryAction(AddressOf _workflowWcfClient.Service.RunWorkflowCalculation)
        Else
            MsgBox(SR.WARNING_NO_RIGHT_RUNNING_AUTO_CALL_OFF)
        End If
    End Sub

    Private Sub tsbtnAutoCallOff_MouseEnter(sender As Object, e As System.EventArgs) Handles tsbtnAutoCallOff.MouseEnter
        TryAction(Sub() InvokeIfNeeded(Sub() tsbtnAutoCallOff.ToolTipText = String.Format(SR.WORKFLOW_NEXT_CALL_OFF_RUN_TIME, _workflowWcfClient.Service.GetNextWorkflowCalculationRunTime.ToShortTimeString)))
    End Sub

    Private Sub SetAutoCallOffControls(ByVal isEnabled As Boolean)
        If tsbtnAutoCallOff.Enabled <> isEnabled Then tsbtnAutoCallOff.Enabled = isEnabled
        If Not isEnabled Then tsbtnAutoCallOff.ToolTipText = SR.WORKFLOW_NOT_RUNNING
        If WorkflowSystemToolStripMenuItem.Enabled <> isEnabled Then WorkflowSystemToolStripMenuItem.Enabled = isEnabled
    End Sub

    Private Sub _workflowWcfClient_ConnectStatusChanged(sender As Object, e As System.EventArgs) Handles _workflowWcfClient.ConnectStatusChanged
        InvokeIfNeeded(AddressOf SetAutoCallOffControls, _workflowWcfClient.IsConnected)
    End Sub

    Private Sub _workflowWcfClient_WorkflowCalculationCompleted(sender As Object, e As System.EventArgs) Handles _workflowWcfClient.WorkflowCalculationCompleted
        InvokeIfNeeded(Sub()
                           MsgBox(SR.WORKFLOW_CALCULATION_COMPLETED)
                           SetAutoCallOffControls(True)
                       End Sub)
    End Sub

    Private Sub _workflowWcfClient_WorkflowCalculationStarted(sender As Object, e As System.EventArgs) Handles _workflowWcfClient.WorkflowCalculationStarted
        InvokeIfNeeded(Sub()
                           MsgBox(SR.WORKFLOW_CALCULATION_STARTED)
                           SetAutoCallOffControls(False)
                       End Sub)
    End Sub

    Private Sub _workflowWcfClient_WorkflowLastCalculationHistory(sender As Object, e As WorkflowEventArgs(Of TsaWorkflowEngine)) Handles _workflowWcfClient.WorkflowLastCalculationHistory

    End Sub

    Private Sub _workflowWcfClient_WorkflowNextCalculationTimeUpdate(sender As Object, e As WorkflowEventArgs(Of Date)) Handles _workflowWcfClient.WorkflowNextCalculationTimeUpdate
        TryAction(Sub() InvokeIfNeeded(Sub() tsbtnAutoCallOff.ToolTipText = String.Format(SR.WORKFLOW_NEXT_CALL_OFF_RUN_TIME, _workflowWcfClient.Service.GetNextWorkflowCalculationRunTime.ToShortTimeString)))
    End Sub

    Private Sub StartWorkflowService()
        If Not CONFIGURATION.IsFailOverMode AndAlso _workflowEnable Then
            Dim setting As LintServiceSetting = Factory.Services.GetServiceSettings(LintServiceType.TSA_WORKFLOW)
            _workflowWcfClient = New WcfTsaWorkflowClient(setting)
        End If
    End Sub

#End Region

    Private Async Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Await GetUpdates()

        SetDefaultDisplay()
    End Sub

    Private Sub SetDefaultDisplay()
        Using frm As New frmDisplayConfig
            Dim displayConfig As DisplayConfigFile = frm.DisplayConfigFile
            _displayConfigFile = DisplayConfigManager.Instance.ConfigFile

            msMain.Visible = _displayConfigFile.ShowToolBar

            If _displayConfigFile.MainFormIsFullScreen Then
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
            End If


            Select Case displayConfig.DefaultForm
                'Case FormType.TSA_CLASSIFIED_LOADING
                '    SetStaticScreen(Of frmClassifiedLoadingPlatform)()
                'Case FormType.TSA_CLASSIFIED_STORAGE
                '    SetStaticScreen(Of frmClassifiedStorage)()
                'Case FormType.TSA_CLASSIFIED_DISCHARGERS
                '    SetStaticScreen(Of frmClassifiedDischarger)()
                Case FormType.TSA_WASHDECK
                    SetStaticScreen(Of frmTunnelInterface)()
                Case FormType.TSA_CLEANWORK_RAIL
                    'SetStaticScreen(Of frmCleanwork)()
                Case FormType.TSA_CLEANWORK_PRODUCTIVITY
                    'SetStaticScreen(Of frmCleanworkProductivity)()
            End Select
        End Using
    End Sub

    Private Async Sub UpdateCompleted(sender As Object, e As AppUpdateEventArgs)
        If e.AppUpdateFinished = True Then
            My.Application.SetSingleInstance(False)

            TryUserAction(Sub()
                              _update.RestartApp()
                          End Sub)

            Application.Exit()
        End If
    End Sub

    Private Sub tssVersion_DoubleClick(sender As Object, e As System.EventArgs) Handles tssVersion.Click
        If (IsAltPressed()) Then
            Dim args As New LintRoleAccessRightEventArgs(LintUserType.SYSTEM_ADMINISTRATOR, CONFIGURATION.Plant)
            Dim card As RfidCard = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
            Factory.Security.CheckRoleAccessRights(card, args)
            If args.CancelAction Then Exit Sub
            If args.HasRight Then
                _update.ModifyStartupFolderShortcut()
            Else
                MsgBox(args.Message)
            End If
        End If
    End Sub
#End Region

#Region "Constructors"

    Public Sub New()
        MyBase.New(Plant.TSA, LintApplicationId.TSA_RAIL_SYSTEM)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DoubleBuffered = True
        SetupMenuItems(UserManagementToolStripMenuItem,
                       ChatToolStripMenuItem,
                       CategorySetupToolStripMenuItem,
                       ReportsToolStripMenuItem,
                       AlarmViewerToolStripMenuItem,
                       OperatorLogToolStripMenuItem,
                       tssProgramMode,
                       CtrlLINTChatToolStripIndicator1)

        AddHandler _update.UpdateCompleted, AddressOf UpdateCompleted
    End Sub
#End Region

End Class
