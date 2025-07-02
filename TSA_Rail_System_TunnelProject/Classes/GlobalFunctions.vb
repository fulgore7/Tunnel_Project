Imports Wdw_Sust.OpcDa.Core

Public Module GlobalFunctions

    Public IsClassifiedOngoingRunDown As Boolean
    Public IsClassifiedOffgoingRunDown As Boolean
    Public IsCleanworkOngoingRunDown As Boolean
    Public IsCleanworkOffgoingRunDown As Boolean


    Public Function IsWholeClassifiedRunDown() As Boolean
        Return IsClassifiedOngoingRunDown AndAlso IsClassifiedOffgoingRunDown
    End Function

    Public Function IsWholeCleanworkRunDown() As Boolean
        Return IsCleanworkOngoingRunDown AndAlso IsCleanworkOffgoingRunDown
    End Function

End Module

Public Module GlobalDefinitions
    Public Const CLASSIFID_STORAGE_CAPACITY As Integer = 790
    Public Const CLEANWORK_STORAGE_CAPACITY As Integer = 259
End Module

Public Module GlobalOpcDefinitions
    Public Available_Washers As OpcElement
    Public Available_Dryers As OpcElement
    Public Total_Washers As OpcElement
    Public Total_Dryers As OpcElement
    Public External_Login_Validation_Service As OpcElement
    Public Classified_Total_Number_Of_Bags As OpcElement
    Public Cleanwork_Total_Number_Of_Bags As OpcElement
    Public Number_Of_Auto_Call_Off_Tunnels As OpcElement
    Public Pound_Washed As OpcElement
    Public Pound_Sorted As OpcElement
End Module
