
Public Class LintGraphicBag

#Region "Fields"
    Private _Account As Integer
    Private _PLC_Bag_ID As Integer
    Private _Category As Integer
    Private _Drop_Destination As Integer
    Private _SourceBin As Integer
    Private _Storage_Destination As Integer
    Private _Soiled_Weight As Double
#End Region

#Region "Properties"
    Public Property Account() As Integer
        Get
            Return _Account
        End Get
        Set(ByVal value As Integer)
            _Account = value
        End Set
    End Property
    Public Property Category() As Integer
        Get
            Return _Category
        End Get
        Set(ByVal value As Integer)
            _Category = value
        End Set
    End Property
    Public Overridable Property Drop_Destination() As Integer
        Get
            Return _Drop_Destination
        End Get
        Set(ByVal value As Integer)
            _Drop_Destination = value
        End Set
    End Property
    Public Property PLC_Bag_ID() As Integer
        Get
            Return _PLC_Bag_ID
        End Get
        Set(ByVal value As Integer)
            _PLC_Bag_ID = value
        End Set
    End Property
    Public Property Soiled_Weight() As Double
        Get
            Return _Soiled_Weight
        End Get
        Set(ByVal value As Double)
            _Soiled_Weight = value
        End Set
    End Property
    Public Property SourceBin() As Integer
        Get
            Return _SourceBin
        End Get
        Set(ByVal value As Integer)
            _SourceBin = value
        End Set
    End Property
    Public Property Storage_Destination() As Integer
        Get
            Return _Storage_Destination
        End Get
        Set(ByVal value As Integer)
            _Storage_Destination = value
        End Set
    End Property




#End Region

#Region "Methods"

#End Region

#Region "Constructors"

    Public Sub New()

    End Sub

#End Region

End Class



