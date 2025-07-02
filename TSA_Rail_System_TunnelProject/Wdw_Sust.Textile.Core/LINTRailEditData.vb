Imports System.Data

Public Class LintRailEditData

#Region "Properties"
    Public Property EmployeeName() As String
    Public Property Message() As String
    Public Property TimeOfAction() As DateTime
    Public Property WorkStationName() As String
    Public Property LINTActionDescription() As String
#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("[{0}] {1} - {2} - {3} - {4}", _TimeOfAction, _EmployeeName, _Message, _WorkStationName, _LINTActionDescription)
    End Function
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As SqlClient.SqlDataReader)
        EmployeeName = reader("Employee_Name")
        TimeOfAction = reader("Time_Of_Action")
        Message = reader("Message")
        WorkStationName = reader("Workstation_Name")
        LINTActionDescription = reader("LINT_Action_Description")
    End Sub
    Public Sub New()

    End Sub
#End Region

End Class