Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface IApplicationConfigFile
        Inherits IConfigurationFile

        Property ApplicationId As LintApplicationId
        Property ApplicationMode As ProgramMode
        Property Plant As Plant

    End Interface
End Namespace