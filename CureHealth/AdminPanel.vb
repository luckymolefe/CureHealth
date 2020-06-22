Public Class AdminPanel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoutBtn.Click
        Me.Close()
        AdminLogin.Show()
    End Sub

    'Nevigation Menu buttons contols
    Private Sub menuAppointments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAppointments.Click
        LoadGrid()
        AppointmentsPanel.Show()
        AppointmentsPanel.BringToFront()
    End Sub

    Private Sub menuAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAddNew.Click
        Me.addNewPanel.Show()
        Me.addNewPanel.BringToFront()
    End Sub

    Private Sub menuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuView.Click
        loadPatientFile()
        viewFilePanel.Show()
        viewFilePanel.BringToFront()
    End Sub

    Private Sub menuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSettings.Click
        settingsPanel.Show()
        settingsPanel.BringToFront()
    End Sub

    'Cancel buttons control panels visibility
    Private Sub btnCancelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAdd.Click
        Me.addNewPanel.Hide()
    End Sub

    Private Sub btnCloseSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseSettings.Click
        settingsPanel.Hide()
        settingsPanel.SendToBack()
    End Sub

    Private Sub btnCloseView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseView.Click
        AppointmentsPanel.Hide()
        AppointmentsPanel.SendToBack()
    End Sub

    Private Sub btnCloseViewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseViewFile.Click
        viewFilePanel.Hide()
        viewFilePanel.SendToBack()
    End Sub

    Private Sub btnCloseCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseCalendar.Click
        calendarPanel.SendToBack()
        calendarPanel.Hide()
    End Sub

    'Save data buttons
    Private Sub btnPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassword.Click
        passwordGroup.Show()
        passwordGroup.BringToFront()
    End Sub

    Private Sub btnSavePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePassword.Click
        Dim password = txtNewPassword.Text()
        Dim passwordConfirm = txtPasswordConfirm.Text()
        lblAlertError.Hide()
        lblAlertSuccess.Hide()
        If password = "" And passwordConfirm = "" Then
            lblAlertError.Show()
            lblAlertError.BringToFront()
        ElseIf password <> passwordConfirm Then
            lblAlertError.Show()
            lblAlertError.BringToFront()
            lblAlertError.Text = "Your password do not match!"
        Else
            'After saving password to Database
            lblAlertSuccess.Show()
            lblAlertSuccess.BringToFront()
        End If
    End Sub

    Private Sub LoadGrid()
        'Set Table headers
        Me.AppointmentsGridView.ColumnCount = 8
        Me.AppointmentsGridView.Columns(0).Name = "#ID"
        Me.AppointmentsGridView.Columns(1).Name = "Firstname"
        Me.AppointmentsGridView.Columns(2).Name = "Lastname"
        Me.AppointmentsGridView.Columns(3).Name = "Gender"
        Me.AppointmentsGridView.Columns(4).Name = "Date"
        Me.AppointmentsGridView.Columns(5).Name = "Time"
        Me.AppointmentsGridView.Columns(6).Name = "Telephone"
        Me.AppointmentsGridView.Columns(7).Name = "Status"
        'Then table data rows
        Dim gridRow As String() = New String() {"9902026962081", "Lucky", "Molefe", "Male", "Thu, 2019 Apr 25", "08:00AM", "0821238656", "Seen"} 'data in first row, use loop to read more data

        For i As Integer = 1 To 5 'loop row 5 times
            'append data to grid view
            Me.AppointmentsGridView.Rows.Add(gridRow)
        Next i
    End Sub

    Private Sub loadPatientFile()
        Me.patientFileGridView.ColumnCount = 7
        Me.patientFileGridView.Columns(0).Name = "#ID"
        Me.patientFileGridView.Columns(1).Name = "Firstname"
        Me.patientFileGridView.Columns(2).Name = "Lastname"
        Me.patientFileGridView.Columns(3).Name = "Gender"
        Me.patientFileGridView.Columns(4).Name = "Telephone"
        Me.patientFileGridView.Columns(5).Name = "Email"
        Me.patientFileGridView.Columns(6).Name = "Address"
        'Then table data rows
        Dim gridRow As String() = New String() {"9902026962081", "Lucky", "Molefe", "Male", "0821238656", "luckmolf@company.com", "123 Street, City, Code"} 'data in first row, use loop to read more data

        For i As Integer = 1 To 5 'loop row 5 times
            'append data to grid view
            Me.patientFileGridView.Rows.Add(gridRow)
        Next i
    End Sub

    Private Sub btnCreateAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateAppointment.Click
        calendarPanel.Show()
        calendarPanel.BringToFront()
    End Sub

    
End Class