Class OpcIncomingData

#Region "Fields"

    Private _clientHandles As Array
    Private _groupHandle As Integer
    Private _itemValues As Array
    Private _numItems As Integer
    Private _qualities As Array
    Private _timeStamps As Array
    Private _transactionID As Integer

#End Region

#Region "Properties"

    Public Property ClientHandles As Array
        Get
            Return _clientHandles
        End Get
        Set(value As Array)
            _clientHandles = value
        End Set
    End Property

    Public Property GroupHandle As Integer
        Get
            Return _groupHandle
        End Get
        Set(value As Integer)
            _groupHandle = value
        End Set
    End Property

    Public Property ItemValues As Array
        Get
            Return _itemValues
        End Get
        Set(value As Array)
            _itemValues = value
        End Set
    End Property

    Public Property NumItems As Integer
        Get
            Return _numItems
        End Get
        Set(value As Integer)
            _numItems = value
        End Set
    End Property

    Public Property Qualities() As Array
        Get
            Return _qualities
        End Get
        Set(value As Array)
            _qualities = value
        End Set
    End Property

    Public Property TimeStamps As Array
        Get
            Return _timeStamps
        End Get
        Set(value As Array)
            _timeStamps = value
        End Set
    End Property

    Public Property TransactionID As Integer
        Get
            Return _transactionID
        End Get
        Set(value As Integer)
            _transactionID = TransactionID
        End Set
    End Property

#End Region

#Region "Constructors"

    Public Sub New(transactionID As Integer, groupHandle As Integer, clientHandles As Array, numItems As Integer, itemValues As Array, timeStamps As Array, qualities As Array)
        _transactionID = transactionID
        _groupHandle = groupHandle
        _numItems = numItems
        _itemValues = itemValues
        _clientHandles = clientHandles
        _timeStamps = timeStamps
        _qualities = qualities
    End Sub

#End Region

End Class