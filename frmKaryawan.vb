Imports System.Data.Odbc
Public Class frmKaryawan
    Sub kondisiAwal()
        txtNama.Text = ""
        cboJabatan.Items.Clear()
        txtUser.Text = ""
        txtPwd.Text = ""
        cboJabatan.Text = ""
        txtNama.Enabled = False
        cboJabatan.Enabled = False
        txtUser.Enabled = False
        txtPwd.Enabled = False
        btnCari.Visible = False
        btnInput.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        btnInput.Text = "Input"
        btnEdit.Text = "Edit"
        btnHapus.Text = "Hapus"
        btnTutup.Text = "Tutup"
        Call KONEKSI()
        DA = New OdbcDataAdapter("select User, Nama, Jabatan from login", CONN)
        DS = New DataSet
        DA.Fill(DS, "login")
        DataGridView1.DataSource = DS.Tables("login")
        DataGridView1.ReadOnly = True

    End Sub

    Sub cari()
        If CodeCari = False Then strCari = InputBox("Masukkan Nama Karyawan!", "Cari Data")
        Call KONEKSI()
        CMD = New OdbcCommand("select * from login where Nama like '%" & strCari & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = False Then
            MsgBox("Data tidak ditemukan", vbInformation, "Info")
            Call kondisiAwal()
        Else
            txtUser.Text = DR.Item(2)
            txtNama.Text = DR.Item(0)
            cboJabatan.Text = DR.Item(1)
            txtPwd.Text = DR.Item(3)
        End If
    End Sub
    Sub siapIsi()
        txtNama.Enabled = True
        cboJabatan.Enabled = True
        txtUser.Enabled = True
        txtPwd.Enabled = True
        cboJabatan.Items.Add("ADMIN")
        cboJabatan.Items.Add("KASIR")
        cboJabatan.Items.Add("USER")
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
        Else
            If txtNama.Text = "" Or txtUser.Text = "" Or cboJabatan.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim InputData As String = "INSERT INTO login (Nama, Jabatan, User, Password, MenuAkses) VALUES ('" & txtNama.Text & "', '" & cboJabatan.Text & "', '" & txtUser.Text & "', '" & txtPwd.Text & "', '0')"
                CMD = New OdbcCommand(InputData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Berhasil", vbInformation, "Info")
                MsgBox("Pastikan urus hak akses untuk selanjutnya!", vbInformation, "Info")
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
            If txtNama.Text = "" Or txtUser.Text = "" Or cboJabatan.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim UpdateData As String = "UPDATE login SET Nama='" & txtNama.Text & "', Jabatan= '" & cboJabatan.Text & "', User= '" & txtUser.Text & "', Password= '" & txtPwd.Text & "' WHERE User= '" & txtUser.Text & "'   "
                CMD = New OdbcCommand(UpdateData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Update Data Berhasil", vbInformation, "Info")
                Call kondisiAwal()

            End If
        End If
    End Sub
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KONEKSI()
            CMD = New OdbcCommand("select * from login where User='" & txtUser.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("User tidak ada!", vbInformation, "Error")
            Else
                txtNama.Text = DR.Item("Nama")
                cboJabatan.Text = DR.Item("Jabatan")
                txtUser.Text = DR.Item("User")
                txtPwd.Text = DR.Item("Password")

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
            If txtNama.Text = "" Or txtUser.Text = "" Or cboJabatan.Text = "" Then
                MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim HapusData As String = "DELETE FROM login WHERE User= '" & txtUser.Text & "' "
                CMD = New OdbcCommand(HapusData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call kondisiAwal()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call cari()
    End Sub
End Class