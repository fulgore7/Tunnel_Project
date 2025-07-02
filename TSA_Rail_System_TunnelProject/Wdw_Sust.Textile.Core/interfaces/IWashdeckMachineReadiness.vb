Namespace Interfaces
    Public Interface IWashdeckMachineReadiness
        ReadOnly Property AvailableDryerQuantity As Integer
        Property Dryers(index As Integer) As LavatecDryer
        Property Machine_Running As Boolean
    End Interface
End Namespace


