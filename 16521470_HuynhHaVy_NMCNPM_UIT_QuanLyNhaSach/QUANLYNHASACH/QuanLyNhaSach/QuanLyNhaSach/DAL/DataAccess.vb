Imports System.Data.SqlClient
Imports DTO.DangnhapDTO
Public Class DataAccess
    Dim dangnhap As New DangnhapDTO
    Public tencsdl As String = dangnhap.Tencsdl
    Private strConnect As New SqlConnection()
    Dim str As String = "Data Source=" + tencsdl + ";Initial Catalog=QuanLyNhaSach;Integrated Security=True"

    Public Sub Create_Connect()

        If strConnect.State = ConnectionState.Closed Then
            strConnect.ConnectionString = str
            strConnect.Open()
        End If
    End Sub

    Public Sub Close_Connect()
        If strConnect.State = ConnectionState.Open Then
            strConnect.Close()
        End If
    End Sub

    Public Function Taidulieu(strLenh As String) As DataTable
        Dim ds As New DataTable
        Create_Connect()
        Dim da As New SqlDataAdapter(strLenh, strConnect)
        da.Fill(ds)
        Return ds
    End Function

    Public Function Thucthisql(ByVal sql As String) As String
        Try
            Create_Connect()
            Dim cmd As New SqlCommand(sql, strConnect)
            cmd.ExecuteNonQuery()
            Close_Connect()
            Return "Success"
        Catch e As Exception
            Return e.ToString
        End Try
    End Function


End Class
