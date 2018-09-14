Imports DTO.SachDTO
Imports BUS.SachBUS
Public Class TIMKIEMSACH
    Dim sach As New SachDTO
    Dim sachbus As New SachBUS
    'Hiển thị sách lên datagridview
    Public Sub hienthisach()
        Luoi.DataSource = sachbus.Taidulieu()
    End Sub
    'Tìm kiếm sách
    Private Sub Timkiem_Click(sender As Object, e As EventArgs) Handles Timkiem.Click
        sach.Tensach = Tensach.Text.Trim
        sach.Theloai = Theloai.Text.Trim
        sach.Tacgia = Tacgia.Text.Trim
        'Tìm kiếm sách theo tên sách
        If CTensach.Checked = True Then
            Luoi.DataSource = sachbus.Timkiemtensach(sach)
        End If
        'Tìm kiếm sách theo thể loại
        If CTheloai.Checked = True Then
            Luoi.DataSource = sachbus.Timkiemtheloai(sach)
        End If
        'Tìm kiếm sách theo tác giả
        If CTacgia.Checked = True Then
            Luoi.DataSource = sachbus.Timkiemtacgia(sach)
        End If
        'Tìm kiếm sách theo tên sách và thể loại
        If ((CTensach.Checked = True) And (CTheloai.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtensachvatheloai(sach)
        End If
        'Tìm kiếm sách theo tên sách và tác giả
        If ((CTensach.Checked = True) And (CTacgia.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtensachvatacgia(sach)
        End If
        'Tìm kiếm sách theo tác giả và thể loại
        If ((CTacgia.Checked = True) And (CTheloai.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtacgiavatheloai(sach)
        End If
        'Tìm kiếm sách theo Tên sách ,Tác giả, thể loại
        If ((CTensach.Checked = True) And (CTheloai.Checked = True) And (CTacgia.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtensachvatheloaivatacgia(sach)
        End If
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("Không tìm thấy sách !")
        End If
    End Sub

    Private Sub Hienthi_Click(sender As Object, e As EventArgs) Handles Hienthi.Click
        hienthisach()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

End Class