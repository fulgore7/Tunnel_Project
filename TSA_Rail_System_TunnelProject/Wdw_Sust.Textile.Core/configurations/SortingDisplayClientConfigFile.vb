Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Interfaces

Namespace Configurations
    Public Class SortingDisplayClientConfigFile
        Inherits ConfigurationFileBase(Of SortingDisplayClientConfigFile)
        Implements IConfigurationFile
        Public Property ClientDetail As LintClientWorkStationDetail
        Public Property ServicePortNumber As Integer
        Public Property ServerUrl As String
        Public Sub New()

        End Sub
    End Class
End Namespace