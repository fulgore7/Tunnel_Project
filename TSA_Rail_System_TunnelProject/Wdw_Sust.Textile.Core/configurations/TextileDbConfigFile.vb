Imports Wdw_Sust.Core.Configurations

Namespace Configurations
    <Serializable>
    Public Class TextileDbConfigFile
        Inherits DbConfigFile
        Public ReadOnly Property ConnectionString(ByVal name As ConnectionStringName) As String
            Get
                Dim cs As String = ConnectionStrings.FirstOrDefault(Function(a) a.ConnectionName = name.ToString).ConnectionString
                If String.IsNullOrEmpty(cs) Then Return String.Empty
                Return cs
            End Get
        End Property

    End Class
End Namespace