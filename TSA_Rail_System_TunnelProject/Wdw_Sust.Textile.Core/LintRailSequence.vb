Imports System.Data.SqlClient


Public Class LintRailSequence
    Inherits List(Of LintRailSequenceStep)

#Region "Properties"
    Public Property RailSequenceName() As String
#End Region

#Region "Methods"
    Public Function GetSequenceStepDescription(ByVal stepNumber As Integer) As String
        For Each sequenceStep As LINTRailSequenceStep In Me
            If sequenceStep.StepNumber = stepNumber Then Return sequenceStep.Description
        Next
        Return String.Format("Step {0} - Step is undefined!!", stepNumber)
    End Function
    Public Function IsStepReadOnly(ByVal stepNumber As Integer) As Boolean
        If Exists(Function(a) a.StepNumber = stepNumber) Then
            Return Find(Function(a) a.StepNumber).IsReadOnly
        End If
        Return False
    End Function
#End Region

#Region "Contructors"
    Public Sub New(ByVal reader As SqlDataReader)
        While reader.Read
            RailSequenceName = CStr(reader("Sequence_Description"))
            Add(New LINTRailSequenceStep(reader))
        End While
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal capacity As Integer)
        MyBase.New(capacity)
    End Sub
    Public Sub New(ByVal collection As IEnumerable(Of LINTRailSequenceStep))
        MyBase.New(collection)
    End Sub
#End Region

End Class


