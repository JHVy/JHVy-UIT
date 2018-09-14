Imports DTO.ThamsoDTO
Imports System.Data.SqlClient
Imports DAL.data
Namespace ThamsoDAL
    Public Class ThamsoDAL
        Dim dataaccess As New DataAccess
        Dim thamso As ThamsoDTO
        'Lấy dữ liệu từ bảng THAMSO
        Public Function Taidulieu() As DataTable
            Return dataaccess.Taidulieu("Select * From THAMSO")
        End Function
        'Cập nhật giá trị tham số
        Public Function Capnhatthamso(ByVal thamso As ThamsoDTO) As String
            Dim sql As String = "update THAMSO set Soluongnhapitnhat='" & thamso.Soluongnhapitnhat & "',Soluongtontoidatruocnhap='" & thamso.Soluongtontoidatruocnhap & "',Soluongtonsautoithieu='" & thamso.Soluongtonsautoithieu & "',Sotiennotoida='" & thamso.Sotiennotoida & "',Sudungquydinh4='" & thamso.Sudungquydinh4 & "' where Mathamso = '" & thamso.Mathamso & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

    End Class
End Namespace
