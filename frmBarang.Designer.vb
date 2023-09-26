<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBarang
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
        Me.cboKet = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboKet
        '
        Me.cboKet.FormattingEnabled = True
        Me.cboKet.Location = New System.Drawing.Point(89, 60)
        Me.cboKet.Name = "cboKet"
        Me.cboKet.Size = New System.Drawing.Size(121, 21)
        Me.cboKet.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Keterangan"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(89, 9)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(121, 20)
        Me.txtId.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 170)
        Me.DataGridView1.TabIndex = 54
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(89, 87)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(121, 20)
        Me.txtHarga.TabIndex = 45
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(296, 61)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(152, 20)
        Me.txtJumlah.TabIndex = 44
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(89, 35)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(359, 20)
        Me.txtNama.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Id Barang"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(219, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Stok"
        '
        'btnTutup
        '
        Me.btnTutup.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._24_close
        Me.btnTutup.Location = New System.Drawing.Point(251, 119)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 75)
        Me.btnTutup.TabIndex = 49
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_file_delete
        Me.btnHapus.Location = New System.Drawing.Point(170, 119)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 75)
        Me.btnHapus.TabIndex = 48
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_book_edit
        Me.btnEdit.Location = New System.Drawing.Point(89, 119)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.TabIndex = 47
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_save_32
        Me.btnInput.Location = New System.Drawing.Point(8, 119)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 75)
        Me.btnInput.TabIndex = 46
        Me.btnInput.Text = "Input"
        Me.btnInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCari.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_Search_Male_User
        Me.btnCari.Location = New System.Drawing.Point(374, 119)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 75)
        Me.btnCari.TabIndex = 56
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCari.UseVisualStyleBackColor = True
        Me.btnCari.Visible = False
        '
        'frmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 389)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cboKet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBarang"
        Me.Text = "From Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboKet As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
End Class
