Namespace Interfaces
    ''' <summary>
    ''' Use to broadcast information to its subscribers
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <seealso cref="Wdw_Sust.Core.Interfaces.IInformationBroadcaster" />
    Public Interface IInformationBroadcaster(Of T As IDataRetrievalEventArgs)
        Inherits IInformationBroadcaster
        ReadOnly Property Subscribers() As IEnumerable(Of IInformationSubscriber(Of T))
    End Interface

    ''' <summary>
    ''' Use to broadcast information to its subscribers
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Interfaces.IInformationBroadcaster" />
    Public Interface IInformationBroadcaster
        Property LastUpdatedTime() As Date
        ReadOnly Property SubscriberCounts As Integer
        Function GetSubscriberNames() As IEnumerable(Of String)
        Sub AddSubscriber(ByVal subscriber As IInformationSubscriber)
        Sub RemoveSubscriber(ByVal subscriber As IInformationSubscriber)
    End Interface
End Namespace
