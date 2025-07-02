Imports Wdw_Sust.Core.Job

Namespace Interfaces

    Public Interface IJobDetail
        Inherits IExecuteJob
        Property JobName As String
        Property IsEnabled As Boolean
        Property IsBusy As Boolean
        Property LastUpdate As Date
        Property MarkForRemoval As Boolean
        ReadOnly Property JobScheduler As IJobManager
        Sub SetScheduler(scheduler As IJobManager)
        Sub Subscribe(scheduler As IJobManager, Optional ByVal runImmediately As Boolean = False)
        Sub Unsubscribe()
    End Interface

    Public Interface ISpecificRunTimeJobDetail
        Inherits IJobDetail
        Property ListOfRunTime As List(Of JobRunTime)
    End Interface

    Public Interface ITimeSpanJobDetail
        Inherits IJobDetail
        Property TimeSpanRunTime As TimeSpan
    End Interface

    Public Interface ISpecificTimeSpanJobDetail
        Inherits ITimeSpanJobDetail
        Property RunFromHour As Integer
        Property RunFromMinute As Integer
        Property RunFromSecond As Integer
        ReadOnly Property StartDateTime As Date
        ReadOnly Property NextUpdate As Date
    End Interface
End Namespace

