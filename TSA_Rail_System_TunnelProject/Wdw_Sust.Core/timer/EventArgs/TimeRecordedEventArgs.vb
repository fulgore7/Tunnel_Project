Namespace Timer.EventArgs
    Public Class TimeRecordedEventArgs
        Inherits System.EventArgs

        Public ReadOnly LastDuration As Double
        Public ReadOnly TotalDuration As Double

        Public Sub New(ByVal lastDuration As Double, ByVal totalDuration As Double)
            Me.LastDuration = lastDuration
            Me.TotalDuration = totalDuration
        End Sub

    End Class
End Namespace