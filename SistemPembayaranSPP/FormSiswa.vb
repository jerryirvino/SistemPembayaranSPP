Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class FormSiswa
    Public siswa As New Tabel("Siswa")
    Private baru As Boolean
    Private kdLama As String
    Private gender As String

    Private Sub FormSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvProfilSiswa.DataSource = siswa.getBs()
        bind()
        modeSave()
        CbxTampilThnAjaran.Text = "2016-2017"
    End Sub
    Private Sub bind()
        TxtNIS.DataBindings.Add("Text", Me.siswa.getBs(), "NIS")
        TxtNama.DataBindings.Add("Text", Me.siswa.getBs(), "Nama")
        TxtTmptLahir.DataBindings.Add("Text", Me.siswa.getBs(), "TmpLahir")
        DtpTglLahir.DataBindings.Add("Text", Me.siswa.getBs(), "TglLahir")
        GbxAgama.DataBindings.Add("Text", Me.siswa.getBs(), "Agama")
        RtbAlamat.DataBindings.Add("Text", Me.siswa.getBs(), "Alamat")
        TxtNamaWali.DataBindings.Add("Text", Me.siswa.getBs(), "NamaWali")
        TxtKontakWali.DataBindings.Add("Text", Me.siswa.getBs(), "Telp")
    End Sub

    Private Sub unbind()
        TxtNIS.DataBindings.Clear()
        TxtNama.DataBindings.Clear()
        TxtTmptLahir.DataBindings.Clear()
        DtpTglLahir.DataBindings.Clear()
        GbxAgama.DataBindings.Clear()
        RtbAlamat.DataBindings.Clear()
        TxtNamaWali.DataBindings.Clear()
        TxtKontakWali.DataBindings.Clear()
    End Sub

    Sub modeSave()
        TxtNIS.Enabled = False
        TxtNama.Enabled = False
        GbxGender.Enabled = False
        TxtTmptLahir.Enabled = False
        DtpTglLahir.Enabled = False
        GbxAgama.Enabled = False
        RtbAlamat.Enabled = False
        TxtNamaWali.Enabled = False
        TxtKontakWali.Enabled = False
        CbxTampilKelas.Enabled = False
        CbxTampilThnAjaran.Enabled = False
    End Sub

    Sub modeEdit()
        TxtNIS.Enabled = True
        TxtNama.Enabled = True
        GbxGender.Enabled = True
        TxtTmptLahir.Enabled = True
        DtpTglLahir.Enabled = True
        GbxAgama.Enabled = True
        RtbAlamat.Enabled = True
        TxtNamaWali.Enabled = True
        TxtKontakWali.Enabled = True

        Me.kdLama = TxtNIS.Text
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        unbind()
        TxtNIS.Text = ""
        TxtNama.Text = ""
        RBL.Checked = True
        TxtTmptLahir.Text = ""
        DtpTglLahir.Text = ""
        RBKr.Checked = True '<-- salah satu dari yg tersedia di Combo Box
        RtbAlamat.Text = ""
        TxtNamaWali.Text = ""
        TxtKontakWali.Text = ""
        modeEdit()
        Me.baru = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim nis, nama, kelamin, tmpLahir, tglLahir, agama, alamat, namaWali, telp
        nis = TxtNIS.Text
        nama = TxtNama.Text
        If RBL.Checked Then
            kelamin = "L"
        Else
            kelamin = "P"
        End If
        tmpLahir = TxtTmptLahir.Text
        tglLahir = DtpTglLahir.Value
        Select Case agama
            Case 1
                If RBKr.Checked Then
                    agama = "Kristen"
                End If
            Case 2
                If RBKa.Checked Then
                    agama = "Katolik"
                End If
            Case 3
                If RBI.Checked Then
                    agama = "Islam"
                End If
            Case 4
                If RBH.Checked Then
                    agama = "Hindu"
                End If
            Case 4
                If RBB.Checked Then
                    agama = "Budha"
                End If
        End Select
        alamat = RtbAlamat.Text
        namaWali = TxtNamaWali.Text
        telp = TxtKontakWali.Text

        Dim strSql As String
        If baru Then
            strSql = "INSERT INTO Siswa VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')"
            strSql = String.Format(strSql, nis, nama, kelamin, tmpLahir, tglLahir, agama, alamat, namaWali, telp)
        Else
            strSql = "UPDATE Siswa SET NIS='{0}', Nama='{1}', Kelamin='{2}', TmpLahir='{3}', TglLahir='{4}', Agama='{5}', Alamat='{6}', NamaWali='{7}', Telp='{8}' WHERE NIS='{9}'"
            strSql = String.Format(strSql, nis, nama, kelamin, tmpLahir, tglLahir, agama, alamat, namaWali, telp, Me.kdLama)
        End If
        Me.siswa.executeSQL(strSql)
        modeSave()
        bind()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If MessageBox.Show("Apakah anda yakin akan menghapus data siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim strSql = "DELETE FROM Siswa WHERE NIS='" & TxtNIS.Text & "'"
            siswa.executeSQL(strSql)
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