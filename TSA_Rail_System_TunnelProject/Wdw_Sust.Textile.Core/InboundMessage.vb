Imports System.Data
Imports Wdw_Sust.Core.Extensions

Public Class InboundMessage

#Region "Properties"

    Public Property MessageUniqueID() As String
    Public Property MessageReceivedTimestamp() As DateTime
    Public Property MessagePlant() As Plant
    Public Property MessageSystem() As LintSystemOrigins
    Public Property MessageZone() As LintZone
    Public Property MessageDepartment() As LintDepartments
    Public Property MessageSeverity() As MessageFaultSeverity
    Public Property MessageCritical() As Boolean
    Public Property MessageType() As MessageType
    Public Property MessageText() As String
    Public Property MessageAcknowledged() As Boolean
    Public Property MessagePendingDelivery() As Boolean
    Public Property MessageProcessed() As Boolean
    Public Property MessageProcessedTimestamp() As Date
    Public Property MessageAlarmGlobalID() As Integer
    Public Property PendingMessageQuantity() As Integer
    Public Property MessageHeader() As String
    Public Property MessageLink() As String
    Public Property MessageAlarmOnStatusDeadband() As Integer
    Public Property MessageAlarmDelayBeforeResendMessage() As Integer
    Public Property MessageAlarmInvalidTime() As Integer
    Public Property MessageComponent() As LintComponents
    Public Property MessageAlarmLastOccurrence() As Date
    Public Property MessageAlarmTotalOccurrences() As Integer
    Public Property MessageAlarmLastDuration() As Integer
#End Region
#Region "Events"
    Public Event _EligibilityToReceiveAlarm(ByVal sender As Object, ByVal e As LintReceiveAlarmEventArgs)
#End Region

    Protected Sub RaiseEligibilityToReceiveAlarm(ByVal message As String)
        RaiseEvent _EligibilityToReceiveAlarm(Me, New LintReceiveAlarmEventArgs(message))
    End Sub

#Region "Methods"
    Public Function CanSendToUser(ByVal user As LintPagingUser) As Boolean
        'compile message header out of message preferences - plant, zone, system, etc.
        With Me
            .MessageHeader = String.Empty
            If user.MessagePreference.IncludePlant Then
                .MessageHeader = String.Format("{0} {1} ", .MessageHeader, .MessagePlant.GetFriendlyName)
            End If
            If user.MessagePreference.IncludeSystem Then
                .MessageHeader = String.Format("{0} {1} ", .MessageHeader, .MessageSystem.GetFriendlyName)
            End If
            If user.MessagePreference.IncludeZone Then
                .MessageHeader = String.Format("{0} {1} ", .MessageHeader, .MessageZone.GetFriendlyName)
            End If
        End With

        If Not user.MessagePreference.MessagingEnabled Then
            RaiseEligibilityToReceiveAlarm(String.Format("{0} does not have message enabled!", user.EmployeeName))
            Return False
        End If
        ' always send the mesage if it is flagged as critical. Overrides all other preferences!
        If MessageCritical Then
            Return True
        End If
        ' check if alarm has been off for min duration before sending message again
        If MessageAlarmDelayBeforeResendMessage > 0 Then
            If Not IsDeadBandTestPassed() Then
                RaiseEligibilityToReceiveAlarm(String.Format("{0} doesn't pass the deadband test and is NOT ELIGIBLE to get this alarm", user.EmployeeName))
                Return False
            End If
        End If
        ' TimeTest
        ' This is to test 3rd shift
        If Not user.MessagePreference.IsAlarmWithinTimeTestPassed Then
            RaiseEligibilityToReceiveAlarm(String.Format("{0} doesn't pass the time test and is NOT ELIGIBLE to get this alarm", user.EmployeeName))
            Return False
        End If
        ' check if time from original alarm on time to now is not excessive (ie. alarm is now out of date)
        If Not IsOutOfDateAlarmTestPassed() Then
            RaiseEligibilityToReceiveAlarm(String.Format("The alarm is out of date! {0} is NOT ELIGIBLE to get this alarm", user.EmployeeName))
            Return False
        End If
        ' Check if setting in the db is correct
        'If user.MessagePreference.EarliestMessageTime > user.MessagePreference.LatestMessageTime Then
        '    RaiseEligibilityToReceiveAlarm(String.Format("{0} doesn't doesn't have a valid setting in the database and is NOT ELIGIBLE to get this alarm", user.EmployeeName)))
        '    Return False
        'End If


        'DayTest
        If Not user.MessagePreference.IsDayOfWeekTestPassed Then
            RaiseEligibilityToReceiveAlarm(String.Format("{0} doesn't pass the day test and is NOT ELIGIBLE to get this alarm", user.EmployeeName))
            Return False
        End If

        'Message Type and Severity Test
        If Not user.MessagePreference.IsAlarmMiniumSeverityTestPassed(MessageType, MessageSeverity) Then
            RaiseEligibilityToReceiveAlarm(String.Format("{0} doesn't pass the message type test and is NOT ELIGIBLE to get this alarm", user.EmployeeName))
        End If

        'PlantTest
        If Not user.IsIncludeWorkLocationMessagesOnlyTestPassed(MessagePlant) Then
            RaiseEligibilityToReceiveAlarm(String.Format("{0} doesn't pass the message plant test", user.EmployeeName))
            Return False
        End If
        RaiseEligibilityToReceiveAlarm(String.Format("{0} is ELIGLIBLE to get this alarm", user.EmployeeName))


        Return True

    End Function

    Public Function IsDeadBandTestPassed() As Boolean
        Return DateDiff(DateInterval.Second, MessageAlarmLastOccurrence, MessageReceivedTimestamp) > MessageAlarmDelayBeforeResendMessage
    End Function
    Public Function IsOutOfDateAlarmTestPassed() As Boolean
        Return DateDiff(DateInterval.Second, MessageReceivedTimestamp, Now) < MessageAlarmInvalidTime
    End Function
