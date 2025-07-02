Imports System.ComponentModel

Namespace Interfaces
    Public Interface IEditableConfigurationManager(Of T As IConfigurationFile)
        Inherits IConfigurationManager(Of T), IEditableObject
    End Interface
End Namespace

