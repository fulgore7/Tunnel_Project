

Imports System.Runtime.CompilerServices

Namespace Extensions
    Public Module IntegerExtensions
        <Extension>
        Public Function IsWithin(ByVal numberTested As Integer, ByVal fromNumber As Integer, ByVal toNumber As Integer, Optional includeLowEdge As Boolean = True, Optional includeHighEdge As Boolean = True) As Boolean
            Dim lowSide As Integer = IIf(includeLowEdge, fromNumber - 1, fromNumber)
            Dim highSide As Integer = IIf(includeHighEdge, toNumber + 1, toNumber)
            Return numberTested > lowSide AndAlso numberTested < highSide
        End Function
        <Extension>
        Public Function IsNotEqual(ByVal numberTested As Integer, ByVal numberTestAgainst As Integer) As Boolean
            Return numberTested <> numberTestAgainst
        End Function
    End Module
End Namespace
