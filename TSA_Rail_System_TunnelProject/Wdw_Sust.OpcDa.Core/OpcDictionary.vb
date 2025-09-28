Friend NotInheritable Class OpcObjectKey

    Public Sub New(plcName As String, tagName As String, groupName As String)
        Me.PLCName = plcName
        Me.TagName = tagName
        Me.GroupName = groupName
    End Sub

    Public Property GroupName() As String
    Public Property PLCName() As String
    Public Property TagName() As String

    Public Overrides Function ToString() As String
        Return String.Format("[{0}]{1}", PLCName, TagName)
    End Function

End Class