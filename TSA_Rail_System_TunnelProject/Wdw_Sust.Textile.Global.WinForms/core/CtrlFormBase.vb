Imports System.Threading
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.WinForms.Native.NativeMethods
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Core.Timer
Imports Wdw_Sust.Core.Job.EventArgs
Imports Wdw_Sust.Core.Job
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Logging

Namespace Wdw_Sust.Textile.Global.WinForms.Core
    Public Class CtrlFormBase
        Implements IInformationSubscriber(Of LintApplicationManagerEventArgs)

#Region "Fields"

        Private _parentForm As Form
        Private _isDragging As Boolean
        Private ReadOnly _syncContext As SynchronizationContext
        Private WithEvents _timeoutManager As TimeoutManager
        Private _listOfJobNames As List(Of String)
        Private _factory As ILintFactoryProvider
        Private _configPath

        Protected BaseToolTip As New ToolTip

        Private Shared JobManager As LintJobProvider = LintJobProvider.Instance
        Private Shared ConfigurationManager As LintApplicationConfigurationManager = LintApplicationConfigurationManager.Instance
        Protected Shared Db_Configuration As TextileDbConfigManager = TextileDbConfigManager.Instance
        Protected Shared ApplicationManager As LintApplicationManager
        Private _splunkLogger As SplunkLogManager = SplunkLogManager.Instance

#End Region

#Region "Events"
        Public Event _JobProcessed As EventHandler(Of JobEventArgs)
#End Region

#Region "Properties"
        Public Property ParentBroadcaster As IInformationBroadcaster Implements IInformationSubscriber.ParentBroadcaster

        Protected ReadOnly Property CONFIGURATION As LintApplicationConfigFile
            Get
                If ConfigurationManager Is Nothing Then Throw New InvalidOperationException("Configuration is not defined!")
                Return ConfigurationManager.ConfigFile
            End Get
        End Property

        Protected ReadOnly Property Factory As ILintFactoryProvider
            Get
                If _factory Is Nothing Then
                    _factory = OnCreateFactoryObject()
                End If
                Return _factory
            End Get
        End Property

        <Category("Custom Object Properties"), Description("To identify the name of the subscriber to subscribe to application change events"), Browsable(False)>
        Public Property SubscriberName As String Implements IInformationSubscriber(Of LintApplicationManagerEventArgs).SubscriberName
            Get
                Return Me.GetType().ToString
            End Get
            Private Set(value As String)
                'Doing nothing
            End Set
        End Property

        <Category("Custom Object Properties"), Description("To enable timeout so it will be closed automatically after a present value. Default is 300 seconds")>
        Public Property EnableTimeout As Boolean

        <Category("Custom Object Properties"), Description("To configure the form to be detachable from the MDI parent or not.")>
        Public Property IsDetachable As Boolean = True

        ''' <summary>
        ''' To determine if the form can be exited out by clicking 'X' to exit the form. Setting this property during runtime will not have effect.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <Category("Custom Object Properties"), Description("To determine if the form can be exited out by clicking 'X' to exit the form. Setting this property during runtime will not have effect.")>
        Public Property IsFormClosable() As Boolean = True

        <Category("Custom Object Properties"), Description("To configure how long it takes to time out. Default is 5 minutes")>
        Public Property TimeoutInSeconds As Integer = 300 '5 minutes

        ' <Category("Custom Object Properties"), Description("To enable application change detection")> _
        '    Public Property EnableApplicationChangeDetection As Boolean '5 minutes

        ''' <summary>
        ''' To enable / disable the red X button on the top right of the form
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                If IsFormClosable Then
                    Return MyBase.CreateParams
                Else
                    Dim cp As CreateParams = MyBase.CreateParams
                    Const CS_NOCLOSE As Integer = &H200
                    cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
                    Return cp
                End If
            End Get
        End Property

        <Browsable(False)>
        Public Overridable ReadOnly Property IsDragging() As Boolean
            Get
                Return _isDragging
            End Get
        End Property

        <Browsable(False)>
        Public ReadOnly Property SyncContext() As SynchronizationContext
            Get
                Return _syncContext
            End Get
        End Property

        <Browsable(False)>
        Protected ReadOnly Property PreviousApplicationMode As ProgramMode
            Get
                If ApplicationManager IsNot Nothing Then
                    Return ApplicationManager.PreviousApplicationMode
                Else
                    Return CONFIGURATION.ApplicationMode
                End If
            End Get
        End Property

        Private ReadOnly Property ListOfJobNames As List(Of String)
            Get
                If _listOfJobNames Is Nothing Then _listOfJobNames = New List(Of String)
                Return _listOfJobNames
            End Get
        End Property

#End Region

#Region "Methods"

