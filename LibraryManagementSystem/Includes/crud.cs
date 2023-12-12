using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    static class crud
    {
        public static MySqlConnection con = connection.mysqldb();
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();
        public static DataSet ds = new DataSet();
        public static string sql;
        public static string result;
        public static string sqladd;
        public static string sqledit;
        #region old crud
        public static bool save_or_update(string sql, string add, string edit, string msgedit, string msgadd)
        {
            try
            {
                con.Open();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                dt = new DataTable();
                da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    {
                        ref var withBlock1 = ref cmd;
                        withBlock1.Connection = con;
                        withBlock1.CommandText = edit;
                        result = cmd.ExecuteNonQuery().ToString();
                    }
                    if (Conversions.ToDouble(result) > 0d)
                    {
                        Interaction.MsgBox(msgedit);
                    }
                }
                else
                {
                    {
                        ref var withBlock2 = ref cmd;
                        withBlock2.Connection = con;
                        withBlock2.CommandText = add;
                        result = cmd.ExecuteNonQuery().ToString();
                    }
                    if (Conversions.ToDouble(result) > 0d)
                    {
                        Interaction.MsgBox(msgadd);

                    }
                }
            }

            // MsgBox(ex.Message)
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }

            return default;

        }

        public static void createNoMsg(string sql)
        {
            try
            {
                con.Open();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message & "createNoMsg")
            }

        }
        public static bool create(string sql)
        {
            try
            {
                con.Open();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                    result = cmd.ExecuteNonQuery().ToString();

                }
            }

            // MsgBox(ex.Message & " create")
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }

            return Conversions.ToBoolean(result);
        }
        public static void reloadDtg(string sql, DataGridView dtg)
        {
            try
            {
                con.Open();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                dt = new DataTable();
                da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message + "reloadDtg");
            }

            con.Close();
            da.Dispose();
        }
        public static void reloadtxt(string sql)
        {
            try
            {
                con.Open();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                dt = new DataTable();
                da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            // MsgBox(ex.Message & "reloadtxt")
            catch (Exception ex)
            {
            }
            finally
            {

                con.Close();
                da.Dispose();

            }
        }
        public static object updates(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                    result = cmd.ExecuteNonQuery().ToString();
                    // If result = 0 Then
                    // MsgBox("No updated data", MsgBoxStyle.Information)
                    // Else
                    // MsgBox("Data in the database has been updated")
                    // End If
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message & "updates")
            }
            return result;
        }
        public static object deletes(string sql)
        {
            try
            {
                con.Open();
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                // If MessageBox.Show("Do you want to delete this rocord?", "Delete" _
                // , MessageBoxButtons.YesNo, MessageBoxIcon.Information) _
                // = Windows.Forms.DialogResult.Yes Then
                result = cmd.ExecuteNonQuery().ToString();

                // End If
                con.Close();
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }
            return result;
        }

        #endregion

        #region Report
        //public static void reports(string sql, string rptname, CrystalReportViewer crystalRpt)
        //{
        //    try
        //    {
        //        con.Open();

        //        string reportname;
        //        {
        //            ref var withBlock = ref cmd;
        //            withBlock.Connection = con;
        //            withBlock.CommandText = sql;
        //        }
        //        ds = new DataSet();
        //        da = new MySqlDataAdapter(sql, con);
        //        da.Fill(ds);
        //        reportname = rptname;
        //        var reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //        string strReportPath;
        //        strReportPath = Application.StartupPath + @"\report\" + reportname + ".rpt";
        //        reportdoc.Load(strReportPath);
        //        reportdoc.SetDataSource(ds.Tables[0]);
  
        //        crystalRpt.ReportSource = reportdoc;
        //    }
        //    catch (Exception ex)
        //    {
        //        Interaction.MsgBox(ex.Message + "No Crystal Reports have been Installed");
        //    }
        //    con.Close();
        //    da.Dispose();
        //}
        #endregion
    }
}