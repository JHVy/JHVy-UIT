Public Class Form1


    Private Sub SachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SachToolStripMenuItem.Click
        Dim quanlysach As New QUANLYSACH
        quanlysach.MdiParent = Me
        quanlysach.Show()
    End Sub



    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        Dim quanlyhachhang As New QUANLYKHACHHANG
        quanlyhachhang.MdiParent = Me
        quanlyhachhang.Show()
    End Sub


    Private Sub DanhSáchSáchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DanhSáchSáchToolStripMenuItem1.Click
        Dim phieunhapsach As New PHIEUNHAPSACH
        phieunhapsach.MdiParent = Me
        phieunhapsach.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub thaydoiquydinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles thaydoiquydinhToolStripMenuItem.Click
        Dim thaydoiquydinh As New THAYDOIQUYDINH
        thaydoiquydinh.MdiParent = Me
        thaydoiquydinh.Show()
    End Sub

    Private Sub HóađơnbánsáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóađơnbánsáchToolStripMenuItem.Click
        Dim hoadonbansach As New HOADONBANSACH
        hoadonbansach.MdiParent = Me
        hoadonbansach.Show()
    End Sub

    Private Sub PhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuThuTiềnToolStripMenuItem.Click
        Dim phieuthutien As New PHIEUTHUTIEN
        phieuthutien.MdiParent = Me
        phieuthutien.Show()
    End Sub

    Private Sub BáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoTồnToolStripMenuItem.Click
        Dim baocaoton As New BAOCAOTON
        baocaoton.MdiParent = Me
        baocaoton.Show()
    End Sub

    Private Sub BáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoCôngNợToolStripMenuItem.Click
        Dim baocaocongno As New BAOCAOCAONGNO
        baocaocongno.MdiParent = Me
        baocaocongno.Show()
    End Sub

    Private Sub SáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchToolStripMenuItem.Click
        Dim tracuusach As New TIMKIEMSACH
        tracuusach.MdiParent = Me
        tracuusach.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dangnhap As New DANGNHAP
        dangnhap.MdiParent = Me
        dangnhap.Show()
        MenuStrip1.Enabled = False
    End Sub
End Class