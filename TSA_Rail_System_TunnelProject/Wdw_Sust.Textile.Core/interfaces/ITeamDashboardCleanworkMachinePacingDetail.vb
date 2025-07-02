Namespace Interfaces
    Public Interface ITeamDashboardCleanworkMachinePacingDetail
        Property MachineId As Integer
        Property ShiftTotalRejectCounts As Integer
        Property ShiftTotalTargetCounts As Integer
        Property ShiftTotalCounts As Integer
        Property PacingCounts As Integer
        Property PacingTargetCounts As Integer
        Property PacingRejectCounts As Integer
        Property DataPoints As Integer
        Property IsOnBreak As Boolean
        ReadOnly Property ShiftThroughputPercentage As Double
        ReadOnly Property PacingThroughputPercentage As Double
        ReadOnly Property PacingRejectPercentage As Double
        ReadOnly Property ShiftRejectPercentage As Double
    End Interface
End Namespace