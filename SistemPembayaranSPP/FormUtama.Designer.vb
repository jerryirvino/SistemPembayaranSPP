<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.TabMenu = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnThnAjar = New System.Windows.Forms.Button()
        Me.BtnKelas = New System.Windows.Forms.Button()
        Me.BtnSiswa = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBayarDPP = New System.Windows.Forms.Button()
        Me.BtnBayarSPP = New System.Windows.Forms.Button()
        Me.BtnJenBayar = New System.Windows.Forms.Button()
        Me.TabLaporan = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Laporan = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PbxMenu = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabMenu.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PbxMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMenu
        '
        Me.TabMenu.Controls.Add(Me.TabPage1)
        Me.TabMenu.Controls.Add(Me.TabPage2)
        Me.TabMenu.Controls.Add(Me.TabLaporan)
        Me.TabMenu.Controls.Add(Me.TabPage3)
        Me.TabMenu.Location = New System.Drawing.Point(1, 1)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.SelectedIndex = 0
        Me.TabMenu.Size = New System.Drawing.Size(480, 134)
        Me.TabMenu.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BtnThnAjar)
        Me.TabPage1.Controls.Add(Me.BtnKelas)
        Me.TabPage1.Controls.Add(Me.BtnSiswa)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(472, 108)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Siswa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tahun Ajaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Siswa"
        '
        'BtnThnAjar
        '
        Me.BtnThnAjar.BackColor = System.Drawing.Color.White
        Me.BtnThnAjar.BackgroundImage = CType(resources.GetObject("BtnThnAjar.BackgroundImage"), System.Drawing.Image)
        Me.BtnThnAjar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnThnAjar.Location = New System.Drawing.Point(178, 5)
        Me.BtnThnAjar.Name = "BtnThnAjar"
        Me.BtnThnAjar.Size = New System.Drawing.Size(80, 80)
        Me.BtnThnAjar.TabIndex = 3
        Me.BtnThnAjar.UseVisualStyleBackColor = False
        '
        'BtnKelas
        '
        Me.BtnKelas.BackColor = System.Drawing.Color.White
        Me.BtnKelas.BackgroundImage = CType(resources.GetObject("BtnKelas.BackgroundImage"), System.Drawing.Image)
        Me.BtnKelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKelas.Location = New System.Drawing.Point(92, 5)
        Me.BtnKelas.Name = "BtnKelas"
        Me.BtnKelas.Size = New System.Drawing.Size(80, 80)
        Me.BtnKelas.TabIndex = 3
        Me.BtnKelas.UseVisualStyleBackColor = False
        '
        'BtnSiswa
        '
        Me.BtnSiswa.BackColor = System.Drawing.Color.White
        Me.BtnSiswa.BackgroundImage = CType(resources.GetObject("BtnSiswa.BackgroundImage"), System.Drawing.Image)
        Me.BtnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSiswa.Location = New System.Drawing.Point(6, 6)
        Me.BtnSiswa.Name = "BtnSiswa"
        Me.BtnSiswa.Size = New System.Drawing.Size(80, 80)
        Me.BtnSiswa.TabIndex = 3
        Me.BtnSiswa.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.BtnBayarDPP)
        Me.TabPage2.Controls.Add(Me.BtnBayarSPP)
        Me.TabPage2.Controls.Add(Me.BtnJenBayar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(472, 108)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pembayaran"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(185, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Pembayaran DPP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Pembayaran SPP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jenis Pembayaran"
        '
        'BtnBayarDPP
        '
        Me.BtnBayarDPP.BackColor = System.Drawing.Color.White
        Me.BtnBayarDPP.BackgroundImage = CType(resources.GetObject("BtnBayarDPP.BackgroundImage"), System.Drawing.Image)
        Me.BtnBayarDPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBayarDPP.Location = New System.Drawing.Point(188, 6)
        Me.BtnBayarDPP.Name = "BtnBayarDPP"
        Me.BtnBayarDPP.Size = New System.Drawing.Size(80, 80)
        Me.BtnBayarDPP.TabIndex = 0
        Me.BtnBayarDPP.UseVisualStyleBackColor = False
        '
        'BtnBayarSPP
        '
        Me.BtnBayarSPP.BackColor = System.Drawing.Color.White
        Me.BtnBayarSPP.BackgroundImage = CType(resources.GetObject("BtnBayarSPP.BackgroundImage"), System.Drawing.Image)
        Me.BtnBayarSPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBayarSPP.Location = New System.Drawing.Point(99, 6)
        Me.BtnBayarSPP.Name = "BtnBayarSPP"
        Me.BtnBayarSPP.Size = New System.Drawing.Size(80, 80)
        Me.BtnBayarSPP.TabIndex = 0
        Me.BtnBayarSPP.UseVisualStyleBackColor = False
        '
        'BtnJenBayar
        '
        Me.BtnJenBayar.BackColor = System.Drawing.Color.White
        Me.BtnJenBayar.BackgroundImage = CType(resources.GetObject("BtnJenBayar.BackgroundImage"), System.Drawing.Image)
        Me.BtnJenBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnJenBayar.Location = New System.Drawing.Point(10, 6)
        Me.BtnJenBayar.Name = "BtnJenBayar"
        Me.BtnJenBayar.Size = New System.Drawing.Size(80, 80)
        Me.BtnJenBayar.TabIndex = 0
        Me.BtnJenBayar.UseVisualStyleBackColor = False
        '
        'TabLaporan
        '
        Me.TabLaporan.Controls.Add(Me.Label7)
        Me.TabLaporan.Controls.Add(Me.Laporan)
        Me.TabLaporan.Location = New System.Drawing.Point(4, 22)
        Me.TabLaporan.Name = "TabLaporan"
        Me.TabLaporan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLaporan.Size = New System.Drawing.Size(472, 108)
        Me.TabLaporan.TabIndex = 2
        Me.TabLaporan.Text = "Laporan"
        Me.TabLaporan.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Laporan"
        '
        'Laporan
        '
        Me.Laporan.BackColor = System.Drawing.Color.White
        Me.Laporan.BackgroundImage = CType(resources.GetObject("Laporan.BackgroundImage"), System.Drawing.Image)
        Me.Laporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Laporan.Location = New System.Drawing.Point(7, 6)
        Me.Laporan.Name = "Laporan"
        Me.Laporan.Size = New System.Drawing.Size(80, 80)
        Me.Laporan.TabIndex = 1
        Me.Laporan.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(472, 108)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Utilitas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PbxMenu
        '
        Me.PbxMenu.Image = CType(resources.GetObject("PbxMenu.Image"), System.Drawing.Image)
        Me.PbxMenu.Location = New System.Drawing.Point(1, 135)
        Me.PbxMenu.Name = "PbxMenu"
        Me.PbxMenu.Size = New System.Drawing.Size(480, 301)
        Me.PbxMenu.TabIndex = 1
        Me.PbxMenu.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Admin"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 435)
        Me.Controls.Add(Me.PbxMenu)
        Me.Controls.Add(Me.TabMenu)
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtama"
        Me.TabMenu.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabLaporan.ResumeLayout(False)
        Me.TabLaporan.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PbxMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabMenu As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabLaporan As TabPage
    Friend WithEvents BtnSiswa As Button
    Friend WithEvents BtnKelas As Button
    Friend WithEvents BtnThnAjar As Button
    Friend WithEvents BtnJenBayar As Button
    Friend WithEvents BtnBayarSPP As Button
    Friend WithEvents BtnBayarDPP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Laporan As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PbxMenu As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
