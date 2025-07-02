Imports System.Drawing
Imports System.Windows.Forms
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Core.Validation.EventArgs
Imports Wdw_Sust.Core.Validation
Imports System.ComponentModel

Friend Class CtrlLintIdCardList
    Inherits CtrlFormBase

#Region "Fields"
    Private _castInfo As LintCastMember
    Private _rfBadgeUserID As RfidCard
    Private _formMode As FormMode
    Private _card As System.Windows.Forms.DataGridViewRow
#End Region

#Region "Properties"

    Public ReadOnly Property RFBadgeUserID As RfidCard
        Get
            Return _rfBadgeUserID
        End Get
    End Property
#End Region

#Region "Form Events"

    Public Event _Refresh()
    Public Event _CardNumberChosen(ByVal sender As Object, ByVal cardNumber As Integer)
    '===================================================================================================
    '                       Keep track of the color shown on the list
    '                       Green = UNASSIGNED; Red = INVALID
    '===================================================================================================
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex >= 0 Then
            Dim dgvr As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If dgvr.Cells("AssignedTo").Value = "UNASSIGNED" Then
                dgvr.DefaultCellStyle.BackColor = Color.Lime
            ElseIf CType(dgvr.Cells("IsCardValidDataGridViewCheckBoxColumn").Value, Boolean) = False Then
                dgvr.DefaultCellStyle.BackColor = Color.IndianRed
            Else
                dgvr.DefaultCellStyle.BackColor = Color.White
            End If
        End If

    End Sub
#End Region

