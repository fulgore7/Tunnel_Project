Namespace Interfaces
    Public Interface IWcfClientBase(Of ContractType As Class)
        Inherits IWcfConnection
        ReadOnly Property Service() As ContractType
        Function SafeExecuteContract(Of T)(ByVal action As Func(Of T)) As T
    End Interface
End Namespace


