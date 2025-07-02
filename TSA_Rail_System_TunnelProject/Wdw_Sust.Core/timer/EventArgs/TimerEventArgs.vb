
Namespace Timer.EventArgs
    Public Class TimerEventArgs
        Inherits System.EventArgs

#Region "Fields"
        Private _ticksBeforeTimeout As Integer
        Private _ticksSoFar As Integer
#End Region

#Region "Contructors"
        Public Sub New(ByVal ticksBeforeTimeout As Integer, ByVal ticksSoFar As Integer)
            _ticksBeforeTimeout = ticksBeforeTimeout
            _ticksSoFar = ticksSoFar
        End Sub
#End Region

#Region "Properties"
        Public ReadOnly Property TicksBeforeTimeout As Integer
            Get
                Return _ticksBeforeTimeout
            End Get
        End Property

        Public ReadOnly Property TicksSoFar As Integer
            Get
                Return _ticksSoFar
            End Get
        End Property
#End Region

    End Class
End Namespace