Imports DTO.PhieuthuDTO
Imports System.Data.SqlClient
Imports DAL.DataAccess
Namespace PhieuthuDAL
    Public Class PhieuthuDAL
        Dim dataaccess As New DataAccess
        Public Function Taidulieuphieuthu() As DataTable
            Return dataaccess.Taidulieu("Select PHIEUTHUTIEN.*,KHACHHANG.Hotenkhachhang From PHIEUTHUTIEN,KHACHHANG where PHIEUTHUTIEN.Makhachhang = KHACHHANG.Makhachhang")
        End Function

        Public Function Themphieuthu(ByVal pt As PhieuthuDTO) As String
            Dim sql As String = "insert into PHIEUTHUTIEN(Maphieuthu,Sotienthu,Ngaythutien,Makhachhang) values('" & pt.Maphieuthu.Trim & "','" & pt.Sotienthu & "','" & pt.Ngaythutien & "','" & pt.Makhachhang.Trim & "')"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Suaphieuthu(ByVal pt As PhieuthuDTO) As String
            Dim sql As String = "update PHIEUTHUTIEN set Makhachhang='" & pt.Makhachhang.Trim & "',Sotienthu='" & pt.Sotienthu & "',Ngaythutien='" & pt.Ngaythutien & "'  where Maphieuthu='" & pt.Maphieuthu.Trim & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Xoaphieuthu(ByVal pt As PhieuthuDTO) As String
            Dim sql As String = "delete from PHIEUTHUTIEN where Maphieuthu= '" & pt.Maphieuthu & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Tangmapt() As String
            Dim sql As String = "Select * From PHIEUTHUTIEN"
            Dim str As String = "Data Source=winchester-pc;Initial Catalog=QuanLyNhaSach;Integrated Security=True"
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "PT001"
            Else
                Dim k As Integer
                ma = "PT"
                k = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0).ToString().Substring(2, 3))
                k = k + 1
                If k < 10 Then
                    ma = ma + "00"
                ElseIf k < 100 Then
                    ma = ma + "0"
                End If
                ma = ma + k.ToString()
            End If
            Return ma
        End Function

        Public Function Timkiemmakhachhang(ByVal pt As PhieuthuDTO) As DataTable
            Dim sql As String = "select * from PHIEUTHUTIEN where Makhachhang like '%" & pt.Makhachhang & "%'"
            Return dataaccess.Taidulieu(sql)
        End Function

        Public Function Tongsotienthu(ByVal makhachhang As String, ByVal thang As Integer, ByVal nam As Integer)
            Dim sql As String = "select SUM(PHIEUTHUTIEN.Sotienthu) from PHIEUTHUTIEN where Makhachhang = '" & makhachhang & "' and MONTH(PHIEUTHUTIEN.Ngaythutien)='" & thang & "' and YEAR(PHIEUTHUTIEN.Ngaythutien) ='" & nam & "' group by PHIEUTHUTIEN.makhachhang"
            Return dataaccess.Taidulieu(sql)
        End Function


    End Class
End Namespace

