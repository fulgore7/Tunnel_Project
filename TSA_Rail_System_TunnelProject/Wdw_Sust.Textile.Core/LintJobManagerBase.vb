Imports Wdw_Sust.Core
Imports Wdw_Sust.Textile.Core.Configurations

<Serializable()>
Public MustInherit Class LintJobManagerBase
    Inherits NotifyableBase

    Protected ReadOnly Property JobManager As LintJobProvider
        Get
            Return LintJobProvider.Instance
        End Get
    End Property
    Protected ReadOnly Property Configuration As LintApplicationConfigurationManager
        Get
            Return LintApplicationConfigurationManager.Instance
        End Get
    End Property
    Protected ReadOnly Property Db_Configuration As TextileDbConfigManager
        Get
            Return TextileDbConfigManager.Instance
        End Get
    End Property
End Class

