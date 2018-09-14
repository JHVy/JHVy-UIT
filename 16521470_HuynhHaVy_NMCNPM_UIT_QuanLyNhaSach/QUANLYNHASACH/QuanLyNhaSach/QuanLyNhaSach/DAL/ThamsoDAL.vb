Imports DTO.ThamsoDTO
Imports System.Data.SqlClient
Imports DAL.DataAccess
Namespace ThamsoDAL
    Public Class ThamsoDAL
        Dim dataaccess As New DataAccess
        Dim thamso As ThamsoDTO
        Public Function Taidulieu() As DataTable
            Return dataaccess.Taidulieu("Select * From THAMSO")
        End Function

        Public Function Capnhatthamso(ByVal thamso As ThamsoDTO) As String
            Dim sql As String = "update THAMSO set Soluongnhapitnhat='" & thamso.Soluongnhapitnhat & "',Soluongtontoidatruocnhap='" & thamso.Soluongtontoidatruocnhap & "',Soluongtonsautoithieu='" & thamso.Soluongtonsautoithieu & "',Sotiennotoida='" & thamso.Sotiennotoida & "',Sudungquydinh4='" & thamso.Sudungquydinh4 & "' where Mathamso = '" & thamso.Mathamso & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Themthamso(ByVal thamso As ThamsoDTO) As String
            Dim sql As String = "insert into THAMSO(Soluongnhapitnhat,Soluongtontoidatruocnhap,Soluongtonsautoithieu,Sotiennotoida,Sudungquydinh4) values('" & thamso.Soluongnhapitnhat & "','" & thamso.Soluongtontoidatruocnhap & "','" & thamso.Soluongtonsautoithieu & "','" & thamso.Sotiennotoida & "','" & thamso.Sudungquydinh4 & "')"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function laythamsobangma(ByVal thamso As ThamsoDTO) As String
            Dim sql As String = "select * from THAMSO where Mathamso = '" & thamso.Mathamso & "'"
            Dim dt As DataTable = dataaccess.Taidulieu(sql)
            If dt.Rows.Count = 0 Then
                Return Nothing
            End If
            Return 1
        End Function

    End Class
End Namespace
