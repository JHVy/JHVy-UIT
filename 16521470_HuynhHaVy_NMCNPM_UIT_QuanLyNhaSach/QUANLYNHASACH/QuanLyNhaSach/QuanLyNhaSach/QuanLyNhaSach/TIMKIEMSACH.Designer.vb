<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TIMKIEMSACH
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
        Me.Tensach = New System.Windows.Forms.TextBox()
        Me.Theloai = New System.Windows.Forms.TextBox()
        Me.Tacgia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CTacgia = New System.Windows.Forms.CheckBox()
        Me.CTheloai = New System.Windows.Forms.CheckBox()
        Me.CTensach = New System.Windows.Forms.CheckBox()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TRA CỨU SÁCH"
        '
        'Tensach
        '
        Me.Tensach.Location = New System.Drawing.Point(101, 16)
        Me.Tensach.Name = "Tensach"
        Me.Tensach.Size = New System.Drawing.Size(100, 20)
        Me.Tensach.TabIndex = 7
        '
        'Theloai
        '
        Me.Theloai.Location = New System.Drawing.Point(101, 57)
        Me.Theloai.Name = "Theloai"
        Me.Theloai.Size = New System.Drawing.Size(100, 20)
        Me.Theloai.TabIndex = 8
        '
        'Tacgia
        '
        Me.Tacgia.Location = New System.Drawing.Point(306, 16)
        Me.Tacgia.Name = "Tacgia"
        Me.Tacgia.Size = New System.Drawing.Size(100, 20)
        Me.Tacgia.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TÊN SÁCH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "THỂ LOẠI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "TÁC GIẢ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tensach)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Theloai)
        Me.GroupBox1.Controls.Add(Me.Tacgia)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 89)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CTacgia)
        Me.GroupBox2.Controls.Add(Me.CTheloai)
        Me.GroupBox2.Controls.Add(Me.CTensach)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 89)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin tìm kiếm"
        '
        'CTacgia
        '
        Me.CTacgia.AutoSize = True
        Me.CTacgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTacgia.Location = New System.Drawing.Point(181, 16)
        Me.CTacgia.Name = "CTacgia"
        Me.CTacgia.Size = New System.Drawing.Size(92, 24)
        Me.CTacgia.TabIndex = 2
        Me.CTacgia.Text = "TÁC GIẢ"
        Me.CTacgia.UseVisualStyleBackColor = True
        '
        'CTheloai
        '
        Me.CTheloai.AutoSize = True
        Me.CTheloai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTheloai.Location = New System.Drawing.Point(22, 53)
        Me.CTheloai.Name = "CTheloai"
        Me.CTheloai.Size = New System.Drawing.Size(101, 24)
        Me.CTheloai.TabIndex = 1
        Me.CTheloai.Text = "THỂ LOẠI"
        Me.CTheloai.UseVisualStyleBackColor = True
        '
        'CTensach
        '
        Me.CTensach.AutoSize = True
        Me.CTensach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTensach.Location = New System.Drawing.Point(22, 16)
        Me.CTensach.Name = "CTensach"
        Me.CTensach.Size = New System.Drawing.Size(108, 24)
        Me.CTensach.TabIndex = 0
        Me.CTensach.Text = "TÊN SÁCH"
        Me.CTensach.UseVisualStyleBackColor = True
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Luoi.Location = New System.Drawing.Point(12, 140)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(738, 345)
        Me.Luoi.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Masach"
        Me.Column1.HeaderText = "Mã sách"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
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
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Theloai"
        Me.Column3.HeaderText = "Thể loại"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Tacgia"
        Me.Column4.HeaderText = "Tác giả"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Soluongton"
        Me.Column5.HeaderText = "Số lượng tồn"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(663, 491)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(87, 36)
        Me.Thoat.TabIndex = 17
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Timkiem
        '
        Me.Timkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timkiem.Location = New System.Drawing.Point(570, 491)
        Me.Timkiem.Name = "Timkiem"
        Me.Timkiem.Size = New System.Drawing.Size(87, 36)
        Me.Timkiem.TabIndex = 18
        Me.Timkiem.Text = "Tìm kiếm"
        Me.Timkiem.UseVisualStyleBackColor = True
        '
        'Hienthi
        '
        Me.Hienthi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hienthi.Location = New System.Drawing.Point(445, 491)
        Me.Hienthi.Name = "Hienthi"
        Me.Hienthi.Size = New System.Drawing.Size(119, 36)
        Me.Hienthi.TabIndex = 19
        Me.Hienthi.Text = "HIển thị tất cả"
        Me.Hienthi.UseVisualStyleBackColor = True
        '
        'TIMKIEMSACH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 534)
        Me.Controls.Add(Me.Hienthi)
        Me.Controls.Add(Me.Timkiem)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Luoi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "TIMKIEMSACH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIMKIEMSACH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tensach As System.Windows.Forms.TextBox
    Friend WithEvents Theloai As System.Windows.Forms.TextBox
    Friend WithEvents Tacgia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CTacgia As System.Windows.Forms.CheckBox
    Friend WithEvents CTheloai As System.Windows.Forms.CheckBox
    Friend WithEvents CTensach As System.Windows.Forms.CheckBox
    Friend WithEvents Luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Timkiem As System.Windows.Forms.Button
    Friend WithEvents Hienthi As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
