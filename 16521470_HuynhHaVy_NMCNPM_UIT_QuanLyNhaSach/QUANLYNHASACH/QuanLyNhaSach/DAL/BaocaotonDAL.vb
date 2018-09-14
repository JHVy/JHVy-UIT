Imports DTO.BaocaotonDTO
Imports System.Data.SqlClient
Imports DAL.data
Namespace BaocaotonDAL

    Public Class BaocaotonDAL
        Dim dataaccess As New DataAccess
        'Hiển thị báo cáo
        Public Function Hienthibaocaoton() As DataTable
            Return dataaccess.Taidulieu("select BAOCAOTON.*,SACH.Tensach from BAOCAOTON,SACH where BAOCAOTON.Masach=SACH.masach")
        End Function
        'Thêm báo cáo
        Public Function Thembaocaoton(ByVal bct As BaocaotonDTO) As String
            Dim sql As String = "insert into BAOCAOTON(machitietton,Thang,Nam,Masach,tondau,tonphatsinh,toncuoi) values('" & bct.Machitietton.Trim & "','" & bct.Thang & "','" & bct.Nam & "','" & bct.Masach & "','" & bct.Tondau & "','" & bct.Tonphatsinh & "','" & bct.Toncuoi & "')"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Tìm kiếm báo cáo theo tháng và năm
        Public Function Timkiembaocaotontheothangvanam(ByVal bct As BaocaotonDTO) As DataTable
            Dim sql As String = "select BAOCAOTON.*,SACH.Tensach from BAOCAOTON,SACH where Thang ='" & bct.Thang & "' and Nam ='" & bct.Nam & "' and BAOCAOTON.Masach = SACH.Masach"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Cập nhật báo cáo
        Public Function Capnhatbaocaoton(ByVal bct As BaocaotonDTO) As String
            Dim sql As String = "update BAOCAOTON set Tondau='" & bct.Tondau & "',Tonphatsinh='" & bct.Tonphatsinh & "',Toncuoi='" & bct.Toncuoi & "' where Machitietton = '" & bct.Machitietton & "'"
            Return dataaccess.Thucthisql(sql)
        End Function
        'Tìm báo cáo tháng trước
        Public Function Timbaocaotontheothangtruoc(ByVal masach As String, ByVal thang As Integer, ByVal nam As Integer) As DataTable
            Dim sql As String = "select * from BAOCAOTON where Masach='" & masach & "' and Thang='" & thang & "' and Nam='" & nam & "'"
            Return dataaccess.Taidulieu(sql)
        End Function
        'Xóa báo cáo theo tháng và năm
        Public Function Xoabaocaotontheothangvanam(ByVal Thang As Integer, ByVal nam As Integer) As String
            Dim sql As String = "delete from BAOCAOTON where Thang='" & Thang & "' and Nam = '" & nam & "'"
            Return dataaccess.Thucthisql(sql)
        End Function

        Public Function Tangmabct() As String
            Dim sql As String = "Select * From BAOCAOTON"
            Dim str As String = dataaccess.str
            Dim con As New SqlConnection()
            con.ConnectionString = str
            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dim ma As String = ""
            If dt.Rows.Count <= 0 Then
                ma = "BT001"
            Else
                Dim k As Integer
                ma = "BT"
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
    End Class
End Namespace

