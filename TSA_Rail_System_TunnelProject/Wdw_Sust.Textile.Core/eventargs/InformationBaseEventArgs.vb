Namespace EventArgs
    Public MustInherit Class InformationBaseEventArgs
        Inherits DataRetrievalEventArgs
        Implements IHaveMoreTasks

        Public Property HaveMoreTasks As Boolean Implements IHaveMoreTasks.HaveMoreTasks

    End Class
End Namespace