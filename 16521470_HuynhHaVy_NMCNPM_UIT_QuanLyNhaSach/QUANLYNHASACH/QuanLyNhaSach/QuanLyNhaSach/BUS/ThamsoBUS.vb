Imports DTO.ThamsoDTO
Imports DAL.ThamsoDAL
Namespace ThamsoBUS
    Public Class ThamsoBUS
        Dim thamsodal As New ThamsoDAL
        Public Function Taithamso()
            Return thamsodal.Taidulieu()
        End Function

        Public Function Capnhatthamso(ByVal thamso As ThamsoDTO) As String
            Return thamsodal.Capnhatthamso(thamso)
        End Function

        Public Function Capnhatlaibangthamso(ByVal thamso As ThamsoDTO) As String
            If thamsodal.laythamsobangma(thamso) <> Nothing Then
                Return thamsodal.Capnhatthamso(thamso)
            Else
                Return thamsodal.Themthamso(thamso)
            End If
        End Function
    End Class
End Namespace

