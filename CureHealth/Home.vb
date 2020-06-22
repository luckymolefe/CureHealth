Public Class Home

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPanel.Click
        AdminLogin.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorPanel.Click
        HcpLogin.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim urlLink As String = "http://pentest.dev/curehealth/resetpassword.php"
        System.Diagnostics.Process.Start(urlLink)
    End Sub
End Class
