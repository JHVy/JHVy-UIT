Namespace PhieuthuDTO
    Public Class PhieuthuDTO
        Dim Mphieunthu As String
        Dim STT As Single
        Dim Nthutien As Date
        Dim Mkhachhang As String
        Property Maphieuthu As String
            Get
                Return Mphieunthu
            End Get
            Set(value As String)
                Mphieunthu = value
            End Set
        End Property

        Property Sotienthu As Single
            Get
                Return STT
            End Get
            Set(value As Single)
                STT = value
            End Set
        End Property

        Property Ngaythutien As Date
            Get
                Return Nthutien
            End Get
            Set(value As Date)
                Nthutien = value
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
    End Class
End Namespace
