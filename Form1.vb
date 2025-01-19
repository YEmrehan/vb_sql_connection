Imports System.Data.SqlClient

Public Class Form1
    Dim baglanti As New SqlClient.SqlConnection("
        server=pc_name\SQLEXPRESS;
        database=vb_sql_connection;
        integrated security = true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ekle As New SqlCommand("
        insert into vb_sql_connection.dbo.table_1(isim,soyisim)
        values('" & TextBox1.Text & "','" & TextBox2.Text & "')", baglanti)
        ekle.Connection.Open()
        ekle.ExecuteNonQuery()
        MessageBox.Show("İşlem Başarılı")
        ekle.Connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sil As New SqlCommand("
        delete from vb_sql_connection.dbo.table_1 where isim = '" & TextBox1.Text & "'", baglanti)
        sil.Connection.Open()
        sil.ExecuteNonQuery()
        MessageBox.Show("İşlem Başarılı")
        sil.Connection.Close()
    End Sub
End Class