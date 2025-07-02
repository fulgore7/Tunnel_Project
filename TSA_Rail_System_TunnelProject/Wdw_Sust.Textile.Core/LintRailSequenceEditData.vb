Imports System.Data

Public Class LintRailSequenceEditData

#Region "Fields"
    Private _oldSequenceStepID As Integer
    Private _oldSequenceStep As String
    Private _newSequenceStepID As Integer
    Private _newSequenceStep As String
    Private _sequenceDescription As String
    Private _employeeName As String
    Private _timeOfAction As DateTime
    Private _workstationName As String
#End Region

#Region "Properties"
    Public Property EmployeeName() As String
        Get
            Return _employeeName
        End Get
        Set(ByVal value As String)
            _employeeName = value
        End Set
    End Property
    Public Property NewSequenceStep() As String
        Get
            Return _newSequenceStep
        End Get
        Set(ByVal value As String)
            _newSequenceStep = value
        End Set
    End Property
    Public Property NewSequenceStepID() As Integer
        Get
            Return _newSequenceStepID
        End Get
        Set(ByVal value As Integer)
            _newSequenceStepID = value
        End Set
    End Property
    Public Property OldSequenceStep() As String
        Get
            Return _oldSequenceStep
        End Get
        Set(ByVal value As String)
            _oldSequenceStep = value
        End Set
    End Property
    Public Property OldSequenceStepID() As Integer
        Get
            Return _oldSequenceStepID
        End Get
        Set(ByVal value As Integer)
            _oldSequenceStepID = value
        End Set
    End Property
    Public Property SequenceDescription() As String
        Get
            Return _sequenceDescription
        End Get
        Set(ByVal value As String)
            _sequenceDescription = value
        End Set
    End Property
    Public Property TimeOfAction() As DateTime
        Get
            Return _timeOfAction
        End Get
        Set(ByVal value As DateTime)
            _timeOfAction = value
        End Set
    End Property
    Public Property WorkstationName() As String
        Get
            Return _workstationName
        End Get
        Set(ByVal value As String)
            _workstationName = value
        End Set
    End Property
#End Region

#Region "Methods"

#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As SqlClient.SqlDataReader)
        Me._employeeName = reader("Employee_Name")
        Me._newSequenceStep = reader("New_Sequence_Step")
        Me._newSequenceStepID = reader("New_Sequence_Step_ID")
        Me._oldSequenceStep = reader("Old_Sequence_Step")
        Me._oldSequenceStepID = reader("Old_Sequence_Step_ID")
        Me._sequenceDescription = reader("Sequence_Description")
        Me._timeOfAction = reader("Time_Of_Action")
        Me._workstationName = reader("Workstation_Name")
    End Sub
#End Region

End Class