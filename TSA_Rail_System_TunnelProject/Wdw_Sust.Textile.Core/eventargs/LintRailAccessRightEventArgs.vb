Imports Wdw_Sust.Textile.Core.Interfaces

Namespace EventArgs
    Public Class LintRailAccessRightEventArgs
        Inherits LintRoleAccessRightEventArgs
        Implements IRailAccessRightEventArgs

#Region "Fields"
        Private ReadOnly _rightsNeeded As List(Of RailAccessOptions)
        Private ReadOnly _castInfo As LintCastMember
#End Region

#Region "Properities"

        Public ReadOnly Property RightNeeded() As List(Of RailAccessOptions) Implements IRailAccessRightEventArgs.RightNeeded
            Get
                Return _rightsNeeded
            End Get
        End Property

#End Region

#Region "Methods"

#End Region

#Region "Constructors"
        Public Sub New(ByVal rightsNeeded As List(Of RailAccessOptions), Optional ByVal roles As List(Of LintUserType) = Nothing, Optional ByVal hasRight As Boolean = False, Optional ByVal message As String = "You don't have the right to perform this action!!")
            MyBase.New(roles, Plant.UNKNOWN, hasRight, message)
            _rightsNeeded = rightsNeeded
        End Sub

        Public Sub New(ByVal rightsNeeded As List(Of RailAccessOptions), ByVal plant As Plant, Optional ByVal roles As List(Of LintUserType) = Nothing, Optional ByVal hasRight As Boolean = False, Optional ByVal message As String = "You don't have the right to perform this action!!")
            MyBase.New(roles, plant, hasRight, message)
            _rightsNeeded = rightsNeeded
        End Sub

        Public Sub New(ByVal rightNeeded As RailAccessOptions, Optional ByVal roles As List(Of LintUserType) = Nothing, Optional ByVal hasRight As Boolean = False, Optional ByVal message As String = "You don't have the right to perform this action!!")
            MyBase.New(roles, Plant.UNKNOWN, hasRight, message)
            _rightsNeeded = New List(Of RailAccessOptions)({rightNeeded})
        End Sub

        Public Sub New(ByVal rightNeeded As RailAccessOptions, ByVal plant As Plant, Optional ByVal roles As List(Of LintUserType) = Nothing, Optional ByVal hasRight As Boolean = False, Optional ByVal message As String = "You don't have the right to perform this action!!")
            MyBase.New(roles, plant, hasRight, message)
            _rightsNeeded = New List(Of RailAccessOptions)({rightNeeded})
        End Sub

        Public Sub New(ByVal rightNeeded As RailAccessOptions, ByVal role As LintUserType, Optional ByVal hasRight As Boolean = False, Optional ByVal message As String = "You don't have the right to perform this action!!")
            MyBase.New(New List(Of LintUserType)({role}), Plant.UNKNOWN, hasRight, message)
            _rightsNeeded = New List(Of RailAccessOptions)({rightNeeded})
        End Sub

#End Region

    End Class
End Namespace

