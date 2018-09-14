Namespace KhachhangDTO
    Public Class KhachhangDTO
        Private Mkhach As String
        Private Hoten As String
        Private Dchi As String
        Private Dthoai As String
        Private Mail As String
        Private STN As Single
        Property Makhachhang As String
            Get
                Return Mkhach
            End Get
            Set(value As String)
                Mkhach = value
            End Set
        End Property

        Property Hotenkhachhang As String
            Get
                Return Hoten
            End Get
            Set(value As String)
                Hoten = value
            End Set
        End Property

        Property Diachi As String
            Get
                Return Dchi
            End Get
            Set(value As String)
                Dchi = value
            End Set
        End Property

        Property Dienthoai As String
            Get
                Return Dthoai
            End Get
            Set(value As String)
                Dthoai = value
            End Set
        End Property

        Property Email As String
            Get
                Return Mail
            End Get
            Set(value As String)
                Mail = value
            End Set
        End Property

        Property Sotienno As Single
            Get
                Return STN
            End Get
            Set(value As Single)
                STN = value
            End Set
        End Property
    End Class
End Namespace
