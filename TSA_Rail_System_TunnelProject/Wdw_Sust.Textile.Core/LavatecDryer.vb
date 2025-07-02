
Public Class LavatecDryer

#Region "Fields"
    Private _current_Cycle_Time As Integer
    Private _dryer_In_Service As Boolean
    Private _dryer_Loading As Boolean
    Private _dryer_Running As Boolean
    Private _dryer_Unloading As Boolean
    Private _fault_Code As Integer
    Private _fault_Value As Integer
#End Region

#Region "Properties"
    Public Property Current_Cycle_Time() As Integer

        Get
            Return _current_Cycle_Time
        End Get
        Set(ByVal value As Integer)
            _current_Cycle_Time = value
        End Set
    End Property

    Public Property Dryer_In_Service() As Boolean
        Get
            Return _dryer_In_Service
        End Get

        Set(ByVal value As Boolean)
            _dryer_In_Service = value
        End Set

    End Property
    Public Property Dryer_Loading() As Boolean
        Get
            Return _dryer_Loading
        End Get

        Set(ByVal value As Boolean)
            _dryer_Loading = value
        End Set
    End Property

    Public Property Dryer_Unloading() As Boolean
        Get
            Return _dryer_Unloading
        End Get
        Set(ByVal value As Boolean)
            _dryer_Unloading = value
        End Set

    End Property

    Public Property Fault_Code() As Integer
        Get
            Return _fault_Code
        End Get

        Set(ByVal value As Integer)
            _fault_Code = value
        End Set
    End Property
#End Region

End Class



