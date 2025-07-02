<Serializable>
Public MustInherit Class BufferedNotifyableBase(Of U)
    Inherits BufferedNotifyableBase
End Class

<Serializable>
Public MustInherit Class BufferedNotifyableBase
    Inherits NotifyableBase

    Private _isChangeEventBuffered As Boolean
    Private _propertyChangedListBuffer As List(Of String)

    Protected Property PropertyChangedListBuffer As List(Of String)
        Get
            If _propertyChangedListBuffer Is Nothing Then _propertyChangedListBuffer = New List(Of String)
            Return _propertyChangedListBuffer
        End Get
        Private Set(value As List(Of String))
            _propertyChangedListBuffer = value
        End Set
    End Property

    Public Property IsPropertyChangedEventBuffered() As Boolean
        Get
            Return _isChangeEventBuffered
        End Get
        Set(ByVal value As Boolean)
            If _isChangeEventBuffered <> value Then
                Dim needRaise As Boolean = _isChangeEventBuffered
                _isChangeEventBuffered = value
                If needRaise Then
                    PropertyChangedListBuffer.ForEach(Sub(a) MyBase.OnPropertyChanged(a))
                    ClearPropertyChangedBuffer()
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnPropertyChanged(propertyName As String)
        If _isChangeEventBuffered Then
            If Not PropertyChangedListBuffer.Contains(propertyName) Then _propertyChangedListBuffer.Add(propertyName)
        Else
            MyBase.OnPropertyChanged(propertyName)
        End If
    End Sub

    Public Sub ClearPropertyChangedBuffer()
        PropertyChangedListBuffer.Clear()
        PropertyChangedListBuffer = Nothing
    End Sub
End Class
