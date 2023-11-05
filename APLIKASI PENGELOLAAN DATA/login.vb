Imports System.Data.SqlClient
Public Class login

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_uname.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Username atau Password belum terisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_uname.Focus()
        Else
            konekdb()
            Dim cmd As New SqlCommand("SELECT * FROM akun WHERE Username = '" + txt_uname.Text + "' AND Password = '" + txt_pass.Text + "'", konek)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                If rd.Item(2).ToString = "Administrator" Then
                    MessageBox.Show("Login sebagai Administrator Set berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AdminSet.Show()
                    Me.Hide()
                ElseIf rd.Item(2).ToString = "Pimpinan" Then
                    MessageBox.Show("Login sebagai Pimpinan berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Pimpinan.Show()
                    Me.Hide()
                ElseIf rd.Item(2).ToString = "Staff" Then
                    MessageBox.Show("Login sebagai Staff berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Staff.Show()
                    Me.Hide()
                ElseIf rd.Item(2).ToString = "Suplier" Then
                    MessageBox.Show("Login sebagai Suplier berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Supplier.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Username atau Password salah, silahkan coba lagi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_uname.Text = ""
                txt_pass.Text = ""
            End If
        End If
    End Sub
End Class
