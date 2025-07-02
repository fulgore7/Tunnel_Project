Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Global.WinForms

Public Class frmScaleCalibration
    Inherits CtrlOpcTsaRailFormBase

#Region "Fields"
    Private WithEvents _calibrationSequence As New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, "Calibration_Sequence", "Calibration")
    Private WithEvents _spanCalibrate As OpcElement
    Private WithEvents _stationNumber As New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, "Calibration_Weight_Station", "Calibration")
    Private WithEvents _calibrationCommError As New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, "calibrationCommError", "Calibration")
    Private WithEvents _C2_Scale As New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, "C2_Scale", "Calibration")
    Private WithEvents _Message_Calibrate_Please_Wait As New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, "Message_Calibrate_Please_Wait", "Calibration")
    Private WithEvents _wasCalibrated As OpcElement  ''Added for the Scale was been calibrated button DLG 08-13-14
    Private WithEvents _cancelCalibration As OpcElement
    Private _stationToCalibrate As Integer
    Private WithEvents _zeroCalibrate As OpcElement
    Private WithEvents _bStart_Calibration As OpcElement
    Private WithEvents _Confirm_Calibration As OpcElement
    Private _isCalibrating As Boolean
    Private _calibrationAlarms As New List(Of OpcElement)
#End Region

#Region "Methods"
    '******************* Initialize Communication to PLC variables  *******************
    Protected Overrides Sub InitializeOPCObjects()
        Dim obj As OpcElement
        CtrlOPCButton1.PLCName = Configuration.PlcTopics.TsaClassifiedPlc
        AddOPCObject(CtrlOPCButton1)
        AddOPCObject(_calibrationSequence)
        AddOPCObject(_stationNumber)
        AddOPCObject(btnCalibrationCancel)
        AddOPCObject(_calibrationCommError)
        AddOPCObject(_C2_Scale)
        AddOPCObject(_Message_Calibrate_Please_Wait)

        For i As Integer = 1 To 34
            obj = AddOPCObject(Of OpcElement)(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Alarms[{0}].Status", 80 + i), "Calibration")
            'AddHandler obj.PropertiesUpdateCompleted, AddressOf UpdateAlarmButtonState
            obj = AddOPCObject(Of OpcElement)(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Bins[{0}].Soiled_Weight", i), "Calibration")
            AddHandler obj.PropertiesUpdateCompleted, AddressOf Weight_PropertiesUpdateCompleted
        Next

    End Sub
    '******************   Set Button Appearences  ******************************
    Private Sub _calibrationSequence_PropertiesUpdateCompleted(ByVal sender As IOpcObject, ByVal e As System.EventArgs) Handles _calibrationSequence.PropertiesUpdateCompleted
        'If PLC SEQ in subroutine Weigh_Station.Calibration equal 10 then set btnZero.Enabled to TRUE and set the background for the button Lime Green 
        If CInt(_calibrationSequence.Value) = 10 Then
            btnZero.Enabled = True
            btnZero.Visible = True
            Label3.Visible = True
            btnZero.BackColor = Color.Lime
            'If PLC SEQ in subroutine Weigh_Station.Calibration equal 10 then set btnZero.Enabled to TRUE (Checking scale at 0 weight) and set the background for the button Lime Green 
        Else
            btnZero.Enabled = False
            btnZero.Visible = False
            Label3.Visible = False
            btnZero.BackColor = SystemColors.Control
        End If
        'If PLC SEQ in subroutine Weigh_Station.Calibration equal 40 then set btnSpan.Enabled to TRUE (checking scale with known weight) and set the background for the button Lime Green 
        If CInt(_calibrationSequence.Value) = 40 Then
            btnSpan.Enabled = True
            btnSpan.Visible = True
            btnSpan.BackColor = Color.Lime
            Label4.Visible = True
        Else
            btnSpan.Enabled = False
            btnSpan.Visible = False
            btnSpan.BackColor = SystemColors.Control
            Label4.Visible = False
        End If

        If (CInt(_calibrationSequence.Value) = 5) Then

            btnStartCalibration.BackColor = SystemColors.Control  ' Background Green
            btnStartCalibration.Visible = True
            btnStartCalibration.Enabled = True
            Label2.Visible = True
        Else
            btnStartCalibration.Visible = False
            btnStartCalibration.Enabled = False
            Label2.Visible = False

        End If

        ' displayScaleWasCalibrated() 'Set colors and Enable for Scale Was Calibrated button

        ComboBox1.Enabled = True
        displayPropStartCal()

        ' If (CInt(_calibrationSequence.Value) > 33 And CInt(_calibrationSequence.Value) <= 35) Then
        'btnSpan.Visible = True
        'Label4.Visible = True
        'Else
        'btnSpan.Visible = False
        'Label4.Visible = False
        'End If
        If (CInt(_calibrationSequence.Value) > 5) Then

            btnCalibrationCancel.Visible = True
        Else
            btnCalibrationCancel.Visible = False
        End If
        '******************************Alaram Messages **************************************************
        '-------Alarm SEQ 23 -- Communication Error
        If (CInt(_calibrationSequence.Value) = 23) Then
            TextBox5.Visible = True
        Else
            TextBox5.Visible = False
        End If
        '-------Alarm SEQ 36 -- Zero Scale Error +/- 2 lbs
        If (CInt(_calibrationSequence.Value) = 36) Then
            TextBox2.Visible = True
        Else
            TextBox2.Visible = False
        End If
        '-------Alarm SEQ 57 -- Error Span Weight on Bag
        '  If (CInt(_calibrationSequence.Value) = 57) Then
        'TextBox3.Visible = True
        'Else
        'TextBox3.Visible = False
        'End If
        '-------Alarm SEQ 58 -- Error Span Not Calibrate
        If (CInt(_calibrationSequence.Value) = 58) Then
            TextBox4.Visible = True
        Else
            TextBox4.Visible = False
        End If
        If (CBool(_C2_Scale.Value) = True) Then
            Label5.Visible = True
        Else
            Label5.Visible = False
        End If
        If (CInt(_calibrationSequence.Value) = 20) Or (CInt(_calibrationSequence.Value) = 24) Or (CInt(_calibrationSequence.Value) = 30) Or (CInt(_calibrationSequence.Value) = 35) Or (CInt(_calibrationSequence.Value) = 50) Or (CInt(_calibrationSequence.Value) = 55) Then
            TextBox7.Visible = True
        Else
            TextBox7.Visible = False
        End If
    End Sub

    '****************** Calibration Span Button Control 
    Private Sub btnSpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpan.Click
        _spanCalibrate = AddOPCObject(Of OpcElement)(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Span_Calibrate[{0}]", _stationToCalibrate))
        OpenOPCComm()
        _spanCalibrate.ValueFromObjectToPlc(String.Empty, 1)
        CloseOPCComm(_spanCalibrate.GroupName)

        btnSpan.BackColor = Color.LightYellow
        CloseOPCComm(_spanCalibrate.GroupName)

    End Sub

    '***************************   Calibrate Zero Button Control
    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        _zeroCalibrate = AddOPCObject(Of OpcElement)(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Zero_Calibrate[{0}]", _stationToCalibrate))
        OpenOPCComm()
        _zeroCalibrate.ValueFromObjectToPlc(String.Empty, 1)
        CloseOPCComm(_zeroCalibrate.GroupName)
        btnZero.BackColor = Color.LightYellow
    End Sub
    ' ****************** Calibration Subroutine   For Zero and Span Communication with PLC**********************
    Private Sub Calibration()
        _zeroCalibrate = New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Zero_Calibrate[{0}]", _stationToCalibrate), String.Format("Calibrate_Station_{0}", _stationToCalibrate))
        _spanCalibrate = New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Span_Calibrate[{0}]", _stationToCalibrate), String.Format("Calibrate_Station_{0}", _stationToCalibrate))
        AddOPCObject(_zeroCalibrate)
        AddOPCObject(_spanCalibrate)

        OpenOPCComm(_stationToCalibrate)
    End Sub

    '****************************   Select Station to Calibrate  *****************************
    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged


        If ComboBox1.SelectedValue IsNot Nothing Then   ' Is something Selected?
            _stationToCalibrate = ComboBox1.SelectedValue  'Set _stationToCalibrate to the selection value
            Console.WriteLine("_stationToCalibrate: {0}", _stationToCalibrate) 'Write Station to Calibrate

            'displayPropCalCompletebtn()  'If calibration alarm not active disable button (grey out), If active, Enable button with Green background
            displayPropStartCal()        'Set colors for Start Calibration button
            '  displayScaleWasCalibrated() 'Set colors and Enable for Scale Was Calibrated button
        End If
    End Sub

    '******************** Start Calibration  -  Security Check  ******************************
    Private Sub CtrlOPCButton1__ButtonClick(ByVal sender As Object, ByVal e As Wdw_Sust.Textile.Core.Interfaces.IRailAccessRightEventArgs) Handles CtrlOPCButton1._ButtonClick
        CheckRailAccessRights(sender, e)
    End Sub

    '********************* Cancel Calibration Subroutine   ***************************
    Private Sub CancelCalibration()
        'Set up to talk to bStart_Calibration bit in PLC
        _bStart_Calibration = New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("bStart_Calibration"), String.Format("bStart_Calibration"))
        AddOPCObject(_bStart_Calibration)
        OpenOPCComm()  'Open OPC Communications
        _bStart_Calibration.ValueFromObjectToPlc("", 0) 'Set bStart_Calibration in PLC to 0
        CloseOPCComm(_bStart_Calibration.GroupName) 'Close OPC communications 

        _calibrationSequence.ValueFromObjectToPlc(String.Empty, 5) 'Set calibration SEQ back to 5 (start of SEQ)


    End Sub

    '***************** Is Calibration Started (SEQ NOT 5) Sub Routine   ***************************
    ' Private Function IsCalibrationStarted() As Boolean
    '      Return Not _calibrationSequence.Value = 5
    '  End Function

    '************** Handle what to do when form is closed (popup message about closing before completing calibration)
    'Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
    '    If IsCalibrationStarted() Then 'Calibration SEQ not at 5
    'If IsCancelAllowed() Then  'Calibration SEQ greater than 5 but less than equal to 20
    'CancelCalibration()
    '     Else
    '    e.Cancel = True
    '   MsgBox("You will have to finish calibrating this hopper before exiting")
    '  End If
    ' End If
    'MyBase.OnFormClosing(e)
    'End Sub

    '************ Is Cancel Allowed Subroutine....Allowed if SEQ is in the 5-20 range  ********************************
    Private Function IsCancelAllowed() As Boolean
        Return CInt(_calibrationSequence.Value) > 5 And CInt(_calibrationSequence.Value) <= 20
    End Function

    '************ Start Calibration Button  Messages for Button

    Protected Overrides Sub Initialize()
        LoadComboBox()
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub InitializeOPCCommunication()
        OpenOPCComm(500)
    End Sub



    Private Sub UpdateAlarmButtonState(ByVal sender As IOpcObject, ByVal e As System.EventArgs)
        Dim stationText As String = sender.TagName.Substring(sender.TagName.IndexOf("[") + 1)
        Dim stationNumber As Integer
        stationText = stationText.Remove(stationText.IndexOf("]"))
        stationNumber = CInt(stationText) - 80
    End Sub

    Private Sub LoadComboBox()
        Dim list As New List(Of LintNameValuePair)
        For i As Integer = 1 To 34
            list.Add(New LintNameValuePair(i, String.Format("Station {0}", i)))
        Next
        LINTNameValuePairBindingSource.DataSource = list
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Weight_PropertiesUpdateCompleted(ByVal sender As IOpcObject, ByVal e As System.EventArgs)
        Dim stationText As String = sender.TagName.Substring(sender.TagName.IndexOf("[") + 1)
        stationText = stationText.Remove(stationText.IndexOf("]"))
        If CInt(stationText) = ComboBox1.SelectedValue Then
            TextBox1.Text = String.Format("{0:F2} LBS", CDbl(CType(sender, OpcElement).Value))
        End If
    End Sub

    '**************** Calibration Was Completed Acknowledge Button     ***********************
    'Private Sub btnScaleWasCalibrated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'Ask for ID Card Popup...This only reads the card 
    'Dim args As New LINTRailAccessRightEventArgs(RailAccessOptions.CALIBRATION)
    '   FACTORY.Security.CheckRailAccessRights(args)
    '  If args.CancelAction Then Exit Sub

    'Check to see if person has access rights to do calibration, if they do send PLC a bit to reset alarm flag, set counter cycle check back to 10 and the alarm counter from 3 back to 0 
    '    If args.HasRight Then
    'Send to the PLC variable Calibration_Check[{0}].bScale_Was_Cal...remember {0} is replaced with _stationToCalibrate value
    '       _wasCalibrated = AddOPCObject(Of OPCElement)(CONFIGURATION.PlcTopics.TsaClassifiedPlc, String.Format("Calibration_Check[{0}].bScale_Was_Cal", _stationToCalibrate))
    '      OpenOPCComm()
    '     _wasCalibrated.ValueFromObjectToPLC("", 1)
    '    CloseOPCComm(_wasCalibrated.GroupName)

    'Log calibration data for this event into the data base
    '        LogOperatorEvent(Me, New LINTOperatorEventArgs(Now, args.EmployeeID, My.Computer.Name, LINTAction.WEIGHT_STATION_CALIBRATION_COMPLETED, String.Format("Station {0} has been calibrated and alarm has been reset!", _stationToCalibrate)))

    'Message to confirm  button operation was completed
    '       MsgBox("Calibration for Station " & _stationToCalibrate & " has been confirmed and Alarm flag reset in PLC")

    '    Else

    'Message if employee badge did not work, popup message box indicating the badge did not see the badge a valid for resetting calibration
    '       MsgBox("You don't have the right to reset the calibration alarm!")

    '    End If
    '   displayPropStartCal()
    'End Sub

    ' ***************** Cancel Calibration   ***************************
    Private Sub btnCancelCalibration_Click(sender As Object, e As System.EventArgs)
        If (CInt(_calibrationSequence.Value) > 5 And CInt(_calibrationSequence.Value) <= 60) Then
            CancelCalibration()
        End If
    End Sub

    '**************** New Start Calibration Button  *****************************
    Private Sub btnStartCalibration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartCalibration.Click
        'Ask for ID Card Popup...This only reads the card 
        Dim card = GetRfidCardData(CONFIGURATION.SecuraKeyComportSettings)
        Dim args As New LintRailAccessRightEventArgs(RailAccessOptions.CALIBRATION)
        Factory.Security.CheckRailAccessRights(card, args)
        If args.CancelAction Then Exit Sub

        'Check to see if person has access rights to do calibration, if they do send PLC a TRUE signal to bStart_Calibration (In SEQ 5) to start the calibration process 
        If args.HasRight Then
            _bStart_Calibration = New OpcElement(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("bStart_Calibration"), String.Format("bStart_Calibration"))
            AddOPCObject(_bStart_Calibration)
            OpenOPCComm()
            _bStart_Calibration.ValueFromObjectToPlc("", 1)
            CloseOPCComm(_bStart_Calibration.GroupName)
            LogOperatorEvent(Me, New LintOperatorEventArgs(Now, args.EmployeeId, My.Computer.Name, LintAction.WEIGHT_STATION_CALIBRATION_STARTED, String.Format("Station {0} has started Calibration!", _stationToCalibrate)))
        Else

            'Message if employee badge did not work, popup message box indicating the badge did not see the badge a valid for resetting calibration
            MsgBox("You don't have the right to reset the calibration alarm!")

        End If
    End Sub
    ' ******************* Start Calibration Button  color/Enable   ***************************
    Private Sub displayPropStartCal()
        If OPCContainsGroup("Calibration") Then
            Dim isAlarmRaised As Boolean = CBool(CType(GetOPCObject(Configuration.PlcTopics.TsaClassifiedPlc, String.Format("Alarms[{0}].Status", 80 + _stationToCalibrate)), OpcElement).Value)

            If isAlarmRaised And ((CInt(_calibrationSequence.Value)) = 5) Then
                btnStartCalibration.Enabled = True         'Enable Button 
                btnStartCalibration.BackColor = Color.Lime  ' Background Green

            Else
                btnStartCalibration.Enabled = True  'Disable Button
                btnStartCalibration.BackColor = SystemColors.Control 'Grey out button color
            End If
        End If
    End Sub
#End Region




    Private Sub TextBox2_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub



End Class