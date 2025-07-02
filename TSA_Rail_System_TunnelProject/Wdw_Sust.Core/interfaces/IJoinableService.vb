Imports System.ServiceModel

Namespace Interfaces
    <ServiceContract(SessionMode:=SessionMode.Required, CallbackContract:=GetType(IJoinableCallBack))>
    Public Interface IJoinableService
        <OperationContract(IsOneWay:=True)>
        Sub Join(ByVal name As String)
        <OperationContract(IsOneWay:=False)>
        Function GetOtherParticipants() As List(Of String)
        <OperationContract(IsOneWay:=False)>
        Function GetParticipantCounts() As Integer
        <OperationContract(IsOneWay:=True)>
        Sub Leave(ByVal name As String)
        <OperationContract(IsOneWay:=True)>
        Sub Broadcast(ByVal message As String)
    End Interface
End Namespace