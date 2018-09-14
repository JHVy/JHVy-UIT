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

    Public Function Themphieuthu()
        Dim dtts As DataTable = thamsobus.Taithamso()
        ktqd4 = Integer.Parse(dtts.Rows(0).Item(5).ToString())
        khachhang.Makhachhang = makhachhang.Text.Trim
        Dim dskh As DataTable = khachhangbus.Timkiemtheomakhachhang(khachhang)
        sotienno = Single.Parse(dskh.Rows(0).Item(5).ToString())
        Tienthu = Single.Parse(sotienthu.Text.Trim)
        maphieuthu.Text = phieuthudal.Tangmapt()
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
        Try
            phieuthu.Sotienthu = Single.Parse(sotienthu.Text.Trim)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Số tiền thu phải là số")
            Return 0
        End Try
        If ktqd4 = 1 Then
            If sotienno < Tienthu Then
                MessageBox.Show("Số tiền thu lớn hơn số tiền khách hàng đang nợ")
                Return 0
            End If
        End If
        tiennomoi = sotienno - Tienthu
        Dim ketQua As String = phieuthubus.Themphieuthu(phieuthu)
        If (ketQua <> "Success") Then
            MessageBox.Show(ketQua)
            Return 0
        Else
            khachhang.Makhachhang = makhachhang.Text.Trim
            khachhang.Sotienno = Single.Parse(tiennomoi)
            khachhangbus.Capnhatsotienno(khachhang)
            MessageBox.Show("Thêm thành công")
            Hienthiphieuthu()
            sotienthu.Clear()
            maphieuthu.Text = phieuthudal.Tangmapt()
        End If
        Return 1
    End Function

    Public Function Suaphieuthu()
        khachhang.Makhachhang = makhachhang.Text.Trim
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

        Try
            phieuthu.Sotienthu = sotienthu.Text.Trim
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Số tiền thu phải là số")
            Return 0
        End Try
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
        tienthumoi = Tienthu - tienthucu
        tiennomoi = sotienno - tienthumoi
        Dim ketqua As String = phieuthubus.Suaphieuthu(phieuthu)
        If (ketqua <> "Success") Then
            MessageBox.Show(ketqua)
            Return 0
        Else
            khachhang.Makhachhang = makhachhang.Text.Trim
            khachhang.Sotienno = Single.Parse(tiennomoi)
            khachhangbus.Capnhatsotienno(khachhang)
            MessageBox.Show("Sửa thành công")
            Hienthiphieuthu()
        End If
        Return 1
    End Function

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

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        phieuthu.Maphieuthu = maphieuthu.Text
        Dim ketQua As String = phieuthubus.Xoaphieuthu(phieuthu)
        If (ketQua <> "Success") Then
            MessageBox.Show(ketQua)
            Return
        End If
        MessageBox.Show("Xóa thành công")
        Hienthiphieuthu()
    End Sub

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        GroupBox1.Enabled = True
        Them.Enabled = False
        Xoa.Enabled = False
        Xoa.Enabled = True
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
        Xoa.Enabled = True
        Xoatrang.Enabled = True
        Sua.Enabled = True
        Luu.Enabled = False
        Khongluu.Enabled = False
        GroupBox1.Enabled = False
        GroupBox3.Enabled = True
    End Sub

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

    Private Sub tracuu_Click(sender As Object, e As EventArgs) Handles tracuu.Click
        phieuthu.Makhachhang = tracuukhachhang.Text.Trim
        Luoi.DataSource = phieuthudal.Timkiemmakhachhang(phieuthu)
    End Sub
End Class