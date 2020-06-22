Public Class AdminLogin

    Private Sub AdminLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.Hide()
    End Sub

    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        Dim username = Me.txtAdminEmail.Text
        Dim password = Me.txtAdminPassword.Text

        If username.Trim() = "" Then
            notifyAlert.Show()
            lblAlertMsg.Text = "Please type your username!"
        ElseIf password.Trim() = "" Then
            notifyAlert.Show()
            lblAlertMsg.Text = "Please type your password!"
        Else
            'validate logins against database
            If username = "admin@curehealth.com" And password = "admin" Then
                clearFields() 'clear all fields
                Me.Hide()
                AdminPanel.Show()
                notifyAlert.Hide()
            Else
                lblAlertMsg.Text = "Invalid login credentials!"
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub clearFields()
        txtAdminEmail.Text = ""
        txtAdminPassword.Text = ""
    End Sub

End Class
