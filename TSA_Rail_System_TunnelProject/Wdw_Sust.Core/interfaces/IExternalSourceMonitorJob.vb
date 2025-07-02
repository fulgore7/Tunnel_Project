Namespace Interfaces
    ''' <summary>
    ''' Interface IExternalSourceMonitorJob
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Interfaces.ITimeSpanJobDetail" />
    ''' <seealso cref="System.IDisposable" />
    Public Interface IExternalSourceMonitorJob
        Inherits ITimeSpanJobDetail, IDisposable
        ''' <summary>
        ''' Gets or sets the source to monitor.
        ''' </summary>
        ''' <value>The source to monitor.</value>
        Property SourceToMonitor As Func(Of Boolean)
        ''' <summary>
        ''' Gets or sets a value indicating whether the sournce status is ok.
        ''' </summary>
        ''' <value><c>true</c> if source status is ok; otherwise, <c>false</c>.</value>
        Property SourceStatusOk As Boolean
        ''' <summary>
        ''' Occurs when [source status changed].
        ''' </summary>
        Event SourceStatusChanged As EventHandler
    End Interface
End Namespace