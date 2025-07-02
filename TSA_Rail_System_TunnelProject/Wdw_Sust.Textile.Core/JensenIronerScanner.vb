
''' <summary>
''' This class is used by an OPC object class
''' </summary>
''' <remarks></remarks>
<Serializable()>
Public Class JensenIronerScanner

#Region "Fields"
    Private _deform_Count As Integer
    Private _good_Count As Integer
    Private _machine_ID As Integer
    Private _repair_Count As Integer
    Private _rewash_Count As Integer
    Private _total_Count As Integer

#End Region

#Region "Properties"
    Public Property Deform_Count() As Integer
        Get
            Return _deform_Count
        End Get
        Set(ByVal value As Integer)
            _deform_Count = value
        End Set
    End Property
    Public Property Good_Count() As Integer
        Get
            Return _good_Count
        End Get
        Set(ByVal value As Integer)
            _good_Count = value
        End Set
    End Property
    Public Property Machine_ID() As Integer
        Get
            Return _machine_ID
        End Get
        Set(ByVal value As Integer)
            _machine_ID = value
        End Set
    End Property
    Public Property Repair_Count() As Integer
        Get
            Return _repair_Count
        End Get
        Set(ByVal value As Integer)
            _repair_Count = value
        End Set
    End Property
    Public Property Rewash_Count() As Integer
        Get
            Return _rewash_Count
        End Get
        Set(ByVal value As Integer)
            _rewash_Count = value
        End Set
    End Property
    Public Property Total_Count() As Integer
        Get
            Return _total_Count
        End Get
        Set(ByVal value As Integer)
            _total_Count = value
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
