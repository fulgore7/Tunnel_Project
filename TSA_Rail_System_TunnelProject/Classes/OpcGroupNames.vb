Friend Class ClassifiedLoadingPlatformOpcGroupName
    Inherits OpcGroupNameBase
    Property Sorting As String
End Class

Friend Class ClassifiedStorageOpcGroupName
    Inherits OpcGroupNameBase
    Property Storage As String
    Property Line01To07 As String
    Property Line17To24 As String
    Property Line08To16 As String
    Property Line36To43 As String
    Property Line41To51 As String
End Class

Friend MustInherit Class OpcGroupNameBase
    Property RailSequence As String
    Property ShortTrip As String
    Property EmptyBagReturn As String
    Property OnGoingBuffer As String
    Property OffgoingBuffer As String
End Class

Friend Class WashdeckOpcGroupName
    Property Tunnel1 As String
    Property Tunnel2 As String
    Property Tunnel3 As String
    Property Tunnel4 As String
    Property Tunnel5 As String
    Property Tunnel6 As String
    Property PhoenixTunnel6 As String
    Property Tunnel7 As String
    Property Tunnel8 As String
    Property CycleTimer As String
    Property CleanworkEmptyBag As String
    Property MachineAvailability As String
End Class
