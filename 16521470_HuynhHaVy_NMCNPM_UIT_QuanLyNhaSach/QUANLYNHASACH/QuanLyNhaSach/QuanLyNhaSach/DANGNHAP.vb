Imports DTO.DangnhapDTO
Imports DAL.data
Imports BUS.DangnhapBUS
Imports DAL.DangnhapDAL
Public Class DANGNHAP
    Dim dangnhapbus As New DangnhapBUS
    Dim dangnhap As New DangnhapDTO
    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Hide()
    End Sub

    Private Sub dangnhap1_Click(sender As Object, e As EventArgs) Handles dangnhap1.Click
        dangnhap.Tendangnhap = Tendangnhap.Text.Trim
        dangnhap.Matkhau = Matkhau.Text.Trim
        'Kiểm tra tên đăng nhập và mật khẩu không được để trống
        If Tendangnhap.Text.Trim = "" Or Matkhau.Text.Trim = "" Then
            MessageBox.Show("Ten đăng nhập, mật khẩu không được để trống không được để trống")
        Else
            'Lấy dữ liệu từ bảng NGUOIDUNG
            Dim dt As DataTable = dangnhapbus.Kiemtrataikhoandangnhap(dangnhap)
            'kiểm tra tên đăng nhập và mật khẩu
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng")
                Tendangnhap.Text = ""
                Matkhau.Text = ""
            Else
                MessageBox.Show("Đăng nhập thành công")
                Close()
                Form1.QuảnLýToolStripMenuItem.Enabled = True
                Form1.TraCứuToolStripMenuItem.Enabled = True
                Form1.BáoCáoToolStripMenuItem.Enabled = True
                Form1.TraCứuToolStripMenuItem1.Enabled = True
                Form1.thaydoiquydinhToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub DANGNHAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tendangnhap.Text = "admin"
        Matkhau.Text = "123456"
    End Sub

    Private Sub DANGNHAP_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Hide()
    End Sub
End Class