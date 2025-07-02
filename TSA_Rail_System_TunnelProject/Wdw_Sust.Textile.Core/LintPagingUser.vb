Imports System.Data

Public Class LintPagingUser

#Region "Fields"


#End Region

#Region "Events"
    Public Event _EligibilityToReceiveAlarm(ByVal sender As Object, ByVal e As LintReceiveAlarmEventArgs)
#End Region

#Region "Properties"
    Public Property EmployeeName() As String
    Public Property EmployeeID() As String
    Public Property MessagePreference() As New MessagingPreferences
    Public Property RailAccessLevel() As Integer
    Public Property ProductivityAccessLevel() As Integer
    Public Property AdminAccessLevel() As Integer
    Public Property RFBadgeuserID() As Integer
    Public Property Department() As String
    Public Property WorkLocation() As String
    Public Property UserType() As Integer
    Public Property WorksAtTSA() As Boolean
    Public Property WorksAtASA() As Boolean
    Public Property WorksAtNSA() As Boolean
    Public Property MaxmessagePageLength() As Integer
    Public Property GetTSAmessages() As Boolean
    Public Property GetASAmessages() As Boolean
    Public Property GetNSAmessages() As Boolean
    Public Property EmailAddress() As String
    Public Property EmployeeFirstName() As String
    Public Property EmployeeLastName() As String
#End Region

#Region "Methods"
    Public Function IsIncludeWorkLocationMessagesOnlyTestPassed(messageAssociatedByPlant As Plant) As Boolean
        If MessagePreference.IncludeWorkLocationMessagesOnly Then
            If (WorksAtTSA = True AndAlso messageAssociatedByPlant = Plant.TSA) OrElse
               (WorksAtNSA = True AndAlso messageAssociatedByPlant = Plant.NSA) OrElse
               (WorksAtASA = True AndAlso messageAssociatedByPlant = Plant.ASA) Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function
#End Region

