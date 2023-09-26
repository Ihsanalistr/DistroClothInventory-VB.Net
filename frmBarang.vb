Imports System.Data.Odbc
Public Class frmBarang
    Sub kondisiAwal()

        txtId.Text = ""
        txtNama.Text = ""
        txtJumlah.Text = ""
        txtHarga.Text = ""
        cboKet.Text = ""
        cboKet.Enabled = False
        txtNama.Enabled = False
        txtId.Enabled = False
        txtJumlah.Enabled = False
        txtHarga.Enabled = False
        btnCari.Visible = False
        btnInput.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        btnInput.Text = "Input"
        btnEdit.Text = "Edit"
        btnHapus.Text = "Hapus"
        btnTutup.Text = "Tutup"
        Call KONEKSI()
        DA = New OdbcDataAdapter("select * from barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "barang")
        DataGridView1.DataSource = DS.Tables("barang")
        DataGridView1.ReadOnly = True
        Call Kombo()
    End Sub

    Sub cari()
        If CodeCari = False Then strCari = InputBox("Masukkan Nama Barang!", "Cari Data")
        Call KONEKSI()
        CMD = New OdbcCommand("select * from barang where nama like '%" & strCari & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = False Then
            MsgBox("Data tidak ditemukan", vbInformation, "Info")
            Call kondisiAwal()
        Else
            txtId.Text = DR.Item(0)
            txtNama.Text = DR.Item(1)
            txtJumlah.Text = DR.Item(2)
            txtHarga.Text = DR.Item(3)
            cboKet.Text = DR.Item(4)
        End If
    End Sub
    Sub Kombo()
        cboKet.Items.Clear()
        cboKet.Items.Add("PCS")
        cboKet.Items.Add("LUSIN")
        cboKet.Items.Add("KODI")
        cboKet.Items.Add("GROSS")
    End Sub
    Sub siapIsi()
        txtNama.Enabled = True
        txtId.Enabled = True
        txtJumlah.Enabled = True
        txtHarga.Enabled = True
        cboKet.Enabled = True
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If btnInput.Text = "Input" Then
            btnInput.Text = "Simpan"
            btnEdit.Enabled = False
            btnHapus.Enabled = False
            btnTutup.Text = "Batal"
            Call siapIsi()
            Call NomorOtomatis()
            txtId.Enabled = False
            txtNama.Focus()
        Else
            If txtNama.Text = "" Or txtId.Text = "" Or txtJumlah.Text = "" Or txtHarga.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim InputData As String = "INSERT INTO barang (id, nama, jumlah, harga, keterangan) VALUES ('" & txtId.Text & "', '" & txtNama.Text & "', '" & txtJumlah.Text & "', '" & txtHarga.Text & "', '" & cboKet.Text & "')"
                CMD = New OdbcCommand(InputData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Berhasil", vbInformation, "Info")
                Call kondisiAwal()

            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            btnInput.Enabled = False
            btnHapus.Enabled = False
            btnTutup.Text = "Batal"
            btnCari.Visible = True
            Call siapIsi()
        Else
            If txtNama.Text = "" Or txtId.Text = "" Or txtJumlah.Text = "" Or txtHarga.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim UpdateData As String = "UPDATE barang SET id='" & txtId.Text & "', nama= '" & txtNama.Text & "', jumlah= '" & txtJumlah.Text & "', harga= '" & txtHarga.Text & "', keterangan= '" & cboKet.Text & "' WHERE id= '" & txtId.Text & "'   "
                CMD = New OdbcCommand(UpdateData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Update Data Berhasil", vbInformation, "Info")
                Call kondisiAwal()

            End If
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        If btnTutup.Text = "Tutup" Then
            Me.Close()
        Else
            Call kondisiAwal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "Hapus" Then
            btnHapus.Text = "Menghapus"
            btnInput.Enabled = False
            btnEdit.Enabled = False
            btnTutup.Text = "Batal"
            Call siapIsi()
        Else
            If txtNama.Text = "" Or txtId.Text = "" Or txtJumlah.Text = "" Or txtHarga.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim HapusData As String = "DELETE FROM barang WHERE id= '" & txtId.Text & "' "
                CMD = New OdbcCommand(HapusData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil", vbInformation, "Info")
                Call kondisiAwal()

            End If
        End If
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KONEKSI()
            CMD = New OdbcCommand("select * from barang where id='" & txtId.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Id tidak ada!", vbInformation, "Error")
            Else
                txtId.Text = DR.Item("id")
                txtNama.Text = DR.Item("nama")
                txtJumlah.Text = DR.Item("jumlah")
                txtHarga.Text = DR.Item("harga")
                cboKet.Text = DR.Item("keterangan")

            End If
        End If
    End Sub

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub NomorOtomatis()
        Call KONEKSI()
        CMD = New OdbcCommand("select * from barang where id in (select max(id) from barang)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "BRG" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            UrutanKode = "BRG" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        txtId.Text = UrutanKode
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call cari()
    End Sub
End Class