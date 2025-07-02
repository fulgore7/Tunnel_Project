Imports Wdw_Sust.Core.Configurations

Namespace Configurations
    Public Class ApplicationConfigManager
        Inherits SingletonConfigurationManager(Of ApplicationConfigManager, ApplicationConfigFile)
        Protected Overrides Function GetDefaultSettings() As ApplicationConfigFile
            Return New ApplicationConfigFile With
                {
                    .ApplicationId = LintApplicationId.UNKNOWN,
                    .ApplicationMode = Wdw_Sust.Core.Enums.ProgramMode.UNKNOWN,
                    .Plant = Plant.UNKNOWN
                }
        End Function
    End Class
End Namespace