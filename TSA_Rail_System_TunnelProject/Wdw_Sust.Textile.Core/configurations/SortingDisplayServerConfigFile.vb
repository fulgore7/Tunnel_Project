Imports System
Imports System.Collections.Generic

Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Configurations

<Serializable()>
Public Class SortingDisplayServerConfigFile
    Inherits ConfigurationFileBase(Of SortingDisplayServerConfigFile)
    Implements IConfigurationFile

    Public Property NumberOfWeightStations As Integer
    Public Property PlcTopicName As String
    Public Property StationDisplayNameString As String
    Public Property PlcTopics As PlcTopicNameConfigFile
    Public Property ServicePortNumber As Integer
    Public Property ServerUrl As String
    Public Property Clients As List(Of LintSortingDisplayClientDetail)
    Public Property AppIds As Dictionary(Of LintApplicationId, WorkStations)
    Public Property OpcRefresh As Integer

End Class