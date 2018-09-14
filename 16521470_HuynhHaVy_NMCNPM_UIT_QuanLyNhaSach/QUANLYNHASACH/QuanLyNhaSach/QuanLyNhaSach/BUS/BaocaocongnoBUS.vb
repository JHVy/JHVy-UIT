Imports DTO.BaocaocongnoDTO
Imports DAL.BaocaocongnoDAL
Namespace BaocaocongnoBUS
    Public Class BaocaocongnoBUS
        Dim baocaocongnodal As New BaocaocongnoDAL
        Public Function Hienthibaocaocongno()
            Return baocaocongnodal.Hienthibaocaocongno
        End Function

        Public Function Thembaocaocongno(ByVal bccn As BaocaocongnoDTO) As String
            Return baocaocongnodal.Thembaocaocongno(bccn)
        End Function

        Public Function Timbaocaotheothangvanam(ByVal bccn As BaocaocongnoDTO)
            Return baocaocongnodal.Timkiembaocaocongnotheothangvanam(bccn)
        End Function

        Public Function Canhatbaocaocongno(ByVal bccn As BaocaocongnoDTO) As String
            Return baocaocongnodal.Capnhatbaocaocongno(bccn)
        End Function

        Public Function Timkiembaocaocongnotheothangtruoc(ByVal Makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return baocaocongnodal.Timbaocaocongnotheothangtruoc(Makhachhang, thang, nam)
        End Function

    End Class
End Namespace
