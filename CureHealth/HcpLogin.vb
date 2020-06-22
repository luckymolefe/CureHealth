Imports System.Windows.Forms

Public Class HcpLogin

    Private Sub hcpClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hcpCloseBtn.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub hcpLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hcpLoginBtn.Click
        'collect user text values
        Dim email = Me.txtHcpEmail.Text
        Dim password = Me.txtHcpPassword.Text

        If email.Trim() = "" Then
            notifyAlert.Show()
            alertMsg.Text = "    Please type your username!"
        ElseIf password.Trim() = "" Then
            notifyAlert.Show()
            alertMsg.Text = "    Please type your password!"
        Else
            'Then check logins verify from database
            If email = "doctor@curehealth.com" And password = "admin" Then
                'clear all fields data
                clearFiels()
                'hide self
                Me.Hide()
                'open welcome doctor panel
                DoctorPanel.Show()
                'hide notification
                notifyAlert.Hide()
            Else
                notifyAlert.Show()
                alertMsg.Text = "    Invalid login credentials!"
            End If

        End If
    End Sub

    Private Sub HcpLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtHcpEmail.Focus()
        Home.Hide()
    End Sub

    Private Sub clearFiels()
        Me.txtHcpEmail.Text = ""
        Me.txtHcpPassword.Text = ""
    End Sub
End Class
