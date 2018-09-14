Namespace ThamsoDTO
    Public Class ThamsoDTO
        Private MThamso As Integer
        Private SLNitnhat As Integer
        Private SLTtoidatruocnhap As Integer
        Private SLTsautoitieu As Integer
        Private STNtoida As Single
        Private SudungQD4 As Integer

        Property Mathamso As Integer
            Get
                Return MThamso
            End Get
            Set(value As Integer)
                MThamso = value
            End Set
        End Property

        Property Soluongnhapitnhat As Integer
            Get
                Return SLNitnhat
            End Get
            Set(value As Integer)
                SLNitnhat = value
            End Set
        End Property

        Property Soluongtontoidatruocnhap As Integer
            Get
                Return SLTtoidatruocnhap
            End Get
            Set(value As Integer)
                SLTtoidatruocnhap = value
            End Set
        End Property

        Property Soluongtonsautoithieu As Integer
            Get
                Return SLTsautoitieu
            End Get
            Set(value As Integer)
                SLTsautoitieu = value
            End Set
        End Property

        Property Sotiennotoida As Integer
            Get
                Return STNtoida
            End Get
            Set(value As Integer)
                STNtoida = value
            End Set
        End Property

        Property Sudungquydinh4 As Single
            Get
                Return SudungQD4
            End Get
            Set(value As Single)
                SudungQD4 = value
            End Set
        End Property
    End Class
End Namespace

