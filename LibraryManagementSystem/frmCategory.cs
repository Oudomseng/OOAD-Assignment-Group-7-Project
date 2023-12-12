using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmCategory
    {
        private object categoryid = 0;

        public frmCategory()
        {
            InitializeComponent();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text))
            {
                Interaction.MsgBox("Field is required.", MsgBoxStyle.Exclamation);
            }
            else
            {
                crud.sql = Conversions.ToString(Operators.ConcatenateObject("Select * From tblcategory WHERE CategoryId = ", categoryid));

                crud.sqladd = "INSERT INTO `tblcategory` (`Category`,`DDecimal`) VALUES ('" + txtCategory.Text + "','" + txtDeweyDecimal.Text + "')";

                crud.sqledit = Conversions.ToString(Operators.ConcatenateObject("UPDATE `tblcategory` SET `Category`='" + txtCategory.Text + "',`DDecimal`='" + txtDeweyDecimal.Text + "' WHERE CategoryId=", categoryid));

                crud.save_or_update(crud.sql, crud.sqladd, crud.sqledit, "Category has been updated in the database.", "New category has been saved in the database.");

                frmCategory_Load(sender, e);

            }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void dtglist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                {
                    var withBlock = dtglist;
                    categoryid = withBlock.CurrentRow.Cells[0].Value;
                    txtCategory.Text = Conversions.ToString(withBlock.CurrentRow.Cells[1].Value);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            categoryid = 0;
            txtCategory.Clear();
            txtDeweyDecimal.Clear();
            crud.sql = "Select CategoryId,`Category`,`DDecimal` as 'DeweyDecimal' From tblcategory WHERE Category !='ALL'";
            crud.reloadDtg(crud.sql, dtglist);
            btndelete.Enabled = false;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            crud.sql = "Select CategoryId,`Category`,`DDecimal` as 'DeweyDecimal' From tblcategory WHERE Category !='ALL' AND  Category Like '%" + txtSearch.Text + "%'";
            crud.reloadDtg(crud.sql, dtglist);
        }

        private void dtglist_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    var withBlock = dtglist;
                    categoryid = withBlock.CurrentRow.Cells[0].Value;
                    txtCategory.Text = Conversions.ToString(withBlock.CurrentRow.Cells[1].Value);
                    txtDeweyDecimal.Text = Conversions.ToString(withBlock.CurrentRow.Cells[2].Value);

                    btndelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                crud.sql = Conversions.ToString(Operators.ConcatenateObject("Delete From tblcategory WHERE CategoryId = ", dtglist.CurrentRow.Cells[0].Value));
                crud.deletes(crud.sql);
                Interaction.MsgBox("Data has been deleted", MsgBoxStyle.Exclamation);
                btnnew_Click(sender, e);
            }
            catch (Exception ex)
            {

            }
        }
    }
}