' ***********************************************************************
' Assembly         : Wdw_Sust.Textile.Global.WinForms
' Author           : yeunc009
' Created          : 06-14-2017
'
' Last Modified By : yeunc009
' Last Modified On : 06-25-2017
' ***********************************************************************
' <copyright file="CtrlLintConnectionStringBuilder.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Imports Wdw_Sust.Core.Db
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.WinForms.Core


''' <summary>
''' Class CtrlLintConnectionStringBuilder.
''' </summary>
''' <seealso cref="Wdw_Sust.Textile.Global.WinForms.Core.CtrlFormBase" />
Public Class CtrlLintConnectionStringBuilder
    Inherits CtrlFormBase

    ''' <summary>
    ''' The use local check
    ''' </summary>
    Private _useLocalCheck As Boolean
    ''' <summary>
    ''' The no right message
    ''' </summary>
    Private Const NO_RIGHT_MESSAGE As String = "You don't have right or the password is incorrect to save changes!!"

    ''' <summary>
    ''' Occurs when [on saving data].
    ''' </summary>
    Public Event _OnSavingData As EventHandler(Of IRoleAccessRightEventArgs)

    ''' <summary>
    ''' This is where the initailization logic for the form
    ''' </summary>
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        DbConfigFileBindingSource.DataSource = Db_Configuration.ConfigFile
    End Sub

    ''' <summary>
    ''' Check using the local method
    ''' </summary>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Private Function LocalCheck() As Boolean
        Dim password As String = InputBox("Please input the password")
        If Not IsNumeric(password) Then Return False
        Return CInt(password) = 8665
    End Function

    ''' <summary>
    ''' Check using the database method
    ''' </summary>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Private Function DatabaseCheck() As Boolean
        Dim args As New LintRoleAccessRightEventArgs(LintUserType.SYSTEM_ADMINISTRATOR, hasRight:=Not LintSecurityProvider.ENABLE_SECURITY)
        OnSavingData(args)
        Return args.HasRight
    End Function

    ''' <summary>
    ''' Handles the <see cref="E:SavingData" /> event.
    ''' </summary>
    ''' <param name="e">The <see cref="LintRoleAccessRightEventArgs" /> instance containing the event data.</param>
    Private Sub OnSavingData(ByVal e As LintRoleAccessRightEventArgs)
        If LintSecurityProvider.ENABLE_SECURITY Then
            RaiseEvent _OnSavingData(Me, e)
        End If
    End Sub

    ''' <summary>
    ''' Handles the save action.
    ''' </summary>
    ''' <param name="accessRightHandler">The access right handler.</param>
    Private Sub HandleSaveAction(ByVal accessRightHandler As Func(Of Boolean))
        If accessRightHandler() Then
            SaveSettings()
            'MsgBox("Please close the program And restart!")
            Close()
        Else
            MsgBox(NO_RIGHT_MESSAGE)
        End If
    End Sub

    ''' <summary>
    ''' Save changes
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If _useLocalCheck Then
            HandleSaveAction(AddressOf LocalCheck)
        Else
            HandleSaveAction(AddressOf DatabaseCheck)
        End If
    End Sub

    ''' <summary>
    ''' Saves the settings.
    ''' </summary>
    Private Sub SaveSettings()
        Db_Configuration.Save()
    End Sub

    ''' <summary>
    ''' check if the connection string is valid
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub btnTestConnection_Click(sender As Object, e As System.EventArgs) Handles btnTestConnection.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            If CheckIfDatabaseIsReachable(CType(ListBox1.SelectedItem, SqlDbConnectionBuilder).ConnectionString) Then
                MsgBox("Test Successful!")
            Else
                MsgBox("Test is not Successful! Please check the connection detail again!")
            End If
        Else
            MsgBox("Please select a connection to check!")
        End If
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the <see cref="CtrlLintConnectionStringBuilder"/> class.
    ''' </summary>
    ''' <param name="useLocalCheck">if set to <c>true</c> [use local check].</param>
    Public Sub New(ByVal useLocalCheck As Boolean)
        InitializeComponent()
        _useLocalCheck = useLocalCheck
    End Sub

    Public Sub New()
        Me.New(False)
    End Sub

End Class

