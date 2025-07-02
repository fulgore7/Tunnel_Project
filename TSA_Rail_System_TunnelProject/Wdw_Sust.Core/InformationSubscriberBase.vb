Imports Wdw_Sust.Core.Interfaces

Public Class InformationSubscriberBase
    Implements IInformationSubscriber
    Private _subscriberName As String
    Public Property ParentBroadcaster As IInformationBroadcaster Implements IInformationSubscriber.ParentBroadcaster

    Public Property SubscriberName As String Implements IInformationSubscriber.SubscriberName
        Get
            If String.IsNullOrEmpty(_subscriberName) Then Return Me.GetType().ToString
            Return _subscriberName
        End Get
        Set(value As String)
            _subscriberName = value
        End Set
    End Property
End Class
