
Imports System.Data.SqlClient
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Helpers


<Serializable()>
    Public Class LintCastMember
    Inherits LintObjectBase(Of LintCastMember)

#Region "Fields"
    Private _lintUserId As Integer?
    Private _futurailAccessLevel As Integer
    Private _LINTAdminAccessLevel As LintAdminAccessLevel
    Private _LINTAccessLevel As LintAccessLevel
    Private _productivityAccessLevel As Integer
    Private _employeeName As String
    Private _employeeID As Integer
    Private _userType As LintUserType
    Private _assignedShift As Shift
    Private _workAtTSA As Boolean
    Private _workAtFLO As Boolean
    Private _workAtNSA As Boolean
    Private _workAtASA As Boolean
    Private _isActive As Boolean
    Private _rfBadgeUserID As Integer
    Private _proxCardNumber As Integer
#End Region

#Region "Events"
    '<NonSerialized()> _
    'Public Event PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
#End Region

#Region "Properties"
    Public ReadOnly Property LintUserId() As Integer?
        Get
            Return _lintUserId
        End Get
    End Property

    Public Property ProxCardNumber() As Integer
        Get
            Return _assignedShift
        End Get
        Set(value As Integer)
            If _proxCardNumber <> value Then
                _proxCardNumber = value
            End If
        End Set
    End Property

    Public Property AssignedShift() As Shift
        Get
            Return _assignedShift
        End Get
        Set(value As Shift)
            If _assignedShift <> value Then
                _assignedShift = value
            End If
        End Set
    End Property


    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(value As Boolean)
            If _isActive <> value Then
                _isActive = value
            End If
        End Set
    End Property

    Public Property FirstName As String
    Public Property LastLoginTime As DateTime
    Public Property LastName As String

    Public ReadOnly Property FullName As String
        Get
            Return String.Format("{0} {1}", FirstName, LastName)
        End Get
    End Property

    Public ReadOnly Property FullNameInReverse As String
        Get
            Return String.Format("{0}, {1}", LastName, LastName)
        End Get
    End Property

    Public Property LINTAdminAccessLevel() As LintAdminAccessLevel
        Get
            Return _LINTAdminAccessLevel
        End Get
        Set(value As LintAdminAccessLevel)
            If _LINTAdminAccessLevel <> value Then
                _LINTAdminAccessLevel = value
            End If
        End Set
    End Property

    Public ReadOnly Property EmployeeName() As String
        Get
            If FirstName = String.Empty AndAlso LastName = String.Empty Then Return "Unknown"
            Return String.Format("{0} {1}", FirstName, LastName)
        End Get
    End Property

    Public Property ProductivityAccessLevel As Integer
        Get
            Return _productivityAccessLevel
        End Get
        Set(value As Integer)
            If _productivityAccessLevel <> value Then
                _productivityAccessLevel = value
            End If
        End Set
    End Property

    Public Property FuturailAccessLevel() As Integer
        Get
            Return _futurailAccessLevel
        End Get
        Set(ByVal value As Integer)
            If _futurailAccessLevel <> value Then
                _futurailAccessLevel = value
                Console.WriteLine("_futurailAccessLevel: {0}", _futurailAccessLevel)
                'RaisePropertyChangedEvent("FuturailAccessLevel")
                OnPropertyChanged(Function() FuturailAccessLevel)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Check if CM is working in multiple locations
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WorksInMultipleLocations As Boolean
        Get
            Dim location As Integer
            If WorkAtASA Then location += 1
            If WorkAtTSA Then location += 1
            If WorkAtNSA Then location += 1
            Return location > 1
        End Get
    End Property

    'Private Sub RaisePropertyChangedEvent(ByVal propertyName As String)
    '    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    'End Sub

    Public Property LintAccessLevel() As LintAccessLevel
        Get
            Return _LINTAccessLevel
        End Get
        Set(ByVal value As LintAccessLevel)
            _LINTAccessLevel = value
            'RaisePropertyChangedEvent("LINTAccessLevel")
            OnPropertyChanged(Function() LintAccessLevel)
        End Set
    End Property

    Public Property EmployeeID() As Integer
        Get
            Return _employeeID
        End Get
        Set(ByVal value As Integer)
            If _employeeID <> value Then
                _employeeID = value
            End If
        End Set
    End Property

    Public Property RFBadgeUserID() As Integer
        Get
            Return _rfBadgeUserID
        End Get
        Set(ByVal value As Integer)
            _rfBadgeUserID = value
        End Set
    End Property

    Public Property UserType() As LintUserType
        Get
            Return _userType
        End Get
        Set(ByVal value As LintUserType)
            If _userType <> value Then
                _userType = value
            End If
        End Set
    End Property

    Public Property WorkAtASA As Boolean
        Get
            Return _workAtASA
        End Get
        Set(ByVal value As Boolean)
            If _workAtASA <> value Then
                _workAtASA = value
            End If
        End Set
    End Property

    Public Property WorkAtNSA As Boolean
        Get
            Return _workAtNSA
        End Get
        Set(ByVal value As Boolean)
            If _workAtNSA <> value Then
                _workAtNSA = value
            End If
        End Set
    End Property

    Public Property WorkAtTSA As Boolean
        Get
            Return _workAtTSA
        End Get
        Set(ByVal value As Boolean)
            If _workAtTSA <> value Then
                _workAtTSA = value
            End If
        End Set
    End Property

    Public Property WorkAtFLO As Boolean
        Get
            Return _workAtFLO
        End Get
        Set(ByVal value As Boolean)
            If _workAtFLO <> value Then
                _workAtFLO = value
            End If
        End Set
    End Property

    Public Property AccountSetup As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.ACCOUNT_SETUP
        End Get
        Set(ByVal value As Boolean)
            If AccountSetup <> value Then
                SetRailAccessOptions(RailAccessOptions.ACCOUNT_SETUP, value)
            End If
        End Set
    End Property

    Public Property BagAccountEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_ACCOUNT_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagAccountEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_ACCOUNT_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagCallIDEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_CALL_ID_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagCallIDEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_CALL_ID_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagCategoryEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_CATEGORY_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagCategoryEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_CATEGORY_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagZeroDestinationEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_ZERO_DESTINATION_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagZeroDestinationEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_ZERO_DESTINATION_EDIT, value)
            End If
        End Set
    End Property

    Public Property DeleteBags As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.DELETE_BAGS
        End Get
        Set(ByVal value As Boolean)
            If DeleteBags <> value Then
                SetRailAccessOptions(RailAccessOptions.DELETE_BAGS, value)
            End If
        End Set
    End Property

    Public Property EditBags As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.EDIT_BAGS
        End Get
        Set(ByVal value As Boolean)
            If EditBags <> value Then
                SetRailAccessOptions(RailAccessOptions.EDIT_BAGS, value)
            End If
        End Set
    End Property

    Public Property BagPLCIDEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_PLC_ID_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagPLCIDEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_PLC_ID_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagRFTagEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_RF_TAG_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagRFTagEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_RF_TAG_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagSourceBinEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_SOURCE_BIN_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagSourceBinEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_SOURCE_BIN_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagStorageDestinationEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_STORAGE_DESTINATION_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagStorageDestinationEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_STORAGE_DESTINATION_EDIT, value)
            End If
        End Set
    End Property

    Public Property BagWeightEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_WEIGHT_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagWeightEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_WEIGHT_EDIT, value)
            End If
        End Set
    End Property

    Public Property CallOffEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.CALL_OFF_EDIT
        End Get
        Set(ByVal value As Boolean)
            If CallOffEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.CALL_OFF_EDIT, value)
            End If
        End Set
    End Property

    Public Property CallOffReset As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.CALL_OFF_RESET
        End Get
        Set(ByVal value As Boolean)
            If CallOffReset <> value Then
                SetRailAccessOptions(RailAccessOptions.CALL_OFF_RESET, value)
            End If
        End Set
    End Property

    Public Property CategorySetup As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.CATEGORY_SETUP
        End Get
        Set(ByVal value As Boolean)
            If CategorySetup <> value Then
                SetRailAccessOptions(RailAccessOptions.CATEGORY_SETUP, value)
            End If
        End Set
    End Property

    Public Property ChangeSequences As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.CHANGE_SEQUENCES
        End Get
        Set(ByVal value As Boolean)
            If ChangeSequences <> value Then
                SetRailAccessOptions(RailAccessOptions.CHANGE_SEQUENCES, value)
            End If
        End Set
    End Property

    Public Property BagDropDestinationEdit As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BAG_DROP_DESTINATION_EDIT
        End Get
        Set(ByVal value As Boolean)
            If BagDropDestinationEdit <> value Then
                SetRailAccessOptions(RailAccessOptions.BAG_DROP_DESTINATION_EDIT, value)
            End If
        End Set
    End Property

    Public Property ExpressProductSelection As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.EXPRESS_PRODUCT_SELECTION
        End Get
        Set(ByVal value As Boolean)
            If ExpressProductSelection <> value Then
                SetRailAccessOptions(RailAccessOptions.EXPRESS_PRODUCT_SELECTION, value)
            End If
        End Set
    End Property

    Public Property Calibration As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.CALIBRATION
        End Get
        Set(ByVal value As Boolean)
            If Calibration <> value Then
                SetRailAccessOptions(RailAccessOptions.CALIBRATION, value)
            End If
        End Set
    End Property

    Public Property SystemConfiguration As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.SYSTEM_CONFIGURATION
        End Get
        Set(ByVal value As Boolean)
            If SystemConfiguration <> value Then
                SetRailAccessOptions(RailAccessOptions.SYSTEM_CONFIGURATION, value)
            End If
        End Set
    End Property

    Public Property RunDownSystem As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.RUN_DOWN_SYSTEM
        End Get
        Set(ByVal value As Boolean)
            If RunDownSystem <> value Then
                SetRailAccessOptions(RailAccessOptions.RUN_DOWN_SYSTEM, value)
            End If
        End Set
    End Property

    Public Property CanBlockUnblockRail As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.BLOCK_UNBLOCK_RAIL
        End Get
        Set(ByVal value As Boolean)
            If CanBlockUnblockRail <> value Then
                SetRailAccessOptions(RailAccessOptions.BLOCK_UNBLOCK_RAIL, value)
            End If
        End Set
    End Property

