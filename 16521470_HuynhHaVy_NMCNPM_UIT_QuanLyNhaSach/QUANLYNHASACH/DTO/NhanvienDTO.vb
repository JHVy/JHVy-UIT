Namespace NhanvienDTO
    Public Class NhanvienDTO
        Private Mnvien As String
        Private Hoten As String
        Private Dchi As String
        Private Dthoai As String
        Private Mail As String
        Private Tluong As Single
        Property Manhanvien As String
            Get
                Return Mnvien
            End Get
            Set(value As String)
                Mnvien = value
            End Set
        End Property

        Property Hotennhanvien As String
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

        Property Tienluong As Single
            Get
                Return Tluong
            End Get
            Set(value As Single)
                Tluong = value
            End Set
        End Property
    End Class
End Namespace
