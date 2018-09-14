﻿Imports DTO.KhachhangDTO
Imports DAL.KhachhangDAL
Imports BUS.KhachhangBUS
Imports DAL.SachDAL
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class QUANLYKHACHHANG
    Dim khachhangbus As New KhachhangBUS
    Dim khachhangdal As New KhachhangDAL
    Dim khachhang As New KhachhangDTO
    'Hiển thị thông tin khách hàng lên datagridview
    Public Sub HienThiThongTinKhachHang()
        sotienno.Text = "0"
        dienthoai.Text = "0"
        Luoi.DataSource = khachhangbus.Taidulieu
    End Sub

    Private Sub QUANLYKHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makhachhang.Text = khachhangdal.Tangma()
        sotienno.Text = "0"
        dienthoai.Text = "0"
        GroupBox1.Enabled = False
        Xoatrang.Enabled = False
        Luu.Enabled = False
        Khongluu.Enabled = False
        Luoi.DataSource = khachhangbus.Taidulieu
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
    'Hàm thêm khách hàng
    Private Function Themkhachhang()
        makhachhang.Text = khachhangdal.Tangma()
        'Kiểm tra tên khách hàng không được để trống
        If hotenkhachhang.Text.Trim = Nothing Then
            MessageBox.Show("Tên khách hàng không được để trống !")
            hotenkhachhang.Focus()
            Return 0
        Else
            khachhang.Hotenkhachhang = hotenkhachhang.Text.Trim()
        End If
        khachhang.Diachi = diachi.Text.Trim
        'Kiểm tra điện thoại phải là số
        Try
            khachhang.Dienthoai = Integer.Parse(dienthoai.Text.Trim)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Điện thoại phải là số !")
            dienthoai.Focus()
            Return 0
        End Try
        khachhang.Makhachhang = makhachhang.Text.Trim
        khachhang.Email = email.Text.Trim
        Dim ketQua As String = khachhangbus.Themkhachhang(khachhang)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Thêm thành công !")
        HienThiThongTinKhachHang()
        hotenkhachhang.Clear()
        dienthoai.Clear()
        diachi.Clear()
        email.Clear()
        makhachhang.Text = khachhangdal.Tangma()
        Return 1
    End Function
    'Hàm xóa khách hàng
    Private Function Xoakhachhang()
        'Xóa khách hàng theo mã khách hàng
        khachhang.Makhachhang = makhachhang.Text
        Dim ketQua As String = khachhangbus.Xoakhachhang(khachhang)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Xóa thành công")
        HienThiThongTinKhachHang()
        Return 1
    End Function
    'Ham sửa khách hàng
    Private Function Suakhachhang()
        'Kiểm tra tên khách hàng không được để trống
        If hotenkhachhang.Text = Nothing Then
            MessageBox.Show("Tên khách hàng không được để trống !")
            hotenkhachhang.Focus()
            Return 0
        Else
            khachhang.Hotenkhachhang = hotenkhachhang.Text.Trim
        End If
        khachhang.Diachi = diachi.Text.Trim
        'Kiểm tra điện thoại phải là số
        Try
            khachhang.Dienthoai = Integer.Parse(dienthoai.Text.Trim)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Điện thoại phải là số !")
            dienthoai.Focus()
            Return 0
        End Try
        khachhang.Makhachhang = makhachhang.Text.Trim
        khachhang.Email = email.Text.Trim
        Dim ketQua As String = khachhangbus.Suakhachhang(khachhang)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Sửa thành công !")
        HienThiThongTinKhachHang()
        Return 1
    End Function

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        GroupBox1.Enabled = True
        GroupBox3.Enabled = False
        Xoa.Enabled = False
        Xoatrang.Enabled = True
        Sua.Enabled = False
        Luu.Enabled = True
        Khongluu.Enabled = True
        hotenkhachhang.Text = ""
        dienthoai.Text = "0"
        diachi.Text = ""
        sotienno.Text = "0"
        email.Text = ""
        makhachhang.Text = khachhangdal.Tangma()
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        If Luoi.RowCount <> Nothing Then
            Xoakhachhang()
        End If
    End Sub

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        GroupBox1.Enabled = True
        Them.Enabled = False
        Xoa.Enabled = False
        Xoatrang.Enabled = True
        Luu.Enabled = True
        Khongluu.Enabled = True
    End Sub
    'Lưu dữ liệu khi thêm khách hàng và sửa khách hàng
    Private Sub Luu_Click(sender As Object, e As EventArgs) Handles Luu.Click
        If Them.Enabled = False Then
            Suakhachhang()
        End If
        If Sua.Enabled = False Then
            Themkhachhang()
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub Khongluu_Click(sender As Object, e As EventArgs) Handles Khongluu.Click
        Them.Enabled = True
        Xoa.Enabled = True
        Xoatrang.Enabled = False
        Sua.Enabled = True
        Luu.Enabled = False
        Khongluu.Enabled = False
        GroupBox1.Enabled = False
        GroupBox3.Enabled = True
    End Sub

    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi.RowEnter
        Dim dong As Integer = e.RowIndex
        hotenkhachhang.DataBindings.Clear()
        hotenkhachhang.DataBindings.Add("Text", Luoi.DataSource, "Hotenkhachhang")
        dienthoai.DataBindings.Clear()
        dienthoai.DataBindings.Add("Text", Luoi.DataSource, "Dienthoai")
        diachi.DataBindings.Clear()
        diachi.DataBindings.Add("Text", Luoi.DataSource, "Diachi")
        sotienno.DataBindings.Clear()
        sotienno.DataBindings.Add("Text", Luoi.DataSource, "Sotienno")
        makhachhang.DataBindings.Clear()
        makhachhang.DataBindings.Add("Text", Luoi.DataSource, "Makhachhang")
        email.DataBindings.Clear()
        email.DataBindings.Add("Text", Luoi.DataSource, "Email")
    End Sub

    Private Sub Xoatrang_Click(sender As Object, e As EventArgs) Handles Xoatrang.Click
        hotenkhachhang.Clear()
        diachi.Clear()
        dienthoai.Clear()
        email.Clear()
    End Sub
    'Tra cứu khách hàng theo tên khách hàng
    Private Sub tracuu_Click(sender As Object, e As EventArgs) Handles tracuu.Click
        khachhang.Hotenkhachhang = tracuutenkhachhang.Text.Trim
        Luoi.DataSource = khachhangbus.Timkiemtenkhachhang(khachhang)
    End Sub

    Private Sub chon_Click(sender As Object, e As EventArgs) Handles chon.Click
        Close()
    End Sub

    Private Sub HIENTHI_Click(sender As Object, e As EventArgs) Handles HIENTHI.Click
        HienThiThongTinKhachHang()
    End Sub
    'Tải dữ liệu khách hàng từ file excel
    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        Dim oldPath As String = Directory.GetCurrentDirectory()
        OpenFileDialog1 = New OpenFileDialog()
        If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Dim strPathName As String = OpenFileDialog1.FileName
            Directory.SetCurrentDirectory(oldPath)
            Dim excelapp As Excel.Application = New Excel.Application
            Dim excelworkbook As Excel.Workbook = excelapp.Workbooks.Open(OpenFileDialog1.FileName)
            Dim sheet As Excel.Worksheet = excelworkbook.Sheets(1)
            Dim range As Excel.Range = sheet.UsedRange
            Dim row As Integer = range.Rows.Count
            For i As Integer = 1 To row
                khachhang.Makhachhang = khachhangdal.Tangma()
                khachhang.Hotenkhachhang = range.Cells(i, 1).Value.ToString
                khachhang.Diachi = range.Cells(i, 2).Value.ToString
                khachhang.Dienthoai = range.Cells(i, 3).Value.ToString
                khachhang.Email = range.Cells(i, 4).Value.ToString
                khachhang.Sotienno = range.Cells(i, 5).Value.ToString
                khachhangbus.Themkhachhang(khachhang)
            Next
        End If
        HienThiThongTinKhachHang()
        MessageBox.Show("Import dữ liệu thành công ... ! ")
    End Sub
End Class