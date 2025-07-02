Imports System.Runtime.CompilerServices

Public Module LintZoneExtensions
    <Extension()>
    Function UseCleanworkReleaseWeight(ByVal zone As LintZone) As Boolean
        Return zone = LintZone.CLEANWORK_EMPTY_BAG_RETURN OrElse
            zone = LintZone.CLEANWORK_FINISHING OrElse
            zone = LintZone.CLEANWORK_FLATWORK_DISCHARGER OrElse
            zone = LintZone.CLEANWORK_FLATWORK_MACHINE OrElse
            zone = LintZone.CLEANWORK_HAND_FOLD OrElse
            zone = LintZone.CLEANWORK_LOADING OrElse
            zone = LintZone.CLEANWORK_NEW_TOWEL_FOLD OrElse
            zone = LintZone.CLEANWORK_OFFGOING_BUFFER OrElse
            zone = LintZone.CLEANWORK_OLD_TOWEL_FOLD OrElse
            zone = LintZone.CLEANWORK_ONGOING_BUFFER OrElse
            zone = LintZone.CLEANWORK_STORAGE OrElse
            zone = LintZone.CLEANWORK_PLC OrElse
            zone = LintZone.CLEANWORK_TOWEL_FOLD_DISCHARGER OrElse
            zone = LintZone.WASHER_EXTRACTOR
    End Function

    <Extension()>
    Function UseClassifiedReleaseWeight(ByVal zone As LintZone) As Boolean
        Return zone = LintZone.CLASSIFIED_DISCHARGER OrElse
            zone = LintZone.CLASSIFIED_EMPTY_BAG_RETURN OrElse
            zone = LintZone.CLASSIFIED_OFFGOING_BUFFER OrElse
            zone = LintZone.CLASSIFIED_ONGOING_BUFFER OrElse
            zone = LintZone.CLASSIFIED_PLC OrElse
            zone = LintZone.CLASSIFIED_STORAGE OrElse
            zone = LintZone.SORTING OrElse
            zone = LintZone.CART_DUMPER OrElse
            zone = LintZone.TUNNEL_WASHER OrElse
            zone = LintZone.WASHDECK_PLC
    End Function
End Module