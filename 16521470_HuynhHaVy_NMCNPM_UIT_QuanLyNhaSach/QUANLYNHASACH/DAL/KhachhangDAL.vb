Imports DTO.KhachhangDTO
Imports System.Data.SqlClient
Imports DAL.data

Namespace KhachhangDAL

    Public Class KhachhangDAL

        Dim dataaccess As New DataAccess
        'Hiển thị dữ liệu khách hàng
        Public Function Taidulieu() As DataTable
            Return dataaccess.Taidulieu("Select * From KHACHHANG")
        End Function
        'Thêm khách hàng
        Public Function Them(ByVal K As KhachhangDTO) As String
            Dim sql As String = "INSERT INTO KHACHHANG(Makhachhang, Hotenkhachhang, Diachi, Dienthoai, Email,Sotienno) VALUES('" & K.Makhachhang.Trim & "',N'" & K.Hotenkhachhang.Trim & "',N'" & K.Diachi.Trim & "','" & K.Dienthoai & "',N'" & K.Email & "','" & K.Sotienno & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa khách hàng
        Public Function Xoa(ByVal K As KhachhangDTO) As String
            Dim sql As String = "delete from KHACHHANG where Makhachhang='" + K.Makhachhang.Trim + "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Sửa khách hàng
        Public Function Sua(ByVal K As KhachhangDTO) As String
            Dim sql As String = "update KHACHHANG set Diachi=N'" & K.Diachi.Trim & "',Hotenkhachhang=N'" & K.Hotenkhachhang.Trim & "',Dienthoai='" & K.Dienthoai.Trim & "',Email=N'" & K.Email.Trim & "' where Makhachhang='" & K.Makhachhang.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Cập nhật số tiền nợ
        Public Function Capnhatsotienno(ByVal K As KhachhangDTO) As String
            Dim sql As String = "update KHACHHANG set Sotienno='" & K.Sotienno & "' where Makhachhang='" & K.Makhachhang.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Tìm kiếm khách hàng theo mã khách hàng
        Public Function Timkiemtheomakhachhang(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Makhachhang ='" & k.Makhachhang & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Lấy mã khách hàng từ bảng KHACHHANG
        Public Function Timkiemmakhachhang() As DataTable
            Dim sql As String = " select Makhachhang from KHACHHANG"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng    
        Public Function Timkiemtenkhachhang(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Hotenkhachhang like '%" & k.Hotenkhachhang & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo địa chỉ
        Public Function Timkiemdiachi(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Diachi like '%" & k.Diachi & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo điện thoại
        Public Function Timkiemdienthoai(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng và địa chỉ
        Public Function Timkiemtenkhachhangvadiachi(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Hotenkhachhang like '%" & k.Hotenkhachhang & "%' and Diachi like '%" & k.Diachi & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng và điện thoại
        Public Function Timkiemtenkhachhangvadienthoai(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Hotenkhachhang like '%" & k.Hotenkhachhang & "%' and Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo địa chỉ và điện thoại
        Public Function Timkiemdiachivadienthoai(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Diachi like '%" & k.Diachi & "%' and Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng, địa chỉ và điện thoại
        Public Function Timkiemtenkhachhangvadiachivadienthoai(ByVal k As KhachhangDTO) As DataTable
            Dim sql As String = "select * from KHACHHANG where Hotenkhachhang like '%" & k.Hotenkhachhang & "%' and Diachi like '%" & k.Diachi & "%' and Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function

        Public Function Tangma() As String
            Dim sql As String = "Select * From KHACHHANG"
            Dim str As String = dataaccess.str
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
