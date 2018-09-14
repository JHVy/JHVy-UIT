Imports DTO.KhachhangDTO
Imports BUS.KhachhangBUS
Public Class TRACCUUKHACHHANG
    Dim khachhang As New KhachhangDTO
    Dim khachhangbus As New KhachhangBUS
    'Hiển thị thông tin khách hàng lên datagridview
    Public Sub hienthikhachhang()
        Luoi.DataSource = khachhangbus.Taidulieu()
    End Sub
    'Tìm kiếm khách hàng
    Private Sub Timkiem_Click(sender As Object, e As EventArgs) Handles Timkiem.Click
        khachhang.Hotenkhachhang = Tenkhachhang.Text.Trim
        khachhang.Diachi = Diachi.Text.Trim
        khachhang.Dienthoai = Dienthoai.Text.Trim
        'Tìm kiếm khách hàng theo tên khách hàng
        If CTenkhachhang.Checked = True Then
            Luoi.DataSource = khachhangbus.Timkiemtenkhachhang(khachhang)
        End If
        'Tìm kiếm khách hàng theo điện thoại
        If CDienthoai.Checked = True Then
            Luoi.DataSource = khachhangbus.Timkiemdienthoai(khachhang)
        End If
        'Tìm kiếm khách hàng theo địa chỉ
        If CDiachi.Checked = True Then
            Luoi.DataSource = khachhangbus.Timkiemdiachi(khachhang)
        End If
        'Tìm kiếm khách hàng theo tên khách hàng và điện thoại
        If ((CTenkhachhang.Checked = True) And (CDienthoai.Checked = True)) Then
            Luoi.DataSource = khachhangbus.Timkiemtenkhachhangvadienthoai(khachhang)
        End If
        'Tìm kiếm khách hàng theo tên khách hàng và địa chỉ
        If ((CTenkhachhang.Checked = True) And (CDiachi.Checked = True)) Then
            Luoi.DataSource = khachhangbus.Timkiemtenkhachhangvadiachi(khachhang)
        End If
        'Tìm kiếm khách hàng theo địa chỉ và điện thoại
        If ((CDiachi.Checked = True) And (CDienthoai.Checked = True)) Then
            Luoi.DataSource = khachhangbus.Timkiemtendienthoaivadiachi(khachhang)
        End If
        'Tìm kiếm khách hàng theo tên khách hàng ,Điện thoại ,địa chỉ
        If ((CTenkhachhang.Checked = True) And (CDienthoai.Checked = True) And (CDiachi.Checked = True)) Then
            Luoi.DataSource = khachhangbus.Timkiemtentenkhachhangvadienthoaivadiachi(khachhang)
        End If
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("Không tìm thấy sách")
        End If
    End Sub

    Private Sub Hienthi_Click(sender As Object, e As EventArgs) Handles Hienthi.Click
        hienthikhachhang()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
End Class