<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRACUUNHANVIEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRACUUNHANVIEN))
        Me.Hienthi = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDiachi = New System.Windows.Forms.CheckBox()
        Me.CDienthoai = New System.Windows.Forms.CheckBox()
        Me.CTennhanvien = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tennhanvien = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dienthoai = New System.Windows.Forms.TextBox()
        Me.Diachi = New System.Windows.Forms.TextBox()
        Me.Timkiem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hienthi
        '
        Me.Hienthi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hienthi.Location = New System.Drawing.Point(815, 172)
        Me.Hienthi.Margin = New System.Windows.Forms.Padding(4)
        Me.Hienthi.Name = "Hienthi"
        Me.Hienthi.Size = New System.Drawing.Size(173, 44)
        Me.Hienthi.TabIndex = 27
        Me.Hienthi.Text = "Hiển thị tất cả"
        Me.Hienthi.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(870, 603)
        Me.Thoat.Margin = New System.Windows.Forms.Padding(4)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(130, 44)
        Me.Thoat.TabIndex = 25
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.BackgroundColor = System.Drawing.Color.Gray
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.Luoi.GridColor = System.Drawing.Color.White
        Me.Luoi.Location = New System.Drawing.Point(16, 237)
        Me.Luoi.Margin = New System.Windows.Forms.Padding(4)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(984, 359)
        Me.Luoi.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Manhanvien"
        Me.Column1.HeaderText = "Mã nhân viên"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Hotennhanvien"
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
        Me.Column5.DataPropertyName = "Tienluong"
        Me.Column5.HeaderText = "Tiền lương"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'CDiachi
        '
        Me.CDiachi.AutoSize = True
        Me.CDiachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDiachi.Location = New System.Drawing.Point(236, 31)
        Me.CDiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.CDiachi.Name = "CDiachi"
        Me.CDiachi.Size = New System.Drawing.Size(103, 26)
        Me.CDiachi.TabIndex = 2
        Me.CDiachi.Text = "ĐỊA CHỈ"
        Me.CDiachi.UseVisualStyleBackColor = True
        '
        'CDienthoai
        '
        Me.CDienthoai.AutoSize = True
        Me.CDienthoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDienthoai.Location = New System.Drawing.Point(29, 65)
        Me.CDienthoai.Margin = New System.Windows.Forms.Padding(4)
        Me.CDienthoai.Name = "CDienthoai"
        Me.CDienthoai.Size = New System.Drawing.Size(143, 26)
        Me.CDienthoai.TabIndex = 1
        Me.CDienthoai.Text = "ĐIỆN THOẠI"
        Me.CDienthoai.UseVisualStyleBackColor = True
        '
        'CTennhanvien
        '
        Me.CTennhanvien.AutoSize = True
        Me.CTennhanvien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTennhanvien.Location = New System.Drawing.Point(29, 31)
        Me.CTennhanvien.Margin = New System.Windows.Forms.Padding(4)
        Me.CTennhanvien.Name = "CTennhanvien"
        Me.CTennhanvien.Size = New System.Drawing.Size(102, 26)
        Me.CTennhanvien.TabIndex = 0
        Me.CTennhanvien.Text = "TÊN NV"
        Me.CTennhanvien.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CDiachi)
        Me.GroupBox2.Controls.Add(Me.CDienthoai)
        Me.GroupBox2.Controls.Add(Me.CTennhanvien)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(593, 54)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(395, 110)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin tìm kiếm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TÊN NV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ĐỊA CHỈ"
        '
        'Tennhanvien
        '
        Me.Tennhanvien.BackColor = System.Drawing.Color.White
        Me.Tennhanvien.ForeColor = System.Drawing.Color.Black
        Me.Tennhanvien.Location = New System.Drawing.Point(151, 25)
        Me.Tennhanvien.Margin = New System.Windows.Forms.Padding(4)
        Me.Tennhanvien.Name = "Tennhanvien"
        Me.Tennhanvien.Size = New System.Drawing.Size(132, 30)
        Me.Tennhanvien.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ĐIỆN THOẠI"
        '
        'Dienthoai
        '
        Me.Dienthoai.BackColor = System.Drawing.Color.White
        Me.Dienthoai.ForeColor = System.Drawing.Color.Black
        Me.Dienthoai.Location = New System.Drawing.Point(151, 70)
        Me.Dienthoai.Margin = New System.Windows.Forms.Padding(4)
        Me.Dienthoai.Name = "Dienthoai"
        Me.Dienthoai.Size = New System.Drawing.Size(132, 30)
        Me.Dienthoai.TabIndex = 8
        '
        'Diachi
        '
        Me.Diachi.BackColor = System.Drawing.Color.White
        Me.Diachi.ForeColor = System.Drawing.Color.Black
        Me.Diachi.Location = New System.Drawing.Point(408, 25)
        Me.Diachi.Margin = New System.Windows.Forms.Padding(4)
        Me.Diachi.Name = "Diachi"
        Me.Diachi.Size = New System.Drawing.Size(132, 30)
        Me.Diachi.TabIndex = 9
        '
        'Timkiem
        '
        Me.Timkiem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timkiem.Location = New System.Drawing.Point(593, 172)
        Me.Timkiem.Margin = New System.Windows.Forms.Padding(4)
        Me.Timkiem.Name = "Timkiem"
        Me.Timkiem.Size = New System.Drawing.Size(159, 44)
        Me.Timkiem.TabIndex = 26
        Me.Timkiem.Text = "Tìm kiếm"
        Me.Timkiem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tennhanvien)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Dienthoai)
        Me.GroupBox1.Controls.Add(Me.Diachi)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(16, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(569, 110)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(400, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "TRA CỨU NHÂN VIÊN"
        '
        'TRACUUNHANVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 657)
        Me.Controls.Add(Me.Hienthi)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Luoi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Timkiem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TRACUUNHANVIEN"
        Me.Text = "TRACUUNHANVIEN"
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hienthi As Button
    Friend WithEvents Thoat As Button
    Friend WithEvents Luoi As DataGridView
    Friend WithEvents CDiachi As CheckBox
    Friend WithEvents CDienthoai As CheckBox
    Friend WithEvents CTennhanvien As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tennhanvien As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dienthoai As TextBox
    Friend WithEvents Diachi As TextBox
    Friend WithEvents Timkiem As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
