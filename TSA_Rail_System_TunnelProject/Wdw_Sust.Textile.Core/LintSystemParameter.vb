Imports System.Data
Imports Wdw_Sust.Core.Helpers
<Serializable()>
Public NotInheritable Class LintSystemParameter
    Inherits LintKeyValuePair(Of LintSystemParameterId, Object)

#Region "Properties"
    Public Property Plant As Plant
#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("{0}: {1}", Key.ToString, Value)
    End Function
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        Key = FixNull(Of LintSystemParameterId)(reader("Parameter_ID"))
        Value = FixNull(Of Object)(reader("Parameter_Value"))
        Me.Plant = FixNull(Of Plant)(reader("Plant_ID"))
    End Sub
    Public Sub New(ByVal systemParameterID As LintSystemParameterId, ByVal parameterValue As Object, ByVal plant As Plant)
        Key = systemParameterID
        Value = parameterValue
        Me.Plant = plant
    End Sub
    Public Sub New()

    End Sub
#End Region

End Class