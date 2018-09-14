<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DANGNHAP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tendangnhap = New System.Windows.Forms.TextBox()
        Me.Matkhau = New System.Windows.Forms.TextBox()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tencsdl = New System.Windows.Forms.TextBox()
        Me.dangnhap1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TÊN ĐĂNG NHẬP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MẬT KHẨU"
        '
        'Tendangnhap
        '
        Me.Tendangnhap.Location = New System.Drawing.Point(371, 27)
        Me.Tendangnhap.Name = "Tendangnhap"
        Me.Tendangnhap.Size = New System.Drawing.Size(175, 20)
        Me.Tendangnhap.TabIndex = 3
        '
        'Matkhau
        '
        Me.Matkhau.Location = New System.Drawing.Point(371, 83)
        Me.Matkhau.Name = "Matkhau"
        Me.Matkhau.Size = New System.Drawing.Size(175, 20)
        Me.Matkhau.TabIndex = 4
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(248, 195)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(129, 51)
        Me.Thoat.TabIndex = 6
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TÊN CSDL"
        '
        'Tencsdl
        '
        Me.Tencsdl.Location = New System.Drawing.Point(371, 145)
        Me.Tencsdl.Name = "Tencsdl"
        Me.Tencsdl.Size = New System.Drawing.Size(175, 20)
        Me.Tencsdl.TabIndex = 8
        '
        'dangnhap1
        '
        Me.dangnhap1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dangnhap1.Location = New System.Drawing.Point(425, 195)
        Me.dangnhap1.Name = "dangnhap1"
        Me.dangnhap1.Size = New System.Drawing.Size(121, 51)
        Me.dangnhap1.TabIndex = 5
        Me.dangnhap1.Text = "Đăng nhập"
        Me.dangnhap1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuanLyNhaSach.My.Resources.Resources.systemcpl_dll_01_14
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 221)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DANGNHAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 279)
        Me.Controls.Add(Me.Tencsdl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.dangnhap1)
        Me.Controls.Add(Me.Matkhau)
        Me.Controls.Add(Me.Tendangnhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DANGNHAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANGNHAP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tendangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Matkhau As System.Windows.Forms.TextBox
    Friend WithEvents dangnhap1 As System.Windows.Forms.Button
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tencsdl As System.Windows.Forms.TextBox
End Class