#Region "LINT Access Level"

    Public Property EditUser As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER
            End Get
            Set(ByVal value As Boolean)
                If EditUser <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER, value)
                End If
            End Set
        End Property

        Public Property AddUser As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.ADD_USER
            End Get
            Set(ByVal value As Boolean)
                If AddUser <> value Then
                    SetLINTAccessLevel(LintAccessLevel.ADD_USER, value)
                End If
            End Set
        End Property

        Public Property DeleteUser As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.DELETE_USER
            End Get
            Set(ByVal value As Boolean)
                If DeleteUser <> value Then
                    SetLINTAccessLevel(LintAccessLevel.DELETE_USER, value)
                End If
            End Set
        End Property

        Public Property EditUserType As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_TYPE
            End Get
            Set(ByVal value As Boolean)
                If EditUserType <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_TYPE, value)
                End If
            End Set
        End Property

        Public Property EditUserWorkLocation As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_WORK_LOCATION
            End Get
            Set(ByVal value As Boolean)
                If EditUserWorkLocation <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_WORK_LOCATION, value)
                End If
            End Set
        End Property
        Public Property EditUserActiveStatus As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_ACTIVE_STATUS
            End Get
            Set(ByVal value As Boolean)
                If EditUserActiveStatus <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_ACTIVE_STATUS, value)
                End If
            End Set
        End Property
        Public Property EditUserRailOptions As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_RAIL_OPTIONS
            End Get
            Set(ByVal value As Boolean)
                If EditUserRailOptions <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_RAIL_OPTIONS, value)
                End If
            End Set
        End Property

        Public Property EditUserSystemConfiguration As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_SYSTEM_CONFIGURATION
            End Get
            Set(ByVal value As Boolean)
                If EditUserSystemConfiguration <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_SYSTEM_CONFIGURATION, value)
                End If
            End Set
        End Property

        Public Property EditUserProductivityTargets As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_PRODUCTIVITY_TARGETS
            End Get
            Set(ByVal value As Boolean)
                If EditUserProductivityTargets <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_PRODUCTIVITY_TARGETS, value)
                End If
            End Set
        End Property

        Public Property EditCard As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_CARD
            End Get
            Set(ByVal value As Boolean)
                If EditCard <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_CARD, value)
                End If
            End Set
        End Property

        Public Property EditEmployeeID As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_EMPLOYEE_ID
            End Get
            Set(ByVal value As Boolean)
                If EditEmployeeID <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_EMPLOYEE_ID, value)
                End If
            End Set
        End Property

        Public Property EditUserName As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_USER_NAME
            End Get
            Set(ByVal value As Boolean)
                If EditUserName <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_USER_NAME, value)
                End If
            End Set
        End Property

        Public Property AddCard As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.ADD_CARD
            End Get
            Set(ByVal value As Boolean)
                If AddCard <> value Then
                    SetLINTAccessLevel(LintAccessLevel.ADD_CARD, value)
                End If
            End Set
        End Property

        Public Property EditCardAssignment As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_CARD_ASSIGNMENT
            End Get
            Set(ByVal value As Boolean)
                If EditCardAssignment <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_CARD_ASSIGNMENT, value)
                End If
            End Set
        End Property
        Public Property EditShift As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_SHIFT
            End Get
            Set(ByVal value As Boolean)
                If EditShift <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_SHIFT, value)
                End If
            End Set
        End Property

        Public Property ReturnCard As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.RETURN_CARD
            End Get
            Set(ByVal value As Boolean)
                If ReturnCard <> value Then
                    SetLINTAccessLevel(LintAccessLevel.RETURN_CARD, value)
                End If
            End Set
        End Property

        Public Property DeleteCard As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.DELETE_CARD
            End Get
            Set(ByVal value As Boolean)
                If DeleteCard <> value Then
                    SetLINTAccessLevel(LintAccessLevel.DELETE_CARD, value)
                End If
            End Set
        End Property

        Public Property EditCardNumber As Boolean
            Get
                Return _LINTAccessLevel And LintAccessLevel.EDIT_CARD_NUMBER
            End Get
            Set(ByVal value As Boolean)
                If EditCardNumber <> value Then
                    SetLINTAccessLevel(LintAccessLevel.EDIT_CARD_NUMBER, value)
                End If
            End Set
        End Property

    Public Property ResetProductionNumbers As Boolean
        Get
            Return _futurailAccessLevel And RailAccessOptions.RESET_PRODUCTION_NUMBERS
        End Get
        Set(value As Boolean)
            If ResetProductionNumbers <> value Then
                SetRailAccessOptions(RailAccessOptions.RESET_PRODUCTION_NUMBERS, value)
            End If
        End Set
    End Property

    Public Property LogOperatorOffOfStation() As Boolean
        Get
            Return _LINTAccessLevel And LintAccessLevel.LOG_OPERATOR_OFF_OF_STATION
        End Get
        Set(ByVal value As Boolean)
            SetLINTAccessLevel(LintAccessLevel.LOG_OPERATOR_OFF_OF_STATION, value)
        End Set
    End Property

    Public Property TeamSetMachineStatus() As Boolean
        Get
            Return _LINTAccessLevel And LintAccessLevel.TEAM_SET_MACHINE_STATUS
        End Get
        Set(ByVal value As Boolean)
            SetLINTAccessLevel(LintAccessLevel.TEAM_SET_MACHINE_STATUS, value)
        End Set
    End Property

    Public ReadOnly Property HasFuturailAccessRights As Boolean
            Get
                Return _futurailAccessLevel > 0 AndAlso IsActive
            End Get
        End Property

        Public ReadOnly Property HasLintAccessRights As Boolean
            Get
                Return _LINTAccessLevel > 0 AndAlso IsActive
            End Get
        End Property

