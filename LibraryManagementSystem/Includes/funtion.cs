using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    static class funtion
    {
        public static MySqlConnection con = connection.mysqldb();
        public static void cleartext(GroupBox group)
        {
            foreach (Control ctrl in (IEnumerable)group.Controls)
            {
                if (ReferenceEquals(ctrl.GetType(), typeof(TextBox)))
                {
                    ctrl.Text = null;
                }
            }
            foreach (Control ctrl in (IEnumerable)group.Controls)
            {
                if (ReferenceEquals(ctrl.GetType(), typeof(RichTextBox)))
                {
                    ctrl.Text = null;
                }
            }
        }

        public static void cleartextForm(Form group)
        {
            foreach (Control ctrl in (IEnumerable)group.Controls)
            {
                if (ReferenceEquals(ctrl.GetType(), typeof(TextBox)))
                {
                    ctrl.Text = null;
                }
            }
            foreach (Control ctrl in (IEnumerable)group.Controls)
            {
                if (ReferenceEquals(ctrl.GetType(), typeof(RichTextBox)))
                {
                    ctrl.Text = null;
                }
            }
        }

        public static void getallforms()
        {
            try
            {


                foreach (Form f in My.MyProject.Application.OpenForms)
                {
                    switch (f.Name ?? "")
                    {
                        // frm_Login.Show()
                        case "frm_Login":
                            {
                                break;
                            }

                        default:
                            {
                                f.Hide();
                                break;
                            }
                    }

                }
            }
            catch (Exception ex)
            {

            }

            // For Each t As Type In sender.GetType().Assembly.GetTypes()
            // If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then

            // MsgBox(t.Name)

            // End If
            // Next
        }

        public static void cbo_fill(ComboBox cbo, string member, string id, string table)
        {

            try
            {
                con.Open();

                {
                    ref var withBlock = ref crud.cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = "Select * From " + table;
                }

                crud.da = new MySqlDataAdapter("Select * From " + table, con);
                crud.da.SelectCommand = crud.cmd;
                crud.dt = new DataTable();
                crud.da.Fill(crud.dt);
                cbo.DataSource = crud.dt;
                cbo.ValueMember = id;
                cbo.DisplayMember = member;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information);
            }
            con.Close();
            // da.Dispose()

        }

        public static void emptymessage()
        {
            Interaction.MsgBox("There are empty fields left that must be filled up!", MsgBoxStyle.Exclamation);
        }


        public static int inc = 0;
        public static int maxrows;

        public static void select_navigation(string sql)
        {
            try
            {
                try
                {
                    con.Open();
                    {
                        ref var withBlock = ref crud.cmd;
                        withBlock.Connection = con;
                        withBlock.CommandText = sql;
                    }
                    crud.dt = new DataTable();
                    crud.da = new MySqlDataAdapter(sql, con);
                    crud.da.Fill(crud.dt);
                    maxrows = crud.dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message + "select_navigation");
                }

                con.Close();
                crud.da.Dispose();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }

        }
        public static void navagate_records(TextBox txt)
        {
            try
            {
                txt.Text = crud.dt.Rows[inc][0].ToString();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }

        }
        // Public Sub auto_suggest(ByVal member As String, ByVal table As String, ByVal txt As Object)
        // Try
        // reload("select  " & member & " from  " & table)
        // filltxtshow()

        // Dim r As DataRow
        // txt.AutoCompleteCustomSource.Clear()

        // For Each r In dt.Rows
        // txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)

        // Next
        // Catch ex As Exception
        // MsgBox(ex.Message)
        // End Try
        // End Sub
        // Public Sub query(ByVal member As String, ByVal table As String, ByVal dtg As Object)
        // Try
        // reload("SELECT " & member & " FROM " & table)
        // filltable(dtg)

        // Catch ex As Exception

        // End Try
        // End Sub
        public static void validation(Form frm)
        {
            try
            {
                foreach (Control ctrl in frm.Controls)
                {
                    if (ctrl is TextBox txtBox)
                    {
                        if (string.IsNullOrEmpty(txtBox.Text))
                        {
                            MessageBox.Show("One of the textboxes is empty; please fill out all fields.");
                            // Optionally, you can return or break out of the loop here, depending on your requirements.
                            return;
                        }
                        // If you have additional logic for non-empty textboxes, you can include it here.
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public static void ErrorMessage(Label lbl, string message, Button btn)
        {
            lbl.BackColor = Color.Red;
            lbl.ForeColor = Color.White;
            lbl.Text = message;
            btn.Enabled = false;
        }
        public static void ClearErrorMessage(Label lbl, Button btn)
        {
            lbl.BackColor = Color.Transparent;
            lbl.Text = "";
            btn.Enabled = true;
        }
        // declarations
        private static string day = Strings.Format(DateTime.Today, "dddd"); // string format of days
        private static int hoursinterval;
        private static DateTime retrievtime; // date borrowed 
        private static int convertedtimeH;    // hour borrowed 
        private static int convertedtimeM;   // minute borrowed 


        private static DateTime time; // current date
        private static int CurrHour; // current hour
        private static int CurrMinute; // current minute

        public static void checkOverduePurposed(string sql, string choiceofporpuse)
        {

            try
            {
                // for retriving the data
                {
                    ref var withBlock = ref crud.cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                crud.dt = new DataTable();
                crud.da = new MySqlDataAdapter(sql, con);
                crud.da.Fill(crud.dt);
                foreach (DataRow row in crud.dt.Rows)
                {
                    int id = Conversions.ToInteger(row[1]);
                    switch (day ?? "")
                    {
                        case "Monday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }

                        case "Tuesday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }

                        case "Wednesday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {


                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }

                        case "Thursday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }

                        case "Friday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }

                        case "Saturday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }
                        case "Sunday":
                            {
                                switch (choiceofporpuse ?? "")
                                {
                                    case "Research":
                                        {
                                            timeOfresearch(id);
                                            break;
                                        }
                                    case "Photocopy":
                                        {
                                            timeOfPhotocopy(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Overnight":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfOvernight(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                    case "Borrowed for 3days":
                                        {

                                            // MsgBox("Overnight")
                                            timeOfthreeDays(id, Conversions.ToInteger(row[0]));
                                            break;
                                        }
                                }

                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }

        }
        public static void timeOfresearch(int id)
        {



            if (Strings.Format(DateTime.Now, "tt") == "AM")
            {
                int checktime = Conversions.ToInteger(DateAndTime.DatePart("h", DateTime.Now) + Strings.Format(DateTime.Now, "mm"));
                if (checktime <= 830 | checktime >= 1130)
                {
                    // MsgBox(Format(Date.Now().Date, "yyyy-MM-dd") & " 11:30:00")
                    crud.sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " + " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" + id + "'";
                    crud.updates(crud.sql);
                }
            }

            else if (Strings.Format(DateTime.Now, "tt") == "PM")
            {
                int checktime = Conversions.ToInteger(DateAndTime.DatePart("h", DateTime.Now).ToString() + DateAndTime.DatePart("n", DateTime.Now));
                if (checktime <= 1330 | checktime >= 1730)
                {
                    crud.sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " + " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" + id + "'";
                    crud.updates(crud.sql);
                }

            }
            // If retrievtime >= 24 Then
            // sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
            // & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
            // updates(sql)
            // Return
            // End If
        }
        public static void timeOfPhotocopy(int id, int retrievtime)
        {

            if (retrievtime >= 30)
            {
                // sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose` ='Photocopy' and borrow_id in ('" & id & "')"
                // updates(sql)
                crud.sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " + " WHERE Status='Borrowed' AND `Purpose` ='Photocopy' and BorrowId='" + id + "'";
                crud.updates(crud.sql);
                return;

            }
        }
        public static void timeOfOvernight(int id, int hoursinterval)
        {
            if (hoursinterval >= 24)
            {
                // sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose`='Overnight' and borrow_id in ('" & id & "')"
                // updates(sql)
                crud.sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " + " WHERE Status='Borrowed' AND `Purpose` ='Overnight' and BorrowId='" + id + "'";
                crud.updates(crud.sql);
                return;
            }
        }
        public static void timeOfthreeDays(int id, int hoursinterval)
        {
            if (hoursinterval >= 73)
            {
                // sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose`='Overnight' and borrow_id in ('" & id & "')"
                // updates(sql)
                crud.sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " + " WHERE Status='Borrowed' AND `Purpose` ='Borrowed for 3days' and BorrowId='" + id + "'";
                crud.updates(crud.sql);
                return;
            }
        }

        // Public Sub formulaofpayments(ByVal frm As frmPayments)
        // Try
        // Dim totaltime As Integer
        // Dim ts As TimeSpan = TimeSpan.Parse(frm.txtOverdueTime.Text)
        // Dim TValueMin As Integer = ts.Minutes.ToString
        // Dim tValueHour As Integer = 60 * ts.Hours.ToString
        // Dim condays As Integer = 24 * ts.Days.ToString

        // totaltime = condays + tValueHour + TValueMin
        // totaltime = totaltime / Val(frm.txtminutes.Text)
        // frm.txtTotPay.Text = totaltime * Val(frm.txtamount.Text)

        // Catch ex As Exception
        // 'MsgBox(ex.Message & "lbl_Rduedate_Click")
        // End Try
        // End Sub
        public static void formulaofpayments()
        {
            try
            {
                int totalhours;
                var ts = TimeSpan.Parse(My.MyProject.Forms.frmOverdue.txtOverdueTime.Text);
                // Dim TValueMin As Integer = ts.Minutes.ToString
                int tValueHour = Conversions.ToInteger(ts.Hours.ToString());
                int condays = (int)Math.Round(24d * Conversions.ToDouble(ts.Days.ToString()));

                totalhours = condays + tValueHour;
                totalhours = (int)Math.Round(totalhours / Conversion.Val(My.MyProject.Forms.frmOverdue.txthours.Text));
                My.MyProject.Forms.frmOverdue.txtTotPay.Text = (totalhours * Conversion.Val(My.MyProject.Forms.frmOverdue.txtamount.Text)).ToString();
            }

            catch (Exception ex)
            {
                // MsgBox(ex.Message & "lbl_Rduedate_Click")
            }
        }
        public static void columnInvisible(DataGridView dtg)
        {
            foreach (DataGridViewColumn c in dtg.Columns)
            {

            }

        }
    }
}