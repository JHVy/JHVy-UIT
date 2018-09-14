Imports DTO.BaocaotonDTO
Imports DAL.BaocaotonDAL
Namespace BaocaotonBUS
    Public Class BaocaotonBUS
        Dim baocaotondal As New BaocaotonDAL
        Public Function Hienthibaocaoton()
            Return baocaotondal.Hienthibaocaoton
        End Function

        Public Function Thembaocaoton(ByVal bct As BaocaotonDTO) As String
            Return baocaotondal.Thembaocaoton(bct)
        End Function

        Public Function Timbaocaotheothangvanam(ByVal bct As BaocaotonDTO)
            Return baocaotondal.Timkiembaocaotontheothangvanam(bct)
        End Function

        Public Function Canhatbaocaoton(ByVal bct As BaocaotonDTO) As String
            Return baocaotondal.Capnhatbaocaoton(bct)
        End Function

        Public Function Timkiembaocaotontheothangtruoc(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer)
            Return baocaotondal.Timbaocaotontheothangtruoc(masach, thang, nam)
        End Function
    End Class
End Namespace

