Imports System.Runtime.CompilerServices

Namespace Extensions
    Public Module UserTypeExtensions
        <Extension()>
        Function CanLogOtherUesrOut(ByVal user As LintUserType) As Boolean
            Return user = LintUserType.PRODUCTION_MANAGER OrElse
                user = LintUserType.SYSTEM_ADMINISTRATOR OrElse
                user = LintUserType.AREA_SUPERVISOR OrElse
                user = LintUserType.OPERATIONS_MANAGER OrElse
                user = LintUserType.PLANT_MANAGER OrElse
                user = LintUserType.SYSTEM_OPERATOR_SR
        End Function
    End Module
End Namespace
