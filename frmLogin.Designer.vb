<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmdLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUserName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Lapor admin jika belum mempunyai akun."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sistem Informasi Penjualan"
        '
        'cmdLogin
        '
        Me.cmdLogin.ActiveBorderThickness = 1
        Me.cmdLogin.ActiveCornerRadius = 20
        Me.cmdLogin.ActiveFillColor = System.Drawing.Color.Navy
        Me.cmdLogin.ActiveForecolor = System.Drawing.Color.White
        Me.cmdLogin.ActiveLineColor = System.Drawing.Color.Transparent
        Me.cmdLogin.BackColor = System.Drawing.Color.White
        Me.cmdLogin.BackgroundImage = CType(resources.GetObject("cmdLogin.BackgroundImage"), System.Drawing.Image)
        Me.cmdLogin.ButtonText = "Login"
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.IdleBorderThickness = 1
        Me.cmdLogin.IdleCornerRadius = 20
        Me.cmdLogin.IdleFillColor = System.Drawing.Color.MediumSlateBlue
        Me.cmdLogin.IdleForecolor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.IdleLineColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.Location = New System.Drawing.Point(326, 188)
        Me.cmdLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdLogin.Name = "cmdLogin"
        Me.HelpProvider1.SetShowHelp(Me.cmdLogin, True)
        Me.cmdLogin.Size = New System.Drawing.Size(163, 37)
        Me.cmdLogin.TabIndex = 3
        Me.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources.log_out
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(513, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._20945988
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(25, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 171)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Silver
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(304, 149)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(215, 30)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUserName
        '
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserName.HintForeColor = System.Drawing.Color.Silver
        Me.txtUserName.HintText = "Username"
        Me.txtUserName.isPassword = False
        Me.txtUserName.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUserName.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUserName.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUserName.LineThickness = 3
        Me.txtUserName.Location = New System.Drawing.Point(304, 111)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(215, 30)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(550, 300)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cmdLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUserName As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
