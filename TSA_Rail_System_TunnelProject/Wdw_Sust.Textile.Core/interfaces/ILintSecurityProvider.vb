Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Interfaces

Namespace Interfaces
    Public Interface ILintSecurityProvider
        Inherits IHavePlant
        'Sub CheckRailAccessRights(e As IRailAccessRightEventArgs)
        'Sub CheckRailAccessRights(sender As Object, e As IRailAccessRightEventArgs)
        Sub CheckRailAccessRights(card As RfidCard, e As IRailAccessRightEventArgs)
        'Sub CheckRoleAccessRights(sender As Object, e As IRoleAccessRightEventArgs)
        Sub CheckRoleAccessRights(card As RfidCard, e As IRoleAccessRightEventArgs)
        Function HasFuturailAccessRight(rfidCard As RfidCard, accessRight As RailAccessOptions) As Boolean
        Function HasLintAccessRight(userRight As LintAccessLevel, accessRight As LintAccessLevel) As Boolean
        Function HasLINTAccessRight(rfidcard As RfidCard, accessRight As LintAdminAccessLevel) As Boolean
        Function HasRailAccessRight(userRight As Integer, accessRight As List(Of RailAccessOptions)) As Boolean
        Function HasRailAccessRight(rfidcard As RfidCard, accessRight As List(Of RailAccessOptions)) As Boolean
        Function HasRailAccessRight(rfidCard As RfidCard, accessRight As List(Of RailAccessOptions), roles As List(Of LintUserType)) As Boolean
        Function HasRailAccessRight(rfidcard As RfidCard, accessRight As RailAccessOptions, role As LintUserType) As Boolean
        Function HasRoleAccessRight(rfidCard As RfidCard, roles As List(Of LintUserType)) As Boolean
        Function IsUserTypeSupported(userType As LintUserType, userTypeNeeded As LintUserType) As Boolean
    End Interface
End Namespace
