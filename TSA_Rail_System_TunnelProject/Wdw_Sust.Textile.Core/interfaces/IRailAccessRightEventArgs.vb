Namespace Interfaces
    Public Interface IRailAccessRightEventArgs
        Inherits IRoleAccessRightEventArgs
        ReadOnly Property RightNeeded() As List(Of RailAccessOptions)
    End Interface
End Namespace
