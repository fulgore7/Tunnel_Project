Imports System.Linq
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.OpcDa.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Enums

Public Class frmClassifiedStorage
    Inherits CtrlOpcTsaRailFormBase

    Private _capacity As New Dictionary(Of Integer, Integer)

#Region "Methods"
    Private Sub GetClassifiedStorageCategoryDistribution()
        Dim list As New List(Of LintCategoryCount)
        Dim dict As New Dictionary(Of Integer, Integer)
        Dim totalNumberOfBags As Integer
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is CtrlOpcBagBase Then
                Dim bag As CtrlOpcBagBase = CType(ctrl, CtrlOpcBagBase)
                If bag.Category > 0 AndAlso (bag.Zone = LintZone.CLASSIFIED_STORAGE) Then
                    If dict.ContainsKey(bag.Category) Then
                        dict(bag.Category) += 1
                    Else
                        dict.Add(bag.Category, 1)
                    End If
                End If
            End If
        Next
        totalNumberOfBags = dict.Sum(Function(a) a.Value)
        For Each pair As KeyValuePair(Of Integer, Integer) In dict
            list.Add(New LintCategoryCount(pair.Key, pair.Value, CDbl(pair.Value / totalNumberOfBags)))
        Next
        list.Sort()
    End Sub

    Private Sub LoadLineMaxCapacity()
        For i As Integer = 1 To 51
            Select Case i
                Case 1, 27 To 33 '22
                    _capacity.Add(i, 22)
                Case 2 To 15, 18 To 24 '23
                    _capacity.Add(i, 23)
                Case 16 '19
                    _capacity.Add(i, 19)
                Case 17 '21
                    _capacity.Add(i, 21)
                Case 34 '11
                    _capacity.Add(i, 11)
                Case 36 To 43, 45 To 51 '10
                    _capacity.Add(i, 10)
            End Select
        Next
    End Sub

    Private Sub LineLabel_MouseHover(sender As System.Object, e As System.EventArgs)
        If OpcComm.EnableOpcCommunication Then
            Dim lbl As CtrlOpcTsaRailBlockLabel = CType(sender, CtrlOpcTsaRailBlockLabel)
            Dim bag As CtrlOpcBagBase
            Dim count As Integer
            Dim max As Integer
            Dim lineNumber As Integer = lbl.RailNumber
            If lineNumber > 0 Then
                max = _capacity(lineNumber)
                Dim tag As String = IIf(lineNumber = 34, "StoreBuffer[{0},{1}]", "Store[{0},{1}]")
                For i As Integer = 1 To max
                    If lineNumber = 34 Then
                        bag = GetOpcObject(CONFIGURATION.PlcTopics.TsaClassifiedPlc, String.Format(tag, 12, i))
                    Else
                        bag = GetOpcObject(CONFIGURATION.PlcTopics.TsaClassifiedPlc, String.Format(tag, lineNumber, i))
                    End If
                    If bag.Category > 0 Then
                        count += 1
                    End If
                Next
                If count > 0 Then
                    ShowToolTip(lbl.Location, String.Format("{0} bags", count), 2000)
                End If
            End If
        End If
    End Sub

    Protected Overrides Sub Initialize()
        LoadLineMaxCapacity()
        AddJob("Test", TimeSpan.FromSeconds(10), AddressOf GetClassifiedStorageCategoryDistribution, False)
        If Not CONFIGURATION.IsFailOverMode() Then CType(ParentForm, frmMain).AlarmBroadcaster.Refresh(True)
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub ManageControlsEvent(ctrl As Control, handlerAction As HandlerAction)
        MyBase.ManageControlsEvent(ctrl, handlerAction)
        If TypeOf ctrl Is CtrlOpcTsaRailBlockLabel Then
            Select Case handlerAction
                Case HandlerAction.Add
                    AddHandler CType(ctrl, CtrlOpcTsaRailBlockLabel)._MouseHover, AddressOf LineLabel_MouseHover
                Case HandlerAction.Remove
                    RemoveHandler CType(ctrl, CtrlOpcTsaRailBlockLabel)._MouseHover, AddressOf LineLabel_MouseHover
            End Select
        End If
    End Sub

    Private Function GetBagCounts() As List(Of LintCategoryCount)
        Dim list As New List(Of LintCategoryCount)
        Dim dict As New Dictionary(Of Integer, Integer)
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is CtrlOpcBagBase Then
                Dim bag As CtrlOpcBagBase = CType(ctrl, CtrlOpcBagBase)
                If bag.Category > 0 Then
                    If dict.ContainsKey(bag.Category) Then
                        dict(bag.Category) += 1
                    Else
                        dict.Add(bag.Category, 1)
                    End If
                End If
            End If
        Next
        For Each pair As KeyValuePair(Of Integer, Integer) In dict
            list.Add(New LintCategoryCount(pair.Key, pair.Value))
        Next
        Return list
    End Function

    Protected Overrides Sub InitializeOpcCommunication()
        OpenOpcComm("TSA_Classified_Storage_Rail_Blocks", 1000)
        OpenOpcComm(3000)
    End Sub

#End Region

End Class