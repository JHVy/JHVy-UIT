Imports DTO.SachDTO
Imports System.Data.SqlClient
Imports DAL.data

Namespace SachDAL

    Public Class SachDAL

        Dim dataaccess As New DataAccess
        'Hiển thị dữ liệu sách
        Public Function Taidulieu() As DataTable
            Return dataaccess.Taidulieu("Select * From SACH")
        End Function
        'Thêm sách
        Public Function Them(ByVal s As SachDTO) As String
            Dim sql As String = "INSERT INTO SACH(Masach, Tensach, Theloai, Tacgia, Soluongton) VALUES(N'" & s.Masach.Trim & "',N'" & s.Tensach.Trim & "',N'" & s.Theloai.Trim & "',N'" & s.Tacgia.Trim & "',N'" & s.Soluongton & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa sách
        Public Function Xoa(ByVal s As SachDTO) As String
            Dim sql As String = "delete from SACH where Masach=N'" + s.Masach.Trim + "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Sửa sách
        Public Function Sua(ByVal s As SachDTO) As String
            Dim sql As String = "update SACH set Tensach=N'" & s.Tensach.Trim & "',Theloai=N'" & s.Theloai.Trim + "',Tacgia=N'" & s.Tacgia.Trim + "' where Masach=N'" & s.Masach.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Cập nhật số lượng tồn
        Public Sub Capnhatsoluongton(ByVal s As SachDTO)
            Dim sql As String = "update SACH set SoLuongTon=N'" & s.Soluongton & "' where MaSach = N'" & s.Masach.Trim & "'"
            dataaccess.Thucthisql(sql)
        End Sub
        'Tìm kiếm sách theo mã sách
        Public Function Timkiemtheomasach(ByVal sach As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Masach='" & sach.Masach & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Lấy mã sách từ bảng SACH
        Public Function Timkiemmasach() As DataTable
            Dim sql As String = "select Masach from SACH"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm sách theo tên sách
        Public Function Timkiemtensach(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Tensach like '%" & s.Tensach & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm Kiếm sách theo thể loại
        Public Function Timkiemtheloai(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Theloai like '%" & s.Theloai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm sách theo tác giả
        Public Function Timkiemtacgia(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Tacgia like '%" & s.Tacgia & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm sách theo tên sách và tác giả
        Public Function Timkiemtensachvatacgia(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Tensach like '%" & s.Tensach & "%' and Tacgia like '%" & s.Tacgia & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm sách theo tên sách và thể loại
        Public Function Timkiemtensachvatheloai(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Tensach like '%" & s.Tensach & "%' and Theloai like '%" & s.Theloai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'tìm kiếm sách theo tác giả và thể loại
        Public Function Timkiemtacgiavatheloai(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Tacgia like '%" & s.Tacgia & "%' and Theloai like '%" & s.Theloai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm sachs theo tên sách , thể loại và tác giả
        Public Function Timkiemtensachvatheloaivatacgia(ByVal s As SachDTO) As DataTable
            Dim sql As String = "select * from SACH where Tensach like '%" & s.Tensach & "%' and Theloai like '%" & s.Theloai & "%' and Tacgia like '%" & s.Tacgia & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function

        Public Function Tangma() As String
            Dim sql As String = "Select * From SACH"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "MS001"
            Else
                Dim k As Integer
                ma = "MS"
                k = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0).ToString().Substring(2, 3))
                k = k + 1
                If k < 10 Then
                    ma = ma + "00"
                ElseIf k < 100 Then
                    ma = ma + "0"
                End If
                ma = ma + k.ToString()
            End If
            Return ma
        End Function
    End Class
End Namespace
