Imports DTO.KhachhangDTO
Imports DAL.KhachhangDAL
Namespace KhachhangBUS
    Public Class KhachhangBUS
        Dim KhachhangDAL As New KhachhangDAL
        Public Function Taidulieu()
            Return KhachhangDAL.Taidulieu()
        End Function

        Public Function Themkhachhang(ByVal k As KhachhangDTO) As String
            Return KhachhangDAL.Them(k)
        End Function

        Public Function Xoakhachhang(ByVal k As KhachhangDTO) As String
            Return KhachhangDAL.Xoa(k)
        End Function

        Public Function Suakhachhang(ByVal k As KhachhangDTO) As String
            Return KhachhangDAL.Sua(k)
        End Function

        Public Function Capnhatsotienno(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Capnhatsotienno(k)
        End Function

        Public Function Timkiemtheomakhachhang(ByVal k As KhachhangDTO)
            Return KhachhangDAL.Timkiemtheomakhachhang(k)
        End Function

        Public Function Timkiemmakhachhang()
            Return KhachhangDAL.Timkiemmakhachhang()
        End Function
    End Class
End Namespace
