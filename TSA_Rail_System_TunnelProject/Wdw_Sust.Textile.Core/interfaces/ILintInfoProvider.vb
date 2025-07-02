Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core

Namespace Interfaces
    Public Interface ILintInfoProvider
        Inherits IHaveConnectionString

        Sub AddLintImageResources(image As LintImage)
        Sub AddLintUser(userDetail As LintCastMember)
        Sub AddLog(employeeID As Integer, rfBadgeUserID As Integer, message As String)
        Sub DeleteLintUser(employeeID As Integer)
        Sub DeleteRfidCardFromDatabase(cardNumber As String, dateOccurred As Date, editedBy As Integer)
        Sub UpdateLintUser(userDetail As LintCastMember, originalEmployeeID As Integer)
        Sub UpdateTsaMachineStatus(machineID As Integer, machineStatus As Boolean)
        Function AddRfidCardToDatabase(rfBadgeGUIDHiWord As Long, rfBadgeGUIDLoWord As Long, rfBadgeUserID As Integer, assignedTo As String, timeIssued As Date, timeUnassigned As Date, cardValid As Boolean, editedByID As Integer) As Boolean
        Function CheckIfUserExists(employeeID As Integer, Optional isOnlyActive As Boolean = True) As Boolean
        Function CheckIfUserExists(employeeName As String, Optional isOnlyActive As Boolean = True) As Boolean
        Function GetAllUserIDs() As List(Of RfidCard)
        Function GetCardInfoWithUserDetailsByEmployeeNumber(employeeNumber As Integer) As RfidCard
        Function GetCardInfoWithUserDetailsByRfidCard(rfidCard As RfidCard) As RfidCard
        Function GetCastMemberNamesByWildCards(wildCards As String, Optional isOnlyActive As Boolean = True) As String()
        Function GetEmployeeIDByRFIDNumber(rfBadgeUserID As Integer) As String
        Function GetEmployeeNameByEmployeeID(employeeID As String) As String
        Function GetEmployeeNameByRFIDNumber(rfBadgeUserID As Integer) As String
        Function GetImageTypeId(imageTypeDescription As String) As Integer
        Function GetImageTypes() As String()
        Function GetLintShifts() As List(Of LintKeyValuePair(Of Shift, String))
        Function GetLINTUser(rfidNumber As Integer, perner As Integer) As LintCastMember
        Function GetLintUsers(Optional isActiveOnly As Boolean = False) As List(Of LintCastMember)
        Function GetLintUserType(userName As String) As Integer
        Function GetLintUserTypes() As List(Of LintKeyValuePair(Of LintUserType, String))
        Function GetLintUserTypes(userType As LintUserType) As List(Of LintKeyValuePair(Of LintUserType, String))
        Function GetNumberOfActiveEmployees() As Integer
        Function GetNumberOfCardReassignmentsByEmployeeID(employeeID As String) As Integer
        Function GetRfidCardInfoByRfidNumber(rfBadgeUserID As Integer) As RfidCard
        Function GetTsaInUseCategories() As List(Of Integer)
        Function GetUserLINTAccessLevel(employeeName As String) As Integer
        Function RfidCardReturnToDatabase(name As String, rf_badge_user_id As Integer, time_unassigned As Date, edited_by As String) As Boolean
        Function UpdateCardInfo(card As RfidCard, editedBy As Integer, assignmentReason As Integer) As Boolean
    End Interface
End Namespace
