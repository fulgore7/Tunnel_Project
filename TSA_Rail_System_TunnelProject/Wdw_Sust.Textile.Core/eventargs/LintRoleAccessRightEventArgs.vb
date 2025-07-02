Imports Wdw_Sust.Textile.Core.Interfaces

Namespace EventArgs
    Public Class LintRoleAccessRightEventArgs
        Inherits System.EventArgs
        Implements IRoleAccessRightEventArgs

#Region "Fields"
        Private ReadOnly _roles As List(Of LintUserType)
#End Region

#Region "Properities"

        Public Property CancelAction() As Boolean Implements IRoleAccessRightEventArgs.CancelAction
        Public Property HasRight() As Boolean Implements IRoleAccessRightEventArgs.HasRight
        Public Property EmployeeId() As Integer Implements IRoleAccessRightEventArgs.EmployeeId
        Public Property UserType As LintUserType Implements IRoleAccessRightEventArgs.UserType
        Public Property PlantLocation As Plant Implements IRoleAccessRightEventArgs.PlantLocation
        Public Property Message As String Implements IRoleAccessRightEventArgs.Message
        Public ReadOnly Property RolesNeeded() As List(Of LintUserType) Implements IRoleAccessRightEventArgs.RolesNeeded
            Get
                Return _roles
            End Get
        End Property

#End Region

#Region "Constructors"

        Public Sub New(ByVal roles As List(Of LintUserType), ByVal plantLocation As Plant, Optional ByVal hasRight As Boolean = False, Optional ByVal message As String = "")
            Me.HasRight = hasRight
            Me.PlantLocation = plantLocation
            Me.Message = message
            _roles = roles
        End Sub

        Public Sub New(ByVal roles As List(Of LintUserType), Optional ByVal hasRight As Boolean = False)
            Me.HasRight = hasRight
            Me.PlantLocation = Plant.UNKNOWN
            Me.Message = Message
            _roles = roles
        End Sub

        Public Sub New(ByVal role As LintUserType, ByVal plantLocation As Plant, Optional ByVal hasRight As Boolean = False)
            Me.HasRight = hasRight
            Me.PlantLocation = plantLocation
            Me.Message = Message
            _roles = New List(Of LintUserType)({role})
        End Sub

        Public Sub New(ByVal role As LintUserType, Optional ByVal hasRight As Boolean = False)
            Me.HasRight = hasRight
            Me.PlantLocation = Plant.UNKNOWN
            Me.Message = Message
            _roles = New List(Of LintUserType)({role})
        End Sub

#End Region


    End Class


End Namespace
