
Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Interfaces

<Serializable()>
Public Class LintServiceSettings
    Inherits ConfigurationFileBase(Of LintServiceSettings)
    Implements IConfigurationFile

    Property LINTServiceSettings As New List(Of LintServiceSetting)
    Property LINTSystemSettings As New LintSystemParameters
    Property IsLocalMode As Boolean
End Class