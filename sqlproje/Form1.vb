Imports System.Data.SqlClient

Public Class Form1
    Dim baglanti As New SqlClient.SqlConnection("
        server=YourServerName;
        database=YourDatabaseName;
        integrated security = true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ekle As New SqlCommand("
        insert into sqlproje.dbo.tablo(isim,soyisim)
        values('" & TextBox1.Text & "','" & TextBox2.Text & "')", baglanti)
        ekle.Connection.Open()
        ekle.ExecuteNonQuery()
        MessageBox.Show("İşlem Başarılı")
        ekle.Connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sil As New SqlCommand("
        delete from sqlproje.dbo.tablo where isim = '" & TextBox1.Text & "'", baglanti)
        sil.Connection.Open()
        sil.ExecuteNonQuery()
        MessageBox.Show("İşlem Başarılı")
        sil.Connection.Close()
    End Sub
End Class