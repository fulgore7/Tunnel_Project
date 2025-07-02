Imports Wdw_Sust.Core.Configurations
Imports Wdw_Sust.Core.Db
Imports Wdw_Sust.Core.Encryption

Namespace Configurations
    Public Class TextileDbConfigManager
        Inherits SingletonEncryptedConfigurationManager(Of TextileDbConfigManager, TextileDbConfigFile)

        Public ReadOnly Property LintInUseConnectionString() As String
            Get
                If ConfigFile.LintInUseConnectionString Is Nothing Then Return String.Empty
                Return ConfigFile.LintInUseConnectionString.ConnectionString
            End Get
        End Property

        Public ReadOnly Property GusInUseConnectionString() As String
            Get
                If ConfigFile.GusInUseConnectionString Is Nothing Then Return String.Empty
                Return ConfigFile.GusInUseConnectionString.ConnectionString
            End Get
        End Property

        Public Sub ChangeInUseLintConnection(toConnection As ConnectionStringName)
            If IsLintConnection(toConnection) Then
                Dim con = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = toConnection.ToString)
                If con IsNot Nothing Then
                    ConfigFile.LintInUseConnectionString = con
                End If
            End If
        End Sub

        Public ReadOnly Property LintProductionConnectionString As String
            Get
                Dim cn = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.LintProductionConnection.ToString)
                If cn IsNot Nothing Then Return cn.ConnectionString
                Return String.Empty
            End Get
        End Property

        Public ReadOnly Property LintDevelopmentConnectionString As String
            Get
                Dim cn = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.LintDevelopmentConnection.ToString)
                If cn IsNot Nothing Then Return cn.ConnectionString
                Return String.Empty
            End Get
        End Property

        Public ReadOnly Property LintFailoverConnectionString As String
            Get
                Dim cn = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.LintFailOverConnection.ToString)
                If cn IsNot Nothing Then Return cn.ConnectionString
                Return String.Empty
            End Get
        End Property

        Public ReadOnly Property LintStagingConnectionString As String
            Get
                Dim cn = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.LintStagingConnection.ToString)
                If cn IsNot Nothing Then Return cn.ConnectionString
                Return String.Empty
            End Get
        End Property

        Public ReadOnly Property TextilesProd As String
            Get
                Dim cn = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.TextilesProd.ToString)
                If cn IsNot Nothing Then Return cn.ConnectionString
                Return String.Empty
            End Get
        End Property
        Public ReadOnly Property WdwLaundryAutomationProdConnectionString As String
            Get
                Dim cn = ConfigFile.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.WdwLaundryAutomationProd.ToString)
                If cn IsNot Nothing Then Return cn.ConnectionString
                Return String.Empty
            End Get
        End Property


        Public Shared Function IsLintConnection(connection As ConnectionStringName) As Boolean
            Return connection = ConnectionStringName.LintProductionConnection OrElse
                connection = ConnectionStringName.LintFailOverConnection OrElse
                connection = ConnectionStringName.LintDevelopmentConnection OrElse
                connection = ConnectionStringName.LintStagingConnection
        End Function

        Protected Overrides Function GetDefaultSettings() As TextileDbConfigFile
            Dim file As New TextileDbConfigFile
            file.Key = EncryptionProvider.GenerateRandomKey()
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.LintProductionConnection.ToString, "Data Source=WDWLintProd, 50433;Initial Catalog=LINT;Persist Security Info=True;User ID=LINT_software;Password=LINTaccess"))            
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.LintStagingConnection.ToString, "Data Source=fldcviswds8401.wdw.disney.com,50433, 50433;Initial Catalog=LINT;Persist Security Info=True;User ID=lint_qa;Password=QA$lint9801;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.LintDevelopmentConnection.ToString, "Data Source=WDWLintDev.wdw.disney.com,50433;Initial Catalog=LINT;Persist Security Info=True;User ID=LINT_software;Password=LINTaccess;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.LintFailOverConnection.ToString, "Data Source=10.91.4.21\W72UA4200HQB;Initial Catalog=LINT;Persist Security Info=True;User ID=sa;Password=TextileAdmin$3;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.GusProductionConnection.ToString, "Data Source=vpcwds7912agv01.wdw.disney.com,50533;Initial Catalog=jaq;User ID=gus_app;Password=Gu_$12$_@pP;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.GusFailOverConnection.ToString, "Data Source=10.91.4.21\w72ua4200hqb;Initial Catalog=JAQ;Persist Security Info=True;User ID=sa;Password=TextileAdmin$3;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.FloCockpitConnection.ToString, "Data Source=10.81.176.250;Initial Catalog=JEGR_DB;Persist Security Info=True;User ID=sa;Password=Jen&excellent;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.WdwLaundryAutomationProd.ToString, "Data Source=DSSQLAGL02.starwave.com,1433;Initial Catalog=wdw_laundry_automation;Persist Security Info=True;User ID=la_sa;Password=23jO@A9RFmuOrZNg;Encrypt=true;TrustServerCertificate=true;"))
            file.ConnectionStrings.Add(New SqlDbConnectionBuilder(ConnectionStringName.TextilesProd.ToString, "Data Source=vn0a0b501f.vra.dpc.pvt,1433;Initial Catalog=textiles;Persist Security Info=True;User ID=textiles_app;Password=8K7MWtMCHP8tvyMW;Encrypt=true;TrustServerCertificate=true;"))            
            file.LintInUseConnectionString = file.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.LintProductionConnection.ToString)
            file.GusInUseConnectionString = file.ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = ConnectionStringName.GusProductionConnection.ToString)
            Return file
        End Function
    End Class

End Namespace


