Imports System.Data.SqlClient


<Serializable()>
Public Class LintOperatorHourlyProductivity
    Inherits LintObjectBase(Of LintOperatorHourlyProductivity)

#Region "Fields"

    Private _hour As Integer
    Private _machineName As String
    Private _actualCounts As Integer
    Private _targetCounts As Integer
    Private _rejectCounts As Integer
    Private _logInDuration As Double

#End Region

#Region "Properities"
    Public Property ActualCounts() As Integer
        Get
            Return _actualCounts
        End Get
        Set(ByVal value As Integer)
            _actualCounts = value
        End Set
    End Property

    Public Property Hour() As Integer
        Get
            Return _hour
        End Get
        Set(ByVal value As Integer)
            _hour = value
        End Set
    End Property

    Public Property LogInDuration() As Double
        Get
            Return _logInDuration / 3600.0
        End Get
        Set(ByVal value As Double)
            _logInDuration = value
        End Set
    End Property

    Public Property MachineName() As String
        Get
            Return _machineName
        End Get
        Set(ByVal value As String)
            _machineName = value
        End Set
    End Property

    Public Property RejectCounts() As Integer
        Get
            Return _rejectCounts
        End Get
        Set(ByVal value As Integer)
            _rejectCounts = value
        End Set
    End Property

    Public Property TargetCounts() As Integer
        Get
            Return _targetCounts
        End Get
        Set(ByVal value As Integer)
            _targetCounts = value
        End Set
    End Property

    Public ReadOnly Property ProductivityEfficiency() As Double
        Get
            If Me.TargetCounts > 0 Then
                Return CDbl(Me._actualCounts / Me._targetCounts)
            Else
                Return 0
            End If
        End Get
    End Property
#End Region

#Region "Methods"

#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As SqlDataReader)
        Me._hour = reader("Hour")
        Me._actualCounts = reader("Counts")
        Me._targetCounts = reader("Targets")
        Me._rejectCounts = reader("Rejects")
        Me._machineName = reader("Machine_Name")
        Me._logInDuration = reader("Login_Time")
    End Sub
#End Region

End Class

