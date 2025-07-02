Imports System.ServiceModel

Imports Wdw_Sust.Core.Cache
Imports Wdw_Sust.Core.Interfaces

Namespace Communications
    Public MustInherit Class WcfNetTcpConnectionBase
        Inherits DataBaseCacheManager
        Implements IWcfNetTcpConnection, ICanUpdate

        Public MustOverride ReadOnly Property ServiceName As String Implements IHaveServiceName.ServiceName
        Public Overridable Property BaseAddress As String Implements IWcfNetTcpConnection.BaseAddress
        Public Property PortNumber As Integer Implements IWcfNetTcpConnection.PortNumber
        Public Property BindingType As WcfBindingType
        Public Property LastUpdateTime As Date Implements ICanUpdate.LastUpdateTime

        ''' <summary>
        ''' By default SecurityMode is not enabled due to not taking local ID
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected Overridable Function CreateBinding() As System.ServiceModel.Channels.Binding
            Select Case BindingType
                Case WcfBindingType.Tcp
                    Return New NetTcpBinding(SecurityMode.None)
                Case Else
                    Throw New NotSupportedException("Binding Type Not Supported!")
            End Select
        End Function

        Public Function IsEndPointInfoValid() As Boolean
            Return Not String.IsNullOrEmpty(BaseAddress) AndAlso PortNumber > 0
        End Function

        Public Sub New(ByVal bindingType As WcfBindingType)
            Me.BindingType = bindingType
        End Sub
    End Class


End Namespace