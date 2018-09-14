Imports DTO.ChitiethoadonDTO
Imports DTO.HoadonDTO
Imports System.Data.SqlClient
Imports DAL.data
Namespace HoadonDAL
    Public Class HoadonDAL
        Dim dataaccess As New DataAccess
        'Hiển thị hóa đơn
        Public Function Hienthihoadon() As DataTable
            Dim sql As String = "select HOADON.*,KHACHHANG.Hotenkhachhang from HOADON,KHACHHANG,NHANVIEN where HOADON.Makhachhang= KHACHHANG.Makhachhang and HOADON.Manhanvienlap = NHANVIEN.Manhanvien"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Hiển thị chi tiết hóa đơn
        Public Function Hienthichitiethoadon(ByVal cthd As ChitiethoadonDTO) As DataTable
            Dim sql As String = "select CHITIETHOADON.*,SACH.Tensach from CHITIETHOADON,SACH where Mahoadon = '" & cthd.Mahoadon.Trim & "' and CHITIETHOADON.Masach=SACH.Masach"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Thêm hóa đơn
        Public Function Themhoadon(ByVal hd As HoadonDTO) As String
            Dim sql As String = "insert into HOADON(Mahoadon,Makhachhang,Ngaylaphoadon,Tongthanhtien,Manhanvienlap) values('" & hd.Mahoadon.Trim & "','" & hd.Makhachhang.Trim & "','" & hd.Ngaylaphoadon & "','" & hd.Tongthanhtien & "','" & hd.Manhanvienlap.Trim & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Thêm chi tiết hóa đơn
        Public Function Themchitiethoadon(ByVal cthd As ChitiethoadonDTO) As String
            Dim sql As String = "insert into CHITIETHOADON(Machitiethoadon,Mahoadon,Masach,Soluongban,Dongiaban) values('" & cthd.Machitiethoadon.Trim & "','" & cthd.Mahoadon.Trim & "','" & cthd.Masach.Trim & "','" & cthd.Soluongban & "','" & cthd.Dongiaban & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Cập nhật tổng thành tiền
        Public Function Capnhattongthanhtien(ByVal hd As HoadonDTO) As String
            Dim sql As String = "update HOADON set Tongthanhtien='" & hd.Tongthanhtien & "' where Mahoadon = '" & hd.Mahoadon.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Tìm hóa đơn theo mã hóa đơn và mã sách
        Public Function Timhoadon(ByVal cthd As ChitiethoadonDTO) As String
            Dim sql As String = "select * from CHITIETHOADON where Mahoadon = '" + cthd.Mahoadon.Trim + "' AND Masach ='" + cthd.Masach.Trim + "'"
            Dim dt As DataTable = dataaccess.Taidulieu(sql)
            If dt.Rows.Count = 0 Then
                Return Nothing
            End If
            Return 1
        End Function
        'Tìm hóa đơn theo mã hóa đơn
        Public Function Timhoadontheoma(ByVal hd As HoadonDTO) As DataTable
            Dim sql As String = "select * from HOADON where Mahoadon = '" & hd.Mahoadon.Trim & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm hóa đơn theo mã nhân viên lập hóa đơn
        Public Function Timhoadontheomanhanvien(ByVal hd As HoadonDTO) As DataTable
            Dim sql As String = "select * from HOADON where Manhanvienlap = '" & hd.MaNhanVienLap.Trim & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm chi tiết hóa đơn
        Public Function Timchitiethoadon(ByVal cthd As ChitiethoadonDTO) As DataTable
            Dim sql As String = "select * from CHITIETHOADON where Mahoadon = '" & cthd.Mahoadon & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tính tổng số lượng bán
        Public Function Tongsoluongban(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer) As DataTable
            Dim sql As String = "select SUM(CHITIETHOADON.Soluongban) from CHITIETHOADON,HOADON where Masach = '" & masach & "' and MONTH(HOADON.NgayLapHoaDon)= '" & thang & "' and YEAR(HOADON.NgayLapHoaDon)='" & nam & "' and CHITIETHOADON.MaHoaDon =HOADON.MaHoaDon group by CHITIETHOADON.MaSach "
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tính tổng thành tiền
        Public Function Tongthanhtien(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer) As DataTable
            Dim sql As String = "select SUM(HOADON.Tongthanhtien) from HOADON where Makhachhang = '" & makhachhang & "' and MONTH(HOADON.Ngaylaphoadon)='" & thang & "' and YEAR(HOADON.Ngaylaphoadon) ='" & nam & "' group by HOADON.makhachhang"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tìm hóa đơn theo tháng và năm
        Public Function Timhoadontheothangvanam(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer) As DataTable
            Dim sql As String = "select * from HOADON where Makhachhang='" & makhachhang & "' and MONTH(HOADON.Ngaylaphoadon)='" & thang & "' and YEAR(HOADON.Ngaylaphoadon) ='" & nam & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Xóa hóa đơn
        Public Function Xoahoadon(ByVal hd As HoadonDTO) As String
            Dim sql As String = "delete from HOADON where Mahoadon = '" & hd.Mahoadon & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa chi tiết hóa đơn
        Public Function Xoachitiethoadon(ByVal cthd As ChitiethoadonDTO) As String
            Dim sql As String = "delete from CHITIETHOADON where Mahoadon = '" & cthd.Mahoadon & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa chi tiết hóa đơn theo mã sách
        Public Function Xoachitiethoadontheomasach(ByVal cthd As ChitiethoadonDTO) As String
            Dim sql As String = "delete from CHITIETHOADON where Mahoadon = '" & cthd.Mahoadon & "' and Masach ='" & cthd.Masach & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Tangmahd() As String
            Dim sql As String = "Select * From HOADON"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "HD001"
            Else
                Dim k As Integer
                ma = "HD"
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

        Public Function Tangmacthd() As String
            Dim sql As String = "Select * From CHITIETHOADON"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "CH001"
            Else
                Dim k As Integer
                ma = "CH"
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

