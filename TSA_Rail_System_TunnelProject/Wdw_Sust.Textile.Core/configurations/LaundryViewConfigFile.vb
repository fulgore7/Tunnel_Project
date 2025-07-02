Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Interfaces

Public Class LaundryViewConfigFile
    Inherits ConfigurationFileBase

    Public Property Plant As Enums.Plant
    Public Property RefreshInt As Integer
    Public Property Display As Enums.DisplayType
    Public Property ReportStart As DateTime
    Public Property ReportEnd As DateTime
    Public Property NumWeeks As Integer
    Public Property NumMachines As Integer
    Public Property MachineIDs As List(Of Integer)
    Public Property IsFullScreen As Boolean
    Public Property ShowClock As Boolean
    Public Property NumScreens As Integer
    Public Property NumStationsPerScreen As Integer
    Public Property ReportLink As String


End Class
