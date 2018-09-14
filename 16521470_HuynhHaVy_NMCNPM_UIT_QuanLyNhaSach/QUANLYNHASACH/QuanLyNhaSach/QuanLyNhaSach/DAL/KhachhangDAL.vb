Imports DTO.KhachhangDTO
Imports System.Data.SqlClient
Imports DAL.DataAccess

Namespace KhachhangDAL

    Public Class KhachhangDAL

        Dim dataaccess As New DataAccess
        Public Function Taidulieu() As DataTable
            Return dataaccess.Taidulieu("Select * From KHACHHANG")
        End Function

        Public Function Them(ByVal K As KhachhangDTO) As String
            Dim sql As String = "INSERT INTO KHACHHANG(Makhachhang, Hotenkhachhang, Diachi, Dienthoai, Email,Sotienno) VALUES('" & K.Makhachhang.Trim & "',N'" & K.Hotenkhachhang.Trim & "',N'" & K.Diachi.Trim & "','" & K.Dienthoai & "',N'" & K.Email & "','" & K.Sotienno & "')"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Xoa(ByVal K As KhachhangDTO) As String
            Dim sql As String = "delete from KHACHHANG where Makhachhang='" + K.Makhachhang.Trim + "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Sua(ByVal K As KhachhangDTO) As String
            Dim sql As String = "update KHACHHANG set Diachi=N'" & K.Diachi.Trim & "',Hotenkhachhang=N'" & K.Hotenkhachhang.Trim & "',Dienthoai='" & K.Dienthoai.Trim & "',Email=N'" & K.Email.Trim & "' where Makhachhang='" & K.Makhachhang.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Capnhatsotienno(ByVal K As KhachhangDTO) As String
            Dim sql As String = "update KHACHHANG set Sotienno='" & K.Sotienno & "' where Makhachhang='" & K.Makhachhang.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Timkiemtheomakhachhang(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Makhachhang ='" & k.Makhachhang & "'"
            Return dataaccess.Taidulieu(sql)
        End Function

        Public Function Timkiemmakhachhang() As DataTable
            Dim sql As String = " select Makhachhang from KHACHHANG"
            Return dataaccess.Taidulieu(sql)
        End Function

        Public Function Tangma() As String
            Dim sql As String = "Select * From KHACHHANG"
            Dim str As String = "Data Source=winchester-pc;Initial Catalog=QuanLyNhaSach;Integrated Security=True"
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "KH001"
            Else
                Dim k As Integer
                ma = "KH"
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
