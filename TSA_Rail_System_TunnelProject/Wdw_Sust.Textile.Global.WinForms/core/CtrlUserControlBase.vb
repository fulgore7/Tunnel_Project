Imports System.Drawing
Imports System.Threading
Imports System.Threading.Tasks
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Core.Interfaces

Namespace Wdw_Sust.Textile.Global.WinForms.Core
    Public Class CtrlUserControlBase

#Region "Fields"
        Protected ConfigMan As LintApplicationConfigurationManager = LintApplicationConfigurationManager.Instance
        Protected CONFIGURATION As LintApplicationConfigFile = ConfigMan.ConfigFile
        Protected DB_CONFIGURATION As TextileDbConfigManager = TextileDbConfigManager.Instance
        Private Shared JobManager As LintJobProvider = LintJobProvider.Instance
        Protected Shared FLASH_SIGNAL As Boolean
        Private _factory As ILintFactoryProvider
        Private _syncContext As SynchronizationContext

#End Region

#Region "Properities"
        Protected Property ToolTipText() As String

        Protected Property ToolTipTitle() As String
            Get
                Return ToolTip1.ToolTipTitle
            End Get
            Set(ByVal value As String)
                ToolTip1.ToolTipTitle = value
            End Set
        End Property

        Public ReadOnly Property SyncContext As SynchronizationContext
            Get
                Return _syncContext
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
#End Region

#Region "Methods"

        ''' <summary>
        ''' Called when the property Factory is being called but the field was not initialized yet.
        ''' By overriding this the form will use the concrete provider for database operations.
        ''' </summary>
        ''' <returns>ILintFactoryProvider.</returns>
        ''' <exception cref="System.Exception">This is needed to override to provide the proper factory object for different facility</exception>
        Protected Overridable Function OnCreateFactoryObject() As ILintFactoryProvider
            If Not DesignMode Then
                Throw New InvalidOperationException("This is needed to override to provide the proper factory object for different facility")
            End If
            Return Nothing
        End Function
        ''' <summary>
        ''' This sub is location in the base class
        ''' </summary>
        ''' <remarks>This sub is location in the base class</remarks>
        Protected Sub ShowToolTip()
            If ToolTipText <> String.Empty Then
                Dim p As Point = ParentForm.ClientRectangle.Location
                p.Offset(Width, Height)
                ToolTip1.Show(ToolTipText, Me, p)
            End If
        End Sub

        ''' <summary>
        ''' This sub is location in the base class
        ''' </summary>
        ''' <remarks>This sub is location in the base class</remarks>
        Protected Sub HideToolTip()
            ToolTip1.Hide(Me)
        End Sub


        ''' <summary>
        ''' Add job to the JobManager
        ''' </summary>
        ''' <param name="jobName">Name of the job. This needs to be unique in <c>JobManager</c></param>
        ''' <param name="frequency">How frequent the job needs to run</param>
        ''' <param name="act">Action of the job</param>
        ''' <param name="runImmediately">Configure if the job needs to run immediately</param>
        ''' <returns>Return a boolean if the job is added successfully</returns>
        ''' <remarks></remarks>
        Protected Function AddJob(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal act As Action, Optional ByVal runImmediately As Boolean = True) As Boolean
            Dim isAdded As Boolean
            If Not Me.IsDisposed Then
                isAdded = JobManager.AddJob(jobName:=jobName, act:=act, frequency:=frequency, runImmediately:=runImmediately)
                If isAdded Then
                    AddHandler Me.Disposed, Sub(a, b) JobManager.RemoveJob(jobName)
                End If
            End If
            'If isAdded Then AddHandler Me.Disposed, Sub(a, b) RemoveJob(jobName)
            Return isAdded
        End Function

        Protected Function AddJob(ByVal job As IJobDetail) As Boolean
            Dim isAdded As Boolean
            If Not Me.IsDisposed Then
                isAdded = JobManager.AddJob(job)
                If isAdded Then
                    AddHandler Me.Disposed, Sub(a, b) JobManager.RemoveJob(job.JobName)
                End If
            End If
            'If isAdded Then AddHandler Me.Disposed, Sub(a, b) RemoveJob(jobName)
            Return isAdded
        End Function

        Protected Function RemoveJob(ByVal jobName As String) As Boolean
            Dim isRemoved As Boolean
            If JobManager.ContainsJob(jobName) Then
                isRemoved = JobManager.RemoveJob(jobName)
            End If
            Return isRemoved
        End Function

        Protected Sub AddFlashEffect()
            If Not JobManager.ContainsJob("flash") Then JobManager.AddJob("flash", TimeSpan.FromSeconds(1), Sub() FLASH_SIGNAL = Not FLASH_SIGNAL)
        End Sub

        'Protected Sub RemoveFlashEffect()
        '    If JOB_MANAGER.ContainsJob("flash") Then JOB_MANAGER.RemoveJob("flash")
        'End Sub

        Public Sub PostSyncCallback(ByVal act As Action)
            Wdw_Sust.Logging.LoggingManager.TryUserAction(Sub()
                                                              SyncContext.Post(New SendOrPostCallback(Sub() act()), Nothing)
                                                          End Sub)
        End Sub

        Public Async Function PostSyncCallbackAsync(ByVal act As Action) As Task
            Await Task.Run(Sub() PostSyncCallback(act))
        End Function
#End Region

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

            _syncContext = SynchronizationContext.Current

        End Sub

    End Class
End Namespace

