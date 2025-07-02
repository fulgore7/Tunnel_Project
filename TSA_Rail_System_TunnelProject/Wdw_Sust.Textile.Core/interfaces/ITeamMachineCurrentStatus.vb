Namespace Interfaces
    Public Interface ITeamMachineCurrentStatus
        Property MachineId As Integer
        Property StartTime As Date
        Property EndTime As Date
        Property CurrentSessionReasonId As TeamSessionChangeReason
        Property CurrentSessionReasonDescription As String
        Property MachineName As String
        ReadOnly Property CurrentDuration As TimeSpan
    End Interface
End Namespace