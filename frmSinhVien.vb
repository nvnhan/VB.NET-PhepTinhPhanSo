Imports System.Linq

Public Class frmSinhVien
    ''' <summary>
    ''' Danh sách sinh viên
    ''' </summary>
    Dim ListSinhVien As New List(Of SinhVien)

    ''' <summary>
    ''' Xóa trống các ô
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearButton7_Click(sender As Object, e As EventArgs) Handles ClearButton7.Click
        MaSoTextBox1.Text = ""
        HoTenTextBox2.Text = ""
        DiemTextBox3.Text = ""
        DisplayTextBox1.Text = ""
    End Sub

    ''' <summary>
    ''' Tìm kiếm sinh viên theo mã số
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FindButton6_Click(sender As Object, e As EventArgs) Handles FindButton6.Click
        Dim ms = MaSoTextBox1.Text
        ' Dùng LINQ tìm sinh viên có mã số tương ứng
        Dim svFind = From sv In ListSinhVien
                     Where sv.MaSo = ms
        If svFind.Count() > 0 Then
            MaSoTextBox1.Text = svFind(0).MaSo
            HoTenTextBox2.Text = svFind(0).HoTen
            DiemTextBox3.Text = svFind(0).Diem
        Else
            MsgBox("Không tìm thấy")
        End If
    End Sub

    ''' <summary>
    ''' Thêm mới sinh viên
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddButton1_Click(sender As Object, e As EventArgs) Handles AddButton1.Click
        Dim diem = Integer.Parse(DiemTextBox3.Text)
        ' Tạo đối tượng sinh viên mới
        Dim newSv = New SinhVien(MaSoTextBox1.Text, HoTenTextBox2.Text, diem)
        ListSinhVien.Add(newSv)
        MsgBox("Đã thêm sinh viên")
    End Sub

    ''' <summary>
    ''' Cập nhật Thông tin sinh viên
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateButton2_Click(sender As Object, e As EventArgs) Handles UpdateButton2.Click
        Dim ms = MaSoTextBox1.Text
        Dim diem = Integer.Parse(DiemTextBox3.Text)
        ' Dùng LINQ tìm sinh viên có mã số tương ứng
        Dim svFind = From sv In ListSinhVien
                     Where sv.MaSo = ms
        If svFind.Count() > 0 Then
            svFind(0).HoTen = HoTenTextBox2.Text
            svFind(0).Diem = diem
            MsgBox("Đã cập nhật thông tin sinh viên")
        Else
            MsgBox("Không tìm thấy sinh viên")
        End If
    End Sub

    ''' <summary>
    ''' Xóa sinh viên khỏi danh sách
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteButton3_Click(sender As Object, e As EventArgs) Handles DeleteButton3.Click
        Dim ms = MaSoTextBox1.Text
        ' Dùng LINQ tìm sinh viên có mã số tương ứng
        Dim svFind = From sv In ListSinhVien
                     Where sv.MaSo = ms
        If svFind.Count() > 0 Then
            ListSinhVien.Remove(svFind)
            MsgBox("Đã xóa sinh viên có mã số " + ms)
        Else
            MsgBox("Không tìm thấy sinh viên")
        End If
    End Sub

    ''' <summary>
    ''' Sắp xếp danh sách theo điểm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SortButton4_Click(sender As Object, e As EventArgs) Handles SortButton4.Click
        ListSinhVien = (From sv In ListSinhVien
                        Order By sv.Diem
                        Select sv).ToList()
        MsgBox("Đã sắp xếp sinh viên")
    End Sub

    Private Sub DisplayButton5_Click(sender As Object, e As EventArgs) Handles DisplayButton5.Click
        DisplayTextBox1.Text = ""
        For Each sv In ListSinhVien
            DisplayTextBox1.Text += sv.MaSo + "   " + sv.HoTen + "   " + sv.Diem.ToString() + Environment.NewLine
        Next
    End Sub
End Class

''' <summary>
''' Class Sinh Vien
''' </summary>
Public Class SinhVien
    Public MaSo As String
    Public HoTen As String
    Public Diem As Integer = 0

    Public Sub New(ByVal ms As String, ByVal ht As String, ByVal d As Integer)
        MaSo = ms
        HoTen = ht
        Diem = d
    End Sub
End Class
