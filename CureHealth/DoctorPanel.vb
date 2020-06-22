Public Class DoctorPanel

    Private Sub DoctorPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call sub to load data into data grid
        Me.LoadGrid()
    End Sub

    'SideBar Logout button
    Private Sub logoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Close()
        HcpLogin.Show()
    End Sub

    'SideBar Menu Navigation control buttons
    Private Sub menuAppoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAppointment.Click
        Me.AppointmentsPanel.Show()
        Me.AppointmentsPanel.BringToFront()
    End Sub

    Private Sub menuConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsult.Click
        Me.consultPanel.Show()
        Me.consultPanel.BringToFront()
    End Sub

    Private Sub menuReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuReports.Click
        Me.reportsPanel.Show()
        Me.reportsPanel.BringToFront()
    End Sub

    Private Sub menuDBBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDBBackup.Click
        Me.backupPanel.Show()
        Me.backupPanel.BringToFront()
    End Sub

    Private Sub menuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSettings.Click
        Me.settingsPanel.Show()
        Me.settingsPanel.BringToFront()
    End Sub

    'Cancel button controls on Panels
    Private Sub btnCancelAppoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAppoint.Click
        Me.AppointmentsPanel.Hide()
    End Sub

    Private Sub btnCancelConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelConsult.Click
        Me.consultPanel.Hide()
    End Sub

    Private Sub btnCancelReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelReport.Click
        Me.reportsPanel.Hide()
    End Sub

    Private Sub btnCancelBackups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBackups.Click
        Me.backupPanel.Hide()
    End Sub

    Private Sub cancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        settingsPanel.Hide()
        Me.clearFields()
    End Sub

    Private Sub LoadGrid()
        'Set Table headers
        Me.AppointmentViewGrid.ColumnCount = 8
        Me.AppointmentViewGrid.Columns(0).Name = "#ID"
        Me.AppointmentViewGrid.Columns(1).Name = "Firstname"
        Me.AppointmentViewGrid.Columns(2).Name = "Lastname"
        Me.AppointmentViewGrid.Columns(3).Name = "Gender"
        Me.AppointmentViewGrid.Columns(4).Name = "Date"
        Me.AppointmentViewGrid.Columns(5).Name = "Time"
        Me.AppointmentViewGrid.Columns(6).Name = "Telephone"
        Me.AppointmentViewGrid.Columns(6).Name = "Status"
        'Then table data rows
        Dim gridRow As String() = New String() {"9902026962081", "Lucky", "Molefe", "Male", "Thu, 2019 Apr 25", "08:00AM", "0821238656", "Seen"} 'data in first row, use loop to read more data

        For i As Integer = 1 To 5 'loop row 5 times
            'append data to grid view
            Me.AppointmentViewGrid.Rows.Add(gridRow)
        Next i
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim newPassword = Me.txtNewPassword.Text
        Dim confirmPassword = Me.txtConfirmPassword.Text

        If newPassword.Trim() = "" Then
            notifyAlert.Show()
            notifyAlert.ForeColor = Color.Red
            notifyAlert.BackColor = Color.Salmon
            lblAlertMsg.Text = "Please type your new password!."
        ElseIf confirmPassword = "" Then
            notifyAlert.Show()
            notifyAlert.ForeColor = Color.Red
            notifyAlert.BackColor = Color.Salmon
            lblAlertMsg.Text = "Please type to confirm new password!."
        ElseIf newPassword <> confirmPassword Then
            notifyAlert.Show()
            notifyAlert.ForeColor = Color.Red
            notifyAlert.BackColor = Color.Salmon
            lblAlertMsg.Text = "Your password do not match!."
        Else
            notifyAlert.Show()
            notifyAlert.ForeColor = Color.ForestGreen
            notifyAlert.BackColor = Color.LightGreen
            lblAlertMsg.Text = "Password update successfully!."
            Me.clearFields() 'reset fields
        End If
    End Sub

    Private Sub clearFields()
        Me.txtNewPassword.Text = ""
        Me.txtConfirmPassword.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
End Class