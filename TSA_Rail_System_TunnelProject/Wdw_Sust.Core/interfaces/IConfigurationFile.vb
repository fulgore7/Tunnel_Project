Imports System.ComponentModel

Namespace Interfaces
    Public Interface IConfigurationFile
        Inherits INotifyPropertyChanged, ICanCheckValidity
        Property LastUpdated As Date
        ReadOnly Property IsInitialized As Boolean
    End Interface
    Public Interface IConfigurationFile(Of T)
        Inherits IConfigurationFile
        Function Clone() As T
    End Interface
End Namespace