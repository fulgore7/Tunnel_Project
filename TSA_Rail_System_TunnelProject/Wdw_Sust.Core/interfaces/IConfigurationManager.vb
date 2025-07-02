Namespace Interfaces
    Public Interface IConfigurationManager(Of T As IConfigurationFile)
        Inherits IConfigurationManager
        Property ConfigFile As T
    End Interface

    Public Interface IConfigurationManager
        Property ConfigurationDirectory As String
        Property ConfigurationFileName As String
        ReadOnly Property ConfigurationFilePath As String
        Sub Load()
        Function Save() As Boolean
        Function Exist() As Boolean
    End Interface
End Namespace