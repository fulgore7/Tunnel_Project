Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Interfaces

<Serializable>
Public Class ApplicationConfigFile(Of T As IConfigurationFile)
    Inherits ConfigurationFileBase(Of T)
    Implements IApplicationConfigFile

    Private _applicationId As LintApplicationId
    Private _applicationMode As ProgramMode
    Private _plant As Plant

    Public Property ApplicationId As LintApplicationId Implements IApplicationConfigFile.ApplicationId
        Get
            Return _applicationId
        End Get
        Set(value As LintApplicationId)
            If SetField(_applicationId, value) Then
                OnPropertyChanged("IsApplicationIdDefined")
            End If
        End Set
    End Property

    Public Property ApplicationMode As ProgramMode Implements IApplicationConfigFile.ApplicationMode
        Get
            Return _applicationMode
        End Get
        Set(value As ProgramMode)
            SetField(_applicationMode, value)
        End Set
    End Property

    Public Property Plant As Plant Implements IApplicationConfigFile.Plant
        Get
            Return _plant
        End Get
        Set(value As Plant)
            SetField(_plant, value)
        End Set
    End Property

End Class

Public Class ApplicationConfigFile
    Inherits ApplicationConfigFile(Of ApplicationConfigFile)
    Public Overrides ReadOnly Property IsValid As Boolean
        Get
            If Not MyBase.IsValid Then Return False
            Return Plant <> Plant.UNKNOWN AndAlso
                ApplicationId <> LintApplicationId.UNKNOWN AndAlso
                ApplicationMode <> ProgramMode.UNKNOWN
        End Get
    End Property
End Class

