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
        CType(Me.Luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BÁO CÁO CÔNG NỢ"
        '
        'Nam
        '
        Me.Nam.Location = New System.Drawing.Point(284, 63)
        Me.Nam.Name = "Nam"
        Me.Nam.Size = New System.Drawing.Size(100, 20)
        Me.Nam.TabIndex = 10
        '
        'Thang
        '
        Me.Thang.Location = New System.Drawing.Point(117, 63)
        Me.Thang.Name = "Thang"
        Me.Thang.Size = New System.Drawing.Size(100, 20)
        Me.Thang.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NĂM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "THÁNG"
        '
        'Luoi
        '
        Me.Luoi.AllowUserToAddRows = False
        Me.Luoi.AllowUserToDeleteRows = False
        Me.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Luoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Luoi.Location = New System.Drawing.Point(12, 124)
        Me.Luoi.Name = "Luoi"
        Me.Luoi.ReadOnly = True
        Me.Luoi.Size = New System.Drawing.Size(738, 345)
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
        Me.Timbaocao.Location = New System.Drawing.Point(561, 56)
        Me.Timbaocao.Name = "Timbaocao"
        Me.Timbaocao.Size = New System.Drawing.Size(87, 36)
        Me.Timbaocao.TabIndex = 13
        Me.Timbaocao.Text = "Tìm báo cáo"
        Me.Timbaocao.UseVisualStyleBackColor = True
        '
        'Lapbaocao
        '
        Me.Lapbaocao.Location = New System.Drawing.Point(431, 54)
        Me.Lapbaocao.Name = "Lapbaocao"
        Me.Lapbaocao.Size = New System.Drawing.Size(87, 36)
        Me.Lapbaocao.TabIndex = 12
        Me.Lapbaocao.Text = "Lập báo cáo"
        Me.Lapbaocao.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Location = New System.Drawing.Point(663, 486)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(87, 36)
        Me.Thoat.TabIndex = 14
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'BAOCAOCAONGNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 534)
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
End Class
