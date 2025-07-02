Namespace Timer
    Public MustInherit Class TimerBase
        Private _start As Long
        Private _stop As Long

        Public Event TimerStarted As EventHandler
        Public Event TimerStopped As EventHandler

        Public Property StartTicks() As Long
            Get
                Return _start
            End Get
            Protected Set(ByVal value As Long)
                _start = value
            End Set
        End Property

        Public Property StopTicks() As Long
            Get
                Return _stop
            End Get
            Set(ByVal value As Long)
                _stop = value
            End Set
        End Property

        Protected Sub RaiseTimerStartedEvent()
            RaiseEvent TimerStarted(Me, System.EventArgs.Empty)
        End Sub

        Protected Sub RaiseTimerStoppedEvent()
            RaiseEvent TimerStarted(Me, System.EventArgs.Empty)
        End Sub

        Public MustOverride Sub StartTimer()

        Public MustOverride Sub StopTimer()

        Protected Shared Function CalculatElapsedTimeInMilliseconds(ByVal tick As Long) As Double
            Return CDbl(tick / 10000)
        End Function
    End Class


End Namespace
