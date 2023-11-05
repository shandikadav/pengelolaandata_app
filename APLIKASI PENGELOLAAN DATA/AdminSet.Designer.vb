<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_pesanperabotan = New System.Windows.Forms.Button()
        Me.btn_pesanbarang = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_perabotan = New System.Windows.Forms.Button()
        Me.btn_inventaris = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ManajemenInventarisbarang1 = New APLIKASI_PENGELOLAAN_DATA.ManajemenInventarisbarang()
        Me.ManajemenInventarisPerabotan1 = New APLIKASI_PENGELOLAAN_DATA.ManajemenInventarisPerabotan()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_pesanperabotan)
        Me.Panel1.Controls.Add(Me.btn_pesanbarang)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_perabotan)
        Me.Panel1.Controls.Add(Me.btn_inventaris)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 500)
        Me.Panel1.TabIndex = 0
        '
        'btn_pesanperabotan
        '
        Me.btn_pesanperabotan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pesanperabotan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pesanperabotan.Location = New System.Drawing.Point(13, 293)
        Me.btn_pesanperabotan.Name = "btn_pesanperabotan"
        Me.btn_pesanperabotan.Size = New System.Drawing.Size(165, 49)
        Me.btn_pesanperabotan.TabIndex = 3
        Me.btn_pesanperabotan.Text = "MANAJEMEN PEMESANAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PERABOTAN PERUSAHAAN"
        Me.btn_pesanperabotan.UseVisualStyleBackColor = True
        '
        'btn_pesanbarang
        '
        Me.btn_pesanbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pesanbarang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pesanbarang.Location = New System.Drawing.Point(13, 227)
        Me.btn_pesanbarang.Name = "btn_pesanbarang"
        Me.btn_pesanbarang.Size = New System.Drawing.Size(165, 49)
        Me.btn_pesanbarang.TabIndex = 2
        Me.btn_pesanbarang.Text = "MANAJEMEN PEMESANAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BARANG PERUSAHAAN"
        Me.btn_pesanbarang.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_logout.Location = New System.Drawing.Point(13, 360)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(165, 41)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_perabotan
        '
        Me.btn_perabotan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_perabotan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_perabotan.Location = New System.Drawing.Point(13, 162)
        Me.btn_perabotan.Name = "btn_perabotan"
        Me.btn_perabotan.Size = New System.Drawing.Size(165, 49)
        Me.btn_perabotan.TabIndex = 1
        Me.btn_perabotan.Text = "MANAJEMEN DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PERABOTAN PERUSAHAAN"
        Me.btn_perabotan.UseVisualStyleBackColor = True
        '
        'btn_inventaris
        '
        Me.btn_inventaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inventaris.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_inventaris.Location = New System.Drawing.Point(13, 96)
        Me.btn_inventaris.Name = "btn_inventaris"
        Me.btn_inventaris.Size = New System.Drawing.Size(165, 49)
        Me.btn_inventaris.TabIndex = 0
        Me.btn_inventaris.Text = "MANAJEMEN DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INVENTARIS BARANG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_inventaris.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADMINISTRASI ASET"
        '
        'ManajemenInventarisbarang1
        '
        Me.ManajemenInventarisbarang1.Location = New System.Drawing.Point(193, 0)
        Me.ManajemenInventarisbarang1.Name = "ManajemenInventarisbarang1"
        Me.ManajemenInventarisbarang1.Size = New System.Drawing.Size(815, 500)
        Me.ManajemenInventarisbarang1.TabIndex = 1
        '
        'ManajemenInventarisPerabotan1
        '
        Me.ManajemenInventarisPerabotan1.Location = New System.Drawing.Point(193, 0)
        Me.ManajemenInventarisPerabotan1.Name = "ManajemenInventarisPerabotan1"
        Me.ManajemenInventarisPerabotan1.Size = New System.Drawing.Size(815, 500)
        Me.ManajemenInventarisPerabotan1.TabIndex = 2
        '
        'AdminSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 500)
        Me.Controls.Add(Me.ManajemenInventarisPerabotan1)
        Me.Controls.Add(Me.ManajemenInventarisbarang1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMKBISA!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_perabotan As Button
    Friend WithEvents btn_inventaris As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_pesanperabotan As Button
    Friend WithEvents btn_pesanbarang As Button
    Friend WithEvents ManajemenInventarisbarang1 As ManajemenInventarisbarang
    Friend WithEvents ManajemenInventarisPerabotan1 As ManajemenInventarisPerabotan
End Class
