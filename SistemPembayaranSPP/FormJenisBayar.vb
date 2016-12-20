Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class FormJenisBayar
    Public JenBayar As New Tabel("JenisBayar")
    Private baru As Boolean
    Private kdLama As String

    Private Sub FormJenisBayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvJenisBayar.DataSource = JenBayar.getBs()
        bind()
        modeSave()
        TxtIdJenBayar.Enabled = False
    End Sub

    Private Sub bind()
        TxtIdJenBayar.DataBindings.Add("Text", Me.JenBayar.getBs(), "JenBayarId")
        TxtNamaBayar.DataBindings.Add("Text", Me.JenBayar.getBs(), "NamaBayar")
        CbxJenisBayar.DataBindings.Add("Text", Me.JenBayar.getBs(), "JenisBayar")
        RtbKet.DataBindings.Add("Text", Me.JenBayar.getBs(), "KetBayar")
    End Sub

    Private Sub unbind()
        TxtIdJenBayar.DataBindings.Clear()
        TxtNamaBayar.DataBindings.Clear()
        CbxJenisBayar.DataBindings.Clear()
        RtbKet.DataBindings.Clear()
    End Sub

    Sub modeSave()
        TxtIdJenBayar.Enabled = False
        TxtNamaBayar.Enabled = False
        CbxJenisBayar.Enabled = False
        RtbKet.Enabled = False
    End Sub

    Sub modeEdit()
        TxtIdJenBayar.Enabled = False
        TxtNamaBayar.Enabled = True
        CbxJenisBayar.Enabled = True
        RtbKet.Enabled = True

        Me.kdLama = TxtIdJenBayar.Text
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        unbind()
        modeEdit()
        TxtNamaBayar.Text = ""
        CbxJenisBayar.Text = ""
        RtbKet.Text = ""
        Me.baru = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim namaBayar, jenisBayar, keterangan
        namaBayar = TxtNamaBayar.Text
        jenisBayar = CbxJenisBayar.Text
        keterangan = RtbKet.Text

        Dim strSql As String
        If baru Then
            strSql = "INSERT INTO JenisBayar VALUES('{0}','{1}','{2}')"
            strSql = String.Format(strSql, namaBayar, jenisBayar, keterangan)
        Else
            strSql = "UPDATE Kelas SET NamaBayar='{0}', JenisBayar='{1}', KetBayar='{2}'"
            strSql = String.Format(strSql, namaBayar, jenisBayar, keterangan, Me.kdLama)
        End If
        Me.JenBayar.executeSQL(strSql)
        modeSave()
        bind()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        modeEdit()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If MessageBox.Show("Apakah anda yakin akan menghapus data siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim strSql = "DELETE FROM JenisBayar WHERE JenBayarId='" & TxtIdJenBayar.Text & "'"
            JenBayar.executeSQL(strSql)
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