Namespace Interfaces
    Public Interface IWcfServiceHost
        Inherits IWcfConnection, IServiceHost

        ReadOnly Property ContractType() As Type
        ReadOnly Property ServiceType() As Type

    End Interface
End Namespace
