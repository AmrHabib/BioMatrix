<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim MachineIDLabel As System.Windows.Forms.Label
        Dim EnrollNumberLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim MachineLocationLabel As System.Windows.Forms.Label
        Dim HRCODELabel As System.Windows.Forms.Label
        Dim MillisecondsLabel As System.Windows.Forms.Label
        Dim MachineSerialLabel As System.Windows.Forms.Label
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colmachineStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmachineLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.VAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New ZkAdmin.DS()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colmachineID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmachineLocation2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colenrollNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluserName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltimeRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldatetimeRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheckInOutName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHRCODE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.TblUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colmachineID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colenrollNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHRCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmachineLocation1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TblMachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colmachineID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmachineSerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TblMachineTableAdapter = New ZkAdmin.DSTableAdapters.TblMachineTableAdapter()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tblIDTxt = New System.Windows.Forms.TextBox()
        Me.MachineSerialTextBox = New System.Windows.Forms.TextBox()
        Me.MillisecondsTextBox = New System.Windows.Forms.TextBox()
        Me.MachineLocationTextBox1 = New System.Windows.Forms.TextBox()
        Me.HRCODETextBox = New System.Windows.Forms.TextBox()
        Me.MachineLocationTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.EnrollNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MachineIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.MachineIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.Radio2 = New System.Windows.Forms.RadioButton()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_seaerch = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New ZkAdmin.DSTableAdapters.TableAdapterManager()
        Me.TblUsersTableAdapter = New ZkAdmin.DSTableAdapters.TblUsersTableAdapter()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.V_AllTableAdapter = New ZkAdmin.DSTableAdapters.V_AllTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        MachineIDLabel = New System.Windows.Forms.Label()
        EnrollNumberLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        MachineLocationLabel = New System.Windows.Forms.Label()
        HRCODELabel = New System.Windows.Forms.Label()
        MillisecondsLabel = New System.Windows.Forms.Label()
        MachineSerialLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MachineIDLabel
        '
        MachineIDLabel.AutoSize = True
        MachineIDLabel.Location = New System.Drawing.Point(404, 380)
        MachineIDLabel.Name = "MachineIDLabel"
        MachineIDLabel.Size = New System.Drawing.Size(64, 13)
        MachineIDLabel.TabIndex = 36
        MachineIDLabel.Text = "machine ID:"
        '
        'EnrollNumberLabel
        '
        EnrollNumberLabel.AutoSize = True
        EnrollNumberLabel.Location = New System.Drawing.Point(391, 406)
        EnrollNumberLabel.Name = "EnrollNumberLabel"
        EnrollNumberLabel.Size = New System.Drawing.Size(77, 13)
        EnrollNumberLabel.TabIndex = 37
        EnrollNumberLabel.Text = "enroll Number:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(406, 432)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(62, 13)
        UserNameLabel.TabIndex = 38
        UserNameLabel.Text = "user Name:"
        '
        'MachineLocationLabel
        '
        MachineLocationLabel.AutoSize = True
        MachineLocationLabel.Location = New System.Drawing.Point(375, 458)
        MachineLocationLabel.Name = "MachineLocationLabel"
        MachineLocationLabel.Size = New System.Drawing.Size(93, 13)
        MachineLocationLabel.TabIndex = 39
        MachineLocationLabel.Text = "machine Location:"
        '
        'HRCODELabel
        '
        HRCODELabel.AutoSize = True
        HRCODELabel.Location = New System.Drawing.Point(415, 484)
        HRCODELabel.Name = "HRCODELabel"
        HRCODELabel.Size = New System.Drawing.Size(53, 13)
        HRCODELabel.TabIndex = 40
        HRCODELabel.Text = "HRCODE:"
        '
        'MillisecondsLabel
        '
        MillisecondsLabel.AutoSize = True
        MillisecondsLabel.Location = New System.Drawing.Point(402, 302)
        MillisecondsLabel.Name = "MillisecondsLabel"
        MillisecondsLabel.Size = New System.Drawing.Size(66, 13)
        MillisecondsLabel.TabIndex = 42
        MillisecondsLabel.Text = "Milliseconds:"
        '
        'MachineSerialLabel
        '
        MachineSerialLabel.AutoSize = True
        MachineSerialLabel.Location = New System.Drawing.Point(389, 276)
        MachineSerialLabel.Name = "MachineSerialLabel"
        MachineSerialLabel.Size = New System.Drawing.Size(79, 13)
        MachineSerialLabel.TabIndex = 43
        MachineSerialLabel.Text = "machine Serial:"
        '
        'colmachineStatus
        '
        Me.colmachineStatus.FieldName = "machineStatus"
        Me.colmachineStatus.Name = "colmachineStatus"
        '
        'colmachineLocation
        '
        Me.colmachineLocation.Caption = "Location"
        Me.colmachineLocation.FieldName = "machineLocation"
        Me.colmachineLocation.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colmachineLocation.Name = "colmachineLocation"
        Me.colmachineLocation.Visible = True
        Me.colmachineLocation.VisibleIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 114)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1132, 429)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1126, 396)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridControl3)
        Me.Panel3.Controls.Add(Me.GridControl2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(295, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(831, 396)
        Me.Panel3.TabIndex = 5
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.VAllBindingSource
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(831, 396)
        Me.GridControl3.TabIndex = 2
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'VAllBindingSource
        '
        Me.VAllBindingSource.DataMember = "V_All"
        Me.VAllBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmachineID2, Me.colmachineLocation2, Me.colenrollNumber1, Me.coluserName1, Me.coldateRecord, Me.coltimeRecord, Me.coldatetimeRecord, Me.colCheckInOutName, Me.colHRCODE1})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        '
        'colmachineID2
        '
        Me.colmachineID2.AppearanceCell.Options.UseTextOptions = True
        Me.colmachineID2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colmachineID2.Caption = "Machine Id"
        Me.colmachineID2.FieldName = "machineID"
        Me.colmachineID2.Name = "colmachineID2"
        Me.colmachineID2.OptionsColumn.FixedWidth = True
        Me.colmachineID2.Visible = True
        Me.colmachineID2.VisibleIndex = 0
        '
        'colmachineLocation2
        '
        Me.colmachineLocation2.Caption = "Location"
        Me.colmachineLocation2.FieldName = "machineLocation"
        Me.colmachineLocation2.Name = "colmachineLocation2"
        Me.colmachineLocation2.OptionsColumn.FixedWidth = True
        Me.colmachineLocation2.Visible = True
        Me.colmachineLocation2.VisibleIndex = 1
        '
        'colenrollNumber1
        '
        Me.colenrollNumber1.AppearanceCell.Options.UseTextOptions = True
        Me.colenrollNumber1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colenrollNumber1.Caption = "Enroll Number"
        Me.colenrollNumber1.FieldName = "enrollNumber"
        Me.colenrollNumber1.Name = "colenrollNumber1"
        Me.colenrollNumber1.OptionsColumn.FixedWidth = True
        Me.colenrollNumber1.Visible = True
        Me.colenrollNumber1.VisibleIndex = 2
        Me.colenrollNumber1.Width = 82
        '
        'coluserName1
        '
        Me.coluserName1.AppearanceCell.Options.UseTextOptions = True
        Me.coluserName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.coluserName1.Caption = "Name"
        Me.coluserName1.FieldName = "userName"
        Me.coluserName1.Name = "coluserName1"
        Me.coluserName1.Visible = True
        Me.coluserName1.VisibleIndex = 3
        Me.coluserName1.Width = 66
        '
        'coldateRecord
        '
        Me.coldateRecord.AppearanceCell.Options.UseTextOptions = True
        Me.coldateRecord.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldateRecord.AppearanceHeader.Options.UseTextOptions = True
        Me.coldateRecord.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldateRecord.Caption = "Date"
        Me.coldateRecord.FieldName = "dateRecord"
        Me.coldateRecord.Name = "coldateRecord"
        Me.coldateRecord.Visible = True
        Me.coldateRecord.VisibleIndex = 4
        Me.coldateRecord.Width = 66
        '
        'coltimeRecord
        '
        Me.coltimeRecord.AppearanceCell.Options.UseTextOptions = True
        Me.coltimeRecord.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltimeRecord.AppearanceHeader.Options.UseTextOptions = True
        Me.coltimeRecord.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltimeRecord.Caption = "Time"
        Me.coltimeRecord.FieldName = "timeRecord"
        Me.coltimeRecord.Name = "coltimeRecord"
        Me.coltimeRecord.Visible = True
        Me.coltimeRecord.VisibleIndex = 5
        Me.coltimeRecord.Width = 66
        '
        'coldatetimeRecord
        '
        Me.coldatetimeRecord.AppearanceCell.Options.UseTextOptions = True
        Me.coldatetimeRecord.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldatetimeRecord.AppearanceHeader.Options.UseTextOptions = True
        Me.coldatetimeRecord.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldatetimeRecord.Caption = "DateTime"
        Me.coldatetimeRecord.FieldName = "datetimeRecord"
        Me.coldatetimeRecord.Name = "coldatetimeRecord"
        Me.coldatetimeRecord.Visible = True
        Me.coldatetimeRecord.VisibleIndex = 6
        Me.coldatetimeRecord.Width = 66
        '
        'colCheckInOutName
        '
        Me.colCheckInOutName.AppearanceCell.Options.UseTextOptions = True
        Me.colCheckInOutName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheckInOutName.AppearanceHeader.Options.UseTextOptions = True
        Me.colCheckInOutName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheckInOutName.Caption = "Check In/Out"
        Me.colCheckInOutName.FieldName = "CheckInOutName"
        Me.colCheckInOutName.Name = "colCheckInOutName"
        Me.colCheckInOutName.Visible = True
        Me.colCheckInOutName.VisibleIndex = 7
        Me.colCheckInOutName.Width = 66
        '
        'colHRCODE1
        '
        Me.colHRCODE1.AppearanceCell.Options.UseTextOptions = True
        Me.colHRCODE1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colHRCODE1.AppearanceHeader.Options.UseTextOptions = True
        Me.colHRCODE1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colHRCODE1.Caption = "Hr System Code"
        Me.colHRCODE1.FieldName = "HRCODE"
        Me.colHRCODE1.Name = "colHRCODE1"
        Me.colHRCODE1.Visible = True
        Me.colHRCODE1.VisibleIndex = 8
        Me.colHRCODE1.Width = 77
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.TblUsersBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(831, 396)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'TblUsersBindingSource
        '
        Me.TblUsersBindingSource.DataMember = "TblUsers"
        Me.TblUsersBindingSource.DataSource = Me.DS
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmachineID1, Me.colenrollNumber, Me.coluserName, Me.colHRCODE, Me.colmachineLocation1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        '
        'colmachineID1
        '
        Me.colmachineID1.AppearanceCell.Options.UseTextOptions = True
        Me.colmachineID1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colmachineID1.Caption = "Machine ID"
        Me.colmachineID1.FieldName = "machineID"
        Me.colmachineID1.Name = "colmachineID1"
        Me.colmachineID1.OptionsColumn.FixedWidth = True
        Me.colmachineID1.Visible = True
        Me.colmachineID1.VisibleIndex = 0
        Me.colmachineID1.Width = 64
        '
        'colenrollNumber
        '
        Me.colenrollNumber.AppearanceCell.Options.UseTextOptions = True
        Me.colenrollNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colenrollNumber.Caption = "Enroll Number"
        Me.colenrollNumber.FieldName = "enrollNumber"
        Me.colenrollNumber.Name = "colenrollNumber"
        Me.colenrollNumber.OptionsColumn.FixedWidth = True
        Me.colenrollNumber.Visible = True
        Me.colenrollNumber.VisibleIndex = 2
        Me.colenrollNumber.Width = 89
        '
        'coluserName
        '
        Me.coluserName.AppearanceCell.Options.UseTextOptions = True
        Me.coluserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.coluserName.Caption = "Name"
        Me.coluserName.FieldName = "userName"
        Me.coluserName.Name = "coluserName"
        Me.coluserName.Visible = True
        Me.coluserName.VisibleIndex = 3
        Me.coluserName.Width = 182
        '
        'colHRCODE
        '
        Me.colHRCODE.AppearanceCell.Options.UseTextOptions = True
        Me.colHRCODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colHRCODE.Caption = "Hr System Code"
        Me.colHRCODE.FieldName = "HRCODE"
        Me.colHRCODE.Name = "colHRCODE"
        Me.colHRCODE.Visible = True
        Me.colHRCODE.VisibleIndex = 4
        Me.colHRCODE.Width = 104
        '
        'colmachineLocation1
        '
        Me.colmachineLocation1.AppearanceCell.Options.UseTextOptions = True
        Me.colmachineLocation1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colmachineLocation1.Caption = "Location"
        Me.colmachineLocation1.FieldName = "machineLocation"
        Me.colmachineLocation1.Name = "colmachineLocation1"
        Me.colmachineLocation1.OptionsColumn.FixedWidth = True
        Me.colmachineLocation1.Visible = True
        Me.colmachineLocation1.VisibleIndex = 1
        Me.colmachineLocation1.Width = 113
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Location = New System.Drawing.Point(290, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 396)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 396)
        Me.Panel2.TabIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TblMachineBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(290, 396)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TblMachineBindingSource
        '
        Me.TblMachineBindingSource.DataMember = "TblMachine"
        Me.TblMachineBindingSource.DataSource = Me.DS
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmachineID, Me.colmachineLocation, Me.colmachineSerial, Me.colmachineStatus})
        GridFormatRule1.Column = Me.colmachineStatus
        GridFormatRule1.ColumnApplyTo = Me.colmachineLocation
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colmachineStatus
        GridFormatRule2.ColumnApplyTo = Me.colmachineLocation
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = False
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colmachineID
        '
        Me.colmachineID.AppearanceCell.Options.UseTextOptions = True
        Me.colmachineID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colmachineID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colmachineID.Caption = "Machine ID"
        Me.colmachineID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colmachineID.FieldName = "machineID"
        Me.colmachineID.Name = "colmachineID"
        Me.colmachineID.OptionsColumn.FixedWidth = True
        Me.colmachineID.Visible = True
        Me.colmachineID.VisibleIndex = 0
        '
        'colmachineSerial
        '
        Me.colmachineSerial.Caption = "Serial No."
        Me.colmachineSerial.FieldName = "machineSerial"
        Me.colmachineSerial.Name = "colmachineSerial"
        Me.colmachineSerial.Visible = True
        Me.colmachineSerial.VisibleIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 405)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1126, 21)
        Me.Panel4.TabIndex = 1
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
        'TblMachineTableAdapter
        '
        Me.TblMachineTableAdapter.ClearBeforeFill = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(MachineSerialLabel)
        Me.Panel5.Controls.Add(Me.tblIDTxt)
        Me.Panel5.Controls.Add(Me.MachineSerialTextBox)
        Me.Panel5.Controls.Add(MillisecondsLabel)
        Me.Panel5.Controls.Add(Me.MillisecondsTextBox)
        Me.Panel5.Controls.Add(Me.MachineLocationTextBox1)
        Me.Panel5.Controls.Add(HRCODELabel)
        Me.Panel5.Controls.Add(Me.HRCODETextBox)
        Me.Panel5.Controls.Add(MachineLocationLabel)
        Me.Panel5.Controls.Add(Me.MachineLocationTextBox)
        Me.Panel5.Controls.Add(UserNameLabel)
        Me.Panel5.Controls.Add(Me.UserNameTextBox)
        Me.Panel5.Controls.Add(EnrollNumberLabel)
        Me.Panel5.Controls.Add(Me.EnrollNumberTextBox)
        Me.Panel5.Controls.Add(MachineIDLabel)
        Me.Panel5.Controls.Add(Me.MachineIDTextBox1)
        Me.Panel5.Controls.Add(Me.MachineIDTextBox)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Radio1)
        Me.Panel5.Controls.Add(Me.Radio2)
        Me.Panel5.Controls.Add(Me.chkAll)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1132, 114)
        Me.Panel5.TabIndex = 1
        '
        'tblIDTxt
        '
        Me.tblIDTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VAllBindingSource, "tblID", True))
        Me.tblIDTxt.Location = New System.Drawing.Point(474, 247)
        Me.tblIDTxt.Name = "tblIDTxt"
        Me.tblIDTxt.Size = New System.Drawing.Size(100, 20)
        Me.tblIDTxt.TabIndex = 44
        Me.tblIDTxt.TabStop = False
        '
        'MachineSerialTextBox
        '
        Me.MachineSerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMachineBindingSource, "machineSerial", True))
        Me.MachineSerialTextBox.Location = New System.Drawing.Point(474, 273)
        Me.MachineSerialTextBox.Name = "MachineSerialTextBox"
        Me.MachineSerialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MachineSerialTextBox.TabIndex = 44
        Me.MachineSerialTextBox.TabStop = False
        '
        'MillisecondsTextBox
        '
        Me.MillisecondsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMachineBindingSource, "Milliseconds", True))
        Me.MillisecondsTextBox.Location = New System.Drawing.Point(474, 299)
        Me.MillisecondsTextBox.Name = "MillisecondsTextBox"
        Me.MillisecondsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MillisecondsTextBox.TabIndex = 43
        Me.MillisecondsTextBox.TabStop = False
        '
        'MachineLocationTextBox1
        '
        Me.MachineLocationTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMachineBindingSource, "machineLocation", True))
        Me.MachineLocationTextBox1.Location = New System.Drawing.Point(474, 325)
        Me.MachineLocationTextBox1.Name = "MachineLocationTextBox1"
        Me.MachineLocationTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MachineLocationTextBox1.TabIndex = 42
        Me.MachineLocationTextBox1.TabStop = False
        '
        'HRCODETextBox
        '
        Me.HRCODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "HRCODE", True))
        Me.HRCODETextBox.Location = New System.Drawing.Point(474, 481)
        Me.HRCODETextBox.Name = "HRCODETextBox"
        Me.HRCODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.HRCODETextBox.TabIndex = 41
        Me.HRCODETextBox.TabStop = False
        '
        'MachineLocationTextBox
        '
        Me.MachineLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "machineLocation", True))
        Me.MachineLocationTextBox.Location = New System.Drawing.Point(474, 455)
        Me.MachineLocationTextBox.Name = "MachineLocationTextBox"
        Me.MachineLocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MachineLocationTextBox.TabIndex = 40
        Me.MachineLocationTextBox.TabStop = False
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "userName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(474, 429)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 39
        Me.UserNameTextBox.TabStop = False
        '
        'EnrollNumberTextBox
        '
        Me.EnrollNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "enrollNumber", True))
        Me.EnrollNumberTextBox.Location = New System.Drawing.Point(474, 403)
        Me.EnrollNumberTextBox.Name = "EnrollNumberTextBox"
        Me.EnrollNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnrollNumberTextBox.TabIndex = 38
        Me.EnrollNumberTextBox.TabStop = False
        '
        'MachineIDTextBox1
        '
        Me.MachineIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "machineID", True))
        Me.MachineIDTextBox1.Location = New System.Drawing.Point(474, 377)
        Me.MachineIDTextBox1.Name = "MachineIDTextBox1"
        Me.MachineIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MachineIDTextBox1.TabIndex = 37
        Me.MachineIDTextBox1.TabStop = False
        '
        'MachineIDTextBox
        '
        Me.MachineIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMachineBindingSource, "machineID", True))
        Me.MachineIDTextBox.Location = New System.Drawing.Point(474, 351)
        Me.MachineIDTextBox.Name = "MachineIDTextBox"
        Me.MachineIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MachineIDTextBox.TabIndex = 32
        Me.MachineIDTextBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 81)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = " Optimize Machine Configuration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Radio1
        '
        Me.Radio1.AutoSize = True
        Me.Radio1.Checked = True
        Me.Radio1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Radio1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Radio1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Radio1.Location = New System.Drawing.Point(789, 0)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(107, 81)
        Me.Radio1.TabIndex = 34
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "User Directory"
        Me.Radio1.UseVisualStyleBackColor = True
        '
        'Radio2
        '
        Me.Radio2.AutoSize = True
        Me.Radio2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Radio2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Radio2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Radio2.Location = New System.Drawing.Point(896, 0)
        Me.Radio2.Name = "Radio2"
        Me.Radio2.Size = New System.Drawing.Size(140, 81)
        Me.Radio2.TabIndex = 35
        Me.Radio2.Text = "Attendance Records"
        Me.Radio2.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.chkAll.Location = New System.Drawing.Point(1036, 0)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(96, 81)
        Me.chkAll.TabIndex = 33
        Me.chkAll.Text = "All Machines"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.btn_seaerch)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 81)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Panel6.Size = New System.Drawing.Size(1132, 33)
        Me.Panel6.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "120"
        '
        'btn_seaerch
        '
        Me.btn_seaerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_seaerch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_seaerch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_seaerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seaerch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seaerch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btn_seaerch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seaerch.Location = New System.Drawing.Point(1009, 0)
        Me.btn_seaerch.Margin = New System.Windows.Forms.Padding(2, 2, 50, 2)
        Me.btn_seaerch.Name = "btn_seaerch"
        Me.btn_seaerch.Size = New System.Drawing.Size(113, 33)
        Me.btn_seaerch.TabIndex = 9
        Me.btn_seaerch.Text = "Print"
        Me.btn_seaerch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_seaerch.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TblMachineTableAdapter = Me.TblMachineTableAdapter
        Me.TableAdapterManager.UpdateOrder = ZkAdmin.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblUsersTableAdapter
        '
        Me.TblUsersTableAdapter.ClearBeforeFill = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "enrollNumber"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 123
        '
        'V_AllTableAdapter
        '
        Me.V_AllTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 360000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 543)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "Main"
        Me.Text = "Zk Admin "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DS As DS
    Friend WithEvents TblMachineBindingSource As BindingSource
    Friend WithEvents TblMachineTableAdapter As DSTableAdapters.TblMachineTableAdapter
    Friend WithEvents colmachineID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmachineLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmachineSerial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MachineIDTextBox As TextBox
    Friend WithEvents TableAdapterManager As DSTableAdapters.TableAdapterManager
    Friend WithEvents TblUsersBindingSource As BindingSource
    Friend WithEvents colmachineID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colenrollNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHRCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmachineLocation1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TblUsersTableAdapter As DSTableAdapters.TblUsersTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Radio2 As RadioButton
    Friend WithEvents Radio1 As RadioButton
    Friend WithEvents VAllBindingSource As BindingSource
    Friend WithEvents colmachineID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colenrollNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluserName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltimeRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldatetimeRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckInOutName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHRCODE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents V_AllTableAdapter As DSTableAdapters.V_AllTableAdapter
    Friend WithEvents colmachineLocation2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_seaerch As Button
    Friend WithEvents EnrollNumberTextBox As TextBox
    Friend WithEvents MachineIDTextBox1 As TextBox
    Friend WithEvents MachineLocationTextBox As TextBox
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents HRCODETextBox As TextBox
    Friend WithEvents MachineLocationTextBox1 As TextBox
    Friend WithEvents MillisecondsTextBox As TextBox
    Friend WithEvents MachineSerialTextBox As TextBox
    Friend WithEvents tblIDTxt As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents colmachineStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
