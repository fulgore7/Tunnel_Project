Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Configurations
Imports Wdw_Sust.Core.Enums

Namespace Configurations

    ''' <summary>
    ''' Class LintApplicationConfigurationManager. This is the main configuration class for all 
    ''' LINT program to configure the application with proper parameters.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Configurations.EditableSingletonConfigurationManager(Of Wdw_Sust.Textile.Core.Configurations.LintApplicationConfigurationManager, Wdw_Sust.Textile.Core.Configurations.LintApplicationConfigFile)" />
    <Serializable>
    Public Class LintApplicationConfigurationManager
        Inherits EditableSingletonConfigurationManager(Of LintApplicationConfigurationManager, LintApplicationConfigFile)

        Protected Overrides Function GetDefaultSettings() As LintApplicationConfigFile
            Return New LintApplicationConfigFile With
            {
                .ApplicationId = LintApplicationId.UNKNOWN,
                .Plant = Plant.UNKNOWN,
                .ApplicationMode = ProgramMode.PRODUCTION,
                .BagDrawingMode = BagDrawingMode.TWO_DIMENSION,
                .IsRemoteLinxUsed = False,
                .RemoteLinxAddress = String.Empty,
                .IsLoggingEnabled = True,
                .IsHidInterfaceUsed = False,
                .IsChatServiceEnabled = False,
                .SendHeartbeat = False,
                .PlcTopics = New PlcTopicNameConfigFile With
                {
                    .AsaMainPlc = "ASA_Main",
                    .NsaMainPlc = "NSA_Main",
                    .NsaProductivityPlc = "NSA_Prod",
                    .NsaSteamTunnelPlc = "Ducker_ST4_Tunnel",
                    .TsaAquamizerPlc = "TSA_Aquamizer",
                    .TsaClassifiedPlc = "TSA_Futurail_Classified",
                    .TsaCleanworkPlc = "TSA_Futurail_Cleanwork",
                    .TsaGatewayPlc = "TSA_Gateway_Master",
                    .TsaProductivityPlc = "TSA_Productivity",
                    .TsaProductivity2Plc = "TSA_Productivity_2",
                    .WarehousePlc = "DC2_WCS_Main_PLC"
                },
                .SecuraKeyComportSettings = New ComPortSetting With
                {
                    .BaudRate = 38400,
                    .ComPortName = "COM4"
                }
            }
        End Function

        Public Overrides Function IsConfiguredProperly() As Boolean
            Return ConfigFile.IsValid
        End Function

    End Class
End Namespace
