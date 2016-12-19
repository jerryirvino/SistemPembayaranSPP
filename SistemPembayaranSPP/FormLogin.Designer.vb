<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnMasuk = New System.Windows.Forms.Button()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = Global.SistemPembayaranSPP.My.Resources.Resources.LogoSDBW
        Me.PbxLogo.Location = New System.Drawing.Point(23, 12)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(152, 157)
        Me.PbxLogo.TabIndex = 13
        Me.PbxLogo.TabStop = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(292, 114)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 3
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnMasuk
        '
        Me.BtnMasuk.Location = New System.Drawing.Point(184, 114)
        Me.BtnMasuk.Name = "BtnMasuk"
        Me.BtnMasuk.Size = New System.Drawing.Size(75, 23)
        Me.BtnMasuk.TabIndex = 2
        Me.BtnMasuk.Text = "Masuk"
        Me.BtnMasuk.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(247, 68)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(120, 20)
        Me.TxtPass.TabIndex = 1
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(247, 39)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(120, 20)
        Me.TxtUsername.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User Name"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(390, 181)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnMasuk)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Login"
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnMasuk As Button
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
