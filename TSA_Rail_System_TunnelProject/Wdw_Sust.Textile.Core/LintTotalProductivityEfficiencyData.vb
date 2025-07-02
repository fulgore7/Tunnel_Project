Imports System.Data
Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintTotalProductivityEfficiencyData
    Inherits LintObjectBase(Of LintTotalProductivityEfficiencyData)

#Region "Properities"

    Public Property ActualFWCounts() As Integer
    Public Property ActualPCCounts() As Integer
    Public Property ActualTFCounts() As Integer
    Public Property TargetBBCounts() As Integer
    Public Property TargetFWCounts() As Integer
    Public Property TargetPCCounts() As Integer
    Public Property TargetTFCounts() As Integer
    Public Property ActualBBCounts() As Integer

    Public ReadOnly Property TFProductivityEfficiency() As Double
        Get
            If TargetTFCounts > 0 Then
                Return CDbl(ActualTFCounts / TargetTFCounts) * 100
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property FWProductivityEfficiency() As Double
        Get
            If TargetFWCounts > 0 Then
                Return CDbl(ActualFWCounts / TargetFWCounts) * 100
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property PCProductivityEfficiency() As Double
        Get
            If TargetPCCounts > 0 Then
                Return CDbl(ActualPCCounts / TargetPCCounts) * 100
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property BBProductivityEfficiency() As Double
        Get
            If TargetBBCounts > 0 Then
                Return CDbl(ActualBBCounts / TargetBBCounts) * 100
            Else
                Return 0
            End If
        End Get

    End Property
#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("FW:{0}, PC:{1}, TF:{2}", FWProductivityEfficiency, PCProductivityEfficiency, TFProductivityEfficiency)
    End Function
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        _ActualTFCounts = FixNull(Of Integer)(reader("Actual_TF_Count"))
        _TargetTFCounts = FixNull(Of Integer)(reader("Target_TF_Count"))
        _ActualFWCounts = FixNull(Of Integer)(reader("Actual_FW_Count"))
        _TargetFWCounts = FixNull(Of Integer)(reader("Target_FW_Count"))
        _ActualPCCounts = FixNull(Of Integer)(reader("Actual_PC_Count"))
        _TargetPCCounts = FixNull(Of Integer)(reader("Target_PC_Count"))
        _ActualBBCounts = FixNull(Of Integer)(reader("Actual_BB_Count"))
        _TargetBBCounts = FixNull(Of Integer)(reader("Target_BBCount"))
    End Sub

    Public Sub New()

    End Sub
#End Region

End Class


