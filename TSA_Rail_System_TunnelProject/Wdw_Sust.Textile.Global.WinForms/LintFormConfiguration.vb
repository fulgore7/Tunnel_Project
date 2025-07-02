Imports Wdw_Sust.Core.Interfaces

Public Class LintFormConfiguration
    Public Property ApplicationModeSubscribers As New List(Of IInformationSubscriber)
    Public Property SelfSubscribe As Boolean = True
    Public Property IsInitializedSuccessfully As Boolean
End Class