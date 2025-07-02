Namespace Job
    <Serializable()>
    Public Class JobRunTime

#Region "Fields"
        Private _hour As Integer
        Private _minute As Integer
        Private _second As Integer
#End Region

#Region "Properties"
        Public Property DayOfWeek As DayOfWeek
        Public Property Hour As Integer
            Get
                Return _hour
            End Get
            Set(value As Integer)
                If value >= 0 And value < 24 Then
                    _hour = value
                Else
                    Throw New ArgumentException("Hour can only have a value between 0 and 23")
                End If
            End Set
        End Property

        Public Property Minute As Integer
            Get
                Return _minute
            End Get
            Set(value As Integer)
                If value >= 0 And value < 60 Then
                    _minute = value
                Else
                    Throw New ArgumentException("Minute can only have a value between 0 and 59")
                End If
            End Set
        End Property

        Public Property Second As Integer
            Get
                Return _second
            End Get
            Set(value As Integer)
                If value >= 0 And value < 60 Then
                    _second = value
                Else
                    Throw New ArgumentException("Second can only have a value between 0 and 59")
                End If
            End Set
        End Property
#End Region

#Region "Methods"
        Public Overrides Function ToString() As String
            Return String.Format("Day:{0}, Hour:{1}, Minute:{2}, Second:{3}", DayOfWeek, Hour, Minute, Second)
        End Function
#End Region

#Region "Contructors"
        Public Sub New(ByVal dayOfWeek As DayOfWeek, ByVal hour As Integer, ByVal minute As Integer, ByVal second As Integer)
            Me.Hour = hour
            Me.Minute = minute
            Me.Second = second
            Me.DayOfWeek = dayOfWeek
        End Sub

        Public Sub New()

        End Sub
#End Region

    End Class
End Namespace

