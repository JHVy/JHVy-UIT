Imports DTO.ThamsoDTO
Imports DAL.ThamsoDAL
Namespace ThamsoBUS
    Public Class ThamsoBUS
        Dim thamsodal As New ThamsoDAL
        'Lấy dữ liệu bảng THAMSO
        Public Function Taithamso()
            Return thamsodal.Taidulieu()
        End Function
        'Cập nhật giá trị tham số
        Public Function Capnhatthamso(ByVal thamso As ThamsoDTO) As String
            Return thamsodal.Capnhatthamso(thamso)
        End Function

       
    End Class
End Namespace

