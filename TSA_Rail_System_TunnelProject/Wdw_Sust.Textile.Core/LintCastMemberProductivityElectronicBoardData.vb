Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintCastMemberProductivityElectronicBoardData

#Region "Properties"
    Public Property Hour As Integer
    Public Property EmployeeName As String
    Public Property LoginTime As Integer
    Public Property ActualCounts As Integer
    Public Property TargetCounts As Integer
    Public Property Department As String
    Public ReadOnly Property Efficiency As Double
        Get
            If TargetCounts = 0 Then Return 0
            Return CDbl(ActualCounts / TargetCounts)
        End Get
    End Property
    Public ReadOnly Property LoginTimeInMinutes As Double
        Get
            Return CDbl(LoginTime / 60)
        End Get
    End Property
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        Hour = FixNull(Of Integer)(reader("Hour"))
        EmployeeName = FixNull(Of String)(reader("Employee_Name"))
        LoginTime = FixNull(Of Integer)(reader("Login_Time"))
        ActualCounts = FixNull(Of Integer)(reader("Actual_Counts"))
        TargetCounts = FixNull(Of Integer)(reader("Target_Counts"))
        Department = FixNull(Of String)(reader("Department"))
    End Sub
#End Region

End Class

