Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Interfaces

Namespace Configurations
    <Serializable>
    Public Class LintApplicationConfigFile
        Inherits ApplicationConfigFile(Of LintApplicationConfigFile)
        Implements IConfigurationFile

        Private _isRemoteLinxUsed As Boolean
        Private _isHidInterfaceUsed As Boolean
        Private _isChatServiceEnabled As Boolean
        Private _workStation As WorkStations
        Private _isInitialized As Boolean
        Private _sendHeartbeat As Boolean

        Public Property SendHeartbeat() As Boolean
            Get
                Return _sendHeartbeat
            End Get
            Set(ByVal value As Boolean)
                SetField(_sendHeartbeat, value)
            End Set
        End Property

        Public Property BagDrawingMode As BagDrawingMode
        Public Property PlcTopics As PlcTopicNameConfigFile

        Public ReadOnly Property IsNotHidInterfaceUsed As Boolean
            Get
                Return Not IsHidInterfaceUsed
            End Get
        End Property
        Public Property SecuraKeyComportSettings As ComPortSetting

        Public ReadOnly Property IsFailOverMode As Boolean
            Get
                Return ApplicationMode = ProgramMode.FAIL_OVER_AUTO OrElse ApplicationMode = ProgramMode.FAIL_OVER_MANUAL
            End Get
        End Property

        Public ReadOnly Property IsTestMode As Boolean
            Get
                Return ApplicationMode = ProgramMode.TEST
            End Get
        End Property

        Public Property IsHidInterfaceUsed As Boolean
            Get
                Return _isHidInterfaceUsed
            End Get
            Set(value As Boolean)
                If SetField(_isHidInterfaceUsed, value) Then
                    OnPropertyChanged("IsNotHidInterfaceUsed")
                End If
            End Set
        End Property
        Public Property WorkStation As WorkStations
            Get
                Return _workStation
            End Get
            Set(value As WorkStations)
                SetField(_workStation, value)
            End Set
        End Property
        Public Property IsChatServiceEnabled As Boolean
            Get
                Return _isChatServiceEnabled
            End Get
            Set(value As Boolean)
                SetField(_isChatServiceEnabled, value)
            End Set
        End Property
        Public Property IsRemoteLinxUsed As Boolean
            Get
                Return _isRemoteLinxUsed
            End Get
            Set(value As Boolean)
                SetField(_isRemoteLinxUsed, value)
            End Set
        End Property
        Public Property RemoteLinxAddress As String
        Public Property IsLoggingEnabled As Boolean
        Public ReadOnly Property IsApplicationIdDefined As Boolean
            Get
                Return ApplicationId <> LintApplicationId.UNKNOWN
            End Get
        End Property
        Public Overrides ReadOnly Property IsInitialized As Boolean
            Get
                Return WorkStation <> WorkStations.UNKNOWN AndAlso Plant <> Plant.UNKNOWN AndAlso ApplicationId <> LintApplicationId.UNKNOWN
            End Get
        End Property

        Public Overrides ReadOnly Property IsValid As Boolean
            Get
                If Not MyBase.IsValid Then Return False
                Return Plant <> Plant.UNKNOWN AndAlso
                ApplicationId <> LintApplicationId.UNKNOWN AndAlso
                ApplicationMode <> ProgramMode.UNKNOWN AndAlso
                WorkStation <> WorkStations.UNKNOWN
            End Get
        End Property

        Public Property RfidReaderComPortSetting As ComPortSetting

        Public Sub New()
            SecuraKeyComportSettings = New ComPortSetting
        End Sub
    End Class
End Namespace