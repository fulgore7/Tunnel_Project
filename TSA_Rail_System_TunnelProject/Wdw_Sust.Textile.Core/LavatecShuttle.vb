Public Class LavatecShuttle

#Region "Fields"
    Private m_Belt_A_Bag_Data As New LintGraphicBag
    Private m_Belt_B_Bag_Data As New LintGraphicBag
    Private m_Belt_A_Running As Boolean
    Private m_Belt_B_Running As Boolean
    Private m_Photocell_on_Belt_A As Boolean
    Private m_Photocell_on_Belt_B As Boolean
    Private m_Position_Dryer_1 As Boolean
    Private m_Position_Dryer_2 As Boolean
    Private m_Position_Dryer_3 As Boolean
    Private m_Position_Dryer_4 As Boolean
    Private m_Position_Dryer_5 As Boolean
    Private m_Position_Dryer_6 As Boolean
    Private m_Position_Dryer_7 As Boolean

#End Region

#Region "Properties"
    Public Property Belt_A_Bag_Data() As LintGraphicBag
        Get
            Return m_Belt_A_Bag_Data
        End Get
        Set(ByVal value As LintGraphicBag)
            m_Belt_A_Bag_Data = value
        End Set
    End Property
    Public Property Belt_A_Running() As Boolean
        Get
            Return m_Belt_A_Running
        End Get
        Set(ByVal value As Boolean)
            m_Belt_A_Running = value
        End Set
    End Property
    Public Property Belt_B_Bag_Data() As LintGraphicBag
        Get
            Return m_Belt_B_Bag_Data
        End Get
        Set(ByVal value As LintGraphicBag)
            m_Belt_B_Bag_Data = value
        End Set
    End Property
    Public Property Belt_B_Running() As Boolean
        Get
            Return m_Belt_B_Running
        End Get
        Set(ByVal value As Boolean)
            m_Belt_B_Running = value
        End Set
    End Property
    Public Property Photocell_on_Belt_A() As Boolean
        Get
            Return m_Photocell_on_Belt_A
        End Get
        Set(ByVal value As Boolean)
            m_Photocell_on_Belt_A = value
        End Set
    End Property
    Public Property Photocell_on_Belt_B() As Boolean
        Get
            Return m_Photocell_on_Belt_B
        End Get
        Set(ByVal value As Boolean)
            m_Photocell_on_Belt_B = value
        End Set
    End Property
    Public Property Position_Dryer_1() As Boolean
        Get
            Return m_Position_Dryer_1
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_1 = value
        End Set
    End Property
    Public Property Position_Dryer_2() As Boolean
        Get
            Return m_Position_Dryer_2
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_2 = value
        End Set
    End Property
    Public Property Position_Dryer_3() As Boolean
        Get
            Return m_Position_Dryer_3
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_3 = value
        End Set
    End Property
    Public Property Position_Dryer_4() As Boolean
        Get
            Return m_Position_Dryer_4
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_4 = value
        End Set
    End Property
    Public Property Position_Dryer_5() As Boolean
        Get
            Return m_Position_Dryer_5
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_5 = value
        End Set
    End Property
    Public Property Position_Dryer_6() As Boolean
        Get
            Return m_Position_Dryer_6
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_6 = value
        End Set
    End Property
    Public Property Position_Dryer_7() As Boolean
        Get
            Return m_Position_Dryer_7
        End Get
        Set(ByVal value As Boolean)
            m_Position_Dryer_7 = value
        End Set
    End Property
#End Region

#Region "Methods"

#End Region

End Class

