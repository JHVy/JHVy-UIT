Imports DTO.DangnhapDTO
Imports DAL.data
Namespace DangnhapDAL
    Public Class DangnhapDAL
        Dim dataaccess As New DataAccess
        'kiểm tra tài khoản đăng nhập
        Public Function Kiemtrataikhoandangnhap(ByVal dn As DangnhapDTO) As DataTable
            Dim sql As String = "select * from NGUOIDUNG where Nguoidung = '" & dn.Tendangnhap & "' and Matkhau = '" & dn.Matkhau & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
    End Class
End Namespace

