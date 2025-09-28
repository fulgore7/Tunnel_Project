Imports Wdw_Sust.OpcDa.Core.Interfaces

Friend Class OpcObjectDictionary
    Inherits Dictionary(Of OpcObjectKey, IOpcObject)

    Public Shadows Function Contains(plcName As String, tagName As String) As Boolean
        For Each k As OpcObjectKey In Keys
            If k.TagName = tagName AndAlso k.PLCName = plcName Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shadows Function Item(plcName As String, tagName As String) As IOpcObject
        For Each s As OpcObjectKey In Keys.ToList
            If s.PLCName = plcName AndAlso s.TagName = tagName Then
                Return MyBase.Item(s)
            End If
        Next
        Throw New ArgumentException("Key Does Not Exist")
    End Function

    Public Shadows Function Item(key As OpcObjectKey) As IOpcObject
        Return MyBase.Item(key)
        Throw New ArgumentException("Key Does Not Exist")
    End Function

    Public Overloads Sub Remove(groupName As String)
        Dim itemsToBeRemoved As New List(Of OpcObjectKey)
        For Each key As OpcObjectKey In Keys
            If key.GroupName = groupName Then
                itemsToBeRemoved.Add(key)
            End If
        Next
        For Each key As OpcObjectKey In itemsToBeRemoved
            Me(key) = Nothing
            MyBase.Remove(key)
        Next
    End Sub

End Class