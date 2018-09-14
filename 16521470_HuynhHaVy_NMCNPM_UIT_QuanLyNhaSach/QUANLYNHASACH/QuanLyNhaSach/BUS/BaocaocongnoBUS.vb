Imports DTO.BaocaocongnoDTO
Imports DAL.BaocaocongnoDAL
Namespace BaocaocongnoBUS
    Public Class BaocaocongnoBUS
        Dim baocaocongnodal As New BaocaocongnoDAL
        'Hiển thị báo cáo
        Public Function Hienthibaocaocongno()
            Return baocaocongnodal.Hienthibaocaocongno
        End Function
        'thêm báo cáo
        Public Function Thembaocaocongno(ByVal bccn As BaocaocongnoDTO) As String
            Return baocaocongnodal.Thembaocaocongno(bccn)
        End Function
        'tìm kiếm báo cáo theo tháng và năm
        Public Function Timbaocaotheothangvanam(ByVal bccn As BaocaocongnoDTO)
            Return baocaocongnodal.Timkiembaocaocongnotheothangvanam(bccn)
        End Function
        'cập nhật báo cáo
        Public Function Canhatbaocaocongno(ByVal bccn As BaocaocongnoDTO) As String
            Return baocaocongnodal.Capnhatbaocaocongno(bccn)
        End Function
        'tìm báo cáo tháng trước
        Public Function Timkiembaocaocongnotheothangtruoc(ByVal Makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return baocaocongnodal.Timbaocaocongnotheothangtruoc(Makhachhang, thang, nam)
        End Function
        'xóa báo cáo theo tháng và năm
        Public Function Xoabaocaocongno(ByVal thang As Integer, ByVal nam As Integer)
            Return baocaocongnodal.Xoabaocaocongnotheothangvanam(thang, nam)
        End Function
    End Class
End Namespace
