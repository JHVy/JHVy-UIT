Imports DTO.BaocaotonDTO
Imports DTO.SachDTO
Imports DAL.BaocaotonDAL
Imports BUS.BaocaotonBUS
Imports BUS.PhieuNhapBUS
Imports BUS.SachBUS
Imports BUS.HoadonBUS
Public Class BAOCAOTON
    Dim baocaoton As New BaocaotonDTO
    Dim sach As New SachDTO
    Dim baocaotonbus As New BaocaotonBUS
    Dim baocaotondal As New BaocaotonDAL
    Dim phieunhapbus As New PhieunhapBUS
    Dim sachbus As New SachBUS
    Dim hoadonbus As New HoadonBUS
    Dim tondau As Integer
    Dim toncuoi As Integer
    Dim tonphatsinh As Integer
    Dim soluongban As Integer

    Private Sub Hienthibaocaoton()
        Luoi.DataSource = baocaotonbus.Hienthibaocaoton()
    End Sub

    Private Sub BAOCAOTON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thang.Text = 0
        Nam.Text = 0
        Hienthibaocaoton()
    End Sub

    Private Sub Lapbaocao_Click(sender As Object, e As EventArgs) Handles Lapbaocao.Click
        Dim dt As DataTable = sachbus.Timkiemmasach()
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống")
            Return
        Else
            baocaoton.Thang = Integer.Parse(Thang.Text)
        End If
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống")
            Return
        Else
            baocaoton.Nam = Integer.Parse(Nam.Text)
        End If
        Dim tbc As DataTable = baocaotondal.Timkiembaocaotontheothangvanam(baocaoton)
        If tbc.Rows.Count = 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                baocaoton.Machitietton = baocaotondal.Tangmabct()
                baocaoton.Masach = dt.Rows(i).Item(0).ToString()
                If baocaoton.Thang - 1 = 0 Then
                    baocaoton.Thang = 12
                    Dim dt1 As DataTable = baocaotonbus.Timkiembaocaotontheothangtruoc(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam - 1)
                    If dt1.Rows.Count = 0 Then
                        Dim dtpn As DataTable = phieunhapbus.Timkiemphieunhaptheothangvanam(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
                        If dtpn.Rows.Count = 0 Then
                            sach.Masach = baocaoton.Masach
                            Dim dts As DataTable = sachbus.Timkiemtheomasach(sach)
                            tondau = Integer.Parse(dts.Rows(0).Item(4).ToString())
                        Else
                            tondau = 0
                        End If
                    Else
                        tondau = Integer.Parse(dt1.Rows(0).Item(6).ToString)
                    End If
                Else
                    Dim dt1 As DataTable = baocaotonbus.Timkiembaocaotontheothangtruoc(baocaoton.Masach, baocaoton.Thang - 1, baocaoton.Nam)
                    If dt1.Rows.Count = 0 Then
                        Dim dtpn As DataTable = phieunhapbus.Timkiemphieunhaptheothangvanam(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
                        If dtpn.Rows.Count = 0 Then
                            sach.Masach = baocaoton.Masach
                            Dim dts As DataTable = sachbus.Timkiemtheomasach(sach)
                            tondau = Integer.Parse(dts.Rows(0).Item(4).ToString())
                        Else
                            tondau = 0
                        End If
                    Else
                        tondau = Integer.Parse(dt1.Rows(0).Item(6).ToString)
                    End If
                End If
                Dim dt2 As DataTable = phieunhapbus.Tongluongnhaptheothang(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
                If dt2.Rows.Count = 0 Then
                    tonphatsinh = 0
                Else
                    tonphatsinh = Integer.Parse(dt2.Rows(0).Item(0).ToString)
                End If
                Dim dt3 As DataTable = hoadonbus.Tongsoluongban(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
                If dt3.Rows.Count = 0 Then
                    soluongban = 0
                Else
                    soluongban = Integer.Parse(dt3.Rows(0).Item(0).ToString())
                End If

                baocaoton.Tondau = tondau
                baocaoton.Tonphatsinh = tonphatsinh
                baocaoton.Toncuoi = tondau + tonphatsinh - soluongban
                Dim ketqua As String = baocaotonbus.Thembaocaoton(baocaoton)
            Next

            Hienthibaocaoton()
        Else
            MessageBox.Show("Tháng đã lập báo cáo")
        End If
    End Sub

    Private Sub Timbaocao_Click(sender As Object, e As EventArgs) Handles Timbaocao.Click
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống")
            Return
        Else
            baocaoton.Thang = Integer.Parse(Thang.Text)
        End If
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống")
            Return
        Else
            baocaoton.Nam = Integer.Parse(Nam.Text)
        End If
        Luoi.DataSource = baocaotonbus.Timbaocaotheothangvanam(baocaoton)
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("tháng này chưa lập báo cáo")
        End If
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
End Class