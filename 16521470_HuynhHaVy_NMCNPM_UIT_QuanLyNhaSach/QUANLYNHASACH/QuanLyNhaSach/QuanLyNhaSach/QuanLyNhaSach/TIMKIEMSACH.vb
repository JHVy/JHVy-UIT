Imports DTO.SachDTO
Imports BUS.SachBUS
Public Class TIMKIEMSACH
    Dim sach As New SachDTO
    Dim sachbus As New SachBUS
    Public Sub hienthisach()
        Luoi.DataSource = sachbus.Taidulieu()
    End Sub

    Private Sub Timkiem_Click(sender As Object, e As EventArgs) Handles Timkiem.Click
        sach.Tensach = Tensach.Text.Trim
        sach.Theloai = Theloai.Text.Trim
        sach.Tacgia = Tacgia.Text.Trim
        If CTensach.Checked = True Then
            Luoi.DataSource = sachbus.Timkiemtensach(sach)
        End If
        If CTheloai.Checked = True Then
            Luoi.DataSource = sachbus.Timkiemtheloai(sach)
        End If
        If CTacgia.Checked = True Then
            Luoi.DataSource = sachbus.Timkiemtacgia(sach)
        End If
        If ((CTensach.Checked = True) And (CTheloai.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtensachvatheloai(sach)
        End If
        If ((CTensach.Checked = True) And (CTacgia.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtensachvatacgia(sach)
        End If
        If ((CTacgia.Checked = True) And (CTheloai.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtacgiavatheloai(sach)
        End If
        If ((CTensach.Checked = True) And (CTheloai.Checked = True) And (CTacgia.Checked = True)) Then
            Luoi.DataSource = sachbus.Timkiemtensachvatheloaivatacgia(sach)
        End If
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("Không tìm thấy sách")
        End If
    End Sub

    Private Sub Hienthi_Click(sender As Object, e As EventArgs) Handles Hienthi.Click
        hienthisach()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
End Class