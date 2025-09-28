Imports Wdw_Sust.OpcDa.Core.Interfaces

Namespace Ab

    Public NotInheritable Class RslinxOpcDaSettings
        Public Shared ReadOnly TagGenerator As IOpcTagGenerator = New RslinxOpcTagGenerator

        Public Shared Function ServerName() As String
            If OpcComm.UseRemoteGateway Then
                Return "RSLinx REMOTE OPC Server"
            Else
                Return "RSLinx OPC Server"
            End If
        End Function

        'Friend Shared ReadOnly ServerName As String = "RSLinx Remote OPC Server"
        'Friend Shared ReadOnly TagGenerator As IOPCTagGenerator = New SoftingOPCTagGenerator
        'Friend Shared ReadOnly ServerName As String = "Softing.OPC.DF.Configuration2.DA"
    End Class

End Namespace