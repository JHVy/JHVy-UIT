Namespace ChitietphieunhapDTO

    Public Class ChitietphieunhapDTO
        Private MaCT As String
        Private MaPN As String
        Private MaS As String
        Private SLN As Integer

        Property Machitiet As String
            Get
                Return MaCT
            End Get
            Set(value As String)
                MaCT = value
            End Set
        End Property

        Property Maphieunhap As String
            Get
                Return MaPN
            End Get
            Set(value As String)
                MaPN = value
            End Set
        End Property

        Property Masach As String
            Get
                Return MaS
            End Get
            Set(value As String)
                MaS = value
            End Set
        End Property

        Property Soluongnhap As String
            Get
                Return SLN
            End Get
            Set(value As String)
                SLN = value
            End Set
        End Property
    End Class
End Namespace

