Imports DTO.HoadonDTO
Imports DTO.ChitiethoadonDTO
Imports DTO.SachDTO
Imports DTO.KhachhangDTO
Imports BUS.HoadonBUS
Imports BUS.SachBUS
Imports BUS.KhachhangBUS
Imports BUS.ThamsoBUS
Imports DAL.HoadonDAL
Public Class HOADONBANSACH
    Dim hoadonbus As New HoadonBUS
    Dim cthd As New ChitiethoadonDTO
    Dim hoadondal As New HoadonDAL
    Dim hd As New HoadonDTO
    Dim thamsobus As New ThamsoBUS
    Dim khachhangbus As New KhachhangBUS
    Dim kh As New KhachhangDTO
    Dim sach As New SachDTO
    Dim sachbus As New SachBUS
    Dim notoida As Integer
    Dim nokhachhang As Single
    Dim tonsauban As Integer
    Dim mcthd As String
    Dim soluongton As Integer
    Dim luongtonmoi As Integer
    Dim tongthanhtien As Single
    Public Sub hienthithongtinhoadon()
        Luoi.DataSource = hoadonbus.Hienthithongtinhoadon()
    End Sub

    Public Sub hienthichitiethoadon()
        Luoi1.DataSource = hoadonbus.Hienthichitiethoadon(cthd)
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

    Private Sub Dong_Click(sender As Object, e As EventArgs) Handles Dong.Click
        Size = New Size(557, 625)
    End Sub

    Private Sub Chitiet_Click(sender As Object, e As EventArgs) Handles Chitiet.Click
        Size = New Size(1130, 625)
    End Sub

    Private Sub HOADONBANSACH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(557, 625)
        tthanhtien.Text = "0"
        hienthithongtinhoadon()
        Ngay.Value = DateTime.Now
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        Dim dtts As DataTable = thamsobus.Taithamso()
        notoida = Single.Parse(dtts.Rows(0).Item(4).ToString())
        If (makhachhang.Text = Nothing) Then
            MessageBox.Show("Mã khách hàng không được dể trống")
            Return
        End If
        kh.Makhachhang = makhachhang.Text.Trim
        Dim dskh As DataTable = khachhangbus.Timkiemtheomakhachhang(kh)
        nokhachhang = Single.Parse(dskh.Rows(0).Item(5).ToString())
        Size = New Size(1130, 625)
        mahoadon.Text = hoadondal.Tangmahd
        hd.Mahoadon = mahoadon.Text.Trim
        Ngay.Format = DateTimePickerFormat.Custom
        Ngay.CustomFormat = "MM/dd/yy"
        Ngay.Format = DateTimePickerFormat.Short
        hd.Ngaylaphoadon = Ngay.Text.Trim
        hd.Makhachhang = makhachhang.Text.Trim
        hd.Tongthanhtien = Integer.Parse(tthanhtien.Text.Trim)
        If nokhachhang > notoida Then
            MessageBox.Show("Số tiền nợ đã vượt quá số tiền nợ tối đa")
            Return
        Else
            Dim ketQua As String = hoadondal.Themhoadon(hd)
            If (ketQua = "Success") Then
                MessageBox.Show("Tạo phiếu thành công")
            Else
                MessageBox.Show(ketQua)
            End If
            hienthithongtinhoadon()
        End If
    End Sub

    Private Sub Chon_Click(sender As Object, e As EventArgs) Handles Chon.Click
        Dim f As New QUANLYKHACHHANG
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            makhachhang.Text = f.makhachhang.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Them1.Click
        If Themmessage() = True Then
            Dim dtts As DataTable = thamsobus.Taithamso()
            tonsauban = Single.Parse(dtts.Rows(0).Item(3).ToString())
            mcthd = hoadondal.Tangmacthd
            cthd.Machitiethoadon = mcthd
            cthd.Mahoadon = mahoadon1.Text.Trim
            cthd.Masach = masach.Text.Trim
            cthd.Soluongban = soluong.Text.Trim
            cthd.Dongiaban = dongia.Text.Trim
            sach.Masach = masach.Text.Trim
            Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
            soluongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
            luongtonmoi = soluongton - cthd.Soluongban
            If (soluongton - cthd.Soluongban) < tonsauban Then
                MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định")
                Return
            End If
            Dim ketqua As String = hoadonbus.Themchitiethoadon(cthd)
            If ketqua <> "Success" Then
                MessageBox.Show(ketqua)
                Return
            Else
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
                hd.Mahoadon = mahoadon1.Text.Trim
                Dim dshd As DataTable = hoadonbus.Timhoadontheoma(hd)
                tongthanhtien = Single.Parse(dshd.Rows(0).Item(3).ToString)
                hd.Tongthanhtien = tongthanhtien + (cthd.Soluongban * cthd.Dongiaban)
                hoadonbus.Capnhattongthanhtien(hd)
                kh.Makhachhang = dshd.Rows(0).Item(1).ToString
                kh.Sotienno = nokhachhang + hd.Tongthanhtien
                khachhangbus.Capnhatsotienno(kh)
                hienthichitiethoadon()
                hienthithongtinhoadon()
            End If
        End If
    End Sub

    Private Sub Chon1_Click(sender As Object, e As EventArgs) Handles Chon1.Click
        Dim f As New QUANLYSACH
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            masach.Text = f.masach.Text
        End If
    End Sub

    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi.RowEnter
        Dim dong As Integer = e.RowIndex
        makhachhang.DataBindings.Clear()
        makhachhang.DataBindings.Add("Text", Luoi.DataSource, "Makhachhang")
        mahoadon.DataBindings.Clear()
        mahoadon.DataBindings.Add("Text", Luoi.DataSource, "Mahoadon")
        mahoadon1.DataBindings.Clear()
        mahoadon1.DataBindings.Add("Text", Luoi.DataSource, "Mahoadon")
        Ngay.DataBindings.Clear()
        Ngay.DataBindings.Add("Text", Luoi.DataSource, "Ngaylaphoadon")
        tthanhtien.DataBindings.Clear()
        tthanhtien.DataBindings.Add("Text", Luoi.DataSource, "Tongthanhtien")
        cthd.Mahoadon = Luoi.Rows(dong).Cells(0).Value.ToString()
        hienthichitiethoadon()
    End Sub

    Private Sub Luoi1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi1.RowEnter
        Dim dong As Integer = e.RowIndex
        mahoadon1.DataBindings.Clear()
        mahoadon1.DataBindings.Add("Text", Luoi1.DataSource, "Mahoadon")
        masach.DataBindings.Clear()
        masach.DataBindings.Add("Text", Luoi1.DataSource, "Masach")
        dongia.DataBindings.Clear()
        dongia.DataBindings.Add("Text", Luoi1.DataSource, "Dongiaban")
        soluong.DataBindings.Clear()
        soluong.DataBindings.Add("Text", Luoi1.DataSource, "Soluongban")
        mcthd = Luoi1.Rows(dong).Cells(0).Value.ToString
    End Sub

    Private Sub Xoatrang_Click(sender As Object, e As EventArgs) Handles Xoatrang.Click
        dongia.Clear()
        soluong.Clear()
    End Sub

    Public Function Themmessage() As Boolean
        Dim message As String = "Bạn có thật sự muốn thêm hay không?"
        Dim caption As String = "Thêm CT"
        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
End Class