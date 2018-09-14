<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PHIEUNHAPSACH
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ngay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maphieunhap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Them = New System.Windows.Forms.Button()
        Me.Chitiet = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.masach = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.soluongnhap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.maphieunhap1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Them1 = New System.Windows.Forms.Button()
        Me.Xoatrang = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Luoi1 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dong = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Luoi1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 31)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "PHIẾU NHẬP SÁCH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ngay)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.maphieunhap)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 97)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu nhập"
        '
        'Ngay
        '
        Me.Ngay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Ngay.Location = New System.Drawing.Point(167, 59)
        Me.Ngay.Name = "Ngay"
        Me.Ngay.Size = New System.Drawing.Size(200, 20)
        Me.Ngay.TabIndex = 39
        Me.Ngay.Value = New Date(2017, 5, 21, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "MÃ PHIẾU NHẬP"
        '
        'maphieunhap
        '
        Me.maphieunhap.Enabled = False
        Me.maphieunhap.Location = New System.Drawing.Point(167, 27)
        Me.maphieunhap.Name = "maphieunhap"
        Me.maphieunhap.Size = New System.Drawing.Size(108, 20)
        Me.maphieunhap.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "NGÀY NHẬP"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.Chitiet)
        Me.GroupBox2.Location = New System.Drawing.Point(100, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 100)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'Them
        '
        Me.Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Them.Location = New System.Drawing.Point(32, 34)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(100, 40)
        Me.Them.TabIndex = 42
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
        '
        'Chitiet
        '
        Me.Chitiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chitiet.Location = New System.Drawing.Point(179, 33)
        Me.Chitiet.Name = "Chitiet"
        Me.Chitiet.Size = New System.Drawing.Size(100, 41)
        Me.Chitiet.TabIndex = 43
        Me.Chitiet.Text = "Chi tiết"
        Me.Chitiet.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Luoi)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(530, 270)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách phiếu nhập"
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Luoi.Location = New System.Drawing.Point(8, 19)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(516, 245)
        Me.Luoi.TabIndex = 45
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Maphieunhap"
        Me.Column1.HeaderText = "Mã phiếu nhập"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Ngaynhap"
        Me.Column2.HeaderText = "Ngày nhập"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(456, 538)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(75, 40)
        Me.Thoat.TabIndex = 44
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Thoat)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 589)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(303, 31)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "CHI TIẾT PHIẾU NHẬP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.masach)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.soluongnhap)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.maphieunhap1)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(547, 97)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông tin chi tiết phiếu nhập"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Chọn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'masach
        '
        Me.masach.Enabled = False
        Me.masach.Location = New System.Drawing.Point(335, 14)
        Me.masach.Name = "masach"
        Me.masach.Size = New System.Drawing.Size(100, 20)
        Me.masach.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "MÃ SÁCH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "SỐ LƯỢNG NHẬP"
        '
        'soluongnhap
        '
        Me.soluongnhap.Location = New System.Drawing.Point(109, 57)
        Me.soluongnhap.Name = "soluongnhap"
        Me.soluongnhap.Size = New System.Drawing.Size(108, 20)
        Me.soluongnhap.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "MÃ PHIẾU NHẬP"
        '
        'maphieunhap1
        '
        Me.maphieunhap1.Enabled = False
        Me.maphieunhap1.Location = New System.Drawing.Point(109, 19)
        Me.maphieunhap1.Name = "maphieunhap1"
        Me.maphieunhap1.Size = New System.Drawing.Size(108, 20)
        Me.maphieunhap1.TabIndex = 38
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Them1)
        Me.GroupBox5.Controls.Add(Me.Xoatrang)
        Me.GroupBox5.Location = New System.Drawing.Point(131, 156)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(330, 100)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Chức năng"
        '
        'Them1
        '
        Me.Them1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Them1.Location = New System.Drawing.Point(56, 35)
        Me.Them1.Name = "Them1"
        Me.Them1.Size = New System.Drawing.Size(100, 40)
        Me.Them1.TabIndex = 42
        Me.Them1.Text = "Thêm CT"
        Me.Them1.UseVisualStyleBackColor = True
        '
        'Xoatrang
        '
        Me.Xoatrang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoatrang.Location = New System.Drawing.Point(196, 34)
        Me.Xoatrang.Name = "Xoatrang"
        Me.Xoatrang.Size = New System.Drawing.Size(100, 41)
        Me.Xoatrang.TabIndex = 43
        Me.Xoatrang.Text = "Xóa trắng"
        Me.Xoatrang.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Luoi1)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 262)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(536, 270)
        Me.GroupBox6.TabIndex = 54
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Chi tiết phiếu nhập"
        '
        'Luoi1
        '
        Me.Luoi1.AllowUserToAddRows = False
        Me.Luoi1.AllowUserToDeleteRows = False
        Me.Luoi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column7, Me.Column5, Me.Column6, Me.Column3})
        Me.Luoi1.Location = New System.Drawing.Point(6, 19)
        Me.Luoi1.Name = "Luoi1"
        Me.Luoi1.ReadOnly = True
        Me.Luoi1.Size = New System.Drawing.Size(524, 245)
        Me.Luoi1.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Maphieunhap"
        Me.Column4.HeaderText = "Mã phiếu nhập"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.DataPropertyName = "Tensach"
        Me.Column7.HeaderText = "Tên sách"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Masach"
        Me.Column5.HeaderText = "Mã sách"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        Me.Column5.Width = 127
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.DataPropertyName = "Soluongnhap"
        Me.Column6.HeaderText = "Số lượng nhập"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Machitietphieunhap"
        Me.Column3.HeaderText = "Mã chi tiết phiếu nhập"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Dong
        '
        Me.Dong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong.Location = New System.Drawing.Point(466, 538)
        Me.Dong.Name = "Dong"
        Me.Dong.Size = New System.Drawing.Size(75, 40)
        Me.Dong.TabIndex = 51
        Me.Dong.Text = "Đóng"
        Me.Dong.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Dong)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(559, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 589)
        Me.Panel2.TabIndex = 1
        '
        'PHIEUNHAPSACH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 589)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PHIEUNHAPSACH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHIEUNHAPSACH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.Luoi1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maphieunhap As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Chitiet As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents masach As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents soluongnhap As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents maphieunhap1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Them1 As System.Windows.Forms.Button
    Friend WithEvents Xoatrang As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Luoi1 As System.Windows.Forms.DataGridView
    Friend WithEvents Dong As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
