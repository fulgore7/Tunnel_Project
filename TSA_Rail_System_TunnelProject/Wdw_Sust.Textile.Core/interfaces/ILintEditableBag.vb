Imports Wdw_Sust.Core.Enums

Namespace Interfaces
    ''' <summary>
    ''' This interface is used across all 3 plants 
    ''' to tell if the bag (CtrlOPCBag or CtrlOPCBagAddButton) is editable
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface ILintEditableBag
        Property BagMode As FormMode
    End Interface

End Namespace