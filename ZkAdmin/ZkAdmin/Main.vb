Public Class Main
    Dim m1, m2 As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.TblMachine' table. You can move, or remove it, as needed.
        Try
            Me.TblMachineTableAdapter.Fill(Me.DS.TblMachine)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        showdata()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        showdata()
    End Sub

    Private Sub Radio1_CheckedChanged(sender As Object, e As EventArgs) Handles Radio1.CheckedChanged
        showdata()

    End Sub

    Private Sub Radio2_CheckedChanged(sender As Object, e As EventArgs) Handles Radio2.CheckedChanged
        showdata()

    End Sub

    Private Sub btn_seaerch_Click(sender As Object, e As EventArgs) Handles btn_seaerch.Click
        If Radio1.Checked Then
            GridControl2.ShowPrintPreview()

        Else
            GridControl3.ShowPrintPreview()
        End If

    End Sub

    Private Sub callEdituser()
        If String.IsNullOrEmpty(MachineIDTextBox1.Text) And String.IsNullOrEmpty(EnrollNumberTextBox.Text) Then
            ' MsgBox("You have To Select a User to Edit ")
        Else
            EditUser.Close()
            EditUser.ShowDialog()
            showdata()
        End If
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        callEdituser()
    End Sub
    Private Sub GridView2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridView2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            callEdituser()
        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        If String.IsNullOrEmpty(MachineIDTextBox.Text) Then
            ' MsgBox("You have To Select a User to Edit ")
        Else
            EditMachine.Close()
            EditMachine.ShowDialog()
            Me.TblMachineTableAdapter.Fill(Me.DS.TblMachine)
        End If
    End Sub



    Private Sub GridControl3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridControl3.KeyPress

    End Sub


    Private Sub GridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView3.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If Not (String.IsNullOrEmpty(tblIDTxt.Text)) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this record ?", "Confirmation", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        ' User clicked Yes, handle accordingly
                        Runsql($"delete TblLog where tblID={tblIDTxt.Text}")
                        showdata()
                        ' Add your code for 'Yes' action here
                    Else
                        ' User clicked No or closed the MessageBox, handle accordingly
                        ' MessageBox.Show("User clicked No or closed the MessageBox.")
                        ' Add your code for 'No' action here
                    End If


                End If
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.TblMachineTableAdapter.Fill(Me.DS.TblMachine)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = Val(Label3.Text) - 1
        If Val(Label3.Text <= 0) Then
            Label3.Text = 120
        End If

        If Val(Label3.Text) <= 10 Then
            Label3.ForeColor = Color.Green
        Else
            Label3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Runsql("update TblMachine set machineStatus=0")
    End Sub

    Private Sub showdata()
        Try

            If String.IsNullOrEmpty(MachineIDTextBox.Text) Then Exit Sub

            If Radio1.Checked Then
                GridControl2.Visible = True
                GridControl3.Visible = False

                If chkAll.Checked Then
                    Me.TblUsersTableAdapter.Fill(Me.DS.TblUsers, 0, 1000000)
                Else
                    Me.TblUsersTableAdapter.Fill(Me.DS.TblUsers, Val(MachineIDTextBox.Text), Val(MachineIDTextBox.Text))
                End If
            Else
                GridControl2.Visible = False
                GridControl3.Visible = True

                If chkAll.Checked Then
                    Me.V_AllTableAdapter.Fill(Me.DS.V_All, 0, 1000000)
                Else
                    Me.V_AllTableAdapter.Fill(Me.DS.V_All, Val(MachineIDTextBox.Text), Val(MachineIDTextBox.Text))
                End If
            End If


        Catch ex As Exception

        End Try



    End Sub


End Class
