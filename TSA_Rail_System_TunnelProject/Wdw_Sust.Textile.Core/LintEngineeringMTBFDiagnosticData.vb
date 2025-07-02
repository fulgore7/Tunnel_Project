Imports System.Data
Imports Wdw_Sust.Core.Helpers

Public Class LintEngineeringMtbfDiagnosticData
    Inherits LintEngineeringDiagnosticData

#Region "Fields"
    Private _MTBF As Double
#End Region

#Region "Properties"
    Public Property MTBF() As Double
        Get
            Return _MTBF
        End Get
        Set(ByVal value As Double)
            _MTBF = value
        End Set
    End Property
#End Region

#Region "Methods"

#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        Me.AlarmDescription = FixNull(Of String)(reader("Alarm_Description"))
        Me.AlarmGlobalID = FixNull(Of Integer)(reader("Alarm_Global_ID"))
        Me.FaultCount = FixNull(Of Integer)(reader("Fault_Count"))
        Me.MTBF = FixNull(Of Double)(reader("MTBF"))
    End Sub
#End Region

End Class

