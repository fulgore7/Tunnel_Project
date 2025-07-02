Imports Wdw_Sust.Textile.Global.Wcf.Interfaces

Namespace Interfaces
    Public Interface IWcfTsaFactoryProvider
        ReadOnly Property Alarm As IWcfLintAlarmServiceClient
        ReadOnly Property Team As IWcfTsaTeamServiceClient
        ReadOnly Property Rail As IWcfTsaRailInfoServiceClient
    End Interface
End Namespace