Public Class configuration
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim Reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            Reg.SetValue("YFHXYA.exe", Application.StartupPath & "\YFHXYA.exe")         '写入注册表，其中SCMS.exe，就是你需要启动的exe文件

            Reg.Close()
            CheckBox1.Text = "取消开机运行"


        Else
            Dim Reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            Reg.DeleteValue("YFHXYA.exe") '删除注册表键
            Reg.Close()

            CheckBox1.Text = "启动开机运行"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class