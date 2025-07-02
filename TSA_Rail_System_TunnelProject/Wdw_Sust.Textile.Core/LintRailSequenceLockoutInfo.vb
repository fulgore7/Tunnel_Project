Imports System.Data
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Core

Public Class LintRailSequenceLockoutInfo

#Region "Fields"
    Private _castInfo As LintCastMember
    Private _sequenceLastLockoutDate As DateTime
    Private _sequenceID As Integer
    Private _sequenceDescription As String
    Private _isSequenceLockedOut As Boolean
#End Region

#Region "Properties"
    Public ReadOnly Property CastInfo() As LintCastMember
        Get
            Return _castInfo
        End Get
    End Property

    Public Property IsSequenceLockedOut() As Boolean
        Get
            Return _isSequenceLockedOut
        End Get
        Set(ByVal value As Boolean)
            _isSequenceLockedOut = value
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

    Public Property SequenceID() As Integer
        Get
            Return _sequenceID
        End Get
        Set(ByVal value As Integer)
            _sequenceID = value
        End Set
    End Property

    Public Property SequenceLastLockoutDate() As DateTime
        Get
            Return _sequenceLastLockoutDate
        End Get
        Set(ByVal value As DateTime)
            _sequenceLastLockoutDate = value
        End Set
    End Property
#End Region

#Region "Contructors"
    Public Sub New(ByVal reader As IDataReader)
        _castInfo = New LintCastMember With {.EmployeeID = reader("Employee_ID"), .FirstName = reader("First_Name"), .LastName = reader("Last_Name"), .UserType = reader("User_Type")}
        _sequenceID = reader("Sequence_ID")
        _sequenceDescription = reader("Sequence_Description")
        _isSequenceLockedOut = _castInfo.EmployeeID > 0
        _sequenceLastLockoutDate = FixNull(Of Date)(reader("Sequence_Last_Lock_Out_Date"))
    End Sub
#End Region

End Class

