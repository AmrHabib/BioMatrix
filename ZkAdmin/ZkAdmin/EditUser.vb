Public Class EditUser
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lab_Name.Text = Main.UserNameTextBox.Text
        TextBox1.Text = Main.HRCODETextBox.Text
        Label3.Text = Main.MachineLocationTextBox.Text
    End Sub

    Private Sub but_cancel_Click(sender As Object, e As EventArgs) Handles but_cancel.Click
        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        save()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            save()
        End If
    End Sub

    Private Sub save()
        If IsNumeric(TextBox1.Text) Then
            Runsql($"update TblUsers set HRCODE={TextBox1.Text } where (machineID={Main.MachineIDTextBox1.Text } and enrollNumber={Main.EnrollNumberTextBox.Text })")
            Close()
        Else
            MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub EditUser_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' Close the form
            Me.Close()
        End If
    End Sub

End Class