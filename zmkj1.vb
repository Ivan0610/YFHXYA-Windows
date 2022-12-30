Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class zmkj1
    Private 点中状态 As Boolean = False '用于判断我们是否按下了鼠标
    Private 选中位置 As Point '按下鼠标的位置
    Private 鼠标位置 As Point '鼠标相对屏幕的位置
    Private Sub zmkj1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Height = My.Computer.Screen.Bounds.Height / 2
        Left = 0
        Top = (My.Computer.Screen.Bounds.Height - Me.Height) / 2
        Width = 45
        Dim path As GraphicsPath = GetRoundedRectPath(Me.ClientRectangle, 20)
        Me.Region = New Region(path)
        Me.TopMost = True
        WaitForm.Close()
        Dim I
        For I = 0.01 To 1 Step 0.01
            Me.Opacity = I
            Application.DoEvents()
            Thread.Sleep(8)
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub zmkj1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown


    End Sub


    Private Sub zmkj1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

    End Sub

    Private Sub zmkj1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        '鼠标位置 = New Point(e.X, e.Y) '获得鼠标的位置（以窗体为坐标系）
        'If Me.点中状态 = True Then '判断是否按下了鼠标
        'Me.Location = PointToScreen(鼠标位置) - Me.选中位置 'PointToScreen(鼠标位置)
        'End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Me.点中状态 = True
        Me.选中位置 = New Point(e.X, e.Y)
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Me.点中状态 = False
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        鼠标位置 = New Point(e.X, e.Y) '获得鼠标的位置（以窗体为坐标系）
        If Me.点中状态 = True Then '判断是否按下了鼠标
            Me.Location = PointToScreen(鼠标位置) - Me.选中位置 'PointToScreen(鼠标位置)
        End If
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