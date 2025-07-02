Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Interfaces

Namespace Configurations
    <Serializable>
    Public Class PlcTopicNameConfigFile
        Inherits ConfigurationFileBase(Of PlcTopicNameConfigFile)
        Implements IConfigurationFile
        Public Property NsaMainPlc As String
        Public Property TsaAquamizerPlc As String
        Public Property TsaProductivityPlc As String
        Public Property TsaProductivity2Plc As String
        Public Property TsaClassifiedPlc As String
        Public Property TsaCleanworkPlc As String
        Public Property TsaGatewayPlc As String
        Public Property NsaProductivityPlc As String
        Public Property AsaMainPlc As String
        Public Property NsaSteamTunnelPlc As String
        Public Property WarehousePlc As String
    End Class
End Namespace