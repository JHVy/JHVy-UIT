Imports DTO.PhieuNhapDTO
Imports DTO.ChitietphieunhapDTO
Imports DAL.PhieuNhapDaL
Namespace PhieuNhapBUS
     public Class PhieunhapBUS
        Dim phieunhapdal As New PhieuNhapDAL
        Public Function Hienthithongtinphieunhap()
            Return phieunhapdal.Hienthithongtinphieunhap()
        End Function

        Public Function Hienthichitietphieunhap(ByVal ctpn As ChitietphieunhapDTO)
            Return phieunhapdal.Hienthichitietphieunhap(ctpn)
        End Function

        Public Function Themphieunhap(ByVal pn As PhieuNhapDTO) As String
            Return phieunhapdal.Themphieunhap(pn)
        End Function

        Public Function Themchitietphieunhap(ByVal ctpn As ChitietphieunhapDTO) As String
            If phieunhapdal.Timphieunhap(ctpn) = Nothing Then
                Return phieunhapdal.Themchitietphieunhap(ctpn)
            Else
                Return "Sách này đã có trong chi tiet phieu nhap"
            End If

        End Function

        Public Function Tongluongnhaptheothang(ByVal masach As String, ByVal thang As String, ByVal nam As String)
            Return phieunhapdal.Tongluongnhaptheosach(masach, thang, nam)
        End Function

        Public Function Timkiemphieunhaptheothangvanam(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer)
            Return phieunhapdal.timphieunhaptheothangvanam(masach, thang, nam)
        End Function
    End Class
End Namespace

