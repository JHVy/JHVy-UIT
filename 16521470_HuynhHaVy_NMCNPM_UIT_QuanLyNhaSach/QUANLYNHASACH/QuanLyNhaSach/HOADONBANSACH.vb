Imports DTO.HoadonDTO
Imports DTO.ChitiethoadonDTO
Imports DTO.SachDTO
Imports DTO.KhachhangDTO
Imports DTO.NhanvienDTO
Imports BUS.HoadonBUS
Imports BUS.SachBUS
Imports BUS.KhachhangBUS
Imports BUS.NhanvienBUS
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
    Dim nv As New NhanvienDTO
    Dim sach As New SachDTO
    Dim sachbus As New SachBUS
    Dim nhanvienbus As New NhanvienBUS
    Dim notoida As Integer
    Dim nokhachhang As Single
    Dim tonsauban As Integer
    Dim mcthd As String
    Dim soluongton As Integer
    Dim luongtonmoi As Integer
    Dim tongthanhtien As Single
    Dim sotienno As Single
    Dim slb As Integer
    Dim dongiaban As Integer
    'Hiển thị thông tin hóa đơn lên datagridview
    Public Sub hienthithongtinhoadon()
        Luoi.DataSource = hoadonbus.Hienthithongtinhoadon()
    End Sub
    'Hiển thị thông tin chi tiết hóa đơn lên datagridview
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
    'Thêm hóa dơn
    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        Dim dtts As DataTable = thamsobus.Taithamso()
        notoida = Single.Parse(dtts.Rows(0).Item(4).ToString())
        'Kiểm tra mã khách hàng không được để trống
        If (makhachhang.Text = Nothing) Then
            MessageBox.Show("Mã khách hàng không được để trống !")
            Return
        End If
        'Lấy mã khách hàng
        kh.Makhachhang = makhachhang.Text.Trim
        Dim dskh As DataTable = khachhangbus.Timkiemtheomakhachhang(kh)
        nokhachhang = Single.Parse(dskh.Rows(0).Item(5).ToString())
        Size = New Size(1130, 625)
        mahoadon.Text = hoadondal.Tangmahd()
        'Lấy mã hóa đơn
        hd.Mahoadon = mahoadon.Text.Trim
        'Lấy mã nhân viên
        If (manhanvien.Text = Nothing) Then
            MessageBox.Show("Mã nhân viên không được để trống !")
            Return
        End If
        nv.Manhanvien = manhanvien.Text.Trim
        Dim dsnv As DataTable = nhanvienbus.Timkiemtheomanhanvien(nv)
        'Lấy ngày lập hóa đơn
        Ngay.Format = DateTimePickerFormat.Custom
        Ngay.CustomFormat = "MM/dd/yy"
        Ngay.Format = DateTimePickerFormat.Short
        hd.Ngaylaphoadon = Ngay.Text.Trim
        'Lấy mã khách hàng trong hóa đơn
        hd.Makhachhang = makhachhang.Text.Trim
        'Lấy mã nhân viên trong hóa đơn
        hd.Manhanvienlap = manhanvien.Text.Trim
        'Lấy tổng thành tiền
        hd.Tongthanhtien = 0
        'Kiểm tra qui định số tiền nợ tối đa
        If nokhachhang > notoida Then
            MessageBox.Show("Số tiền nợ đã vượt quá số tiền nợ tối đa !")
            Return
        Else
            Dim ketQua As String = hoadondal.Themhoadon(hd)
            If (ketQua = "Success") Then
                MessageBox.Show("Tạo phiếu thành công !")
            Else
                MessageBox.Show(ketQua)
            End If
            hienthithongtinhoadon()
        End If
    End Sub
    'Lấy mã khách hàng từ form QUANLYKHACHHANG
    Private Sub Chon_Click(sender As Object, e As EventArgs) Handles Chon.Click
        Dim f As New QUANLYKHACHHANG
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            makhachhang.Text = f.makhachhang.Text
        End If
    End Sub
    'Thêm chi tiết hóa đơn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Them1.Click
        If Themmessage() = True Then
            'Tải dữ liệu tham số
            Dim dtts As DataTable = thamsobus.Taithamso()
            'Lấy số lượng tồn tối thiểu sau khi bán
            tonsauban = Single.Parse(dtts.Rows(0).Item(3).ToString())
            'Lấy giá trị của chi tiết hóa đơn mã chi tiết hóa đơn,mã sách, số lượng bán, Đơn giá bán
            mcthd = hoadondal.Tangmacthd
            cthd.Machitiethoadon = mcthd
            cthd.Mahoadon = mahoadon1.Text.Trim
            cthd.Masach = masach.Text.Trim
            cthd.Soluongban = soluong.Text.Trim
            cthd.Dongiaban = dongia.Text.Trim
            sach.Masach = masach.Text.Trim
            'Tải dữ liệu sách
            Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
            'Lấy số lượng tồn của sách
            soluongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
            'Tính số lượng tồn mới
            luongtonmoi = soluongton - cthd.Soluongban
            'Kiểm tra quy định số lượng tồn tối thiểu sau bán
            If (soluongton - cthd.Soluongban) < tonsauban Then
                MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định !")
                Return
            End If
            Dim ketqua As String = hoadonbus.Themchitiethoadon(cthd)
            If ketqua <> "Success" Then
                MessageBox.Show(ketqua)
                Return
            Else
                'Cập nhật lại số lượng tồn của sách
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
                hd.Mahoadon = mahoadon1.Text.Trim
                'Cập nhật tổng thành tiền của hóa đơn
                Dim dshd As DataTable = hoadonbus.Timhoadontheoma(hd)
                tongthanhtien = Single.Parse(dshd.Rows(0).Item(3).ToString)
                hd.Tongthanhtien = tongthanhtien + (cthd.Soluongban * cthd.Dongiaban)
                hoadonbus.Capnhattongthanhtien(hd)
                'Cập nhật lại số tiền nợ của khách hàng
                kh.Makhachhang = dshd.Rows(0).Item(1).ToString
                kh.Sotienno = nokhachhang + hd.Tongthanhtien
                khachhangbus.Capnhatsotienno(kh)
                hienthichitiethoadon()
                hienthithongtinhoadon()
            End If
        End If
    End Sub
    'Lấy mã sách từ form QUANLYSACH 
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
        manhanvien.DataBindings.Clear()
        manhanvien.DataBindings.Add("Text", Luoi.DataSource, "Manhanvienlap")
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
    'Thông báo khi nhấn nút thêm
    Public Function Themmessage() As Boolean
        Dim message As String = "Bạn có thật sự muốn thêm hay không ?"
        Dim caption As String = "Thêm CT"
        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    'Xóa hóa đơn
    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        hd.Mahoadon = mahoadon.Text.Trim
        cthd.Mahoadon = mahoadon.Text.Trim
        Dim dt1 As DataTable = hoadondal.Timchitiethoadon(cthd)
        'Cập nhật lại số lượng tồn sau khi xóa
        For i As Integer = 0 To dt1.Rows.Count - 1
            sach.Masach = dt1.Rows(0).Item(2).ToString
            Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
            soluongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
            Dim slb As Integer = Integer.Parse(dt1.Rows(i).Item(3).ToString())

            If slb < soluongton Then
                luongtonmoi = soluongton + slb
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
            Else
                luongtonmoi = 0
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
            End If
        Next
        'Cập nhật lại số tiền nợ của khách hàng sau khi xóa
        Dim dt2 As DataTable = hoadondal.Timhoadontheoma(hd)
        For i As Integer = 0 To dt2.Rows.Count - 1
            kh.Makhachhang = dt2.Rows(i).Item(1).ToString
            Dim dt As DataTable = khachhangbus.Timkiemtheomakhachhang(kh)
            sotienno = Single.Parse(dt.Rows(0).Item(5).ToString())
            Dim tt As Single = Single.Parse(dt2.Rows(i).Item(3).ToString())
            If tt < sotienno Then
                kh.Sotienno = sotienno - tt
                khachhangbus.Capnhatsotienno(kh)
            Else
                kh.Sotienno = 0
                khachhangbus.Capnhatsotienno(kh)
            End If
        Next
        Dim ketqua As String = hoadonbus.Xoachitiethoadon(cthd)
        If ketqua <> "Success" Then
            MessageBox.Show(ketqua)
            Return
        Else
            Dim ketqua1 As String = hoadonbus.Xoahoadon(hd)
            If ketqua1 <> "Success" Then
                MessageBox.Show(ketqua)
            Else
                MessageBox.Show("Xóa thành công !")
            End If
        End If
        hienthithongtinhoadon()
        hienthichitiethoadon()
    End Sub
    'Xóa chi tiết hóa đơn
    Private Sub XoaCT_Click(sender As Object, e As EventArgs) Handles XoaCT.Click
        hd.Mahoadon = mahoadon.Text.Trim
        cthd.Mahoadon = mahoadon1.Text.Trim
        cthd.Masach = masach.Text.Trim
        sach.Masach = masach.Text.Trim
        'Cập nhật lại số lượng tồn của sách sau khi xóa
        Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
        soluongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
        slb = Integer.Parse(soluong.Text.Trim)
        dongiaban = Integer.Parse(dongia.Text.Trim)
        If slb < soluongton Then
            luongtonmoi = soluongton + slb
            sach.Soluongton = Integer.Parse(luongtonmoi)
            sachbus.Capnhatsoluongton(sach)
        Else
            luongtonmoi = 0
            sach.Soluongton = Integer.Parse(luongtonmoi)
            sachbus.Capnhatsoluongton(sach)
        End If
        'Cập nhật lại số tiền nợ của khách hàng sau khi xoa
        kh.Makhachhang = makhachhang.Text.Trim
        tongthanhtien = slb * dongiaban
        Dim dt1 As DataTable = khachhangbus.Timkiemtheomakhachhang(kh)
        sotienno = Single.Parse(dt1.Rows(0).Item(5).ToString())
        Dim tt As Single = Single.Parse(tthanhtien.Text.Trim)
        tongthanhtien = tt - (slb * dongiaban)
        hd.Tongthanhtien = tongthanhtien
        hoadondal.Capnhattongthanhtien(hd)
        If tongthanhtien < sotienno Then
            kh.Sotienno = sotienno - (slb * dongiaban)
            khachhangbus.Capnhatsotienno(kh)
        Else
            kh.Sotienno = 0
            khachhangbus.Capnhatsotienno(kh)
        End If
        Dim ketqua As String = hoadonbus.Xoachitiethoadontheoma(cthd)
        If ketqua <> "Success" Then
            MessageBox.Show(ketqua)
            Return
        Else
            MessageBox.Show("Xóa thành công !")
        End If
        hienthithongtinhoadon()
        hienthichitiethoadon()
    End Sub

    Private Sub Chon2_Click(sender As Object, e As EventArgs) Handles Chon2.Click
        Dim f As New QUANLYNHANVIEN
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            manhanvien.Text = f.manhanvien.Text
        End If
    End Sub
End Class