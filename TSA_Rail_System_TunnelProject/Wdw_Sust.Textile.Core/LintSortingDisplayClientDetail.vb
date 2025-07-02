<Serializable()>
Public Class LintSortingDisplayClientDetail
    Inherits LintClientWorkStationDetail

    Public Function GetStationNumbers() As List(Of Integer)
        Dim stations As List(Of Integer) = New List(Of Integer)

        Select Case WorkStation
            Case WorkStations.TSA_HOPPER_DISPLAY_01_02
                stations.Add(1)
                stations.Add(2)
            Case WorkStations.TSA_HOPPER_DISPLAY_03_04
                stations.Add(3)
                stations.Add(4)
            Case WorkStations.TSA_HOPPER_DISPLAY_05_06
                stations.Add(5)
                stations.Add(6)
            Case WorkStations.TSA_HOPPER_DISPLAY_07_08
                stations.Add(7)
                stations.Add(8)
            Case WorkStations.TSA_HOPPER_DISPLAY_09_10
                stations.Add(9)
                stations.Add(10)
            Case WorkStations.TSA_HOPPER_DISPLAY_11_12
                stations.Add(11)
                stations.Add(12)
            Case WorkStations.TSA_HOPPER_DISPLAY_13_14
                stations.Add(13)
                stations.Add(14)
            Case WorkStations.TSA_HOPPER_DISPLAY_15_16
                stations.Add(15)
                stations.Add(16)
            Case WorkStations.TSA_HOPPER_DISPLAY_17_18
                stations.Add(17)
                stations.Add(18)
            Case WorkStations.TSA_HOPPER_DISPLAY_19_20
                stations.Add(19)
                stations.Add(20)
            Case WorkStations.TSA_HOPPER_DISPLAY_21_22
                stations.Add(21)
                stations.Add(22)
            Case WorkStations.TSA_HOPPER_DISPLAY_23_24
                stations.Add(23)
                stations.Add(24)
            Case WorkStations.TSA_HOPPER_DISPLAY_25_26
                stations.Add(25)
                stations.Add(26)
            Case WorkStations.TSA_HOPPER_DISPLAY_27_28
                stations.Add(27)
                stations.Add(28)
            Case WorkStations.TSA_HOPPER_DISPLAY_29_30
                stations.Add(29)
                stations.Add(30)
            Case WorkStations.TSA_HOPPER_DISPLAY_31_32
                stations.Add(31)
                stations.Add(32)
            Case WorkStations.TSA_HOPPER_DISPLAY_33_34
                stations.Add(33)
                stations.Add(34)
        End Select

        Return stations
    End Function
End Class
