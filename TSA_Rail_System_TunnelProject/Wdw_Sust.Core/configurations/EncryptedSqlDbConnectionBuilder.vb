Imports Wdw_Sust.Core.Encryption

Namespace Db
    <Serializable()>
    Public Class EncryptedSqlDbConnectionBuilder
        Inherits SqlDbConnectionBuilder
        Private ReadOnly _encryptor As EncryptionProvider
        Private ReadOnly Property Encryptor() As EncryptionProvider
            Get
                Return _encryptor
            End Get
        End Property
        Public ReadOnly Property EncryptedConnectionString As String
            Get
                Return Encryptor.EncryptData(ConnectionString)
            End Get
        End Property
        Public Sub New(connectionString As String, encryptor As EncryptionProvider, isEncrypted As Boolean)
            If encryptor Is Nothing Then Throw New ArgumentException("encryptor")
            _encryptor = encryptor
            If isEncrypted Then
                connectionString = encryptor.DecryptData(connectionString)
            End If
            CreateInternalConnectionBuilder(connectionString)
        End Sub
        Public Sub New(serverName As String, databaseName As String, userName As String, plainPassword As String, encryptor As EncryptionProvider)
            MyBase.New(serverName, databaseName, userName, plainPassword)
            If encryptor Is Nothing Then Throw New ArgumentException("encryptor")
            _encryptor = encryptor
        End Sub
    End Class
End Namespace