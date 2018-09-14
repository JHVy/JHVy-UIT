Imports DTO.HoadonDTO
Imports DTO.ChitiethoadonDTO
Imports DAL.HoadonDAL

Namespace HoadonBUS
    Public Class HoadonBUS
        Dim hoadondal As New HoadonDAL
        'Hiển thị hóa đơn
        Public Function Hienthithongtinhoadon()
            Return hoadondal.Hienthihoadon()
        End Function
        'Hiển thị chi tiết hóa đơn
        Public Function Hienthichitiethoadon(ByVal cthd As ChitiethoadonDTO)
            Return hoadondal.Hienthichitiethoadon(cthd)
        End Function
        'Thêm hóa đơn
        Public Function Themhoadon(ByVal hd As HoadonDTO) As String
            Return hoadondal.Themhoadon(hd)
        End Function
        'Thêm chi tiết hóa đơn
        Public Function Themchitiethoadon(ByVal cthd As ChitiethoadonDTO) As String
            If hoadondal.Timhoadon(cthd) = Nothing Then
                Return hoadondal.Themchitiethoadon(cthd)
            Else
                Return "Sách đã có trong chi tiết hóa đơn"
            End If
        End Function
        'Cập nhật tổng thành tiền
        Public Function Capnhattongthanhtien(ByVal hd As HoadonDTO) As String
            Return hoadondal.Capnhattongthanhtien(hd)
        End Function
        'Tìm hóa đơn theo mã hóa đơn
        Public Function Timhoadontheoma(ByVal hd As HoadonDTO)
            Return hoadondal.Timhoadontheoma(hd)
        End Function
        'Tìm hóa đơn theo tháng và năm
        Public Function Timkiemhoadontheothangvanam(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return hoadondal.Timhoadontheothangvanam(makhachhang, thang, nam)
        End Function
        'Tìm chi tiết hóa đơn
        Public Function Timchitiethoadon(ByVal cthd As ChitiethoadonDTO)
            Return hoadondal.Timchitiethoadon(cthd)
        End Function
        'Tính tổng số lượng bán
        Public Function Tongsoluongban(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer)
            Return hoadondal.Tongsoluongban(masach, thang, nam)
        End Function
        'Tính tổng thành tiền
        Public Function Tongthanhtien(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return hoadondal.Tongthanhtien(makhachhang, thang, nam)
        End Function
        'Xóa hóa đơn
        Public Function Xoahoadon(ByVal hd As HoadonDTO) As String
            Return hoadondal.Xoahoadon(hd)
        End Function
        'Xóa chi tiết hóa đơn
        Public Function Xoachitiethoadon(ByVal cthd As ChitiethoadonDTO) As String
            Return hoadondal.Xoachitiethoadon(cthd)
        End Function
        'Xóa chi tiết hóa đơn theo mã sách
        Public Function Xoachitiethoadontheoma(ByVal cthd As ChitiethoadonDTO) As String
            Return hoadondal.Xoachitiethoadontheomasach(cthd)
        End Function
    End Class
End Namespace

