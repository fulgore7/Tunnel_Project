
Namespace Maths
    Public Class StandardDeviation
        Private Shared Function SafeDivide(ByVal nominator As Double, ByVal denominator As Double) As Double
            If denominator = 0 Then
                Return 0
            Else
                Return nominator / denominator
            End If
        End Function

        Private Shared Function Average(ByVal data As Double()) As Double
            Dim total As Double = 0
            For i As Integer = 0 To data.Length - 1
                total += data(i)
            Next
            Return SafeDivide(total, data.Length)
        End Function

        Public Shared Function CalculateStandardDeviation(ByVal data As Double()) As Double
            Dim averageOfData As Double = 0
            Dim totalVariance As Double = 0
            If data.Length = 0 Then Return 0
            averageOfData = Average(data)
            For i As Integer = 0 To data.Length - 1
                totalVariance += Math.Pow(data(i) - averageOfData, 2)
            Next
            Return Math.Sqrt(SafeDivide(totalVariance, data.Length))
        End Function
    End Class
End Namespace