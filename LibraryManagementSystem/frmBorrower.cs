using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{

    public partial class frmBorrower
    {
        public frmBorrower()
        {
            InitializeComponent();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_bid.Text) | string.IsNullOrEmpty(txt_fname.Text) | string.IsNullOrEmpty(txt_lname.Text) | string.IsNullOrEmpty(txt_mname.Text) | string.IsNullOrEmpty(txtCourse.Text))

                {
                    funtion.emptymessage();
                }
                else
                {
                    // 'conditionin the gender of a borrower
                    string gender;
                    if (rdio_female.Checked == true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Male";
                    }



                    crud.sql = "SELECT * FROM `tblborrower` WHERE `BorrowerId`=" + txt_bid.Text;

                    crud.sqladd = "insert into tblborrower (`BorrowerId`, `Firstname`, `Lastname`, `MiddleName`, `Address`, " + "`Sex`, `ContactNo`, `CourseYear`,  `BorrowerPhoto`,`BorrowerType`,Stats)" + "values ('" + txt_bid.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_mname.Text + "','" + rch_address.Text + "','" + gender + "','" + txtContact.Text + "','" + txtCourse.Text + "','" + Path.GetFileName(PictureBox1.ImageLocation) + "','Student','Active')";





                    crud.sqledit = "update  tblborrower set  `Firstname`='" + txt_fname.Text + "', `Lastname`='" + txt_lname.Text + "', `MiddleName`='" + txt_mname.Text + "', `Address`='" + rch_address.Text + "', `Sex`='" + gender + "', `ContactNo` ='" + txtContact.Text + "', `CourseYear`='" + txtCourse.Text.ToUpper() + "', `BorrowerPhoto`='" + Path.GetFileName(PictureBox1.ImageLocation) + "', `BorrowerType`='Student' where `BorrowerId`='" + txt_bid.Text + "'";




                    crud.save_or_update(crud.sql, crud.sqladd, crud.sqledit, "Borrower has been updated in the database.", "New borrower has been added in the database.");


                    if (!string.IsNullOrEmpty(txtPhoto.Text))
                    {
                        File.Copy(txtPhoto.Text, Application.StartupPath + @"\BorrowerPhoto\" + Path.GetFileName(PictureBox1.ImageLocation), true);
                    }

                    // ''''''''''''''''''''''''''''''''''''''''''

                    // Call frmBorrower_Load(sender, e)
                    // txt_bid.Clear()
                    btn_New_Click(sender, e);
                }
            }

            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    var withBlock = OpenFileDialog1;

                    // CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                    withBlock.CheckFileExists = true;


                    // CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                    withBlock.CheckPathExists = true;


                    // GET AND SET THE DEFAULT EXTENSION
                    withBlock.DefaultExt = "jpg";


                    // RETURN THE FILE LINKED TO THE LNK FILE
                    withBlock.DereferenceLinks = true;

                    // SET THE FILE NAME TO EMPTY 
                    withBlock.FileName = "";

                    // FILTERING THE FILES
                    withBlock.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*";

                    // SET THIS FOR ONE FILE SELECTION ONLY.
                    withBlock.Multiselect = false;



                    // SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                    withBlock.RestoreDirectory = true;

                    // SET THE TITLE OF THE DIALOG BOX.
                    withBlock.Title = "Select a file to open";

                    // ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                    withBlock.ValidateNames = true;

                    if (withBlock.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            txtPhoto.Text = withBlock.FileName;
                            // PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                            PictureBox1.ImageLocation = withBlock.FileName;
                            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception fileException)
                        {
                            throw fileException;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text);
            }

        }

        private void txt_bid_TextChanged(object sender, EventArgs e)
        {
            crud.reloadtxt("SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" + txt_bid.Text + "'");

            if (crud.dt.Rows.Count > 0)
            {
                txt_fname.Text = Conversions.ToString(crud.dt.Rows[0]["Firstname"]);
                txt_lname.Text = Conversions.ToString(crud.dt.Rows[0]["Lastname"]);
                txt_mname.Text = Conversions.ToString(crud.dt.Rows[0]["MiddleName"]);
                rch_address.Text = Conversions.ToString(crud.dt.Rows[0]["Address"]);
                txtContact.Text = Conversions.ToString(crud.dt.Rows[0]["ContactNo"]);
                txtCourse.Text = Conversions.ToString(crud.dt.Rows[0]["CourseYear"]);
                PictureBox1.ImageLocation = Conversions.ToString(Operators.ConcatenateObject(Application.StartupPath + @"\BorrowerPhoto\", crud.dt.Rows[0]["BorrowerPhoto"]));


                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(crud.dt.Rows[0]["Sex"], "Female", false)))
                {
                    rdio_female.Checked = true;
                }
                else
                {
                    rdio_male.Checked = true;
                }
                // btn_edit.Enabled = True
                btn_delete.Enabled = true;
            }
            // btn_save.Enabled = False
            else
            {

                clearme();
                // btn_edit.Enabled = False
                btn_delete.Enabled = false;
                // btn_save.Enabled = True 
                // 'cleartext(grp_addBorrower)
            }
        }
        public void clearme()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mname.Clear();
            rch_address.Clear();
            txtContact.Clear();
            txtCourse.Clear();
            txtPhoto.Clear();
        }

        private void frmBorrower_Load(object sender, EventArgs e)
        {
            crud.sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear` as 'Course/Year' FROM `tblborrower` WHERE Stats='Active' ";
            crud.reloadDtg(crud.sql, dtg_ABorrowLists);

            funtion.select_navigation("select BorrowerId from tblborrower");
            btn_delete.Enabled = false;
        }

        private void dtg_ABorrowLists_Click(object sender, EventArgs e)
        {
            try
            {
                txt_bid.Text = Conversions.ToString(dtg_ABorrowLists.CurrentRow.Cells[0].Value);
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            funtion.cleartextForm(this);
            crud.sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`  as 'Course/Year' FROM `tblborrower`  WHERE Stats='Active'";
            crud.reloadDtg(crud.sql, dtg_ABorrowLists);
            PictureBox1.ImageLocation = "";
            btn_delete.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            // Dim image_title, image_title1 As String
            // 'To get file name with extension : output=ImageName.gif
            // image_title = Path.GetFileName(PictureBox1.ImageLocation)
            // MsgBox(image_title)
            // 'To get file name without extension : output=ImageName
            // image_title1 = Path.GetFileNameWithoutExtension(PictureBox1.ImageLocation)
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            funtion.select_navigation("select BorrowerId from tblborrower");
            if (funtion.inc != funtion.maxrows - 1)
            {
                funtion.inc = funtion.inc + 1;
                funtion.navagate_records(txt_bid);
            }
            else if (funtion.inc == funtion.maxrows - 1)
            {
                Interaction.MsgBox("No more rows", MsgBoxStyle.Information);
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            funtion.select_navigation("select BorrowerId from tblborrower");
            if (funtion.inc > 0)
            {
                funtion.inc = funtion.inc - 1;
                funtion.navagate_records(txt_bid);
            }
            else if (Conversions.ToBoolean(funtion.inc - 1))
            {
                Interaction.MsgBox("First records", MsgBoxStyle.Information);
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                funtion.select_navigation("select BorrowerId from tblborrower");
                if (funtion.inc != funtion.maxrows - 1)
                {
                    funtion.inc = funtion.maxrows - 1;
                    funtion.navagate_records(txt_bid);
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                funtion.select_navigation("select BorrowerId from tblborrower");
                funtion.inc = 0;
                funtion.navagate_records(txt_bid);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void txtPhoto_TextChanged(object sender, EventArgs e)
        {
            PictureBox1.ImageLocation = txtPhoto.Text;
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this borrower?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE `tblborrower` SET  `Stats` =  'NotActive' WHERE `BorrowerId` ='", dtg_ABorrowLists.CurrentRow.Cells[0].Value), "'"));
                crud.result = Conversions.ToString(crud.deletes(crud.sql));
                if (Conversions.ToBoolean(crud.result) == true)
                {
                    MessageBox.Show("Borrower has been deleted in the database.", "Success", MessageBoxButtons.OK);
                }
                // Call frm_adduser_Load(sender, e)
                // cleartext(Me)
                btn_New_Click(sender, e);
            }
        }

       
    }
}