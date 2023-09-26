Imports System.Data.Odbc
Public Class frmMenu
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        'by ihsan ali
        If Strings.Mid(strMenuAkses, 1, 1) = "1" Then mnuFileMaster.Visible = True Else mnuFileMaster.Visible = False
        If Strings.Mid(strMenuAkses, 2, 1) = "1" Then mnuMasterBarang.Visible = True Else mnuMasterBarang.Visible = False
        If Strings.Mid(strMenuAkses, 3, 1) = "1" Then mnuMasterKaryawan.Visible = True Else mnuMasterKaryawan.Visible = False
        If Strings.Mid(strMenuAkses, 4, 1) = "1" Then mnuMasterPelanggan.Visible = True Else mnuMasterPelanggan.Visible = False
        If Strings.Mid(strMenuAkses, 5, 1) = "1" Then mnuMasterSupplier.Visible = True Else mnuMasterSupplier.Visible = False
        If Strings.Mid(strMenuAkses, 6, 1) = "1" Then mnuHakAkses.Visible = True Else mnuHakAkses.Visible = False
        If Strings.Mid(strMenuAkses, 7, 1) = "1" Then mnuFileTransaksi.Visible = True Else mnuFileTransaksi.Visible = False
        If Strings.Mid(strMenuAkses, 8, 1) = "1" Then mnuTransaksiPenjualan.Visible = True Else mnuTransaksiPenjualan.Visible = False
        If Strings.Mid(strMenuAkses, 9, 1) = "1" Then mnuTransaksiPembelian.Visible = True Else mnuTransaksiPembelian.Visible = False
        If Strings.Mid(strMenuAkses, 10, 1) = "1" Then mnuFileLaporan.Visible = True Else mnuFileLaporan.Visible = False
        If Strings.Mid(strMenuAkses, 11, 1) = "1" Then mnuLapStokBarang.Visible = True Else mnuLapStokBarang.Visible = False
        If Strings.Mid(strMenuAkses, 12, 1) = "1" Then mnuLapDataKaryawan.Visible = True Else mnuLapDataKaryawan.Visible = False
        If Strings.Mid(strMenuAkses, 13, 1) = "1" Then mnuLapDataPelanggan.Visible = True Else mnuLapDataPelanggan.Visible = False
        If Strings.Mid(strMenuAkses, 14, 1) = "1" Then mnuHistoriPenjualan.Visible = True Else mnuHistoriPenjualan.Visible = False
        If Strings.Mid(strMenuAkses, 15, 1) = "1" Then mnuHistoriPembelian.Visible = True Else mnuHistoriPembelian.Visible = False
        If Strings.Mid(strMenuAkses, 16, 1) = "1" Then mnuLapJual.Visible = True Else mnuLapJual.Visible = False
        If Strings.Mid(strMenuAkses, 17, 1) = "1" Then mnuLapBeli.Visible = True Else mnuLapBeli.Visible = False


        Status1.Text = strUser
        Timer1.Interval = 1000
        Timer2.Interval = 1000

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackgroundImage = Me.BackgroundImage
            End If
        Next ctl
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Status3.Text = Format(Now, "dd MMM yyyy | HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Status2.Text = "Sistem Informasi Penjualan" Then
            Status2.Text = "Sistem"
        ElseIf Status2.Text = "Sistem" Then
            Status2.Text = "Sistem Informasi"
        Else
            Status2.Text = "Sistem Informasi Penjualan"
        End If
    End Sub
    Private Sub mnuMasterHakAkses_Click(sender As Object, e As EventArgs) Handles mnuHakAkses.Click
        frmHakAkses.Show()
        frmHakAkses.StartPosition = FormStartPosition.CenterScreen
        frmHakAkses.MdiParent = Me
    End Sub

    Private Sub mnuMasterBarang_Click(sender As Object, e As EventArgs) Handles mnuMasterBarang.Click
        frmBarang.Show()
        frmBarang.StartPosition = FormStartPosition.CenterScreen
        frmBarang.MdiParent = Me
    End Sub
    Private Sub mnuMasterKaryawan_Click(sender As Object, e As EventArgs) Handles mnuMasterKaryawan.Click
        frmKaryawan.Show()
        frmKaryawan.StartPosition = FormStartPosition.CenterScreen
        frmKaryawan.MdiParent = Me
    End Sub
    Private Sub mnuMasterPelanggan_Click(sender As Object, e As EventArgs) Handles mnuMasterPelanggan.Click
        frmPelanggan.Show()
        frmPelanggan.StartPosition = FormStartPosition.CenterScreen
        frmPelanggan.MdiParent = Me
    End Sub
    Private Sub mnuMasterSupplier_Click_1(sender As Object, e As EventArgs) Handles mnuMasterSupplier.Click
        frmSupplier.Show()
        frmSupplier.StartPosition = FormStartPosition.CenterScreen
        frmSupplier.MdiParent = Me

    End Sub
    Private Sub mnuTransaksiPenjualan_Click(sender As Object, e As EventArgs) Handles mnuTransaksiPenjualan.Click
        frmPenjualan.Show()
        frmPenjualan.StartPosition = FormStartPosition.CenterScreen
        frmPenjualan.MdiParent = Me
    End Sub

    Private Sub mnuTransaksiPembelian_Click(sender As Object, e As EventArgs) Handles mnuTransaksiPembelian.Click
        frmPembelian.Show()
        frmPembelian.StartPosition = FormStartPosition.CenterScreen
        frmPembelian.MdiParent = Me
    End Sub
    Private Sub mnuLapStokBarang_Click(sender As Object, e As EventArgs) Handles mnuLapStokBarang.Click
        cetak.Show()
        cetak.CRV.ReportSource = "lapBarang.rpt"
        cetak.CRV.RefreshReport()
    End Sub

    Private Sub mnuLapDataPelanggan_Click(sender As Object, e As EventArgs) Handles mnuLapDataPelanggan.Click
        cetak.Show()
        cetak.CRV.ReportSource = "lapPelanggan.rpt"
        cetak.CRV.RefreshReport()
    End Sub

    Private Sub mnuLapDataKaryawan_Click(sender As Object, e As EventArgs) Handles mnuLapDataKaryawan.Click
        cetak.Show()
        cetak.CRV.ReportSource = "lapKaryawan.rpt"
        cetak.CRV.RefreshReport()
    End Sub

    Private Sub mnuHistoriPenjualan_Click(sender As Object, e As EventArgs) Handles mnuHistoriPenjualan.Click
        frmHistoriPenjualan.Show()
        frmHistoriPenjualan.StartPosition = FormStartPosition.CenterScreen
        frmHistoriPenjualan.MdiParent = Me
    End Sub

    Private Sub mnuHistoriPembelian_Click(sender As Object, e As EventArgs) Handles mnuHistoriPembelian.Click
        frmHistoriPembelian.Show()
        frmHistoriPembelian.StartPosition = FormStartPosition.CenterScreen
        frmHistoriPembelian.MdiParent = Me
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuLapJual.Click
        frmLapJual.Show()
        frmLapJual.StartPosition = FormStartPosition.CenterScreen
        frmLapJual.MdiParent = Me
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuLapBeli.Click
        frmLapBeli.Show()
        frmLapBeli.StartPosition = FormStartPosition.CenterScreen
        frmLapBeli.MdiParent = Me
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        If MsgBox("Anda yakin ingin keluar dari akun ini?", vbYesNo, "Konfirmasi") = vbNo Then
            Exit Sub
        ElseIf vbYes Then
            Me.Close()
            frmLogin.Show()
            frmLogin.txtUserName.Focus()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If MsgBox("Anda yakin ingin keluar dari Aplikasi ini?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        End
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Form1.Show()
        Form1.StartPosition = FormStartPosition.CenterScreen
        Form1.MdiParent = Me
    End Sub
End Class