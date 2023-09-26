Imports System.Data.Odbc
Public Class frmPelanggan
    Sub kondisiAwal()
        txtNama.Text = ""
        txtId.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        txtNama.Enabled = False
        txtId.Enabled = False
        txtAlamat.Enabled = False
        txtTelp.Enabled = False

        btnInput.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        btnInput.Text = "Input"
        btnEdit.Text = "Edit"
        btnHapus.Text = "Hapus"
        btnTutup.Text = "Tutup"
        Call KONEKSI()
        DA = New OdbcDataAdapter("select id, nama, alamat, telepon from pelanggan", CONN)
        DS = New DataSet
        DA.Fill(DS, "pelanggan")
        DataGridView1.DataSource = DS.Tables("pelanggan")
        DataGridView1.ReadOnly = True

    End Sub

    Sub siapIsi()
        txtNama.Enabled = True
        txtId.Enabled = True
        txtAlamat.Enabled = True
        txtTelp.Enabled = True
    End Sub

    Private Sub frmKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
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
            If txtNama.Text = "" Or txtId.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim InputData As String = "INSERT INTO pelanggan (id, nama, alamat, telepon) VALUES ('" & txtId.Text & "', '" & txtNama.Text & "', '" & txtAlamat.Text & "', '" & txtTelp.Text & "')"
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
            Call siapIsi()
        Else
            If txtNama.Text = "" Or txtId.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim UpdateData As String = "UPDATE pelanggan SET id='" & txtId.Text & "', nama= '" & txtNama.Text & "', alamat= '" & txtAlamat.Text & "', telepon= '" & txtTelp.Text & "' WHERE id= '" & txtId.Text & "'   "
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
            If txtNama.Text = "" Or txtId.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim HapusData As String = "DELETE FROM pelanggan WHERE id= '" & txtId.Text & "' "
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
            CMD = New OdbcCommand("select * from pelanggan where id='" & txtId.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Id tidak ada!", vbInformation, "Error")
            Else
                txtId.Text = DR.Item("id")
                txtNama.Text = DR.Item("nama")
                txtAlamat.Text = DR.Item("alamat")
                txtTelp.Text = DR.Item("telepon")

            End If
        End If
    End Sub

    Sub NomorOtomatis()
        Call KONEKSI()
        CMD = New OdbcCommand("select * from pelanggan where id in (select max(id) from pelanggan)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "PL" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            UrutanKode = "PL" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        txtId.Text = UrutanKode
    End Sub

End Class