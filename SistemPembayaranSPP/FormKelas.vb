Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class FormKelas
    Public kelas As New Tabel("Kelas")
    Private baru As Boolean
    Private kdLama As String

    Private Sub FormKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvDataKelas.DataSource = kelas.getBs()
        bind()
        modeSave()
        TxtJumlahKelas.Enabled = False
    End Sub

    Private Sub bind()
        TxtIdKelas.DataBindings.Add("Text", Me.kelas.getBs(), "KelasId")
        TxtTingkat.DataBindings.Add("Text", Me.kelas.getBs(), "NamaKelas")
        TxtKelas.DataBindings.Add("Text", Me.kelas.getBs(), "Tingkat")
        TxtKeterangan.DataBindings.Add("Text", Me.kelas.getBs(), "KetKelas")
    End Sub

    Private Sub unbind()
        TxtIdKelas.DataBindings.Clear()
        TxtTingkat.DataBindings.Clear()
        TxtKelas.DataBindings.Clear()
        TxtKeterangan.DataBindings.Clear()
    End Sub

    Sub modeSave()
        TxtIdKelas.Enabled = False
        TxtTingkat.Enabled = False
        TxtKelas.Enabled = False
        TxtKeterangan.Enabled = False
    End Sub

    Sub modeEdit()
        TxtIdKelas.Enabled = False
        TxtTingkat.Enabled = True
        TxtKelas.Enabled = True
        TxtKeterangan.Enabled = True

        Me.kdLama = TxtIdKelas.Text
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        unbind()
        modeEdit()
        TxtKelas.Text = ""
        TxtTingkat.Text = ""
        TxtKeterangan.Text = ""
        Me.baru = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim tingkat, kelas, keterangan
        kelas = TxtKelas.Text
        tingkat = TxtTingkat.Text
        keterangan = TxtKeterangan.Text

        Dim strSql As String
        If baru Then
            strSql = "INSERT INTO Kelas VALUES('{0}','{1}','{2}')"
            strSql = String.Format(strSql, kelas, tingkat, keterangan)
        Else
            strSql = "UPDATE Kelas SET NamaKelas='{0}', Tingkat='{1}', KetKelas='{2}'"
            strSql = String.Format(strSql, kelas, tingkat, keterangan, Me.kdLama)
        End If
        Me.kelas.executeSQL(strSql)
        modeSave()
        bind()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        modeEdit()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If MessageBox.Show("Apakah anda yakin akan menghapus data siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim strSql = "DELETE FROM Kelas WHERE KelasId='" & TxtIdKelas.Text & "'"
            kelas.executeSQL(strSql)
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