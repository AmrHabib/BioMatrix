<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lab_Machine_serial = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MillisecondsNo = New System.Windows.Forms.NumericUpDown()
        Me.bt_clearOld = New System.Windows.Forms.Button()
        Me.bt_getUserData = New System.Windows.Forms.Button()
        Me.bt_RequestData = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.but_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_machineLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer_RequestData = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_getUserData = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_clearOld = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MillisecondsNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Lab_Machine_serial)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 54)
        Me.Panel1.TabIndex = 0
        '
        'Lab_Machine_serial
        '
        Me.Lab_Machine_serial.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lab_Machine_serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Machine_serial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Lab_Machine_serial.Location = New System.Drawing.Point(0, 0)
        Me.Lab_Machine_serial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lab_Machine_serial.Name = "Lab_Machine_serial"
        Me.Lab_Machine_serial.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Lab_Machine_serial.Size = New System.Drawing.Size(434, 54)
        Me.Lab_Machine_serial.TabIndex = 32
        Me.Lab_Machine_serial.Text = "User Name "
        Me.Lab_Machine_serial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.MillisecondsNo)
        Me.Panel2.Controls.Add(Me.bt_clearOld)
        Me.Panel2.Controls.Add(Me.bt_getUserData)
        Me.Panel2.Controls.Add(Me.bt_RequestData)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.but_cancel)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.txt_machineLocation)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 295)
        Me.Panel2.TabIndex = 1
        '
        'MillisecondsNo
        '
        Me.MillisecondsNo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MillisecondsNo.Location = New System.Drawing.Point(204, 53)
        Me.MillisecondsNo.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MillisecondsNo.Name = "MillisecondsNo"
        Me.MillisecondsNo.Size = New System.Drawing.Size(111, 30)
        Me.MillisecondsNo.TabIndex = 1
        Me.MillisecondsNo.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'bt_clearOld
        '
        Me.bt_clearOld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_clearOld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_clearOld.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_clearOld.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.bt_clearOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_clearOld.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_clearOld.ForeColor = System.Drawing.Color.Green
        Me.bt_clearOld.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_clearOld.Location = New System.Drawing.Point(393, 111)
        Me.bt_clearOld.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.bt_clearOld.Name = "bt_clearOld"
        Me.bt_clearOld.Size = New System.Drawing.Size(156, 61)
        Me.bt_clearOld.TabIndex = 4
        Me.bt_clearOld.Text = "Optimize " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Device storage"
        Me.bt_clearOld.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bt_clearOld.UseVisualStyleBackColor = True
        '
        'bt_getUserData
        '
        Me.bt_getUserData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_getUserData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_getUserData.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_getUserData.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.bt_getUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_getUserData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_getUserData.ForeColor = System.Drawing.Color.Green
        Me.bt_getUserData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_getUserData.Location = New System.Drawing.Point(211, 111)
        Me.bt_getUserData.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.bt_getUserData.Name = "bt_getUserData"
        Me.bt_getUserData.Size = New System.Drawing.Size(156, 61)
        Me.bt_getUserData.TabIndex = 3
        Me.bt_getUserData.Text = "Download  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User Directory"
        Me.bt_getUserData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bt_getUserData.UseVisualStyleBackColor = True
        '
        'bt_RequestData
        '
        Me.bt_RequestData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_RequestData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bt_RequestData.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_RequestData.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.bt_RequestData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_RequestData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_RequestData.ForeColor = System.Drawing.Color.Green
        Me.bt_RequestData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_RequestData.Location = New System.Drawing.Point(26, 111)
        Me.bt_RequestData.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.bt_RequestData.Name = "bt_RequestData"
        Me.bt_RequestData.Size = New System.Drawing.Size(156, 61)
        Me.bt_RequestData.TabIndex = 2
        Me.bt_RequestData.Text = "Download Attendance Records"
        Me.bt_RequestData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bt_RequestData.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(41, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Download Every Min.:"
        '
        'but_cancel
        '
        Me.but_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.but_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.but_cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.but_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_cancel.ForeColor = System.Drawing.Color.Red
        Me.but_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_cancel.Location = New System.Drawing.Point(11, 228)
        Me.but_cancel.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.but_cancel.Name = "but_cancel"
        Me.but_cancel.Size = New System.Drawing.Size(113, 33)
        Me.but_cancel.TabIndex = 5
        Me.but_cancel.Text = "Cancel"
        Me.but_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.but_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Green
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(452, 228)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(113, 33)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_machineLocation
        '
        Me.txt_machineLocation.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_machineLocation.Location = New System.Drawing.Point(202, 10)
        Me.txt_machineLocation.Name = "txt_machineLocation"
        Me.txt_machineLocation.Size = New System.Drawing.Size(181, 30)
        Me.txt_machineLocation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(41, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Machine Location"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 328)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(574, 21)
        Me.Panel4.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "All Rights reserved To Amr Habib "
        '
        'Timer_RequestData
        '
        Me.Timer_RequestData.Interval = 120000
        '
        'Timer_getUserData
        '
        Me.Timer_getUserData.Interval = 120000
        '
        'Timer_clearOld
        '
        Me.Timer_clearOld.Interval = 120000
        '
        'EditMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(574, 349)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Machine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MillisecondsNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Lab_Machine_serial As Label
    Friend WithEvents txt_machineLocation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents but_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents bt_RequestData As Button
    Friend WithEvents bt_getUserData As Button
    Friend WithEvents MillisecondsNo As NumericUpDown
    Friend WithEvents bt_clearOld As Button
    Friend WithEvents Timer_RequestData As Timer
    Friend WithEvents Timer_getUserData As Timer
    Friend WithEvents Timer_clearOld As Timer
End Class
