Namespace HoadonDTO
    Public Class HoadonDTO
        Private MHoadon As String
        Private Mkhachhang As String
        Private Nglaphoadon As Date
        Private Tthanhtien As Single
        Property Mahoadon As String
            Get
                Return MHoadon
            End Get
            Set(value As String)
                MHoadon = value
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

        Property Ngaylaphoadon As Date
            Get
                Return Nglaphoadon
            End Get
            Set(value As Date)
                Nglaphoadon = value
            End Set
        End Property

        Property Tongthanhtien As Single
            Get
                Return Tthanhtien
            End Get
            Set(value As Single)
                Tthanhtien = value
            End Set
        End Property
    End Class
End Namespace

