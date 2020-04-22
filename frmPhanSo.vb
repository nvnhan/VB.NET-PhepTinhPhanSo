Public Class frmPhanSo
    Dim Chuoi As String

    Private Sub btnCong_Click(sender As Object, e As EventArgs) Handles btnCong.Click
        Dim ps1 As PhanSo = PhanSo.Parse(txtPhanSo1.Text)
        Dim ps2 As PhanSo = PhanSo.Parse(txtPhanSo2.Text)
        txtKetQua.Text = (ps1 + ps2).ToString()
        Chuoi = ps1.ToString() + " + " + ps2.ToString() + " = " + txtKetQua.Text
    End Sub

    Private Sub btnTru_Click(sender As Object, e As EventArgs) Handles btnTru.Click
        Dim ps1 As PhanSo = PhanSo.Parse(txtPhanSo1.Text)
        Dim ps2 As PhanSo = PhanSo.Parse(txtPhanSo2.Text)
        txtKetQua.Text = (ps1 - ps2).ToString()
        Chuoi = ps1.ToString() + " - " + ps2.ToString() + " = " + txtKetQua.Text
    End Sub

    Private Sub btnNhan_Click(sender As Object, e As EventArgs) Handles btnNhan.Click
        Dim ps1 As PhanSo = PhanSo.Parse(txtPhanSo1.Text)
        Dim ps2 As PhanSo = PhanSo.Parse(txtPhanSo2.Text)
        txtKetQua.Text = (ps1 * ps2).ToString()
        Chuoi = ps1.ToString() + " * " + ps2.ToString() + " = " + txtKetQua.Text
    End Sub

    Private Sub btnChia_Click(sender As Object, e As EventArgs) Handles btnChia.Click
        Dim ps1 As PhanSo = PhanSo.Parse(txtPhanSo1.Text)
        Dim ps2 As PhanSo = PhanSo.Parse(txtPhanSo2.Text)
        txtKetQua.Text = (ps1 / ps2).ToString()
        Chuoi = ps1.ToString() + " / " + ps2.ToString() + " = " + txtKetQua.Text
    End Sub

    Private Sub btnFIle_Click(sender As Object, e As EventArgs) Handles btnFIle.Click
        Dim dia As New SaveFileDialog
        dia.Title = "Chọn vị trí lưu file"
        dia.FileName = "ketqua.txt"
        dia.Filter = "File text|*.txt"
        If dia.ShowDialog() = DialogResult.OK Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(dia.FileName, True)
            file.WriteLine(Chuoi)
            file.Close()
        End If
    End Sub
End Class

Public Class PhanSo
    Public TuSo As Integer = 1
    Public MauSo As Integer = 1

    ' Tìm ước số chung lớn nhất của a và b
    Public Shared Function GCD(ByVal a As Integer, ByVal b As Integer) As Integer
        If b = 0 Then
            Return a
        End If
        Return GCD(b, a Mod b)        ' Gọi đệ quy tới UCLN của b và a % b
    End Function

    ' Hàm khai báo
    Public Sub New(ByVal t As Integer, ByVal m As Integer)
        TuSo = t
        MauSo = m
    End Sub

    ' Hàm chuyển đổi từ chuỗi sang phân số
    Public Shared Function Parse(s As String) As PhanSo
        Dim array As String() = s.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        Dim ps As New PhanSo(1, 1)
        ps.TuSo = Integer.Parse(array(0))
        If (array.Count() > 1) Then
            ps.MauSo = Integer.Parse(array(1))
            If (ps.MauSo = 0) Then
                ps.MauSo = 1
            End If
        End If
        Return ps
    End Function

    ' Hàm rút gọn phân số
    Public Shared Function RutGon(ByVal ps As PhanSo) As PhanSo
        Dim UCLN As Integer = GCD(ps.TuSo, ps.MauSo)
        Return New PhanSo(ps.TuSo / UCLN, ps.MauSo / UCLN)
    End Function

    ' Hàm to string
    Public Overrides Function ToString() As String
        If MauSo = 1 Then
            Return TuSo.ToString()
        End If
        Return TuSo.ToString() + "/" + MauSo.ToString()
    End Function

    ' ghi đè phép cộng
    Public Shared Operator +(ByVal x As PhanSo, ByVal y As PhanSo) As PhanSo
        Return PhanSo.RutGon(New PhanSo(x.TuSo * y.MauSo + y.TuSo * x.MauSo, x.MauSo * y.MauSo))
    End Operator
    ' Ghi đè phép trừ
    Public Shared Operator -(ByVal x As PhanSo, ByVal y As PhanSo) As PhanSo
        Return PhanSo.RutGon(New PhanSo(x.TuSo * y.MauSo - y.TuSo * x.MauSo, x.MauSo * y.MauSo))
    End Operator
    ' ghi đè phép nhân
    Public Shared Operator *(ByVal x As PhanSo, ByVal y As PhanSo) As PhanSo
        Return PhanSo.RutGon(New PhanSo(x.TuSo * y.TuSo, x.MauSo * y.MauSo))
    End Operator
    ' ghi đè phép chia
    Public Shared Operator /(ByVal x As PhanSo, ByVal y As PhanSo) As PhanSo
        Return PhanSo.RutGon(New PhanSo(x.TuSo * y.MauSo, x.MauSo * y.TuSo))
    End Operator
End Class
