Imports DTO.DangnhapDTO
Imports DAL.DataAccess
Imports BUS.DangnhapBUS
Imports DAL.DangnhapDAL
Public Class DANGNHAP
    Dim dangnhapbus As New DangnhapBUS
    Dim dangnhap As New DangnhapDTO

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Application.Exit()
    End Sub

    Private Sub dangnhap1_Click(sender As Object, e As EventArgs) Handles dangnhap1.Click
        dangnhap.Tendangnhap = Tendangnhap.Text.Trim
        dangnhap.Matkhau = Matkhau.Text.Trim
        If Tendangnhap.Text.Trim = "" Or Matkhau.Text.Trim = "" Or Tencsdl.Text.Trim = "" Then
            MessageBox.Show("Ten đăng nhập, mật khẩu và tên cơ sở dữ liệu không được để trống không được để trống")
        Else
            Dim dt As DataTable = dangnhapbus.Kiemtrataikhoandangnhap(dangnhap)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng")
                Tendangnhap.Text = ""
                Matkhau.Text = ""
            Else
                dangnhap.Tencsdl = Tencsdl.Text.Trim
                MessageBox.Show("Đăng nhập thành công")
                Close()
                Form1.MenuStrip1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Matkhau_TextChanged(sender As Object, e As EventArgs) Handles Matkhau.TextChanged

    End Sub
End Class