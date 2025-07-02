Imports Wdw_Sust.Core.Timer.EventArgs

Namespace Timer

    Public Class HighResolutionTimer
        Inherits TimerBase

#Region "Fields"
        Private _lastRecordedTicks As Long
        Private ReadOnly _steps As New List(Of Long)()
        Private ReadOnly LOCK_OBJECT As New Object()
        Private _isTimerRunning As Boolean
#End Region

#Region "Events"

        Public Event TimeRecorded As EventHandler(Of TimeRecordedEventArgs)

#End Region

#Region "Properties"

        Public ReadOnly Property Steps As IList(Of Long)
            Get
                Return _steps.AsReadOnly
            End Get
        End Property

        Public ReadOnly Property StartDate() As Date
            Get
                If _steps.Count > 0 Then Return New Date(StartTicks)
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property EndDate() As Date
            Get
                If Not _isTimerRunning AndAlso _steps.Count > 0 Then Return New Date(StopTicks)
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property EndTicks() As Long
            Get
                If Not _isTimerRunning AndAlso _steps.Count > 0 Then Return StopTicks
                Return -1
            End Get
        End Property

        Public ReadOnly Property IsTimerRunning As Boolean
            Get
                Return _isTimerRunning
            End Get
        End Property

#End Region

#Region "Methods"

        Private Sub ResetTimer()
            StartTicks = 0
            StopTicks = 0
            _lastRecordedTicks = 0
            _steps.Clear()
        End Sub

        ''' <summary>
        ''' Record elapsed time
        ''' </summary>
        ''' <returns>Last elapsed time in seconds</returns>
        ''' <remarks></remarks>
        Public Function RecordTime() As Double
            Dim currentTicks As Long = Now.Ticks
            Dim returnedElapsedTime As Long = RecordTime(currentTicks - _lastRecordedTicks)
            _lastRecordedTicks = currentTicks
            Return CDbl(CalculatElapsedTimeInMilliseconds(returnedElapsedTime) / 1000)
        End Function

        ''' <summary>
        ''' Records the time.
        ''' </summary>
        ''' <param name="delta">The delta between ticks.</param>
        ''' <returns></returns>
        Private Function RecordTime(ByVal delta As Long) As Long
            SyncLock LOCK_OBJECT
                _steps.Add(delta)
            End SyncLock
            Threading.ThreadPool.QueueUserWorkItem(Sub() RaiseRecordTimeEvent(delta))
            Return delta
        End Function

        Private Sub RaiseRecordTimeEvent(ByVal delta As Long)
            RaiseEvent TimeRecorded(Me, New TimeRecordedEventArgs(CDbl(CalculatElapsedTimeInMilliseconds(delta) / 1000), GetTotalElapsedTimeInSeconds))
        End Sub

        Public Overrides Sub StartTimer()
            StartTimer(True)
        End Sub

        Public Overrides Sub StopTimer()
            If _isTimerRunning Then
                _isTimerRunning = False
                StopTicks = Now.Ticks
                RecordTime()
                RaiseTimerStoppedEvent()
            End If
        End Sub

        Public Overloads Sub StartTimer(resetTime As Boolean)
            If Not _isTimerRunning Then
                _isTimerRunning = True
                If resetTime Then
                    ResetTimer()
                    StartTicks = Now.Ticks
                    _lastRecordedTicks = StartTicks
                End If
                RaiseTimerStartedEvent()
            End If
        End Sub

        Public Overridable Function GetTotalElapsedTimeInMilliseconds() As Double
            Return CalculatElapsedTimeInMilliseconds(Now.Ticks - StartTicks)
        End Function

        Public Function GetTotalElapsedTimeInSeconds() As Double
            Return CDbl(GetTotalElapsedTimeInMilliseconds() / 1000)
        End Function

        Public Function GetLastStepElapsedTimeInSeconds() As Double
            Return CDbl(CalculatElapsedTimeInMilliseconds(_steps.Last) / 1000)
        End Function

#End Region

    End Class



End Namespace

