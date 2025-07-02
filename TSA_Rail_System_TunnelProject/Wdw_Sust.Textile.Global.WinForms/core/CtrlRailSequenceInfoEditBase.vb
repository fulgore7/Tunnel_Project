Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Global.WinForms.Extensions

Namespace Wdw_Sust.Textile.Global.WinForms.Core
    Public Class CtrlRailSequenceInfoEditBase
        Inherits CtrlFormBase

#Region "Fields"
        Private _plant As Plant = Plant.ALL_PLANTS
#End Region

#Region "Methods"
        Protected Overrides Sub Initialize()
            MyBase.Initialize()
            ComboBox1.LoadDataSource(Factory.Rail.GetRailSequenceNames())
            ListBox1.DisplayMember = "Description"
            ListBox1.ValueMember = "StepNumber"
        End Sub


        Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
            If ComboBox1.SelectedIndex <> -1 Then
                'ListBox1.DataSource = FACTORY.Rail(Plant.TSA).GetRailSequenceSteps(CType(ComboBox1.SelectedValue, LINTKeyValuePair(Of Integer, String)).Key)
                ListBox1.DataSource = Factory.Rail.GetRailSequenceSteps(CType(ComboBox1.SelectedItem, LintKeyValuePair(Of Integer, String)).Key)
            End If
        End Sub

        Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
            If ListBox1.SelectedIndex <> -1 Then
                LINTRailSequenceStepBindingSource.DataSource = Factory.Rail.GetRailSequenceStep(CType(ComboBox1.SelectedItem, LintKeyValuePair(Of Integer, String)).Key, CType(ListBox1.SelectedItem, LintRailSequenceStep).StepNumber)
            End If
        End Sub

        Private Sub LINTRailSequenceStepBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles LINTRailSequenceStepBindingSource.ListChanged
            If e.ListChangedType = System.ComponentModel.ListChangedType.ItemChanged Then
                CType(sender, ICanBeDirty).IsDirty = True
            End If
        End Sub
#End Region

    End Class
End Namespace


