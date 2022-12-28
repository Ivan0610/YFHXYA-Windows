Imports System.Xml
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports DocumentFormat.OpenXml.Office2010.ExcelAc
Imports System.Data.SqlTypes

Public Class Form3
    '  Dim xmldoc As New XmlDocument()
    Public Shared Maincolor
    Public Shared MainForecolor

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WaitForm.Show()


        Label3.Text = "设置"
        'Dim I = 0
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        'NotifyIcon1.Visible = True

        set_up.Opacity = 0
        'set_up.Show()
        'set_up.CheckBox2.Checked = GetSetting(ProductName, set_up.Name, "CheckBox2", set_up.CheckBox2.Checked)
        Timer1.Enabled = True        '激活时间控件
        Timer1.Interval = 100
        Timer1.Start() '开启定时器


        Dim I
        For I = 0 To 1 Step 1

            If set_up.CheckBox2.Checked = True Then
                Form3.Maincolor = Color.White
                Form3.MainForecolor = Color.Black
            Else
                Form3.Maincolor = Color.Black
                Form3.MainForecolor = Color.White
            End If
            BackColor = Form3.Maincolor
            Label1.ForeColor = Form3.MainForecolor
            Label2.ForeColor = Form3.MainForecolor
            Label3.ForeColor = Form3.MainForecolor
            PictureBox1.BackColor = Form3.Maincolor

            Label1.Text = System.DateTime.Now
            Label1.Left = (Me.Size.Width - Label1.Width) / 2
            Label1.Top = (Me.Height - Label1.Height) * 0.1
            PictureBox1.Left = Me.Size.Width - PictureBox1.Width
            PictureBox1.Top = Me.Height - PictureBox1.Height
            Label2.Left = Label2.Width - Label2.Width
            Label2.Top = (Me.Height - Label2.Height) * 1
            Label3.Left = Me.Size.Width - Label3.Width
            Label3.Top = Label3.Height - Label3.Height
            Application.DoEvents()
            Thread.Sleep(10)
        Next


        Dim T
        For T = 1 To 0 Step -0.01
            WaitForm.Opacity = I
            Application.DoEvents()
            Thread.Sleep(8)
        Next
        WaitForm.Opacity = 0

        Dim A
        WaitForm.Close()
        Me.TopMost = True
        For A = 0 To 1 Step 0.01
            Me.Opacity = A
            Application.DoEvents()
            Thread.Sleep(10)
        Next
        Me.Opacity = 1
    End Sub
    Private Sub Form3_show(sender As Object, e As EventArgs) Handles MyBase.Load
        'NotifyIcon1.Visible = True
        'NotifyIcon1.ShowBalloonTip(800, "凤凰学业（YFHXYA）", "欢迎使用凤凰学业！", ToolTipIcon.Info)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("凤凰学业")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutBox1.Show()
        Me.TopMost = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(888, "凤凰学业（YFHXYA）", "凤凰学业持续为您服务！", ToolTipIcon.Info)
        Me.Opacity = 0
        '        xmldoc.load("XML_Data_1.xml")
        '        Dim root As XmlNode = xmldoc.SelectSingleNode("bookstore")
        '        Dim xel As XmlElement = xmldoc.CreateElement("事件")
        '        xel.SetAttribute("事件：", "退出")
        '        Dim xel1 As XmlElement = xmldoc.CreateElement("Form3")
        '       root.AppendChild(xel)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WaitForm.Show()
        Me.TopMost = False

        set_up.Opacity = 0
        set_up.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.Opacity = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = System.DateTime.Now
        Label1.Left = (Me.Size.Width - Label1.Width) / 2
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        WaitForm.Show()
        Me.Enabled = False
        set_up.TabPage3.Show()
        set_up.TabControl1.SelectedIndex = 2
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click

        End
    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置ToolStripMenuItem.Click
        Me.Enabled = False
        WaitForm.Show()
        set_up.Show()
    End Sub
End Class