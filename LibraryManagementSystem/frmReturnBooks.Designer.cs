using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmReturnBooks : Form
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
            components = new System.ComponentModel.Container();
            TabControl3 = new TabControl();
            TabPage5 = new TabPage();
            GroupBox3 = new GroupBox();
            txtSearchPborrower = new TextBox();
            txtSearchPborrower.TextChanged += new EventHandler(txtSearchPborrower_TextChanged);
            txtSearchPborrower.KeyPress += new KeyPressEventHandler(txtSearchPborrower_KeyPress);
            Label27 = new Label();
            dtg_RlistReturn = new DataGridView();
            dtg_RlistReturn.Click += new EventHandler(dtg_RlistReturn_Click);
            grp_Rgroup = new GroupBox();
            txtRname = new TextBox();
            cboRborrowerId = new TextBox();
            txtRbookTitle = new TextBox();
            txtRauthor = new TextBox();
            txtRdescription = new TextBox();
            GroupBox2 = new GroupBox();
            lbl_accessionNo = new Label();
            lbl_transid = new Label();
            lbl_borrowerId = new Label();
            Label18 = new Label();
            Label9 = new Label();
            Label3 = new Label();
            Label8 = new Label();
            GroupBox5 = new GroupBox();
            lbl_Rduedate = new Label();
            lbl_rpayments = new Label();
            lbl_Rchange = new Label();
            Label24 = new Label();
            Label23 = new Label();
            txt_RtenAmount = new TextBox();
            Label22 = new Label();
            Label21 = new Label();
            Label25 = new Label();
            txtRCopyBorrowed = new TextBox();
            Label14 = new Label();
            Label11 = new Label();
            txtRRqty = new TextBox();
            txtRRqty.KeyPress += new KeyPressEventHandler(txtRRqty_KeyPress);
            btnNew = new Button();
            btnNew.Click += new EventHandler(btnNew_Click);
            btn_Rsave = new Button();
            btn_Rsave.Click += new EventHandler(btn_Rsave_Click);
            TabPage6 = new TabPage();
            Label4 = new Label();
            txtrbooksSearch = new TextBox();
            txtrbooksSearch.TextChanged += new EventHandler(txtrbooksSearch_TextChanged);
            dtgListreturned = new DataGridView();
            check_due = new Timer(components);
            check_due.Tick += new EventHandler(check_due_Tick);
            TabControl3.SuspendLayout();
            TabPage5.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_RlistReturn).BeginInit();
            grp_Rgroup.SuspendLayout();
            GroupBox2.SuspendLayout();
            GroupBox5.SuspendLayout();
            TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListreturned).BeginInit();
            SuspendLayout();
            // 
            // TabControl3
            // 
            TabControl3.Anchor = AnchorStyles.Top;
            TabControl3.Controls.Add(TabPage5);
            TabControl3.Controls.Add(TabPage6);
            TabControl3.Location = new Point(3, 6);
            TabControl3.Name = "TabControl3";
            TabControl3.SelectedIndex = 0;
            TabControl3.Size = new Size(852, 452);
            TabControl3.TabIndex = 6;
            // 
            // TabPage5
            // 
            TabPage5.Controls.Add(GroupBox3);
            TabPage5.Controls.Add(grp_Rgroup);
            TabPage5.Controls.Add(btnNew);
            TabPage5.Controls.Add(btn_Rsave);
            TabPage5.Location = new Point(4, 22);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(844, 426);
            TabPage5.TabIndex = 0;
            TabPage5.Text = "Unreturn Books";
            TabPage5.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(txtSearchPborrower);
            GroupBox3.Controls.Add(Label27);
            GroupBox3.Controls.Add(dtg_RlistReturn);
            GroupBox3.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox3.Location = new Point(6, 6);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(406, 414);
            GroupBox3.TabIndex = 1;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "View Details of Unreturn Books";
            // 
            // txtSearchPborrower
            // 
            txtSearchPborrower.Location = new Point(117, 24);
            txtSearchPborrower.Name = "txtSearchPborrower";
            txtSearchPborrower.Size = new Size(283, 25);
            txtSearchPborrower.TabIndex = 25;
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.Location = new Point(27, 27);
            Label27.Name = "Label27";
            Label27.Size = new Size(84, 17);
            Label27.TabIndex = 24;
            Label27.Text = "Borrower Id :";
            // 
            // dtg_RlistReturn
            // 
            dtg_RlistReturn.AllowUserToAddRows = false;
            dtg_RlistReturn.AllowUserToDeleteRows = false;
            dtg_RlistReturn.AllowUserToResizeColumns = false;
            dtg_RlistReturn.AllowUserToResizeRows = false;
            dtg_RlistReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtg_RlistReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_RlistReturn.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtg_RlistReturn.Location = new Point(6, 55);
            dtg_RlistReturn.MultiSelect = false;
            dtg_RlistReturn.Name = "dtg_RlistReturn";
            dtg_RlistReturn.RowHeadersVisible = false;
            dtg_RlistReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_RlistReturn.Size = new Size(394, 353);
            dtg_RlistReturn.TabIndex = 0;
            // 
            // grp_Rgroup
            // 
            grp_Rgroup.Controls.Add(txtRname);
            grp_Rgroup.Controls.Add(cboRborrowerId);
            grp_Rgroup.Controls.Add(txtRbookTitle);
            grp_Rgroup.Controls.Add(txtRauthor);
            grp_Rgroup.Controls.Add(txtRdescription);
            grp_Rgroup.Controls.Add(GroupBox2);
            grp_Rgroup.Controls.Add(Label18);
            grp_Rgroup.Controls.Add(Label9);
            grp_Rgroup.Controls.Add(Label3);
            grp_Rgroup.Controls.Add(Label8);
            grp_Rgroup.Controls.Add(GroupBox5);
            grp_Rgroup.Controls.Add(Label25);
            grp_Rgroup.Controls.Add(txtRCopyBorrowed);
            grp_Rgroup.Controls.Add(Label14);
            grp_Rgroup.Controls.Add(Label11);
            grp_Rgroup.Controls.Add(txtRRqty);
            grp_Rgroup.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_Rgroup.Location = new Point(425, 17);
            grp_Rgroup.Name = "grp_Rgroup";
            grp_Rgroup.Size = new Size(388, 297);
            grp_Rgroup.TabIndex = 2;
            grp_Rgroup.TabStop = false;
            grp_Rgroup.Text = "Return";
            // 
            // txtRname
            // 
            txtRname.Enabled = false;
            txtRname.Location = new Point(27, 41);
            txtRname.Name = "txtRname";
            txtRname.Size = new Size(345, 25);
            txtRname.TabIndex = 27;
            // 
            // cboRborrowerId
            // 
            cboRborrowerId.Enabled = false;
            cboRborrowerId.Location = new Point(36, 41);
            cboRborrowerId.Name = "cboRborrowerId";
            cboRborrowerId.Size = new Size(65, 25);
            cboRborrowerId.TabIndex = 30;
            // 
            // txtRbookTitle
            // 
            txtRbookTitle.Enabled = false;
            txtRbookTitle.Location = new Point(27, 89);
            txtRbookTitle.Name = "txtRbookTitle";
            txtRbookTitle.Size = new Size(345, 25);
            txtRbookTitle.TabIndex = 29;
            // 
            // txtRauthor
            // 
            txtRauthor.Enabled = false;
            txtRauthor.Location = new Point(27, 137);
            txtRauthor.Name = "txtRauthor";
            txtRauthor.Size = new Size(345, 25);
            txtRauthor.TabIndex = 27;
            // 
            // txtRdescription
            // 
            txtRdescription.Enabled = false;
            txtRdescription.Location = new Point(27, 182);
            txtRdescription.Multiline = true;
            txtRdescription.Name = "txtRdescription";
            txtRdescription.Size = new Size(345, 101);
            txtRdescription.TabIndex = 27;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(lbl_accessionNo);
            GroupBox2.Controls.Add(lbl_transid);
            GroupBox2.Controls.Add(lbl_borrowerId);
            GroupBox2.Location = new Point(515, 116);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(25, 10);
            GroupBox2.TabIndex = 25;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "ID's Secret";
            // 
            // lbl_accessionNo
            // 
            lbl_accessionNo.AutoSize = true;
            lbl_accessionNo.Location = new Point(56, 42);
            lbl_accessionNo.Name = "lbl_accessionNo";
            lbl_accessionNo.Size = new Size(88, 17);
            lbl_accessionNo.TabIndex = 5;
            lbl_accessionNo.Text = "Accession #  :";
            // 
            // lbl_transid
            // 
            lbl_transid.AutoSize = true;
            lbl_transid.Location = new Point(59, 59);
            lbl_transid.Name = "lbl_transid";
            lbl_transid.Size = new Size(48, 17);
            lbl_transid.TabIndex = 24;
            lbl_transid.Text = "transid";
            // 
            // lbl_borrowerId
            // 
            lbl_borrowerId.AutoSize = true;
            lbl_borrowerId.Location = new Point(56, 25);
            lbl_borrowerId.Name = "lbl_borrowerId";
            lbl_borrowerId.Size = new Size(78, 17);
            lbl_borrowerId.TabIndex = 21;
            lbl_borrowerId.Text = "borrower id";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Location = new Point(28, 21);
            Label18.Name = "Label18";
            Label18.Size = new Size(108, 17);
            Label18.TabIndex = 19;
            Label18.Text = "Borrower Name :";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(24, 165);
            Label9.Name = "Label9";
            Label9.Size = new Size(81, 17);
            Label9.TabIndex = 11;
            Label9.Text = "Description :";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(24, 117);
            Label3.Name = "Label3";
            Label3.Size = new Size(54, 17);
            Label3.TabIndex = 16;
            Label3.Text = "Author :";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(24, 69);
            Label8.Name = "Label8";
            Label8.Size = new Size(72, 17);
            Label8.TabIndex = 7;
            Label8.Text = "Book Title :";
            // 
            // GroupBox5
            // 
            GroupBox5.Controls.Add(lbl_Rduedate);
            GroupBox5.Controls.Add(lbl_rpayments);
            GroupBox5.Controls.Add(lbl_Rchange);
            GroupBox5.Controls.Add(Label24);
            GroupBox5.Controls.Add(Label23);
            GroupBox5.Controls.Add(txt_RtenAmount);
            GroupBox5.Controls.Add(Label22);
            GroupBox5.Controls.Add(Label21);
            GroupBox5.Location = new Point(506, 144);
            GroupBox5.Name = "GroupBox5";
            GroupBox5.Size = new Size(45, 25);
            GroupBox5.TabIndex = 4;
            GroupBox5.TabStop = false;
            GroupBox5.Text = "do not touch.Time and Days for the future used. ";
            // 
            // lbl_Rduedate
            // 
            lbl_Rduedate.AutoSize = true;
            lbl_Rduedate.Location = new Point(71, 26);
            lbl_Rduedate.Name = "lbl_Rduedate";
            lbl_Rduedate.Size = new Size(53, 17);
            lbl_Rduedate.TabIndex = 7;
            lbl_Rduedate.Text = "Label25";
            // 
            // lbl_rpayments
            // 
            lbl_rpayments.AutoSize = true;
            lbl_rpayments.Location = new Point(71, 52);
            lbl_rpayments.Name = "lbl_rpayments";
            lbl_rpayments.Size = new Size(53, 17);
            lbl_rpayments.TabIndex = 4;
            lbl_rpayments.Text = "Label25";
            // 
            // lbl_Rchange
            // 
            lbl_Rchange.AutoSize = true;
            lbl_Rchange.Location = new Point(75, 122);
            lbl_Rchange.Name = "lbl_Rchange";
            lbl_Rchange.Size = new Size(53, 17);
            lbl_Rchange.TabIndex = 6;
            lbl_Rchange.Text = "Label26";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Location = new Point(15, 122);
            Label24.Name = "Label24";
            Label24.Size = new Size(59, 17);
            Label24.TabIndex = 5;
            Label24.Text = "Change :";
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.Location = new Point(6, 87);
            Label23.Name = "Label23";
            Label23.Size = new Size(119, 17);
            Label23.TabIndex = 3;
            Label23.Text = "Tendered Amount :";
            // 
            // txt_RtenAmount
            // 
            txt_RtenAmount.Location = new Point(132, 84);
            txt_RtenAmount.Name = "txt_RtenAmount";
            txt_RtenAmount.Size = new Size(177, 25);
            txt_RtenAmount.TabIndex = 2;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Location = new Point(6, 52);
            Label22.Name = "Label22";
            Label22.Size = new Size(70, 17);
            Label22.TabIndex = 1;
            Label22.Text = "Payments :";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Location = new Point(6, 26);
            Label21.Name = "Label21";
            Label21.Size = new Size(70, 17);
            Label21.TabIndex = 0;
            Label21.Text = "Over Due :";
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.Location = new Point(28, 44);
            Label25.Name = "Label25";
            Label25.Size = new Size(84, 17);
            Label25.TabIndex = 22;
            Label25.Text = "Borrower Id :";
            Label25.Visible = false;
            // 
            // txtRCopyBorrowed
            // 
            txtRCopyBorrowed.Enabled = false;
            txtRCopyBorrowed.Location = new Point(27, 231);
            txtRCopyBorrowed.Name = "txtRCopyBorrowed";
            txtRCopyBorrowed.Size = new Size(147, 25);
            txtRCopyBorrowed.TabIndex = 27;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(189, 211);
            Label14.Name = "Label14";
            Label14.Size = new Size(77, 17);
            Label14.TabIndex = 11;
            Label14.Text = "Return Qty :";
            Label14.Visible = false;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(23, 214);
            Label11.Name = "Label11";
            Label11.Size = new Size(157, 17);
            Label11.TabIndex = 10;
            Label11.Text = "No. of Copies Borrowed :";
            // 
            // txtRRqty
            // 
            txtRRqty.Location = new Point(192, 231);
            txtRRqty.Name = "txtRRqty";
            txtRRqty.Size = new Size(113, 25);
            txtRRqty.TabIndex = 8;
            txtRRqty.Visible = false;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(545, 320);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(123, 63);
            btnNew.TabIndex = 0;
            btnNew.Text = "Clear";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btn_Rsave
            // 
            btn_Rsave.Cursor = Cursors.Hand;
            btn_Rsave.FlatStyle = FlatStyle.Flat;
            btn_Rsave.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Rsave.Location = new Point(425, 320);
            btn_Rsave.Name = "btn_Rsave";
            btn_Rsave.Size = new Size(118, 63);
            btn_Rsave.TabIndex = 0;
            btn_Rsave.Text = "Return";
            btn_Rsave.UseVisualStyleBackColor = true;
            // 
            // TabPage6
            // 
            TabPage6.Controls.Add(Label4);
            TabPage6.Controls.Add(txtrbooksSearch);
            TabPage6.Controls.Add(dtgListreturned);
            TabPage6.Location = new Point(4, 22);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(844, 426);
            TabPage6.TabIndex = 1;
            TabPage6.Text = "History";
            TabPage6.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(426, 8);
            Label4.Name = "Label4";
            Label4.Size = new Size(86, 25);
            Label4.TabIndex = 2;
            Label4.Text = "Search :";
            // 
            // txtrbooksSearch
            // 
            txtrbooksSearch.BackColor = Color.White;
            txtrbooksSearch.Font = new Font("Microsoft Sans Serif", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtrbooksSearch.Location = new Point(517, 3);
            txtrbooksSearch.Name = "txtrbooksSearch";
            txtrbooksSearch.Size = new Size(320, 30);
            txtrbooksSearch.TabIndex = 1;
            // 
            // dtgListreturned
            // 
            dtgListreturned.AllowUserToAddRows = false;
            dtgListreturned.AllowUserToDeleteRows = false;
            dtgListreturned.AllowUserToResizeColumns = false;
            dtgListreturned.AllowUserToResizeRows = false;
            dtgListreturned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgListreturned.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListreturned.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgListreturned.Location = new Point(5, 42);
            dtgListreturned.Name = "dtgListreturned";
            dtgListreturned.RowHeadersVisible = false;
            dtgListreturned.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListreturned.Size = new Size(835, 378);
            dtgListreturned.TabIndex = 0;
            // 
            // frmReturnBooks
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 464);
            Controls.Add(TabControl3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReturnBooks";
            Text = "frmReturnBooks";
            TabControl3.ResumeLayout(false);
            TabPage5.ResumeLayout(false);
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_RlistReturn).EndInit();
            grp_Rgroup.ResumeLayout(false);
            grp_Rgroup.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox5.ResumeLayout(false);
            GroupBox5.PerformLayout();
            TabPage6.ResumeLayout(false);
            TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListreturned).EndInit();
            Load += new EventHandler(frmReturn_Load);
            ResumeLayout(false);

        }

        internal TabControl TabControl3;
        internal TabPage TabPage5;
        internal GroupBox GroupBox3;
        internal TextBox txtSearchPborrower;
        internal Label Label27;
        internal DataGridView dtg_RlistReturn;
        internal GroupBox grp_Rgroup;
        internal TextBox txtRname;
        internal TextBox cboRborrowerId;
        internal TextBox txtRbookTitle;
        internal TextBox txtRauthor;
        internal TextBox txtRdescription;
        internal GroupBox GroupBox2;
        internal Label lbl_accessionNo;
        internal Label lbl_transid;
        internal Label lbl_borrowerId;
        internal Label Label18;
        internal Label Label9;
        internal Label Label3;
        internal Label Label8;
        internal GroupBox GroupBox5;
        internal Label lbl_Rduedate;
        internal Label lbl_rpayments;
        internal Label lbl_Rchange;
        internal Label Label24;
        internal Label Label23;
        internal TextBox txt_RtenAmount;
        internal Label Label22;
        internal Label Label21;
        internal Label Label25;
        internal TextBox txtRCopyBorrowed;
        internal Label Label14;
        internal Label Label11;
        internal TextBox txtRRqty;
        internal Button btnNew;
        internal Button btn_Rsave;
        internal TabPage TabPage6;
        internal Label Label4;
        internal TextBox txtrbooksSearch;
        internal DataGridView dtgListreturned;
        internal Timer check_due;
    }
}