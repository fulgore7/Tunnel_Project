Public Class OpcGroupDefinition

#Region "Fields"

    Private _groupName As String
    Private _isActive As Boolean
    Private _isSubscribed As Boolean
    Private _isSyncronized As Boolean
    Private _updateRate As Integer

#End Region

#Region "Properties"

    Public Property GroupName() As String
        Get
            Return _groupName
        End Get
        Set(value As String)
            _groupName = value
        End Set
    End Property

    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(value As Boolean)
            _isActive = value
        End Set
    End Property

    Public Property IsSubscribed() As Boolean
        Get
            Return _isSubscribed
        End Get
        Set(value As Boolean)
            _isSubscribed = value
        End Set
    End Property

    Public Property IsSyncronized() As Boolean
        Get
            Return _isSyncronized
        End Get
        Set(value As Boolean)
            _isSyncronized = value
        End Set
    End Property

    Public Property UpdateRate() As Integer
        Get
            Return _updateRate
        End Get
        Set(value As Integer)
            _updateRate = value
        End Set
    End Property

#End Region

#Region "Constructors"

    Public Sub New(groupName As String, updateRate As Integer,
isSubscribed As Boolean, isActive As Boolean,
isSyncronized As Boolean)
        Me.GroupName = groupName
        Me.IsActive = isActive
        Me.IsSubscribed = isSubscribed
        Me.IsSyncronized = isSyncronized
        Me.UpdateRate = updateRate
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class