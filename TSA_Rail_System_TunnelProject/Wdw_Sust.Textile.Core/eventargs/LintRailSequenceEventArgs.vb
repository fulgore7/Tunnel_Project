Namespace EventArgs
    Public Class LintRailSequenceEventArgs
        Inherits System.EventArgs

#Region "Fields"
        Private _oldSequenceStep As Integer
        Private _newSequenceStep As Integer
        Private _sequenceID As Integer
        Private _employeeID As Integer
        Private _timeOfAction As DateTime
        Private _message As String
        Private _workstationName As String
#End Region

#Region "Properities"
        Public Property Message() As String
            Get
                Return _message
            End Get
            Set(ByVal value As String)
                _message = value
            End Set
        End Property

        Public ReadOnly Property NewSequenceStep() As Integer
            Get
                Return _newSequenceStep
            End Get
        End Property

        Public ReadOnly Property SequenceID() As Integer
            Get
                Return _sequenceID
            End Get
        End Property

        Public ReadOnly Property OldSequenceStep() As Integer
            Get
                Return _oldSequenceStep
            End Get
        End Property

        Public ReadOnly Property EmployeeID() As Integer
            Get
                Return _employeeID
            End Get
        End Property

        Public ReadOnly Property TimeOfAction() As DateTime
            Get
                Return _timeOfAction
            End Get
        End Property
        Public ReadOnly Property WorkstationName() As String
            Get
                Return _workstationName
            End Get
        End Property

#End Region

#Region "Constructors"
        Public Sub New(ByVal employeeID As Integer, ByVal oldSequenceStep As Integer, ByVal newSequenceStep As Integer,
                   ByVal sequenceID As Integer, ByVal message As String, ByVal workstationName As String)
            _message = message
            _oldSequenceStep = oldSequenceStep
            _timeOfAction = Now
            _sequenceID = sequenceID
            _newSequenceStep = newSequenceStep
            _employeeID = employeeID
            _workstationName = workstationName
        End Sub
#End Region

    End Class

End Namespace
