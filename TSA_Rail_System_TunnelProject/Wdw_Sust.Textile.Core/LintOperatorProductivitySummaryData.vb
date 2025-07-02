
Imports System.Data
Imports Wdw_Sust.Core.Extensions
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.Sort

<Serializable(), DefaultSortByProperty("CastMemberName")>
Public Class LintOperatorProductivitySummaryData
    Inherits LintObjectBase(Of LintOperatorProductivitySummaryData)

#Region "Fields"
    Private _logInDuration As Double
    Private _updateTime As Date
    Private _actualCounts As Integer
    Private _machineID As Integer
    Private _rfBadgeUserID As Integer
    Private _lastLogInTime As Date
    Private _castMemberName As String
    Private _machineName As String
    Private _machineTypeID As LintMachineType
    Private _targetCounts As Integer

#End Region

#Region "Properities"

    Public Property ActualCounts() As Integer
        Get
            Return _actualCounts
        End Get
        Set(value As Integer)
            _actualCounts = value
        End Set
    End Property


    Public Property LastLogInTime() As Date
        Get
            Return _lastLogInTime
        End Get
        Set(value As Date)
            _lastLogInTime = value
        End Set
    End Property


    Public Property MachineID() As Integer
        Get
            Return _machineID
        End Get
        Set(value As Integer)
            _machineID = value
        End Set
    End Property


    Public Property MachineTypeID As LintMachineType
        Get
            Return _machineTypeID
        End Get
        Set(value As LintMachineType)
            _machineTypeID = value
        End Set
    End Property

    Public Property MachineName() As String
        Get
            Return _machineName
        End Get
        Set(value As String)
            _machineName = value
        End Set
    End Property

    Public Property RFBadgeUserID() As Integer
        Get
            Return _rfBadgeUserID
        End Get
        Set(value As Integer)
            _rfBadgeUserID = value
        End Set
    End Property

    Public Property CastMemberName() As String
        Get
            Return _castMemberName
        End Get
        Set(value As String)
            _castMemberName = value
        End Set
    End Property

    Public Property TargetCounts() As Integer
        Get
            Return _targetCounts
        End Get
        Set(value As Integer)
            _targetCounts = value
        End Set
    End Property

    Public ReadOnly Property LogInDuration() As String
        Get
            If _logInDuration < 3600.0 Then
                Return String.Format("{0:F2} minutes", CDbl(_logInDuration / 60.0))
            Else
                Return String.Format("{0:F2} hours", CDbl(_logInDuration / 3600.0))
            End If
        End Get
    End Property

    Public ReadOnly Property ProductivityEfficiency() As Double
        Get
            If TargetCounts > 0 Then
                Return CDbl(_actualCounts / _targetCounts)
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property UpdateTime As Date
        Get
            Return _updateTime
        End Get
    End Property

    Public ReadOnly Property Plant As Plant
        Get
            If MachineID.IsWithin(10000, 19999) Then
                Return Plant.TSA
            ElseIf MachineID.IsWithin(20000, 29999) Then
                Return Plant.NSA
            ElseIf MachineID.IsWithin(30000, 39999) Then
                Return Plant.ASA
            Else
                Return Plant.UNKNOWN
            End If
        End Get
    End Property

    Public ReadOnly Property NameInShortForm As String
        Get
            If CastMemberName Is Nothing Then Return String.Empty
            Dim castName As String = CastMemberName.Replace("  ", " ")
            Dim parts As String() = Strings.Split(castName.Trim, Delimiter:=" ")
            If parts.Length > 1 Then
                castName = String.Format("{0} {1}.", parts(0), parts(1).Chars(0))
            Else
                castName = parts(0).Trim
            End If
            Return castName
        End Get
    End Property

#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("MachineId:{0}", MachineID)
    End Function
#End Region

#Region "Constructors"

    Public Sub New(ByVal reader As SqlClient.SqlDataReader)
        _machineID = FixNull(Of Integer)(reader("Machine_ID"), 0)
        _rfBadgeUserID = FixNull(Of Integer)(reader("RF_Badge_User_ID"), 0)
        _lastLogInTime = FixNull(Of Date)(reader("Last_Update_Time"), Now)
        _castMemberName = FixNull(Of String)(reader("Employee_Name"), String.Empty)
        _machineName = FixNull(Of String)(reader("Machine_Name_Abbreviated"), String.Empty)
        _machineTypeID = FixNull(Of LintMachineType)(reader("Machine_Type_ID"), LintMachineType.UNKNOWN)
        _actualCounts = FixNull(Of Integer)(reader("Actual_Count"), 0)
        _targetCounts = FixNull(Of Integer)(reader("Target_Count"), 0)
        _logInDuration = FixNull(Of Double)(reader("Log_In_Duration"), 0.0)
        _updateTime = Now
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class