#Region "Control Click Events"
    ''' <summary>
    ''' Add new card to the DB
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddNewCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewCard.Click
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to add a new card?", MsgBoxStyle.YesNo, "Add A New Card")
        Dim numberToAdd As Integer

        Try
            If answer = MsgBoxResult.Yes Then
                numberToAdd = AskForNewCardNumber()
                AddCardToSystem(numberToAdd)
            End If
        Catch ex As ArgumentException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Unable to Add New Card")
        End Try

    End Sub

    ''' <summary>
    ''' Return card back to the database as UNASSIGNED
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReturnCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnCard.Click
        Dim card As RfidCard = ReadFromRfid(CONFIGURATION.SecuraKeyComportSettings)
        If card IsNot Nothing Then
            If card.CastInfo.EmployeeName = "UNASSIGNED" Then
                MsgBox("The Card is Not assigned to anyone yet. Card Return Unsuccessfully!!")
                Exit Sub
            End If
            If Factory.LintInfo.RfidCardReturnToDatabase(card.CastInfo.EmployeeName, card.RFBadgeUserID, Now, _castInfo.RFBadgeUserID) Then
                MsgBox("Card Returned To The System!!")
                RaiseEvent _Refresh()
                LoadIDCardDataSource()
                Factory.LintInfo.AddLog(_castInfo.EmployeeID, _castInfo.RFBadgeUserID, String.Format("Card {0} Returned To System", card.RFBadgeUserID))
            Else
                MsgBox("Card Returned Unsuccessful, Try Again!!")
            End If
        End If
    End Sub

    Private Sub LoadIDCardDataSource()
        InvokeIfNeeded(Sub() RFIDCardBindingSource.DataSource = Factory.LintInfo.GetAllUserIDs)
    End Sub
    '===================================================================================================
    '                       If doubled click, captured the card data
    '===================================================================================================
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        SelectCardNumber()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        SelectCardNumber()
    End Sub

    Private Sub SelectCardNumber()
        If _formMode = FormMode.NORMAL Then Exit Sub
        If Not _card.Cells("IsCardValidDataGridViewCheckBoxColumn").Value Then
            MsgBox("This Card Is Not Valid")
            Exit Sub
        End If
        If _card.Cells("AssignedTo").Value.ToString.TrimEnd <> "UNASSIGNED" Then
            MsgBox("This Card Number Has Already Been Assigned.")
            Exit Sub
        End If
        RaiseEvent _CardNumberChosen(Me, _card.Cells("RFBadgeUserIDDataGridViewTextBoxColumn").Value)
        Close()
    End Sub

    Private Sub DataGridView1_CellSingleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If _formMode = FormMode.NORMAL Then Exit Sub
        _card = DataGridView1.Rows(e.RowIndex)
        btnOK.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnDeleteCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCard.Click
        DeleteCard()
    End Sub

    Private Sub DeleteCard()
        Dim cardToBeDeleted As Integer = CInt(DataGridView1.CurrentRow.Cells("RFBadgeUserIDDataGridViewTextBoxColumn").Value)
        Dim result As MsgBoxResult = MsgBox(String.Format("Are you sure you want to delete: {0}?", cardToBeDeleted), MsgBoxStyle.YesNo)
        If Not result = MsgBoxResult.Yes Then Exit Sub
        Try
            Factory.LintInfo.DeleteRfidCardFromDatabase(cardToBeDeleted, Now, _castInfo.RFBadgeUserID)
            Factory.LintInfo.AddLog(_castInfo.EmployeeID, _castInfo.RFBadgeUserID, String.Format("Card {0} Deleted From System", cardToBeDeleted))
            MsgBox(String.Format("Card {0} is deleted from the system!!", cardToBeDeleted))
            RFIDCardBindingSource.DataSource = Factory.LintInfo.GetAllUserIDs
            'RaiseEvent _refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Verify card information from the DB
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnVerifyCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyCard.Click
        VerifyCard()
    End Sub

    Private Sub VerifyCard()
        Dim returnIDCard As RfidCard = ReadFromRfid(CONFIGURATION.SecuraKeyComportSettings)
        If returnIDCard IsNot Nothing Then
            Dim testCard As RfidCard = Factory.LintInfo.GetRfidCardInfoByRfidNumber(returnIDCard.RFBadgeUserID)
            If testCard IsNot Nothing Then
                If testCard.RFBadgeUserID = returnIDCard.RFBadgeUserID AndAlso testCard.RFBadgeGuidLoWord = returnIDCard.RFBadgeGuidLoWord AndAlso testCard.RFBadgeGuidHiWord = returnIDCard.RFBadgeGuidHiWord Then
                    If testCard.CastInfo Is Nothing Then
                        If (MsgBox($"Unable to find card Cast Information for Badge ID: {returnIDCard.RFBadgeUserID}. Try to manually fix this card? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then

                            Try
                                'Prompt user for card number. Do this even if
                                'the current number on the card is right.
                                Dim cardNumber = AskForNewCardNumber()

                                If CheckIfCardExistInTheDatabase(cardNumber) Then
                                    ' Card is in the LINT db - update the card only
                                    If MsgBox($"Please ensure that no other card has RFID Badge ID: {cardNumber}. " _
                                              & Environment.NewLine _
                                              & "Completing this action could create duplicate cards with the same card number.", MsgBoxStyle.OkCancel, "Confirm Updating RFID Card") = MsgBoxResult.Ok Then
                                        UpdateBadgeIdOnRfidCard(cardNumber, True)
                                    End If

                                Else
                                    AddCardToSystem(cardNumber)
                                End If

                            Catch ex As ArgumentException
                                MsgBox(ex.Message, MsgBoxStyle.Information, "Unable to Add New Card")
                            End Try

                        End If
                        Return
                    End If
                    If testCard.CastInfo.EmployeeName = "UNASSIGNED" Then
                        MsgBox($"Card {testCard.RFBadgeUserID} is valid and is not assigned!!")
                    ElseIf testCard.CastInfo.EmployeeName = "CARD LOST" Then
                        MsgBox($"Card {testCard.RFBadgeUserID} is lost and is not valid!!")
                    ElseIf testCard.CastInfo.EmployeeName = "CARD MALFUNCTION" Then
                        MsgBox($"Card {testCard.RFBadgeUserID} is mal-functional and is not valid!!")
                    ElseIf testCard.CastInfo IsNot Nothing Then
                        MsgBox($"Card {testCard.RFBadgeUserID} is valid and is assigned to: {testCard.CastInfo.EmployeeName}")
                    Else
                        MsgBox($"Card {testCard.RFBadgeUserID} is valid but unable to identify assignment")
                    End If
                    'For i As Integer = 0 To RFIDCardBindingSource.Count
                    '    If CType(RFIDCardBindingSource.Item(i), RfidCard).RFBadgeUserID = testCard.RFBadgeUserID Then
                    '        RFIDCardBindingSource.Position = i
                    '        Exit For
                    '    End If
                    'Next
                    RFIDCardBindingSource.Position = FindRfidCardRowIndex(RFIDCardBindingSource, testCard.RFBadgeUserID)
                ElseIf returnIDCard.RFBadgeUserID >= 0 Then
                    If Factory.Security.HasLintAccessRight(_castInfo.LintAccessLevel, LintAccessLevel.ADD_CARD) Then
                        Dim result As MsgBoxResult = MsgBox(String.Format("The Card {0} is Not in The System. Do You Want to Add This Card to The System??", returnIDCard.RFBadgeUserID), MsgBoxStyle.YesNo, "Add Card?")
                        If result = MsgBoxResult.Yes Then
                            If returnIDCard.RFBadgeUserID = 0 Then

                                Try
                                    Dim cardToBeProgrammed As Integer = AskForNewCardNumber()

                                    If cardToBeProgrammed <> 0 Then
                                        AddCardToSystem(cardToBeProgrammed)
                                    End If
                                Catch ex As Exception
                                    MsgBox(ex.Message, MsgBoxStyle.Information, "Unable to Add New Card")
                                End Try

                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(ByVal userDetail As LintCastMember, ByVal currentMode As FormMode)
        InitializeComponent()
        DoubleBuffered = True
        _castInfo = userDetail
        _formMode = currentMode
        Me.AcceptButton = btnSearchIdNumber
    End Sub
#End Region

#Region "Methods"
    Private Shared Function AskForNewCardNumber() As Integer
        Dim enteredBadgeId As Integer
        Dim promptResult = InputBox("Please input desired card number in the text box provided.")

        If Not Int32.TryParse(promptResult, enteredBadgeId) Or enteredBadgeId = 0 Then
            Throw New ArgumentException($"Invalid RFID Badge ID: {promptResult}")
        End If

        Return enteredBadgeId

    End Function

    ''' <summary>
    ''' Add the RFID card instance to the database.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub AddCardToSystem(ByVal numberToAdd As Integer)
        Dim card As RfidCard
        If CheckIfCardExistInTheDatabase(numberToAdd) Then
            MsgBox("Card has already been in the system and cannnot be added!")
            Exit Sub
        End If
        'ReadFromRfid(CONFIGURATION.SecuraKeyComportSettings)
        'card = WriteRfid(numberToAdd, CONFIGURATION.SecuraKeyComportSettings)
        card = UpdateBadgeIdOnRfidCard(numberToAdd, False, False)
        If card Is Nothing OrElse card.RFBadgeUserID <> numberToAdd Then 'card.RFBadgeGuidHiWord = 0 OrElse card.RFBadgeGuidLoWord = 0 Then
            MsgBox("Card not being read successfully!! Please try again!!")
            Exit Sub
        End If
        If Factory.LintInfo.AddRfidCardToDatabase(card.RFBadgeGuidHiWord, card.RFBadgeGuidLoWord, numberToAdd, "UNASSIGNED", Now, Now, 1, _castInfo.RFBadgeUserID) Then
            MsgBox("Card added to the system")
            Factory.LintInfo.AddLog(_castInfo.EmployeeID, _castInfo.RFBadgeUserID, String.Format("Card {0} Added To System", card.RFBadgeUserID))
            RFIDCardBindingSource.DataSource = Factory.LintInfo.GetAllUserIDs
            RFIDCardBindingSource.Position = FindRfidCardRowIndex(RFIDCardBindingSource, numberToAdd)
        Else
            MsgBox("Card CANNOT be added to the system, if continues, see systems team for support!!")
        End If
    End Sub

    Private Function CheckIfCardExistInTheDatabase(ByVal testNumber As Integer) As Boolean
        Return CType(RFIDCardBindingSource.DataSource, List(Of RfidCard)).Exists(Function(a As RfidCard) a.RFBadgeUserID = testNumber)
    End Function

    Protected Overrides Sub Initialize()
        InitializeControls()
        LoadIDCardDataSource()
    End Sub

    Private Sub InitializeControls()
        btnAddNewCard.Enabled = _castInfo.AddCard
        btnReturnCard.Enabled = _castInfo.ReturnCard
        btnDeleteCard.Enabled = _castInfo.DeleteCard
        btnCreateLogoutCard.Enabled = _castInfo.UserType = LintUserType.SYSTEM_ADMINISTRATOR
    End Sub

    Private Sub btnCreateLogoutCard_Click(sender As Object, e As System.EventArgs) Handles btnCreateLogoutCard.Click
        Dim answer As MsgBoxResult = MsgBox("Do you want to create a new logout card?", MsgBoxStyle.YesNo, "Create a New Log Out Card")
        Dim numberToAdd As Integer = 9999 'This number is hard coded in the PLC 
        Dim card As RfidCard
        If answer = MsgBoxResult.Yes Then
            'card = WriteRfid(numberToAdd, CONFIGURATION.SecuraKeyComportSettings)
            card = UpdateBadgeIdOnRfidCard(numberToAdd)
            If card Is Nothing OrElse card.RFBadgeUserID <> numberToAdd Then 'OrElse card.RFBadgeGuidHiWord = 0 OrElse card.RFBadgeGuidLoWord = 0 Then
                MsgBox("Card not being read successfully!! Please try again!!")
            Else
                MsgBox("Card created successfully, now you can use this logout card to log out Cast Members from machines.")
            End If
        End If
    End Sub

    Private Sub AddBusinessRules()
        BusinessRuleManager.AddRule(GetType(RfidCard), "Card not read successfully", "CardNotReadSuccessfully", Function(a As RfidCard) a.RFBadgeGuidHiWord <> 0 AndAlso a.RFBadgeGuidLoWord <> 0)
        BusinessRuleManager.AddRule(GetType(RfidCard), "Card has already been in the system and cannnot be added!", "CardNotReadSuccessfully", Function(a As RfidCard) Not CheckIfCardExistInTheDatabase(a.RFBadgeUserID))
        BusinessRuleManager.AddRule(GetType(RfidCard), "The card is lost and is not valid!!", "CardLost", Function(a As RfidCard) IIf(a.CastInfo IsNot Nothing, Not a.CastInfo.EmployeeName = "CARD LOST", True))
        BusinessRuleManager.AddRule(GetType(RfidCard), "The card is mal-functional and is not valid!!", "CardMalfunction", Function(a As RfidCard) IIf(a.CastInfo IsNot Nothing, Not a.CastInfo.EmployeeName = "CARD MALFUNCTION", True))
        AddHandler BusinessRuleManager.ObjectIsInvalidEvent, AddressOf ObjectIsInvalidEvent
    End Sub

    Private Sub ObjectIsInvalidEvent(sender As Object, e As ObjectInvalidEventArgs)
        MsgBox(e.ErrorSummary)
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        BusinessRuleManager.RemoveRulesByType(GetType(RfidCard))
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub btnSearchIdNumber_Click(sender As Object, e As System.EventArgs) Handles btnSearchIdNumber.Click
        RFIDCardBindingSource.Position = FindRfidCardRowIndex(RFIDCardBindingSource, txtSearchIdNumber.Text, True)
    End Sub
    Private Sub btnFixCardOnly_Click(sender As Object, e As System.EventArgs) Handles btnFixCardOnly.Click
        UpdateBadgeIdOnRfidCard(AskForNewCardNumber(), True)
    End Sub
    Private Sub txtSearchIdNumber_DoubleClick(sender As Object, e As System.EventArgs) Handles txtSearchIdNumber.DoubleClick
        txtSearchIdNumber.Text = String.Empty
    End Sub
#End Region

#Region "Support Methods"

    Private Function UpdateBadgeIdOnRfidCard(badgeId As Integer, Optional ByVal shouldDisplayCardUpdatedMessageBox As Boolean = False, Optional ByVal shouldFindClosestRow As Boolean = False) As RfidCard

        Dim card As RfidCard = WriteRfid(badgeId, CONFIGURATION.SecuraKeyComportSettings)

        If card IsNot Nothing Then

            Try
                Dim rowIndex = FindRfidCardRowIndex(RFIDCardBindingSource, badgeId, shouldFindClosestRow)
                RFIDCardBindingSource.Position = rowIndex
            Catch ex As Exception
                ' Swallow all exceptions
                RFIDCardBindingSource.Position = 0
            End Try

            If shouldDisplayCardUpdatedMessageBox Then
                MsgBox($"Card updated - Badge ID: {badgeId}. Click 'Verify' button to confirm.")
            End If

        End If

        Return card
    End Function

    Private Shared Function FindRfidCardRowIndex(ByRef bindingSource As BindingSource, badgeId As String, Optional ByVal shouldFindClosestRow As Boolean = False)
        Dim targetIdNumber As Integer
        Dim data As List(Of RfidCard) = bindingSource.DataSource
        If Int32.TryParse(badgeId, targetIdNumber) Then

            Dim targetItem = CType(data, List(Of RfidCard)) _
                .Select(Function(c, i) New With {.Card = c, .RowIndex = i}) _
                .FirstOrDefault(Function(item) item.Card.RFBadgeUserID.Equals(targetIdNumber))

            If targetItem IsNot Nothing Then
                Return targetItem.RowIndex
            Else
                If shouldFindClosestRow Then
                    MsgBox($"RF Badge ID: {targetIdNumber} not found. Will move to nearest badge id.")
                    Return FindClosestRifdCardRowIndex(data, targetIdNumber)
                Else
                    Throw New ArgumentException($"Unable to find RF Badge ID: {badgeId}")
                End If

            End If
        Else
            Return 0
        End If
    End Function

    Private Shared Function FindClosestRifdCardRowIndex(ByRef data As List(Of RfidCard), targetRfidNumber As Integer) As Integer
        ' Verify search range
        Dim lowestBadgeId = data(0).RFBadgeUserID
        Dim highestBadgeId = data.Last().RFBadgeUserID

        If targetRfidNumber <= lowestBadgeId Then
            Return 0
        ElseIf targetRfidNumber >= highestBadgeId Then
            Return data.Count - 1
        Else
            Return RecrusiveSearchForClosestRowIndex(data, targetRfidNumber, 0, data.Count - 1)
        End If
    End Function


    Private Shared Function RecrusiveSearchForClosestRowIndex(ByRef data As List(Of RfidCard), targetRfidNumber As Integer, startIndex As Integer, endIndex As Integer) As Integer

        Dim centerIndex As Integer = Math.Truncate((startIndex + endIndex) / 2)

        ' Get RFID above and below
        Dim lowerBoundBadgeId = data(Math.Min(centerIndex, endIndex)).RFBadgeUserID
        Dim upperBoundBadgeId = data(Math.Max(centerIndex + 1, 0)).RFBadgeUserID

        ' Closest rfid badge user id found
        If lowerBoundBadgeId <= targetRfidNumber AndAlso targetRfidNumber <= upperBoundBadgeId Then
            Return data _
                .Select(Function(c, i) New With {.Card = c, .RowIndex = i}) _
                .First(Function(item) item.Card.RFBadgeUserID.Equals(lowerBoundBadgeId)).RowIndex
        End If

        If upperBoundBadgeId < targetRfidNumber Then
            Return RecrusiveSearchForClosestRowIndex(data, targetRfidNumber, centerIndex, endIndex)
        Else
            Return RecrusiveSearchForClosestRowIndex(data, targetRfidNumber, startIndex, centerIndex)
        End If

    End Function


#End Region


End Class




