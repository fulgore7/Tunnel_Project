Imports System.Reflection
Imports TSA_Rail_System.Attributes
Imports TSA_Rail_System.Interfaces
Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.OpcDa.Core.Interfaces

Public MustInherit Class OpcTagGeneratorBase
    Implements IOpcTagGenerator

    ''' <summary>
    ''' Used to cache tag definitions so that it is only generated once. This is a shared field
    ''' </summary>
    Private Shared ReadOnly _tagDefinitionCache As New Dictionary(Of Type, List(Of String))()

    ''' <summary>
    ''' Logic that generates the opc tags.
    ''' </summary>
    ''' <param name="obj">The object.</param>
    ''' <returns>System.String().</returns>
    ''' <exception cref="System.Exception">PLC name is not defined!!</exception>
    Public Function GenerateOpcTags(obj As IOpcObject) As String() Implements IOpcTagGenerator.GenerateOpcTags
        If String.IsNullOrEmpty(obj.PlcName) Then
            Throw New Exception("PLC name is not defined!!")
        End If
        Dim filters As String() = obj.FilterProperties
        Dim names As New List(Of String)
        Dim s As String = String.Empty
        'If this is OpcElemnt class, no need to use cache
        If obj.ListOfOpcTags.Count > 0 Then
            For Each k As String In obj.ListOfOpcTags.Keys
                names.Add(k)
            Next
            Return names.ToArray
            'If this is an OpcElement
        ElseIf TypeOf obj Is OpcElement Then
            s = GenerateOpcElementTagName(obj)
            'TODO: this needs to be separated from GetPLCTagNames as it intends to return a list of plc tags
            obj.ListOfOpcTags.Add(s, 1)  ' OpcElement always has 1 index only
            names.Add(s)
            If OpcComm.PrintTagNameWhenDebug Then Console.WriteLine(String.Format("{0} = index {1}", s, 1))
            Return names.ToArray
            'If list of tags has already in the cache
        ElseIf _tagDefinitionCache.ContainsKey(obj.GetType) Then
            names = _tagDefinitionCache(obj.GetType)
            'If the list of the tags for the class has not been defined yet
        Else
            Dim publicProperties() As PropertyInfo
            Dim myType As Type = obj.GetType()
            publicProperties = myType.GetProperties()
            Dim i As Integer
            For i = 0 To publicProperties.Length - 1
                If Attribute.IsDefined(publicProperties(i), GetType(IsOpcArrayAttribute)) Then
                    Dim a As IsOpcArrayAttribute = Attribute.GetCustomAttribute(publicProperties(i), GetType(IsOpcArrayAttribute))
                    For j As Integer = a.ArrayStartIndex To (a.ArraySize - 1 + a.ArrayStartIndex)
                        TagNameBreakDown(filters, names, publicProperties(i), , j)
                    Next
                Else
                    TagNameBreakDown(filters, names, publicProperties(i))
                End If
            Next
            'Added 6/1/2017 to handle the control class tag generations
            '
            If names.Count = 0 Then
                Dim tempTag As String = GenerateOpcElementTagName(obj)
                names.Add(tempTag)
                obj.ListOfOpcTags.Add(tempTag, 1)
                If OpcComm.PrintTagNameWhenDebug Then Console.WriteLine(String.Format("{0} = index {1}", s, 1))
                Return names.ToArray
            End If

            names.Sort()
            'Add this to the cache
            _tagDefinitionCache.Add(obj.GetType, names)
        End If
        Dim index As Integer = 1
        Dim tempList As New List(Of String)
        For Each s In names
            s = GenerateOpcTagName(obj.PlcName, obj.TagName, s)
            tempList.Add(s)
            obj.ListOfOpcTags.Add(s, index)
            If OpcComm.PrintTagNameWhenDebug Then 'TODO: How to handle Allen Bradley comm hard coded.
                Console.WriteLine(String.Format("{0} = index {1}", s, index))
            End If
            index += 1
        Next
        Return tempList.ToArray
        tempList = Nothing
    End Function

    Protected MustOverride Function GenerateOpcElementTagName(obj As IOpcObject) As String

    Protected MustOverride Function GenerateOpcTagName(plcTopicName As String, tagName As String, subTagName As String) As String

    ''' <summary>
    ''' Used to filter out the properties which are not part of the Opc item structure
    ''' </summary>
    ''' <param name="propertyName">Name of the property</param>
    ''' <returns>Boolean to indicate whether the property is pre-defined</returns>
    ''' <remarks></remarks>
    Private Function IsPreDefinedProperties(propertyName As String, filters As String()) As Boolean
        For Each s As String In filters
            If s = propertyName Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsPropertyOpcRelated(publicProperty As PropertyInfo, filters As String()) As Boolean
        'Check if the property of the object falls in the scope of WDW_SUST.dll
        If Not publicProperty.Module.ScopeName.ToLower.StartsWith("wdw_sust") Then Return False ' And Not publicProperty.ReflectedType.BaseType.FullName = "WDW_SUST.Textile.LINT.Opc.Core.OpcObjectBase" Then Return False
        'Check if the property is non-connectable Opc item
        If Attribute.IsDefined(publicProperty, GetType(NotConnectableOpcItemAttribute)) Then
            If Not Attribute.IsDefined(publicProperty, GetType(ConnectableOpcItemAttribute)) Then Return False
        End If
        'Check if the property is predefined to be not connected
        If IsPreDefinedProperties(publicProperty.Name, filters) Then Return False
        Return True
    End Function

    ''' <summary>
    ''' Subroutine to break down the tag name to the element level
    ''' </summary>
    Private Sub TagNameBreakDown(filters As String(), ByRef names As List(Of String), publicProperty As PropertyInfo, Optional subTagName As String = "", Optional index As Integer = -1)
        If IsPropertyOpcRelated(publicProperty, filters) Then
            If (publicProperty.PropertyType.IsClass OrElse publicProperty.PropertyType.IsInterface) AndAlso
                publicProperty.PropertyType.FullName <> "System.String" Then
                If subTagName Is String.Empty Then
                    If index > -1 Then
                        subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
                    Else
                        subTagName = String.Format("{0}", publicProperty.Name)
                    End If
                Else
                    subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
                End If
                Dim mySubType As Type = publicProperty.PropertyType
                Dim subPublicProperties() As PropertyInfo
                subPublicProperties = mySubType.GetProperties

                For i As Integer = 0 To subPublicProperties.Length - 1
                    If Attribute.IsDefined(subPublicProperties(i), GetType(IsOpcArrayAttribute)) Then
                        Dim a As IsOpcArrayAttribute = Attribute.GetCustomAttribute(subPublicProperties(i), GetType(IsOpcArrayAttribute))
                        For j As Integer = a.ArrayStartIndex To (a.ArraySize - 1 + a.ArrayStartIndex)
                            TagNameBreakDown(filters, names, subPublicProperties(i), subTagName, j)
                        Next
                    Else
                        TagNameBreakDown(filters, names, subPublicProperties(i), subTagName)
                    End If
                Next
            ElseIf subTagName Is String.Empty Then
                If index > -1 Then
                    subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
                Else
                    subTagName = String.Format("{0}", publicProperty.Name)
                End If
                names.Add(subTagName)

            Else
                If index > -1 Then
                    subTagName = String.Format("{0}.{1}[{2}]", subTagName, publicProperty.Name, index)
                Else
                    subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
                End If
                names.Add(subTagName)
            End If

        End If
    End Sub

End Class

