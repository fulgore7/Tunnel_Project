Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    Public Interface IWcfDuplexServiceHost(Of CallBackType)
        Inherits IWcfServiceHost, IJoinableService
        ReadOnly Property CallbackInstances As List(Of CallBackType)

        Sub CheckClientState()
    End Interface
End Namespace