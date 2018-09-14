Imports System.Data.SqlClient
Imports DTO.DangnhapDTO
Namespace data
    Public Class DataAccess
        Dim name
        Dim dangnhap As New DangnhapDTO
        Private strConnect As New SqlConnection()
        Public str As String = "Data Source=(local)\WINCHESTER;Initial Catalog=QLNS;Integrated Security=True"
        'Tạo kết nối
        Public Sub Create_Connect()
            If strConnect.State = ConnectionState.Closed Then
                strConnect.ConnectionString = str
                strConnect.Open()
            End If
        End Sub
        'Đóng kết nối
        Public Sub Close_Connect()
            If strConnect.State = ConnectionState.Open Then
                strConnect.Close()
            End If
        End Sub
        'Tải dữ liệu
        Public Function Taidulieu(strLenh As String) As DataTable
            Dim ds As New DataTable
            Create_Connect()
            Dim da As New SqlDataAdapter(strLenh, strConnect)
            da.Fill(ds)
            Return ds
        End Function
        'Thực thi lệnh
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
End Namespace
