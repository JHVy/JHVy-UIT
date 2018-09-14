<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PHIEUTHUTIEN
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
        Me.Chon = New System.Windows.Forms.Button()
        Me.sotienthu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ngay = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.makhachhang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maphieuthu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tracuu = New System.Windows.Forms.Button()
        Me.tracuukhachhang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.HIENTHI = New System.Windows.Forms.Button()
        Me.Xoatrang = New System.Windows.Forms.Button()
        Me.Them = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Khongluu = New System.Windows.Forms.Button()
        Me.Luu = New System.Windows.Forms.Button()
        Me.Sua = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(480, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PHIẾU THU TIỀN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Chon)
        Me.GroupBox1.Controls.Add(Me.sotienthu)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Ngay)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.makhachhang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.maphieuthu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 98)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu thu"
        '
        'Chon
        '
        Me.Chon.Location = New System.Drawing.Point(571, 12)
        Me.Chon.Name = "Chon"
        Me.Chon.Size = New System.Drawing.Size(75, 23)
        Me.Chon.TabIndex = 44
        Me.Chon.Text = "Chọn"
        Me.Chon.UseVisualStyleBackColor = True
        '
        'sotienthu
        '
        Me.sotienthu.Location = New System.Drawing.Point(457, 59)
        Me.sotienthu.Name = "sotienthu"
        Me.sotienthu.Size = New System.Drawing.Size(108, 20)
        Me.sotienthu.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "SỐ TIỀN THU"
        '
        'Ngay
        '
        Me.Ngay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Ngay.Location = New System.Drawing.Point(109, 59)
        Me.Ngay.Name = "Ngay"
        Me.Ngay.Size = New System.Drawing.Size(108, 20)
        Me.Ngay.TabIndex = 40
        Me.Ngay.Value = New Date(2017, 5, 21, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "NGÀY THU TIỀN"
        '
        'makhachhang
        '
        Me.makhachhang.Enabled = False
        Me.makhachhang.Location = New System.Drawing.Point(457, 16)
        Me.makhachhang.Name = "makhachhang"
        Me.makhachhang.Size = New System.Drawing.Size(108, 20)
        Me.makhachhang.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "MÃ KHÁCH HÀNG"
        '
        'maphieuthu
        '
        Me.maphieuthu.Enabled = False
        Me.maphieuthu.Location = New System.Drawing.Point(109, 20)
        Me.maphieuthu.Name = "maphieuthu"
        Me.maphieuthu.Size = New System.Drawing.Size(108, 20)
        Me.maphieuthu.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "MÃ PHIẾU THU"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Luoi)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 422)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách phiếu thu"
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.Luoi.Location = New System.Drawing.Point(6, 13)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(788, 403)
        Me.Luoi.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Maphieuthu"
        Me.Column1.HeaderText = "Mã phiếu thu"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Makhachhang"
        Me.Column2.HeaderText = "Mã khách hàng"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        Me.Column2.Width = 187
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "Hotenkhachhang"
        Me.Column5.HeaderText = "Họ tên khách hàng"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Ngaythutien"
        Me.Column3.HeaderText = "Ngày thu tiền"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Sotienthu"
        Me.Column4.HeaderText = "Số tiền thu"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tracuu)
        Me.GroupBox4.Controls.Add(Me.tracuukhachhang)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(841, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 98)
        Me.GroupBox4.TabIndex = 42
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
        'tracuukhachhang
        '
        Me.tracuukhachhang.BackColor = System.Drawing.SystemColors.Window
        Me.tracuukhachhang.Cursor = System.Windows.Forms.Cursors.Default
        Me.tracuukhachhang.Location = New System.Drawing.Point(123, 14)
        Me.tracuukhachhang.Name = "tracuukhachhang"
        Me.tracuukhachhang.Size = New System.Drawing.Size(121, 20)
        Me.tracuukhachhang.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "TÊN KHÁCH HÀNG"
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
        Me.GroupBox2.TabIndex = 43
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
        'Them
        '
        Me.Them.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Them.Location = New System.Drawing.Point(6, 31)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(112, 37)
        Me.Them.TabIndex = 23
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
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
        'Thoat
        '
        Me.Thoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(973, 531)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(112, 37)
        Me.Thoat.TabIndex = 44
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'PHIEUTHUTIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 589)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PHIEUTHUTIEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHIEUTHUTIEN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tracuu As System.Windows.Forms.Button
    Friend WithEvents tracuukhachhang As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents HIENTHI As System.Windows.Forms.Button
    Friend WithEvents Xoatrang As System.Windows.Forms.Button
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Xoa As System.Windows.Forms.Button
    Friend WithEvents Khongluu As System.Windows.Forms.Button
    Friend WithEvents Luu As System.Windows.Forms.Button
    Friend WithEvents Sua As System.Windows.Forms.Button
    Friend WithEvents maphieuthu As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents makhachhang As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sotienthu As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Chon As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
