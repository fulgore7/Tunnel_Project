Public Class MessagingPreferences
    Public Property PortalID As String
    Public Property PagerPIN() As String
    Public Property PagerServiceProvider() As String
    Public Property BlackberryPIN() As String
    Public Property BlackberryServiceProvider() As String
    Public Property EmailAddress() As String
    Public Property NextelPIN() As String
    Public Property NextelServiceProvider() As String
    Public Property EmployeeID() As String
    Public Property MinimumSeverityLevelGeneralFaults() As MessageFaultSeverity
    Public Property MinimumSeverityLevelElectricalFaults() As MessageFaultSeverity
    Public Property MinimumSeverityLevelMechanicalFaults() As MessageFaultSeverity
    Public Property MinimumSeverityLevelComputerFaults() As MessageFaultSeverity
    Public Property MinimumSeverityLevelProductivityFaults() As MessageFaultSeverity
    Public Property MinimumSeverityLevelExceptions() As MessageFaultSeverity
    Public Property PersonalCellProvider() As String
    Public Property PersonalCellPIN() As String
    Public Property IncludePlant() As Boolean
    Public Property IncludeDepartment() As Boolean
    Public Property IncludeZone() As Boolean
    Public Property IncludeMachine() As Boolean
    Public Property IncludeSystem() As Boolean
    Public Property IncludeHyperlink() As Boolean
    Public Property IncludeComponent() As Boolean
    Public Property IncludeHistory() As Boolean
    Public Property SendEmailAnytime() As Boolean
    Public Property EarliestMessageTime() As Date
    Public ReadOnly Property EarliestTimeOfDateInMinutes As Integer
        Get
            Return EarliestMessageTime.TimeOfDay.TotalMinutes
        End Get
    End Property
    Public Property LatestMessageTime() As Date
    Public ReadOnly Property LatestTimeOfDateInMinutes As Integer
        Get
            Return LatestMessageTime.TimeOfDay.TotalMinutes
        End Get
    End Property
    Public Property SendMessageOnSunday() As Boolean
    Public Property SendMessageOnMonday() As Boolean
    Public Property SendMessageOnTuesday() As Boolean
    Public Property SendMessageOnWednesday() As Boolean
    Public Property SendMessageOnThursday() As Boolean
    Public Property SendMessageOnFriday() As Boolean
    Public Property SendMessageOnSaturday() As Boolean
    Public Property IncludeWorkLocationMessagesOnly() As Boolean
    Public Property SendToPager() As Boolean
    Public Property SendToBlackberry() As Boolean
    Public Property SendToNextel() As Boolean
    Public Property SendToPersonalCell() As Boolean
    Public Property SendEmailConfirmation() As Boolean
    Public Property SendCriticalMessages() As Boolean
    Public Property MessagingEnabled() As Boolean

    Public Function IsDayOfWeekTestPassed() As Boolean
        If SendMessageOnSunday AndAlso Today.DayOfWeek = DayOfWeek.Sunday Then Return True
        If SendMessageOnMonday AndAlso Today.DayOfWeek = DayOfWeek.Monday Then Return True
        If SendMessageOnTuesday AndAlso Today.DayOfWeek = DayOfWeek.Tuesday Then Return True
        If SendMessageOnWednesday AndAlso Today.DayOfWeek = DayOfWeek.Wednesday Then Return True
        If SendMessageOnThursday AndAlso Today.DayOfWeek = DayOfWeek.Thursday Then Return True
        If SendMessageOnFriday AndAlso Today.DayOfWeek = DayOfWeek.Friday Then Return True
        If SendMessageOnSaturday AndAlso Today.DayOfWeek = DayOfWeek.Saturday Then Return True
        Return False
    End Function

    Public Function IsAlarmMiniumSeverityTestPassed(ByVal messageType As MessageType, ByVal messageSeverity As Integer) As Boolean
        'Message Type and Severity Test
        Select Case messageType
            Case MessageType.GENERAL_FAULT_MESSAGE
                Return MinimumSeverityLevelGeneralFaults > messageSeverity
            Case MessageType.EXCEPTION_MESSAGE
                Return MinimumSeverityLevelGeneralFaults > messageSeverity
            Case MessageType.ELECTRICAL_SYSTEM_MESSAGE
                Return MinimumSeverityLevelElectricalFaults > messageSeverity
            Case MessageType.MECHANICAL_SYSTEM_MESSAGE
                Return MinimumSeverityLevelMechanicalFaults > messageSeverity
            Case MessageType.COMPUTER_PLC_SYSTEM_MESSAGE
                Return MinimumSeverityLevelComputerFaults > messageSeverity
            Case MessageType.PRODUCTION_SYSTEM_MESSAGE
                Return MinimumSeverityLevelProductivityFaults > messageSeverity
            Case Else
                Return False
        End Select
    End Function

    Public Function IsAlarmWithinTimeTestPassed() As Boolean
        Dim currentTotalMinutes As Integer = Now.TimeOfDay.TotalMinutes
        'Message Type and Severity Test
        If EarliestTimeOfDateInMinutes > LatestTimeOfDateInMinutes Then
            If currentTotalMinutes > EarliestTimeOfDateInMinutes AndAlso IsDayOfWeekTestPassed(Today.DayOfWeek) Then
                Return True
            ElseIf currentTotalMinutes < LatestTimeOfDateInMinutes AndAlso IsDayOfWeekTestPassed(GetTomorrow(Today.DayOfWeek)) Then
                Return True
            Else
                Return False
            End If
        Else
            Return currentTotalMinutes >= EarliestTimeOfDateInMinutes AndAlso
                currentTotalMinutes <= LatestTimeOfDateInMinutes AndAlso
                IsDayOfWeekTestPassed(Today.DayOfWeek)
        End If
        'this is for 3 shift
        'If EarliestTimeOfDateInMinutes < LatestTimeOfDateInMinutes Then
        '    Dim timeOfDateInTotalMinutes As Integer = currentTotalMinutes
        '    If EarliestTimeOfDateInMinutes <=  timeOfDateInTotalMinutes andalso 

        '    End If
        '    If (EarliestMessageTime.Day <> LatestMessageTime.Day) AndAlso (EarliestMessageTime.Hour >= Now.Hour OrElse LatestMessageTime.Hour) Then

        '        ' This is to test 1st and 2nd shift
        '    ElseIf (Now.Hour >= EarliestMessageTime.Hour AndAlso Now.Hour <= LatestMessageTime.Hour) Then

        '    Else

        '        Return False
        '    End If
        'End If
    End Function

    Public Function IsDayOfWeekTestPassed(ByVal day As DayOfWeek) As Boolean
        Select Case day
            Case DayOfWeek.Sunday
                Return SendMessageOnSunday
            Case DayOfWeek.Monday
                Return SendMessageOnMonday
            Case DayOfWeek.Tuesday
                Return SendMessageOnTuesday
            Case DayOfWeek.Wednesday
                Return SendMessageOnWednesday
            Case DayOfWeek.Thursday
                Return SendMessageOnThursday
            Case DayOfWeek.Friday
                Return SendMessageOnFriday
            Case DayOfWeek.Saturday
                Return SendMessageOnSaturday
            Case Else
                Return False
        End Select
    End Function

    'Public Function IsWithinRange(ByVal timeOfDay As TimeSpan, ByVal dayOfWeek As DayOfWeek) As Boolean
    '    If StartTimeTotalMinutes > EndTimeTotalMinutes Then
    '        If timeOfDay > StartTimeSpan AndAlso Day = dayOfWeek Then
    '            Return True
    '        ElseIf timeOfDay < EndTimeSpan AndAlso GetTomorrow(Day) = dayOfWeek Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Else
    '        Return timeOfDay >= StartTimeSpan AndAlso timeOfDay <= EndTimeSpan AndAlso Day = dayOfWeek
    '    End If
    'End Function

    Private Shared Function GetTomorrow(ByVal dayOfWeek As DayOfWeek) As DayOfWeek
        If dayOfWeek <> DayOfWeek.Saturday Then
            Return [Enum].Parse(GetType(DayOfWeek), CInt(dayOfWeek) + 1)
        Else
            Return DayOfWeek.Sunday
        End If
    End Function
End Class