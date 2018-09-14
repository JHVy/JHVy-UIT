Namespace DangnhapDTO
    Public Class DangnhapDTO
        Private Tdangnhap As String
        Private Mkhau As String
        Public Tcsdl As String
        Property Tendangnhap As String
            Get
                Return Tdangnhap
            End Get
            Set(value As String)
                Tdangnhap = value
            End Set
        End Property

        Property Matkhau As String
            Get
                Return Mkhau
            End Get
            Set(value As String)
                Mkhau = value
            End Set
        End Property

        Property Tencsdl As String
            Get
                Return Tcsdl
            End Get
            Set(value As String)
                Tcsdl = value
            End Set
        End Property

    End Class
End Namespace

