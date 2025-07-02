Imports Wdw_Sust.Textile.Global.WinForms.Interfaces

Namespace Wdw_Sust.Textile.Global.WinForms.Core
    ''' <summary>
    ''' This is to control which controls will be available for the user to edit per
    ''' the program type.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Textile.Global.WinForms.Interfaces.ICtrlLintAdminConsoleViewModel" />
    Public MustInherit Class CtrlLintAdminConsoleViewModelBase
        Implements ICtrlLintAdminConsoleViewModel
        ''' <summary>
        ''' Gets a value indicating whether bag graphics is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use bag graphics]; otherwise, <c>false</c>.</value>
        Public MustOverride ReadOnly Property UseBagGraphics As Boolean Implements ICtrlLintAdminConsoleViewModel.UseBagGraphics
        ''' <summary>
        ''' Gets a value indicating whether chat service is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use chat service]; otherwise, <c>false</c>.</value>
        Public MustOverride ReadOnly Property UseChatService As Boolean Implements ICtrlLintAdminConsoleViewModel.UseChatService
        ''' <summary>
        ''' Gets a value indicating whether database is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use database]; otherwise, <c>false</c>.</value>
        Public MustOverride ReadOnly Property UseDatabase As Boolean Implements ICtrlLintAdminConsoleViewModel.UseDatabase
        ''' <summary>
        ''' Gets a value indicating whether Opc is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use opc]; otherwise, <c>false</c>.</value>
        Public MustOverride ReadOnly Property UseOpc As Boolean Implements ICtrlLintAdminConsoleViewModel.UseOpc
        ''' <summary>
        ''' Gets a value indicating whether Rfid reader is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use rfid reader]; otherwise, <c>false</c>.</value>
        Public MustOverride ReadOnly Property UseRfidReader As Boolean Implements ICtrlLintAdminConsoleViewModel.UseRfidReader

        ''' <summary>
        ''' Gets a value indicating whether the work station name is used for the program. This is used for logging
        ''' purposes, for example.
        ''' </summary>
        ''' <value><c>true</c> if [use work station name]; otherwise, <c>false</c>.</value>
        Public ReadOnly Property UseWorkStationName As Boolean Implements ICtrlLintAdminConsoleViewModel.UseWorkStationName
            Get
                Return True
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether Lint application identifier is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use lint application identifier]; otherwise, <c>false</c>.</value>
        Public ReadOnly Property UseLintAppId As Boolean Implements ICtrlLintAdminConsoleViewModel.UseLintAppId
            Get
                Return True
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether program mode is used for the program.
        ''' </summary>
        ''' <value><c>true</c> if [use program mode]; otherwise, <c>false</c>.</value>
        Public Overridable ReadOnly Property UseProgramMode As Boolean Implements ICtrlLintAdminConsoleViewModel.UseProgramMode
            Get
                Return True
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether the program can be monitored by the application monitoring system.
        ''' </summary>
        ''' <value><c>true</c> if this instance can monitor application status; otherwise, <c>false</c>.</value>
        Public ReadOnly Property CanMonitorAppStatus As Boolean Implements ICtrlLintAdminConsoleViewModel.CanMonitorAppStatus
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
