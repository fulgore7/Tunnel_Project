Public Class CtrlLintCategoryIdChooser
    Private _value As Integer
    Public Sub New(ByVal listOfUnusedCategories As List(Of Integer))
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.ComboBox1.DataSource = listOfUnusedCategories
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me._value = Me.ComboBox1.SelectedItem
        Me.Close()
    End Sub
    Public ReadOnly Property Value() As Integer
        Get
            Return _value
        End Get
    End Property
End Class