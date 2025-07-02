Imports System.Data
Imports Wdw_Sust.Core.Helpers
Public NotInheritable Class LintSystemParameterRole
    Inherits LintKeyValuePair(Of String, LintUserType)


    Public Sub New(ByVal reader As IDataReader)
        Key = FixNull(Of LintUserType)(reader("Parameter_ID"))
        Value = FixNull(Of Object)(reader("Parameter_Value"))
    End Sub

    Public Sub New(_key As String, _value As LintUserType)
        Key = _key
        Value = _value
    End Sub
End Class
