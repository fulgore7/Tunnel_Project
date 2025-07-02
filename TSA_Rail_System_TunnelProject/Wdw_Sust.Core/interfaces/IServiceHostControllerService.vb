Imports System.ServiceModel

Imports Wdw_Sust.Core.Enums

Namespace Interfaces
    <ServiceContract()>
    Public Interface IServiceHostControllerService
        Sub AddServiceHost(ByVal serviceHost As IServiceHost)
        Sub RemoveServiceHost(ByVal serviceName As String, Optional ByVal shouldThrow As Boolean = False)
        <OperationContract()>
        Sub StartServiceHosts()
        <OperationContract()>
        Sub StopServiceHosts()
        <OperationContract()>
        Sub PauseServiceHosts()
        <OperationContract()>
        Sub RestartServiceHosts()
        <OperationContract()>
        Sub ContinueServiceHosts()
        <OperationContract()>
        Function GetServiceNames() As List(Of String)
        <OperationContract()>
        Function ServiceHostStatus(ByVal serviceName As String) As ServiceStatus
        <OperationContract()>
        Function StartServiceHost(ByVal serviceName As String) As Boolean
        <OperationContract()>
        Function StopServiceHost(ByVal serviceName As String) As Boolean
    End Interface
End Namespace
