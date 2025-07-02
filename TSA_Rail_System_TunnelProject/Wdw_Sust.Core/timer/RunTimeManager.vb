Namespace Timer
    Public Class RunTimeManager
        Inherits TimerBase

        Private ReadOnly _pauseTime As New List(Of Long)()
        Private _pauseTimeStamps As Long
        Private _runStatus As RunTimeStatus = RunTimeStatus.Stopped

        Public ReadOnly Property RunStatus As RunTimeStatus
            Get
                Return _runStatus
            End Get
        End Property

        Public Sub PauseTimer()
            If _runStatus = RunTimeStatus.Started Then
                _runStatus = RunTimeStatus.Paused
                _pauseTimeStamps = Now.Ticks
            End If
        End Sub

        Public ReadOnly Property TotalRunTime As TimeSpan
            Get
                Select Case _runStatus
                    Case RunTimeStatus.Started
                        Return TimeSpan.FromTicks(Now.Ticks - StartTicks - _pauseTime.Sum)
                    Case RunTimeStatus.Stopped
                        Return TimeSpan.FromTicks(StopTicks - StartTicks - _pauseTime.Sum)
                    Case RunTimeStatus.Paused
                        Return TimeSpan.FromTicks(_pauseTimeStamps - StartTicks - _pauseTime.Sum)
                End Select
            End Get
        End Property

        Public Overrides Sub StartTimer()
            If _runStatus = RunTimeStatus.Paused Then
                _runStatus = RunTimeStatus.Started
                _pauseTime.Add(Now.Ticks - _pauseTimeStamps)
                RaiseTimerStartedEvent()
            ElseIf _runStatus = RunTimeStatus.Stopped Then
                _runStatus = RunTimeStatus.Started
                _pauseTime.Clear()
                StartTicks = Now.Ticks
                RaiseTimerStartedEvent()
            End If
        End Sub

        Public Overrides Sub StopTimer()
            If Not _runStatus = RunTimeStatus.Stopped Then
                StopTicks = Now.Ticks
                _runStatus = RunTimeStatus.Stopped
                RaiseTimerStoppedEvent()
            End If
        End Sub
    End Class
End Namespace