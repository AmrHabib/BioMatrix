Imports System
Imports System.Drawing
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading

Module Docmd

    'https://stackoverflow.com/questions/23290454/get-all-dates-between-two-dates-in-sql-server
    'Get all dates between two dates In SQL Server
    '    Declare @MinDate DATE = '20140101',
    '    @MaxDate DATE = '20140106';

    'Select Case TOP(DATEDIFF(DAY, @MinDate, @MaxDate) + 1)
    'Date = DATEADD(DAY, ROW_NUMBER() OVER(ORDER BY a.object_id) - 1, @MinDate)
    'FROM    sys.all_objects a
    'CROSS JOIN sys.all_objects b;

    Public reader As SqlClient.SqlDataReader
    Public Mydataadapter As SqlDataAdapter
    Public Function inc_inv_code() As Integer
        Dim x As Integer = Runsql("select isnull(max(inv_code),0)+1 from tbl_last_inv_code")
        Runsql("insert into tbl_last_inv_code(inv_code)values(" + x.ToString + ")")
        Return x

    End Function
    Public Function on_hand_item(item_id As Integer, v_date As Date) As Integer
        v_date = New DateTime(Year(v_date), Month(v_date), DateAndTime.Day(v_date), 23, 59, 59)

        Dim x As Integer = Val(Runsql("Select on_hand_store From STore_in_Date('" + v_date + "') As STore_in_Date_1 Where (item_id =" + item_id.ToString + ")"))
        If x = -1 Then
            Return 0
        Else
            Return x
        End If




        'Dim x As Integer = Val(Runsql("select TotalOnHand from View_Store_Balance_from_Functions where Item_id=" + item_id.ToString))
        'If x = -1 Then
        '    Return 0
        'Else
        '    Return x
        'End If

    End Function
    Public Function Runsql(ByVal Command_query As String) As String

        Dim Result As String = ""
        Dim MyCommand As New SqlCommand

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.Text
        MyCommand.CommandText = Command_query


        MyCommand.Connection.Open()

        Try
            Result = MyCommand.ExecuteScalar.ToString
        Catch ex As Exception
            Result = "-1"
        End Try

        MyCommand.Connection.Close()

        Return Result
    End Function
    Public Function not_valid_date(ByVal d As Date) As Boolean
        d = New DateTime(Year(d), Month(d), DateAndTime.Day(d), 0, 0, 0)

        If d < gbl_start_date Or d > gbl_end_date Then
            Return True ' return true means it is not valid
            MsgBox("The Date is Not Valid", MsgBoxStyle.Information)
        Else
            Return False
        End If
    End Function
    Public Function Runsql_0(ByVal Command_query As String) As String

        Dim Result As String = ""
        Dim MyCommand As New SqlCommand

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.Text
        MyCommand.CommandText = Command_query


        MyCommand.Connection.Open()

        Try
            Result = MyCommand.ExecuteScalar.ToString
        Catch ex As Exception
            Result = "0"
        End Try

        MyCommand.Connection.Close()

        Return Result

    End Function

    Public Function Runinsert(ByVal Command_query As String) As Integer

        Dim row_count As Integer
        Dim MyCommand As New SqlCommand

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.Text
        MyCommand.CommandText = Command_query


        MyCommand.Connection.Open()

        Try
            row_count = MyCommand.ExecuteNonQuery
        Catch ex As Exception
            row_count = -1
        End Try

        MyCommand.Connection.Close()

        Return row_count

    End Function
    Public Function Runupdate(ByVal Command_query As String) As Integer

        Dim row_count As Integer
        Dim MyCommand As New SqlCommand

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.Text
        MyCommand.CommandText = Command_query


        MyCommand.Connection.Open()

        Try
            row_count = MyCommand.ExecuteNonQuery
        Catch ex As Exception
            row_count = -1
        End Try

        MyCommand.Connection.Close()

        Return row_count

    End Function
    Public Sub Fill(ByVal Combo_Obj As ComboBox, ByVal SqlSelect_Str As String)
        Try

            Dim DisplayMember, ValueMember, TableName As String

            SqlSelect_Str = SqlSelect_Str.ToUpper

            TableName = SqlSelect_Str.Substring(SqlSelect_Str.LastIndexOf("FROM") + 4).Trim
            ValueMember = SqlSelect_Str.Substring(SqlSelect_Str.IndexOf(" ") + 1, (SqlSelect_Str.IndexOf(",") - SqlSelect_Str.IndexOf(" ") - 1)).Trim
            DisplayMember = SqlSelect_Str.Substring(SqlSelect_Str.IndexOf(",") + 1, (SqlSelect_Str.IndexOf("FROM") - SqlSelect_Str.IndexOf(",") - 1)).Trim
            SqlSelect_Str = SqlSelect_Str + " order by " + DisplayMember
            Dim da As New SqlDataAdapter(SqlSelect_Str, My.Settings.Connection_String)
            Dim ds As New DataSet
            da.Fill(ds, TableName)

            With Combo_Obj
                .DisplayMember = DisplayMember
                .ValueMember = ValueMember
                .DataSource = ds.Tables(TableName)
                .SelectedIndex = 0
            End With

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Fill(ByVal Combo_Obj As ComboBox, ByVal SqlSelect_Str As String, sorting As Boolean)
        Try

            Dim DisplayMember, ValueMember, TableName As String

            SqlSelect_Str = SqlSelect_Str.ToUpper

            TableName = SqlSelect_Str.Substring(SqlSelect_Str.LastIndexOf("FROM") + 4).Trim
            ValueMember = SqlSelect_Str.Substring(SqlSelect_Str.IndexOf(" ") + 1, (SqlSelect_Str.IndexOf(",") - SqlSelect_Str.IndexOf(" ") - 1)).Trim
            DisplayMember = SqlSelect_Str.Substring(SqlSelect_Str.IndexOf(",") + 1, (SqlSelect_Str.IndexOf("FROM") - SqlSelect_Str.IndexOf(",") - 1)).Trim

            If sorting = True Then
                SqlSelect_Str = SqlSelect_Str + " order by " + DisplayMember
            End If

            Dim da As New SqlDataAdapter(SqlSelect_Str, My.Settings.Connection_String)
            Dim ds As New DataSet
            da.Fill(ds, TableName)

            With Combo_Obj
                .DisplayMember = DisplayMember
                .ValueMember = ValueMember
                .DataSource = ds.Tables(TableName)
                .SelectedIndex = 0
            End With

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Fill_list(ByVal Combo_Obj As ListBox, ByVal SqlSelect_Str As String)
        Try

            Dim DisplayMember, ValueMember, TableName As String

            SqlSelect_Str = SqlSelect_Str.ToUpper

            TableName = SqlSelect_Str.Substring(SqlSelect_Str.LastIndexOf("FROM") + 4).Trim
            ValueMember = SqlSelect_Str.Substring(SqlSelect_Str.IndexOf(" ") + 1, (SqlSelect_Str.IndexOf(",") - SqlSelect_Str.IndexOf(" ") - 1)).Trim
            DisplayMember = SqlSelect_Str.Substring(SqlSelect_Str.IndexOf(",") + 1, (SqlSelect_Str.IndexOf("FROM") - SqlSelect_Str.IndexOf(",") - 1)).Trim

            Dim da As New SqlDataAdapter(SqlSelect_Str, My.Settings.Connection_String)
            Dim ds As New DataSet
            da.Fill(ds, TableName)

            With Combo_Obj
                .DisplayMember = DisplayMember
                .ValueMember = ValueMember
                .DataSource = ds.Tables(TableName)
                .SelectedIndex = 0
            End With

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Fill_list2(ByVal Combo_Obj As ListBox, ByVal SqlSelect_Str As String)
        Dim dt As New DataTable
        dt = create_table(SqlSelect_Str)
        With Combo_Obj
            .DisplayMember = dt.Columns(1).ColumnName
            .ValueMember = dt.Columns(0).ColumnName
            .DataSource = dt
            If dt.Rows.Count > 0 Then
                .SelectedIndex = 0
                .Text = ""
            End If
        End With
    End Sub
    Public Sub fill_combo2(ByVal Combo_Obj As ComboBox, ByVal SqlSelect_Str As String)
        Dim dt As New DataTable
        dt = create_table(SqlSelect_Str)
        With Combo_Obj
            .DisplayMember = dt.Columns(1).ColumnName
            .ValueMember = dt.Columns(0).ColumnName
            .DataSource = dt
            If dt.Rows.Count > 0 Then
                .SelectedIndex = 0
                .Text = ""
            End If
        End With
    End Sub
    Public Sub msg()
        MsgBox("You don't have privilage to open this windows", MsgBoxStyle.Critical, "Security Alarm")

    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------
    'Public Sub OpenForms(ByVal Form_name As Form)
    '    Try
    '        Dim ool As Form
    '        If chk_security(, 2, Form_name.Name.ToString) = False Then ' بختبر برقم 2 عشان هو المخصص لاختبار صلاحية الفتح
    '            MsgBox("You don't have privilage to open this windows", MsgBoxStyle.Critical, "Security Alarm")
    '            Exit Sub
    '        End If

    '        If oldForm_name.Name = Form_name.Name Then
    '            Exit Sub
    '        End If
    '        ool = oldForm_name
    '        'oldForm_name.Close()
    '        oldForm_name = Form_name



    '        ''Frm_Mdi.Panel1.Controls.Clear()
    '        ''Global_Form_Name.Close()
    '        ''Form_name.TopLevel = False

    '        'Form_name.Close()

    '        Form_name.MdiParent = Frm_Mdi
    '        Form_name.Opacity = 0
    '        Form_name.WindowState = FormWindowState.Minimized
    '        Form_name.Show()
    '        ool.Opacity = 0
    '        ool.Close()
    '        Form_name.Opacity = 100
    '        Form_name.WindowState = FormWindowState.Normal


    '        'Frm_Mdi.Panel1.Controls.Add(Form_name)

    '        Form_name.Dock = DockStyle.Fill

    '        'Global_Form_Name.Close()
    '        'Global_Form_Name = Form_name
    '        ''Form_name.Opacity = 0
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Sub OpenPopup()
        Try
            Dim th As System.Threading.Thread = New Threading.Thread(AddressOf Task_A)
            th.SetApartmentState(ApartmentState.STA)
            th.Start()
        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Task_A()
        Try
            Dim frmBuild As Form = dbForm_name ' Must be created on this thread!
            Application.Run(frmBuild)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Function dlookup(ByVal fld As String, ByVal tbl As String, ByVal wherecondition As String) As String
        '////////////////////// Select \\\\\\\\\\\\\\\\\\\\\\\\\\\
        Try
            Dim result As String
            Dim ConnectionString As String = My.Settings.Connection_String
            Dim cn As New SqlConnection(ConnectionString)
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cmd.Connection = cn
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If wherecondition = "" Then
                cmd.CommandText = "Select " & fld & " from " & tbl
            Else
                cmd.CommandText = "Select " & fld & " from " & tbl & " where " & wherecondition
            End If


            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                'While dr.Read
                dr.Read()
                result = (dr.Item(0).ToString())
                'End While
            Else
                result = -1
            End If
            dr.Close()
            Return result

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '\\\\\\\\\\\\\\\\\\\\ END Select /////////////////////////
    End Function

    Public Function create_table(ByVal sql As String) As DataTable
        'تستقبل جملة سيكول وترجع جدول بالناتج

        Try

            Dim ConnectionString As String = My.Settings.Connection_String
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            Dim cmd As SqlCommand = cn.CreateCommand
            cmd.CommandText = sql

            Dim dt As New DataTable
            Dim ds As New DataSet

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            cmd.ExecuteNonQuery()
            ds.Tables.Add(dt)

            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return dt
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function


    Public Function chk_security(Optional frm_id As Integer = 0, Optional level_id As Integer = 0, Optional frm_name As String = "nothing") As Boolean

        'THE PRIVILAG THAT  I WILL SEND IT TO THIS FUNCTION IS 
        '1 FOR VISIABLE
        '2 FOR OPEN 
        '3 FOR ADD
        '4 FOR EDIT
        '5 FOR DELETE 


        Dim sql As String
        If frm_name = "nothing" Then
            sql = "Select  tbl_Sec_group_details.level_id, tbl_sec_level.level_name FROM tbl_user INNER JOIN tbl_Sec_goups ON tbl_user.group_id = tbl_Sec_goups.group_id INNER JOIN tbl_Sec_group_details ON tbl_Sec_goups.group_id = tbl_Sec_group_details.group_id INNER JOIN tbl_Sec_forms ON tbl_Sec_group_details.frm_id = tbl_Sec_forms.frm_id INNER JOIN tbl_sec_level ON tbl_Sec_group_details.level_id = tbl_sec_level.level_id WHERE(tbl_user.user_id =" + gbl_user_id.ToString + " )and (tbl_Sec_group_details.frm_id=" + frm_id.ToString + ")"
            'sql = "Select  tbl_Sec_group_details.level_id FROM tbl_user INNER JOIN tbl_Sec_goups ON tbl_user.group_id = tbl_Sec_goups.group_id INNER JOIN tbl_Sec_group_details ON tbl_Sec_goups.group_id = tbl_Sec_group_details.group_id INNER JOIN tbl_Sec_forms ON tbl_Sec_group_details.frm_id = tbl_Sec_forms.frm_id INNER JOIN tbl_sec_level ON tbl_Sec_group_details.level_id = tbl_sec_level.level_id WHERE(tbl_user.user_id =" + gbl_user_id.ToString + " )and (tbl_Sec_group_details.frm_id=" + frm_id.ToString + ")"
        Else
            sql = "Select  tbl_Sec_group_details.level_id, tbl_sec_level.level_name FROM tbl_user INNER JOIN tbl_Sec_goups ON tbl_user.group_id = tbl_Sec_goups.group_id INNER JOIN tbl_Sec_group_details ON tbl_Sec_goups.group_id = tbl_Sec_group_details.group_id INNER JOIN tbl_Sec_forms ON tbl_Sec_group_details.frm_id = tbl_Sec_forms.frm_id INNER JOIN tbl_sec_level ON tbl_Sec_group_details.level_id = tbl_sec_level.level_id WHERE(tbl_user.user_id =" + gbl_user_id.ToString + " )and (tbl_Sec_forms.frm_name='" + frm_name + "')"
            'sql = "Select  tbl_Sec_group_details.level_id FROM tbl_user INNER JOIN tbl_Sec_goups ON tbl_user.group_id = tbl_Sec_goups.group_id INNER JOIN tbl_Sec_group_details ON tbl_Sec_goups.group_id = tbl_Sec_group_details.group_id INNER JOIN tbl_Sec_forms ON tbl_Sec_group_details.frm_id = tbl_Sec_forms.frm_id INNER JOIN tbl_sec_level ON tbl_Sec_group_details.level_id = tbl_sec_level.level_id WHERE(tbl_user.user_id =" + gbl_user_id.ToString + " )and (tbl_Sec_forms.frm_name='" + frm_name + "')"
        End If

        Dim Result As String = ""
        Dim lev As Integer
        'Dim MyCommand As New SqlCommand
        'MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        'MyCommand.CommandType = CommandType.Text
        'MyCommand.CommandText = sql
        'MyCommand.Connection.Open()
        'lev = MyCommand.ExecuteScalar.ToString
        Dim tt As DataTable = create_table(sql)
        lev = tt.Rows(0)(0)
        Select Case level_id
            Case 1 'CHECK VISIABLE
                If lev = 9 Then ' NOT VISIABLE 
                    Return False
                Else
                    Return True
                End If
            Case 2 '2 FOR OPEN
                If lev = 7 Then ' NOT ALLOW 
                    Return False
                Else
                    Return True
                End If
            Case 3 '3 FOR ADD
                If lev = 1 Or lev = 2 Or lev = 3 Then ' CAN ADD
                    Return True
                Else
                    Return False
                End If
            Case 4 '4 FOR EDIT
                If lev = 1 Or lev = 2 Or lev = 4 Then ' CAN EDIT
                    Return True
                Else
                    Return False
                End If
            Case 5 '5 FOR DELETE 
                If lev = 1 Or lev = 5 Then ' CAN DELETE
                    Return True
                Else
                    Return False
                End If
                'Case 6
                '    If lev = 1 Or lev = 5 Then ' CAN DELETE
                '        Return True
                '    Else
                '        Return False
                '    End If
            Case Else

                lev = 50
        End Select





        'MyCommand.Connection.Close()

        Return Result


    End Function
    Public Function DG_DataSource(ByVal sql As String) As DataTable
        'تستقبل جملة سيكول وترجع جدول بالناتج

        Try

            Dim ConnectionString As String = My.Settings.Connection_String
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            Dim cmd As SqlCommand = cn.CreateCommand
            cmd.CommandText = sql

            Dim dt As New DataTable
            Dim ds As New DataSet

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            ' cmd.ExecuteNonQuery()


            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return dt
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
#Region "unused"
    Public Function Command_Procedure_OutPut(ByVal Procedure_Name As String, ByVal OutPut_Parameter As String, ByVal Command_Parameter() As String) As Integer

        Dim row_count As Integer
        Dim MyCommand As New SqlCommand

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.StoredProcedure
        MyCommand.CommandText = Procedure_Name


        MyCommand.Parameters.Add(New SqlParameter(OutPut_Parameter, SqlDbType.Int))
        MyCommand.Parameters(OutPut_Parameter).Direction = ParameterDirection.Output

        For index As Integer = 0 To Command_Parameter.Length - 2 Step 2

            MyCommand.Parameters.Add(New SqlParameter(Command_Parameter(index), Command_Parameter(index + 1)))

        Next

        MyCommand.Connection.Open()

        row_count = MyCommand.ExecuteNonQuery

        Global_OutPut_Parameter = CInt(MyCommand.Parameters(OutPut_Parameter).Value)

        MyCommand.Connection.Close()

        Return row_count


    End Function

    Public Function Command_Procedure(ByVal Procedure_Name As String, ByVal Command_Parameter() As String) As Integer

        Dim row_count As Integer
        Dim MyCommand As New SqlCommand

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.StoredProcedure
        MyCommand.CommandText = Procedure_Name


        For index As Integer = 0 To Command_Parameter.Length - 2 Step 2

            MyCommand.Parameters.Add(New SqlParameter(Command_Parameter(index), Command_Parameter(index + 1)))

        Next

        MyCommand.Connection.Open()

        row_count = MyCommand.ExecuteNonQuery()

        MyCommand.Connection.Close()

        Return row_count

    End Function

    Public Sub Command_Procedure_Reader(ByVal Procedure_Name As String, ByVal Command_Parameter() As String)

        Dim MyCommand As New SqlCommand
        Dim userdata_reader As SqlDataReader

        MyCommand.Connection = New SqlConnection(My.Settings.Connection_String)
        MyCommand.CommandType = CommandType.StoredProcedure
        MyCommand.CommandText = Procedure_Name


        For index As Integer = 0 To Command_Parameter.Length - 2 Step 2

            MyCommand.Parameters.Add(New SqlParameter(Command_Parameter(index), Command_Parameter(index + 1)))

        Next


        MyCommand.Connection.Open()

        userdata_reader = MyCommand.ExecuteReader

        While userdata_reader.Read()

            Global_user_name = userdata_reader.GetValue(2)
            Global_user_password = userdata_reader.GetValue(3)

        End While

        MyCommand.Connection.Close()

    End Sub

    Public Sub Writing_TheTracingFile(ByVal mode As String)

        Try
            Dim file_stream As New FileStream("C:\Tracing Users Files\Tracing_user_" & Global_user_name & ".txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
            Dim sasa_StreamWriter As New StreamWriter(file_stream)

            ' Write to the file using StreamWriter class
            sasa_StreamWriter.WriteLine()
            sasa_StreamWriter.BaseStream.Seek(0, SeekOrigin.End)
            sasa_StreamWriter.WriteLine("--> {0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString())
            sasa_StreamWriter.Write("The User [{0}] {1} The System ", Global_user_name, mode)
            sasa_StreamWriter.WriteLine("================================================================================" + ControlChars.Lf)
            sasa_StreamWriter.Flush()

            Global_Version_Validation = True

        Catch ex As Exception
            MessageBox.Show("This Version Is Not Genuine, PLZ Buy The Orginal Copy .. Contact Fast AT Programers 55752852/55422138", "...Trial Version...", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Global_Version_Validation = False
        End Try
    End Sub

    Public Sub TracingTheUser(ByVal Operation As String)

        Dim file_stream As New FileStream("C:\Tracing Users Files\Tracing_user_" & Global_user_name & ".txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
        Dim sasa_StreamWriter As New StreamWriter(file_stream)

        ' Write to the file using StreamWriter class
        sasa_StreamWriter.WriteLine()
        sasa_StreamWriter.BaseStream.Seek(0, SeekOrigin.End)
        sasa_StreamWriter.WriteLine("--> {0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString())
        sasa_StreamWriter.WriteLine(Operation)
        sasa_StreamWriter.WriteLine("================================================================================" + ControlChars.Lf)
        sasa_StreamWriter.Flush()

    End Sub

    Public Sub WrittingPrivileges(ByVal Operation As String)

        Dim file_stream As New FileStream("d:\Privilege.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
        Dim sasa_StreamWriter As New StreamWriter(file_stream)

        ' Write to the file using StreamWriter class
        sasa_StreamWriter.BaseStream.Seek(0, SeekOrigin.End)
        sasa_StreamWriter.WriteLine(Operation)
        sasa_StreamWriter.Flush()

    End Sub


#End Region

End Module
