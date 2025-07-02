Namespace Interfaces
    Public Interface IProgramModeEventArgs
        Inherits IDataRetrievalEventArgs
        ReadOnly Property CurrentProgramMode As ProgramMode
        ReadOnly Property PreviousProgramMode As ProgramMode
        ReadOnly Property IsFailOverMode As Boolean
    End Interface
End Namespace

