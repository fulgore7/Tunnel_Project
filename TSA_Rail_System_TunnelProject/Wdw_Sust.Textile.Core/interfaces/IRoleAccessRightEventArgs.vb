Namespace Interfaces
    Public Interface IRoleAccessRightEventArgs
        Property HasRight() As Boolean
        Property CancelAction() As Boolean
        Property EmployeeId() As Integer
        Property UserType As LintUserType
        Property PlantLocation As Plant
        Property Message() As String
        ReadOnly Property RolesNeeded() As List(Of LintUserType)
    End Interface
End Namespace