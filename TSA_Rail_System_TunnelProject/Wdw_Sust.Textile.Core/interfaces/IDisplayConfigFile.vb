Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface IDisplayConfigFile
        Inherits IConfigurationFile
        Property ChildFormIsCentered As Boolean
        Property DefaultForm As FormType
        Property MainFormIsFullScreen As Boolean
        Property ShowChildFormBorder As Boolean
        Property ShowToolBar As Boolean
    End Interface
End Namespace