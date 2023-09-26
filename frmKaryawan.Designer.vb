<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaryawan
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
        Me.cboJabatan = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboJabatan
        '
        Me.cboJabatan.FormattingEnabled = True
        Me.cboJabatan.Location = New System.Drawing.Point(93, 60)
        Me.cboJabatan.Name = "cboJabatan"
        Me.cboJabatan.Size = New System.Drawing.Size(121, 21)
        Me.cboJabatan.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(435, 170)
        Me.DataGridView1.TabIndex = 25
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(281, 61)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.ReadOnly = True
        Me.txtPwd.Size = New System.Drawing.Size(166, 20)
        Me.txtPwd.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(93, 35)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(354, 20)
        Me.txtNama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(220, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Jabatan"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(93, 9)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(156, 20)
        Me.txtUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Username"
        '
        'btnCari
        '
        Me.btnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCari.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_Search_Male_User
        Me.btnCari.Location = New System.Drawing.Point(372, 93)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 75)
        Me.btnCari.TabIndex = 28
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCari.UseVisualStyleBackColor = True
        Me.btnCari.Visible = False
        '
        'btnTutup
        '
        Me.btnTutup.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._24_close
        Me.btnTutup.Location = New System.Drawing.Point(255, 93)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 75)
        Me.btnTutup.TabIndex = 8
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_file_delete
        Me.btnHapus.Location = New System.Drawing.Point(174, 93)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 75)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_book_edit
        Me.btnEdit.Location = New System.Drawing.Point(93, 93)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_save_32
        Me.btnInput.Location = New System.Drawing.Point(12, 93)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 75)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "Input"
        Me.btnInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'frmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 366)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboJabatan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmKaryawan"
        Me.Text = "Manajemen Karyawan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboJabatan As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnCari As Button
End Class
