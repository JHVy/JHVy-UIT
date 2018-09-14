<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QUANLYSACH
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
        Me.tensach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Them = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.tacgia = New System.Windows.Forms.TextBox()
        Me.theloai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.soluongton = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Sua = New System.Windows.Forms.Button()
        Me.masach = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.HIENTHI = New System.Windows.Forms.Button()
        Me.Xoatrang = New System.Windows.Forms.Button()
        Me.Khongluu = New System.Windows.Forms.Button()
        Me.Luu = New System.Windows.Forms.Button()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tracuu = New System.Windows.Forms.Button()
        Me.tracuutensach = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chon = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(462, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ SÁCH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tensach
        '
        Me.tensach.Location = New System.Drawing.Point(81, 43)
        Me.tensach.Name = "tensach"
        Me.tensach.Size = New System.Drawing.Size(204, 20)
        Me.tensach.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "TÁC GIẢ"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(472, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "THỂ  LOẠI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TÊN SÁCH"
        '
        'Them
        '
        Me.Them.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Them.Location = New System.Drawing.Point(6, 31)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(112, 37)
        Me.Them.TabIndex = 23
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(973, 530)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(118, 37)
        Me.Thoat.TabIndex = 24
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'tacgia
        '
        Me.tacgia.Location = New System.Drawing.Point(81, 70)
        Me.tacgia.Name = "tacgia"
        Me.tacgia.Size = New System.Drawing.Size(204, 20)
        Me.tacgia.TabIndex = 27
        '
        'theloai
        '
        Me.theloai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.theloai.Location = New System.Drawing.Point(581, 14)
        Me.theloai.Name = "theloai"
        Me.theloai.Size = New System.Drawing.Size(204, 20)
        Me.theloai.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(472, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "SỐ LƯỢNG TỒN"
        '
        'soluongton
        '
        Me.soluongton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.soluongton.Enabled = False
        Me.soluongton.Location = New System.Drawing.Point(581, 43)
        Me.soluongton.Name = "soluongton"
        Me.soluongton.Size = New System.Drawing.Size(204, 20)
        Me.soluongton.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "MÃ SÁCH"
        '
        'Xoa
        '
        Me.Xoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa.Location = New System.Drawing.Point(133, 31)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(112, 37)
        Me.Xoa.TabIndex = 32
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = True
        '
        'Sua
        '
        Me.Sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sua.Location = New System.Drawing.Point(6, 88)
        Me.Sua.Name = "Sua"
        Me.Sua.Size = New System.Drawing.Size(112, 37)
        Me.Sua.TabIndex = 33
        Me.Sua.Text = "Sửa"
        Me.Sua.UseVisualStyleBackColor = True
        '
        'masach
        '
        Me.masach.Enabled = False
        Me.masach.Location = New System.Drawing.Point(81, 14)
        Me.masach.Name = "masach"
        Me.masach.Size = New System.Drawing.Size(108, 20)
        Me.masach.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tensach)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.masach)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.soluongton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tacgia)
        Me.GroupBox1.Controls.Add(Me.theloai)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 98)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sách"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.HIENTHI)
        Me.GroupBox2.Controls.Add(Me.Xoatrang)
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.Xoa)
        Me.GroupBox2.Controls.Add(Me.Khongluu)
        Me.GroupBox2.Controls.Add(Me.Luu)
        Me.GroupBox2.Controls.Add(Me.Sua)
        Me.GroupBox2.Location = New System.Drawing.Point(840, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 352)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng"
        '
        'HIENTHI
        '
        Me.HIENTHI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HIENTHI.Location = New System.Drawing.Point(55, 290)
        Me.HIENTHI.Name = "HIENTHI"
        Me.HIENTHI.Size = New System.Drawing.Size(142, 37)
        Me.HIENTHI.TabIndex = 42
        Me.HIENTHI.Text = "Hiển thị tất cả"
        Me.HIENTHI.UseVisualStyleBackColor = True
        '
        'Xoatrang
        '
        Me.Xoatrang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoatrang.Location = New System.Drawing.Point(133, 88)
        Me.Xoatrang.Name = "Xoatrang"
        Me.Xoatrang.Size = New System.Drawing.Size(112, 37)
        Me.Xoatrang.TabIndex = 41
        Me.Xoatrang.Text = "Xóa trắng"
        Me.Xoatrang.UseVisualStyleBackColor = True
        '
        'Khongluu
        '
        Me.Khongluu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Khongluu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Khongluu.Location = New System.Drawing.Point(6, 247)
        Me.Khongluu.Name = "Khongluu"
        Me.Khongluu.Size = New System.Drawing.Size(112, 37)
        Me.Khongluu.TabIndex = 40
        Me.Khongluu.Text = "Không lưu"
        Me.Khongluu.UseVisualStyleBackColor = True
        '
        'Luu
        '
        Me.Luu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luu.Location = New System.Drawing.Point(133, 247)
        Me.Luu.Name = "Luu"
        Me.Luu.Size = New System.Drawing.Size(112, 37)
        Me.Luu.TabIndex = 38
        Me.Luu.Text = "Lưu"
        Me.Luu.UseVisualStyleBackColor = True
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Luoi.Location = New System.Drawing.Point(6, 13)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(788, 403)
        Me.Luoi.TabIndex = 31
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Masach"
        Me.Column1.HeaderText = "Mã sách"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 132
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Tensach"
        Me.Column2.HeaderText = "Tên sách"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Theloai"
        Me.Column3.HeaderText = "Thể loại"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 132
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Tacgia"
        Me.Column4.HeaderText = "Tác giả"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Soluongton"
        Me.Column5.HeaderText = "Số lượng tồn"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 151
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Luoi)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 422)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách sách"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tracuu)
        Me.GroupBox4.Controls.Add(Me.tracuutensach)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(841, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 98)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tra cứu"
        '
        'tracuu
        '
        Me.tracuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tracuu.Location = New System.Drawing.Point(74, 50)
        Me.tracuu.Name = "tracuu"
        Me.tracuu.Size = New System.Drawing.Size(112, 40)
        Me.tracuu.TabIndex = 44
        Me.tracuu.Text = "Tra cứu"
        Me.tracuu.UseVisualStyleBackColor = True
        '
        'tracuutensach
        '
        Me.tracuutensach.BackColor = System.Drawing.SystemColors.Window
        Me.tracuutensach.Cursor = System.Windows.Forms.Cursors.Default
        Me.tracuutensach.Location = New System.Drawing.Point(109, 17)
        Me.tracuutensach.Name = "tracuutensach"
        Me.tracuutensach.Size = New System.Drawing.Size(108, 20)
        Me.tracuutensach.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "TÊN SÁCH"
        '
        'chon
        '
        Me.chon.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.chon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chon.Location = New System.Drawing.Point(846, 531)
        Me.chon.Name = "chon"
        Me.chon.Size = New System.Drawing.Size(112, 37)
        Me.chon.TabIndex = 42
        Me.chon.Text = "Chọn"
        Me.chon.UseVisualStyleBackColor = True
        '
        'QUANLYSACH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 589)
        Me.Controls.Add(Me.chon)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "QUANLYSACH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUAN LY SACH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents tensach As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Private WithEvents tacgia As System.Windows.Forms.TextBox
    Private WithEvents theloai As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents soluongton As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Xoa As System.Windows.Forms.Button
    Friend WithEvents Sua As System.Windows.Forms.Button
    Friend WithEvents masach As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Luu As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Khongluu As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Xoatrang As System.Windows.Forms.Button
    Friend WithEvents tracuu As System.Windows.Forms.Button
    Friend WithEvents tracuutensach As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chon As System.Windows.Forms.Button
    Friend WithEvents HIENTHI As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
