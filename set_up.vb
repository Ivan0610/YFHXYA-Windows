Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Threading

Public Class set_up

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim path As GraphicsPath = GetRoundedRectPath(Me.ClientRectangle, 20)
        Me.Region = New Region(path)
        Form3.Enabled = False
        ' If

        ' End If
        Dim A

        For A = 1 To 0 Step -0.01
            WaitForm.Opacity = A
            Application.DoEvents()
            Thread.Sleep(6)
        Next

        WaitForm.Close()
        Thread.Sleep(5)
        Me.TopMost = True
        For A = 0 To 1 Step 0.01
            Me.Opacity = A
            Application.DoEvents()
            Thread.Sleep(8)
        Next
        'Me.Opacity = 1

    End Sub
    Private Sub Button1_Layout(sender As Object, e As EventArgs) Handles Button1.Layout
        Button1.BackColor = Color.FromArgb(245, 245, 245)
    End Sub
    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        Button1.BackColor = Color.FromArgb(255, 0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B
        For B = 1 To 0 Step -0.01
            Me.Opacity = B
            Application.DoEvents()
            Thread.Sleep(8)
        Next
        Me.Close()
        Form3.Enabled = True
        Form3.TopMost = True
    End Sub



    Private Function GetRoundedRectPath(ByVal Rectangle As Rectangle, ByVal r As Integer) As GraphicsPath
        Rectangle.Offset(-1, -1)
        Dim RoundRect As New Rectangle(Rectangle.Location, New Size(r - 1, r - 1))
        Dim path As New System.Drawing.Drawing2D.GraphicsPath
        path.AddArc(RoundRect, 180, 90) '左上角

        RoundRect.X = Rectangle.Right - r '右上角
        path.AddArc(RoundRect, 270, 90)

        RoundRect.Y = Rectangle.Bottom - r '右下角
        path.AddArc(RoundRect, 0, 90)

        RoundRect.X = Rectangle.Left '左下角
        path.AddArc(RoundRect, 90, 90)

        path.CloseFigure()

        Return path
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        LoginForm1.Opacity = 0
        WaitForm.Show()
        LoginForm1.Show()
        Form3.TopMost = False
        LoginForm1.TopMost = True
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveSetting(ProductName, Me.Name, "CheckBox2", Me.CheckBox2.Checked)
        If Me.CheckBox2.Checked = True Then
            Form3.Maincolor = Color.White
            Form3.MainForecolor = Color.Black
        Else
            Form3.Maincolor = Color.Black
            Form3.MainForecolor = Color.White
        End If
        Form3.BackColor = Form3.Maincolor
        Form3.Label1.ForeColor = Form3.MainForecolor
        Form3.Label2.ForeColor = Form3.MainForecolor
        Form3.Label3.ForeColor = Form3.MainForecolor
        Form3.PictureBox1.BackColor = Form3.Maincolor
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class