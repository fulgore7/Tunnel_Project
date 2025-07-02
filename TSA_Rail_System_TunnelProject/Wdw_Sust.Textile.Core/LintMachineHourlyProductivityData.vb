
Imports System.Data

Public Class LintMachineHourlyProductivityData
    Private _hour As Integer
    Private _machineName As String
    Private _productivty As Integer
    Public Property Hour() As Integer
        Get
            Return _hour
        End Get
        Set(ByVal value As Integer)
            _hour = value
        End Set
    End Property
    Public Property MachineName() As String
        Get
            Return _machineName
        End Get
        Set(ByVal value As String)
            _machineName = value
        End Set
    End Property
    Public Property Productivty() As Integer
        Get
            Return _productivty
        End Get
        Set(ByVal value As Integer)
            _productivty = value
        End Set
    End Property

    Public Sub New(ByVal reader As IDataReader)
        _hour = reader("Hour")
        _machineName = reader("Machine_Name")
        _productivty = reader("Pounds")
    End Sub
End Class

