Imports DTO.PhieuthuDTO
Imports DTO.KhachhangDTO
Imports BUS.PhieuthuBUS
Imports BUS.ThamsoBUS
Imports BUS.KhachhangBUS
Imports DAL.PhieuthuDAL
Public Class PHIEUTHUTIEN
    Dim phieuthubus As New PhieuthuBUS
    Dim phieuthu As New PhieuthuDTO
    Dim khachhang As New KhachhangDTO
    Dim phieuthudal As New PhieuthuDAL
    Dim khachhangbus As New KhachhangBUS
    Dim thamsobus As New ThamsoBUS
    Dim ktqd4 As Integer
    Dim sotienno As Single
    Dim Tienthu As Single
    Dim tiennomoi As Single
    Dim tienthucu As Single
    Dim tienthumoi As Single
    'Hiển thị thông tin phiếu thu lên datagridview
    Public Sub Hienthiphieuthu()
        Luoi.DataSource = phieuthubus.Taidulieuphieuthu()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

    Private Sub PHIEUTHUTIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maphieuthu.Text = phieuthudal.Tangmapt
        sotienthu.Text = "0"
        GroupBox1.Enabled = False
        Luu.Enabled = False
        Khongluu.Enabled = False
        Xoatrang.Enabled = False
        Ngay.Value = DateTime.Now
        Hienthiphieuthu()
    End Sub
    'Hàm thêm phiếu thu
    Public Function Themphieuthu()
        'Tải dữ liệu tham số
        Dim dtts As DataTable = thamsobus.Taithamso()
        ktqd4 = Integer.Parse(dtts.Rows(0).Item(5).ToString())
        'Lấy số tiền nợ của khách hàng
        khachhang.Makhachhang = makhachhang.Text.Trim
        Dim dskh As DataTable = khachhangbus.Timkiemtheomakhachhang(khachhang)
        sotienno = Single.Parse(dskh.Rows(0).Item(5).ToString())
        Tienthu = Single.Parse(sotienthu.Text.Trim)
        maphieuthu.Text = phieuthudal.Tangmapt()
        'lấy dữ liệu cho phiếu thu Mã phiếu thu , mã khách hàng, ngày thu tiền , số tiền thu 
        'Kiểm tra mã khách hàng không được để trống
        If makhachhang.Text.Trim = Nothing Then
            MessageBox.Show("Mã khách hàng không được để trống")
            Return 0
        Else
            phieuthu.Makhachhang = makhachhang.Text.Trim()
        End If
        phieuthu.Maphieuthu = maphieuthu.Text
        Ngay.Format = DateTimePickerFormat.Custom
        Ngay.CustomFormat = "MM/dd/yy"
        phieuthu.Ngaythutien = Ngay.Text
        Ngay.Format = DateTimePickerFormat.Short
        'Kiểm tra số tiền thu phải là số
        Try
            phieuthu.Sotienthu = Single.Parse(sotienthu.Text.Trim)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Số tiền thu phải là số")
            Return 0
        End Try
        'kiểm tra quy định số tiền thu có lớn hơn số tiền khách hàng đang nợ
        If ktqd4 = 1 Then
            If sotienno < Tienthu Then
                MessageBox.Show("Số tiền thu lớn hơn số tiền khách hàng đang nợ")
                Return 0
            End If
        End If
        'Tính tiền nợ mới
        tiennomoi = sotienno - Tienthu
        Dim dt As DataTable = phieuthubus.Timkiemmakhachhangtheongay(phieuthu)
        If dt.Rows.Count = 0 Then
            Dim ketQua As String = phieuthubus.Themphieuthu(phieuthu)
            If (ketQua <> "Success") Then
                MessageBox.Show(ketQua)
                Return 0
            Else
                'Cập nhật số tiền nợ
                khachhang.Makhachhang = makhachhang.Text.Trim
                khachhang.Sotienno = Single.Parse(tiennomoi)
                khachhangbus.Capnhatsotienno(khachhang)
                MessageBox.Show("Thêm thành công")
                Hienthiphieuthu()
                sotienthu.Clear()
                maphieuthu.Text = phieuthudal.Tangmapt()
            End If
        Else
            MessageBox.Show("Đã thu tiền khách hàng trong hôm nay")
        End If
        Return 1
    End Function
    'Hàm Sửa phiếu thu
    Public Function Suaphieuthu()
        khachhang.Makhachhang = makhachhang.Text.Trim
        'lấy dữ liệu cho phiếu thu Mã phiếu thu , mã khách hàng, ngày thu tiền , số tiền thu 
        'Kiểm tra mã khách hàng không được để trống
        If makhachhang.Text.Trim = Nothing Then
            MessageBox.Show("Mã khách hàng không được để trống")
            Return 0
        Else
            phieuthu.Makhachhang = makhachhang.Text.Trim()
        End If
        phieuthu.Maphieuthu = maphieuthu.Text.Trim
        Ngay.Format = DateTimePickerFormat.Custom
        Ngay.CustomFormat = "MM/dd/yy"
        phieuthu.Ngaythutien = Ngay.Text
        Ngay.Format = DateTimePickerFormat.Short
        'Kiểm tra số tiền thu phải là số
        Try
            phieuthu.Sotienthu = sotienthu.Text.Trim
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Số tiền thu phải là số")
            Return 0
        End Try
        'kiểm tra quy định số tiền thu có lớn hơn số tiền khách hàng đang nợ
        Dim dtts As DataTable = thamsobus.Taithamso
        ktqd4 = Integer.Parse(dtts.Rows(0).Item(5).ToString)
        Dim dskh As DataTable = khachhangbus.Timkiemtheomakhachhang(khachhang)
        sotienno = Single.Parse(dskh.Rows(0).Item(5).ToString())
        Tienthu = Single.Parse(sotienthu.Text.Trim)
        If ktqd4 = 1 Then
            If sotienno < Tienthu Then
                MessageBox.Show("Số tiền thu lớn hơn số tiền khách hàng đang nợ")
                Return 0
            End If
        End If
        'Tính tiền nợ mới
        tienthumoi = Tienthu - tienthucu
        tiennomoi = sotienno - tienthumoi
        Dim ketqua As String = phieuthubus.Suaphieuthu(phieuthu)
        If (ketqua <> "Success") Then
            MessageBox.Show(ketqua)
            Return 0
        Else
            'Cập nhật lại số tiền nợ
            khachhang.Makhachhang = makhachhang.Text.Trim
            khachhang.Sotienno = Single.Parse(tiennomoi)
            khachhangbus.Capnhatsotienno(khachhang)
            MessageBox.Show("Sửa thành công")
            Hienthiphieuthu()
        End If
        Return 1
    End Function
    'Hàm xóa phiếu thu
    Public Function Xoaphieuthu()
        'lấy dữ liệu cho phiếu thu Mã phiếu thu , mã khách hàng, ngày thu tiền , số tiền thu 
        khachhang.Makhachhang = makhachhang.Text.Trim
        phieuthu.Maphieuthu = maphieuthu.Text.Trim
        Dim dskh As DataTable = khachhangbus.Timkiemtheomakhachhang(khachhang)
        sotienno = Single.Parse(dskh.Rows(0).Item(5).ToString())
        'Tính tiền nợ mới
        Tienthu = 0
        tienthumoi = Tienthu - tienthucu
        tiennomoi = sotienno - tienthumoi
        Dim ketqua As String = phieuthubus.Xoaphieuthu(phieuthu)
        If (ketqua <> "Success") Then
            MessageBox.Show(ketqua)
            Return 0
        Else
            'Cập nhật lại số tiền nợ
            khachhang.Makhachhang = makhachhang.Text.Trim
            khachhang.Sotienno = Single.Parse(tiennomoi)
            khachhangbus.Capnhatsotienno(khachhang)
            MessageBox.Show("Sửa thành công")
            Hienthiphieuthu()
        End If
        Return 1
    End Function
    'Lấy mã khách hàng từ form QUANLYKHACHHANG
    Private Sub Chon_Click(sender As Object, e As EventArgs) Handles Chon.Click
        Dim f As New QUANLYKHACHHANG
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            makhachhang.Text = f.makhachhang.Text
        End If
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        GroupBox1.Enabled = True
        GroupBox3.Enabled = False
        Xoa.Enabled = False
        Xoatrang.Enabled = True
        Sua.Enabled = False
        Luu.Enabled = True
        Khongluu.Enabled = True
        sotienthu.Text = "0"
        maphieuthu.Text = phieuthudal.Tangmapt()
    End Sub

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        GroupBox1.Enabled = True
        Them.Enabled = False
        Xoa.Enabled = False
        Xoatrang.Enabled = True
        Luu.Enabled = True
        Khongluu.Enabled = True
    End Sub

    Private Sub Xoatrang_Click(sender As Object, e As EventArgs) Handles Xoatrang.Click
        sotienthu.Clear()
        makhachhang.Clear()
    End Sub

    Private Sub HIENTHI_Click(sender As Object, e As EventArgs) Handles HIENTHI.Click
        Hienthiphieuthu()
    End Sub

    Private Sub Khongluu_Click(sender As Object, e As EventArgs) Handles Khongluu.Click
        Them.Enabled = True
        Xoatrang.Enabled = True
        Xoa.Enabled = True
        Sua.Enabled = True
        Luu.Enabled = False
        Khongluu.Enabled = False
        GroupBox1.Enabled = False
        GroupBox3.Enabled = True
    End Sub
    'Lưu dữ liệu khi thêm phiêu thu và sửa phiếu thu
    Private Sub Luu_Click(sender As Object, e As EventArgs) Handles Luu.Click
        If Them.Enabled = False Then
            Suaphieuthu()
        End If
        If Sua.Enabled = False Then
            Themphieuthu()
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi.RowEnter
        Dim dong As Integer = e.RowIndex
        maphieuthu.DataBindings.Clear()
        maphieuthu.DataBindings.Add("Text", Luoi.DataSource, "Maphieuthu")
        makhachhang.DataBindings.Clear()
        makhachhang.DataBindings.Add("Text", Luoi.DataSource, "Makhachhang")
        Ngay.DataBindings.Clear()
        Ngay.DataBindings.Add("Text", Luoi.DataSource, "Ngaythutien")
        sotienthu.DataBindings.Clear()
        sotienthu.DataBindings.Add("Text", Luoi.DataSource, "Sotienthu")
        tienthucu = Single.Parse(Luoi.Rows(dong).Cells(1).Value.ToString())
    End Sub
    'Tra cứu phiếu thu theo mã khách hàng
    Private Sub tracuu_Click(sender As Object, e As EventArgs) Handles tracuu.Click
        phieuthu.Makhachhang = tracuukhachhang.Text.Trim
        Luoi.DataSource = phieuthubus.Timkiemmakhachhang(phieuthu)
    End Sub
    'Xóa phiếu thu
    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        If Luoi.RowCount <> Nothing Then
            Xoaphieuthu()
        End If
    End Sub
End Class