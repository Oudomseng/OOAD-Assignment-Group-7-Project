using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmBorrowBooks : Form
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
            TabControl2 = new TabControl();
            TabPage3 = new TabPage();
            btnNew = new Button();
            btnNew.Click += new EventHandler(btnNew_Click);
            btn_Bsave = new Button();
            btn_Bsave.Click += new EventHandler(btn_Bsave_Click);
            GroupBox1 = new GroupBox();
            btnSearchAccesion = new Button();
            btnSearchAccesion.Click += new EventHandler(btnSearchAccesion_Click);
            txtAccesionNumBorrow = new TextBox();
            txtAccesionNumBorrow.TextChanged += new EventHandler(txtAccesionNumBorrow_TextChanged);
            txtAccesionNumBorrow.KeyPress += new KeyPressEventHandler(txtAccesionNumBorrow_KeyPress);
            lblAccessionNumBorrow = new Label();
            txtbooktype = new TextBox();
            txtbooktype.TextChanged += new EventHandler(txtcategory_TextChanged);
            txtpublisher = new TextBox();
            txtDatePublish = new TextBox();
            txtTitle = new TextBox();
            Label6 = new Label();
            txtAuthor = new TextBox();
            Label3 = new Label();
            Label12 = new Label();
            Label1 = new Label();
            Label5 = new Label();
            grp_Bgroup = new GroupBox();
            txtBorrowerId = new TextBox();
            txtBorrowerId.TextChanged += new EventHandler(txtBorrowerId_TextChanged);
            txtBorrowerId.KeyPress += new KeyPressEventHandler(txtBorrowerId_KeyPress);
            btnSearchBorrower = new Button();
            btnSearchBorrower.Click += new EventHandler(btnSearchBorrower_Click);
            cboPurpose = new ComboBox();
            cboPurpose.KeyPress += new KeyPressEventHandler(cboPurpose_KeyPress);
            txtdue = new TextBox();
            txtCourse = new TextBox();
            txtName = new TextBox();
            Label15 = new Label();
            Label13 = new Label();
            Label7 = new Label();
            Label17 = new Label();
            TabPage4 = new TabPage();
            Label2 = new Label();
            txt_Search = new TextBox();
            txt_Search.TextChanged += new EventHandler(txt_Search_TextChanged);
            dtg_BlistOfBooks = new DataGridView();
            check_due = new Timer(components);
            check_due.Tick += new EventHandler(check_due_Tick);
            TabControl2.SuspendLayout();
            TabPage3.SuspendLayout();
            GroupBox1.SuspendLayout();
            grp_Bgroup.SuspendLayout();
            TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_BlistOfBooks).BeginInit();
            SuspendLayout();
            // 
            // TabControl2
            // 
            TabControl2.Anchor = AnchorStyles.Top;
            TabControl2.Controls.Add(TabPage3);
            TabControl2.Controls.Add(TabPage4);
            TabControl2.Location = new Point(4, 6);
            TabControl2.Name = "TabControl2";
            TabControl2.SelectedIndex = 0;
            TabControl2.Size = new Size(848, 453);
            TabControl2.TabIndex = 22;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(btnNew);
            TabPage3.Controls.Add(btn_Bsave);
            TabPage3.Controls.Add(GroupBox1);
            TabPage3.Controls.Add(grp_Bgroup);
            TabPage3.Location = new Point(4, 22);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(840, 427);
            TabPage3.TabIndex = 0;
            TabPage3.Text = "Details";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(551, 264);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(116, 53);
            btnNew.TabIndex = 17;
            btnNew.Text = "Clear";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btn_Bsave
            // 
            btn_Bsave.Cursor = Cursors.Hand;
            btn_Bsave.FlatStyle = FlatStyle.Flat;
            btn_Bsave.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Bsave.Location = new Point(434, 264);
            btn_Bsave.Name = "btn_Bsave";
            btn_Bsave.Size = new Size(116, 53);
            btn_Bsave.TabIndex = 17;
            btn_Bsave.Text = "Borrow";
            btn_Bsave.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(btnSearchAccesion);
            GroupBox1.Controls.Add(txtAccesionNumBorrow);
            GroupBox1.Controls.Add(lblAccessionNumBorrow);
            GroupBox1.Controls.Add(txtbooktype);
            GroupBox1.Controls.Add(txtpublisher);
            GroupBox1.Controls.Add(txtDatePublish);
            GroupBox1.Controls.Add(txtTitle);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(txtAuthor);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label12);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(15, 26);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(413, 291);
            GroupBox1.TabIndex = 14;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Book's Details";
            // 
            // btnSearchAccesion
            // 
            btnSearchAccesion.Cursor = Cursors.Hand;
            btnSearchAccesion.FlatStyle = FlatStyle.Flat;
            btnSearchAccesion.Font = new Font("Segoe UI", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchAccesion.Location = new Point(350, 50);
            btnSearchAccesion.Name = "btnSearchAccesion";
            btnSearchAccesion.Size = new Size(57, 25);
            btnSearchAccesion.TabIndex = 24;
            btnSearchAccesion.Text = "Find";
            btnSearchAccesion.UseVisualStyleBackColor = true;
            // 
            // txtAccesionNumBorrow
            // 
            txtAccesionNumBorrow.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAccesionNumBorrow.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAccesionNumBorrow.Location = new Point(118, 50);
            txtAccesionNumBorrow.Name = "txtAccesionNumBorrow";
            txtAccesionNumBorrow.Size = new Size(226, 25);
            txtAccesionNumBorrow.TabIndex = 17;
            // 
            // lblAccessionNumBorrow
            // 
            lblAccessionNumBorrow.AutoSize = true;
            lblAccessionNumBorrow.Location = new Point(15, 52);
            lblAccessionNumBorrow.Name = "lblAccessionNumBorrow";
            lblAccessionNumBorrow.Size = new Size(97, 17);
            lblAccessionNumBorrow.TabIndex = 16;
            lblAccessionNumBorrow.Text = "Accession No. :";
            // 
            // txtbooktype
            // 
            txtbooktype.Enabled = false;
            txtbooktype.Location = new Point(118, 210);
            txtbooktype.Name = "txtbooktype";
            txtbooktype.Size = new Size(289, 25);
            txtbooktype.TabIndex = 14;
            // 
            // txtpublisher
            // 
            txtpublisher.Enabled = false;
            txtpublisher.Location = new Point(118, 179);
            txtpublisher.Name = "txtpublisher";
            txtpublisher.Size = new Size(289, 25);
            txtpublisher.TabIndex = 14;
            // 
            // txtDatePublish
            // 
            txtDatePublish.Enabled = false;
            txtDatePublish.Location = new Point(118, 148);
            txtDatePublish.Name = "txtDatePublish";
            txtDatePublish.Size = new Size(289, 25);
            txtDatePublish.TabIndex = 14;
            // 
            // txtTitle
            // 
            txtTitle.Enabled = false;
            txtTitle.Location = new Point(118, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(289, 25);
            txtTitle.TabIndex = 13;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(14, 213);
            Label6.Name = "Label6";
            Label6.Size = new Size(97, 17);
            Label6.TabIndex = 11;
            Label6.Text = "Type of Books :";
            // 
            // txtAuthor
            // 
            txtAuthor.Enabled = false;
            txtAuthor.Location = new Point(118, 117);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(289, 25);
            txtAuthor.TabIndex = 13;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(44, 182);
            Label3.Name = "Label3";
            Label3.Size = new Size(68, 17);
            Label3.TabIndex = 11;
            Label3.Text = "Publisher :";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label12.Location = new Point(25, 151);
            Label12.Name = "Label12";
            Label12.Size = new Size(87, 17);
            Label12.TabIndex = 11;
            Label12.Text = "Date Publish :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(73, 84);
            Label1.Name = "Label1";
            Label1.Size = new Size(39, 17);
            Label1.TabIndex = 4;
            Label1.Text = "Title :";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(58, 120);
            Label5.Name = "Label5";
            Label5.Size = new Size(54, 17);
            Label5.TabIndex = 8;
            Label5.Text = "Author :";
            // 
            // grp_Bgroup
            // 
            grp_Bgroup.Controls.Add(txtBorrowerId);
            grp_Bgroup.Controls.Add(btnSearchBorrower);
            grp_Bgroup.Controls.Add(cboPurpose);
            grp_Bgroup.Controls.Add(txtdue);
            grp_Bgroup.Controls.Add(txtCourse);
            grp_Bgroup.Controls.Add(txtName);
            grp_Bgroup.Controls.Add(Label15);
            grp_Bgroup.Controls.Add(Label13);
            grp_Bgroup.Controls.Add(Label7);
            grp_Bgroup.Controls.Add(Label17);
            grp_Bgroup.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_Bgroup.Location = new Point(434, 33);
            grp_Bgroup.Name = "grp_Bgroup";
            grp_Bgroup.Size = new Size(380, 228);
            grp_Bgroup.TabIndex = 15;
            grp_Bgroup.TabStop = false;
            grp_Bgroup.Text = "Borrower's";
            // 
            // txtBorrowerId
            // 
            txtBorrowerId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBorrowerId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBorrowerId.Location = new Point(112, 60);
            txtBorrowerId.Name = "txtBorrowerId";
            txtBorrowerId.Size = new Size(176, 25);
            txtBorrowerId.TabIndex = 24;
            // 
            // btnSearchBorrower
            // 
            btnSearchBorrower.Cursor = Cursors.Hand;
            btnSearchBorrower.FlatStyle = FlatStyle.Flat;
            btnSearchBorrower.Font = new Font("Segoe UI", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchBorrower.Location = new Point(293, 60);
            btnSearchBorrower.Name = "btnSearchBorrower";
            btnSearchBorrower.Size = new Size(57, 25);
            btnSearchBorrower.TabIndex = 23;
            btnSearchBorrower.Text = "Find";
            btnSearchBorrower.UseVisualStyleBackColor = true;
            // 
            // cboPurpose
            // 
            cboPurpose.FormattingEnabled = true;
            cboPurpose.Items.AddRange(new object[] { "Overnight", "Research", "Photocopy" });
            cboPurpose.Location = new Point(112, 153);
            cboPurpose.Name = "cboPurpose";
            cboPurpose.Size = new Size(246, 25);
            cboPurpose.TabIndex = 22;
            cboPurpose.Text = "Select";
            // 
            // txtdue
            // 
            txtdue.Location = new Point(293, 153);
            txtdue.Name = "txtdue";
            txtdue.Size = new Size(40, 25);
            txtdue.TabIndex = 18;
            // 
            // txtCourse
            // 
            txtCourse.Enabled = false;
            txtCourse.Location = new Point(112, 122);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(246, 25);
            txtCourse.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(112, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 25);
            txtName.TabIndex = 20;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label15.Location = new Point(43, 156);
            Label15.Name = "Label15";
            Label15.Size = new Size(63, 17);
            Label15.TabIndex = 18;
            Label15.Text = "Purpose :";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label13.Location = new Point(18, 125);
            Label13.Name = "Label13";
            Label13.Size = new Size(87, 17);
            Label13.TabIndex = 16;
            Label13.Text = "Year/Section :";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(22, 63);
            Label7.Name = "Label7";
            Label7.Size = new Size(84, 17);
            Label7.TabIndex = 10;
            Label7.Text = "Borrower Id :";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label17.Location = new Point(56, 94);
            Label17.Name = "Label17";
            Label17.Size = new Size(50, 17);
            Label17.TabIndex = 14;
            Label17.Text = "Name :";
            // 
            // TabPage4
            // 
            TabPage4.Controls.Add(Label2);
            TabPage4.Controls.Add(txt_Search);
            TabPage4.Controls.Add(dtg_BlistOfBooks);
            TabPage4.Location = new Point(4, 22);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(840, 427);
            TabPage4.TabIndex = 1;
            TabPage4.Text = "History";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 13.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(432, 10);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 25);
            Label2.TabIndex = 5;
            Label2.Text = "Search :";
            // 
            // txt_Search
            // 
            txt_Search.BackColor = Color.White;
            txt_Search.Font = new Font("Segoe UI", 13.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Search.Location = new Point(506, 6);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(329, 31);
            txt_Search.TabIndex = 4;
            // 
            // dtg_BlistOfBooks
            // 
            dtg_BlistOfBooks.AllowUserToAddRows = false;
            dtg_BlistOfBooks.AllowUserToDeleteRows = false;
            dtg_BlistOfBooks.AllowUserToResizeColumns = false;
            dtg_BlistOfBooks.AllowUserToResizeRows = false;
            dtg_BlistOfBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_BlistOfBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtg_BlistOfBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_BlistOfBooks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtg_BlistOfBooks.Location = new Point(5, 43);
            dtg_BlistOfBooks.Name = "dtg_BlistOfBooks";
            dtg_BlistOfBooks.RowHeadersVisible = false;
            dtg_BlistOfBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_BlistOfBooks.Size = new Size(830, 378);
            dtg_BlistOfBooks.TabIndex = 3;
            // 
            // check_due
            // 
            // 
            // frmBorrowBooks
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 464);
            Controls.Add(TabControl2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBorrowBooks";
            Text = "frmBorrowBooks";
            TabControl2.ResumeLayout(false);
            TabPage3.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            grp_Bgroup.ResumeLayout(false);
            grp_Bgroup.PerformLayout();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_BlistOfBooks).EndInit();
            Load += new EventHandler(frmBorrow_Load);
            ResumeLayout(false);

        }

        internal TabControl TabControl2;
        internal TabPage TabPage3;
        internal Button btnNew;
        internal Button btn_Bsave;
        internal GroupBox GroupBox1;
        internal Button btnSearchAccesion;
        internal TextBox txtAccesionNumBorrow;
        internal Label lblAccessionNumBorrow;
        internal TextBox txtbooktype;
        internal TextBox txtpublisher;
        internal TextBox txtDatePublish;
        internal TextBox txtTitle;
        internal Label Label6;
        internal TextBox txtAuthor;
        internal Label Label3;
        internal Label Label12;
        internal Label Label1;
        internal Label Label5;
        internal GroupBox grp_Bgroup;
        internal TextBox txtBorrowerId;
        internal Button btnSearchBorrower;
        internal ComboBox cboPurpose;
        internal TextBox txtdue;
        internal TextBox txtCourse;
        internal TextBox txtName;
        internal Label Label15;
        internal Label Label13;
        internal Label Label7;
        internal Label Label17;
        internal TabPage TabPage4;
        internal Label Label2;
        internal TextBox txt_Search;
        internal DataGridView dtg_BlistOfBooks;
        internal Timer check_due;
    }
}