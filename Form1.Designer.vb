<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhanSo1 = New System.Windows.Forms.TextBox()
        Me.txtPhanSo2 = New System.Windows.Forms.TextBox()
        Me.txtKetQua = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCong = New System.Windows.Forms.Button()
        Me.btnChia = New System.Windows.Forms.Button()
        Me.btnNhan = New System.Windows.Forms.Button()
        Me.btnTru = New System.Windows.Forms.Button()
        Me.btnFIle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phân số thứ 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Phân số thứ 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kết quả"
        '
        'txtPhanSo1
        '
        Me.txtPhanSo1.Location = New System.Drawing.Point(245, 45)
        Me.txtPhanSo1.Name = "txtPhanSo1"
        Me.txtPhanSo1.Size = New System.Drawing.Size(184, 20)
        Me.txtPhanSo1.TabIndex = 0
        '
        'txtPhanSo2
        '
        Me.txtPhanSo2.Location = New System.Drawing.Point(245, 84)
        Me.txtPhanSo2.Name = "txtPhanSo2"
        Me.txtPhanSo2.Size = New System.Drawing.Size(184, 20)
        Me.txtPhanSo2.TabIndex = 1
        '
        'txtKetQua
        '
        Me.txtKetQua.Location = New System.Drawing.Point(245, 124)
        Me.txtKetQua.Name = "txtKetQua"
        Me.txtKetQua.Size = New System.Drawing.Size(184, 20)
        Me.txtKetQua.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Phép tính"
        '
        'btnCong
        '
        Me.btnCong.Location = New System.Drawing.Point(245, 157)
        Me.btnCong.Name = "btnCong"
        Me.btnCong.Size = New System.Drawing.Size(35, 23)
        Me.btnCong.TabIndex = 2
        Me.btnCong.Text = "+"
        Me.btnCong.UseVisualStyleBackColor = True
        '
        'btnChia
        '
        Me.btnChia.Location = New System.Drawing.Point(394, 157)
        Me.btnChia.Name = "btnChia"
        Me.btnChia.Size = New System.Drawing.Size(35, 23)
        Me.btnChia.TabIndex = 2
        Me.btnChia.Text = "/"
        Me.btnChia.UseVisualStyleBackColor = True
        '
        'btnNhan
        '
        Me.btnNhan.Location = New System.Drawing.Point(346, 157)
        Me.btnNhan.Name = "btnNhan"
        Me.btnNhan.Size = New System.Drawing.Size(35, 23)
        Me.btnNhan.TabIndex = 2
        Me.btnNhan.Text = "*"
        Me.btnNhan.UseVisualStyleBackColor = True
        '
        'btnTru
        '
        Me.btnTru.Location = New System.Drawing.Point(294, 157)
        Me.btnTru.Name = "btnTru"
        Me.btnTru.Size = New System.Drawing.Size(35, 23)
        Me.btnTru.TabIndex = 2
        Me.btnTru.Text = "-"
        Me.btnTru.UseVisualStyleBackColor = True
        '
        'btnFIle
        '
        Me.btnFIle.Location = New System.Drawing.Point(245, 194)
        Me.btnFIle.Name = "btnFIle"
        Me.btnFIle.Size = New System.Drawing.Size(184, 23)
        Me.btnFIle.TabIndex = 3
        Me.btnFIle.Text = "Ghi kết quả ra file"
        Me.btnFIle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.btnFIle)
        Me.Controls.Add(Me.btnTru)
        Me.Controls.Add(Me.btnNhan)
        Me.Controls.Add(Me.btnChia)
        Me.Controls.Add(Me.btnCong)
        Me.Controls.Add(Me.txtKetQua)
        Me.Controls.Add(Me.txtPhanSo2)
        Me.Controls.Add(Me.txtPhanSo1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phép tính phân số"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhanSo1 As TextBox
    Friend WithEvents txtPhanSo2 As TextBox
    Friend WithEvents txtKetQua As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCong As Button
    Friend WithEvents btnChia As Button
    Friend WithEvents btnNhan As Button
    Friend WithEvents btnTru As Button
    Friend WithEvents btnFIle As Button
End Class
