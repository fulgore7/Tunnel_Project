Imports Wdw_Sust.Core.Enums

<Serializable()>
Public Class LintShiftData

#Region "Fields"
    <NonSerialized()>
    Private ReadOnly _parent As LintShiftClock
    Private ReadOnly _breaks As New Dictionary(Of Integer, LintInterval)()
    Private _shiftStartTime As Date
    Private _shiftEndTime As Date
#End Region

#Region "Properties"

    Public Property ShiftData As LintInterval
    Public ReadOnly Property ShiftStartTime As DateTime
        Get
            Return _shiftStartTime
        End Get
    End Property
    Public Property Shift As Shift
    Public ReadOnly Property ShiftEndTime As Date
        Get
            If ShiftData Is Nothing Then Return Date.MinValue
            Return ShiftStartTime.AddHours(ShiftData.DurationInHours)
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return String.Format("Start: {0:00}:{1:00} - Duration: {2:F2}", ShiftData.StartHour, ShiftData.StartMinute, ShiftData.DurationInHours)
    End Function

#End Region

#Region "Methods"
    Private Function IsIntervalInProgress(ByVal startHour As Integer, ByVal startMinute As Integer, ByVal durationInHours As Double) As Boolean
        Dim current As DateTime = Now
        Dim startTime As DateTime
        Dim endTime As DateTime
        startTime = Today.AddHours(startHour).AddMinutes(startMinute)
        If Shift = Shift.THIRD_SHIFT AndAlso current.Hour < startTime.Hour Then startTime = startTime.AddDays(-1)
        endTime = startTime.Add(TimeSpan.FromHours(durationInHours))
        If endTime > current AndAlso current > startTime Then Return True
        Return False
    End Function

    Private Shared Function IsBreakPassed(ByVal break As LintInterval, isSameDay As Boolean) As Boolean
        Dim time As DateTime = Today.AddHours(break.StartHour).AddMinutes(break.StartMinute).Add(TimeSpan.FromHours(break.DurationInHours))
        If Not isSameDay Then time = time.AddDays(1)
        Return Now > time
    End Function

    ''' <summary>
    ''' Get the time so far in the current shift
    ''' </summary>
    ''' <returns>Time so far in hours</returns>
    ''' <remarks></remarks>
    Public Function GetCurrentShiftTimeSoFarInHours() As Double
        Return GetCurrentShiftTimeSoFar.TotalHours
    End Function

    Public Function GetCurrentShiftTimeSoFarInHoursMinusBreaks() As Double
        Dim time As Double = GetCurrentShiftTimeSoFarInHours()
        Dim isSameDay1st = _shiftStartTime.Hour < _breaks(1).StartHour
        Dim isSameDay2nd = _shiftStartTime.Hour < _breaks(2).StartHour
        Dim isSameDay3rd = _shiftStartTime.Hour < _breaks(3).StartHour
        If IsBreakPassed(_breaks(1), isSameDay1st) Then
            time = time - _breaks(1).DurationInHours
            If IsBreakPassed(_breaks(2), isSameDay2nd) Then
                time = time - _breaks(2).DurationInHours
                If IsBreakPassed(_breaks(3), isSameDay3rd) Then
                    time = time - _breaks(3).DurationInHours
                End If
            End If
        End If
        Return time
    End Function

    Public Function GetCurrentShiftTimeSoFar() As TimeSpan
        If Not IsShiftInProgress() Then Return TimeSpan.MinValue
        If Shift = Shift.THIRD_SHIFT AndAlso Now.Subtract(ShiftStartTime).TotalDays > 1 Then _shiftStartTime = _shiftStartTime.AddDays(-1)
        Return Now.Subtract(ShiftStartTime)
    End Function

    Public Function GetShiftTimeMinusBreaksInHours() As Double
        If Not IsShiftInProgress() Then Return 0
        Return Me.ShiftData.DurationInHours - _breaks(1).DurationInHours - _breaks(2).DurationInHours - _breaks(3).DurationInHours
    End Function

    Public Function IsShiftInProgress() As Boolean
        Return IsIntervalInProgress(ShiftData.StartHour, ShiftData.StartMinute, ShiftData.DurationInHours)
    End Function

    Public Sub SetShiftData(ByVal startHour As Integer, ByVal startMinute As Integer, ByVal durationInHours As Double)
        If ShiftData Is Nothing Then
            ShiftData = New LintInterval(startHour, startMinute, durationInHours)
        Else
            ShiftData.SetInterval(startHour, startMinute, durationInHours)
        End If
        SetShiftStartEndTime()
    End Sub

    Friend Sub SetShiftStartEndTime()
        Dim current As DateTime = Now
        _shiftStartTime = Today.AddHours(ShiftData.StartHour).AddMinutes(ShiftData.StartMinute)
        If Shift = Shift.THIRD_SHIFT AndAlso current.Hour < _shiftStartTime.Hour Then _shiftStartTime = _shiftStartTime.AddDays(-1)
        _shiftEndTime = _shiftStartTime.Add(TimeSpan.FromHours(ShiftData.DurationInHours))
    End Sub

    Public Sub SetBreak(ByVal breakNumber As Integer, ByVal startHour As Integer, ByVal startMinute As Integer, ByVal durationInHours As Double)
        If Not _breaks.ContainsKey(breakNumber) Then
            _breaks.Add(breakNumber, New LintInterval(startHour, startMinute, durationInHours))
        Else
            _breaks(breakNumber).SetInterval(startHour, startMinute, durationInHours)
        End If
    End Sub

    Public Function IsBreakInProgress() As Boolean
        If IsIntervalInProgress(_breaks(1).StartHour, _breaks(1).StartMinute, _breaks(1).DurationInHours) Then Return True
        If IsIntervalInProgress(_breaks(2).StartHour, _breaks(2).StartMinute, _breaks(2).DurationInHours) Then Return True
        If IsIntervalInProgress(_breaks(3).StartHour, _breaks(3).StartMinute, _breaks(3).DurationInHours) Then Return True
        Return False
    End Function

    Public Sub SetShift(ByVal shift As Shift)
        Me.Shift = shift
        With _parent.Parameters
            Select Case shift
                Case Shift.FIRST_SHIFT
                    SetShiftData(.GetParameterValue(Of Integer)(LintSystemParameterId.FirstShiftStartHour),
                                 .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShiftStartMinute),
                                 .GetParameterValue(Of Double)(LintSystemParameterId.FirstShiftDurationInHours))
                    SetBreak(1,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShift1stBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShift1stBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.FirstShift1stBreakDurationInHours))
                    SetBreak(2,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShift2ndBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShift2ndBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.FirstShift2ndBreakDurationInHours))
                    SetBreak(3,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShift3rdBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.FirstShift3rdBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.FirstShift3rdBreakDurationInHours))
                Case Shift.SECOND_SHIFT
                    SetShiftData(.GetParameterValue(Of Integer)(LintSystemParameterId.SecondShiftStartHour),
                                 .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShiftStartMinute),
                                 .GetParameterValue(Of Double)(LintSystemParameterId.SecondShiftDurationInHours))
                    SetBreak(1,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShift1stBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShift1stBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.SecondShift1stBreakDurationInHours))
                    SetBreak(2,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShift2ndBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShift2ndBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.SecondShift2ndBreakDurationInHours))
                    SetBreak(3,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShift3rdBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.SecondShift3rdBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.SecondShift3rdBreakDurationInHours))
                Case Shift.THIRD_SHIFT
                    SetShiftData(.GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShiftStartHour),
                                 .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShiftStartMinute),
                                 .GetParameterValue(Of Double)(LintSystemParameterId.ThirdShiftDurationInHours))
                    SetBreak(1,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShift1stBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShift1stBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.ThirdShift1stBreakDurationInHours))
                    SetBreak(2,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShift2ndBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShift2ndBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.ThirdShift2ndBreakDurationInHours))
                    SetBreak(3,
                             .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShift3rdBreakStartHour),
                             .GetParameterValue(Of Integer)(LintSystemParameterId.ThirdShift3rdBreakStartMinute),
                             .GetParameterValue(Of Double)(LintSystemParameterId.ThirdShift3rdBreakDurationInHours))
                Case Else
                    Throw New ArgumentException("Shift data not supported!")
            End Select
        End With

    End Sub
#End Region

#Region "Constructors"
    Public Sub New(shift As Shift, parent As LintShiftClock)
        _parent = parent
        SetShift(shift)
    End Sub
#End Region

End Class
