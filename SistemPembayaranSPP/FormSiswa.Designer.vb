<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSiswa))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PbxSDBW = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.CbxTampilThnAjaran = New System.Windows.Forms.ComboBox()
        Me.DgvProfilSiswa = New System.Windows.Forms.DataGridView()
        Me.NIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmpLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaWali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKontakWali = New System.Windows.Forms.TextBox()
        Me.TxtNIS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtTmptLahir = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GbxGender = New System.Windows.Forms.GroupBox()
        Me.RBP = New System.Windows.Forms.RadioButton()
        Me.RBL = New System.Windows.Forms.RadioButton()
        Me.DtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.TxtNamaWali = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbxTampilKelas = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GbxAgama = New System.Windows.Forms.GroupBox()
        Me.RBKa = New System.Windows.Forms.RadioButton()
        Me.RBKr = New System.Windows.Forms.RadioButton()
        Me.RBI = New System.Windows.Forms.RadioButton()
        Me.RBH = New System.Windows.Forms.RadioButton()
        Me.RBB = New System.Windows.Forms.RadioButton()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProfilSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GbxGender.SuspendLayout()
        Me.GbxAgama.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(109, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(263, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Telp. 0274 562537, Email: infosd@budyawacana.com"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(109, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Jl. Kranggan no 11, Yogyakarta 55233"
        '
        'PbxSDBW
        '
        Me.PbxSDBW.Image = Global.SistemPembayaranSPP.My.Resources.Resources.SDBW
        Me.PbxSDBW.Location = New System.Drawing.Point(103, 12)
        Me.PbxSDBW.Name = "PbxSDBW"
        Me.PbxSDBW.Size = New System.Drawing.Size(302, 28)
        Me.PbxSDBW.TabIndex = 41
        Me.PbxSDBW.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = Global.SistemPembayaranSPP.My.Resources.Resources.LogoSDBW
        Me.PbxLogo.Location = New System.Drawing.Point(12, 12)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(85, 85)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 40
        Me.PbxLogo.TabStop = False
        '
        'CbxTampilThnAjaran
        '
        Me.CbxTampilThnAjaran.FormattingEnabled = True
        Me.CbxTampilThnAjaran.Location = New System.Drawing.Point(579, 434)
        Me.CbxTampilThnAjaran.Name = "CbxTampilThnAjaran"
        Me.CbxTampilThnAjaran.Size = New System.Drawing.Size(121, 21)
        Me.CbxTampilThnAjaran.TabIndex = 49
        '
        'DgvProfilSiswa
        '
        Me.DgvProfilSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProfilSiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIS, Me.Nama, Me.Kelamin, Me.TmpLahir, Me.TglLahir, Me.Agama, Me.Alamat, Me.NamaWali, Me.Telp})
        Me.DgvProfilSiswa.Location = New System.Drawing.Point(478, 103)
        Me.DgvProfilSiswa.Name = "DgvProfilSiswa"
        Me.DgvProfilSiswa.Size = New System.Drawing.Size(481, 294)
        Me.DgvProfilSiswa.TabIndex = 45
        '
        'NIS
        '
        Me.NIS.DataPropertyName = "NIS"
        Me.NIS.HeaderText = "NIS"
        Me.NIS.Name = "NIS"
        Me.NIS.Width = 50
        '
        'Nama
        '
        Me.Nama.DataPropertyName = "Nama"
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        '
        'Kelamin
        '
        Me.Kelamin.DataPropertyName = "Kelamin"
        Me.Kelamin.HeaderText = "Jenis Kelamin"
        Me.Kelamin.Name = "Kelamin"
        Me.Kelamin.Width = 50
        '
        'TmpLahir
        '
        Me.TmpLahir.DataPropertyName = "TmpLahir"
        Me.TmpLahir.HeaderText = "Tempat Lahir"
        Me.TmpLahir.Name = "TmpLahir"
        Me.TmpLahir.Width = 70
        '
        'TglLahir
        '
        Me.TglLahir.DataPropertyName = "TglLahir"
        Me.TglLahir.HeaderText = "Tanggal Lahir"
        Me.TglLahir.Name = "TglLahir"
        Me.TglLahir.Width = 60
        '
        'Agama
        '
        Me.Agama.DataPropertyName = "Agama"
        Me.Agama.HeaderText = "Agama"
        Me.Agama.Name = "Agama"
        Me.Agama.Width = 70
        '
        'Alamat
        '
        Me.Alamat.DataPropertyName = "Alamat"
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Width = 150
        '
        'NamaWali
        '
        Me.NamaWali.DataPropertyName = "NamaWali"
        Me.NamaWali.HeaderText = "Nama Wali"
        Me.NamaWali.Name = "NamaWali"
        '
        'Telp
        '
        Me.Telp.DataPropertyName = "Telp"
        Me.Telp.HeaderText = "Telp"
        Me.Telp.Name = "Telp"
        Me.Telp.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GbxAgama)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.BtnDel)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.BtnNew)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtKontakWali)
        Me.GroupBox2.Controls.Add(Me.TxtNIS)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtNama)
        Me.GroupBox2.Controls.Add(Me.TxtTmptLahir)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GbxGender)
        Me.GroupBox2.Controls.Add(Me.DtpTglLahir)
        Me.GroupBox2.Controls.Add(Me.TxtNamaWali)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.RtbAlamat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 416)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Siswa"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Location = New System.Drawing.Point(67, 360)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(50, 50)
        Me.BtnSave.TabIndex = 72
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.BackgroundImage = CType(resources.GetObject("BtnDel.BackgroundImage"), System.Drawing.Image)
        Me.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDel.Location = New System.Drawing.Point(179, 360)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(50, 50)
        Me.BtnDel.TabIndex = 69
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdit.Location = New System.Drawing.Point(123, 360)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(50, 50)
        Me.BtnEdit.TabIndex = 70
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.BackgroundImage = CType(resources.GetObject("BtnNew.BackgroundImage"), System.Drawing.Image)
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.Location = New System.Drawing.Point(11, 360)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(50, 50)
        Me.BtnNew.TabIndex = 71
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'TxtKontakWali
        '
        Me.TxtKontakWali.Location = New System.Drawing.Point(138, 326)
        Me.TxtKontakWali.Name = "TxtKontakWali"
        Me.TxtKontakWali.Size = New System.Drawing.Size(134, 20)
        Me.TxtKontakWali.TabIndex = 24
        '
        'TxtNIS
        '
        Me.TxtNIS.Location = New System.Drawing.Point(138, 19)
        Me.TxtNIS.Name = "TxtNIS"
        Me.TxtNIS.Size = New System.Drawing.Size(100, 20)
        Me.TxtNIS.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Kontak Wali"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(138, 45)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(306, 20)
        Me.TxtNama.TabIndex = 2
        '
        'TxtTmptLahir
        '
        Me.TxtTmptLahir.Location = New System.Drawing.Point(138, 120)
        Me.TxtTmptLahir.Name = "TxtTmptLahir"
        Me.TxtTmptLahir.Size = New System.Drawing.Size(100, 20)
        Me.TxtTmptLahir.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Nama Wali"
        '
        'GbxGender
        '
        Me.GbxGender.Controls.Add(Me.RBP)
        Me.GbxGender.Controls.Add(Me.RBL)
        Me.GbxGender.Location = New System.Drawing.Point(138, 71)
        Me.GbxGender.Name = "GbxGender"
        Me.GbxGender.Size = New System.Drawing.Size(163, 43)
        Me.GbxGender.TabIndex = 4
        Me.GbxGender.TabStop = False
        '
        'RBP
        '
        Me.RBP.AutoSize = True
        Me.RBP.Location = New System.Drawing.Point(80, 19)
        Me.RBP.Name = "RBP"
        Me.RBP.Size = New System.Drawing.Size(79, 17)
        Me.RBP.TabIndex = 1
        Me.RBP.TabStop = True
        Me.RBP.Text = "Perempuan"
        Me.RBP.UseVisualStyleBackColor = True
        '
        'RBL
        '
        Me.RBL.AutoSize = True
        Me.RBL.Location = New System.Drawing.Point(6, 19)
        Me.RBL.Name = "RBL"
        Me.RBL.Size = New System.Drawing.Size(68, 17)
        Me.RBL.TabIndex = 0
        Me.RBL.TabStop = True
        Me.RBL.Text = "Laki-Laki"
        Me.RBL.UseVisualStyleBackColor = True
        '
        'DtpTglLahir
        '
        Me.DtpTglLahir.Location = New System.Drawing.Point(244, 120)
        Me.DtpTglLahir.Name = "DtpTglLahir"
        Me.DtpTglLahir.Size = New System.Drawing.Size(200, 20)
        Me.DtpTglLahir.TabIndex = 5
        '
        'TxtNamaWali
        '
        Me.TxtNamaWali.Location = New System.Drawing.Point(138, 300)
        Me.TxtNamaWali.Name = "TxtNamaWali"
        Me.TxtNamaWali.Size = New System.Drawing.Size(306, 20)
        Me.TxtNamaWali.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama"
        '
        'RtbAlamat
        '
        Me.RtbAlamat.Location = New System.Drawing.Point(138, 198)
        Me.RtbAlamat.Name = "RtbAlamat"
        Me.RtbAlamat.Size = New System.Drawing.Size(306, 96)
        Me.RtbAlamat.TabIndex = 17
        Me.RtbAlamat.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tempat Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Alamat"
        '
        'CbxTampilKelas
        '
        Me.CbxTampilKelas.FormattingEnabled = True
        Me.CbxTampilKelas.Location = New System.Drawing.Point(579, 407)
        Me.CbxTampilKelas.Name = "CbxTampilKelas"
        Me.CbxTampilKelas.Size = New System.Drawing.Size(121, 21)
        Me.CbxTampilKelas.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(490, 437)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Tahun Ajaran"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(490, 410)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Kelas"
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Location = New System.Drawing.Point(909, 445)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 50)
        Me.BtnClose.TabIndex = 65
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GbxAgama
        '
        Me.GbxAgama.Controls.Add(Me.RBB)
        Me.GbxAgama.Controls.Add(Me.RBH)
        Me.GbxAgama.Controls.Add(Me.RBI)
        Me.GbxAgama.Controls.Add(Me.RBKa)
        Me.GbxAgama.Controls.Add(Me.RBKr)
        Me.GbxAgama.Location = New System.Drawing.Point(138, 146)
        Me.GbxAgama.Name = "GbxAgama"
        Me.GbxAgama.Size = New System.Drawing.Size(306, 43)
        Me.GbxAgama.TabIndex = 73
        Me.GbxAgama.TabStop = False
        '
        'RBKa
        '
        Me.RBKa.AutoSize = True
        Me.RBKa.Location = New System.Drawing.Point(69, 19)
        Me.RBKa.Name = "RBKa"
        Me.RBKa.Size = New System.Drawing.Size(57, 17)
        Me.RBKa.TabIndex = 1
        Me.RBKa.TabStop = True
        Me.RBKa.Text = "Katolik"
        Me.RBKa.UseVisualStyleBackColor = True
        '
        'RBKr
        '
        Me.RBKr.AutoSize = True
        Me.RBKr.Location = New System.Drawing.Point(6, 19)
        Me.RBKr.Name = "RBKr"
        Me.RBKr.Size = New System.Drawing.Size(57, 17)
        Me.RBKr.TabIndex = 0
        Me.RBKr.TabStop = True
        Me.RBKr.Text = "Kristen"
        Me.RBKr.UseVisualStyleBackColor = True
        '
        'RBI
        '
        Me.RBI.AutoSize = True
        Me.RBI.Location = New System.Drawing.Point(132, 19)
        Me.RBI.Name = "RBI"
        Me.RBI.Size = New System.Drawing.Size(49, 17)
        Me.RBI.TabIndex = 2
        Me.RBI.TabStop = True
        Me.RBI.Text = "Islam"
        Me.RBI.UseVisualStyleBackColor = True
        '
        'RBH
        '
        Me.RBH.AutoSize = True
        Me.RBH.Location = New System.Drawing.Point(187, 19)
        Me.RBH.Name = "RBH"
        Me.RBH.Size = New System.Drawing.Size(53, 17)
        Me.RBH.TabIndex = 3
        Me.RBH.TabStop = True
        Me.RBH.Text = "Hindu"
        Me.RBH.UseVisualStyleBackColor = True
        '
        'RBB
        '
        Me.RBB.AutoSize = True
        Me.RBB.Location = New System.Drawing.Point(246, 19)
        Me.RBB.Name = "RBB"
        Me.RBB.Size = New System.Drawing.Size(56, 17)
        Me.RBB.TabIndex = 4
        Me.RBB.TabStop = True
        Me.RBB.Text = "Budha"
        Me.RBB.UseVisualStyleBackColor = True
        '
        'FormSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(971, 526)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.CbxTampilThnAjaran)
        Me.Controls.Add(Me.DgvProfilSiswa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CbxTampilKelas)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PbxSDBW)
        Me.Controls.Add(Me.PbxLogo)
        Me.Name = "FormSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSiswa"
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProfilSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbxGender.ResumeLayout(False)
        Me.GbxGender.PerformLayout()
        Me.GbxAgama.ResumeLayout(False)
        Me.GbxAgama.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PbxSDBW As PictureBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents CbxTampilThnAjaran As ComboBox
    Friend WithEvents DgvProfilSiswa As DataGridView
    Friend WithEvents NIS As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kelamin As DataGridViewTextBoxColumn
    Friend WithEvents TmpLahir As DataGridViewTextBoxColumn
    Friend WithEvents TglLahir As DataGridViewTextBoxColumn
    Friend WithEvents Agama As DataGridViewTextBoxColumn
    Friend WithEvents Alamat As DataGridViewTextBoxColumn
    Friend WithEvents NamaWali As DataGridViewTextBoxColumn
    Friend WithEvents Telp As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtKontakWali As TextBox
    Friend WithEvents TxtNIS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtTmptLahir As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GbxGender As GroupBox
    Friend WithEvents RBP As RadioButton
    Friend WithEvents RBL As RadioButton
    Friend WithEvents DtpTglLahir As DateTimePicker
    Friend WithEvents TxtNamaWali As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RtbAlamat As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbxTampilKelas As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents GbxAgama As GroupBox
    Friend WithEvents RBB As RadioButton
    Friend WithEvents RBH As RadioButton
    Friend WithEvents RBI As RadioButton
    Friend WithEvents RBKa As RadioButton
    Friend WithEvents RBKr As RadioButton
End Class
