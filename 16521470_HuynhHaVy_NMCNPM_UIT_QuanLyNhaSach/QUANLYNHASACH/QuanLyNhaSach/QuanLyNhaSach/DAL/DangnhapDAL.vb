Imports DTO.DangnhapDTO
Imports DAL.DataAccess
Namespace DangnhapDAL
    Public Class DangnhapDAL
        Dim dataaccess As New DataAccess
        Public Function Kiemtrataikhoandangnhap(ByVal dn As DangnhapDTO) As DataTable
            Dim sql As String = "select * from NGUOIDUNG where Nguoidung = '" & dn.Tendangnhap & "' and Matkhau = '" & dn.Matkhau & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
    End Class
End Namespace

