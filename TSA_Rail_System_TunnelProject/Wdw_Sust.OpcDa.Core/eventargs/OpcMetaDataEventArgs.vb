Public Class OpcMetaDataEventArgs
    Inherits System.EventArgs

    Private countItems As Integer

    Public Sub New(countMetaDataItems As Integer)
        CountItemsRegisteredFromView = countMetaDataItems
    End Sub

    Public Property CountItemsRegisteredFromView As Integer
        Get
            Return countItems
        End Get
        Set(value As Integer)
            countItems = value
        End Set
    End Property

End Class