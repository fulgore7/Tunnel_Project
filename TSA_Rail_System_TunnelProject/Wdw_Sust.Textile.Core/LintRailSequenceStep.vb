Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Core.Enums

Imports System.ComponentModel
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Interfaces
Imports System.Data

Public Class LintRailSequenceStep
    Implements ICanBeDirty

#Region "Fields"
    Public Property UniqueID As Integer
    Public Property StepNumber As Integer
    Public Property Description As String
    Public Property IsDirty As Boolean Implements ICanBeDirty.IsDirty
    ''' <summary>
    ''' If the step is active
    ''' </summary>
    Public Property IsActive As Boolean
    ''' <summary>
    ''' Indicate if the step is readonly, which is not changable from the GUI 
    ''' if the step is set to true in the database
    ''' </summary>
    Public ReadOnly Property IsReadOnly As Boolean
        Get
            Return RolesToModifySequence <= 0
        End Get
    End Property
#End Region

#Region "Properties"
    Public ReadOnly Property ListOfRoles As List(Of LintUserType)
        Get
            If IsDefaultAccess Then Return Nothing
            Dim roles As List(Of LintUserType) = GetListOfEnumsFromInteger(Of LintUserType)(RolesToModifySequence)
            roles.Remove(LintUserType.UNASSIGNED)
            Return roles
        End Get
    End Property
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        UniqueID = FixNull(Of Integer)(reader("Unique_ID"))
        StepNumber = FixNull(Of Integer)(reader("Sequence_Step"))
        Description = FixNull(Of String)(String.Format("Step {0} - {1}", reader("Sequence_Step"), reader("Sequence_Step_Description")))
        IsActive = FixNull(Of Boolean)(reader("Is_Step_Active"))
        RolesToModifySequence = FixNull(Of Integer)(reader("Roles_To_Modified"))
    End Sub

    Public Sub New()

    End Sub
#End Region

End Class

<Serializable()>
Partial Public Class LintRailSequenceStep
    Inherits NotifyableBase

#Region "Fields"
    Public Shared ReadOnly DefaultAllAccess As Integer = 16777215
    Private _rolesToModifySequence As Integer
#End Region

#Region "Properties"
    ''' <summary>
    ''' Roles to modify the step if it is defined in the database
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RolesToModifySequence() As Integer
        Get
            Return _rolesToModifySequence
        End Get
        Set(ByVal value As Integer)
            If SetField(_rolesToModifySequence, value) Then
                Console.WriteLine("_rolesToModifySequence: {0}", _rolesToModifySequence)
            End If
        End Set
    End Property

#Region "Sequence Edit Role Types"

    Public Property CanEditByAdmin As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.SYSTEM_ADMINISTRATOR
        End Get
        Set(ByVal value As Boolean)
            If CanEditByAdmin <> value Then
                SetEditRoleType(LintUserType.SYSTEM_ADMINISTRATOR, value)
                OnPropertyChanged("CanEditByAdmin")
            End If
        End Set
    End Property

    Public Property CanEditByEngineeringManager As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.ENGINEER_MANAGER
        End Get
        Set(ByVal value As Boolean)
            If CanEditByEngineeringManager <> value Then
                SetEditRoleType(LintUserType.ENGINEER_MANAGER, value)
                OnPropertyChanged("CanEditByEngineeringManager")
            End If
        End Set
    End Property

    Public Property CanEditByEngineeringLSM As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.ENGINEER_LSM
        End Get
        Set(ByVal value As Boolean)
            If CanEditByEngineeringLSM <> value Then
                SetEditRoleType(LintUserType.ENGINEER_LSM, value)
                OnPropertyChanged("CanEditByEngineeringLSM")
            End If
        End Set
    End Property

    Public Property CanEditByEngineeringLSMJr As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.ENGINEER_LSM_JR
        End Get
        Set(ByVal value As Boolean)
            If CanEditByEngineeringLSMJr <> value Then
                SetEditRoleType(LintUserType.ENGINEER_LSM_JR, value)
                OnPropertyChanged("CanEditByEngineeringLSMJr")
            End If
        End Set
    End Property

    Public Property CanEditBySystemsOperator As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.SYSTEM_OPERATOR
        End Get
        Set(ByVal value As Boolean)
            If CanEditBySystemsOperator <> value Then
                SetEditRoleType(LintUserType.SYSTEM_OPERATOR, value)
                OnPropertyChanged("CanEditBySystemsOperator")
            End If
        End Set
    End Property

    Public Property CanEditBySystemsOperatorSr As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.SYSTEM_OPERATOR_SR
        End Get
        Set(ByVal value As Boolean)
            If CanEditBySystemsOperatorSr <> value Then
                SetEditRoleType(LintUserType.SYSTEM_OPERATOR_SR, value)
                OnPropertyChanged("CanEditBySystemsOperatorSr")
            End If
        End Set
    End Property

    Public Property CanEditBySystemSupport As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.SYSTEM_SUPPORT
        End Get
        Set(ByVal value As Boolean)
            If CanEditBySystemSupport <> value Then
                SetEditRoleType(LintUserType.SYSTEM_SUPPORT, value)
                OnPropertyChanged("CanEditBySystemSupport")
            End If
        End Set
    End Property

    Public Property CanEditByOutsideVendor As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.OUTSIDE_VENDOR
        End Get
        Set(ByVal value As Boolean)
            If CanEditByOutsideVendor <> value Then
                SetEditRoleType(LintUserType.OUTSIDE_VENDOR, value)
                OnPropertyChanged("CanEditByOutsideVendor")
            End If
        End Set
    End Property

    Public Property CanEditByOperationsManager As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.OPERATIONS_MANAGER
        End Get
        Set(ByVal value As Boolean)
            If CanEditByOperationsManager <> value Then
                SetEditRoleType(LintUserType.OPERATIONS_MANAGER, value)
                OnPropertyChanged("CanEditByOperationsManager")
            End If
        End Set
    End Property

    Public Property CanEditByPlantManager As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.PLANT_MANAGER
        End Get
        Set(ByVal value As Boolean)
            If CanEditByPlantManager <> value Then
                SetEditRoleType(LintUserType.PLANT_MANAGER, value)
                OnPropertyChanged("CanEditByPlantManager")
            End If
        End Set
    End Property

    Public Property CanEditByAreaSupervisor As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.AREA_SUPERVISOR
        End Get
        Set(ByVal value As Boolean)
            If CanEditByAreaSupervisor <> value Then
                SetEditRoleType(LintUserType.AREA_SUPERVISOR, value)
                OnPropertyChanged("CanEditByAreaSupervisor")
            End If
        End Set
    End Property

    Public Property CanEditByEngineeringForman As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.ENGINEER_FOREMAN
        End Get
        Set(ByVal value As Boolean)
            If CanEditByEngineeringForman <> value Then
                SetEditRoleType(LintUserType.ENGINEER_FOREMAN, value)
                OnPropertyChanged("CanEditByEngineeringForman")
            End If
        End Set
    End Property

    Public Property CanEditByProductionManager As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.PRODUCTION_MANAGER
        End Get
        Set(ByVal value As Boolean)
            If CanEditByProductionManager <> value Then
                SetEditRoleType(LintUserType.PRODUCTION_MANAGER, value)
                OnPropertyChanged("CanEditByProductionManager")
            End If
        End Set
    End Property

    Public Property CanEditByEngineeringCraftSupport As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.ENGINEER_CRAFT_SUPPORT
        End Get
        Set(ByVal value As Boolean)
            If CanEditByEngineeringCraftSupport <> value Then
                SetEditRoleType(LintUserType.ENGINEER_CRAFT_SUPPORT, value)
                OnPropertyChanged("CanEditByEngineeringCraftSupport")
            End If
        End Set
    End Property

    Public Property CanEditByProductionOperator As Boolean
        Get
            Return _rolesToModifySequence And LintUserType.PRODUCTION_OPERATOR
        End Get
        Set(ByVal value As Boolean)
            If CanEditByProductionOperator <> value Then
                SetEditRoleType(LintUserType.PRODUCTION_OPERATOR, value)
                OnPropertyChanged("CanEditByProductionOperator")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Check if there is customization to the step that some roles will not be able to edit
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsDefaultAccess As Boolean
        Get
            Return RolesToModifySequence = DefaultAllAccess '(2 ^ 24 - 1) '2^24 - 1 All roles can modfiy as far as if the CM has right to edit sequence
        End Get
    End Property

#End Region

#End Region

#Region "Methods"
    Private Sub SetEditRoleType(ByVal userType As LintUserType, ByVal isEnabled As Boolean)
        If isEnabled Then
            _rolesToModifySequence += userType
        ElseIf Not isEnabled Then
            _rolesToModifySequence -= userType
        End If
    End Sub
#End Region

End Class


