Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Validation
Imports Wdw_Sust.Core.Validation.EventArgs
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Core.WinForms.Helpers
Imports Wdw_Sust.Logging.LoggingManager
Imports Wdw_Sust.Rostr
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.WinForms.Core
Imports Wdw_Sust.Textile.Global.WinForms.Extensions
Imports Wdw_Sust.Web
Imports Wdw_Sust.Web.Models

Public Class CtrlLintUserManagement
    Inherits CtrlMainFormBase

#Region "Fields"

    Private _castInfo As LintCastMember
    Private _formMode As FormMode = FormMode.NORMAL
    Private _backupCastInfo As LintCastMember
    Private _previousSelection As Integer = -1
    Private _listOfCast As List(Of LintCastMember)
    Private _tasUsers As List(Of TasUser)
    Private _originalEmployeeID As Integer
    Private _position As Integer
    Private _isDuplicateEmployeeNameTriggered As Boolean = False
    Private _rostr As RostrClient
    Private _tas As New TasApi()
    Private _helpForm = New CtrlBlueId()

#End Region

#Region "Events"

    Public Event RequestChangeModeEvent(sender As Object, e As LintRailAccessRightEventArgs)

#End Region

#Region "Properties"

    Public Property Mode As FormMode
        Get
            Return _formMode
        End Get
        Set(value As FormMode)
            _formMode = value
            Select Case _formMode
                Case FormMode.ADD
                    gbCastInfo.Enabled = True
                    gbWorkLocation.Enabled = True
                    gbUserList.Enabled = False
                    btnAddUser.Enabled = False
                    btnDeleteUser.Enabled = False
                    btnEditUser.Enabled = False
                    btnIDCardList.Enabled = False
                    btnApply.Enabled = True
                    btnCancel.Enabled = True
                    ' Recently added 10/12/2012 In order to allow rights of users to successfully add a user (without business rules interference)
                    EmployeeIDTextBox.Enabled = True
                    FirstNameTextBox.Enabled = True
                    LastNameTextBox.Enabled = True
                    UserTypeComboBox.Enabled = True
                    AssignedShiftComboBox.Enabled = True
                    With _castInfo
                        gbEditUser.Enabled = .EditUser
                        gbRailSystemAccess.Enabled = .EditUserSystemConfiguration OrElse .EditUserRailOptions
                        gbBagEdits.Enabled = .EditUserRailOptions
                        gbSystemConfiguration.Enabled = .EditUserSystemConfiguration
                        btnAssignIDCard.Enabled = .EditCardAssignment
                        gbIDCard.Enabled = .EditCardAssignment OrElse .EditCardNumber
                        gbProxId.Enabled = .EditCardAssignment OrElse .EditCardNumber
                        gbUserManagement.Enabled = Factory.Security.IsUserTypeSupported(.UserType, LintUserType.SYSTEM_ADMINISTRATOR)
                    End With
                    EmployeeIDTextBox.PasswordChar = String.Empty
                Case FormMode.EDIT
                    gbUserList.Enabled = False
                    btnAddUser.Enabled = False
                    btnDeleteUser.Enabled = False
                    btnEditUser.Enabled = False
                    btnIDCardList.Enabled = False
                    btnApply.Enabled = True
                    btnCancel.Enabled = True
                    gbCastInfo.Enabled = True
                    With _castInfo
                        gbWorkLocation.Enabled = .EditUserWorkLocation
                        gbEditUser.Enabled = .EditUser
                        gbRailSystemAccess.Enabled = .EditUserSystemConfiguration OrElse .EditUserRailOptions
                        gbBagEdits.Enabled = .EditUserRailOptions
                        gbSystemConfiguration.Enabled = .EditUserSystemConfiguration
                        gbIDCard.Enabled = .EditCardAssignment OrElse .EditCardNumber
                        gbProxId.Enabled = .EditCardAssignment OrElse .EditCardNumber
                        gbUserManagement.Enabled = Factory.Security.IsUserTypeSupported(.UserType, LintUserType.SYSTEM_ADMINISTRATOR)
                        btnAssignIDCard.Enabled = .EditCardAssignment
                        FirstNameTextBox.Enabled = .EditUserName
                        LastNameTextBox.Enabled = .EditUserName
                        EmployeeIDTextBox.Enabled = .EditEmployeeID
                        AssignedShiftComboBox.Enabled = .EditShift
                    End With
                    If Not _castInfo.EditEmployeeID Then EmployeeIDTextBox.PasswordChar = "*"
                Case FormMode.NORMAL
                    gbCastInfo.Enabled = False
                    gbWorkLocation.Enabled = False
                    gbEditUser.Enabled = False
                    gbRailSystemAccess.Enabled = False
                    gbBagEdits.Enabled = False
                    gbSystemConfiguration.Enabled = False
                    gbIDCard.Enabled = False
                    gbProxId.Enabled = False
                    gbUserManagement.Enabled = False
                    gbUserList.Enabled = True
                    btnApply.Enabled = False
                    btnCancel.Enabled = False
                    AssignedShiftComboBox.Enabled = False
                    With _castInfo
                        btnAddUser.Enabled = .AddUser
                        btnDeleteUser.Enabled = .DeleteUser
                        btnEditUser.Enabled = .EditUser
                        btnIDCardList.Enabled = .EditCard
                    End With
                    If Not _castInfo.EditEmployeeID Then EmployeeIDTextBox.PasswordChar = "*"
            End Select
        End Set
    End Property

