Imports System.Data.Odbc
Public Class frmHistoriPenjualan
    Sub KondisiAwal()
        ComboBox1.Text = ""
        lblTanggal.Text = ""
        lblTotalHarga.Text = ""
        txtDibayar.Clear()
        lblKembali.Text = ""
        DGV.Columns.Clear()
    End Sub
    Sub MunculKodePelanggan()
        Call KONEKSI()
        ComboBox1.Items.Clear()
        CMD = New OdbcCommand("select * from penjualan", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub
    Private Sub frmHistoriPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call MunculKodePelanggan()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call KONEKSI()
        CMD = New OdbcCommand("select * from penjualan where NoJual= '" & ComboBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            lblTanggal.Text = Format(DR.Item("tglJual"), "dd-MMMM-yyyy")
            lblTotalHarga.Text = DR.Item("totalJual")
            txtDibayar.Text = DR.Item("dibayar")
            lblKembali.Text = DR.Item("kembali")
        End If
        Call KONEKSI()
        DA = New OdbcDataAdapter("select namaBrg, hrgJual, jmlJual, subTotal from detailjual where NoJual = '" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True

        DGV.Columns(0).Width = 250
        DGV.Columns(1).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        lblTotalHarga.Text = FormatNumber(lblTotalHarga.Text, 0)
        txtDibayar.Text = FormatNumber(txtDibayar.Text, 0)
        lblKembali.Text = FormatNumber(lblKembali.Text, 0)

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If ComboBox1.Text = "" Then
            MsgBox("Data ada yang kosong nih...", vbInformation, "Error")
        Else
            cetak.Show()
            cetak.CRV.SelectionFormula = "totext({penjualan.noJual})='" & ComboBox1.Text & "'"
            cetak.CRV.ReportSource = "notaJual.rpt"
            cetak.CRV.RefreshReport()
            Call KondisiAwal()
        End If
    End Sub

    Private Sub brnBatal_Click(sender As Object, e As EventArgs) Handles brnBatal.Click
        If MsgBox("Anda yakin ingin menghapus view?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call KondisiAwal()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        If MsgBox("Anda yakin ingin keluar dari menu ini?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub
End Class