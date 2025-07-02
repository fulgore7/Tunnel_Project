Public Class SingletonTaskBuilder
    Inherits SingletonProviderBase(Of SingletonTaskBuilder)

    Public Tasks As List(Of Task) = New List(Of Task)
End Class
