Imports DTO.SachDTO
Imports BUS.SachBUS
Imports DAL.SachDAL
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class QUANLYSACH

    Dim sach As New SachDTO
    Dim sachdal As New SachDAL
    Dim sachbus As New SachBUS
    'Hiển thị thông tin sách lên datagridview
    Public Sub HienThiThongTinSach()
        soluongton.Text = "0"
        Luoi.DataSource = sachbus.Taidulieu
    End Sub

    Private Sub QUANLYSACH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        masach.Text = sachdal.Tangma()
        soluongton.Text = "0"
        GroupBox1.Enabled = False
        Luu.Enabled = False
        Khongluu.Enabled = False
        Xoatrang.Enabled = False
        Luoi.DataSource = sachbus.Taidulieu
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
    'Hàm thêm sách
    Private Function Themsach()
        masach.Text = sachdal.Tangma()
        'Kiểm tra tên sách không được để trống
        If tensach.Text.Trim = Nothing Then
            MessageBox.Show("Tên sách không được để trống")
            tensach.Focus()
            Return 0
        Else
            sach.Tensach = tensach.Text.Trim()
        End If
        sach.Tacgia = tacgia.Text.Trim()
        sach.Theloai = theloai.Text.Trim()
        sach.Masach = masach.Text.Trim()
        sach.Soluongton = Integer.Parse(soluongton.Text.Trim())
        Dim ketQua As String = sachbus.Themsach(sach)
        If (ketQua <> "Success") Then

            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Thêm thành công")
        HienThiThongTinSach()
        tensach.Clear()
        theloai.Clear()
        tacgia.Clear()
        masach.Text = sachdal.Tangma()
        Return 1
    End Function
    'hàm sửa sách
    Private Function Suasach()
        'Kiểm tra tên sách không được để trống
        If tensach.Text = Nothing Then
            MessageBox.Show("Tên sách không được để trống")
            tensach.Focus()
            Return 0
        Else
            sach.Tensach = tensach.Text.Trim
        End If
        sach.Tacgia = tacgia.Text.Trim
        sach.Theloai = theloai.Text.Trim
        sach.Masach = masach.Text.Trim
        Dim ketQua As String = sachbus.Suasach(sach)
        If (ketQua <> "Success") Then
            MessageBox.Show(ketQua)
            Return 0
        End If
        MessageBox.Show("Sửa thành công")
        HienThiThongTinSach()
        Return 1
    End Function
    'hàm xóa sách
    Private Function Xoasach()
        'Xóa sách theo mã sách
        sach.Masach = masach.Text
        Dim ketQua As String = sachbus.Xoasach(sach)
        If (ketQua <> "Success") Then
            MessageBox.Show("Không thể xóa sách")
            Return 0
        End If
        MessageBox.Show("Xóa thành công")
        HienThiThongTinSach()
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
        tensach.Text = ""
        theloai.Text = ""
        tacgia.Text = ""
        soluongton.Text = "0"
        masach.Text = sachdal.Tangma()
    End Sub

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        GroupBox1.Enabled = True
        Them.Enabled = False
        Xoa.Enabled = False
        Xoatrang.Enabled = True
        Luu.Enabled = True
        Khongluu.Enabled = True
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        If Luoi.RowCount <> Nothing Then
            Xoasach()
        End If
    End Sub
    'Lưu giá trị khi thêm sách và sửa sách
    Private Sub Luu_Click(sender As Object, e As EventArgs) Handles Luu.Click
        If Them.Enabled = False Then
            Suasach()
        End If
        If Sua.Enabled = False Then
            Themsach()
            GroupBox3.Enabled = False
        End If

    End Sub

    Private Sub Xoatrang_Click(sender As Object, e As EventArgs) Handles Xoatrang.Click
        tensach.Clear()
        theloai.Clear()
        tacgia.Clear()
    End Sub
    'Tra cứu sách theo tên sách
    Private Sub tracuu_Click(sender As Object, e As EventArgs) Handles tracuu.Click
        sach.Tensach = tracuutensach.Text.Trim
        Luoi.DataSource = sachbus.Timkiemtensach(sach)
    End Sub

    Private Sub chon_Click(sender As Object, e As EventArgs) Handles chon.Click
        Close()
    End Sub

    Private Sub HIENTHI_Click(sender As Object, e As EventArgs) Handles HIENTHI.Click
        HienThiThongTinSach()
    End Sub

    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi.RowEnter
        Dim dong As Integer = e.RowIndex
        tensach.DataBindings.Clear()
        tensach.DataBindings.Add("Text", Luoi.DataSource, "Tensach")
        theloai.DataBindings.Clear()
        theloai.DataBindings.Add("Text", Luoi.DataSource, "Theloai")
        tacgia.DataBindings.Clear()
        tacgia.DataBindings.Add("Text", Luoi.DataSource, "Tacgia")
        soluongton.DataBindings.Clear()
        soluongton.DataBindings.Add("Text", Luoi.DataSource, "Soluongton")
        masach.DataBindings.Clear()
        masach.DataBindings.Add("Text", Luoi.DataSource, "Masach")
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
    'Tải dữ liệu sách từ file excel
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
                sach.Masach = sachdal.Tangma()
                sach.Tensach = range.Cells(i, 1).Value.ToString
                sach.Theloai = range.Cells(i, 2).Value.ToString
                sach.Tacgia = range.Cells(i, 3).Value.ToString
                sach.Soluongton = Integer.Parse(range.Cells(i, 4).Value.ToString)
                sachbus.Themsach(sach)
            Next
        End If
        HienThiThongTinSach()
        MessageBox.Show("Import dữ liệu thành công ...")
    End Sub
End Class