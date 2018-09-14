<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAOCAOCAONGNO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BAOCAOCAONGNO))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nam = New System.Windows.Forms.TextBox()
        Me.Thang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Luoi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timbaocao = New System.Windows.Forms.Button()
        Me.Lapbaocao = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.Xuatfile = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(364, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BÁO CÁO CÔNG NỢ"
        '
        'Nam
        '
        Me.Nam.BackColor = System.Drawing.Color.White
        Me.Nam.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nam.ForeColor = System.Drawing.Color.Black
        Me.Nam.Location = New System.Drawing.Point(381, 69)
        Me.Nam.Margin = New System.Windows.Forms.Padding(4)
        Me.Nam.Name = "Nam"
        Me.Nam.Size = New System.Drawing.Size(132, 30)
        Me.Nam.TabIndex = 10
        '
        'Thang
        '
        Me.Thang.BackColor = System.Drawing.Color.White
        Me.Thang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thang.ForeColor = System.Drawing.Color.Black
        Me.Thang.Location = New System.Drawing.Point(153, 69)
        Me.Thang.Margin = New System.Windows.Forms.Padding(4)
        Me.Thang.Name = "Thang"
        Me.Thang.Size = New System.Drawing.Size(132, 30)
        Me.Thang.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(312, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NĂM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(61, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "THÁNG"
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.BackgroundColor = System.Drawing.Color.DarkGray
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Luoi.GridColor = System.Drawing.Color.White
        Me.Luoi.Location = New System.Drawing.Point(16, 153)
        Me.Luoi.Margin = New System.Windows.Forms.Padding(4)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(984, 425)
        Me.Luoi.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Machitietcongno"
        Me.Column1.HeaderText = "Mã chi tiết công nợ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Makhachhang"
        Me.Column2.HeaderText = "Mã khách hàng"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.DataPropertyName = "Hotenkhachhang"
        Me.Column8.HeaderText = "Tên khách hàng"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Thang"
        Me.Column3.HeaderText = "Tháng"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Nam"
        Me.Column4.HeaderText = "Năm"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Nodau"
        Me.Column5.HeaderText = "Nợ đầu"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Nophatsinh"
        Me.Column6.HeaderText = "Nợ phát sinh"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Nocuoi"
        Me.Column7.HeaderText = "Nợ cuối"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Timbaocao
        '
        Me.Timbaocao.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timbaocao.Location = New System.Drawing.Point(745, 62)
        Me.Timbaocao.Margin = New System.Windows.Forms.Padding(4)
        Me.Timbaocao.Name = "Timbaocao"
        Me.Timbaocao.Size = New System.Drawing.Size(148, 44)
        Me.Timbaocao.TabIndex = 13
        Me.Timbaocao.Text = "Tìm báo cáo"
        Me.Timbaocao.UseVisualStyleBackColor = True
        '
        'Lapbaocao
        '
        Me.Lapbaocao.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lapbaocao.Location = New System.Drawing.Point(567, 62)
        Me.Lapbaocao.Margin = New System.Windows.Forms.Padding(4)
        Me.Lapbaocao.Name = "Lapbaocao"
        Me.Lapbaocao.Size = New System.Drawing.Size(145, 44)
        Me.Lapbaocao.TabIndex = 12
        Me.Lapbaocao.Text = "Lập báo cáo"
        Me.Lapbaocao.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thoat.Location = New System.Drawing.Point(845, 598)
        Me.Thoat.Margin = New System.Windows.Forms.Padding(4)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(155, 44)
        Me.Thoat.TabIndex = 14
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'Xuatfile
        '
        Me.Xuatfile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xuatfile.Location = New System.Drawing.Point(602, 598)
        Me.Xuatfile.Margin = New System.Windows.Forms.Padding(4)
        Me.Xuatfile.Name = "Xuatfile"
        Me.Xuatfile.Size = New System.Drawing.Size(216, 44)
        Me.Xuatfile.TabIndex = 15
        Me.Xuatfile.Text = "Xuất file excel"
        Me.Xuatfile.UseVisualStyleBackColor = True
        '
        'BAOCAOCAONGNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 657)
        Me.Controls.Add(Me.Xuatfile)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Timbaocao)
        Me.Controls.Add(Me.Lapbaocao)
        Me.Controls.Add(Me.Luoi)
        Me.Controls.Add(Me.Nam)
        Me.Controls.Add(Me.Thang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "BAOCAOCAONGNO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAOCAOCAONGNO"
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nam As System.Windows.Forms.TextBox
    Friend WithEvents Thang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Timbaocao As System.Windows.Forms.Button
    Friend WithEvents Lapbaocao As System.Windows.Forms.Button
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Xuatfile As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
