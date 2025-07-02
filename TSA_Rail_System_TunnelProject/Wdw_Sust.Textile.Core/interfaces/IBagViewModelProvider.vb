Imports System.Windows
Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.Textile.Core.Interfaces

Public Interface IBagViewModelProvider
    <NotConnectableOpcItem>
    Property Factory As ILintFactoryProvider

    <NotConnectableOpcItem>
    Property CategoryBackgroundColor As Integer

    <NotConnectableOpcItem>
    Property CategoryForegroundColor As Integer

    <NotConnectableOpcItem>
    Property IsVisible As Visibility

    <NotConnectableOpcItem>
    Property SecondaryNumberVisible As Visibility

    Function OnCreateFactoryObject() As ILintFactoryProvider

    Sub InitializeOpcItems()

    Sub GetBagDetails()
End Interface
