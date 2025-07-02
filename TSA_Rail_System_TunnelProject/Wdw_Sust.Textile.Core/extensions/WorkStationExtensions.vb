Imports System.Runtime.CompilerServices
Namespace Extensions
    Public Module WorkStationExtensions
        <Extension()>
        Public Function IsTsaControlWorkStation(ByVal workStation As WorkStations) As Boolean
            Return workStation = WorkStations.TSA_CLEANWORK_CONTROL_PC OrElse
                   workStation = WorkStations.TSA_COACHES_PC OrElse
                   workStation = WorkStations.TSA_SORTING_CONTROL_PC OrElse
                   workStation = WorkStations.TSA_WASHDECK_CONTROL_PC_1 OrElse
                   workStation = WorkStations.TSA_WASHDECK_CONTROL_PC_2 OrElse
                   workStation = WorkStations.DEVELOPMENT_PC
        End Function
    End Module
End Namespace

