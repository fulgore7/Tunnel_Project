Imports System.Data

<Serializable()>
Public MustInherit Class LintProdBase
    Inherits LintObjectBase(Of LintProdBase)

#Region "Properties"
    Public Property LintUserID() As Integer
    Public Property PieceCount() As Double
    Public Property RejectCount() As Double
    Public Property ExpectedCount() As Double
    Public Property FirstName As String
    Public Property LastName As String
    Public Property ShiftColor() As String 'Not stored in database, must be calculated based on efficiency
    Public ReadOnly Property FullName() As String
        Get
            If (String.IsNullOrEmpty(FirstName) = False And String.IsNullOrEmpty(LastName) = False) Then
                Return FirstName + " " + LastName.Substring(0, 1)
            Else
                Return String.Empty
            End If
        End Get
    End Property
    Public ReadOnly Property Efficiency As Double
        Get
            If (ExpectedCount > 0) Then
                Dim pace As Double = (PieceCount / ExpectedCount)
                Return pace
            Else
                Return 0
            End If
        End Get
    End Property
#End Region

#Region "Constructors"
    Public Sub New(ByVal lintUserID As Integer, ByVal pieceCount As Integer, ByVal rejectCount As Integer, ByVal expectedCount As Integer,
                   ByVal firstName As String, ByVal lastName As String)
        _LintUserID = lintUserID
        _PieceCount = pieceCount
        _RejectCount = rejectCount
        _ExpectedCount = expectedCount
        _FirstName = firstName
        _LastName = lastName
    End Sub

    Public Sub New(ByVal reader As IDataReader)
        _LintUserID = reader("lint_user_id")
        _PieceCount = reader("piece_count")
        _RejectCount = reader("reject_count")
        _ExpectedCount = reader("expected_count")
        _FirstName = reader("first_name")
        _LastName = reader("last_name")
    End Sub
#End Region

End Class
