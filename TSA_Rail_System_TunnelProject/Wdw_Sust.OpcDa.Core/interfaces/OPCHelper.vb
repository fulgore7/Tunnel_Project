Imports System.Reflection
Imports System.ComponentModel

Imports WDW_SUST.Textile.LINT.Core
Namespace Textile.LINT.OPC.Core

    Friend Module OPCHelper
        Private _tagDefinitionCache As New Dictionary(Of Type, List(Of String))
        Friend OPC_CLIENT_HANDLE_INDEX As Integer

        Public Function GetPLCTags(ByVal opcObject As IOPCObject, ByVal filterProperties As String()) As String()
            'If opcObject.PLCName = String.Empty Then
            '    Throw New Exception("PLC name is not defined!!")
            'End If
            'Dim names As New List(Of String)
            'Dim s As String = ""
            ''If this is OPCElemnt class, no need to use cache
            'If TypeOf opcObject Is OPCElement Then
            '    s = String.Format("[{0}]{1}", opcObject.PLCName, opcObject.TagName)
            '    names.Add(s)
            '    Return names.ToArray
            '    'If list of tags has already in the cache
            'ElseIf _tagDefinitionCache.ContainsKey(opcObject.GetType) Then
            '    names = _tagDefinitionCache(opcObject.GetType)
            '    'If the list of the tags for the class has not been defined yet
            'Else
            '    Dim publicProperties() As PropertyInfo
            '    Dim myType As Type = opcObject.GetType()
            '    publicProperties = myType.GetProperties()
            '    Dim para As ParameterInfo()
            '    Dim i As Integer
            '    For i = 0 To publicProperties.Length - 1
            '        para = Nothing
            '        para = publicProperties(i).GetIndexParameters()
            '        If para.Length > 0 Then
            '            Dim tempPropertyName As String = String.Format("{0}_ARRAY_SIZE", publicProperties(i).Name).ToUpper
            '            Dim size As Integer = opcObject.GetType.GetField(tempPropertyName, BindingFlags.NonPublic AndAlso BindingFlags.IgnoreCase).GetValue(opcObject)
            '            Dim base As Integer = 1
            '            If Attribute.IsDefined(publicProperties(i), GetType(Attributes.ArrayBaseEqualsZeroAttribute)) Then
            '                base = 0
            '            End If
            '            For j As Integer = base To (size - 1 + base)
            '                TagNameBreakDown(names, publicProperties(i), , j)
            '            Next
            '        Else
            '            TagNameBreakDown(names, publicProperties(i))
            '        End If
            '    Next
            '    names.Sort()
            '    'Add this to the cache
            '    _tagDefinitionCache.Add(opcObject.GetType, names)
            'End If
            'Dim tempList As New List(Of String)
            'For Each s In names
            '    s = String.Format("[{0}]{1}.{2}", opcObject.PLCName, opcObject.TagName, s)
            '    tempList.Add(s)
            'Next
            'Return tempList.ToArray
            'tempList = Nothing

        End Function
        Private Function IsPropertyOPCRelated(ByVal publicProperty As PropertyInfo) As Boolean
            'Check if the property of the object falls in the scope of WDW_SUST.dll
            If Not publicProperty.Module.ScopeName = "WDW_SUST.dll" Then
                Return False
            End If
            'Check if the property is non-connectable opc item
            If Attribute.IsDefined(publicProperty, GetType(Attributes.NotConnectableOPCItemAttribute)) Then
                Return False
            End If
            'Check if the property is predefined to be not connected
            If IsPreDefinedProperties(publicProperty.Name) Then
                Return False
            End If
            Return True
        End Function
        Private Function IsPreDefinedProperties(ByVal propertyName As String) As Boolean
            For Each s As String In FilterProperties
                If s = propertyName Then
                    Return True
                End If
            Next
            Return False
        End Function
        ''' <summary>
        ''' Subroutine to break down the tag name to the element level
        ''' </summary>
        Private Sub TagNameBreakDown(ByRef names As List(Of String), ByVal publicProperty As PropertyInfo, Optional ByVal subTagName As String = "", Optional ByVal index As Integer = -1)
            If IsPropertyOPCRelated(publicProperty) Then
                If publicProperty.PropertyType.IsClass AndAlso publicProperty.PropertyType.FullName <> "System.String" Then
                    If subTagName Is "" Then
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
                        Dim para As ParameterInfo()
                        para = Nothing
                        para = subPublicProperties(i).GetIndexParameters()
                        If para.Length > 0 Then
                            Dim tempPropertyName As String = String.Format("{0}_ARRAY_SIZE", subPublicProperties(i).Name).ToUpper
                            Dim propType As Object = Activator.CreateInstance(publicProperty.PropertyType)
                            Dim size As Integer = publicProperty.PropertyType.GetField(tempPropertyName, BindingFlags.NonPublic AndAlso BindingFlags.IgnoreCase).GetValue(propType)
                            Dim base As Integer = 1
                            If Attribute.IsDefined(subPublicProperties(i), GetType(Attributes.ArrayBaseEqualsZeroAttribute)) Then
                                base = 0
                            End If
                            For j As Integer = base To (size - 1 + base)
                                TagNameBreakDown(names, subPublicProperties(i), publicProperty.Name, j)
                            Next
                        Else
                            TagNameBreakDown(names, subPublicProperties(i), subTagName)
                        End If
                    Next
                    Exit Sub
                ElseIf subTagName Is "" Then
                    If index > -1 Then
                        subTagName = String.Format("{0}[{1}]", publicProperty.Name, index)
                    Else
                        subTagName = String.Format("{0}", publicProperty.Name)
                    End If
                Else
                    If index > -1 Then
                        subTagName = String.Format("{0}.{1}[{2}]", subTagName, publicProperty.Name, index)
                    Else
                        subTagName = String.Format("{0}.{1}", subTagName, publicProperty.Name)
                    End If
                End If
                names.Add(subTagName)
            End If
        End Sub



    End Module

End Namespace