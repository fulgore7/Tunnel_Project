Imports Wdw_Sust.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.Wcf
Imports Wdw_Sust.Textile.Global.Wcf.Interfaces
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

Public Class WcfTsaFactoryProvider
    Inherits ProviderBase(Of WcfTsaFactoryProvider)
    Implements IWcfTsaFactoryProvider

    Public ReadOnly Property Alarm As IWcfLintAlarmServiceClient Implements IWcfTsaFactoryProvider.Alarm
        Get
            Return New WcfLintAlarmServiceClient(WcfBindingType.Tcp)
        End Get
    End Property

    Public ReadOnly Property Rail As IWcfTsaRailInfoServiceClient Implements IWcfTsaFactoryProvider.Rail
        Get
            Return New WcfTsaRailInfoServiceClient(WcfBindingType.Tcp, LintServiceType.WCF_LINT_RAIL_INFO_7851)
        End Get
    End Property

    Public ReadOnly Property Team As IWcfTsaTeamServiceClient Implements IWcfTsaFactoryProvider.Team
        Get
            Return New WcfTsaTeamServiceClient(WcfBindingType.Tcp)
        End Get
    End Property
End Class