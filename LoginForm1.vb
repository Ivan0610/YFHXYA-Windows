Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class LoginForm1

    ' TODO: 插入代码，以使用提供的用户名和密码执行自定义的身份验证
    ' (请参阅 https://go.microsoft.com/fwlink/?LinkId=35339)。  
    ' 随后自定义主体可附加到当前线程的主体，如下所示: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 其中 CustomPrincipal 是用于执行身份验证的 IPrincipal 实现。
    ' 随后，My.User 将返回 CustomPrincipal 对象中封装的标识信息
    ' 如用户名、显示名等

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "Yujianhao" And PasswordTextBox.Text = "Yjh061018" Then
            MessageBox.Show("登入成功！"）
        Else
            MessageBox.Show("登入失败！"）
        End If
        Me.Close()
        set_up.Enabled = True
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        set_up.Show()
        Me.TopMost = False
        set_up.Enabled = True
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As GraphicsPath = GetRoundedRectPath(Me.ClientRectangle, 20)
        Me.Region = New Region(path)
        set_up.Enabled = False
        Dim A, B
        For B = 1 To 0 Step -0.01
            WaitForm.Opacity = B
            Application.DoEvents()
            Thread.Sleep(8)
        Next

        WaitForm.Close()

        Me.TopMost = True
        For A = 0 To 1 Step 0.01
            Me.Opacity = A
            Application.DoEvents()
            Thread.Sleep(8)
        Next
        Me.Opacity = 1


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For A = 1 To 0 Step -0.01
            Me.Opacity = A
            Application.DoEvents()
            Thread.Sleep(8)
        Next
        Me.Close()
        set_up.Enabled = True
        set_up.TopMost = True
    End Sub
End Class
