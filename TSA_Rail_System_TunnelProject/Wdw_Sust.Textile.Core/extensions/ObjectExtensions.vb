Imports System.Runtime.CompilerServices
Imports Wdw_Sust.Core.Validation

Namespace Extension
    Public Module ObjectExtension
        <Extension()>
        Function IsValid(ByVal obj As LintObjectBase) As Boolean
            Dim isObjectValid As Boolean = True
            If BusinessRuleManager.HasRules(obj.GetType) Then
                isObjectValid = BusinessRuleManager.CheckRules(obj)
            End If
            Return isObjectValid
        End Function
    End Module
    Public Module TeamSessionChangeReasonExtension
        <Extension>
        Public Function ToTeamMachineStatus(reason As TeamSessionChangeReason) As TeamMachineStatus
            Select Case reason
                Case TeamSessionChangeReason.MachineProductive
                    Return TeamMachineStatus.MachineAvailable
                Case TeamSessionChangeReason.MachineUnproductive
                    Return TeamMachineStatus.MachineAvailable
                Case TeamSessionChangeReason.MachineStop
                    Return TeamMachineStatus.MachineAvailable
                Case TeamSessionChangeReason.MachineMaintenanceByEngineering
                    Return TeamMachineStatus.MachineMaintenanceInProgress
                Case TeamSessionChangeReason.MachineMaintenanceByProduction
                    Return TeamMachineStatus.MachineMaintenanceRequested
                Case TeamSessionChangeReason.MachineFaulted
                    Return TeamMachineStatus.MachineAvailable
                Case TeamSessionChangeReason.MachineBreakInProgress
                    Return TeamMachineStatus.MachineAvailable
                Case Else
                    Return TeamMachineStatus.MachineAvailable
            End Select
        End Function
    End Module

End Namespace
