Imports System.ComponentModel
Imports System.Windows.Forms

Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.WinForms.Interfaces
Imports Wdw_Sust.Textile.Global.WinForms.ViewModels

Namespace Wdw_Sust.Textile.Global.WinForms.Core

    Public Class CtrlMainFormBase
        Inherits CtrlFormBase
        Implements ILintAppMainForm

#Region "Fields"
        Private _applicationId As LintApplicationId = LintApplicationId.UNKNOWN
        Private _isHealthMonitoringEnabled As Boolean
        Private _monitoringManager As ApplicationHealthMonitoringManager
        Private configPath As String
        'Private WithEvents _updateTimer As System.Timers.Timer
#End Region

#Region "Properties"

        ''' <summary>
        ''' Gets or sets the application identifier.
        ''' </summary>
        ''' <value>The application identifier.</value>
        <Category("Custom Object Properties"), Description("Enum declared in WDW_SUST.Textile.Lint.LintDefintions")>
        Public Property ApplicationId As LintApplicationId
            Get
                Return _applicationId
            End Get
            Set(ByVal value As LintApplicationId)
                _applicationId = value
                If _applicationId = LintApplicationId.UNKNOWN Then
                    IsHealthMonitoringEnabled = False
                End If
            End Set
        End Property

        Private ReadOnly Property MonitoringManager As ApplicationHealthMonitoringManager
            Get
                If _monitoringManager Is Nothing Then _monitoringManager = New ApplicationHealthMonitoringManager(New LintKeyValuePair(Of LintApplicationId, String)(ApplicationId, My.Computer.Name), Db_Configuration.LintProductionConnectionString)
                Return _monitoringManager
            End Get
        End Property

        ''' <summary>
        ''' If this is enabled, the application will update the timestamp in the database for
        ''' monitoring purposes.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks>
        ''' If this is enabled, the application will update the timestamp in the database for
        ''' monitoring purposes.
        ''' </remarks>
        <Category("Custom Object Properties")>
        Public Property IsHealthMonitoringEnabled As Boolean
            Get
                Return _isHealthMonitoringEnabled
            End Get
            Set(ByVal value As Boolean)
                If value AndAlso _applicationId = LintApplicationId.UNKNOWN Then
                    Throw New ArgumentException("You can only set this property to true if ApplicationID property is not UNKNOWN")
                ElseIf Not value Then
                    If Not DesignMode Then ChangeJobStatusIfDefined(Name, False)
                End If
                _isHealthMonitoringEnabled = value
            End Set
        End Property

#End Region

#Region "Methods"

        Protected Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
            If DesignMode Then
                MyBase.OnHandleCreated(e)
            Else
                OnApplicationStarted()
                If IsConfigurationConfigured() Then
                    MyBase.OnHandleCreated(e)
                Else
                    BeginInvoke(New MethodInvoker(AddressOf Close))
                End If
            End If
        End Sub

        Private Function IsConfigurationConfigured() As Boolean
            If Configuration.IsValid Then Return True
            If TypeOf Me IsNot IConfigurator Then
                Using frm As New CtrlLintAdminConsole(True, OnCreateLintAdminConsoleViewModel)
                    frm.ShowDialog()
                End Using
            End If
            Return Configuration.IsValid
        End Function

        Protected Overridable Function OnCreateLintAdminConsoleViewModel() As ICtrlLintAdminConsoleViewModel
            Return New CtrlLintAdminConsoleViewModelForRailGraphics
        End Function

        '''' <summary>
        '''' To allow derived class that can change the behavior when the application starts.
        '''' </summary>
        '''' <param name="e"></param>
        '''' <remarks></remarks>
        Protected Overridable Sub OnApplicationStarted()

        End Sub

        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            If _monitoringManager IsNot Nothing Then
                _monitoringManager.Unsubscribe()
                _monitoringManager = Nothing
            End If
            MyBase.OnFormClosed(e)
        End Sub

        Protected Overrides Sub OnInitialize(config As LintFormConfiguration)
            If Not DesignMode Then
                If IsHealthMonitoringEnabled And ApplicationId = LintApplicationId.UNKNOWN Then
                    Throw New ArgumentException("please set the application id on the property windows!!!")
                ElseIf IsHealthMonitoringEnabled Then ' andalso not configuration.isfailovermode then
                    AddJob(MonitoringManager)
                    config.ApplicationModeSubscribers.Add(MonitoringManager)
                End If
            End If
            MyBase.OnInitialize(config)
        End Sub
#End Region

#Region "Constructors"
        Public Sub New(configPath As String)
            MyBase.New(configPath)
            InitializeComponent()
        End Sub

        Public Sub New(configPath As String, ByVal plant As Plant, ByVal appId As LintApplicationId)
            MyBase.New(configPath, plant, appId)
            InitializeComponent()
        End Sub

        Public Sub New(ByVal plant As Plant, ByVal appId As LintApplicationId)
            MyBase.New(plant, appId)
            InitializeComponent()
        End Sub

        Public Sub New()
            MyBase.New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub
#End Region
    End Class

End Namespace
