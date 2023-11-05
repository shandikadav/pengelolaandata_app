<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.btn_approvalkantor = New System.Windows.Forms.Button()
        Me.btn_approvalbarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_laporan)
        Me.Panel1.Controls.Add(Me.btn_approvalkantor)
        Me.Panel1.Controls.Add(Me.btn_approvalbarang)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 500)
        Me.Panel1.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_logout.Location = New System.Drawing.Point(13, 294)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(165, 41)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_laporan
        '
        Me.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_laporan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_laporan.Location = New System.Drawing.Point(13, 227)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(165, 49)
        Me.btn_laporan.TabIndex = 2
        Me.btn_laporan.Text = "KIRIM LAPORAN PENGIRIMAN"
        Me.btn_laporan.UseVisualStyleBackColor = True
        '
        'btn_approvalkantor
        '
        Me.btn_approvalkantor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_approvalkantor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_approvalkantor.Location = New System.Drawing.Point(13, 162)
        Me.btn_approvalkantor.Name = "btn_approvalkantor"
        Me.btn_approvalkantor.Size = New System.Drawing.Size(165, 49)
        Me.btn_approvalkantor.TabIndex = 2
        Me.btn_approvalkantor.Text = "CEK KONDISI BARANG TERKIRIM"
        Me.btn_approvalkantor.UseVisualStyleBackColor = True
        '
        'btn_approvalbarang
        '
        Me.btn_approvalbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_approvalbarang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_approvalbarang.Location = New System.Drawing.Point(13, 96)
        Me.btn_approvalbarang.Name = "btn_approvalbarang"
        Me.btn_approvalbarang.Size = New System.Drawing.Size(165, 49)
        Me.btn_approvalbarang.TabIndex = 2
        Me.btn_approvalbarang.Text = "CEK DAFTAR PEMESANAN"
        Me.btn_approvalbarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SUPLIER"
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 500)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMKBISA!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_laporan As Button
    Friend WithEvents btn_approvalkantor As Button
    Friend WithEvents btn_approvalbarang As Button
    Friend WithEvents Label1 As Label
End Class
