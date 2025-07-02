' ***********************************************************************
' Assembly         : Wdw_Sust.Core
' Author           : yeunc009
' Created          : 01-23-2017
'
' Last Modified By : yeunc009
' Last Modified On : 01-23-2017
' ***********************************************************************
' <copyright file="IsOpcArrayAttribute.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Namespace Attributes
    ''' <summary>
    ''' Class IsOpcArrayAttribute.
    ''' </summary>
    ''' <seealso cref="System.Attribute" />
    <AttributeUsage(AttributeTargets.Property)>
    Public Class IsOpcArrayAttribute
        Inherits Attribute

#Region "Fields"

        ''' <summary>
        ''' The array size
        ''' </summary>
        Private _arraySize As Integer
        ''' <summary>
        ''' The array start index
        ''' </summary>
        Private _arrayStartIndex As ArrayStartWithIndex = ArrayStartWithIndex.ZERO

#End Region

#Region "Properties"

        ''' <summary>
        ''' Gets or sets the size of the array.
        ''' </summary>
        ''' <value>The size of the array.</value>
        Public Property ArraySize As Integer
            Get
                Return _arraySize
            End Get
            Set(value As Integer)
                _arraySize = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the start index of the array.
        ''' </summary>
        ''' <value>The start index of the array.</value>
        Public Property ArrayStartIndex As ArrayStartWithIndex
            Get
                Return _arrayStartIndex
            End Get
            Set(value As ArrayStartWithIndex)
                _arrayStartIndex = value
            End Set
        End Property

#End Region

#Region "Contructors"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="IsOpcArrayAttribute" /> class.
        ''' </summary>
        ''' <param name="size">The size.</param>
        ''' <param name="arrayStartIndex">Start index of the array.</param>
        Public Sub New(ByVal size As Integer, Optional ByVal arrayStartIndex As ArrayStartWithIndex = ArrayStartWithIndex.ZERO)
            _arraySize = size
            _arrayStartIndex = arrayStartIndex
        End Sub
#End Region

    End Class
End Namespace