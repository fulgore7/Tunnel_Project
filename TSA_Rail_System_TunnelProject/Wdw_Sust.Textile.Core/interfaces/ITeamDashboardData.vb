Namespace Interfaces
    Public Interface ITeamDashboardData
        Inherits IHaveMachineId
        Property MachineAreaType As Integer
        Property UniqueId As Integer
        Property CurrentSessionReasonDescription As String
        Property CurrentSessionReasonID As TeamSessionChangeReason
        Property StartTime As Date
        Property EndTime As Date
        Property BreakinProgressInHours As Double
        Property MachineProductiveInHours As Double
        Property MachineUnproductiveInHours As Double
        Property MachineStopInHours As Double
        Property MachineMaintenanceByProductionInHours As Double
        Property MachineMaintenanceByEngineeringInHours As Double
        Property MachinePmByEngineeringInHours As Double
        Property MachineFaultTimeInHours As Double
        Property ActualCounts As Integer
        Property RejectCounts As Integer
        Property TargetCounts As Integer
        Property MachineName As String
        ReadOnly Property TotalTimeInHours As Double
        ReadOnly Property ActualAfterRejectCounts As Integer
        ReadOnly Property TotalThroughputPercentage As Double
        ReadOnly Property MachineAvailableTimeInPercentage As Double
        ReadOnly Property MachineUnavailableTimeInPercentage As Double
        ReadOnly Property MachinePmTimeInPercentage As Double
        ReadOnly Property MachineIdleTimeInPercentage As Double
        ReadOnly Property MachineAvailableTimeInHours As Double
        ReadOnly Property RejectPercentage As Double
        ReadOnly Property MachineUnavailableTimeInHours As Double
        ReadOnly Property MachineIdleTimeInHours As Double
        ReadOnly Property FellShortPercentage As Double
    End Interface
End Namespace