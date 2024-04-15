Imports System
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net

Module Global_Var
    Public machID As Integer
    Public gbl_Command_query As String
    Public gbl_Result As String

    Public gbl_start_date As Date
    Public gbl_end_date As Date

    Public dbForm_name As Form

    Public gbl_report_header_txt As String
    Public gbl_report_header As String
    Public gbl_color As String
    Public gbl_checked_user_ok As Boolean = False
    Public gbl_checked_save_user_ok As Boolean = False
    Public gbl_header As String 'with "\" at the end
    Public gbl_footer As String 'with "\" at the end

    Public gbl_arch_path As String 'with "\" at the end
    Public gbl_Emp_app As String
    Public gbl_come_from As String
    ' Global Variable for loading 
    Public gbl_active_emp As Integer
    Public gbl_user_id As Integer

    Public gbl_emp_id As Integer

    Public gbl_production_code As Integer

    Public gbl_emp_id2 As Integer

    Public gbl_purchase_id As Integer
    Public gbl_extra_id As Integer
    Public gbl_rent_id As Integer
    Public gbl_loading_id As Integer
    Public gbl_delivery_id As Integer

    Public gbl_receipt_id As Integer
    Public gbl_emp_name As String
    Public gbl_emp_name_full As String

    Public gbl_user_name As String
    Public gbl_calculated_by As Integer

    Public gbl_password As String
    Public gbl_last_path As String
    Public gbl_item_id As String
    Public gbl_scrab_inv_code As Integer
    Public gbl_expenses_id As Integer
    Public gbl_sales_id As Integer
    Public gbl_inv_code_rent As Integer
    Public gbl_client_inv_code_rent As Integer
    Public gbl_Inv_code_loading As Integer
    Public gbl_Inv_code As Integer
    Public gbl_client_name_loading As String
    Public gbl_type_of_scrap_inv As Integer ' 1 for purchase and 2 for return
    '==========================
    Public gbl_new_price As Double
    Public gbl_P_disc As Double
    Public gbl_P_master As Double

    Public gbl_new_rent As Double
    Public gbl_R_disc As Double
    Public gbl_R_master As Double

    Public gbl_qty As Double
    Public gbl_set_but_pressed As Boolean
    '=============================

    Public gbl_supplier_name As String
    Public gbl_supplier_id As Integer
    '=============================
    Public gbl_item_name As String

    Public gbl_client_name As String
    'global variable used by up level client and prject client
    Public gbl_Project_id As Integer
    Public gbl_Project_name As String
    Public gbl_up_client_id As Integer

    'Global variable used by delivery form
    Public gbl_inv_code_order As Integer
    Public gbl_client_order As Integer
    Public gbl_client_name_order As String

    'global variable used by pending operation 
    Public gbl_send_to_pending As Boolean
    Public gbl_send_to_pending_msg As String
    Public gbl_pending_tbl_id As Integer
    Public gbl_rec_code As Integer




    'Global variable used by production forms 
    Public gbl_btn_open_item_list As Integer


    'Global variable used by forms 
    Public gbl_voucher_id As Integer

    Public gbl_client_id As Integer
    Public rep_bill_num As Integer
    Public rep_rec_code As Integer
    Public rep_inv_code As Integer
    Public rep_rent_inv_code As Integer
    Public rep_purchase_inv_code As Integer
    Public rep_sales_inv_code As Integer
    Public rep_extra_inv_code As Integer
    Public rep_expenses_inv_code As Integer
    Public rep_final_inv_code As Integer
    ' Public 
    Public item_Cat_id1, item_Cat_id2, Item_id1, Item_id2 As Integer
    Public Item_name As String
    'For Database prefrence
    Public SqlConnectionString As String
    Public SqlDataBase As String = "como"
    Public SqlUserName As String
    Public SqlPassword As String

    Public Global_OutPut_Parameter As String ' The output parameter of procedures Wiht Global Commands
    '============================================================================================================
    Public selected_frm As Integer ' For  user & password form "frm_login"
    '----------------------------------------------------------------------
    ' variables for the user_name  &  user_id
    '=================== main form ===================
    Public Global_Form_Name As Form
    '  Public oldForm_name As Form = about
    Public Global_Version_Validation As Boolean
    '============= Users =============================
    Public Global_user_name As String
    Public Global_user_password As String
    Public Global_user_id As Integer
    Public Global_user_group As Integer
    '============= Order ======================
    Public Global_order_id As String
    Public Global_client_id As String
    Public Global_client_name As String
    Public Global_client_phone As String
    Public Global_client_add As String
    Public Global_order_status As String
    '=============== Product =====================
    Public global_product_id As String

    '================Employees====================
    Public Global_employee_name As String
    Public Global_Emp_id As String
    Public Global_Form_Emp_id As String
    Public Global_Emp_typ As Integer
    '========================================

    '============== notify =================
    Public Global_notify_close As Boolean = False

    '============== session =================
    Public Global_session_id As String
    Public global_session_num As String

    '======================================
    Public global_supplier_id As Integer
    '================   Balloon  ========================
    Public Global_Ballon_client_name As String
    Public Global_Ballon_client_code As String
    Public Global_Ballon_DaysLeft As Int16
    Public Global_service_data(3, 1) As String
    Public global_baloon_form1_chek As Boolean
    Public global_baloon_form2_chek As Boolean
    Public global_baloon_form3_chek As Boolean
    '=================== Member Ship =================
    Public emp_photo_path As String
    Public product_photo_path As String
    Public global_product_code As String
    Public P_ZOOM_FROM As Int16

    Public pro_photo_path As String
    Public Pic_ZOOM_FROM As Int16
    '========================store========================
    Public global_invoice_type As Int16
    Public global_invoice_c As Integer
    Public storetype As Int16


End Module

