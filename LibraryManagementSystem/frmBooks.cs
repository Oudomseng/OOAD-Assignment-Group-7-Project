using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmBooks
    {
        public frmBooks()
        {
            InitializeComponent();
        }
        private void txtAccessionNo_TextChanged(object sender, EventArgs e)
        {


            try
            {
                crud.sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` , `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType ,DeweyDecimal,Remark  FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND  `AccessionNo`= '" + txtAccessionNo.Text + "'";
                crud.reloadtxt(crud.sql);
                if (crud.dt.Rows.Count > 0)
                {
                    {
                        var withBlock = crud.dt.Rows[0];
                        txtTitle.Text = Conversions.ToString(withBlock[1]);
                        txtDesc.Text = Conversions.ToString(withBlock[2]);
                        txtAuthor.Text = Conversions.ToString(withBlock[3]);
                        dtpDatePublish.Value = Conversions.ToDate(Strings.Format(withBlock[4], "MM/dd/yyyy"));
                        txtPublisher.Text = Conversions.ToString(withBlock[5]);
                        cboCategory.Text = Conversions.ToString(withBlock[6]);
                        cboType.Text = Conversions.ToString(withBlock[7]);
                        txtDeweyDecimal.Text = Conversions.ToString(withBlock[9]);


                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                    }
                }
                else
                {
                    txtTitle.Clear();
                    txtDesc.Clear();
                    txtAuthor.Clear();
                    txtPublisher.Clear();
                    cboType.Text = "Unknown";

                    funtion.cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory");


                    dtpDatePublish.Value = Conversions.ToDate(Strings.Format(DateTime.Now, "MM/dd/yyyy"));

                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                Text = ex.Message;
            }
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);

            crud.sql = Conversions.ToString(Operators.ConcatenateObject("SELECT * FROM `tblcategory` WHERE  `CategoryId`=", cboCategory.SelectedValue));
            crud.reloadtxt(crud.sql);
            txtDeweyDecimal.Text = Conversions.ToString(crud.dt.Rows[0][2]);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            funtion.cleartextForm(this);
            crud.sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price',DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` ";
            crud.reloadDtg(crud.sql, dtgList);
            funtion.cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory WHERE Category !='ALL'  ORDER BY CATEGORY ASC");



            btnUpdate.Enabled = false;

            btnSave.Enabled = true;

            btnDelete.Enabled = false;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            crud.sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price', DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND (`BookTitle` Like '%" + txtSearch.Text + "%' OR `Author` Like '%" + txtSearch.Text + "%' OR `AccessionNo`  Like '%" + txtSearch.Text + "%')";
            crud.reloadDtg(crud.sql, dtgList);
        }
        #region Numbers only


        private void txtAccessionNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8 && !(Conversions.ToString(e.KeyChar) == "."))
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                crud.sql = Conversions.ToString(Operators.ConcatenateObject("SELECT * FROM `tblcategory` WHERE  `CategoryId`=", cboCategory.SelectedValue));
                crud.reloadtxt(crud.sql);
                txtDeweyDecimal.Text = Conversions.ToString(crud.dt.Rows[0][2]);
            }


            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string datePublish = Strings.Format(dtpDatePublish.Value, "yyyy-MM-dd");
                string remarks = "";



                if (string.IsNullOrEmpty(txtAccessionNo.Text) | string.IsNullOrEmpty(txtAuthor.Text) | string.IsNullOrEmpty(txtTitle.Text) | string.IsNullOrEmpty(txtDesc.Text) | string.IsNullOrEmpty(txtPublisher.Text))
                {
                    Interaction.MsgBox("All fields are required to be filled up.", MsgBoxStyle.Exclamation);
                }
                else
                {

                    remarks = "Donate";

                    crud.sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = " + txtAccessionNo.Text;
                    crud.reloadtxt(crud.sql);

                    if (crud.dt.Rows.Count > 0)
                    {
                        Interaction.MsgBox("Accession number is already in used.", MsgBoxStyle.Exclamation);
                        return;
                    }

                    crud.sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" + txtAccessionNo.Text + "'";

                    // adding books
                    crud.sqladd = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into `tblbooks` " + " (`AccessionNo`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`,Status,DeweyDecimal,OverAllQty,Remark,BookType) " + " VALUES ('" + txtAccessionNo.Text + "','" + txtTitle.Text + "','" + txtDesc.Text + "','" + txtAuthor.Text + "','" + datePublish + "','" + txtPublisher.Text + "','", cboCategory.SelectedValue), "','0',1, 'Available' ,'"), txtDeweyDecimal.Text), "',1,'"), remarks), "','"), cboType.Text), "')"));
                    // updating books

                    crud.sqledit = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update `tblbooks` Set `BookTitle`='" + txtTitle.Text + "', `BookDesc`='" + txtDesc.Text + "', `Author`='" + txtAuthor.Text + "', `PublishDate`='" + datePublish + "', `BookPublisher`='" + txtPublisher.Text + "', `CategoryId`='", cboCategory.SelectedValue), "',`DeweyDecimal`='"), txtDeweyDecimal.Text), "',Remark='"), remarks), "',BookType='"), cboType.Text), "'  WHERE `AccessionNo`='"), txtAccessionNo.Text), "'"));


                    crud.save_or_update(crud.sql, crud.sqladd, crud.sqledit, "Books has been updated in the database.", "New books has been saved in the database.");


                    // sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"
                    // reloadtxt(sql)
                    // If dt.Rows.Count > 0 Then

                    // ''put a codes here  
                    // sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" & txtTitle.Text & "'"
                    // updates(sql)

                    // Else
                    crud.sql = "SELECT * FROM `tblbooknumber` WHERE `BOOKTITLE` = '" + txtTitle.Text + "'";
                    crud.reloadtxt(crud.sql);
                    if (crud.dt.Rows.Count > 0)
                    {

                        // 'put a codes here  
                        crud.sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" + txtTitle.Text + "'";
                        crud.updates(crud.sql);
                    }

                    else
                    {
                        crud.sql = "INSERT INTO  `tblbooknumber` (`BOOKTITLE`,`QTY`,`Desc`, `Author`, `PublishDate`, `Publisher`) " + " VALUES ('" + txtTitle.Text + "',1,'" + txtDesc.Text + "','" + txtAuthor.Text + "','" + datePublish + "','" + txtPublisher.Text + "')";
                        crud.create(crud.sql);
                    }

                    frmBooks_Load(sender, e);

                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string datePublish = Strings.Format(dtpDatePublish.Value, "yyyy-MM-dd");
                string remarks = "";



                if (string.IsNullOrEmpty(txtAccessionNo.Text) | string.IsNullOrEmpty(txtAuthor.Text) | string.IsNullOrEmpty(txtTitle.Text) | string.IsNullOrEmpty(txtDesc.Text) | string.IsNullOrEmpty(txtPublisher.Text))
                {
                    Interaction.MsgBox("All fields are required to filled up.", MsgBoxStyle.Exclamation);
                }
                else
                {
                    // If rdoDonate.Checked = True Then
                    remarks = "Donate";
                    // ElseIf rdoPurchased.Checked = True Then
                    // remarks = "Purchased"
                    // End If


                    crud.sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" + txtAccessionNo.Text + "'";
                    crud.reloadtxt(crud.sql);

                    if (crud.dt.Rows.Count > 0)
                    {

                        crud.sqledit = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update `tblbooks` Set `BookTitle`='" + txtTitle.Text + "', `BookDesc`='" + txtDesc.Text + "', `Author`='" + txtAuthor.Text + "', `PublishDate`='" + datePublish + "', `BookPublisher`='" + txtPublisher.Text + "', `CategoryId`='", cboCategory.SelectedValue), "', `DeweyDecimal`='"), txtDeweyDecimal.Text), "',Remark='"), remarks), "',BookType='"), cboType.Text), "'  WHERE `AccessionNo`='"), txtAccessionNo.Text), "'"));


                        crud.save_or_update(crud.sql, crud.sqladd, crud.sqledit, "Books has been updated in the database.", "New books has been saved in the database.");

                        frmBooks_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            crud.sql = "DELETE FROM `tblbooks` WHERE `AccessionNo` = '" + txtAccessionNo.Text + "'";

            crud.deletes(crud.sql);

            Interaction.MsgBox("Book has been deleted!", MsgBoxStyle.Information);
            btnNew_Click(sender, e);
        }
        private void cboType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                {
                    var withBlock = dtgList;

                    txtAccessionNo.Text = Conversions.ToString(withBlock.CurrentRow.Cells[0].Value);
                    txtTitle.Text = Conversions.ToString(withBlock.CurrentRow.Cells[1].Value);
                    txtDesc.Text = Conversions.ToString(withBlock.CurrentRow.Cells[2].Value);
                    txtAuthor.Text = Conversions.ToString(withBlock.CurrentRow.Cells[3].Value);
                    dtpDatePublish.Value = Conversions.ToDate(Strings.Format(withBlock.CurrentRow.Cells[4].Value, "MM/dd/yyyy"));
                    txtPublisher.Text = Conversions.ToString(withBlock.CurrentRow.Cells[5].Value);
                    cboCategory.Text = Conversions.ToString(withBlock.CurrentRow.Cells[6].Value);
                    cboType.Text = Conversions.ToString(withBlock.CurrentRow.Cells[7].Value);

                    txtDeweyDecimal.Text = Conversions.ToString(withBlock.CurrentRow.Cells[9].Value);


                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}