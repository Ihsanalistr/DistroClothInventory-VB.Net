Imports System.Data.Odbc
Public Class Form1
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        btnBatal.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Call KONEKSI()
            CMD = New OdbcCommand("select * from login where User = '" & frmMenu.Status1.Text & "' and Password = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                btnBatal.Enabled = True
                TextBox1.Enabled = False
                TextBox2.Focus()
            Else
                MsgBox("Password salah salah!", vbInformation, "Error")
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Password baru harus diisi", vbInformation, "Error")
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password baru dan konfirmasi harus sama", vbInformation, "Error")
            Else
                Call KONEKSI()
                Dim editpwd As String = "Update login set Password='" & TextBox3.Text & "' where User='" & frmMenu.Status1.Text & "'"
                CMD = New OdbcCommand(editpwd, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Update data berhasil", vbInformation, "Info")
                Call KondisiAwal()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call KondisiAwal()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class