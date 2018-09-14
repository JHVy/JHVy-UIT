<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRACCUUKHACHHANG
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dienthoai = New System.Windows.Forms.TextBox()
        Me.Diachi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CDiachi = New System.Windows.Forms.CheckBox()
        Me.CDienthoai = New System.Windows.Forms.CheckBox()
        Me.CTenkhachhang = New System.Windows.Forms.CheckBox()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Timkiem = New System.Windows.Forms.Button()
        Me.Hienthi = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(300, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TRA CỨU KHÁCH HÀNG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tenkhachhang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Dienthoai)
        Me.GroupBox1.Controls.Add(Me.Diachi)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 89)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TÊN KH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ĐỊA CHỈ"
        '
        'Tenkhachhang
        '
        Me.Tenkhachhang.BackColor = System.Drawing.Color.White
        Me.Tenkhachhang.ForeColor = System.Drawing.Color.Black
        Me.Tenkhachhang.Location = New System.Drawing.Point(113, 20)
        Me.Tenkhachhang.Name = "Tenkhachhang"
        Me.Tenkhachhang.Size = New System.Drawing.Size(100, 26)
        Me.Tenkhachhang.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ĐIỆN THOẠI"
        '
        'Dienthoai
        '
        Me.Dienthoai.BackColor = System.Drawing.Color.White
        Me.Dienthoai.ForeColor = System.Drawing.Color.Black
        Me.Dienthoai.Location = New System.Drawing.Point(113, 57)
        Me.Dienthoai.Name = "Dienthoai"
        Me.Dienthoai.Size = New System.Drawing.Size(100, 26)
        Me.Dienthoai.TabIndex = 8
        '
        'Diachi
        '
        Me.Diachi.BackColor = System.Drawing.Color.White
        Me.Diachi.ForeColor = System.Drawing.Color.Black
        Me.Diachi.Location = New System.Drawing.Point(306, 20)
        Me.Diachi.Name = "Diachi"
        Me.Diachi.Size = New System.Drawing.Size(100, 26)
        Me.Diachi.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CDiachi)
        Me.GroupBox2.Controls.Add(Me.CDienthoai)
        Me.GroupBox2.Controls.Add(Me.CTenkhachhang)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(445, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 89)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin tìm kiếm"
        '
        'CDiachi
        '
        Me.CDiachi.AutoSize = True
        Me.CDiachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDiachi.Location = New System.Drawing.Point(181, 16)
        Me.CDiachi.Name = "CDiachi"
        Me.CDiachi.Size = New System.Drawing.Size(85, 23)
        Me.CDiachi.TabIndex = 2
        Me.CDiachi.Text = "ĐỊA CHỈ"
        Me.CDiachi.UseVisualStyleBackColor = True
        '
        'CDienthoai
        '
        Me.CDienthoai.AutoSize = True
        Me.CDienthoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDienthoai.Location = New System.Drawing.Point(22, 53)
        Me.CDienthoai.Name = "CDienthoai"
        Me.CDienthoai.Size = New System.Drawing.Size(117, 23)
        Me.CDienthoai.TabIndex = 1
        Me.CDienthoai.Text = "ĐIỆN THOẠI"
        Me.CDienthoai.UseVisualStyleBackColor = True
        '
        'CTenkhachhang
        '
        Me.CTenkhachhang.AutoSize = True
        Me.CTenkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTenkhachhang.Location = New System.Drawing.Point(22, 16)
        Me.CTenkhachhang.Name = "CTenkhachhang"
        Me.CTenkhachhang.Size = New System.Drawing.Size(85, 23)
        Me.CTenkhachhang.TabIndex = 0
        Me.CTenkhachhang.Text = "TÊN KH"
        Me.CTenkhachhang.UseVisualStyleBackColor = True
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.BackgroundColor = System.Drawing.Color.Gray
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.Luoi.GridColor = System.Drawing.Color.White
        Me.Luoi.Location = New System.Drawing.Point(12, 140)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(738, 345)
        Me.Luoi.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Makhachhang"
        Me.Column1.HeaderText = "Mã khách hàng"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Hotenkhachhang"
        Me.Column2.HeaderText = "Họ tên"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Diachi"
        Me.Column3.HeaderText = "Địa chỉ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Dienthoai"
        Me.Column6.HeaderText = "Điện thoại"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Email"
        Me.Column4.HeaderText = "Email"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Sotienno"
        Me.Column5.HeaderText = "Số tiền nợ"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(663, 491)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(87, 36)
        Me.Thoat.TabIndex = 18
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Timkiem
        '
        Me.Timkiem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timkiem.Location = New System.Drawing.Point(570, 491)
        Me.Timkiem.Name = "Timkiem"
        Me.Timkiem.Size = New System.Drawing.Size(87, 36)
        Me.Timkiem.TabIndex = 19
        Me.Timkiem.Text = "Tìm kiếm"
        Me.Timkiem.UseVisualStyleBackColor = True
        '
        'Hienthi
        '
        Me.Hienthi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hienthi.Location = New System.Drawing.Point(445, 491)
        Me.Hienthi.Name = "Hienthi"
        Me.Hienthi.Size = New System.Drawing.Size(119, 36)
        Me.Hienthi.TabIndex = 20
        Me.Hienthi.Text = "HIển thị tất cả"
        Me.Hienthi.UseVisualStyleBackColor = True
        '
        'TRACCUUKHACHHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(762, 534)
        Me.Controls.Add(Me.Hienthi)
        Me.Controls.Add(Me.Timkiem)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Luoi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TRACCUUKHACHHANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRACCUUKHACHHANG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dienthoai As System.Windows.Forms.TextBox
    Friend WithEvents Diachi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CDiachi As System.Windows.Forms.CheckBox
    Friend WithEvents CDienthoai As System.Windows.Forms.CheckBox
    Friend WithEvents CTenkhachhang As System.Windows.Forms.CheckBox
    Friend WithEvents Luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Timkiem As System.Windows.Forms.Button
    Friend WithEvents Hienthi As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
