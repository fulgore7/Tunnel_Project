Imports System.Linq

Namespace Timer
    Public Class TimerManager
        Implements IDisposable

#Region "Fields"
        Private WithEvents _timer As Timers.Timer
        Private _lastTickTime As DateTime
#End Region

#Region "Events"

        Public Event TimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
        Public Event TimerStarted(ByVal sender As Object, ByVal e As System.EventArgs)
        Public Event TimerStopped(ByVal sender As Object, ByVal e As System.EventArgs)

#End Region

#Region "Properties"
        ''' <summary>
        ''' IsActive is to tell if the timer is running at the moment
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsActive As Boolean
            Get
                Return Timer.Enabled
            End Get
        End Property

        Protected ReadOnly Property Timer() As Timers.Timer
            Get
                If _timer Is Nothing Then _timer = New Timers.Timer() With {.Interval = 1000}
                Return _timer
            End Get
        End Property

        Public ReadOnly Property LastTickTime As DateTime
            Get
                Return _lastTickTime
            End Get
        End Property

        Public Property TimerInterval As Integer
            Get
                Return Timer.Interval
            End Get
            Set(value As Integer)
                Timer.Interval = value
            End Set
        End Property


#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    If _timer IsNot Nothing Then
                        _timer.Dispose()
                        _timer = Nothing
                    End If
                End If
            End If
            Me.disposedValue = True
        End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

#Region "Methods"
        Private Sub _timer_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles _timer.Elapsed
            Tick()
        End Sub

        ''' <summary>
        ''' Used to raise the tick event
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overridable Sub Tick()
            RaiseEvent TimerTick(Me, System.EventArgs.Empty)
            _lastTickTime = Now
        End Sub

        ''' <summary>
        ''' Start the timer
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub StartTimer()
            If Not Timer.Enabled Then
                Timer.Enabled = True
                'Console.WriteLine("Timer is active")
            End If
            RaiseEvent TimerStarted(Me, System.EventArgs.Empty)
        End Sub

        ''' <summary>
        ''' Stop the timer
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub StopTimer()
            If Timer.Enabled Then
                Timer.Enabled = False
                'Console.WriteLine("Timer is not active")
                Timer.Dispose()
                _timer = Nothing
            End If
            RaiseEvent TimerStopped(Me, System.EventArgs.Empty)
        End Sub
#End Region

#Region "Contructors"
        Public Sub New(ByVal autoStart As Boolean)
            If autoStart Then StartTimer()
        End Sub
#End Region

    End Class


End Namespace


