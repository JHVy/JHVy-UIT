Namespace PhieuNhapDTO
    Public Class PhieuNhapDTO
        Private MaPN As String
        Private NgNhap As String
        Property Maphieunhap As String
            Get
                Return MaPN
            End Get
            Set(value As String)
                MaPN = value
            End Set
        End Property

        Property Ngaynhap As String
            Get
                Return NgNhap
            End Get
            Set(value As String)
                NgNhap = value
            End Set
        End Property

    End Class
End Namespace

