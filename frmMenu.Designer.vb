<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Status3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mnuLapBeli = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLapJual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHistoriPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHistoriPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLapDataPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLapDataKaryawan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuLapStokBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaksiPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaksiPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHakAkses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMasterSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMasterPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMasterKaryawan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMasterBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Status3
        '
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(33, 17)
        Me.Status3.Text = "Time"
        '
        'Status2
        '
        Me.Status2.ImageTransparentColor = System.Drawing.Color.White
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(751, 17)
        Me.Status2.Spring = True
        Me.Status2.Text = "Status"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(35, 17)
        Me.Status1.Text = "Akun"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1, Me.Status2, Me.Status3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(834, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "Status1"
        '
        'mnuLapBeli
        '
        Me.mnuLapBeli.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_preferences_contact_list
        Me.mnuLapBeli.Name = "mnuLapBeli"
        Me.mnuLapBeli.Size = New System.Drawing.Size(176, 22)
        Me.mnuLapBeli.Text = "Laporan &Pembelian"
        '
        'mnuLapJual
        '
        Me.mnuLapJual.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_preferences_contact_list
        Me.mnuLapJual.Name = "mnuLapJual"
        Me.mnuLapJual.Size = New System.Drawing.Size(176, 22)
        Me.mnuLapJual.Text = "Laporan &Penjualan"
        '
        'mnuHistoriPembelian
        '
        Me.mnuHistoriPembelian.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_note_edit
        Me.mnuHistoriPembelian.Name = "mnuHistoriPembelian"
        Me.mnuHistoriPembelian.Size = New System.Drawing.Size(176, 22)
        Me.mnuHistoriPembelian.Text = "Histori &Pembelian"
        '
        'mnuHistoriPenjualan
        '
        Me.mnuHistoriPenjualan.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_note_edit
        Me.mnuHistoriPenjualan.Name = "mnuHistoriPenjualan"
        Me.mnuHistoriPenjualan.Size = New System.Drawing.Size(176, 22)
        Me.mnuHistoriPenjualan.Text = "Histori &Penjualan"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(173, 6)
        '
        'mnuLapDataPelanggan
        '
        Me.mnuLapDataPelanggan.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_database_save
        Me.mnuLapDataPelanggan.Name = "mnuLapDataPelanggan"
        Me.mnuLapDataPelanggan.Size = New System.Drawing.Size(176, 22)
        Me.mnuLapDataPelanggan.Text = "Data &Pelanggan"
        '
        'mnuLapDataKaryawan
        '
        Me.mnuLapDataKaryawan.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_database_save
        Me.mnuLapDataKaryawan.Name = "mnuLapDataKaryawan"
        Me.mnuLapDataKaryawan.Size = New System.Drawing.Size(176, 22)
        Me.mnuLapDataKaryawan.Text = "Data &Karyawan"
        '
        'Timer2
        '
        '
        'mnuLapStokBarang
        '
        Me.mnuLapStokBarang.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_database_save
        Me.mnuLapStokBarang.Name = "mnuLapStokBarang"
        Me.mnuLapStokBarang.Size = New System.Drawing.Size(176, 22)
        Me.mnuLapStokBarang.Text = "&Stok &Barang"
        '
        'mnuTransaksiPembelian
        '
        Me.mnuTransaksiPembelian.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_calendar_edit
        Me.mnuTransaksiPembelian.Name = "mnuTransaksiPembelian"
        Me.mnuTransaksiPembelian.Size = New System.Drawing.Size(130, 22)
        Me.mnuTransaksiPembelian.Text = "&Pembelian"
        '
        'mnuTransaksiPenjualan
        '
        Me.mnuTransaksiPenjualan.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_list_edit
        Me.mnuTransaksiPenjualan.Name = "mnuTransaksiPenjualan"
        Me.mnuTransaksiPenjualan.Size = New System.Drawing.Size(130, 22)
        Me.mnuTransaksiPenjualan.Text = "&Penjualan"
        '
        'mnuFileTransaksi
        '
        Me.mnuFileTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTransaksiPenjualan, Me.mnuTransaksiPembelian})
        Me.mnuFileTransaksi.Name = "mnuFileTransaksi"
        Me.mnuFileTransaksi.Size = New System.Drawing.Size(87, 20)
        Me.mnuFileTransaksi.Text = "File &Transaksi"
        '
        'mnuHakAkses
        '
        Me.mnuHakAkses.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_diagram_v2_08
        Me.mnuHakAkses.Name = "mnuHakAkses"
        Me.mnuHakAkses.Size = New System.Drawing.Size(180, 22)
        Me.mnuHakAkses.Text = "&Hak Akses"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'mnuMasterSupplier
        '
        Me.mnuMasterSupplier.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_user_group_new
        Me.mnuMasterSupplier.Name = "mnuMasterSupplier"
        Me.mnuMasterSupplier.Size = New System.Drawing.Size(180, 22)
        Me.mnuMasterSupplier.Text = "&Supplier"
        '
        'mnuMasterPelanggan
        '
        Me.mnuMasterPelanggan.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_user_group_new
        Me.mnuMasterPelanggan.Name = "mnuMasterPelanggan"
        Me.mnuMasterPelanggan.Size = New System.Drawing.Size(180, 22)
        Me.mnuMasterPelanggan.Text = "&Pelanggan"
        '
        'mnuMasterKaryawan
        '
        Me.mnuMasterKaryawan.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_administrator_004
        Me.mnuMasterKaryawan.Name = "mnuMasterKaryawan"
        Me.mnuMasterKaryawan.Size = New System.Drawing.Size(180, 22)
        Me.mnuMasterKaryawan.Text = "&Karyawan"
        '
        'mnuMasterBarang
        '
        Me.mnuMasterBarang.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_cog_edit
        Me.mnuMasterBarang.Name = "mnuMasterBarang"
        Me.mnuMasterBarang.Size = New System.Drawing.Size(180, 22)
        Me.mnuMasterBarang.Text = "&Barang"
        '
        'mnuFileMaster
        '
        Me.mnuFileMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMasterBarang, Me.mnuMasterKaryawan, Me.mnuMasterPelanggan, Me.mnuMasterSupplier, Me.ToolStripMenuItem1, Me.mnuHakAkses, Me.GantiPasswordToolStripMenuItem})
        Me.mnuFileMaster.Name = "mnuFileMaster"
        Me.mnuFileMaster.Size = New System.Drawing.Size(76, 20)
        Me.mnuFileMaster.Text = "File &Master"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._16_key_002
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "&Ganti Password"
        '
        'mnuFileLaporan
        '
        Me.mnuFileLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLapStokBarang, Me.mnuLapDataKaryawan, Me.mnuLapDataPelanggan, Me.ToolStripMenuItem3, Me.mnuHistoriPenjualan, Me.mnuHistoriPembelian, Me.ToolStripMenuItem2, Me.mnuLapJual, Me.mnuLapBeli})
        Me.mnuFileLaporan.Name = "mnuFileLaporan"
        Me.mnuFileLaporan.Size = New System.Drawing.Size(83, 20)
        Me.mnuFileLaporan.Text = "File &Laporan"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(173, 6)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileMaster, Me.mnuFileTransaksi, Me.mnuFileLaporan, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout, Me.mnuExit})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'mnuLogout
        '
        Me.mnuLogout.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._16_delete
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(180, 22)
        Me.mnuLogout.Text = "Keluar &Akun"
        '
        'mnuExit
        '
        Me.mnuExit.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._16_cross_circle_frame
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Keluar &Aplikasi"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources.SI_Penjualan_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Penjualan Kelompok Sans"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Status3 As ToolStripStatusLabel
    Friend WithEvents Status2 As ToolStripStatusLabel
    Friend WithEvents Status1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents mnuLapBeli As ToolStripMenuItem
    Friend WithEvents mnuLapJual As ToolStripMenuItem
    Friend WithEvents mnuHistoriPembelian As ToolStripMenuItem
    Friend WithEvents mnuHistoriPenjualan As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents mnuLapDataPelanggan As ToolStripMenuItem
    Friend WithEvents mnuLapDataKaryawan As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents mnuLapStokBarang As ToolStripMenuItem
    Friend WithEvents mnuTransaksiPembelian As ToolStripMenuItem
    Friend WithEvents mnuTransaksiPenjualan As ToolStripMenuItem
    Friend WithEvents mnuFileTransaksi As ToolStripMenuItem
    Friend WithEvents mnuHakAkses As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuMasterSupplier As ToolStripMenuItem
    Friend WithEvents mnuMasterPelanggan As ToolStripMenuItem
    Friend WithEvents mnuMasterKaryawan As ToolStripMenuItem
    Friend WithEvents mnuMasterBarang As ToolStripMenuItem
    Friend WithEvents mnuFileMaster As ToolStripMenuItem
    Friend WithEvents mnuFileLaporan As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
End Class
