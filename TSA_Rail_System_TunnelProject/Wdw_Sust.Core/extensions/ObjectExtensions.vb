Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace Extensions
    Public Module ObjectExtensions

        <Extension()>
        Function ConvertToTimeFormat(obj As Long, Optional referenceTime As DateTime = #1/1/1970#) As DateTime
            Return ConvertToDateTime(obj, referenceTime).ToLocalTime
        End Function

        <Extension()>
        Function DoAction(actionSource As Action) As Action
            actionSource.Invoke()
            Return actionSource
        End Function

        <Extension>
        Public Sub Empty(directory As DirectoryInfo)
            directory.GetFiles.ForEach(Sub(file) file.Delete())
            directory.GetDirectories().ForEach(Sub(subDirectory) subDirectory.Delete(True))
        End Sub

        <Extension()>
        Sub ForEach(Of T)(items As IList(Of T), act As Action(Of T))
            For i As Integer = 0 To items.Count - 1
                act(items(i))
            Next
        End Sub

        <Extension()>
        Function ThenDoAction(actionSource As Action, actionToDo As Action) As Action
            actionToDo.Invoke()
            Return actionToDo
        End Function

        <Extension()>
        Function WhenFalse(testCondition As Boolean, action As Action) As Boolean
            If Not testCondition AndAlso action IsNot Nothing Then action()
            Return testCondition
        End Function

        <Extension()>
        Function WhenTrue(testCondition As Boolean, action As Action) As Boolean
            If testCondition AndAlso action IsNot Nothing Then action()
            Return testCondition
        End Function

    End Module
End Namespace