Imports Wdw_Sust.Core.Configurations

Namespace Configurations
    Public Class SortingDisplayClientConfigurationManager
        Inherits SingletonConfigurationManager(Of SortingDisplayClientConfigurationManager, SortingDisplayClientConfigFile)
        Protected Overrides Function GetDefaultSettings() As SortingDisplayClientConfigFile
            Return New SortingDisplayClientConfigFile With
                {
                    .ClientDetail = New LintClientWorkStationDetail With
                    {
                        .WorkStationName = My.Computer.Name,
                        .WorkStation = WorkStations.NSA_HOPPER_DISPLAY_13_16
                    },
                    .ServicePortNumber = 12345,
                    .ServerUrl = "192.168.1.200"
                }
        End Function
    End Class
End Namespace
