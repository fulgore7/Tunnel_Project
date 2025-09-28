Imports Wdw_Sust.OpcDa.Core.Interfaces

Namespace EventArgs

    Public Class OpcGroupDataChangeEventArgs
        Inherits System.EventArgs

        Private _listOfOPCObjects As List(Of IOpcObject)

        Public Sub New(listOfOPCObjects As List(Of IOpcObject))
            Me._listOfOPCObjects = listOfOPCObjects
        End Sub

        Public ReadOnly Property ListOfOpcObjects() As List(Of IOpcObject)
            Get
                Return _listOfOPCObjects
            End Get
        End Property

    End Class

End Namespace