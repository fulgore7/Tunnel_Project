Imports Wdw_Sust.Core.Interfaces

Namespace Interfaces
    ''' <summary>
    ''' This is the object that can get to different providers and also set 
    ''' their connection strings accordingly.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Interfaces.IHaveConnectionString" />
    Public Interface ILintFactoryProvider
        Inherits IHaveConnectionString
        Property EnableAutomaticUpdateConnectionString As Boolean
        ReadOnly Property Alarm As ILintAlarmProvider
        ReadOnly Property ProdStatus As ILintProdStatusProvider
        ReadOnly Property LintInfo As ILintInfoProvider
        ReadOnly Property Productivity As ILintProductivityInfoProvider
        ReadOnly Property Rail As ILintRailInfoProvider
        ReadOnly Property ProductivityReportInfo As ILintProductivityReportInfoProvider
        ReadOnly Property Security As ILintSecurityProvider
        ReadOnly Property Services As ILintSystemsProvider
        ReadOnly Property Team As ILintTeamProvider
    End Interface
End Namespace
