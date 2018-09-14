Imports DTO.NhanvienDTO
Imports DAL.NhanvienDAL
Imports BUS.NhanvienBUS
'Imports DAL.SachDAL
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class QUANLYNHANVIEN

    Dim nhanvienbus As New NhanvienBUS
    Dim nhanviendal As New NhanvienDAL
    Dim nhanvien As New NhanvienDTO
    '
    Public Sub HienThiThongTinNhanVien()
        tienluong.Text = "0"
        dienthoai.Text = "0"
        Luoi.DataSource = nhanvienbus.Taidulieu
    End Sub

    Private Sub QUANLYNHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        manhanvien.Text = nhanviendal.Tangma()
        tienluong.Text = "0"
        dienthoai.Text = "0"
        GroupBox1.Enabled = False
        Xoatrang.Enabled = False
        Luu.Enabled = False
        Khongluu.Enabled = False
        Luoi.DataSource = nhanvienbus.Taidulieu
    End Sub
    'Thoát form quan li nhan vien
    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
    'Thêm nhân viên
    Private Function Themnhanvien()
        manhanvien.Text = nhanviendal.Tangma()
        'Kiểm tra tên nhân viên không được để trống
        If hotennhanvien.Text.Trim = Nothing Then
            MessageBox.Show("Tên nhân viên không được để trống !")
            hotennhanvien.Focus()
            Return 0
        Else
            nhanvien.Hotennhanvien = hotennhanvien.Text.Trim()
        End If
        nhanvien.Diachi = diachi.Text.Trim
        'Kiểm tra điện thoại phải là số
        Try
            nhanvien.Dienthoai = Integer.Parse(dienthoai.Text.Trim)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Điện thoại phải là số !")
            dienthoai.Focus()
            Return 0
        End Try
        nhanvien.Manhanvien = manhanvien.Text.Trim
        nhanvien.Email = email.Text.Trim
        Dim ketQua As String = nhanvienbus.Themnhanvien(nhanvien)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Thêm thành công !")
        HienThiThongTinNhanVien()
        hotennhanvien.Clear()
        dienthoai.Clear()
        diachi.Clear()
        email.Clear()
        manhanvien.Text = nhanviendal.Tangma()
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
        hotennhanvien.Text = ""
        dienthoai.Text = "0"
        diachi.Text = ""
        tienluong.Text = "0"
        email.Text = ""
        manhanvien.Text = nhanviendal.Tangma()
    End Sub
    'xóa nhân viên
    Private Function Xoanhanvien()
        'Xóa nhân viên theo mã nhân viên
        nhanvien.Manhanvien = manhanvien.Text
        Dim ketQua As String = nhanvienbus.Xoanhanvien(nhanvien)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Xóa thành công !")
        HienThiThongTinNhanVien()
        Return 1
    End Function

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        If Luoi.RowCount <> Nothing Then
            Xoanhanvien()
        End If
    End Sub
    'cập nhật thông tin nhân viên
    Private Function Suanhanvien()
        'Kiểm tra tên khách hàng không được để trống
        If hotennhanvien.Text = Nothing Then
            MessageBox.Show("Tên khách hàng không được để trống !")
            hotennhanvien.Focus()
            Return 0
        Else
            nhanvien.Hotennhanvien = hotennhanvien.Text.Trim
        End If
        nhanvien.Diachi = diachi.Text.Trim
        'Kiểm tra điện thoại phải là số
        Try
            nhanvien.Dienthoai = Integer.Parse(dienthoai.Text.Trim)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Điện thoại phải là số !")
            dienthoai.Focus()
            Return 0
        End Try
        nhanvien.Manhanvien = manhanvien.Text.Trim
        nhanvien.Email = email.Text.Trim
        Dim ketQua As String = nhanvienbus.Suanhanvien(nhanvien)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Sửa thành công !")
        HienThiThongTinNhanVien()
        Return 1
    End Function

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        GroupBox1.Enabled = True
        Them.Enabled = False
        Xoa.Enabled = False
        Xoatrang.Enabled = True
        Luu.Enabled = True
        Khongluu.Enabled = True
    End Sub

    Private Sub Luu_Click(sender As Object, e As EventArgs) Handles Luu.Click
        If Them.Enabled = False Then
            Suanhanvien()
        End If
        If Sua.Enabled = False Then
            Themnhanvien()
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
        hotennhanvien.DataBindings.Clear()
        hotennhanvien.DataBindings.Add("Text", Luoi.DataSource, "Hotennhanvien")
        dienthoai.DataBindings.Clear()
        dienthoai.DataBindings.Add("Text", Luoi.DataSource, "Dienthoai")
        diachi.DataBindings.Clear()
        diachi.DataBindings.Add("Text", Luoi.DataSource, "Diachi")
        tienluong.DataBindings.Clear()
        tienluong.DataBindings.Add("Text", Luoi.DataSource, "Tienluong")
        manhanvien.DataBindings.Clear()
        manhanvien.DataBindings.Add("Text", Luoi.DataSource, "Manhanvien")
        email.DataBindings.Clear()
        email.DataBindings.Add("Text", Luoi.DataSource, "Email")
    End Sub

    Private Sub Xoatrang_Click(sender As Object, e As EventArgs) Handles Xoatrang.Click
        hotennhanvien.Clear()
        diachi.Clear()
        dienthoai.Clear()
        email.Clear()
    End Sub

    Private Sub tracuu_Click(sender As Object, e As EventArgs) Handles tracuu.Click
        nhanvien.Hotennhanvien = tracuutennhanvien.Text.Trim
        Luoi.DataSource = nhanvienbus.Timkiemtennhanvien(nhanvien)
    End Sub

    Private Sub chon_Click(sender As Object, e As EventArgs) Handles chon.Click
        Close()
    End Sub

    Private Sub HIENTHI_Click(sender As Object, e As EventArgs) Handles HIENTHI.Click
        HienThiThongTinNhanVien()
    End Sub

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
                nhanvien.Manhanvien = nhanviendal.Tangma()
                nhanvien.Hotennhanvien = range.Cells(i, 1).Value.ToString
                nhanvien.Diachi = range.Cells(i, 2).Value.ToString
                nhanvien.Dienthoai = range.Cells(i, 3).Value.ToString
                nhanvien.Email = range.Cells(i, 4).Value.ToString
                nhanvien.Tienluong = range.Cells(i, 5).Value.ToString
                nhanvienbus.Themnhanvien(nhanvien)
            Next
        End If
        HienThiThongTinNhanVien()
        MessageBox.Show("Import dữ liệu thành công ...!")
    End Sub
End Class