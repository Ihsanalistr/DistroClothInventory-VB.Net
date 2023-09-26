<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoriPenjualan
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
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.brnBatal = New System.Windows.Forms.Button()
        Me.txtDibayar = New System.Windows.Forms.TextBox()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.lblTotalHarga = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._24_close
        Me.btnTutup.Location = New System.Drawing.Point(254, 321)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(115, 65)
        Me.btnTutup.TabIndex = 4
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'brnBatal
        '
        Me.brnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.brnBatal.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_old_edit_undo
        Me.brnBatal.Location = New System.Drawing.Point(133, 321)
        Me.brnBatal.Name = "brnBatal"
        Me.brnBatal.Size = New System.Drawing.Size(115, 65)
        Me.brnBatal.TabIndex = 3
        Me.brnBatal.Text = "Batal"
        Me.brnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.brnBatal.UseVisualStyleBackColor = True
        '
        'txtDibayar
        '
        Me.txtDibayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDibayar.Location = New System.Drawing.Point(622, 348)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.ReadOnly = True
        Me.txtDibayar.Size = New System.Drawing.Size(100, 20)
        Me.txtDibayar.TabIndex = 24
        '
        'lblKembali
        '
        Me.lblKembali.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKembali.Location = New System.Drawing.Point(622, 368)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(100, 23)
        Me.lblKembali.TabIndex = 23
        Me.lblKembali.Text = "Total Harga"
        '
        'lblTotalHarga
        '
        Me.lblTotalHarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalHarga.Location = New System.Drawing.Point(622, 322)
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalHarga.TabIndex = 22
        Me.lblTotalHarga.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(516, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Kembali"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(516, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Dibayar"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(516, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total Harga"
        '
        'DGV
        '
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 44)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(710, 266)
        Me.DGV.TabIndex = 18
        '
        'lblTanggal
        '
        Me.lblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTanggal.Location = New System.Drawing.Point(351, 9)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(122, 23)
        Me.lblTanggal.TabIndex = 17
        Me.lblTanggal.Text = "tgl"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(245, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tanggal"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(118, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Faktur"
        '
        'btnCetak
        '
        Me.btnCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCetak.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_agt_print
        Me.btnCetak.Location = New System.Drawing.Point(12, 321)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(115, 65)
        Me.btnCetak.TabIndex = 2
        Me.btnCetak.Text = "Print"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'frmHistoriPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.brnBatal)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.txtDibayar)
        Me.Controls.Add(Me.lblKembali)
        Me.Controls.Add(Me.lblTotalHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHistoriPenjualan"
        Me.Text = "Riwayat Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTutup As Button
    Friend WithEvents brnBatal As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents txtDibayar As TextBox
    Friend WithEvents lblKembali As Label
    Friend WithEvents lblTotalHarga As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
