Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization

Namespace Configurations
    Public Class EditableConfigurationManager(Of T As IConfigurationFile)
        Inherits ConfigurationManager(Of T)
        Implements IEditableConfigurationManager(Of T)

        Private _stateConfigObject As T

        Public Sub BeginEdit() Implements IEditableConfigurationManager(Of T).BeginEdit
            If _stateConfigObject Is Nothing Then
                _stateConfigObject = SerializationManager.DeserializeData(SerializationManager.SerializeData(ConfigFile))
            End If
        End Sub

        Public Sub EndEdit() Implements IEditableConfigurationManager(Of T).EndEdit
            If _stateConfigObject IsNot Nothing Then _stateConfigObject = Nothing
        End Sub

        Public Sub CancelEdit() Implements IEditableConfigurationManager(Of T).CancelEdit
            If _stateConfigObject IsNot Nothing Then
                ConfigFile = _stateConfigObject
                _stateConfigObject = Nothing
            End If
        End Sub
    End Class
End Namespace

