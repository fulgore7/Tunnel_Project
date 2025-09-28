.0Imports Wdw_Sust.OpcDa.Core.Ab
Imports Wdw_Sust.OpcDa.Core.Interfaces

Public MustInherit Class OpcObjectAbBase
    Inherits OpcObjectBase

    ''' <summary>
    ''' Get the tag names in the opc item format [PLCName]Item_Name.Sub_Item_Name
    ''' </summary>
    ''' <returns>List of opc items</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetPlcTagNames() As String()
        Return RslinxOpcDaSettings.TagGenerator.GenerateOpcTags(Me)
    End Function

    Public Sub New(plcName As String, tagName As String, groupName As String)
        MyBase.New(plcName, tagName, groupName)
    End Sub
    Public Sub New(tagName As String, groupName As String)
        MyBase.New(tagName, groupName)
    End Sub
    Public Sub New()

    End Sub

End Class

