﻿Imports System.IO
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization

Namespace Configurations
    ''' <summary>
    ''' Class EncryptedConfigurationManager. The file generated by this class will be encrypted. 
    ''' This is used when sensitive information is stored in the config file, such as the database connection
    ''' string.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <seealso cref="Wdw_Sust.Core.Configurations.ConfigurationManager(Of T)" />
    Public Class EncryptedConfigurationManager(Of T As IEncryptedConfigurationFile)
        Inherits ConfigurationManager(Of T)

        Protected Overrides Function OnCreateConfigFileObject() As T
            Return SerializationManager.DeserializeFromEncryptedXmlFileWithKey(Of T)(ConfigurationFilePath)
        End Function

        Public Overrides Function Save() As Boolean
            Try
                SerializationManager.SerializeToEncryptedXmlWithKey(Of T)(ConfigFile.Key, ConfigurationFilePath, ConfigFile, FileMode.Create)
                OnSavedConfigFileEvent(System.EventArgs.Empty)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Sub New(configurationDirectory As String, Optional ByVal configurationFileName As String = Nothing)
            MyBase.New(configurationDirectory, configurationFileName)
            If configurationFileName Is Nothing Then Me.ConfigurationFileName = String.Format("{0}.cfg", GetType(T).Name)
        End Sub

    End Class
End Namespace

