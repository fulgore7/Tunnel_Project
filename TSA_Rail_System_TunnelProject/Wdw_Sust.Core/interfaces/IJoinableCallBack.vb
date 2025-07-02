
Imports System.ServiceModel

Namespace Interfaces
    <ServiceContract()>
    Public Interface IJoinableCallBack
        <OperationContract(IsOneWay:=False)>
        Function GetName() As String
        <OperationContract(IsOneWay:=True)>
        Sub SomeoneHasJoined(ByVal name As String)
        <OperationContract(IsOneWay:=True)>
        Sub SomeoneHasLeft(ByVal name As String)
        <OperationContract(IsOneWay:=True)>
        Sub MessageFromHost(ByVal message As String)
    End Interface
End Namespace