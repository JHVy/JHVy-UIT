Imports DTO.BaocaotonDTO
Imports DTO.SachDTO
Imports DAL.BaocaotonDAL
Imports BUS.BaocaotonBUS
Imports BUS.PhieuNhapBUS
Imports BUS.SachBUS
Imports BUS.HoadonBUS
Imports System.Text.RegularExpressions
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
    'Hiển thị báo cáo tồn lên datagridview
    Private Sub Hienthibaocaoton()
        Luoi.DataSource = baocaotonbus.Hienthibaocaoton()
    End Sub

    Private Sub BAOCAOTON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thang.Text = 0
        Nam.Text = 0
        Hienthibaocaoton()
    End Sub
    'Lập báo cáo
    Private Sub Lapbaocao_Click(sender As Object, e As EventArgs) Handles Lapbaocao.Click
        Dim dt As DataTable = sachbus.Timkiemmasach()
        'Kiểm tra tháng không được để trống
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống !")
            Return
        Else
            baocaoton.Thang = Integer.Parse(Thang.Text)
        End If
        'Kiểm tra năm không được để trống
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống !")
            Return
        Else
            baocaoton.Nam = Integer.Parse(Nam.Text)
        End If
        'Tìm báo cáo theo tháng và năm
        'Nếu báo cáo tồn tại thì cập nhật lại báo cáo ngược lại thì thêm báo cáo
        Dim tbc As DataTable = baocaotondal.Timkiembaocaotontheothangvanam(baocaoton)
        If tbc.Rows.Count = 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                baocaoton.Machitietton = baocaotondal.Tangmabct()
                baocaoton.Masach = dt.Rows(i).Item(0).ToString()
                'Kiểm tra nếu tháng = 1 thì lấy báo cáo của tháng 12 năm trước
                If baocaoton.Thang - 1 = 0 Then
                    baocaoton.Thang = 12
                    'Lấy báo cáo của tháng 12 năm trước
                    Dim dt1 As DataTable = baocaotonbus.Timkiembaocaotontheothangtruoc(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam - 1)
                    'Tính tồn đầu của sách
                    'Tồn đầu = 0 nếu không có báo cáo tháng trước ngươc lại tồn đầu = tồn cuối tháng 12 năm trước
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
                    'Lấy báo cáo của tháng trước
                    Dim dt1 As DataTable = baocaotonbus.Timkiembaocaotontheothangtruoc(baocaoton.Masach, baocaoton.Thang - 1, baocaoton.Nam)
                    'Tính tồn đầu của sách
                    'Tồn đầu = 0 nếu không có báo cáo tháng trước ngươc lại tồn đầu = tồn cuối tháng 12 năm trước
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
                'Lấy tổng số lượng nhập của sách theo tháng năm lập báo cáo
                Dim dt2 As DataTable = phieunhapbus.Tongluongnhaptheosach(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
                'Tính tồn phát sinh của sách
                'Tồn phát sinh =0 nếu tổng số lượng nhập trong phiếu nhập =0 ngược lại tồn phát sinh =tổng số lượng nhập của sách trong phiếu nhập theo tháng và năm lập báo cáo
                If dt2.Rows.Count = 0 Then
                    tonphatsinh = 0
                Else
                    tonphatsinh = Integer.Parse(dt2.Rows(0).Item(0).ToString)
                End If
                'Lấy tổng số lượng bán của sách theo tháng năm lập báo cáo
                Dim dt3 As DataTable = hoadonbus.Tongsoluongban(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
                'Tính tổng số lượng bán của khách hàng
                'Số lượng bán = 0 nếu số lượng bán trong hóa đơn =0 ngược lại số lượng bán = tổng số lượng bán của sách trong hóa đơn theo thàng và năm lập báo cáo
                If dt3.Rows.Count = 0 Then
                    soluongban = 0
                Else
                    soluongban = Integer.Parse(dt3.Rows(0).Item(0).ToString())
                End If
                'Lấy giá trị tondau,toncuoi,tonphatsinh
                baocaoton.Tondau = tondau
                baocaoton.Tonphatsinh = tonphatsinh
                baocaoton.Toncuoi = tondau + tonphatsinh - soluongban
                Dim ketqua As String = baocaotonbus.Thembaocaoton(baocaoton)
            Next
            Hienthibaocaoton()
        Else
            Capnhatbaocao()
        End If
    End Sub
    'Tìm báo cáo
    Private Sub Timbaocao_Click(sender As Object, e As EventArgs) Handles Timbaocao.Click
        'Kiểm tra tháng không được để trống
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống !")
            Return
        Else
            baocaoton.Thang = Integer.Parse(Thang.Text)
        End If
        'Kiểm tra năm không được để trống
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống !")
            Return
        Else
            baocaoton.Nam = Integer.Parse(Nam.Text)
        End If
        Luoi.DataSource = baocaotonbus.Timbaocaotheothangvanam(baocaoton)
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("Tháng này chưa lập báo cáo !")
        End If
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
    'Xuất file báo cáo ra excel
    Private Sub Xuatfile_Click(sender As Object, e As EventArgs) Handles Xuatfile.Click
        SaveFileDialog1.InitialDirectory = "C:"
        SaveFileDialog1.Title = " Xuất file Excel !"
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = " Excel Files(2003)|*.xls|Excel Files(2017)|*.xlsx"
        If SaveFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            Dim Excelapp As New Microsoft.Office.Interop.Excel.Application
            Excelapp.Application.Workbooks.Add(Type.Missing)
            Excelapp.Columns.ColumnWidth = 20
            Excelapp.Cells(1, 1) = Luoi.Columns(7).HeaderText
            Excelapp.Cells(1, 2) = Luoi.Columns(1).HeaderText
            Excelapp.Cells(1, 3) = Luoi.Columns(2).HeaderText
            Excelapp.Cells(1, 4) = Luoi.Columns(4).HeaderText
            Excelapp.Cells(1, 5) = Luoi.Columns(5).HeaderText
            Excelapp.Cells(1, 6) = Luoi.Columns(6).HeaderText
            For i As Integer = 0 To Luoi.RowCount.ToString - 1
                Excelapp.Cells(i + 2, 1) = Luoi.Rows(i).Cells(7).Value.ToString
                Excelapp.Cells(i + 2, 2) = Luoi.Rows(i).Cells(1).Value.ToString
                Excelapp.Cells(i + 2, 3) = Luoi.Rows(i).Cells(2).Value.ToString
                Excelapp.Cells(i + 2, 4) = Luoi.Rows(i).Cells(4).Value.ToString
                Excelapp.Cells(i + 2, 5) = Luoi.Rows(i).Cells(5).Value.ToString
                Excelapp.Cells(i + 2, 6) = Luoi.Rows(i).Cells(6).Value.ToString
            Next
            Excelapp.ActiveWorkbook.SaveCopyAs(SaveFileDialog1.FileName.ToString())
            Excelapp.ActiveWorkbook.Saved = True
            Excelapp.Quit()
        End If
    End Sub
    'Cập nhật báo cáo
    Private Sub Capnhatbaocao()
        'Xóa báo cáo cũ và lập báo cáo mới
        Dim dt As DataTable = sachbus.Timkiemmasach()
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống !")
            Return
        Else
            baocaoton.Thang = Integer.Parse(Thang.Text)
        End If
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống !")
            Return
        Else
            baocaoton.Nam = Integer.Parse(Nam.Text)
        End If
        baocaotondal.Xoabaocaotontheothangvanam(baocaoton.Thang, baocaoton.Nam)
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
            Dim dt2 As DataTable = phieunhapbus.Tongluongnhaptheosach(baocaoton.Masach, baocaoton.Thang, baocaoton.Nam)
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
    End Sub
End Class