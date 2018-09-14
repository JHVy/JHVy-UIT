Namespace ChitiethoadonDTO
    Public Class ChitiethoadonDTO
        Private MCThoadon As String
        Private Mhoadon As String
        Private Msach As String
        Private SLB As Integer
        Private DGB As Single

        Property Machitiethoadon As String
            Get
                Return MCThoadon
            End Get
            Set(value As String)
                MCThoadon = value
            End Set
        End Property

        Property Mahoadon As String
            Get
                Return Mhoadon
            End Get
            Set(value As String)
                Mhoadon = value
            End Set
        End Property

        Property Masach As String
            Get
                Return Msach
            End Get
            Set(value As String)
                Msach = value
            End Set
        End Property

        Property Soluongban As String
            Get
                Return SLB
            End Get
            Set(value As String)
                SLB = value
            End Set
        End Property

        Property Dongiaban As String
            Get
                Return DGB
            End Get
            Set(value As String)
                DGB = value
            End Set
        End Property
    End Class
End Namespace

