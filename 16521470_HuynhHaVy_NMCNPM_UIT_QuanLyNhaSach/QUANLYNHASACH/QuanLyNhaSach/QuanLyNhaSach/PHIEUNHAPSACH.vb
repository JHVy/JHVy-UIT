Imports DTO.PhieuNhapDTO
Imports DTO.ChitietphieunhapDTO
Imports DTO.SachDTO
Imports BUS.PhieuNhapBUS
Imports BUS.SachBUS
Imports BUS.ThamsoBUS
Imports DAL.PhieuNhapDaL
Public Class PHIEUNHAPSACH
    Dim phieunhapbus As New PhieunhapBUS
    Dim ctpn As New ChitietphieunhapDTO
    Dim pn As New PhieuNhapDTO
    Dim phieunhapdal As New PhieuNhapDAL
    Dim sachbus As New SachBUS
    Dim sach As New SachDTO
    Dim thamsobus As New ThamsoBUS
    Dim luongton As Integer
    Dim luongtontam As Integer
    Dim luongtonmoi As Integer
    Dim nhapitnhat As Integer
    Dim luongtonmax As Integer
    Dim mact As String
    'Hiển thị thông tin phiếu nhập lên datagridview
    Public Sub hienthithongtinphieunhap()
        Luoi.DataSource = phieunhapbus.Hienthithongtinphieunhap
    End Sub
    'Hiển thị thông tin chi tiết phiếu nhập lên datagridview
    Public Sub hienthichitietphieunhap()
        Luoi1.DataSource = phieunhapbus.Hienthichitietphieunhap(ctpn)
    End Sub

    Private Sub PHIEUNHAPSACH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(557, 625)
        hienthithongtinphieunhap()
        Ngay.Value = DateTime.Now
    End Sub

    Private Sub Dong_Click(sender As Object, e As EventArgs) Handles Dong.Click
        Size = New Size(557, 625)
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Close()
    End Sub

    Private Sub Luoi_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi.RowEnter
        Dim dong As Integer = e.RowIndex
        maphieunhap.DataBindings.Clear()
        maphieunhap.DataBindings.Add("Text", Luoi.DataSource, "Maphieunhap")
        Ngay.DataBindings.Clear()
        Ngay.DataBindings.Add("Text", Luoi.DataSource, "Ngaynhap")
        maphieunhap1.DataBindings.Clear()
        maphieunhap1.DataBindings.Add("Text", Luoi.DataSource, "Maphieunhap")
        ctpn.Maphieunhap = Luoi.Rows(dong).Cells(0).Value.ToString()
        hienthichitietphieunhap()
    End Sub

    Private Sub Luoi1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi1.RowEnter
        Dim dong As Integer = e.RowIndex
        maphieunhap1.DataBindings.Clear()
        maphieunhap1.DataBindings.Add("Text", Luoi1.DataSource, "Maphieunhap")
        soluongnhap.DataBindings.Clear()
        soluongnhap.DataBindings.Add("Text", Luoi1.DataSource, "Soluongnhap")
        masach.DataBindings.Clear()
        masach.DataBindings.Add("Text", Luoi1.DataSource, "Masach")
    End Sub
    'Thêm phiếu nhập
    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        Size = New Size(1130, 625)
        maphieunhap.Text = phieunhapdal.Tangmapn()
        pn.Maphieunhap = maphieunhap.Text.Trim
        Ngay.Format = DateTimePickerFormat.Custom
        Ngay.CustomFormat = "MM/dd/yy"
        pn.Ngaynhap = Ngay.Text.Trim
        Ngay.Format = DateTimePickerFormat.Short
        Dim ketQua As String = phieunhapbus.Themphieunhap(pn)
        If (ketQua = "Success") Then
            MessageBox.Show("Tạo phiếu thành công")
        Else
            MessageBox.Show(ketQua)
        End If
        hienthithongtinphieunhap()
    End Sub

    Private Sub Chitiet_Click(sender As Object, e As EventArgs) Handles Chitiet.Click
        Size = New Size(1130, 625)
    End Sub
    'Lấy ma sách từ form QUANLYSACH
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New QUANLYSACH
        f.ShowDialog()
        If (f.DialogResult = DialogResult.OK) Then
            masach.Text = f.masach.Text
        End If
    End Sub
    ' hàm Thêm chi tiết phiếu nhập
    Public Function Themchitietphieunhap()
        If Themmessage() = True Then
            'Tải dữ liệu tham số
            Dim dtts As DataTable = thamsobus.Taithamso()
            nhapitnhat = Integer.Parse(dtts.Rows(0).Item(1).ToString())
            luongtonmax = Integer.Parse(dtts.Rows(0).Item(2).ToString())
            mact = phieunhapdal.Tangmactpn()
            ctpn.Machitiet = mact
            ctpn.Maphieunhap = maphieunhap1.Text.Trim
            ctpn.Masach = masach.Text.Trim
            'Kiểm tra quy định số lượng nhập tối thiểu
            Try
                If (Integer.Parse(soluongnhap.Text.Trim) < nhapitnhat) Then
                    MessageBox.Show(String.Format("Số lượng phải lớn hơn số lượng quy định ({0} quyển)", nhapitnhat))
                    Return 0
                Else
                    ctpn.Soluongnhap = soluongnhap.Text.Trim
                End If
            Catch generatedExceptionName As FormatException
                MessageBox.Show("Số lượng phải là kiểu số")
                soluongnhap.Focus()
                Return 0
            End Try
            sach.Masach = masach.Text.Trim
            'Lấy số lượng tồn của sachs
            Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
            luongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
            luongtontam = luongton
            'Tính số lượng tồn mới
            luongtonmoi = luongton + Integer.Parse(soluongnhap.Text.Trim)
            'Kiểm tra qui định số lượng tồn tối đa trước nhập
            If luongton < luongtonmax Then
                Dim ketqua As String = phieunhapbus.Themchitietphieunhap(ctpn)
                If ketqua <> "Success" Then
                    MessageBox.Show(ketqua)
                    Return 0
                Else
                    sach.Soluongton = Integer.Parse(luongtonmoi)
                    sachbus.Capnhatsoluongton(sach)
                    hienthichitietphieunhap()
                End If
            Else
                MessageBox.Show("Chỉ nhập các đầu sách có lượng tồn ít hơn theo quy định")
            End If
        End If
        Return 1
    End Function
    'Thêm chi tiết phiếu nhập
    Private Sub Them1_Click(sender As Object, e As EventArgs) Handles Them1.Click
        Themchitietphieunhap()
    End Sub

    Private Sub Xoatrang_Click(sender As Object, e As EventArgs) Handles Xoatrang.Click
        soluongnhap.Clear()
    End Sub
    'Hiển thị thông báo khi nhấn nút thêm
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
    'Xóa phiếu nhập
    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        pn.Maphieunhap = maphieunhap.Text.Trim
        ctpn.Maphieunhap = maphieunhap.Text.Trim
        Dim dt1 As DataTable = phieunhapdal.Timphieunhap1(ctpn)
        'Cập nhật số lượng tồn sau khi xóa
        For i As Integer = 0 To dt1.Rows.Count - 1
            sach.Masach = dt1.Rows(i).Item(2).ToString
            Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
            luongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
            Dim sln As Integer = Integer.Parse(dt1.Rows(i).Item(3).ToString())
            If sln < luongton Then
                luongtonmoi = luongton - sln
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
            Else
                luongtonmoi = 0
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
            End If
        Next
        Dim ketqua As String = phieunhapbus.Xoachitietphieunhap(ctpn)
        If ketqua <> "Success" Then
            MessageBox.Show(ketqua)
            Return
        Else
            Dim ketqua1 As String = phieunhapbus.Xoaphieunhap(pn)
            If ketqua1 <> "Success" Then
                MessageBox.Show(ketqua)
            Else
                MessageBox.Show("Xóa thành công")
            End If
        End If
        hienthithongtinphieunhap()
        hienthichitietphieunhap()
    End Sub
    'Xóa chi tiết phiếu nhập
    Private Sub XoaCT_Click(sender As Object, e As EventArgs) Handles XoaCT.Click
        pn.Maphieunhap = maphieunhap.Text.Trim
        ctpn.Maphieunhap = maphieunhap1.Text.Trim
        ctpn.Masach = masach.Text.Trim
        'Cập nhật số lượng tồn sau khi xóa
        Dim dt1 As DataTable = phieunhapdal.Timphieunhap1(ctpn)
        sach.Masach = masach.Text.Trim
        Dim dt As DataTable = sachbus.Timkiemtheomasach(sach)
        luongton = Integer.Parse(dt.Rows(0).Item(4).ToString())
        Dim sln As Integer = soluongnhap.Text.Trim

            If sln < luongton Then
                luongtonmoi = luongton - sln
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
            Else
                luongtonmoi = 0
                sach.Soluongton = Integer.Parse(luongtonmoi)
                sachbus.Capnhatsoluongton(sach)
            End If
        Dim ketqua As String = phieunhapbus.Xoachitietphieunhaptheomasach(ctpn)
        If ketqua <> "Success" Then
            MessageBox.Show(ketqua)
            Return
        Else
            MessageBox.Show("Xóa thành công")
        End If
        hienthichitietphieunhap()
    End Sub
End Class