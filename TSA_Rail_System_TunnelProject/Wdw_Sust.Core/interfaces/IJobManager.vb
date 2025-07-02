

Namespace Interfaces
    Public Interface IJobManager
        Function AddJob(ByVal jobDetail As IJobDetail, Optional runImmediately As Boolean = False) As IJobDetail
        Sub RemoveJob(ByVal job As IJobDetail)
    End Interface
End Namespace