#End Region
#End Region

#Region "Methods"
        Shared Function CreateTestLINTCastMemberInfo(Optional ByVal accessRight As DefaultRailAccessLevel = DefaultRailAccessLevel.SYSTEM_ADMINISTRATOR) As LintCastMember
            Return New LintCastMember() With {.FuturailAccessLevel = accessRight}
        End Function

        Public Function IsWorkingInPlant(plant As Plant) As Boolean
            Return (plant = Plant.ASA AndAlso WorkAtASA) OrElse
                   (plant = Plant.TSA AndAlso WorkAtTSA) OrElse
                   (plant = Plant.NSA AndAlso WorkAtNSA)
        End Function

        Private Sub SetLINTAccessLevel(ByVal accessLevel As LintAccessLevel, ByVal isEnabled As Boolean)
            If isEnabled Then
                _LINTAccessLevel += accessLevel
            ElseIf Not isEnabled Then
                _LINTAccessLevel -= accessLevel
            End If
        End Sub

        Private Sub SetRailAccessOptions(ByVal accessLevel As RailAccessOptions, ByVal isEnabled As Boolean)
            If isEnabled Then
                _futurailAccessLevel += accessLevel
            ElseIf Not isEnabled Then
                _futurailAccessLevel -= accessLevel
            End If
        End Sub

    Public Function GetWorkLocation() As Plant
        If WorksInMultipleLocations Then Return Plant.MULTIPLE_PLANTS
        If WorkAtASA Then
            Return Plant.ASA
        ElseIf WorkAtNSA Then
            Return Plant.NSA
        ElseIf WorkAtTSA Then
            Return Plant.TSA
        ElseIf WorkAtFLO Then
            Return Plant.FLO
        End If
        Return Plant.TSA
    End Function
#End Region

#Region "Constructors"
    Public Sub New()

        End Sub

    Public Sub New(ByVal reader As SqlDataReader)
        _lintUserId = reader("lint_user_id")
        _futurailAccessLevel = reader("Futurail_access_level")
        _LINTAdminAccessLevel = reader("Admin_access_level")
        _LINTAccessLevel = reader("Lint_access_level")
        _rfBadgeUserID = reader("RF_Badge_User_ID")
        _productivityAccessLevel = reader("Productivity_access_level")
        _employeeName = reader("employee_name")
        _employeeID = reader("employee_id")
        _userType = reader("user_type")
        _assignedShift = reader("Assigned_Shift")
        _isActive = reader("Is_Active")
        _workAtASA = reader("Works_at_ASA")
        _workAtNSA = reader("Works_at_NSA")
        _workAtTSA = reader("Works_at_TSA")
        FirstName = FixNull(Of String)(reader("First_Name"), String.Empty)
        LastName = FixNull(Of String)(reader("Last_Name"), String.Empty)
        LastLoginTime = FixNull(Of DateTime)(reader("Last_Login_Time"))
    End Sub
#End Region

End Class


