Imports Wdw_Sust.Textile.Tsa.Workflow
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Communications
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Tsa.Workflow.EventArgs

Public Class WorkflowClient
    Private WithEvents _client As New OutgoingConnection

    Public Event ConnectStatusChanged As EventHandler
    Public Event ConnectException As EventHandler
    Public Event WorkflowCalculationStarted As EventHandler
    Public Event WorkflowCalculationCompleted As EventHandler
    Public Event WorkflowNextCalculationTimeUpdate As EventHandler(Of WorkflowEventArgs(Of Date))
    Public Event WorkflowLastCalculationHistory As EventHandler(Of WorkflowEventArgs(Of TsaWorkflowEngine))

    Public ReadOnly Property IsConnected As Boolean
        Get
            Return _client.IsConnected
        End Get
    End Property

    Public Function StartWorkflowService(ByVal setting As LintServiceSetting) As Boolean
        Return _client.Connect(setting.BaseAddress, setting.PortNumber)
    End Function

    Public Sub StopWorkflowService()
        Disconnect()
    End Sub

    Private Sub Connect(ByVal hostName As String, ByVal portNumber As Integer)
        If Not IsConnected Then _client.Connect(hostName, portNumber)
    End Sub

    Private Sub Disconnect()
        If IsConnected Then _client.Disconnect()
    End Sub

    Private Sub _client_ConnectException(sender As Object, e As System.EventArgs) Handles _client.ConnectException
        RaiseEvent ConnectException(Me, e)
    End Sub

    Private Sub _client_ConnectStatusChanged(sender As Object, e As System.EventArgs) Handles _client.ConnectStatusChanged
        RaiseEvent ConnectStatusChanged(Me, System.EventArgs.Empty)
    End Sub

    Private Sub _client_MessageReceived(message As INetworkMessage) Handles _client.MessageReceived
        Select Case CType(message.MessageHeader.MessageType, WorkflowMessageType)
            Case WorkflowMessageType.CalculationStatus
                ' InvokeIfNeeded(Sub() tssLastAction.Text = message.MessageContent)
            Case WorkflowMessageType.CalculationStarted
                RaiseEvent WorkflowCalculationStarted(Me, System.EventArgs.Empty)
            Case WorkflowMessageType.CalculationCompleted
                RaiseEvent WorkflowCalculationCompleted(Me, System.EventArgs.Empty)
            Case WorkflowMessageType.GetLastWorkflowCalculation
                RaiseEvent WorkflowLastCalculationHistory(Me, New WorkflowEventArgs(Of TsaWorkflowEngine) With {.ReturnedParameter = message.MessageContent})
            Case WorkflowMessageType.GetNextUpdate
                RaiseEvent WorkflowNextCalculationTimeUpdate(Me, New WorkflowEventArgs(Of Date) With {.ReturnedParameter = message.MessageContent})
            Case Else
                WriteLog(String.Format("Message type {0} is not supported!", CType(message.MessageHeader.MessageType, WorkflowMessageType)), My.Application.Info.ProductName)
        End Select
    End Sub

    Public Sub RunRemoteWorkflowCalculation()
        TryAction(Sub() SendNetworkAsyncMessage(WorkflowMessageType.RunWorkflowCalculation, NetworkMessage.EmptyContent), writeLogIfError:=True)
    End Sub

    'Public Function GetNextWorkflowCalculationTime() As DateTime
    '    Dim msg As INetworkMessage
    '    If TryAction(Sub() msg = SendNetworkSyncMessage(WorkflowMessageType.GetNextUpdate, NetworkMessage.EmptyContent), writeLogIfError:=True) Then
    '        Return CDate(msg.MessageContent)
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    Public Function GetLastWorkflowCalculation() As Boolean
        Return TryAction(Sub() SendNetworkAsyncMessage(WorkflowMessageType.GetLastWorkflowCalculation, NetworkMessage.EmptyContent), writeLogIfError:=True)
    End Function

    'Public Function GetCallOffData(ByVal washerNumber As Integer) As List(Of TSACallOffData)
    '    Dim msg As INetworkMessage = Nothing
    '    If TryAction(Sub()
    '                     msg = SendNetworkSyncMessage(WorkflowMessageType.GetCallOffData, washerNumber)
    '                 End Sub, writeLogIfError:=True) Then
    '        Return CType(msg.MessageContent, List(Of TSACallOffData))
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    Private Sub SendNetworkAsyncMessage(ByVal messageType As WorkflowMessageType, ByVal messageContent As Object)
        If Not IsConnected Then Exit Sub
        Dim msg As New NetworkMessage(CInt(messageType), messageContent)
        TryAction(Sub() _client.SendMessage(msg), writeLogIfError:=True)
    End Sub

    Private Function SendNetworkSyncMessage(ByVal messageType As WorkflowMessageType, ByVal messageContent As Object) As INetworkMessage
        If Not IsConnected Then Return Nothing
        Dim msg As New NetworkMessage(CInt(messageType), messageContent)
        Return _client.SendSyncMessage(Of INetworkMessage)(msg)
    End Function

    'Public Function GetNextWorkflowCalculationTime() As DateTime
    '    Dim msg As INetworkMessage = SendNetworkSyncMessage(WorkflowMessageType.GetNextUpdate, NetworkMessage.EmptyContent)
    '    If msg Is Nothing Then Return Nothing
    '    Return CDate(msg.MessageContent)
    'End Function

End Class