<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHakAkses
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
        Me.chkMasterSupplier = New System.Windows.Forms.CheckBox()
        Me.chkLapPem = New System.Windows.Forms.CheckBox()
        Me.chkLapPen = New System.Windows.Forms.CheckBox()
        Me.chkLapHPem = New System.Windows.Forms.CheckBox()
        Me.chkLapHPen = New System.Windows.Forms.CheckBox()
        Me.chkTransBeli = New System.Windows.Forms.CheckBox()
        Me.chkLapPelanggan = New System.Windows.Forms.CheckBox()
        Me.chkLapKaryawan = New System.Windows.Forms.CheckBox()
        Me.chkLapBarang = New System.Windows.Forms.CheckBox()
        Me.chkTransJual = New System.Windows.Forms.CheckBox()
        Me.chkHakAkses = New System.Windows.Forms.CheckBox()
        Me.chkMasterPelanggan = New System.Windows.Forms.CheckBox()
        Me.chkMasterKaryawan = New System.Windows.Forms.CheckBox()
        Me.chkMasterBarang = New System.Windows.Forms.CheckBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.chkFileLaporan = New System.Windows.Forms.CheckBox()
        Me.chkFileTransaksi = New System.Windows.Forms.CheckBox()
        Me.chkFileMaster = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkMasterSupplier
        '
        Me.chkMasterSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterSupplier.AutoSize = True
        Me.chkMasterSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterSupplier.Location = New System.Drawing.Point(222, 250)
        Me.chkMasterSupplier.Name = "chkMasterSupplier"
        Me.chkMasterSupplier.Size = New System.Drawing.Size(64, 17)
        Me.chkMasterSupplier.TabIndex = 51
        Me.chkMasterSupplier.Text = "Supplier"
        Me.chkMasterSupplier.UseVisualStyleBackColor = False
        '
        'chkLapPem
        '
        Me.chkLapPem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapPem.AutoSize = True
        Me.chkLapPem.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapPem.Location = New System.Drawing.Point(575, 250)
        Me.chkLapPem.Name = "chkLapPem"
        Me.chkLapPem.Size = New System.Drawing.Size(75, 17)
        Me.chkLapPem.TabIndex = 63
        Me.chkLapPem.Text = "Pembelian"
        Me.chkLapPem.UseVisualStyleBackColor = False
        '
        'chkLapPen
        '
        Me.chkLapPen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapPen.AutoSize = True
        Me.chkLapPen.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapPen.Location = New System.Drawing.Point(575, 227)
        Me.chkLapPen.Name = "chkLapPen"
        Me.chkLapPen.Size = New System.Drawing.Size(73, 17)
        Me.chkLapPen.TabIndex = 62
        Me.chkLapPen.Text = "Penjualan"
        Me.chkLapPen.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkLapPen.UseVisualStyleBackColor = False
        '
        'chkLapHPem
        '
        Me.chkLapHPem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapHPem.AutoSize = True
        Me.chkLapHPem.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapHPem.Location = New System.Drawing.Point(575, 204)
        Me.chkLapHPem.Name = "chkLapHPem"
        Me.chkLapHPem.Size = New System.Drawing.Size(107, 17)
        Me.chkLapHPem.TabIndex = 61
        Me.chkLapHPem.Text = "Histori Pembelian"
        Me.chkLapHPem.UseVisualStyleBackColor = False
        '
        'chkLapHPen
        '
        Me.chkLapHPen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapHPen.AutoSize = True
        Me.chkLapHPen.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapHPen.Location = New System.Drawing.Point(575, 181)
        Me.chkLapHPen.Name = "chkLapHPen"
        Me.chkLapHPen.Size = New System.Drawing.Size(105, 17)
        Me.chkLapHPen.TabIndex = 60
        Me.chkLapHPen.Text = "Histori Penjualan"
        Me.chkLapHPen.UseVisualStyleBackColor = False
        '
        'chkTransBeli
        '
        Me.chkTransBeli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTransBeli.AutoSize = True
        Me.chkTransBeli.BackColor = System.Drawing.SystemColors.Control
        Me.chkTransBeli.Location = New System.Drawing.Point(328, 204)
        Me.chkTransBeli.Name = "chkTransBeli"
        Me.chkTransBeli.Size = New System.Drawing.Size(75, 17)
        Me.chkTransBeli.TabIndex = 55
        Me.chkTransBeli.Text = "Pembelian"
        Me.chkTransBeli.UseVisualStyleBackColor = False
        '
        'chkLapPelanggan
        '
        Me.chkLapPelanggan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapPelanggan.AutoSize = True
        Me.chkLapPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapPelanggan.Location = New System.Drawing.Point(457, 227)
        Me.chkLapPelanggan.Name = "chkLapPelanggan"
        Me.chkLapPelanggan.Size = New System.Drawing.Size(103, 17)
        Me.chkLapPelanggan.TabIndex = 59
        Me.chkLapPelanggan.Text = "Data Pelanggan"
        Me.chkLapPelanggan.UseVisualStyleBackColor = False
        '
        'chkLapKaryawan
        '
        Me.chkLapKaryawan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapKaryawan.AutoSize = True
        Me.chkLapKaryawan.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapKaryawan.Location = New System.Drawing.Point(457, 204)
        Me.chkLapKaryawan.Name = "chkLapKaryawan"
        Me.chkLapKaryawan.Size = New System.Drawing.Size(99, 17)
        Me.chkLapKaryawan.TabIndex = 58
        Me.chkLapKaryawan.Text = "Data Karyawan"
        Me.chkLapKaryawan.UseVisualStyleBackColor = False
        '
        'chkLapBarang
        '
        Me.chkLapBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkLapBarang.AutoSize = True
        Me.chkLapBarang.BackColor = System.Drawing.SystemColors.Control
        Me.chkLapBarang.Location = New System.Drawing.Point(457, 181)
        Me.chkLapBarang.Name = "chkLapBarang"
        Me.chkLapBarang.Size = New System.Drawing.Size(85, 17)
        Me.chkLapBarang.TabIndex = 57
        Me.chkLapBarang.Text = "Stok Barang"
        Me.chkLapBarang.UseVisualStyleBackColor = False
        '
        'chkTransJual
        '
        Me.chkTransJual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTransJual.AutoSize = True
        Me.chkTransJual.BackColor = System.Drawing.SystemColors.Control
        Me.chkTransJual.Location = New System.Drawing.Point(328, 181)
        Me.chkTransJual.Name = "chkTransJual"
        Me.chkTransJual.Size = New System.Drawing.Size(73, 17)
        Me.chkTransJual.TabIndex = 54
        Me.chkTransJual.Text = "Penjualan"
        Me.chkTransJual.UseVisualStyleBackColor = False
        '
        'chkHakAkses
        '
        Me.chkHakAkses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkHakAkses.AutoSize = True
        Me.chkHakAkses.BackColor = System.Drawing.SystemColors.Control
        Me.chkHakAkses.Location = New System.Drawing.Point(222, 273)
        Me.chkHakAkses.Name = "chkHakAkses"
        Me.chkHakAkses.Size = New System.Drawing.Size(78, 17)
        Me.chkHakAkses.TabIndex = 52
        Me.chkHakAkses.Text = "Hak Akses"
        Me.chkHakAkses.UseVisualStyleBackColor = False
        '
        'chkMasterPelanggan
        '
        Me.chkMasterPelanggan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterPelanggan.AutoSize = True
        Me.chkMasterPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterPelanggan.Location = New System.Drawing.Point(222, 227)
        Me.chkMasterPelanggan.Name = "chkMasterPelanggan"
        Me.chkMasterPelanggan.Size = New System.Drawing.Size(77, 17)
        Me.chkMasterPelanggan.TabIndex = 50
        Me.chkMasterPelanggan.Text = "Pelanggan"
        Me.chkMasterPelanggan.UseVisualStyleBackColor = False
        '
        'chkMasterKaryawan
        '
        Me.chkMasterKaryawan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterKaryawan.AutoSize = True
        Me.chkMasterKaryawan.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterKaryawan.Location = New System.Drawing.Point(222, 204)
        Me.chkMasterKaryawan.Name = "chkMasterKaryawan"
        Me.chkMasterKaryawan.Size = New System.Drawing.Size(73, 17)
        Me.chkMasterKaryawan.TabIndex = 49
        Me.chkMasterKaryawan.Text = "Karyawan"
        Me.chkMasterKaryawan.UseVisualStyleBackColor = False
        '
        'chkMasterBarang
        '
        Me.chkMasterBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterBarang.AutoSize = True
        Me.chkMasterBarang.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterBarang.Location = New System.Drawing.Point(222, 181)
        Me.chkMasterBarang.Name = "chkMasterBarang"
        Me.chkMasterBarang.Size = New System.Drawing.Size(60, 17)
        Me.chkMasterBarang.TabIndex = 48
        Me.chkMasterBarang.Text = "Barang"
        Me.chkMasterBarang.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeluar.Location = New System.Drawing.Point(280, 348)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(156, 23)
        Me.btnKeluar.TabIndex = 68
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBatal.Location = New System.Drawing.Point(441, 319)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 67
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHapus.Location = New System.Drawing.Point(361, 319)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 66
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCari.Location = New System.Drawing.Point(280, 319)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 65
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSimpan.Location = New System.Drawing.Point(199, 319)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 64
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'chkFileLaporan
        '
        Me.chkFileLaporan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkFileLaporan.AutoSize = True
        Me.chkFileLaporan.Location = New System.Drawing.Point(441, 158)
        Me.chkFileLaporan.Name = "chkFileLaporan"
        Me.chkFileLaporan.Size = New System.Drawing.Size(84, 17)
        Me.chkFileLaporan.TabIndex = 56
        Me.chkFileLaporan.Text = "File Laporan"
        Me.chkFileLaporan.UseVisualStyleBackColor = True
        '
        'chkFileTransaksi
        '
        Me.chkFileTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkFileTransaksi.AutoSize = True
        Me.chkFileTransaksi.Location = New System.Drawing.Point(314, 158)
        Me.chkFileTransaksi.Name = "chkFileTransaksi"
        Me.chkFileTransaksi.Size = New System.Drawing.Size(91, 17)
        Me.chkFileTransaksi.TabIndex = 53
        Me.chkFileTransaksi.Text = "File Transaksi"
        Me.chkFileTransaksi.UseVisualStyleBackColor = True
        '
        'chkFileMaster
        '
        Me.chkFileMaster.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkFileMaster.AutoSize = True
        Me.chkFileMaster.BackColor = System.Drawing.SystemColors.Control
        Me.chkFileMaster.Location = New System.Drawing.Point(207, 158)
        Me.chkFileMaster.Name = "chkFileMaster"
        Me.chkFileMaster.Size = New System.Drawing.Size(77, 17)
        Me.chkFileMaster.TabIndex = 47
        Me.chkFileMaster.Text = "File Master"
        Me.chkFileMaster.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Menu Akses"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Location = New System.Drawing.Point(207, 108)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(258, 20)
        Me.txtPassword.TabIndex = 46
        '
        'txtUser
        '
        Me.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUser.Location = New System.Drawing.Point(207, 78)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(170, 20)
        Me.txtUser.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Pemberian Akses Menu"
        '
        'frmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.chkMasterSupplier)
        Me.Controls.Add(Me.chkLapPem)
        Me.Controls.Add(Me.chkLapPen)
        Me.Controls.Add(Me.chkLapHPem)
        Me.Controls.Add(Me.chkLapHPen)
        Me.Controls.Add(Me.chkTransBeli)
        Me.Controls.Add(Me.chkLapPelanggan)
        Me.Controls.Add(Me.chkLapKaryawan)
        Me.Controls.Add(Me.chkLapBarang)
        Me.Controls.Add(Me.chkTransJual)
        Me.Controls.Add(Me.chkHakAkses)
        Me.Controls.Add(Me.chkMasterPelanggan)
        Me.Controls.Add(Me.chkMasterKaryawan)
        Me.Controls.Add(Me.chkMasterBarang)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.chkFileLaporan)
        Me.Controls.Add(Me.chkFileTransaksi)
        Me.Controls.Add(Me.chkFileMaster)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHakAkses"
        Me.Text = "Manajemen Hak Akses"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMasterSupplier As CheckBox
    Friend WithEvents chkLapPem As CheckBox
    Friend WithEvents chkLapPen As CheckBox
    Friend WithEvents chkLapHPem As CheckBox
    Friend WithEvents chkLapHPen As CheckBox
    Friend WithEvents chkTransBeli As CheckBox
    Friend WithEvents chkLapPelanggan As CheckBox
    Friend WithEvents chkLapKaryawan As CheckBox
    Friend WithEvents chkLapBarang As CheckBox
    Friend WithEvents chkTransJual As CheckBox
    Friend WithEvents chkHakAkses As CheckBox
    Friend WithEvents chkMasterPelanggan As CheckBox
    Friend WithEvents chkMasterKaryawan As CheckBox
    Friend WithEvents chkMasterBarang As CheckBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents cmdSimpan As Button
    Friend WithEvents chkFileLaporan As CheckBox
    Friend WithEvents chkFileTransaksi As CheckBox
    Friend WithEvents chkFileMaster As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
