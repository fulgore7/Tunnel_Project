Imports Wdw_Sust.Core.Configurations
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core

Public Class DisplayConfigManager
    Inherits EditableSingletonConfigurationManager(Of DisplayConfigManager, DisplayConfigFile)

    Protected Overrides Function GetDefaultSettings() As DisplayConfigFile
        Return New DisplayConfigFile With
        {
            .DefaultForm = FormType.NO_FORM,
            .ChildFormIsCentered = True,
            .MainFormIsFullScreen = True,
            .ShowToolBar = True,
            .ShowChildFormBorder = True
        }
    End Function

End Class
