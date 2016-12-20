Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class FormLogin
    Public admins As New Tabel("Admins")
    Private baru As Boolean
    Private kdLama As String
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=PembayaranSPP ;Integrated Security= True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT Username, Password from " &
        "Admins WHERE Username = '" & TxtUsername.Text & "' AND " &
        "Password ='" & TxtPass.Text & "'"

        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            FormUtama.Show()
        Else
            MessageBox.Show("Mohon maaf username dan password anda salah!")
        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
End Class
