Imports System.Data
Imports Wdw_Sust.Core.Helpers

Public Class LintEngineeringMttrDiagnosticData
    Inherits LintEngineeringDiagnosticData

#Region "Fields"
    Private _MTTR As Double
#End Region

#Region "Properties"
    Public Property MTTR() As Double
        Get
            Return _MTTR
        End Get
        Set(ByVal value As Double)
            _MTTR = value
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
        Me.MTTR = FixNull(Of Double)(reader("MTTR"))
    End Sub
#End Region

End Class
