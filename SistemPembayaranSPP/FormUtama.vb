Public Class FormUtama
    Private Sub BtnSiswa_Click(sender As Object, e As EventArgs) Handles BtnSiswa.Click
        FormSiswa.Show()
    End Sub

    Private Sub BtnKelas_Click(sender As Object, e As EventArgs) Handles BtnKelas.Click
        FormKelas.Show()
    End Sub

    Private Sub BtnThnAjar_Click(sender As Object, e As EventArgs) Handles BtnThnAjar.Click
        FormTahunAjaran.Show()
    End Sub

    Private Sub BtnJenBayar_Click(sender As Object, e As EventArgs) Handles BtnJenBayar.Click
        FormJenisBayar.Show()
    End Sub

    Private Sub BtnBayarSPP_Click(sender As Object, e As EventArgs) Handles BtnBayarSPP.Click

    End Sub

    Private Sub BtnBayarDPP_Click(sender As Object, e As EventArgs) Handles BtnBayarDPP.Click

    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAdmin.Show()
    End Sub
End Class