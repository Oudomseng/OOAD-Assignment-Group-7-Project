using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    static class user
    {
        public static MySqlConnection con = connection.mysqldb();
        public static void login(object username, object pass)
        {
            try
            {

                con.Open();
                crud.reloadtxt(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM `tbluser` WHERE User_name= '", username), "' and Pass = sha1('"), pass), "')")));

                {
                    var withBlock = My.MyProject.Forms.Form1;
                    if (crud.dt.Rows.Count > 0)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(crud.dt.Rows[0]["UserRole"], "Administrator", false)))
                        {
                            Interaction.MsgBox(Operators.ConcatenateObject("Welcome ", crud.dt.Rows[0]["UserRole"]));
                            // Form1.Text = "User :" & dt.Rows(0).Item("Fullname")
                            withBlock.Show();
                            My.MyProject.Forms.frmLogin.Hide();
                        }

                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(crud.dt.Rows[0]["UserRole"], "Librarian", false)))
                        {

                            Interaction.MsgBox(Operators.ConcatenateObject("Welcome ", crud.dt.Rows[0]["UserRole"]));
                            // Form1.Text = "User :" & dt.Rows(0).Item("Fullname")


                            withBlock.Show();
                            My.MyProject.Forms.frmLogin.Hide();
                        }


                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(crud.dt.Rows[0]["UserRole"], "Assistant", false)))
                        {
                            Interaction.MsgBox(Operators.ConcatenateObject("Welcome ", crud.dt.Rows[0]["UserRole"]));
                            // With Form1

                            withBlock.Show();
                            My.MyProject.Forms.frmLogin.Hide();
                        }
                    }

                    // sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " &
                    // " VALUES ('" & dt.Rows(0).Item("UserID") & "',Now(),'Logged in')"
                    // create(sql)

                    else
                    {
                        Interaction.MsgBox("Acount doest not exist!", MsgBoxStyle.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Interaction.MsgBox(ex.Message);
            }
            con.Close();
            crud.da.Dispose();
        }
        //public static void append(string sql, string field, object txt)
        //{
        //    crud.reloadtxt(sql);
        //    try
        //    {
        //        txt.AutoCompleteCustomSource.Clear();
        //        foreach (DataRow r in crud.dt.Rows)
        //            txt.AutoCompleteCustomSource.Add(r[field].ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        Interaction.MsgBox(ex.Message);
        //    }


        //}
    }
}