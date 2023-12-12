using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmBorrower : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtg_ABorrowLists = new System.Windows.Forms.DataGridView();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.rdio_female = new System.Windows.Forms.RadioButton();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.rch_address = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.rdio_male = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnDisable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btn_last
            // 
            this.btn_last.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Location = new System.Drawing.Point(736, 221);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(51, 24);
            this.btn_last.TabIndex = 60;
            this.btn_last.Text = ">>|";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(679, 221);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(51, 24);
            this.btn_next.TabIndex = 59;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(753, 174);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(68, 44);
            this.btn_New.TabIndex = 57;
            this.btn_New.Text = "Clear";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_first
            // 
            this.btn_first.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(565, 221);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(51, 24);
            this.btn_first.TabIndex = 61;
            this.btn_first.Text = "|<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(679, 175);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 44);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(609, 175);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(66, 44);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(622, 221);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(51, 24);
            this.btn_prev.TabIndex = 58;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(125, 196);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(357, 25);
            this.txtContact.TabIndex = 51;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(29, 202);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 17);
            this.Label7.TabIndex = 52;
            this.Label7.Text = "Contact No. : ";
            // 
            // txtCourse
            // 
            this.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(607, 146);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(216, 25);
            this.txtCourse.TabIndex = 50;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(514, 149);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 17);
            this.Label6.TabIndex = 53;
            this.Label6.Text = "Course/Year :";
            // 
            // dtg_ABorrowLists
            // 
            this.dtg_ABorrowLists.AllowUserToAddRows = false;
            this.dtg_ABorrowLists.AllowUserToDeleteRows = false;
            this.dtg_ABorrowLists.AllowUserToResizeColumns = false;
            this.dtg_ABorrowLists.AllowUserToResizeRows = false;
            this.dtg_ABorrowLists.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_ABorrowLists.Location = new System.Drawing.Point(6, 249);
            this.dtg_ABorrowLists.Name = "dtg_ABorrowLists";
            this.dtg_ABorrowLists.RowHeadersVisible = false;
            this.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ABorrowLists.Size = new System.Drawing.Size(846, 210);
            this.dtg_ABorrowLists.TabIndex = 49;
            this.dtg_ABorrowLists.Click += new System.EventHandler(this.dtg_ABorrowLists_Click);
            // 
            // txt_bid
            // 
            this.txt_bid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_bid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bid.Location = new System.Drawing.Point(125, 11);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(357, 25);
            this.txt_bid.TabIndex = 35;
            this.txt_bid.TextChanged += new System.EventHandler(this.txt_bid_TextChanged);
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(125, 40);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(357, 25);
            this.txt_fname.TabIndex = 36;
            // 
            // rdio_female
            // 
            this.rdio_female.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdio_female.AutoSize = true;
            this.rdio_female.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_female.Location = new System.Drawing.Point(187, 175);
            this.rdio_female.Name = "rdio_female";
            this.rdio_female.Size = new System.Drawing.Size(67, 21);
            this.rdio_female.TabIndex = 47;
            this.rdio_female.TabStop = true;
            this.rdio_female.Text = "Female";
            this.rdio_female.UseVisualStyleBackColor = true;
            // 
            // txt_mname
            // 
            this.txt_mname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(125, 98);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(357, 25);
            this.txt_mname.TabIndex = 38;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(37, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 17);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Borrower Id :";
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(125, 69);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(357, 25);
            this.txt_lname.TabIndex = 37;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(41, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 17);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "First Name :";
            // 
            // rch_address
            // 
            this.rch_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rch_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_address.Location = new System.Drawing.Point(125, 127);
            this.rch_address.Name = "rch_address";
            this.rch_address.Size = new System.Drawing.Size(357, 44);
            this.rch_address.TabIndex = 43;
            this.rch_address.Text = "";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(40, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 17);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Last Name :";
            // 
            // rdio_male
            // 
            this.rdio_male.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdio_male.AutoSize = true;
            this.rdio_male.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_male.Location = new System.Drawing.Point(125, 175);
            this.rdio_male.Name = "rdio_male";
            this.rdio_male.Size = new System.Drawing.Size(55, 21);
            this.rdio_male.TabIndex = 46;
            this.rdio_male.TabStop = true;
            this.rdio_male.Text = "Male";
            this.rdio_male.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(24, 101);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 17);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Middle Name :";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(52, 130);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 17);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Address :";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(73, 177);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 17);
            this.Label9.TabIndex = 39;
            this.Label9.Text = "Sex :";
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Enabled = false;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(611, 175);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(64, 44);
            this.btn_edit.TabIndex = 55;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(607, 6);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(216, 136);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 48;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhoto.Location = new System.Drawing.Point(609, 41);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(209, 20);
            this.txtPhoto.TabIndex = 63;
            this.txtPhoto.TextChanged += new System.EventHandler(this.txtPhoto_TextChanged);
            // 
            // btnDisable
            // 
            this.btnDisable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Location = new System.Drawing.Point(679, 175);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(68, 44);
            this.btnDisable.TabIndex = 65;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // frmBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 464);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtg_ABorrowLists);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.rdio_female);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.rch_address);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.rdio_male);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.btnDisable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrower";
            this.Text = "frmBorrower";
            this.Load += new System.EventHandler(this.frmBorrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal OpenFileDialog OpenFileDialog1;
        internal Button btn_last;
        internal Button btn_next;
        internal Button btn_New;
        internal Button btn_first;
        internal Button btn_delete;
        internal Button btn_save;
        internal Button btn_prev;
        internal TextBox txtContact;
        internal Label Label7;
        internal TextBox txtCourse;
        internal Label Label6;
        internal DataGridView dtg_ABorrowLists;
        internal TextBox txt_bid;
        internal TextBox txt_fname;
        internal RadioButton rdio_female;
        internal TextBox txt_mname;
        internal Label Label1;
        internal TextBox txt_lname;
        internal Label Label2;
        internal RichTextBox rch_address;
        internal Label Label3;
        internal RadioButton rdio_male;
        internal Label Label4;
        internal Label Label5;
        internal Label Label9;
        internal Button btn_edit;
        internal PictureBox PictureBox1;
        internal TextBox txtPhoto;
        internal Button btnDisable;
    }
}