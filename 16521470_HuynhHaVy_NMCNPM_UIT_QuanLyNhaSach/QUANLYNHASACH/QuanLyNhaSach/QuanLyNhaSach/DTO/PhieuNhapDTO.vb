Namespace PhieuNhapDTO
    Public Class PhieuNhapDTO
        Private MaPN As String
        Private NgNhap As Date
        Property Maphieunhap As String
            Get
                Return MaPN
            End Get
            Set(value As String)
                MaPN = value
            End Set
        End Property

        Property Ngaynhap As date
            Get
                Return NgNhap
            End Get
            Set(value As Date)
                NgNhap = value
            End Set
        End Property

    End Class
End Namespace

