Imports DTO.SachDTO
Imports DAL.SachDAL
Namespace SachBUS
    Public Class SachBUS
        Dim sachdal As New SachDAL
        Public Function Taidulieu()
            Return sachdal.Taidulieu()
        End Function

        Public Function Themsach(ByVal s As SachDTO) As String
            Return sachdal.Them(s)
        End Function

        Public Function Xoasach(ByVal s As SachDTO) As String
            Return sachdal.Xoa(s)
        End Function

        Public Function Suasach(ByVal s As SachDTO) As String
            Return sachdal.Sua(s)
        End Function

        Public Function Timkiemtheomasach(ByVal s As SachDTO)
            Return sachdal.Timkiemtheomasach(s)
        End Function

        Public Function Timkiemmasach()
            Return sachdal.Timkiemmasach()
        End Function

        Public Sub Capnhatsoluongton(ByVal s As SachDTO)
            sachdal.Capnhatsoluongton(s)
        End Sub

        Public Function Timkiemtensach(ByVal s As SachDTO)
            Return sachdal.Timkiemtensach(s)
        End Function

        Public Function Timkiemtheloai(ByVal s As SachDTO)
            Return sachdal.Timkiemtheloai(s)
        End Function

        Public Function Timkiemtacgia(ByVal s As SachDTO)
            Return sachdal.Timkiemtacgia(s)
        End Function

        Public Function Timkiemtensachvatacgia(ByVal s As SachDTO)
            Return sachdal.Timkiemtensachvatacgia(s)
        End Function

        Public Function Timkiemtensachvatheloai(ByVal s As SachDTO)
            Return sachdal.Timkiemtensachvatheloai(s)
        End Function

        Public Function Timkiemtacgiavatheloai(ByVal s As SachDTO)
            Return sachdal.Timkiemtacgiavatheloai(s)
        End Function

        Public Function Timkiemtensachvatheloaivatacgia(ByVal s As SachDTO)
            Return sachdal.Timkiemtensachvatheloaivatacgia(s)
        End Function
    End Class
End Namespace
