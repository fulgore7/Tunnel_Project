Public Module Enums

    Public Enum CipMedia As SByte
        Ethernet = 18
        Backplane = 1
    End Enum

    Public Enum OPC_COMM_TYPE As Integer
        OpcCommStatus = 1
        OPCTagValueChanged = 2
    End Enum

    Public Enum OpcThreadMode As Integer
        MULTI_THREADED
        SINGLE_THREADED
    End Enum

End Module