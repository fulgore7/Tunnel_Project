Imports Wdw_Sust.OpcDa.Core.Interfaces

Namespace EventArgs

    Public Class OpocGlobalDataChangeEventArgs
        Inherits System.EventArgs
        Private _groupName As String
        Private _opcCommType As OPC_COMM_TYPE

        Public Sub New(groupName As String, listOfOPCItems As List(Of IOpcObject))
            Me._groupName = groupName

        End Sub

        Public ReadOnly Property GroupName() As String
            Get
                Return _groupName
            End Get
        End Property

        Public ReadOnly Property OpcCommType() As OPC_COMM_TYPE
            Get
                Return _opcCommType
            End Get
        End Property

    End Class

End Namespace