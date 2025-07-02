
Imports System.Collections.Generic
Imports Wdw_Sust.Core.Configurations
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Configurations

Public Class SortingDisplayServerConfigurationManager
    Inherits SingletonConfigurationManager(Of SortingDisplayServerConfigurationManager, SortingDisplayServerConfigFile)

    Protected Overrides Function GetDefaultSettings() As SortingDisplayServerConfigFile
        Dim clients As List(Of LintSortingDisplayClientDetail) = New List(Of LintSortingDisplayClientDetail)
        Dim appIds As Dictionary(Of LintApplicationId, WorkStations) = New Dictionary(Of LintApplicationId, WorkStations)

        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD01", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_01_02})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD02", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_03_04})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD03", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_05_06})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD04", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_07_08})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD05", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_09_10})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD06", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_11_12})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD07", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_13_14})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD08", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_15_16})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD09", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_17_18})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD10", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_19_20})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD11", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_21_22})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD12", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_23_24})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD13", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_25_26})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD14", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_27_28})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD15", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_29_30})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD16", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_31_32})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WDW-TS-TSA-SD17", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_33_34})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WX-CND7259NVV", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_09_10})
        clients.Add(New LintSortingDisplayClientDetail With {.WorkStationName = "WTSTEST01", .WorkStation = Wdw_Sust.Textile.Core.Enums.WorkStations.TSA_HOPPER_DISPLAY_09_10})

        appIds.Add(LintApplicationId.TSA_Sorting_1_2, WorkStations.TSA_HOPPER_DISPLAY_01_02)
        appIds.Add(LintApplicationId.TSA_Sorting_3_4, WorkStations.TSA_HOPPER_DISPLAY_03_04)
        appIds.Add(LintApplicationId.TSA_Sorting_5_6, WorkStations.TSA_HOPPER_DISPLAY_05_06)
        appIds.Add(LintApplicationId.TSA_Sorting_7_8, WorkStations.TSA_HOPPER_DISPLAY_07_08)
        appIds.Add(LintApplicationId.TSA_Sorting_9_10, WorkStations.TSA_HOPPER_DISPLAY_09_10)
        appIds.Add(LintApplicationId.TSA_Sorting_11_12, WorkStations.TSA_HOPPER_DISPLAY_11_12)
        appIds.Add(LintApplicationId.TSA_Sorting_13_14, WorkStations.TSA_HOPPER_DISPLAY_13_14)
        appIds.Add(LintApplicationId.TSA_Sorting_15_16, WorkStations.TSA_HOPPER_DISPLAY_15_16)
        appIds.Add(LintApplicationId.TSA_Sorting_17_18, WorkStations.TSA_HOPPER_DISPLAY_17_18)
        appIds.Add(LintApplicationId.TSA_Sorting_19_20, WorkStations.TSA_HOPPER_DISPLAY_19_20)
        appIds.Add(LintApplicationId.TSA_Sorting_21_22, WorkStations.TSA_HOPPER_DISPLAY_21_22)
        appIds.Add(LintApplicationId.TSA_Sorting_23_24, WorkStations.TSA_HOPPER_DISPLAY_23_24)
        appIds.Add(LintApplicationId.TSA_Sorting_25_26, WorkStations.TSA_HOPPER_DISPLAY_25_26)
        appIds.Add(LintApplicationId.TSA_Sorting_27_28, WorkStations.TSA_HOPPER_DISPLAY_27_28)
        appIds.Add(LintApplicationId.TSA_Sorting_29_30, WorkStations.TSA_HOPPER_DISPLAY_29_30)
        appIds.Add(LintApplicationId.TSA_Sorting_31_32, WorkStations.TSA_HOPPER_DISPLAY_31_32)
        appIds.Add(LintApplicationId.TSA_Sorting_33_34, WorkStations.TSA_HOPPER_DISPLAY_33_34)

        Return New SortingDisplayServerConfigFile() With
            {
                .ServicePortNumber = 19712,
                .ServerUrl = "fldcvpswa7850.wdw.disney.com",
                .PlcTopics = New PlcTopicNameConfigFile() With
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
                    .WarehousePlc = "DC2_WCS_Main_PLC"
                },
                .StationDisplayNameString = "WeightStationSortingDisplays[{0}]",
                .NumberOfWeightStations = 34,
                .PlcTopicName = "TSA_Futurail_Classified",
                .Clients = clients,
                .AppIds = appIds,
                .OpcRefresh = 2000
            }
    End Function
End Class

