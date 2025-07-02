
Public Class LintImage

#Region "Private Fields"
        Private _imageContent() As Byte
        Private _imageType As Integer
        Private _imageID As Integer
        Private _imageFileType As String
        Private _imageDescription As String
#End Region

#Region "Public Properties"
        Public Property ImageDescription() As String
            Get
                Return _imageDescription
            End Get
            Set(ByVal value As String)
                _imageDescription = value
            End Set
        End Property
        Public Property ImageType() As Integer
            Get
                Return _imageType
            End Get
            Set(ByVal value As Integer)
                _imageType = value
            End Set
        End Property
        Public Property ImageContent() As Byte()
            Get
                Return _imageContent
            End Get
            Set(ByVal value As Byte())
                _imageContent = value
            End Set
        End Property
        Public Property ImageFileType() As String
            Get
                Return _imageFileType
            End Get
            Set(ByVal value As String)
                _imageFileType = value
            End Set
        End Property
        Public Property ImageID() As Integer
            Get
                Return _imageID
            End Get
            Set(ByVal value As Integer)
                _imageID = value
            End Set
        End Property
#End Region

#Region "Constructors"
        Public Sub New()
            Me.ImageID = 0
            Me.ImageType = 0
            Me.ImageDescription = String.Empty
        End Sub
#End Region

    End Class
