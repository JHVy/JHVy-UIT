Imports System.Data.SqlClient
Imports DTO.PhieuNhapDTO
Imports DTO.ChitietphieunhapDTO
Imports DAL.data
Namespace PhieuNhapDaL

        Public Class PhieuNhapDAL
        Dim dataaccess As New DataAccess
        'Hiển thị thông tin phiếu nhập
        Public Function Hienthithongtinphieunhap() As DataTable
            Dim sql As String = "select * from PHIEUNHAP"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Hiển thị chi tiết phiếu nhập
        Public Function Hienthichitietphieunhap(ByVal ctpn As ChitietphieunhapDTO) As DataTable
            Dim sql As String = "select CHITIETPHIEUNHAP.*,SACH.Tensach from CHITIETPHIEUNHAP,SACH where Maphieunhap = '" + ctpn.Maphieunhap.Trim + "' and CHITIETPHIEUNHAP.Masach = SACH.Masach "
            Return dataaccess.Taidulieu(sql)
        End Function
        'Thêm phiếu nhập
        Public Function Themphieunhap(ByVal pn As PhieuNhapDTO) As String
            Dim sql As String = "insert into PHIEUNHAP(Maphieunhap,Ngaynhap) values('" & pn.Maphieunhap.Trim & "','" & pn.Ngaynhap & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Thêm chi tiết phiếu nhập
        Public Function Themchitietphieunhap(ByVal ctpn As ChitietphieunhapDTO) As String
            Dim sql As String = "insert into CHITIETPHIEUNHAP(Machitietphieunhap,Maphieunhap,Masach,Soluongnhap) values('" & ctpn.Machitiet.Trim & "',N'" & ctpn.Maphieunhap.Trim & "',N'" & ctpn.Masach.Trim & "','" & ctpn.Soluongnhap.Trim & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Tim phiếu nhập theo mã phiếu nhập và mã sách
        Public Function Timphieunhap(ByVal ctpn As ChitietphieunhapDTO) As String
            Dim sql As String = "select * from CHITIETPHIEUNHAP where Maphieunhap = '" + ctpn.Maphieunhap.Trim + "' AND Masach ='" + ctpn.Masach.Trim + "'"
            Dim dt As DataTable = dataaccess.Taidulieu(sql)
            If dt.Rows.Count = 0 Then
                Return Nothing
            End If
            Return 1
        End Function
        'tìm phiếu nhập theo mã phiếu nhập
        Public Function Timphieunhap1(ByVal ctpn As ChitietphieunhapDTO) As DataTable
            Dim sql As String = "select * from CHITIETPHIEUNHAP where Maphieunhap ='" & ctpn.Maphieunhap & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'tìm phiếu nhập theo tháng và năm
        Public Function timphieunhaptheothangvanam(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer) As DataTable
            Dim sql As String = "select * from CHITIETPHIEUNHAP,PHIEUNHAP where Masach='" & masach & "' and MONTH(PHIEUNHAP.Ngaynhap)='" & thang & "' and YEAR(PHIEUNHAP.Ngaynhap) ='" & nam & "' and CHITIETPHIEUNHAP.Maphieunhap= PHIEUNHAP.Maphieunhap"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Tính tổng lượng nhập theo sách
        Public Function Tongluongnhaptheosach(ByVal masach As String, ByVal thang As String, ByVal nam As String) As DataTable
            Dim sql As String = "SElECT SUM(Soluongnhap) from CHITIETPHIEUNHAP,PHIEUNHAP where Masach = '" & masach & "' and MONTH(PHIEUNHAP.Ngaynhap)='" & thang & "' and YEAR(PHIEUNHAP.Ngaynhap)='" & nam & "' and CHITIETPHIEUNHAP.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap group by CHITIETPHIEUNHAP.Masach"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Xóa phiếu nhập
        Public Function Xoaphieunhap(ByVal pn As PhieuNhapDTO) As String
            Dim sql As String = "Delete from PHIEUNHAP where MAphieunhap='" & pn.Maphieunhap & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa chi tiết phiếu nhập
        Public Function Xoachitietphieunhap(ByVal ctpn As ChitietphieunhapDTO) As String
            Dim sql As String = "Delete from CHITIETPHIEUNHAP where Maphieunhap='" & ctpn.Maphieunhap & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Xóa chi tiết phiếu nhập theo mã sách
        Public Function Xoachitietphieunaptheomasach(ByVal ctpn As ChitietphieunhapDTO) As String
            Dim sql As String = "delete from CHITIETPHIEUNHAP where Maphieunhap='" & ctpn.Maphieunhap & "' and Masach = '" & ctpn.Masach & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Tangmapn() As String
            Dim sql As String = "Select * From PHIEUNHAP"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "PN001"
            Else
                Dim k As Integer
                ma = "PN"
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

        Public Function Tangmactpn() As String
            Dim sql As String = "Select * From CHITIETPHIEUNHAP"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "CP001"
            Else
                Dim k As Integer
                ma = "CP"
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

