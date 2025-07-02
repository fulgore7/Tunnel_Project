Imports System.Data

Public Class LintLiveCastProductivityData

#Region "Properties"
    Public Property EventTimeStamp As Date
    Public Property EmployeeID As Integer
    Public Property EmployeeName As String
    Public Property Efficiency As Double
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        EmployeeName = reader("Employee_Name")
        EmployeeID = reader("Employee_ID")
        EventTimeStamp = reader("Event_Time")
        Efficiency = reader("Efficiency")
    End Sub
#End Region

End Class