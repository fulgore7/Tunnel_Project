Namespace EventArgs

    Public Class OpcCommStatusEventArgs
        Inherits System.EventArgs
        Private _eventTimeStamp As Date
        Private _groupName As String

        Public Sub New()
            Me._eventTimeStamp = Now
        End Sub

        Public ReadOnly Property EventTimeStamp() As Date
            Get
                Return _eventTimeStamp
            End Get
        End Property

        Public ReadOnly Property GroupName() As String
            Get
                Return _groupName
            End Get
        End Property

    End Class

End Namespace