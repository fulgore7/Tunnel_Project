Imports Wdw_Sust.Textile.Core.Enums

Namespace EventArgs
    Public Class LintOperatorEventArgs
        Inherits System.EventArgs

#Region "Fields"
        Private _dateOfAction As DateTime
        Private _employeeID As Integer
        Private _LINTActionID As LintAction
        Private _logDescription As String
        Private _workstationName As String
#End Region

#Region "Properities"
        Public ReadOnly Property DateOfAction() As DateTime
            Get
                Return _dateOfAction
            End Get
        End Property
        Public ReadOnly Property EmployeeID() As Integer
            Get
                Return _employeeID
            End Get
        End Property
        Public Property LintActionId() As LintAction
            Get
                Return _LINTActionID
            End Get
            Set(ByVal value As LintAction)
                _LINTActionID = value
            End Set
        End Property
        Public Property LogDescription() As String
            Get
                Return _logDescription
            End Get
            Set(ByVal value As String)
                _logDescription = value
            End Set
        End Property
        Public ReadOnly Property WorkstationName() As String
            Get
                Return _workstationName
            End Get
        End Property
#End Region

#Region "Constructors"

        Public Sub New(ByVal dateOfAction As DateTime, ByVal employeeId As Integer, ByVal workstationName As String, Optional ByVal lintActionId As LintAction = LintAction.UNKNOWN_ACTION, Optional ByVal logDescription As String = "")
            _dateOfAction = dateOfAction
            _employeeID = employeeId
            _workstationName = workstationName
            _LINTActionID = lintActionId
            _logDescription = logDescription
        End Sub

#End Region

    End Class
End Namespace
