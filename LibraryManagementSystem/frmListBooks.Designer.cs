using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmListBooks : Form
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
            txtSearch = new TextBox();
            txtSearch.TextChanged += new EventHandler(txtSerach_TextChanged);
            Label2 = new Label();
            btnAdd = new Button();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label1 = new Label();
            dtgList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgList).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(459, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(264, 27);
            txtSearch.TabIndex = 10;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(367, 54);
            Label2.Name = "Label2";
            Label2.Size = new Size(86, 25);
            Label2.TabIndex = 9;
            Label2.Text = "Search :";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(565, 374);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 51);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Select";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(648, 374);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 51);
            Button1.TabIndex = 8;
            Button1.Text = "Close";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 27.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 5);
            Label1.Name = "Label1";
            Label1.Size = new Size(293, 40);
            Label1.TabIndex = 6;
            Label1.Text = "Search for Books";
            // 
            // dtgList
            // 
            dtgList.AllowUserToAddRows = false;
            dtgList.AllowUserToDeleteRows = false;
            dtgList.AllowUserToResizeColumns = false;
            dtgList.AllowUserToResizeRows = false;
            dtgList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgList.Location = new Point(12, 82);
            dtgList.MultiSelect = false;
            dtgList.Name = "dtgList";
            dtgList.RowHeadersVisible = false;
            dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgList.Size = new Size(711, 286);
            dtgList.TabIndex = 5;
            // 
            // frmListBooks
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 429);
            Controls.Add(txtSearch);
            Controls.Add(Label2);
            Controls.Add(btnAdd);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Controls.Add(dtgList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Books";
            ((System.ComponentModel.ISupportInitialize)dtgList).EndInit();
            Load += new EventHandler(frmListBooks_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtSearch;
        internal Label Label2;
        internal Button btnAdd;
        internal Button Button1;
        internal Label Label1;
        internal DataGridView dtgList;
    }
}