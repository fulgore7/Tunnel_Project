Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace Extensions
    Public Module EnumExtensions
        ''' <summary> Retrieve the description on the enum, e.g. 
        ''' [Description("Bright Pink")] 
        ''' BrightPink = 2, 
        ''' Then when you pass in the enum, it will retrieve the description 
        ''' </summary> 
        ''' <param name="en">The Enumeration</param> 
        ''' <returns>A string representing the friendly name</returns> 
        <Extension()>
        Function GetFriendlyName(ByVal en As [Enum]) As String
            Dim type As Type = en.GetType()
            Dim memInfo As MemberInfo() = type.GetMember(en.ToString())
            If memInfo IsNot Nothing AndAlso memInfo.Length > 0 Then
                Dim attrs As Object() = memInfo(0).GetCustomAttributes(GetType(DescriptionAttribute), False)
                If attrs IsNot Nothing AndAlso attrs.Length > 0 Then
                    Return DirectCast(attrs(0), DescriptionAttribute).Description
                End If
            End If
            Return en.ToString()
        End Function


    End Module
End Namespace
