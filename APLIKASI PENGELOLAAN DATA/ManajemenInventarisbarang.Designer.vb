<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenInventarisbarang
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_barangid = New System.Windows.Forms.TextBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.cmb_namasuplier = New System.Windows.Forms.ComboBox()
        Me.txt_hargabarang = New System.Windows.Forms.TextBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_suplierid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANAJEMEN INVENTARIS BARANG"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(792, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NAMA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NAMA SUPLIER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "HARGA BARANG"
        '
        'txt_barangid
        '
        Me.txt_barangid.Location = New System.Drawing.Point(275, 257)
        Me.txt_barangid.Name = "txt_barangid"
        Me.txt_barangid.Size = New System.Drawing.Size(251, 20)
        Me.txt_barangid.TabIndex = 0
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(275, 287)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(251, 20)
        Me.txt_namabarang.TabIndex = 1
        '
        'cmb_namasuplier
        '
        Me.cmb_namasuplier.FormattingEnabled = True
        Me.cmb_namasuplier.Location = New System.Drawing.Point(275, 317)
        Me.cmb_namasuplier.Name = "cmb_namasuplier"
        Me.cmb_namasuplier.Size = New System.Drawing.Size(251, 21)
        Me.cmb_namasuplier.TabIndex = 2
        '
        'txt_hargabarang
        '
        Me.txt_hargabarang.Location = New System.Drawing.Point(275, 348)
        Me.txt_hargabarang.Name = "txt_hargabarang"
        Me.txt_hargabarang.Size = New System.Drawing.Size(251, 20)
        Me.txt_hargabarang.TabIndex = 3
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_cari.FlatAppearance.BorderSize = 0
        Me.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cari.Location = New System.Drawing.Point(532, 254)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(67, 25)
        Me.btn_cari.TabIndex = 8
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_simpan.Location = New System.Drawing.Point(113, 428)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(102, 35)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_ubah.Location = New System.Drawing.Point(373, 428)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(102, 35)
        Me.btn_ubah.TabIndex = 6
        Me.btn_ubah.Text = "UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_hapus.Location = New System.Drawing.Point(620, 428)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(102, 35)
        Me.btn_hapus.TabIndex = 7
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Suplier ID"
        '
        'txt_suplierid
        '
        Me.txt_suplierid.Location = New System.Drawing.Point(275, 374)
        Me.txt_suplierid.Name = "txt_suplierid"
        Me.txt_suplierid.Size = New System.Drawing.Size(251, 20)
        Me.txt_suplierid.TabIndex = 4
        '
        'ManajemenInventarisbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txt_suplierid)
        Me.Controls.Add(Me.txt_hargabarang)
        Me.Controls.Add(Me.cmb_namasuplier)
        Me.Controls.Add(Me.txt_namabarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_barangid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManajemenInventarisbarang"
        Me.Size = New System.Drawing.Size(815, 500)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_barangid As TextBox
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents cmb_namasuplier As ComboBox
    Friend WithEvents txt_hargabarang As TextBox
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_suplierid As TextBox
End Class
