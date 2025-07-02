

Public Class frmClassifiedLoadingPlatform
    Inherits CtrlOpcTsaRailFormBase

    Private _groups As New ClassifiedLoadingPlatformOpcGroupName With {.RailSequence = "Classified_Loading_Platform_Sequence",
                                                                       .ShortTrip = "Classified_Loading_Platform_Short_Trip",
                                                                       .EmptyBagReturn = "Classified_Loading_Platform_Empty_Bag_Return",
                                                                       .Sorting = "Classified_Loading_Platform_Sorting",
                                                                       .OnGoingBuffer = "Classified_Loading_Platform_Sorting_Ongoing_Buffer"}

#Region "Methods"

    Protected Overrides Sub Initialize()
        If Not CONFIGURATION.IsFailOverMode Then CType(ParentForm, frmMain).AlarmBroadcaster.Refresh(True)
        OPCGroupBindingSource.DataSource = _groups
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub InitializeOpcCommunication()
        OpenOpcComm(_groups.RailSequence, 3000)
        MyBase.OpenOpcComm()
    End Sub

#End Region

End Class


