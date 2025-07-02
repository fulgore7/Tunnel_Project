

Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.OpcDa.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Dal
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Imports Wdw_Sust.Textile.Tsa.Dal

Public Class frmCleanExpressProduct
    Inherits CtrlLintOpcFormBase

#Region "Fields"
    Private WithEvents _expressProduct As New OpcElement(CONFIGURATION.PlcTopics.TsaCleanworkPlc, "Fast_Category")
    Private _oldExpressProduct As Integer = -1
#End Region

#Region "Events"
    Public Event _OnChangingExpressProduct(ByVal sender As Object, ByVal e As IRailAccessRightEventArgs)
    Public Event _OnChangedExpressProduct(ByVal sender As Object, ByVal e As LintOperatorEventArgs)
#End Region

#Region "Methods"
    Protected Overrides Function OnCreateFactoryObject() As ILintFactoryProvider
        Return TsaFactoryProvider.Instance
    End Function

    Private Sub _expressProduct_PropertiesUpdateCompleted(ByVal sender As IOpcObject, ByVal e As System.EventArgs) Handles _expressProduct.PropertiesUpdateCompleted
        If _oldExpressProduct = -1 Then
            _oldExpressProduct = CInt(_expressProduct.Value)
            ComboBox1.Enabled = True
        End If
        ComboBox1.SelectedValue = CInt(_expressProduct.Value)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If _oldExpressProduct <> ComboBox1.SelectedValue Then
            UpdateExpressProductCode()
            Close()
        Else
            MsgBox("No change is found!!")
        End If
    End Sub

    Protected Overrides Sub Initialize()
        InvokeIfNeeded(Sub() LINTCategoryDetailBindingSource.DataSource = Factory.Rail.GetCategoryDescriptionDetails)
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub InitializeOpcObjects()
        AddOpcObject(_expressProduct)
    End Sub

    Private Sub UpdateExpressProductCode()
        Dim args As New LintRailAccessRightEventArgs(RailAccessOptions.EDIT_BAGS, hasRight:=Not LintSecurityProvider.ENABLE_SECURITY)
        RaiseEvent _OnChangingExpressProduct(Me, args)
        If args.CancelAction Then Exit Sub
        If args.HasRight Then
            _expressProduct.ValueFromObjectToPlc(String.Empty, ComboBox1.SelectedValue)
            RaiseEvent _OnChangedExpressProduct(Me, New LintOperatorEventArgs(Now, args.EmployeeId, My.Computer.Name, LintAction.EXPRESS_PRODUCT_CHANGE, String.Format("Cleanwork express product changed from {0} to {1}", _oldExpressProduct, ComboBox1.SelectedValue)))
        Else
            MsgBox(args.Message)
        End If
    End Sub

#End Region

#Region "Constructors"
#End Region

End Class