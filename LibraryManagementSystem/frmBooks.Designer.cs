using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmBooks : Form
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
            btnDelete = new Button();
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnUpdate = new Button();
            btnUpdate.Click += new EventHandler(btnUpdate_Click);
            cboType = new ComboBox();
            cboType.KeyPress += new KeyPressEventHandler(cboType_KeyPress);
            Label9 = new Label();
            txtDeweyDecimal = new TextBox();
            Label12 = new Label();
            Label11 = new Label();
            txtSearch = new TextBox();
            txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            btnSave = new Button();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnNew = new Button();
            btnNew.Click += new EventHandler(btnNew_Click);
            dtgList = new DataGridView();
            dtgList.CellClick += new DataGridViewCellEventHandler(dtgList_CellClick);
            cboCategory = new ComboBox();
            cboCategory.SelectedIndexChanged += new EventHandler(cboCategory_SelectedIndexChanged);
            cboCategory.KeyPress += new KeyPressEventHandler(cboCategory_KeyPress);
            Label6 = new Label();
            dtpDatePublish = new DateTimePicker();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            Label10 = new Label();
            txtDesc = new TextBox();
            Label7 = new Label();
            Label5 = new Label();
            txtTitle = new TextBox();
            Label4 = new Label();
            Label2 = new Label();
            txtAccessionNo = new TextBox();
            txtAccessionNo.TextChanged += new EventHandler(txtAccessionNo_TextChanged);
            txtAccessionNo.KeyPress += new KeyPressEventHandler(txtAccessionNo_KeyPress);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgList).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(298, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(63, 55);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(233, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(63, 55);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cboType
            // 
            cboType.Anchor = AnchorStyles.Top;
            cboType.Font = new Font("Microsoft Sans Serif", 10.0f);
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Unknown", "Fiction", "Non-Fiction" });
            cboType.Location = new Point(565, 94);
            cboType.Name = "cboType";
            cboType.Size = new Size(239, 24);
            cboType.TabIndex = 45;
            cboType.Text = "Unknown";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Top;
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 10.0f);
            Label9.Location = new Point(458, 97);
            Label9.Name = "Label9";
            Label9.Size = new Size(107, 17);
            Label9.TabIndex = 44;
            Label9.Text = "Type of Books :";
            // 
            // txtDeweyDecimal
            // 
            txtDeweyDecimal.Anchor = AnchorStyles.Top;
            txtDeweyDecimal.BackColor = SystemColors.ButtonHighlight;
            txtDeweyDecimal.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeweyDecimal.Location = new Point(565, 64);
            txtDeweyDecimal.Name = "txtDeweyDecimal";
            txtDeweyDecimal.ReadOnly = true;
            txtDeweyDecimal.Size = new Size(239, 23);
            txtDeweyDecimal.TabIndex = 37;
            // 
            // Label12
            // 
            Label12.Anchor = AnchorStyles.Top;
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label12.Location = new Point(453, 67);
            Label12.Name = "Label12";
            Label12.Size = new Size(112, 17);
            Label12.TabIndex = 43;
            Label12.Text = "Dewey Decimal :";
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Top;
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.Location = new Point(488, 191);
            Label11.Name = "Label11";
            Label11.Size = new Size(64, 20);
            Label11.TabIndex = 42;
            Label11.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(557, 188);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(296, 26);
            txtSearch.TabIndex = 41;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(168, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(63, 55);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(363, 144);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(63, 55);
            btnNew.TabIndex = 39;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dtgList
            // 
            dtgList.AllowUserToAddRows = false;
            dtgList.AllowUserToDeleteRows = false;
            dtgList.AllowUserToResizeColumns = false;
            dtgList.AllowUserToResizeRows = false;
            dtgList.Anchor = AnchorStyles.Top;
            dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgList.Location = new Point(5, 220);
            dtgList.Name = "dtgList";
            dtgList.RowHeadersVisible = false;
            dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgList.Size = new Size(848, 237);
            dtgList.TabIndex = 33;
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.Top;
            cboCategory.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(565, 37);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(239, 24);
            cboCategory.TabIndex = 36;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Top;
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(66, 120);
            Label6.Name = "Label6";
            Label6.Size = new Size(96, 17);
            Label6.TabIndex = 31;
            Label6.Text = "Date Publish :";
            // 
            // dtpDatePublish
            // 
            dtpDatePublish.Anchor = AnchorStyles.Top;
            dtpDatePublish.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDatePublish.Format = DateTimePickerFormat.Short;
            dtpDatePublish.Location = new Point(168, 115);
            dtpDatePublish.Name = "dtpDatePublish";
            dtpDatePublish.Size = new Size(170, 23);
            dtpDatePublish.TabIndex = 34;
            // 
            // txtPublisher
            // 
            txtPublisher.Anchor = AnchorStyles.Top;
            txtPublisher.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPublisher.Location = new Point(565, 11);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(239, 23);
            txtPublisher.TabIndex = 35;
            // 
            // txtAuthor
            // 
            txtAuthor.Anchor = AnchorStyles.Top;
            txtAuthor.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(168, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(239, 23);
            txtAuthor.TabIndex = 32;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top;
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.Location = new Point(492, 42);
            Label10.Name = "Label10";
            Label10.Size = new Size(73, 17);
            Label10.TabIndex = 27;
            Label10.Text = "Category :";
            // 
            // txtDesc
            // 
            txtDesc.Anchor = AnchorStyles.Top;
            txtDesc.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(168, 63);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(239, 23);
            txtDesc.TabIndex = 30;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Top;
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(490, 14);
            Label7.Name = "Label7";
            Label7.Size = new Size(75, 17);
            Label7.TabIndex = 26;
            Label7.Text = "Publisher :";
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Top;
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(102, 94);
            Label5.Name = "Label5";
            Label5.Size = new Size(58, 17);
            Label5.TabIndex = 24;
            Label5.Text = "Author :";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top;
            txtTitle.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(168, 37);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(239, 23);
            txtTitle.TabIndex = 29;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top;
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(73, 68);
            Label4.Name = "Label4";
            Label4.Size = new Size(87, 17);
            Label4.TabIndex = 23;
            Label4.Text = "Description :";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(117, 40);
            Label2.Name = "Label2";
            Label2.Size = new Size(43, 17);
            Label2.TabIndex = 22;
            Label2.Text = "Title :";
            // 
            // txtAccessionNo
            // 
            txtAccessionNo.Anchor = AnchorStyles.Top;
            txtAccessionNo.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccessionNo.Location = new Point(168, 11);
            txtAccessionNo.Name = "txtAccessionNo";
            txtAccessionNo.Size = new Size(239, 23);
            txtAccessionNo.TabIndex = 28;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(55, 17);
            Label1.Name = "Label1";
            Label1.Size = new Size(106, 17);
            Label1.TabIndex = 21;
            Label1.Text = "Accession No. :";
            // 
            // frmBooks
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 464);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cboType);
            Controls.Add(Label9);
            Controls.Add(txtDeweyDecimal);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(dtgList);
            Controls.Add(cboCategory);
            Controls.Add(Label6);
            Controls.Add(dtpDatePublish);
            Controls.Add(txtPublisher);
            Controls.Add(txtAuthor);
            Controls.Add(Label10);
            Controls.Add(txtDesc);
            Controls.Add(Label7);
            Controls.Add(Label5);
            Controls.Add(txtTitle);
            Controls.Add(Label4);
            Controls.Add(Label2);
            Controls.Add(txtAccessionNo);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBooks";
            Text = "frmBooks";
            ((System.ComponentModel.ISupportInitialize)dtgList).EndInit();
            Load += new EventHandler(frmBooks_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button btnDelete;
        internal Button btnUpdate;
        internal ComboBox cboType;
        internal Label Label9;
        internal TextBox txtDeweyDecimal;
        internal Label Label12;
        internal Label Label11;
        internal TextBox txtSearch;
        internal Button btnSave;
        internal Button btnNew;
        internal DataGridView dtgList;
        internal ComboBox cboCategory;
        internal Label Label6;
        internal DateTimePicker dtpDatePublish;
        internal TextBox txtPublisher;
        internal TextBox txtAuthor;
        internal Label Label10;
        internal TextBox txtDesc;
        internal Label Label7;
        internal Label Label5;
        internal TextBox txtTitle;
        internal Label Label4;
        internal Label Label2;
        internal TextBox txtAccessionNo;
        internal Label Label1;
    }
}