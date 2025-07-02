Imports Wdw_Sust.Core.Communications
Imports Wdw_Sust.Textile.Global.Wcf.Interfaces
Imports Wdw_Sust.Core.Enums

Public Class WcfSortingDisplayServiceClient
    Inherits WcfNetTcpClientBase(Of IWcfSortingDisplayService)

    Public Sub New(bindingType As WcfBindingType, baseAddress As String, portNumber As Integer)
        MyBase.New(bindingType, baseAddress, portNumber)
    End Sub

    Public Overrides ReadOnly Property ServiceName As String
        Get
            Return "WcfSortingDisplayService"
        End Get
    End Property
End Class
