Imports System.Data
Imports Wdw_Sust.Core.Extensions

Public Class OutboundMessage

#Region "Property Get/Set"
    Public Property MessageRecipientEmployeeID() As String
    Public Property MessageRecipientEmailAddresss As String
    Public Property MessageHeader() As String
    Public Property MessageText() As String
    Public Property MessageLink() As String
    Public Property MessageGlobalAlarmID() As Integer
    Public Property MessageUniqueID() As Integer
    Public Property MessageTimestamp() As Date
    Public Property MessagePreference() As New MessagingPreferences
#End Region

#Region "Functions"
    Public Shared Function CreateOutboundMessage(ByVal messageInbound As InboundMessage, affectEmployeeId As Integer)
        Dim outBoundMessage As New OutboundMessage
        With outBoundMessage
            .MessageRecipientEmployeeID = affectEmployeeId
            .MessageText = String.Format("{0} - {1} ID={2}", messageInbound.MessagePlant.GetFriendlyName, messageInbound.MessageText, messageInbound.MessageUniqueID)
            .MessageHeader = messageInbound.MessageHeader
            .MessageGlobalAlarmID = messageInbound.MessageAlarmGlobalID
            .MessageLink = String.Empty
        End With
        Return outBoundMessage
    End Function

#End Region

    Public Sub New(reader As IDataReader)

        MessageUniqueID = CType(reader("Message_Unique_ID"), String)
        MessageTimestamp = CType(reader("Message_Timestamp"), Date)
        If reader("Portal_ID") IsNot System.DBNull.Value Then
            MessagePreference.PortalID = CType(reader("Portal_ID"), String)
        End If
        If reader("Message_Recipient_Employee_ID") IsNot System.DBNull.Value Then
            MessageRecipientEmployeeID = CType(reader("Message_Recipient_Employee_ID"), String)
        End If
        If reader("Message_Text") IsNot System.DBNull.Value Then
            MessageText = CType(reader("Message_Text"), String)
        End If
        If reader("Message_Header") IsNot System.DBNull.Value Then
            MessageHeader = CType(reader("Message_Header"), String)
        End If
        If reader("Message_Link") IsNot System.DBNull.Value Then
            MessageLink = CType(reader("Message_Link"), String)
        End If
        If reader("Message_Global_Alarm_ID") IsNot System.DBNull.Value Then
            MessageGlobalAlarmID = CType(reader("Message_Global_Alarm_ID"), Integer)
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
        If reader("Messaging_Enabled") IsNot System.DBNull.Value Then
            MessagePreference.MessagingEnabled = CType(reader("Messaging_Enabled"), Boolean)
        End If
    End Sub

    Public Sub New()

    End Sub
End Class