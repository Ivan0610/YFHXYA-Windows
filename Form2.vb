Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit
Imports System.Threading

Public Class Form2
    Private Sub Form2_show() Handles MyBase.Load
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
        Dim path As GraphicsPath = GetRoundedRectPath(Me.ClientRectangle, 20)
        Me.Region = New Region(path)
        Me.TopMost = True

        Dim I
        For I = 0.01 To 1 Step 0.01
            Me.Opacity = I
            Application.DoEvents()
            Thread.Sleep(10)
        Next
        Me.Opacity = 1
        Thread.Sleep(2000)
        For I = 1 To 0.01 Step -0.01
            Me.Opacity = I
            Application.DoEvents()
            Thread.Sleep(10)
        Next
        Me.Opacity = 0

        Form3.Opacity = 0
        Form3.Show()
        'Me.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.StartPosition = FormStartPosition.CenterParent
        Label1.Text = "浙江信息工程学校"
        Label2.Text = "机械制造22"
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