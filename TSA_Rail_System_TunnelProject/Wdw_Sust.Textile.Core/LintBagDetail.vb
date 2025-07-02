Imports Wdw_Sust.Core
Imports Wdw_Sust.Textile.Core.Interfaces

''' <summary>
''' Warning: this class is used in more than 1 OPC class and property names should not be changed
''' </summary>
''' <remarks>Last Updated: 09/11/2009 (CYS)</remarks>
<Serializable()>
Public Class LintBagDetail
    Inherits NotifyableBase(Of LintBagDetail)
    Implements ILintBagDetail

#Region "Fields"

    Private _account As Integer
    Private _allocated_to_washer As Integer
    Private _call_id As Integer
    Private _category As Integer
    Private _clean_weight As Decimal
    Private _data_changed_manually As Boolean
    Private _drop_destination As Integer
    Private _estimated_pieces As Integer
    Private _location_tracking_history As String
    Private _plc_bag_id As Integer
    Private _recirculation_destination As Integer
    Private _rf_tag_id As Integer
    Private _soiled_weight As Decimal
    Private _source_bin As Integer
    Private _source_dryer As Integer
    Private _source_vc As Integer
    Private _source_washer As Integer
    Private _storage_destination As Integer
    Private _used_assignment As Integer
    Private _wash_formula As Integer

#End Region

#Region "Properties"

    Public Overridable Property Account() As Integer
        Get
            Return _account
        End Get
        Set(value As Integer)
            SetField(_account, value)
        End Set
    End Property

    Public Overridable Property Allocated_to_Washer() As Integer
        Get
            Return _allocated_to_washer
        End Get
        Set(value As Integer)
            SetField(_allocated_to_washer, value)
        End Set
    End Property

    Public Overridable Property Call_ID() As Integer
        Get
            Return _call_id
        End Get
        Set(value As Integer)
            SetField(_call_id, value)
        End Set
    End Property

    Public Overridable Property Category() As Integer Implements ILintBagDetail.Category_Code
        Get
            Return _category
        End Get
        Set(value As Integer)
            SetField(_category, value)
        End Set
    End Property

    Public Overridable Property Clean_Weight() As Decimal Implements ILintBagDetail.Clean_Weight
        Get
            Return _clean_weight
        End Get
        Set(value As Decimal)
            SetField(_clean_weight, value)
        End Set
    End Property

    Public Property Data_Changed_Manually As Boolean Implements ILintBagDetail.Data_Changed_Manually
        Get
            Return _data_changed_manually
        End Get
        Set(value As Boolean)
            SetField(_data_changed_manually, value)
        End Set
    End Property

    Public Overridable Property Drop_Destination() As Integer Implements ILintBagDetail.Drop_Destination
        Get
            Return _drop_destination
        End Get
        Set(value As Integer)
            SetField(_drop_destination, value)
        End Set
    End Property

    Public Overridable Property Estimated_Pieces() As Integer
        Get
            Return _estimated_pieces
        End Get
        Set(value As Integer)
            SetField(_estimated_pieces, value)
        End Set
    End Property

    Public Overridable Property Location_Tracking_History() As String
        Get
            Return _location_tracking_history
        End Get
        Set(value As String)
            SetField(_location_tracking_history, value)
        End Set
    End Property

    Public Overridable Property PLC_Bag_ID() As Integer Implements ILintBagDetail.PLC_Bag_ID
        Get
            Return _plc_bag_id
        End Get
        Set(value As Integer)
            SetField(_plc_bag_id, value)
        End Set
    End Property

    Public Overridable Property Recirculation_Destination() As Integer
        Get
            Return _recirculation_destination
        End Get
        Set(value As Integer)
            SetField(_recirculation_destination, value)
        End Set
    End Property

    Public Overridable Property RF_Tag_ID() As Integer
        Get
            Return _rf_tag_id
        End Get
        Set(value As Integer)
            SetField(_rf_tag_id, value)
        End Set
    End Property

    Public Overridable Property Soiled_Weight() As Decimal Implements ILintBagDetail.Soiled_Weight
        Get
            Return _soiled_weight
        End Get
        Set(value As Decimal)
            SetField(_soiled_weight, value)
        End Set
    End Property

    Public Overridable Property Source_Dryer() As Integer
        Get
            Return _source_dryer
        End Get
        Set(value As Integer)
            SetField(_source_dryer, value)
        End Set
    End Property

    Public Overridable Property Source_VC() As Integer
        Get
            Return _source_vc
        End Get
        Set(value As Integer)
            SetField(_source_vc, value)
        End Set
    End Property

    Public Overridable Property Source_Washer() As Integer
        Get
            Return _source_washer
        End Get
        Set(value As Integer)
            SetField(_source_washer, value)
        End Set
    End Property

    Public Overridable Property SourceBin() As Integer Implements ILintBagDetail.Sorting_Station
        Get
            Return _source_bin
        End Get
        Set(value As Integer)
            SetField(_source_bin, value)
        End Set
    End Property

    Public Overridable Property Storage_Destination() As Integer Implements ILintBagDetail.Storage_Destination
        Get
            Return _storage_destination
        End Get
        Set(value As Integer)
            SetField(_storage_destination, value)
        End Set
    End Property

    Public Property UsedAssignment As Integer Implements ILintBagDetail.UsedAssignment
        Get
            Return _used_assignment
        End Get
        Set(value As Integer)
            SetField(_used_assignment, value)
        End Set
    End Property

    Public Overridable Property Wash_Formula() As Integer
        Get
            Return _wash_formula
        End Get
        Set(value As Integer)
            SetField(_wash_formula, value)
        End Set
    End Property

#End Region

#Region "Methods"

    Public Shared Function EmptyBagDetail() As LintBagDetail
        Return New LintBagDetail With {
                .Account = 0,
                .Allocated_to_Washer = 0,
                .Call_ID = 0,
                .Clean_Weight = 0,
                .Category = 0,
                .Data_Changed_Manually = 0,
                .Drop_Destination = 0,
                .Estimated_Pieces = 0,
                .PLC_Bag_ID = 0,
                .Recirculation_Destination = 0,
                .Soiled_Weight = 0,
                .RF_Tag_ID = 0,
                .SourceBin = 0,
                .Source_Dryer = 0,
                .Source_VC = 0,
                .Storage_Destination = 0,
                .Source_Washer = 0,
                .Wash_Formula = 0
            }
    End Function

#End Region

#Region "Constructors"

    Public Sub New(reader As IDataReader)
        PLC_Bag_ID = reader("bag_ID")
        Soiled_Weight = reader("soiled_weight")
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class