#End Region

#Region "Methods"

    Private Sub btnAddUser_Click(sender As Object, e As System.EventArgs) Handles btnAddUser.Click
        _previousSelection = LINTCastMemberBindingSource.Position
        _position = LINTCastMemberBindingSource.Add(New LintCastMember With {.IsActive = True, .LastName = String.Empty, .FirstName = String.Empty})
        LINTCastMemberBindingSource.Position = _position
        Mode = FormMode.ADD
        _originalEmployeeID = 0
    End Sub

    Private Sub btnApply_Click(sender As Object, e As System.EventArgs) Handles btnApply.Click
        ApplyChanges()
    End Sub

    Private Sub RefreshListBox()
        LoadCastMembers()
        CType(ListBox1.BindingContext(ListBox1.DataSource), CurrencyManager).Refresh()
    End Sub

    Private Sub ApplyChanges()
        Dim applyChangesSuccessfully As Boolean
        Dim tempName As String = CType(LINTCastMemberBindingSource.Current, LintCastMember).EmployeeName
        If Mode = FormMode.ADD Then
            applyChangesSuccessfully = AddCastMemberDetails(CType(LINTCastMemberBindingSource.Current, LintCastMember))
        ElseIf Mode = FormMode.EDIT Then
            applyChangesSuccessfully = UpdateCastMemberDetails(CType(LINTCastMemberBindingSource.Current, LintCastMember))
        End If
        If applyChangesSuccessfully Then
            RefreshListBox()
            ListBox1.Text = tempName
            Mode = FormMode.NORMAL
        End If
    End Sub

    Private Sub btnAssignIDCard_Click(sender As Object, e As System.EventArgs) Handles btnAssignIDCard.Click
        If Mode = FormMode.ADD Then
            Try
                If Factory.Security.HasLintAccessRight(_castInfo.LintAccessLevel, LintAccessLevel.ADD_USER) Then
                    Select Case MsgBox("This user is not in the database, do you want to add the user into database?", MsgBoxStyle.YesNo, "Add User?")
                        Case MsgBoxResult.Yes
                            Dim tempCastMember As LintCastMember = CType(LINTCastMemberBindingSource.Current, LintCastMember)
                            If AddCastMemberDetails(tempCastMember) Then
                                AssignIdCardOpen(tempCastMember.RFBadgeUserID)
                                RefreshListBox()
                                ListBox1.Text = tempCastMember.EmployeeName
                                EditUser()
                            Else
                                MsgBox("User cannot be added to the system! Please check data input!")
                            End If
                        Case MsgBoxResult.No
                    End Select
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                'Return False
            End Try
        ElseIf Mode = FormMode.EDIT Then
            AssignIdCardOpen()
        End If
    End Sub

    Private Sub AssignIdCardOpen(Optional cardID As Integer = 1)
        Using frm As New CtrlLintIdCardAssignment(_castInfo, FirstNameTextBox.Text, LastNameTextBox.Text)
            If cardID > 1 Then frm.tbIDNumber.Text = cardID
            AddHandler frm._Card_Assignment_Completed, Sub(a, b) InvokeIfNeeded(Sub() LINTCastMemberBindingSource.DataSource = Factory.LintInfo.GetLintUsers)
            'complaint about multiple handlers coming from the same location
            AddHandler frm._WriteRF, Sub(a) RFBadgeUserIDTextBox.Text = a
            AddHandler frm._Refresh, AddressOf RefreshListBox
            AddHandler frm._Card_Assignment_Exception, Sub(a, b) InvokeIfNeeded(Sub() MsgBox("Card assignment exception!"))
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnIDCardList_Click(sender As Object, e As System.EventArgs) Handles btnIDCardList.Click
        Using frm As New CtrlLintIdCardList(_castInfo, _formMode)
            AddHandler frm._Refresh, AddressOf RefreshListBox
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
        SuspendLayout()
        If Mode = FormMode.ADD Then
            LINTCastMemberBindingSource.RemoveCurrent()
        ElseIf Mode = FormMode.EDIT Then
            LINTCastMemberBindingSource.Item(LINTCastMemberBindingSource.Position) = _backupCastInfo
            _backupCastInfo = Nothing
        End If
        LINTCastMemberBindingSource.Position = _previousSelection
        Mode = FormMode.NORMAL
        RefreshListBox()
        ResumeLayout()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As System.EventArgs) Handles btnDeleteUser.Click
        If CheckIfNonAdminEditAdmin() Then
            MsgBox("You do not have the rights to perform this action!")
        Else
            If DeleteUser(CType(LINTCastMemberBindingSource.Current, LintCastMember)) Then
                _listOfCast.Remove(CType(LINTCastMemberBindingSource.Current, LintCastMember))
                LINTCastMemberBindingSource.DataSource = _listOfCast
                'Mode = FormMode.DELETE
                RefreshListBox()
            End If
        End If
    End Sub

    ''' <summary>
    ''' When the button is clicked, the system will locate the CMs based on the name filter.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(sender As Object, e As System.EventArgs) Handles btnSearch.Click
        Dim parameter = Factory.Services.GetSystemParameters(Plant.ALL_PLANTS, LintSystemParameterId.RostrApiKey)
        Dim list As List(Of LintCastMember) = GetFilterCastMemberList()
        Using frm As New CtrlLintUserSearch(list, parameter?.Value)
            AddHandler frm._NameFound, Sub(sdr, castMemberName) ListBox1.Text = castMemberName
            frm.ShowDialog()
        End Using
    End Sub

    Private Function GetFilterCastMemberList() As List(Of LintCastMember)
        Dim source As List(Of LintCastMember) = Nothing
        If _listOfCast IsNot Nothing Then
            If cmbCastName.Text = "ALL" Then
                source = _listOfCast
            ElseIf cmbCastName.Text = "TSA" Then
                source = _listOfCast.FindAll(Function(a As LintCastMember) a.WorkAtTSA)
            ElseIf cmbCastName.Text = "NSA" Then
                source = _listOfCast.FindAll(Function(a As LintCastMember) a.WorkAtNSA)
            Else
                source = _listOfCast.FindAll(Function(a As LintCastMember) a.WorkAtASA)
            End If
            If cbShowOnlyActiveCasts.Checked Then
                source = source.Where(Function(a) a.IsActive).ToList
            End If
        End If
        Return source
    End Function

    Private Sub cmbCastName_TextChanged(sender As Object, e As System.EventArgs) Handles cmbCastName.TextChanged
        LINTCastMemberBindingSource.DataSource = GetFilterCastMemberList()
        tsslCastCount.Text = String.Format("Cast Member Counts {0}", LINTCastMemberBindingSource.DataSource.Count)
    End Sub

    Private Function DeleteUser(employeeDetail As LintCastMember) As Boolean
        Try
            Select Case MsgBox(String.Format("Do you want to delete user {0} in the database?", employeeDetail.EmployeeName), MsgBoxStyle.YesNo, "Are you sure?")
                Case MsgBoxResult.Yes
                    Factory.LintInfo.DeleteLintUser(employeeDetail.EmployeeID)
                    MsgBox(String.Format("User {0} has been deleted from the system!", employeeDetail.EmployeeName))
                    Return True
                Case MsgBoxResult.No
                    'do nothing
                    Return False
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnEditUser_Click(sender As Object, e As System.EventArgs) Handles btnEditUser.Click
        RequestToChangeToEditMode()
    End Sub

    Private Sub LoadCastMembers()
        _listOfCast = Factory.LintInfo.GetLintUsers()
        If cbShowOnlyActiveCasts.Checked Then
            LINTCastMemberBindingSource.DataSource = _listOfCast.Where(Function(a) a.IsActive).ToList
        End If
        tsslCastCount.Text = String.Format("Cast Member Counts {0}", LINTCastMemberBindingSource.DataSource.Count)
    End Sub

    Private Sub EditUser()
        Mode = FormMode.EDIT
        _previousSelection = LINTCastMemberBindingSource.Position
        _backupCastInfo = CType(LINTCastMemberBindingSource.Current, LintCastMember).Clone
        _originalEmployeeID = CType(LINTCastMemberBindingSource.Current, LintCastMember).EmployeeID
    End Sub

    Private Function CheckIfNonAdminEditAdmin() As Boolean
        Dim cast As LintCastMember = CType(LINTCastMemberBindingSource.Current, LintCastMember)
        Dim check As Boolean = _castInfo.UserType <> LintUserType.SYSTEM_ADMINISTRATOR And (UserTypeComboBox.SelectedValue = LintUserType.SYSTEM_ADMINISTRATOR Or cast.UserType = LintUserType.SYSTEM_ADMINISTRATOR)
        Return check
    End Function

    Protected Overrides Sub Initialize()
        Mode = FormMode.NORMAL
        LintSecurityProvider.ENABLE_SECURITY = True
        LoadCastMembers()
        UserTypeComboBox.LoadDataSource(Factory.LintInfo.GetLintUserTypes)
        AssignedShiftComboBox.LoadDataSource(Factory.LintInfo.GetLintShifts)
        InitializeControlsByUserRights()
        AddBusinessRules()
        cmbCastName.Text = "ALL"
        tsslLogin.Text = String.Format("Current Logged In As {0}", _castInfo.EmployeeName)
        AddHandler cbShowOnlyActiveCasts.CheckedChanged, AddressOf cmbCastName_TextChanged
    End Sub

    Private Sub ObjectIsInvalidEvent(sender As Object, e As ObjectInvalidEventArgs)
        _isDuplicateEmployeeNameTriggered = e.Errors.Exists(Function(a) a.RuleName = "CheckDuplicateEmployeeName")
        MsgBox(e.ErrorSummary)
    End Sub

    Private Sub AddBusinessRules()
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "Employee name is empty!",
                                    "CheckEmployeeNameInput",
                                    Function(a As LintCastMember) Not String.IsNullOrEmpty(a.FirstName) OrElse
                                        Not String.IsNullOrEmpty(a.LastName) OrElse
                                        Not String.IsNullOrEmpty(a.FirstName) OrElse
                                        Not String.IsNullOrEmpty(a.LastName) OrElse
                                        IsNumeric(a.FirstName) OrElse
                                        IsNumeric(a.LastName))
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "Employee ID is not valid!",
                                    "CheckEmployeeIDInput",
                                    Function(a As LintCastMember) IsNumeric(a.EmployeeID) AndAlso a.EmployeeID > 0)
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "Employee ID has already existed in the database!",
                                    "CheckDuplicateEmployeeID",
                                    Function(a As LintCastMember) (Not ((_originalEmployeeID <> a.EmployeeID) AndAlso Factory.LintInfo.CheckIfUserExists(a.EmployeeID))))
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "This employee name is in the database, contact Sustaining Team for support",
                                    "CheckDuplicateEmployeeName",
                                    Function(a As LintCastMember) Not (_listOfCast.Exists(Function(b) a.FirstName.Trim.ToLower = b.FirstName.Trim.ToLower AndAlso
                                                                                                 a.LastName.Trim.ToLower = b.LastName.Trim.ToLower) AndAlso
                                                                                                 Mode = FormMode.ADD AndAlso
                                                                                                 _castInfo.UserType <> LintUserType.SYSTEM_ADMINISTRATOR))
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "User type is not valid!",
                                    "CheckUserTypeInput",
                                    Function(a As LintCastMember) a.UserType > 0)
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "You can't change the user to this type!",
                                    "CheckChangeUserType",
                                    Function(a As LintCastMember) (_castInfo.UserType = LintUserType.SYSTEM_ADMINISTRATOR) OrElse
                                        ((a.UserType <> LintUserType.SYSTEM_ADMINISTRATOR) AndAlso
                                        (_castInfo.UserType <> LintUserType.SYSTEM_ADMINISTRATOR)))

        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "Select one or more work locations!",
                                    "CheckLocationInput",
                                    Function(a As LintCastMember) a.WorkAtASA OrElse a.WorkAtNSA OrElse a.WorkAtTSA)
        BusinessRuleManager.AddRule(GetType(LintCastMember),
                                    "Select a shift!",
                                    "CheckShiftInput",
                                    Function(a As LintCastMember) a.AssignedShift = Shift.FIRST_SHIFT OrElse
                                        a.AssignedShift = Shift.SECOND_SHIFT OrElse
                                        a.AssignedShift = Shift.THIRD_SHIFT)
        AddHandler BusinessRuleManager.ObjectIsInvalidEvent, AddressOf ObjectIsInvalidEvent
    End Sub

    ''' <summary>
    ''' Initializes the controls by user rights.
    ''' </summary>
    Private Sub InitializeControlsByUserRights()
        gbWorkLocation.Enabled = False
        With _castInfo
            gbSystemConfiguration.Enabled = .EditUserSystemConfiguration
            gbBagEdits.Enabled = .EditBags
            UserTypeComboBox.Enabled = .EditUserType
            EmployeeIDTextBox.Enabled = .EditEmployeeID
            RFBadgeUserIDTextBox.Enabled = .EditCardNumber
            btnAssignIDCard.Enabled = .EditCardAssignment
            btnIDCardList.Enabled = .EditCard
            cbShowOnlyActiveCasts.Enabled = .EditUserActiveStatus
            IsActiveCheckBox1.Enabled = .EditUserActiveStatus
            If .EditUser Then AddHandler ListBox1.MouseDoubleClick, AddressOf lstbxLINTUserList_MouseDoubleClick
        End With
    End Sub

    Private Sub lstbxLINTUserList_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        RequestToChangeToEditMode()
    End Sub

    Private Sub RequestToChangeToEditMode()
        If CheckIfNonAdminEditAdmin() Then
            MsgBox("You do not have the rights to perform this action!")
        ElseIf CheckIfNonAdminEditSelf() Then
            MsgBox("You may not edit yourself!")
        Else
            EditUser()
        End If
    End Sub

    Private Function CheckIfNonAdminEditSelf() As Boolean
        Return _castInfo.LINTAdminAccessLevel <> LintAdminAccessLevel.ADMIN AndAlso _castInfo.EmployeeID = CType(LINTCastMemberBindingSource.Current, LintCastMember).EmployeeID
    End Function

    Private Sub ListBox1_SingleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        _previousSelection = LINTCastMemberBindingSource.Position
    End Sub

    Private Function AddCastMemberDetails(userDetail As LintCastMember) As Boolean
        Try
            If CheckUserInputs() Then
                If RFBadgeUserIDTextBox.Text = String.Empty OrElse CInt(RFBadgeUserIDTextBox.Text) = 0 OrElse CInt(RFBadgeUserIDTextBox.Text) = 1 Then
                    userDetail.RFBadgeUserID = 1
                Else
                    userDetail.RFBadgeUserID = CInt(RFBadgeUserIDTextBox.Text)
                End If
                Factory.LintInfo.AddLintUser(userDetail)

                updateProxId(Integer.Parse(userDetail.EmployeeID))

                Dim logMsg = $"Added user (lint_user_id): {userDetail.LintUserId}"
                Factory.LintInfo.AddLog(_castInfo.EmployeeID, _castInfo.RFBadgeUserID, logMsg)

                MsgBox(String.Format("User {0} has been added to the system!", userDetail.EmployeeName))
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Function updateProxId(perner As Integer) As Boolean
        Dim isSuccessful = False

        If Not String.IsNullOrEmpty(proxTextbox.Text) Then
            Dim proxLen = Len(proxTextbox.Text)
            Dim currentProxId = Integer.Parse(proxTextbox.Text)
            Dim userId = getTasUserId(perner)
            Dim dbProxId = _tas.GetUserBlueId(userId)

            If currentProxId <> dbProxId AndAlso proxLen = 6 Then
                Dim payload As IdUpdateBody() = New IdUpdateBody(1) {}
                payload(0) = New IdUpdateBody With {
                    .CardData = currentProxId,
                    .CardTypeId = 1
                }

                Dim newProx = _tas.UpdateProxId(userId, payload)

                If newProx > 0 Then
                    isSuccessful = True
                    proxTextbox.Text = newProx.ToString().PadLeft(6, "0")
                End If
            ElseIf proxLen < 6 Then
                MsgBox($"Prox ID must be a value of 6 digits.  {proxLen} digits supplied")
            End If
        Else
            isSuccessful = True
        End If

        Return isSuccessful
    End Function

    Private Function CheckUserInputs() As Boolean
        _isDuplicateEmployeeNameTriggered = False
        Dim proxLen = Len(proxTextbox.Text)
        Dim proxTextboxCorrect = proxLen = 6

        ' check if empty string exists in text-box, pass validation if true
        If Not String.IsNullOrEmpty(proxTextbox.Text) Then
            If proxLen < 6 Then
                MsgBox($"Prox ID must be a value of 6 digits.  {proxLen} digits supplied")
            End If
        Else
            proxTextboxCorrect = True
        End If

        Dim cm As LintCastMember = CType(LINTCastMemberBindingSource.Current, LintCastMember)
        Return cm.IsValid AndAlso proxTextboxCorrect
    End Function

    Private Function UpdateCastMemberDetails(userDetail As LintCastMember) As Boolean
        Try
            If CheckUserInputs() Then
                Factory.LintInfo.UpdateLintUser(userDetail, _originalEmployeeID)
                updateProxId(Integer.Parse(userDetail.EmployeeID))
                MsgBox(String.Format("User {0} has been updated in the system!", userDetail.EmployeeName))
                LoadCastMembers()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub UserTypeComboBox_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles UserTypeComboBox.SelectedIndexChanged
        If (_formMode = FormMode.EDIT OrElse _formMode = FormMode.ADD) AndAlso Not IsShiftPressed() Then
            RemoveHandler UserTypeComboBox.SelectedIndexChanged, AddressOf UserTypeComboBox_SelectionChangeCommitted
            Dim cast As LintCastMember = CType(LINTCastMemberBindingSource.Current, LintCastMember)
            cast.UserType = CType(UserTypeComboBox.SelectedValue, LintUserType)
            UpdateUserRights(cast)
            AddHandler UserTypeComboBox.SelectedIndexChanged, AddressOf UserTypeComboBox_SelectionChangeCommitted
        End If
    End Sub

    Private Sub UpdateUserRights(cast As LintCastMember)
        If cast.WorksInMultipleLocations OrElse cast.GetWorkLocation = Plant.TSA Then
            cast.FuturailAccessLevel = [Enum].Parse(GetType(DefaultRailAccessLevel), String.Format("TSA_{0}", UserTypeComboBox.SelectedValue))
            cast.LintAccessLevel = [Enum].Parse(GetType(DefaultLINTAccessLevel), String.Format("TSA_{0}", UserTypeComboBox.SelectedValue))
        Else
            cast.FuturailAccessLevel = [Enum].Parse(GetType(DefaultRailAccessLevel), String.Format("{0}_{1}", cast.GetWorkLocation, UserTypeComboBox.SelectedValue))
            cast.LintAccessLevel = [Enum].Parse(GetType(DefaultLINTAccessLevel), String.Format("{0}_{1}", cast.GetWorkLocation, UserTypeComboBox.SelectedValue))
        End If
    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedValueChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim perner = CType(ListBox1.SelectedItem, LintCastMember).EmployeeID
            Dim x = Factory.LintInfo.GetNumberOfCardReassignmentsByEmployeeID(perner)
            lblCardReassignment.Visible = (x > 0)
            lblCardReassignment.Text = String.Format("Number of Reassignments: {0}", x)

            Dim userId As Integer = getTasUserId(Integer.Parse(perner))
            Dim prox As Integer = _tas.GetUserBlueId(userId)

            If prox > 0 Then
                proxTextbox.Text = prox.ToString().PadLeft(6, "0")
            Else
                proxTextbox.Clear()
            End If
        End If
    End Sub

    Private Function getTasUserId(perner As Integer) As Integer
        Dim userId = 0
        Dim tasUser As TasUser = Nothing

        Try
            If _tasUsers IsNot Nothing Then
                tasUser = (From user In _tasUsers
                           Where user.Perner = perner
                           Select user).FirstOrDefault()

                If tasUser IsNot Nothing Then
                    userId = tasUser.Id
                Else ' May want to consider building out an error form with data that is configurable.
                    MsgBox($"CM with Perner: {perner} was not found. Please ask the SE team to verify that the Airflow Scheduler service is running.", MsgBoxStyle.OkOnly, "User Not Found In TAS")
                End If
            End If
        Catch ex As Exception
            WriteException(ex)
        End Try

        Return userId
    End Function

    Public Async Function SetPersonDetailsAsync(Optional imageUrl As String = "", Optional firstName As String = "", Optional lastName As String = "") As Task
        Await Task.Run(Sub()
                           PostIfNeeded(SyncContext, RostrImage, Sub()
                                                                     Dim tImage As Bitmap
                                                                     Dim resourceImage As Object = My.Resources.default_avatar

                                                                     If Not String.IsNullOrEmpty(imageUrl) Then
                                                                         Dim tClient As New WebClient()
                                                                         Try
                                                                             tImage = Image.FromStream(New MemoryStream(tClient.DownloadData(imageUrl)))
                                                                         Catch ex As Exception
                                                                             WriteException(ex)
                                                                             tImage = New Bitmap(CType(resourceImage, Image))
                                                                         End Try
                                                                     Else
                                                                         tImage = New Bitmap(CType(resourceImage, Image))
                                                                     End If

                                                                     If tImage IsNot Nothing Then
                                                                         RostrImage.Image = tImage
                                                                     End If
                                                                 End Sub)

                           If (Not String.IsNullOrEmpty(firstName)) AndAlso (_formMode = FormMode.EDIT OrElse _formMode = FormMode.ADD) Then
                               Dim castMember = CType(LINTCastMemberBindingSource.Current, LintCastMember)

                               castMember.FirstName = firstName
                               castMember.LastName = lastName
                           End If
                       End Sub)
    End Function

    Public Async Function GetRostrAsync(Optional perner As String = "") As Task
        Await TryUserActionAsync(Async Sub()
                                     If String.IsNullOrWhiteSpace(perner) Then
                                         '' why is this method called then.  So do nothing.
                                     Else
                                         '' Wait while the cast member's picture is loaded.
                                         Await Task.Run(Sub() PostIfNeeded(SyncContext, RostrImage, Sub() RostrImage.Image = My.Resources.loading_circle))

                                         Try
                                             Dim _rostrPerson As RostrPerson = Await _rostr.GetPersonAsync(perner)
                                             If (_rostrPerson IsNot Nothing) Then
                                                 Await SetPersonDetailsAsync(_rostrPerson.ImagePath, _rostrPerson.NickName, _rostrPerson.LastName)
                                             Else
                                                 Await SetPersonDetailsAsync()
                                             End If
                                             PostIfNeeded(SyncContext, Me, Sub()
                                                                               FirstNameTextBox.Enabled = False
                                                                               LastNameTextBox.Enabled = False
                                                                               FirstNameTextBox.ReadOnly = True
                                                                               LastNameTextBox.ReadOnly = True
                                                                           End Sub)
                                         Catch ex As Exception
                                             PostIfNeeded(SyncContext, Me, Sub()
                                                                               FirstNameTextBox.Enabled = True
                                                                               LastNameTextBox.Enabled = True
                                                                               FirstNameTextBox.ReadOnly = False
                                                                               LastNameTextBox.ReadOnly = False
                                                                           End Sub)
                                         End Try
                                     End If
                                 End Sub)
    End Function

    Private Async Sub EmployeeIDTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles EmployeeIDTextBox.TextChanged
        If (_formMode = FormMode.EDIT OrElse _formMode = FormMode.ADD) AndAlso EmployeeIDTextBox.Text.Count > 3 Then
            Await GetRostrAsync(EmployeeIDTextBox.Text)
        End If
    End Sub

    Private Async Sub LintCastMemberBindingSource_CurrentChanged(sender As Object, e As System.EventArgs)
        Await GetRostrAsync(CType(LINTCastMemberBindingSource.Current, LintCastMember).EmployeeID)
    End Sub

    Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
        MyBase.OnClosing(e)
        _helpForm.Close()
        BusinessRuleManager.RemoveRulesByType(GetType(LintCastMember))
        RemoveHandler BusinessRuleManager.ObjectIsInvalidEvent, AddressOf ObjectIsInvalidEvent
    End Sub

    Private Sub CtrlLintUserManagement_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        ' load user data from TAS
        _tasUsers = _tas.GetUsersAsync()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As System.EventArgs) Handles PictureBox1.Click
        If _helpForm.IsDisposed Then
            _helpForm = New CtrlBlueId()
        End If

        _helpForm.Show()
    End Sub

#End Region

#Region "Contructors"

    Public Sub New(castInfo As LintCastMember, rostrToken As String)
        InitializeComponent()
        DoubleBuffered = True
        _rostr = New RostrClient(rostrToken)
        _castInfo = castInfo

        AddHandler LINTCastMemberBindingSource.CurrentChanged, AddressOf LintCastMemberBindingSource_CurrentChanged
    End Sub

#End Region

End Class