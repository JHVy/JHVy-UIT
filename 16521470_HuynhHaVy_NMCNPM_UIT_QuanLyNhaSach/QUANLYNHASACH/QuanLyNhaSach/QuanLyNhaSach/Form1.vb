Imports DTO.DangnhapDTO
Public Class Form1
    Dim dn As New DangnhapDTO

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

    Private Sub ThoátToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Dangnhap.Click
        Dim dangnhap As New DANGNHAP
        dangnhap.MdiParent = Me
        dangnhap.Show()
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
        QuảnLýToolStripMenuItem.Enabled = False
        TraCứuToolStripMenuItem.Enabled = False
        BáoCáoToolStripMenuItem.Enabled = False
        TraCứuToolStripMenuItem1.Enabled = False
        thaydoiquydinhToolStripMenuItem.Enabled = False
    End Sub

    Private Sub KháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem1.Click
        Dim tracuukhachhang As New TRACCUUKHACHHANG
        tracuukhachhang.MdiParent = Me
        tracuukhachhang.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class