Imports System.Data.SqlClient


Public Class LintTunnelProductivityData

#Region "Properities"
    Public Property MachineID() As Integer
    Public Property NumberOfBagDrops() As Integer
    Public Property RunDuration() As Decimal
#End Region

#Region "Constructors"
    Public Sub New()

    End Sub
    Public Sub New(ByVal machineID As Integer, ByVal numberOfBagDrops As Integer)
        Me.MachineID = machineID
        Me.NumberOfBagDrops = numberOfBagDrops
    End Sub
    Public Sub New(ByVal reader As SqlDataReader)
        MachineID = reader("Machine_ID")
        NumberOfBagDrops = reader("Number_Of_Bag_Drops")
        RunDuration = reader("Tunnel_Run_Time")
    End Sub
#End Region

End Class
