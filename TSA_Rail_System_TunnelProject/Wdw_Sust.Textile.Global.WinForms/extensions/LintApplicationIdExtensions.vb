Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports Wdw_Sust.Textile.Core.Enums

Public Module LintApplicationIdExtensions
    <Extension>
    Public Function GetApplicationIcon(ByVal appId As LintApplicationId) As Icon
        Select Case appId
            Case LintApplicationId.ASA_DATA_COLLECTION 'done
                Return My.Resources.donald_yellow
            Case LintApplicationId.ASA_PRODUCTIVITY_DISPLAY
                Return My.Resources.donald_blue
            Case LintApplicationId.ASA_RAIL_SYSTEM 'done
                Return My.Resources.donald_blue
            Case LintApplicationId.LINT_ALARM_DATA_COLLECTION
                Return My.Resources.mickey_orange
            Case LintApplicationId.LINT_DATA_AUTOMATIC_TRANSFER_PORTAL
                Return My.Resources.mickey_pink
            Case LintApplicationId.NSA_DATA_COLLECTION 'done
                Return My.Resources.minnie_yellow
            Case LintApplicationId.NSA_RAIL_SYSTEM 'done
                Return My.Resources.minnie_blue
            Case LintApplicationId.TSA_DATA_COLLECTION 'done
                Return My.Resources.goofy_yellow
            Case LintApplicationId.TSA_ENGINEERING_SHOP_WASHDECK_DISPLAY 'done
                Return My.Resources.mickey_light_blue
            Case LintApplicationId.TSA_RAIL_SYSTEM 'done
                'Return My.Resources.goofy_dev
                Return My.Resources.goofy_blue
            Case LintApplicationId.TSA_TEAM_DATA_COLLECTION 'done
                Return My.Resources.goofy_orange
            Case LintApplicationId.TSA_WORKFLOW_DATA_COLLECTION 'done
                Return My.Resources.goofy_purple
            Case LintApplicationId.TSA_WORKFLOW_SYSTEM
                Return My.Resources.goofy_red
            Case Else
                Return My.Resources.mickey_blue
        End Select
    End Function
End Module
