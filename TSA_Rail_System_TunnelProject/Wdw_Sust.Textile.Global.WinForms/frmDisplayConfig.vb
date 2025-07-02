Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Core.WinForms.ControlExtensions
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Core.Helpers
Imports System.Windows.Forms

Public Class frmDisplayConfig
    Inherits CtrlLightFormBase

#Region "Fields"
    Private _displayConfig As DisplayConfigManager
    Private _configManager As LintApplicationConfigurationManager = LintApplicationConfigurationManager.Instance
    Private _plant As Plant
#End Region

#Region "Properties"
    Public ReadOnly Property DisplayConfigFile As DisplayConfigFile
        Get
            Return _displayConfig.ConfigFile
        End Get
    End Property
#End Region

    Private Async Sub frmDisplayConfig_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        _displayConfig.Load()
        Await SetFieldsOnLoad()
    End Sub

    Private Async Function SetFieldsOnLoad() As Task
        Await Task.Run(Sub()
                           Dim configFile = _displayConfig.ConfigFile

                           PostSyncCallback(Sub()
                                                LoadEnumDataSource(Of FormType)(cbxDefaultForm, descriptionFilter:=IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath), useDescription:=False)
                                                cbxDefaultForm.SelectedValue = configFile.DefaultForm
                                                chbxCenterForm.Checked = configFile.ChildFormIsCentered
                                                chbxShowChildFormBorder.Checked = configFile.ShowChildFormBorder
                                                chbxLaunchMaximized.Checked = configFile.MainFormIsFullScreen
                                                chbxShowToolbar.Checked = configFile.ShowToolBar
                                            End Sub)
                       End Sub)
    End Function

    Private Sub btnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click
        If CheckRights() = True Then
            SetConfigFile()
            _displayConfig.Save()

            Me.Close()
        End If
    End Sub

    Private Sub SetConfigFile()
        _displayConfig.ConfigFile = New DisplayConfigFile With {
            .DefaultForm = cbxDefaultForm.SelectedValue,
            .ChildFormIsCentered = chbxCenterForm.Checked,
            .ShowChildFormBorder = chbxShowChildFormBorder.Checked,
            .MainFormIsFullScreen = chbxLaunchMaximized.Checked,
            .ShowToolBar = chbxShowToolbar.Checked
        }
    End Sub

    Private Function CheckRights() As Boolean
        Dim args As New LintRoleAccessRightEventArgs(LintUserType.SYSTEM_ADMINISTRATOR, _plant)
        Dim card As RfidCard = GetRfidCardData(_configManager.ConfigFile.SecuraKeyComportSettings)
        Dim returnVar As Boolean = False
        Factory.Security.CheckRoleAccessRights(card, args)
        If args.CancelAction Then
            returnVar = False
        End If
        If args.HasRight Then
            returnVar = True
        End If

        Return returnVar
    End Function

    Public Sub New()
        MyBase.New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _displayConfig = DisplayConfigManager.Instance
        _displayConfig.ConfigurationDirectory = _configManager.ConfigurationDirectory
    End Sub
End Class