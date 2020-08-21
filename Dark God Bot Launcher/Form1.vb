
Imports System.IO
Imports System.Net
Imports Ionic.Zip
Imports Microsoft.Build.Framework.XamlTypes

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Checking For updates Now Please Wait!")

        CheckForUpdates()

    End Sub

    Private Sub CheckForUpdates()
        Dim request As HttpWebRequest = WebRequest.Create("https://botlauncher.twistedxmods.com/Update/Updatecheck")
        Dim response As HttpWebResponse = request.GetResponse()
        Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You are up todate!")
        Else
            MsgBox("There is a new update we, will download it now for you.")

            'Process.Start("https://www.twistedxmodzrp.tk/resources/categories/twisted-x-modz-rp-launcher.2/")
            My.Computer.Network.DownloadFile("https://botlauncher.twistedxmods.com/Update/Files/Launcher.zip", "C:\Darkbot\Launcher\Launcher.zip")

            MessageBox.Show("update download completed.")

            Timer2.Start()
            ''WebBrowser1.Navigate("https://twistedx.000webhostapp.com/TXM-RP-Launcher/releases/Twisted%20X%20Modz%20RP%20Launcher.exe")

        End If
    End Sub

    Private Sub FrostTextBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Website Status
        Dim address As String = "https://botlauncher.twistedxmods.com/Home/Home"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        FrostTextBox1.Text = reader.ReadToEnd
    End Sub

    Private Sub FrostTextBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Website Status
        Dim address As String = "https://botlauncher.twistedxmods.com/News/News"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        FrostTextBox2.Text = reader.ReadToEnd
    End Sub

    Private Sub Label10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Server 1 Status
        Dim address As String = "https://botlauncher.twistedxmods.com/Status/Server"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label10.Text = reader.ReadToEnd
    End Sub

    Private Sub Label2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Update Server Status
        Dim address As String = "https://botlauncher.twistedxmods.com/Status/Updateserverstatus"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label2.Text = reader.ReadToEnd
    End Sub

    Private Sub Label4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Website Status
        Dim address As String = "https://botlauncher.twistedxmods.com/Status/WebsiteStatus"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label4.Text = reader.ReadToEnd
    End Sub

    Private Sub Label6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auth Status
        Dim address As String = "https://botlauncher.twistedxmods.com/Status/AuthStatus"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label6.Text = reader.ReadToEnd
    End Sub

    Private Sub Label9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tool Version
        Dim address As String = "https://botlauncher.twistedxmods.com/Update/Version"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label9.Text = reader.ReadToEnd
    End Sub


    Private Sub FrostButton10_Click(sender As Object, e As EventArgs) Handles FrostButton10.Click
        My.Computer.Network.DownloadFile("https://botlauncher.twistedxmods.com/Download/Dark.zip", "C:\Darkbot\Dark.zip")
        MessageBox.Show("Download has completed unziping Now!!.")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim path As String = ("C:\Darkbot\Dark.zip")
        Using zip As ZipFile = ZipFile.Read(path)
            zip.ExtractAll(("C:\Darkbot\"), ExtractExistingFileAction.DoNotOverwrite)
            'MessageBox.Show("Files Extracted Successfully!!.")
            Label11.Text = "Files Extracted Successfully"
        End Using
    End Sub

    Private Sub FrostButton9_Click(sender As Object, e As EventArgs) Handles FrostButton9.Click
        Dim file As String = "C:\Darkbot\Dark\config.json"
        If System.IO.File.Exists(file) = True Then
            Process.Start(file)
        Else
            MsgBox("File Does Not Exist!!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FrostButton7_Click(sender As Object, e As EventArgs) Handles FrostButton7.Click
        Process.Start("C:\Darkbot\Dark\StartBot.exe")
    End Sub

    Private Sub FrostButton11_Click(sender As Object, e As EventArgs) Handles FrostButton11.Click
        Process.Start("C:\Darkbot\Dark\requirements.exe")
    End Sub

    Private Sub FrostButton8_Click(sender As Object, e As EventArgs) Handles FrostButton8.Click
        CloseBot()
    End Sub

    Private Sub CloseBot()
        ' CLOSE ALL
        Do Until Process.GetProcessesByName("StartBot").Count < 1
            For Each p As Process In Process.GetProcessesByName("StartBot")
                p.CloseMainWindow()
            Next
        Loop
    End Sub

    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        Close()
    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        Process.Start("https://twistedxmods.com/")
        'Timer3.Enabled = True
        'Timer3.Interval = 100 '1000 is 1 sec
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs) Handles FrostButton2.Click
        Process.Start("https://discord.gg/8vAZ7VR")
    End Sub

    Private Sub FrostButton3_Click(sender As Object, e As EventArgs) Handles FrostButton3.Click
        Process.Start("https://github.com/TwistedXMods")
    End Sub

    Private Sub FrostButton5_Click(sender As Object, e As EventArgs) Handles FrostButton5.Click
        Process.Start("https://www.twitch.tv/twisted_x_420")
    End Sub

    Private Sub FrostButton6_Click(sender As Object, e As EventArgs) Handles FrostButton6.Click
        Process.Start("https://paypal.me/TwistedXModz?locale.x=en_US")
    End Sub

    Private Sub FrostButton4_Click(sender As Object, e As EventArgs) Handles FrostButton4.Click
        Process.Start("https://www.youtube.com/channel/UC1cISzeYvNfdYBLV0lJkhvQ")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim path As String = ("C:\Darkbot\Launcher\Launcher.zip")
        Using zip As ZipFile = ZipFile.Read(path)
            zip.ExtractAll(("C:\Darkbot\Launcher"), ExtractExistingFileAction.DoNotOverwrite)
            'MessageBox.Show("Files Extracted Successfully!!.")
            Label12.Text = "Files Extracted Successfully they are in C:\Darkbot\Launcher"
        End Using
    End Sub

    Private Sub FrostButton12_Click(sender As Object, e As EventArgs) Handles FrostButton12.Click
        Process.Start("https://twistedxmods.com/support-tickets/")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        FrostProgressBar1.Increment(+1)
        If FrostProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Process.Start("https://twistedxmods.com/")
        End If
    End Sub
End Class
