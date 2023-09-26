Imports System.Data.Odbc
Public Class frmPembelian
    Dim TglMySQL As String

    Sub KondisiAwal()
        lblNamaSp.Text = ""
        lblAlamat.Text = ""
        lblTelp.Text = ""
        lblTanggal.Text = Today
        lblAdmin.Text = frmMenu.Status1.Text
        lblKembali.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        lblNamaBarang.Text = ""
        lblHargaBarang.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        lblItem.Text = ""
        Call MunculKodePelanggan()
        Call NomorOtomatis()
        Call BuatKolom()
        lblTotal.Text = "0"
        ComboBox1.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = TimeOfDay
    End Sub

    Private Sub frmPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        DA = New OdbcDataAdapter("select id, nama from barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "barang")
        DataGridView2.DataSource = DS.Tables("barang")
        DataGridView2.ReadOnly = True
    End Sub

    Sub MunculKodePelanggan()
        Call KONEKSI()
        ComboBox1.Items.Clear()
        CMD = New OdbcCommand("select * from supplier", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call KONEKSI()
        CMD = New OdbcCommand("select * from supplier where id= '" & ComboBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            lblNamaSp.Text = DR!nama
            lblAlamat.Text = DR!alamat
            lblTelp.Text = DR!telepon
        End If
    End Sub

    Sub NomorOtomatis()
        Call KONEKSI()
        CMD = New OdbcCommand("select * from pembelian where NoBeli in (select max(NoBeli) from pembelian)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "B" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 9) + 1
            UrutanKode = "B" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        lblNoBeli.Text = UrutanKode
    End Sub

    Sub BuatKolom()
        'ihsanali
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KONEKSI()
            CMD = New OdbcCommand("select * from barang where id='" & TextBox2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Id tidak ada!", vbInformation, "Error")
            Else
                TextBox2.Text = DR.Item("id")
                lblNamaBarang.Text = DR.Item("nama")
                'TextBox3.Text = DR.Item("jumlah")
                lblHargaBarang.Text = DR.Item("harga")
                'cboKet.Text = DR.Item("keterangan")
                TextBox3.Enabled = True
                lblJumlahBarang.Text = DR.Item("jumlah")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan masukan yang belum terisi dahulu lalu tekan Enter!", vbInformation, "Info")
        Else
            If lblJumlahBarang.Text < Val(TextBox3.Text) Then
                MsgBox("Stok barang anda kurang nih...", vbInformation, "Error")
            Else
                DataGridView1.Rows.Add(New String() {TextBox2.Text, lblNamaBarang.Text, lblHargaBarang.Text, TextBox3.Text, Val(lblHargaBarang.Text) * Val(TextBox3.Text)})
                Call RumusSubTotal()
                TextBox2.Text = ""
                lblNamaBarang.Text = ""
                lblHargaBarang.Text = ""
                TextBox3.Text = ""
                TextBox3.Enabled = False
                Call RumusCariItem()
            End If
        End If

    End Sub
    Sub RumusSubTotal()
        Dim hitung As Integer
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            lblTotal.Text = hitung
        Next

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(lblTotal.Text) Then
                MsgBox("Pembayaran ada kurang nih...", vbInformation, "Error")
            ElseIf Val(TextBox1.Text) = Val(lblTotal.Text) Then
                lblKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(lblTotal.Text) Then
                lblKembali.Text = Val(TextBox1.Text) - Val(lblTotal.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            lblItem.Text = HitungItem
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblKembali.Text = "" Or lblNamaSp.Text = "" Or lblTotal.Text = 0 Then
            MsgBox("Transaksi tidak ada, silahkan melakukan transaksi terlebih dahulu!", vbInformation, "Error")
        Else
            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanJual As String = "insert into pembelian values ('" & lblNoBeli.Text & "', '" & TglMySQL & "', '" & lblJam.Text & "', '" & lblItem.Text & "', '" & lblTotal.Text & "', '" & TextBox1.Text & "', '" & lblKembali.Text & "', '" & ComboBox1.Text & "', '" & frmMenu.Status1.Text & "')"
            CMD = New OdbcCommand(SimpanJual, CONN)
            CMD.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetail As String = "insert into detailbeli values ('" & lblNoBeli.Text & "',  '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                CMD = New OdbcCommand(SimpanDetail, CONN)
                CMD.ExecuteNonQuery()

                CMD = New OdbcCommand("select * from barang where id= '" & DataGridView1.Rows(Baris).Cells(0).Value & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                Dim TambahinStok As String = "Update barang set jumlah= '" & DR.Item("jumlah") + DataGridView1.Rows(Baris).Cells(3).Value & "' where id= '" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                CMD = New OdbcCommand(TambahinStok, CONN)
                CMD.ExecuteNonQuery()

            Next
            Call KondisiAwal()
            MsgBox("Transaksi berhasil disimpan!", vbInformation, "Info")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call KondisiAwal()
    End Sub

End Class