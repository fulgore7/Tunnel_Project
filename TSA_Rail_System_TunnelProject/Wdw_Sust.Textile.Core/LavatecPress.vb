
Public Class LavatecPress

#Region "Fields"
        Private m_Press_Bag_Data As New LINTGraphicBag
        Private m_Press_Conveyor_Running As Boolean
        Private m_Press_Current_Cycle_Time As Integer
        Private m_Press_Fault As Boolean
        Private m_Press_Fault_Duration As Integer
        Private m_Press_Loading_in_Progress As Boolean
        Private m_Press_Occupied As Boolean
        Private m_Press_Ready As Boolean
        Private m_Press_Unloading_in_Progress As Boolean
#End Region

#Region "Properties"
        Public Property Press_Bag_Data() As LINTGraphicBag
            Get
                Return m_Press_Bag_Data
            End Get
            Set(ByVal value As LINTGraphicBag)
                m_Press_Bag_Data = value
            End Set
        End Property
        Public Property Press_Conveyor_Running() As Boolean
            Get
                Return m_Press_Conveyor_Running
            End Get
            Set(ByVal value As Boolean)
                m_Press_Conveyor_Running = value
            End Set
        End Property
        Public Property Press_Current_Cycle_Time() As Integer
            Get
                Return m_Press_Current_Cycle_Time
            End Get
            Set(ByVal value As Integer)
                m_Press_Current_Cycle_Time = value
            End Set
        End Property
        Public Property Press_Fault() As Boolean
            Get
                Return m_Press_Fault
            End Get
            Set(ByVal value As Boolean)
                m_Press_Fault = value
            End Set
        End Property
        Public Property Press_Fault_Duration() As Integer
            Get
                Return m_Press_Fault_Duration
            End Get
            Set(ByVal value As Integer)
                m_Press_Fault_Duration = value
            End Set
        End Property
        Public Property Press_Loading_in_Progress() As Boolean
            Get
                Return m_Press_Loading_in_Progress
            End Get
            Set(ByVal value As Boolean)
                m_Press_Loading_in_Progress = value
            End Set
        End Property
        Public Property Press_Occupied() As Boolean
            Get
                Return m_Press_Occupied
            End Get
            Set(ByVal value As Boolean)
                m_Press_Occupied = value
            End Set
        End Property
        Public Property Press_Ready() As Boolean
            Get
                Return m_Press_Ready
            End Get
            Set(ByVal value As Boolean)
                m_Press_Ready = value
            End Set
        End Property
        Public Property Press_Unloading_in_Progress() As Boolean
            Get
                Return m_Press_Unloading_in_Progress
            End Get
            Set(ByVal value As Boolean)
                m_Press_Unloading_in_Progress = value
            End Set
        End Property

#End Region

#Region "Methods"

#End Region

End Class

