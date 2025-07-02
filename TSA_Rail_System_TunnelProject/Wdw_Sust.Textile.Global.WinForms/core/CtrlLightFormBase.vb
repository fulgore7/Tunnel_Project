Imports System.Threading
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Dal
Namespace Wdw_Sust.Textile.Global.WinForms.Core

    Public Class CtrlLightFormBase

        Private _factory As ILintFactoryProvider

        Public Property SyncContext As SynchronizationContext
        Protected Shared Db_Configuration As TextileDbConfigManager = TextileDbConfigManager.Instance
        Protected ReadOnly Property Factory As ILintFactoryProvider
            Get
                If _factory Is Nothing Then
                    _factory = OnCreateFactoryObject()
                End If
                Return _factory
            End Get
        End Property

        Public Sub PostSyncCallback(ByVal act As Action)
            Wdw_Sust.Logging.LoggingManager.TryUserAction(Sub()
                                                              SyncContext.Post(New SendOrPostCallback(Sub() act()), Nothing)
                                                          End Sub)
        End Sub

        Protected Overridable Function OnCreateFactoryObject() As ILintFactoryProvider
            'Throw New Exception("This is needed to override to provide the proper factory object for different facility")
            Dim factory As ILintFactoryProvider = LintFactoryProvider.Instance
            factory.ConnectionString = Db_Configuration.LintInUseConnectionString
            Return factory
        End Function

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            SyncContext = SynchronizationContext.Current
        End Sub
    End Class
End Namespace