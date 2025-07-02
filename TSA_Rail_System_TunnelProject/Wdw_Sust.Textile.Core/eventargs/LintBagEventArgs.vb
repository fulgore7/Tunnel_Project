Imports Wdw_Sust.Core.Enums

Namespace EventArgs
    Public Class LintBagEventArgs
        Inherits System.EventArgs

#Region "Fields"

        Private _zone As LintZone
        Private _rundownZone As LintRundownZone

#End Region

#Region "Properties"

        Public Property BagMode() As FormMode = FormMode.NORMAL

        ''' <summary>
        ''' This message will only be shown when the bag mode is set to read only!!
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Message() As String

        Public ReadOnly Property Zone() As LintZone
            Get
                Return _zone
            End Get
        End Property

        Public ReadOnly Property RundownZone() As LintRundownZone
            Get
                Return _rundownZone
            End Get
        End Property

#End Region

#Region "Constructors"

        Public Sub New(ByVal bagMode As FormMode, ByVal zone As LintZone, ByVal rundownZone As LintRundownZone)
            _BagMode = bagMode
            _zone = zone
            _rundownZone = rundownZone
        End Sub

#End Region

    End Class

End Namespace
