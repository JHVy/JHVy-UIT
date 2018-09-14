Namespace BaocaotonDTO
    Public Class BaocaotonDTO
        Private Mchitietton As String
        Private Th As Integer
        Private Na As Integer
        Private Msach As String
        Private Tdau As Integer
        Private Tphatsinh As Integer
        Private Tcuoi As Integer
        Property Machitietton As String
            Get
                Return Mchitietton
            End Get
            Set(value As String)
                Mchitietton = value
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

        Property Masach As String
            Get
                Return Msach
            End Get
            Set(value As String)
                Msach = value
            End Set
        End Property

        Property Tondau As Integer
            Get
                Return Tdau
            End Get
            Set(value As Integer)
                Tdau = value
            End Set
        End Property

        Property Tonphatsinh As Integer
            Get
                Return Tphatsinh
            End Get
            Set(value As Integer)
                Tphatsinh = value
            End Set
        End Property

        Property Toncuoi As Integer
            Get
                Return Tcuoi
            End Get
            Set(value As Integer)
                Tcuoi = value
            End Set
        End Property
    End Class
End Namespace
