Imports Wdw_Sust.Core.Interfaces

Public MustInherit Class InformationBroadcasterBase(Of SpecifiedProvider As Class, T As IDataRetrievalEventArgs)
    Inherits SingletonProviderBase(Of SpecifiedProvider)
    Implements IInformationBroadcaster(Of T)

#Region "Fields"
    Private WithEvents _backgroundWorker As New System.ComponentModel.BackgroundWorker
    Private ReadOnly _subscribers = New List(Of IInformationSubscriber(Of T))
    Private _lastUpdatedTime As Date = Now
    Private _queue As New Queue(Of T)
    Protected Shared ReadOnly PROCESS_LOCK As New Object
#End Region

#Region "Events"
    Public Event _NextUpdateTimeChanged As EventHandler
#End Region

#Region "Properties"

    Public Property LastUpdatedTime() As Date Implements IInformationBroadcaster(Of T).LastUpdatedTime
        Get
            Return _lastUpdatedTime
        End Get
        Protected Set(ByVal value As Date)
            _lastUpdatedTime = value
            RaiseEvent _NextUpdateTimeChanged(Me, System.EventArgs.Empty)
        End Set
    End Property

    Public ReadOnly Property Subscribers As System.Collections.Generic.IEnumerable(Of IInformationSubscriber(Of T)) Implements IInformationBroadcaster(Of T).Subscribers
        Get
            Return _subscribers
        End Get
    End Property

    Protected Function GetInternalSubscriberList() As List(Of IInformationSubscriber(Of T))
        SyncLock PROCESS_LOCK
            Return _subscribers
        End SyncLock
    End Function

    Public ReadOnly Property SubscriberCounts As Integer Implements IInformationBroadcaster.SubscriberCounts
        Get
            Return Subscribers.Count
        End Get
    End Property

#End Region

#Region "Methods"
    ''' <summary>
    ''' Gets the subscriber names.
    ''' </summary>
    ''' <returns>List(Of System.String).</returns>
    Public Function GetSubscriberNames() As IEnumerable(Of String) Implements IInformationBroadcaster.GetSubscriberNames
        Dim names As New List(Of String)
        For i As Integer = 0 To Subscribers.Count - 1
            names.Add(Subscribers(i).SubscriberName)
        Next
        names.Sort()
        Return names
    End Function
    ''' <summary>
    ''' Use e.Result to indicate of the operation is successful. If not it will continue to try
    ''' until a predefined number of times reaches and raise the _InformationRetrieveFailed event.
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub WorkCompleted(e As System.ComponentModel.RunWorkerCompletedEventArgs)
        Dim args As IDataRetrievalEventArgs = TryCast(e.Result, IDataRetrievalEventArgs)
        If e.Result Is Nothing Then Throw New ArgumentNullException("e.Result")
        If args Is Nothing Then Throw New ArgumentException(String.Format("{0} does not implement IDataRetrievalEventArgs interface", e.Result.GetType().ToString))
        If args.IsDataRetrivedSuccessfully Then
            OnWorkCompletedSucessfully(args)
        Else
            args.InfoRetrivalUnsuccessfulCounts += 1
            OnWorkCompletedUnsucessfully(args)
        End If
        If _queue.Count > 0 Then
            args = _queue.Dequeue
            Console.WriteLine(Now)
            If args IsNot Nothing Then
                RunBackgroundWorker(args)
            End If
        End If
    End Sub
    ''' <summary>
    ''' Perform task after the work is completed successfully
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overridable Sub OnWorkCompletedSucessfully(e As T)

    End Sub

    ''' <summary>
    ''' Perform task after the work is completed unsuccessfully, such as a retry of the same task again
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overridable Sub OnWorkCompletedUnsucessfully(e As T)

    End Sub

    Protected Sub RunBackgroundWorker(args As T)
        If Not _backgroundWorker.IsBusy Then
            _backgroundWorker.RunWorkerAsync(args)
        Else
            _queue.Enqueue(args)
        End If
    End Sub

    ''' <summary>
    ''' Define what work will be performed when the condition is met. This needs to be overridden to change the
    ''' behavior of the broadcaster
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overridable Sub WorkToPerform(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        e.Result = e.Argument
    End Sub

    Public Sub AddSubscriber(subscriber As IInformationSubscriber) Implements IInformationBroadcaster(Of T).AddSubscriber
        SyncLock PROCESS_LOCK
            If subscriber Is Nothing Then Exit Sub
            If Not _subscribers.Contains(subscriber) Then
                _subscribers.Add(subscriber)
                subscriber.ParentBroadcaster = Me
                OnSubscriberAdded(subscriber)
            End If
        End SyncLock
    End Sub

    Public Sub AddSubscribers(subscribers As List(Of IInformationSubscriber(Of T)))
        subscribers.ForEach(Sub(a) If a IsNot Nothing Then AddSubscriber(a))
    End Sub

    ''' <summary>
    ''' Overrides when you want to perform extra logic after the subscriber was added.
    ''' </summary>
    ''' <param name="addedSubscriber"></param>
    Protected Overridable Sub OnSubscriberAdded(ByVal addedSubscriber As IInformationSubscriber(Of T))

    End Sub


    Public Sub RemoveSubscriber(subscriber As IInformationSubscriber) Implements IInformationBroadcaster(Of T).RemoveSubscriber
        'Public Sub RemoveSubscriber(subscriber As IInformationSubscriber(Of T)) Implements IInformationBroadcaster(Of T).RemoveSubscriber
        SyncLock PROCESS_LOCK
            If _subscribers.Contains(subscriber) Then
                subscriber.ParentBroadcaster = Nothing
                _subscribers.Remove(subscriber) ' _toBeRemovedSubscribers.Add(subscriber)
            End If
        End SyncLock
    End Sub

    Private Sub _backgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _backgroundWorker.RunWorkerCompleted
        LastUpdatedTime = Now
        WorkCompleted(e)
    End Sub

    ''' <summary>
    ''' To declare what the background worker is supposed to do
    ''' </summary>
    ''' <param name="eventHandler">The sub that will perform the work</param>
    ''' <remarks></remarks>
    Private Sub SubscribeBackgroundWorkerWork(ByVal eventHandler As System.ComponentModel.DoWorkEventHandler)
        AddHandler _backgroundWorker.DoWork, eventHandler
    End Sub

    Private Sub UnsubscribeBackgroundWorkerWork(ByVal eventHandler As System.ComponentModel.DoWorkEventHandler)
        RemoveHandler _backgroundWorker.DoWork, eventHandler
    End Sub
#End Region

#Region "Constructors"
    Public Sub New()
        SubscribeBackgroundWorkerWork(AddressOf WorkToPerform)
    End Sub
#End Region

End Class
