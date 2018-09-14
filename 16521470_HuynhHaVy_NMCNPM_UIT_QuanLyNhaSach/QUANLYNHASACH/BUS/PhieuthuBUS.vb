Imports DTO.PhieuthuDTO
Imports DAL.PhieuthuDAL
Namespace PhieuthuBUS
    Public Class PhieuthuBUS
        Dim phieuthudal As New PhieuthuDAL
        'Hiển thị dữ liệu phiếu thu
        Public Function Taidulieuphieuthu()
            Return phieuthudal.Taidulieuphieuthu()
        End Function
        'Thêm phiếu thu
        Public Function Themphieuthu(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Themphieuthu(pt)
        End Function
        'Xóa phiếu thu
        Public Function Xoaphieuthu(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Xoaphieuthu(pt)
        End Function
        'Sửa phiếu thu
        Public Function Suaphieuthu(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Suaphieuthu(pt)
        End Function
        'Tính tổng số tiền thu
        Public Function Tongsotienthu(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return phieuthudal.Tongsotienthu(makhachhang, thang, nam)
        End Function
        'Tìm kiếm phiếu thu theo mã khách hàng và ngày thu tiền
        Public Function Timkiemmakhachhangtheongay(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Timkiemkhachhangtheongay(pt)
        End Function
        'Tìm kiếm phiếu thu theo mã khách hàng
        Public Function Timkiemmakhachhang(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Timkiemmakhachhang(pt)
        End Function
    End Class
End Namespace