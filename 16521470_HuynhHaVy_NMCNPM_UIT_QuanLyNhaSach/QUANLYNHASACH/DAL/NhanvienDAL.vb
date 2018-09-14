Imports DTO.NhanvienDTO
Imports System.Data.SqlClient
Imports DAL.data

Namespace NhanvienDAL

    Public Class NhanvienDAL

        Dim dataaccess As New DataAccess
        'Hiển thị dữ liệu nhân viên
        Public Function Taidulieu() As DataTable
            Return dataaccess.Taidulieu("Select * From NHANVIEN")
        End Function
        'Thêm nhân viên
        Public Function Them(ByVal K As NhanvienDTO) As String
            Dim sql As String = "INSERT INTO NHANVIEN(Manhanvien, Hotennhanvien, Diachi, Dienthoai, Email, Tienluong) VALUES('" & K.Manhanvien.Trim & "',N'" & K.Hotennhanvien.Trim & "',N'" & K.Diachi.Trim & "','" & K.Dienthoai & "',N'" & K.Email & "','" & K.Tienluong & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa nhân viên
        Public Function Xoa(ByVal K As NhanvienDTO) As String
            Dim sql As String = "delete from NHANVIEN where Manhanvien='" + K.Manhanvien.Trim + "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Sửa nhân viên
        Public Function Sua(ByVal K As NhanvienDTO) As String
            Dim sql As String = "update NHANVIEN set Diachi=N'" & K.Diachi.Trim & "',Hotennhanvien=N'" & K.Hotennhanvien.Trim & "',Dienthoai='" & K.Dienthoai.Trim & "',Email=N'" & K.Email.Trim & "' where Manhanvien='" & K.Manhanvien.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Cập nhật tiền lương
        Public Function Capnhattienluong(ByVal K As NhanvienDTO) As String
            Dim sql As String = "update KNHANVIEN set Tienluong='" & K.Tienluong & "' where Manhanvien='" & K.Manhanvien.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Tìm kiếm nhan vien theo ma nhan vien
        Public Function Timkiemtheomanhanvien(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Manhanvien ='" & k.Manhanvien & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Lấy mã nhân viên từ bảng NHANVIEN
        Public Function Timkiemmanhanvien() As DataTable
            Dim sql As String = " select Manhanvien from NHANVIEN"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên  
        Public Function Timkiemtennhanvien(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Hotennhanvien like '%" & k.Hotennhanvien & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo địa chỉ
        Public Function Timkiemdiachi(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Diachi like '%" & k.Diachi & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo điện thoại
        Public Function Timkiemdienthoai(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên và địa chỉ
        Public Function Timkiemtennhanvienvadiachi(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Hotennhanvien like '%" & k.Hotennhanvien & "%' and Diachi like '%" & k.Diachi & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên và điện thoại
        Public Function Timkiemtennhanvienvadienthoai(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Hotennhanvien like '%" & k.Hotennhanvien & "%' and Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo địa chỉ và điện thoại
        Public Function Timkiemdiachivadienthoai(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Diachi like '%" & k.Diachi & "%' and Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên, địa chỉ và điện thoại
        Public Function Timkiemtennhanvienvadiachivadienthoai(ByVal k As NhanvienDTO) As DataTable
            Dim sql As String = "select * from NHANVIEN where Hotennhanvien like '%" & k.Hotennhanvien & "%' and Diachi like '%" & k.Diachi & "%' and Dienthoai like '%" & k.Dienthoai & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function

        Public Function Tangma() As String
            Dim sql As String = "Select * From NHANVIEN"
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
