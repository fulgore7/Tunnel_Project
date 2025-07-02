Imports System.ComponentModel

Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Configurations
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.EventArgs

Public Class LintApplicationManager
    Inherits InformationBroadcasterBase(Of LintApplicationManager, LintApplicationManagerEventArgs)

#Region "Fields"
    Private _previousApplicationMode As ProgramMode = ProgramMode.UNKNOWN
    Private WithEvents Configuration As LintApplicationConfigurationManager = LintApplicationConfigurationManager.Instance
#End Region

#Region "Properties"
    Public ReadOnly Property PreviousApplicationMode As ProgramMode
        Get
            Return _previousApplicationMode
        End Get
    End Property
#End Region

#Region "Methods"

    Public Sub Refresh()
        Dim args As New LintApplicationManagerEventArgs(PreviousApplicationMode,
                                                        Configuration.ConfigFile.ApplicationMode,
                                                        False,
                                                        False,
                                                        False,
                                                        False,
                                                        False,
                                                        False)
        RunBackgroundWorker(args)
    End Sub

    Private Sub Configuration_ConfigObjectChanged(sender As Object, e As PropertyChangedEventArgs) Handles Configuration.ConfigObjectChanged
        If Configuration.ConfigFile.ApplicationMode = ProgramMode.FAIL_OVER_MANUAL Then
            _previousApplicationMode = ProgramMode.FAIL_OVER_MANUAL
        Else
            _previousApplicationMode = ProgramMode.UNKNOWN
        End If
        Dim isWorkstationChanged As Boolean
        Dim isApplicationModeChanged As Boolean
        Dim isChatSevicesChanged As Boolean
        Dim isInUseLintConnectionChanged As Boolean
        Dim isEnableLoggingChanged As Boolean
        Select Case e.PropertyName
            Case "ApplicationMode"
                isApplicationModeChanged = True
            Case "IsChatServiceEnabled"
                isChatSevicesChanged = True
            Case "WorkStation"
                isWorkstationChanged = True
            Case "LintInUseProductionConnectionStringName"
                isInUseLintConnectionChanged = True
            Case "EnableLogging"
                isEnableLoggingChanged = True
        End Select
        Dim args As New LintApplicationManagerEventArgs(PreviousApplicationMode,
                                                        Configuration.ConfigFile.ApplicationMode,
                                                        isWorkstationChanged,
                                                        isApplicationModeChanged,
                                                        isChatSevicesChanged,
                                                        isInUseLintConnectionChanged,
                                                        isEnableLoggingChanged,
                                                        Configuration.ConfigFile.IsChatServiceEnabled)
        RunBackgroundWorker(args)
    End Sub

    Protected Overrides Sub OnSubscriberAdded(addedSubscriber As IInformationSubscriber(Of LintApplicationManagerEventArgs))
        addedSubscriber.ProcessSubscribedInformation(New LintApplicationManagerEventArgs(PreviousApplicationMode,
                                                        Configuration.ConfigFile.ApplicationMode,
                                                        False,
                                                        False,
                                                        False,
                                                        False,
                                                        False,
                                                        isChatEnabled:=Configuration.ConfigFile.IsChatServiceEnabled))
    End Sub

    Protected Overrides Sub WorkToPerform(sender As Object, e As DoWorkEventArgs)
        Dim args As LintApplicationManagerEventArgs = TryCast(e.Argument, LintApplicationManagerEventArgs)
        Dim subscribers As IList(Of IInformationSubscriber(Of LintApplicationManagerEventArgs)) = Me.Subscribers
        For i As Integer = subscribers.Count - 1 To 0 Step -1
            subscribers(i).ProcessSubscribedInformation(CType(e.Argument, LintApplicationManagerEventArgs))
        Next
        args.IsDataRetrivedSuccessfully = True
        args.InfoRetrivalUnsuccessfulCounts = 0
        LastUpdatedTime = Now
        e.Result = args
    End Sub
#End Region

#Region "Constructors"
    Public Sub New()
        _previousApplicationMode = Configuration.ConfigFile.ApplicationMode
    End Sub
#End Region

End Class