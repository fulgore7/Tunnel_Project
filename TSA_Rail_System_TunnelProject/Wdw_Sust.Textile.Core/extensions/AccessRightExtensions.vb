Imports System.Runtime.CompilerServices
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Interfaces

Namespace Extensions
    Public Module EventExtensions
        <Extension()>
        Public Function AccessRightCheck(Of T As IRoleAccessRightEventArgs)(ByVal c As ICanCheckAccess, ByVal eventObject As [Delegate], ByVal e As T) As Boolean
            eventObject.DynamicInvoke(c, e)
            If e.CancelAction Then Return False
            Return e.HasRight
        End Function

        <Extension()>
        Sub DoWork(ByVal testCondition As IRoleAccessRightEventArgs, Optional ByVal trueAction As Action = Nothing, Optional ByVal falseAction As Action = Nothing)
            If testCondition.HasRight Then
                If trueAction IsNot Nothing Then trueAction()
            Else
                If falseAction IsNot Nothing Then falseAction()
            End If
        End Sub
    End Module
End Namespace



