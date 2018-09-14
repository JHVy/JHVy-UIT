Imports DTO.NhanvienDTO
Imports BUS.NhanvienBUS

Public Class TRACUUNHANVIEN

    Dim nhanvien As New NhanvienDTO
    Dim nhanvienbus As New NhanvienBUS

    'Hiện thông tin lên datagridview
    Public Sub hienthinhanvien()
        Luoi.DataSource = nhanvienbus.Taidulieu()
    End Sub

    Private Sub Timkiem_Click(sender As Object, e As EventArgs) Handles Timkiem.Click
        nhanvien.Hotennhanvien = Tennhanvien.Text.Trim
        nhanvien.Diachi = Diachi.Text.Trim
        nhanvien.Dienthoai = Dienthoai.Text.Trim
        'Tìm kiếm khách hàng theo tên khách hàng
        If CTennhanvien.Checked = True Then
            Luoi.DataSource = nhanvienbus.Timkiemtennhanvien(nhanvien)
        End If
        'Tìm kiếm khách hàng theo điện thoại
        If CDienthoai.Checked = True Then
            Luoi.DataSource = nhanvienbus.Timkiemdienthoai(nhanvien)
        End If
        'Tìm kiếm khách hàng theo địa chỉ
        If CDiachi.Checked = True Then
            Luoi.DataSource = nhanvienbus.Timkiemdiachi(nhanvien)
        End If
        'Tìm kiếm khách hàng theo tên khách hàng và điện thoại
        If ((CTennhanvien.Checked = True) And (CDienthoai.Checked = True)) Then
            Luoi.DataSource = nhanvienbus.Timkiemtennhanvienvadienthoai(nhanvien)
        End If
        'Tìm kiếm khách hàng theo tên khách hàng và địa chỉ
        If ((CTennhanvien.Checked = True) And (CDiachi.Checked = True)) Then
            Luoi.DataSource = nhanvienbus.Timkiemtennhanvienvadiachi(nhanvien)
        End If
        'Tìm kiếm khách hàng theo địa chỉ và điện thoại
        If ((CDiachi.Checked = True) And (CDienthoai.Checked = True)) Then
            Luoi.DataSource = nhanvienbus.Timkiemtendienthoaivadiachi(nhanvien)
        End If
        'Tìm kiếm khách hàng theo tên khách hàng ,Điện thoại ,địa chỉ
        If ((CTennhanvien.Checked = True) And (CDienthoai.Checked = True) And (CDiachi.Checked = True)) Then
            Luoi.DataSource = nhanvienbus.Timkiemtentennhanvienvadienthoaivadiachi(nhanvien)
        End If
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("Không tìm thấy !")
        End If
    End Sub

    Private Sub Hienthi_Click(sender As Object, e As EventArgs) Handles Hienthi.Click
        hienthinhanvien()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
End Class