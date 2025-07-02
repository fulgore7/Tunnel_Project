

Namespace Interfaces
    ''' <summary>
    ''' This is used to provide if the object state is valid before commiting to database or other 
    ''' use that requires to check the object status.
    ''' Check out <see cref="Wdw_Sust.Core.Validation.BusinessRuleManager"/> for more information.
    ''' <seealso cref="Wdw_Sust.Core.Validation.BusinessRuleManager"/>.
    ''' </summary>
    Public Interface ICanCheckValidity
        ReadOnly Property IsValid As Boolean
    End Interface
End Namespace
