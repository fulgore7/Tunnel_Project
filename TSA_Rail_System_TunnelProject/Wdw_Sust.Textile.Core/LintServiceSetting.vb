Imports System.Data
Imports Wdw_Sust.Core.Configurations.Core
Imports Wdw_Sust.Core.Helpers

<Serializable>
Public Class LintServiceSetting
    Public Property ServiceID As LintServiceType
    Public Property ServiceDescription As String
    Public Property BaseAddress As String
    Public Property PortNumber As Integer

    Public Sub New(ByVal reader As IDataReader)
        ServiceID = reader("Service_ID")
        ServiceDescription = FixNull(Of String)(reader("Service_Description"))
        BaseAddress = FixNull(Of String)(reader("Service_Base_Address"))
        PortNumber = FixNull(Of Integer)(reader("Service_Port_Number"))
    End Sub

    Public Sub New()

    End Sub
End Class

Public Class LintServiceSettingConfigFile
    Inherits ConfigurationFileBase
    Public Property LintServiceSettings As IEnumerable(Of LintServiceSetting)

End Class