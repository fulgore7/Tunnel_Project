Namespace Interfaces
    ''' <summary>
    ''' This interface is used across all 3 plants and are the building
    ''' block for the OPC Bag Control. This should not be changed in normal
    ''' case and will affect all 3 facilities
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface ILintBagDetail

        Property Category_Code() As Integer
        Property Clean_Weight() As Decimal
        Property Data_Changed_Manually As Boolean
        Property Drop_Destination() As Integer
        Property PLC_Bag_ID() As Integer
        Property Soiled_Weight() As Decimal
        Property Sorting_Station() As Integer
        Property Storage_Destination() As Integer
        Property UsedAssignment As Integer

    End Interface
End Namespace
