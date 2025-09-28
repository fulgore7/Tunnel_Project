Imports Wdw_Sust.OpcDa.Core.Interfaces

Friend Class OpcItemDictionary
    Inherits Dictionary(Of OpcItemKey, IOpcObject)

    Public Shadows Function ContainsKey(key As Integer) As Boolean
        For Each i As OpcItemKey In Keys
            If i.ClientHandle = key Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shadows Function ContainsKey(key As String) As Boolean
        For Each s As OpcItemKey In Keys
            If s.PlcTagName = key Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shadows Function ContainsKey(key As OpcItemKey) As Boolean
        Return MyBase.ContainsKey(key)
    End Function

    Public Function GetKey(clientHandle As Integer) As OpcItemKey
        For Each tempKey As OpcItemKey In Keys
            If tempKey.ClientHandle = clientHandle Then
                Return tempKey
            End If
        Next
        Throw New ArgumentException("This client handle is not defined!!")
    End Function

    Public Function GetKey(plcTagName As String) As OpcItemKey
        For Each tempKey As OpcItemKey In Keys
            If tempKey.PlcTagName = plcTagName Then
                Return tempKey
            End If
        Next
        Throw New ArgumentException(String.Format("PLC tag name {0} is not defined!!", plcTagName))
    End Function

    ''' <summary>
    ''' Used to get the OPC object by using the PLC tag name of the object
    ''' </summary>
    ''' <param name="key">Name of the PLC tag name</param>
    ''' <returns>The IOPCObject from the list</returns>
    ''' <remarks></remarks>
    Public Shadows Function Item(key As String) As IOpcObject
        For Each s As OpcItemKey In Keys
            If s.PlcTagName = key Then
                Return MyBase.Item(s)
            End If
        Next
        Throw New ArgumentException(String.Format("Key {0} Does Not Exist", key))
    End Function

    ''' <summary>
    ''' Used to get the opc object by using the client handle of the opc object
    ''' </summary>
    ''' <param name="key">Client handle of the opc item</param>
    ''' <returns>The IOPCObject from the list</returns>
    ''' <remarks></remarks>
    Public Shadows Function Item(key As Integer) As IOpcObject
        For Each i As OpcItemKey In Keys
            If i.ClientHandle = key Then
                Return MyBase.Item(i)
            End If
        Next
        Throw New ArgumentException("Key Does Not Exist")
    End Function

    Public Shadows Sub Remove(key As OpcItemKey)
        Me(key) = Nothing
        MyBase.Remove(key)
    End Sub

End Class