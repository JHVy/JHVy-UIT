Imports DTO.BaocaocongnoDTO
Imports DTO.KhachhangDTO
Imports DAL.BaocaocongnoDAL
Imports BUS.BaocaocongnoBUS
Imports BUS.HoadonBUS
Imports BUS.PhieuthuBUS
Imports BUS.KhachhangBUS
Public Class BAOCAOCAONGNO
    Dim baocaocongno As New BaocaocongnoDTO
    Dim khachhang As New KhachhangDTO
    Dim baocaocongnobus As New BaocaocongnoBUS
    Dim baocaocongnodal As New BaocaocongnoDAL
    Dim khachhangbus As New KhachhangBUS
    Dim hoadonbus As New HoadonBUS
    Dim phieuthubus As New PhieuthuBUS
    Dim nodau As Single
    Dim nocuoi As Single
    Dim nophatsinh As Single
    Dim sotienthu As Single

    Private Sub Hienthibaocaocongno()
        Luoi.DataSource = baocaocongnobus.Hienthibaocaocongno()
    End Sub

    Private Sub BAOCAOCAONGNO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thang.Text = 0
        Nam.Text = 0
        Hienthibaocaocongno()
    End Sub

    Private Sub Lapbaocao_Click(sender As Object, e As EventArgs) Handles Lapbaocao.Click
        Dim dt As DataTable = khachhangbus.Timkiemmakhachhang()
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống")
            Return
        Else
            baocaocongno.Thang = Integer.Parse(Thang.Text)
        End If
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống")
            Return
        Else
            baocaocongno.Nam = Integer.Parse(Nam.Text)
        End If
        Dim tbc As DataTable = baocaocongnobus.Timbaocaotheothangvanam(baocaocongno)
        If tbc.Rows.Count = 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                baocaocongno.Machitietcongno = baocaocongnodal.Tangmabccn()
                baocaocongno.Makhachhang = dt.Rows(i).Item(0).ToString()
                If baocaocongno.Thang - 1 = 0 Then
                    baocaocongno.Thang = 12
                    Dim dt1 As DataTable = baocaocongnobus.Timkiembaocaocongnotheothangtruoc(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam - 1)
                    If dt1.Rows.Count = 0 Then
                        Dim dthd As DataTable = hoadonbus.Timkiemhoadontheothangvanam(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam)
                        If dthd.Rows.Count = 0 Then
                            khachhang.Makhachhang = baocaocongno.Makhachhang
                            Dim dts As DataTable = khachhangbus.Timkiemtheomakhachhang(khachhang)
                            nodau = Integer.Parse(dts.Rows(0).Item(5).ToString())
                        Else
                            nodau = 0
                        End If
                    Else
                        nodau = Integer.Parse(dt1.Rows(0).Item(6).ToString)
                    End If
                Else
                    Dim dt1 As DataTable = baocaocongnobus.Timkiembaocaocongnotheothangtruoc(baocaocongno.Makhachhang, baocaocongno.Thang - 1, baocaocongno.Nam)
                    If dt1.Rows.Count = 0 Then
                        Dim dthd As DataTable = hoadonbus.Timkiemhoadontheothangvanam(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam)
                        If dthd.Rows.Count = 0 Then
                            khachhang.Makhachhang = baocaocongno.Makhachhang
                            Dim dts As DataTable = khachhangbus.Timkiemtheomakhachhang(khachhang)
                            nodau = Integer.Parse(dts.Rows(0).Item(5).ToString())
                        Else
                            nodau = 0
                        End If
                    Else
                        nodau = Integer.Parse(dt1.Rows(0).Item(6).ToString)
                    End If
                End If
                Dim dt2 As DataTable = hoadonbus.Tongthanhtien(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam)
                If dt2.Rows.Count = 0 Then
                    nophatsinh = 0
                Else
                    nophatsinh = Integer.Parse(dt2.Rows(0).Item(0).ToString)
                End If
                Dim dt3 As DataTable = phieuthubus.Tongsotienthu(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam)
                If dt3.Rows.Count = 0 Then
                    sotienthu = 0
                Else
                    sotienthu = Integer.Parse(dt3.Rows(0).Item(0).ToString())
                End If
                baocaocongno.Nodau = nodau
                baocaocongno.Nophatsinh = nophatsinh
                If sotienthu > nodau + nophatsinh Then
                    baocaocongno.Nocuoi = 0
                Else
                    baocaocongno.Nocuoi = nodau + nophatsinh - sotienthu
                End If
                Dim ketqua As String = baocaocongnobus.Thembaocaocongno(baocaocongno)
            Next
            Hienthibaocaocongno()
        Else
            MessageBox.Show("Tháng đã lập báo cáo")
        End If
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

    Private Sub Timbaocao_Click(sender As Object, e As EventArgs) Handles Timbaocao.Click
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống")
            Return
        Else
            baocaocongno.Thang = Integer.Parse(Thang.Text)
        End If
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống")
            Return
        Else
            baocaocongno.Nam = Integer.Parse(Nam.Text)
        End If
        Luoi.DataSource = baocaocongnobus.Timbaocaotheothangvanam(baocaocongno)
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("tháng này chưa lập báo cáo")
        End If
    End Sub
End Class