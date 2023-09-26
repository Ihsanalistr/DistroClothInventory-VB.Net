Public Class frmLapJual
    Sub Bulan() 'ihsan ali
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("01 - JANUARI")
        ComboBox1.Items.Add("02 - FEBRUARI")
        ComboBox1.Items.Add("03 - MARET")
        ComboBox1.Items.Add("04 - APRIL")
        ComboBox1.Items.Add("05 - MEI")
        ComboBox1.Items.Add("06 - JUNI")
        ComboBox1.Items.Add("07 - JULI")
        ComboBox1.Items.Add("08 - AGUSTUS")
        ComboBox1.Items.Add("09 - SEPTEMBER")
        ComboBox1.Items.Add("10 - OKTOBER")
        ComboBox1.Items.Add("11 - NOVEMBER")
        ComboBox1.Items.Add("12 - DESEMBER")
    End Sub

    Sub Tahun()
        ComboBox2.Items.Clear()
        ComboBox2.Text = Date.Now.Year
        For i As Integer = 0 To 10
            ComboBox2.Items.Add(Date.Now.Year - i)
        Next
    End Sub

    Private Sub frmLapJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bulan()
        Call Tahun()
        Label6.Text = Format(DateTimePicker2.Value, "yyyy,MM,dd")
        Label7.Text = Format(DateTimePicker3.Value, "yyyy,MM,dd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cetak.Show()
        cetak.CRV.SelectionFormula = "totext({penjualan.tglJual})='" & DateTimePicker1.Value & "'"
        cetak.CRV.ReportSource = "lapPenHar.rpt"
        cetak.CRV.RefreshReport()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cetak.Show()
        cetak.CRV.SelectionFormula = "{penjualan.tglJual} in date (" & Label6.Text & ") to date (" & Label7.Text & ")"
        cetak.CRV.ReportSource = "lapPenMing.rpt"
        cetak.CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silahkan isi Bulan dan Tahun terlebih dahulu!", vbInformation, "Error")
        Else
            cetak.Show()
            cetak.CRV.SelectionFormula = "Month({penjualan.tglJual})=" & Val(ComboBox1.Text) & " and year ({penjualan.tglJual})=" & Val(ComboBox2.Text)
            cetak.CRV.ReportSource = "lapPenBul.rpt"
            cetak.CRV.RefreshReport()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Label6.Text = Format(DateTimePicker2.Value, "yyyy,MM,dd")
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Label7.Text = Format(DateTimePicker3.Value, "yyyy,MM,dd")
    End Sub

End Class