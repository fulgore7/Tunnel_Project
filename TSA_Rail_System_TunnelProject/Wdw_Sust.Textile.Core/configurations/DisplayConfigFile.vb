Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Textile.Core.Interfaces

Public Class DisplayConfigFile
    Inherits ApplicationConfigFile(Of DisplayConfigFile)
    Implements IDisplayConfigFile

    Private _defaultForm As FormType
    Private _childFormIsCentered As Boolean
    Private _showChildFormBorder As Boolean
    Private _mainFormIsFullScreen As Boolean
    Private _showMainFormBorder As Boolean
    Private _showToolBar As Boolean

    Public Property DefaultForm As FormType Implements IDisplayConfigFile.DefaultForm
        Get
            Return _defaultForm
        End Get
        Set(value As FormType)
            SetField(_defaultForm, value)
        End Set
    End Property

    Public Property ChildFormIsCentered As Boolean Implements IDisplayConfigFile.ChildFormIsCentered
        Get
            Return _childFormIsCentered
        End Get
        Set(value As Boolean)
            SetField(_childFormIsCentered, value)
        End Set
    End Property

    Public Property ShowChildFormBorder As Boolean Implements IDisplayConfigFile.ShowChildFormBorder
        Get
            Return _showChildFormBorder
        End Get
        Set(value As Boolean)
            SetField(_showChildFormBorder, value)
        End Set
    End Property

    Public Property MainFormIsFullScreen As Boolean Implements IDisplayConfigFile.MainFormIsFullScreen
        Get
            Return _mainFormIsFullScreen
        End Get
        Set(value As Boolean)
            SetField(_mainFormIsFullScreen, value)
        End Set
    End Property

    Public Property ShowToolBar As Boolean Implements IDisplayConfigFile.ShowToolBar
        Get
            Return _showToolBar
        End Get
        Set(value As Boolean)
            SetField(_showToolBar, value)
        End Set
    End Property

End Class
