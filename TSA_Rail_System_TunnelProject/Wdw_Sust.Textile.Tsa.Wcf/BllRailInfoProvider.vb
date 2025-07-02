Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Tsa.Wcf.Interfaces

Public Class BllRailInfoProvider
    Inherits SingletonProviderBase(Of BllRailInfoProvider)
    Implements IInformationSubscriber(Of LintApplicationManagerEventArgs)

    Private WithEvents _service As IWcfTsaRailInfoService
    Private _informationSource As InformationSource
    Private JOB_MANAGER As LintJobProvider = LintJobProvider.Instance

    Public ReadOnly Property Service As IWcfTsaRailInfoService
        Get
            Return _service
        End Get
    End Property

    ''' <summary>
    ''' Information source to get data. Either using Wcf or directly geting from the database
    ''' </summary>
    Public Property InformationSource As InformationSource
        Get
            Return _informationSource
        End Get
        Set(value As InformationSource)
            If _informationSource <> value Then
                _informationSource = value
                If _informationSource = InformationSource.Wcf Then
                    _service = BllWcfRailInfoProvider.Instance
                Else
                    _service = BllDatabaseRailInfoProvider.Instance
                End If
            End If
        End Set
    End Property

    Public Property ParentBroadcaster As IInformationBroadcaster Implements IInformationSubscriber.ParentBroadcaster

    Public Property SubscriberName As String Implements IInformationSubscriber.SubscriberName

    Public Sub New()
        InformationSource = InformationSource.Wcf
    End Sub

    Private Sub _service_InformationRetrivalFailed(sender As Object, e As System.EventArgs) Handles _service.InformationRetrivalFailed
        If TypeOf sender Is BllWcfRailInfoProvider Then
            Dim jobName As String = String.Format("Check_Application_Server_{0}", Me.GetHashCode)
            InformationSource = InformationSource.Database
            JOB_MANAGER.DoOnce(jobName, TimeSpan.FromMinutes(5), Sub() InformationSource = InformationSource.Wcf)
        End If
    End Sub

    Public Sub ProcessSubscribedInformation(args As LintApplicationManagerEventArgs) Implements IInformationSubscriber(Of LintApplicationManagerEventArgs).ProcessSubscribedInformation

    End Sub
End Class





