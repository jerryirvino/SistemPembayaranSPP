<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTahunAjaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTahunAjaran))
        Me.DtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.DtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.CbxSemester = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtThnAjaran = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvThnAjaran = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxThnAjaran = New System.Windows.Forms.GroupBox()
        Me.TxtIdThnAjaran = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.PbxSDBW = New System.Windows.Forms.PictureBox()
        Me.ThnAjaranId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThnAjaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglMulai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvThnAjaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxThnAjaran.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpAkhir
        '
        Me.DtpAkhir.Location = New System.Drawing.Point(109, 136)
        Me.DtpAkhir.Name = "DtpAkhir"
        Me.DtpAkhir.Size = New System.Drawing.Size(200, 20)
        Me.DtpAkhir.TabIndex = 15
        '
        'DtpMulai
        '
        Me.DtpMulai.Location = New System.Drawing.Point(109, 109)
        Me.DtpMulai.Name = "DtpMulai"
        Me.DtpMulai.Size = New System.Drawing.Size(200, 20)
        Me.DtpMulai.TabIndex = 14
        '
        'CbxSemester
        '
        Me.CbxSemester.FormattingEnabled = True
        Me.CbxSemester.Items.AddRange(New Object() {"GANJIL", "GENAP"})
        Me.CbxSemester.Location = New System.Drawing.Point(109, 82)
        Me.CbxSemester.Name = "CbxSemester"
        Me.CbxSemester.Size = New System.Drawing.Size(150, 21)
        Me.CbxSemester.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Akhir"
        '
        'TxtThnAjaran
        '
        Me.TxtThnAjaran.Location = New System.Drawing.Point(109, 50)
        Me.TxtThnAjaran.Name = "TxtThnAjaran"
        Me.TxtThnAjaran.Size = New System.Drawing.Size(150, 20)
        Me.TxtThnAjaran.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(109, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(263, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Telp. 0274 562537, Email: infosd@budyawacana.com"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(109, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Jl. Kranggan no 11, Yogyakarta 55233"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mulai"
        '
        'DgvThnAjaran
        '
        Me.DgvThnAjaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvThnAjaran.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ThnAjaranId, Me.ThnAjaran, Me.Semester, Me.TglMulai, Me.TglAkhir})
        Me.DgvThnAjaran.Location = New System.Drawing.Point(12, 328)
        Me.DgvThnAjaran.Name = "DgvThnAjaran"
        Me.DgvThnAjaran.Size = New System.Drawing.Size(388, 180)
        Me.DgvThnAjaran.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tahun Ajaran"
        '
        'GbxThnAjaran
        '
        Me.GbxThnAjaran.Controls.Add(Me.TxtIdThnAjaran)
        Me.GbxThnAjaran.Controls.Add(Me.Label5)
        Me.GbxThnAjaran.Controls.Add(Me.BtnSave)
        Me.GbxThnAjaran.Controls.Add(Me.BtnDel)
        Me.GbxThnAjaran.Controls.Add(Me.BtnEdit)
        Me.GbxThnAjaran.Controls.Add(Me.BtnNew)
        Me.GbxThnAjaran.Controls.Add(Me.BtnClose)
        Me.GbxThnAjaran.Controls.Add(Me.DtpAkhir)
        Me.GbxThnAjaran.Controls.Add(Me.DtpMulai)
        Me.GbxThnAjaran.Controls.Add(Me.CbxSemester)
        Me.GbxThnAjaran.Controls.Add(Me.Label4)
        Me.GbxThnAjaran.Controls.Add(Me.TxtThnAjaran)
        Me.GbxThnAjaran.Controls.Add(Me.Label3)
        Me.GbxThnAjaran.Controls.Add(Me.Label2)
        Me.GbxThnAjaran.Controls.Add(Me.Label1)
        Me.GbxThnAjaran.Location = New System.Drawing.Point(12, 104)
        Me.GbxThnAjaran.Name = "GbxThnAjaran"
        Me.GbxThnAjaran.Size = New System.Drawing.Size(389, 218)
        Me.GbxThnAjaran.TabIndex = 44
        Me.GbxThnAjaran.TabStop = False
        Me.GbxThnAjaran.Text = "Data Tahun Ajaran"
        '
        'TxtIdThnAjaran
        '
        Me.TxtIdThnAjaran.Enabled = False
        Me.TxtIdThnAjaran.Location = New System.Drawing.Point(109, 24)
        Me.TxtIdThnAjaran.Name = "TxtIdThnAjaran"
        Me.TxtIdThnAjaran.Size = New System.Drawing.Size(56, 20)
        Me.TxtIdThnAjaran.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Id Tahun Ajaran"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Location = New System.Drawing.Point(156, 164)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(50, 50)
        Me.BtnSave.TabIndex = 76
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.BackgroundImage = CType(resources.GetObject("BtnDel.BackgroundImage"), System.Drawing.Image)
        Me.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDel.Location = New System.Drawing.Point(268, 164)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(50, 50)
        Me.BtnDel.TabIndex = 73
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdit.Location = New System.Drawing.Point(212, 164)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(50, 50)
        Me.BtnEdit.TabIndex = 74
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.BackgroundImage = CType(resources.GetObject("BtnNew.BackgroundImage"), System.Drawing.Image)
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.Location = New System.Drawing.Point(100, 164)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(50, 50)
        Me.BtnNew.TabIndex = 75
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Location = New System.Drawing.Point(333, 164)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 50)
        Me.BtnClose.TabIndex = 66
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = Global.SistemPembayaranSPP.My.Resources.Resources.LogoSDBW
        Me.PbxLogo.Location = New System.Drawing.Point(12, 13)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(85, 85)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 46
        Me.PbxLogo.TabStop = False
        '
        'PbxSDBW
        '
        Me.PbxSDBW.Image = Global.SistemPembayaranSPP.My.Resources.Resources.SDBW
        Me.PbxSDBW.Location = New System.Drawing.Point(103, 13)
        Me.PbxSDBW.Name = "PbxSDBW"
        Me.PbxSDBW.Size = New System.Drawing.Size(302, 28)
        Me.PbxSDBW.TabIndex = 47
        Me.PbxSDBW.TabStop = False
        '
        'ThnAjaranId
        '
        Me.ThnAjaranId.DataPropertyName = "ThnAjaranId"
        Me.ThnAjaranId.HeaderText = "ID"
        Me.ThnAjaranId.Name = "ThnAjaranId"
        Me.ThnAjaranId.Width = 20
        '
        'ThnAjaran
        '
        Me.ThnAjaran.DataPropertyName = "ThnAjaran"
        Me.ThnAjaran.HeaderText = "Tahun Ajaran"
        Me.ThnAjaran.Name = "ThnAjaran"
        Me.ThnAjaran.Width = 60
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        '
        'TglMulai
        '
        Me.TglMulai.DataPropertyName = "TglMulai"
        Me.TglMulai.HeaderText = "Tanggal Mulai"
        Me.TglMulai.Name = "TglMulai"
        '
        'TglAkhir
        '
        Me.TglAkhir.DataPropertyName = "TglAkhir"
        Me.TglAkhir.HeaderText = "Tanggal Akhir"
        Me.TglAkhir.Name = "TglAkhir"
        '
        'FormTahunAjaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 520)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DgvThnAjaran)
        Me.Controls.Add(Me.PbxSDBW)
        Me.Controls.Add(Me.GbxThnAjaran)
        Me.Name = "FormTahunAjaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTahunAjaran"
        CType(Me.DgvThnAjaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxThnAjaran.ResumeLayout(False)
        Me.GbxThnAjaran.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents DtpAkhir As DateTimePicker
    Friend WithEvents DtpMulai As DateTimePicker
    Friend WithEvents CbxSemester As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtThnAjaran As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvThnAjaran As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PbxSDBW As PictureBox
    Friend WithEvents GbxThnAjaran As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TxtIdThnAjaran As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ThnAjaranId As DataGridViewTextBoxColumn
    Friend WithEvents ThnAjaran As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents TglMulai As DataGridViewTextBoxColumn
    Friend WithEvents TglAkhir As DataGridViewTextBoxColumn
End Class
