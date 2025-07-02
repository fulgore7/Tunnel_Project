Imports System.Data

<Serializable()>
Public Class LintWashGroupInfo
    Inherits LintObjectBase(Of LintWashGroupInfo)

#Region "Fields"
    Private _washGroupID As Integer
    Private _description As String
    Private _incompatibleGroup1 As Integer
    Private _incompatibleGroup2 As Integer
    Private _incompatibleGroup3 As Integer
    Private _incompatibleGroup4 As Integer
    Private _incompatibleGroup5 As Integer
    Private _incompatibleGroup6 As Integer
    Private _incompatibleGroup7 As Integer
    Private _incompatibleGroup8 As Integer
    Private _incompatibleGroup9 As Integer
    Private _incompatibleGroup10 As Integer
    Private _chemicalStrength As String
#End Region

#Region "Properties"
    Public Property ChemicalStrength() As String
        Get
            Return _chemicalStrength
        End Get
        Set(ByVal value As String)
            _chemicalStrength = value
        End Set
    End Property

    Public Property Description() As String
        Get
            If _description Is Nothing Then
                _description = String.Empty
            End If
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property
    Public Property IncompatibleGroup1 As Integer
        Get
            Return _incompatibleGroup1
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup1 = value
        End Set
    End Property

    Public Property IncompatibleGroup10() As Integer
        Get
            Return _incompatibleGroup10
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup10 = value
        End Set
    End Property
    Public Property IncompatibleGroup2() As Integer
        Get
            Return _incompatibleGroup2
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup2 = value
        End Set
    End Property
    Public Property IncompatibleGroup3() As Integer
        Get
            Return _incompatibleGroup3
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup3 = value
        End Set
    End Property
    Public Property IncompatibleGroup4() As Integer
        Get
            Return _incompatibleGroup4
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup4 = value
        End Set
    End Property
    Public Property IncompatibleGroup5() As Integer
        Get
            Return _incompatibleGroup5
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup5 = value
        End Set
    End Property
    Public Property IncompatibleGroup6() As Integer
        Get
            Return _incompatibleGroup6
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup6 = value
        End Set
    End Property
    Public Property IncompatibleGroup7() As Integer
        Get
            Return _incompatibleGroup7
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup7 = value
        End Set
    End Property
    Public Property IncompatibleGroup8() As Integer
        Get
            Return _incompatibleGroup8
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup8 = value
        End Set
    End Property
    Public Property IncompatibleGroup9() As Integer
        Get
            Return _incompatibleGroup9
        End Get
        Set(ByVal value As Integer)
            _incompatibleGroup9 = value
        End Set
    End Property
    Public Property WashGroupID() As Integer
        Get
            Return _washGroupID
        End Get
        Set(ByVal value As Integer)
            _washGroupID = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New(ByVal reader As IDataReader)
        _washGroupID = reader("Wash_Group_ID")
        _incompatibleGroup1 = reader("Incompatible_Group_1")
        _incompatibleGroup2 = reader("Incompatible_Group_2")
        _incompatibleGroup3 = reader("Incompatible_Group_3")
        _incompatibleGroup4 = reader("Incompatible_Group_4")
        _incompatibleGroup5 = reader("Incompatible_Group_5")
        _incompatibleGroup6 = reader("Incompatible_Group_6")
        _incompatibleGroup7 = reader("Incompatible_Group_7")
        _incompatibleGroup8 = reader("Incompatible_Group_8")
        _incompatibleGroup9 = reader("Incompatible_Group_9")
        _incompatibleGroup10 = reader("Incompatible_Group_10")
        _chemicalStrength = reader("Chemical_Strength")
        _description = reader("Description")
    End Sub
#End Region

End Class