#Region "Dragging"

        Private Sub StartDrag()
            AddHandler MouseMove, AddressOf CtrlFormBase_MouseMove
            Me._isDragging = True
        End Sub

        Private Sub StopDrag()
            RemoveHandler MouseMove, AddressOf CtrlFormBase_MouseMove
            Me._isDragging = False
        End Sub

        ''' <summary>
        ''' Use native code here to intercept Windows messages
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub CtrlFormBase_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If IsDragging Then
                Capture = False
                ' Create and send a WM_NCLBUTTONDOWN message.
                Dim msg As Message = Message.Create(Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
                DefWndProc(msg)
            End If
        End Sub

        Private Sub CtrlFormBase_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
            StopDrag()
        End Sub

        Private Sub CtrlFormBase_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            StopDrag()
        End Sub
#End Region

#Region "Job Related Methods"

        Private Sub JOB_MANAGER_JobProcessed(sender As Object, e As JobEventArgs)
            RaiseEvent _JobProcessed(Me, e)
        End Sub

        Protected Function ContainsJob(ByVal jobName As String) As Boolean
            Return JobManager.ContainsJob(jobName)
        End Function

        Protected Function AddJob(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal act As Action, Optional ByVal runImmediately As Boolean = True) As Boolean
            Dim job As New TimeSpanJobDetail(jobName, frequency, act, True)
            Return AddJob(job, runImmediately)
        End Function

        Protected Function AddJob(ByVal job As IJobDetail, Optional ByVal runImmediately As Boolean = True) As Boolean
            Dim isSuccessful As Boolean = JobManager.AddJob(job, runImmediately)
            If isSuccessful Then ListOfJobNames.Add(job.JobName)
            Return isSuccessful
        End Function

        Protected Function RemoveJob(ByVal jobName As String) As Boolean
            Dim isSuccessful As Boolean = JobManager.RemoveJob(jobName)
            If isSuccessful Then ListOfJobNames.Remove(jobName)
            Return isSuccessful
        End Function

        Protected Overrides Sub OnClosing(e As CancelEventArgs)
            If TypeOf Me Is IConfigurator Then
                If ConfigurationManager.IsConfigFileADefault Then
                    ConfigurationManager.Save()
                End If
            End If
        End Sub

        Protected Function ChangeJobStatusIfDefined(ByVal jobName As String, ByVal enableJob As Boolean) As Boolean
            Dim job As IJobDetail = JobManager.GetJob(jobName)
            If job IsNot Nothing Then
                If job.IsEnabled <> enableJob Then
                    job.IsEnabled = enableJob
                    If job.IsEnabled Then job.ExecuteJob()
                End If
            End If
            Return job IsNot Nothing
        End Function

        Protected Sub ChangeJobStatusIfDefined(ByVal enableJob As Boolean, ParamArray jobNames As String())
            For Each job As String In jobNames
                ChangeJobStatusIfDefined(job, enableJob)
            Next
        End Sub

        Protected Sub RemoveJobs(ByVal ParamArray jobName() As String)
            For i As Integer = 0 To jobName.Count - 1
                JobManager.RemoveJob(jobName(i))
            Next
        End Sub

        ''' <summary>
        ''' Gets the job counts.
        ''' </summary>
        ''' <returns>System.Int32.</returns>
        Public Function GetJobCounts() As Integer
            Return JobManager.JobCounts
        End Function

        ''' <summary>
        ''' Gets the job names.
        ''' </summary>
        ''' <returns>List(Of System.String).</returns>
        Public Function GetJobNames() As List(Of String)
            Return JobManager.GetJobNames
        End Function

        ''' <summary>
        ''' Gets the application mode subscriber names.
        ''' </summary>
        ''' <returns>List(Of System.String).</returns>
        Public Function GetApplicationModeSubscriberNames() As List(Of String)
            Return ApplicationManager.GetSubscriberNames()
        End Function

        ''' <summary>
        ''' Define an action that is only needed to run once when the test condition 
        ''' to become true the very first timeoutInSeconds
        ''' </summary>
        ''' <param name="jobName">A Unique name of the job to add</param>
        ''' <param name="frequency">How frequent this job needs to run</param>
        ''' <param name="testCondition">Condition to be tested</param>
        ''' <param name="actionWhenTrue">Action to do when the condition first becomes true</param>
        ''' <param name="actionWhenFalse">Optional action to do when the condition is false. This will run every time the condition is false</param>
        ''' <param name="runImmediately">Set if the job should run immediately</param>
        ''' <returns>Return a boolean to tell if the job was added successfully</returns>
        Protected Function DoOnceAtFirstTrueResult(jobName As String, frequency As TimeSpan, testCondition As Func(Of Boolean), actionWhenTrue As Action, Optional actionWhenFalse As Action = Nothing, Optional runImmediately As Boolean = True) As Boolean
            Return JobManager.DoOnceAtFirstTrueResult(jobName, frequency, testCondition, actionWhenTrue, actionWhenFalse, runImmediately)
        End Function

        ''' <summary>
        ''' This is the opposite of the function <code>DoOnceAtFirstTrueResult</code> please see
        ''' <code>DoOnceAtFirstTrueResult</code> for detail.
        ''' </summary>
        Protected Sub DoUntilFirstFalseResult(jobName As String, frequency As TimeSpan, testCondition As Func(Of Boolean), actionWhenFalse As Action, Optional actionWhenTrue As Action = Nothing, Optional runImmediately As Boolean = True)
            JobManager.ContinueUntilFirstFalseResult(jobName, frequency, testCondition, actionWhenFalse, actionWhenTrue)
        End Sub

#End Region

        Protected Overridable Function OnCreateFactoryObject() As ILintFactoryProvider
            'Throw New Exception("This is needed to override to provide the proper factory object for different facility")
            Dim factory As ILintFactoryProvider = LintFactoryProvider.Instance
            factory.ConnectionString = Db_Configuration.LintInUseConnectionString
            Return factory
        End Function

        ''' <summary>
        ''' Subscribes the application change information. If the object is also a form, the system will
        ''' also remove the form object from the ApplicationManager to prevent memory leak
        ''' </summary>
        ''' <param name="config">The configuration.</param>
        Private Sub SubscribeApplicationChangeInfo(ByVal config As LintFormConfiguration)
            If ApplicationManager IsNot Nothing Then
                For Each subscriber As IInformationSubscriber In config.ApplicationModeSubscribers
                    Dim obj As Form = TryCast(subscriber, Form)
                    If obj IsNot Nothing Then
                        AddHandler FormClosing, Sub(a, b) ApplicationManager.RemoveSubscriber(obj)
                    End If
                    ApplicationManager.AddSubscriber(subscriber)
                Next
            End If
        End Sub

        ''' <summary>
        ''' Processes the subscribed information.
        ''' </summary>
        ''' <param name="args">The <see cref="LintApplicationManagerEventArgs"/> instance containing the event data.</param>
        Private Sub ProcessSubscribedInformation(args As LintApplicationManagerEventArgs) Implements IInformationSubscriber(Of LintApplicationManagerEventArgs).ProcessSubscribedInformation
            Dim arg As LintApplicationManagerEventArgs = TryCast(args, LintApplicationManagerEventArgs)
            If arg IsNot Nothing Then
                If arg.IsChatSevicesChanged Then
                    InvokeIfNeeded(AddressOf ChatServiceEnableChanged)
                ElseIf arg.IsApplicationModeChanged Then
                    InvokeIfNeeded(AddressOf ApplicationModeChanged)
                ElseIf arg.IsEnableLoggingChanged Then
                    InvokeIfNeeded(AddressOf LoggingEnableChanged)
                ElseIf arg.IsInUseLintConnectionChanged Then
                    InvokeIfNeeded(AddressOf LintInUseConnectionStringChanged)
                ElseIf arg.IsWorkstationChanged Then
                    InvokeIfNeeded(AddressOf WorkStationChanged)
                End If
            End If
        End Sub

        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            MyBase.OnFormClosed(e)
            GC.Collect()
        End Sub

        Private Sub _timeoutManager_TimeoutEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles _timeoutManager.TimeoutEvent
            InvokeIfNeeded(AddressOf Close)
        End Sub

        Private Sub CtrlFormBase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
            If EnableTimeout Then _timeoutManager.StopTimer()
        End Sub

        Private Sub CtrlFormBase_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
            If EnableTimeout Then _timeoutManager.StartTimer()
        End Sub

        Private Sub CtrlFormBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyClass.Load
            If Not DesignMode Then
                AddHandler JobManager.JobProcessed, AddressOf JOB_MANAGER_JobProcessed
                If IsMdiChild Then _parentForm = MdiParent
                If Not DesignMode AndAlso EnableTimeout Then _timeoutManager = New TimeoutManager(TimeoutInSeconds, True)
                OnInitialize(New LintFormConfiguration)
                If TypeOf Me Is CtrlMdiFormBase Then
                    ApplicationModeChanged()
                    WorkStationChanged()
                    ChatServiceEnableChanged()
                End If
            End If
        End Sub

        ''' <summary>
        ''' This is where the initailization logic for the form
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub Initialize()
        End Sub

        ''' <summary>
        ''' This is used to subscribe to different settings from the base form, espeically to the application manager to listen
        ''' to the application mode changes
        ''' </summary>
        ''' <param name="config"></param>
        Protected Overridable Sub OnInitialize(ByVal config As LintFormConfiguration)
            Icon = CONFIGURATION.ApplicationId.GetApplicationIcon()
            If config.IsInitializedSuccessfully Or True Then
                If config.SelfSubscribe AndAlso config.ApplicationModeSubscribers.ToList.Find(Function(a) ReferenceEquals(a, Me)) Is Nothing Then
                    config.ApplicationModeSubscribers.Add(Me)
                End If
                SubscribeApplicationChangeInfo(config)
                config.ApplicationModeSubscribers.Clear()
                config = Nothing
                InvokeIfNeeded(AddressOf Initialize)
            End If
        End Sub

        Protected Overridable Sub OnStoppingForm()

        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            If _timeoutManager IsNot Nothing AndAlso _timeoutManager.IsActive Then _timeoutManager.StopTimer()
            If _listOfJobNames IsNot Nothing Then If _listOfJobNames.Count > 0 Then _listOfJobNames.ForEach(Sub(a) JobManager.RemoveJob(a))
            RemoveHandler JobManager.JobProcessed, AddressOf JOB_MANAGER_JobProcessed
            EnableTimeout = False
            MyBase.OnFormClosing(e)
        End Sub

        Private Sub CtrlFormBase_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
            If IsDetachable Then
                SuspendLayout()
                If IsMdiChild Then
                    MdiParent = Nothing
                Else
                    MdiParent = _parentForm
                End If
                ResumeLayout(False)
            End If
        End Sub

        Private Sub CtrlFormBase_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
            If Not IsDragging Then StartDrag()
        End Sub

        'Protected Sub SubscribeTimerTickEvent(ByVal e As TimeoutManager.TimerTickEventHandler)
        '    If _timeoutmanager IsNot Nothing Then AddHandler _timeoutmanager.TimerTick, e
        'End Sub

        Protected Sub ShowToolTip(ByVal p As Point, ByVal msg As String, Optional ByVal durationInMilliSeconds As Integer = 2000)
            BaseToolTip.Show(msg, Me, p, durationInMilliSeconds)
        End Sub

        Protected Sub HideToolTip()
            BaseToolTip.Hide(Me)
        End Sub

        ''' <summary>
        ''' Will call when the database connection string is changed
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub LintInUseConnectionStringChanged()

        End Sub

        ''' <summary>
        ''' Will call when the application mode is changed
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub ApplicationModeChanged()

        End Sub

        ''' <summary>
        ''' Will call when the workstation mode is changed
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub WorkStationChanged()

        End Sub

        ''' <summary>
        ''' Will call when the chat function is changed
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub ChatServiceEnableChanged()

        End Sub

        ''' <summary>
        ''' Will call when the logging function is changed
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub LoggingEnableChanged()

        End Sub

        Private Sub StartApp()
            ApplicationManager = LintApplicationManager.Instance
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            UpdateStyles()

            If CONFIGURATION.SendHeartbeat Then
                JobManager.AddJob("app-heartbeat", TimeSpan.FromMinutes(5), AddressOf SendHeartbeat, runImmediately:=True)
            End If
        End Sub

        Private Sub SendHeartbeat()
            _splunkLogger.SendHeartbeat()
        End Sub

        Private Sub InitConfig(Optional ByVal configPath As String = "")
            If configPath = "" Then
                _configPath = GetConfigFilePath(IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))
            Else
                _configPath = configPath
            End If
            InitializeComponent()
            Db_Configuration.ConfigurationDirectory = _configPath
            ConfigurationManager.ConfigurationDirectory = _configPath
        End Sub

        Public Sub PostSyncCallback(ByVal act As Action)
            Wdw_Sust.Logging.LoggingManager.TryUserAction(Sub()
                                                              SyncContext.Post(New SendOrPostCallback(Sub() act()), Nothing)
                                                          End Sub)
        End Sub
#End Region

#Region "Contructors"

        Public Sub New(configPath As String)
            InitConfig(configPath)
            StartApp()
            _syncContext = SynchronizationContext.Current
        End Sub

        Public Sub New(configPath As String, ByVal plant As Plant, ByVal appId As LintApplicationId)
            InitConfig(configPath)

            CONFIGURATION.ApplicationId = appId
            CONFIGURATION.Plant = plant

            StartApp()
        End Sub

        Public Sub New(ByVal plant As Plant, ByVal appId As LintApplicationId)
            InitConfig()

            CONFIGURATION.ApplicationId = appId
            CONFIGURATION.Plant = plant

            StartApp()
        End Sub

        Public Sub New()
            InitializeComponent()
            StartApp()
            _syncContext = SynchronizationContext.Current
        End Sub

        Public Sub New(factory As ILintFactoryProvider)
            InitializeComponent()
            _factory = factory
        End Sub
#End Region

    End Class
End Namespace