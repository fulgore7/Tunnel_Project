Namespace Interfaces
    Public Interface IInformationSubscriber(Of T As IDataRetrievalEventArgs)
        Inherits IInformationSubscriber
        Sub ProcessSubscribedInformation(ByVal args As T)
    End Interface

    Public Interface IInformationSubscriber
        Property ParentBroadcaster As IInformationBroadcaster
        Property SubscriberName As String
    End Interface

    Public Interface IProgramModeSubscriber(Of U As IProgramModeEventArgs)
        Inherits IInformationSubscriber
        Sub ProcessSubscribedInformation(ByVal args As U)
    End Interface
End Namespace
