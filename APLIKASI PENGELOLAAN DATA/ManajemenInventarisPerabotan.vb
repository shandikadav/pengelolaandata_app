Imports System.Data.SqlClient
Public Class ManajemenInventarisPerabotan

    Sub bersihkandata()
        txt_perabotanid.Text = ""
        txt_namabarang.Text = ""
        txt_suplierid.Text = ""
        txt_hargabarang.Text = ""
        cmb_namasuplier.Text = ""
    End Sub

    Sub tampildatacmb()
        konekdb()
        Dim cmd As New SqlCommand("SELECT NamaSuplier FROM suplier", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            Do While rd.Read
                cmb_namasuplier.Items.Add(rd.Item("NamaSuplier"))
            Loop
        End If
    End Sub

    Sub tampilkandata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT perabotan.ID,NamaPerabotan,suplier.NamaSuplier,HargaPerabotan FROM perabotan,suplier WHERE suplier.ID = perabotan.SuplierID", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "perabotan")
        DataGridView1.DataSource = ds.Tables("perabotan")
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_perabotanid.Text = "" Or txt_namabarang.Text = "" Or cmb_namasuplier.Text = "" Or txt_hargabarang.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_perabotanid.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "INSERT INTO perabotan VALUES ('" + txt_perabotanid.Text + "','" + txt_namabarang.Text + "','" + txt_suplierid.Text + "','" + txt_hargabarang.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub ManajemenInventarisPerabotan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
        tampildatacmb()
        Label6.Visible = False
        txt_suplierid.Visible = False
    End Sub

    Private Sub cmb_namasuplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_namasuplier.SelectedIndexChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM suplier WHERE NamaSuplier = '" + cmb_namasuplier.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_suplierid.Text = rd.Item(0)
        End If
    End Sub

    Private Sub txt_suplierid_TextChanged(sender As Object, e As EventArgs) Handles txt_suplierid.TextChanged
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM suplier WHERE ID = '" + txt_suplierid.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            cmb_namasuplier.Text = rd.Item(1)
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_perabotanid.Text = "" Or txt_namabarang.Text = "" Or cmb_namasuplier.Text = "" Or txt_hargabarang.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_perabotanid.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "UPDATE perabotan SET NamaPerabotan = '" + txt_namabarang.Text + "', SuplierID = '" + txt_suplierid.Text + "', HargaPerabotan = '" + txt_hargabarang.Text + "' WHERE ID = '" + txt_perabotanid.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_perabotanid.Text = "" Or txt_namabarang.Text = "" Or cmb_namasuplier.Text = "" Or txt_hargabarang.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_perabotanid.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = DialogResult.No Then
                Exit Sub
            End If
            sql = "DELETE FROM perabotan WHERE ID LIKE '" + txt_perabotanid.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM perabotan WHERE ID = '" + txt_perabotanid.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_perabotanid.Text = rd.Item(0)
            txt_namabarang.Text = rd.Item(1)
            txt_suplierid.Text = rd.Item(2)
            txt_hargabarang.Text = rd.Item(3)
        Else
            MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
