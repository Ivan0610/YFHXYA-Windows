Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class Form1

    Private Sub Form1_show(sender As Object, e As EventArgs) Handles MyBase.Load


        set_up.CheckBox2.Checked = GetSetting(ProductName, set_up.Name, "CheckBox2", set_up.CheckBox2.Checked)
        If set_up.CheckBox2.Checked = True Then
            Form3.Maincolor = Color.White
            Form3.MainForecolor = Color.Black
        Else
            Form3.Maincolor = Color.Black
            Form3.MainForecolor = Color.White
        End If
        Me.BackColor = Form3.Maincolor
        Label1.ForeColor = Form3.MainForecolor
        Label2.ForeColor = Form3.MainForecolor
        Label3.ForeColor = Form3.MainForecolor
        Label4.ForeColor = Form3.MainForecolor
        Label5.ForeColor = Form3.MainForecolor

        Dim path As GraphicsPath = GetRoundedRectPath(Me.ClientRectangle, 20)
        Me.Region = New Region(path)
        Me.TopMost = True
        Dim I
        For I = 0.01 To 1 Step 0.01
            Me.Opacity = I
            Application.DoEvents()
            Thread.Sleep(11)
        Next
        Me.Opacity = 1
        Thread.Sleep(3000)
        For I = 1 To 0.01 Step -0.01
            Me.Opacity = I
            Application.DoEvents()
            Thread.Sleep(13)
        Next
        Me.Opacity = 0
        Form2.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "YFHXYA"
        Label2.Text = "凤凰学业"
        Label3.Text = "1.0.0.20220827_Alpha"
        Label1.Left = Label2.Left = Label3.Left = (Me.Size.Width - Label1.Width) / 2

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
End Class
