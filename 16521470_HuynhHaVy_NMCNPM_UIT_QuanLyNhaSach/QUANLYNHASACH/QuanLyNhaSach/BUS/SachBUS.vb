Imports DTO.SachDTO
Imports DAL.SachDAL
Namespace SachBUS
    Public Class SachBUS
        Dim sachdal As New SachDAL
        'Hiển thị dữ liệu sách
        Public Function Taidulieu()
            Return sachdal.Taidulieu()
        End Function
        'Thêm sách
        Public Function Themsach(ByVal s As SachDTO) As String
            Return sachdal.Them(s)
        End Function
        'Xóa sách
        Public Function Xoasach(ByVal s As SachDTO) As String
            Return sachdal.Xoa(s)
        End Function
        'Sửa sách
        Public Function Suasach(ByVal s As SachDTO) As String
            Return sachdal.Sua(s)
        End Function
        'Cập nhật số lượng tồn
        Public Function Timkiemtheomasach(ByVal s As SachDTO)
            Return sachdal.Timkiemtheomasach(s)
        End Function
        'Tìm kiếm sách theo mã sách
        Public Function Timkiemmasach()
            Return sachdal.Timkiemmasach()
        End Function
        'Lấy mã sách từ bảng SACH
        Public Sub Capnhatsoluongton(ByVal s As SachDTO)
            sachdal.Capnhatsoluongton(s)
        End Sub
        'Tìm kiếm sách theo tên sách
        Public Function Timkiemtensach(ByVal s As SachDTO)
            Return sachdal.Timkiemtensach(s)
        End Function
        'Tìm Kiếm sách theo thể loại
        Public Function Timkiemtheloai(ByVal s As SachDTO)
            Return sachdal.Timkiemtheloai(s)
        End Function
        'Tìm kiếm sách theo tác giả
        Public Function Timkiemtacgia(ByVal s As SachDTO)
            Return sachdal.Timkiemtacgia(s)
        End Function
        'Tìm kiếm sách theo tên sách và tác giả
        Public Function Timkiemtensachvatacgia(ByVal s As SachDTO)
            Return sachdal.Timkiemtensachvatacgia(s)
        End Function
        'Tìm kiếm sách theo tên sách và thể loại
        Public Function Timkiemtensachvatheloai(ByVal s As SachDTO)
            Return sachdal.Timkiemtensachvatheloai(s)
        End Function
        'tìm kiếm sách theo tác giả và thể loại
        Public Function Timkiemtacgiavatheloai(ByVal s As SachDTO)
            Return sachdal.Timkiemtacgiavatheloai(s)
        End Function
        'Tìm kiếm sachs theo tên sách , thể loại và tác giả
        Public Function Timkiemtensachvatheloaivatacgia(ByVal s As SachDTO)
            Return sachdal.Timkiemtensachvatheloaivatacgia(s)
        End Function
    End Class
End Namespace
