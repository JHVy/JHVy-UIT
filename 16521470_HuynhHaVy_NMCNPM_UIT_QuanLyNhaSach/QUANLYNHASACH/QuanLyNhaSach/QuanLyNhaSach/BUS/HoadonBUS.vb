Imports DTO.HoadonDTO
Imports DTO.ChitiethoadonDTO
Imports DAL.HoadonDAL

Namespace HoadonBUS
    Public Class HoadonBUS
        Dim hoadondal As New HoadonDAL
        Public Function Hienthithongtinhoadon()
            Return hoadondal.Hienthihoadon()
        End Function

        Public Function Hienthichitiethoadon(ByVal cthd As ChitiethoadonDTO)
            Return hoadondal.Hienthichitiethoadon(cthd)
        End Function

        Public Function Themhoadon(ByVal hd As HoadonDTO) As String
            Return hoadondal.Themhoadon(hd)
        End Function

        Public Function Themchitiethoadon(ByVal cthd As ChitiethoadonDTO) As String
            If hoadondal.Timhoadon(cthd) = Nothing Then
                Return hoadondal.Themchitiethoadon(cthd)
            Else
                Return "Sách đã có trong chi tiết hóa đơn"
            End If
        End Function

        Public Function Capnhattongthanhtien(ByVal hd As HoadonDTO) As String
            Return hoadondal.Capnhattongthanhtien(hd)
        End Function

        Public Function Timhoadontheoma(ByVal hd As HoadonDTO)
            Return hoadondal.Timhoadontheoma(hd)
        End Function

        Public Function Tongsoluongban(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer)
            Return hoadondal.Tongsoluongban(masach, thang, nam)
        End Function

        Public Function Tongthanhtien(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return hoadondal.Tongthanhtien(makhachhang, thang, nam)
        End Function

        Public Function Timkiemhoadontheothangvanam(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return hoadondal.Timhoadontheothangvanam(makhachhang, thang, nam)
        End Function
    End Class
End Namespace

