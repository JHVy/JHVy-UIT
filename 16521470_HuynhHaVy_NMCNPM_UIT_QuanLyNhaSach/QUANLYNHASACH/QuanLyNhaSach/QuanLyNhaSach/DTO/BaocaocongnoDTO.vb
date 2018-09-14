Namespace BaocaocongnoDTO
    Public Class BaocaocongnoDTO
        Private Mchitietcongno As String
        Private Th As Integer
        Private Na As Integer
        Private Mkhachhang As String
        Private Ndau As Single
        Private Nphatsinh As Single
        Private Ncuoi As Single
        Property Machitietcongno As String
            Get
                Return Mchitietcongno
            End Get
            Set(value As String)
                Mchitietcongno = value
            End Set
        End Property

        Property Thang As Integer
            Get
                Return Th
            End Get
            Set(value As Integer)
                Th = value
            End Set
        End Property

        Property Nam As Integer
            Get
                Return Na
            End Get
            Set(value As Integer)
                Na = value
            End Set
        End Property

        Property Makhachhang As String
            Get
                Return Mkhachhang
            End Get
            Set(value As String)
                Mkhachhang = value
            End Set
        End Property

        Property Nodau As Single
            Get
                Return Ndau
            End Get
            Set(value As Single)
                Ndau = value
            End Set
        End Property

        Property Nophatsinh As Single
            Get
                Return Nphatsinh
            End Get
            Set(value As Single)
                Nphatsinh = value
            End Set
        End Property

        Property Nocuoi As Single
            Get
                Return Ncuoi
            End Get
            Set(value As Single)
                Ncuoi = value
            End Set
        End Property
    End Class
End Namespace
