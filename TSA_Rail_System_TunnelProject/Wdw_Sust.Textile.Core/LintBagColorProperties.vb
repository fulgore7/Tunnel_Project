Public Class LintBagColorProperties
    Private _backColorInArgbValue As Integer
    Private _textColorInArgbValue As Integer
    Public Property BackColor() As Integer
        Get
            Return _backColorInArgbValue
        End Get
        Set(ByVal value As Integer)
            _backColorInArgbValue = value
        End Set
    End Property
    Public Property TextColor() As Integer
        Get
            Return _textColorInArgbValue
        End Get
        Set(ByVal value As Integer)
            _textColorInArgbValue = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal backColorInArgbValue As Integer, ByVal textColorInArgbValue As Integer)
        Me._backColorInArgbValue = backColorInArgbValue
        Me._textColorInArgbValue = textColorInArgbValue
    End Sub
    Public Sub New(ByVal reader As IDataReader)
        Me._backColorInArgbValue = CInt(reader(0))
        Me._textColorInArgbValue = CInt(reader(1))
    End Sub
End Class



