<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APLIKASI PENGELOLAAN DATA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(93, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PERUSAHAAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "USERNAME"
        '
        'txt_uname
        '
        Me.txt_uname.Location = New System.Drawing.Point(26, 150)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(265, 20)
        Me.txt_uname.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PASSWORD"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(26, 203)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(265, 20)
        Me.txt_pass.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(26, 230)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Lihat Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Location = New System.Drawing.Point(26, 277)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(265, 27)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 375)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_uname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMKBISA!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btn_login As Button
End Class
