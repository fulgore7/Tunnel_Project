
Imports System.Data
Imports Wdw_Sust.Core.Helpers



<Serializable()>
Public Class LintOperatorLoginDetail
    Inherits LintObjectBase(Of LintOperatorLoginDetail)

#Region "Fields"

#End Region

#Region "Properities"

    Public Property EmployeeName() As String

    ''' <summary>
    ''' Login in time in minutes
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LoginTime() As Double
        Get
            Return CDbl(DateDiff(DateInterval.Second, _StartTime, _EndTime) / 60)
        End Get
    End Property

    Public Property MachineName() As String
    Public Property StartTime As DateTime
    Public Property EndTime As DateTime
    Public Property TotalCount() As Integer
    Public Property TargetCount As Integer
    Public ReadOnly Property Percentage As Double
        Get
            If _TargetCount = 0 Then Return 0
            Return CDbl(_TotalCount / TargetCount)
        End Get
    End Property
#End Region

#Region "Methods"

#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        _EmployeeName = reader("Employee_Name")
        _MachineName = reader("Machine_Name")
        _StartTime = FixNull(Of Date)(reader("Start_Time"), Nothing)
        _EndTime = FixNull(Of Date)(reader("End_Time"), Nothing)
        _TotalCount = FixNull(Of Integer)(reader("Total_Count"))
        _TargetCount = FixNull(Of Integer)(reader("Target_Count"))
    End Sub
#End Region

End Class


