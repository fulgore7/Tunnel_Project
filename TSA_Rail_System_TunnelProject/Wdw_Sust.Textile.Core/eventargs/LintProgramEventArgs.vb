Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces

Namespace EventArgs
    Public Class LintProgramEventArgs
        Inherits DataRetrievalEventArgs
        Implements IProgramModeEventArgs

        Private _currentAppMode As ProgramMode
        Private _previousAppMode As ProgramMode

        Public ReadOnly Property CurrentApplicationMode As ProgramMode Implements IProgramModeEventArgs.CurrentProgramMode
            Get
                Return _currentAppMode
            End Get
        End Property

        Public ReadOnly Property PreviousApplicationMode As ProgramMode Implements IProgramModeEventArgs.PreviousProgramMode
            Get
                Return _previousAppMode
            End Get
        End Property

        Public ReadOnly Property IsFailOverMode As Boolean Implements IProgramModeEventArgs.IsFailOverMode
            Get
                Return CurrentApplicationMode = ProgramMode.FAIL_OVER_AUTO OrElse CurrentApplicationMode = ProgramMode.FAIL_OVER_MANUAL
            End Get
        End Property

        Public Sub New(previousMode As ProgramMode, currentMode As ProgramMode)
            _previousAppMode = previousMode
            _currentAppMode = currentMode
        End Sub
    End Class
End Namespace
