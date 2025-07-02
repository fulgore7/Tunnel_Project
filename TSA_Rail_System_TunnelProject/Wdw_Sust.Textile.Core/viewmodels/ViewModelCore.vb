Namespace ViewModels
    ' This view model supports unit testing for CtrlOpcBagEdit
    Public Class ViewModelCore

#Region "ctor"
        ' Indicates if the soiled weight should be validated.
        Private _wasSoiledWeightChanged As Boolean
        Public Property WasSoiledWeightChanged() As Boolean
            Get
                Return _wasSoiledWeightChanged
            End Get
            Set(ByVal value As Boolean)
                _wasSoiledWeightChanged = value
            End Set
        End Property

        Public Property Plant() As Plant
#End Region

        Public Sub New(_laundry As Plant)
            SetLaundry(_laundry)
        End Sub

        Public Sub SetLaundry(_laundry As Plant)
            ' Plant.UNKNOWN is the used as a generic default value.
            Plant = _laundry
        End Sub

        ' Initialize the view model
        Public Sub Init()
            WasSoiledWeightChanged = False
        End Sub

        Public Function IsCategoryValid(categoryValue As Integer) As Boolean

            ' Verify that the category has been set and is NOT 88
            If categoryValue = 0 OrElse categoryValue = 88 Then Return False

            Return True

        End Function

        Function IsBagWeightValid(bagWeightValue As String) As Boolean

            ' Exit early if bag weight was not updated
            If Not _wasSoiledWeightChanged Then Return True

            ' Reset flag
            _wasSoiledWeightChanged = False

            ' Verify that a numeric value has been entered, and that that numeric value is 300 lbs or less.
            If Not IsNumeric(bagWeightValue) Then Return False

            ' Verify that the numeric value is greater than zero AND less than the max bag weight.
            Dim bagWeight = CDbl(bagWeightValue)
            Dim maxBagWeight = GetBagMaxWeightByLaundry()
            If bagWeight <= 1 Or bagWeight > maxBagWeight Then Return False

            Return True

        End Function

        Function GetBagMaxWeightByLaundry() As Double
            Dim maxBagWeight As Double = 300    ' original default value

            If Plant = Plant.NSA Then
                maxBagWeight = 180
            End If

            Return maxBagWeight
        End Function

        Public Function IsUpdateBagDetailValid(categoryValue As Integer, bagWeightValue As String, Optional maxBagWeight As Double = 300) As Boolean
            ' Validate the category selection
            If Not IsCategoryValid(categoryValue) Then Return False

            ' Validate the bag weight entry
            If Not IsBagWeightValid(bagWeightValue) Then Return False

            Return True
        End Function

        Public Function IsAddBagDetailValid(categoryValue As Integer) As Boolean
            ' Validate the category selection
            If Not IsCategoryValid(categoryValue) Then Return False

            Return True
        End Function

        Public Function IsDeleteBagDetailValid(categoryValue As Integer) As Boolean
            ' Validate the category selection
            If Not IsCategoryValid(categoryValue) Then Return False

            Return True
        End Function

    End Class
End Namespace