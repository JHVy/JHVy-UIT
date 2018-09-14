Imports DTO.DangnhapDTO
Imports DAL.DangnhapDAL
Namespace DangnhapBUS
    Public Class DangnhapBUS
        Dim dangnhapdal As New DangnhapDAL
        Public Function Kiemtrataikhoandangnhap(ByVal dn As DangnhapDTO)
            Return dangnhapdal.Kiemtrataikhoandangnhap(dn)
        End Function
    End Class
End Namespace

