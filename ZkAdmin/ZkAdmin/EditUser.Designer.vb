<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lab_Name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.but_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Lab_Name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 54)
        Me.Panel1.TabIndex = 0
        '
        'Lab_Name
        '
        Me.Lab_Name.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lab_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Lab_Name.Location = New System.Drawing.Point(0, 0)
        Me.Lab_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lab_Name.Name = "Lab_Name"
        Me.Lab_Name.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Lab_Name.Size = New System.Drawing.Size(345, 54)
        Me.Lab_Name.TabIndex = 32
        Me.Lab_Name.Text = "User Name "
        Me.Lab_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Label3.Size = New System.Drawing.Size(254, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hr System Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.but_cancel)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 212)
        Me.Panel2.TabIndex = 1
        '
        'but_cancel
        '
        Me.but_cancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.but_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.but_cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.but_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_cancel.ForeColor = System.Drawing.Color.Red
        Me.but_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_cancel.Location = New System.Drawing.Point(11, 141)
        Me.but_cancel.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.but_cancel.Name = "but_cancel"
        Me.but_cancel.Size = New System.Drawing.Size(113, 33)
        Me.but_cancel.TabIndex = 10
        Me.but_cancel.Text = "Cancel"
        Me.but_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.but_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Green
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(452, 141)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(113, 33)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(320, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 30)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hr System Code"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 245)
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
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(574, 266)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Lab_Name As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents but_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
End Class
