Imports Wdw_Sust.Core.Enums

Namespace EventArgs
    ''' <summary>
    ''' To track the program mode should we need use the program mode feature
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Textile.Core.EventArgs.LintProgramEventArgs" />
    Public Class LintApplicationManagerEventArgs
        Inherits LintProgramEventArgs

#Region "Fields"
        Private _isWorkstationChanged As Boolean
        Private _isApplicationModeChanged As Boolean
        Private _isChatSevicesChanged As Boolean
        Private _isInUseLintConnectionChanged As Boolean
        Private _isEnableLoggingChanged As Boolean
        Private _isChatEnabled As Boolean
#End Region

#Region "Events"

#End Region

#Region "Properties"
        Public ReadOnly Property IsFailOverModeManual As Boolean
            Get
                Return CurrentApplicationMode = ProgramMode.FAIL_OVER_MANUAL
            End Get
        End Property

        Public ReadOnly Property IsFailOverModeAuto As Boolean
            Get
                Return PreviousApplicationMode = ProgramMode.FAIL_OVER_AUTO
            End Get
        End Property

        Public ReadOnly Property IsApplicationModeChanged As Boolean
            Get
                Return _isApplicationModeChanged
            End Get
        End Property

        Public ReadOnly Property IsChatSevicesChanged As Boolean
            Get
                Return _isChatSevicesChanged
            End Get
        End Property

        Public ReadOnly Property IsInUseLintConnectionChanged As Boolean
            Get
                Return _isInUseLintConnectionChanged
            End Get
        End Property

        Public ReadOnly Property IsEnableLoggingChanged As Boolean
            Get
                Return _isEnableLoggingChanged
            End Get
        End Property

        Public ReadOnly Property IsWorkstationChanged As Boolean
            Get
                Return _isWorkstationChanged
            End Get
        End Property

        Public ReadOnly Property IsChatEnabled As Boolean
            Get
                Return _isChatEnabled
            End Get
        End Property
#End Region

#Region "Methods"

#End Region

#Region "Constructors"
        Public Sub New(previousAppMode As ProgramMode,
                       currentAppMode As ProgramMode,
                       isWorkstationChanged As Boolean,
                       isApplicationModeChanged As Boolean,
                       isChatSevicesChanged As Boolean,
                       isInUseLintConnectionChanged As Boolean,
                       isEnableLoggingChanged As Boolean,
                       isChatEnabled As Boolean)
            MyBase.New(previousAppMode, currentAppMode)
            _isApplicationModeChanged = isApplicationModeChanged
            _isWorkstationChanged = isWorkstationChanged
            _isChatSevicesChanged = isChatSevicesChanged
            _isInUseLintConnectionChanged = isInUseLintConnectionChanged
            _isEnableLoggingChanged = isEnableLoggingChanged
            _isChatEnabled = isChatEnabled
        End Sub
#End Region

    End Class
End Namespace
