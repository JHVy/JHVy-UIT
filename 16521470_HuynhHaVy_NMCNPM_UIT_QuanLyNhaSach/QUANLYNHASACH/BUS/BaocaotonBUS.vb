Imports DTO.BaocaotonDTO
Imports DAL.BaocaotonDAL
Namespace BaocaotonBUS
    Public Class BaocaotonBUS
        Dim baocaotondal As New BaocaotonDAL
        'Hiển thị báo cáo
        Public Function Hienthibaocaoton()
            Return baocaotondal.Hienthibaocaoton
        End Function
        'Thêm báo cáo
        Public Function Thembaocaoton(ByVal bct As BaocaotonDTO) As String
            Return baocaotondal.Thembaocaoton(bct)
        End Function
        'Tìm kiếm báo cáo theo tháng và năm
        Public Function Timbaocaotheothangvanam(ByVal bct As BaocaotonDTO)
            Return baocaotondal.Timkiembaocaotontheothangvanam(bct)
        End Function
        'Cập nhật báo cáo
        Public Function Canhatbaocaoton(ByVal bct As BaocaotonDTO) As String
            Return baocaotondal.Capnhatbaocaoton(bct)
        End Function
        'Tìm báo cáo tháng trước
        Public Function Timkiembaocaotontheothangtruoc(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer)
            Return baocaotondal.Timbaocaotontheothangtruoc(masach, thang, nam)
        End Function
        'Xóa báo cáo theo tháng và năm
        Public Function Xoabaocaotontheothangvanam(ByVal thang As Integer, ByVal nam As Integer) As String
            Return baocaotondal.Xoabaocaotontheothangvanam(thang, nam)
        End Function
    End Class
End Namespace

