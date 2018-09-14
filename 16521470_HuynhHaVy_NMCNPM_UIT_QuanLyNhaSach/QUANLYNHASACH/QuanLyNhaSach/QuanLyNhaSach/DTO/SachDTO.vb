Namespace SachDTO
    Public Class SachDTO
        Private Tsach As String
        Private Tgia As String
        Private Tloai As String
        Private SLT As Integer
        Private MaS As String

        Property Masach As String
            Get
                Return MaS
            End Get
            Set(value As String)
                MaS = value
            End Set
        End Property

        Property Tensach As String
            Get
                Return Tsach
            End Get
            Set(value As String)
                Tsach = value
            End Set
        End Property

        Property Tacgia As String
            Get
                Return Tgia
            End Get
            Set(value As String)
                Tgia = value
            End Set
        End Property

        Property Theloai As String
            Get
                Return Tloai
            End Get
            Set(value As String)
                Tloai = value
            End Set
        End Property

        Property Soluongton As Integer
            Get
                Return SLT
            End Get
            Set(value As Integer)
                SLT = value
            End Set
        End Property
    End Class
End Namespace