#Region "Constructors"
    Public Sub New(reader As IDataReader)

        EmployeeName = CType(reader("employee_name"), String)
        EmployeeID = CType(reader("employee_ID"), String)
        If reader("First_Name") IsNot System.DBNull.Value Then
            EmployeeFirstName = CType(reader("First_Name"), String)
        End If
        If reader("Last_Name") IsNot System.DBNull.Value Then
            EmployeeLastName = CType(reader("Last_Name"), String)
        End If
        Department = CType(reader("department"), String)
        WorkLocation = CType(reader("work_location"), String)
        UserType = CType(reader("user_type"), Integer)
        WorksAtTSA = CType(reader("works_at_TSA"), Boolean)
        WorksAtASA = CType(reader("works_at_ASA"), Boolean)
        WorksAtNSA = CType(reader("works_at_NSA"), Boolean)
        If reader("Portal_ID") IsNot System.DBNull.Value Then
            MessagePreference.PortalID = CType(reader("Portal_ID"), String)
        End If
        If reader("Blackberry_PIN") IsNot System.DBNull.Value Then
            MessagePreference.BlackberryPIN = CType(reader("Blackberry_PIN"), String)
        End If
        If reader("Blackberry_Service_Provider") IsNot System.DBNull.Value Then
            MessagePreference.BlackberryServiceProvider = CType(reader("Blackberry_Service_Provider"), String)
        End If
        If reader("Email_Address") IsNot System.DBNull.Value Then
            MessagePreference.EmailAddress = CType(reader("Email_Address"), String)
        End If
        If reader("Nextel_PIN") IsNot System.DBNull.Value Then
            MessagePreference.NextelPIN = CType(reader("Nextel_PIN"), String)
        End If
        If reader("Nextel_Service_Provider") IsNot System.DBNull.Value Then
            MessagePreference.NextelServiceProvider = CType(reader("Nextel_Service_Provider"), String)
        End If
        If reader("Pager_PIN") IsNot System.DBNull.Value Then
            MessagePreference.PagerPIN = CType(reader("Pager_PIN"), String)
        End If
        If reader("Pager_Service_Provider") IsNot System.DBNull.Value Then
            MessagePreference.PagerServiceProvider = CType(reader("Pager_Service_Provider"), String)
        End If
        If reader("Personal_Cell_PIN") IsNot System.DBNull.Value Then
            MessagePreference.PersonalCellPIN = CType(reader("Personal_Cell_PIN"), String)
        End If
        If reader("Personal_Cell_Provider") IsNot System.DBNull.Value Then
            MessagePreference.PersonalCellProvider = CType(reader("Personal_Cell_Provider"), String)
        End If
        If reader("Include_Component") IsNot System.DBNull.Value Then
            MessagePreference.IncludeComponent = CType(reader("Include_Component"), Boolean)
        End If
        If reader("Include_Department") IsNot System.DBNull.Value Then
            MessagePreference.IncludeDepartment = CType(reader("Include_Department"), Boolean)
        End If
        If reader("Include_History") IsNot System.DBNull.Value Then
            MessagePreference.IncludeHistory = CType(reader("Include_History"), Boolean)
        End If
        If reader("Include_Hyperlink") IsNot System.DBNull.Value Then
            MessagePreference.IncludeHyperlink = CType(reader("Include_Hyperlink"), Boolean)
        End If
        If reader("Include_Machine") IsNot System.DBNull.Value Then
            MessagePreference.IncludeMachine = CType(reader("Include_Machine"), Boolean)
        End If
        If reader("Include_Plant") IsNot System.DBNull.Value Then
            MessagePreference.IncludePlant = CType(reader("Include_Plant"), Boolean)
        End If
        If reader("Include_System") IsNot System.DBNull.Value Then
            MessagePreference.IncludeSystem = CType(reader("Include_System"), Boolean)
        End If
        If reader("Include_Zone") IsNot System.DBNull.Value Then
            MessagePreference.IncludeZone = CType(reader("Include_Zone"), Boolean)
        End If
        If reader("Include_Work_Location_Messages_Only") IsNot System.DBNull.Value Then
            MessagePreference.IncludeWorkLocationMessagesOnly = CType(reader("Include_Work_Location_Messages_Only"), Boolean)
        End If
        If reader("Minimum_Severity_Level_Computer_Faults") IsNot System.DBNull.Value Then
            MessagePreference.MinimumSeverityLevelComputerFaults = CType(reader("Minimum_Severity_Level_Computer_Faults"), Integer)
        End If
        If reader("Minimum_Severity_Level_Electrical_Faults") IsNot System.DBNull.Value Then
            MessagePreference.MinimumSeverityLevelElectricalFaults = CType(reader("Minimum_Severity_Level_Electrical_Faults"), Integer)
        End If
        If reader("Minimum_Severity_Level_Exceptions") IsNot System.DBNull.Value Then
            MessagePreference.MinimumSeverityLevelExceptions = CType(reader("Minimum_Severity_Level_Exceptions"), Integer)
        End If
        If reader("Minimum_Severity_Level_General_Faults") IsNot System.DBNull.Value Then
            MessagePreference.MinimumSeverityLevelGeneralFaults = CType(reader("Minimum_Severity_Level_General_Faults"), Integer)
        End If
        If reader("Minimum_Severity_Level_Mechanical_Faults") IsNot System.DBNull.Value Then
            MessagePreference.MinimumSeverityLevelMechanicalFaults = CType(reader("Minimum_Severity_Level_Mechanical_Faults"), Integer)
        End If
        If reader("Minimum_Severity_Level_Productivity_Faults") IsNot System.DBNull.Value Then
            MessagePreference.MinimumSeverityLevelProductivityFaults = CType(reader("Minimum_Severity_Level_Productivity_Faults"), Integer)
        End If
        If reader("Earliest_Message_Time") IsNot System.DBNull.Value Then
            MessagePreference.EarliestMessageTime = CType(reader("Earliest_Message_Time"), Date)
        End If
        If reader("Latest_Message_Time") IsNot System.DBNull.Value Then
            MessagePreference.LatestMessageTime = CType(reader("Latest_Message_Time"), Date)
        End If
        If reader("Send_Email_Anytime") IsNot System.DBNull.Value Then
            MessagePreference.SendEmailAnytime = CType(reader("Send_Email_Anytime"), Boolean)
        End If
        If reader("Send_Email_Confirmation") IsNot System.DBNull.Value Then
            MessagePreference.SendEmailConfirmation = CType(reader("Send_Email_Confirmation"), Boolean)
        End If
        If reader("Send_to_Blackberry") IsNot System.DBNull.Value Then
            MessagePreference.SendToBlackberry = CType(reader("Send_to_Blackberry"), Boolean)
        End If
        If reader("Send_to_Nextel") IsNot System.DBNull.Value Then
            MessagePreference.SendToNextel = CType(reader("Send_to_Nextel"), Boolean)
        End If
        If reader("Send_to_Pager") IsNot System.DBNull.Value Then
            MessagePreference.SendToPager = CType(reader("Send_to_Pager"), Boolean)
        End If
        If reader("Send_to_Personal_Cell") IsNot System.DBNull.Value Then
            MessagePreference.SendToPersonalCell = CType(reader("Send_to_Personal_Cell"), Boolean)
        End If
        If reader("Send_Critical_Messages") IsNot System.DBNull.Value Then
            MessagePreference.SendCriticalMessages = CType(reader("Send_Critical_Messages"), Boolean)
        End If
        If reader("Send_Message_on_Sunday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnSunday = CType(reader("Send_Message_on_Sunday"), Boolean)
        End If
        If reader("Send_Message_on_Monday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnMonday = CType(reader("Send_Message_on_Monday"), Boolean)
        End If
        If reader("Send_Message_on_Tuesday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnTuesday = CType(reader("Send_Message_on_Tuesday"), Boolean)
        End If
        If reader("Send_Message_on_Wednesday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnWednesday = CType(reader("Send_Message_on_Wednesday"), Boolean)
        End If
        If reader("Send_Message_on_Thursday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnThursday = CType(reader("Send_Message_on_Thursday"), Boolean)
        End If
        If reader("Send_Message_on_Friday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnFriday = CType(reader("Send_Message_on_Friday"), Boolean)
        End If
        If reader("Send_Message_on_Saturday") IsNot System.DBNull.Value Then
            MessagePreference.SendMessageOnSaturday = CType(reader("Send_Message_on_Saturday"), Boolean)
        End If
        If reader("Messaging_Enabled") IsNot System.DBNull.Value Then
            MessagePreference.MessagingEnabled = CType(reader("Messaging_Enabled"), Boolean)
        End If
    End Sub
#End Region

End Class