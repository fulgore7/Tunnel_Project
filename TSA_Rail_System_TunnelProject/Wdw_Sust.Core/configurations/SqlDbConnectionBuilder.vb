Imports System.ComponentModel
Imports System.Data.SqlClient

Namespace Db

    <Serializable()>
    Public Class SqlDbConnectionBuilder
        Inherits NotifyableBase
        Public Property ConnectionName As String
        Private _connectionBuilder As SqlConnectionStringBuilder
        Public Sub New(serverName As String, databaseName As String, userName As String, plainPassword As String)
            _connectionBuilder = New SqlConnectionStringBuilder() With
                                 {
                                     .InitialCatalog = databaseName,
                                     .DataSource = serverName,
                                     .UserID = userName,
                                     .Password = plainPassword,
                                     .Pooling = False
                                 }
        End Sub

        Protected Sub CreateInternalConnectionBuilder(Optional ByVal cs As String = "")
            _connectionBuilder = New SqlConnectionStringBuilder(cs)
            _connectionBuilder.IntegratedSecurity = False
            _connectionBuilder.Pooling = False
        End Sub

        Public Sub New()
            CreateInternalConnectionBuilder()
        End Sub

        Public Sub New(ByVal connectionString As String)
            Me.New(String.Empty, connectionString)
        End Sub

        Public Sub New(ByVal connectionName As String, ByVal connectionString As String)
            Me.ConnectionName = connectionName
            CreateInternalConnectionBuilder(connectionString)
        End Sub

        <Bindable(True, BindingDirection.TwoWay)>
        Public Property IntegratedSecurity As Boolean
            Get
                Return _connectionBuilder.IntegratedSecurity
            End Get
            Set(value As Boolean)
                _connectionBuilder.IntegratedSecurity = value
            End Set
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

        <Bindable(True, BindingDirection.TwoWay)>
        Public Property Encrypt As Boolean
            Get
                Return _connectionBuilder.Encrypt
            End Get
            Set(ByVal value As Boolean)
                _connectionBuilder.Encrypt = value
            End Set
        End Property

        <Bindable(True, BindingDirection.TwoWay)>
        Public Property TrustServerCertificate As Boolean
            Get
                Return _connectionBuilder.TrustServerCertificate
            End Get
            Set(ByVal value As Boolean)
                _connectionBuilder.TrustServerCertificate = value
            End Set
        End Property

        Public ReadOnly Property ConnectionString As String
            Get
                Return _connectionBuilder.ConnectionString
            End Get
        End Property
    End Class
End Namespace