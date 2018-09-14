Imports DTO.PhieuNhapDTO
Imports DTO.ChitietphieunhapDTO
Imports DAL.PhieuNhapDaL
Namespace PhieuNhapBUS
     public Class PhieunhapBUS
        Dim phieunhapdal As New PhieuNhapDAL
        'Hiển thị thông tin phiếu nhập
        Public Function Hienthithongtinphieunhap()
            Return phieunhapdal.Hienthithongtinphieunhap()
        End Function
        'Hiển thị chi tiết phiếu nhập
        Public Function Hienthichitietphieunhap(ByVal ctpn As ChitietphieunhapDTO)
            Return phieunhapdal.Hienthichitietphieunhap(ctpn)
        End Function
        'Thêm phiếu nhập
        Public Function Themphieunhap(ByVal pn As PhieuNhapDTO) As String
            Return phieunhapdal.Themphieunhap(pn)
        End Function
        'Thêm chi tiết phiếu nhập
        Public Function Themchitietphieunhap(ByVal ctpn As ChitietphieunhapDTO) As String
            If phieunhapdal.Timphieunhap(ctpn) = Nothing Then
                Return phieunhapdal.Themchitietphieunhap(ctpn)
            Else
                Return "Sách này đã có trong chi tiet phieu nhap"
            End If

        End Function
        'Tính tổng lượng nhập theo sách
        Public Function Tongluongnhaptheosach(ByVal masach As String, ByVal thang As String, ByVal nam As String)
            Return phieunhapdal.Tongluongnhaptheosach(masach, thang, nam)
        End Function
        'tìm phiếu nhập theo tháng và năm
        Public Function Timkiemphieunhaptheothangvanam(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer)
            Return phieunhapdal.timphieunhaptheothangvanam(masach, thang, nam)
        End Function
        'tìm phiếu nhập theo mã phiếu nhập
        Public Function Timphieunhap(ByVal ctpn As ChitietphieunhapDTO)
            Return phieunhapdal.Timphieunhap1(ctpn)
        End Function
        'Xóa phiếu nhập
        Public Function Xoaphieunhap(ByVal pn As PhieuNhapDTO) As String
            Return phieunhapdal.Xoaphieunhap(pn)
        End Function
        'Xóa chi tiết phiếu nhập
        Public Function Xoachitietphieunhap(ByVal ctpn As ChitietphieunhapDTO) As String
            Return phieunhapdal.Xoachitietphieunhap(ctpn)
        End Function
        'Xóa chi tiết phiếu nhập theo mã sách
        Public Function Xoachitietphieunhaptheomasach(ByVal ctpn As ChitietphieunhapDTO) As String
            Return phieunhapdal.Xoachitietphieunaptheomasach(ctpn)
        End Function
    End Class
End Namespace

