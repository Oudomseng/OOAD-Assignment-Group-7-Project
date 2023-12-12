using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmUser
    {
        public frmUser()
        {
            InitializeComponent();
        }
        private void frm_adduser_Load(object sender, EventArgs e)
        {
            try
            {
                cbo_type.Text = "Administrator";
                crud.reloadDtg("Select UserId as 'ID' ,Fullname as 'Name',User_name as 'UserName',UserRole as 'Type' From tbluser WHERE Status='Active'", dtg_listUser);
                dtg_listUser.Columns[0].Visible = false;
                if (lbl_id.Text == "id")
                {

                    btn_update.Enabled = false;
                    btn_delete.Enabled = false;
                    btn_saveuser.Enabled = true;
                }

                else
                {
                    btn_saveuser.Enabled = false;
                    btn_update.Enabled = true;
                    btn_delete.Enabled = true;
                }
            }


            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "id";
            frm_adduser_Load(sender, e);
            funtion.cleartextForm(this);
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_name.Text) | string.IsNullOrEmpty(txt_pass.Text) | string.IsNullOrEmpty(txt_username.Text))
            {
                funtion.emptymessage();
            }
            else
            {
                crud.result = Conversions.ToString(crud.create("insert into tbluser (`Fullname`, `User_name`, `Pass`, `UserRole`,`Status`) " + "values('" + txt_name.Text + "','" + txt_username.Text + "',sha1('" + txt_pass.Text + "'),'" + cbo_type.Text + "','Active')"));


                if (Conversions.ToBoolean(crud.result) == true)
                {
                    Interaction.MsgBox("User has been saved in the database.");
                }
                btn_close_Click(sender, e);
                funtion.cleartextForm(this);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text) | string.IsNullOrEmpty(txt_pass.Text) | string.IsNullOrEmpty(txt_username.Text))
                {
                    funtion.emptymessage();
                }
                else
                {
                    crud.result = Conversions.ToString(crud.updates("update tbluser set Fullname = '" + txt_name.Text + "',User_name= '" + txt_username.Text + "',Pass= sha1('" + txt_pass.Text + "'),UserRole= '" + cbo_type.Text + "' where UserId = " + lbl_id.Text));

                    if (Conversions.ToBoolean(crud.result) == true)
                    {
                        Interaction.MsgBox("User has been updated in the database.");
                    }

                    btn_close_Click(sender, e);
                    funtion.cleartextForm(this);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // result = deletes("delete from tbluser where UserId = '" & lbl_id.Text & "'")
                    crud.result = Conversions.ToString(crud.updates("update tbluser set Status='NotActive' where UserId = " + lbl_id.Text));
                    if (Conversions.ToBoolean(crud.result) == true)
                    {
                        MessageBox.Show("User has been deleted in the database.", "Success", MessageBoxButtons.OK);
                    }
                    // Call frm_adduser_Load(sender, e)
                    funtion.cleartextForm(this);
                    btn_close_Click(sender, e);
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_listUser_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    var withBlock = dtg_listUser.CurrentRow;
                    lbl_id.Text = Conversions.ToString(withBlock.Cells[0].Value);
                    txt_name.Text = Conversions.ToString(withBlock.Cells[1].Value);
                    txt_username.Text = Conversions.ToString(withBlock.Cells[2].Value);
                    cbo_type.Text = Conversions.ToString(withBlock.Cells[3].Value);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dtg_listUser_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                {
                    var withBlock = dtg_listUser.CurrentRow;
                    lbl_id.Text = Conversions.ToString(withBlock.Cells[0].Value);
                    txt_name.Text = Conversions.ToString(withBlock.Cells[1].Value);
                    txt_username.Text = Conversions.ToString(withBlock.Cells[2].Value);
                    cbo_type.Text = Conversions.ToString(withBlock.Cells[3].Value);
                }
            }
            catch (Exception ex)
            {

            }
        }



        private void lbl_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbl_id.Text == "id")
                {

                    btn_update.Enabled = false;
                    btn_delete.Enabled = false;
                    btn_saveuser.Enabled = true;
                }

                else
                {
                    btn_saveuser.Enabled = false;
                    btn_update.Enabled = true;
                    btn_delete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
    }
}