#End Region


#Region "Constructors"
    Public Sub New()

    End Sub

    Public Sub New(reader As IDataReader)
        MessageUniqueID = CType(reader("Message_Unique_ID"), String)
        MessageReceivedTimestamp = CType(reader("Message_Received_Timestamp"), Date)
        If reader("Message_Received_Timestamp") IsNot System.DBNull.Value Then
            MessagePlant = CType(reader("Message_Plant"), String)
        End If
        If reader("Message_System") IsNot System.DBNull.Value Then
            MessageSystem = CType(reader("Message_System"), String)
        End If
        If reader("Message_Component") IsNot System.DBNull.Value Then
            MessageComponent = CType(reader("Message_Component"), String)
        End If
        If reader("Message_Zone") IsNot System.DBNull.Value Then
            MessageZone = CType(reader("Message_Zone"), String)
        End If
        If reader("Message_Department") IsNot System.DBNull.Value Then
            MessageDepartment = CType(reader("Message_Department"), String)
        End If
        If reader("Message_Severity") IsNot System.DBNull.Value Then
            MessageSeverity = CType(reader("Message_Severity"), String)
        End If
        If reader("Message_Critical") IsNot System.DBNull.Value Then
            MessageCritical = CType(reader("Message_Critical"), Boolean)
        End If
        If reader("Message_Type") IsNot System.DBNull.Value Then
            MessageType = CType(reader("Message_Type"), String)
        End If
        If reader("Message_Text") IsNot System.DBNull.Value Then
            MessageText = CType(reader("Message_Text"), String)
        End If
        If reader("Message_Acknowledged") IsNot System.DBNull.Value Then
            MessageAcknowledged = CType(reader("Message_Acknowledged"), Boolean)
        End If
        If reader("Message_Pending_Delivery") IsNot System.DBNull.Value Then
            MessagePendingDelivery = CType(reader("Message_Pending_Delivery"), Boolean)
        End If
        If reader("Message_Processed") IsNot System.DBNull.Value Then
            MessageProcessed = CType(reader("Message_Processed"), Boolean)
        End If
        If reader("Message_Processed_Timestamp") IsNot System.DBNull.Value Then
            MessageProcessedTimestamp = CType(reader("Message_Processed_Timestamp"), Date)
        End If
        If reader("Message_Alarm_Global_ID") IsNot System.DBNull.Value Then
            MessageAlarmGlobalID = CType(reader("Message_Alarm_Global_ID"), Integer)
        End If
        If reader("Message_Alarm_On_Status_Deadband") IsNot System.DBNull.Value Then
            MessageAlarmOnStatusDeadband = CType(reader("Message_Alarm_On_Status_Deadband"), Integer)
        End If
        If reader("Message_Alarm_Delay_Before_Resend_Message") IsNot System.DBNull.Value Then
            MessageAlarmDelayBeforeResendMessage = CType(reader("Message_Alarm_Delay_Before_Resend_Message"), Integer)
        End If
        If reader("Message_Alarm_Last_Occurrence") IsNot System.DBNull.Value Then
            MessageAlarmLastOccurrence = CType(reader("Message_Alarm_Last_Occurrence"), Date)
        End If
    End Sub
#End Region

End Class