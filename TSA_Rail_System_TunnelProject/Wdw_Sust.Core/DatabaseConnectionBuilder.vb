Imports System.Data.SqlClient
Imports System.ComponentModel

Imports Wdw_Sust.Core.Encryption

<Serializable()>
Public Class ConnectionStringBuilder
    Private _connectionBuilder As SqlConnectionStringBuilder
    Private _encryption As EncryptionProvider

    Public Sub New(ByVal connectionString As String, Optional ByVal isEncrypted As Boolean = False)
        If isEncrypted Then
            connectionString = Encryptor.DecryptData(connectionString)
        End If
        _connectionBuilder = New SqlConnectionStringBuilder(connectionString)
    End Sub

    Protected ReadOnly Property Encryptor As EncryptionProvider
        Get
            If _encryption Is Nothing Then _encryption = New EncryptionProvider()
            Return _encryption
        End Get
    End Property

    Public ReadOnly Property EncryptedConnectionString As String
        Get
            Return _encryption.EncryptData(ConnectionBuilder.ConnectionString)
        End Get
    End Property
    Public Sub New(ByVal connectionBuilder As SqlConnectionStringBuilder)
        _connectionBuilder = connectionBuilder
    End Sub

    Protected ReadOnly Property ConnectionBuilder As SqlConnectionStringBuilder
        Get
            Return _connectionBuilder
        End Get
    End Property

    <Bindable(True, BindingDirection.TwoWay)>
    Public Property DatabaseName As String
        Get
            Return _connectionBuilder.InitialCatalog
        End Get
        Set(value As String)
            _connectionBuilder.InitialCatalog = value
        End Set
    End Property

    <Bindable(True, BindingDirection.TwoWay)>
    Public Property ServerName As String
        Get
            Return _connectionBuilder.DataSource
        End Get
        Set(ByVal value As String)
            _connectionBuilder.DataSource = value
        End Set
    End Property

    <Bindable(True, BindingDirection.TwoWay)>
    Public Property UserName As String
        Get
            Return _connectionBuilder.UserID
        End Get
        Set(ByVal value As String)
            _connectionBuilder.UserID = value
        End Set
    End Property

    <Bindable(True, BindingDirection.TwoWay)>
    Public Property Password As String
        Get
            Return _connectionBuilder.Password
        End Get
        Set(ByVal value As String)
            _connectionBuilder.Password = value
        End Set
    End Property

    Public ReadOnly Property ConnectionString As String
        Get
            Return _connectionBuilder.ConnectionString
        End Get
    End Property



End Class




