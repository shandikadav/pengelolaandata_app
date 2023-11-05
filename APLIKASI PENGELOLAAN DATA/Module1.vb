Imports System.Data.SqlClient
Module Module1
    Public konek As SqlConnection

    Sub konekdb()
        Try
            konek = New SqlConnection("Data Source =DESKTOP-D5OLT2H\SQLEXPRESS;initial catalog=DB_PERUSAHAANPENGELOLAAN;integrated security=true")
            konek.Open()
        Catch ex As Exception
            MsgBox("Database tidak terkoneksi", vbExclamation)
        End Try
    End Sub

    Public Sub jalankansql(ByVal sql As String)
        Dim sqlcmd As New SqlCommand
        Try
            konekdb()
            sqlcmd.Connection = konek
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = sql
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub
End Module
