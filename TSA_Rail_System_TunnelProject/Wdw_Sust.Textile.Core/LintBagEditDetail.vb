
<Serializable()>
Public Class LintBagEditDetail
    Inherits LintObjectBase(Of LINTAlarmDetail)

#Region "Fields"
    Private _employeeName As String
    Private _oldCategoryCode As Integer
    Private _oldStorageRail As Integer
    Private _oldDropDestination As Integer
    Private _oldSortingStation As Integer
    Private _message As String
    Private _newCategoryCode As Integer
    Private _newStorageRail As Integer
    Private _newDropDestination As Integer
    Private _newSortingStation As Integer
    Private _timeOfAction As DateTime
    Private _workstationName As String
#End Region

#Region "Properties"

    Public Property EmployeeName() As String
        Get
            Return _employeeName
        End Get
        Set(ByVal value As String)
            _employeeName = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property

    Public Property NewCategoryCode() As Integer
        Get
            Return _newCategoryCode
        End Get
        Set(ByVal value As Integer)
            _newCategoryCode = value
        End Set
    End Property

    Public Property NewDropDestination() As Integer
        Get
            Return _newDropDestination
        End Get
        Set(ByVal value As Integer)
            _newDropDestination = value
        End Set
    End Property

    Public Property NewSortingStation() As Integer
        Get
            Return _newSortingStation
        End Get
        Set(ByVal value As Integer)
            _newSortingStation = value
        End Set
    End Property

    Public Property NewStorageRail() As Integer
        Get
            Return _newStorageRail
        End Get
        Set(ByVal value As Integer)
            _newStorageRail = value
        End Set
    End Property

    Public Property OldCategoryCode() As Integer
        Get
            Return _oldCategoryCode
        End Get
        Set(ByVal value As Integer)
            _oldCategoryCode = value
        End Set
    End Property

    Public Property OldDropDestination() As Integer
        Get
            Return _oldDropDestination
        End Get
        Set(ByVal value As Integer)
            _oldDropDestination = value
        End Set
    End Property

    Public Property OldSortingStation() As Integer
        Get
            Return _oldSortingStation
        End Get
        Set(ByVal value As Integer)
            _oldSortingStation = value
        End Set
    End Property

    Public Property OldStorageRail() As Integer
        Get
            Return _oldStorageRail
        End Get
        Set(ByVal value As Integer)
            _oldStorageRail = value
        End Set
    End Property

    Public Property TimeOfAction() As DateTime
        Get
            Return _timeOfAction
        End Get
        Set(ByVal value As DateTime)
            _timeOfAction = value
        End Set
    End Property

    Public Property WorkstationName() As String
        Get
            Return _workstationName
        End Get
        Set(ByVal value As String)
            _workstationName = value
        End Set
    End Property

#End Region

#Region "Contructors"
    Public Sub New(ByVal reader As IDataReader)
        _employeeName = reader("Employee_Name")
        _oldCategoryCode = reader("Old_Category_Code")
        _oldStorageRail = reader("Old_Storage_Rail")
        _oldDropDestination = reader("Old_Drop_Destination")
        _oldSortingStation = reader("Old_Sorting_Station")

        _newCategoryCode = reader("New_Category_Code")
        _newStorageRail = reader("New_Storage_Rail")
        _newDropDestination = reader("New_Drop_Destination")
        _newSortingStation = reader("New_Sorting_Station")

        _workstationName = reader("Workstation_Name")
        _message = reader("Message")
        _timeOfAction = reader("Time_Of_Action")
    End Sub
#End Region

End Class


