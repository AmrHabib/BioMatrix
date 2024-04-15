Public Class EditMachine
    Dim value_changed As Boolean = False


    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lab_Machine_serial.Text = Main.MachineSerialTextBox.Text

        txt_machineLocation.Text = Main.MachineLocationTextBox1.Text

        MillisecondsNo.Text = Val(Main.MillisecondsTextBox.Text) / 60000

        machID = Val(Main.MachineIDTextBox.Text)


    End Sub

    Private Sub but_cancel_Click(sender As Object, e As EventArgs) Handles but_cancel.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        save()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_machineLocation.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            save()
        End If
    End Sub
    Private Sub MillisecondsNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MillisecondsNo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            save()
        End If
    End Sub
    Private Sub EditUser_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' Close the form
            Me.Close()
        End If
    End Sub
    Private Sub txt_machineLocation_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_machineLocation.KeyDown, MillisecondsNo.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' Close the form
            Me.Close()
        End If
    End Sub

    Private Sub save()
        Try

            If Not (String.IsNullOrEmpty(txt_machineLocation.Text)) Then
                Dim int_milliseconds = MillisecondsNo.Value * 60000
                Dim value_changed_chk = 0

                If value_changed Then
                    value_changed_chk = 1
                End If

                Runsql($"update TblMachine set machineLocation='{txt_machineLocation.Text}', Milliseconds={int_milliseconds},changeMilliseconds={value_changed_chk} where machineID= {machID} ")

                value_changed_chk = 0

                Close()
            Else
                MessageBox.Show("Please enter a valid Location.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub bt_RequestData_Click(sender As Object, e As EventArgs) Handles bt_RequestData.Click
        Try

            Runsql($"update TblMachine set RequestData=1 where machineID={machID}")
            MessageBox.Show("The request has been sent to the device.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Timer_RequestData.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bt_getUserData_Click(sender As Object, e As EventArgs) Handles bt_getUserData.Click
        Try

            Runsql($"update TblMachine set getUserData=1 where machineID={machID}")
            MessageBox.Show("The request has been sent to the device.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Timer_getUserData.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bt_clearOld_Click(sender As Object, e As EventArgs) Handles bt_clearOld.Click
        Try
            Runsql($"update TblMachine set clearOld=1 where machineID={machID}")
            MessageBox.Show("The request has been sent to the device.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Timer_clearOld.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer_RequestData_Tick(sender As Object, e As EventArgs) Handles Timer_RequestData.Tick

        Try


            Dim val = Runsql($"select RequestDataDone from TblMachine where machineID={machID }")

            If val = 1 Then
                MessageBox.Show("Attendance records downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Runsql($"update TblMachine set RequestDataDone=0 ,RequestData=0 where machineID={machID}")
            End If

            Timer_RequestData.Enabled = False

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Timer_getUserData_Tick(sender As Object, e As EventArgs) Handles Timer_getUserData.Tick

        Try

            Dim val = Runsql($"select getUserData from TblMachine where machineID={machID}")

            If val = 1 Then
                MessageBox.Show("User Directory downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Runsql($"update TblMachine set getUserDataDone=0 ,getUserData=0 where machineID={machID}")
            End If

            Timer_getUserData.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer_clearOld_Tick(sender As Object, e As EventArgs) Handles Timer_clearOld.Tick
        Try
            Dim val = Runsql($"select clearOld from TblMachine where machineID={machID}")

            If val = 1 Then
                MessageBox.Show("Optimize device storage done successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Runsql($"update TblMachine set clearOldDone=0 ,clearOld=0 where machineID={machID}")
            End If

            Timer_getUserData.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub MillisecondsNo_ValueChanged(sender As Object, e As EventArgs) Handles MillisecondsNo.ValueChanged
        value_changed = True
    End Sub


    Private Sub EditMachine_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Timer_getUserData.Enabled = False

    End Sub
End Class