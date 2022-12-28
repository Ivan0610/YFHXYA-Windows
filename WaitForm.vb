Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class WaitForm
    Private Sub WaitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As GraphicsPath = GetRoundedRectPath(Me.ClientRectangle, 20)
        Me.Region = New Region(path)
        Dim I
        For I = 0 To 1 Step 0.01
            Me.Opacity = I
            Application.DoEvents()
            Thread.Sleep(8)
        Next
        Me.Opacity = 1
        Me.TopMost = True
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