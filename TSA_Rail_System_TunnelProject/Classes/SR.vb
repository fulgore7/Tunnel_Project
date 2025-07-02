Public Module SR
    Public Const WORKFLOW_NOT_RUNNING As String = "Workflow is not running, make sure it is running in the war room!"
    Public Const WORKFLOW_CALCULATION_ERROR As String = "Calculation error occurred! Please try again in 5 Minutes! If continues, please call Systems Team for assistance!"
    Public Const WORKFLOW_CALCULATION_STARTED As String = "Auto call off calculation started!"
    Public Const WORKFLOW_CALCULATION_COMPLETED As String = "Auto call off calculation completed!"
    Public Const WORKFLOW_NEXT_CALL_OFF_RUN_TIME As String = "Next call off will run at: {0}"

    Public Const ALARM_UPDATE_IN_SECOND As String = "Update alarms in {0:F2} seconds"

    Public Const INFORMATION_TOTAL_WASHED As String = "Washed: {0:F0} lbs. ({1} Bags)"
    Public Const INFORMATION_TOTAL_SORTED As String = "Sorted: {0:F0} lbs. ({1} Bags)"
    Public Const INFORMATION_NUMBER_OF_CLEAN_BAG As String = "Cleanwork Bags: {0} ({1:P0})"
    Public Const INFORMATION_NUMBER_OF_CLASSIFIED_BAG As String = "Classified Bags: {0} ({1:P0})"
    Public Const INFORMATION_WASHER As String = "Washers: {0}/{1}"
    Public Const INFORMATION_DRYER As String = "Dryers: {0}/{1} ({2:P0})"
    Public Const INFORMATION_LOGIN As String = "FW: {0}, TF: {1}"
    Public Const INFORMATION_BREAK_IN_PROGRESS As String = "Break in Progress"
    Public Const INFORMATION_NO_LOG_IN As String = "No Login Information"
    Public Const INFORMATION_NO_RECORDED_LAST_ACTION As String = "Last Action: Not Recorded"
    Public Const INFORMATION_ACTIVE_ALARM_COUNTS As String = "Active Alarms: {0}"

    Public Const WARNING_NO_RIGHT_RUNNING_AUTO_CALL_OFF As String = "You don't have the right to run the auto-call off!!"
    Public Const WARNING_SELECT_ACTIVE_FORM_TO_PRINT As String = "Select an active form to print!"
    Public Const WARNING_SCAN_ID_AGAIN As String = "Please scan your ID again!!"
    Public Const WARNING_NO_RIGHT_PERFORM_ACTION_AT_WORKSTATION As String = "You cannot perform this action on this workstation: {0}"
    Public Const WARNING_FEATURE_NOT_AVAILABLE_IN_FAIL_OVER_MODE As String = "Program is in fail over mode!! No data is available. Please try again when the program is in production mode!!"
    Public Const WARNING_BAG_CANNOT_BE_EDITED_IN_PC As String = "*This bag cannot be edited from this PC!!"

    Public Const JOB_CHECK_WORKFLOW_HOST As String = "Check_Workflow_Host"
    Public Const JOB_GET_WASHDECK_AUTOMATIC_PRODUCTIVITY_UPDATE As String = "Get_Washdeck_Automatic_Productivity_Upate"
    Public Const JOB_GET_CLEANWORK_PRODUCTIVITY As String = "Get_Cleanwork_Productivity"
    Public Const JOB_GET_PLANT_PRODUCT_DISTRIBUTION As String = "Get_Plant_Product_Distribution"
    Public Const JOB_GET_BAG_WASHED_AND_SORTED As String = "Get_Bag_Washed_And_Sorted"
    Public Const JOB_PING_APPLICATION_SERVER As String = "Ping_Application_Service"

    Public Const OPC_GROUP_GLOBAL_PARAMETER As String = "Global_Parameters"

End Module
