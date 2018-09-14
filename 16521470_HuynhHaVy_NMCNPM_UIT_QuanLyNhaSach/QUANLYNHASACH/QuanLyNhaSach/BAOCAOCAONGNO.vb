Imports DTO.BaocaocongnoDTO
Imports DTO.KhachhangDTO
Imports DAL.BaocaocongnoDAL
Imports BUS.BaocaocongnoBUS
Imports BUS.HoadonBUS
Imports BUS.PhieuthuBUS
Imports BUS.KhachhangBUS
Imports System.Text.RegularExpressions
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
    'Hiển thị báo cáo công nợ lên datagridview
    Private Sub Hienthibaocaocongno()
        Luoi.DataSource = baocaocongnobus.Hienthibaocaocongno()
    End Sub

    Private Sub BAOCAOCAONGNO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thang.Text = 0
        Nam.Text = 0
        Hienthibaocaocongno()
    End Sub
    'Lập báo cáo
    Private Sub Lapbaocao_Click(sender As Object, e As EventArgs) Handles Lapbaocao.Click
        Dim dt As DataTable = khachhangbus.Timkiemmakhachhang()
        'Kiểm tra tháng không được để trống
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống !")
            Return
        Else
            baocaocongno.Thang = Integer.Parse(Thang.Text)
        End If
        'Kiểm tra năm không được để trống
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống !")
            Return
        Else
            baocaocongno.Nam = Integer.Parse(Nam.Text)
        End If
        'Tìm báo cáo theo tháng và năm
        'Nếu báo cáo tồn tại thì cập nhật lại báo cáo ngược lại thì thêm báo cáo
        Dim tbc As DataTable = baocaocongnobus.Timbaocaotheothangvanam(baocaocongno)
        If tbc.Rows.Count = 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                baocaocongno.Machitietcongno = baocaocongnodal.Tangmabccn()
                baocaocongno.Makhachhang = dt.Rows(i).Item(0).ToString()
                'Kiểm tra nếu tháng = 1 thì lấy báo cáo của tháng 12 năm trước
                If baocaocongno.Thang - 1 = 0 Then
                    baocaocongno.Thang = 12
                    'Lấy báo cáo của tháng 12 năm trước
                    Dim dt1 As DataTable = baocaocongnobus.Timkiembaocaocongnotheothangtruoc(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam - 1)
                    'Tính nợ đầu của khách hàng
                    'Nợ đầu = 0 nếu không có báo cáo tháng trước ngươc lại Nợ đầu = Nợ cuối tháng 12 năm trước
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
                    'Lấy báo cáo của tháng trước
                    Dim dt1 As DataTable = baocaocongnobus.Timkiembaocaocongnotheothangtruoc(baocaocongno.Makhachhang, baocaocongno.Thang - 1, baocaocongno.Nam)
                    'Tính nợ đầu của khách hàng
                    'Nợ đầu = 0 nếu không có báo cáo tháng trước ngươc lại Nợ đầu = Nợ cuối tháng trước
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
                'Lấy tổng thành tiền của khách hàng theo tháng năm lập báo cáo
                Dim dt2 As DataTable = hoadonbus.Tongthanhtien(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam)
                'Tính nợ phát sinh của khách hàng
                'Nợ phát sinh =0 nếu tổng thành tiền trong hóa đơn =0 ngược lại nợ phát sinh =tổng thành tiền của khách hàng trong hóa đơn theo tháng và năm lập báo cáo
                If dt2.Rows.Count = 0 Then
                    nophatsinh = 0
                Else
                    nophatsinh = Integer.Parse(dt2.Rows(0).Item(0).ToString)
                End If
                'Lấy tổng số tiền thu của khách hàng theo tháng năm lập báo cáo
                Dim dt3 As DataTable = phieuthubus.Tongsotienthu(baocaocongno.Makhachhang, baocaocongno.Thang, baocaocongno.Nam)
                'Tính tổng sồ tiền thu của khách hàng
                'Số tiền thu = 0 nếu số tiền thu trong phiếu thu =0 ngược lại số tiền thu = tổng số tiền thu của khách hàng trong phiếu thu theo thàng và năm lập báo cáo
                If dt3.Rows.Count = 0 Then
                    sotienthu = 0
                Else
                    sotienthu = Integer.Parse(dt3.Rows(0).Item(0).ToString())
                End If
                'Lấy giá trị nodau,nophatsinh,nocuoi 
                baocaocongno.Nodau = nodau
                baocaocongno.Nophatsinh = nophatsinh
                'Nếu số tiền thu > nợ đầu + nợ phát sinh
                'Nợ cuối =0 ngược lại nợ cuối = nợ đầu + nợ phát sinh - tổng số tiền thu
                If sotienthu > nodau + nophatsinh Then
                    baocaocongno.Nocuoi = 0
                Else
                    baocaocongno.Nocuoi = nodau + nophatsinh - sotienthu
                End If
                Dim ketqua As String = baocaocongnobus.Thembaocaocongno(baocaocongno)
            Next
            Hienthibaocaocongno()
        Else
            Capnhatbaocao()
        End If
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub
    'Tìm báo cáo
    Private Sub Timbaocao_Click(sender As Object, e As EventArgs) Handles Timbaocao.Click
        'Kiểm tra tháng không được để trống
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống !")
            Return
        Else
            baocaocongno.Thang = Integer.Parse(Thang.Text)
        End If
        'Kiểm tra năm không được để trống
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống !")
            Return
        Else
            baocaocongno.Nam = Integer.Parse(Nam.Text)
        End If
        Luoi.DataSource = baocaocongnobus.Timbaocaotheothangvanam(baocaocongno)
        If Luoi.RowCount = Nothing Then
            MessageBox.Show("Tháng này chưa lập báo cáo !")
        End If
    End Sub
    'Xuất file báo cáo ra excel
    Private Sub Xuatfile_Click(sender As Object, e As EventArgs) Handles Xuatfile.Click
        SaveFileDialog1.InitialDirectory = "C:"
        SaveFileDialog1.Title = " Xuất file Excel"
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
            Excelapp.Cells(1, 5) = Luoi.Columns(6).HeaderText
            Excelapp.Cells(1, 6) = Luoi.Columns(5).HeaderText
            For i As Integer = 0 To Luoi.RowCount.ToString - 1
                Excelapp.Cells(i + 2, 1) = Luoi.Rows(i).Cells(7).Value.ToString
                Excelapp.Cells(i + 2, 2) = Luoi.Rows(i).Cells(1).Value.ToString
                Excelapp.Cells(i + 2, 3) = Luoi.Rows(i).Cells(2).Value.ToString
                Excelapp.Cells(i + 2, 4) = Luoi.Rows(i).Cells(4).Value.ToString
                Excelapp.Cells(i + 2, 5) = Luoi.Rows(i).Cells(6).Value.ToString
                Excelapp.Cells(i + 2, 6) = Luoi.Rows(i).Cells(5).Value.ToString
            Next
            Excelapp.ActiveWorkbook.SaveCopyAs(SaveFileDialog1.FileName.ToString())
            Excelapp.ActiveWorkbook.Saved = True
            Excelapp.Quit()
        End If

    End Sub
    'Cập nhật báo báo
    Private Sub Capnhatbaocao()
        'Xóa báo cáo cũ và lập báo cáo mới
        Dim dt As DataTable = khachhangbus.Timkiemmakhachhang()
        If Thang.Text.Trim = 0 Then
            MessageBox.Show("Tháng không được để trống !")
            Return
        Else
            baocaocongno.Thang = Integer.Parse(Thang.Text)
        End If
        If Nam.Text.Trim = 0 Then
            MessageBox.Show("Năm không được để trống !")
            Return
        Else
            baocaocongno.Nam = Integer.Parse(Nam.Text)
        End If
        baocaocongnobus.Xoabaocaocongno(baocaocongno.Thang, baocaocongno.Nam)
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
    End Sub
End Class