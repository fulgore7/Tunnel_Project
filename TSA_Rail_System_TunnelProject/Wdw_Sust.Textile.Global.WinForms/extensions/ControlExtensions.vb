Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Wdw_Sust.Textile.Core

Namespace Extensions

    Public Module ComboBoxExtensions
        <Extension()>
        Sub LoadDataSource(Of T, V)(ByVal cmbBox As ComboBox, ByVal dataSource As ICollection(Of LintKeyValuePair(Of T, V)))
            cmbBox.DataSource = dataSource
            cmbBox.ValueMember = "Key"
            cmbBox.DisplayMember = "Value"
        End Sub
    End Module
End Namespace