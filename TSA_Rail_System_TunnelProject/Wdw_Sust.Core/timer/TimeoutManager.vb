Imports Wdw_Sust.Core.Timer.EventArgs

Namespace Timer
    Public Class TimeoutManager
        Inherits TimerManager

#Region "Fields"
        Private _currentTick As Integer
        Private _timeoutInSeconds As Integer
        Private _isCycled As Boolean
#End Region

#Region "Events"
        Public Event TimeoutEvent(ByVal sender As Object, ByVal e As System.EventArgs)
        Public Shadows Event TimerTick(ByVal sender As Object, ByVal e As TimerEventArgs)
#End Region

#Region "Properties"

        Public Property TimeoutInSeconds() As Integer
            Get
                Return _timeoutInSeconds
            End Get
            Set(ByVal value As Integer)
                _timeoutInSeconds = value
            End Set
        End Property

        ''' <summary>
        ''' If this is set to true, the timer will restart itself after each TimeoutEvent
        ''' is fired.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IsCycled As Boolean
            Get
                Return _isCycled
            End Get
            Set(value As Boolean)
                _isCycled = value
            End Set
        End Property

#End Region

#Region "Methods"

        Protected Overrides Sub Tick()
            If IsActive Then
                _currentTick += 1
                If _currentTick >= _timeoutInSeconds Then
                    If IsCycled Then
                        ResetTimer()
                    Else
                        StopTimer()
                    End If
                    RaiseEvent TimeoutEvent(Me, System.EventArgs.Empty)
                Else
                    RaiseEvent TimerTick(Me, New TimerEventArgs(_timeoutInSeconds - _currentTick, _currentTick))
                    'Console.WriteLine("Current Tick: {0}", _currentTick)
                End If
            End If
            MyBase.Tick()
        End Sub

        Public Sub ResetTimer()
            _currentTick = 0
        End Sub

#End Region

#Region "Contructors"
        Public Sub New(ByVal timeOutInSecond As Integer, ByVal autoStart As Boolean, Optional ByVal isCycled As Boolean = False)
            MyBase.New(autoStart)
            _timeoutInSeconds = timeOutInSecond
            _isCycled = isCycled
        End Sub
#End Region

    End Class



End Namespace

