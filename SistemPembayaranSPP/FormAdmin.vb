Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class FormAdmin
    Public admins As New Tabel("Admins")
    Private baru As Boolean
    Private kdLama As String

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvAdmin.DataSource = admins.getBs()
        bind()
        modeSave()
        TxtIdAdmin.Enabled = False

        DgvAdmin.Columns(3).Visible = False
    End Sub
    Private Sub bind()
        TxtIdAdmin.DataBindings.Add("Text", Me.admins.getBs(), "AdminId")
        TxtNamaAdmin.DataBindings.Add("Text", Me.admins.getBs(), "NamaAdmin")
        TxtUsername.DataBindings.Add("Text", Me.admins.getBs(), "Username")
        TxtPassword.DataBindings.Add("Text", Me.admins.getBs(), "Password")
    End Sub

    Private Sub unbind()
        TxtIdAdmin.DataBindings.Clear()
        TxtNamaAdmin.DataBindings.Clear()
        TxtUsername.DataBindings.Clear()
        TxtPassword.DataBindings.Clear()
    End Sub

    Sub modeSave()
        TxtIdAdmin.Enabled = False
        TxtNamaAdmin.Enabled = False
        TxtUsername.Enabled = False
        TxtPassword.Enabled = False

        TxtPassword.PasswordChar = "*"
    End Sub

    Sub modeEdit()
        TxtIdAdmin.Enabled = False
        TxtNamaAdmin.Enabled = True
        TxtUsername.Enabled = True
        TxtPassword.Enabled = True

        Me.kdLama = TxtIdAdmin.Text
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        unbind()
        modeEdit()
        TxtNamaAdmin.Text = ""
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        Me.baru = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim nama, username, password
        nama = TxtNamaAdmin.Text
        username = TxtUsername.Text
        password = TxtPassword.Text

        Dim strSql As String
        If baru Then
            strSql = "INSERT INTO Admins VALUES('{0}','{1}','{2}')"
            strSql = String.Format(strSql, nama, username, password)
        Else
            strSql = "UPDATE Admins SET NamaAdmin='{0}', Username='{1}', Password='{2}'"
            strSql = String.Format(strSql, nama, username, password, Me.kdLama)
        End If
        Me.admins.executeSQL(strSql)
        modeSave()
        bind()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        modeEdit()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If MessageBox.Show("Apakah anda yakin akan menghapus data siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim strSql = "DELETE FROM Admins WHERE KelasId='" & TxtIdAdmin.Text & "'"
            admins.executeSQL(strSql)
            MessageBox.Show("Data Siswa telah berhasil dihapus", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Penghapusan Siswa dibatalkan", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class