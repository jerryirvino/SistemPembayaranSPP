Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class FormTahunAjaran
    Public TahunAjaran As New Tabel("TahunAjaran")
    Private baru As Boolean
    Private kdLama As String

    Private Sub FormTahunAjaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvThnAjaran.DataSource = TahunAjaran.getBs()
        bind()
        modeSave()
        TxtIdThnAjaran.Enabled = False
    End Sub

    Private Sub bind()
        TxtIdThnAjaran.DataBindings.Add("Text", Me.TahunAjaran.getBs(), "ThnAjaranId")
        TxtThnAjaran.DataBindings.Add("Text", Me.TahunAjaran.getBs(), "ThnAjaran")
        CbxSemester.DataBindings.Add("Text", Me.TahunAjaran.getBs(), "Semester")
        DtpMulai.DataBindings.Add("Text", Me.TahunAjaran.getBs(), "TglMulai")
        DtpAkhir.DataBindings.Add("Text", Me.TahunAjaran.getBs(), "TglAkhir")
    End Sub

    Private Sub unbind()
        TxtIdThnAjaran.DataBindings.Clear()
        TxtThnAjaran.DataBindings.Clear()
        CbxSemester.DataBindings.Clear()
        DtpMulai.DataBindings.Clear()
        DtpAkhir.DataBindings.Clear()
    End Sub

    Sub modeSave()
        TxtIdThnAjaran.Enabled = False
        TxtThnAjaran.Enabled = False
        CbxSemester.Enabled = False
        DtpMulai.Enabled = False
        DtpAkhir.Enabled = False
    End Sub

    Sub modeEdit()
        TxtIdThnAjaran.Enabled = False
        TxtThnAjaran.Enabled = True
        CbxSemester.Enabled = True
        DtpMulai.Enabled = True
        DtpAkhir.Enabled = True

        Me.kdLama = TxtIdThnAjaran.Text
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        unbind()
        modeEdit()
        TxtThnAjaran.Text = ""
        CbxSemester.Text = ""
        DtpMulai.Value = Now
        DtpAkhir.Value = Now

        baru = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim tahunAjaran, semester, tglMulai, tglAkhir
        tahunAjaran = TxtThnAjaran.Text
        semester = CbxSemester.Text
        tglMulai = DtpMulai.Value
        tglAkhir = DtpAkhir.Value

        Dim strSql As String
        If baru Then
            strSql = "INSERT INTO TahunAjaran VALUES('{0}','{1}','{2}', '{3}')"
            strSql = String.Format(strSql, tahunAjaran, semester, tglMulai, tglAkhir)
        Else
            strSql = "UPDATE TahunAjaran SET ThnAjaran='{0}', Semester='{1}', TglMulai='{2}', TglAkhir='{3}'"
            strSql = String.Format(strSql, tahunAjaran, semester, tglMulai, tglAkhir, Me.kdLama)
        End If
        Me.TahunAjaran.executeSQL(strSql)
        modeSave()
        bind()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        modeEdit()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If MessageBox.Show("Apakah anda yakin akan menghapus data siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim strSql = "DELETE FROM TahunAjaran WHERE ThnAjaranId='" & TxtThnAjaran.Text & "'"
            TahunAjaran.executeSQL(strSql)
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