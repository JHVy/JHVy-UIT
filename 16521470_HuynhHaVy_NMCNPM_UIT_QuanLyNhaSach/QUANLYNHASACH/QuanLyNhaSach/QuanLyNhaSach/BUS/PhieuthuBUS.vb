Imports DTO.PhieuthuDTO
Imports DAL.PhieuthuDAL
Namespace PhieuthuBUS
    Public Class PhieuthuBUS
        Dim phieuthudal As New PhieuthuDAL
        Public Function Taidulieuphieuthu()
            Return phieuthudal.Taidulieuphieuthu()
        End Function

        Public Function Themphieuthu(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Themphieuthu(pt)
        End Function

        Public Function Xoaphieuthu(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Xoaphieuthu(pt)
        End Function

        Public Function Suaphieuthu(ByVal pt As PhieuthuDTO)
            Return phieuthudal.Suaphieuthu(pt)
        End Function

        Public Function Tongsotienthu(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Return phieuthudal.Tongsotienthu(makhachhang, thang, nam)
        End Function
    End Class
End Namespace