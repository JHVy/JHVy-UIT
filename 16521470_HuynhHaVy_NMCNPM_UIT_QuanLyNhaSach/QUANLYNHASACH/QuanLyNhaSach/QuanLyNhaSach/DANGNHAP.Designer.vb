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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DANGNHAP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tendangnhap = New System.Windows.Forms.TextBox()
        Me.Matkhau = New System.Windows.Forms.TextBox()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.dangnhap1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(212, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TÊN ĐĂNG NHẬP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(212, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MẬT KHẨU"
        '
        'Tendangnhap
        '
        Me.Tendangnhap.BackColor = System.Drawing.Color.White
        Me.Tendangnhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tendangnhap.ForeColor = System.Drawing.Color.Black
        Me.Tendangnhap.Location = New System.Drawing.Point(371, 60)
        Me.Tendangnhap.Name = "Tendangnhap"
        Me.Tendangnhap.Size = New System.Drawing.Size(203, 26)
        Me.Tendangnhap.TabIndex = 3
        '
        'Matkhau
        '
        Me.Matkhau.BackColor = System.Drawing.Color.White
        Me.Matkhau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matkhau.ForeColor = System.Drawing.Color.Black
        Me.Matkhau.Location = New System.Drawing.Point(371, 118)
        Me.Matkhau.Name = "Matkhau"
        Me.Matkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Matkhau.Size = New System.Drawing.Size(203, 26)
        Me.Matkhau.TabIndex = 4
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(248, 195)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(129, 51)
        Me.Thoat.TabIndex = 6
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'dangnhap1
        '
        Me.dangnhap1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dangnhap1.Location = New System.Drawing.Point(425, 195)
        Me.dangnhap1.Name = "dangnhap1"
        Me.dangnhap1.Size = New System.Drawing.Size(121, 51)
        Me.dangnhap1.TabIndex = 5
        Me.dangnhap1.Text = "Đăng nhập"
        Me.dangnhap1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 246)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'DANGNHAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(596, 279)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.dangnhap1)
        Me.Controls.Add(Me.Matkhau)
        Me.Controls.Add(Me.Tendangnhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
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
End Class
