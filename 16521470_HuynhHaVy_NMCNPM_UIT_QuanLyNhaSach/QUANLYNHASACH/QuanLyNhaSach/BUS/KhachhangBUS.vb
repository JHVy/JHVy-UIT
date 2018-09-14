Imports DTO.KhachhangDTO
Imports DAL.KhachhangDAL
Namespace KhachhangBUS
    Public Class KhachhangBUS
        Dim KhachhangDAL As New KhachhangDAL
        'Hiển thị dữ liệu khách hàng
        Public Function Taidulieu()
            Return KhachhangDAL.Taidulieu()
        End Function
        'Thêm khách hàng
        Public Function Themkhachhang(ByVal k As KhachhangDTO) As String
            Return KhachhangDAL.Them(k)
        End Function
        'Xóa khách hàng
        Public Function Xoakhachhang(ByVal k As KhachhangDTO) As String
            Return KhachhangDAL.Xoa(k)
        End Function
        'Sửa khách hàng
        Public Function Suakhachhang(ByVal k As KhachhangDTO) As String
            Return KhachhangDAL.Sua(k)
        End Function
        'Cập nhật số tiền nợ
        Public Function Capnhatsotienno(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Capnhatsotienno(k)
        End Function
        'Tìm kiếm khách hàng theo mã khách hàng
        Public Function Timkiemtheomakhachhang(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemtheomakhachhang(k)
        End Function
        'Lấy mã khách hàng từ bảng KHACHHANG
        Public Function Timkiemmakhachhang()
            Return KhachhangDAL.Timkiemmakhachhang()
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng 
        Public Function Timkiemtenkhachhang(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemtenkhachhang(k)
        End Function
        'Tìm kiếm khách hàng theo địa chỉ
        Public Function Timkiemdiachi(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemdiachi(k)
        End Function
        'Tìm kiếm khách hàng theo điện thoại
        Public Function Timkiemdienthoai(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemdienthoai(k)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng và Điện thoại
        Public Function Timkiemtenkhachhangvadienthoai(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemtenkhachhangvadienthoai(k)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng và địa chỉ
        Public Function Timkiemtenkhachhangvadiachi(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemtenkhachhangvadiachi(k)
        End Function
        'Tìm kiếm khách hàng theo địa chỉ và điện thoại
        Public Function Timkiemtendienthoaivadiachi(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemdiachivadienthoai(k)
        End Function
        'Tìm kiếm khách hàng theo tên khách hàng, địa chỉ và điện thoại
        Public Function Timkiemtentenkhachhangvadienthoaivadiachi(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemtenkhachhangvadiachivadienthoai(k)
        End Function
    End Class
End Namespace
