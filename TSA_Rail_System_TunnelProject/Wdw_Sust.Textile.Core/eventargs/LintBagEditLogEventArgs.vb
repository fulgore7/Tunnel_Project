Namespace EventArgs
    Public Class LintBagEditLogEventArgs
        Inherits System.EventArgs
#Region "Fields"
        Private _oldCategoryCode As Integer
        Private _oldStorageRail As Integer
        Private _oldDropDestination As Integer
        Private _oldSortingStation As Integer
        Private _oldPLCBagID As Integer
        Private _newCategoryCode As Integer
        Private _newStorageRail As Integer
        Private _newDropDestination As Integer
        Private _newSortingStation As Integer
        Private _newPLCBagID As Integer
        Private _railActionID As LintAction
        Private _zoneID As LintZone
        Private _employeeID As Integer
        Private _timeOfAction As DateTime
        Private _message As String
        Private _workstationName As String
#End Region

#Region "Properities"
        Public Property Message() As String
            Get
                Return _message
            End Get
            Set(ByVal value As String)
                _message = value
            End Set
        End Property

        Public ReadOnly Property NewCategoryCode() As Integer
            Get
                Return _newCategoryCode
            End Get
        End Property

        Public ReadOnly Property NewDropDestination() As Integer
            Get
                Return _newDropDestination
            End Get
        End Property

        Public ReadOnly Property NewPLCBagID() As Integer
            Get
                Return _newPLCBagID
            End Get
        End Property

        Public ReadOnly Property NewSortingStation() As Integer
            Get
                Return _newSortingStation
            End Get
        End Property

        Public ReadOnly Property NewStorageRail() As Integer
            Get
                Return _newStorageRail
            End Get
        End Property

        Public ReadOnly Property OldCategoryCode() As Integer
            Get
                Return _oldCategoryCode
            End Get
        End Property

        Public ReadOnly Property OldDropDestination() As Integer
            Get
                Return _oldDropDestination
            End Get
        End Property

        Public ReadOnly Property OldPLCBagID() As Integer
            Get
                Return _oldPLCBagID
            End Get
        End Property

        Public ReadOnly Property EmployeeID() As Integer
            Get
                Return _employeeID
            End Get
        End Property

        Public ReadOnly Property OldSortingStation() As Integer
            Get
                Return _oldSortingStation
            End Get
        End Property

        Public ReadOnly Property OldStorageRail() As Integer
            Get
                Return _oldStorageRail
            End Get
        End Property

        Public ReadOnly Property RailActionID() As LintAction
            Get
                Return _railActionID
            End Get
        End Property

        Public ReadOnly Property TimeOfAction() As DateTime
            Get
                Return _timeOfAction
            End Get
        End Property

        Public ReadOnly Property WorkstationName() As String
            Get
                Return _workstationName
            End Get
        End Property

        Public ReadOnly Property ZoneID() As LintZone
            Get
                Return _zoneID
            End Get
        End Property
#End Region

#Region "Constructors"
        Public Sub New(ByVal employeeID As Integer, ByVal railAction As LintAction, ByVal oldStorageRail As Integer, ByVal oldCategoryCode As Integer, ByVal oldDropDestination As Integer,
                       ByVal oldSortingStation As Integer, ByVal oldPLCBagID As Integer, ByVal newStorageRail As Integer, ByVal newCategoryCode As Integer, ByVal newDropDestination As Integer,
                       ByVal newSortingStation As Integer, ByVal newPLCBagID As Integer, ByVal zone As LintZone, ByVal message As String, ByVal workstationName As String)
            _message = message
            _oldCategoryCode = oldCategoryCode
            _oldDropDestination = oldDropDestination
            _oldSortingStation = oldSortingStation
            _oldStorageRail = oldStorageRail
            _oldPLCBagID = oldPLCBagID
            _timeOfAction = Now
            _newPLCBagID = newPLCBagID
            _newDropDestination = newDropDestination
            _newStorageRail = newStorageRail
            _newSortingStation = newSortingStation
            _newCategoryCode = newCategoryCode
            _zoneID = zone
            _railActionID = railAction
            _employeeID = employeeID
            _workstationName = workstationName
        End Sub
        Public Sub New(before As LintBagDetail, after As LintBagDetail, zone As LintZone, railAction As LintAction, employeeId As Integer, ByVal message As String, workStationName As String)
            _message = message
            _oldCategoryCode = before.Category
            _oldDropDestination = before.Drop_Destination
            _oldSortingStation = before.SourceBin
            _oldStorageRail = before.Storage_Destination
            _oldPLCBagID = before.PLC_Bag_ID
            _timeOfAction = Now
            _newPLCBagID = after.PLC_Bag_ID
            _newDropDestination = after.Drop_Destination
            _newStorageRail = after.Storage_Destination
            _newSortingStation = after.SourceBin
            _newCategoryCode = after.Category
            _zoneID = zone
            _railActionID = railAction
            _employeeID = employeeId
            _workstationName = workStationName
        End Sub
#End Region

    End Class
End Namespace
