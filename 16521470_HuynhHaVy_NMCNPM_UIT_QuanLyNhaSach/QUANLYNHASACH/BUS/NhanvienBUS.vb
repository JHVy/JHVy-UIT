Imports DTO.NhanvienDTO
Imports DAL.NhanvienDAL
Namespace NhanvienBUS

    Public Class NhanvienBUS

        Dim NhanvienDAL As New NhanvienDAL
        'Hiển thị dữ liệu nhân viên
        Public Function Taidulieu()
            Return NhanvienDAL.Taidulieu()
        End Function
        'Thêm nhân viên
        Public Function Themnhanvien(ByVal k As NhanvienDTO) As String
            Return NhanvienDAL.Them(k)
        End Function
        'Xóa nhân viên
        Public Function Xoanhanvien(ByVal k As NhanvienDTO) As String
            Return NhanvienDAL.Xoa(k)
        End Function
        'Sửa nhân viên
        Public Function Suanhanvien(ByVal k As NhanvienDTO) As String
            Return NhanvienDAL.Sua(k)
        End Function
        'Cập nhật số tiền nợ
        Public Function Capnhatsotienno(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Capnhattienluong(k)
        End Function
        'Tìm kiếm nhân viên theo mã nhân viên
        Public Function Timkiemtheomanhanvien(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemtheomanhanvien(k)
        End Function
        'Lấy mã nhân viên từ bảng nhanvien
        Public Function Timkiemmanhanvien()
            Return NhanvienDAL.Timkiemmanhanvien()
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên 
        Public Function Timkiemtennhanvien(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemtennhanvien(k)
        End Function
        'Tìm kiếm nhân viên theo địa chỉ
        Public Function Timkiemdiachi(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemdiachi(k)
        End Function
        'Tìm kiếm nhân viên theo điện thoại
        Public Function Timkiemdienthoai(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemdienthoai(k)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên và Điện thoại
        Public Function Timkiemtennhanvienvadienthoai(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemtennhanvienvadienthoai(k)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên và địa chỉ
        Public Function Timkiemtennhanvienvadiachi(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemtennhanvienvadiachi(k)
        End Function
        'Tìm kiếm nhân viên theo địa chỉ và điện thoại
        Public Function Timkiemtendienthoaivadiachi(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemdiachivadienthoai(k)
        End Function
        'Tìm kiếm nhân viên theo tên nhân viên, địa chỉ và điện thoại
        Public Function Timkiemtentennhanvienvadienthoaivadiachi(ByVal k As NhanvienDTO)
            Return NhanvienDAL.Timkiemtennhanvienvadiachivadienthoai(k)
        End Function

    End Class
End Namespace
