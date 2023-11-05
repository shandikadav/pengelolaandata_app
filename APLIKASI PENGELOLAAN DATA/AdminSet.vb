Imports System.Data.SqlClient
Public Class AdminSet

    Sub kondisiawal()
        ManajemenInventarisbarang1.Visible = False
        ManajemenInventarisPerabotan1.Visible = False
    End Sub

    Private Sub ManajemenInventarisbarang1_Load(sender As Object, e As EventArgs) Handles ManajemenInventarisbarang1.Load
        kondisiawal()
    End Sub

    Private Sub btn_inventaris_Click(sender As Object, e As EventArgs) Handles btn_inventaris.Click
        ManajemenInventarisbarang1.Visible = True
        ManajemenInventarisPerabotan1.Visible = False
    End Sub

    Private Sub btn_perabotan_Click(sender As Object, e As EventArgs) Handles btn_perabotan.Click
        ManajemenInventarisPerabotan1.Visible = True
        ManajemenInventarisbarang1.Visible = False
    End Sub
End Class