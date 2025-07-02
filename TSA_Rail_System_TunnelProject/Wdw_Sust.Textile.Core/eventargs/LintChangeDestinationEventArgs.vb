Namespace EventArgs
    Public Class LintChangeDestinationEventArgs
        Inherits System.EventArgs

#Region "Fields"
        Private _destination As Integer
        Private _destinationType As BagDestinationType
#End Region

#Region "Properties"

        Public ReadOnly Property Destination() As Integer
            Get
                Return _destination
            End Get
        End Property

        Public ReadOnly Property DestinationType() As BagDestinationType
            Get
                Return _destinationType
            End Get
        End Property
#End Region

#Region "Methods"

#End Region

#Region "Constructors"

        Public Sub New(ByVal destination As Integer, ByVal destinationType As BagDestinationType)
            _destination = destination
            _destinationType = destinationType
        End Sub

#End Region

    End Class

End Namespace
