Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Job

<Serializable()>
Public NotInheritable Class LintShiftClock

#Region "Fields"
    <NonSerialized()>
    Private ReadOnly _shifts As New List(Of LintShiftData)()
    <NonSerialized()>
    Private _parameters As LintSystemParameters
    Private _currentShift As LintShiftData
    Private _breakInProgress As Boolean
    Private _shiftDate As Date = Today
#End Region

#Region "Events"
    Public Event CurrentShiftChanged As EventHandler
    Public Event CurrentBreakStatusChanged As EventHandler
#End Region

#Region "Properties"
    Public ReadOnly Property Parameters As LintSystemParameters
        Get
            Return _parameters
        End Get
    End Property

    Public ReadOnly Property CurrentShift As Shift
        Get
            If _currentShift Is Nothing Then Return Shift.NON_SHIFT
            Return _currentShift.Shift
        End Get
    End Property

    Public ReadOnly Property CurrentShiftTimeInHours As Double
        Get
            If _currentShift Is Nothing Then Return 0.0
            Return _currentShift.GetCurrentShiftTimeSoFarInHours
        End Get
    End Property

    Public ReadOnly Property IsBreakInProgress() As Boolean
        Get
            Return _breakInProgress
        End Get
    End Property
    Public ReadOnly Property IsNonShiftTime() As Boolean
        Get
            Return CurrentShift = Shift.NON_SHIFT
        End Get
    End Property

#End Region

#Region "Methods"
    Public Sub SetParameters(ByVal systemParameters As LintSystemParameters)
        _parameters = systemParameters
        _shifts.Find(Function(a) a.Shift = Shift.FIRST_SHIFT).SetShift(Shift.FIRST_SHIFT)
        _shifts.Find(Function(a) a.Shift = Shift.SECOND_SHIFT).SetShift(Shift.SECOND_SHIFT)
        _shifts.Find(Function(a) a.Shift = Shift.THIRD_SHIFT).SetShift(Shift.THIRD_SHIFT)
        _currentShift = _shifts.Find(Function(a) a.IsShiftInProgress)
    End Sub

    Public Function GetCurrentShiftData() As LintShiftData
        CheckShiftStatus()
        If CurrentShift <> Shift.ALL_SHIFT AndAlso
                CurrentShift <> Shift.UNKNOWN AndAlso
                CurrentShift <> Shift.NON_SHIFT Then
            Return _shifts.Find(Function(a) a.Shift = CurrentShift)
        End If
        Return Nothing
    End Function

    Public Sub CheckShiftStatus()
        If _currentShift Is Nothing Then
            _currentShift = _shifts.Find(Function(a) a.IsShiftInProgress)
            If _currentShift IsNot Nothing Then
                RaiseEvent CurrentShiftChanged(Me, System.EventArgs.Empty)
            End If
        Else
            If Not _currentShift.IsShiftInProgress Then
                _currentShift = _shifts.Find(Function(a) a.IsShiftInProgress)
                RaiseEvent CurrentShiftChanged(Me, System.EventArgs.Empty)
            End If
            If _currentShift IsNot Nothing Then
                Dim isBreakInProgress = _currentShift.IsBreakInProgress
                If isBreakInProgress <> _breakInProgress Then
                    _breakInProgress = isBreakInProgress
                    RaiseEvent CurrentBreakStatusChanged(Me, System.EventArgs.Empty)
                End If
            End If
        End If
        If _shiftDate <> Today Then
            _shiftDate = Today
            _shifts.ForEach(Sub(a) a.SetShiftStartEndTime())
        End If
    End Sub

#End Region

#Region "Constructors"

    Public Sub New(ByVal systemParameters As LintSystemParameters)
        _parameters = systemParameters
        _shifts.Add(New LintShiftData(Shift.FIRST_SHIFT, Me))
        _shifts.Add(New LintShiftData(Shift.SECOND_SHIFT, Me))
        _shifts.Add(New LintShiftData(Shift.THIRD_SHIFT, Me))
        _currentShift = _shifts.Find(Function(a) a.IsShiftInProgress)
    End Sub
#End Region

End Class

