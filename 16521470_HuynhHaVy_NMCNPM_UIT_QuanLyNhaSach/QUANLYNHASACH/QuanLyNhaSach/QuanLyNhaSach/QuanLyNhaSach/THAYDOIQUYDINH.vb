Imports DTO.ThamsoDTO
Imports DAL.ThamsoDAL
Imports BUS.ThamsoBUS

Public Class THAYDOIQUYDINH
    Dim thamsobus As New ThamsoBUS
    Dim thamso As New ThamsoDTO
    Dim mathamso As Integer
    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

    Private Sub Macdinh_Click(sender As Object, e As EventArgs) Handles Macdinh.Click
        TextBox1.Text = "150"
        TextBox2.Text = "300"
        TextBox3.Text = "20"
        TextBox4.Text = "20000"
        CheckBox1.Checked = True
        Dim dt As DataTable = thamsobus.Taithamso()
        If dt.Rows.Count = 0 Then
            mathamso = 0
        Else
            mathamso = Integer.Parse(dt.Rows(0).Item(0).ToString())
        End If
        thamso.Soluongnhapitnhat = Integer.Parse(TextBox1.Text)
        thamso.Soluongtontoidatruocnhap = Integer.Parse(TextBox2.Text)
        thamso.Soluongtonsautoithieu = Integer.Parse(TextBox3.Text)
        thamso.Sotiennotoida = Integer.Parse(TextBox4.Text)
        thamso.Sudungquydinh4 = 1
        Dim ketqua As String = thamsobus.Capnhatlaibangthamso(thamso)
        If (ketqua <> "Success") Then
            MessageBox.Show(ketqua)
        Else
            MessageBox.Show("Đã khôi phục về mặc định!")
        End If
        hienthigiatrihientai()
    End Sub

    Public Sub hienthigiatrihientai()
        Dim dt As DataTable = thamsobus.Taithamso
        If dt.Rows.Count > 0 Then
            TextBox5.Text = dt.Rows(0).Item(1).ToString
            TextBox6.Text = dt.Rows(0).Item(2).ToString
            TextBox7.Text = dt.Rows(0).Item(3).ToString
            TextBox8.Text = dt.Rows(0).Item(4).ToString
            Dim check As Integer = Integer.Parse(dt.Rows(0).Item(5).ToString())
            If check = 1 Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
        End If
    End Sub

    Private Sub THAYDOIQUYDINH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        hienthigiatrihientai()
    End Sub

    Private Sub Thaydoi_Click(sender As Object, e As EventArgs) Handles Thaydoi.Click
        Dim dt As DataTable = thamsobus.Taithamso
        mathamso = Integer.Parse(dt.Rows(0).Item(0).ToString())
        thamso.Mathamso = mathamso
        If (CheckBox1.Checked = True) Then
            thamso.Sudungquydinh4 = 1
        Else
            thamso.Sudungquydinh4 = 0
        End If
        Try
            thamso.Soluongnhapitnhat = Integer.Parse(TextBox1.Text)
            thamso.Soluongtontoidatruocnhap = Integer.Parse(TextBox2.Text)
            thamso.Soluongtonsautoithieu = Integer.Parse(TextBox3.Text)
            thamso.Sotiennotoida = Integer.Parse(TextBox4.Text)
        Catch generatedExceptionName As FormatException
            MessageBox.Show("Bạn phải nhập số ")
            Return
        End Try
        Dim ketqua As String = thamsobus.Capnhatthamso(thamso)
        If ketqua <> "Success" Then
            MessageBox.Show(ketqua)
        Else
            MessageBox.Show("Thay đổi thành công")
        End If
        hienthigiatrihientai()
    End Sub
End Class