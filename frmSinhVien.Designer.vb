<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinhVien
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
        Me.MaSoTextBox1 = New System.Windows.Forms.TextBox()
        Me.HoTenTextBox2 = New System.Windows.Forms.TextBox()
        Me.DiemTextBox3 = New System.Windows.Forms.TextBox()
        Me.AddButton1 = New System.Windows.Forms.Button()
        Me.UpdateButton2 = New System.Windows.Forms.Button()
        Me.DeleteButton3 = New System.Windows.Forms.Button()
        Me.SortButton4 = New System.Windows.Forms.Button()
        Me.DisplayButton5 = New System.Windows.Forms.Button()
        Me.FindButton6 = New System.Windows.Forms.Button()
        Me.ClearButton7 = New System.Windows.Forms.Button()
        Me.DisplayTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã số"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Điểm"
        '
        'MaSoTextBox1
        '
        Me.MaSoTextBox1.Location = New System.Drawing.Point(171, 30)
        Me.MaSoTextBox1.Name = "MaSoTextBox1"
        Me.MaSoTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.MaSoTextBox1.TabIndex = 0
        '
        'HoTenTextBox2
        '
        Me.HoTenTextBox2.Location = New System.Drawing.Point(171, 58)
        Me.HoTenTextBox2.Name = "HoTenTextBox2"
        Me.HoTenTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.HoTenTextBox2.TabIndex = 1
        '
        'DiemTextBox3
        '
        Me.DiemTextBox3.Location = New System.Drawing.Point(171, 86)
        Me.DiemTextBox3.Name = "DiemTextBox3"
        Me.DiemTextBox3.Size = New System.Drawing.Size(200, 20)
        Me.DiemTextBox3.TabIndex = 2
        '
        'AddButton1
        '
        Me.AddButton1.Location = New System.Drawing.Point(414, 28)
        Me.AddButton1.Name = "AddButton1"
        Me.AddButton1.Size = New System.Drawing.Size(75, 23)
        Me.AddButton1.TabIndex = 5
        Me.AddButton1.Text = "Add"
        Me.AddButton1.UseVisualStyleBackColor = True
        '
        'UpdateButton2
        '
        Me.UpdateButton2.Location = New System.Drawing.Point(414, 56)
        Me.UpdateButton2.Name = "UpdateButton2"
        Me.UpdateButton2.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton2.TabIndex = 6
        Me.UpdateButton2.Text = "Update"
        Me.UpdateButton2.UseVisualStyleBackColor = True
        '
        'DeleteButton3
        '
        Me.DeleteButton3.Location = New System.Drawing.Point(414, 84)
        Me.DeleteButton3.Name = "DeleteButton3"
        Me.DeleteButton3.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton3.TabIndex = 7
        Me.DeleteButton3.Text = "Delete"
        Me.DeleteButton3.UseVisualStyleBackColor = True
        '
        'SortButton4
        '
        Me.SortButton4.Location = New System.Drawing.Point(414, 113)
        Me.SortButton4.Name = "SortButton4"
        Me.SortButton4.Size = New System.Drawing.Size(75, 23)
        Me.SortButton4.TabIndex = 8
        Me.SortButton4.Text = "Sort"
        Me.SortButton4.UseVisualStyleBackColor = True
        '
        'DisplayButton5
        '
        Me.DisplayButton5.Location = New System.Drawing.Point(414, 142)
        Me.DisplayButton5.Name = "DisplayButton5"
        Me.DisplayButton5.Size = New System.Drawing.Size(75, 23)
        Me.DisplayButton5.TabIndex = 9
        Me.DisplayButton5.Text = "Display"
        Me.DisplayButton5.UseVisualStyleBackColor = True
        '
        'FindButton6
        '
        Me.FindButton6.Location = New System.Drawing.Point(171, 113)
        Me.FindButton6.Name = "FindButton6"
        Me.FindButton6.Size = New System.Drawing.Size(75, 23)
        Me.FindButton6.TabIndex = 3
        Me.FindButton6.Text = "Find"
        Me.FindButton6.UseVisualStyleBackColor = True
        '
        'ClearButton7
        '
        Me.ClearButton7.Location = New System.Drawing.Point(252, 113)
        Me.ClearButton7.Name = "ClearButton7"
        Me.ClearButton7.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton7.TabIndex = 4
        Me.ClearButton7.Text = "Clear"
        Me.ClearButton7.UseVisualStyleBackColor = True
        '
        'DisplayTextBox1
        '
        Me.DisplayTextBox1.Location = New System.Drawing.Point(12, 192)
        Me.DisplayTextBox1.Multiline = True
        Me.DisplayTextBox1.Name = "DisplayTextBox1"
        Me.DisplayTextBox1.Size = New System.Drawing.Size(560, 157)
        Me.DisplayTextBox1.TabIndex = 10
        '
        'frmSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.DisplayTextBox1)
        Me.Controls.Add(Me.ClearButton7)
        Me.Controls.Add(Me.FindButton6)
        Me.Controls.Add(Me.DisplayButton5)
        Me.Controls.Add(Me.SortButton4)
        Me.Controls.Add(Me.DeleteButton3)
        Me.Controls.Add(Me.UpdateButton2)
        Me.Controls.Add(Me.AddButton1)
        Me.Controls.Add(Me.DiemTextBox3)
        Me.Controls.Add(Me.HoTenTextBox2)
        Me.Controls.Add(Me.MaSoTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sinh viên"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaSoTextBox1 As TextBox
    Friend WithEvents HoTenTextBox2 As TextBox
    Friend WithEvents DiemTextBox3 As TextBox
    Friend WithEvents AddButton1 As Button
    Friend WithEvents UpdateButton2 As Button
    Friend WithEvents DeleteButton3 As Button
    Friend WithEvents SortButton4 As Button
    Friend WithEvents DisplayButton5 As Button
    Friend WithEvents FindButton6 As Button
    Friend WithEvents ClearButton7 As Button
    Friend WithEvents DisplayTextBox1 As TextBox
End Class
