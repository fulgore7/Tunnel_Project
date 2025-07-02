Imports System.ComponentModel

Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Db
Imports Wdw_Sust.Core.Interfaces

Namespace Configurations
    <Serializable>
    Public Class DbConfigFile
        Inherits ConfigurationFileBase(Of DbConfigFile)
        Implements IEncryptedConfigurationFile

        Private WithEvents _connectionStrings As BindingList(Of SqlDbConnectionBuilder)

        Public Property Key As String Implements IEncryptedConfigurationFile.Key

        Public ReadOnly Property ConnectionStrings As BindingList(Of SqlDbConnectionBuilder)
            Get
                Return _connectionStrings
            End Get
        End Property

        Public Property LintInUseConnectionString As SqlDbConnectionBuilder

        Public Property GusInUseConnectionString As SqlDbConnectionBuilder

        Public Sub New()
            _connectionStrings = New BindingList(Of SqlDbConnectionBuilder)
        End Sub

        Private Sub _connectionStrings_ListChanged(sender As Object, e As ListChangedEventArgs) Handles _connectionStrings.ListChanged
        End Sub
    End Class
End Namespace
